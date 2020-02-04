using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Collections.Generic;

namespace Wall_e_Controller
{
    public partial class MainForm : Form
    {
        private static SerialPort port = new SerialPort();
        private bool arduinoConnection = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArduinoComLabel.Text = Functions.GetSettingValue("arduino-com");
            RPiIPLabel.Text = Functions.GetSettingValue("ip-address");
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            arduinoConnection = false;

            ArduinoStatusLabel.Text = "inactive";
            ArduinoStatusLabel.ForeColor = Color.Red;
            RPiStatusLabel.Text = "inactive";
            RPiStatusLabel.ForeColor = Color.Red;

            Task.Factory.StartNew(() =>
            {
                try
                {
                    if (!port.IsOpen)
                    {
                        disconnectComPort = DisconnectComPort;

                        port = new SerialPort(Functions.GetSettingValue("arduino-com"));
                        port.DataReceived += new SerialDataReceivedEventHandler(ReceiveBytes);
                        port.ErrorReceived += new SerialErrorReceivedEventHandler(SerialError);
                        port.WriteTimeout = 200;
                        port.Open();
                        Thread.Sleep(500);
                    }

                    byte[] test = { 0 };
                    SendBytes(test);

                    Thread.Sleep(500);
                    if (!arduinoConnection)
                    {
                        WriteLogLine("ERROR: Sending module not detected");
                        port.Close();
                    }
                }
                catch
                {
                    WriteLogLine("ERROR: Selected port not responding");
                }
            });

            StartPictureUpdate();
        }

        private ATConsole atConsole = new ATConsole(SendBytes);
        private void AtButton_Click(object sender, EventArgs e)
        {
            if (arduinoConnection)
            {
                DialogResult settings = atConsole.ShowDialog();
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            DialogResult settings = new SettingsForm().ShowDialog();

            ArduinoComLabel.Text = Functions.GetSettingValue("arduino-com");
            RPiIPLabel.Text = Functions.GetSettingValue("ip-address");
        }



        private bool atMessageBuild = false;
        private string atMessage = "";
        void ReceiveBytes(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] received = new byte[port.BytesToRead];
            port.Read(received, 0, received.Length);

            if (received.Contains((byte)0))
            {
                arduinoConnection = true;

                if (motorLoop.Status != TaskStatus.Running)
                {
                    motorLoop = Task.Factory.StartNew(() => { MotorLoop(); });
                }

                ArduinoStatusLabel.BeginInvoke((MethodInvoker)delegate ()
                {
                    ArduinoStatusLabel.Text = "active";
                    ArduinoStatusLabel.ForeColor = Color.Green;
                });
            }
            else
            {
                foreach (byte b in received)
                {
                    BeginInvoke((MethodInvoker)delegate ()
                    {
                        int selectionStart = IncomingDataTextBox.SelectionStart;
                        int selectionLength = IncomingDataTextBox.SelectionLength;

                        IncomingDataTextBox.AppendText(b.ToString());
                        if (b == 4 || b == 2 || b == 1 || b == 0)
                        {
                            IncomingDataTextBox.AppendText(Environment.NewLine);
                        }
                        else
                        {
                            IncomingDataTextBox.AppendText(",");
                        }

                        if (IncomingDataTextBox.Focused)
                        {
                            IncomingDataTextBox.SelectionStart = selectionStart;
                            IncomingDataTextBox.SelectionLength = 0;
                            IncomingDataTextBox.ScrollToCaret();
                            IncomingDataTextBox.SelectionLength = selectionLength;
                        }
                        else
                        {
                            IncomingDataTextBox.SelectionStart = IncomingDataTextBox.Text.Length;
                        }
                    });

                    if (b == 2 || b == 1)
                    {
                        atMessageBuild = !atMessageBuild;
                        if (!atMessageBuild)
                        {
                            if (atConsole.Visible)
                            {
                                atConsole.WriteIncomingATMessage((b == 1 ? "<" : ">") + atMessage);
                            }
                            atMessage = "";
                        }
                    }
                    else
                    {
                        if (atMessageBuild)
                        {
                            atMessage += (char)b;
                        }
                    }
                }
            }
        }

        static Action disconnectComPort;
        static void SendBytes(byte[] sendData)
        {
            if (port.IsOpen)
            {
                try
                {
                    port.Write(sendData, 0, sendData.Length);
                }
                catch
                {
                    disconnectComPort();
                }
            }
            else
            {
                disconnectComPort();
            }
        }

        void SerialError(object sender, SerialErrorReceivedEventArgs e)
        {
            DisconnectComPort();
        }

        void DisconnectComPort()
        {
            if (arduinoConnection)
            {
                WriteLogLine("ERROR: Send module connection lost");
                port.Close();
                arduinoConnection = false;

                BeginInvoke((MethodInvoker)delegate ()
                {
                    ArduinoStatusLabel.Text = "inactive";
                    ArduinoStatusLabel.ForeColor = Color.Red;
                });
            }
        }

        void WriteLogLine(string logMessage)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                int selectionStart = LogTextBox.SelectionStart;
                int selectionLength = LogTextBox.SelectionLength;

                LogTextBox.AppendText(logMessage + Environment.NewLine);

                if (LogTextBox.Focused)
                {
                    LogTextBox.SelectionStart = selectionStart;
                    LogTextBox.SelectionLength = 0;
                    LogTextBox.ScrollToCaret();
                    LogTextBox.SelectionLength = selectionLength;
                }
                else
                {
                    LogTextBox.SelectionStart = LogTextBox.Text.Length;
                }
            });
        }

        private void IncomingDataResetButton_Click(object sender, EventArgs e)
        {
            IncomingDataTextBox.Text = "";
        }

        private void LogResetButton_Click(object sender, EventArgs e)
        {
            LogTextBox.Text = "";
        }



        bool forward = false;
        bool backward = false;
        bool right = false;
        bool left = false;

        bool belly = false;
        bool bellyOpen = false;

        int setSpeed = 0;
        int r_speed = 0;
        int l_speed = 0;

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                forward = true;
            }
            if (e.KeyCode == Keys.S)
            {
                backward = true;
            }

            if (e.KeyCode == Keys.A)
            {
                left = true;
            }
            if (e.KeyCode == Keys.D)
            {
                right = true;
            }

            if (e.KeyCode == Keys.K && !belly)
            {
                belly = true;
                bellyOpen = !bellyOpen;
                if (bellyOpen)
                {
                    WriteLogLine("Opening belly");
                    servoValues.Add(new byte[] { 100, 150, 20 });
                }
                else
                {
                    WriteLogLine("Closing belly");
                    servoValues.Add(new byte[] { 100, 50, 20 });
                }
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                forward = false;
            }

            if (e.KeyCode == Keys.S)
            {
                backward = false;
            }

            if (e.KeyCode == Keys.A)
            {
                left = false;
            }

            if (e.KeyCode == Keys.D)
            {
                right = false;
            }

            if (e.KeyCode == Keys.K)
            {
                belly = false;
            }
        }

        private int speedStep = 5;
        private void MainForm_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                setSpeed += speedStep;
                if (setSpeed > 100) { setSpeed = 100; }
            }
            else if (e.Delta < 0)
            {
                setSpeed -= speedStep;
                if (setSpeed < 0) { setSpeed = 0; }
            }

            PowerLabel.Text = "Power: " + setSpeed.ToString();
        }


        Task motorLoop = Task.Factory.StartNew(() => { });
        List<byte[]> servoValues = new List<byte[]>();
        async void MotorLoop()
        {
            while (arduinoConnection)
            {
                bool processedForward = forward;
                bool processedBackward = backward;
                bool processedLeft = left;
                bool processedRight = right;

                if (forward && backward)
                {
                    processedForward = false;
                    processedBackward = false;
                }
                if (left && right)
                {
                    processedLeft = false;
                    processedRight = false;
                }

                if (processedForward)
                {
                    if (processedRight)
                    {
                        r_speed = 0;
                        l_speed = setSpeed;
                    }
                    else if (processedLeft)
                    {
                        r_speed = setSpeed;
                        l_speed = 0;
                    }
                    else
                    {
                        r_speed = setSpeed;
                        l_speed = setSpeed;
                    }
                }
                else if (processedBackward)
                {
                    if (processedRight)
                    {
                        r_speed = 0;
                        l_speed = -setSpeed;
                    }
                    else if (processedLeft)
                    {
                        r_speed = -setSpeed;
                        l_speed = 0;
                    }
                    else
                    {
                        r_speed = -setSpeed;
                        l_speed = -setSpeed;
                    }
                }
                else if (processedRight)
                {
                    r_speed = -setSpeed;
                    l_speed = setSpeed;

                    if (r_speed > -60)
                        r_speed = -60;

                    if (l_speed < 60)
                        l_speed = 60;
                }
                else if (processedLeft)
                {
                    r_speed = setSpeed;
                    l_speed = -setSpeed;

                    if (l_speed > -60)
                        l_speed = -60;

                    if (r_speed < 60)
                        r_speed = 60;
                }
                else
                {
                    r_speed = 0;
                    l_speed = 0;
                }

                int processedSpeedRight = 150 + (int)(r_speed * (float.Parse(Functions.GetSettingValue("right-motor-offset")) / 100));
                int processedSpeedLeft = 150 + (int)(l_speed * (float.Parse(Functions.GetSettingValue("left-motor-offset")) / 100));

                byte sendByteR = (byte)processedSpeedRight;
                byte sendByteL = (byte)processedSpeedLeft;

                if (bool.Parse(Functions.GetSettingValue("inverse-steering")))
                {
                    sendByteR = (byte)processedSpeedLeft;
                    sendByteL = (byte)processedSpeedRight;
                }

                int servoAmount = servoValues.Count;
                byte[] servoArray = new byte[3 * servoAmount];
                for (int i = 0; i < servoAmount; i++)
                {
                    servoValues[i].CopyTo(servoArray, 3 * i);
                }
                servoValues.Clear();

                byte[] sendarray = new byte[servoArray.Length + 5];
                sendarray[0] = 3;
                sendarray[1] = sendByteL;
                sendarray[2] = sendByteR;
                sendarray[3] = (byte)(100 + servoAmount);
                servoArray.CopyTo(sendarray, 4);
                sendarray[sendarray.Length - 1] = 4;

                WriteLogLine(sendByteL + "," + sendByteR);

                if (!atConsole.Visible)
                {
                    SendBytes(sendarray);
                }
                else
                {
                    WriteLogLine("paused");
                }
                await Task.Delay(10);
            }
        }



        Task updateTask = Task.Factory.StartNew(() => { });
        void StartPictureUpdate()
        {
            if (updateTask.Status != TaskStatus.Running)
            {
                updateTask = Task.Factory.StartNew(() =>
                {
                    CameraWebClient client = new CameraWebClient();
                    byte[] image = new byte[0];

                    bool startLoop = false;
                    try
                    {
                        image = client.DownloadData(new Uri("http://" + Functions.GetSettingValue("ip-address") + "/cam/cam_pic.php"));
                        startLoop = true;

                        BeginInvoke((MethodInvoker)delegate ()
                        {
                            RPiStatusLabel.Text = "active";
                            RPiStatusLabel.ForeColor = Color.Green;
                        });
                    }
                    catch
                    {
                        WriteLogLine("ERROR: Video source unreachable");
                    }

                    while (startLoop)
                    {
                        try
                        {
                            image = client.DownloadData(new Uri("http://" + Functions.GetSettingValue("ip-address") + "/cam/cam_pic.php"));
                        }
                        catch
                        {
                            BeginInvoke((MethodInvoker)delegate ()
                            {
                                RPiStatusLabel.Text = "inactive";
                                RPiStatusLabel.ForeColor = Color.Red;
                            });

                            WriteLogLine("ERROR: Video connection lost");
                            break;
                        }

                        try
                        {
                            Image img = Image.FromStream(new MemoryStream(image));
                            CamView.BeginInvoke((MethodInvoker)delegate () { CamView.Image = img; });
                        }
                        catch
                        {
                            WriteLogLine("ERROR: Invalid video data");
                        }
                    }
                });
            }
        }
    }

    public class CameraWebClient : WebClient
    {
        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest wr = base.GetWebRequest(address);
            wr.Timeout = 500;
            return wr;
        }
    }
}

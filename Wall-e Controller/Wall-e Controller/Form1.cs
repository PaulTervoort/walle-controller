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
    public partial class Form1 : Form
    {
        SerialPort port = new SerialPort();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArduinoComLabel.Text = Functions.GetSettingValue("arduino-com");
            RPiIPLabel.Text = Functions.GetSettingValue("ip-address");
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            ArduinoStatusLabel.Text = "inactive";
            ArduinoStatusLabel.ForeColor = Color.Red;
            RPiStatusLabel.Text = "inactive";
            RPiStatusLabel.ForeColor = Color.Red;

            Task.Factory.StartNew(() =>
            {
                try
                {
                    if (port.IsOpen) { port.Close(); }

                    port = new SerialPort(Functions.GetSettingValue("arduino-com"));
                    port.DataReceived += new SerialDataReceivedEventHandler(ReceiveBytes);
                    port.Open();

                    byte[] test = { 0 };
                    SendData(test);
                }
                catch { }
            });

            UpdatePicture();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            DialogResult settings = new settingsForm().ShowDialog();

            ArduinoComLabel.Text = Functions.GetSettingValue("arduino-com");
            RPiIPLabel.Text = Functions.GetSettingValue("ip-address");
        }

        void ReceiveBytes(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] received = new byte[port.BytesToRead];
            port.Read(received, 0, received.Length);

            if (received.Contains((byte)0))
            {
                ArduinoStatusLabel.BeginInvoke((MethodInvoker)delegate ()
                {
                    ArduinoStatusLabel.Text = "active";
                    ArduinoStatusLabel.ForeColor = Color.Green;
                });
            }
        }

        void SendData(byte[] sendData)
        {
            try
            {
                port.Write(sendData, 0, sendData.Length);
            }
            catch { }
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

        bool forward = false;
        bool backward = false;
        bool right = false;
        bool left = false;
        bool threadRunning = false;

        bool belly = false;
        bool bellyOpen = false;

        int setSpeed = 0;
        int r_speed = 0;
        int l_speed = 0;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            bool allowThreadRun = false;

            if (e.KeyCode == Keys.W && !forward)
            {
                allowThreadRun = true;
                forward = true;
            }else if (e.KeyCode == Keys.S && !backward)
            {
                allowThreadRun = true;
                backward = true;
            }

            if (e.KeyCode == Keys.A && !left)
            {
                allowThreadRun = true;
                left = true;
            }else if (e.KeyCode == Keys.D && !right)
            {
                allowThreadRun = true;
                right = true;
            }

            if (!threadRunning && allowThreadRun && port.IsOpen)
            {
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    SetSpeeds();
                }).Start();
                threadRunning = true;
                allowThreadRun = false;
            }

            if (e.KeyCode == Keys.K && !belly)
            {
                belly = true;
                bellyOpen = !bellyOpen;
                if (bellyOpen)
                {
                    WriteLogLine("Opening belly");
                    byte[] servoArray = { 101, 100, 150, 20, 4 };
                    SetSpeeds(servoArray);
                }
                else
                {
                    WriteLogLine("Closing belly");
                    byte[] servoArray = { 101, 100, 50, 20, 4 };
                    SetSpeeds(servoArray);
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
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

        public void SetSpeeds(byte[] servoArray = null)
        {
            if (servoArray == null)
            {
                byte[] noArray = { 100, 4 };
                servoArray = noArray;
            }

            while (forward || backward || right || left)
            {
                if (forward)
                {
                    if (right)
                    {
                        r_speed = 0;
                        l_speed = setSpeed;
                    }
                    else if (left)
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
                else if (backward)
                {
                    if (right)
                    {
                        r_speed = 0;
                        l_speed = -setSpeed;
                    }
                    else if (left)
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
                else if (right)
                {
                    r_speed = -setSpeed;
                    l_speed = setSpeed;

                    if (r_speed > -60)
                        r_speed = -60;

                    if (l_speed < 60)
                        l_speed = 60;
                }
                else if (left)
                {
                    r_speed = setSpeed;
                    l_speed = -setSpeed;

                    if (l_speed > -60)
                        l_speed = -60;

                    if (r_speed < 60)
                        r_speed = 60;
                }

                //Console.WriteLine("R:" + r_speed);
                //Console.WriteLine("L:" + l_speed);

                int byteRSpeed = 150 + (int)(r_speed * (float.Parse(Functions.GetSettingValue("right-motor-offset")) / 100));
                int byteLSpeed = 150 + (int)(l_speed * (float.Parse(Functions.GetSettingValue("left-motor-offset")) / 100));

                int sendByteR = byteRSpeed;
                int sendByteL = byteLSpeed;

                if (bool.Parse(Functions.GetSettingValue("inverse-steering")))
                {
                    sendByteR = byteLSpeed;
                    sendByteL = byteRSpeed;
                }

                byte[] speeds = { 3, (byte)sendByteL, (byte)sendByteR };
                byte[] sendarray = new byte[speeds.Length + servoArray.Length];

                speeds.CopyTo(sendarray, 0);
                servoArray.CopyTo(sendarray, speeds.Length);

                SendData(sendarray);
                Thread.Sleep(10);
                //Console.WriteLine("S:" + setSpeed.ToString() + " R:" + r_speed + " L:" + l_speed);
            }

            if (!forward && !backward && !right && !left)
            {
                byte[] speeds = { 3, 150, 150 };
                byte[] sendarray = new byte[speeds.Length + servoArray.Length];

                speeds.CopyTo(sendarray, 0);
                servoArray.CopyTo(sendarray, speeds.Length);

                SendData(sendarray);
            }

            threadRunning = false;
        }

        int speedStep = 5;

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                setSpeed += speedStep;
                if (setSpeed > 100)
                    setSpeed = 100;
            }
            else if (e.Delta < 0)
            {
                setSpeed -= speedStep;
                if (setSpeed < 0)
                    setSpeed = 0;
            }

            PowerLabel.Text = "Power: " + setSpeed.ToString();
            Console.WriteLine(PowerLabel.Location);
            PowerLabel.ForeColor = Color.White;
        }



        Task UpdateTask = Task.Factory.StartNew(() => { });

        void UpdatePicture()
        {
            if (UpdateTask.Status != TaskStatus.Running)
            {
                RPiStatusLabel.Text = "active";
                RPiStatusLabel.ForeColor = Color.Green;

                UpdateTask = Task.Factory.StartNew(() =>
                {
                    CameraWebClient client = new CameraWebClient();
                    byte[] image = new byte[0];

                    while (true)
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

                            WriteLogLine("ERROR: Image data unreachable");
                            break;
                        }

                        try
                        {
                            Image img = Image.FromStream(new MemoryStream(image));
                            CamView.BeginInvoke((MethodInvoker)delegate () { CamView.Image = img; });
                        }
                        catch
                        {
                            WriteLogLine("ERROR: Invalid image data");
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

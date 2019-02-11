﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Wall_e_Controller
{
    public partial class Form1 : Form
    {
        SerialPort port = new SerialPort();
        List<byte> dataIn = new List<byte>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arduinoComLabel.Text = Functions.GetSettingValue("arduino-com");
            rpiIPLabel.Text = Functions.GetSettingValue("ip-address");

            Console.WriteLine("Starting thread.");
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (port.IsOpen)
                    port.Close();

                port = new SerialPort(Functions.GetSettingValue("arduino-com"));
                port.DataReceived += new SerialDataReceivedEventHandler(ReceiveBytes);
                port.Open();

                arduinoStatusLabel.Text = "active";
                arduinoStatusLabel.ForeColor = Color.Green;
            }
            catch
            {
                arduinoStatusLabel.Text = "inactive";
                arduinoStatusLabel.ForeColor = Color.Red;
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            DialogResult settings = new settingsForm().ShowDialog();

            arduinoComLabel.Text = Functions.GetSettingValue("arduino-com");
            rpiIPLabel.Text = Functions.GetSettingValue("ip-address");
        }

        void ReceiveBytes(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] temp = new byte[port.BytesToRead];
            port.Read(temp, 0, temp.Length);
            dataIn.AddRange(temp);
        }

        void SendData(byte[] sendData)
        {
            try
            {
                port.Write(sendData, 0, sendData.Length);
            }
            catch { }
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

            if (!threadRunning && allowThreadRun)
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
                    Console.WriteLine("Opening belly");
                    byte[] servoArray = { 101, 100, 150, 20, 4 };
                    SetSpeeds(servoArray);
                }
                else
                {
                    Console.WriteLine("Closing belly");
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

            speedLabel.Text = "Power: " + setSpeed.ToString();
        }
    }
}
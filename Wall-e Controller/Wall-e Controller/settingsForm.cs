using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wall_e_Controller
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            ComBox.DataSource = ports;
            foreach (string port in ports)
            {
                if (port == Functions.GetSettingValue("arduino-com"))
                    ComBox.SelectedItem = port;
            }

            string[] ip = Functions.GetSettingValue("ip-address").Split('.');
            RPiIPOne.Value = int.Parse(ip[0]);
            RPiIPTwo.Value = int.Parse(ip[1]);
            RPiIPThree.Value = int.Parse(ip[2]);
            RPiIPFour.Value = int.Parse(ip[3]);

            LeftMotorOffset.Value = int.Parse(Functions.GetSettingValue("left-motor-offset"));
            RightMotorOffset.Value = int.Parse(Functions.GetSettingValue("right-motor-offset"));

            InverseSteering.Checked = bool.Parse(Functions.GetSettingValue("inverse-steering"));

        }

        private void settingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions.SetSettingValue("arduino-com", ComBox.Text);
            Functions.SetSettingValue("ip-address", RPiIPOne.Value.ToString() + "." + RPiIPTwo.Value.ToString() + "." + RPiIPThree.Value.ToString() + "." + RPiIPFour.Value.ToString());
            Functions.SetSettingValue("left-motor-offset", LeftMotorOffset.Value.ToString());
            Functions.SetSettingValue("right-motor-offset", RightMotorOffset.Value.ToString());
            Functions.SetSettingValue("inverse-steering", InverseSteering.Checked.ToString());
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

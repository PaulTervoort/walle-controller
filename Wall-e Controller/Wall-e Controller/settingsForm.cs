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
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comBox.DataSource = ports;
            foreach (string port in ports)
            {
                if (port == Functions.GetSettingValue("arduino-com"))
                    comBox.SelectedItem = port;
            }

            string[] ip = Functions.GetSettingValue("ip-address").Split('.');
            rpiIPOne.Value = int.Parse(ip[0]);
            rpiIPTwo.Value = int.Parse(ip[1]);
            rpiIPThree.Value = int.Parse(ip[2]);
            rpiIPFour.Value = int.Parse(ip[3]);

            leftMotorOffset.Value = int.Parse(Functions.GetSettingValue("left-motor-offset"));
            rightMotorOffset.Value = int.Parse(Functions.GetSettingValue("right-motor-offset"));

            inverseSteering.Checked = bool.Parse(Functions.GetSettingValue("inverse-steering"));

        }

        private void settingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions.SetSettingValue("arduino-com", comBox.Text);
            Functions.SetSettingValue("ip-address", rpiIPOne.Value.ToString() + "." + rpiIPTwo.Value.ToString() + "." + rpiIPThree.Value.ToString() + "." + rpiIPFour.Value.ToString());
            Functions.SetSettingValue("left-motor-offset", leftMotorOffset.Value.ToString());
            Functions.SetSettingValue("right-motor-offset", rightMotorOffset.Value.ToString());
            Functions.SetSettingValue("inverse-steering", inverseSteering.Checked.ToString());
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

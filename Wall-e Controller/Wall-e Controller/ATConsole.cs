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
    public partial class ATConsole : Form
    {
        MainForm parent;

        public ATConsole(MainForm parentForm)
        {
            parent = parentForm;
            InitializeComponent();
        }


        public void WriteIncomingATMessage(string message)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                logTextBox.SelectionStart = 0;
                logTextBox.SelectionLength = 0;
                if (message[0] == '<')
                {
                    logTextBox.SelectionColor = WalleLabel.ForeColor;
                }
                else
                {
                    logTextBox.SelectionColor = SendModuleLabel.ForeColor;
                }

                logTextBox.SelectedText = "< " + message.Substring(1);
            });
        }

        void SendAtCommand(string command)
        {
            byte[] atCommand = new byte[command.Length + 2];
            atCommand[0] = 2;
            atCommand[atCommand.Length - 1] = 2;
            Array.Copy(Encoding.ASCII.GetBytes(command), 0, atCommand, 1, command.Length);

            Task.Factory.StartNew(() =>
            {
                parent.SendBytes(atCommand);
            });

            logTextBox.SelectionStart = 0;
            logTextBox.SelectionLength = 0;
            logTextBox.SelectionColor = OutgoingLabel.ForeColor;
            logTextBox.SelectedText = "> " + command + Environment.NewLine;
        }


        string previousNumber = "";
        void ChannelNumberTextbox_TextChanged(object sender, EventArgs e)
        {
            if(ChannelTextBox.Text != previousNumber)
            {
                string textboxText = ChannelTextBox.Text;
                string filteredNumber = "";
                foreach (char c in textboxText)
                {
                    if (Char.IsDigit(c))
                    {
                        filteredNumber += c;
                    }
                }
                previousNumber = filteredNumber;
                ChannelTextBox.Text = filteredNumber;
            }
        }


        void CommandTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendAtCommand(CommandTextBox.Text);
                CommandTextBox.Text = "";
            }
        }

        private void ChannelButton_Click(object sender, EventArgs e)
        {
            SendAtCommand("C" + ChannelTextBox.Text.PadLeft(3, '0'));
        }

        private void DefaultButton_Click(object sender, EventArgs e)
        {
            SendAtCommand("DEFAULT");
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            SendAtCommand("RX");
        }
    }
}

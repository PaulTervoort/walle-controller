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
        Action<byte[]> sendData;

        public ATConsole(Action<byte[]> sendDataFunction)
        {
            sendData = sendDataFunction;
            InitializeComponent();
        }

        public void WriteIncomingATMessage(string message)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                richTextBox1.SelectionStart = 0;
                richTextBox1.SelectionLength = 0;
                richTextBox1.SelectionColor = label2.ForeColor;
                richTextBox1.SelectedText = "< " + message + Environment.NewLine;
            });
        }

        void CommandTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                byte[] atCommand = new byte[CommandTextBox.Text.Length + 2];
                atCommand[0] = 2;
                atCommand[atCommand.Length - 1] = 2;
                Array.Copy(Encoding.ASCII.GetBytes(CommandTextBox.Text), 0, atCommand, 1, CommandTextBox.Text.Length);

                Task.Factory.StartNew(() =>
                {
                    sendData(atCommand);
                });

                richTextBox1.SelectionStart = 0;
                richTextBox1.SelectionLength = 0;
                richTextBox1.SelectionColor = label1.ForeColor;
                richTextBox1.SelectedText = "> " + CommandTextBox.Text + Environment.NewLine;
                CommandTextBox.Text = "";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

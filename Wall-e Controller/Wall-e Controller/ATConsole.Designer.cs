namespace Wall_e_Controller
{
    partial class ATConsole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATConsole));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CommandTextBox = new System.Windows.Forms.TextBox();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.LogTextBoxBorderPanel = new System.Windows.Forms.Panel();
            this.OutgoingLabel = new System.Windows.Forms.Label();
            this.WalleLabel = new System.Windows.Forms.Label();
            this.CommandLabel = new System.Windows.Forms.Label();
            this.SendModuleLabel = new System.Windows.Forms.Label();
            this.ChannelButton = new System.Windows.Forms.Button();
            this.ChannelTextBox = new System.Windows.Forms.TextBox();
            this.DefaultButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.LogTextBoxBorderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 0;
            // 
            // CommandTextBox
            // 
            this.CommandTextBox.Location = new System.Drawing.Point(151, 12);
            this.CommandTextBox.Name = "CommandTextBox";
            this.CommandTextBox.Size = new System.Drawing.Size(290, 22);
            this.CommandTextBox.TabIndex = 0;
            this.CommandTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CommandTextBox_PreviewKeyDown);
            // 
            // logTextBox
            // 
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTextBox.Location = new System.Drawing.Point(0, 0);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(427, 209);
            this.logTextBox.TabIndex = 23;
            this.logTextBox.TabStop = false;
            this.logTextBox.Text = "";
            // 
            // LogTextBoxBorderPanel
            // 
            this.LogTextBoxBorderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogTextBoxBorderPanel.Controls.Add(this.logTextBox);
            this.LogTextBoxBorderPanel.Location = new System.Drawing.Point(12, 69);
            this.LogTextBoxBorderPanel.Name = "LogTextBoxBorderPanel";
            this.LogTextBoxBorderPanel.Size = new System.Drawing.Size(429, 211);
            this.LogTextBoxBorderPanel.TabIndex = 24;
            // 
            // OutgoingLabel
            // 
            this.OutgoingLabel.AutoSize = true;
            this.OutgoingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutgoingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.OutgoingLabel.Location = new System.Drawing.Point(12, 283);
            this.OutgoingLabel.Name = "OutgoingLabel";
            this.OutgoingLabel.Size = new System.Drawing.Size(74, 17);
            this.OutgoingLabel.TabIndex = 24;
            this.OutgoingLabel.Text = "Outgoing";
            // 
            // WalleLabel
            // 
            this.WalleLabel.AutoSize = true;
            this.WalleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WalleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WalleLabel.Location = new System.Drawing.Point(386, 283);
            this.WalleLabel.Name = "WalleLabel";
            this.WalleLabel.Size = new System.Drawing.Size(55, 17);
            this.WalleLabel.TabIndex = 25;
            this.WalleLabel.Text = "Wall-E";
            // 
            // CommandLabel
            // 
            this.CommandLabel.AutoSize = true;
            this.CommandLabel.Location = new System.Drawing.Point(9, 15);
            this.CommandLabel.Name = "CommandLabel";
            this.CommandLabel.Size = new System.Drawing.Size(136, 17);
            this.CommandLabel.TabIndex = 26;
            this.CommandLabel.Text = "Enter AT-Command:";
            // 
            // SendModuleLabel
            // 
            this.SendModuleLabel.AutoSize = true;
            this.SendModuleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendModuleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SendModuleLabel.Location = new System.Drawing.Point(175, 283);
            this.SendModuleLabel.Name = "SendModuleLabel";
            this.SendModuleLabel.Size = new System.Drawing.Size(102, 17);
            this.SendModuleLabel.TabIndex = 27;
            this.SendModuleLabel.Text = "Send Module";
            // 
            // ChannelButton
            // 
            this.ChannelButton.Location = new System.Drawing.Point(57, 40);
            this.ChannelButton.Name = "ChannelButton";
            this.ChannelButton.Size = new System.Drawing.Size(124, 23);
            this.ChannelButton.TabIndex = 3;
            this.ChannelButton.Text = "Set Channel";
            this.ChannelButton.UseVisualStyleBackColor = true;
            this.ChannelButton.Click += new System.EventHandler(this.ChannelButton_Click);
            // 
            // ChannelTextBox
            // 
            this.ChannelTextBox.Location = new System.Drawing.Point(12, 40);
            this.ChannelTextBox.MaxLength = 3;
            this.ChannelTextBox.Name = "ChannelTextBox";
            this.ChannelTextBox.Size = new System.Drawing.Size(39, 22);
            this.ChannelTextBox.TabIndex = 2;
            this.ChannelTextBox.Text = "1";
            this.ChannelTextBox.TextChanged += new System.EventHandler(this.ChannelNumberTextbox_TextChanged);
            // 
            // DefaultButton
            // 
            this.DefaultButton.Location = new System.Drawing.Point(187, 40);
            this.DefaultButton.Name = "DefaultButton";
            this.DefaultButton.Size = new System.Drawing.Size(124, 23);
            this.DefaultButton.TabIndex = 4;
            this.DefaultButton.Text = "Set To Default";
            this.DefaultButton.UseVisualStyleBackColor = true;
            this.DefaultButton.Click += new System.EventHandler(this.DefaultButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(317, 40);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(124, 23);
            this.InfoButton.TabIndex = 5;
            this.InfoButton.Text = "Get Info";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // ATConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 309);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.DefaultButton);
            this.Controls.Add(this.ChannelTextBox);
            this.Controls.Add(this.ChannelButton);
            this.Controls.Add(this.SendModuleLabel);
            this.Controls.Add(this.CommandLabel);
            this.Controls.Add(this.WalleLabel);
            this.Controls.Add(this.OutgoingLabel);
            this.Controls.Add(this.LogTextBoxBorderPanel);
            this.Controls.Add(this.CommandTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ATConsole";
            this.Text = "Wall-E AT-Console";
            this.LogTextBoxBorderPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox CommandTextBox;
        public System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.Panel LogTextBoxBorderPanel;
        private System.Windows.Forms.Label OutgoingLabel;
        private System.Windows.Forms.Label WalleLabel;
        private System.Windows.Forms.Label CommandLabel;
        private System.Windows.Forms.Label SendModuleLabel;
        private System.Windows.Forms.Button ChannelButton;
        private System.Windows.Forms.TextBox ChannelTextBox;
        private System.Windows.Forms.Button DefaultButton;
        private System.Windows.Forms.Button InfoButton;
    }
}
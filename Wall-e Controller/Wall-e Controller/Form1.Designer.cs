namespace Wall_e_Controller
{
    partial class Form1
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
            this.settingsButton = new System.Windows.Forms.Button();
            this.arduinoComTitleLabel = new System.Windows.Forms.Label();
            this.rpiIPTitleLabel = new System.Windows.Forms.Label();
            this.arduinoStatusTitleLabel = new System.Windows.Forms.Label();
            this.rpiStatusTitleLabel = new System.Windows.Forms.Label();
            this.rpiStatusLabel = new System.Windows.Forms.Label();
            this.arduinoStatusLabel = new System.Windows.Forms.Label();
            this.rpiIPLabel = new System.Windows.Forms.Label();
            this.arduinoComLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.camView = new System.Windows.Forms.PictureBox();
            this.atButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.speedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.camView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.Location = new System.Drawing.Point(1000, 23);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(94, 40);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // arduinoComTitleLabel
            // 
            this.arduinoComTitleLabel.AutoSize = true;
            this.arduinoComTitleLabel.Location = new System.Drawing.Point(12, 12);
            this.arduinoComTitleLabel.Name = "arduinoComTitleLabel";
            this.arduinoComTitleLabel.Size = new System.Drawing.Size(96, 17);
            this.arduinoComTitleLabel.TabIndex = 2;
            this.arduinoComTitleLabel.Text = "Arduino COM:";
            // 
            // rpiIPTitleLabel
            // 
            this.rpiIPTitleLabel.AutoSize = true;
            this.rpiIPTitleLabel.Location = new System.Drawing.Point(12, 29);
            this.rpiIPTitleLabel.Name = "rpiIPTitleLabel";
            this.rpiIPTitleLabel.Size = new System.Drawing.Size(106, 17);
            this.rpiIPTitleLabel.TabIndex = 3;
            this.rpiIPTitleLabel.Text = "RPi IP Address:";
            // 
            // arduinoStatusTitleLabel
            // 
            this.arduinoStatusTitleLabel.AutoSize = true;
            this.arduinoStatusTitleLabel.Location = new System.Drawing.Point(12, 46);
            this.arduinoStatusTitleLabel.Name = "arduinoStatusTitleLabel";
            this.arduinoStatusTitleLabel.Size = new System.Drawing.Size(103, 17);
            this.arduinoStatusTitleLabel.TabIndex = 4;
            this.arduinoStatusTitleLabel.Text = "Arudino status:";
            // 
            // rpiStatusTitleLabel
            // 
            this.rpiStatusTitleLabel.AutoSize = true;
            this.rpiStatusTitleLabel.Location = new System.Drawing.Point(12, 63);
            this.rpiStatusTitleLabel.Name = "rpiStatusTitleLabel";
            this.rpiStatusTitleLabel.Size = new System.Drawing.Size(78, 17);
            this.rpiStatusTitleLabel.TabIndex = 5;
            this.rpiStatusTitleLabel.Text = "RPi Status:";
            // 
            // rpiStatusLabel
            // 
            this.rpiStatusLabel.AutoSize = true;
            this.rpiStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.rpiStatusLabel.Location = new System.Drawing.Point(124, 63);
            this.rpiStatusLabel.Name = "rpiStatusLabel";
            this.rpiStatusLabel.Size = new System.Drawing.Size(56, 17);
            this.rpiStatusLabel.TabIndex = 9;
            this.rpiStatusLabel.Text = "inactive";
            // 
            // arduinoStatusLabel
            // 
            this.arduinoStatusLabel.AutoSize = true;
            this.arduinoStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.arduinoStatusLabel.Location = new System.Drawing.Point(124, 46);
            this.arduinoStatusLabel.Name = "arduinoStatusLabel";
            this.arduinoStatusLabel.Size = new System.Drawing.Size(56, 17);
            this.arduinoStatusLabel.TabIndex = 8;
            this.arduinoStatusLabel.Text = "inactive";
            // 
            // rpiIPLabel
            // 
            this.rpiIPLabel.AutoSize = true;
            this.rpiIPLabel.Location = new System.Drawing.Point(124, 29);
            this.rpiIPLabel.Name = "rpiIPLabel";
            this.rpiIPLabel.Size = new System.Drawing.Size(84, 17);
            this.rpiIPLabel.TabIndex = 7;
            this.rpiIPLabel.Text = "192.168.1.2";
            // 
            // arduinoComLabel
            // 
            this.arduinoComLabel.AutoSize = true;
            this.arduinoComLabel.Location = new System.Drawing.Point(124, 12);
            this.arduinoComLabel.Name = "arduinoComLabel";
            this.arduinoComLabel.Size = new System.Drawing.Size(47, 17);
            this.arduinoComLabel.TabIndex = 6;
            this.arduinoComLabel.Text = "COM0";
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectButton.Location = new System.Drawing.Point(800, 23);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(94, 40);
            this.connectButton.TabIndex = 10;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // camView
            // 
            this.camView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.camView.Location = new System.Drawing.Point(12, 83);
            this.camView.Name = "camView";
            this.camView.Size = new System.Drawing.Size(1082, 500);
            this.camView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.camView.TabIndex = 11;
            this.camView.TabStop = false;
            // 
            // atButton
            // 
            this.atButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.atButton.Location = new System.Drawing.Point(900, 23);
            this.atButton.Name = "atButton";
            this.atButton.Size = new System.Drawing.Size(94, 40);
            this.atButton.TabIndex = 12;
            this.atButton.Text = "AT-Console";
            this.atButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.speedLabel);
            this.panel1.Location = new System.Drawing.Point(900, 540);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 43);
            this.panel1.TabIndex = 13;
            // 
            // speedLabel
            // 
            this.speedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.ForeColor = System.Drawing.Color.White;
            this.speedLabel.Location = new System.Drawing.Point(3, 2);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(146, 38);
            this.speedLabel.TabIndex = 0;
            this.speedLabel.Text = "Power: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 595);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.atButton);
            this.Controls.Add(this.camView);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.rpiStatusLabel);
            this.Controls.Add(this.arduinoStatusLabel);
            this.Controls.Add(this.rpiIPLabel);
            this.Controls.Add(this.arduinoComLabel);
            this.Controls.Add(this.rpiStatusTitleLabel);
            this.Controls.Add(this.arduinoStatusTitleLabel);
            this.Controls.Add(this.rpiIPTitleLabel);
            this.Controls.Add(this.arduinoComTitleLabel);
            this.Controls.Add(this.settingsButton);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Wall-e Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseWheel);
            ((System.ComponentModel.ISupportInitialize)(this.camView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label arduinoComTitleLabel;
        private System.Windows.Forms.Label rpiIPTitleLabel;
        private System.Windows.Forms.Label arduinoStatusTitleLabel;
        private System.Windows.Forms.Label rpiStatusTitleLabel;
        private System.Windows.Forms.Label rpiStatusLabel;
        private System.Windows.Forms.Label arduinoStatusLabel;
        private System.Windows.Forms.Label rpiIPLabel;
        private System.Windows.Forms.Label arduinoComLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.PictureBox camView;
        private System.Windows.Forms.Button atButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label speedLabel;
    }
}


namespace Wall_e_Controller
{
    partial class settingsForm
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
            this.arduinoComTitleLabel = new System.Windows.Forms.Label();
            this.comBox = new System.Windows.Forms.ComboBox();
            this.rpiIPTitleLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rpiIPOne = new System.Windows.Forms.NumericUpDown();
            this.rpiIPFour = new System.Windows.Forms.NumericUpDown();
            this.rpiIPThree = new System.Windows.Forms.NumericUpDown();
            this.rpiIPTwo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.leftMotorOffset = new System.Windows.Forms.NumericUpDown();
            this.rightMotorOffset = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.inverseSteering = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rpiIPOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpiIPFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpiIPThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpiIPTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMotorOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightMotorOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // arduinoComTitleLabel
            // 
            this.arduinoComTitleLabel.AutoSize = true;
            this.arduinoComTitleLabel.Location = new System.Drawing.Point(12, 33);
            this.arduinoComTitleLabel.Name = "arduinoComTitleLabel";
            this.arduinoComTitleLabel.Size = new System.Drawing.Size(96, 17);
            this.arduinoComTitleLabel.TabIndex = 0;
            this.arduinoComTitleLabel.Text = "Arduino COM:";
            // 
            // comBox
            // 
            this.comBox.FormattingEnabled = true;
            this.comBox.Location = new System.Drawing.Point(227, 30);
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(214, 24);
            this.comBox.TabIndex = 1;
            // 
            // rpiIPTitleLabel
            // 
            this.rpiIPTitleLabel.AutoSize = true;
            this.rpiIPTitleLabel.Location = new System.Drawing.Point(12, 62);
            this.rpiIPTitleLabel.Name = "rpiIPTitleLabel";
            this.rpiIPTitleLabel.Size = new System.Drawing.Size(110, 17);
            this.rpiIPTitleLabel.TabIndex = 2;
            this.rpiIPTitleLabel.Text = "Raspberry Pi IP:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = ".";
            // 
            // rpiIPOne
            // 
            this.rpiIPOne.Location = new System.Drawing.Point(227, 62);
            this.rpiIPOne.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.rpiIPOne.Name = "rpiIPOne";
            this.rpiIPOne.Size = new System.Drawing.Size(48, 22);
            this.rpiIPOne.TabIndex = 11;
            // 
            // rpiIPFour
            // 
            this.rpiIPFour.Location = new System.Drawing.Point(393, 62);
            this.rpiIPFour.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.rpiIPFour.Name = "rpiIPFour";
            this.rpiIPFour.Size = new System.Drawing.Size(48, 22);
            this.rpiIPFour.TabIndex = 14;
            // 
            // rpiIPThree
            // 
            this.rpiIPThree.Location = new System.Drawing.Point(338, 62);
            this.rpiIPThree.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.rpiIPThree.Name = "rpiIPThree";
            this.rpiIPThree.Size = new System.Drawing.Size(48, 22);
            this.rpiIPThree.TabIndex = 13;
            // 
            // rpiIPTwo
            // 
            this.rpiIPTwo.Location = new System.Drawing.Point(282, 62);
            this.rpiIPTwo.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.rpiIPTwo.Name = "rpiIPTwo";
            this.rpiIPTwo.Size = new System.Drawing.Size(48, 22);
            this.rpiIPTwo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Communication Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Motor Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Left Motor Offset:";
            // 
            // leftMotorOffset
            // 
            this.leftMotorOffset.Location = new System.Drawing.Point(227, 120);
            this.leftMotorOffset.Name = "leftMotorOffset";
            this.leftMotorOffset.Size = new System.Drawing.Size(214, 22);
            this.leftMotorOffset.TabIndex = 18;
            // 
            // rightMotorOffset
            // 
            this.rightMotorOffset.Location = new System.Drawing.Point(227, 149);
            this.rightMotorOffset.Name = "rightMotorOffset";
            this.rightMotorOffset.Size = new System.Drawing.Size(214, 22);
            this.rightMotorOffset.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Right Motor Offset:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(175, 254);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(102, 37);
            this.closeButton.TabIndex = 21;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Steering Settings";
            // 
            // inverseSteering
            // 
            this.inverseSteering.AutoSize = true;
            this.inverseSteering.Location = new System.Drawing.Point(423, 207);
            this.inverseSteering.Name = "inverseSteering";
            this.inverseSteering.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.inverseSteering.Size = new System.Drawing.Size(18, 17);
            this.inverseSteering.TabIndex = 23;
            this.inverseSteering.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Inverse Steering:";
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 309);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.inverseSteering);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.rightMotorOffset);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.leftMotorOffset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rpiIPTwo);
            this.Controls.Add(this.rpiIPThree);
            this.Controls.Add(this.rpiIPFour);
            this.Controls.Add(this.rpiIPOne);
            this.Controls.Add(this.rpiIPTitleLabel);
            this.Controls.Add(this.comBox);
            this.Controls.Add(this.arduinoComTitleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "settingsForm";
            this.Text = "Wall-e Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.settingsForm_FormClosing);
            this.Load += new System.EventHandler(this.settingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rpiIPOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpiIPFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpiIPThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpiIPTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMotorOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightMotorOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label arduinoComTitleLabel;
        private System.Windows.Forms.ComboBox comBox;
        private System.Windows.Forms.Label rpiIPTitleLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown rpiIPOne;
        private System.Windows.Forms.NumericUpDown rpiIPFour;
        private System.Windows.Forms.NumericUpDown rpiIPThree;
        private System.Windows.Forms.NumericUpDown rpiIPTwo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown leftMotorOffset;
        private System.Windows.Forms.NumericUpDown rightMotorOffset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox inverseSteering;
        private System.Windows.Forms.Label label9;
    }
}
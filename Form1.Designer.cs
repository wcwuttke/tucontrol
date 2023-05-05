namespace tucontrol
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
            this.components = new System.ComponentModel.Container();
            this.lMark = new System.Windows.Forms.Label();
            this.lSpace = new System.Windows.Forms.Label();
            this.lBaud = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbToneLO = new System.Windows.Forms.RadioButton();
            this.rbToneHI = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbShift850 = new System.Windows.Forms.RadioButton();
            this.rbShift450 = new System.Windows.Forms.RadioButton();
            this.rbShift425 = new System.Windows.Forms.RadioButton();
            this.rbShift170 = new System.Windows.Forms.RadioButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bCmdList = new System.Windows.Forms.Button();
            this.bStatus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rbST8000A = new System.Windows.Forms.RadioButton();
            this.rbST8000 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bSend = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbRev = new System.Windows.Forms.RadioButton();
            this.rbNorm = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rb57 = new System.Windows.Forms.RadioButton();
            this.rb75 = new System.Windows.Forms.RadioButton();
            this.rb50 = new System.Windows.Forms.RadioButton();
            this.rb45 = new System.Windows.Forms.RadioButton();
            this.cbCmdList = new System.Windows.Forms.ComboBox();
            this.lOBaud = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lMark
            // 
            this.lMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lMark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lMark.Font = new System.Drawing.Font("Digital-7 Mono", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMark.ForeColor = System.Drawing.Color.Red;
            this.lMark.Location = new System.Drawing.Point(12, 9);
            this.lMark.Name = "lMark";
            this.lMark.Size = new System.Drawing.Size(67, 30);
            this.lMark.TabIndex = 0;
            this.lMark.Text = "2125";
            this.lMark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSpace
            // 
            this.lSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lSpace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lSpace.Font = new System.Drawing.Font("Digital-7 Mono", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSpace.ForeColor = System.Drawing.Color.Red;
            this.lSpace.Location = new System.Drawing.Point(12, 39);
            this.lSpace.Name = "lSpace";
            this.lSpace.Size = new System.Drawing.Size(67, 30);
            this.lSpace.TabIndex = 1;
            this.lSpace.Text = "2295";
            this.lSpace.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lBaud
            // 
            this.lBaud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lBaud.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lBaud.Font = new System.Drawing.Font("Digital-7 Mono", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBaud.ForeColor = System.Drawing.Color.Red;
            this.lBaud.Location = new System.Drawing.Point(12, 69);
            this.lBaud.Name = "lBaud";
            this.lBaud.Size = new System.Drawing.Size(67, 30);
            this.lBaud.TabIndex = 2;
            this.lBaud.Text = "045";
            this.lBaud.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "MARK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SPACE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "IBAUD";
            // 
            // rbToneLO
            // 
            this.rbToneLO.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbToneLO.Location = new System.Drawing.Point(6, 19);
            this.rbToneLO.Name = "rbToneLO";
            this.rbToneLO.Size = new System.Drawing.Size(48, 23);
            this.rbToneLO.TabIndex = 17;
            this.rbToneLO.TabStop = true;
            this.rbToneLO.Text = "LO";
            this.rbToneLO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbToneLO.UseVisualStyleBackColor = true;
            this.rbToneLO.CheckedChanged += new System.EventHandler(this.rbToneLO_CheckedChanged);
            // 
            // rbToneHI
            // 
            this.rbToneHI.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbToneHI.Location = new System.Drawing.Point(59, 19);
            this.rbToneHI.Name = "rbToneHI";
            this.rbToneHI.Size = new System.Drawing.Size(48, 23);
            this.rbToneHI.TabIndex = 18;
            this.rbToneHI.TabStop = true;
            this.rbToneHI.Text = "HI";
            this.rbToneHI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbToneHI.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbToneLO);
            this.groupBox1.Controls.Add(this.rbToneHI);
            this.groupBox1.Location = new System.Drawing.Point(318, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 52);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TONES";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbShift850);
            this.groupBox2.Controls.Add(this.rbShift450);
            this.groupBox2.Controls.Add(this.rbShift425);
            this.groupBox2.Controls.Add(this.rbShift170);
            this.groupBox2.Location = new System.Drawing.Point(131, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 52);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SHIFT";
            // 
            // rbShift850
            // 
            this.rbShift850.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbShift850.AutoSize = true;
            this.rbShift850.Location = new System.Drawing.Point(134, 18);
            this.rbShift850.Name = "rbShift850";
            this.rbShift850.Size = new System.Drawing.Size(35, 23);
            this.rbShift850.TabIndex = 21;
            this.rbShift850.TabStop = true;
            this.rbShift850.Text = "850";
            this.rbShift850.UseVisualStyleBackColor = true;
            this.rbShift850.CheckedChanged += new System.EventHandler(this.rbShift850_CheckedChanged);
            // 
            // rbShift450
            // 
            this.rbShift450.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbShift450.AutoSize = true;
            this.rbShift450.Location = new System.Drawing.Point(93, 18);
            this.rbShift450.Name = "rbShift450";
            this.rbShift450.Size = new System.Drawing.Size(35, 23);
            this.rbShift450.TabIndex = 20;
            this.rbShift450.TabStop = true;
            this.rbShift450.Text = "450";
            this.rbShift450.UseVisualStyleBackColor = true;
            this.rbShift450.CheckedChanged += new System.EventHandler(this.rbShift450_CheckedChanged);
            // 
            // rbShift425
            // 
            this.rbShift425.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbShift425.AutoSize = true;
            this.rbShift425.Location = new System.Drawing.Point(52, 18);
            this.rbShift425.Name = "rbShift425";
            this.rbShift425.Size = new System.Drawing.Size(35, 23);
            this.rbShift425.TabIndex = 19;
            this.rbShift425.TabStop = true;
            this.rbShift425.Text = "425";
            this.rbShift425.UseVisualStyleBackColor = true;
            this.rbShift425.CheckedChanged += new System.EventHandler(this.rbShift425_CheckedChanged);
            // 
            // rbShift170
            // 
            this.rbShift170.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbShift170.AutoSize = true;
            this.rbShift170.Location = new System.Drawing.Point(11, 18);
            this.rbShift170.Name = "rbShift170";
            this.rbShift170.Size = new System.Drawing.Size(35, 23);
            this.rbShift170.TabIndex = 18;
            this.rbShift170.TabStop = true;
            this.rbShift170.Text = "170";
            this.rbShift170.UseVisualStyleBackColor = true;
            this.rbShift170.CheckedChanged += new System.EventHandler(this.rbShift170_CheckedChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM18";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bCmdList);
            this.groupBox3.Controls.Add(this.bStatus);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.rbST8000A);
            this.groupBox3.Controls.Add(this.rbST8000);
            this.groupBox3.Location = new System.Drawing.Point(8, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 39);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modem - Not Connected";
            // 
            // bCmdList
            // 
            this.bCmdList.Location = new System.Drawing.Point(222, 13);
            this.bCmdList.Name = "bCmdList";
            this.bCmdList.Size = new System.Drawing.Size(70, 23);
            this.bCmdList.TabIndex = 30;
            this.bCmdList.Text = "CMD LIST";
            this.bCmdList.UseVisualStyleBackColor = true;
            this.bCmdList.Click += new System.EventHandler(this.bCmdList_Click);
            // 
            // bStatus
            // 
            this.bStatus.Location = new System.Drawing.Point(158, 13);
            this.bStatus.Name = "bStatus";
            this.bStatus.Size = new System.Drawing.Size(58, 23);
            this.bStatus.TabIndex = 29;
            this.bStatus.Text = "STATUS";
            this.bStatus.UseVisualStyleBackColor = true;
            this.bStatus.Click += new System.EventHandler(this.bStatus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "COM Port:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(355, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 21);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // rbST8000A
            // 
            this.rbST8000A.AutoSize = true;
            this.rbST8000A.Location = new System.Drawing.Point(79, 16);
            this.rbST8000A.Name = "rbST8000A";
            this.rbST8000A.Size = new System.Drawing.Size(73, 17);
            this.rbST8000A.TabIndex = 1;
            this.rbST8000A.TabStop = true;
            this.rbST8000A.Text = "ST-8000A";
            this.rbST8000A.UseVisualStyleBackColor = true;
            // 
            // rbST8000
            // 
            this.rbST8000.AutoSize = true;
            this.rbST8000.Location = new System.Drawing.Point(7, 16);
            this.rbST8000.Name = "rbST8000";
            this.rbST8000.Size = new System.Drawing.Size(66, 17);
            this.rbST8000.TabIndex = 0;
            this.rbST8000.TabStop = true;
            this.rbST8000.Text = "ST-8000";
            this.rbST8000.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 224);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(429, 282);
            this.textBox1.TabIndex = 25;
            this.textBox1.WordWrap = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(339, 20);
            this.textBox2.TabIndex = 26;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bSend);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Location = new System.Drawing.Point(8, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(429, 40);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Send Command";
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(351, 14);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(72, 20);
            this.bSend.TabIndex = 27;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbRev);
            this.groupBox5.Controls.Add(this.rbNorm);
            this.groupBox5.Location = new System.Drawing.Point(318, 67);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(113, 52);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "POLARITY";
            // 
            // rbRev
            // 
            this.rbRev.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRev.Location = new System.Drawing.Point(60, 18);
            this.rbRev.Name = "rbRev";
            this.rbRev.Size = new System.Drawing.Size(48, 23);
            this.rbRev.TabIndex = 23;
            this.rbRev.TabStop = true;
            this.rbRev.Text = "REV";
            this.rbRev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbRev.UseVisualStyleBackColor = true;
            // 
            // rbNorm
            // 
            this.rbNorm.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbNorm.Location = new System.Drawing.Point(6, 18);
            this.rbNorm.Name = "rbNorm";
            this.rbNorm.Size = new System.Drawing.Size(48, 23);
            this.rbNorm.TabIndex = 22;
            this.rbNorm.TabStop = true;
            this.rbNorm.Text = "NOR";
            this.rbNorm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbNorm.UseVisualStyleBackColor = true;
            this.rbNorm.CheckedChanged += new System.EventHandler(this.rbNorm_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rb57);
            this.groupBox6.Controls.Add(this.rb75);
            this.groupBox6.Controls.Add(this.rb50);
            this.groupBox6.Controls.Add(this.rb45);
            this.groupBox6.Location = new System.Drawing.Point(131, 67);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(181, 52);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "BAUD";
            // 
            // rb57
            // 
            this.rb57.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb57.AutoSize = true;
            this.rb57.Location = new System.Drawing.Point(93, 18);
            this.rb57.Name = "rb57";
            this.rb57.Size = new System.Drawing.Size(29, 23);
            this.rb57.TabIndex = 22;
            this.rb57.TabStop = true;
            this.rb57.Text = "57";
            this.rb57.UseVisualStyleBackColor = true;
            this.rb57.CheckedChanged += new System.EventHandler(this.rb57_CheckedChanged);
            // 
            // rb75
            // 
            this.rb75.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb75.AutoSize = true;
            this.rb75.Location = new System.Drawing.Point(134, 18);
            this.rb75.Name = "rb75";
            this.rb75.Size = new System.Drawing.Size(29, 23);
            this.rb75.TabIndex = 21;
            this.rb75.TabStop = true;
            this.rb75.Text = "75";
            this.rb75.UseVisualStyleBackColor = true;
            this.rb75.CheckedChanged += new System.EventHandler(this.rb75_CheckedChanged);
            // 
            // rb50
            // 
            this.rb50.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb50.AutoSize = true;
            this.rb50.Location = new System.Drawing.Point(52, 18);
            this.rb50.Name = "rb50";
            this.rb50.Size = new System.Drawing.Size(29, 23);
            this.rb50.TabIndex = 19;
            this.rb50.TabStop = true;
            this.rb50.Text = "50";
            this.rb50.UseVisualStyleBackColor = true;
            this.rb50.CheckedChanged += new System.EventHandler(this.rb50_CheckedChanged);
            // 
            // rb45
            // 
            this.rb45.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb45.AutoSize = true;
            this.rb45.Location = new System.Drawing.Point(11, 18);
            this.rb45.Name = "rb45";
            this.rb45.Size = new System.Drawing.Size(29, 23);
            this.rb45.TabIndex = 18;
            this.rb45.TabStop = true;
            this.rb45.Text = "45";
            this.rb45.UseVisualStyleBackColor = true;
            this.rb45.CheckedChanged += new System.EventHandler(this.rb45_CheckedChanged);
            // 
            // cbCmdList
            // 
            this.cbCmdList.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCmdList.FormattingEnabled = true;
            this.cbCmdList.Location = new System.Drawing.Point(87, 124);
            this.cbCmdList.Name = "cbCmdList";
            this.cbCmdList.Size = new System.Drawing.Size(350, 21);
            this.cbCmdList.TabIndex = 30;
            this.cbCmdList.Visible = false;
            this.cbCmdList.SelectedIndexChanged += new System.EventHandler(this.cbCmdList_SelectedIndexChanged);
            // 
            // lOBaud
            // 
            this.lOBaud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lOBaud.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lOBaud.Font = new System.Drawing.Font("Digital-7 Mono", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOBaud.ForeColor = System.Drawing.Color.Red;
            this.lOBaud.Location = new System.Drawing.Point(12, 99);
            this.lOBaud.Name = "lOBaud";
            this.lOBaud.Size = new System.Drawing.Size(67, 30);
            this.lOBaud.TabIndex = 31;
            this.lOBaud.Text = "045";
            this.lOBaud.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "OBAUD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 510);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lOBaud);
            this.Controls.Add(this.cbCmdList);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBaud);
            this.Controls.Add(this.lSpace);
            this.Controls.Add(this.lMark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Terminal Unit Control";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lMark;
        private System.Windows.Forms.Label lSpace;
        private System.Windows.Forms.Label lBaud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbToneLO;
        private System.Windows.Forms.RadioButton rbToneHI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbShift850;
        private System.Windows.Forms.RadioButton rbShift450;
        private System.Windows.Forms.RadioButton rbShift425;
        private System.Windows.Forms.RadioButton rbShift170;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbST8000A;
        private System.Windows.Forms.RadioButton rbST8000;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bStatus;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbRev;
        private System.Windows.Forms.RadioButton rbNorm;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rb75;
        private System.Windows.Forms.RadioButton rb50;
        private System.Windows.Forms.RadioButton rb45;
        private System.Windows.Forms.RadioButton rb57;
        private System.Windows.Forms.Button bCmdList;
        private System.Windows.Forms.ComboBox cbCmdList;
        private System.Windows.Forms.Label lOBaud;
        private System.Windows.Forms.Label label6;
    }
}


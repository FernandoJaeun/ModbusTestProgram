namespace 모드버스테스트2
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StopBitprop = new System.Windows.Forms.ComboBox();
            this.Parityprop = new System.Windows.Forms.ComboBox();
            this.DataBitprop = new System.Windows.Forms.ComboBox();
            this.BaudRateProp = new System.Windows.Forms.ComboBox();
            this.COMprop = new System.Windows.Forms.ComboBox();
            this.SaveConfig = new System.Windows.Forms.Button();
            this.CloseForm2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CommStatus = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TimeOutprop = new System.Windows.Forms.MaskedTextBox();
            this.Portprop = new System.Windows.Forms.TextBox();
            this.IPAddressprop = new System.Windows.Forms.MaskedTextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.StopBitprop);
            this.groupBox1.Controls.Add(this.Parityprop);
            this.groupBox1.Controls.Add(this.DataBitprop);
            this.groupBox1.Controls.Add(this.BaudRateProp);
            this.groupBox1.Controls.Add(this.COMprop);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 19);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = " RTU 통신설정";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(379, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "스탑비트";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(300, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "패리티";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(205, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "데이터비트";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(115, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "통신속도";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "통신포트";
            // 
            // StopBitprop
            // 
            this.StopBitprop.BackColor = System.Drawing.SystemColors.HighlightText;
            this.StopBitprop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBitprop.Enabled = false;
            this.StopBitprop.ForeColor = System.Drawing.Color.Black;
            this.StopBitprop.FormattingEnabled = true;
            this.StopBitprop.Location = new System.Drawing.Point(382, 62);
            this.StopBitprop.Name = "StopBitprop";
            this.StopBitprop.Size = new System.Drawing.Size(63, 23);
            this.StopBitprop.TabIndex = 1;
            this.StopBitprop.SelectedIndexChanged += new System.EventHandler(this.StopBitprop_SelectedIndexChanged);
            // 
            // Parityprop
            // 
            this.Parityprop.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Parityprop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Parityprop.Enabled = false;
            this.Parityprop.ForeColor = System.Drawing.Color.Black;
            this.Parityprop.FormattingEnabled = true;
            this.Parityprop.Location = new System.Drawing.Point(303, 62);
            this.Parityprop.Name = "Parityprop";
            this.Parityprop.Size = new System.Drawing.Size(63, 23);
            this.Parityprop.TabIndex = 1;
            this.Parityprop.SelectedIndexChanged += new System.EventHandler(this.Parityprop_SelectedIndexChanged);
            // 
            // DataBitprop
            // 
            this.DataBitprop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBitprop.Enabled = false;
            this.DataBitprop.FormattingEnabled = true;
            this.DataBitprop.Location = new System.Drawing.Point(208, 62);
            this.DataBitprop.Name = "DataBitprop";
            this.DataBitprop.Size = new System.Drawing.Size(79, 23);
            this.DataBitprop.TabIndex = 1;
            this.DataBitprop.SelectedIndexChanged += new System.EventHandler(this.DataBitprop_SelectedIndexChanged);
            // 
            // BaudRateProp
            // 
            this.BaudRateProp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BaudRateProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRateProp.Enabled = false;
            this.BaudRateProp.ForeColor = System.Drawing.Color.Black;
            this.BaudRateProp.FormattingEnabled = true;
            this.BaudRateProp.Location = new System.Drawing.Point(118, 62);
            this.BaudRateProp.Name = "BaudRateProp";
            this.BaudRateProp.Size = new System.Drawing.Size(74, 23);
            this.BaudRateProp.TabIndex = 1;
            this.BaudRateProp.SelectedIndexChanged += new System.EventHandler(this.BaudRateProp_SelectedIndexChanged);
            // 
            // COMprop
            // 
            this.COMprop.BackColor = System.Drawing.SystemColors.HotTrack;
            this.COMprop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMprop.Enabled = false;
            this.COMprop.ForeColor = System.Drawing.Color.Yellow;
            this.COMprop.FormattingEnabled = true;
            this.COMprop.Location = new System.Drawing.Point(17, 62);
            this.COMprop.Name = "COMprop";
            this.COMprop.Size = new System.Drawing.Size(85, 23);
            this.COMprop.TabIndex = 1;
            this.COMprop.SelectedIndexChanged += new System.EventHandler(this.COMprop_SelectedIndexChanged);
            // 
            // SaveConfig
            // 
            this.SaveConfig.Location = new System.Drawing.Point(226, 279);
            this.SaveConfig.Name = "SaveConfig";
            this.SaveConfig.Size = new System.Drawing.Size(137, 32);
            this.SaveConfig.TabIndex = 2;
            this.SaveConfig.Text = "저장 및 포트연결";
            this.SaveConfig.UseVisualStyleBackColor = true;
            this.SaveConfig.Click += new System.EventHandler(this.SaveConfig_Click);
            // 
            // CloseForm2
            // 
            this.CloseForm2.Location = new System.Drawing.Point(369, 279);
            this.CloseForm2.Name = "CloseForm2";
            this.CloseForm2.Size = new System.Drawing.Size(106, 32);
            this.CloseForm2.TabIndex = 2;
            this.CloseForm2.Text = "현재 폼 닫기";
            this.CloseForm2.UseVisualStyleBackColor = true;
            this.CloseForm2.Click += new System.EventHandler(this.CloseForm2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "연결상태";
            // 
            // CommStatus
            // 
            this.CommStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CommStatus.Location = new System.Drawing.Point(80, 283);
            this.CommStatus.Name = "CommStatus";
            this.CommStatus.Size = new System.Drawing.Size(96, 25);
            this.CommStatus.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TimeOutprop);
            this.groupBox2.Controls.Add(this.Portprop);
            this.groupBox2.Controls.Add(this.IPAddressprop);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(18, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // TimeOutprop
            // 
            this.TimeOutprop.Enabled = false;
            this.TimeOutprop.Location = new System.Drawing.Point(351, 59);
            this.TimeOutprop.Mask = "9999  ms";
            this.TimeOutprop.Name = "TimeOutprop";
            this.TimeOutprop.Size = new System.Drawing.Size(100, 25);
            this.TimeOutprop.TabIndex = 5;
            this.TimeOutprop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Portprop
            // 
            this.Portprop.Enabled = false;
            this.Portprop.Location = new System.Drawing.Point(263, 59);
            this.Portprop.Name = "Portprop";
            this.Portprop.Size = new System.Drawing.Size(82, 25);
            this.Portprop.TabIndex = 4;
            this.Portprop.Text = "502";
            this.Portprop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IPAddressprop
            // 
            this.IPAddressprop.Enabled = false;
            this.IPAddressprop.Location = new System.Drawing.Point(11, 59);
            this.IPAddressprop.Mask = "  000   .   000   .   000   .   000      ";
            this.IPAddressprop.Name = "IPAddressprop";
            this.IPAddressprop.Size = new System.Drawing.Size(246, 25);
            this.IPAddressprop.TabIndex = 3;
            this.IPAddressprop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IPAddressprop.TextChanged += new System.EventHandler(this.IPAddressprop_TextChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(150, 19);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = " TCP/ IP 통신설정";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(348, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "응답시간";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(260, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Port";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(8, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "IP Address";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 329);
            this.Controls.Add(this.CommStatus);
            this.Controls.Add(this.CloseForm2);
            this.Controls.Add(this.SaveConfig);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2 : Window for Setting";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StopBitprop;
        private System.Windows.Forms.ComboBox Parityprop;
        private System.Windows.Forms.ComboBox DataBitprop;
        private System.Windows.Forms.ComboBox BaudRateProp;
        private System.Windows.Forms.ComboBox COMprop;
        private System.Windows.Forms.Button SaveConfig;
        private System.Windows.Forms.Button CloseForm2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox CommStatus;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Portprop;
        private System.Windows.Forms.MaskedTextBox IPAddressprop;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox TimeOutprop;
    }
}
namespace 모드버스테스트2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.SetComPort = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FuncCodeList = new System.Windows.Forms.ComboBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.SlaveID = new System.Windows.Forms.TextBox();
            this.StartAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ReadData = new System.Windows.Forms.Button();
            this.TimerOFF = new System.Windows.Forms.Button();
            this.MBDataList = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MBDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // SetComPort
            // 
            this.SetComPort.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SetComPort.Location = new System.Drawing.Point(18, 18);
            this.SetComPort.Name = "SetComPort";
            this.SetComPort.Size = new System.Drawing.Size(148, 49);
            this.SetComPort.TabIndex = 1;
            this.SetComPort.Text = "통신 포트 설정";
            this.SetComPort.UseVisualStyleBackColor = true;
            this.SetComPort.Click += new System.EventHandler(this.SetComPort_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FuncCodeList);
            this.groupBox1.Controls.Add(this.Quantity);
            this.groupBox1.Controls.Add(this.SlaveID);
            this.groupBox1.Controls.Add(this.StartAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(18, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 159);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "여기서 슬레이브를 지정하세요";
            // 
            // FuncCodeList
            // 
            this.FuncCodeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FuncCodeList.FormattingEnabled = true;
            this.FuncCodeList.Location = new System.Drawing.Point(138, 66);
            this.FuncCodeList.Name = "FuncCodeList";
            this.FuncCodeList.Size = new System.Drawing.Size(121, 25);
            this.FuncCodeList.TabIndex = 3;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(138, 127);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(121, 25);
            this.Quantity.TabIndex = 2;
            this.Quantity.Text = "1";
            // 
            // SlaveID
            // 
            this.SlaveID.Location = new System.Drawing.Point(138, 34);
            this.SlaveID.Name = "SlaveID";
            this.SlaveID.Size = new System.Drawing.Size(121, 25);
            this.SlaveID.TabIndex = 2;
            this.SlaveID.Text = "1";
            // 
            // StartAddress
            // 
            this.StartAddress.Location = new System.Drawing.Point(138, 96);
            this.StartAddress.Name = "StartAddress";
            this.StartAddress.Size = new System.Drawing.Size(121, 25);
            this.StartAddress.TabIndex = 2;
            this.StartAddress.Text = "130";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Slave ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Function Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(12, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Starting Address";
            // 
            // ReadData
            // 
            this.ReadData.Location = new System.Drawing.Point(172, 19);
            this.ReadData.Name = "ReadData";
            this.ReadData.Size = new System.Drawing.Size(115, 49);
            this.ReadData.TabIndex = 4;
            this.ReadData.Text = "데이터 읽기";
            this.ReadData.UseVisualStyleBackColor = true;
            this.ReadData.Click += new System.EventHandler(this.ReadData_Click);
            // 
            // TimerOFF
            // 
            this.TimerOFF.Location = new System.Drawing.Point(14, 437);
            this.TimerOFF.Name = "TimerOFF";
            this.TimerOFF.Size = new System.Drawing.Size(82, 32);
            this.TimerOFF.TabIndex = 4;
            this.TimerOFF.Text = "읽기 종료";
            this.TimerOFF.UseVisualStyleBackColor = true;
            this.TimerOFF.Click += new System.EventHandler(this.TimerOFF_Click);
            // 
            // MBDataList
            // 
            this.MBDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MBDataList.Location = new System.Drawing.Point(293, 19);
            this.MBDataList.Name = "MBDataList";
            this.MBDataList.RowHeadersWidth = 51;
            this.MBDataList.RowTemplate.Height = 27;
            this.MBDataList.Size = new System.Drawing.Size(540, 224);
            this.MBDataList.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 481);
            this.Controls.Add(this.MBDataList);
            this.Controls.Add(this.TimerOFF);
            this.Controls.Add(this.ReadData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SetComPort);
            this.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1 : Main Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MBDataList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetComPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox StartAddress;
        private System.Windows.Forms.ComboBox FuncCodeList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ReadData;
        private System.Windows.Forms.TextBox SlaveID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TimerOFF;
        private System.Windows.Forms.DataGridView MBDataList;
        private System.Windows.Forms.TextBox IPAddressProp;
    }
}


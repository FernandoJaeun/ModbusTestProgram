using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using EasyModbus;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;
using System.Timers;
using System.Runtime.CompilerServices;

namespace 모드버스테스트2
{
    public delegate void DataGetEventHandler(string serial, int baud, int Parity, int Stopbit);

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CommStatus.Text = "연결 안 됨";
        }

        public DataGetEventHandler DataSendEvent;

        ModbusClient modbusClient = new ModbusClient();

        public string setSlaveID,
                                  setComNum,
                                  setBaudRate,
                                  setDataBit;

        private string setParity,
                                   setStopBit;


        private void Form2_Load(object sender, EventArgs e)
        {
            string[] portNum = { "COM3", "COM4", "COM5", "COM6", "COM7" };
            COMprop.Items.AddRange(portNum);
            COMprop.SelectedIndex = 0;
            setComNum = COMprop.SelectedItem.ToString();

            string[] baudRate = { "9600", "19200", "38400", "57600", "115200 " };
            BaudRateProp.Items.AddRange(baudRate);
            BaudRateProp.SelectedIndex = 0;

            string[] dataBit = { "7", "8" };
            DataBitprop.Items.AddRange(dataBit);
            DataBitprop.SelectedIndex = 1;

            string[] parity = { "None", "Odd(1)", "Even(2)" };
            Parityprop.Items.AddRange(parity);
            Parityprop.SelectedIndex = 0;

            string[] stopBit = { "0", "1", "2" };
            StopBitprop.Items.AddRange(stopBit);
            StopBitprop.SelectedIndex = 2;
        }

/*        private void COMprop_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.setComNum = COMprop.SelectedItem.ToString();
        }

        private void BaudRateProp_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.setBaudRate = BaudRateProp.SelectedItem.ToString();
        }

        private void DataBitprop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataBitprop.SelectedIndex >= 0)
            {
                this.setDataBit = DataBitprop.SelectedItem as string;
            }
        }

        private void Parityprop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Parityprop.SelectedIndex >= 0)
            {
                this.setParity = Parityprop.SelectedItem as string;
            }
        }

        private void StopBitprop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StopBitprop.SelectedIndex >= 0)
            {
                this.setStopBit = Parityprop.SelectedItem as string;
            }
        }
*/
  
        //선택된 설정값 저장하기
        private void SaveConfig_Click(object sender, EventArgs e)
        {
            DataSendEvent
                (                          // Form1으로 설정 값 보내기    
                    COMprop.SelectedItem.ToString(),
                    Convert.ToInt32(BaudRateProp.SelectedItem),
                    Parityprop.SelectedIndex,
                    StopBitprop.SelectedIndex 
                );
        }

        //포트 설정 화면 닫기
        private void CloseForm2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //RTU 통신포트 설정
        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            
            IPAddressprop.Enabled = false;
            Portprop.Enabled = false;
            TimeOutprop.Enabled = false;

            COMprop.Enabled = true;
            BaudRateProp.Enabled = true;
            Parityprop.Enabled = true;
            StopBitprop.Enabled = true;
        }

        //TCP/IP 통신포트 설정
        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            
            COMprop.Enabled = false;
            BaudRateProp.Enabled = false;
            Parityprop.Enabled = false;
            StopBitprop.Enabled = false;

            IPAddressprop.Enabled = true;
            Portprop.Enabled = true;
            TimeOutprop.Enabled = true;
        }

        //추후 만들 예정 , Port, TimeOut
        private void IPAddressprop_TextChanged(object sender, EventArgs e)
        {

        }
    }

    //일단 만듦 부분 클래스 공부
    public class TCPCommSetting : Form
    {

    }

}

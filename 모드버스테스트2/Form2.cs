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
    public delegate void RTUDataGetEventHandler(string serial, int baud, int parity, int stopBit); // Form 1 으로 RTU 설정 정보 전달
    public delegate void TCPIPDataGetEventHandler(string ip, int port, int timeOut); // Form 1 으로 TCP/IP 설정 정보 전달
    public partial class Form2 : Form
    {
        public bool isRTU;

        public Form2()
        {
            InitializeComponent();
            CommStatus.Text = "Waiting..";
        }
        ModbusClient modbusClient = new ModbusClient();     // 모드버스 라이브러리, Modbus ClientD의 전역 인스턴스

        public RTUDataGetEventHandler RTUDataSendEvent;           // 보낼 데이터를 담는 변수
        public TCPIPDataGetEventHandler TCPIPDataSendEvent;
        
        /*private EventHandler ipaddress_Enter;
        private EventHandler ipaddress_Leave;
        private KeyEventHandler ipaddress_KeyDown;*/

        //Form 2가 열리면 콤보박스에 값을 할당
        private void Form2_Load(object sender, EventArgs e)
        {
            IPAddressProp ipaddress = new IPAddressProp();
            string[] portNum = { "COM3", "COM4", "COM5", "COM6", "COM7" };  // COM 포트리스트 생성
            COMprop.Items.AddRange(portNum);
            COMprop.SelectedIndex = 0;

            string[] BaudRate = { "9600", "19200", "38400", "57600", "115200 " }; //보 레이트 리스트 생성
            BaudRateProp.Items.AddRange(BaudRate);
            BaudRateProp.SelectedIndex = 0;

            string[] dataBit = { "7", "8" };    // 데이터 비트 리스트 생성
            DataBitprop.Items.AddRange(dataBit);
            DataBitprop.SelectedIndex = 1;

            string[] parity = { "None", "Odd(1)", "Even(2)" };  // 패리티 리스트 생성
            Parityprop.Items.AddRange(parity);
            Parityprop.SelectedIndex = 0;

            string[] stopBit = { "0", "1", "2" };   // 스톱 비트 리스트 생성
            StopBitprop.Items.AddRange(stopBit);
            StopBitprop.SelectedIndex = 2;
        }
        //RTU 통신설정 활성화
        public void RTUChoice_Click(object sender, EventArgs e)
        {
            isRTU = true;
            TCPIPChoice.Checked = false;   // TCP/IP 통신설정 그룹박스 OFF

            IPAddressProp.Enabled = false;           // TCP/IP IP address    Disable
            IPPortprop.Enabled = false;             // TCP/IP Port            Disable
            TimeOutprop.Enabled = false;     // TCP/IP 응답시간      Disable

            COMprop.Enabled = true;             // RTU COM 포트         Enable
            BaudRateProp.Enabled = true;   // RTU 보레이트            Enable
            Parityprop.Enabled = true;          // RTU 패리티                Enable
            StopBitprop.Enabled = true;       // RTU 스톱비트            Enable
        }

        //TCP/IP 통신설정 활성화
        private void TCPIPChoice_Click(object sender, EventArgs e)
        {
            isRTU = false;
            RTUChoice.Checked = false;   // RTU 통신설정 그룹박스 OFF

            COMprop.Enabled = false;                   // RTU COM 포트           Disable
            BaudRateProp.Enabled = false;         // RTU 보레이트              Disable
            Parityprop.Enabled = false;                // RTU 패리티                  Disable
            StopBitprop.Enabled = false;             // RTU 스톱비트               Disalbe

            IPAddressProp.Enabled = true;           // TCP/IP IP address     Enable
            IPPortprop.Enabled = true;                     // TCP/IP Port                Enable
            TimeOutprop.Enabled = true;             // TCP/IP 응답시간          Enable

            IPAddressProp.KeyDown += new KeyEventHandler(IPAddressProp_KeyDown);
        }

        private void IPAddressProp_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                IPAddressProp.AppendText(".");
            }
        }

        //선택된 설정값 저장하기  
        private void SaveConfig_Click(object sender, EventArgs e)
        {
            if(isRTU == true)    // RTU 설정 값을 Form1 TryConnectRTU 메소드로 전달
            {
                RTUDataSendEvent   
                (
                    COMprop.SelectedItem.ToString(),                           // 선택된 COM 포트 값 전송
                    Convert.ToInt32(BaudRateProp.SelectedItem),    // 선택된 보 레이트 값 전송
                    Parityprop.SelectedIndex,                                           // 선택된 패리티 값 전송
                    StopBitprop.SelectedIndex                                         // 선택된 스톱비트 값 전송
                );
            }
            else    // TCP/IP 설정 값을 Form1 TryConnectTCPIP 메소드로 전달
            {
                TCPIPDataSendEvent
                    (
                    IPAddressProp.Text,
                    Convert.ToInt32(IPPortprop.Text),
                    Convert.ToInt32(TimeOutprop.Text)
                    );
            }    
        }

        //포트 설정 화면 닫기
        private void CloseForm2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    //일단 만듦 부분 클래스 공부
    public class TCPCommSetting : Form
    {

    }

}

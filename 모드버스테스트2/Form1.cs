using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using System.IO.Ports;
using System.CodeDom.Compiler;
using System.Runtime.InteropServices.ComTypes;
using EasyModbus.Exceptions;

namespace 모드버스테스트2
{
    /// <summary>
    /// Implements a ModbusClient.
    /// </summary>

    public partial class Form1 : Form
    {
        //TCP는 추후에 할 예정

        private string func_Code;
        private int rtu_Slave_ID, rtu_Starting_Address, rtu_Quantity,
                            tcp_Starting_Address, tcp_Quantity;

        Form2 setComm = new Form2();
        ModbusClient modbusClient = new ModbusClient();

        List<string> registry = new List<string>();

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
        }

        /*      이놈을 어떻게 쓸까..
       public enum FuncCodes     
       {
           Read_Coils = 1,                              
           Read_Discrete_Inputs = 2,         
           Read_Holding_Registers = 3,    
           Read_Input_Registers = 4  
       }
*/

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] FuncList = {
                "FC 01 / Read Coils",
                "FC 02 / Read Discrete Inputs",
                "FC 03 / Read Holding Registers",
                "FC 04 / Read Input Registers" };
            FuncCodeList.Items.AddRange(FuncList);
            FuncCodeList.SelectedIndex = 3;
            RTUSlaveID.Text = "1";
            RTUStartAdrs.Text = "130";
            RTUQuantity.Text = "1";


        }
        /*
     public Form1(Form2 form2)   // 이렇게 하면 Form2의 내용을 Form1에서 쓸 수 있다 카더라
       {
           InitializeComponent();
           setComm = form2;
       }
       */

        private void SetComPort_Click(object sender, EventArgs e)
        {
            setComm.DataSendEvent += new DataGetEventHandler(this.TryConnect);
            setComm.ShowDialog();
        }

        private void TimerOFF_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        //RTU모드 통신 연결시도
        private void TryConnect(string serial, int baud, int Parity, int Stopbit)
        {
            modbusClient.SerialPort = serial;  //포트지정
            modbusClient.ConnectionTimeout = 50;
            modbusClient.Baudrate = baud;    //통신속도 지정
            if (Parity == 0)        //패리티 지정
                modbusClient.Parity = System.IO.Ports.Parity.None;
            else if (Parity == 1)
                modbusClient.Parity = System.IO.Ports.Parity.Odd;
            else
                modbusClient.Parity = System.IO.Ports.Parity.Even;

            if (Stopbit == 0)       //StopBit 지정
                modbusClient.StopBits = StopBits.None;
            else if (Stopbit == 1)
                modbusClient.StopBits = StopBits.One;
            else
                modbusClient.StopBits = StopBits.Two;

            try
            {
                modbusClient.Connect();     //연결 시도
                MessageBox.Show("잘했어", "포트 연결 상태", MessageBoxButtons.OK);
                setComm.CommStatus.Text = "Good";
            }
            catch
            {
                if (modbusClient.Connected == false)
                {
                    modbusClient.Disconnect();    //연결 실패시 끊기
                    MessageBox.Show("포트 연결 실패", "포트 연결 상태", MessageBoxButtons.OK);
                    setComm.CommStatus.Text = "Not Bad";
                }
            }
        }

        private void ReadData_Click(object sender, EventArgs e)
        {
            if (modbusClient.Connected == true)
            {
                rtu_Slave_ID = Convert.ToInt32(RTUSlaveID.Text);
                rtu_Starting_Address = Convert.ToInt32(RTUStartAdrs.Text);
                rtu_Quantity = Convert.ToInt32(RTUQuantity.Text);

                timer.Interval = 500;
                timer.Tick += new EventHandler(timer_tick);
                timer.Start();
            }
        }

        private void timer_tick(object sender, EventArgs e)
        {

            for (int i = 0; i < rtu_Quantity; i++)
            {
                try
                {
                    registry.Add(modbusClient.ReadInputRegisters(130 + i, 1)[0].ToString());
                }
                catch (ModbusException)
                {
                    i--;
                }
                catch (TimeoutException)
                {
                    i--;
                }
            }

            foreach (var item in registry)
            {
                RealDataChat.Rows.Add(
                    rtu_Slave_ID,
                       FuncCodeList.SelectedItem.ToString().Substring(3, 2),
                       rtu_Starting_Address,
                       modbusClient.Baudrate
                       );
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using EasyModbus;
using System.Diagnostics;

namespace 모드버스테스트2
{
    public partial class Form1 : Form
    {
        int count = 0;
        ModbusClient modbusClient = new ModbusClient();     // 모드버스 라이브러리 인스턴스 생성

        public Form1()
        {
            InitializeComponent();
        }

        //Form 1가 열리면 RTU 어드레스 그룹박스에 값을 할당
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] funcList = {   // Fucntion Code 리스트 생성
                "FC 01 / Read Coils",
                "FC 02 / Read Discrete Inputs",
                "FC 03 / Read Holding Registers",
                "FC 04 / Read Input Registers" };
            FuncCodeList.DataSource = funcList;     // Function Code 리스트 할당
        }

        Form2 communicationPortSetting = new Form2();    // Form 2 인스턴스 생성
        // Form 2 를 열어 통신포트 지정
        private void SetComPort_Click(object sender, EventArgs e)
        {
            communicationPortSetting.RTUDataSendEvent += new RTUDataGetEventHandler(this.TryConnectRTU);    // Form 2 에서 지정한 포트 내용을 Form 1으로 전송
            communicationPortSetting.TCPIPDataSendEvent += new TCPIPDataGetEventHandler(this.TryConnectTCPIP);
            communicationPortSetting.ShowDialog();       // Form 2 열기, 모달방식 --> Form 2가 열려있는 동안 Form 1 사용 불가
        }

        // Form 2 에서 보낸 데이터를 받아 통신 연결을 시도함
        private void TryConnectRTU(string comPort, int baudRate, int parity, int stopBit)
        {
            modbusClient.SerialPort = comPort;    // COM 포트 지정
            modbusClient.Baudrate = baudRate;    // 보 레이트 지정
            modbusClient.ConnectionTimeout = 50;
            modbusClient.Parity = (Parity)Enum.ToObject(typeof(Parity), parity); // 패리티 지정
            modbusClient.StopBits = (StopBits)Enum.ToObject(typeof(StopBits), stopBit); // 스톱 비트 지정
           this.Connect();  // this는 자기 자신 인스턴스를 가르킨다.
        }

        private void TryConnectTCPIP(string ip, int port, int timeOut)
        {
            //modbusClient.IPAddress = ip;    // IP Address 지정
            modbusClient.IPAddress = ip;    // IP Address 지정
            modbusClient.Port = port;       // 포트 지정
            modbusClient.ConnectionTimeout = timeOut;   // 타임 아웃 지정
            this.Connect();
        }

        public void Connect()
        {
            try // 연결 시도
            {
                modbusClient.Connect();
                communicationPortSetting.CommStatus.Text = "Connected";  // 상태칸에 메세지 입력
            }
            catch // 연결 중 에러 감지됨.
            {
                modbusClient.Disconnect();
                if (modbusClient.Connected == false)    // 연결이 안되면
                {
                    MessageBox.Show("포트 연결 실패 \n\n" +
                        "## 다음 상황을 고려해보세요 \n" +
                        "- 해당 포트를 이미 사용중입니다. \n" +
                        "- 빈 포트를 지정하셨습니다. \n" +
                        "- 오늘은 날이 아닙니다..",
                        "포트 연결 상태", MessageBoxButtons.OK); // 연결 실패 메세지 박스를 띄우고,
                    communicationPortSetting.CommStatus.Text = "Not Connected";  // 상태칸에 메세지 입력
                }
            }
        }
        public static string[] readData;
        private static int slaveID;
        private static int startingAddress;
        private static int quantity;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();    // 주기적으로 값을 읽기 위해 타이머 생성

        // 데이터를 읽기
        private void ReadData_Click(object sender, EventArgs e)
        {
            // 프로그레스바 타이머에 반응
            if (modbusClient.Connected == true)     // 연결이 됐을 때
            {
                slaveID = Convert.ToInt32(SlaveID.Text);           // RTU 슬레이브 ID
                startingAddress = Convert.ToInt32(StartAddress.Text);      // RTU 시작 Address
                quantity = Convert.ToInt32(Quantity.Text);        // RTU 읽을 메모리 개수

                timer.Interval = 100;   // 타이머 주기 지정
                timer.Tick += new EventHandler(RepeatReadData);  // 타이머 시간 되면 작동할 메소드
                timer.Enabled = true; // 타이머 사용
                new Thread(() => timer.Start()).Start();     // 타이머 ON
            }
            else
                MessageBox.Show("연결이 끊어졌습니다");
        }

        List<RTUDataList> RTUdatas { get; set; }     // RTU로 읽은 데이터 값을 보관하기 위한 저장공간
        List<TCPDataList> TCPdatas { get; set; }     // TCP/IP로 읽은 데이터 값을 보관하기 위한 저장공간

        // 주기적으로 데이터 읽어들이기    
        private void RepeatReadData(object sender, EventArgs e)
        {
            FuncCodeList.Enabled = false;
            SlaveID.Enabled = false;
            StartAddress.Enabled = false;
            Quantity.Enabled = false;

            readData = new string[quantity];
            int funcCode = FuncCodeList.SelectedIndex;

            // 지정한 슬레이브의 데이터를 읽어들이는 코드, 반복문
            for (int i = 0; i < Convert.ToInt32(Quantity.Text); i++)    // 읽을 메모리 개수만큼 반복
            {
                readData[i] = ReadDataFromSlave(funcCode, startingAddress + i);
                Debug.WriteLine(readData[i]);

                if (readData[i] == null)
                    i--;
            }
            // 읽어들인 값을 리스트 뷰에 표시
            this.GetDatas();

        }

        private void GetDatas()
        {
            if (communicationPortSetting.isRTU == true)
            {
                RTUdatas = GetRTUDatas();
                MBDataList.DataSource = RTUdatas;
            }
            else
            {
                TCPdatas = GetTCPDatas();
                MBDataList.DataSource = TCPdatas;
            }
        }

        private string ReadDataFromSlave(int FunctionCode, int startingAddress)
        {
            try     // 데이터 Gathering 시도
            {
                switch (FunctionCode)
                {
                    case 0:
                        return modbusClient.ReadCoils(startingAddress, 1)[0].ToString(); // FC 1 00000-100000 시작번지 부터 지정한 개수 읽기

                    case 1:
                        return modbusClient.ReadDiscreteInputs(startingAddress, 1)[0].ToString();  // FC 2 100001-200000

                    case 2:
                        return modbusClient.ReadHoldingRegisters(startingAddress, 1)[0].ToString();    // FC 3 400001-500000

                    case 3:
                        return modbusClient.ReadInputRegisters(startingAddress, 1)[0].ToString();  // FC 4 300000-400000

                    default:        // 이외의 값이 들어올 때 처리
                        return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            #region 예외처리 보관함
            /*catch (ModbusException) // 모드버스 예외 발생 시
            {
                i--;        // 예외 발생한 부분 다시 반복
            }
            catch (TimeoutException)    // 타임 아웃 에러 시
            {
                i--;        // 예외 발생한 부분 다시 반복
            }
            catch (StackOverflowException)  // 데이터 과다복용 사망 시
            {
                i--;
            }
            catch (NullReferenceException)
            {
                readData[i] = "Null 붙잡을 노래";
            }
            */
            #endregion
        }

        // 읽은 데이터를 저장하는 곳
        private List<RTUDataList> GetRTUDatas()
        {
            var listOfRTU = new List<RTUDataList>();        // 저장소의 변수 생성 --> 데이터를 담기 위함
            int count = 0;  // 표에서 Starting Address를 1씩 증가시키기 위해
            foreach (var item in readData) // 읽을 개수만큼 반복
            {
                count++;
                listOfRTU.Add(new RTUDataList()         // RTU 데이터 표시 항목
                {
                    Address = startingAddress + count,                   // 메모리 번지
                    FunctionCode = FuncCodeList.SelectedIndex + 1,      
                    BaudRate = modbusClient.Baudrate,              
                    Parity_StopBits = modbusClient.Parity.ToString() + "/" + modbusClient.StopBits.ToString(),  
                    Value = item       // 데이터
                });
            }
            return listOfRTU;
        }

        private List<TCPDataList> GetTCPDatas()
        {
            var listOfTCP = new List<TCPDataList>();        // 저장소의 변수 생성 --> 데이터를 담기 위함
            int count = 0;  // 표에서 Starting Address를 1씩 증가시키기 위해
            foreach (var item in readData) // 읽을 개수만큼 반복
            {
                count++;
                listOfTCP.Add(new TCPDataList()         // TCP/IP 데이터 표시 항목
                {
                    Address = startingAddress + count,                   // 메모리 번지
                    FunctionCode = FuncCodeList.SelectedIndex + 1,
                    Timeout = modbusClient.ConnectionTimeout,
                    Value = item       // 데이터
                });
            }
            return listOfTCP;
        }

        // 읽기 종료 버튼
        private void TimerOFF_Click(object sender, EventArgs e)
        {
            timer.Stop();
            FuncCodeList.Enabled = true;
            SlaveID.Enabled = true;
            StartAddress.Enabled = true;
            Quantity.Enabled = true;
        }

    }
}

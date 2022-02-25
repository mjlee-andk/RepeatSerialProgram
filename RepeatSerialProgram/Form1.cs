using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace RepeatSerialProgram
{
    public partial class MainForm : Form
    {
        const string CRLF = "\r\n";
        const string CR = "\r";

        const string DEFAULT_REPEAT_TIME = "100";

        string currentAddress;

        string commandString1 = "";
        string commandString2 = "";
        string commandString3 = "";

        public MainForm()
        {
            InitializeComponent();
        }

        //
        // 프로그램 시작 시 디폴트 값 설정
        //
        private void MainForm_Load(object sender, EventArgs e)
        {
            // 시리얼 통신 디폴트 값 설정
            Combobox_Port.DataSource = SerialPort.GetPortNames();
            Combobox_Baudrate.SelectedIndex = 4; // 9600
            Combobox_Databits.SelectedIndex = 0; // 7bit
            Combobox_Parity.SelectedIndex = 2; // EVEN
            Combobox_Stopbits.SelectedIndex = 0; // 1

            // RS485 주소 디폴트 값 설정
            Combobox_Address1.SelectedIndex = 0; // 01
            Combobox_Address2.SelectedIndex = 1; // 02
            Combobox_Address3.SelectedIndex = 2; // 03

            // CR/LF 디폴트 값 설정
            Combobox_CRLF1.SelectedIndex = 0; // CR/LF
            Combobox_CRLF2.SelectedIndex = 0; // CR/LF
            Combobox_CRLF3.SelectedIndex = 0; // CR/LF

            // 반복 시간 디폴트 값 설정
            Textbox_Repeattime.Text = DEFAULT_REPEAT_TIME;
            timer1.Interval = Convert.ToInt32(DEFAULT_REPEAT_TIME);
        }

        //
        // 통신 연결/끊기 버튼
        //
        private void Button_Connect_Click(object sender, EventArgs e)
        {
            // 통신 연결하기
            if(Button_Connect.Text == "Connect")
            {
                // 시리얼 포트가 이미 열려있다면 종료
                if (serialPort1.IsOpen)
                {
                    return;
                }

                // 시리얼 통신 입력된 값으로 설정
                serialPort1.PortName = Combobox_Port.Text;
                serialPort1.BaudRate = Convert.ToInt32(Combobox_Baudrate.Text);
                serialPort1.DataBits = Convert.ToInt32(Combobox_Databits.Text);

                // parity
                if (Combobox_Parity.Text == "NONE")
                {
                    serialPort1.Parity = Parity.None;
                }
                else if (Combobox_Parity.Text == "ODD")
                {
                    serialPort1.Parity = Parity.Odd;
                }
                else
                {
                    serialPort1.Parity = Parity.Even;
                }

                // stopbit
                if (Combobox_Stopbits.Text == "1")
                {
                    serialPort1.StopBits = StopBits.One;
                }
                else if (Combobox_Stopbits.Text == "1.5")
                {
                    serialPort1.StopBits = StopBits.OnePointFive;
                }
                else
                {
                    serialPort1.StopBits = StopBits.Two;
                }
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                serialPort1.Open();

                MakeEnabledForSerial(false);
            }
            // 통신 끊기 버튼
            else
            {
                // 시리얼 통신 종료
                serialPort1.Close();
                MakeEnabledForSerial(true);
            }            
        }

        //
        // 시리얼 통신 수신
        //
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                var receivedData = serialPort1.ReadLine();
                // 크로스 스레드 문제 해결을 위한 처리
                /* 크로스 스레드란? 
                 * 자신의 스레드가 아닌 다른 스레드가 컨트롤에 접근하는 경우에 발생하는 오류
                 * Textbox를 UI스레드가 아닌 SerialPort 스레드에서 접근하려고 해서 오류 발생하여 처리해줌
                 */
                Textbox_Result.Invoke((MethodInvoker)delegate ()
                {
                    Textbox_Result.AppendText(receivedData);
                    Textbox_Result.AppendText("\n");
                });
            }
        }

        //
        // 커맨드 송신 시작/중단 버튼
        //
        private void Button_Start_Click(object sender, EventArgs e)
        {
            // 커맨드 송신 시작
            if(Button_Start.Text == "Start")
            {
                // 버튼 Stop으로 변경
                Button_Start.Text = "Stop";

                // 입력된 값으로 커맨드 만들기
                commandString1 = MakeCommand(Combobox_Address1.Text, Textbox_Command1.Text, Combobox_CRLF1.Text);
                commandString2 = MakeCommand(Combobox_Address2.Text, Textbox_Command2.Text, Combobox_CRLF2.Text);
                commandString3 = MakeCommand(Combobox_Address3.Text, Textbox_Command3.Text, Combobox_CRLF3.Text);

                // 처음 주소부터 시작
                currentAddress = Combobox_Address1.Text;

                // 입력한 반복 시간 설정
                if (Textbox_Repeattime.Text == "" || Textbox_Repeattime.Text == null)
                {
                    timer1.Interval = Convert.ToInt32(DEFAULT_REPEAT_TIME);
                }
                else
                {
                    timer1.Interval = Convert.ToInt32(Textbox_Repeattime.Text);
                }

                MakeEnabledForCommand(false);
            }
            // 커맨드 송신 중단
            else
            {
                Button_Start.Text = "Start";
                MakeEnabledForCommand(true);
            }
        }

        //
        // 커맨드 송신 관련 버튼, 콤보박스, 타이머 활성화/비활성화 함수
        //
        private void MakeEnabledForCommand(bool isTrue)
        {
            // 반복 시간 입력란
            Textbox_Repeattime.Enabled = isTrue;

            // 주소 입력란
            Combobox_Address1.Enabled = isTrue;
            Combobox_Address2.Enabled = isTrue;
            Combobox_Address3.Enabled = isTrue;

            // 커맨드 입력란
            Textbox_Command1.Enabled = isTrue;
            Textbox_Command2.Enabled = isTrue;
            Textbox_Command3.Enabled = isTrue;

            // CR/LF 입력란
            Combobox_CRLF1.Enabled = isTrue;
            Combobox_CRLF2.Enabled = isTrue;
            Combobox_CRLF3.Enabled = isTrue;

            Button_Connect.Enabled = isTrue;

            // 타이머 종료
            timer1.Enabled = !isTrue;
        }

        private void MakeEnabledForSerial(bool isTrue)
        {
            // 끊기 후에는 콤보박스 활성화
            Combobox_Port.Enabled = isTrue;
            Combobox_Baudrate.Enabled = isTrue;
            Combobox_Databits.Enabled = isTrue;
            Combobox_Parity.Enabled = isTrue;
            Combobox_Stopbits.Enabled = isTrue;

            // 시작 버튼 비활성화
            Button_Start.Enabled = !isTrue;

            // 버튼 이름 수정
            if (isTrue)
            {
                Button_Connect.Text = "Connect";
            }
            else
            {
                Button_Connect.Text = "Disconnect";
            }            
        }

        //
        // 명령어 만들기 함수
        // 기본 명령어 포맷 : 주소+명령어+CR/LF
        // 예시 : @01RW\r\n
        //
        private string MakeCommand(string selectedAddress, string selectedCommand, string selectedCRLF)
        {
            var result = "@";
            result = result + selectedAddress + selectedCommand;

            if (selectedCRLF == "CR/LF")
            {
                result += CRLF;
            }
            else
            {
                result += CR;
            }
            return result;
        }

        //
        // 입력한 반복 시간 간격마다 tick 함수를 호출한다
        //
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentAddress.Equals(Combobox_Address1.Text))
            {
                serialPort1.Write(commandString1);
                currentAddress = Combobox_Address2.Text;
            }
            else if (currentAddress.Equals(Combobox_Address2.Text))
            {
                serialPort1.Write(commandString2);
                currentAddress = Combobox_Address3.Text;
            }
            else
            {
                serialPort1.Write(commandString3);
                currentAddress = Combobox_Address1.Text;
            }
        }

        //
        // Clear 버튼
        //
        private void Button_Clear_Click(object sender, EventArgs e)
        {
            Textbox_Result.Text = "";
        }

        //
        // 반복 시간 입력란에 숫자만 입력되도록 
        //
        private void Textbox_Repeattime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
    }
}

namespace RepeatSerialProgram
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Textbox_Command1 = new System.Windows.Forms.TextBox();
            this.Combobox_Databits = new System.Windows.Forms.ComboBox();
            this.Combobox_Parity = new System.Windows.Forms.ComboBox();
            this.Combobox_Stopbits = new System.Windows.Forms.ComboBox();
            this.Combobox_Baudrate = new System.Windows.Forms.ComboBox();
            this.Combobox_CRLF1 = new System.Windows.Forms.ComboBox();
            this.Label_Baudrate = new System.Windows.Forms.Label();
            this.Label_Databits = new System.Windows.Forms.Label();
            this.Label_Parity = new System.Windows.Forms.Label();
            this.Label_Stopbits = new System.Windows.Forms.Label();
            this.Button_Connect = new System.Windows.Forms.Button();
            this.Label_Address = new System.Windows.Forms.Label();
            this.Label_Command = new System.Windows.Forms.Label();
            this.Label_CRLF = new System.Windows.Forms.Label();
            this.Combobox_Address1 = new System.Windows.Forms.ComboBox();
            this.Combobox_Address2 = new System.Windows.Forms.ComboBox();
            this.Combobox_CRLF2 = new System.Windows.Forms.ComboBox();
            this.Textbox_Command2 = new System.Windows.Forms.TextBox();
            this.Combobox_Address3 = new System.Windows.Forms.ComboBox();
            this.Combobox_CRLF3 = new System.Windows.Forms.ComboBox();
            this.Textbox_Command3 = new System.Windows.Forms.TextBox();
            this.Button_Start = new System.Windows.Forms.Button();
            this.Label_RepeatTime = new System.Windows.Forms.Label();
            this.Textbox_Repeattime = new System.Windows.Forms.TextBox();
            this.Textbox_Result = new System.Windows.Forms.TextBox();
            this.Label_Result = new System.Windows.Forms.Label();
            this.Label_Port = new System.Windows.Forms.Label();
            this.Combobox_Port = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Button_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataBits = 7;
            this.serialPort1.Parity = System.IO.Ports.Parity.Even;
            this.serialPort1.RtsEnable = true;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Textbox_Command1
            // 
            this.Textbox_Command1.Location = new System.Drawing.Point(216, 161);
            this.Textbox_Command1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Textbox_Command1.Name = "Textbox_Command1";
            this.Textbox_Command1.Size = new System.Drawing.Size(268, 29);
            this.Textbox_Command1.TabIndex = 3;
            this.Textbox_Command1.Text = "RW";
            // 
            // Combobox_Databits
            // 
            this.Combobox_Databits.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Combobox_Databits.FormattingEnabled = true;
            this.Combobox_Databits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.Combobox_Databits.Location = new System.Drawing.Point(374, 46);
            this.Combobox_Databits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Combobox_Databits.Name = "Combobox_Databits";
            this.Combobox_Databits.Size = new System.Drawing.Size(95, 27);
            this.Combobox_Databits.TabIndex = 4;
            // 
            // Combobox_Parity
            // 
            this.Combobox_Parity.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Combobox_Parity.FormattingEnabled = true;
            this.Combobox_Parity.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN"});
            this.Combobox_Parity.Location = new System.Drawing.Point(506, 46);
            this.Combobox_Parity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Combobox_Parity.Name = "Combobox_Parity";
            this.Combobox_Parity.Size = new System.Drawing.Size(95, 27);
            this.Combobox_Parity.TabIndex = 5;
            // 
            // Combobox_Stopbits
            // 
            this.Combobox_Stopbits.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Combobox_Stopbits.FormattingEnabled = true;
            this.Combobox_Stopbits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.Combobox_Stopbits.Location = new System.Drawing.Point(629, 46);
            this.Combobox_Stopbits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Combobox_Stopbits.Name = "Combobox_Stopbits";
            this.Combobox_Stopbits.Size = new System.Drawing.Size(95, 27);
            this.Combobox_Stopbits.TabIndex = 6;
            // 
            // Combobox_Baudrate
            // 
            this.Combobox_Baudrate.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Combobox_Baudrate.FormattingEnabled = true;
            this.Combobox_Baudrate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600"});
            this.Combobox_Baudrate.Location = new System.Drawing.Point(186, 46);
            this.Combobox_Baudrate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Combobox_Baudrate.Name = "Combobox_Baudrate";
            this.Combobox_Baudrate.Size = new System.Drawing.Size(145, 27);
            this.Combobox_Baudrate.TabIndex = 7;
            // 
            // Combobox_CRLF1
            // 
            this.Combobox_CRLF1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Combobox_CRLF1.FormattingEnabled = true;
            this.Combobox_CRLF1.Items.AddRange(new object[] {
            "CR/LF",
            "CR"});
            this.Combobox_CRLF1.Location = new System.Drawing.Point(553, 163);
            this.Combobox_CRLF1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Combobox_CRLF1.Name = "Combobox_CRLF1";
            this.Combobox_CRLF1.Size = new System.Drawing.Size(171, 27);
            this.Combobox_CRLF1.TabIndex = 8;
            // 
            // Label_Baudrate
            // 
            this.Label_Baudrate.AutoSize = true;
            this.Label_Baudrate.Location = new System.Drawing.Point(183, 22);
            this.Label_Baudrate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Baudrate.Name = "Label_Baudrate";
            this.Label_Baudrate.Size = new System.Drawing.Size(81, 19);
            this.Label_Baudrate.TabIndex = 9;
            this.Label_Baudrate.Text = "Baudrate";
            // 
            // Label_Databits
            // 
            this.Label_Databits.AutoSize = true;
            this.Label_Databits.Location = new System.Drawing.Point(371, 22);
            this.Label_Databits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Databits.Name = "Label_Databits";
            this.Label_Databits.Size = new System.Drawing.Size(73, 19);
            this.Label_Databits.TabIndex = 10;
            this.Label_Databits.Text = "Databits";
            // 
            // Label_Parity
            // 
            this.Label_Parity.AutoSize = true;
            this.Label_Parity.Location = new System.Drawing.Point(503, 22);
            this.Label_Parity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Parity.Name = "Label_Parity";
            this.Label_Parity.Size = new System.Drawing.Size(54, 19);
            this.Label_Parity.TabIndex = 11;
            this.Label_Parity.Text = "Parity";
            // 
            // Label_Stopbits
            // 
            this.Label_Stopbits.AutoSize = true;
            this.Label_Stopbits.Location = new System.Drawing.Point(626, 22);
            this.Label_Stopbits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Stopbits.Name = "Label_Stopbits";
            this.Label_Stopbits.Size = new System.Drawing.Size(74, 19);
            this.Label_Stopbits.TabIndex = 12;
            this.Label_Stopbits.Text = "Stopbits";
            // 
            // Button_Connect
            // 
            this.Button_Connect.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_Connect.Location = new System.Drawing.Point(761, 46);
            this.Button_Connect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(171, 46);
            this.Button_Connect.TabIndex = 13;
            this.Button_Connect.Text = "Connect";
            this.Button_Connect.UseVisualStyleBackColor = true;
            this.Button_Connect.Click += new System.EventHandler(this.Button_Connect_Click);
            // 
            // Label_Address
            // 
            this.Label_Address.AutoSize = true;
            this.Label_Address.Location = new System.Drawing.Point(31, 137);
            this.Label_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Address.Name = "Label_Address";
            this.Label_Address.Size = new System.Drawing.Size(77, 19);
            this.Label_Address.TabIndex = 14;
            this.Label_Address.Text = "Address";
            // 
            // Label_Command
            // 
            this.Label_Command.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Label_Command.AutoSize = true;
            this.Label_Command.Location = new System.Drawing.Point(213, 137);
            this.Label_Command.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Command.Name = "Label_Command";
            this.Label_Command.Size = new System.Drawing.Size(92, 19);
            this.Label_Command.TabIndex = 15;
            this.Label_Command.Text = "Command";
            // 
            // Label_CRLF
            // 
            this.Label_CRLF.AutoSize = true;
            this.Label_CRLF.Location = new System.Drawing.Point(550, 137);
            this.Label_CRLF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_CRLF.Name = "Label_CRLF";
            this.Label_CRLF.Size = new System.Drawing.Size(58, 19);
            this.Label_CRLF.TabIndex = 16;
            this.Label_CRLF.Text = "CR/LF";
            // 
            // Combobox_Address1
            // 
            this.Combobox_Address1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Combobox_Address1.FormattingEnabled = true;
            this.Combobox_Address1.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.Combobox_Address1.Location = new System.Drawing.Point(34, 161);
            this.Combobox_Address1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Combobox_Address1.Name = "Combobox_Address1";
            this.Combobox_Address1.Size = new System.Drawing.Size(121, 27);
            this.Combobox_Address1.TabIndex = 18;
            // 
            // Combobox_Address2
            // 
            this.Combobox_Address2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Combobox_Address2.FormattingEnabled = true;
            this.Combobox_Address2.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.Combobox_Address2.Location = new System.Drawing.Point(34, 219);
            this.Combobox_Address2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Combobox_Address2.Name = "Combobox_Address2";
            this.Combobox_Address2.Size = new System.Drawing.Size(121, 27);
            this.Combobox_Address2.TabIndex = 21;
            // 
            // Combobox_CRLF2
            // 
            this.Combobox_CRLF2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Combobox_CRLF2.FormattingEnabled = true;
            this.Combobox_CRLF2.Items.AddRange(new object[] {
            "CR/LF",
            "CR"});
            this.Combobox_CRLF2.Location = new System.Drawing.Point(553, 219);
            this.Combobox_CRLF2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Combobox_CRLF2.Name = "Combobox_CRLF2";
            this.Combobox_CRLF2.Size = new System.Drawing.Size(171, 27);
            this.Combobox_CRLF2.TabIndex = 20;
            // 
            // Textbox_Command2
            // 
            this.Textbox_Command2.Location = new System.Drawing.Point(216, 219);
            this.Textbox_Command2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Textbox_Command2.Name = "Textbox_Command2";
            this.Textbox_Command2.Size = new System.Drawing.Size(268, 29);
            this.Textbox_Command2.TabIndex = 19;
            this.Textbox_Command2.Text = "RW";
            // 
            // Combobox_Address3
            // 
            this.Combobox_Address3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Combobox_Address3.FormattingEnabled = true;
            this.Combobox_Address3.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.Combobox_Address3.Location = new System.Drawing.Point(34, 278);
            this.Combobox_Address3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Combobox_Address3.Name = "Combobox_Address3";
            this.Combobox_Address3.Size = new System.Drawing.Size(121, 27);
            this.Combobox_Address3.TabIndex = 24;
            // 
            // Combobox_CRLF3
            // 
            this.Combobox_CRLF3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Combobox_CRLF3.FormattingEnabled = true;
            this.Combobox_CRLF3.Items.AddRange(new object[] {
            "CR/LF",
            "CR"});
            this.Combobox_CRLF3.Location = new System.Drawing.Point(553, 276);
            this.Combobox_CRLF3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Combobox_CRLF3.Name = "Combobox_CRLF3";
            this.Combobox_CRLF3.Size = new System.Drawing.Size(171, 27);
            this.Combobox_CRLF3.TabIndex = 23;
            // 
            // Textbox_Command3
            // 
            this.Textbox_Command3.Location = new System.Drawing.Point(217, 276);
            this.Textbox_Command3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Textbox_Command3.Name = "Textbox_Command3";
            this.Textbox_Command3.Size = new System.Drawing.Size(268, 29);
            this.Textbox_Command3.TabIndex = 22;
            this.Textbox_Command3.Text = "RW";
            // 
            // Button_Start
            // 
            this.Button_Start.Enabled = false;
            this.Button_Start.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_Start.Location = new System.Drawing.Point(760, 409);
            this.Button_Start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(171, 46);
            this.Button_Start.TabIndex = 25;
            this.Button_Start.Text = "Start";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // Label_RepeatTime
            // 
            this.Label_RepeatTime.AutoSize = true;
            this.Label_RepeatTime.Location = new System.Drawing.Point(757, 326);
            this.Label_RepeatTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_RepeatTime.Name = "Label_RepeatTime";
            this.Label_RepeatTime.Size = new System.Drawing.Size(146, 19);
            this.Label_RepeatTime.TabIndex = 27;
            this.Label_RepeatTime.Text = "Repeat Time(ms)";
            // 
            // Textbox_Repeattime
            // 
            this.Textbox_Repeattime.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Textbox_Repeattime.Location = new System.Drawing.Point(760, 349);
            this.Textbox_Repeattime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Textbox_Repeattime.Name = "Textbox_Repeattime";
            this.Textbox_Repeattime.Size = new System.Drawing.Size(171, 29);
            this.Textbox_Repeattime.TabIndex = 26;
            this.Textbox_Repeattime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_Repeattime_KeyPress);
            // 
            // Textbox_Result
            // 
            this.Textbox_Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Textbox_Result.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Textbox_Result.Location = new System.Drawing.Point(34, 350);
            this.Textbox_Result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Textbox_Result.Multiline = true;
            this.Textbox_Result.Name = "Textbox_Result";
            this.Textbox_Result.ReadOnly = true;
            this.Textbox_Result.Size = new System.Drawing.Size(690, 387);
            this.Textbox_Result.TabIndex = 28;
            // 
            // Label_Result
            // 
            this.Label_Result.AutoSize = true;
            this.Label_Result.Location = new System.Drawing.Point(31, 326);
            this.Label_Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(58, 19);
            this.Label_Result.TabIndex = 29;
            this.Label_Result.Text = "Result";
            // 
            // Label_Port
            // 
            this.Label_Port.AutoSize = true;
            this.Label_Port.Location = new System.Drawing.Point(31, 22);
            this.Label_Port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Port.Name = "Label_Port";
            this.Label_Port.Size = new System.Drawing.Size(42, 19);
            this.Label_Port.TabIndex = 31;
            this.Label_Port.Text = "Port";
            // 
            // Combobox_Port
            // 
            this.Combobox_Port.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Combobox_Port.FormattingEnabled = true;
            this.Combobox_Port.Location = new System.Drawing.Point(34, 46);
            this.Combobox_Port.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Combobox_Port.Name = "Combobox_Port";
            this.Combobox_Port.Size = new System.Drawing.Size(121, 27);
            this.Combobox_Port.TabIndex = 30;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Button_Clear
            // 
            this.Button_Clear.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_Clear.Location = new System.Drawing.Point(760, 467);
            this.Button_Clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(171, 46);
            this.Button_Clear.TabIndex = 32;
            this.Button_Clear.Text = "Clear";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 758);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Label_Port);
            this.Controls.Add(this.Combobox_Port);
            this.Controls.Add(this.Label_Result);
            this.Controls.Add(this.Textbox_Result);
            this.Controls.Add(this.Label_RepeatTime);
            this.Controls.Add(this.Textbox_Repeattime);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.Combobox_Address3);
            this.Controls.Add(this.Combobox_CRLF3);
            this.Controls.Add(this.Textbox_Command3);
            this.Controls.Add(this.Combobox_Address2);
            this.Controls.Add(this.Combobox_CRLF2);
            this.Controls.Add(this.Textbox_Command2);
            this.Controls.Add(this.Combobox_Address1);
            this.Controls.Add(this.Label_CRLF);
            this.Controls.Add(this.Label_Command);
            this.Controls.Add(this.Label_Address);
            this.Controls.Add(this.Button_Connect);
            this.Controls.Add(this.Label_Stopbits);
            this.Controls.Add(this.Label_Parity);
            this.Controls.Add(this.Label_Databits);
            this.Controls.Add(this.Label_Baudrate);
            this.Controls.Add(this.Combobox_CRLF1);
            this.Controls.Add(this.Combobox_Baudrate);
            this.Controls.Add(this.Combobox_Stopbits);
            this.Controls.Add(this.Combobox_Parity);
            this.Controls.Add(this.Combobox_Databits);
            this.Controls.Add(this.Textbox_Command1);
            this.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "RepeatSerialProgram";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox Textbox_Command1;
        private System.Windows.Forms.ComboBox Combobox_Databits;
        private System.Windows.Forms.ComboBox Combobox_Parity;
        private System.Windows.Forms.ComboBox Combobox_Stopbits;
        private System.Windows.Forms.ComboBox Combobox_Baudrate;
        private System.Windows.Forms.ComboBox Combobox_CRLF1;
        private System.Windows.Forms.Label Label_Baudrate;
        private System.Windows.Forms.Label Label_Databits;
        private System.Windows.Forms.Label Label_Parity;
        private System.Windows.Forms.Label Label_Stopbits;
        private System.Windows.Forms.Button Button_Connect;
        private System.Windows.Forms.Label Label_Address;
        private System.Windows.Forms.Label Label_Command;
        private System.Windows.Forms.Label Label_CRLF;
        private System.Windows.Forms.ComboBox Combobox_Address1;
        private System.Windows.Forms.ComboBox Combobox_Address2;
        private System.Windows.Forms.ComboBox Combobox_CRLF2;
        private System.Windows.Forms.TextBox Textbox_Command2;
        private System.Windows.Forms.ComboBox Combobox_Address3;
        private System.Windows.Forms.ComboBox Combobox_CRLF3;
        private System.Windows.Forms.TextBox Textbox_Command3;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Label Label_RepeatTime;
        private System.Windows.Forms.TextBox Textbox_Repeattime;
        private System.Windows.Forms.TextBox Textbox_Result;
        private System.Windows.Forms.Label Label_Result;
        private System.Windows.Forms.Label Label_Port;
        private System.Windows.Forms.ComboBox Combobox_Port;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Button_Clear;
    }
}


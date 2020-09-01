namespace 串口助手
{
    partial class SerialPortHelper_HomeForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SendTimer = new System.Windows.Forms.Timer(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Auto_SendMessage = new System.Windows.Forms.CheckBox();
            this.Btn_Open_SerialPort = new System.Windows.Forms.Button();
            this.Take_Result_RichBox = new System.Windows.Forms.RichTextBox();
            this.SendTextBox = new System.Windows.Forms.RichTextBox();
            this.Time_ComboBox = new System.Windows.Forms.ComboBox();
            this.Btn_SendMessage = new System.Windows.Forms.Button();
            this.Port_Combox = new System.Windows.Forms.ComboBox();
            this.Com_ComBox = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendTimer
            // 
            this.SendTimer.Tick += new System.EventHandler(this.SendTimer_Tick);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.Auto_SendMessage);
            this.tabPage1.Controls.Add(this.Btn_Open_SerialPort);
            this.tabPage1.Controls.Add(this.Take_Result_RichBox);
            this.tabPage1.Controls.Add(this.SendTextBox);
            this.tabPage1.Controls.Add(this.Time_ComboBox);
            this.tabPage1.Controls.Add(this.Btn_SendMessage);
            this.tabPage1.Controls.Add(this.Port_Combox);
            this.tabPage1.Controls.Add(this.Com_ComBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(586, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "主页";
            // 
            // Auto_SendMessage
            // 
            this.Auto_SendMessage.AutoSize = true;
            this.Auto_SendMessage.Font = new System.Drawing.Font("宋体", 11F);
            this.Auto_SendMessage.Location = new System.Drawing.Point(6, 177);
            this.Auto_SendMessage.Name = "Auto_SendMessage";
            this.Auto_SendMessage.Size = new System.Drawing.Size(116, 19);
            this.Auto_SendMessage.TabIndex = 7;
            this.Auto_SendMessage.Text = "启动自动发送";
            this.Auto_SendMessage.UseVisualStyleBackColor = true;
            // 
            // Btn_Open_SerialPort
            // 
            this.Btn_Open_SerialPort.BackColor = System.Drawing.Color.Lime;
            this.Btn_Open_SerialPort.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Open_SerialPort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_Open_SerialPort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Open_SerialPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Open_SerialPort.Location = new System.Drawing.Point(8, 117);
            this.Btn_Open_SerialPort.Name = "Btn_Open_SerialPort";
            this.Btn_Open_SerialPort.Size = new System.Drawing.Size(107, 23);
            this.Btn_Open_SerialPort.TabIndex = 5;
            this.Btn_Open_SerialPort.Text = "打开串口";
            this.Btn_Open_SerialPort.UseVisualStyleBackColor = false;
            this.Btn_Open_SerialPort.Click += new System.EventHandler(this.Btn_Open_SerialPort_Click);
            // 
            // Take_Result_RichBox
            // 
            this.Take_Result_RichBox.Location = new System.Drawing.Point(124, 3);
            this.Take_Result_RichBox.Name = "Take_Result_RichBox";
            this.Take_Result_RichBox.Size = new System.Drawing.Size(446, 157);
            this.Take_Result_RichBox.TabIndex = 6;
            this.Take_Result_RichBox.Text = "";
            // 
            // SendTextBox
            // 
            this.SendTextBox.Location = new System.Drawing.Point(124, 177);
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.Size = new System.Drawing.Size(343, 96);
            this.SendTextBox.TabIndex = 0;
            this.SendTextBox.Text = "";
            // 
            // Time_ComboBox
            // 
            this.Time_ComboBox.FormattingEnabled = true;
            this.Time_ComboBox.Location = new System.Drawing.Point(8, 91);
            this.Time_ComboBox.Name = "Time_ComboBox";
            this.Time_ComboBox.Size = new System.Drawing.Size(107, 20);
            this.Time_ComboBox.TabIndex = 3;
            // 
            // Btn_SendMessage
            // 
            this.Btn_SendMessage.Location = new System.Drawing.Point(486, 177);
            this.Btn_SendMessage.Name = "Btn_SendMessage";
            this.Btn_SendMessage.Size = new System.Drawing.Size(84, 96);
            this.Btn_SendMessage.TabIndex = 4;
            this.Btn_SendMessage.Text = "发送消息";
            this.Btn_SendMessage.UseVisualStyleBackColor = true;
            this.Btn_SendMessage.Click += new System.EventHandler(this.Btn_SendMessage_Click);
            // 
            // Port_Combox
            // 
            this.Port_Combox.FormattingEnabled = true;
            this.Port_Combox.Items.AddRange(new object[] {
            "      600",
            "     1200",
            "     2400",
            "     4800",
            "     9600",
            "    14400",
            "    19200",
            "    28800",
            "    38400",
            "    57600",
            "   115200"});
            this.Port_Combox.Location = new System.Drawing.Point(8, 51);
            this.Port_Combox.Name = "Port_Combox";
            this.Port_Combox.Size = new System.Drawing.Size(107, 20);
            this.Port_Combox.TabIndex = 2;
            // 
            // Com_ComBox
            // 
            this.Com_ComBox.FormattingEnabled = true;
            this.Com_ComBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.Com_ComBox.Location = new System.Drawing.Point(8, 6);
            this.Com_ComBox.Name = "Com_ComBox";
            this.Com_ComBox.Size = new System.Drawing.Size(107, 20);
            this.Com_ComBox.TabIndex = 1;
            this.Com_ComBox.SelectedIndexChanged += new System.EventHandler(this.Com_ComBox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 305);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // SerialPortHelper_HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 305);
            this.Controls.Add(this.tabControl1);
            this.Name = "SerialPortHelper_HomeForm";
            this.Text = "串口助手（自制版）";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer SendTimer;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox Auto_SendMessage;
        private System.Windows.Forms.Button Btn_Open_SerialPort;
        private System.Windows.Forms.RichTextBox Take_Result_RichBox;
        private System.Windows.Forms.RichTextBox SendTextBox;
        private System.Windows.Forms.ComboBox Time_ComboBox;
        private System.Windows.Forms.Button Btn_SendMessage;
        private System.Windows.Forms.ComboBox Port_Combox;
        private System.Windows.Forms.ComboBox Com_ComBox;
        private System.Windows.Forms.TabControl tabControl1;
    }
}


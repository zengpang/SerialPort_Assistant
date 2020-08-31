namespace 串口助手
{
    partial class Cartogram_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cartogram_Form));
            this.c1Chart3D1 = new C1.Win.C1Chart3D.C1Chart3D();
            this.SendProtocol_Btn = new System.Windows.Forms.Button();
            this.AddProtocol_Btn = new System.Windows.Forms.Button();
            this.Protocol_Name_ComBox = new System.Windows.Forms.ComboBox();
            this.Protocol_Content_TextBox = new System.Windows.Forms.TextBox();
            this.Paint_Timer = new System.Windows.Forms.Timer(this.components);
            this.SendProtocol_Timer = new System.Windows.Forms.Timer(this.components);
            this.Cartogram_SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.Cartogram_Paint3D_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Chart3D1
            // 
            this.c1Chart3D1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Chart3D1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.c1Chart3D1.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold);
            this.c1Chart3D1.ForeColor = System.Drawing.Color.Yellow;
            this.c1Chart3D1.Location = new System.Drawing.Point(185, 12);
            this.c1Chart3D1.Name = "c1Chart3D1";
            this.c1Chart3D1.PropBag = resources.GetString("c1Chart3D1.PropBag");
            this.c1Chart3D1.Size = new System.Drawing.Size(389, 259);
            this.c1Chart3D1.TabIndex = 4;
            // 
            // SendProtocol_Btn
            // 
            this.SendProtocol_Btn.Location = new System.Drawing.Point(27, 95);
            this.SendProtocol_Btn.Name = "SendProtocol_Btn";
            this.SendProtocol_Btn.Size = new System.Drawing.Size(119, 40);
            this.SendProtocol_Btn.TabIndex = 5;
            this.SendProtocol_Btn.Text = "发送协议";
            this.SendProtocol_Btn.UseVisualStyleBackColor = true;
            this.SendProtocol_Btn.Click += new System.EventHandler(this.SendProtocol_Btn_Click);
            // 
            // AddProtocol_Btn
            // 
            this.AddProtocol_Btn.Location = new System.Drawing.Point(27, 141);
            this.AddProtocol_Btn.Name = "AddProtocol_Btn";
            this.AddProtocol_Btn.Size = new System.Drawing.Size(119, 39);
            this.AddProtocol_Btn.TabIndex = 6;
            this.AddProtocol_Btn.Text = "添加协议";
            this.AddProtocol_Btn.UseVisualStyleBackColor = true;
            this.AddProtocol_Btn.Click += new System.EventHandler(this.AddProtocol_Btn_Click);
            // 
            // Protocol_Name_ComBox
            // 
            this.Protocol_Name_ComBox.FormattingEnabled = true;
            this.Protocol_Name_ComBox.Location = new System.Drawing.Point(27, 25);
            this.Protocol_Name_ComBox.Name = "Protocol_Name_ComBox";
            this.Protocol_Name_ComBox.Size = new System.Drawing.Size(119, 20);
            this.Protocol_Name_ComBox.TabIndex = 7;
            this.Protocol_Name_ComBox.SelectedIndexChanged += new System.EventHandler(this.Protocol_Name_ComBox_SelectedIndexChanged);
            // 
            // Protocol_Content_TextBox
            // 
            this.Protocol_Content_TextBox.Location = new System.Drawing.Point(27, 52);
            this.Protocol_Content_TextBox.Name = "Protocol_Content_TextBox";
            this.Protocol_Content_TextBox.Size = new System.Drawing.Size(119, 21);
            this.Protocol_Content_TextBox.TabIndex = 8;
            // 
            // Paint_Timer
            // 
            this.Paint_Timer.Interval = 500;
            this.Paint_Timer.Tick += new System.EventHandler(this.Paint_Timer_Tick);
            // 
            // SendProtocol_Timer
            // 
            this.SendProtocol_Timer.Interval = 500;
            this.SendProtocol_Timer.Tick += new System.EventHandler(this.SendProtocol_Timer_Tick);
            // 
            // Cartogram_SerialPort
            // 
            this.Cartogram_SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Cartogram_SerialPort_DataReceived);
            // 
            // Cartogram_Paint3D_Timer
            // 
            this.Cartogram_Paint3D_Timer.Tick += new System.EventHandler(this.Cartogram_Paint3D_Timer_Tick);
            // 
            // Cartogram_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(586, 279);
            this.Controls.Add(this.Protocol_Content_TextBox);
            this.Controls.Add(this.Protocol_Name_ComBox);
            this.Controls.Add(this.AddProtocol_Btn);
            this.Controls.Add(this.SendProtocol_Btn);
            this.Controls.Add(this.c1Chart3D1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cartogram_Form";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Cartogram_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Chart3D.C1Chart3D c1Chart3D1;
        private System.Windows.Forms.Button SendProtocol_Btn;
        private System.Windows.Forms.Button AddProtocol_Btn;
        private System.Windows.Forms.ComboBox Protocol_Name_ComBox;
        private System.Windows.Forms.TextBox Protocol_Content_TextBox;
        private System.Windows.Forms.Timer Paint_Timer;
        private System.Windows.Forms.Timer SendProtocol_Timer;
        public System.IO.Ports.SerialPort Cartogram_SerialPort;
        private System.Windows.Forms.Timer Cartogram_Paint3D_Timer;
    }
}
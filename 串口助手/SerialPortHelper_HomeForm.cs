using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using 串口助手.Protocols;
using 串口助手.Protocols_Operation;

namespace 串口助手
{
    public partial class SerialPortHelper_HomeForm : Form
    {
        private bool IsAutoMessage = false;
        private byte[] Sendbytes = new byte[20];
        private byte[] Receivebytes;
        private string Protocol_Path="Protocol.xml";
        private ProtocolList protocolList;
        private String Protocol_Context = "";
        private Protocols_GURD_XML protocols_GURD_XML = new Protocols_GURD_XML();
        private Cartogram_Form form2;
        public  delegate void SerialPortData();
        public static event SerialPortData serialPortData;

        public SerialPortHelper_HomeForm()
        {
          
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Receivebytes = new byte[serialPort.BytesToRead];
            serialPort.Read(Receivebytes, 0, serialPort.BytesToRead);
            foreach(byte SingleByte in Receivebytes)
            {
                string ReceiveContext= SingleByte.ToString("X2");
                
                    Take_Result_RichBox.Text += ReceiveContext+' ';
                

            }



        }

        private void Btn_SendMessage_Click(object sender, EventArgs e)
        {
            SendMessage();

        }

        private void Btn_Open_SerialPort_Click(object sender, EventArgs e)
        {
            Btn_Open_SerialPort.BackColor = Color.Red;

        
            serialPort.PortName = Com_ComBox.Text.Trim();
            serialPort.BaudRate = int.Parse((Port_Combox.Text.Trim()));
            serialPort.Open();

        }

        private void SendMessage()
        {
            IsAutoMessage = Auto_SendMessage.Checked;
            Protocol_Context = SendTextBox.Text.Trim();
            Send_Protocol();

            if (IsAutoMessage)
            {

                SendTimer.Start();

            }
            else
            {
                serialPort.Write(Sendbytes, 0, 8);
            }
        }

        private void SendTimer_Tick(object sender, EventArgs e)
        {
            SendTimer.Stop();
            serialPort.Write(Sendbytes, 0, 8);
            SendTimer.Start();


        }
        private void Send_Protocol()
        {
            string[] Protocols = Protocol_Context.Split(' ');
            for(int i=0;i<8;i++)
            {
                Sendbytes[i] = Convert.ToByte(Protocols[i], 16);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            protocolList = new ProtocolList();

            if (!(File.Exists(Protocol_Path)))
            {
                protocolList.Protocols.Add(new Protocol("红外线", "ee e1 01 55 ff fc fd ff"));
                protocols_GURD_XML.Protocol_Save(protocolList, Protocol_Path);
            }
            Com_ComBox.Text = "  " + SerialPort.GetPortNames()[0];
            Port_Combox.Text = "     115200";
            TabPage tab2 = new TabPage();
            tab2.Text = "统计图";
            tab2.Name = "Statistical_TabPage";

            form2 = new Cartogram_Form();
            form2.TopLevel = false;
            tab2.Controls.Add(form2);
            tabControl1.TabPages.Add(tab2);
            form2.Show();
         
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPortData();

            serialPort.Close();
            

        }
    }
}

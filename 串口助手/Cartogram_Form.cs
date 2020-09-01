using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 串口助手.Protocols;
using 串口助手.Protocols_Operation;
using 工作工具库.Cartogram;

namespace 串口助手
{
    public partial class Cartogram_Form : Form
    {
        private byte[] ProtocolRead = new byte[4000];
        private ProtocolList protocolList;
        private byte[] SendBuffer;
        private Protocols_GURD_XML protocols_GURD_XML=new Protocols_GURD_XML();
        private string Protocol_Path = "Protocol.xml";
        private Random rnd = new Random();
        private StereoscopicCartogramPaint stereoscopicCartogramPaint=new StereoscopicCartogramPaint();
        private double[,] PaintData = new double[21, 90];
        private int[,] PhasePosition = new int[21, 9];
        private int[] rdata = new int[9];
        int[] rphase = new int[9];


        public Cartogram_Form()
        {
            InitializeComponent();
           

        }

        private void SendProtocol_Btn_Click(object sender, EventArgs e)
        {
            Cartogram_Paint3D_Timer.Enabled = true;
            if (!Cartogram_SerialPort.IsOpen)
            {
                Cartogram_SerialPort.Open();

            }
            SendProtocol_Timer.Start();






        }

        private void AddProtocol_Btn_Click(object sender, EventArgs e)
        {
            AddProtocolDialog addProtocolDialog = new AddProtocolDialog();
            addProtocolDialog.protocolAdd += ProtocolComboBoxUpdata;

            addProtocolDialog.Show();


        }

        private void Cartogram_Form_Load(object sender, EventArgs e)
        {
            
            protocolList=protocols_GURD_XML.Load(Protocol_Path);
            foreach(Protocol protocol in protocolList.Protocols)
            {
                Protocol_Name_ComBox.Items.Add(protocol.Protocol_TitleName);

            }
            stereoscopicCartogramPaint.StereoscopicCartogramInitialized(ref c1Chart3D1,ref PaintData);
            SerialPortHelper_HomeForm.serialPortData += SerialPortChange;


        }

        private void Cartogram_SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
           
            Cartogram_SerialPort.Read(ProtocolRead,0, Cartogram_SerialPort.BytesToRead);

            for (int j = 0; j < 9; j++)
            {

               
                rphase[j] = j * 10 + rnd.Next(10);//输入数据的相位信息   
                rdata[j] = ProtocolRead[13 + j] * 5 + rnd.Next(5); //输入数据的幅值
            }

        }

        private void SendProtocol_Timer_Tick(object sender, EventArgs e)
        {
            SendProtocol_Timer.Stop();
            SendProtocol();
            SendProtocol_Timer.Start();

        }

        private void Protocol_Name_ComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i=0;i< protocolList.Protocols.Count;i++)
            {
                if(protocolList.Protocols[i].Protocol_TitleName==Protocol_Name_ComBox.Text)
                {
                    Protocol_Content_TextBox.Text = protocolList.Protocols[i].Protocol_Content;
                }
            }
        }
        private void ProtocolComboBoxUpdata(ProtocolList protocolList)
        {
            Protocol_Name_ComBox.Items.Clear();
            foreach (Protocol protocol in protocolList.Protocols)
            {
                Protocol_Name_ComBox.Items.Add(protocol.Protocol_TitleName);

            }
          
        }

        private void Paint_Timer_Tick(object sender, EventArgs e)
        {
            Paint_Timer.Stop();
            Paint_Timer.Start();


        }
        private void SendProtocol()
        {
            string[] SendProtocolContents = Protocol_Content_TextBox.Text.Split(' ');
            SendBuffer = new byte[SendProtocolContents.Length];
            for (int i = 0; i < SendProtocolContents.Length; i++)
            {
                SendBuffer[i] = Convert.ToByte(SendProtocolContents[i], 16);

            }
            Cartogram_SerialPort.Write(SendBuffer, 0, SendBuffer.Length);
        }
        private void Cartogram_Paint3D_Timer_Tick(object sender, EventArgs e)
        {
            Cartogram_Paint3D_Timer.Stop();
            stereoscopicCartogramPaint.StereoscopicCartogram_RealTimePaint(ref c1Chart3D1,ref PaintData,ref rdata,ref rphase,ref PhasePosition);

            Cartogram_Paint3D_Timer.Start();
        }
        public void SerialPortChange(string PortName,int BaudRate)
        {
            Cartogram_SerialPort.PortName = PortName;
            Cartogram_SerialPort.BaudRate = BaudRate;
        }


    }
}

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

namespace 串口助手
{
    public partial class AddProtocolDialog : Form
    {
        private string Protocol_Path = "Protocol.xml";
        private Protocols_GURD_XML operation = new Protocols_GURD_XML();
        public delegate void ProtocolAdd(ProtocolList protocolList);
        public event ProtocolAdd protocolAdd;


        public AddProtocolDialog()
        {
            InitializeComponent();
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ProtocolAdd_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                ProtocolList protocolList = operation.Load(Protocol_Path);

                protocolList = operation.Add(ProtocolName_TextBox.Text, ProtocolContent_TextBox.Text, protocolList);
                operation.Protocol_Save(protocolList, Protocol_Path);
                protocolAdd(protocolList);
                MessageBox.Show("添加成功");
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("发生错误:" + ex.ToString());

            }
           


        }
    }
}

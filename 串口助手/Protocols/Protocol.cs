using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace 串口助手.Protocols
{
    public class Protocol
    {
        [XmlElement("ProtocolName")]
        public string Protocol_TitleName { get; set; }

        [XmlElement("ProtocolContent")]
        public string Protocol_Content { get; set; }
        public Protocol()
        {

        }

        public Protocol(string Protocol_TitleName,string Protocol_Content)
        {
            this.Protocol_TitleName = Protocol_TitleName;
            this.Protocol_Content = Protocol_Content;

        }
        
    }
}

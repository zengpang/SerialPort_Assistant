using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using 串口助手.Protocols;

namespace 串口助手.Protocols_Operation
{
    public class Protocols_GURD_XML
    {
        public void Protocol_Save(ProtocolList protocolList,string Protocol_Path)
        {
            using (StreamWriter ProtocolstreamWriter = new StreamWriter(Protocol_Path))
            {
                using (StringWriter ProtocolXmlContent = new StringWriter())
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ProtocolList));
                    serializer.Serialize(ProtocolXmlContent, protocolList);
                    ProtocolstreamWriter.Write(ProtocolXmlContent);

                }


            }

        }
   
        public ProtocolList Load(string Protocol_Path)
        {
            ProtocolList protocolList = new ProtocolList();
            using (StreamReader ProtocolXmlRead = new StreamReader(Protocol_Path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ProtocolList));
                protocolList = serializer.Deserialize(ProtocolXmlRead) as ProtocolList;

            }
            return protocolList;
        }
        public ProtocolList Add(string Protocol_TitleName,string Protocol_Content,ProtocolList protocolList)
        {
            protocolList.Protocols.Add(new Protocol(Protocol_TitleName, Protocol_Content));
            return protocolList;
        }
       

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace 串口助手.Protocols
{
    [XmlRoot("ProtocolRoot")]
    public class ProtocolList
    {
        [XmlArray("Protocols"),XmlArrayItem("Protocol")]
        public List<Protocol> Protocols { get; set; } = new List<Protocol>();

    }
}

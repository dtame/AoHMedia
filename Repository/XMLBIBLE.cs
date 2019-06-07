using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Repository
{
        [XmlRoot(ElementName = "XMLBIBLE")]
        public class XMLBIBLE
        {
            [XmlElement(ElementName = "BIBLEBOOK")]
            public BIBLEBOOK BIBLEBOOK { get; set; }
            [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Xsi { get; set; }
            [XmlAttribute(AttributeName = "biblename")]
            public string Biblename { get; set; }
        }
}

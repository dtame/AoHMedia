using System.Collections.Generic;
using System.Xml.Serialization;

namespace Repository
{
        [XmlRoot(ElementName = "BIBLEBOOK")]
        public class BIBLEBOOK
        {
            [XmlElement(ElementName = "CHAPTER")]
            public List<CHAPTER> CHAPTER { get; set; }
            [XmlAttribute(AttributeName = "bnumber")]
            public string Bnumber { get; set; }
            [XmlAttribute(AttributeName = "bname")]
            public string Bname { get; set; }
        }
}

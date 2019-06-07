using System.Collections.Generic;
using System.Xml.Serialization;

namespace Repository
{
        [XmlRoot(ElementName = "CHAPTER")]
        public class CHAPTER
        {
            [XmlElement(ElementName = "VERS")]
            public List<VERS> VERS { get; set; }
            [XmlAttribute(AttributeName = "cnumber")]
            public string Cnumber { get; set; }
        }
}

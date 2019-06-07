using System.Xml.Serialization;

namespace Repository
{    
        [XmlRoot(ElementName = "VERS")]
        public class VERS
        {
            [XmlAttribute(AttributeName = "vnumber")]
            public string Vnumber { get; set; }
            [XmlText]
            public string Text { get; set; }
        }  
}

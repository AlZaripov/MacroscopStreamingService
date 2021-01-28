using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VideoStreamingApp.BL
{
    [XmlRoot("Configuration")]
    public class ConfigurationXML
    {
        [XmlArray("Channels")]
        [XmlArrayItem("ChannelInfo")]
        public List<ChannelInfo> Chanels { get; set; }
    }
}

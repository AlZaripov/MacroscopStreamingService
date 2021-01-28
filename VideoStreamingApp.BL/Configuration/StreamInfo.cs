using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VideoStreamingApp.BL
{
    public class StreamInfo
    {
        [XmlAttribute("StreamType")]
        public string StreamType { get; set; } = "Main";

        [XmlAttribute("StreamFormat")]
        public string StreamFormat { get; set; } = "H264";

        [XmlAttribute("RotationMode")]
        public string RotationMode { get; set; } = "None";
    }
}

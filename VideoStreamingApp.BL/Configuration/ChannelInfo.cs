using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VideoStreamingApp.BL
{
    [Serializable]
    public class ChannelInfo
    {
        [XmlAttribute("Id")]
        public string ID { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Description")]
        public string Description { get; set; }

        [XmlAttribute("DeviceInfo")]
        public string DeviceInfo { get; set; } = "Virtual Camera Macroscop Virtual Ip Camera";

        [XmlAttribute("AttachedToServer")]
        public string AttachedToServer { get; set; } = "d9af8547-31ed-47cc-a9b5-14b66da29688";

        [XmlAttribute("IsDisabled")]
        public bool IsDisabled { get; set; } = false;

        [XmlAttribute("IsSoundOn")]
        public bool IsSoundOn { get; set; } = false;

        [XmlAttribute("IsArchivingEnabled")]
        public bool IsArhivingEnabled { get; set; } = true;

        [XmlAttribute("IsSoundArchivingEnabled")]
        public bool IsSoundArchivingEnable { get; set; } = true;

        [XmlAttribute("AllowedRealtime")]
        public bool AllowedRealTime { get; set; } = true;

        [XmlAttribute("AllowedArchive")]
        public bool AllowedArchive { get; set; } = true;

        [XmlAttribute("IsPtzOn")]
        public bool IsPtzOn { get; set; } = false;

        public StreamInfo StreamInfo { get; set; }

        public ChannelInfo(string ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
            StreamInfo = new StreamInfo();
        }

        // Конструктор для реализации Serializable
        private ChannelInfo()
        {
            StreamInfo = new StreamInfo();
        }
    }
}

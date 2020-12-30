// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class CreateFaultRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        [NameInMap("ConnectId")]
        [Validation(Required=false)]
        public string ConnectId { get; set; }

        [NameInMap("AgentOssFileName")]
        [Validation(Required=false)]
        public string AgentOssFileName { get; set; }

        [NameInMap("AgentFilePath")]
        [Validation(Required=false)]
        public string AgentFilePath { get; set; }

        [NameInMap("CustomOssFileName")]
        [Validation(Required=false)]
        public string CustomOssFileName { get; set; }

        [NameInMap("CustomFilePath")]
        [Validation(Required=false)]
        public string CustomFilePath { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        [NameInMap("ClientPort")]
        [Validation(Required=false)]
        public string ClientPort { get; set; }

        [NameInMap("OperatingSystemVersion")]
        [Validation(Required=false)]
        public string OperatingSystemVersion { get; set; }

        [NameInMap("BrowserVersion")]
        [Validation(Required=false)]
        public string BrowserVersion { get; set; }

        [NameInMap("MicrophoneList")]
        [Validation(Required=false)]
        public string MicrophoneList { get; set; }

        [NameInMap("MicrophoneEquipment")]
        [Validation(Required=false)]
        public string MicrophoneEquipment { get; set; }

        [NameInMap("SpeakerList")]
        [Validation(Required=false)]
        public string SpeakerList { get; set; }

        [NameInMap("SpeakerEquipment")]
        [Validation(Required=false)]
        public string SpeakerEquipment { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("ServiceIp")]
        [Validation(Required=false)]
        public string ServiceIp { get; set; }

        [NameInMap("ServicePort")]
        [Validation(Required=false)]
        public string ServicePort { get; set; }

    }

}

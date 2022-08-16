// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateHoneypotProbeRequest : TeaModel {
        [NameInMap("Arp")]
        [Validation(Required=false)]
        public bool? Arp { get; set; }

        [NameInMap("BusinessGroupId")]
        [Validation(Required=false)]
        public string BusinessGroupId { get; set; }

        [NameInMap("ControlNodeId")]
        [Validation(Required=false)]
        public string ControlNodeId { get; set; }

        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("HoneypotBindList")]
        [Validation(Required=false)]
        public List<CreateHoneypotProbeRequestHoneypotBindList> HoneypotBindList { get; set; }
        public class CreateHoneypotProbeRequestHoneypotBindList : TeaModel {
            [NameInMap("BindPortList")]
            [Validation(Required=false)]
            public List<CreateHoneypotProbeRequestHoneypotBindListBindPortList> BindPortList { get; set; }
            public class CreateHoneypotProbeRequestHoneypotBindListBindPortList : TeaModel {
                [NameInMap("BindPort")]
                [Validation(Required=false)]
                public bool? BindPort { get; set; }

                [NameInMap("EndPort")]
                [Validation(Required=false)]
                public int? EndPort { get; set; }

                [NameInMap("Fixed")]
                [Validation(Required=false)]
                public bool? Fixed { get; set; }

                [NameInMap("StartPort")]
                [Validation(Required=false)]
                public int? StartPort { get; set; }

                [NameInMap("TargetPort")]
                [Validation(Required=false)]
                public int? TargetPort { get; set; }

            }

            [NameInMap("HoneypotId")]
            [Validation(Required=false)]
            public string HoneypotId { get; set; }

        }

        [NameInMap("Ping")]
        [Validation(Required=false)]
        public bool? Ping { get; set; }

        [NameInMap("ProbeType")]
        [Validation(Required=false)]
        public string ProbeType { get; set; }

        [NameInMap("ProbeVersion")]
        [Validation(Required=false)]
        public string ProbeVersion { get; set; }

        [NameInMap("ProxyIp")]
        [Validation(Required=false)]
        public string ProxyIp { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}

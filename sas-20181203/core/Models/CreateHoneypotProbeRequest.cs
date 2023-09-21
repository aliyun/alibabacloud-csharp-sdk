// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateHoneypotProbeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable Address Resolution Protocol (ARP) spoofing. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("Arp")]
        [Validation(Required=false)]
        public bool? Arp { get; set; }

        /// <summary>
        /// The ID of the business group.
        /// </summary>
        [NameInMap("BusinessGroupId")]
        [Validation(Required=false)]
        public string BusinessGroupId { get; set; }

        /// <summary>
        /// The ID of the management node.
        /// 
        /// > You can call the [ListHoneypotNode](~~ListHoneypotNode~~) operation to query the IDs of management nodes.
        /// </summary>
        [NameInMap("ControlNodeId")]
        [Validation(Required=false)]
        public string ControlNodeId { get; set; }

        /// <summary>
        /// The name of the probe.
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The configuration of the probe.
        /// </summary>
        [NameInMap("HoneypotBindList")]
        [Validation(Required=false)]
        public List<CreateHoneypotProbeRequestHoneypotBindList> HoneypotBindList { get; set; }
        public class CreateHoneypotProbeRequestHoneypotBindList : TeaModel {
            /// <summary>
            /// The listener ports.
            /// </summary>
            [NameInMap("BindPortList")]
            [Validation(Required=false)]
            public List<CreateHoneypotProbeRequestHoneypotBindListBindPortList> BindPortList { get; set; }
            public class CreateHoneypotProbeRequestHoneypotBindListBindPortList : TeaModel {
                /// <summary>
                /// Specifies whether to bind a port. Valid values:
                /// 
                /// *   **true**: yes
                /// *   **false**: no
                /// </summary>
                [NameInMap("BindPort")]
                [Validation(Required=false)]
                public bool? BindPort { get; set; }

                /// <summary>
                /// The end of the port range.
                /// </summary>
                [NameInMap("EndPort")]
                [Validation(Required=false)]
                public int? EndPort { get; set; }

                /// <summary>
                /// Specifies whether the port is a fixed port. Valid values:
                /// 
                /// *   **0**: no
                /// *   **1**: yes
                /// </summary>
                [NameInMap("Fixed")]
                [Validation(Required=false)]
                public bool? Fixed { get; set; }

                /// <summary>
                /// The start of the port range.
                /// </summary>
                [NameInMap("StartPort")]
                [Validation(Required=false)]
                public int? StartPort { get; set; }

                /// <summary>
                /// The destination port.
                /// 
                /// > If **HoneypotId** is specified, this parameter is required.
                /// </summary>
                [NameInMap("TargetPort")]
                [Validation(Required=false)]
                public int? TargetPort { get; set; }

            }

            /// <summary>
            /// The ID of the honeypot.
            /// 
            /// > You can call the [ListHoneypot](~~ListHoneypot~~) operation to query the IDs of honeypots.
            /// </summary>
            [NameInMap("HoneypotId")]
            [Validation(Required=false)]
            public string HoneypotId { get; set; }

        }

        /// <summary>
        /// Specifies whether to enable ping scan. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("Ping")]
        [Validation(Required=false)]
        public bool? Ping { get; set; }

        /// <summary>
        /// The type of the probe. Valid values:
        /// 
        /// *   **host_probe**: host probe
        /// *   **vpc_black_hole_probe**: virtual private cloud (VPC) probe
        /// </summary>
        [NameInMap("ProbeType")]
        [Validation(Required=false)]
        public string ProbeType { get; set; }

        /// <summary>
        /// The version of the probe.
        /// </summary>
        [NameInMap("ProbeVersion")]
        [Validation(Required=false)]
        public string ProbeVersion { get; set; }

        /// <summary>
        /// The IP address of the proxy.
        /// </summary>
        [NameInMap("ProxyIp")]
        [Validation(Required=false)]
        public string ProxyIp { get; set; }

        /// <summary>
        /// The UUID of the instance.
        /// 
        /// > If **ProbeType** is set to **host_probe**, this parameter is required.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// The ID of the VPC.
        /// 
        /// > If **ProbeType** is set to **vpc_black_hole_probe**, this parameter is required. You can call the [DescribeVpcHoneyPotList](~~DescribeVpcHoneyPotList~~) operation to query the IDs of VPCs.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}

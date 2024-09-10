// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTrafficMarkingPolicyRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among all requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run. Valid values:
        /// 
        /// *   **true**: performs a dry run. The system checks the required parameters, request format, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and sends the request.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The differentiated services code point (DSCP) value to be added to packets that match the traffic classification rule. Valid values: **0** to **63**.
        /// 
        /// The DSCP value of each traffic marking policy on a transit router must be unique.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MarkingDscp")]
        [Validation(Required=false)]
        public int? MarkingDscp { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The priority value of the traffic marking policy. Valid values: **1** to **100**.
        /// 
        /// The priority value of each traffic marking policy on a transit router must be unique. A smaller value specifies a higher priority.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The description of the traffic marking policy.
        /// 
        /// This parameter is optional. If you enter a description, it must be 1 to 256 characters in length, and cannot start with http:// or https://.
        /// </summary>
        [NameInMap("TrafficMarkingPolicyDescription")]
        [Validation(Required=false)]
        public string TrafficMarkingPolicyDescription { get; set; }

        /// <summary>
        /// The name of the traffic marking policy.
        /// 
        /// The name can be empty or 1 to 128 characters in length, and cannot start with http:// or https://.
        /// </summary>
        [NameInMap("TrafficMarkingPolicyName")]
        [Validation(Required=false)]
        public string TrafficMarkingPolicyName { get; set; }

        /// <summary>
        /// The traffic classification rules in the traffic marking policy.
        /// 
        /// Data packets that meet the traffic classification rule is assigned the DSCP value of quality of service (QoS) policy.
        /// 
        /// You can create up to 50 traffic classification rules.
        /// </summary>
        [NameInMap("TrafficMatchRules")]
        [Validation(Required=false)]
        public List<CreateTrafficMarkingPolicyRequestTrafficMatchRules> TrafficMatchRules { get; set; }
        public class CreateTrafficMarkingPolicyRequestTrafficMatchRules : TeaModel {
            [NameInMap("AddressFamily")]
            [Validation(Required=false)]
            public string AddressFamily { get; set; }

            /// <summary>
            /// The destination CIDR block that is used to match packets.
            /// 
            /// Packets whose destination IP addresses fall into the specified destination CIDR block meet the traffic classification rule. If you do not specify a destination CIDR block, all packets meet the traffic classification rule.
            /// 
            /// You can create up to 50 traffic classification rules in each call You can specify a destination CIDR block for each traffic classification rule.
            /// </summary>
            [NameInMap("DstCidr")]
            [Validation(Required=false)]
            public string DstCidr { get; set; }

            /// <summary>
            /// The destination port range that is used to match packets. Valid values: **-1** and **1** to **65535**.
            /// 
            /// Packets whose destination ports fall within the destination port range meet the traffic classification rule. If you do not specify destination port range, all packets meet the traffic classification rule.
            /// 
            /// You can enter up to two port numbers. Take note of the following rules:
            /// 
            /// *   If you enter only one port number, such as 1, packets whose destination port is 1 meet the traffic classification rule.
            /// *   If you enter two port numbers, such as 1 and 200, packets whose destination ports fall into 1 and 200 meet the traffic classification rule.
            /// *   If you enter two port numbers and one of them is -1, the other port number must also be -1. In this case, all packets meet the traffic classification rule.
            /// 
            /// You can create up to 50 traffic classification rules in each call. You can specify a destination port range for each traffic classification rule.
            /// </summary>
            [NameInMap("DstPortRange")]
            [Validation(Required=false)]
            public List<int?> DstPortRange { get; set; }

            /// <summary>
            /// The DSCP value that is used to match packets. Valid values: **0** to **63**.
            /// 
            /// Packets that carry the specified DSCP value meet the traffic classification rule. If you do not specify a DSCP value, all packets meet the traffic classification rule.
            /// 
            /// >  The DSCP value that you specify for this parameter is the DSCP value that packets carry before they are transmitted over the inter-region connection.
            /// 
            /// You can create up to 50 traffic classification rules in each call. You can specify a DSCP value for each traffic classification rule.
            /// </summary>
            [NameInMap("MatchDscp")]
            [Validation(Required=false)]
            public int? MatchDscp { get; set; }

            /// <summary>
            /// The protocol that is used to match packets.
            /// 
            /// Traffic classification rules support the following protocols: **HTTP**, **HTTPS**, **TCP**, **UDP**, **SSH**, and **Telnet**. For more information, log on to the [CEN console](https://cen.console.aliyun.com/cen/list).
            /// 
            /// **Some protocols use a fixed port. Click to view protocols and ports.**
            /// 
            /// *   If the protocol is **ICMP**, the destination port must be **-1**.
            /// *   If the protocol is **GRE**, the destination port must be **1**.
            /// *   If the protocol is **SSH**, the destination port must be **22**.
            /// *   If the protocol is **Telnet**, the destination port must be **23**.
            /// *   If the protocol is **HTTP**, the destination port must be **80**.
            /// *   If the protocol is **HTTPS**, the destination port must be **443**.
            /// *   If the protocol is **MS SQL**, the destination port must be **1443**.
            /// *   If the protocol is **Oracle**, the destination port must be **1521**.
            /// *   If the protocol is **Mysql**, the destination port must be **3306**.
            /// *   If the protocol is **RDP**, the destination port must be **3389**.
            /// *   If the protocol is **Postgre SQL**, the destination port must be **5432**.
            /// *   If the protocol is **Redis**, the destination port must be **6379**.
            /// 
            /// You can create up to 50 traffic classification rules in each call. You can specify a protocol for each traffic classification rule.
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// The source CIDR block that is used to match packets.
            /// 
            /// Packets whose source IP addresses fall into the specified source CIDR block meet the traffic classification rule. If you do not specify a source CIDR block, all packets meet the traffic classification rule.
            /// 
            /// You can create up to 50 traffic classification rules in each call. You can specify a source CIDR block for each traffic classification rule.
            /// </summary>
            [NameInMap("SrcCidr")]
            [Validation(Required=false)]
            public string SrcCidr { get; set; }

            /// <summary>
            /// The source port range that is used to match packets. Valid values: **-1** and **1** to **65535**.
            /// 
            /// Packets whose source ports fall into the source port range meet the traffic classification rule. If you do not specify a source port range, all packets meet the traffic classification rule.
            /// 
            /// You can enter up to two port numbers. Take note of the following rules:
            /// 
            /// *   If you enter only one port number, such as 1, packets whose source port is 1 meet the traffic classification rule.
            /// *   If you enter two port numbers, such as 1 and 200, packets whose source ports fall into 1 and 200 meet the traffic classification rule.
            /// *   If you enter two port numbers and one of them is -1, the other port number must also be -1. In this case, all packets meet the traffic classification rule.
            /// 
            /// You can create up to 50 traffic classification rules in each call. You can specify a source port range for each traffic classification rule.
            /// </summary>
            [NameInMap("SrcPortRange")]
            [Validation(Required=false)]
            public List<int?> SrcPortRange { get; set; }

            /// <summary>
            /// The description of the traffic classification rule.
            /// 
            /// You can create up to 50 traffic classification rules in each call. You can specify a description for each traffic classification rule.
            /// 
            /// This parameter is optional. If you enter a description, it must be 1 to 256 characters in length, and cannot start with http:// or https://.
            /// </summary>
            [NameInMap("TrafficMatchRuleDescription")]
            [Validation(Required=false)]
            public string TrafficMatchRuleDescription { get; set; }

            /// <summary>
            /// The name of the traffic classification rule.
            /// 
            /// You can create up to 50 traffic classification rules in each call. You can specify a name for each traffic classification rule.
            /// 
            /// The name can be empty or 1 to 128 characters in length, and cannot start with http:// or https://.
            /// </summary>
            [NameInMap("TrafficMatchRuleName")]
            [Validation(Required=false)]
            public string TrafficMatchRuleName { get; set; }

        }

        /// <summary>
        /// The ID of the transit router.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}

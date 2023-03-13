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
        /// The description must be 2 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The description must start with a letter.
        /// </summary>
        [NameInMap("TrafficMarkingPolicyDescription")]
        [Validation(Required=false)]
        public string TrafficMarkingPolicyDescription { get; set; }

        /// <summary>
        /// The name of the traffic marking policy.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("TrafficMarkingPolicyName")]
        [Validation(Required=false)]
        public string TrafficMarkingPolicyName { get; set; }

        /// <summary>
        /// The traffic classification rules in the traffic marking policy.
        /// 
        /// Packets that match the traffic classification rules are assigned the DSCP value of the traffic marking policy.
        /// 
        /// You can specify at most 50 traffic classification rules.
        /// </summary>
        [NameInMap("TrafficMatchRules")]
        [Validation(Required=false)]
        public List<CreateTrafficMarkingPolicyRequestTrafficMatchRules> TrafficMatchRules { get; set; }
        public class CreateTrafficMarkingPolicyRequestTrafficMatchRules : TeaModel {
            /// <summary>
            /// The destination CIDR block that is used to match packets.
            /// 
            /// The traffic classification rule matches the packets whose destination IP addresses fall within the specified destination CIDR block. If you do not set this parameter, packets with all destination IP addresses are matched.
            /// 
            /// You can create up to 50 traffic classification rules in each call. You can specify a destination CIDR block for each traffic classification rule.
            /// </summary>
            [NameInMap("DstCidr")]
            [Validation(Required=false)]
            public string DstCidr { get; set; }

            /// <summary>
            /// The destination port range that is used to match packets. Valid values: **-1** and **1** to **65535**.
            /// 
            /// The traffic classification rule matches the packets whose destination ports fall within the destination port range. If you do not set this parameter, packets with all destination ports are matched.
            /// 
            /// You can specify at most two ports. Take note of the following rules:
            /// 
            /// *   If you enter only one port number such as 1, the system matches the packets whose destination port is port 1.
            /// *   If you enter two port numbers such as 1 and 200, the system matches the packets whose destination ports fall between 1 and 200.
            /// *   If you enter two port numbers and one of them is -1, the other port number must also be -1. In this case, packets with all destination ports are matched.
            /// 
            /// You can create up to 50 traffic classification rules in each call. You can specify a destination port range for each traffic classification rule.
            /// </summary>
            [NameInMap("DstPortRange")]
            [Validation(Required=false)]
            public List<int?> DstPortRange { get; set; }

            /// <summary>
            /// The DSCP value that is used to match packets. Valid values: **0** to **63**.
            /// 
            /// The traffic classification rule matches the packets that contain the specified DSCP value. If you do not set this parameter, packets are considered a match regardless of the DSCP value.
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
            /// Valid values: **HTTP**, **HTTPS**, **TCP**, **UDP**, **SSH**, and **Telnet**. For more information, log on to the [Cloud Enterprise Network (CEN) console](https://cen.console.aliyun.com/cen/list).
            /// 
            /// You can create up to 50 traffic classification rules in each call. You can specify a protocol for each traffic classification rule.
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// The source CIDR block that is used to match packets.
            /// 
            /// The traffic classification rule matches the packets whose source IP addresses fall within the specified source CIDR block. If you do not set this parameter, packets with all source IP addresses are matched.
            /// 
            /// You can create up to 50 traffic classification rules in each call. You can specify a source CIDR block for each traffic classification rule.
            /// </summary>
            [NameInMap("SrcCidr")]
            [Validation(Required=false)]
            public string SrcCidr { get; set; }

            /// <summary>
            /// The source port range that is used to match packets. Valid values: **-1** and **1** to **65535**.
            /// 
            /// The traffic classification rule matches the packets whose source ports fall within the source port range. If you do not set this parameter, packets with all source ports are matched.
            /// 
            /// You can specify at most two ports. Take note of the following rules:
            /// 
            /// *   If you enter only one port number such as 1, the system matches the packets whose source port is 1.
            /// *   If you enter two port numbers such as 1 and 200, the system matches the packets whose source ports fall between 1 and 200.
            /// *   If you enter two port numbers and one of them is -1, the other port number must also be -1. In this case, packets with all source ports are matched.
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
            /// The description must be 2 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The description must start with a letter.
            /// </summary>
            [NameInMap("TrafficMatchRuleDescription")]
            [Validation(Required=false)]
            public string TrafficMatchRuleDescription { get; set; }

            /// <summary>
            /// The name of the traffic classification rule.
            /// 
            /// You can create up to 50 traffic classification rules in each call. You can specify a name for each traffic classification rule.
            /// 
            /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). It must start with a letter.
            /// </summary>
            [NameInMap("TrafficMatchRuleName")]
            [Validation(Required=false)]
            public string TrafficMatchRuleName { get; set; }

        }

        /// <summary>
        /// The ID of the transit router.
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}

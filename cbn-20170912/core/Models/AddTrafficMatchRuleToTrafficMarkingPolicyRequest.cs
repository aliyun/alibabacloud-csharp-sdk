// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class AddTrafficMatchRuleToTrafficMarkingPolicyRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters.
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

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the traffic marking policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TrafficMarkingPolicyId")]
        [Validation(Required=false)]
        public string TrafficMarkingPolicyId { get; set; }

        /// <summary>
        /// The traffic classification rules.
        /// 
        /// You can add at most 50 traffic classification rules in each call.
        /// </summary>
        [NameInMap("TrafficMatchRules")]
        [Validation(Required=false)]
        public List<AddTrafficMatchRuleToTrafficMarkingPolicyRequestTrafficMatchRules> TrafficMatchRules { get; set; }
        public class AddTrafficMatchRuleToTrafficMarkingPolicyRequestTrafficMatchRules : TeaModel {
            [NameInMap("AddressFamily")]
            [Validation(Required=false)]
            public string AddressFamily { get; set; }

            /// <summary>
            /// The destination CIDR block that is used to match packets.
            /// 
            /// Packets whose destination IP addresses fall into the specified destination CIDR block are considered a match. If you do not specify a destination CIDR block, packets are considered a match regardless of the destination IP address.
            /// </summary>
            [NameInMap("DstCidr")]
            [Validation(Required=false)]
            public string DstCidr { get; set; }

            /// <summary>
            /// The destination port range that is used to match packets. Valid values: **-1** and **1** to **65535**.
            /// 
            /// Packets whose destination ports fall into the specified destination port range are considered a match. If you do not specify destination port range, packets are considered a match regardless of the destination port.
            /// 
            /// You can specify at most two port numbers for this parameter. Take note of the following rules:
            /// 
            /// *   If you enter only one port number, such as 1, packets whose destination port is 1 are considered a match.
            /// *   If you enter two port numbers, such as 1 and 200, packets whose destination ports fall into 1 and 200 are considered a match.
            /// *   If you enter two port numbers and one of them is -1, the other port must also be -1. In this case, packets are considered a match regardless of the destination port.
            /// </summary>
            [NameInMap("DstPortRange")]
            [Validation(Required=false)]
            public List<int?> DstPortRange { get; set; }

            /// <summary>
            /// The Differentiated Services Code Point (DSCP) value that is used to match packets. Valid values: **0** to **63**.
            /// 
            /// Packets that carry the specified DSCP value are considered a match. If you do not specify a DSCP value, packets are considered a match regardless of the DSCP value.
            /// 
            /// >  The DSCP value that you specify for this parameter is the DSCP value that packets carry before they are transmitted over the inter-region connection.
            /// </summary>
            [NameInMap("MatchDscp")]
            [Validation(Required=false)]
            public int? MatchDscp { get; set; }

            /// <summary>
            /// The protocol that is used to match packets.
            /// 
            /// Traffic classification rules support the following protocols: **HTTP**, **HTTPS**, **TCP**, **UDP**, **SSH**, and **Telnet**. For more information, log on to the [Cloud Enterprise Network (CEN) console](https://cen.console.aliyun.com/cen/list).
            /// 
            /// **Some protocols use a specific port. Click to view protocols and ports.**
            /// 
            /// *   If the protocol is **ICMP**, set the destination port to **-1**.
            /// *   If the protocol is **GRE**, set the destination port to **-1**.
            /// *   If the protocol is **SSH**, set the destination port to **22**.
            /// *   If the protocol is **Telnet**, set the destination port to **23**.
            /// *   If the protocol is **HTTP**, set the destination port to **80**.
            /// *   If the protocol is **HTTPS**, set the destination port to **443**.
            /// *   If the protocol is **MS SQL**, set the destination port to **1443**.
            /// *   If the protocol is **Oracle**, set the destination port to **1521**.
            /// *   If the protocol is **Mysql**, set the destination port to **3306**.
            /// *   If the protocol is **RDP**, set the destination port to **3389**.
            /// *   If the protocol is **Postgre SQL**, set the destination port to **5432**.
            /// *   If the protocol is **Redis**, set the destination port to **6379**.
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// The source CIDR block that is used to match packets.
            /// 
            /// Packets whose source IP addresses fall into the specified source CIDR block are considered a match. If you do not specify a source CIDR block, packets are considered a match regardless of the source IP address.
            /// </summary>
            [NameInMap("SrcCidr")]
            [Validation(Required=false)]
            public string SrcCidr { get; set; }

            /// <summary>
            /// The source port range that is used to match packets. Valid values: **-1** and **1** to **65535**.
            /// 
            /// Packets whose source ports fall into the specified source port range are considered a match. If you do not specify a source port range, packets are considered a match regardless of the source port.
            /// 
            /// You can enter at most two port numbers. Take note of the following rules:
            /// 
            /// *   If you enter only one port number, such as 1, packets whose source port is 1 are considered a match.
            /// *   If you enter two port numbers, such as 1 and 200, packets whose source ports fall into 1 and 200 are considered a match.
            /// *   If you enter two port numbers and one of them is -1, the other port number must also be -1. In this case, packets are considered a match regardless of the source port.
            /// </summary>
            [NameInMap("SrcPortRange")]
            [Validation(Required=false)]
            public List<int?> SrcPortRange { get; set; }

            /// <summary>
            /// The description of the traffic classification rule.
            /// 
            /// This parameter is optional. If you enter a description, it must be 1 to 256 characters in length, and cannot start with http:// or https://.
            /// </summary>
            [NameInMap("TrafficMatchRuleDescription")]
            [Validation(Required=false)]
            public string TrafficMatchRuleDescription { get; set; }

            /// <summary>
            /// The name of the traffic classification rule.
            /// 
            /// The name can be empty or 1 to 128 characters in length, and cannot start with http:// or https://.
            /// </summary>
            [NameInMap("TrafficMatchRuleName")]
            [Validation(Required=false)]
            public string TrafficMatchRuleName { get; set; }

        }

    }

}

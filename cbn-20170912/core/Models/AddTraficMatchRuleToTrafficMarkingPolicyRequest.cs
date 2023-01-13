// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class AddTraficMatchRuleToTrafficMarkingPolicyRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. 
        /// 
        /// You can use the client to generate the value, but you must ensure that it is unique among all requests. The token can contain only ASCII characters.  
        /// 
        /// >  If you do not set this parameter, ClientToken is set to the value of RequestId. The value of RequestId for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether only to precheck the request. Valid values:
        /// 
        /// - **true**: prechecks the request but does not add the traffic classification rule. The system checks the required parameters, the request format, and the service limits. If the request fails to pass the precheck, an error message is returned. If the request passes the precheck, the `DryRunOperation` error code is returned.
        /// - **false** (default): sends the request. If the request passes the precheck, the traffic classification rule is added.
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
        /// </summary>
        [NameInMap("TrafficMarkingPolicyId")]
        [Validation(Required=false)]
        public string TrafficMarkingPolicyId { get; set; }

        [NameInMap("TrafficMatchRules")]
        [Validation(Required=false)]
        public List<AddTraficMatchRuleToTrafficMarkingPolicyRequestTrafficMatchRules> TrafficMatchRules { get; set; }
        public class AddTraficMatchRuleToTrafficMarkingPolicyRequestTrafficMatchRules : TeaModel {
            /// <summary>
            /// The destination CIDR block that is used to match packets. 
            /// 
            /// The traffic classification rule matches the packets whose destination IP addresses fall within the specified destination CIDR block. If you do not set this parameter, packets are considered a match regardless of the DSCP value.  
            /// 
            /// You can specify at most 50 traffic classification rules.
            /// </summary>
            [NameInMap("DstCidr")]
            [Validation(Required=false)]
            public string DstCidr { get; set; }

            [NameInMap("DstPortRange")]
            [Validation(Required=false)]
            public List<int?> DstPortRange { get; set; }

            /// <summary>
            /// The differentiated services code point (DSCP) value that is used to match packets. Valid values: **0** to **63**.  
            /// 
            /// The traffic classification rule matches the packets that contain the specified DSCP value. If you do not set this parameter, packets are considered a match regardless of the DSCP value.  
            /// 
            /// >  The DSCP value that you specify for this parameter is the DSCP value that packets carry before they are transmitted over the inter-region connection.  You can specify at most 50 traffic classification rules.
            /// </summary>
            [NameInMap("MatchDscp")]
            [Validation(Required=false)]
            public int? MatchDscp { get; set; }

            /// <summary>
            /// The protocol used to match data packets. 
            /// 
            /// Valid values: **HTTP**, **HTTPS**, **TCP**, **UDP**, **SSH**, and **Telnet**. For more information, log on to the [Cloud Enterprise Network (CEN) console](https://cen.console.aliyun.com/cen/list).  
            /// 
            /// You can specify at most 50 traffic classification rules.
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// The source CIDR block that is used to match packets. 
            /// 
            /// The traffic classification rule matches the packets whose source IP addresses fall within the specified source CIDR block. If you do not set this parameter, packets are considered a match regardless of the source IP address.  
            /// 
            /// You can specify at most 50 traffic classification rules.
            /// </summary>
            [NameInMap("SrcCidr")]
            [Validation(Required=false)]
            public string SrcCidr { get; set; }

            [NameInMap("SrcPortRange")]
            [Validation(Required=false)]
            public List<int?> SrcPortRange { get; set; }

            /// <summary>
            /// The description of the traffic classification rule. 
            /// 
            /// The description must be 2 to 128 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The description must start with a letter.  
            /// 
            /// You can specify at most 50 traffic classification rules.
            /// </summary>
            [NameInMap("TrafficMatchRuleDescription")]
            [Validation(Required=false)]
            public string TrafficMatchRuleDescription { get; set; }

            /// <summary>
            /// The name of the traffic classification rule. 
            /// 
            /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). It must start with a letter.  
            /// 
            /// You can specify at most 50 traffic classification rules.
            /// </summary>
            [NameInMap("TrafficMatchRuleName")]
            [Validation(Required=false)]
            public string TrafficMatchRuleName { get; set; }

        }

    }

}

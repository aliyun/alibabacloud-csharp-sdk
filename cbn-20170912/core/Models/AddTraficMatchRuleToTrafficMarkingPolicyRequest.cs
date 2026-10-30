// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class AddTraficMatchRuleToTrafficMarkingPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate a parameter value on your client to ensure that the value is unique across different requests. The ClientToken parameter supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prechecks the request without adding the traffic classification rule to the traffic marking policy. The system checks whether required parameters are specified, the request format is valid, and service limits are met. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends the request. If the request passes the precheck, the traffic classification rule is added to the traffic marking policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
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
        /// <para>The ID of the traffic marking policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tm-u9nxup5kww5po8****</para>
        /// </summary>
        [NameInMap("TrafficMarkingPolicyId")]
        [Validation(Required=false)]
        public string TrafficMarkingPolicyId { get; set; }

        /// <summary>
        /// <para>The list of traffic classification rules.</para>
        /// <para>You can add up to 50 traffic classification rules at a time.</para>
        /// </summary>
        [NameInMap("TrafficMatchRules")]
        [Validation(Required=false)]
        public List<AddTraficMatchRuleToTrafficMarkingPolicyRequestTrafficMatchRules> TrafficMatchRules { get; set; }
        public class AddTraficMatchRuleToTrafficMarkingPolicyRequestTrafficMatchRules : TeaModel {
            /// <summary>
            /// <para>The destination CIDR block of the traffic packet.</para>
            /// <para>The traffic classification rule matches traffic whose destination IP address falls within the destination CIDR block. If you do not specify this parameter, the traffic classification rule matches traffic with any destination IP address.</para>
            /// <para>You can add up to 50 traffic classification rules at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.10.0/24</para>
            /// </summary>
            [NameInMap("DstCidr")]
            [Validation(Required=false)]
            public string DstCidr { get; set; }

            /// <summary>
            /// <para>The destination port of the traffic packet. Valid values: <b>-1</b> and <b>1</b> to <b>65535</b>.</para>
            /// <para>The traffic classification rule matches traffic whose destination port number falls within the destination port range. If you do not specify this parameter, the traffic classification rule matches traffic with any destination port number.</para>
            /// <para>You can enter up to two port numbers for this parameter. The input format is described as follows:</para>
            /// <list type="bullet">
            /// <item><description>If you enter only one port number, such as 1, the system matches traffic whose destination port is 1 by default.</description></item>
            /// <item><description>If you enter two port numbers, such as 1 and 200, the system matches traffic whose destination port is in the range of 1 to 200 by default.</description></item>
            /// <item><description>If you enter two port numbers and one of them is -1, the other port number must also be -1, which indicates that traffic with any destination port is matched.</description></item>
            /// </list>
            /// <para>You can add up to 50 traffic classification rules at a time.</para>
            /// </summary>
            [NameInMap("DstPortRange")]
            [Validation(Required=false)]
            public List<int?> DstPortRange { get; set; }

            /// <summary>
            /// <para>The Differentiated Services Code Point (DSCP) value of the traffic packet. Valid values: <b>0</b> to <b>63</b>.</para>
            /// <para>The traffic classification rule matches traffic that contains the specified DSCP value. If you do not specify this parameter, the traffic classification rule matches traffic with any DSCP value.</para>
            /// <remarks>
            /// <para>The DSCP value refers to the DSCP value carried by the traffic packet before it enters the inter-region connection.</para>
            /// </remarks>
            /// <para>You can add up to 50 traffic classification rules at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MatchDscp")]
            [Validation(Required=false)]
            public int? MatchDscp { get; set; }

            /// <summary>
            /// <para>The protocol type of the traffic packet.</para>
            /// <para>The traffic classification rule supports matching traffic of various protocol types, such as <b>HTTP</b>, <b>HTTPS</b>, <b>TCP</b>, <b>UDP</b>, <b>SSH</b>, and <b>Telnet</b>. For more protocol types, log on to the <a href="https://cen.console.aliyun.com/cen/list">Cloud Enterprise Network (CEN) console</a>.</para>
            /// <para>You can add up to 50 traffic classification rules at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The source CIDR block of the traffic packet.</para>
            /// <para>The traffic classification rule matches traffic whose source IP address falls within the source CIDR block. If you do not specify this parameter, the traffic classification rule matches traffic with any source IP address.</para>
            /// <para>You can add up to 50 traffic classification rules at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.10.0/24</para>
            /// </summary>
            [NameInMap("SrcCidr")]
            [Validation(Required=false)]
            public string SrcCidr { get; set; }

            /// <summary>
            /// <para>The source port of the traffic packet. Valid values: <b>-1</b> and <b>1</b> to <b>65535</b>.</para>
            /// <para>The traffic classification rule matches traffic whose source port number falls within the source port range. If you do not specify this parameter, the traffic classification rule matches traffic with any source port number.</para>
            /// <para>You can enter up to two port numbers for this parameter. The input format is described as follows:</para>
            /// <list type="bullet">
            /// <item><description>If you enter only one port number, such as 1, the system matches traffic whose source port is 1 by default.</description></item>
            /// <item><description>If you enter two port numbers, such as 1 and 200, the system matches traffic whose source port is in the range of 1 to 200 by default.</description></item>
            /// <item><description>If you enter two port numbers and one of them is -1, the other port number must also be -1, which indicates that traffic with any source port is matched.</description></item>
            /// </list>
            /// <para>You can add up to 50 traffic classification rules at a time.</para>
            /// </summary>
            [NameInMap("SrcPortRange")]
            [Validation(Required=false)]
            public List<int?> SrcPortRange { get; set; }

            /// <summary>
            /// <para>The description of the traffic classification rule.</para>
            /// <para>You can add up to 50 traffic classification rules at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desctest</para>
            /// </summary>
            [NameInMap("TrafficMatchRuleDescription")]
            [Validation(Required=false)]
            public string TrafficMatchRuleDescription { get; set; }

            /// <summary>
            /// <para>The name of the traffic classification rule.</para>
            /// <para>You can add up to 50 traffic classification rules at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nametest</para>
            /// </summary>
            [NameInMap("TrafficMatchRuleName")]
            [Validation(Required=false)]
            public string TrafficMatchRuleName { get; set; }

        }

    }

}

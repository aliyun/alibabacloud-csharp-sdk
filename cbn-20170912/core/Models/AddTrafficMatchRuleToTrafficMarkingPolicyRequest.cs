// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class AddTrafficMatchRuleToTrafficMarkingPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the request passes the dry run, traffic classification rules are added to the traffic marking policy.</description></item>
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
        public List<AddTrafficMatchRuleToTrafficMarkingPolicyRequestTrafficMatchRules> TrafficMatchRules { get; set; }
        public class AddTrafficMatchRuleToTrafficMarkingPolicyRequestTrafficMatchRules : TeaModel {
            /// <summary>
            /// <para>The address type. Valid values: IPv4, IPv6, or empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("AddressFamily")]
            [Validation(Required=false)]
            public string AddressFamily { get; set; }

            /// <summary>
            /// <para>The destination CIDR block of the traffic packet.</para>
            /// <para>The traffic classification rule matches traffic whose destination IP address falls within the destination CIDR block. If you do not specify this parameter, the traffic classification rule matches traffic with any destination IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.10.0/24</para>
            /// </summary>
            [NameInMap("DstCidr")]
            [Validation(Required=false)]
            public string DstCidr { get; set; }

            /// <summary>
            /// <para>The destination port of the traffic packet. Valid values: <b>-1</b> and <b>1</b> to <b>65535</b>.</para>
            /// <para>The traffic classification rule matches traffic whose destination port falls within the destination port range. If you do not specify this parameter, the traffic classification rule matches traffic with any destination port.</para>
            /// <para>You can specify up to 2 port numbers for this parameter. The input format is described as follows:</para>
            /// <list type="bullet">
            /// <item><description>If you specify only one port number, for example, 1, the system matches traffic whose destination port is 1. If the value is -1, the system matches traffic with any destination port.</description></item>
            /// <item><description>If you specify two port numbers, for example, 1 and 200, the system matches traffic whose destination port is in the range of 1 to 200.</description></item>
            /// <item><description>If you specify two port numbers and one of them is -1, the other port number must also be -1, which indicates that traffic with any destination port is matched.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("DstPortRange")]
            [Validation(Required=false)]
            public List<int?> DstPortRange { get; set; }

            /// <summary>
            /// <para>The Differentiated Services Code Point (DSCP) value of the traffic packet. Valid values: <b>0</b> to <b>63</b>.</para>
            /// <para>The traffic classification rule matches traffic that contains the specified DSCP value. If you do not specify this parameter, the traffic classification rule matches traffic with any DSCP value.</para>
            /// <remarks>
            /// <para>The DSCP value refers to the DSCP value that the traffic packet already carries before it enters the inter-region connection.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MatchDscp")]
            [Validation(Required=false)]
            public int? MatchDscp { get; set; }

            /// <summary>
            /// <para>The protocol type of the traffic packet.</para>
            /// <para>The traffic classification rule supports matching traffic of multiple protocol types, such as <b>HTTP</b>, <b>HTTPS</b>, <b>TCP</b>, <b>UDP</b>, <b>SSH</b>, and <b>Telnet</b>. For more protocol types, log on to the <a href="https://cen.console.aliyun.com/cen/list">Cloud Enterprise Network (CEN) console</a>.</para>
            /// <details>
            /// <summary>Some protocols have fixed ports. Click to view port details.</summary>
            /// 
            /// <list type="bullet">
            /// <item><description>If the protocol type is <b>ICMP</b>, the destination port must be set to <b>-1</b>.</description></item>
            /// <item><description>If the protocol type is <b>GRE</b>, the destination port must be set to <b>-1</b>.</description></item>
            /// <item><description>If the protocol type is <b>SSH</b>, the destination port must be set to <b>22</b>.</description></item>
            /// <item><description>If the protocol type is <b>Telnet</b>, the destination port must be set to <b>23</b>.</description></item>
            /// <item><description>If the protocol type is <b>HTTP</b>, the destination port must be set to <b>80</b>.</description></item>
            /// <item><description>If the protocol type is <b>HTTPS</b>, the destination port must be set to <b>443</b>.</description></item>
            /// <item><description>If the protocol type is <b>MS SQL</b>, the destination port must be set to <b>1443</b>.</description></item>
            /// <item><description>If the protocol type is <b>Oracle</b>, the destination port must be set to <b>1521</b>.</description></item>
            /// <item><description>If the protocol type is <b>Mysql</b>, the destination port must be set to <b>3306</b>.</description></item>
            /// <item><description>If the protocol type is <b>RDP</b>, the destination port must be set to <b>3389</b>.</description></item>
            /// <item><description>If the protocol type is <b>Postgre SQL</b>, the destination port must be set to <b>5432</b>.</description></item>
            /// <item><description>If the protocol type is <b>Redis</b>, the destination port must be set to <b>6379</b>.</description></item>
            /// </list>
            /// </details>
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
            /// 
            /// <b>Example:</b>
            /// <para>192.168.10.0/24</para>
            /// </summary>
            [NameInMap("SrcCidr")]
            [Validation(Required=false)]
            public string SrcCidr { get; set; }

            /// <summary>
            /// <para>The source port of the traffic packet. Valid values: <b>-1</b> and <b>1</b> to <b>65535</b>.</para>
            /// <para>The traffic classification rule matches traffic whose source port falls within the source port range. If you do not specify this parameter, the traffic classification rule matches traffic with any source port.</para>
            /// <para>You can specify up to two port numbers for this parameter. The input format is described as follows:</para>
            /// <list type="bullet">
            /// <item><description>If you specify only one port number, for example, 1, the system matches traffic whose source port is 1. If the value is -1, the system matches traffic with any source port.</description></item>
            /// <item><description>If you specify two port numbers, for example, 1 and 200, the system matches traffic whose source port is in the range of 1 to 200.</description></item>
            /// <item><description>If you specify two port numbers and one of them is -1, the other port number must also be -1, which indicates that traffic with any source port is matched.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("SrcPortRange")]
            [Validation(Required=false)]
            public List<int?> SrcPortRange { get; set; }

            /// <summary>
            /// <para>The description of the traffic classification rule.</para>
            /// <para>The description can be empty or 1 to 256 characters in length and cannot start with http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desctest</para>
            /// </summary>
            [NameInMap("TrafficMatchRuleDescription")]
            [Validation(Required=false)]
            public string TrafficMatchRuleDescription { get; set; }

            /// <summary>
            /// <para>The name of the traffic classification rule.</para>
            /// <para>The name can be empty or 1 to 128 characters in length and cannot start with http:// or https://.</para>
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

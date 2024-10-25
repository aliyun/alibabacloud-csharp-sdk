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
        /// <para>You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not set this parameter, <b>ClientToken</b> is set to the value of <b>RequestId</b>. The value of <b>RequestId</b> for each API request may be different.</para>
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
        /// <item><description><b>true</b>: performs a dry run. The system checks the required parameters, request format, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request.</description></item>
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
        /// <para>The traffic classification rules.</para>
        /// <para>You can add at most 50 traffic classification rules in each call.</para>
        /// </summary>
        [NameInMap("TrafficMatchRules")]
        [Validation(Required=false)]
        public List<AddTrafficMatchRuleToTrafficMarkingPolicyRequestTrafficMatchRules> TrafficMatchRules { get; set; }
        public class AddTrafficMatchRuleToTrafficMarkingPolicyRequestTrafficMatchRules : TeaModel {
            /// <summary>
            /// <para>The address family. You can set the value to IPv4 or IPv6, or leave the value empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("AddressFamily")]
            [Validation(Required=false)]
            public string AddressFamily { get; set; }

            /// <summary>
            /// <para>The destination CIDR block that is used to match packets.</para>
            /// <para>Packets whose destination IP addresses fall into the specified destination CIDR block are considered a match. If you do not specify a destination CIDR block, packets are considered a match regardless of the destination IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.10.0/24</para>
            /// </summary>
            [NameInMap("DstCidr")]
            [Validation(Required=false)]
            public string DstCidr { get; set; }

            /// <summary>
            /// <para>The destination port range that is used to match packets. Valid values: <b>-1</b> and <b>1</b> to <b>65535</b>.</para>
            /// <para>Packets whose destination ports fall into the specified destination port range are considered a match. If you do not specify destination port range, packets are considered a match regardless of the destination port.</para>
            /// <para>You can specify at most two port numbers for this parameter. Take note of the following rules:</para>
            /// <list type="bullet">
            /// <item><description>If you enter only one port number, such as 1, packets whose destination port is 1 are considered a match. A value of -1 specifies all destination ports.</description></item>
            /// <item><description>If you enter two port numbers, such as 1 and 200, packets whose destination ports fall into 1 and 200 are considered a match.</description></item>
            /// <item><description>If you enter two port numbers and one of them is -1, the other port must also be -1. In this case, packets are considered a match regardless of the destination port.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("DstPortRange")]
            [Validation(Required=false)]
            public List<int?> DstPortRange { get; set; }

            /// <summary>
            /// <para>The Differentiated Services Code Point (DSCP) value that is used to match packets. Valid values: <b>0</b> to <b>63</b>.</para>
            /// <para>Packets that carry the specified DSCP value are considered a match. If you do not specify a DSCP value, packets are considered a match regardless of the DSCP value.</para>
            /// <remarks>
            /// <para> The DSCP value that you specify for this parameter is the DSCP value that packets carry before they are transmitted over the inter-region connection.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MatchDscp")]
            [Validation(Required=false)]
            public int? MatchDscp { get; set; }

            /// <summary>
            /// <para>The protocol that is used to match packets.</para>
            /// <para>Traffic classification rules support the following protocols: <b>HTTP</b>, <b>HTTPS</b>, <b>TCP</b>, <b>UDP</b>, <b>SSH</b>, and <b>Telnet</b>. For more information, log on to the <a href="https://cen.console.aliyun.com/cen/list">Cloud Enterprise Network (CEN) console</a>.</para>
            /// <para><b>Some protocols use a specific port. Click to view protocols and ports.</b></para>
            /// <list type="bullet">
            /// <item><description>If the protocol is <b>ICMP</b>, set the destination port to <b>-1</b>.</description></item>
            /// <item><description>If the protocol is <b>GRE</b>, set the destination port to <b>-1</b>.</description></item>
            /// <item><description>If the protocol is <b>SSH</b>, set the destination port to <b>22</b>.</description></item>
            /// <item><description>If the protocol is <b>Telnet</b>, set the destination port to <b>23</b>.</description></item>
            /// <item><description>If the protocol is <b>HTTP</b>, set the destination port to <b>80</b>.</description></item>
            /// <item><description>If the protocol is <b>HTTPS</b>, set the destination port to <b>443</b>.</description></item>
            /// <item><description>If the protocol is <b>MS SQL</b>, set the destination port to <b>1443</b>.</description></item>
            /// <item><description>If the protocol is <b>Oracle</b>, set the destination port to <b>1521</b>.</description></item>
            /// <item><description>If the protocol is <b>Mysql</b>, set the destination port to <b>3306</b>.</description></item>
            /// <item><description>If the protocol is <b>RDP</b>, set the destination port to <b>3389</b>.</description></item>
            /// <item><description>If the protocol is <b>Postgre SQL</b>, set the destination port to <b>5432</b>.</description></item>
            /// <item><description>If the protocol is <b>Redis</b>, set the destination port to <b>6379</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The source CIDR block that is used to match packets.</para>
            /// <para>Packets whose source IP addresses fall into the specified source CIDR block are considered a match. If you do not specify a source CIDR block, packets are considered a match regardless of the source IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.10.0/24</para>
            /// </summary>
            [NameInMap("SrcCidr")]
            [Validation(Required=false)]
            public string SrcCidr { get; set; }

            /// <summary>
            /// <para>The source port range that is used to match packets. Valid values: <b>-1</b> and <b>1</b> to <b>65535</b>.</para>
            /// <para>Packets whose source ports fall into the specified source port range are considered a match. If you do not specify a source port range, packets are considered a match regardless of the source port.</para>
            /// <para>You can enter at most two port numbers. Take note of the following rules:</para>
            /// <list type="bullet">
            /// <item><description>If you enter only one port number, such as 1, packets whose source port is 1 are considered a match. A value of -1 specifies all source ports.</description></item>
            /// <item><description>If you enter two port numbers, such as 1 and 200, packets whose source ports fall into 1 and 200 are considered a match.</description></item>
            /// <item><description>If you enter two port numbers and one of them is -1, the other port number must also be -1. In this case, packets are considered a match regardless of the source port.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("SrcPortRange")]
            [Validation(Required=false)]
            public List<int?> SrcPortRange { get; set; }

            /// <summary>
            /// <para>The description of the traffic classification rule.</para>
            /// <para>This parameter is optional. If you enter a description, it must be 1 to 256 characters in length, and cannot start with http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desctest</para>
            /// </summary>
            [NameInMap("TrafficMatchRuleDescription")]
            [Validation(Required=false)]
            public string TrafficMatchRuleDescription { get; set; }

            /// <summary>
            /// <para>The name of the traffic classification rule.</para>
            /// <para>The name is optional. If you enter a name, it must be 1 to 128 characters in length, and cannot start with http:// or https://.</para>
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

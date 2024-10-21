// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTrafficMarkingPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must make sure that it is unique among all requests. The client token can contain only ASCII characters.</para>
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

        /// <summary>
        /// <para>The differentiated services code point (DSCP) value to be added to packets that match the traffic classification rule. Valid values: <b>0</b> to <b>63</b>.</para>
        /// <para>The DSCP value of each traffic marking policy on a transit router must be unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
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
        /// <para>The priority value of the traffic marking policy. Valid values: <b>1</b> to <b>100</b>.</para>
        /// <para>The priority value of each traffic marking policy on a transit router must be unique. A smaller value specifies a higher priority.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
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
        /// <para>The description of the traffic marking policy.</para>
        /// <para>This parameter is optional. If you enter a description, it must be 1 to 256 characters in length, and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("TrafficMarkingPolicyDescription")]
        [Validation(Required=false)]
        public string TrafficMarkingPolicyDescription { get; set; }

        /// <summary>
        /// <para>The name of the traffic marking policy.</para>
        /// <para>The name can be empty or 1 to 128 characters in length, and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("TrafficMarkingPolicyName")]
        [Validation(Required=false)]
        public string TrafficMarkingPolicyName { get; set; }

        /// <summary>
        /// <para>The traffic classification rules in the traffic marking policy.</para>
        /// <para>Data packets that meet the traffic classification rule is assigned the DSCP value of quality of service (QoS) policy.</para>
        /// <para>You can create up to 50 traffic classification rules.</para>
        /// </summary>
        [NameInMap("TrafficMatchRules")]
        [Validation(Required=false)]
        public List<CreateTrafficMarkingPolicyRequestTrafficMatchRules> TrafficMatchRules { get; set; }
        public class CreateTrafficMarkingPolicyRequestTrafficMatchRules : TeaModel {
            [NameInMap("AddressFamily")]
            [Validation(Required=false)]
            public string AddressFamily { get; set; }

            /// <summary>
            /// <para>The destination CIDR block that is used to match packets.</para>
            /// <para>Packets whose destination IP addresses fall into the specified destination CIDR block meet the traffic classification rule. If you do not specify a destination CIDR block, all packets meet the traffic classification rule.</para>
            /// <para>You can create up to 50 traffic classification rules in each call You can specify a destination CIDR block for each traffic classification rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.10.0/24</para>
            /// </summary>
            [NameInMap("DstCidr")]
            [Validation(Required=false)]
            public string DstCidr { get; set; }

            /// <summary>
            /// <para>The destination port range that is used to match packets. Valid values: <b>-1</b> and <b>1</b> to <b>65535</b>.</para>
            /// <para>Packets whose destination ports fall within the destination port range meet the traffic classification rule. If you do not specify destination port range, all packets meet the traffic classification rule.</para>
            /// <para>You can enter up to two port numbers. Take note of the following rules:</para>
            /// <list type="bullet">
            /// <item><description>If you enter only one port number, such as 1, packets whose destination port is 1 meet the traffic classification rule.</description></item>
            /// <item><description>If you enter two port numbers, such as 1 and 200, packets whose destination ports fall into 1 and 200 meet the traffic classification rule.</description></item>
            /// <item><description>If you enter two port numbers and one of them is -1, the other port number must also be -1. In this case, all packets meet the traffic classification rule.</description></item>
            /// </list>
            /// <para>You can create up to 50 traffic classification rules in each call. You can specify a destination port range for each traffic classification rule.</para>
            /// </summary>
            [NameInMap("DstPortRange")]
            [Validation(Required=false)]
            public List<int?> DstPortRange { get; set; }

            /// <summary>
            /// <para>The DSCP value that is used to match packets. Valid values: <b>0</b> to <b>63</b>.</para>
            /// <para>Packets that carry the specified DSCP value meet the traffic classification rule. If you do not specify a DSCP value, all packets meet the traffic classification rule.</para>
            /// <remarks>
            /// <para> The DSCP value that you specify for this parameter is the DSCP value that packets carry before they are transmitted over the inter-region connection.</para>
            /// </remarks>
            /// <para>You can create up to 50 traffic classification rules in each call. You can specify a DSCP value for each traffic classification rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("MatchDscp")]
            [Validation(Required=false)]
            public int? MatchDscp { get; set; }

            /// <summary>
            /// <para>The protocol that is used to match packets.</para>
            /// <para>Traffic classification rules support the following protocols: <b>HTTP</b>, <b>HTTPS</b>, <b>TCP</b>, <b>UDP</b>, <b>SSH</b>, and <b>Telnet</b>. For more information, log on to the <a href="https://cen.console.aliyun.com/cen/list">CEN console</a>.</para>
            /// <para><b>Some protocols use a fixed port. Click to view protocols and ports.</b></para>
            /// <list type="bullet">
            /// <item><description>If the protocol is <b>ICMP</b>, the destination port must be <b>-1</b>.</description></item>
            /// <item><description>If the protocol is <b>GRE</b>, the destination port must be <b>1</b>.</description></item>
            /// <item><description>If the protocol is <b>SSH</b>, the destination port must be <b>22</b>.</description></item>
            /// <item><description>If the protocol is <b>Telnet</b>, the destination port must be <b>23</b>.</description></item>
            /// <item><description>If the protocol is <b>HTTP</b>, the destination port must be <b>80</b>.</description></item>
            /// <item><description>If the protocol is <b>HTTPS</b>, the destination port must be <b>443</b>.</description></item>
            /// <item><description>If the protocol is <b>MS SQL</b>, the destination port must be <b>1443</b>.</description></item>
            /// <item><description>If the protocol is <b>Oracle</b>, the destination port must be <b>1521</b>.</description></item>
            /// <item><description>If the protocol is <b>Mysql</b>, the destination port must be <b>3306</b>.</description></item>
            /// <item><description>If the protocol is <b>RDP</b>, the destination port must be <b>3389</b>.</description></item>
            /// <item><description>If the protocol is <b>Postgre SQL</b>, the destination port must be <b>5432</b>.</description></item>
            /// <item><description>If the protocol is <b>Redis</b>, the destination port must be <b>6379</b>.</description></item>
            /// </list>
            /// <para>You can create up to 50 traffic classification rules in each call. You can specify a protocol for each traffic classification rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The source CIDR block that is used to match packets.</para>
            /// <para>Packets whose source IP addresses fall into the specified source CIDR block meet the traffic classification rule. If you do not specify a source CIDR block, all packets meet the traffic classification rule.</para>
            /// <para>You can create up to 50 traffic classification rules in each call. You can specify a source CIDR block for each traffic classification rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.10.0/24</para>
            /// </summary>
            [NameInMap("SrcCidr")]
            [Validation(Required=false)]
            public string SrcCidr { get; set; }

            /// <summary>
            /// <para>The source port range that is used to match packets. Valid values: <b>-1</b> and <b>1</b> to <b>65535</b>.</para>
            /// <para>Packets whose source ports fall into the source port range meet the traffic classification rule. If you do not specify a source port range, all packets meet the traffic classification rule.</para>
            /// <para>You can enter up to two port numbers. Take note of the following rules:</para>
            /// <list type="bullet">
            /// <item><description>If you enter only one port number, such as 1, packets whose source port is 1 meet the traffic classification rule.</description></item>
            /// <item><description>If you enter two port numbers, such as 1 and 200, packets whose source ports fall into 1 and 200 meet the traffic classification rule.</description></item>
            /// <item><description>If you enter two port numbers and one of them is -1, the other port number must also be -1. In this case, all packets meet the traffic classification rule.</description></item>
            /// </list>
            /// <para>You can create up to 50 traffic classification rules in each call. You can specify a source port range for each traffic classification rule.</para>
            /// </summary>
            [NameInMap("SrcPortRange")]
            [Validation(Required=false)]
            public List<int?> SrcPortRange { get; set; }

            /// <summary>
            /// <para>The description of the traffic classification rule.</para>
            /// <para>You can create up to 50 traffic classification rules in each call. You can specify a description for each traffic classification rule.</para>
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
            /// <para>You can create up to 50 traffic classification rules in each call. You can specify a name for each traffic classification rule.</para>
            /// <para>The name can be empty or 1 to 128 characters in length, and cannot start with http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nametest</para>
            /// </summary>
            [NameInMap("TrafficMatchRuleName")]
            [Validation(Required=false)]
            public string TrafficMatchRuleName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the transit router.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-8vbuqeo5h5pu3m01d****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}

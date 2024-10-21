// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class UpdateTrafficMarkingPolicyAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The traffic classification rules to be added to the traffic marking policy.</para>
        /// <para>You can add at most 50 traffic classification rules in each call.</para>
        /// </summary>
        [NameInMap("AddTrafficMatchRules")]
        [Validation(Required=false)]
        public List<UpdateTrafficMarkingPolicyAttributeRequestAddTrafficMatchRules> AddTrafficMatchRules { get; set; }
        public class UpdateTrafficMarkingPolicyAttributeRequestAddTrafficMatchRules : TeaModel {
            [NameInMap("AddressFamily")]
            [Validation(Required=false)]
            public string AddressFamily { get; set; }

            /// <summary>
            /// <para>The destination CIDR block that is used to match packets.</para>
            /// <para>Packets whose destination IP addresses fall into the specified destination CIDR block meet the traffic classification rule. If you do not specify a destination CIDR block, all packets meet the traffic classification rule.</para>
            /// <para>You can create up to 50 traffic classification rules in each call. You can specify a destination CIDR block for each traffic classification rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.30.0.0/24</para>
            /// </summary>
            [NameInMap("DstCidr")]
            [Validation(Required=false)]
            public string DstCidr { get; set; }

            /// <summary>
            /// <para>The destination port range that is used to match packets. Valid values: <b>-1</b> and <b>1</b> to <b>65535</b>.</para>
            /// <para>Packets whose destination ports fall within the specified destination port range are considered a match. If you do not specify a destination port range, packets are considered a match regardless of the destination port.</para>
            /// <para>You can enter up to two port numbers. Take note of the following rules:</para>
            /// <list type="bullet">
            /// <item><description>If you enter only one port number, such as 1, packets whose destination port is 1 match the traffic classification rule. A value of -1 specifies all destination ports.</description></item>
            /// <item><description>If you enter two port numbers, such as 1 and 200, packets whose destination ports fall into 1 and 200 are considered a match.</description></item>
            /// <item><description>If you enter two port numbers and one of them is -1, the other port number must also be -1. In this case, all packets meet the traffic classification rule.</description></item>
            /// </list>
            /// <para>You can create up to 50 traffic classification rules in each call. You can specify a destination port range for each traffic classification rule.</para>
            /// </summary>
            [NameInMap("DstPortRange")]
            [Validation(Required=false)]
            public List<int?> DstPortRange { get; set; }

            /// <summary>
            /// <para>The Differentiated Service Code Point (DSCP) value that is used to match packets. Valid values: <b>0</b> to <b>63</b>.</para>
            /// <para>Requests that carry the specified DSCP value are considered a match. If you do not specify a DSCP value, packets are considered a match regardless of the DSCP value.</para>
            /// <remarks>
            /// <para> The DSCP value that you specify for this parameter is the DSCP value that packets carry before they are transmitted over the inter-region connection.</para>
            /// </remarks>
            /// <para>You can create up to 50 traffic classification rules in each call. You can specify a DSCP value for each traffic classification rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MatchDscp")]
            [Validation(Required=false)]
            public int? MatchDscp { get; set; }

            /// <summary>
            /// <para>The protocol that is used to match packets.</para>
            /// <para>Traffic classification rules support the following protocols: <b>HTTP</b>, <b>HTTPS</b>, <b>TCP</b>, <b>UDP</b>, <b>SSH</b>, and <b>Telnet</b>. For more information, log on to the <a href="https://cen.console.aliyun.com/cen/list">CEN console</a>.</para>
            /// <para><b>Some protocols use a fixed port. Click to view the protocols and ports.</b></para>
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
            /// <item><description>If the protocol is <b>Redis</b>, the destination port must be <b>6379</b>.</description></item>
            /// </list>
            /// <para>You can create up to 50 traffic classification rules in each call. You can specify a protocol for each traffic classification rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UDP</para>
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
            /// <para>10.128.32.0/19</para>
            /// </summary>
            [NameInMap("SrcCidr")]
            [Validation(Required=false)]
            public string SrcCidr { get; set; }

            /// <summary>
            /// <para>The source port range that is used to match packets. Valid values: <b>-1</b> and <b>1</b> to <b>65535</b>.</para>
            /// <para>The traffic classification rule matches the packets whose source ports fall within the source port range. If you do not specify this parameter, packets are considered a match regardless of the source port.</para>
            /// <para>You can enter up to two port numbers. Take note of the following rules:</para>
            /// <list type="bullet">
            /// <item><description>If you enter only one port number, such as 1, packets whose source port is 1 are considered a match. A value of -1 specifies all source ports.</description></item>
            /// <item><description>If you enter two port numbers, such as 1 and 200, packets whose source ports fall into 1 and 200 are considered a match.</description></item>
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
            /// <para>This parameter is optional. If you enter a description, it must be 1 to 256 characters in length and cannot start with http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
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
            /// <para>Guangzhou Testing</para>
            /// </summary>
            [NameInMap("TrafficMatchRuleName")]
            [Validation(Required=false)]
            public string TrafficMatchRuleName { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The traffic classification rules to be deleted from the traffic marking policy.</para>
        /// <remarks>
        /// <para> Specify detailed information about the traffic classification rule, such as the source CIDR block, destination CIDR block, source port, destination port, and DSCP value. If you do not specify sufficient information, the system may fail to match the traffic classification rule that you want to delete.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("DeleteTrafficMatchRules")]
        [Validation(Required=false)]
        public List<UpdateTrafficMarkingPolicyAttributeRequestDeleteTrafficMatchRules> DeleteTrafficMatchRules { get; set; }
        public class UpdateTrafficMarkingPolicyAttributeRequestDeleteTrafficMatchRules : TeaModel {
            [NameInMap("AddressFamily")]
            [Validation(Required=false)]
            public string AddressFamily { get; set; }

            /// <summary>
            /// <para>The destination CIDR block that is used to match packets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.200.3/32</para>
            /// </summary>
            [NameInMap("DstCidr")]
            [Validation(Required=false)]
            public string DstCidr { get; set; }

            /// <summary>
            /// <para>The destination port range that is used to match packets.</para>
            /// </summary>
            [NameInMap("DstPortRange")]
            [Validation(Required=false)]
            public List<int?> DstPortRange { get; set; }

            /// <summary>
            /// <para>The DSCP value that is used to match packets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MatchDscp")]
            [Validation(Required=false)]
            public int? MatchDscp { get; set; }

            /// <summary>
            /// <para>The protocol that is used to match packets.</para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/468322.html">ListTrafficMarkingPolicies</a> operation to query the details about a traffic classification rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The source CIDR block that is used to match packets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.72.0.0/16</para>
            /// </summary>
            [NameInMap("SrcCidr")]
            [Validation(Required=false)]
            public string SrcCidr { get; set; }

            /// <summary>
            /// <para>The source port range that is used to match packets.</para>
            /// </summary>
            [NameInMap("SrcPortRange")]
            [Validation(Required=false)]
            public List<int?> SrcPortRange { get; set; }

            /// <summary>
            /// <para>The description of the traffic classification rule.</para>
            /// <para>This parameter is optional. If you enter a description, it must be 1 to 256 characters in length, and cannot start with http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hangzhou-to-Qingdao CAT</para>
            /// </summary>
            [NameInMap("TrafficMatchRuleDescription")]
            [Validation(Required=false)]
            public string TrafficMatchRuleDescription { get; set; }

            /// <summary>
            /// <para>The name of the traffic classification rule.</para>
            /// <para>The name can be empty or 1 to 128 characters in length, and cannot start with http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TrafficMatchRuleName")]
            [Validation(Required=false)]
            public string TrafficMatchRuleName { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: preforms a dry run. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
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
        /// <para>The new description of the traffic marking policy.</para>
        /// <para>The description must be 2 to 128 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The description must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("TrafficMarkingPolicyDescription")]
        [Validation(Required=false)]
        public string TrafficMarkingPolicyDescription { get; set; }

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
        /// <para>The new name of the traffic marking policy.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). It must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("TrafficMarkingPolicyName")]
        [Validation(Required=false)]
        public string TrafficMarkingPolicyName { get; set; }

    }

}

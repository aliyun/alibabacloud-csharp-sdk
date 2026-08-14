// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeExpressConnectTrafficQosRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C7FA9D6-72E0-48A9-A9C3-2DA8569CD5EB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of QoS rules.</para>
        /// </summary>
        [NameInMap("RuleList")]
        [Validation(Required=false)]
        public List<DescribeExpressConnectTrafficQosRuleResponseBodyRuleList> RuleList { get; set; }
        public class DescribeExpressConnectTrafficQosRuleResponseBodyRuleList : TeaModel {
            /// <summary>
            /// <para>The destination IP address IPv4 CIDR block for traffic matching of the QoS rule.</para>
            /// <remarks>
            /// <para>This parameter cannot be specified together with <b>SrcIPv6Cidr</b> or <b>DstIPv6Cidr</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><c>1.1.**.**</c>/24</para>
            /// </summary>
            [NameInMap("DstCidr")]
            [Validation(Required=false)]
            public string DstCidr { get; set; }

            /// <summary>
            /// <para>The destination IP address IPv6 CIDR block for traffic matching of the QoS rule.</para>
            /// <remarks>
            /// <para>This parameter cannot be specified together with <b>SrcCidr</b> or <b>DstCidr</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2001:0db8:1234:****::/64</para>
            /// </summary>
            [NameInMap("DstIPv6Cidr")]
            [Validation(Required=false)]
            public string DstIPv6Cidr { get; set; }

            /// <summary>
            /// <para>The destination port range for traffic matching of the QoS rule. Valid values: <b>0</b> to <b>65535</b>. A value of -1 indicates no match. Currently, only a single port number can be specified, and the start and end port numbers must be the same. The destination port range is fixed for different protocol types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ALL</b>: -1/-1. Not editable.</para>
            /// </description></item>
            /// <item><description><para><b>ICMP(IPv4)</b>: -1/-1. Not editable.</para>
            /// </description></item>
            /// <item><description><para><b>ICMPv6(IPv6)</b>: -1/-1. Not editable.</para>
            /// </description></item>
            /// <item><description><para><b>TCP</b>: -1/-1. Editable.</para>
            /// </description></item>
            /// <item><description><para><b>UDP</b>: -1/-1. Editable.</para>
            /// </description></item>
            /// <item><description><para><b>GRE</b>: -1/-1. Not editable.</para>
            /// </description></item>
            /// <item><description><para><b>SSH</b>: 22/22. Not editable.</para>
            /// </description></item>
            /// <item><description><para><b>Telnet</b>: 23/23. Not editable.</para>
            /// </description></item>
            /// <item><description><para><b>HTTP</b>: 80/80. Not editable.</para>
            /// </description></item>
            /// <item><description><para><b>HTTPS</b>: 443/443. Not editable.</para>
            /// </description></item>
            /// <item><description><para><b>MS SQL</b>: 1443/1443. Not editable.</para>
            /// </description></item>
            /// <item><description><para><b>Oracle</b>: 1521/1521. Not editable.</para>
            /// </description></item>
            /// <item><description><para><b>MySql</b>: 3306/3306. Not editable.</para>
            /// </description></item>
            /// <item><description><para><b>RDP</b>: 3389/3389. Not editable.</para>
            /// </description></item>
            /// <item><description><para><b>PostgreSQL</b>: 5432/5432. Not editable.</para>
            /// </description></item>
            /// <item><description><para><b>Redis</b>: 6379/6379. Not editable.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>-1/-1</para>
            /// </summary>
            [NameInMap("DstPortRange")]
            [Validation(Required=false)]
            public string DstPortRange { get; set; }

            /// <summary>
            /// <para>The DSCP value for traffic matching of the QoS rule. Valid values: <b>0</b> to <b>63</b>. A value of -1 indicates no match.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MatchDscp")]
            [Validation(Required=false)]
            public int? MatchDscp { get; set; }

            /// <summary>
            /// <para>The priority of the QoS rule. Valid values: <b>1</b> to <b>9000</b>. A larger value indicates a higher priority. The priority must be unique within the same QoS policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The protocol type of the QoS rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ALL</b></para>
            /// </description></item>
            /// <item><description><para><b>ICMP(IPv4)</b></para>
            /// </description></item>
            /// <item><description><para><b>ICMPv6(IPv6)</b></para>
            /// </description></item>
            /// <item><description><para><b>TCP</b></para>
            /// </description></item>
            /// <item><description><para><b>UDP</b></para>
            /// </description></item>
            /// <item><description><para><b>GRE</b></para>
            /// </description></item>
            /// <item><description><para><b>SSH</b></para>
            /// </description></item>
            /// <item><description><para><b>Telnet</b></para>
            /// </description></item>
            /// <item><description><para><b>HTTP</b></para>
            /// </description></item>
            /// <item><description><para><b>HTTPS</b></para>
            /// </description></item>
            /// <item><description><para><b>MS SQL</b></para>
            /// </description></item>
            /// <item><description><para><b>Oracle</b></para>
            /// </description></item>
            /// <item><description><para><b>MySql</b></para>
            /// </description></item>
            /// <item><description><para><b>RDP</b></para>
            /// </description></item>
            /// <item><description><para><b>PostgreSQL</b></para>
            /// </description></item>
            /// <item><description><para><b>Redis</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The QoS policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-pksbqfmotl5hzq****</para>
            /// </summary>
            [NameInMap("QosId")]
            [Validation(Required=false)]
            public string QosId { get; set; }

            /// <summary>
            /// <para>The QoS queue ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-queue-9nyx2u7n71s2rc****</para>
            /// </summary>
            [NameInMap("QueueId")]
            [Validation(Required=false)]
            public string QueueId { get; set; }

            /// <summary>
            /// <para>The DSCP value to remark in the traffic. Valid values: <b>0</b> to <b>63</b>. A value of -1 indicates no remarking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RemarkingDscp")]
            [Validation(Required=false)]
            public int? RemarkingDscp { get; set; }

            /// <summary>
            /// <para>The description of the QoS rule.</para>
            /// <para>The description is 0 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-rule-test</para>
            /// </summary>
            [NameInMap("RuleDescription")]
            [Validation(Required=false)]
            public string RuleDescription { get; set; }

            /// <summary>
            /// <para>The QoS rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-rule-iugg0l9x27f2noc****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The name of the QoS rule.</para>
            /// <para>The name is 0 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-rule-test</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The source IPv4 CIDR block for traffic matching of the QoS rule.</para>
            /// <remarks>
            /// <para>This parameter cannot be specified together with <b>SrcIPv6Cidr</b> or <b>DstIPv6Cidr</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><c>1.1.**.**</c>/24</para>
            /// </summary>
            [NameInMap("SrcCidr")]
            [Validation(Required=false)]
            public string SrcCidr { get; set; }

            /// <summary>
            /// <para>The source IPv6 CIDR block for traffic matching of the QoS rule.</para>
            /// <remarks>
            /// <para>This parameter cannot be specified together with <b>SrcCidr</b> or <b>DstCidr</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2001:0db8:1234:****::/64</para>
            /// </summary>
            [NameInMap("SrcIPv6Cidr")]
            [Validation(Required=false)]
            public string SrcIPv6Cidr { get; set; }

            /// <summary>
            /// <para>The source port range for traffic matching of the QoS rule. Valid values: <b>0</b> to <b>65535</b>. A value of -1 indicates no match. Currently, only a single port number can be specified, and the start and end port numbers must be the same.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1/-1</para>
            /// </summary>
            [NameInMap("SrcPortRange")]
            [Validation(Required=false)]
            public string SrcPortRange { get; set; }

            /// <summary>
            /// <para>The status of the QoS rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Normal</b>: active.</para>
            /// </description></item>
            /// <item><description><para><b>Configuring</b>: being configured.</para>
            /// </description></item>
            /// <item><description><para><b>Deleting</b>: being deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeExpressConnectTrafficQosQueueResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of QoS queues.</para>
        /// </summary>
        [NameInMap("QueueList")]
        [Validation(Required=false)]
        public List<DescribeExpressConnectTrafficQosQueueResponseBodyQueueList> QueueList { get; set; }
        public class DescribeExpressConnectTrafficQosQueueResponseBodyQueueList : TeaModel {
            /// <summary>
            /// <para>The bandwidth percentage of the QoS queue.</para>
            /// <list type="bullet">
            /// <item><description><para>When the QoS queue type is <b>Medium</b>, this field is required. Valid values: <b>1</b> to <b>100</b>.</para>
            /// </description></item>
            /// <item><description><para>When the QoS queue type is <b>Default</b>, this field is &quot;-&quot;.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("BandwidthPercent")]
            [Validation(Required=false)]
            public string BandwidthPercent { get; set; }

            /// <summary>
            /// <para>The QoS policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-ncfgzxg40zks5n****</para>
            /// </summary>
            [NameInMap("QosId")]
            [Validation(Required=false)]
            public string QosId { get; set; }

            /// <summary>
            /// <para>The description of the QoS queue.</para>
            /// <para>The description must be <b>0</b> to <b>256</b> characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-queue-test</para>
            /// </summary>
            [NameInMap("QueueDescription")]
            [Validation(Required=false)]
            public string QueueDescription { get; set; }

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
            /// <para>The name of the QoS queue.</para>
            /// <para>The name must be <b>0</b> to <b>128</b> characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-queue-test</para>
            /// </summary>
            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <para>The type of the QoS queue. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>High</b>: high-priority queue.</para>
            /// </description></item>
            /// <item><description><para><b>Medium</b>: medium-priority queue.</para>
            /// </description></item>
            /// <item><description><para><b>Default</b>: default-priority queue.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>The default-priority queue cannot be created.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>High</para>
            /// </summary>
            [NameInMap("QueueType")]
            [Validation(Required=false)]
            public string QueueType { get; set; }

            /// <summary>
            /// <para>The list of QoS rules.</para>
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeExpressConnectTrafficQosQueueResponseBodyQueueListRuleList> RuleList { get; set; }
            public class DescribeExpressConnectTrafficQosQueueResponseBodyQueueListRuleList : TeaModel {
                /// <summary>
                /// <para>The destination IP address IPv4 CIDR block that is used for traffic matching by the QoS rule.</para>
                /// <remarks>
                /// <para>You cannot specify this parameter together with <b>SrcIPv6Cidr</b> or <b>DstIPv6Cidr</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para><c>1.1.**.**</c>/24</para>
                /// </summary>
                [NameInMap("DstCidr")]
                [Validation(Required=false)]
                public string DstCidr { get; set; }

                /// <summary>
                /// <para>The destination IP address IPv6 CIDR block that is used for traffic matching by the QoS rule.</para>
                /// <remarks>
                /// <para>You cannot specify this parameter together with <b>SrcCidr</b> or <b>DstCidr</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2001:0db8:1234:****::/64</para>
                /// </summary>
                [NameInMap("DstIPv6Cidr")]
                [Validation(Required=false)]
                public string DstIPv6Cidr { get; set; }

                /// <summary>
                /// <para>The destination port range that is used for traffic matching by the QoS rule. Valid values: <b>0</b> to <b>65535</b>. A value of -1 indicates that no port is matched. Only a single port number is supported. The start and end port numbers must be the same. The destination port range is fixed for each protocol type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>ALL</b>: -1/-1, not editable.</para>
                /// </description></item>
                /// <item><description><para><b>ICMP(IPv4)</b>: -1/-1, not editable.</para>
                /// </description></item>
                /// <item><description><para><b>ICMPv6(IPv6)</b>: -1/-1, not editable.</para>
                /// </description></item>
                /// <item><description><para><b>TCP</b>: -1/-1, editable.</para>
                /// </description></item>
                /// <item><description><para><b>UDP</b>: -1/-1, editable.</para>
                /// </description></item>
                /// <item><description><para><b>GRE</b>: -1/-1, not editable.</para>
                /// </description></item>
                /// <item><description><para><b>SSH</b>: 22/22, not editable.</para>
                /// </description></item>
                /// <item><description><para><b>Telnet</b>: 23/23, not editable.</para>
                /// </description></item>
                /// <item><description><para><b>HTTP</b>: 80/80, not editable.</para>
                /// </description></item>
                /// <item><description><para><b>HTTPS</b>: 443/443, not editable.</para>
                /// </description></item>
                /// <item><description><para><b>MS SQL</b>: 1443/1443, not editable.</para>
                /// </description></item>
                /// <item><description><para><b>Oracle</b>: 1521/1521, not editable.</para>
                /// </description></item>
                /// <item><description><para><b>MySql</b>: 3306/3306, not editable.</para>
                /// </description></item>
                /// <item><description><para><b>RDP</b>: 3389/3389, not editable.</para>
                /// </description></item>
                /// <item><description><para><b>PostgreSQL</b>: 5432/5432, not editable.</para>
                /// </description></item>
                /// <item><description><para><b>Redis</b>: 6379/6379, not editable.</para>
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
                /// <para>The DSCP value that is used for traffic matching by the QoS rule. Valid values: <b>0</b> to <b>63</b>. A value of -1 indicates that no DSCP value is matched.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MatchDscp")]
                [Validation(Required=false)]
                public int? MatchDscp { get; set; }

                /// <summary>
                /// <para>The priority of the QoS rule. Valid values: <b>1</b> to <b>9000</b>. A larger value indicates a higher priority. The priority of each QoS rule must be unique within the same QoS policy.</para>
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
                /// <item><description><para><b>Redis</b>.</para>
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
                /// <para>qos-91xz9f8zd7yj8x****</para>
                /// </summary>
                [NameInMap("QosId")]
                [Validation(Required=false)]
                public string QosId { get; set; }

                /// <summary>
                /// <para>The QoS queue ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qos-queue-iugg0l9x27f2no****</para>
                /// </summary>
                [NameInMap("QueueId")]
                [Validation(Required=false)]
                public string QueueId { get; set; }

                /// <summary>
                /// <para>The new DSCP value to remark in the traffic. Valid values: <b>0</b> to <b>63</b>. A value of -1 indicates that the DSCP value is not modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RemarkingDscp")]
                [Validation(Required=false)]
                public int? RemarkingDscp { get; set; }

                /// <summary>
                /// <para>The description of the QoS rule.</para>
                /// <para>The description must be <b>0</b> to <b>256</b> characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
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
                /// <para>qos-rule-iugg0l9x27f2no****</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The name of the QoS rule.</para>
                /// <para>The name must be <b>0</b> to <b>128</b> characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qos-rule-test</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The source IPv4 CIDR block that is used for traffic matching by the QoS rule.</para>
                /// <remarks>
                /// <para>You cannot specify this parameter together with <b>SrcIPv6Cidr</b> or <b>DstIPv6Cidr</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para><c>1.1.**.**</c>/24</para>
                /// </summary>
                [NameInMap("SrcCidr")]
                [Validation(Required=false)]
                public string SrcCidr { get; set; }

                /// <summary>
                /// <para>The source IPv6 CIDR block that is used for traffic matching by the QoS rule.</para>
                /// <remarks>
                /// <para>You cannot specify this parameter together with <b>SrcCidr</b> or <b>DstCidr</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2001:0db8:1234:****::/64</para>
                /// </summary>
                [NameInMap("SrcIPv6Cidr")]
                [Validation(Required=false)]
                public string SrcIPv6Cidr { get; set; }

                /// <summary>
                /// <para>The source port range that is used for traffic matching by the QoS rule. Valid values: <b>0</b> to <b>65535</b>. A value of -1 indicates that no port is matched. Only a single port number is supported. The start and end port numbers must be the same.</para>
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

            /// <summary>
            /// <para>The status of the QoS queue. Valid values:</para>
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

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>606998F0-B94D-48FE-8316-ACA81BB230DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

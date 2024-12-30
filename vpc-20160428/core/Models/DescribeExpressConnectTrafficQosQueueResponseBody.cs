// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeExpressConnectTrafficQosQueueResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the QoS queues.</para>
        /// </summary>
        [NameInMap("QueueList")]
        [Validation(Required=false)]
        public List<DescribeExpressConnectTrafficQosQueueResponseBodyQueueList> QueueList { get; set; }
        public class DescribeExpressConnectTrafficQosQueueResponseBodyQueueList : TeaModel {
            /// <summary>
            /// <para>The percentage of bandwidth allocated to a QoS queue.</para>
            /// <list type="bullet">
            /// <item><description>If QueueType is set to <b>Medium</b>, this parameter is returned. Valid values: <b>1</b> to <b>100</b>.</description></item>
            /// <item><description>If QueueType is set to <b>Default</b>, a value of - is returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("BandwidthPercent")]
            [Validation(Required=false)]
            public string BandwidthPercent { get; set; }

            /// <summary>
            /// <para>The ID of the QoS policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-ncfgzxg40zks5n0qze</para>
            /// </summary>
            [NameInMap("QosId")]
            [Validation(Required=false)]
            public string QosId { get; set; }

            /// <summary>
            /// <para>The description of the QoS queue.</para>
            /// <para>The name must be <b>0</b> to <b>256</b> characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-queue-test</para>
            /// </summary>
            [NameInMap("QueueDescription")]
            [Validation(Required=false)]
            public string QueueDescription { get; set; }

            /// <summary>
            /// <para>The ID of the QoS queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-queue-9nyx2u7n71s2rcy4n5</para>
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
            /// <para>The priority of the QoS queue. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>High</b></description></item>
            /// <item><description><b>Medium</b></description></item>
            /// <item><description><b>Default</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> You cannot create a QoS queue of the default priority.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>High</para>
            /// </summary>
            [NameInMap("QueueType")]
            [Validation(Required=false)]
            public string QueueType { get; set; }

            /// <summary>
            /// <para>The information about the QoS rules.</para>
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeExpressConnectTrafficQosQueueResponseBodyQueueListRuleList> RuleList { get; set; }
            public class DescribeExpressConnectTrafficQosQueueResponseBodyQueueListRuleList : TeaModel {
                /// <summary>
                /// <para>The destination IPv4 CIDR block that matches the QoS rule traffic.</para>
                /// <remarks>
                /// <para>If the parameter is unavailable, specify <b>SrcIPv6Cidr</b> or <b>DstIPv6Cidr</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1.1.1.0/24</para>
                /// </summary>
                [NameInMap("DstCidr")]
                [Validation(Required=false)]
                public string DstCidr { get; set; }

                /// <summary>
                /// <para>The destination IPv6 CIDR block that matches the QoS rule traffic.</para>
                /// <remarks>
                /// <para>If the parameter is unavailable, specify <b>SrcCidr</b> or <b>DstCidr</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2001:0db8:1234:5678::/64</para>
                /// </summary>
                [NameInMap("DstIPv6Cidr")]
                [Validation(Required=false)]
                public string DstIPv6Cidr { get; set; }

                /// <summary>
                /// <para>The range of destination ports that match the QoS rule traffic. Valid values: <b>0</b> to <b>65535</b>. If the traffic does not match, the value is -1. You can specify only one port. The start port number must be the same as the end port number. Different protocols correspond to different ports. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ALL</b> (uneditable): -1/-1.</description></item>
                /// <item><description><b>ICMP(IPv4)</b> (uneditable): -1/-1.</description></item>
                /// <item><description><b>ICMPv6(IPv6)</b> (uneditable): -1/-1.</description></item>
                /// <item><description><b>TCP</b> (editable): -1/-1.</description></item>
                /// <item><description><b>UDP</b> (editable): -1/-1.</description></item>
                /// <item><description><b>GRE</b> (uneditable): -1/-1.</description></item>
                /// <item><description><b>SSH</b> (uneditable): 22/22.</description></item>
                /// <item><description><b>Telnet</b> (uneditable): 23/23.</description></item>
                /// <item><description><b>HTTP</b> (uneditable): 80/80.</description></item>
                /// <item><description><b>HTTPS</b> (uneditable): 443/443.</description></item>
                /// <item><description><b>MS SQL</b> (uneditable): 1443/1443.</description></item>
                /// <item><description><b>Oracle</b> (uneditable): 1521/1521.</description></item>
                /// <item><description><b>MySql</b> (uneditable): 3306/3306.</description></item>
                /// <item><description><b>RDP</b> (uneditable): 3389/3389.</description></item>
                /// <item><description><b>PostgreSQL</b> (uneditable): 5432/5432.</description></item>
                /// <item><description><b>Redis</b> (uneditable): 6379/6379.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>-1/-1</para>
                /// </summary>
                [NameInMap("DstPortRange")]
                [Validation(Required=false)]
                public string DstPortRange { get; set; }

                /// <summary>
                /// <para>The DSCP value that matches the QoS rule traffic. Valid values: <b>0</b> to <b>63</b>. If no value is matched, the value is -1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MatchDscp")]
                [Validation(Required=false)]
                public int? MatchDscp { get; set; }

                /// <summary>
                /// <para>The priority of the QoS rule. Valid values: <b>1</b> to <b>9000</b>. A larger value indicates a higher priority. The priority of each QoS rule must be unique in the same QoS policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The protocol of the QoS rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ALL</b></description></item>
                /// <item><description><b>ICMP(IPv4)</b></description></item>
                /// <item><description><b>ICMPv6(IPv6)</b></description></item>
                /// <item><description><b>TCP</b></description></item>
                /// <item><description><b>UDP</b></description></item>
                /// <item><description><b>GRE</b></description></item>
                /// <item><description><b>SSH</b></description></item>
                /// <item><description><b>Telnet</b></description></item>
                /// <item><description><b>HTTP</b></description></item>
                /// <item><description><b>HTTPS</b></description></item>
                /// <item><description><b>MS SQL</b></description></item>
                /// <item><description><b>Oracle</b></description></item>
                /// <item><description><b>MySql</b></description></item>
                /// <item><description><b>RDP</b></description></item>
                /// <item><description><b>PostgreSQL</b></description></item>
                /// <item><description><b>Redis</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ALL</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The ID of the QoS policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qos-91xz9f8zd7yj8xwknz</para>
                /// </summary>
                [NameInMap("QosId")]
                [Validation(Required=false)]
                public string QosId { get; set; }

                /// <summary>
                /// <para>The ID of the QoS queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qos-queue-iugg0l9x27f2nocouj</para>
                /// </summary>
                [NameInMap("QueueId")]
                [Validation(Required=false)]
                public string QueueId { get; set; }

                /// <summary>
                /// <para>The new DSCP value. Valid values: <b>0</b> to <b>63</b>. If you do not change the value, the value is -1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RemarkingDscp")]
                [Validation(Required=false)]
                public int? RemarkingDscp { get; set; }

                /// <summary>
                /// <para>The description of the QoS rule.</para>
                /// <para>The name must be <b>0</b> to <b>256</b> characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qos-rule-test</para>
                /// </summary>
                [NameInMap("RuleDescription")]
                [Validation(Required=false)]
                public string RuleDescription { get; set; }

                /// <summary>
                /// <para>The ID of the QoS rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qos-rule-iugg0l9x27f2nocouj</para>
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
                /// <para>The source IPv4 CIDR block that matches the QoS rule traffic.</para>
                /// <remarks>
                /// <para>If the parameter is unavailable, specify <b>SrcIPv6Cidr</b> or <b>DstIPv6Cidr</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1.1.1.0/24</para>
                /// </summary>
                [NameInMap("SrcCidr")]
                [Validation(Required=false)]
                public string SrcCidr { get; set; }

                /// <summary>
                /// <para>The source IPv6 CIDR block that matches the QoS rule traffic.</para>
                /// <remarks>
                /// <para>If the parameter is unavailable, specify <b>SrcCidr</b> or <b>DstCidr</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2001:0db8:1234:5678::/64</para>
                /// </summary>
                [NameInMap("SrcIPv6Cidr")]
                [Validation(Required=false)]
                public string SrcIPv6Cidr { get; set; }

                /// <summary>
                /// <para>The range of source ports that match the QoS rule traffic. Valid values: <b>0</b> to <b>65535</b>. If the traffic does not match, the value is -1. You can specify only one port. The start port number must be the same as the end port number.</para>
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
                /// <item><description><b>Normal</b>: The QoS queue is available.</description></item>
                /// <item><description><b>Configuring</b>: The QoS queue is being configured.</description></item>
                /// <item><description><b>Deleting</b>: The QoS queue is being deleted.</description></item>
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
            /// <para>The state of the QoS queue. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: The QoS queue is available.</description></item>
            /// <item><description><b>Configuring</b>: The QoS queue is being configured.</description></item>
            /// <item><description><b>Deleting</b>: The QoS queue is being deleted.</description></item>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeExpressConnectTrafficQosQueueResponseBody : TeaModel {
        [NameInMap("QueueList")]
        [Validation(Required=false)]
        public List<DescribeExpressConnectTrafficQosQueueResponseBodyQueueList> QueueList { get; set; }
        public class DescribeExpressConnectTrafficQosQueueResponseBodyQueueList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("BandwidthPercent")]
            [Validation(Required=false)]
            public string BandwidthPercent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qos-ncfgzxg40zks5n0qze</para>
            /// </summary>
            [NameInMap("QosId")]
            [Validation(Required=false)]
            public string QosId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qos-queue-test</para>
            /// </summary>
            [NameInMap("QueueDescription")]
            [Validation(Required=false)]
            public string QueueDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qos-queue-9nyx2u7n71s2rcy4n5</para>
            /// </summary>
            [NameInMap("QueueId")]
            [Validation(Required=false)]
            public string QueueId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qos-queue-test</para>
            /// </summary>
            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>High</para>
            /// </summary>
            [NameInMap("QueueType")]
            [Validation(Required=false)]
            public string QueueType { get; set; }

            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeExpressConnectTrafficQosQueueResponseBodyQueueListRuleList> RuleList { get; set; }
            public class DescribeExpressConnectTrafficQosQueueResponseBodyQueueListRuleList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1.1.1.0/24</para>
                /// </summary>
                [NameInMap("DstCidr")]
                [Validation(Required=false)]
                public string DstCidr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2001:0db8:1234:5678::/64</para>
                /// </summary>
                [NameInMap("DstIPv6Cidr")]
                [Validation(Required=false)]
                public string DstIPv6Cidr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>-1/-1</para>
                /// </summary>
                [NameInMap("DstPortRange")]
                [Validation(Required=false)]
                public string DstPortRange { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MatchDscp")]
                [Validation(Required=false)]
                public int? MatchDscp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ALL</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>qos-91xz9f8zd7yj8xwknz</para>
                /// </summary>
                [NameInMap("QosId")]
                [Validation(Required=false)]
                public string QosId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>qos-queue-iugg0l9x27f2nocouj</para>
                /// </summary>
                [NameInMap("QueueId")]
                [Validation(Required=false)]
                public string QueueId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RemarkingDscp")]
                [Validation(Required=false)]
                public int? RemarkingDscp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>qos-rule-test</para>
                /// </summary>
                [NameInMap("RuleDescription")]
                [Validation(Required=false)]
                public string RuleDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>qos-rule-iugg0l9x27f2nocouj</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>qos-rule-test</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.1.1.0/24</para>
                /// </summary>
                [NameInMap("SrcCidr")]
                [Validation(Required=false)]
                public string SrcCidr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2001:0db8:1234:5678::/64</para>
                /// </summary>
                [NameInMap("SrcIPv6Cidr")]
                [Validation(Required=false)]
                public string SrcIPv6Cidr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>-1/-1</para>
                /// </summary>
                [NameInMap("SrcPortRange")]
                [Validation(Required=false)]
                public string SrcPortRange { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>606998F0-B94D-48FE-8316-ACA81BB230DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

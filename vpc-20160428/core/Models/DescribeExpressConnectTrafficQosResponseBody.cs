// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeExpressConnectTrafficQosResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("QosList")]
        [Validation(Required=false)]
        public List<DescribeExpressConnectTrafficQosResponseBodyQosList> QosList { get; set; }
        public class DescribeExpressConnectTrafficQosResponseBodyQosList : TeaModel {
            [NameInMap("AssociatedInstanceList")]
            [Validation(Required=false)]
            public List<DescribeExpressConnectTrafficQosResponseBodyQosListAssociatedInstanceList> AssociatedInstanceList { get; set; }
            public class DescribeExpressConnectTrafficQosResponseBodyQosListAssociatedInstanceList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>pc-bp159zj8zujwy3p07j83e</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("InstanceProgressing")]
                [Validation(Required=false)]
                public int? InstanceProgressing { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PHYSICALCONNECTION</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progressing")]
            [Validation(Required=false)]
            public int? Progressing { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qos-test</para>
            /// </summary>
            [NameInMap("QosDescription")]
            [Validation(Required=false)]
            public string QosDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qos-pksbqfmotl5hzqmhf8</para>
            /// </summary>
            [NameInMap("QosId")]
            [Validation(Required=false)]
            public string QosId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qos-test</para>
            /// </summary>
            [NameInMap("QosName")]
            [Validation(Required=false)]
            public string QosName { get; set; }

            [NameInMap("QueueList")]
            [Validation(Required=false)]
            public List<DescribeExpressConnectTrafficQosResponseBodyQosListQueueList> QueueList { get; set; }
            public class DescribeExpressConnectTrafficQosResponseBodyQosListQueueList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("BandwidthPercent")]
                [Validation(Required=false)]
                public string BandwidthPercent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>qos-pksbqfmotl5hzqmhf8</para>
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

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4CF20CC7-D1FC-425B-A15B-DF7C8E2131A7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

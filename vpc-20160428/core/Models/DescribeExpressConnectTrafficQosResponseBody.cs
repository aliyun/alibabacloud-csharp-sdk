// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeExpressConnectTrafficQosResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1 to 100</b>. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value can be used in the next request to retrieve a new page of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The information about QoS policies.</para>
        /// </summary>
        [NameInMap("QosList")]
        [Validation(Required=false)]
        public List<DescribeExpressConnectTrafficQosResponseBodyQosList> QosList { get; set; }
        public class DescribeExpressConnectTrafficQosResponseBodyQosList : TeaModel {
            /// <summary>
            /// <para>The information about the instances to which the QoS policy is associated.</para>
            /// </summary>
            [NameInMap("AssociatedInstanceList")]
            [Validation(Required=false)]
            public List<DescribeExpressConnectTrafficQosResponseBodyQosListAssociatedInstanceList> AssociatedInstanceList { get; set; }
            public class DescribeExpressConnectTrafficQosResponseBodyQosListAssociatedInstanceList : TeaModel {
                /// <summary>
                /// <para>The ID of the instance to which the QoS policy is associated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-bp159zj8zujwy3p07j83e</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The configuration progress of the instance to which the QoS policy is associated. Valid values: <b>0</b> to <b>100</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("InstanceProgressing")]
                [Validation(Required=false)]
                public int? InstanceProgressing { get; set; }

                /// <summary>
                /// <para>The state of the instance to which the QoS policy is associated. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>: The instance is available.</description></item>
                /// <item><description><b>Configuring</b>: The instance is being configured.</description></item>
                /// <item><description><b>Deleting</b>: The instance is being deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                /// <summary>
                /// <para>The type of the instance to which the QoS policy is associated. Only <b>PHYSICALCONNECTION</b> is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PHYSICALCONNECTION</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

            }

            /// <summary>
            /// <para>The configuration progress of the QoS policy. Valid values: <b>0</b> to <b>100</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progressing")]
            [Validation(Required=false)]
            public int? Progressing { get; set; }

            /// <summary>
            /// <para>The description of the QoS policy.</para>
            /// <para>The description can be up to 256 characters in length. It cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-test</para>
            /// </summary>
            [NameInMap("QosDescription")]
            [Validation(Required=false)]
            public string QosDescription { get; set; }

            /// <summary>
            /// <para>The ID of the QoS policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-pksbqfmotl5hzq****</para>
            /// </summary>
            [NameInMap("QosId")]
            [Validation(Required=false)]
            public string QosId { get; set; }

            /// <summary>
            /// <para>The name of the QoS policy.</para>
            /// <para>The name can be up to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-test</para>
            /// </summary>
            [NameInMap("QosName")]
            [Validation(Required=false)]
            public string QosName { get; set; }

            /// <summary>
            /// <para>The information about the QoS queues.</para>
            /// </summary>
            [NameInMap("QueueList")]
            [Validation(Required=false)]
            public List<DescribeExpressConnectTrafficQosResponseBodyQosListQueueList> QueueList { get; set; }
            public class DescribeExpressConnectTrafficQosResponseBodyQosListQueueList : TeaModel {
                /// <summary>
                /// <para>The percentage of bandwidth allocated to a QoS queue.</para>
                /// <list type="bullet">
                /// <item><description>If QueueType is set to <b>Medium</b>, this parameter is required. Valid values: <b>1</b> to <b>100</b>.</description></item>
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
                /// <para>qos-pksbqfmotl5hzqmhf8</para>
                /// </summary>
                [NameInMap("QosId")]
                [Validation(Required=false)]
                public string QosId { get; set; }

                /// <summary>
                /// <para>The description of the QoS queue.</para>
                /// <para>The description can be up to <b>256</b> characters in length. It cannot start with <c>http://</c> or <c>https://</c>.</para>
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
                /// <para>The name can be up to <b>128</b> characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
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
                /// <item><description><b>High</b>: high-priority queue.</description></item>
                /// <item><description><b>Medium</b>: standard queue.</description></item>
                /// <item><description><b>Default</b>: default queue.</description></item>
                /// </list>
                /// <remarks>
                /// <para>You cannot create a default queue.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>High</para>
                /// </summary>
                [NameInMap("QueueType")]
                [Validation(Required=false)]
                public string QueueType { get; set; }

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
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmz7vtyl4f***</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The state of the QoS policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: The QoS policy is available.</description></item>
            /// <item><description><b>Configuring</b>: The QoS policy is being configured.</description></item>
            /// </list>
            /// <remarks>
            /// <para>If a QoS policy is in the Configuring state, you cannot perform most of the operations to create, update, or delete QoS policies, QoS queues, or QoS rules.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag list.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeExpressConnectTrafficQosResponseBodyQosListTags> Tags { get; set; }
            public class DescribeExpressConnectTrafficQosResponseBodyQosListTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceJoshua</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4CF20CC7-D1FC-425B-A15B-DF7C8E2131A7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

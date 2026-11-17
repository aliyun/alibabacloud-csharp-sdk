// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeExpressConnectTrafficQosResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page. Valid values: <b>1</b> to <b>100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Leave empty for the first query or when no next query is required.</para>
        /// </description></item>
        /// <item><description><para>If a next query is required, set the value to the <b>NextToken</b> value returned by the previous API call.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of QoS policies.</para>
        /// </summary>
        [NameInMap("QosList")]
        [Validation(Required=false)]
        public List<DescribeExpressConnectTrafficQosResponseBodyQosList> QosList { get; set; }
        public class DescribeExpressConnectTrafficQosResponseBodyQosList : TeaModel {
            /// <summary>
            /// <para>The list of associated instances.</para>
            /// </summary>
            [NameInMap("AssociatedInstanceList")]
            [Validation(Required=false)]
            public List<DescribeExpressConnectTrafficQosResponseBodyQosListAssociatedInstanceList> AssociatedInstanceList { get; set; }
            public class DescribeExpressConnectTrafficQosResponseBodyQosListAssociatedInstanceList : TeaModel {
                /// <summary>
                /// <para>The ID of the associated instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-bp159zj8zujwy3p07****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The configuration progress of the associated instance. Valid values: <b>0</b> to <b>100</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("InstanceProgressing")]
                [Validation(Required=false)]
                public int? InstanceProgressing { get; set; }

                /// <summary>
                /// <para>The status of the associated instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Normal</b>: The instance is available.</para>
                /// </description></item>
                /// <item><description><para><b>Configuring</b>: The instance is being configured.</para>
                /// </description></item>
                /// <item><description><para><b>Deleting</b>: The instance is being deleted.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                /// <summary>
                /// <para>The type of the associated instance. Valid value: <b>PHYSICALCONNECTION</b> (Express Connect circuit).</para>
                /// 
                /// <b>Example:</b>
                /// <para>PHYSICALCONNECTION</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

            }

            /// <summary>
            /// <para>The overall configuration progress of the QoS policy. Valid values: <b>0</b> to <b>100</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progressing")]
            [Validation(Required=false)]
            public int? Progressing { get; set; }

            /// <summary>
            /// <para>The description of the QoS policy. </para>
            /// <para>The description must be <b>0</b> to <b>256</b> characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
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
            /// <para>The name of the QoS policy. </para>
            /// <para>The name must be <b>0</b> to <b>128</b> characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-test</para>
            /// </summary>
            [NameInMap("QosName")]
            [Validation(Required=false)]
            public string QosName { get; set; }

            /// <summary>
            /// <para>The list of QoS queues.</para>
            /// </summary>
            [NameInMap("QueueList")]
            [Validation(Required=false)]
            public List<DescribeExpressConnectTrafficQosResponseBodyQosListQueueList> QueueList { get; set; }
            public class DescribeExpressConnectTrafficQosResponseBodyQosListQueueList : TeaModel {
                /// <summary>
                /// <para>The bandwidth percentage of the QoS queue.</para>
                /// <list type="bullet">
                /// <item><description><para>When the QoS queue type is <b>Medium</b>, this parameter is required. Valid values: <b>1</b> to <b>100</b>.</para>
                /// </description></item>
                /// <item><description><para>When the QoS queue type is <b>Default</b>, the value of this parameter is &quot;-&quot;.</para>
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
                /// <para>The ID of the QoS policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qos-pksbqfmotl5hzq****</para>
                /// </summary>
                [NameInMap("QosId")]
                [Validation(Required=false)]
                public string QosId { get; set; }

                /// <summary>
                /// <para>The description of the QoS queue.</para>
                /// <para>The description must be <b>0</b> to <b>256</b> characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
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
                /// <para>qos-queue-9nyx2u7n71s2rc****</para>
                /// </summary>
                [NameInMap("QueueId")]
                [Validation(Required=false)]
                public string QueueId { get; set; }

                /// <summary>
                /// <para>The name of the QoS queue.</para>
                /// <para>The name must be <b>0</b> to <b>128</b> characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
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
                /// <item><description><para><b>High</b>: High-priority queue.</para>
                /// </description></item>
                /// <item><description><para><b>Medium</b>: Medium-priority queue.</para>
                /// </description></item>
                /// <item><description><para><b>Default</b>: Default-priority queue.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>You cannot create a default-priority queue.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>High</para>
                /// </summary>
                [NameInMap("QueueType")]
                [Validation(Required=false)]
                public string QueueType { get; set; }

                /// <summary>
                /// <para>The status of the QoS queue. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Normal</b>: The queue is available.</para>
                /// </description></item>
                /// <item><description><para><b>Configuring</b>: The queue is being configured.</para>
                /// </description></item>
                /// <item><description><para><b>Deleting</b>: The queue is being deleted.</para>
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
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmz7vtyl4f***</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The status of the QoS policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Normal</b>: The QoS policy is available.</para>
            /// </description></item>
            /// <item><description><para><b>Configuring</b>: The QoS policy is being configured.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>When a QoS policy is in the Configuring state, most creation, update, and deletion operations for QoS policies, QoS queues, and QoS rules are restricted.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags of the resource.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeExpressConnectTrafficQosResponseBodyQosListTags> Tags { get; set; }
            public class DescribeExpressConnectTrafficQosResponseBodyQosListTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the resource.</para>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

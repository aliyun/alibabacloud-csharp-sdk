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
        /// <para>The number of entries per page for paginated queries. Valid values: <b>1</b> to <b>100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Leave this parameter empty for the first query or if no subsequent query is required.</para>
        /// </description></item>
        /// <item><description><para>If a next query is to be sent, set the value to the <b>NextToken</b> value returned in the previous API call.</para>
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
                /// <item><description><para><b>Normal</b>: available.</para>
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
                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                /// <summary>
                /// <para>The type of the associated instance. Valid values: <b>PHYSICALCONNECTION</b>: Express Connect circuit.</para>
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
            /// <para>The description is <b>0</b> to <b>256</b> characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-test</para>
            /// </summary>
            [NameInMap("QosDescription")]
            [Validation(Required=false)]
            public string QosDescription { get; set; }

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
            /// <para>The name of the QoS policy. </para>
            /// <para>The name is <b>0</b> to <b>128</b> characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
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
                /// <item><description><para>When the QoS queue type is <b>Default</b>, this parameter is set to &quot;-&quot;.</para>
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
                /// <para>qos-pksbqfmotl5hzq****</para>
                /// </summary>
                [NameInMap("QosId")]
                [Validation(Required=false)]
                public string QosId { get; set; }

                /// <summary>
                /// <para>The description of the QoS queue.</para>
                /// <para>The description is <b>0</b> to <b>256</b> characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
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
                /// <para>The name is <b>0</b> to <b>128</b> characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qos-queue-test</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <para>The QoS queue type. Valid values:</para>
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
                /// <para>The status of the QoS queue. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Normal</b>: available.</para>
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
            /// <para>The resource group ID.</para>
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
            /// <item><description><para><b>Normal</b>: available.</para>
            /// </description></item>
            /// <item><description><para><b>Configuring</b>: being configured.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>A QoS policy in the Configuring state restricts most create, update, and delete operations on QoS policies, QoS queues, and QoS rules.</para>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListDisasterRecoveryItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial. This parameter is returned only if the access is denied because the Resource Access Management (RAM) user does not have the required permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("accessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListDisasterRecoveryItemsResponseBodyData Data { get; set; }
        public class ListDisasterRecoveryItemsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Global Replicator tasks.</para>
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListDisasterRecoveryItemsResponseBodyDataList> List { get; set; }
            public class ListDisasterRecoveryItemsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The time when the query task was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-20 03:38:28</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The extended information.</para>
                /// </summary>
                [NameInMap("extInfo")]
                [Validation(Required=false)]
                public Dictionary<string, string> ExtInfo { get; set; }

                /// <summary>
                /// <para>The ID of the Global Replicator task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100070284</para>
                /// </summary>
                [NameInMap("itemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                /// <summary>
                /// <para>The status of the topic mapping. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CREATING</description></item>
                /// <item><description>CHANGING</description></item>
                /// <item><description>RUNNING</description></item>
                /// <item><description>MANUAL_STOPPED</description></item>
                /// <item><description>OVERDUE_STOPPED</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("itemStatus")]
                [Validation(Required=false)]
                public string ItemStatus { get; set; }

                /// <summary>
                /// <para>The ID of the topic mapping.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1300000016</para>
                /// </summary>
                [NameInMap("planId")]
                [Validation(Required=false)]
                public long? PlanId { get; set; }

                /// <summary>
                /// <para>The topics involved in the topic mapping.</para>
                /// </summary>
                [NameInMap("topics")]
                [Validation(Required=false)]
                public List<ListDisasterRecoveryItemsResponseBodyDataListTopics> Topics { get; set; }
                public class ListDisasterRecoveryItemsResponseBodyDataListTopics : TeaModel {
                    /// <term><b>Obsolete</b></term>
                    /// 
                    /// <summary>
                    /// <para>The ID of the consumer group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>group-test</para>
                    /// </summary>
                    [NameInMap("consumerGroupId")]
                    [Validation(Required=false)]
                    [Obsolete]
                    public string ConsumerGroupId { get; set; }

                    /// <summary>
                    /// <para>The method used to deliver messages to the destination instance.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Concurrently: concurrent delivery</description></item>
                    /// <item><description>Orderly: ordered delivery</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Concurrently</para>
                    /// </summary>
                    [NameInMap("deliveryOrderType")]
                    [Validation(Required=false)]
                    public string DeliveryOrderType { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rmq-cn-kh43w0olz0c</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The instance type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ALIYUN_ROCKETMQ</para>
                    /// </summary>
                    [NameInMap("instanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// <para>regionId</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("regionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The topic name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>topic-test</para>
                    /// </summary>
                    [NameInMap("topicName")]
                    [Validation(Required=false)]
                    public string TopicName { get; set; }

                }

                /// <summary>
                /// <para>The time when the query task was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-04 02:19:44</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The scroll ID of the request. The ID is automatically generated by the system. The result can be paginated only if this parameter is included in the pagination request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B13D0B07-F24B-4790-88D8-D47A38063D00</para>
            /// </summary>
            [NameInMap("scrollId")]
            [Validation(Required=false)]
            public string ScrollId { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceId</para>
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instanceId</para>
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C115601B-8736-5BBF-AC99-7FEAE12xxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

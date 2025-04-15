// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetDisasterRecoveryItemResponseBody : TeaModel {
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
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDisasterRecoveryItemResponseBodyData Data { get; set; }
        public class GetDisasterRecoveryItemResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the topic mapping task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-24 02:57:31</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Additional Information</para>
            /// </summary>
            [NameInMap("extInfo")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtInfo { get; set; }

            /// <summary>
            /// <para>The ID of the topic mapping</para>
            /// 
            /// <b>Example:</b>
            /// <para>100070284</para>
            /// </summary>
            [NameInMap("itemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            /// <summary>
            /// <para>The topic mapping task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("itemStatus")]
            [Validation(Required=false)]
            public string ItemStatus { get; set; }

            /// <summary>
            /// <para>The ID of the global message backup plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1300000016</para>
            /// </summary>
            [NameInMap("planId")]
            [Validation(Required=false)]
            public long? PlanId { get; set; }

            /// <summary>
            /// <para>Topics included in the backup mapping</para>
            /// </summary>
            [NameInMap("topics")]
            [Validation(Required=false)]
            public List<GetDisasterRecoveryItemResponseBodyDataTopics> Topics { get; set; }
            public class GetDisasterRecoveryItemResponseBodyDataTopics : TeaModel {
                /// <summary>
                /// <para>The consumer group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx_reserve_group</para>
                /// </summary>
                [NameInMap("consumerGroupId")]
                [Validation(Required=false)]
                public string ConsumerGroupId { get; set; }

                /// <summary>
                /// <para>The order in which messages are delivered to the target instance. The parameter values ​​are as follows:</para>
                /// <list type="bullet">
                /// <item><description>Concurrently: concurrent delivery</description></item>
                /// <item><description>Orderly: sequential delivery</description></item>
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
                /// <para>rmq-cn-wwo3xxx</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Instance type</para>
                /// <list type="bullet">
                /// <item><description>ALIYUN_ROCKETMQ: Alibaba Cloud instance</description></item>
                /// <item><description>EXTERNAL_ROCKETMQ: External instance, open-source instance, open-source cluster</description></item>
                /// </list>
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
                /// <para>order_push_xxx</para>
                /// </summary>
                [NameInMap("topicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

            }

            /// <summary>
            /// <para>The time when the topic mapping task was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-26 02:13:10</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

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
        /// <para>The HTTP status code.</para>
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
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>AF9A8B10-C426-530F-A0DD-96320B39****</para>
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

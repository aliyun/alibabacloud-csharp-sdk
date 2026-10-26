// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetConsumerGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The fault code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidConsumerGroupId</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetConsumerGroupResponseBodyData Data { get; set; }
        public class GetConsumerGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The consumption retry policy of the consumer group. For more information, see <a href="https://help.aliyun.com/document_detail/440356.html">Consumption retry</a>.</para>
            /// </summary>
            [NameInMap("consumeRetryPolicy")]
            [Validation(Required=false)]
            public GetConsumerGroupResponseBodyDataConsumeRetryPolicy ConsumeRetryPolicy { get; set; }
            public class GetConsumerGroupResponseBodyDataConsumeRetryPolicy : TeaModel {
                /// <summary>
                /// <para>The dead-letter topic.</para>
                /// <para>If a consumer fails to consume a message due to an exception and the message still cannot be consumed after retries, the message is delivered to the dead-letter topic for subsequent business recovery or review. For more information, see <a href="https://help.aliyun.com/document_detail/440356.html">Consumption retry and dead-letter messages</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DLQ_mqtest</para>
                /// </summary>
                [NameInMap("deadLetterTargetTopic")]
                [Validation(Required=false)]
                public string DeadLetterTargetTopic { get; set; }

                /// <summary>
                /// <para>The fixed retry interval. Unit: seconds.</para>
                /// <list type="bullet">
                /// <item><description>Concurrently (concurrent delivery): 10-1800</description></item>
                /// <item><description>Orderly (ordered delivery): 1-600</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("fixedIntervalRetryTime")]
                [Validation(Required=false)]
                public int? FixedIntervalRetryTime { get; set; }

                /// <summary>
                /// <para>The maximum number of retry attempts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("maxRetryTimes")]
                [Validation(Required=false)]
                public int? MaxRetryTimes { get; set; }

                /// <summary>
                /// <para>The retry policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DefaultRetryPolicy</para>
                /// </summary>
                [NameInMap("retryPolicy")]
                [Validation(Required=false)]
                public string RetryPolicy { get; set; }

            }

            /// <summary>
            /// <para>The ID of the consumer group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CID-TEST</para>
            /// </summary>
            [NameInMap("consumerGroupId")]
            [Validation(Required=false)]
            public string ConsumerGroupId { get; set; }

            /// <summary>
            /// <para>The time when the consumer group was created, in the format of YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-01 20:05:50</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The delivery order of the consumer group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Concurrently</para>
            /// </summary>
            [NameInMap("deliveryOrderType")]
            [Validation(Required=false)]
            public string DeliveryOrderType { get; set; }

            /// <summary>
            /// <para>Indicates whether exclusive consumption is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("exclusive")]
            [Validation(Required=false)]
            public bool? Exclusive { get; set; }

            /// <summary>
            /// <para>The ID of the instance to which the consumer group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq-cn-7e22ody****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The maximum TPS for consuming messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("maxReceiveTps")]
            [Validation(Required=false)]
            public long? MaxReceiveTps { get; set; }

            /// <summary>
            /// <para>The consumption pattern. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CLUSTERING: clustering consumption.</description></item>
            /// <item><description>LITE_SELECTIVE: LITE_SELECTIVE.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LITE_SELECTIVE</para>
            /// </summary>
            [NameInMap("messageModel")]
            [Validation(Required=false)]
            public string MessageModel { get; set; }

            /// <summary>
            /// <para>The region ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The remarks of the consumer group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is the remark for test.</para>
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The status of the consumer group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The topic name for the lite type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("topicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

            /// <summary>
            /// <para>The time when the consumer group was last updated, in the format of YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-01 20:05:50</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The dynamic fault code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ConsumerGroupId</para>
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic fault message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>consumerGroupId</para>
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The fault message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter consumerGroupId is invalid.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. Each request has a unique ID, which can be used to troubleshoot and locate faults.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7F94090-3358-506A-97DC-34BC803C****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the execute operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class CreateConsumerGroupRequest : TeaModel {
        /// <summary>
        /// <para>The consumption retry policy of the consumer group to be created. For more information, see <a href="https://help.aliyun.com/document_detail/440356.html">Consumption retry</a>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("consumeRetryPolicy")]
        [Validation(Required=false)]
        public CreateConsumerGroupRequestConsumeRetryPolicy ConsumeRetryPolicy { get; set; }
        public class CreateConsumerGroupRequestConsumeRetryPolicy : TeaModel {
            /// <summary>
            /// <para>The dead-letter topic.</para>
            /// <para>If a consumer fails to consume a message and the message still failed after retries, the message is delivered to the dead-letter topic for subsequent business recovery or backtracking. For more information, see <a href="https://help.aliyun.com/document_detail/440356.html">Consumption retry and dead-letter messages</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DLQ_mqtest</para>
            /// </summary>
            [NameInMap("deadLetterTargetTopic")]
            [Validation(Required=false)]
            public string DeadLetterTargetTopic { get; set; }

            /// <summary>
            /// <para>The fixed retry interval, in seconds. This parameter takes effect when the retry policy is set to FixedRetryPolicy.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Concurrent delivery: 10 to 1800</description></item>
            /// <item><description>Ordered delivery: 1 to 600</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
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
            /// <para>The retry policy type. For more information, see <a href="https://help.aliyun.com/document_detail/440356.html">Message retry</a>.</para>
            /// <para>Valid parameter values:</para>
            /// <list type="bullet">
            /// <item><description>FixedRetryPolicy: fixed-interval retry, supported only for ordered delivery</description></item>
            /// <item><description>DefaultRetryPolicy: progressive backoff retry, supported only for concurrent delivery</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DefaultRetryPolicy</para>
            /// </summary>
            [NameInMap("retryPolicy")]
            [Validation(Required=false)]
            public string RetryPolicy { get; set; }

        }

        /// <summary>
        /// <para>The delivery order type of the consumer group to be created.</para>
        /// <para>Valid parameter values:</para>
        /// <list type="bullet">
        /// <item><description>Concurrently: concurrent delivery</description></item>
        /// <item><description>Orderly: ordered delivery</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Concurrently</para>
        /// </summary>
        [NameInMap("deliveryOrderType")]
        [Validation(Required=false)]
        public string DeliveryOrderType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable exclusive subscription, which means a LiteTopic can only be subscribed to by one consumer. Set to true to enable or false to shutdown.</para>
        /// </summary>
        [NameInMap("exclusive")]
        [Validation(Required=false)]
        public bool? Exclusive { get; set; }

        /// <summary>
        /// <para>The maximum TPS for consuming messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("maxReceiveTps")]
        [Validation(Required=false)]
        public long? MaxReceiveTps { get; set; }

        /// <summary>
        /// <para>The subscribe pattern for consumers:</para>
        /// <list type="bullet">
        /// <item><description>CLUSTERING: clustering consumption pattern. All consumers in the ConsumerGroup share the same subscription.</description></item>
        /// <item><description>LITE_SELECTIVE: lightweight consumption pattern. Consumers in the ConsumerGroup can have different subscriptions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LITE_SELECTIVE</para>
        /// </summary>
        [NameInMap("messageModel")]
        [Validation(Required=false)]
        public string MessageModel { get; set; }

        /// <summary>
        /// <para>The remarks for the consumer group to be created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is the remark for test.</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The name of the lite-type topic to subscribe to when using the LITE_SELECTIVE consumption pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liteTopicTest</para>
        /// </summary>
        [NameInMap("topicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}

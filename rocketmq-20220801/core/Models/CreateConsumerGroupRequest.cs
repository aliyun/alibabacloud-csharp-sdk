// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class CreateConsumerGroupRequest : TeaModel {
        /// <summary>
        /// <para>The consumption retry policy of the consumer group. For more information, see <a href="https://help.aliyun.com/document_detail/440356.html">Consumption retry</a>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("consumeRetryPolicy")]
        [Validation(Required=false)]
        public CreateConsumerGroupRequestConsumeRetryPolicy ConsumeRetryPolicy { get; set; }
        public class CreateConsumerGroupRequestConsumeRetryPolicy : TeaModel {
            /// <summary>
            /// <para>The dead-letter topic.</para>
            /// <para>If a message still fails to be consumed after the maximum number of retries specified in the consumption retry policy is reached, the message is delivered to the dead-letter topic for subsequent business recovery or backtracking. For more information, see <a href="https://help.aliyun.com/document_detail/440356.html">Consumption retry and dead-letter messages</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DLQ_mqtest</para>
            /// </summary>
            [NameInMap("deadLetterTargetTopic")]
            [Validation(Required=false)]
            public string DeadLetterTargetTopic { get; set; }

            /// <summary>
            /// <para>The fixed interval. Unit: seconds. This parameter takes effect only if you set retryPolicy to FixedRetryPolicy. Valid values:</para>
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
            /// <para>The maximum number of retries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("maxRetryTimes")]
            [Validation(Required=false)]
            public int? MaxRetryTimes { get; set; }

            /// <summary>
            /// <para>The retry policy. For more information, see <a href="https://help.aliyun.com/document_detail/440356.html">Message retry</a>.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FixedRetryPolicy: fixed-interval retry. This value is valid only if you set deliveryOrderType to Orderly.</description></item>
            /// <item><description>DefaultRetryPolicy: exponential backoff retry. This value is valid only if you set deliveryOrderType to Concurrently.</description></item>
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
        /// <para>The message delivery method of the consumer group.</para>
        /// <para>Valid values:</para>
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
        /// <para>The maximum number of messages that can be processed by consumers per second.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("maxReceiveTps")]
        [Validation(Required=false)]
        public long? MaxReceiveTps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CLUSTERING</para>
        /// </summary>
        [NameInMap("messageModel")]
        [Validation(Required=false)]
        public string MessageModel { get; set; }

        /// <summary>
        /// <para>The description of the consumer group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is the remark for test.</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("topicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}

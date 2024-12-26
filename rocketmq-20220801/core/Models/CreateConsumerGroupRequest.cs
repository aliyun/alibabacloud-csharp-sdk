// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class CreateConsumerGroupRequest : TeaModel {
        /// <summary>
        /// <para>The consumption retry policy that you want to configure for the consumer group. For more information, see <a href="https://help.aliyun.com/document_detail/440356.html">Consumption retry</a>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("consumeRetryPolicy")]
        [Validation(Required=false)]
        public CreateConsumerGroupRequestConsumeRetryPolicy ConsumeRetryPolicy { get; set; }
        public class CreateConsumerGroupRequestConsumeRetryPolicy : TeaModel {
            /// <summary>
            /// <para>The dead-letter topic.</para>
            /// <para>If a consumer still fails to consume a message after the message is retried for a specified number of times, the message is delivered to a dead-letter topic for subsequent business recovery or troubleshooting. For more information, see <a href="https://help.aliyun.com/document_detail/440356.html">Consumption retry and dead-letter messages</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DLQ_mqtest</para>
            /// </summary>
            [NameInMap("deadLetterTargetTopic")]
            [Validation(Required=false)]
            public string DeadLetterTargetTopic { get; set; }

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
            /// <item><description>FixedRetryPolicy: Failed messages are retried at a fixed interval.</description></item>
            /// <item><description>DefaultRetryPolicy: Failed messages are retried at incremental intervals as the number of retries increases.</description></item>
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
        /// <para>The message delivery order of the consumer group.</para>
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

        [NameInMap("maxReceiveTps")]
        [Validation(Required=false)]
        public long? MaxReceiveTps { get; set; }

        /// <summary>
        /// <para>The remarks on the consumer group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is the remark for test.</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}

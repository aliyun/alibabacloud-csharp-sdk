// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class UpdateConsumerGroupRequest : TeaModel {
        /// <summary>
        /// <para>The updated consumption retry policy of the consumer group. For more information, see <a href="https://help.aliyun.com/document_detail/440356.html">Consumption retry</a>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("consumeRetryPolicy")]
        [Validation(Required=false)]
        public UpdateConsumerGroupRequestConsumeRetryPolicy ConsumeRetryPolicy { get; set; }
        public class UpdateConsumerGroupRequestConsumeRetryPolicy : TeaModel {
            /// <summary>
            /// <para>The dead-letter topic.</para>
            /// <para>If a consumer fails to consume a message and the message still fails after retries, the message is delivered to the dead-letter topic for subsequent business recovery or review. For more information, see <a href="https://help.aliyun.com/document_detail/440356.html">Consumption retry and dead-letter messages</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DLQ_mqtest</para>
            /// </summary>
            [NameInMap("deadLetterTargetTopic")]
            [Validation(Required=false)]
            public string DeadLetterTargetTopic { get; set; }

            /// <summary>
            /// <para>The fixed retry interval. Unit: seconds. This parameter takes effect only when the retry policy is set to FixedRetryPolicy (fixed-interval retry).
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Concurrent delivery: 10-1800</description></item>
            /// <item><description>Ordered delivery: 1-600</description></item>
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
            /// <para>The retry policy type. For more information, see <a href="https://help.aliyun.com/document_detail/440356.html">Message retry</a>.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FixedRetryPolicy: fixed-interval retry. Only ordered delivery is supported.</description></item>
            /// <item><description>DefaultRetryPolicy: incremental backoff retry. Only concurrent delivery is supported.</description></item>
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

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Modification is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Concurrently</para>
        /// </summary>
        [NameInMap("deliveryOrderType")]
        [Validation(Required=false)]
        [Obsolete]
        public string DeliveryOrderType { get; set; }

        /// <summary>
        /// <para>The upper limit of TPS for consuming messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("maxReceiveTps")]
        [Validation(Required=false)]
        public long? MaxReceiveTps { get; set; }

        /// <summary>
        /// <para>The updated remarks of the consumer group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is the remark for test.</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class CreateConsumerGroupRequest : TeaModel {
        /// <summary>
        /// The consumption retry policy that you want to configure for the consumer group. For more information, see [Consumption retry](https://help.aliyun.com/document_detail/440356.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("consumeRetryPolicy")]
        [Validation(Required=false)]
        public CreateConsumerGroupRequestConsumeRetryPolicy ConsumeRetryPolicy { get; set; }
        public class CreateConsumerGroupRequestConsumeRetryPolicy : TeaModel {
            /// <summary>
            /// The dead-letter topic.
            /// 
            /// If a consumer still fails to consume a message after the message is retried for a specified number of times, the message is delivered to a dead-letter topic for subsequent business recovery or troubleshooting. For more information, see [Consumption retry and dead-letter messages](https://help.aliyun.com/document_detail/440356.html).
            /// </summary>
            [NameInMap("deadLetterTargetTopic")]
            [Validation(Required=false)]
            public string DeadLetterTargetTopic { get; set; }

            /// <summary>
            /// The maximum number of retries.
            /// </summary>
            [NameInMap("maxRetryTimes")]
            [Validation(Required=false)]
            public int? MaxRetryTimes { get; set; }

            /// <summary>
            /// The retry policy. For more information, see [Message retry](https://help.aliyun.com/document_detail/440356.html).
            /// 
            /// Valid values:
            /// 
            /// *   FixedRetryPolicy: Failed messages are retried at a fixed interval.
            /// *   DefaultRetryPolicy: Failed messages are retried at incremental intervals as the number of retries increases.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("retryPolicy")]
            [Validation(Required=false)]
            public string RetryPolicy { get; set; }

        }

        /// <summary>
        /// The message delivery order of the consumer group.
        /// 
        /// Valid values:
        /// 
        /// *   Concurrently: concurrent delivery
        /// *   Orderly: ordered delivery
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("deliveryOrderType")]
        [Validation(Required=false)]
        public string DeliveryOrderType { get; set; }

        /// <summary>
        /// The remarks on the consumer group.
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}

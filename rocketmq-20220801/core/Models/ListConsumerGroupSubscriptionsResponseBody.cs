// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListConsumerGroupSubscriptionsResponseBody : TeaModel {
        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListConsumerGroupSubscriptionsResponseBodyData> Data { get; set; }
        public class ListConsumerGroupSubscriptionsResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether message consumption is consistent. Valid values:
            /// 
            /// *   false: Unconsumed messages exist in the consumer group.
            /// *   true: No unconsumed message exists in the consumer group.
            /// </summary>
            [NameInMap("consistency")]
            [Validation(Required=false)]
            public bool? Consistency { get; set; }

            /// <summary>
            /// The ID of the consumer group.
            /// </summary>
            [NameInMap("consumerGroupId")]
            [Validation(Required=false)]
            public string ConsumerGroupId { get; set; }

            /// <summary>
            /// The filter expression.
            /// </summary>
            [NameInMap("filterExpression")]
            [Validation(Required=false)]
            public string FilterExpression { get; set; }

            /// <summary>
            /// The type of the filter expression. Valid values:
            /// 
            /// *   SQL: filters messages by using SQL expressions.
            /// *   TAG: filters messages by using tags.
            /// </summary>
            [NameInMap("filterExpressionType")]
            [Validation(Required=false)]
            public string FilterExpressionType { get; set; }

            /// <summary>
            /// The consumption mode of the consumer group. Valid values:
            /// 
            /// *   BROADCASTING: broadcasting consumption
            /// *   CLUSTERING: clustering consumption
            /// </summary>
            [NameInMap("messageModel")]
            [Validation(Required=false)]
            public string MessageModel { get; set; }

            /// <summary>
            /// The subscription status. Valid values:
            /// 
            /// *   ONLINE: The consumer group is online. If the consumer group contains multiple consumers, this value is returned as long as one of the consumers is online.
            /// *   OFFLINE: The consumer group is offline. If the consumer group contains multiple consumers, this value is returned only if all consumers are offline.
            /// </summary>
            [NameInMap("subscriptionStatus")]
            [Validation(Required=false)]
            public string SubscriptionStatus { get; set; }

            /// <summary>
            /// Indicates whether the topic is created.
            /// </summary>
            [NameInMap("topicCreated")]
            [Validation(Required=false)]
            public bool? TopicCreated { get; set; }

            /// <summary>
            /// The topic to which the consumer group subscribes.
            /// </summary>
            [NameInMap("topicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

        }

        /// <summary>
        /// The dynamic error code.
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// The dynamic error message.
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

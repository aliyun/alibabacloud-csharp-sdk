// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListConsumerGroupSubscriptionsResponseBody : TeaModel {
        /// <summary>
        /// The returned error code.
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
            /// The consumer group ID.
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
            /// The type of the filter expression. Valid values: SQL, TAG, and UNSPECIFIED.
            /// </summary>
            [NameInMap("filterExpressionType")]
            [Validation(Required=false)]
            public string FilterExpressionType { get; set; }

            /// <summary>
            /// The consumption mode. Valid values: BROADCASTING and CLUSTERING.
            /// </summary>
            [NameInMap("messageModel")]
            [Validation(Required=false)]
            public string MessageModel { get; set; }

            /// <summary>
            /// The subscription status. Valid values: ONLINE and OFFLINE.
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
        /// The returned dynamic error code.
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// The returned dynamic error message.
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// The returned HTTP status code.
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The returned error message.
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
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

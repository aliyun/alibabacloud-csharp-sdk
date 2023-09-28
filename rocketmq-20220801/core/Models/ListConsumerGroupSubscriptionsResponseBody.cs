// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListConsumerGroupSubscriptionsResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListConsumerGroupSubscriptionsResponseBodyData> Data { get; set; }
        public class ListConsumerGroupSubscriptionsResponseBodyData : TeaModel {
            [NameInMap("consumerGroupId")]
            [Validation(Required=false)]
            public string ConsumerGroupId { get; set; }

            [NameInMap("filterExpression")]
            [Validation(Required=false)]
            public string FilterExpression { get; set; }

            [NameInMap("filterExpressionType")]
            [Validation(Required=false)]
            public string FilterExpressionType { get; set; }

            [NameInMap("messageModel")]
            [Validation(Required=false)]
            public string MessageModel { get; set; }

            [NameInMap("subscriptionStatus")]
            [Validation(Required=false)]
            public string SubscriptionStatus { get; set; }

            [NameInMap("topicCreated")]
            [Validation(Required=false)]
            public bool? TopicCreated { get; set; }

            [NameInMap("topicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

        }

        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

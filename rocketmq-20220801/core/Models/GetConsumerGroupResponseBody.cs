// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetConsumerGroupResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetConsumerGroupResponseBodyData Data { get; set; }
        public class GetConsumerGroupResponseBodyData : TeaModel {
            [NameInMap("consumeRetryPolicy")]
            [Validation(Required=false)]
            public GetConsumerGroupResponseBodyDataConsumeRetryPolicy ConsumeRetryPolicy { get; set; }
            public class GetConsumerGroupResponseBodyDataConsumeRetryPolicy : TeaModel {
                [NameInMap("deadLetterTargetTopic")]
                [Validation(Required=false)]
                public string DeadLetterTargetTopic { get; set; }

                [NameInMap("maxRetryTimes")]
                [Validation(Required=false)]
                public int? MaxRetryTimes { get; set; }

                [NameInMap("retryPolicy")]
                [Validation(Required=false)]
                public string RetryPolicy { get; set; }

            }

            [NameInMap("consumerGroupId")]
            [Validation(Required=false)]
            public string ConsumerGroupId { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("deliveryOrderType")]
            [Validation(Required=false)]
            public string DeliveryOrderType { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

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

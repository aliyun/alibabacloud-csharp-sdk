// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class CreateConsumerGroupRequest : TeaModel {
        [NameInMap("consumeRetryPolicy")]
        [Validation(Required=false)]
        public CreateConsumerGroupRequestConsumeRetryPolicy ConsumeRetryPolicy { get; set; }
        public class CreateConsumerGroupRequestConsumeRetryPolicy : TeaModel {
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

        [NameInMap("deliveryOrderType")]
        [Validation(Required=false)]
        public string DeliveryOrderType { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}

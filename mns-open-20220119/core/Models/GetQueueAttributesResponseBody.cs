// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class GetQueueAttributesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQueueAttributesResponseBodyData Data { get; set; }
        public class GetQueueAttributesResponseBodyData : TeaModel {
            [NameInMap("ActiveMessages")]
            [Validation(Required=false)]
            public long? ActiveMessages { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("DelayMessages")]
            [Validation(Required=false)]
            public long? DelayMessages { get; set; }

            [NameInMap("DelaySeconds")]
            [Validation(Required=false)]
            public long? DelaySeconds { get; set; }

            [NameInMap("InactiveMessages")]
            [Validation(Required=false)]
            public long? InactiveMessages { get; set; }

            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public long? LastModifyTime { get; set; }

            [NameInMap("LoggingEnabled")]
            [Validation(Required=false)]
            public bool? LoggingEnabled { get; set; }

            [NameInMap("MaximumMessageSize")]
            [Validation(Required=false)]
            public long? MaximumMessageSize { get; set; }

            [NameInMap("MessageRetentionPeriod")]
            [Validation(Required=false)]
            public long? MessageRetentionPeriod { get; set; }

            [NameInMap("PollingWaitSeconds")]
            [Validation(Required=false)]
            public long? PollingWaitSeconds { get; set; }

            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            [NameInMap("VisibilityTimeout")]
            [Validation(Required=false)]
            public long? VisibilityTimeout { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

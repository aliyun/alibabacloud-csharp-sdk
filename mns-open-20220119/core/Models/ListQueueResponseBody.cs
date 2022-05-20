// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class ListQueueResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListQueueResponseBodyData Data { get; set; }
        public class ListQueueResponseBodyData : TeaModel {
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<ListQueueResponseBodyDataPageData> PageData { get; set; }
            public class ListQueueResponseBodyDataPageData : TeaModel {
                public long? ActiveMessages { get; set; }
                public long? CreateTime { get; set; }
                public long? DelayMessages { get; set; }
                public long? DelaySeconds { get; set; }
                public long? InactiveMessages { get; set; }
                public long? LastModifyTime { get; set; }
                public bool? LoggingEnabled { get; set; }
                public long? MaximumMessageSize { get; set; }
                public long? MessageRetentionPeriod { get; set; }
                public long? PollingWaitSeconds { get; set; }
                public string QueueInternalUrl { get; set; }
                public string QueueName { get; set; }
                public string QueueUrl { get; set; }
                public long? VisibilityTimeout { get; set; }
            }
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Pages")]
            [Validation(Required=false)]
            public long? Pages { get; set; }
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
        };

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

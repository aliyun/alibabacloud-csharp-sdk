// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListAppEventsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAppEventsResponseBodyData Data { get; set; }
        public class ListAppEventsResponseBodyData : TeaModel {
            [NameInMap("AppEventEntity")]
            [Validation(Required=false)]
            public List<ListAppEventsResponseBodyDataAppEventEntity> AppEventEntity { get; set; }
            public class ListAppEventsResponseBodyDataAppEventEntity : TeaModel {
                public string EventType { get; set; }
                public string FirstTimestamp { get; set; }
                public string LastTimestamp { get; set; }
                public string Message { get; set; }
                public string ObjectKind { get; set; }
                public string ObjectName { get; set; }
                public string Reason { get; set; }
            }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

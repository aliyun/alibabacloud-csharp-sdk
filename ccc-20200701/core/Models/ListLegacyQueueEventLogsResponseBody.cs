// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListLegacyQueueEventLogsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListLegacyQueueEventLogsResponseBodyData Data { get; set; }
        public class ListLegacyQueueEventLogsResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListLegacyQueueEventLogsResponseBodyDataList> List { get; set; }
            public class ListLegacyQueueEventLogsResponseBodyDataList : TeaModel {
                public string Acid { get; set; }
                public string Ani { get; set; }
                public string AnswerPhone { get; set; }
                public long? AnswerTime { get; set; }
                public string Cause { get; set; }
                public string Dnis { get; set; }
                public long? QueueTime { get; set; }
                public string StatisticDate { get; set; }
                public string TenantId { get; set; }
                public string Vq { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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

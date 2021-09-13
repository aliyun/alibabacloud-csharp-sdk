// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListRecentCallDetailRecordsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRecentCallDetailRecordsResponseBodyData Data { get; set; }
        public class ListRecentCallDetailRecordsResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListRecentCallDetailRecordsResponseBodyDataList> List { get; set; }
            public class ListRecentCallDetailRecordsResponseBodyDataList : TeaModel {
                public long? StartTime { get; set; }
                public string ContactDisposition { get; set; }
                public string ContactType { get; set; }
                public string AgentIds { get; set; }
                public string ContactId { get; set; }
                public string CallDuration { get; set; }
                public string CallingNumber { get; set; }
                public long? Duration { get; set; }
                public string InstanceId { get; set; }
                public string CalledNumber { get; set; }
                public string SkillGroupIds { get; set; }
            }
        };

    }

}

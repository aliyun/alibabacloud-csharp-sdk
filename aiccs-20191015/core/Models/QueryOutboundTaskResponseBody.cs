// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryOutboundTaskResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryOutboundTaskResponseBodyData Data { get; set; }
        public class QueryOutboundTaskResponseBodyData : TeaModel {
            [NameInMap("TotalResults")]
            [Validation(Required=false)]
            public string TotalResults { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public string CurrentPage { get; set; }
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryOutboundTaskResponseBodyDataList> List { get; set; }
            public class QueryOutboundTaskResponseBodyDataList : TeaModel {
                public int? Status { get; set; }
                public int? Type { get; set; }
                public string EndDate { get; set; }
                public int? RetryTime { get; set; }
                public int? RetryInterval { get; set; }
                public string StartDate { get; set; }
                public long? GmtModified { get; set; }
                public string Creator { get; set; }
                public string EndTime { get; set; }
                public string StartTime { get; set; }
                public int? Model { get; set; }
                public long? BuId { get; set; }
                public string Modifier { get; set; }
                public string GroupName { get; set; }
                public string Description { get; set; }
                public long? DepartmentId { get; set; }
                public long? GmtCreate { get; set; }
                public long? SkillGroup { get; set; }
                public string Name { get; set; }
                public string ExtAttrs { get; set; }
                public string CallerNum { get; set; }
                public long? Id { get; set; }
            }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}

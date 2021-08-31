// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryTaskDetailResponseBody : TeaModel {
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTaskDetailResponseBodyData Data { get; set; }
        public class QueryTaskDetailResponseBodyData : TeaModel {
            [NameInMap("TotalResults")]
            [Validation(Required=false)]
            public string TotalResults { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public string CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryTaskDetailResponseBodyDataList> List { get; set; }
            public class QueryTaskDetailResponseBodyDataList : TeaModel {
                public int? Status { get; set; }
                public string ServicerName { get; set; }
                public string MemberName { get; set; }
                public int? OutboundNum { get; set; }
                public string RetryTime { get; set; }
                public int? Priority { get; set; }
                public long? GmtModified { get; set; }
                public string Dnis { get; set; }
                public long? ServicerId { get; set; }
                public long? OutboundTaskId { get; set; }
                public long? BuId { get; set; }
                public int? EndReason { get; set; }
                public long? GmtCreate { get; set; }
                public long? DepartmentId { get; set; }
                public string Ani { get; set; }
                public long? MemberId { get; set; }
                public int? SkillGroup { get; set; }
                public string ExtAttrs { get; set; }
                public int? Id { get; set; }
            }
        };

    }

}

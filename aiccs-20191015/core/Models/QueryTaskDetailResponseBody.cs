// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryTaskDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTaskDetailResponseBodyData Data { get; set; }
        public class QueryTaskDetailResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public string CurrentPage { get; set; }

            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryTaskDetailResponseBodyDataList> List { get; set; }
            public class QueryTaskDetailResponseBodyDataList : TeaModel {
                [NameInMap("Ani")]
                [Validation(Required=false)]
                public string Ani { get; set; }

                [NameInMap("BuId")]
                [Validation(Required=false)]
                public long? BuId { get; set; }

                [NameInMap("DepartmentId")]
                [Validation(Required=false)]
                public long? DepartmentId { get; set; }

                [NameInMap("Dnis")]
                [Validation(Required=false)]
                public string Dnis { get; set; }

                [NameInMap("EndReason")]
                [Validation(Required=false)]
                public int? EndReason { get; set; }

                [NameInMap("ExtAttrs")]
                [Validation(Required=false)]
                public string ExtAttrs { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                [NameInMap("MemberId")]
                [Validation(Required=false)]
                public long? MemberId { get; set; }

                [NameInMap("MemberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                [NameInMap("OutboundNum")]
                [Validation(Required=false)]
                public int? OutboundNum { get; set; }

                [NameInMap("OutboundTaskId")]
                [Validation(Required=false)]
                public long? OutboundTaskId { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("RetryTime")]
                [Validation(Required=false)]
                public string RetryTime { get; set; }

                [NameInMap("ServicerId")]
                [Validation(Required=false)]
                public long? ServicerId { get; set; }

                [NameInMap("ServicerName")]
                [Validation(Required=false)]
                public string ServicerName { get; set; }

                [NameInMap("SkillGroup")]
                [Validation(Required=false)]
                public int? SkillGroup { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            [NameInMap("TotalResults")]
            [Validation(Required=false)]
            public string TotalResults { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}

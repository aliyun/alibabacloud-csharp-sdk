// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryOutboundTaskResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryOutboundTaskResponseBodyData Data { get; set; }
        public class QueryOutboundTaskResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public string CurrentPage { get; set; }

            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryOutboundTaskResponseBodyDataList> List { get; set; }
            public class QueryOutboundTaskResponseBodyDataList : TeaModel {
                [NameInMap("BuId")]
                [Validation(Required=false)]
                public long? BuId { get; set; }

                [NameInMap("CallerNum")]
                [Validation(Required=false)]
                public string CallerNum { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("DepartmentId")]
                [Validation(Required=false)]
                public long? DepartmentId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("ExtAttrs")]
                [Validation(Required=false)]
                public string ExtAttrs { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Model")]
                [Validation(Required=false)]
                public int? Model { get; set; }

                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RetryInterval")]
                [Validation(Required=false)]
                public int? RetryInterval { get; set; }

                [NameInMap("RetryTime")]
                [Validation(Required=false)]
                public int? RetryTime { get; set; }

                [NameInMap("SkillGroup")]
                [Validation(Required=false)]
                public long? SkillGroup { get; set; }

                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

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

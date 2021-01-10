// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutTaskbykeywordResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetLinkeBahamutTaskbykeywordResponseBodyResult> Result { get; set; }
        public class GetLinkeBahamutTaskbykeywordResponseBodyResult : TeaModel {
            [NameInMap("AbortedBlocked")]
            [Validation(Required=false)]
            public bool? AbortedBlocked { get; set; }

            [NameInMap("Assignee")]
            [Validation(Required=false)]
            public string Assignee { get; set; }

            [NameInMap("AssigneeUser")]
            [Validation(Required=false)]
            public string AssigneeUser { get; set; }

            [NameInMap("Completed")]
            [Validation(Required=false)]
            public bool? Completed { get; set; }

            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            [NameInMap("Extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            [NameInMap("FinishedSuccessful")]
            [Validation(Required=false)]
            public bool? FinishedSuccessful { get; set; }

            [NameInMap("FlowStatus")]
            [Validation(Required=false)]
            public string FlowStatus { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("ObjectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            [NameInMap("ObjectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            [NameInMap("PortalUrl")]
            [Validation(Required=false)]
            public string PortalUrl { get; set; }

            [NameInMap("RecordCnName")]
            [Validation(Required=false)]
            public string RecordCnName { get; set; }

            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusName")]
            [Validation(Required=false)]
            public string StatusName { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("AppNames")]
            [Validation(Required=false)]
            public List<string> AppNames { get; set; }

            [NameInMap("AssigneeUsers")]
            [Validation(Required=false)]
            public List<string> AssigneeUsers { get; set; }

        }

        [NameInMap("Paginator")]
        [Validation(Required=false)]
        public GetLinkeBahamutTaskbykeywordResponseBodyPaginator Paginator { get; set; }
        public class GetLinkeBahamutTaskbykeywordResponseBodyPaginator : TeaModel {
            [NameInMap("ItemCount")]
            [Validation(Required=false)]
            public long? ItemCount { get; set; }
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public long? PageCount { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
        };

    }

}

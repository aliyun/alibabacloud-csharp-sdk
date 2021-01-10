// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListLinkeBahamutAoneinternalworkitemResponseBody : TeaModel {
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
        public List<ListLinkeBahamutAoneinternalworkitemResponseBodyResult> Result { get; set; }
        public class ListLinkeBahamutAoneinternalworkitemResponseBodyResult : TeaModel {
            [NameInMap("AkProjectId")]
            [Validation(Required=false)]
            public string AkProjectId { get; set; }

            [NameInMap("AssignedTo")]
            [Validation(Required=false)]
            public string AssignedTo { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            [NameInMap("OtherJson")]
            [Validation(Required=false)]
            public string OtherJson { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            [NameInMap("PriorityId")]
            [Validation(Required=false)]
            public string PriorityId { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("Stamp")]
            [Validation(Required=false)]
            public string Stamp { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusId")]
            [Validation(Required=false)]
            public string StatusId { get; set; }

            [NameInMap("StatusStage")]
            [Validation(Required=false)]
            public string StatusStage { get; set; }

            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("CfsList")]
            [Validation(Required=false)]
            public List<string> CfsList { get; set; }

        }

        [NameInMap("Paginator")]
        [Validation(Required=false)]
        public ListLinkeBahamutAoneinternalworkitemResponseBodyPaginator Paginator { get; set; }
        public class ListLinkeBahamutAoneinternalworkitemResponseBodyPaginator : TeaModel {
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

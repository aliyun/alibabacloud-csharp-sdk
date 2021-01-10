// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutGlobalreleaseResponseBody : TeaModel {
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
        public List<QueryLinkeBahamutGlobalreleaseResponseBodyResult> Result { get; set; }
        public class QueryLinkeBahamutGlobalreleaseResponseBodyResult : TeaModel {
            [NameInMap("AoneReleaseId")]
            [Validation(Required=false)]
            public string AoneReleaseId { get; set; }

            [NameInMap("AppGroupName")]
            [Validation(Required=false)]
            public string AppGroupName { get; set; }

            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("ExternalId")]
            [Validation(Required=false)]
            public string ExternalId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ReleaseDate")]
            [Validation(Required=false)]
            public long? ReleaseDate { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Managers")]
            [Validation(Required=false)]
            public List<string> Managers { get; set; }

        }

        [NameInMap("Paginator")]
        [Validation(Required=false)]
        public QueryLinkeBahamutGlobalreleaseResponseBodyPaginator Paginator { get; set; }
        public class QueryLinkeBahamutGlobalreleaseResponseBodyPaginator : TeaModel {
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

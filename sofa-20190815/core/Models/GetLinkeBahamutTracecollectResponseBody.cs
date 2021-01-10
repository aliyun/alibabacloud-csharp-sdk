// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutTracecollectResponseBody : TeaModel {
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
        public List<GetLinkeBahamutTracecollectResponseBodyResult> Result { get; set; }
        public class GetLinkeBahamutTracecollectResponseBodyResult : TeaModel {
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("SaveTime")]
            [Validation(Required=false)]
            public string SaveTime { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("TraceDescribe")]
            [Validation(Required=false)]
            public string TraceDescribe { get; set; }

            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

            [NameInMap("TraceName")]
            [Validation(Required=false)]
            public string TraceName { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        [NameInMap("Paginator")]
        [Validation(Required=false)]
        public GetLinkeBahamutTracecollectResponseBodyPaginator Paginator { get; set; }
        public class GetLinkeBahamutTracecollectResponseBodyPaginator : TeaModel {
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

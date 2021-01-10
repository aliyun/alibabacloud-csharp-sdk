// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutArchdomainappsResponseBody : TeaModel {
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
        public List<GetLinkeBahamutArchdomainappsResponseBodyResult> Result { get; set; }
        public class GetLinkeBahamutArchdomainappsResponseBodyResult : TeaModel {
            [NameInMap("AppGroupName")]
            [Validation(Required=false)]
            public string AppGroupName { get; set; }

            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            [NameInMap("FirstArchDomain")]
            [Validation(Required=false)]
            public string FirstArchDomain { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RecentLiveTime")]
            [Validation(Required=false)]
            public string RecentLiveTime { get; set; }

            [NameInMap("SecondArchDomain")]
            [Validation(Required=false)]
            public string SecondArchDomain { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Owners")]
            [Validation(Required=false)]
            public List<string> Owners { get; set; }

            [NameInMap("OwnerObjs")]
            [Validation(Required=false)]
            public List<string> OwnerObjs { get; set; }

        }

        [NameInMap("Paginator")]
        [Validation(Required=false)]
        public GetLinkeBahamutArchdomainappsResponseBodyPaginator Paginator { get; set; }
        public class GetLinkeBahamutArchdomainappsResponseBodyPaginator : TeaModel {
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

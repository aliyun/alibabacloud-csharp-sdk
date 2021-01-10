// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutQualitylogResponseBody : TeaModel {
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

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryLinkeBahamutQualitylogResponseBodyResult Result { get; set; }
        public class QueryLinkeBahamutQualitylogResponseBodyResult : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public long? PageCount { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryLinkeBahamutQualitylogResponseBodyResultData> Data { get; set; }
            public class QueryLinkeBahamutQualitylogResponseBodyResultData : TeaModel {
                public string CommitId { get; set; }
                public string Content { get; set; }
                public bool? IsCommitUpToDate { get; set; }
                public string Item { get; set; }
                public string Reason { get; set; }
                public long? UpdateAt { get; set; }
            }
        };

    }

}

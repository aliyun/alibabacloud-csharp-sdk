// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QueryShortUrlResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryShortUrlResponseBodyData Data { get; set; }
        public class QueryShortUrlResponseBodyData : TeaModel {
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }
            [NameInMap("PageViewCount")]
            [Validation(Required=false)]
            public string PageViewCount { get; set; }
            [NameInMap("ShortUrl")]
            [Validation(Required=false)]
            public string ShortUrl { get; set; }
            [NameInMap("ShortUrlName")]
            [Validation(Required=false)]
            public string ShortUrlName { get; set; }
            [NameInMap("ShortUrlStatus")]
            [Validation(Required=false)]
            public string ShortUrlStatus { get; set; }
            [NameInMap("SourceUrl")]
            [Validation(Required=false)]
            public string SourceUrl { get; set; }
            [NameInMap("UniqueVisitorCount")]
            [Validation(Required=false)]
            public string UniqueVisitorCount { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QueryShortUrlResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryShortUrlResponseData Data { get; set; }
        public class QueryShortUrlResponseData : TeaModel {
            [NameInMap("SourceUrl")]
            [Validation(Required=true)]
            public string SourceUrl { get; set; }
            [NameInMap("ShortUrlName")]
            [Validation(Required=true)]
            public string ShortUrlName { get; set; }
            [NameInMap("ShortUrlStatus")]
            [Validation(Required=true)]
            public string ShortUrlStatus { get; set; }
            [NameInMap("ShortUrl")]
            [Validation(Required=true)]
            public string ShortUrl { get; set; }
            [NameInMap("CreateDate")]
            [Validation(Required=true)]
            public string CreateDate { get; set; }
            [NameInMap("ExpireDate")]
            [Validation(Required=true)]
            public string ExpireDate { get; set; }
            [NameInMap("PageViewCount")]
            [Validation(Required=true)]
            public string PageViewCount { get; set; }
            [NameInMap("UniqueVisitorCount")]
            [Validation(Required=true)]
            public string UniqueVisitorCount { get; set; }
        };

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QueryPageSmartShortUrlLogResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public QueryPageSmartShortUrlLogResponseBodyModel Model { get; set; }
        public class QueryPageSmartShortUrlLogResponseBodyModel : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryPageSmartShortUrlLogResponseBodyModelList> List { get; set; }
            public class QueryPageSmartShortUrlLogResponseBodyModelList : TeaModel {
                [NameInMap("ClickState")]
                [Validation(Required=false)]
                public long? ClickState { get; set; }

                [NameInMap("ClickTime")]
                [Validation(Required=false)]
                public long? ClickTime { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                [NameInMap("ShortName")]
                [Validation(Required=false)]
                public string ShortName { get; set; }

                [NameInMap("ShortUrl")]
                [Validation(Required=false)]
                public string ShortUrl { get; set; }

            }

            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeDownloadUrlsForAppKeyResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

        [NameInMap("UrlResult")]
        [Validation(Required=false)]
        public DescribeDownloadUrlsForAppKeyResponseBodyUrlResult UrlResult { get; set; }
        public class DescribeDownloadUrlsForAppKeyResponseBodyUrlResult : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }
            [NameInMap("Urls")]
            [Validation(Required=false)]
            public DescribeDownloadUrlsForAppKeyResponseBodyUrlResultUrls Urls { get; set; }
            public class DescribeDownloadUrlsForAppKeyResponseBodyUrlResultUrls : TeaModel {
                [NameInMap("Android")]
                [Validation(Required=false)]
                public string Android { get; set; }

                [NameInMap("Wins")]
                [Validation(Required=false)]
                public string Wins { get; set; }

                [NameInMap("IOS")]
                [Validation(Required=false)]
                public string IOS { get; set; }

            }
        };

    }

}

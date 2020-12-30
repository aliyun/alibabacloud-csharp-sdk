// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DownloadAppKeyFileResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

        [NameInMap("DownloadLinkResult")]
        [Validation(Required=false)]
        public DownloadAppKeyFileResponseBodyDownloadLinkResult DownloadLinkResult { get; set; }
        public class DownloadAppKeyFileResponseBodyDownloadLinkResult : TeaModel {
            [NameInMap("DownloadLink")]
            [Validation(Required=false)]
            public string DownloadLink { get; set; }
        };

    }

}

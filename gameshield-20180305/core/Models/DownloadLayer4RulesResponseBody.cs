// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DownloadLayer4RulesResponseBody : TeaModel {
        [NameInMap("DownloadFileResult")]
        [Validation(Required=false)]
        public DownloadLayer4RulesResponseBodyDownloadFileResult DownloadFileResult { get; set; }
        public class DownloadLayer4RulesResponseBodyDownloadFileResult : TeaModel {
            [NameInMap("DownloadLink")]
            [Validation(Required=false)]
            public string DownloadLink { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

    }

}

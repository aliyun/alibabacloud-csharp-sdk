// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class GenerateSdkDownloadInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SdkDownloadInfo")]
        [Validation(Required=false)]
        public GenerateSdkDownloadInfoResponseBodySdkDownloadInfo SdkDownloadInfo { get; set; }
        public class GenerateSdkDownloadInfoResponseBodySdkDownloadInfo : TeaModel {
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }
        };

    }

}

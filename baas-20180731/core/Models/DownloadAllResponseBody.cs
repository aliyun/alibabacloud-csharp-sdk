// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DownloadAllResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DownloadAllResponseBodyResult Result { get; set; }
        public class DownloadAllResponseBodyResult : TeaModel {
            [NameInMap("BizviewUrl")]
            [Validation(Required=false)]
            public string BizviewUrl { get; set; }

            [NameInMap("CertUrl")]
            [Validation(Required=false)]
            public string CertUrl { get; set; }

            [NameInMap("SdkUrl")]
            [Validation(Required=false)]
            public string SdkUrl { get; set; }

        }

    }

}

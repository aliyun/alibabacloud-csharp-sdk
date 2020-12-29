// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class ApplyAntChainCertificateWithKeyAutoCreationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ApplyAntChainCertificateWithKeyAutoCreationResponseBodyResult Result { get; set; }
        public class ApplyAntChainCertificateWithKeyAutoCreationResponseBodyResult : TeaModel {
            [NameInMap("PrivateKey")]
            [Validation(Required=false)]
            public string PrivateKey { get; set; }
            [NameInMap("DownloadPath")]
            [Validation(Required=false)]
            public ApplyAntChainCertificateWithKeyAutoCreationResponseBodyResultDownloadPath DownloadPath { get; set; }
            public class ApplyAntChainCertificateWithKeyAutoCreationResponseBodyResultDownloadPath : TeaModel {
                [NameInMap("CaCrtUrl")]
                [Validation(Required=false)]
                public string CaCrtUrl { get; set; }

                [NameInMap("SdkUrl")]
                [Validation(Required=false)]
                public string SdkUrl { get; set; }

                [NameInMap("ClientCrtUrl")]
                [Validation(Required=false)]
                public string ClientCrtUrl { get; set; }

                [NameInMap("TrustCaUrl")]
                [Validation(Required=false)]
                public string TrustCaUrl { get; set; }

            }
        };

    }

}

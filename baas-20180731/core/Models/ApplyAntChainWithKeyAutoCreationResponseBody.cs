// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class ApplyAntChainWithKeyAutoCreationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ApplyAntChainWithKeyAutoCreationResponseBodyResult Result { get; set; }
        public class ApplyAntChainWithKeyAutoCreationResponseBodyResult : TeaModel {
            [NameInMap("DownloadPath")]
            [Validation(Required=false)]
            public ApplyAntChainWithKeyAutoCreationResponseBodyResultDownloadPath DownloadPath { get; set; }
            public class ApplyAntChainWithKeyAutoCreationResponseBodyResultDownloadPath : TeaModel {
                [NameInMap("CaCrtUrl")]
                [Validation(Required=false)]
                public string CaCrtUrl { get; set; }

                [NameInMap("ClientCrtUrl")]
                [Validation(Required=false)]
                public string ClientCrtUrl { get; set; }

                [NameInMap("SdkUrl")]
                [Validation(Required=false)]
                public string SdkUrl { get; set; }

                [NameInMap("TrustCaUrl")]
                [Validation(Required=false)]
                public string TrustCaUrl { get; set; }

            }

            [NameInMap("PrivateKey")]
            [Validation(Required=false)]
            public string PrivateKey { get; set; }

        }

    }

}

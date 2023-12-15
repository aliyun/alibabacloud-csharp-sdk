// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class ApplyBlockchainWithKeyAutoCreationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ApplyBlockchainWithKeyAutoCreationResponseBodyResult Result { get; set; }
        public class ApplyBlockchainWithKeyAutoCreationResponseBodyResult : TeaModel {
            [NameInMap("DownloadPath")]
            [Validation(Required=false)]
            public ApplyBlockchainWithKeyAutoCreationResponseBodyResultDownloadPath DownloadPath { get; set; }
            public class ApplyBlockchainWithKeyAutoCreationResponseBodyResultDownloadPath : TeaModel {
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

            [NameInMap("PrivateKey")]
            [Validation(Required=false)]
            public string PrivateKey { get; set; }

        }

    }

}

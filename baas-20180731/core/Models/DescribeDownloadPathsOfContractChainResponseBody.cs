// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeDownloadPathsOfContractChainResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeDownloadPathsOfContractChainResponseBodyResult Result { get; set; }
        public class DescribeDownloadPathsOfContractChainResponseBodyResult : TeaModel {
            [NameInMap("CaUrl")]
            [Validation(Required=false)]
            public string CaUrl { get; set; }

            [NameInMap("CertUrl")]
            [Validation(Required=false)]
            public string CertUrl { get; set; }

            [NameInMap("TrustCaUrl")]
            [Validation(Required=false)]
            public string TrustCaUrl { get; set; }

        }

    }

}

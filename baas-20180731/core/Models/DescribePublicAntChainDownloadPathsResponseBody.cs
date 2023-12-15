// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribePublicAntChainDownloadPathsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribePublicAntChainDownloadPathsResponseBodyResult Result { get; set; }
        public class DescribePublicAntChainDownloadPathsResponseBodyResult : TeaModel {
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

    }

}

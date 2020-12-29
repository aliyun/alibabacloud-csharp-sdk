// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeAntChainQRCodeAuthorizationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainQRCodeAuthorizationResponseBodyResult Result { get; set; }
        public class DescribeAntChainQRCodeAuthorizationResponseBodyResult : TeaModel {
            [NameInMap("QRCodeType")]
            [Validation(Required=false)]
            public string QRCodeType { get; set; }
            [NameInMap("AuthorizationType")]
            [Validation(Required=false)]
            public string AuthorizationType { get; set; }
            [NameInMap("AntChainId")]
            [Validation(Required=false)]
            public string AntChainId { get; set; }
        };

    }

}

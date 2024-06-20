// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeAntChainMiniAppBrowserTransactionQRCodeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainMiniAppBrowserTransactionQRCodeResponseBodyResult Result { get; set; }
        public class DescribeAntChainMiniAppBrowserTransactionQRCodeResponseBodyResult : TeaModel {
            [NameInMap("AntChainId")]
            [Validation(Required=false)]
            public string AntChainId { get; set; }

            [NameInMap("Base64QRCodePNG")]
            [Validation(Required=false)]
            public string Base64QRCodePNG { get; set; }

            [NameInMap("QRCodeContent")]
            [Validation(Required=false)]
            public string QRCodeContent { get; set; }

            [NameInMap("TransactionHash")]
            [Validation(Required=false)]
            public string TransactionHash { get; set; }

        }

    }

}

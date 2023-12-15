// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeAntChainMiniAppBrowserQRCodeAccessLogResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainMiniAppBrowserQRCodeAccessLogResponseBodyResult Result { get; set; }
        public class DescribeAntChainMiniAppBrowserQRCodeAccessLogResponseBodyResult : TeaModel {
            [NameInMap("AccessAlipayAccountCount")]
            [Validation(Required=false)]
            public long? AccessAlipayAccountCount { get; set; }

            [NameInMap("AccessCount")]
            [Validation(Required=false)]
            public long? AccessCount { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeAntChainMiniAppBrowserQRCodeAccessLogV2ResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainMiniAppBrowserQRCodeAccessLogV2ResponseBodyResult Result { get; set; }
        public class DescribeAntChainMiniAppBrowserQRCodeAccessLogV2ResponseBodyResult : TeaModel {
            [NameInMap("AccessAlipayAccountCount")]
            [Validation(Required=false)]
            public long? AccessAlipayAccountCount { get; set; }

            [NameInMap("AccessCount")]
            [Validation(Required=false)]
            public long? AccessCount { get; set; }

        }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

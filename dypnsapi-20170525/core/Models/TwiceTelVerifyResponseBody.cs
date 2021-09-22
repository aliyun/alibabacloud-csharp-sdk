// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class TwiceTelVerifyResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TwiceTelVerifyResult")]
        [Validation(Required=false)]
        public TwiceTelVerifyResponseBodyTwiceTelVerifyResult TwiceTelVerifyResult { get; set; }
        public class TwiceTelVerifyResponseBodyTwiceTelVerifyResult : TeaModel {
            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }
            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public int? VerifyResult { get; set; }
        };

    }

}

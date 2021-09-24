// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneNumberResaleResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TwiceTelVerify")]
        [Validation(Required=false)]
        public DescribePhoneNumberResaleResponseBodyTwiceTelVerify TwiceTelVerify { get; set; }
        public class DescribePhoneNumberResaleResponseBodyTwiceTelVerify : TeaModel {
            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }
            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public int? VerifyResult { get; set; }
        };

    }

}

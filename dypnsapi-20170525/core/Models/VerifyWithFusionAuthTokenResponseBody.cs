// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class VerifyWithFusionAuthTokenResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public VerifyWithFusionAuthTokenResponseBodyModel Model { get; set; }
        public class VerifyWithFusionAuthTokenResponseBodyModel : TeaModel {
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            [NameInMap("PhoneScore")]
            [Validation(Required=false)]
            public long? PhoneScore { get; set; }

            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public string VerifyResult { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

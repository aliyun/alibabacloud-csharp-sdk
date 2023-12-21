// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Captcha20230305.Models
{
    public class VerifyIntelligentCaptchaResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public VerifyIntelligentCaptchaResponseBodyResult Result { get; set; }
        public class VerifyIntelligentCaptchaResponseBodyResult : TeaModel {
            [NameInMap("VerifyCode")]
            [Validation(Required=false)]
            public string VerifyCode { get; set; }

            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public bool? VerifyResult { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

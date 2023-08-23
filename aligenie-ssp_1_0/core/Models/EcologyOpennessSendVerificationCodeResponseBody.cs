// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class EcologyOpennessSendVerificationCodeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public EcologyOpennessSendVerificationCodeResponseBodyResult Result { get; set; }
        public class EcologyOpennessSendVerificationCodeResponseBodyResult : TeaModel {
            [NameInMap("ExpireIn")]
            [Validation(Required=false)]
            public int? ExpireIn { get; set; }

            [NameInMap("RepeatInterval")]
            [Validation(Required=false)]
            public int? RepeatInterval { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

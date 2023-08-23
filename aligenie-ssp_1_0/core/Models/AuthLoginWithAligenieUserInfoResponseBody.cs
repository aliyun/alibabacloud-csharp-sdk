// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class AuthLoginWithAligenieUserInfoResponseBody : TeaModel {
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
        public AuthLoginWithAligenieUserInfoResponseBodyResult Result { get; set; }
        public class AuthLoginWithAligenieUserInfoResponseBodyResult : TeaModel {
            [NameInMap("ExpiredTimeLong")]
            [Validation(Required=false)]
            public long? ExpiredTimeLong { get; set; }

            [NameInMap("LoginStateAccessToken")]
            [Validation(Required=false)]
            public string LoginStateAccessToken { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

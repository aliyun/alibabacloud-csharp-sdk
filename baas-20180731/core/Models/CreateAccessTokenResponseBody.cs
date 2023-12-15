// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class CreateAccessTokenResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateAccessTokenResponseBodyResult Result { get; set; }
        public class CreateAccessTokenResponseBodyResult : TeaModel {
            [NameInMap("AccessToken")]
            [Validation(Required=false)]
            public string AccessToken { get; set; }

            [NameInMap("ExpiresIn")]
            [Validation(Required=false)]
            public long? ExpiresIn { get; set; }

            [NameInMap("RefreshToken")]
            [Validation(Required=false)]
            public string RefreshToken { get; set; }

            [NameInMap("TokenType")]
            [Validation(Required=false)]
            public string TokenType { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

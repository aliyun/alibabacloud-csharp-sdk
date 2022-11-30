// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class GetAuthTokenResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TokenInfo")]
        [Validation(Required=false)]
        public GetAuthTokenResponseBodyTokenInfo TokenInfo { get; set; }
        public class GetAuthTokenResponseBodyTokenInfo : TeaModel {
            [NameInMap("AccessToken")]
            [Validation(Required=false)]
            public string AccessToken { get; set; }

            [NameInMap("JwtToken")]
            [Validation(Required=false)]
            public string JwtToken { get; set; }

        }

    }

}

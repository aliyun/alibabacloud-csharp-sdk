// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class GetAuthTokenResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetAuthTokenResponseBodyResult Result { get; set; }
        public class GetAuthTokenResponseBodyResult : TeaModel {
            [NameInMap("AccessToken")]
            [Validation(Required=false)]
            public string AccessToken { get; set; }
            [NameInMap("AccessTokenExpiredTime")]
            [Validation(Required=false)]
            public long? AccessTokenExpiredTime { get; set; }
            [NameInMap("RefreshToken")]
            [Validation(Required=false)]
            public string RefreshToken { get; set; }
        };

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp_room20210515.Models
{
    public class GetLoginTokenResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetLoginTokenResponseBodyResult Result { get; set; }
        public class GetLoginTokenResponseBodyResult : TeaModel {
            [NameInMap("AccessToken")]
            [Validation(Required=false)]
            public string AccessToken { get; set; }
            [NameInMap("RefreshToken")]
            [Validation(Required=false)]
            public string RefreshToken { get; set; }
            [NameInMap("AccessTokenExpiredTime")]
            [Validation(Required=false)]
            public long? AccessTokenExpiredTime { get; set; }
        };

    }

}

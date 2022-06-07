// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateOAuthTokenResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateOAuthTokenResponseBodyResult Result { get; set; }
        public class CreateOAuthTokenResponseBodyResult : TeaModel {
            [NameInMap("accessToken")]
            [Validation(Required=false)]
            public string AccessToken { get; set; }
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }
            [NameInMap("tokenType")]
            [Validation(Required=false)]
            public string TokenType { get; set; }
        };

        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class FetchAccessTokenResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public FetchAccessTokenResponseBodyData Data { get; set; }
        public class FetchAccessTokenResponseBodyData : TeaModel {
            [NameInMap("Access_token")]
            [Validation(Required=false)]
            public string AccessToken { get; set; }
            [NameInMap("Expires_in")]
            [Validation(Required=false)]
            public string ExpiresIn { get; set; }
            [NameInMap("Id_token")]
            [Validation(Required=false)]
            public string IdToken { get; set; }
            [NameInMap("Refresh_token")]
            [Validation(Required=false)]
            public string RefreshToken { get; set; }
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }
            [NameInMap("Token_type")]
            [Validation(Required=false)]
            public string TokenType { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

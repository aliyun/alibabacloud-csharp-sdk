// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class GetAuthenticatorResponseBody : TeaModel {
        [NameInMap("Authenticator")]
        [Validation(Required=false)]
        public GetAuthenticatorResponseBodyAuthenticator Authenticator { get; set; }
        public class GetAuthenticatorResponseBodyAuthenticator : TeaModel {
            [NameInMap("AuthenticatorName")]
            [Validation(Required=false)]
            public string AuthenticatorName { get; set; }

            [NameInMap("AuthenticatorUuid")]
            [Validation(Required=false)]
            public string AuthenticatorUuid { get; set; }

            [NameInMap("CredentialId")]
            [Validation(Required=false)]
            public string CredentialId { get; set; }

            [NameInMap("CustomAuthenticator")]
            [Validation(Required=false)]
            public string CustomAuthenticator { get; set; }

            [NameInMap("LastVerifySourceIp")]
            [Validation(Required=false)]
            public string LastVerifySourceIp { get; set; }

            [NameInMap("LastVerifyTime")]
            [Validation(Required=false)]
            public long? LastVerifyTime { get; set; }

            [NameInMap("LastVerifyUserAgent")]
            [Validation(Required=false)]
            public string LastVerifyUserAgent { get; set; }

            [NameInMap("RegisterSourceIp")]
            [Validation(Required=false)]
            public string RegisterSourceIp { get; set; }

            [NameInMap("RegisterTime")]
            [Validation(Required=false)]
            public long? RegisterTime { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

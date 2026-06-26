// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetOAuth2CredentialProviderResponseBody : TeaModel {
        [NameInMap("OAuth2CredentialProvider")]
        [Validation(Required=false)]
        public GetOAuth2CredentialProviderResponseBodyOAuth2CredentialProvider OAuth2CredentialProvider { get; set; }
        public class GetOAuth2CredentialProviderResponseBodyOAuth2CredentialProvider : TeaModel {
            [NameInMap("CallbackURL")]
            [Validation(Required=false)]
            public string CallbackURL { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CredentialProviderArn")]
            [Validation(Required=false)]
            public string CredentialProviderArn { get; set; }

            [NameInMap("CredentialProviderVendor")]
            [Validation(Required=false)]
            public string CredentialProviderVendor { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("OAuth2CredentialProviderName")]
            [Validation(Required=false)]
            public string OAuth2CredentialProviderName { get; set; }

            [NameInMap("OAuth2ProviderConfig")]
            [Validation(Required=false)]
            public OAuth2ProviderConfig OAuth2ProviderConfig { get; set; }

            [NameInMap("TokenVaultName")]
            [Validation(Required=false)]
            public string TokenVaultName { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

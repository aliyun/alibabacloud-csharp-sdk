// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateOAuth2CredentialProviderResponseBody : TeaModel {
        [NameInMap("OAuth2CredentialProvider")]
        [Validation(Required=false)]
        public CreateOAuth2CredentialProviderResponseBodyOAuth2CredentialProvider OAuth2CredentialProvider { get; set; }
        public class CreateOAuth2CredentialProviderResponseBodyOAuth2CredentialProvider : TeaModel {
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

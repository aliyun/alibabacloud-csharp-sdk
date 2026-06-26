// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateOAuth2CredentialProviderShrinkRequest : TeaModel {
        [NameInMap("CallbackURL")]
        [Validation(Required=false)]
        public string CallbackURL { get; set; }

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
        public string OAuth2ProviderConfigShrink { get; set; }

        [NameInMap("TokenVaultName")]
        [Validation(Required=false)]
        public string TokenVaultName { get; set; }

    }

}

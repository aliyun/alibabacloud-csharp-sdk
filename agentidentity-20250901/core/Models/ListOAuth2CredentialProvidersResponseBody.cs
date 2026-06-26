// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class ListOAuth2CredentialProvidersResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OAuth2CredentialProviders")]
        [Validation(Required=false)]
        public List<ListOAuth2CredentialProvidersResponseBodyOAuth2CredentialProviders> OAuth2CredentialProviders { get; set; }
        public class ListOAuth2CredentialProvidersResponseBodyOAuth2CredentialProviders : TeaModel {
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

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

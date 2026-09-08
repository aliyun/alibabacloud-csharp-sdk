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

            /// <summary>
            /// <b>Example:</b>
            /// <para>idaas_xxxx</para>
            /// </summary>
            [NameInMap("IDaaSInstanceId")]
            [Validation(Required=false)]
            public string IDaaSInstanceId { get; set; }

            [NameInMap("OAuth2CredentialProviderName")]
            [Validation(Required=false)]
            public string OAuth2CredentialProviderName { get; set; }

            [NameInMap("OAuth2ProviderConfig")]
            [Validation(Required=false)]
            public OAuth2ProviderConfig OAuth2ProviderConfig { get; set; }

            [NameInMap("OAuthType")]
            [Validation(Required=false)]
            public string OAuthType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>app_xxxx</para>
            /// </summary>
            [NameInMap("OutboundApplicationId")]
            [Validation(Required=false)]
            public string OutboundApplicationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>agent-xxxxx</para>
            /// </summary>
            [NameInMap("OutboundAudience")]
            [Validation(Required=false)]
            public string OutboundAudience { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>client_xxxx</para>
            /// </summary>
            [NameInMap("OutboundClientId")]
            [Validation(Required=false)]
            public string OutboundClientId { get; set; }

            [NameInMap("SourcePlatform")]
            [Validation(Required=false)]
            public string SourcePlatform { get; set; }

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

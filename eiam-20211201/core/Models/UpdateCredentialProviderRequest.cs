// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateCredentialProviderRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency token that ensures the idempotence of the request.</para>
        /// <para>Generate a unique parameter value from your client to ensure uniqueness across different requests. ClientToken supports only ASCII characters and cannot exceed 64 characters in length. For more information, see References: <a href="https://www.alibabacloud.com/help/zh/ecs/developer-reference/how-to-ensure-idempotence">How to ensure idempotence</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The credential provider configuration.</para>
        /// </summary>
        [NameInMap("CredentialProviderConfig")]
        [Validation(Required=false)]
        public UpdateCredentialProviderRequestCredentialProviderConfig CredentialProviderConfig { get; set; }
        public class UpdateCredentialProviderRequestCredentialProviderConfig : TeaModel {
            /// <summary>
            /// <para>The configuration of the JWT credential provider.</para>
            /// </summary>
            [NameInMap("JwtProviderConfig")]
            [Validation(Required=false)]
            public UpdateCredentialProviderRequestCredentialProviderConfigJwtProviderConfig JwtProviderConfig { get; set; }
            public class UpdateCredentialProviderRequestCredentialProviderConfigJwtProviderConfig : TeaModel {
                /// <summary>
                /// <para>The list of allowed JWT issuers.</para>
                /// <remarks>
                /// <para>The list cannot contain more than 200 entries.</para>
                /// </remarks>
                /// <remarks>
                /// <para>Notice: To clear the issuer list, pass an empty list or an empty string when calling the API.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AllowedTokenIssuers")]
                [Validation(Required=false)]
                public List<string> AllowedTokenIssuers { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the JWT derived short token capability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DerivedShortTokenEnabled")]
                [Validation(Required=false)]
                public bool? DerivedShortTokenEnabled { get; set; }

                /// <summary>
                /// <para>The validity period of the JWT, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>900</para>
                /// </summary>
                [NameInMap("Expiration")]
                [Validation(Required=false)]
                public int? Expiration { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable JWT expiration cleanup.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ExpirationCleanupEnabled")]
                [Validation(Required=false)]
                public bool? ExpirationCleanupEnabled { get; set; }

            }

            /// <summary>
            /// <para>The configuration of the OAuth credential provider.</para>
            /// </summary>
            [NameInMap("OAuthProviderConfig")]
            [Validation(Required=false)]
            public UpdateCredentialProviderRequestCredentialProviderConfigOAuthProviderConfig OAuthProviderConfig { get; set; }
            public class UpdateCredentialProviderRequestCredentialProviderConfigOAuthProviderConfig : TeaModel {
                /// <summary>
                /// <para>The endpoint URL used to guide users through authorization. Conditionally required: this parameter is required when AuthorizationFlow is set to user_federation and ProviderVendor is set to custom. For preset vendors, this value can be automatically populated through DiscoveryUrl.</para>
                /// </summary>
                [NameInMap("AuthorizationEndpoint")]
                [Validation(Required=false)]
                public string AuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>The OAuth authorization flow type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>m2m: Machine-to-machine (2LO, Client Credentials).</description></item>
                /// <item><description>user_federation: User federation (3LO, Authorization Code).</description></item>
                /// </list>
                /// </summary>
                [NameInMap("AuthorizationFlow")]
                [Validation(Required=false)]
                public string AuthorizationFlow { get; set; }

                /// <summary>
                /// <para>The client_secret in the OAuth protocol.</para>
                /// <remarks>
                /// <para>The value cannot exceed 1024 characters in length.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>client_secret_example_xxx</para>
                /// </summary>
                [NameInMap("ClientSecret")]
                [Validation(Required=false)]
                public string ClientSecret { get; set; }

                /// <summary>
                /// <para>The Discovery document URL used to automatically retrieve OAuth endpoint configurations. Conditionally optional: this parameter is used when AuthorizationFlow is set to user_federation. If DiscoveryUrl is not provided, you must manually configure fields such as TokenEndpoint and AuthorizationEndpoint.</para>
                /// </summary>
                [NameInMap("DiscoveryUrl")]
                [Validation(Required=false)]
                public string DiscoveryUrl { get; set; }

                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>The PKCE code_challenge generation method. Default value: s256.</para>
                /// </summary>
                [NameInMap("PkceChallengeMethod")]
                [Validation(Required=false)]
                public string PkceChallengeMethod { get; set; }

                /// <summary>
                /// <para>Specifies whether to use the PKCE extension for enhanced security. We recommend that you always enable this feature.</para>
                /// </summary>
                [NameInMap("PkceEnabled")]
                [Validation(Required=false)]
                public bool? PkceEnabled { get; set; }

                /// <summary>
                /// <para>The preset vendor or custom configuration. This parameter is optional. Default value: custom.</para>
                /// </summary>
                [NameInMap("ProviderVendor")]
                [Validation(Required=false)]
                public string ProviderVendor { get; set; }

                /// <summary>
                /// <para>The scope in the OAuth protocol, which specifies the permission scope.</para>
                /// <remarks>
                /// <para>The Scope configuration on the OAuth credential provider serves as a fallback value. If the scope parameter is not specified when calling the DeveloperAPI to obtain an OAuth Access Token, the Scope configuration on the credential provider is used for token issuance.</para>
                /// </remarks>
                /// <remarks>
                /// <para>Notice: Separate multiple Scope values with spaces. To clear the Scope configuration, pass an empty string.</para>
                /// </remarks>
                /// <para>Restrictions for each individual Scope value:</para>
                /// <ol>
                /// <item><description>Allowed characters: lowercase letters, digits, and special characters <c>|/:_-.</c></description></item>
                /// <item><description>Must contain at least one lowercase letter or digit.</description></item>
                /// <item><description>Must start with a special character <c>.</c>, a lowercase letter, or a digit.</description></item>
                /// <item><description>Cannot exceed 1024 characters in length.</description></item>
                /// </ol>
                /// 
                /// <b>Example:</b>
                /// <para>example:test_01 example:test_02</para>
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                /// <summary>
                /// <para>The token endpoint of the OAuth protocol.</para>
                /// <remarks>
                /// <para>The value must start with <c>http://</c> or <c>https://</c> and cannot exceed 1024 characters in length.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/token">https://example.com/token</a></para>
                /// </summary>
                [NameInMap("TokenEndpoint")]
                [Validation(Required=false)]
                public string TokenEndpoint { get; set; }

            }

        }

        /// <summary>
        /// <para>The credential provider ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>atp_01kr2cmj5gxxx4fvmls2e93dxxxxx</para>
        /// </summary>
        [NameInMap("CredentialProviderId")]
        [Validation(Required=false)]
        public string CredentialProviderId { get; set; }

        /// <summary>
        /// <para>The credential provider name.</para>
        /// <remarks>
        /// <para>The name cannot exceed 64 characters in length.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test_example_name</para>
        /// </summary>
        [NameInMap("CredentialProviderName")]
        [Validation(Required=false)]
        public string CredentialProviderName { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}

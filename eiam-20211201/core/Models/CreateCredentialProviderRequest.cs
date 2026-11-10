// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateCredentialProviderRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency token that ensures the idempotence of the request.</para>
        /// <para>Generate a unique parameter value from your client to ensure that different requests have unique values. ClientToken supports only ASCII characters and cannot exceed 64 characters in length. For more information, see References <a href="https://www.alibabacloud.com/help/zh/ecs/developer-reference/how-to-ensure-idempotence">How to ensure idempotence</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The configuration of the credential provider.</para>
        /// </summary>
        [NameInMap("CredentialProviderConfig")]
        [Validation(Required=false)]
        public CreateCredentialProviderRequestCredentialProviderConfig CredentialProviderConfig { get; set; }
        public class CreateCredentialProviderRequestCredentialProviderConfig : TeaModel {
            /// <summary>
            /// <para>The configuration of the JWT credential provider.</para>
            /// </summary>
            [NameInMap("JwtProviderConfig")]
            [Validation(Required=false)]
            public CreateCredentialProviderRequestCredentialProviderConfigJwtProviderConfig JwtProviderConfig { get; set; }
            public class CreateCredentialProviderRequestCredentialProviderConfigJwtProviderConfig : TeaModel {
                /// <summary>
                /// <para>The list of allowed JWT issuers.</para>
                /// <remarks>
                /// <para>The list cannot contain more than 200 entries.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AllowedTokenIssuers")]
                [Validation(Required=false)]
                public List<string> AllowedTokenIssuers { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the JWT derived short token feature.</para>
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
            public CreateCredentialProviderRequestCredentialProviderConfigOAuthProviderConfig OAuthProviderConfig { get; set; }
            public class CreateCredentialProviderRequestCredentialProviderConfigOAuthProviderConfig : TeaModel {
                /// <summary>
                /// <para>The authorization endpoint of the OAuth protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/authorize">https://example.com/authorize</a></para>
                /// </summary>
                [NameInMap("AuthorizationEndpoint")]
                [Validation(Required=false)]
                public string AuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>The OAuth authorization flow type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>m2m: Machine-to-machine.</description></item>
                /// <item><description>user_federation: User federation.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>m2m</para>
                /// </summary>
                [NameInMap("AuthorizationFlow")]
                [Validation(Required=false)]
                public string AuthorizationFlow { get; set; }

                /// <summary>
                /// <para>The client_id in the OAuth protocol, which is the client ID.</para>
                /// <remarks>
                /// <para>The length cannot exceed 128 characters.</para>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>client_id_example_xxx</para>
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>The client_secret in the OAuth protocol, which is the client secret.</para>
                /// <remarks>
                /// <para>The length cannot exceed 1024 characters.</para>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>client_secret_example_xxx</para>
                /// </summary>
                [NameInMap("ClientSecret")]
                [Validation(Required=false)]
                public string ClientSecret { get; set; }

                /// <summary>
                /// <para>The URL of the OAuth Discovery document.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/.well-known/openid-configuration">https://example.com/.well-known/openid-configuration</a></para>
                /// </summary>
                [NameInMap("DiscoveryUrl")]
                [Validation(Required=false)]
                public string DiscoveryUrl { get; set; }

                /// <summary>
                /// <para>The Issuer endpoint of the OAuth protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/issuer">https://example.com/issuer</a></para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>The algorithm used to calculate the Code Challenge in PKCE. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>S256.</description></item>
                /// <item><description>plain.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>S256</para>
                /// </summary>
                [NameInMap("PkceChallengeMethod")]
                [Validation(Required=false)]
                public string PkceChallengeMethod { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable PKCE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PkceEnabled")]
                [Validation(Required=false)]
                public bool? PkceEnabled { get; set; }

                /// <summary>
                /// <para>The OAuth provider vendor type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>custom: Custom.</description></item>
                /// <item><description>dingtalk: DingTalk.</description></item>
                /// <item><description>feishu: Lark.</description></item>
                /// <item><description>github: GitHub.</description></item>
                /// <item><description>microsoft: Microsoft.</description></item>
                /// <item><description>google: Google.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>custom</para>
                /// </summary>
                [NameInMap("ProviderVendor")]
                [Validation(Required=false)]
                public string ProviderVendor { get; set; }

                /// <summary>
                /// <para>The scope in the OAuth protocol, which specifies the permission scope.</para>
                /// <remarks>
                /// <para>The Scope configuration on the credential provider serves as the default value. If the scope parameter is not specified when calling the DeveloperAPI to obtain an OAuth Access Token, the Scope configuration on the credential provider is used for issuance.</para>
                /// </remarks>
                /// <remarks>
                /// <para>Notice: Separate multiple Scope values with spaces.</para>
                /// </remarks>
                /// <para>The following restrictions apply to each individual Scope value:</para>
                /// <ol>
                /// <item><description>Allowed characters: lowercase letters, digits, and the special characters <c>|/:_-.</c>.</description></item>
                /// <item><description>Must contain at least one lowercase letter or digit.</description></item>
                /// <item><description>Must start with the special character <c>.</c>, a lowercase letter, or a digit.</description></item>
                /// <item><description>The length cannot exceed 1024 characters.</description></item>
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
                /// <para>The value must start with <c>http://</c> or <c>https://</c>, and the length cannot exceed 1024 characters.</para>
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
        /// <para>The business identifier of the credential provider.</para>
        /// <remarks>
        /// <para>Allowed characters include uppercase and lowercase letters, digits, and the special characters <c>.-_</c>. The length cannot exceed 64 characters.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_example_identifier</para>
        /// </summary>
        [NameInMap("CredentialProviderIdentifier")]
        [Validation(Required=false)]
        public string CredentialProviderIdentifier { get; set; }

        /// <summary>
        /// <para>The name of the credential provider.</para>
        /// <remarks>
        /// <para>The length cannot exceed 64 characters.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_example_name</para>
        /// </summary>
        [NameInMap("CredentialProviderName")]
        [Validation(Required=false)]
        public string CredentialProviderName { get; set; }

        /// <summary>
        /// <para>The type of the credential provider. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>oauth: OAuth credential provider.</description></item>
        /// <item><description>jwt: JWT credential provider.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oauth</para>
        /// </summary>
        [NameInMap("CredentialProviderType")]
        [Validation(Required=false)]
        public string CredentialProviderType { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// <remarks>
        /// <para>The length cannot exceed 128 characters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>This is an example description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateCredentialProviderRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate a parameter value on your client to ensure that the value is unique across different requests. The ClientToken parameter supports only ASCII characters and can be up to 64 characters in length. For more information, see References: <a href="https://www.alibabacloud.com/help/zh/ecs/developer-reference/how-to-ensure-idempotence">How to ensure idempotence</a>.</para>
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
                /// <para>The list can contain up to 200 items.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AllowedTokenIssuers")]
                [Validation(Required=false)]
                public List<string> AllowedTokenIssuers { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the capability to derive short tokens from JWTs.</para>
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
                /// <para>Specifies whether to enable cleanup of expired JWTs.</para>
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
                /// <para>The authorization endpoint in the OAuth protocol.</para>
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
                /// <item><description>m2m: Machine-to-machine</description></item>
                /// <item><description>user_federation: User federation</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>m2m</para>
                /// </summary>
                [NameInMap("AuthorizationFlow")]
                [Validation(Required=false)]
                public string AuthorizationFlow { get; set; }

                /// <summary>
                /// <para>The client ID in the OAuth protocol.</para>
                /// <remarks>
                /// <para>The client ID can be up to 128 characters in length.</para>
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
                /// <para>The client secret in the OAuth protocol.</para>
                /// <remarks>
                /// <para>The client secret can be up to 1,024 characters in length.</para>
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
                /// <para>The URL of the OAuth discovery document.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/.well-known/openid-configuration">https://example.com/.well-known/openid-configuration</a></para>
                /// </summary>
                [NameInMap("DiscoveryUrl")]
                [Validation(Required=false)]
                public string DiscoveryUrl { get; set; }

                /// <summary>
                /// <para>The issuer endpoint in the OAuth protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/issuer">https://example.com/issuer</a></para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>The algorithm used to calculate the code challenge in PKCE. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>S256</description></item>
                /// <item><description>plain</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>S256</para>
                /// </summary>
                [NameInMap("PkceChallengeMethod")]
                [Validation(Required=false)]
                public string PkceChallengeMethod { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable Proof Key for Code Exchange (PKCE).</para>
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
                /// <item><description>custom: Custom</description></item>
                /// <item><description>dingtalk: DingTalk</description></item>
                /// <item><description>feishu: Lark</description></item>
                /// <item><description>github: GitHub</description></item>
                /// <item><description>microsoft: Microsoft</description></item>
                /// <item><description>google: Google</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>custom</para>
                /// </summary>
                [NameInMap("ProviderVendor")]
                [Validation(Required=false)]
                public string ProviderVendor { get; set; }

                /// <summary>
                /// <para>The scope in the OAuth protocol.</para>
                /// <remarks>
                /// <para>The scope configuration of the OAuth credential provider serves as a fallback value. If the scope parameter is not specified when you call the Developer API to obtain an OAuth access token, the scope configuration of the credential provider is used to issue the token.
                /// Notice: Separate multiple scope values with spaces.</notice>
                /// Limits on a single scope value:</para>
                /// </remarks>
                /// <ol>
                /// <item><description>Valid characters: lowercase letters, digits, and the following special characters: <c>|/:_-.</c>.</description></item>
                /// <item><description>The value must contain lowercase letters or digits.</description></item>
                /// <item><description>The value must start with a period (<c>.</c>), a lowercase letter, or a digit.</description></item>
                /// <item><description>The value can be up to 1,024 characters in length.</description></item>
                /// </ol>
                /// 
                /// <b>Example:</b>
                /// <para>example:test_01 example:test_02</para>
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                /// <summary>
                /// <para>The token endpoint in the OAuth protocol.</para>
                /// <remarks>
                /// <para>The endpoint must start with <c>http://</c> or <c>https://</c> and can be up to 1,024 characters in length.</para>
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
        /// <para>The credential provider identifier.</para>
        /// <remarks>
        /// <para>Valid characters: uppercase and lowercase letters, digits, and the following special characters: <c>.-_</c>. The identifier can be up to 64 characters in length.</para>
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
        /// <para>The credential provider name.</para>
        /// <remarks>
        /// <para>The name can be up to 64 characters in length.</para>
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
        /// <para>The credential provider type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>oauth: OAuth credential provider</description></item>
        /// <item><description>jwt: JWT credential provider</description></item>
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
        /// <para>The description can be up to 128 characters in length.</para>
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

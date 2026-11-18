// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateCredentialProviderRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate the parameter value on your client to ensure that the value is unique across different requests. The ClientToken parameter supports only ASCII characters and can be up to 64 characters in length. For more information, see References: <a href="https://www.alibabacloud.com/help/zh/ecs/developer-reference/how-to-ensure-idempotence">How to ensure idempotence</a>.</para>
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
        public UpdateCredentialProviderRequestCredentialProviderConfig CredentialProviderConfig { get; set; }
        public class UpdateCredentialProviderRequestCredentialProviderConfig : TeaModel {
            /// <summary>
            /// <para>The configuration of the JSON Web Token (JWT) credential provider.</para>
            /// </summary>
            [NameInMap("JwtProviderConfig")]
            [Validation(Required=false)]
            public UpdateCredentialProviderRequestCredentialProviderConfigJwtProviderConfig JwtProviderConfig { get; set; }
            public class UpdateCredentialProviderRequestCredentialProviderConfigJwtProviderConfig : TeaModel {
                /// <summary>
                /// <para>The list of allowed JWT issuers.</para>
                /// <remarks>
                /// <para>The list can contain up to 200 issuers.</para>
                /// </remarks>
                /// <remarks>
                /// <para>Notice: To clear the issuer list, pass an empty list or an empty string when you call the operation.</notice></para>
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
                /// <para>The validity period of the JWT. Unit: seconds.</para>
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
                /// <para>The authorization endpoint.</para>
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
                /// <item><description>m2m: machine-to-machine.</description></item>
                /// <item><description>user_federation: user federation.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>m2m</para>
                /// </summary>
                [NameInMap("AuthorizationFlow")]
                [Validation(Required=false)]
                public string AuthorizationFlow { get; set; }

                /// <summary>
                /// <para>The client secret in the OAuth protocol.</para>
                /// <remarks>
                /// <para>The client secret can be up to 1,024 characters in length.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>client_secret_example_xxx</para>
                /// </summary>
                [NameInMap("ClientSecret")]
                [Validation(Required=false)]
                public string ClientSecret { get; set; }

                /// <summary>
                /// <para>The URL of the discovery document.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/.well-known/openid-configuration">https://example.com/.well-known/openid-configuration</a></para>
                /// </summary>
                [NameInMap("DiscoveryUrl")]
                [Validation(Required=false)]
                public string DiscoveryUrl { get; set; }

                /// <summary>
                /// <para>The URL of the authorization server identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/issuer">https://example.com/issuer</a></para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>The PKCE challenge method. Valid values:</para>
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
                /// <para>Specifies whether to enable Proof Key for Code Exchange (PKCE).</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PkceEnabled")]
                [Validation(Required=false)]
                public bool? PkceEnabled { get; set; }

                /// <summary>
                /// <para>The vendor type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>custom: custom.</description></item>
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
                /// <para>The scope in the OAuth protocol.</para>
                /// <remarks>
                /// <para>The scope configuration of the OAuth credential provider serves as a fallback value. If the scope parameter is not specified when you call the Developer API to obtain an OAuth access token, the access token is issued based on the scope configuration of the credential provider.</para>
                /// </remarks>
                /// <remarks>
                /// <para>Notice: Separate multiple scope values with spaces. To clear the scope configuration, enter an empty string.</notice></para>
                /// </remarks>
                /// <para>The limits on a single scope value are as follows:</para>
                /// <ol>
                /// <item><description>Allowed characters: lowercase letters, digits, and the following special characters: <c>|/:_-.</c></description></item>
                /// <item><description>The value must contain at least one lowercase letter or digit.</description></item>
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
                /// <para>The token endpoint of the OAuth protocol.</para>
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
        /// <para>The name of the credential provider.</para>
        /// <remarks>
        /// <para>The name can be up to 64 characters in length.</para>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketOidcConfig : TeaModel {
        /// <summary>
        /// <para>The OAuth2 Authorization Code configuration.</para>
        /// </summary>
        [NameInMap("authCodeConfig")]
        [Validation(Required=false)]
        public HiMarketOidcConfigAuthCodeConfig AuthCodeConfig { get; set; }
        public class HiMarketOidcConfigAuthCodeConfig : TeaModel {
            /// <summary>
            /// <para>The authorization endpoint URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://idaas.example.com/oauth2/authorize">https://idaas.example.com/oauth2/authorize</a></para>
            /// </summary>
            [NameInMap("authorizationEndpoint")]
            [Validation(Required=false)]
            public string AuthorizationEndpoint { get; set; }

            /// <summary>
            /// <para>The OAuth2 client ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-client-id</para>
            /// </summary>
            [NameInMap("clientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The OAuth2 client secret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-client-secret</para>
            /// </summary>
            [NameInMap("clientSecret")]
            [Validation(Required=false)]
            public string ClientSecret { get; set; }

            /// <summary>
            /// <para>The OIDC issuer URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://idaas.example.com">https://idaas.example.com</a></para>
            /// </summary>
            [NameInMap("issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>The JWKS public key set URI.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://idaas.example.com/.well-known/jwks.json">https://idaas.example.com/.well-known/jwks.json</a></para>
            /// </summary>
            [NameInMap("jwkSetUri")]
            [Validation(Required=false)]
            public string JwkSetUri { get; set; }

            /// <summary>
            /// <para>The OAuth2 redirect URI.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://gateway.example.com/callback">https://gateway.example.com/callback</a></para>
            /// </summary>
            [NameInMap("redirectUri")]
            [Validation(Required=false)]
            public string RedirectUri { get; set; }

            /// <summary>
            /// <para>The OAuth2 authorization scopes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>openid profile email</para>
            /// </summary>
            [NameInMap("scopes")]
            [Validation(Required=false)]
            public string Scopes { get; set; }

            /// <summary>
            /// <para>The token endpoint URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://idaas.example.com/oauth2/token">https://idaas.example.com/oauth2/token</a></para>
            /// </summary>
            [NameInMap("tokenEndpoint")]
            [Validation(Required=false)]
            public string TokenEndpoint { get; set; }

            /// <summary>
            /// <para>The UserInfo endpoint URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://idaas.example.com/userinfo">https://idaas.example.com/userinfo</a></para>
            /// </summary>
            [NameInMap("userInfoEndpoint")]
            [Validation(Required=false)]
            public string UserInfoEndpoint { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the OIDC configuration is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The authorization type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>authorization_code</para>
        /// </summary>
        [NameInMap("grantType")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

        /// <summary>
        /// <para>The identity field mapping configuration.</para>
        /// </summary>
        [NameInMap("identityMapping")]
        [Validation(Required=false)]
        public HiMarketOidcConfigIdentityMapping IdentityMapping { get; set; }
        public class HiMarketOidcConfigIdentityMapping : TeaModel {
            /// <summary>
            /// <para>The custom field mappings.</para>
            /// </summary>
            [NameInMap("customFields")]
            [Validation(Required=false)]
            public Dictionary<string, string> CustomFields { get; set; }

            /// <summary>
            /// <para>The identity field name that corresponds to the email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>email</para>
            /// </summary>
            [NameInMap("emailField")]
            [Validation(Required=false)]
            public string EmailField { get; set; }

            /// <summary>
            /// <para>The identity field name that corresponds to the user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sub</para>
            /// </summary>
            [NameInMap("userIdField")]
            [Validation(Required=false)]
            public string UserIdField { get; set; }

            /// <summary>
            /// <para>The identity field name that corresponds to the username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("userNameField")]
            [Validation(Required=false)]
            public string UserNameField { get; set; }

        }

        /// <summary>
        /// <para>The provider logo URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/logo.png">https://example.com/logo.png</a></para>
        /// </summary>
        [NameInMap("logoUrl")]
        [Validation(Required=false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// <para>The OIDC configuration name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-oidc-config</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The OIDC provider name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云IDaaS</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

    }

}

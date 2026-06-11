// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketOidcConfig : TeaModel {
        /// <summary>
        /// <para>Configuration settings for the authorization code grant type.</para>
        /// </summary>
        [NameInMap("authCodeConfig")]
        [Validation(Required=false)]
        public HiMarketOidcConfigAuthCodeConfig AuthCodeConfig { get; set; }
        public class HiMarketOidcConfigAuthCodeConfig : TeaModel {
            /// <summary>
            /// <para>The URL of the identity provider\&quot;s authorization endpoint.</para>
            /// </summary>
            [NameInMap("authorizationEndpoint")]
            [Validation(Required=false)]
            public string AuthorizationEndpoint { get; set; }

            /// <summary>
            /// <para>The client ID obtained from the identity provider after registering your application.</para>
            /// </summary>
            [NameInMap("clientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The client secret obtained from the identity provider after registering your application.</para>
            /// </summary>
            [NameInMap("clientSecret")]
            [Validation(Required=false)]
            public string ClientSecret { get; set; }

            /// <summary>
            /// <para>The identity provider\&quot;s unique issuer URL, used to validate ID tokens.</para>
            /// </summary>
            [NameInMap("issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>The provider\&quot;s JWK Set URI. This URI provides the public keys needed to verify ID token signatures.</para>
            /// </summary>
            [NameInMap("jwkSetUri")]
            [Validation(Required=false)]
            public string JwkSetUri { get; set; }

            /// <summary>
            /// <para>The application\&quot;s redirect URI. The provider sends the authorization code to this URI after successful authentication. You must register this URI with the identity provider.</para>
            /// </summary>
            [NameInMap("redirectUri")]
            [Validation(Required=false)]
            public string RedirectUri { get; set; }

            /// <summary>
            /// <para>A space-separated list of scopes to request from the provider. The <c>openid</c> scope is required for OIDC authentication. For example: <c>openid profile email</c>.</para>
            /// </summary>
            [NameInMap("scopes")]
            [Validation(Required=false)]
            public string Scopes { get; set; }

            /// <summary>
            /// <para>The URL of the identity provider\&quot;s token endpoint.</para>
            /// </summary>
            [NameInMap("tokenEndpoint")]
            [Validation(Required=false)]
            public string TokenEndpoint { get; set; }

            /// <summary>
            /// <para>The URL of the identity provider\&quot;s user info endpoint.</para>
            /// </summary>
            [NameInMap("userInfoEndpoint")]
            [Validation(Required=false)]
            public string UserInfoEndpoint { get; set; }

        }

        /// <summary>
        /// <para>Enables or disables this identity provider. If set to <c>false</c>, users cannot sign in with this provider.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The OAuth 2.0 grant type. For OIDC, this must be <c>authorization_code</c>.</para>
        /// </summary>
        [NameInMap("grantType")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

        /// <summary>
        /// <para>Specifies how to map claims from an ID token to user attributes in your system.</para>
        /// </summary>
        [NameInMap("identityMapping")]
        [Validation(Required=false)]
        public HiMarketOidcConfigIdentityMapping IdentityMapping { get; set; }
        public class HiMarketOidcConfigIdentityMapping : TeaModel {
            /// <summary>
            /// <para>Maps additional claims from the ID token to custom user attributes. For each mapping, the key is the target attribute in your system, and the value is the name of the claim from the ID token.</para>
            /// </summary>
            [NameInMap("customFields")]
            [Validation(Required=false)]
            public Dictionary<string, string> CustomFields { get; set; }

            /// <summary>
            /// <para>The ID token claim that maps to the user\&quot;s email address. The <c>email</c> claim is a common choice.</para>
            /// </summary>
            [NameInMap("emailField")]
            [Validation(Required=false)]
            public string EmailField { get; set; }

            /// <summary>
            /// <para>The ID token claim that maps to the user\&quot;s unique ID. The <c>sub</c> claim is a common choice.</para>
            /// </summary>
            [NameInMap("userIdField")]
            [Validation(Required=false)]
            public string UserIdField { get; set; }

            /// <summary>
            /// <para>The ID token claim that maps to the user\&quot;s display name. Common choices include <c>name</c> and <c>preferred_username</c>.</para>
            /// </summary>
            [NameInMap("userNameField")]
            [Validation(Required=false)]
            public string UserNameField { get; set; }

        }

        /// <summary>
        /// <para>The URL for the provider\&quot;s logo. This logo appears on the sign-in page.</para>
        /// </summary>
        [NameInMap("logoUrl")]
        [Validation(Required=false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// <para>The provider\&quot;s display name. This name appears on the sign-in page.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The unique identifier for the identity provider.</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

    }

}

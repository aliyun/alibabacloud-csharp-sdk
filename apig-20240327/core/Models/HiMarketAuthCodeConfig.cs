// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketAuthCodeConfig : TeaModel {
        /// <summary>
        /// <para>The URL of the identity provider\&quot;s authorization endpoint. Your application redirects users to this URL to sign in and grant consent.</para>
        /// </summary>
        [NameInMap("authorizationEndpoint")]
        [Validation(Required=false)]
        public string AuthorizationEndpoint { get; set; }

        /// <summary>
        /// <para>The unique identifier for your application. The identity provider assigns this ID when you register your application.</para>
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The secret key for your application. This secret authenticates your application with the identity provider.</para>
        /// </summary>
        [NameInMap("clientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// <para>The URL of the identity provider that issues the tokens. This URL uniquely identifies the provider.</para>
        /// </summary>
        [NameInMap("issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// <para>The URL of the identity provider\&quot;s JSON Web Key Set (JWKS) document. This document contains the public signing keys for token validation.</para>
        /// </summary>
        [NameInMap("jwkSetUri")]
        [Validation(Required=false)]
        public string JwkSetUri { get; set; }

        /// <summary>
        /// <para>The URL where the identity provider redirects the user after authorizing your application. This URL must be registered in your application settings with the identity provider.</para>
        /// </summary>
        [NameInMap("redirectUri")]
        [Validation(Required=false)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// <para>A space-separated list of requested permissions. For example: <c>openid profile</c>.</para>
        /// </summary>
        [NameInMap("scopes")]
        [Validation(Required=false)]
        public string Scopes { get; set; }

        /// <summary>
        /// <para>The URL of the identity provider\&quot;s token endpoint. Your application uses this endpoint to exchange an authorization code for an access token.</para>
        /// </summary>
        [NameInMap("tokenEndpoint")]
        [Validation(Required=false)]
        public string TokenEndpoint { get; set; }

        /// <summary>
        /// <para>The URL of the identity provider\&quot;s user info endpoint. Your application can use this endpoint to retrieve the authenticated user\&quot;s profile information.</para>
        /// </summary>
        [NameInMap("userInfoEndpoint")]
        [Validation(Required=false)]
        public string UserInfoEndpoint { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketAuthCodeConfig : TeaModel {
        /// <summary>
        /// <para>The OAuth2 authorization endpoint URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://idp.example.com/oauth2/authorize">https://idp.example.com/oauth2/authorize</a></para>
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
        /// <para>The OAuth2 client secret. The secret is AES-encrypted when stored.</para>
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
        /// <para><a href="https://idp.example.com">https://idp.example.com</a></para>
        /// </summary>
        [NameInMap("issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// <para>The JWKS public key set URI, used for token signature verification.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://idp.example.com/.well-known/jwks.json">https://idp.example.com/.well-known/jwks.json</a></para>
        /// </summary>
        [NameInMap("jwkSetUri")]
        [Validation(Required=false)]
        public string JwkSetUri { get; set; }

        /// <summary>
        /// <para>The OAuth2 callback URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://gateway.example.com/callback">https://gateway.example.com/callback</a></para>
        /// </summary>
        [NameInMap("redirectUri")]
        [Validation(Required=false)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// <para>The OAuth2 authorization scopes, separated by spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openid profile email</para>
        /// </summary>
        [NameInMap("scopes")]
        [Validation(Required=false)]
        public string Scopes { get; set; }

        /// <summary>
        /// <para>The OAuth2 token endpoint URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://idp.example.com/oauth2/token">https://idp.example.com/oauth2/token</a></para>
        /// </summary>
        [NameInMap("tokenEndpoint")]
        [Validation(Required=false)]
        public string TokenEndpoint { get; set; }

        /// <summary>
        /// <para>The OIDC UserInfo endpoint URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://idp.example.com/userinfo">https://idp.example.com/userinfo</a></para>
        /// </summary>
        [NameInMap("userInfoEndpoint")]
        [Validation(Required=false)]
        public string UserInfoEndpoint { get; set; }

    }

}

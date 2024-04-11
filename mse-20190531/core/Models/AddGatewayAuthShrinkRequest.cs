// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddGatewayAuthShrinkRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("AuthResourceConfig")]
        [Validation(Required=false)]
        public string AuthResourceConfig { get; set; }

        /// <summary>
        /// The information about the resource to be authorized.
        /// </summary>
        [NameInMap("AuthResourceList")]
        [Validation(Required=false)]
        public string AuthResourceListShrink { get; set; }

        [NameInMap("AuthResourceMode")]
        [Validation(Required=false)]
        public int? AuthResourceMode { get; set; }

        /// <summary>
        /// The application ID registered with the OIDC authentication service.
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// The application secret registered with the OIDC authentication service.
        /// </summary>
        [NameInMap("ClientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The domain name of the cookie. After the authentication is passed, the cookie is sent to the specified domain name to maintain the logon status. For example, if you set `Cookie-domain` to a.example.com, the cookie is sent to the domain name `a.example.com`. If you set `Cookie-domain` to .example.com, the cookie is sent to all subdomains of `example.com`.
        /// </summary>
        [NameInMap("CookieDomain")]
        [Validation(Required=false)]
        public string CookieDomain { get; set; }

        /// <summary>
        /// The information about the custom authentication service.
        /// </summary>
        [NameInMap("ExternalAuthZJSON")]
        [Validation(Required=false)]
        public string ExternalAuthZJSONShrink { get; set; }

        /// <summary>
        /// The unique ID of the gateway.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// Specifies whether to enable the whitelist feature.
        /// </summary>
        [NameInMap("IsWhite")]
        [Validation(Required=false)]
        public bool? IsWhite { get; set; }

        /// <summary>
        /// The iss value of JWT claims, which indicates the issuer. You must make sure that the value of this parameter is the same as the iss value in the payload of JWT claims.
        /// </summary>
        [NameInMap("Issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// The JWT public key. The JSON format is supported.
        /// </summary>
        [NameInMap("Jwks")]
        [Validation(Required=false)]
        public string Jwks { get; set; }

        /// <summary>
        /// The URL that is used to log on to the IDaaS instance.
        /// </summary>
        [NameInMap("LoginUrl")]
        [Validation(Required=false)]
        public string LoginUrl { get; set; }

        /// <summary>
        /// The name.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The redirect URL.
        /// </summary>
        [NameInMap("RedirectUrl")]
        [Validation(Required=false)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// The OIDC scope.
        /// </summary>
        [NameInMap("ScopesList")]
        [Validation(Required=false)]
        public string ScopesListShrink { get; set; }

        /// <summary>
        /// The status.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public bool? Status { get; set; }

        /// <summary>
        /// The sub value of JWT claims, which indicates the subject. You must make sure that the value of this parameter is the same as the sub value in the payload of JWT claims. If you do not set this parameter or leave it empty, the default value, which is the value of the Issuer parameter, is used.
        /// </summary>
        [NameInMap("Sub")]
        [Validation(Required=false)]
        public string Sub { get; set; }

        /// <summary>
        /// The name of the parameter that is required to verify a token. By default, a token is prefixed with Bearer and stored in the authorization header. Example: `Authorization: Bearer token`.
        /// </summary>
        [NameInMap("TokenName")]
        [Validation(Required=false)]
        public string TokenName { get; set; }

        /// <summary>
        /// The name prefix of the parameter that is required to verify a token. By default, a token is prefixed with Bearer and stored in the authorization header. Example: `Authorization: Bearer token`
        /// </summary>
        [NameInMap("TokenNamePrefix")]
        [Validation(Required=false)]
        public string TokenNamePrefix { get; set; }

        /// <summary>
        /// Specifies whether to enable pass-through.
        /// </summary>
        [NameInMap("TokenPass")]
        [Validation(Required=false)]
        public bool? TokenPass { get; set; }

        /// <summary>
        /// The position of the parameter that is required to verify a token. By default, a token is prefixed with Bearer and stored in the authorization header. Example: `Authorization: Bearer token`.
        /// </summary>
        [NameInMap("TokenPosition")]
        [Validation(Required=false)]
        public string TokenPosition { get; set; }

        /// <summary>
        /// The authentication type. JSON Web Token (JWT) authentication, OpenID Connect (OIDC) authentication, Identity as a Service (IDaaS) authentication, or custom authentication are supported.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

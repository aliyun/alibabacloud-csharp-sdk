// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketOidcConfig : TeaModel {
        [NameInMap("authCodeConfig")]
        [Validation(Required=false)]
        public HiMarketOidcConfigAuthCodeConfig AuthCodeConfig { get; set; }
        public class HiMarketOidcConfigAuthCodeConfig : TeaModel {
            [NameInMap("authorizationEndpoint")]
            [Validation(Required=false)]
            public string AuthorizationEndpoint { get; set; }

            [NameInMap("clientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            [NameInMap("clientSecret")]
            [Validation(Required=false)]
            public string ClientSecret { get; set; }

            [NameInMap("issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            [NameInMap("jwkSetUri")]
            [Validation(Required=false)]
            public string JwkSetUri { get; set; }

            [NameInMap("redirectUri")]
            [Validation(Required=false)]
            public string RedirectUri { get; set; }

            [NameInMap("scopes")]
            [Validation(Required=false)]
            public string Scopes { get; set; }

            [NameInMap("tokenEndpoint")]
            [Validation(Required=false)]
            public string TokenEndpoint { get; set; }

            [NameInMap("userInfoEndpoint")]
            [Validation(Required=false)]
            public string UserInfoEndpoint { get; set; }

        }

        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("grantType")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

        [NameInMap("identityMapping")]
        [Validation(Required=false)]
        public HiMarketOidcConfigIdentityMapping IdentityMapping { get; set; }
        public class HiMarketOidcConfigIdentityMapping : TeaModel {
            [NameInMap("customFields")]
            [Validation(Required=false)]
            public Dictionary<string, string> CustomFields { get; set; }

            [NameInMap("emailField")]
            [Validation(Required=false)]
            public string EmailField { get; set; }

            [NameInMap("userIdField")]
            [Validation(Required=false)]
            public string UserIdField { get; set; }

            [NameInMap("userNameField")]
            [Validation(Required=false)]
            public string UserNameField { get; set; }

        }

        [NameInMap("logoUrl")]
        [Validation(Required=false)]
        public string LogoUrl { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

    }

}

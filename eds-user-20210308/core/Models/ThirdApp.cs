// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class ThirdApp : TeaModel {
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OidcSsoConfig")]
        [Validation(Required=false)]
        public ThirdAppOidcSsoConfig OidcSsoConfig { get; set; }
        public class ThirdAppOidcSsoConfig : TeaModel {
            [NameInMap("AccessTokenEffectiveTime")]
            [Validation(Required=false)]
            public int? AccessTokenEffectiveTime { get; set; }

            [NameInMap("CodeEffectiveTime")]
            [Validation(Required=false)]
            public int? CodeEffectiveTime { get; set; }

            [NameInMap("EnableAuthLogin")]
            [Validation(Required=false)]
            public bool? EnableAuthLogin { get; set; }

            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public ThirdAppOidcSsoConfigEndpoints Endpoints { get; set; }
            public class ThirdAppOidcSsoConfigEndpoints : TeaModel {
                [NameInMap("AuthorizationEndpoint")]
                [Validation(Required=false)]
                public string AuthorizationEndpoint { get; set; }

                [NameInMap("DiscoveryEndpoint")]
                [Validation(Required=false)]
                public string DiscoveryEndpoint { get; set; }

                [NameInMap("GuestAuthorizationEndpoint")]
                [Validation(Required=false)]
                public string GuestAuthorizationEndpoint { get; set; }

                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                [NameInMap("JwksEndpoint")]
                [Validation(Required=false)]
                public string JwksEndpoint { get; set; }

                [NameInMap("LogoutEndpoint")]
                [Validation(Required=false)]
                public string LogoutEndpoint { get; set; }

                [NameInMap("RevokeEndpoint")]
                [Validation(Required=false)]
                public string RevokeEndpoint { get; set; }

                [NameInMap("TokenEndpoint")]
                [Validation(Required=false)]
                public string TokenEndpoint { get; set; }

                [NameInMap("UserinfoEndpoint")]
                [Validation(Required=false)]
                public string UserinfoEndpoint { get; set; }

            }

            [NameInMap("GrantScopes")]
            [Validation(Required=false)]
            public List<string> GrantScopes { get; set; }

            [NameInMap("GrantTypes")]
            [Validation(Required=false)]
            public List<string> GrantTypes { get; set; }

            [NameInMap("IdTokenAlgorithmType")]
            [Validation(Required=false)]
            public int? IdTokenAlgorithmType { get; set; }

            [NameInMap("IdTokenEffectiveTime")]
            [Validation(Required=false)]
            public int? IdTokenEffectiveTime { get; set; }

            [NameInMap("RedirectUris")]
            [Validation(Required=false)]
            public List<string> RedirectUris { get; set; }

            [NameInMap("RefreshTokenEffective")]
            [Validation(Required=false)]
            public int? RefreshTokenEffective { get; set; }

        }

        [NameInMap("Secrets")]
        [Validation(Required=false)]
        public List<ThirdAppSecrets> Secrets { get; set; }
        public class ThirdAppSecrets : TeaModel {
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("Secret")]
            [Validation(Required=false)]
            public string Secret { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class ThirdApp : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The OIDC configuration.</para>
        /// </summary>
        [NameInMap("OidcSsoConfig")]
        [Validation(Required=false)]
        public ThirdAppOidcSsoConfig OidcSsoConfig { get; set; }
        public class ThirdAppOidcSsoConfig : TeaModel {
            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AccessTokenEffectiveTime")]
            [Validation(Required=false)]
            public int? AccessTokenEffectiveTime { get; set; }

            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CodeEffectiveTime")]
            [Validation(Required=false)]
            public int? CodeEffectiveTime { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable authorized logon.</para>
            /// </summary>
            [NameInMap("EnableAuthLogin")]
            [Validation(Required=false)]
            public bool? EnableAuthLogin { get; set; }

            /// <summary>
            /// <para>The endpoints.</para>
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public ThirdAppOidcSsoConfigEndpoints Endpoints { get; set; }
            public class ThirdAppOidcSsoConfigEndpoints : TeaModel {
                /// <summary>
                /// <para>The authorization endpoint.</para>
                /// </summary>
                [NameInMap("AuthorizationEndpoint")]
                [Validation(Required=false)]
                public string AuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>The discovery endpoint.</para>
                /// </summary>
                [NameInMap("DiscoveryEndpoint")]
                [Validation(Required=false)]
                public string DiscoveryEndpoint { get; set; }

                /// <summary>
                /// <para>The guest authorization endpoint.</para>
                /// </summary>
                [NameInMap("GuestAuthorizationEndpoint")]
                [Validation(Required=false)]
                public string GuestAuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>Issuer</para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>The signature public key endpoint.</para>
                /// </summary>
                [NameInMap("JwksEndpoint")]
                [Validation(Required=false)]
                public string JwksEndpoint { get; set; }

                /// <summary>
                /// <para>The logout endpoint.</para>
                /// </summary>
                [NameInMap("LogoutEndpoint")]
                [Validation(Required=false)]
                public string LogoutEndpoint { get; set; }

                /// <summary>
                /// <para>The revocation endpoint.</para>
                /// </summary>
                [NameInMap("RevokeEndpoint")]
                [Validation(Required=false)]
                public string RevokeEndpoint { get; set; }

                /// <summary>
                /// <para>The token endpoint.</para>
                /// </summary>
                [NameInMap("TokenEndpoint")]
                [Validation(Required=false)]
                public string TokenEndpoint { get; set; }

                /// <summary>
                /// <para>The user information endpoint.</para>
                /// </summary>
                [NameInMap("UserinfoEndpoint")]
                [Validation(Required=false)]
                public string UserinfoEndpoint { get; set; }

            }

            /// <summary>
            /// <para>The grant scopes.</para>
            /// </summary>
            [NameInMap("GrantScopes")]
            [Validation(Required=false)]
            public List<string> GrantScopes { get; set; }

            /// <summary>
            /// <para>The grant types.</para>
            /// </summary>
            [NameInMap("GrantTypes")]
            [Validation(Required=false)]
            public List<string> GrantTypes { get; set; }

            /// <summary>
            /// <para>The signature type.</para>
            /// </summary>
            [NameInMap("IdTokenAlgorithmType")]
            [Validation(Required=false)]
            public string IdTokenAlgorithmType { get; set; }

            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IdTokenEffectiveTime")]
            [Validation(Required=false)]
            public int? IdTokenEffectiveTime { get; set; }

            /// <summary>
            /// <para>The URI whitelist.</para>
            /// </summary>
            [NameInMap("RedirectUris")]
            [Validation(Required=false)]
            public List<string> RedirectUris { get; set; }

            /// <summary>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RefreshTokenEffective")]
            [Validation(Required=false)]
            public int? RefreshTokenEffective { get; set; }

        }

        /// <summary>
        /// <para>The secrets.</para>
        /// </summary>
        [NameInMap("Secrets")]
        [Validation(Required=false)]
        public List<ThirdAppSecrets> Secrets { get; set; }
        public class ThirdAppSecrets : TeaModel {
            /// <summary>
            /// <para>Specifies whether it is enabled.</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The ciphertext.</para>
            /// </summary>
            [NameInMap("Secret")]
            [Validation(Required=false)]
            public string Secret { get; set; }

        }

    }

}

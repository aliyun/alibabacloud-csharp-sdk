// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ExecIdentityProviderMetadataUrlResolutionResponseBody : TeaModel {
        [NameInMap("IdentityProviderMetadata")]
        [Validation(Required=false)]
        public ExecIdentityProviderMetadataUrlResolutionResponseBodyIdentityProviderMetadata IdentityProviderMetadata { get; set; }
        public class ExecIdentityProviderMetadataUrlResolutionResponseBodyIdentityProviderMetadata : TeaModel {
            /// <summary>
            /// <para>OIDC IdP的Meta信息。</para>
            /// </summary>
            [NameInMap("OidcOpenIdConfiguration")]
            [Validation(Required=false)]
            public ExecIdentityProviderMetadataUrlResolutionResponseBodyIdentityProviderMetadataOidcOpenIdConfiguration OidcOpenIdConfiguration { get; set; }
            public class ExecIdentityProviderMetadataUrlResolutionResponseBodyIdentityProviderMetadataOidcOpenIdConfiguration : TeaModel {
                /// <summary>
                /// <para>oAuth2 授权端点。</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://demo.com/oauth2/default/v1/authorize">https://demo.com/oauth2/default/v1/authorize</a></para>
                /// </summary>
                [NameInMap("AuthorizationEndpoint")]
                [Validation(Required=false)]
                public string AuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>OIDC issuer信息。</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://demo.com/fe974231-3454-4b70-9326-70fb71e41bce/v2.0/">https://demo.com/fe974231-3454-4b70-9326-70fb71e41bce/v2.0/</a></para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>OIDC jwks地址。</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://demo.com/oauth2/v1/keys">https://demo.com/oauth2/v1/keys</a></para>
                /// </summary>
                [NameInMap("JwksUri")]
                [Validation(Required=false)]
                public string JwksUri { get; set; }

                /// <summary>
                /// <para>oAuth2 Token端点。</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://demo.com/api/bff/v1.2/developer/oidc/token">https://demo.com/api/bff/v1.2/developer/oidc/token</a></para>
                /// </summary>
                [NameInMap("TokenEndpoint")]
                [Validation(Required=false)]
                public string TokenEndpoint { get; set; }

                /// <summary>
                /// <para>OIDC 用户信息端点。</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://demo.com/api/bff/v1.2/developer/oidc/userinfo">https://demo.com/api/bff/v1.2/developer/oidc/userinfo</a></para>
                /// </summary>
                [NameInMap("UserinfoEndpoint")]
                [Validation(Required=false)]
                public string UserinfoEndpoint { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

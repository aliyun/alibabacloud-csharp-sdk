// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ExecIdentityProviderMetadataUrlResolutionResponseBody : TeaModel {
        /// <summary>
        /// <para>The identity provider metadata.</para>
        /// </summary>
        [NameInMap("IdentityProviderMetadata")]
        [Validation(Required=false)]
        public ExecIdentityProviderMetadataUrlResolutionResponseBodyIdentityProviderMetadata IdentityProviderMetadata { get; set; }
        public class ExecIdentityProviderMetadataUrlResolutionResponseBodyIdentityProviderMetadata : TeaModel {
            /// <summary>
            /// <para>The OIDC identity provider metadata.</para>
            /// </summary>
            [NameInMap("OidcOpenIdConfiguration")]
            [Validation(Required=false)]
            public ExecIdentityProviderMetadataUrlResolutionResponseBodyIdentityProviderMetadataOidcOpenIdConfiguration OidcOpenIdConfiguration { get; set; }
            public class ExecIdentityProviderMetadataUrlResolutionResponseBodyIdentityProviderMetadataOidcOpenIdConfiguration : TeaModel {
                /// <summary>
                /// <para>The OAuth 2.0 authorization endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://demo.com/oauth2/default/v1/authorize">https://demo.com/oauth2/default/v1/authorize</a></para>
                /// </summary>
                [NameInMap("AuthorizationEndpoint")]
                [Validation(Required=false)]
                public string AuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>The OIDC issuer.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://demo.com/fe974231-3454-4b70-9326-70fb71e41bce/v2.0/">https://demo.com/fe974231-3454-4b70-9326-70fb71e41bce/v2.0/</a></para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>The OIDC JSON Web Key Set (JWKS) URI.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://demo.com/oauth2/v1/keys">https://demo.com/oauth2/v1/keys</a></para>
                /// </summary>
                [NameInMap("JwksUri")]
                [Validation(Required=false)]
                public string JwksUri { get; set; }

                /// <summary>
                /// <para>The OAuth 2.0 token endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://demo.com/api/bff/v1.2/developer/oidc/token">https://demo.com/api/bff/v1.2/developer/oidc/token</a></para>
                /// </summary>
                [NameInMap("TokenEndpoint")]
                [Validation(Required=false)]
                public string TokenEndpoint { get; set; }

                /// <summary>
                /// <para>The OIDC userinfo endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://demo.com/api/bff/v1.2/developer/oidc/userinfo">https://demo.com/api/bff/v1.2/developer/oidc/userinfo</a></para>
                /// </summary>
                [NameInMap("UserinfoEndpoint")]
                [Validation(Required=false)]
                public string UserinfoEndpoint { get; set; }

            }

            /// <summary>
            /// <para>The SAML identity provider metadata.</para>
            /// </summary>
            [NameInMap("SamlMetadataConfiguration")]
            [Validation(Required=false)]
            public ExecIdentityProviderMetadataUrlResolutionResponseBodyIdentityProviderMetadataSamlMetadataConfiguration SamlMetadataConfiguration { get; set; }
            public class ExecIdentityProviderMetadataUrlResolutionResponseBodyIdentityProviderMetadataSamlMetadataConfiguration : TeaModel {
                /// <summary>
                /// <para>The certificates.</para>
                /// </summary>
                [NameInMap("Certificates")]
                [Validation(Required=false)]
                public List<ExecIdentityProviderMetadataUrlResolutionResponseBodyIdentityProviderMetadataSamlMetadataConfigurationCertificates> Certificates { get; set; }
                public class ExecIdentityProviderMetadataUrlResolutionResponseBodyIdentityProviderMetadataSamlMetadataConfigurationCertificates : TeaModel {
                    /// <summary>
                    /// <para>The content of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-----BEGIN CERTIFICATE----- MIIE+zCCA0egAwIBAgIJAJZY0ZY0ZY0Z -----END CERTIFICATE-----</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                }

                /// <summary>
                /// <para>The entity ID of the SAML identity provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://dc.test.com/adfs/services/trust">http://dc.test.com/adfs/services/trust</a></para>
                /// </summary>
                [NameInMap("IdPEntityId")]
                [Validation(Required=false)]
                public string IdPEntityId { get; set; }

                /// <summary>
                /// <para>The SSO URL of the SAML identity provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://dc.test.com/adfs/ls/">https://dc.test.com/adfs/ls/</a></para>
                /// </summary>
                [NameInMap("IdPSsoUrl")]
                [Validation(Required=false)]
                public string IdPSsoUrl { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

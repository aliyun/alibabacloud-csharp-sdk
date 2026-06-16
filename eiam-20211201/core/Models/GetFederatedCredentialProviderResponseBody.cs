// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetFederatedCredentialProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>The federated credential provider.</para>
        /// </summary>
        [NameInMap("FederatedCredentialProvider")]
        [Validation(Required=false)]
        public GetFederatedCredentialProviderResponseBodyFederatedCredentialProvider FederatedCredentialProvider { get; set; }
        public class GetFederatedCredentialProviderResponseBodyFederatedCredentialProvider : TeaModel {
            [NameInMap("CloudIdPProviderConfig")]
            [Validation(Required=false)]
            public GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderCloudIdPProviderConfig CloudIdPProviderConfig { get; set; }
            public class GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderCloudIdPProviderConfig : TeaModel {
                [NameInMap("IdentityProviderId")]
                [Validation(Required=false)]
                public string IdentityProviderId { get; set; }

            }

            /// <summary>
            /// <para>The time when the provider was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1729061324000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the federated credential provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fcp_asd123XXX</para>
            /// </summary>
            [NameInMap("FederatedCredentialProviderId")]
            [Validation(Required=false)]
            public string FederatedCredentialProviderId { get; set; }

            /// <summary>
            /// <para>The name of the federated credential provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("FederatedCredentialProviderName")]
            [Validation(Required=false)]
            public string FederatedCredentialProviderName { get; set; }

            /// <summary>
            /// <para>The type of the federated credential provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pkcs7</para>
            /// </summary>
            [NameInMap("FederatedCredentialProviderType")]
            [Validation(Required=false)]
            public string FederatedCredentialProviderType { get; set; }

            /// <summary>
            /// <para>The ID of the EIAM instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_qlbbighyxbu42xl7eninojXXX</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the network access endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>inae_public</para>
            /// </summary>
            [NameInMap("NetworkAccessEndpointId")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointId { get; set; }

            /// <summary>
            /// <para>The OpenID Connect (OIDC) configuration.</para>
            /// </summary>
            [NameInMap("OidcProviderConfig")]
            [Validation(Required=false)]
            public GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderOidcProviderConfig OidcProviderConfig { get; set; }
            public class GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderOidcProviderConfig : TeaModel {
                /// <summary>
                /// <para>A list of audiences for the OIDC credential.</para>
                /// </summary>
                [NameInMap("Audiences")]
                [Validation(Required=false)]
                public List<string> Audiences { get; set; }

                /// <summary>
                /// <para>The dynamically obtained JWKS.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com">https://example.com</a></para>
                /// </summary>
                [NameInMap("DynamicJwks")]
                [Validation(Required=false)]
                public string DynamicJwks { get; set; }

                /// <summary>
                /// <para>The issuer of the OIDC credential.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://test.idaas.com/v2/oauth">http://test.idaas.com/v2/oauth</a></para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>The time of the last JWKS retrieval.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1729061324000</para>
                /// </summary>
                [NameInMap("JwksLastObtainedTime")]
                [Validation(Required=false)]
                public long? JwksLastObtainedTime { get; set; }

                /// <summary>
                /// <para>The source of the JSON Web Key Set (JWKS).</para>
                /// 
                /// <b>Example:</b>
                /// <para>static</para>
                /// </summary>
                [NameInMap("JwksSource")]
                [Validation(Required=false)]
                public string JwksSource { get; set; }

                /// <summary>
                /// <para>The JWKS endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com">https://example.com</a></para>
                /// </summary>
                [NameInMap("JwksUri")]
                [Validation(Required=false)]
                public string JwksUri { get; set; }

                /// <summary>
                /// <para>The static JWKS content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;keys&quot;: [
                ///     {
                ///       &quot;kty&quot;: &quot;RSA&quot;,
                ///       &quot;e&quot;: &quot;AQAB&quot;,
                ///       &quot;use&quot;: &quot;sig&quot;,
                ///       &quot;kid&quot;: &quot;KEY2RzsjRrimRASiAhCjBo18YwDoxpYHnHtv&quot;,
                ///       &quot;n&quot;: &quot;qrsfFfSZngqKOxVE29ZIR4SXkwKq029B3HLDAZui_Pwaxwn8FssR9QdwsljZS06BTDp10vhPgqMB7s7TmHulL3I4WuSB-l4uXTXXXX&quot;
                ///     }
                ///   ]
                /// }</para>
                /// </summary>
                [NameInMap("StaticJwks")]
                [Validation(Required=false)]
                public string StaticJwks { get; set; }

                /// <summary>
                /// <para>The trust condition for the OIDC provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IsNullOrEmpty(&quot;jwt.issuer&quot;)</para>
                /// </summary>
                [NameInMap("TrustCondition")]
                [Validation(Required=false)]
                public string TrustCondition { get; set; }

            }

            /// <summary>
            /// <para>The PKCS#7 configuration.</para>
            /// </summary>
            [NameInMap("Pkcs7ProviderConfig")]
            [Validation(Required=false)]
            public GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderPkcs7ProviderConfig Pkcs7ProviderConfig { get; set; }
            public class GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderPkcs7ProviderConfig : TeaModel {
                /// <summary>
                /// <para>A list of PKCS#7 certificates.</para>
                /// </summary>
                [NameInMap("Certificates")]
                [Validation(Required=false)]
                public List<GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderPkcs7ProviderConfigCertificates> Certificates { get; set; }
                public class GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderPkcs7ProviderConfigCertificates : TeaModel {
                    /// <summary>
                    /// <para>The certificate metadata.</para>
                    /// </summary>
                    [NameInMap("CertificateMetadata")]
                    [Validation(Required=false)]
                    public GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderPkcs7ProviderConfigCertificatesCertificateMetadata CertificateMetadata { get; set; }
                    public class GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderPkcs7ProviderConfigCertificatesCertificateMetadata : TeaModel {
                        /// <summary>
                        /// <para>The time when the certificate expires.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1729061324000</para>
                        /// </summary>
                        [NameInMap("NotAfter")]
                        [Validation(Required=false)]
                        public long? NotAfter { get; set; }

                        /// <summary>
                        /// <para>The time when the certificate becomes valid.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1729061324000</para>
                        /// </summary>
                        [NameInMap("NotBefore")]
                        [Validation(Required=false)]
                        public long? NotBefore { get; set; }

                    }

                    /// <summary>
                    /// <para>The content of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-----BEGIN CERTIFICATE-----
                    /// MIIE+zCCA0egAwIBAgIJAJZY0ZY0ZY0Z
                    /// -----END CERTIFICATE-----</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The fingerprint of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2b18947a6a9fc7764fd8b5fb18a863b0c6daxxx</para>
                    /// </summary>
                    [NameInMap("Fingerprint")]
                    [Validation(Required=false)]
                    public string Fingerprint { get; set; }

                }

                /// <summary>
                /// <para>The Cryptographic Message Syntax (CMS) verification mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cert</para>
                /// </summary>
                [NameInMap("CmsVerificationMode")]
                [Validation(Required=false)]
                public string CmsVerificationMode { get; set; }

                /// <summary>
                /// <para>The validity period of the signature, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3600</para>
                /// </summary>
                [NameInMap("SignatureEffectiveTime")]
                [Validation(Required=false)]
                public long? SignatureEffectiveTime { get; set; }

                /// <summary>
                /// <para>An expression that specifies the signing time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pkcs7.payload.jsonData.audience.signingTime</para>
                /// </summary>
                [NameInMap("SigningTimeValueExpression")]
                [Validation(Required=false)]
                public string SigningTimeValueExpression { get; set; }

                /// <summary>
                /// <para>The source of the certificate trust anchor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alibaba_cloud</para>
                /// </summary>
                [NameInMap("TrustAnchorSource")]
                [Validation(Required=false)]
                public string TrustAnchorSource { get; set; }

                /// <summary>
                /// <para>The trust condition for the PKCS#7 provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IsNullOrEmpty(&quot;certNo&quot;)</para>
                /// </summary>
                [NameInMap("TrustCondition")]
                [Validation(Required=false)]
                public string TrustCondition { get; set; }

            }

            /// <summary>
            /// <para>The private certificate authority (CA) configuration.</para>
            /// </summary>
            [NameInMap("PrivateCaProviderConfig")]
            [Validation(Required=false)]
            public GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderPrivateCaProviderConfig PrivateCaProviderConfig { get; set; }
            public class GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderPrivateCaProviderConfig : TeaModel {
                /// <summary>
                /// <para>A list of root certificates.</para>
                /// </summary>
                [NameInMap("Certificates")]
                [Validation(Required=false)]
                public List<GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderPrivateCaProviderConfigCertificates> Certificates { get; set; }
                public class GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderPrivateCaProviderConfigCertificates : TeaModel {
                    /// <summary>
                    /// <para>The certificate metadata.</para>
                    /// </summary>
                    [NameInMap("CertificateMetadata")]
                    [Validation(Required=false)]
                    public GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderPrivateCaProviderConfigCertificatesCertificateMetadata CertificateMetadata { get; set; }
                    public class GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderPrivateCaProviderConfigCertificatesCertificateMetadata : TeaModel {
                        /// <summary>
                        /// <para>The time when the certificate expires.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1729061324000</para>
                        /// </summary>
                        [NameInMap("NotAfter")]
                        [Validation(Required=false)]
                        public long? NotAfter { get; set; }

                        /// <summary>
                        /// <para>The time when the certificate becomes valid.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1729061324000</para>
                        /// </summary>
                        [NameInMap("NotBefore")]
                        [Validation(Required=false)]
                        public long? NotBefore { get; set; }

                    }

                    /// <summary>
                    /// <para>The content of the root certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-----BEGIN CERTIFICATE-----
                    /// MIIE+zCCA0egAwIBAgIJAJZY0ZY0ZY0Z
                    /// -----END CERTIFICATE-----</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The fingerprint of the root certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2b18947a6a9fc7764fd8b5fb18a863b0c6daxxx</para>
                    /// </summary>
                    [NameInMap("Fingerprint")]
                    [Validation(Required=false)]
                    public string Fingerprint { get; set; }

                }

                /// <summary>
                /// <para>The method for obtaining the root certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>custom</para>
                /// </summary>
                [NameInMap("TrustAnchorSource")]
                [Validation(Required=false)]
                public string TrustAnchorSource { get; set; }

                /// <summary>
                /// <para>The trust condition for the root certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IsNullOrEmpty(&quot;certNo&quot;)</para>
                /// </summary>
                [NameInMap("TrustCondition")]
                [Validation(Required=false)]
                public string TrustCondition { get; set; }

            }

            /// <summary>
            /// <para>The status of the federated credential provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the provider was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1729061324000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

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

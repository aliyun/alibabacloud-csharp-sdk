// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetFederatedCredentialProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>The federated credential provider object.</para>
        /// </summary>
        [NameInMap("FederatedCredentialProvider")]
        [Validation(Required=false)]
        public GetFederatedCredentialProviderResponseBodyFederatedCredentialProvider FederatedCredentialProvider { get; set; }
        public class GetFederatedCredentialProviderResponseBodyFederatedCredentialProvider : TeaModel {
            /// <summary>
            /// <para>The cloud identity provider configuration.</para>
            /// </summary>
            [NameInMap("CloudIdPProviderConfig")]
            [Validation(Required=false)]
            public GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderCloudIdPProviderConfig CloudIdPProviderConfig { get; set; }
            public class GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderCloudIdPProviderConfig : TeaModel {
                /// <summary>
                /// <para>The identity provider ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>idp_1234567890</para>
                /// </summary>
                [NameInMap("IdentityProviderId")]
                [Validation(Required=false)]
                public string IdentityProviderId { get; set; }

            }

            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
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
            /// <para>The federated trust source ID.</para>
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
            /// <para>The EIAM instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_qlbbighyxbu42xl7eninojXXX</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The network access endpoint ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>inae_public</para>
            /// </summary>
            [NameInMap("NetworkAccessEndpointId")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointId { get; set; }

            /// <summary>
            /// <para>The OIDC configuration.</para>
            /// </summary>
            [NameInMap("OidcProviderConfig")]
            [Validation(Required=false)]
            public GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderOidcProviderConfig OidcProviderConfig { get; set; }
            public class GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderOidcProviderConfig : TeaModel {
                /// <summary>
                /// <para>The audience list of the OIDC credential.</para>
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
                /// <para>The token issuer identifier (Issuer).</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://test.idaas.com/v2/oauth">http://test.idaas.com/v2/oauth</a></para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>The time when the JWKS was last obtained. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1729061324000</para>
                /// </summary>
                [NameInMap("JwksLastObtainedTime")]
                [Validation(Required=false)]
                public long? JwksLastObtainedTime { get; set; }

                /// <summary>
                /// <para>The JWKS source.</para>
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
                /// <para>The statically obtained JWKS.</para>
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
                /// <para>The trust condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IsNullOrEmpty(&quot;jwt.issuer&quot;)</para>
                /// </summary>
                [NameInMap("TrustCondition")]
                [Validation(Required=false)]
                public string TrustCondition { get; set; }

            }

            /// <summary>
            /// <para>The PKCS7 configuration.</para>
            /// </summary>
            [NameInMap("Pkcs7ProviderConfig")]
            [Validation(Required=false)]
            public GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderPkcs7ProviderConfig Pkcs7ProviderConfig { get; set; }
            public class GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderPkcs7ProviderConfig : TeaModel {
                /// <summary>
                /// <para>The PKCS7 certificate list.</para>
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
                        /// <para>The effective period of the certificate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1729061324000</para>
                        /// </summary>
                        [NameInMap("NotBefore")]
                        [Validation(Required=false)]
                        public long? NotBefore { get; set; }

                    }

                    /// <summary>
                    /// <para>The root certificate content.</para>
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
                    /// <para>The root certificate fingerprint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2b18947a6a9fc7764fd8b5fb18a863b0c6daxxx</para>
                    /// </summary>
                    [NameInMap("Fingerprint")]
                    [Validation(Required=false)]
                    public string Fingerprint { get; set; }

                }

                /// <summary>
                /// <para>The CMS verification mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cert</para>
                /// </summary>
                [NameInMap("CmsVerificationMode")]
                [Validation(Required=false)]
                public string CmsVerificationMode { get; set; }

                /// <summary>
                /// <para>The signature effective time. The value indicates the duration for which the signature is valid. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3600</para>
                /// </summary>
                [NameInMap("SignatureEffectiveTime")]
                [Validation(Required=false)]
                public long? SignatureEffectiveTime { get; set; }

                /// <summary>
                /// <para>The signing time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pkcs7.payload.jsonData.audience.signingTime</para>
                /// </summary>
                [NameInMap("SigningTimeValueExpression")]
                [Validation(Required=false)]
                public string SigningTimeValueExpression { get; set; }

                /// <summary>
                /// <para>The certificate trust anchor source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alibaba_cloud</para>
                /// </summary>
                [NameInMap("TrustAnchorSource")]
                [Validation(Required=false)]
                public string TrustAnchorSource { get; set; }

                /// <summary>
                /// <para>The trust condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IsNullOrEmpty(&quot;certNo&quot;)</para>
                /// </summary>
                [NameInMap("TrustCondition")]
                [Validation(Required=false)]
                public string TrustCondition { get; set; }

            }

            /// <summary>
            /// <para>The private CA configuration.</para>
            /// </summary>
            [NameInMap("PrivateCaProviderConfig")]
            [Validation(Required=false)]
            public GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderPrivateCaProviderConfig PrivateCaProviderConfig { get; set; }
            public class GetFederatedCredentialProviderResponseBodyFederatedCredentialProviderPrivateCaProviderConfig : TeaModel {
                /// <summary>
                /// <para>The root certificate.</para>
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
                        /// <para>The effective period of the certificate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1729061324000</para>
                        /// </summary>
                        [NameInMap("NotBefore")]
                        [Validation(Required=false)]
                        public long? NotBefore { get; set; }

                    }

                    /// <summary>
                    /// <para>The root certificate content.</para>
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
                    /// <para>The root certificate fingerprint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2b18947a6a9fc7764fd8b5fb18a863b0c6daxxx</para>
                    /// </summary>
                    [NameInMap("Fingerprint")]
                    [Validation(Required=false)]
                    public string Fingerprint { get; set; }

                }

                /// <summary>
                /// <para>The method used to retrieve the root certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>custom</para>
                /// </summary>
                [NameInMap("TrustAnchorSource")]
                [Validation(Required=false)]
                public string TrustAnchorSource { get; set; }

                /// <summary>
                /// <para>The trust condition of the root certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IsNullOrEmpty(&quot;certNo&quot;)</para>
                /// </summary>
                [NameInMap("TrustCondition")]
                [Validation(Required=false)]
                public string TrustCondition { get; set; }

            }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The update time. The value is a UNIX timestamp in milliseconds.</para>
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

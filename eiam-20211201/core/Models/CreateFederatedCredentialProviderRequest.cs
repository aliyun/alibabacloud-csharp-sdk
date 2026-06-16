// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateFederatedCredentialProviderRequest : TeaModel {
        [NameInMap("CloudIdPProviderConfig")]
        [Validation(Required=false)]
        public CreateFederatedCredentialProviderRequestCloudIdPProviderConfig CloudIdPProviderConfig { get; set; }
        public class CreateFederatedCredentialProviderRequestCloudIdPProviderConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>idp_m7hk2hbnew5ir3ycfabug6xxxx</para>
            /// </summary>
            [NameInMap("IdentityProviderId")]
            [Validation(Required=false)]
            public string IdentityProviderId { get; set; }

        }

        /// <summary>
        /// <para>The description of the federated credential provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the federated credential provider.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("FederatedCredentialProviderName")]
        [Validation(Required=false)]
        public string FederatedCredentialProviderName { get; set; }

        /// <summary>
        /// <para>The type of the federated credential provider.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pkcs7</para>
        /// </summary>
        [NameInMap("FederatedCredentialProviderType")]
        [Validation(Required=false)]
        public string FederatedCredentialProviderType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The network access endpoint ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nae_example_id</para>
        /// </summary>
        [NameInMap("NetworkAccessEndpointId")]
        [Validation(Required=false)]
        public string NetworkAccessEndpointId { get; set; }

        /// <summary>
        /// <para>The configuration for an OIDC-based provider.</para>
        /// </summary>
        [NameInMap("OidcProviderConfig")]
        [Validation(Required=false)]
        public CreateFederatedCredentialProviderRequestOidcProviderConfig OidcProviderConfig { get; set; }
        public class CreateFederatedCredentialProviderRequestOidcProviderConfig : TeaModel {
            /// <summary>
            /// <para>A list of audiences. The <c>aud</c> claim in the OIDC token must match a value from this list.</para>
            /// </summary>
            [NameInMap("Audiences")]
            [Validation(Required=false)]
            public List<string> Audiences { get; set; }

            /// <summary>
            /// <para>The issuer identifier for the OIDC provider. This value must match the <c>iss</c> claim in the token.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com">https://example.com</a></para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

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
            /// <para>The URI of the JWKS endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/jwks">https://example.com/jwks</a></para>
            /// </summary>
            [NameInMap("JwksUri")]
            [Validation(Required=false)]
            public string JwksUri { get; set; }

            /// <summary>
            /// <para>The static JWKS content in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;keys&quot;: [
            ///     {
            ///       &quot;kty&quot;: &quot;RSA&quot;,
            ///       &quot;e&quot;: &quot;AQAB&quot;,
            ///       &quot;use&quot;: &quot;sig&quot;,
            ///       &quot;kid&quot;: &quot;KEY2RzsjRrimRASiAhCjBo18YwDoxpYHnHtv&quot;,
            ///       &quot;n&quot;: &quot;qrsfFfSZngqKOxVE29ZIR4SXkwKq029B3HLDAZui_Pwaxwn8FssR9QdwsljZS06BTDp10vhPgqMB7s7TmHulL3I4WuSB-l4uXXXXX&quot;
            ///     }
            ///   ]
            /// }</para>
            /// </summary>
            [NameInMap("StaticJwks")]
            [Validation(Required=false)]
            public string StaticJwks { get; set; }

            /// <summary>
            /// <para>The condition the OIDC token must meet to be trusted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IsNullOrEmpty(&quot;jwt.issuer&quot;)</para>
            /// </summary>
            [NameInMap("TrustCondition")]
            [Validation(Required=false)]
            public string TrustCondition { get; set; }

        }

        /// <summary>
        /// <para>The configuration for a PKCS7-based provider.</para>
        /// </summary>
        [NameInMap("Pkcs7ProviderConfig")]
        [Validation(Required=false)]
        public CreateFederatedCredentialProviderRequestPkcs7ProviderConfig Pkcs7ProviderConfig { get; set; }
        public class CreateFederatedCredentialProviderRequestPkcs7ProviderConfig : TeaModel {
            /// <summary>
            /// <para>The certificates for verifying the PKCS7 signature.</para>
            /// </summary>
            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<CreateFederatedCredentialProviderRequestPkcs7ProviderConfigCertificates> Certificates { get; set; }
            public class CreateFederatedCredentialProviderRequestPkcs7ProviderConfigCertificates : TeaModel {
                /// <summary>
                /// <para>The content of the PEM-encoded certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-----BEGIN CERTIFICATE-----
                /// MIIE+zCCA0egAwIBAgIJAJZY0ZY0ZY0Z
                /// -----END CERTIFICATE-----</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

            }

            /// <summary>
            /// <para>The Cryptographic Message Syntax (CMS) verification mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cert_chain</para>
            /// </summary>
            [NameInMap("CmsVerificationMode")]
            [Validation(Required=false)]
            public string CmsVerificationMode { get; set; }

            /// <summary>
            /// <para>The validity period of the signature, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("SignatureEffectiveTime")]
            [Validation(Required=false)]
            public long? SignatureEffectiveTime { get; set; }

            /// <summary>
            /// <para>The expression to extract the signing time from the signature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pkcs7.signingTime</para>
            /// </summary>
            [NameInMap("SigningTimeValueExpression")]
            [Validation(Required=false)]
            public string SigningTimeValueExpression { get; set; }

            /// <summary>
            /// <para>The source of the trust anchor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("TrustAnchorSource")]
            [Validation(Required=false)]
            public string TrustAnchorSource { get; set; }

            /// <summary>
            /// <para>The condition that the signature data must meet to be trusted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IsNullOrEmpty(&quot;jwt.issuer&quot;)</para>
            /// </summary>
            [NameInMap("TrustCondition")]
            [Validation(Required=false)]
            public string TrustCondition { get; set; }

        }

        /// <summary>
        /// <para>The configuration for a private CA-based provider.</para>
        /// </summary>
        [NameInMap("PrivateCaProviderConfig")]
        [Validation(Required=false)]
        public CreateFederatedCredentialProviderRequestPrivateCaProviderConfig PrivateCaProviderConfig { get; set; }
        public class CreateFederatedCredentialProviderRequestPrivateCaProviderConfig : TeaModel {
            /// <summary>
            /// <para>The root certificates that form the trust anchor.</para>
            /// </summary>
            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<CreateFederatedCredentialProviderRequestPrivateCaProviderConfigCertificates> Certificates { get; set; }
            public class CreateFederatedCredentialProviderRequestPrivateCaProviderConfigCertificates : TeaModel {
                /// <summary>
                /// <para>The content of the PEM-encoded certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-----BEGIN CERTIFICATE-----
                /// MIIE+zCCA0egAwIBAgIJAJZY0ZY0ZY0Z
                /// -----END CERTIFICATE-----</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

            }

            /// <summary>
            /// <para>The source of the trust anchor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("TrustAnchorSource")]
            [Validation(Required=false)]
            public string TrustAnchorSource { get; set; }

            /// <summary>
            /// <para>The condition for trusting the root certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IsNullOrEmpty(&quot;jwt.issuer&quot;)</para>
            /// </summary>
            [NameInMap("TrustCondition")]
            [Validation(Required=false)]
            public string TrustCondition { get; set; }

        }

    }

}

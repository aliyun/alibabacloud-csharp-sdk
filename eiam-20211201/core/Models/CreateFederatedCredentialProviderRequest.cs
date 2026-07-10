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
        /// <para>The description of the federated trust source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the federated trust source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("FederatedCredentialProviderName")]
        [Validation(Required=false)]
        public string FederatedCredentialProviderName { get; set; }

        /// <summary>
        /// <para>The type of the federated trust source.</para>
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
        /// <para>The ID of the network access endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nae_example_id</para>
        /// </summary>
        [NameInMap("NetworkAccessEndpointId")]
        [Validation(Required=false)]
        public string NetworkAccessEndpointId { get; set; }

        /// <summary>
        /// <para>The OIDC configuration.</para>
        /// </summary>
        [NameInMap("OidcProviderConfig")]
        [Validation(Required=false)]
        public CreateFederatedCredentialProviderRequestOidcProviderConfig OidcProviderConfig { get; set; }
        public class CreateFederatedCredentialProviderRequestOidcProviderConfig : TeaModel {
            /// <summary>
            /// <para>The list of audiences.</para>
            /// </summary>
            [NameInMap("Audiences")]
            [Validation(Required=false)]
            public List<string> Audiences { get; set; }

            /// <summary>
            /// <para>Issuer</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com">https://example.com</a></para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>The source of the JWKS.</para>
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
            /// <para><a href="https://example.com/jwks">https://example.com/jwks</a></para>
            /// </summary>
            [NameInMap("JwksUri")]
            [Validation(Required=false)]
            public string JwksUri { get; set; }

            /// <summary>
            /// <para>The statically retrieved JWKS.</para>
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
        public CreateFederatedCredentialProviderRequestPkcs7ProviderConfig Pkcs7ProviderConfig { get; set; }
        public class CreateFederatedCredentialProviderRequestPkcs7ProviderConfig : TeaModel {
            /// <summary>
            /// <para>The list of PKCS7 certificates.</para>
            /// </summary>
            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<CreateFederatedCredentialProviderRequestPkcs7ProviderConfigCertificates> Certificates { get; set; }
            public class CreateFederatedCredentialProviderRequestPkcs7ProviderConfigCertificates : TeaModel {
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

            }

            /// <summary>
            /// <para>The CMS verification mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cert_chain</para>
            /// </summary>
            [NameInMap("CmsVerificationMode")]
            [Validation(Required=false)]
            public string CmsVerificationMode { get; set; }

            /// <summary>
            /// <para>The validity period of the signature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("SignatureEffectiveTime")]
            [Validation(Required=false)]
            public long? SignatureEffectiveTime { get; set; }

            /// <summary>
            /// <para>The expression used to retrieve the signing time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pkcs7.signingTime</para>
            /// </summary>
            [NameInMap("SigningTimeValueExpression")]
            [Validation(Required=false)]
            public string SigningTimeValueExpression { get; set; }

            /// <summary>
            /// <para>The source of the certificate trust anchor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("TrustAnchorSource")]
            [Validation(Required=false)]
            public string TrustAnchorSource { get; set; }

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
        /// <para>The private CA configuration.</para>
        /// </summary>
        [NameInMap("PrivateCaProviderConfig")]
        [Validation(Required=false)]
        public CreateFederatedCredentialProviderRequestPrivateCaProviderConfig PrivateCaProviderConfig { get; set; }
        public class CreateFederatedCredentialProviderRequestPrivateCaProviderConfig : TeaModel {
            /// <summary>
            /// <para>The list of root certificates.</para>
            /// </summary>
            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<CreateFederatedCredentialProviderRequestPrivateCaProviderConfigCertificates> Certificates { get; set; }
            public class CreateFederatedCredentialProviderRequestPrivateCaProviderConfigCertificates : TeaModel {
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
            /// <para>The trust condition for the root certificate.</para>
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

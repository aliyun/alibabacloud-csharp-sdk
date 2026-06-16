// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateFederatedCredentialProviderRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the federated credential provider.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fcp_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("FederatedCredentialProviderId")]
        [Validation(Required=false)]
        public string FederatedCredentialProviderId { get; set; }

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
        /// <para>nae_public</para>
        /// </summary>
        [NameInMap("NetworkAccessEndpointId")]
        [Validation(Required=false)]
        public string NetworkAccessEndpointId { get; set; }

        /// <summary>
        /// <para>The OpenID Connect (OIDC) configuration.</para>
        /// </summary>
        [NameInMap("OidcProviderConfig")]
        [Validation(Required=false)]
        public UpdateFederatedCredentialProviderRequestOidcProviderConfig OidcProviderConfig { get; set; }
        public class UpdateFederatedCredentialProviderRequestOidcProviderConfig : TeaModel {
            /// <summary>
            /// <para>The list of audiences.</para>
            /// </summary>
            [NameInMap("Audiences")]
            [Validation(Required=false)]
            public List<string> Audiences { get; set; }

            /// <summary>
            /// <para>The source of the JSON Web Key Set (JWKS).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>static</para>
            /// </summary>
            [NameInMap("JwksSource")]
            [Validation(Required=false)]
            public string JwksSource { get; set; }

            /// <summary>
            /// <para>JWKS endpoint</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/jwks">https://example.com/jwks</a></para>
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
        public UpdateFederatedCredentialProviderRequestPkcs7ProviderConfig Pkcs7ProviderConfig { get; set; }
        public class UpdateFederatedCredentialProviderRequestPkcs7ProviderConfig : TeaModel {
            /// <summary>
            /// <para>The list of PKCS7 certificates.</para>
            /// </summary>
            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<UpdateFederatedCredentialProviderRequestPkcs7ProviderConfigCertificates> Certificates { get; set; }
            public class UpdateFederatedCredentialProviderRequestPkcs7ProviderConfigCertificates : TeaModel {
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
            /// <para>The Cryptographic Message Syntax (CMS) verification mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cert</para>
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
            /// <para>The expression to obtain the signing time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pkcs7.signingTime</para>
            /// </summary>
            [NameInMap("SigningTimeValueExpression")]
            [Validation(Required=false)]
            public string SigningTimeValueExpression { get; set; }

            /// <summary>
            /// <para>The source of the certificate trust anchor.</para>
            /// <para>This parameter is required.</para>
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
        /// <para>The configuration of the private certificate authority (CA).</para>
        /// </summary>
        [NameInMap("PrivateCaProviderConfig")]
        [Validation(Required=false)]
        public UpdateFederatedCredentialProviderRequestPrivateCaProviderConfig PrivateCaProviderConfig { get; set; }
        public class UpdateFederatedCredentialProviderRequestPrivateCaProviderConfig : TeaModel {
            /// <summary>
            /// <para>The list of root certificates.</para>
            /// </summary>
            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<UpdateFederatedCredentialProviderRequestPrivateCaProviderConfigCertificates> Certificates { get; set; }
            public class UpdateFederatedCredentialProviderRequestPrivateCaProviderConfigCertificates : TeaModel {
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
            /// <para>The method to obtain the root certificate.</para>
            /// <para>This parameter is required.</para>
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

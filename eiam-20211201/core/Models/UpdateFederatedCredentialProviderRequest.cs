// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateFederatedCredentialProviderRequest : TeaModel {
        /// <summary>
        /// <para>联邦凭证提供方ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fcp_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("FederatedCredentialProviderId")]
        [Validation(Required=false)]
        public string FederatedCredentialProviderId { get; set; }

        /// <summary>
        /// <para>联邦凭证提供方名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("FederatedCredentialProviderName")]
        [Validation(Required=false)]
        public string FederatedCredentialProviderName { get; set; }

        /// <summary>
        /// <para>IDaaS EIAM实例的ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>网络端点ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>nae_public</para>
        /// </summary>
        [NameInMap("NetworkAccessEndpointId")]
        [Validation(Required=false)]
        public string NetworkAccessEndpointId { get; set; }

        /// <summary>
        /// <para>OIDC配置</para>
        /// </summary>
        [NameInMap("OidcProviderConfig")]
        [Validation(Required=false)]
        public UpdateFederatedCredentialProviderRequestOidcProviderConfig OidcProviderConfig { get; set; }
        public class UpdateFederatedCredentialProviderRequestOidcProviderConfig : TeaModel {
            [NameInMap("Audiences")]
            [Validation(Required=false)]
            public List<string> Audiences { get; set; }

            /// <summary>
            /// <para>Jwks来源</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>static</para>
            /// </summary>
            [NameInMap("JwksSource")]
            [Validation(Required=false)]
            public string JwksSource { get; set; }

            /// <summary>
            /// <para>JWKS 端点</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/jwks">https://example.com/jwks</a></para>
            /// </summary>
            [NameInMap("JwksUri")]
            [Validation(Required=false)]
            public string JwksUri { get; set; }

            /// <summary>
            /// <para>静态获取的jwks</para>
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
            /// <para>信任条件</para>
            /// 
            /// <b>Example:</b>
            /// <para>IsNullOrEmpty(&quot;jwt.issuer&quot;)</para>
            /// </summary>
            [NameInMap("TrustCondition")]
            [Validation(Required=false)]
            public string TrustCondition { get; set; }

        }

        /// <summary>
        /// <para>PKCS7配置</para>
        /// </summary>
        [NameInMap("Pkcs7ProviderConfig")]
        [Validation(Required=false)]
        public UpdateFederatedCredentialProviderRequestPkcs7ProviderConfig Pkcs7ProviderConfig { get; set; }
        public class UpdateFederatedCredentialProviderRequestPkcs7ProviderConfig : TeaModel {
            /// <summary>
            /// <para>pkcs7证书列表</para>
            /// </summary>
            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<UpdateFederatedCredentialProviderRequestPkcs7ProviderConfigCertificates> Certificates { get; set; }
            public class UpdateFederatedCredentialProviderRequestPkcs7ProviderConfigCertificates : TeaModel {
                /// <summary>
                /// <para>Root证书内容</para>
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
            /// <para>CMS验证模式</para>
            /// 
            /// <b>Example:</b>
            /// <para>cert</para>
            /// </summary>
            [NameInMap("CmsVerificationMode")]
            [Validation(Required=false)]
            public string CmsVerificationMode { get; set; }

            /// <summary>
            /// <para>签名有效期, 单位秒，1200</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("SignatureEffectiveTime")]
            [Validation(Required=false)]
            public long? SignatureEffectiveTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pkcs7.signingTime</para>
            /// </summary>
            [NameInMap("SigningTimeValueExpression")]
            [Validation(Required=false)]
            public string SigningTimeValueExpression { get; set; }

            /// <summary>
            /// <para>证书信任锚点来源</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("TrustAnchorSource")]
            [Validation(Required=false)]
            public string TrustAnchorSource { get; set; }

            /// <summary>
            /// <para>信任条件</para>
            /// 
            /// <b>Example:</b>
            /// <para>IsNullOrEmpty(&quot;jwt.issuer&quot;)</para>
            /// </summary>
            [NameInMap("TrustCondition")]
            [Validation(Required=false)]
            public string TrustCondition { get; set; }

        }

        /// <summary>
        /// <para>私有CA配置</para>
        /// </summary>
        [NameInMap("PrivateCaProviderConfig")]
        [Validation(Required=false)]
        public UpdateFederatedCredentialProviderRequestPrivateCaProviderConfig PrivateCaProviderConfig { get; set; }
        public class UpdateFederatedCredentialProviderRequestPrivateCaProviderConfig : TeaModel {
            /// <summary>
            /// <para>Root证书列表</para>
            /// </summary>
            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<UpdateFederatedCredentialProviderRequestPrivateCaProviderConfigCertificates> Certificates { get; set; }
            public class UpdateFederatedCredentialProviderRequestPrivateCaProviderConfigCertificates : TeaModel {
                /// <summary>
                /// <para>Root证书内容</para>
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
            /// <para>Root证书获取方式</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("TrustAnchorSource")]
            [Validation(Required=false)]
            public string TrustAnchorSource { get; set; }

            /// <summary>
            /// <para>Root证书的信任条件</para>
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

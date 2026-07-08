// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetCertificateDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The certificate algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RSA</b>: The RSA algorithm.</para>
        /// </description></item>
        /// <item><description><para><b>ECC</b>: The ECC algorithm.</para>
        /// </description></item>
        /// <item><description><para><b>SM2</b>: The SM2 algorithm.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RSA</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The global ID of the certificate, which is used in various Alibaba Cloud services. The format of the ID is <c>&lt;Certificate ID&gt;-&lt;Region ID&gt;</c>. The region ID is <c>cn-hangzhou</c> for the China site and <c>ap-southeast-1</c> for the International site. For example, if a certificate ID is <c>123</c>, its <c>CertIdentifier</c> is <c>123-cn-hangzhou</c> for the China site and <c>123-ap-southeast-1</c> for the International site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21912069-cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// <para>The information about the certificate chain.</para>
        /// </summary>
        [NameInMap("CertificateChainList")]
        [Validation(Required=false)]
        public List<GetCertificateDetailResponseBodyCertificateChainList> CertificateChainList { get; set; }
        public class GetCertificateDetailResponseBodyCertificateChainList : TeaModel {
            /// <summary>
            /// <para>The issuer of the certificate chain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Digicert</para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>The end of the validity period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17326613180000</para>
            /// </summary>
            [NameInMap("NotAfter")]
            [Validation(Required=false)]
            public long? NotAfter { get; set; }

            /// <summary>
            /// <para>The beginning of the validity period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17321613180000</para>
            /// </summary>
            [NameInMap("NotBefore")]
            [Validation(Required=false)]
            public long? NotBefore { get; set; }

            /// <summary>
            /// <para>The remaining validity period of the certificate chain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RemainDay")]
            [Validation(Required=false)]
            public int? RemainDay { get; set; }

            /// <summary>
            /// <para>The common name of the certificate chain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Digicert</para>
            /// </summary>
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

        }

        /// <summary>
        /// <para>The certificate ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22559621</para>
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public int? CertificateId { get; set; }

        /// <summary>
        /// <para>The certificate name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("CertificateName")]
        [Validation(Required=false)]
        public string CertificateName { get; set; }

        /// <summary>
        /// <para>The source of the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>BUY</b>: a purchased certificate.</para>
        /// </description></item>
        /// <item><description><para><b>TEST</b>: a test certificate.</para>
        /// </description></item>
        /// <item><description><para>Upload the certificate.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BUY</para>
        /// </summary>
        [NameInMap("CertificateSource")]
        [Validation(Required=false)]
        public string CertificateSource { get; set; }

        /// <summary>
        /// <para>The status of the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>issued</b>: The certificate is issued.</para>
        /// </description></item>
        /// <item><description><para><b>revoked</b>: The certificate is revoked.</para>
        /// </description></item>
        /// <item><description><para><b>willExpire</b>: The certificate is about to expire.</para>
        /// </description></item>
        /// <item><description><para><b>expired</b>: The certificate has expired.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>issued</para>
        /// </summary>
        [NameInMap("CertificateStatus")]
        [Validation(Required=false)]
        public string CertificateStatus { get; set; }

        /// <summary>
        /// <para>The common name.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The ID of the company profile that is associated with the certificate application. This parameter is empty for DV certificates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44211</para>
        /// </summary>
        [NameInMap("CompanyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        /// <summary>
        /// <para>The ID of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>304066</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public long? ContactId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE REQUEST----- ...... -----END CERTIFICATE REQUEST-----</para>
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        /// <summary>
        /// <para>The domain names that are bound to the certificate. Multiple domain names are separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyundoc.com,example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Indicates whether a private key is available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ExistPrivateKey")]
        [Validation(Required=false)]
        public bool? ExistPrivateKey { get; set; }

        /// <summary>
        /// <para>The fingerprint of the public key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("FingerPrint")]
        [Validation(Required=false)]
        public string FingerPrint { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas_dv-cn-123</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The issuer of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Digicert</para>
        /// </summary>
        [NameInMap("Issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// <para>The key size.</para>
        /// <list type="bullet">
        /// <item><description><para>For RSA algorithms, the key size is typically 2,048, 3,072, or 4,096 bits.</para>
        /// </description></item>
        /// <item><description><para>For ECC and SM2 algorithms, the key size is typically 256 bits.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("KeySize")]
        [Validation(Required=false)]
        public int? KeySize { get; set; }

        /// <summary>
        /// <para>The end of the validity period of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17326613180000</para>
        /// </summary>
        [NameInMap("NotAfter")]
        [Validation(Required=false)]
        public long? NotAfter { get; set; }

        /// <summary>
        /// <para>The beginning of the validity period of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17321613180000</para>
        /// </summary>
        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public long? NotBefore { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5979d897-d69f-4fc9-87dd-f3bb73c40b80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The serial number of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Serial")]
        [Validation(Required=false)]
        public string Serial { get; set; }

        /// <summary>
        /// <para>The subject alternative names (SANs) of the certificate.</para>
        /// </summary>
        [NameInMap("SubjectAlternativeNames")]
        [Validation(Required=false)]
        public List<string> SubjectAlternativeNames { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetCertificateDetailResponseBodyTags> Tags { get; set; }
        public class GetCertificateDetailResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance. You can specify 1 to 20 tag keys. The value cannot be an empty string.</para>
            /// <para>The value can be up to 64 characters in length, cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>The list of cloud services in which the certificate is deployed.</para>
        /// </summary>
        [NameInMap("UsingProductList")]
        [Validation(Required=false)]
        public List<string> UsingProductList { get; set; }

    }

}

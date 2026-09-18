// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetCertificateDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The certificate algorithm.</para>
        /// <list type="bullet">
        /// <item><description><b>RSA</b>: RSA algorithm.</description></item>
        /// <item><description><b>ECC</b>: ECC algorithm.</description></item>
        /// <item><description><b>SM2</b>: SM2 algorithm.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RSA</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The global certificate ID in the format of certificate ID + &quot;-&quot; + site region ID. This ID is commonly used across Alibaba Cloud services.
        ///   --For the China site, the value is certificate ID + &quot;-cn-hangzhou&quot;.
        /// For the International site, the value is certificate ID + &quot;-ap-southeast-1&quot;.
        /// For example, if the certificate ID is 123, the CertIdentifier on the China site is &quot;123-cn-hangzhou&quot;, and the CertIdentifier on the International site is &quot;123-ap-southeast-1&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21912069-cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// <para>The certificate chain information list.</para>
        /// </summary>
        [NameInMap("CertificateChainList")]
        [Validation(Required=false)]
        public List<GetCertificateDetailResponseBodyCertificateChainList> CertificateChainList { get; set; }
        public class GetCertificateDetailResponseBodyCertificateChainList : TeaModel {
            /// <summary>
            /// <para>The issuer name of the certificate chain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Digicert</para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>The end time of the certificate validity period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17326613180000</para>
            /// </summary>
            [NameInMap("NotAfter")]
            [Validation(Required=false)]
            public long? NotAfter { get; set; }

            /// <summary>
            /// <para>The start time of the certificate validity period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17321613180000</para>
            /// </summary>
            [NameInMap("NotBefore")]
            [Validation(Required=false)]
            public long? NotBefore { get; set; }

            /// <summary>
            /// <para>The remaining days of the certificate chain validity period.</para>
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
        /// <para>The certificate source.</para>
        /// <list type="bullet">
        /// <item><description>BUY: Purchased certificate.</description></item>
        /// <item><description>TEST: Test certificate.</description></item>
        /// <item><description>UPLOAD: Uploaded certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BUY</para>
        /// </summary>
        [NameInMap("CertificateSource")]
        [Validation(Required=false)]
        public string CertificateSource { get; set; }

        /// <summary>
        /// <para>The certificate status.</para>
        /// <list type="bullet">
        /// <item><description><b>issued</b>: Issued.</description></item>
        /// <item><description><b>revoked</b>: Revoked.</description></item>
        /// <item><description><b>willExpire</b>: About to expire.</description></item>
        /// <item><description><b>expired</b>: Expired.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>issued</para>
        /// </summary>
        [NameInMap("CertificateStatus")]
        [Validation(Required=false)]
        public string CertificateStatus { get; set; }

        /// <summary>
        /// <para>The common domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The company information ID associated with the certificate application. This value is empty for DV certificates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44211</para>
        /// </summary>
        [NameInMap("CompanyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        /// <summary>
        /// <para>The contact ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>304066</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public long? ContactId { get; set; }

        /// <summary>
        /// <para>The certificate signing request (CSR) used to issue the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE REQUEST----- ...... -----END CERTIFICATE REQUEST-----</para>
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        /// <summary>
        /// <para>The deployment information in JSON format:</para>
        /// <para>--Scope: Valid values are all/server. The value is all if the certificate has a private key, or server if it does not.</para>
        /// <para>--ServerName: The name of the server associated with the certificate instance.</para>
        /// <para>--ResourceInstanceId: The resource identifier of the server associated with the certificate instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;Scope&quot;: &quot;all&quot;,
        ///        &quot;ServerName&quot;: &quot;acmeServerName&quot;,
        ///        &quot;ResourceInstanceId&quot;: &quot;cas_dv-cn-XXX&quot;
        /// }</para>
        /// </summary>
        [NameInMap("DeploymentDesc")]
        [Validation(Required=false)]
        public string DeploymentDesc { get; set; }

        /// <summary>
        /// <para>All domain names included in the certificate. Multiple domain names are separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyundoc.com,example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Indicates whether a private key exists on the backend for the current certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ExistPrivateKey")]
        [Validation(Required=false)]
        public bool? ExistPrivateKey { get; set; }

        /// <summary>
        /// <para>The public key fingerprint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("FingerPrint")]
        [Validation(Required=false)]
        public string FingerPrint { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas_dv-cn-123</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The certificate issue authority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Digicert</para>
        /// </summary>
        [NameInMap("Issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// <para>The key algorithm length.</para>
        /// <list type="bullet">
        /// <item><description>The RSA algorithm length is typically 2048, 3072, or 4096.</description></item>
        /// <item><description>The ECC and SM2 algorithm length is typically 256.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("KeySize")]
        [Validation(Required=false)]
        public int? KeySize { get; set; }

        /// <summary>
        /// <para>The end time of the certificate validity period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17326613180000</para>
        /// </summary>
        [NameInMap("NotAfter")]
        [Validation(Required=false)]
        public long? NotAfter { get; set; }

        /// <summary>
        /// <para>The start time of the certificate validity period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17321613180000</para>
        /// </summary>
        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public long? NotBefore { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5979d897-d69f-4fc9-87dd-f3bb73c40b80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The certificate serial number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Serial")]
        [Validation(Required=false)]
        public string Serial { get; set; }

        /// <summary>
        /// <para>The list of Subject Alternative Names (SANs) of the certificate, returned in array format. This corresponds to the <c>Subject Alternative Name</c> field of the certificate.</para>
        /// </summary>
        [NameInMap("SubjectAlternativeNames")]
        [Validation(Required=false)]
        public List<string> SubjectAlternativeNames { get; set; }

        /// <summary>
        /// <para>The tag list.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetCertificateDetailResponseBodyTags> Tags { get; set; }
        public class GetCertificateDetailResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance. Valid values of N: <b>1</b> to <b>20</b>. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>The list of Alibaba Cloud services to which the certificate is currently deployed.</para>
        /// </summary>
        [NameInMap("UsingProductList")]
        [Validation(Required=false)]
        public List<string> UsingProductList { get; set; }

    }

}

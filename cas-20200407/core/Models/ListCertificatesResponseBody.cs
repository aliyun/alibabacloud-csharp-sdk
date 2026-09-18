// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCertificatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of certificates.</para>
        /// </summary>
        [NameInMap("CertificateList")]
        [Validation(Required=false)]
        public List<ListCertificatesResponseBodyCertificateList> CertificateList { get; set; }
        public class ListCertificatesResponseBodyCertificateList : TeaModel {
            /// <summary>
            /// <para>The encryption algorithm type of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RSA</b>: RSA algorithm.</description></item>
            /// <item><description><b>ECC</b>: ECC algorithm.</description></item>
            /// <item><description><b>SM2</b>: SM2 (Chinese national cryptographic) algorithm.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RSA</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// <para>The global certificate ID, in the format of certificate ID + &quot;-&quot; + site region ID. This ID is commonly used across Alibaba Cloud services.</para>
            /// <list type="bullet">
            /// <item><description>For the China site, the value is certificate ID + &quot;-cn-hangzhou&quot;.</description></item>
            /// <item><description>For the China site, the value is certificate ID + &quot;-ap-southeast-1&quot;.</description></item>
            /// </list>
            /// <para>For example, if the certificate ID is 123, the CertIdentifier on the China site is &quot;123-cn-hangzhou&quot;, and the CertIdentifier on the China site is &quot;123-ap-southeast-1&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21589515-cn-hangzhou</para>
            /// </summary>
            [NameInMap("CertIdentifier")]
            [Validation(Required=false)]
            public string CertIdentifier { get; set; }

            /// <summary>
            /// <para>The certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17281539</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

            /// <summary>
            /// <para>The certificate name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("CertificateName")]
            [Validation(Required=false)]
            public string CertificateName { get; set; }

            /// <summary>
            /// <para>The source of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BUY: a formal certificate.</description></item>
            /// <item><description>TEST: a test certificate.</description></item>
            /// <item><description>UPLOAD: an uploaded certificate.</description></item>
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
            /// <para>The common name of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun.com</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The deployment information in JSON format:</para>
            /// <para>--Scope: valid values are all/server. If the certificate has a private key, the value is all. If the certificate does not have a private key, the value is server.</para>
            /// <para>--ServerName: the name of the server associated with the certificate instance.</para>
            /// <para>--ResourceInstanceId: the resource identifier of the server associated with the certificate instance.</para>
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
            /// <para>The domain names bound to the certificate. Multiple domain names are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>Indicates whether the certificate has a private key. Valid values:</para>
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
            /// <para>The fingerprint of the public key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("FingerPrint")]
            [Validation(Required=false)]
            public string FingerPrint { get; set; }

            /// <summary>
            /// <para>The certificate instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cas-cn-v***</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The certificate issuer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DigiCert</para>
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
            /// <para>1749580567000</para>
            /// </summary>
            [NameInMap("NotAfter")]
            [Validation(Required=false)]
            public long? NotAfter { get; set; }

            /// <summary>
            /// <para>The start time of the certificate validity period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1760745600000</para>
            /// </summary>
            [NameInMap("NotBefore")]
            [Validation(Required=false)]
            public long? NotBefore { get; set; }

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
            /// <para>The list of subject alternative names (SANs) of the certificate, returned as an array. This corresponds to the <c>Subject Alternative Name</c> field of the certificate.</para>
            /// </summary>
            [NameInMap("SubjectAlternativeNames")]
            [Validation(Required=false)]
            public List<string> SubjectAlternativeNames { get; set; }

            /// <summary>
            /// <para>The list of Alibaba Cloud services to which the certificate is currently deployed.</para>
            /// </summary>
            [NameInMap("UsingProductList")]
            [Validation(Required=false)]
            public List<string> UsingProductList { get; set; }

        }

        /// <summary>
        /// <para>The current page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

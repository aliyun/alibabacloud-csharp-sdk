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
            /// <para>The encryption algorithm of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>RSA</b></para>
            /// </description></item>
            /// <item><description><para><b>ECC</b></para>
            /// </description></item>
            /// <item><description><para><b>SM2</b></para>
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
            /// <para>The global ID of the certificate. This ID is used across Alibaba Cloud services and is in the <c>Certificate ID-Region ID</c> format. For example, if a certificate ID is <c>123</c>, the <c>CertIdentifier</c> is <c>123-cn-hangzhou</c> for the Alibaba Cloud China site and <c>123-ap-southeast-1</c> for the Alibaba Cloud International site (www\.alibabacloud.com).</para>
            /// <list type="bullet">
            /// <item><description><para>For the Alibaba Cloud China website, the format is certificate ID + &quot;-cn-hangzhou&quot;.</para>
            /// </description></item>
            /// <item><description><para>For the Alibaba Cloud International website (www\.alibabacloud.com), the format is certificate ID + &quot;-ap-southeast-1&quot;.</para>
            /// </description></item>
            /// </list>
            /// <para>For example, if the certificate ID is 123, the CertIdentifier is &quot;123-cn-hangzhou&quot; for the China site and &quot;123-ap-southeast-1&quot; for the International site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21589515-cn-hangzhou</para>
            /// </summary>
            [NameInMap("CertIdentifier")]
            [Validation(Required=false)]
            public string CertIdentifier { get; set; }

            /// <summary>
            /// <para>The ID of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17281539</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

            /// <summary>
            /// <para>The name of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("CertificateName")]
            [Validation(Required=false)]
            public string CertificateName { get; set; }

            /// <summary>
            /// <para>The source of the certificate.</para>
            /// <list type="bullet">
            /// <item><description><para>BUY: A purchased certificate.</para>
            /// </description></item>
            /// <item><description><para>TEST: A test certificate.</para>
            /// </description></item>
            /// <item><description><para>UPLOAD: An uploaded certificate.</para>
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
            /// <para>The status of the certificate.</para>
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
            /// <para>The common name of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun.com</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The domain names that are bound to the certificate. Multiple domain names are separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>Indicates whether a private key is available. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: A private key is available.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: A private key is not available.</para>
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
            /// <para>The ID of the certificate instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cas-cn-v***</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The certification authority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DigiCert</para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>The key size, in bits.</para>
            /// <list type="bullet">
            /// <item><description><para>For RSA keys, typical sizes are 2048, 3072, or 4096.</para>
            /// </description></item>
            /// <item><description><para>For ECC or SM2 keys, the typical size is 256.</para>
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
            /// <para>The end of the certificate validity period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1749580567000</para>
            /// </summary>
            [NameInMap("NotAfter")]
            [Validation(Required=false)]
            public long? NotAfter { get; set; }

            /// <summary>
            /// <para>The beginning of the certificate validity period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1760745600000</para>
            /// </summary>
            [NameInMap("NotBefore")]
            [Validation(Required=false)]
            public long? NotBefore { get; set; }

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
            /// <para>An array that contains the alternative domain names of the certificate. This parameter corresponds to the <c>Subject Alternative Name</c> field of the certificate.</para>
            /// </summary>
            [NameInMap("SubjectAlternativeNames")]
            [Validation(Required=false)]
            public List<string> SubjectAlternativeNames { get; set; }

            /// <summary>
            /// <para>The list of Alibaba Cloud products in which the certificate is deployed.</para>
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
        /// <para>The ID of the request. Alibaba Cloud generates a unique ID for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateServerCertificateWithCsrRequest : TeaModel {
        /// <summary>
        /// <para>The expiration time of the server certificate in UNIX timestamp format. Unit: seconds.</para>
        /// <remarks>
        /// <para>The <b>BeforeTime</b> and <b>AfterTime</b> parameters must both be empty or both be specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1665819958</para>
        /// </summary>
        [NameInMap("AfterTime")]
        [Validation(Required=false)]
        public long? AfterTime { get; set; }

        /// <summary>
        /// <para>The key algorithm of the server certificate. The key algorithm is in the <c>&lt;Encryption algorithm&gt;_&lt;Key length&gt;</c> format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RSA_1024</b>: The signature algorithm is Sha256WithRSA.</description></item>
        /// <item><description><b>RSA_2048</b>: The signature algorithm is Sha256WithRSA.</description></item>
        /// <item><description><b>RSA_4096</b>: The signature algorithm is Sha256WithRSA.</description></item>
        /// <item><description><b>ECC_256</b>: The signature algorithm is Sha256WithECDSA.</description></item>
        /// <item><description><b>ECC_384</b>: The signature algorithm is Sha256WithECDSA.</description></item>
        /// <item><description><b>ECC_512</b>: The signature algorithm is Sha256WithECDSA.</description></item>
        /// <item><description><b>SM2_256</b>: The signature algorithm is SM3WithSM2.</description></item>
        /// </list>
        /// <para>The encryption algorithm of the server certificate must be the same as that of the subordinate CA certificate, but the key length can be different. For example, if the key algorithm of the subordinate CA certificate is RSA_2048, the key algorithm of the server certificate must be RSA_1024, RSA_2048, or RSA_4096.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/465954.html">DescribeCACertificate</a> to query the key algorithm of the subordinate CA certificate.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_2048</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AsynchronousFlag")]
        [Validation(Required=false)]
        public bool? AsynchronousFlag { get; set; }

        /// <summary>
        /// <para>The issuance time of the server certificate in UNIX timestamp format. The default value is the time when you call this operation. Unit: seconds.</para>
        /// <remarks>
        /// <para>The <b>BeforeTime</b> and <b>AfterTime</b> parameters must both be empty or both be specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1634283958</para>
        /// </summary>
        [NameInMap("BeforeTime")]
        [Validation(Required=false)]
        public long? BeforeTime { get; set; }

        /// <summary>
        /// <para>The common name of the certificate. Chinese characters, English characters, and other characters are supported.</para>
        /// <remarks>
        /// <para>If you set the <b>Csr</b> parameter, the value of the <b>CommonName</b> parameter is determined by the corresponding information in the <b>Csr</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mtcsq.com</para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The country code, such as <b>CN</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <para>The CSR content.
        /// You can use OpenSSL or Keytool to generate a CSR. For more information, see <a href="https://help.aliyun.com/document_detail/42218.html">How do I create a CSR file?</a>.
        /// &lt;props=&quot;china&quot;&gt;You can also create a CSR in the SSL Certificates Service console. For more information, see <a href="https://help.aliyun.com/document_detail/313297.html">Create a CSR</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE REQUEST-----   ...... -----END CERTIFICATE REQUEST-----</para>
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        /// <summary>
        /// <para>The user-defined identifier, which serves as a unique key.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em><b>e6bb538d538c70c01f81hfd3</b></em>*</para>
        /// </summary>
        [NameInMap("CustomIdentifier")]
        [Validation(Required=false)]
        public string CustomIdentifier { get; set; }

        /// <summary>
        /// <para>The validity period of the server certificate. Unit: days.
        /// The <b>Days</b>, <b>BeforeTime</b>, and <b>AfterTime</b> parameters cannot all be empty. The <b>BeforeTime</b> and <b>AfterTime</b> parameters must both be empty or both be specified. The following rules apply:</para>
        /// <list type="bullet">
        /// <item><description><para>If you set the <b>Days</b> parameter, you can choose to set or not set the <b>BeforeTime</b> and <b>AfterTime</b> parameters.</para>
        /// </description></item>
        /// <item><description><para>If you do not set the <b>Days</b> parameter, you must set the <b>BeforeTime</b> and <b>AfterTime</b> parameters.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you set the <b>Days</b>, <b>BeforeTime</b>, and <b>AfterTime</b> parameters at the same time, the validity period of the server certificate is determined by the value of the <b>Days</b> parameter.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The validity period of the server certificate cannot exceed the validity period of the subordinate CA certificate. You can call <a href="https://help.aliyun.com/document_detail/465954.html">DescribeCACertificate</a> to query the validity period of the subordinate CA certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("Days")]
        [Validation(Required=false)]
        public int? Days { get; set; }

        /// <summary>
        /// <para>The extended domain name or extended IP address of the server certificate. After you add extended information to the certificate, you can apply the certificate to multiple domain names or IP addresses.</para>
        /// <para>You can enter multiple domain names and IP addresses at the same time. Separate multiple values with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the CRL address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: No. </para>
        /// </description></item>
        /// <item><description><para>1: Yes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableCrl")]
        [Validation(Required=false)]
        public long? EnableCrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately return the digital certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Does not return the certificate. This is the default value.</description></item>
        /// <item><description><b>1</b>: Returns the certificate.</description></item>
        /// <item><description><b>2</b>: Returns the certificate and its certificate chain.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Immediately")]
        [Validation(Required=false)]
        public int? Immediately { get; set; }

        /// <summary>
        /// <para>The name of the city where the certificate organization is located. Chinese characters, English characters, and other characters are supported.
        /// The default value is the name of the city where the organization of the subordinate CA certificate that issues this certificate is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hangzhou</para>
        /// </summary>
        [NameInMap("Locality")]
        [Validation(Required=false)]
        public string Locality { get; set; }

        /// <summary>
        /// <para>The certificate validity period. Unit: months.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Months")]
        [Validation(Required=false)]
        public int? Months { get; set; }

        /// <summary>
        /// <para>The organization name. Default value: Alibaba Inc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud</para>
        /// </summary>
        [NameInMap("Organization")]
        [Validation(Required=false)]
        public string Organization { get; set; }

        /// <summary>
        /// <para>The department name. Default value: Aliyun CDN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IT</para>
        /// </summary>
        [NameInMap("OrganizationUnit")]
        [Validation(Required=false)]
        public string OrganizationUnit { get; set; }

        /// <summary>
        /// <para>The unique identifier of the subordinate CA certificate that issues this certificate.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/465957.html">DescribeCACertificateList</a> to query the unique identifier of the subordinate CA certificate.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>270oe6bb538d538c70c01f81hfd3****</para>
        /// </summary>
        [NameInMap("ParentIdentifier")]
        [Validation(Required=false)]
        public string ParentIdentifier { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek****wia</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The name of the province, municipality, or autonomous region where the certificate organization is located. Chinese characters, English characters, and other characters are supported. The default value is the name of the province, municipality, or autonomous region where the organization of the subordinate CA certificate that issues this certificate is located.
        /// &lt;props=&quot;intl&quot;&gt;The name of the province or state where the certificate organization is located. Chinese characters, English characters, and other characters are supported. The default value is the name of the province or state where the organization of the subordinate CA certificate that issues this certificate is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhejiang</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The tag list.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateServerCertificateWithCsrRequestTags> Tags { get; set; }
        public class CreateServerCertificateWithCsrRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>account</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The certificate validity period. Unit: years.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Years")]
        [Validation(Required=false)]
        public int? Years { get; set; }

    }

}

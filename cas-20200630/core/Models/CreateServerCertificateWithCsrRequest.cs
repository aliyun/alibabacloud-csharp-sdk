// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateServerCertificateWithCsrRequest : TeaModel {
        /// <summary>
        /// <para>Expiration time of the server-side certificate, in UNIX timestamp format. Unit: seconds.</para>
        /// <remarks>
        /// <para>The <b>BeforeTime</b> and <b>AfterTime</b> parameters must both be empty or both configured.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1665819958</para>
        /// </summary>
        [NameInMap("AfterTime")]
        [Validation(Required=false)]
        public long? AfterTime { get; set; }

        /// <summary>
        /// <para>Key algorithm for the server-side certificate. Use the format <c>&lt;encryption algorithm&gt;_&lt;key length&gt;</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RSA_1024</b>: Signature algorithm is Sha256WithRSA.</para>
        /// </description></item>
        /// <item><description><para><b>RSA_2048</b>: Signature algorithm is Sha256WithRSA.</para>
        /// </description></item>
        /// <item><description><para><b>RSA_4096</b>: Signature algorithm is Sha256WithRSA.</para>
        /// </description></item>
        /// <item><description><para><b>ECC_256</b>: Signature algorithm is Sha256WithECDSA.</para>
        /// </description></item>
        /// <item><description><para><b>ECC_384</b>: Signature algorithm is Sha256WithECDSA.</para>
        /// </description></item>
        /// <item><description><para><b>ECC_512</b>: Signature algorithm is Sha256WithECDSA.</para>
        /// </description></item>
        /// <item><description><para><b>SM2_256</b>: Signature algorithm is SM3WithSM2.</para>
        /// </description></item>
        /// </list>
        /// <para>The encryption algorithm of the server-side certificate must match that of the sub-CA certificate. The key length can differ. For example, if the sub-CA certificate uses RSA_2048, the server-side certificate must use RSA_1024, RSA_2048, or RSA_4096.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/465954.html">DescribeCACertificate</a> to check the key algorithm of the sub-CA certificate.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_2048</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>Issue time of the server-side certificate, in UNIX timestamp format. Default: current time when you call this API. Unit: seconds.</para>
        /// <remarks>
        /// <para>The <b>BeforeTime</b> and <b>AfterTime</b> parameters must both be empty or both configured.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1634283958</para>
        /// </summary>
        [NameInMap("BeforeTime")]
        [Validation(Required=false)]
        public long? BeforeTime { get; set; }

        /// <summary>
        /// <para>Set the common name for the certificate. Supports Chinese, English, and other characters.</para>
        /// <remarks>
        /// <para>If you set the <b>Csr</b> parameter, the value of <b>CommonName</b> comes from the corresponding field in the <b>Csr</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mtcsq.com</para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The country code. For example, CN or US.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <para>You can generate a CSR using OpenSSL or Keytool. For more information, see <a href="https://help.aliyun.com/document_detail/42218.html">How to create a CSR file</a>.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>You can also create a CSR in the SSL Certificate console. For more information, see <a href="https://help.aliyun.com/document_detail/313297.html">Create a CSR</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE REQUEST-----   ...... -----END CERTIFICATE REQUEST-----</para>
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        /// <summary>
        /// <para>A custom identifier. This is a unique key.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em><b>e6bb538d538c70c01f81hfd3</b></em>*</para>
        /// </summary>
        [NameInMap("CustomIdentifier")]
        [Validation(Required=false)]
        public string CustomIdentifier { get; set; }

        /// <summary>
        /// <para>The <b>Days</b>, <b>BeforeTime</b>, and <b>AfterTime</b> parameters cannot all be empty. The <b>BeforeTime</b> and <b>AfterTime</b> parameters must both be empty or both set. Follow these rules:</para>
        /// <list type="bullet">
        /// <item><description><para>If you set <b>Days</b>, you can optionally set <b>BeforeTime</b> and <b>AfterTime</b>.</para>
        /// </description></item>
        /// <item><description><para>If you do not set <b>Days</b>, you must set both <b>BeforeTime</b> and <b>AfterTime</b>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you set <b>Days</b>, <b>BeforeTime</b>, and <b>AfterTime</b> together, the validity period uses the value of <b>Days</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The server-side certificate validity period cannot exceed that of the sub-CA certificate. Call <a href="https://help.aliyun.com/document_detail/465954.html">DescribeCACertificate</a> to check the sub-CA certificate validity period.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("Days")]
        [Validation(Required=false)]
        public int? Days { get; set; }

        /// <summary>
        /// <para>Additional domain names or IP addresses for the server-side certificate. Adding this information lets you apply the certificate to multiple domains or IP addresses.</para>
        /// <para>You can enter multiple domain names and IP addresses. Separate them with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the certificate revocation list (CRL) address.</para>
        /// <para>0 - No</para>
        /// <para>1 - Yes</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableCrl")]
        [Validation(Required=false)]
        public long? EnableCrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the digital certificate immediately.</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Do not return. Default.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Return the certificate.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Return the certificate and its certificate chain.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Immediately")]
        [Validation(Required=false)]
        public int? Immediately { get; set; }

        /// <summary>
        /// <para>The city where the organization for the certificate is located. The name can contain both Chinese and English characters. By default, this parameter is set to the city of the organization for the issuing subordinate Certificate Authority (CA).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hangzhou</para>
        /// </summary>
        [NameInMap("Locality")]
        [Validation(Required=false)]
        public string Locality { get; set; }

        /// <summary>
        /// <para>The validity period of the certificate, in months.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Months")]
        [Validation(Required=false)]
        public int? Months { get; set; }

        /// <summary>
        /// <para>The name of the organization. Default value: Alibaba Inc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云</para>
        /// </summary>
        [NameInMap("Organization")]
        [Validation(Required=false)]
        public string Organization { get; set; }

        /// <summary>
        /// <para>The name of the department. Default value: Alibaba Cloud CDN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IT</para>
        /// </summary>
        [NameInMap("OrganizationUnit")]
        [Validation(Required=false)]
        public string OrganizationUnit { get; set; }

        /// <summary>
        /// <para>Unique identifier of the sub-CA certificate that issues this certificate.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/465957.html">DescribeCACertificateList</a> to query the unique identifier of the sub-CA certificate.</para>
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
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek****wia</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;Set the name of the province, municipality, or autonomous region where the organization is located. Supports Chinese, English, and other characters. Defaults to the province, municipality, or autonomous region of the issuing sub-CA certificate\&quot;s organization.
        /// &lt;props=&quot;intl&quot;&gt;Set the name of the state or province where the organization is located. Supports Chinese, English, and other characters. Defaults to the state or province of the issuing sub-CA certificate\&quot;s organization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhejiang</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>A list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateServerCertificateWithCsrRequestTags> Tags { get; set; }
        public class CreateServerCertificateWithCsrRequestTags : TeaModel {
            /// <summary>
            /// <para>Tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>account</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The validity period of the certificate, in years.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Years")]
        [Validation(Required=false)]
        public int? Years { get; set; }

    }

}

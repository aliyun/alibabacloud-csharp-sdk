// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateClientCertificateWithCsrRequest : TeaModel {
        /// <summary>
        /// <para>The expiration time of the client certificate. This is a UNIX timestamp in seconds.</para>
        /// <remarks>
        /// <para>Specify the <b>BeforeTime</b> and <b>AfterTime</b> parameters together, or omit both.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1665819958</para>
        /// </summary>
        [NameInMap("AfterTime")]
        [Validation(Required=false)]
        public long? AfterTime { get; set; }

        /// <summary>
        /// <para>The key algorithm of the client certificate. The key algorithm is in the <c>&lt;Encryption algorithm&gt;_&lt;Key length&gt;</c> format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RSA_1024</b>: The corresponding signature algorithm is Sha256WithRSA.</para>
        /// </description></item>
        /// <item><description><para><b>RSA_2048</b>: The corresponding signature algorithm is Sha256WithRSA.</para>
        /// </description></item>
        /// <item><description><para><b>RSA_4096</b>: The corresponding signature algorithm is Sha256WithRSA.</para>
        /// </description></item>
        /// <item><description><para><b>ECC_256</b>: The corresponding signature algorithm is Sha256WithECDSA.</para>
        /// </description></item>
        /// <item><description><para><b>ECC_384</b>: The corresponding signature algorithm is Sha256WithECDSA.</para>
        /// </description></item>
        /// <item><description><para><b>ECC_512</b>: The corresponding signature algorithm is Sha256WithECDSA.</para>
        /// </description></item>
        /// <item><description><para><b>SM2_256</b>: The corresponding signature algorithm is SM3WithSM2.</para>
        /// </description></item>
        /// </list>
        /// <para>The encryption algorithm of the client certificate must be the same as that of the subordinate CA certificate, but the key length can be different. For example, if the key algorithm of the subordinate CA certificate is RSA_2048, the key algorithm of the client certificate must be one of RSA_1024, RSA_2048, and RSA_4096.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/465954.html">DescribeCACertificate</a> to query the key algorithm of the subordinate CA certificate.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_2048</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The issuance time of the client certificate. This is a UNIX timestamp in seconds. The default value is the time of the API call.</para>
        /// <remarks>
        /// <para>The <b>BeforeTime</b> and <b>AfterTime</b> parameters must be specified together or left empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1634283958</para>
        /// </summary>
        [NameInMap("BeforeTime")]
        [Validation(Required=false)]
        public long? BeforeTime { get; set; }

        /// <summary>
        /// <para>The common name of the certificate. Chinese and English characters are supported.</para>
        /// <remarks>
        /// <para>If you specify the <b>Csr</b> parameter, the value of this parameter is determined by the information in the <b>Csr</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aliyundoc.com</para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The country code, for example, <b>CN</b> or <b>US</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <para>The content of the CSR. Use OpenSSL or Keytool to generate a CSR. For more information, see <a href="https://help.aliyun.com/document_detail/42218.html">Create a CSR file</a>.</para>
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
        /// <para><em><b>e6bb538d538c70c01f81fg3</b></em>*</para>
        /// </summary>
        [NameInMap("CustomIdentifier")]
        [Validation(Required=false)]
        public string CustomIdentifier { get; set; }

        /// <summary>
        /// <para>The validity period of the client certificate, in days. You must specify the validity period using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description><para>Specify the <b>Days</b> parameter.</para>
        /// </description></item>
        /// <item><description><para>Specify both the <b>BeforeTime</b> and <b>AfterTime</b> parameters.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify <b>Days</b>, <b>BeforeTime</b>, and <b>AfterTime</b> at the same time, the value of <b>Days</b> is used.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The validity period of the client certificate cannot exceed that of the subordinate CA certificate. Call <a href="https://help.aliyun.com/document_detail/465954.html">DescribeCACertificate</a> to view the validity period of the subordinate CA certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("Days")]
        [Validation(Required=false)]
        public int? Days { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the Certificate Revocation List (CRL) address.</para>
        /// <para>0: No</para>
        /// <para>1: Yes</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableCrl")]
        [Validation(Required=false)]
        public long? EnableCrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the digital certificate.</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Do not return the certificate. This is the default value.</para>
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
        /// <para>The name of the city where the organization is located. Chinese and English characters are supported. By default, this parameter uses the city name of the organization that is associated with the issuing subordinate CA certificate.</para>
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
        /// <para>Alibaba Inc</para>
        /// </summary>
        [NameInMap("Organization")]
        [Validation(Required=false)]
        public string Organization { get; set; }

        /// <summary>
        /// <para>The name of the department. Default value: Alibaba Cloud CDN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Security</para>
        /// </summary>
        [NameInMap("OrganizationUnit")]
        [Validation(Required=false)]
        public string OrganizationUnit { get; set; }

        /// <summary>
        /// <para>The unique identifier of the subordinate CA certificate that issues the client certificate.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/465957.html">DescribeCACertificateList</a> to query the unique identifiers of subordinate CA certificates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>270ae6bb538d538c70c01f81fg3****</para>
        /// </summary>
        [NameInMap("ParentIdentifier")]
        [Validation(Required=false)]
        public string ParentIdentifier { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the certificate belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ae******4wia</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of the Subject Alternative Name (SAN) extension for the client certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Email address.</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: Uniform Resource Identifier (URI).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SanType")]
        [Validation(Required=false)]
        public int? SanType { get; set; }

        /// <summary>
        /// <para>The extension for the client certificate. To specify multiple extensions, separate them with a comma.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:somebody@example.com">somebody@example.com</a></para>
        /// </summary>
        [NameInMap("SanValue")]
        [Validation(Required=false)]
        public string SanValue { get; set; }

        /// <summary>
        /// <para>Specify the name of the province or state where the certificate organization is located. The value can contain letters. The default value is the name of the province or state of the intermediate CA\&quot;s organization.</para>
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
        public List<CreateClientCertificateWithCsrRequestTags> Tags { get; set; }
        public class CreateClientCertificateWithCsrRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>database</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
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

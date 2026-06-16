// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateServerCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The expiration time of the server certificate. This value is a UNIX timestamp in seconds.</para>
        /// <remarks>
        /// <para>The <b>BeforeTime</b> and <b>AfterTime</b> parameters must be specified together or left empty together.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1665819958</para>
        /// </summary>
        [NameInMap("AfterTime")]
        [Validation(Required=false)]
        public long? AfterTime { get; set; }

        /// <summary>
        /// <para>The key algorithm of the server certificate. The algorithm is in the <c>&lt;encryption algorithm&gt;_&lt;key length&gt;</c> format. Valid values:</para>
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
        /// <para>The encryption algorithm of the server certificate must be the same as the encryption algorithm of the subordinate CA certificate, but the key length can be different. For example, if the key algorithm of the subordinate CA certificate is RSA_2048, the key algorithm of the server certificate must be RSA_1024, RSA_2048, or RSA_4096.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/465954.html">DescribeCACertificate</a> to query the key algorithm of the subordinate CA certificate.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_2048</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The issuance time of the server certificate. This value is a UNIX timestamp in seconds. The default value is the time when you call this operation.</para>
        /// <remarks>
        /// <para>The <b>BeforeTime</b> and <b>AfterTime</b> parameters must be specified together or left empty together.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1634283958</para>
        /// </summary>
        [NameInMap("BeforeTime")]
        [Validation(Required=false)]
        public long? BeforeTime { get; set; }

        /// <summary>
        /// <para>The name of the certificate user. For a server authentication (ServerAuth) certificate, the user is the server. Enter the domain name or IP address that is bound to the server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The country code, such as CN or US.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <para>A custom identifier. This key must be unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>6bb538d538c70c01f81dg3</b></b></para>
        /// </summary>
        [NameInMap("CustomIdentifier")]
        [Validation(Required=false)]
        public string CustomIdentifier { get; set; }

        /// <summary>
        /// <para>The validity period of the server certificate, in days. The <b>Days</b>, <b>BeforeTime</b>, and <b>AfterTime</b> parameters cannot all be empty. The <b>BeforeTime</b> and <b>AfterTime</b> parameters must be specified together or left empty together. The following rules describe how to set these parameters:</para>
        /// <list type="bullet">
        /// <item><description><para>If you specify <b>Days</b>, the <b>BeforeTime</b> and <b>AfterTime</b> parameters are optional.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify <b>Days</b>, you must specify both <b>BeforeTime</b> and <b>AfterTime</b>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify <b>Days</b>, <b>BeforeTime</b>, and <b>AfterTime</b> at the same time, the value of <b>Days</b> determines the validity period of the server certificate.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The validity period of the server certificate cannot exceed the validity period of the subordinate CA certificate. You can call <a href="https://help.aliyun.com/document_detail/465954.html">DescribeCACertificate</a> to view the validity period of the subordinate CA certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("Days")]
        [Validation(Required=false)]
        public int? Days { get; set; }

        /// <summary>
        /// <para>The additional domain names and IP addresses for the server certificate. This information lets you apply the certificate to multiple domain names and IP addresses.</para>
        /// <para>Separate multiple domain names or IP addresses with a comma (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

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
        /// <para>Specifies whether to return the digital certificate immediately.</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: No. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Returns the certificate.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Returns the certificate and its certificate chain.</para>
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
        /// <para>The city where the organization is located. Chinese and English characters are supported. The default value is the city of the organization that is associated with the subordinate CA certificate that issues this certificate.</para>
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
        /// <para>The name of the organization. The default value is Alibaba Inc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云</para>
        /// </summary>
        [NameInMap("Organization")]
        [Validation(Required=false)]
        public string Organization { get; set; }

        /// <summary>
        /// <para>The name of the department. The default value is Alibaba Cloud CDN.</para>
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
        /// <para>Call <a href="https://help.aliyun.com/document_detail/465957.html">DescribeCACertificateList</a> to query the unique identifier of the subordinate CA certificate.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>271ae6bb538d538c70c01f81dg3****</para>
        /// </summary>
        [NameInMap("ParentIdentifier")]
        [Validation(Required=false)]
        public string ParentIdentifier { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. Call the <a href="https://help.aliyun.com/document_detail/2716559.html">ListResources</a> operation to get this ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The province or state where the organization is located. Chinese and English characters are supported. The default value is the province or state of the organization that is associated with the subordinate CA certificate that issues this certificate.</para>
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
        public List<CreateServerCertificateRequestTags> Tags { get; set; }
        public class CreateServerCertificateRequestTags : TeaModel {
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

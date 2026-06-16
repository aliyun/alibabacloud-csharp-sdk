// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateClientCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The expiration time of the client certificate in UNIX timestamp format. The unit is seconds.</para>
        /// <remarks>
        /// <para><b>BeforeTime</b> and <b>AfterTime</b> must be specified together or left empty together.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1665819958</para>
        /// </summary>
        [NameInMap("AfterTime")]
        [Validation(Required=false)]
        public long? AfterTime { get; set; }

        /// <summary>
        /// <para>The key algorithm for the client certificate. The format is <c>&lt;encryption algorithm&gt;_&lt;key length&gt;</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RSA_1024</b>: The signature algorithm is Sha256WithRSA.</para>
        /// </description></item>
        /// <item><description><para><b>RSA_2048</b>: The signature algorithm is Sha256WithRSA.</para>
        /// </description></item>
        /// <item><description><para><b>RSA_4096</b>: The signature algorithm is Sha256WithRSA.</para>
        /// </description></item>
        /// <item><description><para><b>ECC_256</b>: The signature algorithm is Sha256WithECDSA.</para>
        /// </description></item>
        /// <item><description><para><b>ECC_384</b>: The signature algorithm is Sha256WithECDSA.</para>
        /// </description></item>
        /// <item><description><para><b>ECC_512</b>: The signature algorithm is Sha256WithECDSA.</para>
        /// </description></item>
        /// <item><description><para><b>SM2_256</b>: The signature algorithm is SM3WithSM2.</para>
        /// </description></item>
        /// </list>
        /// <para>The encryption algorithm of the client certificate must be the same as the subordinate CA certificate. The key length can be different. For example, if the subordinate CA certificate uses the RSA_2048 key algorithm, the client certificate must use RSA_1024, RSA_2048, or RSA_4096.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/465954.html">DescribeCACertificate</a> to find the key algorithm of the subordinate CA certificate.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_2048</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>Set the name of the issued certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cert-name</para>
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// <para>The issuance time of the client certificate in UNIX timestamp format. The unit is seconds. The default value is the time when you call this operation.</para>
        /// <remarks>
        /// <para><b>BeforeTime</b> and <b>AfterTime</b> must be specified together or left empty together.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1634283958</para>
        /// </summary>
        [NameInMap("BeforeTime")]
        [Validation(Required=false)]
        public long? BeforeTime { get; set; }

        /// <summary>
        /// <para>Used to ensure request idempotence. The client generates this parameter value, which must be unique across different requests. It can contain a maximum of 64 ASCII characters and must not include any non-ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the certificate user. For a client authentication (ClientAuth) certificate, the user is typically an individual, a company, an organization, or an application. Specify the common name of the user, such as John Doe, Alibaba, Alibaba Cloud Cryptography Platform, or Tmall Genie.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The country code. Default: CN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <para>A custom identifier. This is a unique key.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>6bb538d538c70c01f81jh2</b></b></para>
        /// </summary>
        [NameInMap("CustomIdentifier")]
        [Validation(Required=false)]
        public string CustomIdentifier { get; set; }

        /// <summary>
        /// <para>The validity period of the client certificate in days. The <b>Days</b>, <b>BeforeTime</b>, or <b>AfterTime</b> parameters cannot all be empty. The <b>BeforeTime</b> and <b>AfterTime</b> parameters must be set together or left empty. The parameters are configured as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>If you set the <b>Days</b> parameter, the <b>BeforeTime</b> and <b>AfterTime</b> parameters are optional.</para>
        /// </description></item>
        /// <item><description><para>If you do not set the <b>Days</b> parameter, you must set both the <b>BeforeTime</b> and <b>AfterTime</b> parameters.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you set the <b>Days</b>, <b>BeforeTime</b>, and <b>AfterTime</b> parameters, the value of the <b>Days</b> parameter takes precedence.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The validity period of the client certificate cannot exceed the validity period of the subordinate CA certificate. To view the validity period of the subordinate CA certificate, you can call <a href="https://help.aliyun.com/document_detail/465954.html">DescribeCACertificate</a>.</description></item>
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
        /// <para>Valid values: 0 (No) and 1 (Yes).</para>
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
        /// <item><description><para><b>1</b>: Yes, return the certificate.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Yes, return the certificate and its certificate chain.</para>
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
        /// <para>The name of the city where the organization is located. The default value is the city of the subordinate CA that issues the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州市</para>
        /// </summary>
        [NameInMap("Locality")]
        [Validation(Required=false)]
        public string Locality { get; set; }

        /// <summary>
        /// <para>The validity period of the certificate in months.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Months")]
        [Validation(Required=false)]
        public int? Months { get; set; }

        /// <summary>
        /// <para>The name of the organization. Default: Alibaba Inc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云</para>
        /// </summary>
        [NameInMap("Organization")]
        [Validation(Required=false)]
        public string Organization { get; set; }

        /// <summary>
        /// <para>The name of the department. Default: Alibaba Cloud CDN.</para>
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
        /// <para>Call DescribeCACertificateList to query the unique identifier of the subordinate CA certificate.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>273ae6bb538d538c70c01f81jh2****</para>
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
        /// <para>The type of Subject Alternative Name (SAN) extension for the client certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Email</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: Uniform Resource Identifier (URI)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SanType")]
        [Validation(Required=false)]
        public int? SanType { get; set; }

        /// <summary>
        /// <para>The extension information for the client certificate. To enter multiple extensions, separate them with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:somebody@example.com">somebody@example.com</a></para>
        /// </summary>
        [NameInMap("SanValue")]
        [Validation(Required=false)]
        public string SanValue { get; set; }

        /// <summary>
        /// <para>Specify the province or state of the certificate organization. The value can contain letters. The default value is the province or state of the organization for the intermediate CA that issued the certificate.</para>
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
        public List<CreateClientCertificateRequestTags> Tags { get; set; }
        public class CreateClientCertificateRequestTags : TeaModel {
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
            /// <para>1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The validity period of the certificate in years.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Years")]
        [Validation(Required=false)]
        public int? Years { get; set; }

    }

}

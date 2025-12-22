// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateClientCertificateWithCsrRequest : TeaModel {
        /// <summary>
        /// <para>The expiration time of the client certificate. This value is a UNIX timestamp. Unit: seconds.</para>
        /// <remarks>
        /// <para> The <b>BeforeTime</b> and <b>AfterTime</b> parameters must be both empty or both specified.</para>
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
        /// <item><description><b>RSA_1024</b>: The signature algorithm is Sha256WithRSA.</description></item>
        /// <item><description><b>RSA_2048</b>: The signature algorithm is Sha256WithRSA.</description></item>
        /// <item><description><b>RSA_4096</b>: The signature algorithm is Sha256WithRSA.</description></item>
        /// <item><description><b>ECC_256</b>: The signature algorithm is Sha256WithECDSA.</description></item>
        /// <item><description><b>ECC_384</b>: The signature algorithm is Sha256WithECDSA.</description></item>
        /// <item><description><b>ECC_512</b>: The signature algorithm is Sha256WithECDSA.</description></item>
        /// <item><description><b>SM2_256</b>: The signature algorithm is SM3WithSM2.</description></item>
        /// </list>
        /// <para>The encryption algorithm of the client certificate must be the same with the encryption algorithm of the intermediate CA certificate. The key length can be different. For example, if the key algorithm of the intermediate CA certificate is RSA_2048, the key algorithm of the client certificate must be RSA_1024, RSA_2048, or RSA_4096.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/328096.html">DescribeCACertificate</a> operation to query the key algorithm of an intermediate CA certificate.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_2048</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The issuance time of the client certificate. This value is a UNIX timestamp. The default value is the time when you call this operation. Unit: seconds.</para>
        /// <remarks>
        /// <para> The <b>BeforeTime</b> and <b>AfterTime</b> parameters must be both empty or both specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1634283958</para>
        /// </summary>
        [NameInMap("BeforeTime")]
        [Validation(Required=false)]
        public long? BeforeTime { get; set; }

        /// <summary>
        /// <para>The common name of the certificate. The value can contain letters.</para>
        /// <remarks>
        /// <para> If you specify the <b>CsrPemString</b> parameter, the value of the <b>CommonName</b> parameter is determined by the <b>CsrPemString</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aliyundoc.com</para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The code of the country in which the organization is located, such as <b>CN</b> and <b>US</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <para>The content of the CSR file. You can generate a CSR file by using the OpenSSL tool or Keytool. For more information, see <a href="https://help.aliyun.com/document_detail/42218.html">How do I create a CSR file?</a> You can also create a CSR file in the Certificate Management Service console. For more information, see <a href="https://help.aliyun.com/document_detail/313297.html">Create a CSR</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE REQUEST-----   ...... -----END CERTIFICATE REQUEST-----</para>
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        [NameInMap("CustomIdentifier")]
        [Validation(Required=false)]
        public string CustomIdentifier { get; set; }

        /// <summary>
        /// <para>The validity period of the client certificate. Unit: days. You must specify at least one of the <b>Days</b>, <b>BeforeTime</b>, and <b>AfterTime</b> parameters. The <b>BeforeTime</b> and <b>AfterTime</b> parameters must be both empty or both specified. The following list describes how to specify these parameters:</para>
        /// <list type="bullet">
        /// <item><description>If you specify the <b>Days</b> parameter, you can specify both the <b>BeforeTime</b> and <b>AfterTime</b> parameters or leave them both empty.********</description></item>
        /// <item><description>If you do not specify the <b>Days</b> parameter, you must specify both the <b>BeforeTime</b> and <b>AfterTime</b> parameters.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you specify the <b>Days</b>, <b>BeforeTime</b>, and <b>AfterTime</b> parameters together, the validity period of the client certificate is determined by the value of the <b>Days</b> parameter.</para>
        /// </description></item>
        /// <item><description><para>The validity period of the client certificate cannot exceed the validity period of the intermediate CA certificate. You can call the <a href="https://help.aliyun.com/document_detail/328096.html">DescribeCACertificate</a> operation to query the validity period of an intermediate CA certificate.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("Days")]
        [Validation(Required=false)]
        public int? Days { get; set; }

        /// <summary>
        /// <para>include the CRL address.</para>
        /// <list type="bullet">
        /// <item><description>0- No</description></item>
        /// <item><description>1- Yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableCrl")]
        [Validation(Required=false)]
        public long? EnableCrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: does not return the certificate. This is the default value.</description></item>
        /// <item><description><b>1</b>: returns the certificate.</description></item>
        /// <item><description><b>2</b>: returns the certificate and the certificate chain of the certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Immediately")]
        [Validation(Required=false)]
        public int? Immediately { get; set; }

        /// <summary>
        /// <para>The name of the city in which the organization is located. The value can contain letters. The default value is the name of the city in which the organization is located. The organization is associated with the intermediate CA certificate from which the certificate is issued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hangzhou</para>
        /// </summary>
        [NameInMap("Locality")]
        [Validation(Required=false)]
        public string Locality { get; set; }

        /// <summary>
        /// <para>The validity period of the client certificate. Unit: months.</para>
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
        /// <para>Alibaba Cloud Computing Co., Ltd.</para>
        /// </summary>
        [NameInMap("Organization")]
        [Validation(Required=false)]
        public string Organization { get; set; }

        /// <summary>
        /// <para>The name of the department. Default value: Aliyun CDN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Security</para>
        /// </summary>
        [NameInMap("OrganizationUnit")]
        [Validation(Required=false)]
        public string OrganizationUnit { get; set; }

        /// <summary>
        /// <para>The unique identifier of the intermediate CA certificate from which the client certificate is issued.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/328095.html">DescribeCACertificateList</a> operation to query the unique identifier of an intermediate CA certificate.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>270ae6bb538d538c70c01f81fg3****</para>
        /// </summary>
        [NameInMap("ParentIdentifier")]
        [Validation(Required=false)]
        public string ParentIdentifier { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of the Subject Alternative Name (SAN) extension that is supported by the client certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: an email address</description></item>
        /// <item><description><b>6</b>: a Uniform Resource Identifier (URI)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SanType")]
        [Validation(Required=false)]
        public int? SanType { get; set; }

        /// <summary>
        /// <para>The content of the extension. You can specify multiple SAN extensions. If you want to specify multiple SAN extensions, separate them with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:somebody@example.com">somebody@example.com</a></para>
        /// </summary>
        [NameInMap("SanValue")]
        [Validation(Required=false)]
        public string SanValue { get; set; }

        /// <summary>
        /// <para>The province, municipality, or autonomous region in which the organization is located. The value can contain letters. The default value is the name of the province, municipality, or autonomous region in which the organization is located. The organization is associated with the intermediate CA certificate from which the certificate is issued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhejiang</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateClientCertificateWithCsrRequestTags> Tags { get; set; }
        public class CreateClientCertificateWithCsrRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The validity period of the client certificate. Unit: years.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Years")]
        [Validation(Required=false)]
        public int? Years { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateClientCertificateRequest : TeaModel {
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
        /// <para>The encryption algorithm of the client certificate must be the same with the encryption algorithm of the intermediate certificate authority (CA) certificate. The key length can be different. For example, if the key algorithm of the intermediate CA certificate is RSA_2048, the key algorithm of the client certificate must be RSA_1024, RSA_2048, or RSA_4096.</para>
        /// <remarks>
        /// <para>You can call the [DescribeCACertificate] operation to query the key algorithm of an intermediate CA certificate.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_2048</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

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

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the client certificate user. In most cases, the user of a client certificate is an individual, a company, an organization, or an application. We recommend that you enter the common name of a user. Examples: Bob, Alibaba, Alibaba Cloud password platform, and Tmall Genie.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The country in which the organization is located. Default value: CN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        [NameInMap("CustomIdentifier")]
        [Validation(Required=false)]
        public string CustomIdentifier { get; set; }

        /// <summary>
        /// <para>The validity period of the client certificate. Unit: day. You must specify at least one of the <b>Days</b>, <b>BeforeTime</b>, and <b>AfterTime</b> parameters. The <b>BeforeTime</b> and <b>AfterTime</b> parameters must be both empty or both specified. The following list describes how to specify these parameters:</para>
        /// <list type="bullet">
        /// <item><description>If you specify the <b>Days</b> parameter, you can specify both the <b>BeforeTime</b> and <b>AfterTime</b> parameters or leave them both empty.</description></item>
        /// <item><description>If you do not specify the <b>Days</b> parameter, you must specify both the <b>BeforeTime</b> and <b>AfterTime</b> parameters.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you specify the <b>Days</b>, <b>BeforeTime</b>, and <b>AfterTime</b> parameters at the same time, the validity period of the client certificate is determined by the value of the <b>Days</b> parameter.</para>
        /// </description></item>
        /// <item><description><para>The validity period of the client certificate cannot exceed the validity period of the intermediate CA certificate. You can call the <a href="https://help.aliyun.com/document_detail/465954.html">DescribeCACertificate</a> operation to query the validity period of an intermediate CA certificate.</para>
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("Months")]
        [Validation(Required=false)]
        public int? Months { get; set; }

        /// <summary>
        /// <para>The name of the organization. Default value: Alibaba Inc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud</para>
        /// </summary>
        [NameInMap("Organization")]
        [Validation(Required=false)]
        public string Organization { get; set; }

        /// <summary>
        /// <para>The name of the department. Default value: Aliyun CDN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IT</para>
        /// </summary>
        [NameInMap("OrganizationUnit")]
        [Validation(Required=false)]
        public string OrganizationUnit { get; set; }

        /// <summary>
        /// <para>The unique identifier of the intermediate CA certificate from which the server certificate is issued.</para>
        /// <remarks>
        /// <para>You can call the [DescribeCACertificateList] operation to query the unique identifier of an intermediate CA certificate.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>273ae6bb538d538c70c01f81jh2****</para>
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
        public List<CreateClientCertificateRequestTags> Tags { get; set; }
        public class CreateClientCertificateRequestTags : TeaModel {
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
        /// <para>5</para>
        /// </summary>
        [NameInMap("Years")]
        [Validation(Required=false)]
        public int? Years { get; set; }

    }

}

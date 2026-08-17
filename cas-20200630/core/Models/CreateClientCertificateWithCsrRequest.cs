// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateClientCertificateWithCsrRequest : TeaModel {
        /// <summary>
        /// <para>The expiration time of the client certificate in UNIX timestamp format. Unit: seconds.</para>
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
        /// <para>The key algorithm of the client certificate. The key algorithm is in the <c>&lt;encryption algorithm&gt;_&lt;key length&gt;</c> format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RSA_1024</b>: The signature algorithm is Sha256WithRSA.</description></item>
        /// <item><description><b>RSA_2048</b>: The signature algorithm is Sha256WithRSA.</description></item>
        /// <item><description><b>RSA_4096</b>: The signature algorithm is Sha256WithRSA.</description></item>
        /// <item><description><b>ECC_256</b>: The signature algorithm is Sha256WithECDSA.</description></item>
        /// <item><description><b>ECC_384</b>: The signature algorithm is Sha256WithECDSA.</description></item>
        /// <item><description><b>ECC_512</b>: The signature algorithm is Sha256WithECDSA.</description></item>
        /// <item><description><b>SM2_256</b>: The signature algorithm is SM3WithSM2.</description></item>
        /// </list>
        /// <para>The encryption algorithm of the client certificate must be the same as that of the sub-CA certificate, but the key length can be different. For example, if the key algorithm of the sub-CA certificate is RSA_2048, the key algorithm of the client certificate must be RSA_1024, RSA_2048, or RSA_4096.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/465954.html">DescribeCACertificate</a> to query the key algorithm of the sub-CA certificate.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_2048</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The asynchronous processing flag. If the value is &quot;true&quot;, the backend service issues the certificate asynchronously.
        /// After the request is submitted, you can call the ListClientCertificate operation to obtain the latest certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AsynchronousFlag")]
        [Validation(Required=false)]
        public bool? AsynchronousFlag { get; set; }

        /// <summary>
        /// <para>The issuance time of the client certificate in UNIX timestamp format. Default value: the time when you call this operation. Unit: seconds.</para>
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
        /// <para>If you set the <b>CsrPemString</b> parameter, the value of the <b>CommonName</b> parameter is determined by the corresponding information in the <b>CsrPemString</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aliyundoc.com</para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The country code. Example: <b>CN</b> or <b>US</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <para>The CSR content. You can use OpenSSL or Keytool to generate a CSR. For more information, see <a href="https://help.aliyun.com/document_detail/42218.html">How to create a CSR file</a>.
        /// &lt;props=&quot;china&quot;&gt;You can also create a CSR in the SSL Certificates Service console. For more information, see <a href="https://help.aliyun.com/document_detail/313297.html">Create a CSR</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE REQUEST-----   ...... -----END CERTIFICATE REQUEST-----</para>
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        /// <summary>
        /// <para>The custom identifier, which serves as a unique key.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em><b>e6bb538d538c70c01f81fg3</b></em>*</para>
        /// </summary>
        [NameInMap("CustomIdentifier")]
        [Validation(Required=false)]
        public string CustomIdentifier { get; set; }

        /// <summary>
        /// <para>The validity period of the client certificate. Unit: days.
        /// The <b>Days</b>, <b>BeforeTime</b>, and <b>AfterTime</b> parameters cannot all be empty. The <b>BeforeTime</b> and <b>AfterTime</b> parameters must both be empty or both be specified. The following rules apply:</para>
        /// <list type="bullet">
        /// <item><description>If you set the <b>Days</b> parameter, you can choose to set or not set the <b>BeforeTime</b> and <b>AfterTime</b> parameters.</description></item>
        /// <item><description>If you do not set the <b>Days</b> parameter, you must set the <b>BeforeTime</b> and <b>AfterTime</b> parameters.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you set the <b>Days</b>, <b>BeforeTime</b>, and <b>AfterTime</b> parameters at the same time, the validity period of the client certificate is determined by the value of the <b>Days</b> parameter.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The validity period of the client certificate cannot exceed the validity period of the sub-CA certificate. You can call <a href="https://help.aliyun.com/document_detail/465954.html">DescribeCACertificate</a> to view the validity period of the sub-CA certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("Days")]
        [Validation(Required=false)]
        public int? Days { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the Certificate Revocation List (CRL) address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: No.</description></item>
        /// <item><description>1: Yes.</description></item>
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
        /// <item><description><b>0</b>: does not return the certificate. This is the default value.</description></item>
        /// <item><description><b>1</b>: returns the certificate.</description></item>
        /// <item><description><b>2</b>: returns the certificate and its certificate chain.</description></item>
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
        /// Default value: the name of the city where the sub-CA certificate organization that issues this certificate is located.</para>
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
        /// <para>Alibaba Inc</para>
        /// </summary>
        [NameInMap("Organization")]
        [Validation(Required=false)]
        public string Organization { get; set; }

        /// <summary>
        /// <para>The organizational unit name. Default value: Aliyun CDN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Security</para>
        /// </summary>
        [NameInMap("OrganizationUnit")]
        [Validation(Required=false)]
        public string OrganizationUnit { get; set; }

        /// <summary>
        /// <para>The unique identifier of the sub-CA certificate that issues this certificate.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/465957.html">DescribeCACertificateList</a> to query the unique identifier of the sub-CA certificate.</para>
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
        /// <para>The type of the Subject Alternative Name (SAN) extension of the client certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: otherName (0): other name.</description></item>
        /// <item><description><b>1</b>: rfc822Name (1): RFC 822 name, which is typically an email address.</description></item>
        /// <item><description><b>2</b>: dNSName (2): DNS name (domain name).</description></item>
        /// <item><description><b>3</b>: x400Address (3): X.400 address, an early email standard address.</description></item>
        /// <item><description><b>4</b>: directoryName (4): directory name, which is typically an X.500 distinguished name (DN).</description></item>
        /// <item><description><b>5</b>: ediPartyName (5): Electronic Data Interchange (EDI) party name.</description></item>
        /// <item><description><b>6</b>: uniformResourceIdentifier (6): Uniform Resource Identifier (URI).</description></item>
        /// <item><description><b>7</b>: iPAddress (7): IP address.</description></item>
        /// <item><description><b>8</b>: registeredID (8): registered ID (object identifier OID).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SanType")]
        [Validation(Required=false)]
        public int? SanType { get; set; }

        /// <summary>
        /// <para>The specific SAN extension information of the client certificate. You can enter multiple values separated by commas (,).</para>
        /// <ol>
        /// <item><description>otherName (0): other name</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>Example: 1.3.6.1.4.1.311.20.2.3 (OID) + <a href="mailto:user@domain.com">user@domain.com</a> (UPN - User Principal Name)</description></item>
        /// <item><description>Description: A custom extension type that typically consists of a specific OID (object identifier) and a corresponding value. In Windows environments, it is commonly used to store UPN (User Principal Name), such as <a href="mailto:zhangsan@company.com">zhangsan@company.com</a> for smart card logon.</description></item>
        /// </list>
        /// <ol start="2">
        /// <item><description>rfc822Name (1): RFC 822 name (email address)</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>Example: <a href="mailto:admin@example.com">admin@example.com</a>,<a href="mailto:support@company.cn">support@company.cn</a></description></item>
        /// <item><description>Description: An Internet email address that complies with the RFC 822 standard. It is commonly used in S/MIME email signing and encryption certificates to identify the sender or recipient of an email.</description></item>
        /// <item><description>dNSName (2): DNS name (domain name)</description></item>
        /// <item><description>Example: <a href="http://www.example.com,api.test.cn,*.mydomain.com">www.example.com,api.test.cn,*.mydomain.com</a> (wildcard domain name)</description></item>
        /// <item><description>Description: The most commonly used type in HTTPS website SSL/TLS certificates. A certificate can contain multiple DNS names through the SAN extension, allowing a single certificate to protect multiple subdomains or completely different domain names.</description></item>
        /// </list>
        /// <ol start="3">
        /// <item><description>x400Address (3): X.400 address</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>Example: G=Zhang; S=San; O=Company; PRMD=IT; ADMD=Telecom; C=CN</description></item>
        /// <item><description>Description: An early email system address standard with a complex structure that includes attributes such as country (C), administration domain (ADMD), organization (O), surname (S), and given name (G). It is rarely used in modern Internet HTTPS certificates and is mostly found in traditional European government, enterprise, or military communication systems.</description></item>
        /// </list>
        /// <ol start="4">
        /// <item><description>directoryName (4): directory name</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>Example: CN=IT Department, OU=Tech, O=Company Ltd, L=Beijing, ST=Beijing, C=CN</description></item>
        /// <item><description>Description: A standard X.500 distinguished name (DN). It is typically used to explicitly identify the complete hierarchical information of an organization, department, or entity in a certificate. It is commonly found in enterprise internal root certificates or specific government digital certificates.</description></item>
        /// </list>
        /// <ol start="5">
        /// <item><description>ediPartyName (5): EDI party name</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>Example: nameAssigner=GlobalTradeOrg, partyName=SupplierA</description></item>
        /// <item><description>Description: Used specifically in the Electronic Data Interchange (EDI) domain. It identifies a specific party in business message exchanges (such as order and invoice transmissions) and typically includes the assigning organization (nameAssigner) and the party name (partyName).</description></item>
        /// </list>
        /// <ol start="6">
        /// <item><description>uniformResourceIdentifier (6): Uniform Resource Identifier (URI)</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>Example: <a href="http://www.example.com/verify,https://api.test.cn/status">http://www.example.com/verify,https://api.test.cn/status</a></description></item>
        /// <item><description>Description: A standard URL format that must include a protocol prefix (such as http:// or https://). It can point to a specific network resource address.</description></item>
        /// </list>
        /// <ol start="7">
        /// <item><description>iPAddress (7): IP address</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>Example: 192.168.1.100 (IPv4), 2001:0db8:85a3::8a2e:0370:7334 (IPv6)</description></item>
        /// <item><description>Description: Directly binds to a server IP address. It is commonly used for internal systems without domain names, API servers, or specific services that can only be accessed through a public IP address. Note: Public IP certificates typically require strict Organization Validation (OV).</description></item>
        /// </list>
        /// <ol start="8">
        /// <item><description>registeredID (8): registered ID (object identifier OID)</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>Example: 1.2.3.4.55.6.5.99, 2.5.29.17</description></item>
        /// <item><description>Description: A unique numeric identifier assigned by international standards organizations. It is rarely used directly as a subject name in certificates and is more commonly used as a unique identity code or policy identifier within systems.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:somebody@example.com">somebody@example.com</a></para>
        /// </summary>
        [NameInMap("SanValue")]
        [Validation(Required=false)]
        public string SanValue { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The name of the province, municipality, or autonomous region where the certificate organization is located. Chinese characters, English characters, and other characters are supported. Default value: the name of the province, municipality, or autonomous region where the sub-CA certificate organization that issues this certificate is located.
        /// &lt;props=&quot;intl&quot;&gt;The name of the province or state where the certificate organization is located. Chinese characters, English characters, and other characters are supported. Default value: the name of the province or state where the sub-CA certificate organization that issues this certificate is located.</para>
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

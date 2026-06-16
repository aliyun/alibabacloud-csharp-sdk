// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class ListClientCertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of details about the client or server-side certificates.</para>
        /// </summary>
        [NameInMap("CertificateList")]
        [Validation(Required=false)]
        public List<ListClientCertificateResponseBodyCertificateList> CertificateList { get; set; }
        public class ListClientCertificateResponseBodyCertificateList : TeaModel {
            /// <summary>
            /// <para>The expiration date of the certificate. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665819958000</para>
            /// </summary>
            [NameInMap("AfterDate")]
            [Validation(Required=false)]
            public long? AfterDate { get; set; }

            /// <summary>
            /// <para>The type of the encryption algorithm of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>RSA</b>: RSA algorithm.</para>
            /// </description></item>
            /// <item><description><para><b>ECC</b>: ECC algorithm.</para>
            /// </description></item>
            /// <item><description><para><b>SM2</b>: SM2 algorithm.</para>
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
            /// <para>The name of the issued certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>生产培训10.153.13.177</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>The issuance date of the certificate. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1634283958000</para>
            /// </summary>
            [NameInMap("BeforeDate")]
            [Validation(Required=false)]
            public long? BeforeDate { get; set; }

            /// <summary>
            /// <para>The type of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>CLIENT</b>: a client certificate.</para>
            /// </description></item>
            /// <item><description><para><b>SERVER</b>: a server-side certificate.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SERVER</para>
            /// </summary>
            [NameInMap("CertificateType")]
            [Validation(Required=false)]
            public string CertificateType { get; set; }

            /// <summary>
            /// <para>The common name of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyundoc.com</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The country code of the country where the organization associated with the issuing subordinate CA certificate is located.</para>
            /// <para>For more information about country codes, see the <b>Country codes</b> section of <a href="https://help.aliyun.com/document_detail/198289.html">Manage company information</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("CountryCode")]
            [Validation(Required=false)]
            public string CountryCode { get; set; }

            /// <summary>
            /// <para>The custom identifier, which is a unique key.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>48d8d3ecc9976d9ecd2b2f25</b></b></para>
            /// </summary>
            [NameInMap("CustomIdentifier")]
            [Validation(Required=false)]
            public string CustomIdentifier { get; set; }

            /// <summary>
            /// <para>The validity period of the certificate. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>365</para>
            /// </summary>
            [NameInMap("Days")]
            [Validation(Required=false)]
            public int? Days { get; set; }

            /// <summary>
            /// <para>The primary key ID of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12321</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The unique identifier of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d3b95700998e47afc4d95f886579****</para>
            /// </summary>
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <para>The key length of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4096</para>
            /// </summary>
            [NameInMap("KeySize")]
            [Validation(Required=false)]
            public int? KeySize { get; set; }

            /// <summary>
            /// <para>The city where the organization associated with the issuing subordinate CA certificate is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hangzhou</para>
            /// </summary>
            [NameInMap("Locality")]
            [Validation(Required=false)]
            public string Locality { get; set; }

            /// <summary>
            /// <para>The MD5 fingerprint of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d3b95700998e47afc4d95f886579****</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>The name of the organization that is associated with the issuing subordinate CA certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里云计算有限公司</para>
            /// </summary>
            [NameInMap("Organization")]
            [Validation(Required=false)]
            public string Organization { get; set; }

            /// <summary>
            /// <para>The name of the department of the organization that is associated with the issuing subordinate certificate authority (CA) certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Security</para>
            /// </summary>
            [NameInMap("OrganizationUnit")]
            [Validation(Required=false)]
            public string OrganizationUnit { get; set; }

            /// <summary>
            /// <para>The unique identifier of the subordinate CA certificate that issued this certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>160ae6bb538d538c70c01f81dcf2****</para>
            /// </summary>
            [NameInMap("ParentIdentifier")]
            [Validation(Required=false)]
            public string ParentIdentifier { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the certificate belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmyxa2uv6cu5a</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The Subject Alternative Name (SAN) extension of the certificate. This extension indicates other domain names, IP addresses, and so on that are associated with the certificate.</para>
            /// <para>This parameter is a string that is converted from a JSON array. Each element in the JSON array is a struct that corresponds to a SAN extension. Each SAN extension struct contains the following parameters:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Type</b>: The type of the extension. This parameter is of the Integer type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: an email address.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: a domain name.</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: a Uniform Resource Identifier (URI).</para>
            /// </description></item>
            /// <item><description><para><b>7</b>: an IP address.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>Value</b>: The content of the extension. This parameter is of the String type.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[ {&quot;Type&quot;: 7, &quot;Value&quot;: &quot;192.0.XX.XX&quot;}, {&quot;Type&quot;: 2, &quot;Value&quot;: &quot;<a href="http://www.aliyundoc.com%22%7D">www.aliyundoc.com&quot;}</a>, ]</para>
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

            /// <summary>
            /// <para>The serial number of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>62b2b943a32d96883a6650e672ea0276****</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// <para>The SHA-256 fingerprint of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14dcc8afc7578e1fcec36d658f7e20de18f6957bbac42b373a66bc9de4e9****</para>
            /// </summary>
            [NameInMap("Sha2")]
            [Validation(Required=false)]
            public string Sha2 { get; set; }

            /// <summary>
            /// <para>The signature algorithm of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SHA256WITHRSA</para>
            /// </summary>
            [NameInMap("SignAlgorithm")]
            [Validation(Required=false)]
            public string SignAlgorithm { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;The name of the province, municipality, or autonomous region where the organization associated with the issuing subordinate CA certificate is located.
            /// &lt;props=&quot;intl&quot;&gt;The name of the province or state where the organization associated with the issuing subordinate CA certificate is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhejiang</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The status of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ISSUE</b>: The certificate is issued.</para>
            /// </description></item>
            /// <item><description><para><b>REVOKE</b>: The certificate is revoked.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ISSUE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The Distinguished Name (DN) of the certificate. The DN indicates the user of the certificate and contains the following information:</para>
            /// <list type="bullet">
            /// <item><description><para><b>C</b>: The country.</para>
            /// </description></item>
            /// <item><description><para><b>O</b>: The organization.</para>
            /// </description></item>
            /// <item><description><para><b>OU</b>: The department.</para>
            /// </description></item>
            /// <item><description><para><b>L</b>: The city.</para>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description><b>ST</b>: The province, municipality, or autonomous region.</description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description><para><b>ST</b>: The province or state.</para>
            /// </description></item>
            /// <item><description><para><b>CN</b>: The common name.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>C=CN,O=阿里云计算有限公司,OU=Security,L=Hangzhou,ST=Zhejiang,CN=Aliyun</para>
            /// </summary>
            [NameInMap("SubjectDN")]
            [Validation(Required=false)]
            public string SubjectDN { get; set; }

            /// <summary>
            /// <para>The content of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE-----  ...... -----END CERTIFICATE-----</para>
            /// </summary>
            [NameInMap("X509Certificate")]
            [Validation(Required=false)]
            public string X509Certificate { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Paging parameter: the maximum number of entries in the result set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of certificates returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The total number of client and server-side certificates that are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

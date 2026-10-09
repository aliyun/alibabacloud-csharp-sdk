// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeCACertificateListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of CA certificate details.</para>
        /// </summary>
        [NameInMap("CertificateList")]
        [Validation(Required=false)]
        public List<DescribeCACertificateListResponseBodyCertificateList> CertificateList { get; set; }
        public class DescribeCACertificateListResponseBodyCertificateList : TeaModel {
            /// <summary>
            /// <para>The expiration date of the CA certificate. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665819958000</para>
            /// </summary>
            [NameInMap("AfterDate")]
            [Validation(Required=false)]
            public long? AfterDate { get; set; }

            /// <summary>
            /// <para>The encryption algorithm type of the CA certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RSA</b>: RSA algorithm.</description></item>
            /// <item><description><b>ECC</b>: ECC algorithm.</description></item>
            /// <item><description><b>SM2</b>: SM2 (Chinese national cryptographic) algorithm.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RSA</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// <para>The instance alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun_CA</para>
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The issuance date of the CA certificate. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1634283958000</para>
            /// </summary>
            [NameInMap("BeforeDate")]
            [Validation(Required=false)]
            public long? BeforeDate { get; set; }

            /// <summary>
            /// <para>The type of the CA certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ROOT</b>: root CA certificate.</description></item>
            /// <item><description><b>SUB_ROOT</b>: subordinate CA certificate.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUB_ROOT</para>
            /// </summary>
            [NameInMap("CertificateType")]
            [Validation(Required=false)]
            public string CertificateType { get; set; }

            /// <summary>
            /// <para>The common name or abbreviation of the organization associated with the CA certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The country code of the organization associated with the CA certificate.</para>
            /// <para>For more information about country codes, see the <b>International codes</b> section in <a href="https://help.aliyun.com/document_detail/198289.html">Manage company information</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("CountryCode")]
            [Validation(Required=false)]
            public string CountryCode { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance is a complimentary instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: No.</description></item>
            /// <item><description>1: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Gift")]
            [Validation(Required=false)]
            public int? Gift { get; set; }

            /// <summary>
            /// <para>The unique identifier of the CA certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>160ae6bb538d538c70c01f81dcf2****</para>
            /// </summary>
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <para>The key length of the CA certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("KeySize")]
            [Validation(Required=false)]
            public int? KeySize { get; set; }

            /// <summary>
            /// <para>The name of the city where the organization associated with the CA certificate is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hangzhou</para>
            /// </summary>
            [NameInMap("Locality")]
            [Validation(Required=false)]
            public string Locality { get; set; }

            /// <summary>
            /// <para>The MD5 fingerprint of the CA certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>160ae6bb538d538c70c01f81dcf2****</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>The name of the organization associated with the CA certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里云计算有限公司</para>
            /// </summary>
            [NameInMap("Organization")]
            [Validation(Required=false)]
            public string Organization { get; set; }

            /// <summary>
            /// <para>The name of the department within the organization associated with the CA certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Security</para>
            /// </summary>
            [NameInMap("OrganizationUnit")]
            [Validation(Required=false)]
            public string OrganizationUnit { get; set; }

            /// <summary>
            /// <para>The unique identifier of the root CA certificate that issued this CA certificate.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>CertificateType</b> is <b>SUB_ROOT</b> (subordinate CA certificate).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1a83bcbb89e562885e40aa0108f5****</para>
            /// </summary>
            [NameInMap("ParentIdentifier")]
            [Validation(Required=false)]
            public string ParentIdentifier { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the certificate belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmzjwrhehpavi</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The Subject Alternative Names (SANs) of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

            /// <summary>
            /// <para>The serial number of the CA certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70e3b2566d92805173767869727fb92e****</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// <para>The SHA-256 fingerprint of the CA certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14dcc8afc7578e1fcec36d658f7e20de18f6957bbac42b373a66bc9de4e9****</para>
            /// </summary>
            [NameInMap("Sha2")]
            [Validation(Required=false)]
            public string Sha2 { get; set; }

            /// <summary>
            /// <para>The signature algorithm of the CA certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SHA256WITHRSA</para>
            /// </summary>
            [NameInMap("SignAlgorithm")]
            [Validation(Required=false)]
            public string SignAlgorithm { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;The name of the province, municipality, or autonomous region where the organization associated with the CA certificate is located.
            /// &lt;props=&quot;intl&quot;&gt;The name of the province or state where the organization associated with the CA certificate is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhejiang</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The status of the CA certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ISSUE</b>: The certificate is issued normally.</description></item>
            /// <item><description><b>REVOKE</b>: The certificate has been revoked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ISSUE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The Distinguished Name (DN) attribute of the CA certificate, which represents the subject of the certificate. It contains the following information:</para>
            /// <list type="bullet">
            /// <item><description><b>C</b>: The country code of the organization.</description></item>
            /// <item><description><b>O</b>: The name of the organization.</description></item>
            /// <item><description><b>OU</b>: The department within the organization.</description></item>
            /// <item><description><b>L</b>: The city where the organization is located.</description></item>
            /// <item><description><b>CN</b>: The common name or abbreviation of the organization.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>C=CN,O=阿里云计算有限公司,OU=Security,L=Hangzhou,ST=Zhejiang,CN=Aliyun</para>
            /// </summary>
            [NameInMap("SubjectDN")]
            [Validation(Required=false)]
            public string SubjectDN { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance is a trial instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: No.</description></item>
            /// <item><description>1: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Trial")]
            [Validation(Required=false)]
            public int? Trial { get; set; }

            /// <summary>
            /// <para>The content of the CA certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE----- …… -----END CERTIFICATE-----</para>
            /// </summary>
            [NameInMap("X509Certificate")]
            [Validation(Required=false)]
            public string X509Certificate { get; set; }

            /// <summary>
            /// <para>The validity period of the CA certificate. Unit: years.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Years")]
            [Validation(Required=false)]
            public int? Years { get; set; }

        }

        /// <summary>
        /// <para>The page number of the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
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
        /// <para>The number of CA certificates per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The total number of root CA certificates and subordinate CA certificates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

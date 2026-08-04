// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeCACertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the CA certificate.</para>
        /// </summary>
        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public DescribeCACertificateResponseBodyCertificate Certificate { get; set; }
        public class DescribeCACertificateResponseBodyCertificate : TeaModel {
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
            /// <para>The issuance date of the CA certificate. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1634283958000</para>
            /// </summary>
            [NameInMap("BeforeDate")]
            [Validation(Required=false)]
            public long? BeforeDate { get; set; }

            /// <summary>
            /// <para>The complete certificate chain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE-----
            /// -----END CERTIFICATE-----</para>
            /// <para>-----BEGIN CERTIFICATE-----
            /// -----END CERTIFICATE-----</para>
            /// <para>-----BEGIN CERTIFICATE-----
            /// -----END CERTIFICATE-----</para>
            /// </summary>
            [NameInMap("CaCertChain")]
            [Validation(Required=false)]
            public string CaCertChain { get; set; }

            /// <summary>
            /// <para>The number of certificates issued by the private CA instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CertIssuedCount")]
            [Validation(Required=false)]
            public long? CertIssuedCount { get; set; }

            /// <summary>
            /// <para>The maximum validity period for certificates issued by the CA, as specified by the certMaxTime of the CA.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("CertMaxTime")]
            [Validation(Required=false)]
            public int? CertMaxTime { get; set; }

            /// <summary>
            /// <para>The number of remaining certificate quotas that can be allocated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("CertRemainingCount")]
            [Validation(Required=false)]
            public long? CertRemainingCount { get; set; }

            /// <summary>
            /// <para>The total number of purchased certificate quotas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("CertTotalCount")]
            [Validation(Required=false)]
            public long? CertTotalCount { get; set; }

            /// <summary>
            /// <para>The type of the CA certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ROOT</b>: root CA certificate.</description></item>
            /// <item><description><b>SUB_ROOT</b>: sub-CA certificate.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUB_ROOT</para>
            /// </summary>
            [NameInMap("CertificateType")]
            [Validation(Required=false)]
            public string CertificateType { get; set; }

            /// <summary>
            /// <para>The identifier of the hardware security module (HSM) cluster. (The CA is enabled through an HSM.)</para>
            /// 
            /// <b>Example:</b>
            /// <para>XXX-id</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

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
            /// <para>The validity period of the CRL, ranging from 1 to 365 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("CrlDay")]
            [Validation(Required=false)]
            public int? CrlDay { get; set; }

            /// <summary>
            /// <para>The certificate revocation list (CRL) status (enabled or disabled).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("CrlStatus")]
            [Validation(Required=false)]
            public string CrlStatus { get; set; }

            /// <summary>
            /// <para>The CRL URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://crl-cn-publish.oss-cn-hangzhou.aliyuncs.com/pca/crl/1925647866611395/1ed40789-483f-6023-b6b8-29ddd3bb0a9a.crl">https://crl-cn-publish.oss-cn-hangzhou.aliyuncs.com/pca/crl/1925647866611395/1ed40789-483f-6023-b6b8-29ddd3bb0a9a.crl</a></para>
            /// </summary>
            [NameInMap("CrlUrl")]
            [Validation(Required=false)]
            public string CrlUrl { get; set; }

            /// <summary>
            /// <para>The algorithm with key length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RSA_2048</para>
            /// </summary>
            [NameInMap("FullAlgorithm")]
            [Validation(Required=false)]
            public string FullAlgorithm { get; set; }

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
            /// <para>The issuing authority of the CA. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>local: private certificate.</description></item>
            /// <item><description>iTrusChina: compliant CA.</description></item>
            /// <item><description>external: externally imported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>local</para>
            /// </summary>
            [NameInMap("IssuerType")]
            [Validation(Required=false)]
            public string IssuerType { get; set; }

            /// <summary>
            /// <para>The key index position in the HSM. (The CA is enabled through an HSM.)</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("KeyIndex")]
            [Validation(Required=false)]
            public int? KeyIndex { get; set; }

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
            /// <para>aliyun</para>
            /// </summary>
            [NameInMap("Organization")]
            [Validation(Required=false)]
            public string Organization { get; set; }

            /// <summary>
            /// <para>The name of the department in the organization associated with the CA certificate.</para>
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
            /// <para>This parameter is returned only when <b>CertificateType</b> is <b>SUB_ROOT</b> (sub-CA certificate).</para>
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
            /// <para>rg-aek2pxd7ekpoo2y</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
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
            /// <item><description><b>ISSUE</b>: issued.</description></item>
            /// <item><description><b>REVOKE</b>: revoked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ISSUE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The subject attributes of the CA certificate, which include the following information:</para>
            /// <list type="bullet">
            /// <item><description><b>C</b>: the country code of the organization.</description></item>
            /// <item><description><b>O</b>: the name of the organization.</description></item>
            /// <item><description><b>OU</b>: the department of the organization.</description></item>
            /// <item><description><b>L</b>: the city where the organization is located.
            /// &lt;props=&quot;china&quot;&gt;- <b>ST</b>: the province, municipality, or autonomous region where the organization is located.
            /// &lt;props=&quot;intl&quot;&gt;- <b>ST</b>: the province or state where the organization is located.</description></item>
            /// <item><description><b>CN</b>: the common name or abbreviation of the organization.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>C=CN,O=aliyun,OU=Security,L=Hangzhou,ST=Zhejiang,CN=Aliyun</para>
            /// </summary>
            [NameInMap("SubjectDN")]
            [Validation(Required=false)]
            public string SubjectDN { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeCACertificateResponseBodyCertificateTags> Tags { get; set; }
            public class DescribeCACertificateResponseBodyCertificateTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Usage status</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BMS</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

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
            /// <para>1</para>
            /// </summary>
            [NameInMap("Years")]
            [Validation(Required=false)]
            public int? Years { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The validity period of the CA certificate. Unit: years.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Years")]
        [Validation(Required=false)]
        public int? Years { get; set; }

    }

}

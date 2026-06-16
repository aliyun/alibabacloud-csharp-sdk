// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeClientCertificateForSerialNumberResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the client or server certificates.</para>
        /// </summary>
        [NameInMap("CertificateList")]
        [Validation(Required=false)]
        public List<DescribeClientCertificateForSerialNumberResponseBodyCertificateList> CertificateList { get; set; }
        public class DescribeClientCertificateForSerialNumberResponseBodyCertificateList : TeaModel {
            /// <summary>
            /// <para>The expiration time of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-23T16:15Z</para>
            /// </summary>
            [NameInMap("AfterDate")]
            [Validation(Required=false)]
            public string AfterDate { get; set; }

            /// <summary>
            /// <para>The encryption algorithm of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>RSA</b>: The RSA algorithm.</para>
            /// </description></item>
            /// <item><description><para><b>ECC</b>: The ECC algorithm.</para>
            /// </description></item>
            /// <item><description><para><b>SM2</b>: The SM2 algorithm.</para>
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
            /// <para>The issuance time of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-28T16:15Z</para>
            /// </summary>
            [NameInMap("BeforeDate")]
            [Validation(Required=false)]
            public string BeforeDate { get; set; }

            /// <summary>
            /// <para>The type of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUB_ROOT</para>
            /// </summary>
            [NameInMap("CertificateType")]
            [Validation(Required=false)]
            public string CertificateType { get; set; }

            /// <summary>
            /// <para>The common name of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun.com</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The two-letter country code of the issuer.</para>
            /// <para>For more information about country codes, see the <b>Country codes</b> section in <a href="https://help.aliyun.com/document_detail/198289.html">Manage company profiles</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("CountryCode")]
            [Validation(Required=false)]
            public string CountryCode { get; set; }

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
            /// <para>The city of the issuer.</para>
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
            /// <para>The organization of the issuer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里云计算有限公司</para>
            /// </summary>
            [NameInMap("Organization")]
            [Validation(Required=false)]
            public string Organization { get; set; }

            /// <summary>
            /// <para>The organizational unit of the issuer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Security</para>
            /// </summary>
            [NameInMap("OrganizationUnit")]
            [Validation(Required=false)]
            public string OrganizationUnit { get; set; }

            /// <summary>
            /// <para>The identifier of the issuer. This parameter is returned only if the certificate is issued by Alibaba Cloud.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1a83bcbb89e562885e40aa0108f5****</para>
            /// </summary>
            [NameInMap("ParentIdentifier")]
            [Validation(Required=false)]
            public string ParentIdentifier { get; set; }

            /// <summary>
            /// <para>The subject alternative name (SAN) extension, which specifies identifiers such as email addresses, domain names, URIs, and IP addresses.</para>
            /// <para>A JSON string that represents an array of SAN objects. Each object contains the following parameters:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Type</b>: The type of the extension. This parameter is an integer. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: email address.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: domain name.</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: uniform resource identifier (URI).</para>
            /// </description></item>
            /// <item><description><para><b>7</b>: IP address.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>Value</b>: The content of the extension. This parameter is a string.</para>
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
            /// <para>084bde9cd233f0ddae33adc438cfbbbd****</para>
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
            /// <para>&lt;props=&quot;china&quot;&gt;The state or province of the issuer.
            /// &lt;props=&quot;intl&quot;&gt;The state or province of the issuer.</para>
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
            /// <para>The distinguished name (DN) of the certificate. The DN contains information about the certificate subject, including:</para>
            /// <list type="bullet">
            /// <item><description><para><b>C</b>: Country.</para>
            /// </description></item>
            /// <item><description><para><b>O</b>: Organization.</para>
            /// </description></item>
            /// <item><description><para><b>OU</b>: Organizational unit.</para>
            /// </description></item>
            /// <item><description><para><b>L</b>: City.</para>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description><b>ST</b>: State or province.</description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description><para><b>ST</b>: State or province.</para>
            /// </description></item>
            /// <item><description><para><b>CN</b>: Common name.</para>
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
            /// <para>The certificate content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE-----  ...... -----END CERTIFICATE-----</para>
            /// </summary>
            [NameInMap("X509Certificate")]
            [Validation(Required=false)]
            public string X509Certificate { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Years")]
            [Validation(Required=false)]
            public int? Years { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

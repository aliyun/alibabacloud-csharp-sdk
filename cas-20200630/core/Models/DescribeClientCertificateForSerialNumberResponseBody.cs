// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeClientCertificateForSerialNumberResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the client certificates or server certificates.</para>
        /// </summary>
        [NameInMap("CertificateList")]
        [Validation(Required=false)]
        public List<DescribeClientCertificateForSerialNumberResponseBodyCertificateList> CertificateList { get; set; }
        public class DescribeClientCertificateForSerialNumberResponseBodyCertificateList : TeaModel {
            /// <summary>
            /// <para>The expiration date of the certificate. The format is YYYY-MM-DD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-23T16:15Z</para>
            /// </summary>
            [NameInMap("AfterDate")]
            [Validation(Required=false)]
            public string AfterDate { get; set; }

            /// <summary>
            /// <para>The encryption algorithm type of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RSA</b>: RSA algorithm.</description></item>
            /// <item><description><b>ECC</b>: ECC algorithm.</description></item>
            /// <item><description><b>SM2</b>: SM2 algorithm.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RSA</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// <para>The issuance date of the certificate. The format is YYYY-MM-DD.</para>
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
            /// <para>The code of the country where the organization associated with the subordinate CA certificate that issued this certificate is located.</para>
            /// <para>For more information about country codes, see the <b>International codes</b> section in <a href="https://help.aliyun.com/document_detail/198289.html">Manage company information</a>.</para>
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
            /// <para>The name of the city where the organization associated with the subordinate CA certificate that issued this certificate is located.</para>
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
            /// <para>The name of the organization associated with the subordinate CA certificate that issued this certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud Computing Co., Ltd</para>
            /// </summary>
            [NameInMap("Organization")]
            [Validation(Required=false)]
            public string Organization { get; set; }

            /// <summary>
            /// <para>The name of the department in the organization associated with the subordinate CA certificate that issued this certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Security</para>
            /// </summary>
            [NameInMap("OrganizationUnit")]
            [Validation(Required=false)]
            public string OrganizationUnit { get; set; }

            /// <summary>
            /// <para>If this parameter is not empty, the client certificate is issued by Alibaba Cloud.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1a83bcbb89e562885e40aa0108f5****</para>
            /// </summary>
            [NameInMap("ParentIdentifier")]
            [Validation(Required=false)]
            public string ParentIdentifier { get; set; }

            /// <summary>
            /// <para>The Subject Alternative Name (SAN) extension of the certificate, which indicates other domain names or IP addresses associated with the certificate.</para>
            /// <para>This parameter is represented as a string converted from a JSON array. Each element in the JSON array is a structure that corresponds to a SAN extension. Each SAN extension structure contains the following parameters:</para>
            /// <list type="bullet">
            /// <item><description><b>Type</b>: An Integer value that indicates the type of the extension. Valid values:<list type="bullet">
            /// <item><description><b>1</b>: an email address.</description></item>
            /// <item><description><b>2</b>: a domain name.</description></item>
            /// <item><description><b>6</b>: a Uniform Resource Identifier (URI).</description></item>
            /// <item><description><b>7</b>: an IP address.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>Value</b>: A String value that indicates the content of the extension.</description></item>
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
            /// <para>&lt;props=&quot;china&quot;&gt;The name of the province, municipality, or autonomous region where the organization associated with the subordinate CA certificate that issued this certificate is located.
            /// &lt;props=&quot;intl&quot;&gt;The name of the province or state where the organization associated with the subordinate CA certificate that issued this certificate is located.</para>
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
            /// <para>The distinguished name (DN) attribute of the certificate, which indicates the subject of the certificate. The DN contains the following information:</para>
            /// <list type="bullet">
            /// <item><description><b>C</b>: The country.</description></item>
            /// <item><description><b>O</b>: The organization.</description></item>
            /// <item><description><b>OU</b>: The department.</description></item>
            /// <item><description><b>L</b>: The city.
            /// &lt;props=&quot;china&quot;&gt;- <b>ST</b>: The province, municipality, or autonomous region.
            /// &lt;props=&quot;intl&quot;&gt;- <b>ST</b>: The province or state.</description></item>
            /// <item><description><b>CN</b>: The common name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>C=CN,O=Alibaba Cloud Computing Co., Ltd.,OU=Security,L=Hangzhou,ST=Zhejiang,CN=Aliyun</para>
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

            /// <summary>
            /// <para>The validity period of the certificate. Unit: years.</para>
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

    }

}

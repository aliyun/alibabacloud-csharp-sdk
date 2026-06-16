// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class ListRevokeCertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the revoked client or server-side certificates.</para>
        /// </summary>
        [NameInMap("CertificateList")]
        [Validation(Required=false)]
        public List<ListRevokeCertificateResponseBodyCertificateList> CertificateList { get; set; }
        public class ListRevokeCertificateResponseBodyCertificateList : TeaModel {
            /// <summary>
            /// <para>The expiration date of the certificate. The format is <c>yyyy-MM-ddT00:00Z</c>. For example, <c>2021-12-31T00:00Z</c> indicates December 31, 2021.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-31T00:00Z</para>
            /// </summary>
            [NameInMap("AfterDate")]
            [Validation(Required=false)]
            public string AfterDate { get; set; }

            /// <summary>
            /// <para>The type of the encryption algorithm of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>RSA</b>: the RSA algorithm.</para>
            /// </description></item>
            /// <item><description><para><b>ECC</b>: the ECC algorithm.</para>
            /// </description></item>
            /// <item><description><para><b>SM2</b>: the SM2 algorithm.</para>
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
            /// <para>The date when the certificate was issued. The format is <c>yyyy-MM-ddT00:00Z</c>. For example, <c>2021-01-01T00:00Z</c> indicates January 1, 2021.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-01T00:00Z</para>
            /// </summary>
            [NameInMap("BeforeDate")]
            [Validation(Required=false)]
            public string BeforeDate { get; set; }

            /// <summary>
            /// <para>The type of the certificate.</para>
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
            /// <para>The country code of the organization that is associated with the subordinate CA certificate that issued the certificate.</para>
            /// <para>For more information about country codes, see the &quot;Country codes&quot; section in <a href="https://help.aliyun.com/document_detail/198289.html">Manage company information</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("CountryCode")]
            [Validation(Required=false)]
            public string CountryCode { get; set; }

            /// <summary>
            /// <para>The custom identifier. This is a unique key.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>48d8d3ecc9976d9ecd2b2f25</b></b></para>
            /// </summary>
            [NameInMap("CustomIdentifier")]
            [Validation(Required=false)]
            public string CustomIdentifier { get; set; }

            /// <summary>
            /// <para>The unique identifier of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>05e148d8d3ecc9976d9ecd2b2f25****</para>
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
            /// <para>The name of the city where the organization of the subordinate CA certificate that issued the certificate is located.</para>
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
            /// <para>05e148d8d3ecc9976d9ecd2b2f25****</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>The name of the organization that is associated with the subordinate CA certificate that issued the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里云计算有限公司</para>
            /// </summary>
            [NameInMap("Organization")]
            [Validation(Required=false)]
            public string Organization { get; set; }

            /// <summary>
            /// <para>The name of the department of the organization that is associated with the subordinate CA certificate that issued the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Security</para>
            /// </summary>
            [NameInMap("OrganizationUnit")]
            [Validation(Required=false)]
            public string OrganizationUnit { get; set; }

            /// <summary>
            /// <para>The identifier of the parent certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>160ae6bb538d538c70c01f81dcf2****</para>
            /// </summary>
            [NameInMap("ParentIdentifier")]
            [Validation(Required=false)]
            public string ParentIdentifier { get; set; }

            /// <summary>
            /// <para>The date when the certificate was revoked. The format is <c>yyyy-MM-ddT00:00Z</c>. For example, <c>2021-09-01T00:00Z</c> indicates September 1, 2021.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-01T00:00Z</para>
            /// </summary>
            [NameInMap("RevokeDate")]
            [Validation(Required=false)]
            public string RevokeDate { get; set; }

            /// <summary>
            /// <para>The Subject Alternative Name (SAN) extension of the certificate.</para>
            /// <para>This parameter is a string that is converted from a JSON array. Each element in the JSON array is a struct that corresponds to a SAN extension. Each SAN extension struct contains the following parameters:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Type</b>: The type of the extension. This parameter is of the integer type. Valid values:</para>
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
            /// <item><description><para><b>Value</b>: The content of the extension. This parameter is of the string type.</para>
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
            /// <para>168b12c42e62339f8d2340ff530f9365****</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// <para>The SHA-256 fingerprint of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b60eff7e04323ff662f9ab5e6986f849f626a9c7bf2c59dcc752fa23779a****</para>
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
            /// <para>The name of the province or state of the organization that is associated with the subordinate CA certificate that issued the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhejiang</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The status of the certificate.</para>
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
            /// <item><description><para><b>CN</b>: The common name.</para>
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
            /// <para>C=CN,O=阿里云计算有限公司,OU=Security,L=ZheJiang,ST=HangZhou,CN=aliyundoc.com</para>
            /// </summary>
            [NameInMap("SubjectDN")]
            [Validation(Required=false)]
            public string SubjectDN { get; set; }

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
        /// <para>The number of revoked certificates on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The total number of revoked client and server-side certificates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

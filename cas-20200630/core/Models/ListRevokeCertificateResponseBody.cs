// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class ListRevokeCertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the details about the revoked client certificates or server certificates.</para>
        /// </summary>
        [NameInMap("CertificateList")]
        [Validation(Required=false)]
        public List<ListRevokeCertificateResponseBodyCertificateList> CertificateList { get; set; }
        public class ListRevokeCertificateResponseBodyCertificateList : TeaModel {
            /// <summary>
            /// <para>The expiration date of the certificate. The date is in the <c>yyyy-MM-ddT00:00Z</c> format. For example, the value <c>2021-12-31T00:00Z</c> indicates December 31, 2021.</para>
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
            /// <item><description><b>RSA</b>: the Rivest-Shamir-Adleman (RSA) algorithm.</description></item>
            /// <item><description><b>ECC</b>: the elliptic curve cryptography (ECC) algorithm.</description></item>
            /// <item><description><b>SM2</b>: the SM2 algorithm, which is developed and approved by the State Cryptography Administration of China.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RSA</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// <para>The issuance date of the certificate. The date is in the <c>yyyy-MM-ddT00:00Z</c> format. For example, the value <c>2021-01-01T00:00Z</c> indicates January 1, 2021.</para>
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
            /// <para>The code of the country in which the organization is located. The organization is associated with the intermediate certificate from which the certificate is issued.</para>
            /// <para>For more information about country codes, see the <b>&quot;Country codes&quot;</b> section of the <a href="https://help.aliyun.com/document_detail/198289.html">Manage company profiles</a> topic.</para>
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
            /// <para>The name of the city in which the organization is located. The organization is associated with the intermediate certificate from which the certificate is issued.</para>
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
            /// <para>The name of the organization. The organization is associated with the intermediate certificate from which the certificate is issued.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud Computing Co., Ltd.</para>
            /// </summary>
            [NameInMap("Organization")]
            [Validation(Required=false)]
            public string Organization { get; set; }

            /// <summary>
            /// <para>The name of the department in the organization. The organization is associated with the intermediate certificate authority (CA) certificate from which the certificate is issued.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Security</para>
            /// </summary>
            [NameInMap("OrganizationUnit")]
            [Validation(Required=false)]
            public string OrganizationUnit { get; set; }

            /// <summary>
            /// <para>The identifier of the root certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>160ae6bb538d538c70c01f81dcf2****</para>
            /// </summary>
            [NameInMap("ParentIdentifier")]
            [Validation(Required=false)]
            public string ParentIdentifier { get; set; }

            /// <summary>
            /// <para>The date on which the certificate was revoked. The value is in the <c>yyyy-MM-ddT00:00Z</c> format. For example, the value <c>2021-09-01T00:00Z</c> indicates September 1, 2021.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-01T00:00Z</para>
            /// </summary>
            [NameInMap("RevokeDate")]
            [Validation(Required=false)]
            public string RevokeDate { get; set; }

            /// <summary>
            /// <para>The subject alternative name (SAN) extension of the certificate.</para>
            /// <para>The value is a string that consists of JSON arrays. Each element in a JSON array is a JSON struct that corresponds to a SAN extension. A SAN extension struct contains the following parameters:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Type</b>: the type of the extension. Data type: integer. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: an email address</description></item>
            /// <item><description><b>2</b>: a domain name</description></item>
            /// <item><description><b>6</b>: a Uniform Resource Identifier (URI)</description></item>
            /// <item><description><b>7</b>: an IP address</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>Value</b>: the value of the extension. Data type: string.</para>
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
            /// <para>The name of the province, municipality, or autonomous region in which the organization is located. The organization is associated with the intermediate certificate from which the certificate is issued.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhejiang</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ISSUE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The distinguished name (DN) extension of the certificate, which indicates the user of the certificate. The DN extension includes the following information:</para>
            /// <list type="bullet">
            /// <item><description><b>C</b>: the country</description></item>
            /// <item><description><b>O</b>: the organization</description></item>
            /// <item><description><b>OU</b>: the department</description></item>
            /// <item><description><b>L</b>: the city</description></item>
            /// <item><description><b>ST</b>: the province, municipality, or autonomous region</description></item>
            /// <item><description><b>CN</b>: the common name</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>C=CN,O=Alibaba Cloud Computing Co., Ltd.,OU=Security,L=ZheJiang,ST=HangZhou,CN=aliyundoc.com</para>
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
        /// <para>The number of revoked certificates that are returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The total number of revoked client certificates and server certificates that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

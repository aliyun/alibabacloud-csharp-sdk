// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribePcaAndExternalCACertificateListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of certificates.</para>
        /// </summary>
        [NameInMap("CertificateList")]
        [Validation(Required=false)]
        public List<DescribePcaAndExternalCACertificateListResponseBodyCertificateList> CertificateList { get; set; }
        public class DescribePcaAndExternalCACertificateListResponseBodyCertificateList : TeaModel {
            /// <summary>
            /// <para>The expiration time of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-23T16:15Z</para>
            /// </summary>
            [NameInMap("AfterDate")]
            [Validation(Required=false)]
            public long? AfterDate { get; set; }

            /// <summary>
            /// <para>The algorithm of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RSA</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// <para>The time at which the certificate is issued.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-01T00:00Z</para>
            /// </summary>
            [NameInMap("BeforeDate")]
            [Validation(Required=false)]
            public long? BeforeDate { get; set; }

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
            /// <para>The primary domain name that is bound to the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun.com</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The country code of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("CountryCode")]
            [Validation(Required=false)]
            public string CountryCode { get; set; }

            /// <summary>
            /// <para>The ID of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>05e148d8d3ecc9976d9ecd2b2f25****</para>
            /// </summary>
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <para>The key size of the certificate. Unit: bits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("KeySize")]
            [Validation(Required=false)]
            public int? KeySize { get; set; }

            /// <summary>
            /// <para>The city in which the organization is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hangzhou</para>
            /// </summary>
            [NameInMap("Locality")]
            [Validation(Required=false)]
            public string Locality { get; set; }

            /// <summary>
            /// <para>The MD5 value of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>05e148d8d3ecc9976d9ecd2b2f25****</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>The organization to which the certificate belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里云计算有限公司</para>
            /// </summary>
            [NameInMap("Organization")]
            [Validation(Required=false)]
            public string Organization { get; set; }

            /// <summary>
            /// <para>The certificate authority (CA) that issued the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Security</para>
            /// </summary>
            [NameInMap("OrganizationUnit")]
            [Validation(Required=false)]
            public string OrganizationUnit { get; set; }

            /// <summary>
            /// <para>The ID of the parent certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1a83bcbb89e562885e40aa0108f5****</para>
            /// </summary>
            [NameInMap("ParentIdentifier")]
            [Validation(Required=false)]
            public string ParentIdentifier { get; set; }

            /// <summary>
            /// <para>All domain names that are bound to the certificate.</para>
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
            /// <para>The primary domain name that is bound to the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14dcc8afc7578e1fcec36d658f7e20de18f6957bbac42b373a66bc9de4e9****</para>
            /// </summary>
            [NameInMap("Sha2")]
            [Validation(Required=false)]
            public string Sha2 { get; set; }

            /// <summary>
            /// <para>The signature algorithm of the certificate. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>SHA256WITHRSA</para>
            /// </summary>
            [NameInMap("SignAlgorithm")]
            [Validation(Required=false)]
            public string SignAlgorithm { get; set; }

            /// <summary>
            /// <para>The status of the certificate. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhejiang</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The status of the certificate. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>ISSUE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The subject of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C=CN,O=阿里云计算有限公司,OU=Security,L=Hangzhou,ST=Zhejiang,CN=Aliyun</para>
            /// </summary>
            [NameInMap("SubjectDN")]
            [Validation(Required=false)]
            public string SubjectDN { get; set; }

            /// <summary>
            /// <para>The content of the X.509 certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE----- …… -----END CERTIFICATE-----</para>
            /// </summary>
            [NameInMap("X509Certificate")]
            [Validation(Required=false)]
            public string X509Certificate { get; set; }

            /// <summary>
            /// <para>The validity period of the certificate, in years.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Years")]
            [Validation(Required=false)]
            public int? Years { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

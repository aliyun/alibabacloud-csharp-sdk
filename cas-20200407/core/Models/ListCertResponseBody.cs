// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCertResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of certificates.</para>
        /// </summary>
        [NameInMap("CertList")]
        [Validation(Required=false)]
        public List<ListCertResponseBodyCertList> CertList { get; set; }
        public class ListCertResponseBodyCertList : TeaModel {
            /// <summary>
            /// <para>The expiration date of the certificate. This value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1634283958000</para>
            /// </summary>
            [NameInMap("AfterDate")]
            [Validation(Required=false)]
            public long? AfterDate { get; set; }

            /// <summary>
            /// <para>The encryption algorithm of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>RSA</b>: the RSA algorithm</para>
            /// </description></item>
            /// <item><description><para><b>ECC</b>: the ECC algorithm</para>
            /// </description></item>
            /// <item><description><para><b>SM2</b>: the SM2 algorithm</para>
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
            /// <para>The start date of the certificate\&quot;s validity period. This value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665819958000</para>
            /// </summary>
            [NameInMap("BeforeDate")]
            [Validation(Required=false)]
            public long? BeforeDate { get; set; }

            /// <summary>
            /// <para>The type of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>CA</b>: a Certificate Authority (CA) certificate</para>
            /// </description></item>
            /// <item><description><para><b>CERT</b>: an issued certificate</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CERT</para>
            /// </summary>
            [NameInMap("CertType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            /// <summary>
            /// <para>The common name of the certificate. This is typically the primary domain name associated with the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun.alibaba.com</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>Indicates whether a private key is available for the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b></para>
            /// </description></item>
            /// <item><description><para><b>false</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ExistPrivateKey")]
            [Validation(Required=false)]
            public bool? ExistPrivateKey { get; set; }

            /// <summary>
            /// <para>The unique identifier of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14dcc8afc7578e</para>
            /// </summary>
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <para>The issuer of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mySSL</para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>The Subject Alternative Names (SANs) associated with the certificate. Multiple domain names are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>*.alibaba.com,aliyun.alibaba.com</para>
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

            /// <summary>
            /// <para>The serial number of the certificate. This parameter is returned only if the <c>OrderType</c> request parameter is set to <c>CERT</c> or <c>UPLOAD</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>038abf4c27c33a7c11ad6658124135b52180</para>
            /// </summary>
            [NameInMap("SerialNo")]
            [Validation(Required=false)]
            public string SerialNo { get; set; }

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
            /// <para>The source of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>upload</b>: The certificate is uploaded.</para>
            /// </description></item>
            /// <item><description><para><b>aliyun</b>: The certificate is from Alibaba Cloud.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

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
            /// <para>The warehouse ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("WhId")]
            [Validation(Required=false)]
            public long? WhId { get; set; }

            /// <summary>
            /// <para>The warehouse instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_whInstanceId</para>
            /// </summary>
            [NameInMap("WhInstanceId")]
            [Validation(Required=false)]
            public string WhInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The current page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

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
        /// <para>The page size. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public long? ShowSize { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

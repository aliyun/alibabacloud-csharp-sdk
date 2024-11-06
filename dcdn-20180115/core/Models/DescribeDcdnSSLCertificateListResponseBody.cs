// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnSSLCertificateListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of certificates.</para>
        /// </summary>
        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeDcdnSSLCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeDcdnSSLCertificateListResponseBodyCertificateListModel : TeaModel {
            /// <summary>
            /// <para>Details about each certificate.</para>
            /// </summary>
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public DescribeDcdnSSLCertificateListResponseBodyCertificateListModelCertList CertList { get; set; }
            public class DescribeDcdnSSLCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                [NameInMap("Cert")]
                [Validation(Required=false)]
                public List<DescribeDcdnSSLCertificateListResponseBodyCertificateListModelCertListCert> Cert { get; set; }
                public class DescribeDcdnSSLCertificateListResponseBodyCertificateListModelCertListCert : TeaModel {
                    /// <summary>
                    /// <para>The ID of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7428244</para>
                    /// </summary>
                    [NameInMap("CertId")]
                    [Validation(Required=false)]
                    public long? CertId { get; set; }

                    /// <summary>
                    /// <para>The name of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yourCertName</para>
                    /// </summary>
                    [NameInMap("CertName")]
                    [Validation(Required=false)]
                    public string CertName { get; set; }

                    /// <summary>
                    /// <para>The region ID of the certificate. Valid values: <b>cn-hangzhou</b> and <b>ap-southeast-1</b>. Default value: <b>cn-hangzhou</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("CertRegion")]
                    [Validation(Required=false)]
                    public string CertRegion { get; set; }

                    /// <summary>
                    /// <para>The Common Name (CN) attribute of the certificate. In most cases, the CN is a domain name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example.com</para>
                    /// </summary>
                    [NameInMap("Common")]
                    [Validation(Required=false)]
                    public string Common { get; set; }

                    /// <summary>
                    /// <para>The fingerprint of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4278e3b81ab5bc678d253e74c17ffb88</para>
                    /// </summary>
                    [NameInMap("Fingerprint")]
                    [Validation(Required=false)]
                    public string Fingerprint { get; set; }

                    /// <summary>
                    /// <para>The certificate authority (CA) that issued the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yourCertIssuer</para>
                    /// </summary>
                    [NameInMap("Issuer")]
                    [Validation(Required=false)]
                    public string Issuer { get; set; }

                    /// <summary>
                    /// <para>The time when the certificate was last modified. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1548065550</para>
                    /// </summary>
                    [NameInMap("LastTime")]
                    [Validation(Required=false)]
                    public long? LastTime { get; set; }

                }

            }

            /// <summary>
            /// <para>The number of certificates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number. Pages start from page 1. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Valid values: an integer from 1 to 1000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-3C82-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

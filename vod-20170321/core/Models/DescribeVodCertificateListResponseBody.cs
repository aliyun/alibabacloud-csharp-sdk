// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodCertificateListResponseBody : TeaModel {
        /// <summary>
        /// The common name of the certificate.
        /// </summary>
        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeVodCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeVodCertificateListResponseBodyCertificateListModel : TeaModel {
            /// <summary>
            /// The ID of the certificate.
            /// </summary>
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public DescribeVodCertificateListResponseBodyCertificateListModelCertList CertList { get; set; }
            public class DescribeVodCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                [NameInMap("Cert")]
                [Validation(Required=false)]
                public List<DescribeVodCertificateListResponseBodyCertificateListModelCertListCert> Cert { get; set; }
                public class DescribeVodCertificateListResponseBodyCertificateListModelCertListCert : TeaModel {
                    [NameInMap("CertId")]
                    [Validation(Required=false)]
                    public long? CertId { get; set; }

                    /// <summary>
                    /// The operation that you want to perform. Set the value to **DescribeVodCertificateList**.
                    /// </summary>
                    [NameInMap("CertName")]
                    [Validation(Required=false)]
                    public string CertName { get; set; }

                    [NameInMap("Common")]
                    [Validation(Required=false)]
                    public string Common { get; set; }

                    /// <summary>
                    /// The ID of the request.
                    /// </summary>
                    [NameInMap("Fingerprint")]
                    [Validation(Required=false)]
                    public string Fingerprint { get; set; }

                    /// <summary>
                    /// Queries the certificates of a specified domain name for CDN or all the domain names for CDN within your Alibaba Cloud account.
                    /// </summary>
                    [NameInMap("Issuer")]
                    [Validation(Required=false)]
                    public string Issuer { get; set; }

                    /// <summary>
                    /// The details of each certificate.
                    /// </summary>
                    [NameInMap("LastTime")]
                    [Validation(Required=false)]
                    public long? LastTime { get; set; }

                }

            }

            /// <summary>
            /// The number of certificates.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

        }

        /// <summary>
        /// The certificate authority (CA) that issued the certificate.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnSSLCertificateListResponseBody : TeaModel {
        /// <summary>
        /// The list of certificates.
        /// </summary>
        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeDcdnSSLCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeDcdnSSLCertificateListResponseBodyCertificateListModel : TeaModel {
            /// <summary>
            /// Details about each certificate.
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
                    /// The ID of the certificate.
                    /// </summary>
                    [NameInMap("CertId")]
                    [Validation(Required=false)]
                    public long? CertId { get; set; }

                    /// <summary>
                    /// The name of the certificate.
                    /// </summary>
                    [NameInMap("CertName")]
                    [Validation(Required=false)]
                    public string CertName { get; set; }

                    /// <summary>
                    /// The region ID of the certificate. Valid values: **cn-hangzhou** and **ap-southeast-1**. Default value: **cn-hangzhou**.
                    /// </summary>
                    [NameInMap("CertRegion")]
                    [Validation(Required=false)]
                    public string CertRegion { get; set; }

                    /// <summary>
                    /// The Common Name (CN) attribute of the certificate. In most cases, the CN is a domain name.
                    /// </summary>
                    [NameInMap("Common")]
                    [Validation(Required=false)]
                    public string Common { get; set; }

                    /// <summary>
                    /// The fingerprint of the certificate.
                    /// </summary>
                    [NameInMap("Fingerprint")]
                    [Validation(Required=false)]
                    public string Fingerprint { get; set; }

                    /// <summary>
                    /// The certificate authority (CA) that issued the certificate.
                    /// </summary>
                    [NameInMap("Issuer")]
                    [Validation(Required=false)]
                    public string Issuer { get; set; }

                    /// <summary>
                    /// The time when the certificate was last modified. Unit: milliseconds.
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

            /// <summary>
            /// The page number. Pages start from page 1. Default value: 1.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page. Valid values: an integer from 1 to 1000.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

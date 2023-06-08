// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnCertificateListResponseBody : TeaModel {
        /// <summary>
        /// Details about certificates.
        /// </summary>
        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeCdnCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeCdnCertificateListResponseBodyCertificateListModel : TeaModel {
            /// <summary>
            /// The list of certificates.
            /// </summary>
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public DescribeCdnCertificateListResponseBodyCertificateListModelCertList CertList { get; set; }
            public class DescribeCdnCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                [NameInMap("Cert")]
                [Validation(Required=false)]
                public List<DescribeCdnCertificateListResponseBodyCertificateListModelCertListCert> Cert { get; set; }
                public class DescribeCdnCertificateListResponseBodyCertificateListModelCertListCert : TeaModel {
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
                    /// The timestamp.
                    /// </summary>
                    [NameInMap("LastTime")]
                    [Validation(Required=false)]
                    public long? LastTime { get; set; }

                }

            }

            /// <summary>
            /// The number of certificates that are returned.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

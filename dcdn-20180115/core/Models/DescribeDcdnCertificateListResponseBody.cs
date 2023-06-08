// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnCertificateListResponseBody : TeaModel {
        /// <summary>
        /// Details about certificates.
        /// </summary>
        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeDcdnCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeDcdnCertificateListResponseBodyCertificateListModel : TeaModel {
            /// <summary>
            /// Details about each certificate.
            /// </summary>
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public DescribeDcdnCertificateListResponseBodyCertificateListModelCertList CertList { get; set; }
            public class DescribeDcdnCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                [NameInMap("Cert")]
                [Validation(Required=false)]
                public List<DescribeDcdnCertificateListResponseBodyCertificateListModelCertListCert> Cert { get; set; }
                public class DescribeDcdnCertificateListResponseBodyCertificateListModelCertListCert : TeaModel {
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
            /// The number of certificates.
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodCertificateListResponseBody : TeaModel {
        /// <summary>
        /// The information about each certificate.
        /// </summary>
        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeVodCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeVodCertificateListResponseBodyCertificateListModel : TeaModel {
            /// <summary>
            /// The list of certificates.
            /// </summary>
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public DescribeVodCertificateListResponseBodyCertificateListModelCertList CertList { get; set; }
            public class DescribeVodCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                [NameInMap("Cert")]
                [Validation(Required=false)]
                public List<DescribeVodCertificateListResponseBodyCertificateListModelCertListCert> Cert { get; set; }
                public class DescribeVodCertificateListResponseBodyCertificateListModelCertListCert : TeaModel {
                    [NameInMap("Algorithm")]
                    [Validation(Required=false)]
                    public string Algorithm { get; set; }

                    /// <summary>
                    /// The ID of the certificate.
                    /// </summary>
                    [NameInMap("CertId")]
                    [Validation(Required=false)]
                    public long? CertId { get; set; }

                    [NameInMap("CertIdentifier")]
                    [Validation(Required=false)]
                    public string CertIdentifier { get; set; }

                    /// <summary>
                    /// The name of the certificate.
                    /// </summary>
                    [NameInMap("CertName")]
                    [Validation(Required=false)]
                    public string CertName { get; set; }

                    /// <summary>
                    /// The common name of the certificate.
                    /// </summary>
                    [NameInMap("Common")]
                    [Validation(Required=false)]
                    public string Common { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("DomainMatchCert")]
                    [Validation(Required=false)]
                    public bool? DomainMatchCert { get; set; }

                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// The fingerprint of the certificate.
                    /// </summary>
                    [NameInMap("Fingerprint")]
                    [Validation(Required=false)]
                    public string Fingerprint { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// The certificate authority (CA) that issued the certificate.
                    /// </summary>
                    [NameInMap("Issuer")]
                    [Validation(Required=false)]
                    public string Issuer { get; set; }

                    /// <summary>
                    /// The time when the certificate was issued. Unit: seconds.
                    /// </summary>
                    [NameInMap("LastTime")]
                    [Validation(Required=false)]
                    public long? LastTime { get; set; }

                    [NameInMap("SignAlgorithm")]
                    [Validation(Required=false)]
                    public string SignAlgorithm { get; set; }

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

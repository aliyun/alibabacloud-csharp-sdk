// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnSMCertificateListResponseBody : TeaModel {
        /// <summary>
        /// The type of the certificate information.
        /// </summary>
        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeDcdnSMCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeDcdnSMCertificateListResponseBodyCertificateListModel : TeaModel {
            /// <summary>
            /// A list of certificates.
            /// </summary>
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public List<DescribeDcdnSMCertificateListResponseBodyCertificateListModelCertList> CertList { get; set; }
            public class DescribeDcdnSMCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                /// <summary>
                /// The ID of the certificate.
                /// </summary>
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

                /// <summary>
                /// The certificate authority (CA) that issued the certificate.
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

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

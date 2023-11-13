// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeCertsResponseBody : TeaModel {
        /// <summary>
        /// The certificate information about the website.
        /// </summary>
        [NameInMap("Certs")]
        [Validation(Required=false)]
        public List<DescribeCertsResponseBodyCerts> Certs { get; set; }
        public class DescribeCertsResponseBodyCerts : TeaModel {
            [NameInMap("CertIdentifier")]
            [Validation(Required=false)]
            public string CertIdentifier { get; set; }

            /// <summary>
            /// The domain name that is associated with the certificate.
            /// </summary>
            [NameInMap("Common")]
            [Validation(Required=false)]
            public string Common { get; set; }

            /// <summary>
            /// Indicates whether the certificate is associated with the domain name. Valid values:
            /// 
            /// *   **true**: The certificate is associated with the domain name.
            /// *   **false**: The certificate is not associated with the domain name.
            /// </summary>
            [NameInMap("DomainRelated")]
            [Validation(Required=false)]
            public bool? DomainRelated { get; set; }

            /// <summary>
            /// The expiration date of the certificate. string
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// The ID of the certificate.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// The certificate authority (CA) that issued the certificate.
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// The name of the certificate.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The issuance date of the certificate. string
            /// </summary>
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

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
            /// <summary>
            /// The global certificate ID, which is in the certificate ID-cn-hangzhou format. If the ID of the certificate is 123, CertIdentifier is 123-cn-hangzhou.
            /// </summary>
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
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("DomainRelated")]
            [Validation(Required=false)]
            public bool? DomainRelated { get; set; }

            /// <summary>
            /// The expiration date of the certificate. The value is a string.
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// The certificate ID.
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
            /// The issuance date of the certificate. The value is a string.
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

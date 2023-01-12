// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListListenerCertificatesResponseBody : TeaModel {
        /// <summary>
        /// Details about the certificates.
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<ListListenerCertificatesResponseBodyCertificates> Certificates { get; set; }
        public class ListListenerCertificatesResponseBodyCertificates : TeaModel {
            /// <summary>
            /// The ID of the certificate.
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

            /// <summary>
            /// The domain name associated with the additional certificate.
            /// 
            /// This parameter is not returned if the certificate is a default one.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// Indicates whether the certificate is a default one:
            /// 
            /// *   **true**: a default certificate
            /// *   **false**: an additional certificate
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// The state of the certificate.
            /// 
            /// *   **active**: The certificate is associated with a listener and takes effect.
            /// *   **updating**: The additional certificate is being replaced.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// The maximum number of entries returned.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the next query. Valid values:
        /// 
        /// *   If **NextToken** is not returned, it indicates that no additional results exist.
        /// *   If **NextToken** is returned, the value is the token that is used for the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

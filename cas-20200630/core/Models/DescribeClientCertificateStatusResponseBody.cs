// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeClientCertificateStatusResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the status information about the certificates.
        /// </summary>
        [NameInMap("CertificateStatus")]
        [Validation(Required=false)]
        public List<DescribeClientCertificateStatusResponseBodyCertificateStatus> CertificateStatus { get; set; }
        public class DescribeClientCertificateStatusResponseBodyCertificateStatus : TeaModel {
            /// <summary>
            /// The date on which the certificate was revoked.
            /// 
            /// >  This parameter is returned only when the value of the **Status** parameter is **revoked**. The value revoked indicates that the certificate is revoked.
            /// </summary>
            [NameInMap("RevokeTime")]
            [Validation(Required=false)]
            public long? RevokeTime { get; set; }

            /// <summary>
            /// The serial number of the certificate.
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// The status of the certificate. Valid values:
            /// 
            /// *   **good**: The certificate is not revoked.
            /// *   **revoked**: The certificate is revoked.
            /// *   **unknown**: The server cannot determine the status of the certificate.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

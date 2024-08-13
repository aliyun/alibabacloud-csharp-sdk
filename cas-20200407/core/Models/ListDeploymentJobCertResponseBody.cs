// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListDeploymentJobCertResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDeploymentJobCertResponseBodyData> Data { get; set; }
        public class ListDeploymentJobCertResponseBodyData : TeaModel {
            /// <summary>
            /// The algorithm of the certificate public key.
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// The ID of the certificate.
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public long? CertId { get; set; }

            /// <summary>
            /// The instance ID of the certificate.
            /// </summary>
            [NameInMap("CertInstanceId")]
            [Validation(Required=false)]
            public string CertInstanceId { get; set; }

            /// <summary>
            /// The name of the certificate.
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// The type of the certificate order. Valid values:
            /// 
            /// *   **upload**: uploaded certificate.
            /// *   **buy**: purchased certificate.
            /// *   **free**: free certificate. This value is available only on the China site (aliyun.com).
            /// </summary>
            [NameInMap("CertOrderType")]
            [Validation(Required=false)]
            public string CertOrderType { get; set; }

            /// <summary>
            /// The type of the certificate.
            /// </summary>
            [NameInMap("CertType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            /// <summary>
            /// The common name of the certificate.
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// Indicates whether the certificate is hosted. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("IsTrustee")]
            [Validation(Required=false)]
            public bool? IsTrustee { get; set; }

            /// <summary>
            /// The month in which the certificate is applied for.
            /// </summary>
            [NameInMap("Month")]
            [Validation(Required=false)]
            public int? Month { get; set; }

            /// <summary>
            /// The end time of the validity period of the certificate. The value is a timestamp in seconds.
            /// </summary>
            [NameInMap("NotAfterTime")]
            [Validation(Required=false)]
            public long? NotAfterTime { get; set; }

            /// <summary>
            /// The start time of the validity period of the certificate. The value is a timestamp in seconds.
            /// </summary>
            [NameInMap("NotBeforeTime")]
            [Validation(Required=false)]
            public long? NotBeforeTime { get; set; }

            /// <summary>
            /// The ID of the certificate order.
            /// 
            /// >  If CertId is returned, this parameter is not returned.
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// The subject alternative name (SAN) extensions of the certificate.
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public List<string> Sans { get; set; }

            /// <summary>
            /// The status code of the certificate. Valid values:
            /// 
            /// *   **payed**: paid and pending application
            /// *   **checking**: being validated
            /// *   **checkedFail**: validation failed
            /// *   **revoked**: revoked
            /// *   **revokeChecking**: revocation request being validated
            /// *   **issued**: issued (excluding hosted certificates that are issued, certificates that are about to expire, expired certificates, and uploaded certificates)
            /// *   **trustee**: hosted and issued
            /// *   **upload**: uploaded (excluding certificates that are about to expire and expired certificates)
            /// *   **willExpired**: about to expire (including certificates issued by using the Certificate Management Service console and uploaded certificates)
            /// *   **expired**: expired (including certificates issued by using the Certificate Management Service console and uploaded certificates)
            /// *   **validity**: valid (including certificates that are not expired or revoked)
            /// *   **refund**: refunded
            /// *   **closed**: closed
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

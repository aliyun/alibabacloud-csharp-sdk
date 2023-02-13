// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class GetCAInstanceStatusResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the status information about the private CA instance.
        /// </summary>
        [NameInMap("InstanceStatusList")]
        [Validation(Required=false)]
        public List<GetCAInstanceStatusResponseBodyInstanceStatusList> InstanceStatusList { get; set; }
        public class GetCAInstanceStatusResponseBodyInstanceStatusList : TeaModel {
            /// <summary>
            /// The expiration date of the private CA certificate. This value is a UNIX timestamp. Unit: milliseconds.
            /// 
            /// >  This parameter is returned only when the value of the **Status** parameter is **USED** or **REVOKE**. The value USED indicates that the private CA instance is enabled, and the value REVOKE indicates that the instance is revoked.
            /// </summary>
            [NameInMap("AfterTime")]
            [Validation(Required=false)]
            public long? AfterTime { get; set; }

            /// <summary>
            /// The issuance date of the private CA certificate. This value is a UNIX timestamp. Unit: milliseconds.
            /// 
            /// >  This parameter is returned only when the value of the **Status** parameter is **USED** or **REVOKE**. The value USED indicates that the private CA instance is enabled, and the value REVOKE indicates that the instance is revoked.
            /// </summary>
            [NameInMap("BeforeTime")]
            [Validation(Required=false)]
            public long? BeforeTime { get; set; }

            /// <summary>
            /// The number of certificates that are issued by using the private CA instance.
            /// </summary>
            [NameInMap("CertIssuedCount")]
            [Validation(Required=false)]
            public int? CertIssuedCount { get; set; }

            /// <summary>
            /// The number of certificates that can be issued by using the private CA instance.
            /// 
            /// For a private root CA instance whose **Type** is **ROOT**, this parameter indicates the number of intermediate CA certificates that can be issued. For a private intermediate CA instance whose **Type** is **SUB_ROOT**, this parameter indicates the total number of client certificates and server certificates that can be issued
            /// </summary>
            [NameInMap("CertTotalCount")]
            [Validation(Required=false)]
            public int? CertTotalCount { get; set; }

            /// <summary>
            /// The unique identifier of the private CA certificate.
            /// 
            /// >  This parameter is returned only when the value of the **Status** parameter is **USED** or **REVOKE**. The value USED indicates that the private CA instance is enabled, and the value REVOKE indicates that the instance is revoked.
            /// </summary>
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// The ID of the private CA instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The status of the private CA instance. Valid values:
            /// 
            /// *   **BUY**: The private CA instance is purchased but is not enabled.
            /// *   **USED**: The private CA instance is enabled.
            /// *   **REFUND**: The payment of the private CA instance is refunded.
            /// *   **REVOKE**: The private CA instance is revoked.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The type of the private CA instance. Valid values:
            /// 
            /// *   **ROOT**: root CA instance
            /// *   **SUB_ROOT**: intermediate CA instance
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The expiration date of the private CA instance. This value is a UNIX timestamp. Unit: milliseconds.
            /// 
            /// >  This parameter corresponds to the duration that you select when you purchase the private CA instance. The duration indicates the subscription period of the Private Certificate Authority (PCA) service.
            /// </summary>
            [NameInMap("UseExpireTime")]
            [Validation(Required=false)]
            public long? UseExpireTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

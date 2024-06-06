// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DiagnoseVpnConnectionsResponseBody : TeaModel {
        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The diagnostic information.
        /// </summary>
        [NameInMap("VpnConnections")]
        [Validation(Required=false)]
        public List<DiagnoseVpnConnectionsResponseBodyVpnConnections> VpnConnections { get; set; }
        public class DiagnoseVpnConnectionsResponseBodyVpnConnections : TeaModel {
            /// <summary>
            /// The cause of the error.
            /// </summary>
            [NameInMap("FailedReason")]
            [Validation(Required=false)]
            public string FailedReason { get; set; }

            /// <summary>
            /// The error code.
            /// </summary>
            [NameInMap("FailedReasonCode")]
            [Validation(Required=false)]
            public string FailedReasonCode { get; set; }

            /// <summary>
            /// The timestamp when the current error occurred on the IPsec-VPN connection. Unit: millisecond.
            /// 
            /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("FailedTime")]
            [Validation(Required=false)]
            public long? FailedTime { get; set; }

            /// <summary>
            /// If the values of the parameters configured for the IPsec-VPN connection and the peer gateway device do not match, this parameter indicates the value of the parameters configured for the IPsec-VPN connection.
            /// </summary>
            [NameInMap("MismatchLocalParam")]
            [Validation(Required=false)]
            public string MismatchLocalParam { get; set; }

            /// <summary>
            /// If the parameter values configured for the IPsec-VPN connection and the peer gateway device do not match, this parameter indicates the value of the parameter configured for the peer gateway device.
            /// </summary>
            [NameInMap("MismatchRemoteParam")]
            [Validation(Required=false)]
            public string MismatchRemoteParam { get; set; }

            /// <summary>
            /// The error level. Valid values:
            /// 
            /// *   **Critical**
            /// *   **Warn**
            /// *   **Normal**
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// The log information about the error.
            /// </summary>
            [NameInMap("SourceLog")]
            [Validation(Required=false)]
            public string SourceLog { get; set; }

            /// <summary>
            /// The tunnel ID.
            /// </summary>
            [NameInMap("TunnelId")]
            [Validation(Required=false)]
            public string TunnelId { get; set; }

            /// <summary>
            /// The ID of the IPsec-VPN connection.
            /// </summary>
            [NameInMap("VpnConnectionId")]
            [Validation(Required=false)]
            public string VpnConnectionId { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetVpnGatewayDiagnoseResultResponseBody : TeaModel {
        /// <summary>
        /// The time when the diagnostic started.
        /// 
        /// The time follows the ISO8601 standard in the `YYYY-MM-DDThh:mm:ssZ` format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public string BeginTime { get; set; }

        /// <summary>
        /// The ID of the diagnostic.
        /// </summary>
        [NameInMap("DiagnoseId")]
        [Validation(Required=false)]
        public string DiagnoseId { get; set; }

        /// <summary>
        /// The information about the diagnostic items.
        /// </summary>
        [NameInMap("DiagnoseResult")]
        [Validation(Required=false)]
        public List<GetVpnGatewayDiagnoseResultResponseBodyDiagnoseResult> DiagnoseResult { get; set; }
        public class GetVpnGatewayDiagnoseResultResponseBodyDiagnoseResult : TeaModel {
            /// <summary>
            /// The diagnostic item.
            /// 
            /// *   **RouteEntryConflict**: route conflicts.
            /// *   **VpnRouteQuota**: the quota of destination-based routes for the VPN gateway.
            /// *   **VpnIPsecQuota**: the quota of IPsec-VPN connections for the VPN gateway.
            /// *   **VpnPbrRouteQuota**: the quota of policy-based routes for the VPN gateway.
            /// *   **VcoConfigConsistency**: the consistency of the IPsec-VPN connection.
            /// *   **VcoUserInternetIpConnectivity**: Internet connectivity of the customer gateway.
            /// *   **VcoPrivateConnectivity**: private network connectivity.
            /// 
            /// For more information about the diagnostic items, see [Background information about quick diagnostics](~~190330~~).
            /// </summary>
            [NameInMap("DiagnoseName")]
            [Validation(Required=false)]
            public string DiagnoseName { get; set; }

            /// <summary>
            /// The diagnostic result.
            /// 
            /// The system returns different results for each diagnostic item.
            /// 
            /// *   **RouteEntryConflict**: information about route conflicts.
            /// 
            /// *   **VpnRouteQuota**:
            /// 
            ///     *   **quotaName**: the quota ID of destination-based routes.
            ///     *   **quantity**: the quota of destination-based routes for the VPN gateway.
            ///     *   **used**: the number of destination-based routes created for the VPN gateway.
            /// 
            /// *   **VpnIPsecQuota**:
            /// 
            ///     *   **quotaName**: the quota ID of IPsec-VPN connections.
            ///     *   **quantity**: the quota of IPsec-VPN connections for the VPN gateway.
            ///     *   **used**: the number of IPsec-VPN connections created for the VPN gateway.
            /// 
            /// *   **VpnPbrRouteQuota**:
            /// 
            ///     *   **quotaName**: the quota ID of policy-based routes.
            ///     *   **quantity**: the quota of policy-based routes for the VPN gateway.
            ///     *   **used**: the number of policy-based routes created for the VPN gateway.
            /// 
            /// *   **VcoConfigConsistency**:
            /// 
            ///     *   **vcoLackConf**: The system cannot obtain the configuration of the peer of the IPsec-VPN connection.
            ///     *   **vcoRunningConf**: the configurations that have been added to the peer of the IPsec-VPN connection.
            ///     *   **vcoDiffConf**: the configurations that are inconsistent between the local end and the peer.
            ///     *   **vcoConf**: the configurations that have been added to the local end.
            /// 
            /// *   **VcoUserInternetIpConnectivity**:
            /// 
            ///     *   **targetIp**: the public IP address of the customer gateway.
            ///     *   **rtt**: the latency when the system accesses the public IP address of the customer gateway. Unit: milliseconds.
            ///     *   **lossRate**: the packet loss when the system accesses the public IP address of the customer gateway.
            /// 
            /// *   **VcoPrivateConnectivity**:
            /// 
            ///     *   **targetIp**: the source IP address.
            ///     *   **srcIp**: the destination IP address.
            ///     *   **rtt**: the latency when the source IP address accesses the destination IP address. Unit: milliseconds.
            ///     *   **lossRate**: the packet loss when the source IP address accesses the destination IP address.
            /// </summary>
            [NameInMap("DiagnoseResultDescription")]
            [Validation(Required=false)]
            public string DiagnoseResultDescription { get; set; }

            /// <summary>
            /// The diagnostic result level.
            /// 
            /// *   **normal**
            /// *   **warning**
            /// *   **error**
            /// 
            /// For more information, see [Background information about quick diagnostics](~~190330~~).
            /// </summary>
            [NameInMap("DiagnoseResultLevel")]
            [Validation(Required=false)]
            public string DiagnoseResultLevel { get; set; }

        }

        /// <summary>
        /// The timestamp when the system finishes diagnosing the item.
        /// 
        /// The time follows the ISO8601 standard in the `YYYY-MM-DDThh:mm:ssZ` format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// The number of diagnostic items that have been diagnosed.
        /// </summary>
        [NameInMap("FinishedCount")]
        [Validation(Required=false)]
        public int? FinishedCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource that is diagnosed.
        /// </summary>
        [NameInMap("ResourceInstanceId")]
        [Validation(Required=false)]
        public string ResourceInstanceId { get; set; }

        /// <summary>
        /// The type of the resource.
        /// 
        /// The value is set to **IPsec**, which indicates an IPsec-VPN connection.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The total number of diagnostic items.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The ID of the VPN gateway.
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetTransitRouterFlowTopNRequest : TeaModel {
        /// <summary>
        /// The IDs of the member accounts.
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public List<long?> AccountIds { get; set; }

        /// <summary>
        /// The ID of the CEN bandwidth plan.
        /// </summary>
        [NameInMap("BandwithPackageId")]
        [Validation(Required=false)]
        public string BandwithPackageId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. The maximum time range that you can query is 24 hours.
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// The CEN instance ID.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The direction of the inter-region traffic in the local regions or for the local IP addresses. Valid values:
        /// 
        /// *   **in**: inbound traffic
        /// *   **out**: outbound traffic
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// The end of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. The maximum time range that you can query is 24 hours.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The dimension for ranking inter-region traffic data. The value of this parameter is case-sensitive. Valid values:
        /// 
        /// *   **1Tuple**: queries the rankings of inter-region traffic data for the local regions, Cloud Enterprise Network (CEN) instances, and IP addresses.
        /// *   **2Tuple**: queries the rankings of inter-region traffic data for the local and remote regions, and the local and remote IP addresses.
        /// *   **5Tuple**: queries the rankings of inter-region traffic data for the local and remote IP addresses, local and remote ports, and protocols.
        /// *   **Cen**: queries the rankings of inter-region traffic data for CEN instances.
        /// *   **RegionPair**: queries the rankings of inter-region traffic data for the local and remote regions.
        /// *   **Port**: queries the rankings of inter-region traffic data for the local and remote ports.
        /// *   **Protocol**: queries the rankings of inter-region traffic data for the protocols.
        /// </summary>
        [NameInMap("GroupBy")]
        [Validation(Required=false)]
        public string GroupBy { get; set; }

        /// <summary>
        /// The metric for ranking inter-region traffic data. Default value: Bytes. This value specifies that inter-region traffic data is ranked by traffic volume.
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The remote IP address.
        /// </summary>
        [NameInMap("OtherIp")]
        [Validation(Required=false)]
        public string OtherIp { get; set; }

        /// <summary>
        /// The remote port.
        /// </summary>
        [NameInMap("OtherPort")]
        [Validation(Required=false)]
        public string OtherPort { get; set; }

        /// <summary>
        /// The remote region.
        /// </summary>
        [NameInMap("OtherRegion")]
        [Validation(Required=false)]
        public string OtherRegion { get; set; }

        /// <summary>
        /// The protocol number.
        /// 
        /// >  All protocols are supported. This parameter is required only if you set **GroupBy** to **5Tuple** or **Protocol**.
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// The order for ranking inter-region traffic data. Valid values:
        /// 
        /// *   **desc**: descending order
        /// *   **asc**: ascending order
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// The local IP address.
        /// </summary>
        [NameInMap("ThisIp")]
        [Validation(Required=false)]
        public string ThisIp { get; set; }

        /// <summary>
        /// The local port.
        /// </summary>
        [NameInMap("ThisPort")]
        [Validation(Required=false)]
        public string ThisPort { get; set; }

        /// <summary>
        /// The local region where the **local IP address** resides.
        /// </summary>
        [NameInMap("ThisRegion")]
        [Validation(Required=false)]
        public string ThisRegion { get; set; }

        /// <summary>
        /// Specifies the maximum number of data entries to display. Default value: **10**. Maximum value: 100.
        /// </summary>
        [NameInMap("TopN")]
        [Validation(Required=false)]
        public int? TopN { get; set; }

        /// <summary>
        /// Specifies whether to enable the multi-account management feature. Default value: **false**. This value specifies that the multi-account management feature is disabled.
        /// 
        /// >  By default, the multi-account management feature is not available. If you want to use this feature, contact your account manager to apply for permissions.
        /// </summary>
        [NameInMap("UseMultiAccount")]
        [Validation(Required=false)]
        public bool? UseMultiAccount { get; set; }

    }

}

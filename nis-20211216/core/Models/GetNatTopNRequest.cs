// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetNatTopNRequest : TeaModel {
        /// <summary>
        /// The beginning of the time range to query in milliseconds. If you do not specify **EndTime**, the point in time specified by **BeginTime** is queried.
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// The end of the time range to query in milliseconds. The time range specified by **BeginTime** and **EndTime** cannot exceed **86400000** milliseconds (24 hours).
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// Query ranking statistics for a specific IP address. If you specify this parameter, you do not need to specify **TopN** or **OrderBy**.
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// The ID of the NAT gateway.
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// The metric that is used for real-time SNAT performance ranking. Valid values:
        /// 
        /// *   **InBps**: inbound data transfer. Unit: bit/s.
        /// *   **OutBps**: outbound data transfer. Unit: bit/s.
        /// *   **InPps**: inbound packet forwarding rate. Unit: packets per second.
        /// *   **OutPps**: outbound packet forwarding rate. Unit: packets per second.
        /// *   **NewSessionPerSecond**: new connection creation rate. Unit: connections per second.
        /// *   **ActiveSessionCount**: number of concurrent connections. Unit: connections.
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The ID of the region in which the NAT gateway is deployed.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The number of entries to return for real-time SNAT performance ranking. Valid values: **1 to 100**. Default value: **10**.
        /// </summary>
        [NameInMap("TopN")]
        [Validation(Required=false)]
        public int? TopN { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetTransitRouterFlowTopNResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ranking result of inter-region traffic data.
        /// </summary>
        [NameInMap("TransitRouterFlowTopN")]
        [Validation(Required=false)]
        public List<GetTransitRouterFlowTopNResponseBodyTransitRouterFlowTopN> TransitRouterFlowTopN { get; set; }
        public class GetTransitRouterFlowTopNResponseBodyTransitRouterFlowTopN : TeaModel {
            /// <summary>
            /// The account ID.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The ID of the CEN bandwidth plan.
            /// </summary>
            [NameInMap("BandwithPackageId")]
            [Validation(Required=false)]
            public string BandwithPackageId { get; set; }

            /// <summary>
            /// The total volume of traffic in the specified time range.
            /// </summary>
            [NameInMap("Bytes")]
            [Validation(Required=false)]
            public double? Bytes { get; set; }

            /// <summary>
            /// The CEN instance ID.
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// The end of the time range that you queried. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

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
            /// The remote region where the remote IP address resides.
            /// </summary>
            [NameInMap("OtherRegion")]
            [Validation(Required=false)]
            public string OtherRegion { get; set; }

            /// <summary>
            /// The total number of packets in the specified time range.
            /// </summary>
            [NameInMap("Packets")]
            [Validation(Required=false)]
            public double? Packets { get; set; }

            /// <summary>
            /// The protocol number.
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// The beginning of the time range that you queried. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

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
            /// The local region where the local IP address resides.
            /// </summary>
            [NameInMap("ThisRegion")]
            [Validation(Required=false)]
            public string ThisRegion { get; set; }

        }

    }

}

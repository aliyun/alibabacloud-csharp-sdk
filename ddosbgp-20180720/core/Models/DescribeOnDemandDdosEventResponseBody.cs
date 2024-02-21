// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeOnDemandDdosEventResponseBody : TeaModel {
        /// <summary>
        /// The list of DDoS events and the details of each event.
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<DescribeOnDemandDdosEventResponseBodyEvents> Events { get; set; }
        public class DescribeOnDemandDdosEventResponseBodyEvents : TeaModel {
            /// <summary>
            /// The timestamp that indicates the end time of the attack. Unit: seconds. The timestamp follows the UNIX time format. It is the number of seconds that have elapsed since 00:00:00 Thursday, 1 January 1970.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public int? EndTime { get; set; }

            /// <summary>
            /// The IP address of the protection target that encounters the DDoS attack.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The throughput of the DDoS attack. Unit: Mbit/s.
            /// </summary>
            [NameInMap("Mbps")]
            [Validation(Required=false)]
            public int? Mbps { get; set; }

            /// <summary>
            /// The packet forwarding rate of the DDoS attack. Unit: packets per second (PPS).
            /// </summary>
            [NameInMap("Pps")]
            [Validation(Required=false)]
            public int? Pps { get; set; }

            /// <summary>
            /// The timestamp that indicates the start time of the attack. Unit: seconds. The timestamp follows the UNIX time format. It is the number of seconds that have elapsed since 00:00:00 Thursday, 1 January 1970.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public int? StartTime { get; set; }

            /// <summary>
            /// The status of the event. Valid values:
            /// 
            /// *   **hole_begin **: indicates that the event is in the blackhole state.
            /// *   **hole_end **: indicates that blackhole ends.
            /// *   **defense_begin **: indicates that the event is in the cleaning state.
            /// *   **defense_end **: indicates that cleaning ends.
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

        /// <summary>
        /// The total number of DDoS events.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeOnDemandDdosEventResponseBody : TeaModel {
        /// <summary>
        /// The details about the DDoS attack event.
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<DescribeOnDemandDdosEventResponseBodyEvents> Events { get; set; }
        public class DescribeOnDemandDdosEventResponseBodyEvents : TeaModel {
            /// <summary>
            /// The time when the DDoS attack stopped. This value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public int? EndTime { get; set; }

            /// <summary>
            /// The attacked IP address.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The attack traffic. Unit: Mbit/s.
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
            /// The time when the DDoS attack started. This value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public int? StartTime { get; set; }

            /// <summary>
            /// The status of the DDoS attack event. Valid values:
            /// 
            /// *   **hole_begin**: indicates that blackhole filtering is triggered.
            /// *   **hole_end**: indicates that tblackhole filtering is deactivated.
            /// *   **defense_begin**: indicates that traffic scrubbing is in progress.
            /// *   **defense_end**: indicates that traffic scrubbing is complete.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of DDoS attack events that are returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}

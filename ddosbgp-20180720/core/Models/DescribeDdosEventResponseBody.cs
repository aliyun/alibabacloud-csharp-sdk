// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeDdosEventResponseBody : TeaModel {
        /// <summary>
        /// The details about the DDoS attack event.
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<DescribeDdosEventResponseBodyEvents> Events { get; set; }
        public class DescribeDdosEventResponseBodyEvents : TeaModel {
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
            /// The volume of the request traffic at the start of the DDoS attack. Unit: Mbit/s.
            /// </summary>
            [NameInMap("Mbps")]
            [Validation(Required=false)]
            public int? Mbps { get; set; }

            /// <summary>
            /// The number of packets at the start of the DDoS attack. Unit: packets per second (PPS).
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
            /// *   **hole_begin**: indicates that blackhole filtering is triggered for the attacked IP address.
            /// *   **hole_end**: indicates that blackhole filtering is deactivated for the attacked IP address.
            /// *   **defense_begin**: indicates that attack traffic is being scrubbed.
            /// *   **defense_end**: indicates that attack traffic is scrubbed.
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
        /// The total number of DDoS attack events.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}

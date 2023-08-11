// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeOnDemandDdosEventResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<DescribeOnDemandDdosEventResponseBodyEvents> Events { get; set; }
        public class DescribeOnDemandDdosEventResponseBodyEvents : TeaModel {
            /// <summary>
            /// The packet forwarding rate of the DDoS attack. Unit: packets per second (PPS).
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public int? EndTime { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("Mbps")]
            [Validation(Required=false)]
            public int? Mbps { get; set; }

            [NameInMap("Pps")]
            [Validation(Required=false)]
            public int? Pps { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public int? StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The timestamp that indicates the start time of the attack. Unit: seconds. The timestamp follows the UNIX time format. It is the number of seconds that have elapsed since 00:00:00 Thursday, 1 January 1970.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of DDoS events and the details of each event.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}

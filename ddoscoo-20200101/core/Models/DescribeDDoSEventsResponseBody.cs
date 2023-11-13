// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDoSEventsResponseBody : TeaModel {
        /// <summary>
        /// The DDoS attack events.
        /// </summary>
        [NameInMap("DDoSEvents")]
        [Validation(Required=false)]
        public List<DescribeDDoSEventsResponseBodyDDoSEvents> DDoSEvents { get; set; }
        public class DescribeDDoSEventsResponseBodyDDoSEvents : TeaModel {
            /// <summary>
            /// The bandwidth of attack traffic. Unit: bit/s.
            /// </summary>
            [NameInMap("Bps")]
            [Validation(Required=false)]
            public long? Bps { get; set; }

            /// <summary>
            /// The time when the DDoS attack stopped. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The type of the attack event. Valid values:
            /// 
            /// *   **defense**: traffic scrubbing events
            /// *   **blackhole**: blackhole filtering events
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// The attacked IP address.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The attacked port.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The packet forwarding rate of attack traffic. Unit: packets per second (pps).
            /// </summary>
            [NameInMap("Pps")]
            [Validation(Required=false)]
            public long? Pps { get; set; }

            /// <summary>
            /// The region from which the attack was launched. Valid values:
            /// 
            /// *   **cn**: a region in the Chinese mainland
            /// *   **alb-ap-northeast-1-gf-x**: Japan (Tokyo)
            /// *   **alb-ap-southeast-gf-x**: Singapore
            /// *   **alb-cn-hongkong-gf-x**: Hong Kong (China)
            /// *   **alb-eu-central-1-gf-x**: Germany (Frankfurt)
            /// *   **alb-us-west-1-gf-x**: US (Silicon Valley)
            /// 
            /// > The values except **cn** are returned only when **RegionId** is set to **ap-southeast-1**.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The time when the DDoS attack started. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned attack events.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}

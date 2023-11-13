// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortFlowListResponseBody : TeaModel {
        /// <summary>
        /// The returned traffic data.
        /// </summary>
        [NameInMap("PortFlowList")]
        [Validation(Required=false)]
        public List<DescribePortFlowListResponseBodyPortFlowList> PortFlowList { get; set; }
        public class DescribePortFlowListResponseBodyPortFlowList : TeaModel {
            /// <summary>
            /// The bandwidth of attack traffic. Unit: bit/s.
            /// </summary>
            [NameInMap("AttackBps")]
            [Validation(Required=false)]
            public long? AttackBps { get; set; }

            /// <summary>
            /// The packet forwarding rate of attack traffic. Unit: pps.
            /// </summary>
            [NameInMap("AttackPps")]
            [Validation(Required=false)]
            public long? AttackPps { get; set; }

            /// <summary>
            /// The inbound bandwidth. Unit: bit/s.
            /// </summary>
            [NameInMap("InBps")]
            [Validation(Required=false)]
            public long? InBps { get; set; }

            /// <summary>
            /// The packet forwarding rate of inbound traffic. Unit: packets per second.
            /// </summary>
            [NameInMap("InPps")]
            [Validation(Required=false)]
            public long? InPps { get; set; }

            /// <summary>
            /// The index number of the returned data.
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// The outbound bandwidth. Unit: bit/s.
            /// </summary>
            [NameInMap("OutBps")]
            [Validation(Required=false)]
            public long? OutBps { get; set; }

            /// <summary>
            /// The packet forwarding rate of outbound traffic. Unit: packets per second (pps).
            /// </summary>
            [NameInMap("OutPps")]
            [Validation(Required=false)]
            public long? OutPps { get; set; }

            /// <summary>
            /// The source region of the traffic. Valid values:
            /// 
            /// *   **cn**: mainland China
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

            [NameInMap("SlaBpsDropBps")]
            [Validation(Required=false)]
            public long? SlaBpsDropBps { get; set; }

            [NameInMap("SlaBpsDropPps")]
            [Validation(Required=false)]
            public long? SlaBpsDropPps { get; set; }

            [NameInMap("SlaConnDropBps")]
            [Validation(Required=false)]
            public long? SlaConnDropBps { get; set; }

            [NameInMap("SlaConnDropPps")]
            [Validation(Required=false)]
            public long? SlaConnDropPps { get; set; }

            [NameInMap("SlaCpsDropBps")]
            [Validation(Required=false)]
            public long? SlaCpsDropBps { get; set; }

            [NameInMap("SlaCpsDropPps")]
            [Validation(Required=false)]
            public long? SlaCpsDropPps { get; set; }

            [NameInMap("SlaPpsDropBps")]
            [Validation(Required=false)]
            public long? SlaPpsDropBps { get; set; }

            [NameInMap("SlaPpsDropPps")]
            [Validation(Required=false)]
            public long? SlaPpsDropPps { get; set; }

            /// <summary>
            /// The time when the data was collected. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeTrafficResponseBody : TeaModel {
        /// <summary>
        /// The queried traffic statistics.
        /// </summary>
        [NameInMap("FlowList")]
        [Validation(Required=false)]
        public List<DescribeTrafficResponseBodyFlowList> FlowList { get; set; }
        public class DescribeTrafficResponseBodyFlowList : TeaModel {
            /// <summary>
            /// The bandwidth of attack traffic. Unit: bit/s.
            /// 
            /// >  This parameter is returned only if attack traffic exists.
            /// </summary>
            [NameInMap("AttackBps")]
            [Validation(Required=false)]
            public long? AttackBps { get; set; }

            /// <summary>
            /// The packet forwarding rate of attack traffic. Unit: packets per second.
            /// 
            /// >  This parameter is returned only if attack traffic exists.
            /// </summary>
            [NameInMap("AttackPps")]
            [Validation(Required=false)]
            public long? AttackPps { get; set; }

            /// <summary>
            /// The type of the traffic statistics. Valid values:
            /// 
            /// *   **max**: the peak traffic within the specified interval
            /// *   **avg**: the average traffic within the specified interval
            /// </summary>
            [NameInMap("FlowType")]
            [Validation(Required=false)]
            public string FlowType { get; set; }

            /// <summary>
            /// The bandwidth of the total traffic. Unit: Kbit/s.
            /// </summary>
            [NameInMap("Kbps")]
            [Validation(Required=false)]
            public int? Kbps { get; set; }

            /// <summary>
            /// The ID of the traffic statistics.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The packet forwarding rate of the total traffic. Unit: packets per second.
            /// </summary>
            [NameInMap("Pps")]
            [Validation(Required=false)]
            public int? Pps { get; set; }

            /// <summary>
            /// The time when the traffic statistics are calculated. This value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public int? Time { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

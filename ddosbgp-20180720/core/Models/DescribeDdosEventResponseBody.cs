// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeDdosEventResponseBody : TeaModel {
        /// <summary>
        /// The number of packets at the start of the DDoS attack. Unit: packets per second (PPS).
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<DescribeDdosEventResponseBodyEvents> Events { get; set; }
        public class DescribeDdosEventResponseBodyEvents : TeaModel {
            /// <summary>
            /// All Alibaba Cloud API operations must include common request parameters. For more information about common request parameters, see [Common parameters](~~118841~~).
            /// 
            /// For more information about sample requests, see the **"Examples"** section of this topic.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public int? EndTime { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// WB269094
            /// </summary>
            [NameInMap("Mbps")]
            [Validation(Required=false)]
            public int? Mbps { get; set; }

            [NameInMap("Pps")]
            [Validation(Required=false)]
            public int? Pps { get; set; }

            /// <summary>
            /// DescribeDdosEvent
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public int? StartTime { get; set; }

            /// <summary>
            /// Queries the details about the DDoS attack events that occurred on a specific Anti-DDoS Origin instance.
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
        /// The time when the DDoS attack started. This value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}

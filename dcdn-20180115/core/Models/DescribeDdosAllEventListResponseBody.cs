// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDdosAllEventListResponseBody : TeaModel {
        /// <summary>
        /// The list of events.
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeDdosAllEventListResponseBodyDataList> DataList { get; set; }
        public class DescribeDdosAllEventListResponseBodyDataList : TeaModel {
            /// <summary>
            /// The peak attack traffic of volumetric attacks. Unit: bit/s.
            /// </summary>
            [NameInMap("Bps")]
            [Validation(Required=false)]
            public long? Bps { get; set; }

            /// <summary>
            /// The peak of connection flood attacks. Unit: connections per seconds (CPS).
            /// </summary>
            [NameInMap("Cps")]
            [Validation(Required=false)]
            public long? Cps { get; set; }

            /// <summary>
            /// The end of the time range during which data was queried. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The event ID.
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// The type of the DDoS attack event that was queried. Valid values:
            /// 
            /// *   **web-cc**: web resource exhaustion attacks
            /// *   **cc**: connection flood attacks
            /// *   **traffic**: volumetric attacks
            /// *   If you do not configure this parameter, DDoS attack events of all types are queried.
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// The peak attack traffic of volumetric attacks. Unit: packets per second (PPS).
            /// </summary>
            [NameInMap("Pps")]
            [Validation(Required=false)]
            public long? Pps { get; set; }

            /// <summary>
            /// The peak of web resource exhaustion attacks. Unit: queries per second (QPS).
            /// </summary>
            [NameInMap("Qps")]
            [Validation(Required=false)]
            public long? Qps { get; set; }

            /// <summary>
            /// The beginning of the time range during which data was queried. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The attack target.
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

        }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page. Default value: **10**. Valid values: 5, 10, and 20.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}

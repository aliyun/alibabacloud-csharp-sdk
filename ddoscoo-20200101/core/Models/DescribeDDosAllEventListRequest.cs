// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosAllEventListRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. The DDoS attack events occur before **EndTime** are queried. This value is a UNIX timestamp. Unit: seconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The type of the DDoS attack events you want to query. Valid values:
        /// 
        /// *   **web-cc**: resource exhaustion attacks
        /// *   **cc**: connection flood attacks
        /// *   **defense**: DDoS attacks that trigger traffic scrubbing
        /// *   **blackhole**: DDoS attacks that trigger blackhole filtering
        /// 
        /// If you want to query multiple types of DDoS attack events, separate them with commas (,).
        /// 
        /// If you do not configure this parameter, DDoS attack events of all types are queried.
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The DDoS attack events occur after **StartTime** are queried. This value is a UNIX timestamp. Unit: seconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskMonitorDataListResponseBody : TeaModel {
        /// <summary>
        /// The near real-time monitoring data of the disks.
        /// </summary>
        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public List<DescribeDiskMonitorDataListResponseBodyMonitorData> MonitorData { get; set; }
        public class DescribeDiskMonitorDataListResponseBodyMonitorData : TeaModel {
            /// <summary>
            /// The number of burst I/O operations.
            /// </summary>
            [NameInMap("BurstIOCount")]
            [Validation(Required=false)]
            public long? BurstIOCount { get; set; }

            /// <summary>
            /// The ID of the disk.
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// The beginning of the time range during which the performance of the disk bursts. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the `yyyy-MM-ddTHH:mm:ssZ` format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

        }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

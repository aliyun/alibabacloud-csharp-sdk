// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskMonitorDataResponseBody : TeaModel {
        /// <summary>
        /// The near real-time monitoring data of the disk.
        /// </summary>
        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public List<DescribeDiskMonitorDataResponseBodyMonitorData> MonitorData { get; set; }
        public class DescribeDiskMonitorDataResponseBodyMonitorData : TeaModel {
            /// <summary>
            /// The percentage of BPS.
            /// </summary>
            [NameInMap("BPSPercent")]
            [Validation(Required=false)]
            public long? BPSPercent { get; set; }

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
            /// The percentage of IOPS.
            /// </summary>
            [NameInMap("IOPSPercent")]
            [Validation(Required=false)]
            public long? IOPSPercent { get; set; }

            /// <summary>
            /// The read bandwidth of the disk. Unit: MByte/s.
            /// </summary>
            [NameInMap("ReadBPS")]
            [Validation(Required=false)]
            public long? ReadBPS { get; set; }

            /// <summary>
            /// Read IO block size. Unit: Bytes
            /// </summary>
            [NameInMap("ReadBlockSize")]
            [Validation(Required=false)]
            public long? ReadBlockSize { get; set; }

            /// <summary>
            /// The maximum number of read IOPS.
            /// </summary>
            [NameInMap("ReadIOPS")]
            [Validation(Required=false)]
            public long? ReadIOPS { get; set; }

            /// <summary>
            /// Read IO latency. Unit:  microsecond
            /// </summary>
            [NameInMap("ReadLatency")]
            [Validation(Required=false)]
            public long? ReadLatency { get; set; }

            /// <summary>
            /// The timestamp that is used to query the near real-time monitoring data of the disk. The time follows the [ISO 8601](~~25696~~) standard in the `yyyy-MM-ddTHH:mm:ssZ` format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// The write bandwidth of the disk. Unit: MByte/s.
            /// </summary>
            [NameInMap("WriteBPS")]
            [Validation(Required=false)]
            public long? WriteBPS { get; set; }

            /// <summary>
            /// Write IO block size. Unit: Bytes
            /// </summary>
            [NameInMap("WriteBlockSize")]
            [Validation(Required=false)]
            public long? WriteBlockSize { get; set; }

            /// <summary>
            /// The maximum number of write IOPS.
            /// </summary>
            [NameInMap("WriteIOPS")]
            [Validation(Required=false)]
            public long? WriteIOPS { get; set; }

            /// <summary>
            /// Write IO latency. Unit: microsecond
            /// </summary>
            [NameInMap("WriteLatency")]
            [Validation(Required=false)]
            public long? WriteLatency { get; set; }

        }

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

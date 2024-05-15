// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiskMonitorDataResponseBody : TeaModel {
        /// <summary>
        /// The monitoring data of the disk.
        /// </summary>
        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public DescribeDiskMonitorDataResponseBodyMonitorData MonitorData { get; set; }
        public class DescribeDiskMonitorDataResponseBodyMonitorData : TeaModel {
            [NameInMap("DiskMonitorData")]
            [Validation(Required=false)]
            public List<DescribeDiskMonitorDataResponseBodyMonitorDataDiskMonitorData> DiskMonitorData { get; set; }
            public class DescribeDiskMonitorDataResponseBodyMonitorDataDiskMonitorData : TeaModel {
                /// <summary>
                /// The read bandwidth of the disk. Unit: byte/s.
                /// </summary>
                [NameInMap("BPSRead")]
                [Validation(Required=false)]
                public int? BPSRead { get; set; }

                /// <summary>
                /// The total read and write bandwidth of the disk. Unit: byte/s.
                /// </summary>
                [NameInMap("BPSTotal")]
                [Validation(Required=false)]
                public int? BPSTotal { get; set; }

                /// <summary>
                /// The write bandwidth of the disk. Unit: byte/s.
                /// </summary>
                [NameInMap("BPSWrite")]
                [Validation(Required=false)]
                public int? BPSWrite { get; set; }

                /// <summary>
                /// The ID of the disk.
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// The number of read I/O operations per second on the disk.
                /// </summary>
                [NameInMap("IOPSRead")]
                [Validation(Required=false)]
                public int? IOPSRead { get; set; }

                /// <summary>
                /// The total number of read and write I/O operations per second on the disk.
                /// </summary>
                [NameInMap("IOPSTotal")]
                [Validation(Required=false)]
                public int? IOPSTotal { get; set; }

                /// <summary>
                /// The number of write I/O operations per second on the disk.
                /// </summary>
                [NameInMap("IOPSWrite")]
                [Validation(Required=false)]
                public int? IOPSWrite { get; set; }

                /// <summary>
                /// The read latency of the disk. Unit: microseconds.
                /// </summary>
                [NameInMap("LatencyRead")]
                [Validation(Required=false)]
                public int? LatencyRead { get; set; }

                /// <summary>
                /// The write latency of the disk. Unit: microseconds.
                /// </summary>
                [NameInMap("LatencyWrite")]
                [Validation(Required=false)]
                public int? LatencyWrite { get; set; }

                /// <summary>
                /// The timestamp of the monitoring data. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned monitoring data entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

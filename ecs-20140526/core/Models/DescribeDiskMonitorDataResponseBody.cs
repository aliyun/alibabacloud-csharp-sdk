// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiskMonitorDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The monitoring data of the disk.</para>
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
                /// <para>The read bandwidth of the disk. Unit: byte/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BPSRead")]
                [Validation(Required=false)]
                public int? BPSRead { get; set; }

                /// <summary>
                /// <para>The total read and write bandwidth of the disk. Unit: byte/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>204</para>
                /// </summary>
                [NameInMap("BPSTotal")]
                [Validation(Required=false)]
                public int? BPSTotal { get; set; }

                /// <summary>
                /// <para>The write bandwidth of the disk. Unit: byte/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>204</para>
                /// </summary>
                [NameInMap("BPSWrite")]
                [Validation(Required=false)]
                public int? BPSWrite { get; set; }

                /// <summary>
                /// <para>The ID of the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-bp1bq5g3dxxo1x4o****</para>
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// <para>The number of read I/O operations per second on the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IOPSRead")]
                [Validation(Required=false)]
                public int? IOPSRead { get; set; }

                /// <summary>
                /// <para>The total number of read and write I/O operations per second on the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IOPSTotal")]
                [Validation(Required=false)]
                public int? IOPSTotal { get; set; }

                /// <summary>
                /// <para>The number of write I/O operations per second on the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IOPSWrite")]
                [Validation(Required=false)]
                public int? IOPSWrite { get; set; }

                /// <summary>
                /// <para>The read latency of the disk. Unit: microseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LatencyRead")]
                [Validation(Required=false)]
                public int? LatencyRead { get; set; }

                /// <summary>
                /// <para>The write latency of the disk. Unit: microseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LatencyWrite")]
                [Validation(Required=false)]
                public int? LatencyWrite { get; set; }

                /// <summary>
                /// <para>The timestamp of the monitoring data. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2014-07-23T12:07:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned monitoring data entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

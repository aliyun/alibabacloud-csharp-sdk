// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskMonitorDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The near real-time monitoring data of the disk.</para>
        /// </summary>
        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public List<DescribeDiskMonitorDataResponseBodyMonitorData> MonitorData { get; set; }
        public class DescribeDiskMonitorDataResponseBodyMonitorData : TeaModel {
            /// <summary>
            /// <para>The percentage of BPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80(%)</para>
            /// </summary>
            [NameInMap("BPSPercent")]
            [Validation(Required=false)]
            public long? BPSPercent { get; set; }

            /// <summary>
            /// <para>The number of burst I/O operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BurstIOCount")]
            [Validation(Required=false)]
            public long? BurstIOCount { get; set; }

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
            /// <para>The percentage of IOPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80(%)</para>
            /// </summary>
            [NameInMap("IOPSPercent")]
            [Validation(Required=false)]
            public long? IOPSPercent { get; set; }

            /// <summary>
            /// <para>The read bandwidth of the disk. Unit: MByte/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ReadBPS")]
            [Validation(Required=false)]
            public long? ReadBPS { get; set; }

            /// <summary>
            /// <para>Read IO block size. Unit: Bytes</para>
            /// 
            /// <b>Example:</b>
            /// <para>4096</para>
            /// </summary>
            [NameInMap("ReadBlockSize")]
            [Validation(Required=false)]
            public long? ReadBlockSize { get; set; }

            /// <summary>
            /// <para>The maximum number of read IOPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("ReadIOPS")]
            [Validation(Required=false)]
            public long? ReadIOPS { get; set; }

            /// <summary>
            /// <para>Read IO latency. Unit:  microsecond</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ReadLatency")]
            [Validation(Required=false)]
            public long? ReadLatency { get; set; }

            /// <summary>
            /// <para>The timestamp that is used to query the near real-time monitoring data of the disk. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-06-01T08:00:00Z</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// <para>The write bandwidth of the disk. Unit: MByte/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>204</para>
            /// </summary>
            [NameInMap("WriteBPS")]
            [Validation(Required=false)]
            public long? WriteBPS { get; set; }

            /// <summary>
            /// <para>Write IO block size. Unit: Bytes</para>
            /// 
            /// <b>Example:</b>
            /// <para>4096</para>
            /// </summary>
            [NameInMap("WriteBlockSize")]
            [Validation(Required=false)]
            public long? WriteBlockSize { get; set; }

            /// <summary>
            /// <para>The maximum number of write IOPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("WriteIOPS")]
            [Validation(Required=false)]
            public long? WriteIOPS { get; set; }

            /// <summary>
            /// <para>Write IO latency. Unit: microsecond</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("WriteLatency")]
            [Validation(Required=false)]
            public long? WriteLatency { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDiskIopsListResponseBody : TeaModel {
        /// <summary>
        /// <para>The IOPS monitoring data of the cloud disk.</para>
        /// </summary>
        [NameInMap("DiskIopsList")]
        [Validation(Required=false)]
        public List<DescribeDiskIopsListResponseBodyDiskIopsList> DiskIopsList { get; set; }
        public class DescribeDiskIopsListResponseBodyDiskIopsList : TeaModel {
            /// <summary>
            /// <para>The business time . The time is displayed in the yyyy-MM-dd HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-14 00:00:00</para>
            /// </summary>
            [NameInMap("BizTime")]
            [Validation(Required=false)]
            public string BizTime { get; set; }

            /// <summary>
            /// <para>The ID of the disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-5tzm9wnhzlhjzcbtxo465****</para>
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// <para>The read throughput. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10054</para>
            /// </summary>
            [NameInMap("ReadBytes")]
            [Validation(Required=false)]
            public long? ReadBytes { get; set; }

            /// <summary>
            /// <para>The read latency. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15646532</para>
            /// </summary>
            [NameInMap("ReadLatency")]
            [Validation(Required=false)]
            public long? ReadLatency { get; set; }

            /// <summary>
            /// <para>The read IOPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("ReadOps")]
            [Validation(Required=false)]
            public long? ReadOps { get; set; }

            /// <summary>
            /// <para>The ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-3</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The write throughput. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WriteBytes")]
            [Validation(Required=false)]
            public long? WriteBytes { get; set; }

            /// <summary>
            /// <para>The write latency. Unit: microseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WriteLatency")]
            [Validation(Required=false)]
            public long? WriteLatency { get; set; }

            /// <summary>
            /// <para>The write IOPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WriteOps")]
            [Validation(Required=false)]
            public long? WriteOps { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7814CAB-DB4E-140A-9D6F-7C8210C1DAC3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

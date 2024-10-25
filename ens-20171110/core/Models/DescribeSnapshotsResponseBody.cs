// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSnapshotsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9635ED2E-3103-1606-84D4-9F8E816B19F9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the snapshots.</para>
        /// </summary>
        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public List<DescribeSnapshotsResponseBodySnapshots> Snapshots { get; set; }
        public class DescribeSnapshotsResponseBodySnapshots : TeaModel {
            /// <summary>
            /// <para>The creation time. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-08-20T14:52:28Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the edge node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-15</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The capacity of the disk. Unit: MiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// <para>The ID of the snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// <para>The name of the snapshot. This parameter is returned only if a snapshot name was specified when the snapshot was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testSnapshotName</para>
            /// </summary>
            [NameInMap("SnapshotName")]
            [Validation(Required=false)]
            public string SnapshotName { get; set; }

            /// <summary>
            /// <para>The type of the disk. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: ultra disk</description></item>
            /// <item><description>cloud_ssd: all-flash disk</description></item>
            /// <item><description>local_hdd: local HDD</description></item>
            /// <item><description>local_ssd: local SSD</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_efficiency</para>
            /// </summary>
            [NameInMap("SourceDiskCategory")]
            [Validation(Required=false)]
            public string SourceDiskCategory { get; set; }

            /// <summary>
            /// <para>The ID of the source disk. This parameter is retained even after the source disk for which the snapshot was created is released.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-bp67acfmxazb4ph****</para>
            /// </summary>
            [NameInMap("SourceDiskId")]
            [Validation(Required=false)]
            public string SourceDiskId { get; set; }

            /// <summary>
            /// <para>The type of the disk. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>1: system disk</description></item>
            /// <item><description>2: data disk</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SourceDiskType")]
            [Validation(Required=false)]
            public string SourceDiskType { get; set; }

            /// <summary>
            /// <para>The ID of the source edge node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-27</para>
            /// </summary>
            [NameInMap("SourceEnsRegionId")]
            [Validation(Required=false)]
            public string SourceEnsRegionId { get; set; }

            /// <summary>
            /// <para>The ID of the source snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-bpdfer893jfkdqe****</para>
            /// </summary>
            [NameInMap("SourceSnapshotId")]
            [Validation(Required=false)]
            public string SourceSnapshotId { get; set; }

            /// <summary>
            /// <para>The status of the snapshot. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>creating: The snapshot is being created.</description></item>
            /// <item><description>Available: The snapshot is available.</description></item>
            /// <item><description>deleting: The snapshot is being deleted.</description></item>
            /// <item><description>error: An error occurred on the snapshot.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The total number of snapshots.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

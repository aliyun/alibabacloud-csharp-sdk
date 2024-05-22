// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSnapshotsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
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
        /// The information about the snapshots.
        /// </summary>
        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public List<DescribeSnapshotsResponseBodySnapshots> Snapshots { get; set; }
        public class DescribeSnapshotsResponseBodySnapshots : TeaModel {
            /// <summary>
            /// The creation time. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The description of the snapshot.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the edge node.
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// The capacity of the disk. Unit: MiB.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// The ID of the snapshot.
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// The name of the snapshot. This parameter is returned only if a snapshot name was specified when the snapshot was created.
            /// </summary>
            [NameInMap("SnapshotName")]
            [Validation(Required=false)]
            public string SnapshotName { get; set; }

            /// <summary>
            /// The type of the disk. Valid value:
            /// 
            /// *   cloud_efficiency: ultra disk
            /// *   cloud_ssd: all-flash disk
            /// *   local_hdd: local HDD
            /// *   local_ssd: local SSD
            /// </summary>
            [NameInMap("SourceDiskCategory")]
            [Validation(Required=false)]
            public string SourceDiskCategory { get; set; }

            /// <summary>
            /// The ID of the source disk. This parameter is retained even after the source disk for which the snapshot was created is released.
            /// </summary>
            [NameInMap("SourceDiskId")]
            [Validation(Required=false)]
            public string SourceDiskId { get; set; }

            /// <summary>
            /// The type of the disk. Valid value:
            /// 
            /// *   1: system disk
            /// *   2: data disk
            /// </summary>
            [NameInMap("SourceDiskType")]
            [Validation(Required=false)]
            public string SourceDiskType { get; set; }

            /// <summary>
            /// The ID of the source edge node.
            /// </summary>
            [NameInMap("SourceEnsRegionId")]
            [Validation(Required=false)]
            public string SourceEnsRegionId { get; set; }

            /// <summary>
            /// The ID of the source snapshot.
            /// </summary>
            [NameInMap("SourceSnapshotId")]
            [Validation(Required=false)]
            public string SourceSnapshotId { get; set; }

            /// <summary>
            /// The status of the snapshot. Valid value:
            /// 
            /// *   creating: The snapshot is being created.
            /// *   Available: The snapshot is available.
            /// *   deleting: The snapshot is being deleted.
            /// *   error: An error occurred on the snapshot.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The total number of snapshots.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

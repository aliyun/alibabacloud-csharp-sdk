// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeSnapshotsResponseBody : TeaModel {
        /// <summary>
        /// The page number.
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
        /// The details about snapshots.
        /// </summary>
        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public DescribeSnapshotsResponseBodySnapshots Snapshots { get; set; }
        public class DescribeSnapshotsResponseBodySnapshots : TeaModel {
            [NameInMap("Snapshot")]
            [Validation(Required=false)]
            public List<DescribeSnapshotsResponseBodySnapshotsSnapshot> Snapshot { get; set; }
            public class DescribeSnapshotsResponseBodySnapshotsSnapshot : TeaModel {
                /// <summary>
                /// The time when the snapshot was created.
                /// 
                /// The time follows the [ISO 8601](https://www.iso.org/iso-8601-date-and-time-format.html) standard in UTC. The time is displayed in the `yyyy-MM-ddThh:mmZ` format.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The description of the snapshot.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// Indicates whether the snapshot is encrypted.
                /// 
                /// Valid values:
                /// 
                /// *   0: The snapshot is not encrypted.
                /// *   1: The snapshot is encrypted.
                /// </summary>
                [NameInMap("EncryptType")]
                [Validation(Required=false)]
                public int? EncryptType { get; set; }

                /// <summary>
                /// The type of the file system.
                /// </summary>
                [NameInMap("FileSystemType")]
                [Validation(Required=false)]
                public string FileSystemType { get; set; }

                /// <summary>
                /// The progress of the snapshot creation. The value of this parameter is expressed as a percentage.
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// The remaining time that is required to create the snapshot.
                /// 
                /// Unit: seconds.
                /// </summary>
                [NameInMap("RemainTime")]
                [Validation(Required=false)]
                public int? RemainTime { get; set; }

                /// <summary>
                /// The retention period of the auto snapshot.
                /// 
                /// Unit: days.
                /// 
                /// Valid values:
                /// 
                /// *   \\-1: Auto snapshots are permanently retained. After the number of auto snapshots exceeds the upper limit, the earliest auto snapshot is automatically deleted.
                /// *   1 to 65536: Auto snapshots are retained for the specified days. After the retention period of auto snapshots expires, the auto snapshots are automatically deleted.
                /// </summary>
                [NameInMap("RetentionDays")]
                [Validation(Required=false)]
                public int? RetentionDays { get; set; }

                /// <summary>
                /// The snapshot ID.
                /// </summary>
                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

                /// <summary>
                /// The snapshot name.
                /// 
                /// If you specify a name to create a snapshot, the name of the snapshot is returned. Otherwise, no value is returned for this parameter.
                /// </summary>
                [NameInMap("SnapshotName")]
                [Validation(Required=false)]
                public string SnapshotName { get; set; }

                /// <summary>
                /// The snapshot type. Valid values:
                /// 
                /// *   auto: automatically created snapshots
                /// *   user: manually created snapshots
                /// </summary>
                [NameInMap("SnapshotType")]
                [Validation(Required=false)]
                public string SnapshotType { get; set; }

                /// <summary>
                /// The ID of the source file system.
                /// 
                /// This parameter is retained even if the source file system of the snapshot is deleted.
                /// </summary>
                [NameInMap("SourceFileSystemId")]
                [Validation(Required=false)]
                public string SourceFileSystemId { get; set; }

                /// <summary>
                /// The capacity of the source file system.
                /// 
                /// Unit: GiB.
                /// </summary>
                [NameInMap("SourceFileSystemSize")]
                [Validation(Required=false)]
                public long? SourceFileSystemSize { get; set; }

                /// <summary>
                /// The version of the source file system.
                /// </summary>
                [NameInMap("SourceFileSystemVersion")]
                [Validation(Required=false)]
                public string SourceFileSystemVersion { get; set; }

                /// <summary>
                /// The status of the snapshot.
                /// 
                /// Valid values:
                /// 
                /// *   progressing: The snapshot is being created.
                /// *   accomplished: The snapshot is created.
                /// *   failed: The snapshot fails to be created.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The total number of snapshots returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

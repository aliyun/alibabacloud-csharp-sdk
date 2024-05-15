// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSnapshotsResponseBody : TeaModel {
        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// The information about the snapshots.
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
                /// Indicates whether the snapshot can be used to create or roll back disks. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("Available")]
                [Validation(Required=false)]
                public bool? Available { get; set; }

                /// <summary>
                /// The category of the snapshot.
                /// 
                /// >  This parameter will be removed in the future. We recommend that you use `InstantAccess` to ensure future compatibility.
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The time when the snapshot was created. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
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
                /// Indicates whether the snapshot is encrypted.
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public bool? Encrypted { get; set; }

                /// <summary>
                /// Indicates whether the instant access feature is enabled. Valid values:
                /// 
                /// *   true: The instant access feature is enabled. The instant access feature can be enabled only for enhanced SSDs (ESSDs).
                /// *   false: The instant access feature is disabled. The snapshot is a normal snapshot for which the instant access feature is disabled.
                /// </summary>
                [NameInMap("InstantAccess")]
                [Validation(Required=false)]
                public bool? InstantAccess { get; set; }

                /// <summary>
                /// Indicates the validity period of the instant access feature. When the specified period expires, the instant access feature is automatically disabled.
                /// 
                /// By default, the value of this parameter is the same as the value of `RetentionDays`.
                /// </summary>
                [NameInMap("InstantAccessRetentionDays")]
                [Validation(Required=false)]
                public int? InstantAccessRetentionDays { get; set; }

                /// <summary>
                /// The ID of the Key Management Service (KMS) key used for the data disk.
                /// </summary>
                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                /// <summary>
                /// The time when the snapshot was last changed. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("LastModifiedTime")]
                [Validation(Required=false)]
                public string LastModifiedTime { get; set; }

                /// <summary>
                /// The product code of the Alibaba Cloud Marketplace image.
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// The progress of the snapshot creation task. Unit: percent (%).
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// The ID of the region to which the snapshot belongs.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The amount of remaining time required to create the snapshot. Unit: seconds.
                /// </summary>
                [NameInMap("RemainTime")]
                [Validation(Required=false)]
                public int? RemainTime { get; set; }

                /// <summary>
                /// The resource group ID to which the snapshot belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The retention period of the automatic snapshot. Unit: days.
                /// </summary>
                [NameInMap("RetentionDays")]
                [Validation(Required=false)]
                public int? RetentionDays { get; set; }

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
                /// The serial number of the snapshot.
                /// </summary>
                [NameInMap("SnapshotSN")]
                [Validation(Required=false)]
                public string SnapshotSN { get; set; }

                /// <summary>
                /// The type of snapshot. Valid values:
                /// 
                /// *   auto or timer: automatic snapshot
                /// *   user: manual snapshot
                /// *   all: all snapshot types
                /// </summary>
                [NameInMap("SnapshotType")]
                [Validation(Required=false)]
                public string SnapshotType { get; set; }

                /// <summary>
                /// The ID of the source disk. This parameter is retained even after the source disk is released.
                /// </summary>
                [NameInMap("SourceDiskId")]
                [Validation(Required=false)]
                public string SourceDiskId { get; set; }

                /// <summary>
                /// The capacity of the source disk. Unit: GiB.
                /// </summary>
                [NameInMap("SourceDiskSize")]
                [Validation(Required=false)]
                public string SourceDiskSize { get; set; }

                /// <summary>
                /// The type of the source disk. Valid values:
                /// 
                /// *   system
                /// *   data
                /// </summary>
                [NameInMap("SourceDiskType")]
                [Validation(Required=false)]
                public string SourceDiskType { get; set; }

                /// <summary>
                /// The region ID of the source snapshot.
                /// </summary>
                [NameInMap("SourceRegionId")]
                [Validation(Required=false)]
                public string SourceRegionId { get; set; }

                /// <summary>
                /// The ID of the source snapshot.
                /// </summary>
                [NameInMap("SourceSnapshotId")]
                [Validation(Required=false)]
                public string SourceSnapshotId { get; set; }

                /// <summary>
                /// The category of the source disk.
                /// 
                /// >  This parameter will be removed in the future. We recommend that you use other parameters to ensure future compatibility.
                /// </summary>
                [NameInMap("SourceStorageType")]
                [Validation(Required=false)]
                public string SourceStorageType { get; set; }

                /// <summary>
                /// The state of the snapshot. Valid values:
                /// 
                /// *   progressing
                /// *   accomplished
                /// *   failed
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tags of the snapshot.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeSnapshotsResponseBodySnapshotsSnapshotTags Tags { get; set; }
                public class DescribeSnapshotsResponseBodySnapshotsSnapshotTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeSnapshotsResponseBodySnapshotsSnapshotTagsTag> Tag { get; set; }
                    public class DescribeSnapshotsResponseBodySnapshotsSnapshotTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key of the snapshot.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value of the snapshot.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// Indicates whether the snapshot has been used to create images or disks. Valid values:
                /// 
                /// *   image
                /// *   disk
                /// *   image_disk
                /// *   none
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

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

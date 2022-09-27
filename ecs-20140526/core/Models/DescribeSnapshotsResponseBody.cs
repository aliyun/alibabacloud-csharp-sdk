// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSnapshotsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public DescribeSnapshotsResponseBodySnapshots Snapshots { get; set; }
        public class DescribeSnapshotsResponseBodySnapshots : TeaModel {
            [NameInMap("Snapshot")]
            [Validation(Required=false)]
            public List<DescribeSnapshotsResponseBodySnapshotsSnapshot> Snapshot { get; set; }
            public class DescribeSnapshotsResponseBodySnapshotsSnapshot : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public bool? Encrypted { get; set; }

                [NameInMap("InstantAccess")]
                [Validation(Required=false)]
                public bool? InstantAccess { get; set; }

                [NameInMap("InstantAccessRetentionDays")]
                [Validation(Required=false)]
                public int? InstantAccessRetentionDays { get; set; }

                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                [NameInMap("LastModifiedTime")]
                [Validation(Required=false)]
                public string LastModifiedTime { get; set; }

                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                [NameInMap("RemainTime")]
                [Validation(Required=false)]
                public int? RemainTime { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("RetentionDays")]
                [Validation(Required=false)]
                public int? RetentionDays { get; set; }

                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

                [NameInMap("SnapshotName")]
                [Validation(Required=false)]
                public string SnapshotName { get; set; }

                [NameInMap("SnapshotSN")]
                [Validation(Required=false)]
                public string SnapshotSN { get; set; }

                [NameInMap("SnapshotType")]
                [Validation(Required=false)]
                public string SnapshotType { get; set; }

                [NameInMap("SourceDiskId")]
                [Validation(Required=false)]
                public string SourceDiskId { get; set; }

                [NameInMap("SourceDiskSize")]
                [Validation(Required=false)]
                public string SourceDiskSize { get; set; }

                [NameInMap("SourceDiskType")]
                [Validation(Required=false)]
                public string SourceDiskType { get; set; }

                [NameInMap("SourceRegionId")]
                [Validation(Required=false)]
                public string SourceRegionId { get; set; }

                [NameInMap("SourceSnapshotId")]
                [Validation(Required=false)]
                public string SourceSnapshotId { get; set; }

                [NameInMap("SourceStorageType")]
                [Validation(Required=false)]
                public string SourceStorageType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeSnapshotsResponseBodySnapshotsSnapshotTags Tags { get; set; }
                public class DescribeSnapshotsResponseBodySnapshotsSnapshotTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeSnapshotsResponseBodySnapshotsSnapshotTagsTag> Tag { get; set; }
                    public class DescribeSnapshotsResponseBodySnapshotsSnapshotTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                [NameInMap("Usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

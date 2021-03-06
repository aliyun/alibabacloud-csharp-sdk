// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSnapshotsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public DescribeSnapshotsResponseBodySnapshots Snapshots { get; set; }
        public class DescribeSnapshotsResponseBodySnapshots : TeaModel {
            [NameInMap("Snapshot")]
            [Validation(Required=false)]
            public List<DescribeSnapshotsResponseBodySnapshotsSnapshot> Snapshot { get; set; }
            public class DescribeSnapshotsResponseBodySnapshotsSnapshot : TeaModel {
                public string CreationTime { get; set; }
                public string Status { get; set; }
                public bool? InstantAccess { get; set; }
                public int? RetentionDays { get; set; }
                public string SourceDiskSize { get; set; }
                public DescribeSnapshotsResponseBodySnapshotsSnapshotTags Tags { get; set; }
                public class DescribeSnapshotsResponseBodySnapshotsSnapshotTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeSnapshotsResponseBodySnapshotsSnapshotTagsTag> Tag { get; set; }
                    public class DescribeSnapshotsResponseBodySnapshotsSnapshotTagsTag : TeaModel {
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                    }

                }
                public string LastModifiedTime { get; set; }
                public bool? Encrypted { get; set; }
                public string SourceDiskId { get; set; }
                public string Description { get; set; }
                public int? InstantAccessRetentionDays { get; set; }
                public string KMSKeyId { get; set; }
                public string Progress { get; set; }
                public int? RemainTime { get; set; }
                public string SourceDiskType { get; set; }
                public string SourceStorageType { get; set; }
                public string Usage { get; set; }
                public string SnapshotType { get; set; }
                public string SnapshotName { get; set; }
                public string SnapshotId { get; set; }
                public string ResourceGroupId { get; set; }
                public string Category { get; set; }
                public string SnapshotSN { get; set; }
                public string ProductCode { get; set; }
            }
        };

    }

}

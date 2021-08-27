// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSnapshotGroupsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnapshotGroups")]
        [Validation(Required=false)]
        public DescribeSnapshotGroupsResponseBodySnapshotGroups SnapshotGroups { get; set; }
        public class DescribeSnapshotGroupsResponseBodySnapshotGroups : TeaModel {
            [NameInMap("SnapshotGroup")]
            [Validation(Required=false)]
            public List<DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroup> SnapshotGroup { get; set; }
            public class DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroup : TeaModel {
                public string Status { get; set; }
                public string CreationTime { get; set; }
                public string Description { get; set; }
                public string ProgressStatus { get; set; }
                public string SnapshotGroupId { get; set; }
                public string InstanceId { get; set; }
                public string Name { get; set; }
                public DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupSnapshots Snapshots { get; set; }
                public class DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupSnapshots : TeaModel {
                    [NameInMap("Snapshot")]
                    [Validation(Required=false)]
                    public List<DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupSnapshotsSnapshot> Snapshot { get; set; }
                    public class DescribeSnapshotGroupsResponseBodySnapshotGroupsSnapshotGroupSnapshotsSnapshot : TeaModel {
                        [NameInMap("SourceDiskId")]
                        [Validation(Required=false)]
                        public string SourceDiskId { get; set; }

                        [NameInMap("Progress")]
                        [Validation(Required=false)]
                        public string Progress { get; set; }

                        [NameInMap("InstantAccessRetentionDays")]
                        [Validation(Required=false)]
                        public int? InstantAccessRetentionDays { get; set; }

                        [NameInMap("SnapshotId")]
                        [Validation(Required=false)]
                        public string SnapshotId { get; set; }

                        [NameInMap("InstantAccess")]
                        [Validation(Required=false)]
                        public bool? InstantAccess { get; set; }

                        [NameInMap("SourceDiskType")]
                        [Validation(Required=false)]
                        public string SourceDiskType { get; set; }

                    }

                }
            }
        };

    }

}

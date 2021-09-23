// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeSnapshotsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public DescribeSnapshotsResponseBodySnapshots Snapshots { get; set; }
        public class DescribeSnapshotsResponseBodySnapshots : TeaModel {
            [NameInMap("Snapshot")]
            [Validation(Required=false)]
            public List<DescribeSnapshotsResponseBodySnapshotsSnapshot> Snapshot { get; set; }
            public class DescribeSnapshotsResponseBodySnapshotsSnapshot : TeaModel {
                public string Status { get; set; }
                public string Progress { get; set; }
                public string CreateTime { get; set; }
                public string SourceFileSystemId { get; set; }
                public int? RemainTime { get; set; }
                public int? RetentionDays { get; set; }
                public long? SourceFileSystemSize { get; set; }
                public string SnapshotName { get; set; }
                public string SourceFileSystemVersion { get; set; }
                public int? EncryptType { get; set; }
                public string Description { get; set; }
                public string SnapshotId { get; set; }
            }
        };

    }

}

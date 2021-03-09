// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeSnapshotsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=true)]
        public string NextToken { get; set; }

        [NameInMap("Snapshots")]
        [Validation(Required=true)]
        public List<DescribeSnapshotsResponseSnapshots> Snapshots { get; set; }
        public class DescribeSnapshotsResponseSnapshots : TeaModel {
            [NameInMap("SnapshotId")]
            [Validation(Required=true)]
            public string SnapshotId { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=true)]
            public string DesktopId { get; set; }

            [NameInMap("SnapshotName")]
            [Validation(Required=true)]
            public string SnapshotName { get; set; }

            [NameInMap("Description")]
            [Validation(Required=true)]
            public string Description { get; set; }

            [NameInMap("SnapshotType")]
            [Validation(Required=true)]
            public string SnapshotType { get; set; }

            [NameInMap("SourceDiskSize")]
            [Validation(Required=true)]
            public string SourceDiskSize { get; set; }

            [NameInMap("SourceDiskType")]
            [Validation(Required=true)]
            public string SourceDiskType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=true)]
            public string CreationTime { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=true)]
            public string Progress { get; set; }

            [NameInMap("RemainTime")]
            [Validation(Required=true)]
            public int? RemainTime { get; set; }

        }

    }

}

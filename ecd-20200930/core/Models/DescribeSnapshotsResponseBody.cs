// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeSnapshotsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public List<DescribeSnapshotsResponseBodySnapshots> Snapshots { get; set; }
        public class DescribeSnapshotsResponseBodySnapshots : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SnapshotType")]
            [Validation(Required=false)]
            public string SnapshotType { get; set; }

            [NameInMap("SnapshotName")]
            [Validation(Required=false)]
            public string SnapshotName { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            [NameInMap("RemainTime")]
            [Validation(Required=false)]
            public int? RemainTime { get; set; }

            [NameInMap("SourceDiskSize")]
            [Validation(Required=false)]
            public string SourceDiskSize { get; set; }

            [NameInMap("SourceDiskType")]
            [Validation(Required=false)]
            public string SourceDiskType { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

        }

    }

}

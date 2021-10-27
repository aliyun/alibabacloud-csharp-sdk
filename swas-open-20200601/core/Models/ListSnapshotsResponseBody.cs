// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListSnapshotsResponseBody : TeaModel {
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
        public List<ListSnapshotsResponseBodySnapshots> Snapshots { get; set; }
        public class ListSnapshotsResponseBodySnapshots : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            [NameInMap("SnapshotName")]
            [Validation(Required=false)]
            public string SnapshotName { get; set; }

            [NameInMap("SourceDiskId")]
            [Validation(Required=false)]
            public string SourceDiskId { get; set; }

            [NameInMap("SourceDiskType")]
            [Validation(Required=false)]
            public string SourceDiskType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

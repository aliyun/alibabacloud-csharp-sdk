// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSnapshotsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeSnapshotsResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeSnapshotsResponseBodyPageInfo : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }
        };

        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public List<DescribeSnapshotsResponseBodySnapshots> Snapshots { get; set; }
        public class DescribeSnapshotsResponseBodySnapshots : TeaModel {
            [NameInMap("ContainerSnapshotId")]
            [Validation(Required=false)]
            public string ContainerSnapshotId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SnapshotHash")]
            [Validation(Required=false)]
            public string SnapshotHash { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("ActualItems")]
            [Validation(Required=false)]
            public long? ActualItems { get; set; }

            [NameInMap("VaultId")]
            [Validation(Required=false)]
            public string VaultId { get; set; }

            [NameInMap("ActualBytes")]
            [Validation(Required=false)]
            public long? ActualBytes { get; set; }

            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("ExitCode")]
            [Validation(Required=false)]
            public string ExitCode { get; set; }

            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            [NameInMap("ItemsDone")]
            [Validation(Required=false)]
            public long? ItemsDone { get; set; }

            [NameInMap("BytesTotal")]
            [Validation(Required=false)]
            public long? BytesTotal { get; set; }

            [NameInMap("Retention")]
            [Validation(Required=false)]
            public long? Retention { get; set; }

            [NameInMap("ErrorType")]
            [Validation(Required=false)]
            public string ErrorType { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            [NameInMap("ParentSnapshotHash")]
            [Validation(Required=false)]
            public string ParentSnapshotHash { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ParentHash")]
            [Validation(Required=false)]
            public string ParentHash { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            [NameInMap("ErrorFile")]
            [Validation(Required=false)]
            public string ErrorFile { get; set; }

            [NameInMap("SnapshotType")]
            [Validation(Required=false)]
            public string SnapshotType { get; set; }

            [NameInMap("SnapshotName")]
            [Validation(Required=false)]
            public string SnapshotName { get; set; }

            [NameInMap("SnapshotOption")]
            [Validation(Required=false)]
            public string SnapshotOption { get; set; }

            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("ErrorCount")]
            [Validation(Required=false)]
            public long? ErrorCount { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("ItemsTotal")]
            [Validation(Required=false)]
            public long? ItemsTotal { get; set; }

            [NameInMap("BytesDone")]
            [Validation(Required=false)]
            public long? BytesDone { get; set; }

            [NameInMap("Paths")]
            [Validation(Required=false)]
            public List<string> Paths { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class SearchHistoricalSnapshotsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public SearchHistoricalSnapshotsResponseBodySnapshots Snapshots { get; set; }
        public class SearchHistoricalSnapshotsResponseBodySnapshots : TeaModel {
            [NameInMap("Snapshot")]
            [Validation(Required=false)]
            public List<SearchHistoricalSnapshotsResponseBodySnapshotsSnapshot> Snapshot { get; set; }
            public class SearchHistoricalSnapshotsResponseBodySnapshotsSnapshot : TeaModel {
                public long? ActualBytes { get; set; }
                public long? ActualItems { get; set; }
                public string BackupType { get; set; }
                public string Bucket { get; set; }
                public long? BytesDone { get; set; }
                public long? BytesTotal { get; set; }
                public string ClientId { get; set; }
                public long? CompleteTime { get; set; }
                public long? CreateTime { get; set; }
                public long? CreatedTime { get; set; }
                public string ErrorFile { get; set; }
                public long? ExpireTime { get; set; }
                public string FileSystemId { get; set; }
                public string InstanceId { get; set; }
                public string InstanceName { get; set; }
                public long? ItemsDone { get; set; }
                public long? ItemsTotal { get; set; }
                public string JobId { get; set; }
                public string ParentSnapshotHash { get; set; }
                public string Path { get; set; }
                public SearchHistoricalSnapshotsResponseBodySnapshotsSnapshotPaths Paths { get; set; }
                public class SearchHistoricalSnapshotsResponseBodySnapshotsSnapshotPaths : TeaModel {
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public List<string> Path { get; set; }

                }
                public string Prefix { get; set; }
                public long? RangeEnd { get; set; }
                public long? RangeStart { get; set; }
                public long? Retention { get; set; }
                public string SnapshotHash { get; set; }
                public string SnapshotId { get; set; }
                public string SourceType { get; set; }
                public long? StartTime { get; set; }
                public string Status { get; set; }
                public string TableName { get; set; }
                public long? UpdatedTime { get; set; }
                public string VaultId { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

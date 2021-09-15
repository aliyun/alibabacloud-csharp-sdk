// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRestoreJobsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeRestoreJobsResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeRestoreJobsResponseBodyPageInfo : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
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

        [NameInMap("RestoreJobs")]
        [Validation(Required=false)]
        public List<DescribeRestoreJobsResponseBodyRestoreJobs> RestoreJobs { get; set; }
        public class DescribeRestoreJobsResponseBodyRestoreJobs : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SnapshotHash")]
            [Validation(Required=false)]
            public string SnapshotHash { get; set; }

            [NameInMap("SourceClientId")]
            [Validation(Required=false)]
            public string SourceClientId { get; set; }

            [NameInMap("ErrorFileUrl")]
            [Validation(Required=false)]
            public string ErrorFileUrl { get; set; }

            [NameInMap("Includes")]
            [Validation(Required=false)]
            public string Includes { get; set; }

            [NameInMap("RestoreName")]
            [Validation(Required=false)]
            public string RestoreName { get; set; }

            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("VaultId")]
            [Validation(Required=false)]
            public string VaultId { get; set; }

            [NameInMap("ActualBytes")]
            [Validation(Required=false)]
            public long? ActualBytes { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Percentage")]
            [Validation(Required=false)]
            public int? Percentage { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("RestoreType")]
            [Validation(Required=false)]
            public string RestoreType { get; set; }

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

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public long? CompleteTime { get; set; }

            [NameInMap("ErrorType")]
            [Validation(Required=false)]
            public string ErrorType { get; set; }

            [NameInMap("SnapshotVersion")]
            [Validation(Required=false)]
            public string SnapshotVersion { get; set; }

            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("ErrorFile")]
            [Validation(Required=false)]
            public string ErrorFile { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            [NameInMap("Excludes")]
            [Validation(Required=false)]
            public string Excludes { get; set; }

            [NameInMap("Speed")]
            [Validation(Required=false)]
            public long? Speed { get; set; }

            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

            [NameInMap("RestoreId")]
            [Validation(Required=false)]
            public string RestoreId { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("Eta")]
            [Validation(Required=false)]
            public long? Eta { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("ErrorCount")]
            [Validation(Required=false)]
            public long? ErrorCount { get; set; }

            [NameInMap("ItemsTotal")]
            [Validation(Required=false)]
            public long? ItemsTotal { get; set; }

            [NameInMap("BytesDone")]
            [Validation(Required=false)]
            public long? BytesDone { get; set; }

        }

    }

}

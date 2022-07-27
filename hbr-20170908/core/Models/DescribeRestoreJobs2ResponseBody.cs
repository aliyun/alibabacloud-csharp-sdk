// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeRestoreJobs2ResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RestoreJobs")]
        [Validation(Required=false)]
        public DescribeRestoreJobs2ResponseBodyRestoreJobs RestoreJobs { get; set; }
        public class DescribeRestoreJobs2ResponseBodyRestoreJobs : TeaModel {
            [NameInMap("RestoreJob")]
            [Validation(Required=false)]
            public List<DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJob> RestoreJob { get; set; }
            public class DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJob : TeaModel {
                public long? ActualBytes { get; set; }
                public long? ActualItems { get; set; }
                public long? BytesDone { get; set; }
                public long? BytesTotal { get; set; }
                public string ClusterId { get; set; }
                public long? CompleteTime { get; set; }
                public long? CreatedTime { get; set; }
                public string CrossAccountRoleName { get; set; }
                public string CrossAccountType { get; set; }
                public long? CrossAccountUserId { get; set; }
                public string ErrorFile { get; set; }
                public string ErrorMessage { get; set; }
                public string Exclude { get; set; }
                public long? ExpireTime { get; set; }
                public string Include { get; set; }
                public long? ItemsDone { get; set; }
                public long? ItemsTotal { get; set; }
                public string Options { get; set; }
                public DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJobOtsDetail OtsDetail { get; set; }
                public class DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJobOtsDetail : TeaModel {
                    [NameInMap("BatchChannelCount")]
                    [Validation(Required=false)]
                    public int? BatchChannelCount { get; set; }

                    [NameInMap("OverwriteExisting")]
                    [Validation(Required=false)]
                    public bool? OverwriteExisting { get; set; }

                }
                public string ParentId { get; set; }
                public int? Progress { get; set; }
                public string RestoreId { get; set; }
                public string RestoreType { get; set; }
                public string SnapshotHash { get; set; }
                public string SnapshotId { get; set; }
                public string SourceType { get; set; }
                public long? Speed { get; set; }
                public long? StartTime { get; set; }
                public string Status { get; set; }
                public string TargetBucket { get; set; }
                public string TargetClientId { get; set; }
                public long? TargetCreateTime { get; set; }
                public string TargetDataSourceId { get; set; }
                public string TargetFileSystemId { get; set; }
                public string TargetInstanceId { get; set; }
                public string TargetInstanceName { get; set; }
                public string TargetPath { get; set; }
                public string TargetPrefix { get; set; }
                public string TargetTableName { get; set; }
                public long? TargetTime { get; set; }
                public string UdmDetail { get; set; }
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

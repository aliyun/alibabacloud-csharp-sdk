// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeBackupJobs2ResponseBody : TeaModel {
        [NameInMap("BackupJobs")]
        [Validation(Required=false)]
        public DescribeBackupJobs2ResponseBodyBackupJobs BackupJobs { get; set; }
        public class DescribeBackupJobs2ResponseBodyBackupJobs : TeaModel {
            [NameInMap("BackupJob")]
            [Validation(Required=false)]
            public List<DescribeBackupJobs2ResponseBodyBackupJobsBackupJob> BackupJob { get; set; }
            public class DescribeBackupJobs2ResponseBodyBackupJobsBackupJob : TeaModel {
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
                public string CrossAccountRoleName { get; set; }
                public string CrossAccountType { get; set; }
                public long? CrossAccountUserId { get; set; }
                public string ErrorMessage { get; set; }
                public string Exclude { get; set; }
                public string FileSystemId { get; set; }
                public string Include { get; set; }
                public string InstanceId { get; set; }
                public string InstanceName { get; set; }
                public long? ItemsDone { get; set; }
                public long? ItemsTotal { get; set; }
                public string JobId { get; set; }
                public string JobName { get; set; }
                public string Options { get; set; }
                public DescribeBackupJobs2ResponseBodyBackupJobsBackupJobOtsDetail OtsDetail { get; set; }
                public class DescribeBackupJobs2ResponseBodyBackupJobsBackupJobOtsDetail : TeaModel {
                    [NameInMap("TableNames")]
                    [Validation(Required=false)]
                    public DescribeBackupJobs2ResponseBodyBackupJobsBackupJobOtsDetailTableNames TableNames { get; set; }
                    public class DescribeBackupJobs2ResponseBodyBackupJobsBackupJobOtsDetailTableNames : TeaModel {
                        [NameInMap("TableName")]
                        [Validation(Required=false)]
                        public List<string> TableName { get; set; }
                    };

                }
                public DescribeBackupJobs2ResponseBodyBackupJobsBackupJobPaths Paths { get; set; }
                public class DescribeBackupJobs2ResponseBodyBackupJobsBackupJobPaths : TeaModel {
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public List<string> Path { get; set; }

                }
                public string PlanId { get; set; }
                public string Prefix { get; set; }
                public int? Progress { get; set; }
                public string SourceType { get; set; }
                public long? Speed { get; set; }
                public string SpeedLimit { get; set; }
                public long? StartTime { get; set; }
                public string Status { get; set; }
                public string TableName { get; set; }
                public long? UpdatedTime { get; set; }
                public string VaultId { get; set; }
            }
        };

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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

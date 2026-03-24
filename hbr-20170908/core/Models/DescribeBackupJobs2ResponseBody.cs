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
                [NameInMap("ActualBytes")]
                [Validation(Required=false)]
                public long? ActualBytes { get; set; }

                [NameInMap("ActualFiles")]
                [Validation(Required=false)]
                public long? ActualFiles { get; set; }

                [NameInMap("ActualItems")]
                [Validation(Required=false)]
                public long? ActualItems { get; set; }

                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                [NameInMap("BytesDone")]
                [Validation(Required=false)]
                public long? BytesDone { get; set; }

                [NameInMap("BytesTotal")]
                [Validation(Required=false)]
                public long? BytesTotal { get; set; }

                [NameInMap("ChangeListPath")]
                [Validation(Required=false)]
                public string ChangeListPath { get; set; }

                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                [NameInMap("CompleteTime")]
                [Validation(Required=false)]
                public long? CompleteTime { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                [NameInMap("CrossAccountRoleName")]
                [Validation(Required=false)]
                public string CrossAccountRoleName { get; set; }

                [NameInMap("CrossAccountType")]
                [Validation(Required=false)]
                public string CrossAccountType { get; set; }

                [NameInMap("CrossAccountUserId")]
                [Validation(Required=false)]
                public long? CrossAccountUserId { get; set; }

                [NameInMap("DestDataSourceDetail")]
                [Validation(Required=false)]
                public string DestDataSourceDetail { get; set; }

                [NameInMap("DestDataSourceId")]
                [Validation(Required=false)]
                public string DestDataSourceId { get; set; }

                [NameInMap("DestSourceType")]
                [Validation(Required=false)]
                public string DestSourceType { get; set; }

                [NameInMap("Detail")]
                [Validation(Required=false)]
                public DescribeBackupJobs2ResponseBodyBackupJobsBackupJobDetail Detail { get; set; }
                public class DescribeBackupJobs2ResponseBodyBackupJobsBackupJobDetail : TeaModel {
                    [NameInMap("DestinationNativeSnapshotErrorMessage")]
                    [Validation(Required=false)]
                    public string DestinationNativeSnapshotErrorMessage { get; set; }

                    [NameInMap("DestinationNativeSnapshotId")]
                    [Validation(Required=false)]
                    public string DestinationNativeSnapshotId { get; set; }

                    [NameInMap("DestinationNativeSnapshotProgress")]
                    [Validation(Required=false)]
                    public int? DestinationNativeSnapshotProgress { get; set; }

                    [NameInMap("DestinationNativeSnapshotStatus")]
                    [Validation(Required=false)]
                    public string DestinationNativeSnapshotStatus { get; set; }

                    [NameInMap("DestinationRetention")]
                    [Validation(Required=false)]
                    public long? DestinationRetention { get; set; }

                    [NameInMap("DestinationSnapshotId")]
                    [Validation(Required=false)]
                    public string DestinationSnapshotId { get; set; }

                    [NameInMap("DiskNativeSnapshotIdList")]
                    [Validation(Required=false)]
                    public DescribeBackupJobs2ResponseBodyBackupJobsBackupJobDetailDiskNativeSnapshotIdList DiskNativeSnapshotIdList { get; set; }
                    public class DescribeBackupJobs2ResponseBodyBackupJobsBackupJobDetailDiskNativeSnapshotIdList : TeaModel {
                        [NameInMap("DiskNativeSnapshotId")]
                        [Validation(Required=false)]
                        public List<string> DiskNativeSnapshotId { get; set; }

                    }

                    [NameInMap("DoCopy")]
                    [Validation(Required=false)]
                    public bool? DoCopy { get; set; }

                    [NameInMap("InstanceInfos")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> InstanceInfos { get; set; }

                    [NameInMap("NativeSnapshotId")]
                    [Validation(Required=false)]
                    public string NativeSnapshotId { get; set; }

                }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("Exclude")]
                [Validation(Required=false)]
                public string Exclude { get; set; }

                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                [NameInMap("FilesDone")]
                [Validation(Required=false)]
                public long? FilesDone { get; set; }

                [NameInMap("FilesTotal")]
                [Validation(Required=false)]
                public long? FilesTotal { get; set; }

                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                [NameInMap("Include")]
                [Validation(Required=false)]
                public string Include { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("ItemsDone")]
                [Validation(Required=false)]
                public long? ItemsDone { get; set; }

                [NameInMap("ItemsTotal")]
                [Validation(Required=false)]
                public long? ItemsTotal { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                [NameInMap("Options")]
                [Validation(Required=false)]
                public string Options { get; set; }

                [NameInMap("OtsDetail")]
                [Validation(Required=false)]
                public DescribeBackupJobs2ResponseBodyBackupJobsBackupJobOtsDetail OtsDetail { get; set; }
                public class DescribeBackupJobs2ResponseBodyBackupJobsBackupJobOtsDetail : TeaModel {
                    [NameInMap("TableNames")]
                    [Validation(Required=false)]
                    public DescribeBackupJobs2ResponseBodyBackupJobsBackupJobOtsDetailTableNames TableNames { get; set; }
                    public class DescribeBackupJobs2ResponseBodyBackupJobsBackupJobOtsDetailTableNames : TeaModel {
                        [NameInMap("TableName")]
                        [Validation(Required=false)]
                        public List<string> TableName { get; set; }

                    }

                }

                [NameInMap("Paths")]
                [Validation(Required=false)]
                public DescribeBackupJobs2ResponseBodyBackupJobsBackupJobPaths Paths { get; set; }
                public class DescribeBackupJobs2ResponseBodyBackupJobsBackupJobPaths : TeaModel {
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public List<string> Path { get; set; }

                }

                [NameInMap("PlanId")]
                [Validation(Required=false)]
                public string PlanId { get; set; }

                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                [NameInMap("Report")]
                [Validation(Required=false)]
                public DescribeBackupJobs2ResponseBodyBackupJobsBackupJobReport Report { get; set; }
                public class DescribeBackupJobs2ResponseBodyBackupJobsBackupJobReport : TeaModel {
                    [NameInMap("FailedFiles")]
                    [Validation(Required=false)]
                    public string FailedFiles { get; set; }

                    [NameInMap("ReportTaskStatus")]
                    [Validation(Required=false)]
                    public string ReportTaskStatus { get; set; }

                    [NameInMap("SkippedFiles")]
                    [Validation(Required=false)]
                    public string SkippedFiles { get; set; }

                    [NameInMap("SuccessFiles")]
                    [Validation(Required=false)]
                    public string SuccessFiles { get; set; }

                    [NameInMap("TotalFiles")]
                    [Validation(Required=false)]
                    public string TotalFiles { get; set; }

                }

                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("Speed")]
                [Validation(Required=false)]
                public long? Speed { get; set; }

                [NameInMap("SpeedLimit")]
                [Validation(Required=false)]
                public string SpeedLimit { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                [NameInMap("TriggerMode")]
                [Validation(Required=false)]
                public string TriggerMode { get; set; }

                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The message that is returned. If the call is successful, &quot;successful&quot; is returned. If the call fails, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number of the returned page. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Valid values: 1 to 99. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful.</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of returned backup jobs that meet the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

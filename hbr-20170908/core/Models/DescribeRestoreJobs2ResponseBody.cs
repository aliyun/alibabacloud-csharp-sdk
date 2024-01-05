// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeRestoreJobs2ResponseBody : TeaModel {
        /// <summary>
        /// The response status code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The response message. If the request was successful, "successful" is returned. If the request failed, an error message is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 99. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details about the restore jobs.
        /// </summary>
        [NameInMap("RestoreJobs")]
        [Validation(Required=false)]
        public DescribeRestoreJobs2ResponseBodyRestoreJobs RestoreJobs { get; set; }
        public class DescribeRestoreJobs2ResponseBodyRestoreJobs : TeaModel {
            [NameInMap("RestoreJob")]
            [Validation(Required=false)]
            public List<DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJob> RestoreJob { get; set; }
            public class DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJob : TeaModel {
                /// <summary>
                /// The actual amount of data that is restored after duplicates are removed. Unit: bytes.
                /// </summary>
                [NameInMap("ActualBytes")]
                [Validation(Required=false)]
                public long? ActualBytes { get; set; }

                /// <summary>
                /// This parameter is valid only if the **SourceType** parameter is set to **ECS_FILE**. This parameter indicates the actual number of objects that are restored by the restore job.
                /// </summary>
                [NameInMap("ActualItems")]
                [Validation(Required=false)]
                public long? ActualItems { get; set; }

                /// <summary>
                /// The amount of data that was restored. Unit: bytes.
                /// </summary>
                [NameInMap("BytesDone")]
                [Validation(Required=false)]
                public long? BytesDone { get; set; }

                /// <summary>
                /// The total amount of data that is backed up from the data source. Unit: bytes.
                /// </summary>
                [NameInMap("BytesTotal")]
                [Validation(Required=false)]
                public long? BytesTotal { get; set; }

                /// <summary>
                /// The ID of the client group used for restoration.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The time when the restore job was completed. The value is a UNIX timestamp. Unit: seconds.
                /// </summary>
                [NameInMap("CompleteTime")]
                [Validation(Required=false)]
                public long? CompleteTime { get; set; }

                /// <summary>
                /// The time when the restore job was created. The value is a UNIX timestamp. Unit: seconds.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// The name of the RAM role that is created within the source Alibaba Cloud account and assigned to the current Alibaba Cloud account to authorize the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.
                /// </summary>
                [NameInMap("CrossAccountRoleName")]
                [Validation(Required=false)]
                public string CrossAccountRoleName { get; set; }

                /// <summary>
                /// Indicates whether data is backed up within the same Alibaba Cloud account or across Alibaba Cloud accounts. Valid values:
                /// 
                /// *   SELF_ACCOUNT: Data is backed up within the same Alibaba Cloud account.
                /// *   CROSS_ACCOUNT: Data is backed up across Alibaba Cloud accounts.
                /// </summary>
                [NameInMap("CrossAccountType")]
                [Validation(Required=false)]
                public string CrossAccountType { get; set; }

                /// <summary>
                /// The ID of the source Alibaba Cloud account that authorizes the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.
                /// </summary>
                [NameInMap("CrossAccountUserId")]
                [Validation(Required=false)]
                public long? CrossAccountUserId { get; set; }

                /// <summary>
                /// The list of the files that failed to be restored.
                /// </summary>
                [NameInMap("ErrorFile")]
                [Validation(Required=false)]
                public string ErrorFile { get; set; }

                /// <summary>
                /// The error message that is returned for the restore job.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// This parameter is returned only if the **SourceType** parameter is set to **ECS_FILE**. This parameter indicates the paths to the files that are excluded from the restore job. The value can be 1 to 255 characters in length.
                /// </summary>
                [NameInMap("Exclude")]
                [Validation(Required=false)]
                public string Exclude { get; set; }

                /// <summary>
                /// The time when the restore job expires.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                [NameInMap("FailbackDetail")]
                [Validation(Required=false)]
                public string FailbackDetail { get; set; }

                /// <summary>
                /// The paths to the files that are included in the restore job.
                /// </summary>
                [NameInMap("Include")]
                [Validation(Required=false)]
                public string Include { get; set; }

                /// <summary>
                /// This parameter is valid only if the **SourceType** parameter is set to **ECS_FILE**. This parameter indicates the number of restored objects.
                /// </summary>
                [NameInMap("ItemsDone")]
                [Validation(Required=false)]
                public long? ItemsDone { get; set; }

                /// <summary>
                /// This parameter is valid only if the **SourceType** parameter is set to **ECS_FILE**. This parameter indicates the total number of objects in the data source.
                /// </summary>
                [NameInMap("ItemsTotal")]
                [Validation(Required=false)]
                public long? ItemsTotal { get; set; }

                [NameInMap("MeteringBytesDone")]
                [Validation(Required=false)]
                public long? MeteringBytesDone { get; set; }

                [NameInMap("MeteringBytesTotal")]
                [Validation(Required=false)]
                public long? MeteringBytesTotal { get; set; }

                /// <summary>
                /// This parameter is returned only if the **SourceType** parameter is set to **ECS_FILE**. This parameter indicates whether Windows Volume Shadow Copy Service (VSS) is used to define a restoration path.
                /// 
                /// *   This parameter is available only for Windows ECS instances.
                /// *   If data changes occur in the backup source, the source data must be the same as the data to be backed up before you can set this parameter to `["UseVSS":true]`.
                /// *   If you use VSS, you cannot restore data from multiple directories.
                /// </summary>
                [NameInMap("Options")]
                [Validation(Required=false)]
                public string Options { get; set; }

                /// <summary>
                /// The details about the Tablestore instance.
                /// </summary>
                [NameInMap("OtsDetail")]
                [Validation(Required=false)]
                public DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJobOtsDetail OtsDetail { get; set; }
                public class DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJobOtsDetail : TeaModel {
                    /// <summary>
                    /// The number of channels processed by each Tablestore restore job.
                    /// </summary>
                    [NameInMap("BatchChannelCount")]
                    [Validation(Required=false)]
                    public int? BatchChannelCount { get; set; }

                    /// <summary>
                    /// Indicates whether the existing Tablestore restore job was overwritten.
                    /// </summary>
                    [NameInMap("OverwriteExisting")]
                    [Validation(Required=false)]
                    public bool? OverwriteExisting { get; set; }

                }

                /// <summary>
                /// The ID of the parent job.
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// The progress of the restore job. For example, 10000 indicates that the progress is 100%.
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                [NameInMap("Report")]
                [Validation(Required=false)]
                public DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJobReport Report { get; set; }
                public class DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJobReport : TeaModel {
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

                /// <summary>
                /// The ID of the restore job.
                /// </summary>
                [NameInMap("RestoreId")]
                [Validation(Required=false)]
                public string RestoreId { get; set; }

                /// <summary>
                /// The type of the restore job.
                /// </summary>
                [NameInMap("RestoreType")]
                [Validation(Required=false)]
                public string RestoreType { get; set; }

                /// <summary>
                /// The hash value of the backup snapshot.
                /// </summary>
                [NameInMap("SnapshotHash")]
                [Validation(Required=false)]
                public string SnapshotHash { get; set; }

                /// <summary>
                /// The ID of the snapshot used for restoration.
                /// </summary>
                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

                /// <summary>
                /// The type of the data source. Valid values:
                /// 
                /// *   **ECS_FILE**: ECS files
                /// *   **OSS**: OSS buckets
                /// *   **NAS**: NAS file systems
                /// *   **OTS_TABLE**: Tablestore instances
                /// *   **UDM_ECS**: ECS instances
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// The average speed at which data is backed up. Unit: KB/s.
                /// </summary>
                [NameInMap("Speed")]
                [Validation(Required=false)]
                public long? Speed { get; set; }

                /// <summary>
                /// The time when the restore job starts. The value is a UNIX timestamp. Unit: seconds.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// The status of the restore job. Valid values:
                /// 
                /// *   **COMPLETE**: The restore job is completed.
                /// *   **PARTIAL_COMPLETE**: The restore job is partially completed.
                /// *   **FAILED**: The restore job has failed.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

                /// <summary>
                /// The name of the destination OSS bucket. This parameter is returned only for OSS buckets.
                /// </summary>
                [NameInMap("TargetBucket")]
                [Validation(Required=false)]
                public string TargetBucket { get; set; }

                /// <summary>
                /// The ID of the destination client.
                /// </summary>
                [NameInMap("TargetClientId")]
                [Validation(Required=false)]
                public string TargetClientId { get; set; }

                /// <summary>
                /// This parameter is returned only for NAS file systems. This parameter indicates the time when the file system was created.
                /// </summary>
                [NameInMap("TargetCreateTime")]
                [Validation(Required=false)]
                public long? TargetCreateTime { get; set; }

                /// <summary>
                /// The ID of the destination data source.
                /// </summary>
                [NameInMap("TargetDataSourceId")]
                [Validation(Required=false)]
                public string TargetDataSourceId { get; set; }

                /// <summary>
                /// The ID of the destination NAS file system. This parameter is returned only for NAS file systems.
                /// </summary>
                [NameInMap("TargetFileSystemId")]
                [Validation(Required=false)]
                public string TargetFileSystemId { get; set; }

                /// <summary>
                /// The ID of the destination instance for the restore job.
                /// </summary>
                [NameInMap("TargetInstanceId")]
                [Validation(Required=false)]
                public string TargetInstanceId { get; set; }

                /// <summary>
                /// The name of the destination Tablestore instance.
                /// </summary>
                [NameInMap("TargetInstanceName")]
                [Validation(Required=false)]
                public string TargetInstanceName { get; set; }

                /// <summary>
                /// The destination file path of the restore job.
                /// </summary>
                [NameInMap("TargetPath")]
                [Validation(Required=false)]
                public string TargetPath { get; set; }

                /// <summary>
                /// The prefix of the objects that are restored. This parameter is returned only for OSS buckets.
                /// </summary>
                [NameInMap("TargetPrefix")]
                [Validation(Required=false)]
                public string TargetPrefix { get; set; }

                /// <summary>
                /// The name of the destination table in the Tablestore instance.
                /// </summary>
                [NameInMap("TargetTableName")]
                [Validation(Required=false)]
                public string TargetTableName { get; set; }

                /// <summary>
                /// The time when the Tablestore instance was backed up. The value is a UNIX timestamp. Unit: seconds.
                /// </summary>
                [NameInMap("TargetTime")]
                [Validation(Required=false)]
                public long? TargetTime { get; set; }

                /// <summary>
                /// The details about ECS instance backup.
                /// </summary>
                [NameInMap("UdmDetail")]
                [Validation(Required=false)]
                public string UdmDetail { get; set; }

                /// <summary>
                /// The time when the restore job was updated. The value is a UNIX timestamp. Unit: seconds.
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

                /// <summary>
                /// The ID of the backup vault.
                /// </summary>
                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRestoreJobsResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeRestoreJobsResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeRestoreJobsResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of restoration tasks returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: **10**.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of restoration tasks returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the restoration tasks.
        /// </summary>
        [NameInMap("RestoreJobs")]
        [Validation(Required=false)]
        public List<DescribeRestoreJobsResponseBodyRestoreJobs> RestoreJobs { get; set; }
        public class DescribeRestoreJobsResponseBodyRestoreJobs : TeaModel {
            /// <summary>
            /// The size of backup data. Unit: bytes.
            /// </summary>
            [NameInMap("ActualBytes")]
            [Validation(Required=false)]
            public long? ActualBytes { get; set; }

            /// <summary>
            /// The total size of data that is restored. Unit: bytes.
            /// </summary>
            [NameInMap("BytesDone")]
            [Validation(Required=false)]
            public long? BytesDone { get; set; }

            /// <summary>
            /// The total size of data that you want to restore. Unit: bytes.
            /// </summary>
            [NameInMap("BytesTotal")]
            [Validation(Required=false)]
            public long? BytesTotal { get; set; }

            /// <summary>
            /// The ID of the anti-ransomware agent that is used to restore data.
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// The timestamp when the restoration task is complete. Unit: milliseconds.
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public long? CompleteTime { get; set; }

            /// <summary>
            /// The timestamp when the restoration task is created. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// The duration of the restoration task. Unit: seconds.
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// The number of the restoration tasks on which errors occur.
            /// </summary>
            [NameInMap("ErrorCount")]
            [Validation(Required=false)]
            public long? ErrorCount { get; set; }

            /// <summary>
            /// The name of the CSV file. The CSV file contains the files that fail to be restored.
            /// </summary>
            [NameInMap("ErrorFile")]
            [Validation(Required=false)]
            public string ErrorFile { get; set; }

            /// <summary>
            /// The URL to download the CSV file. The CSV file contains the files that fail to be restored.
            /// </summary>
            [NameInMap("ErrorFileUrl")]
            [Validation(Required=false)]
            public string ErrorFileUrl { get; set; }

            /// <summary>
            /// The error code that is returned for the restoration task.
            /// </summary>
            [NameInMap("ErrorType")]
            [Validation(Required=false)]
            public string ErrorType { get; set; }

            /// <summary>
            /// The timestamp when the in-progress restoration task is expected to be complete. Unit: seconds.
            /// </summary>
            [NameInMap("Eta")]
            [Validation(Required=false)]
            public long? Eta { get; set; }

            /// <summary>
            /// The directory excluded from the anti-ransomware policy. The value is the directory that you specify to skip protection when you create the anti-ransomware policy.
            /// </summary>
            [NameInMap("Excludes")]
            [Validation(Required=false)]
            public string Excludes { get; set; }

            /// <summary>
            /// The return value of the restoration task.
            /// </summary>
            [NameInMap("ExitCode")]
            [Validation(Required=false)]
            public string ExitCode { get; set; }

            /// <summary>
            /// The time when the restoration task is created.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The time when the restoration task is updated.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The included directory based on which the files to restore are located. The value is the directory that you specify for protection when you create the anti-ransomware policy
            /// </summary>
            [NameInMap("Includes")]
            [Validation(Required=false)]
            public string Includes { get; set; }

            /// <summary>
            /// The ID of the server whose data you want to restore.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the server whose data you want to restore.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address of the server whose data you want to restore.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The internal IP address of the server whose data you want to restore.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The number of files that are backed up.
            /// </summary>
            [NameInMap("ItemsDone")]
            [Validation(Required=false)]
            public long? ItemsDone { get; set; }

            /// <summary>
            /// The total number of files that you want to restore.
            /// </summary>
            [NameInMap("ItemsTotal")]
            [Validation(Required=false)]
            public long? ItemsTotal { get; set; }

            /// <summary>
            /// The error message returned.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The progress of the restoration task in percentage.
            /// </summary>
            [NameInMap("Percentage")]
            [Validation(Required=false)]
            public int? Percentage { get; set; }

            /// <summary>
            /// The ID of the request, which is used to locate and troubleshoot issues.
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// The ID of the restoration task.
            /// </summary>
            [NameInMap("RestoreId")]
            [Validation(Required=false)]
            public string RestoreId { get; set; }

            /// <summary>
            /// The name of the restoration task.
            /// </summary>
            [NameInMap("RestoreName")]
            [Validation(Required=false)]
            public string RestoreName { get; set; }

            /// <summary>
            /// The type of the file that is restored. Valid values:
            /// 
            /// *   **ECS_FILE**: files on Elastic Compute Service (ECS) instances
            /// *   **FILE**: files on servers in data centers
            /// </summary>
            [NameInMap("RestoreType")]
            [Validation(Required=false)]
            public string RestoreType { get; set; }

            /// <summary>
            /// The hash value of the snapshot that stores backup data when the data is backed up.
            /// </summary>
            [NameInMap("SnapshotHash")]
            [Validation(Required=false)]
            public string SnapshotHash { get; set; }

            /// <summary>
            /// The hash value ID of the snapshot that stores backup data when the data is backed up.
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// The version of the backup data.
            /// </summary>
            [NameInMap("SnapshotVersion")]
            [Validation(Required=false)]
            public string SnapshotVersion { get; set; }

            /// <summary>
            /// The path to the source file that you want to restore.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The ID of the anti-ransomware agent that is used to back up data.
            /// </summary>
            [NameInMap("SourceClientId")]
            [Validation(Required=false)]
            public string SourceClientId { get; set; }

            /// <summary>
            /// The speed of data restoration. Unit: byte/s.
            /// </summary>
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public long? Speed { get; set; }

            /// <summary>
            /// The status of the restoration task. Valid values:
            /// 
            /// *   **RUNNING**: The task is running.
            /// *   **COMPLETE**: The task is complete.
            /// *   **FAILED**: The task fails.
            /// *   **CANCELING**: The task is being canceled.
            /// *   **CANCELED**: The task is canceled.
            /// *   **PARTIAL_COMPLETE**: The task is partially successful.
            /// *   **CREATED**: The task is created but is not run.
            /// *   **EXPIRED**: The task is not updated.
            /// *   **QUEUED**: The task is waiting to be run.
            /// *   **CLIENT_DELETED**: The task fails because the anti-ransomware agent is uninstalled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The folder to which the backup data is restored. After you create the restoration task, the backup data is restored to the specified folder.
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// The timestamp when the restoration task was last updated. Unit: milliseconds.
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

            /// <summary>
            /// The UUID of the server whose data you want to restore.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// The ID of the backup vault in which the backup data is stored.
            /// </summary>
            [NameInMap("VaultId")]
            [Validation(Required=false)]
            public string VaultId { get; set; }

            /// <summary>
            /// The ID of the region where the backup vault resides.
            /// </summary>
            [NameInMap("VaultRegionId")]
            [Validation(Required=false)]
            public string VaultRegionId { get; set; }

        }

    }

}

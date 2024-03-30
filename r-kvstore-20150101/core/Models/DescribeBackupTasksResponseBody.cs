// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeBackupTasksResponseBody : TeaModel {
        /// <summary>
        /// The following parameters are internal parameters. Ignore the parameters.
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeBackupTasksResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeBackupTasksResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// An internal parameter. Ignore this parameter.
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// An internal parameter. Ignore this parameter.
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// An internal parameter. Ignore this parameter.
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// An internal parameter. Ignore this parameter.
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// An internal parameter. Ignore this parameter.
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// An internal parameter. Ignore this parameter.
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// An internal parameter. Ignore this parameter.
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// The details of the backup tasks.
        /// </summary>
        [NameInMap("BackupJobs")]
        [Validation(Required=false)]
        public List<DescribeBackupTasksResponseBodyBackupJobs> BackupJobs { get; set; }
        public class DescribeBackupTasksResponseBodyBackupJobs : TeaModel {
            /// <summary>
            /// The ID of the backup task.
            /// </summary>
            [NameInMap("BackupJobID")]
            [Validation(Required=false)]
            public long? BackupJobID { get; set; }

            /// <summary>
            /// The state of the backup task. Valid values:
            /// 
            /// *   **NoStart**: The backup task is not started.
            /// *   **Preparing**: The backup task is being prepared.
            /// *   **Waiting**: The backup task is pending.
            /// *   **Uploading**: The system is uploading the backup file.
            /// *   **Checking**: The system is checking the uploaded backup file.
            /// *   **Finished**: The backup task is completed.
            /// </summary>
            [NameInMap("BackupProgressStatus")]
            [Validation(Required=false)]
            public string BackupProgressStatus { get; set; }

            /// <summary>
            /// The backup mode. Valid values:
            /// 
            /// *   **Automated**: automatic backup
            /// *   **Manual**: manual backup
            /// </summary>
            [NameInMap("JobMode")]
            [Validation(Required=false)]
            public string JobMode { get; set; }

            /// <summary>
            /// The ID of the data node.
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// The progress of the backup task in percentage.
            /// </summary>
            [NameInMap("Process")]
            [Validation(Required=false)]
            public string Process { get; set; }

            /// <summary>
            /// The start time of the backup task. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The type of the backup task. Valid values:
            /// 
            /// *   **TempBackupTask**: The backup task was manually performed.
            /// *   **NormalBackupTask**: The backup task was automatically performed.
            /// </summary>
            [NameInMap("TaskAction")]
            [Validation(Required=false)]
            public string TaskAction { get; set; }

        }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The status of the backup task. Valid values:
        /// 
        /// *   **NoStart**: The backup task is not started.
        /// *   **Preparing**: The backup task is being prepared.
        /// *   **Waiting**: The backup task is pending.
        /// *   **Uploading:** The system is uploading the backup file.
        /// *   **Checking:** The system is checking the uploaded backup file.
        /// *   **Finished**: The backup task is complete.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeBackupTasksResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeBackupTasksResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeBackupTasksResponseBodyAccessDeniedDetail : TeaModel {
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// The ID of the ApsaraDB for Redis instance. You can call the [DescribeInstances](~~60933~~) operation to query instance IDs.
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
            public int? BackupJobID { get; set; }

            /// <summary>
            /// The beginning time when the backup task started. The time is in the *yyyy-MM-dd*T*HH:mm:ss*Z format and displayed in UTC.
            /// </summary>
            [NameInMap("BackupProgressStatus")]
            [Validation(Required=false)]
            public string BackupProgressStatus { get; set; }

            /// <summary>
            /// Manual
            /// </summary>
            [NameInMap("JobMode")]
            [Validation(Required=false)]
            public string JobMode { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// The backup mode. Valid values:
            /// 
            /// *   **Automated**: automatic backup
            /// *   **Manual**: manual backup
            /// </summary>
            [NameInMap("Process")]
            [Validation(Required=false)]
            public string Process { get; set; }

            /// <summary>
            /// 1162****
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeBackupTasksResponseBody : TeaModel {
        /// <summary>
        /// The details of the backup task.
        /// </summary>
        [NameInMap("BackupJobs")]
        [Validation(Required=false)]
        public List<DescribeBackupTasksResponseBodyBackupJobs> BackupJobs { get; set; }
        public class DescribeBackupTasksResponseBodyBackupJobs : TeaModel {
            /// <summary>
            /// The backup task status. Valid values:
            /// 
            /// *   **Scheduled**: The backup task is in planning. Regular backup tasks that have not started are also in this state.
            /// *   **Checking**: The instance is being checked before the backup.
            /// *   **Backuping**: The backup task is in progress.
            /// *   **Finished**: The backup task is completed.
            /// </summary>
            [NameInMap("BackupSetStatus")]
            [Validation(Required=false)]
            public string BackupSetStatus { get; set; }

            /// <summary>
            /// The start time of the backup task.
            /// </summary>
            [NameInMap("BackupStartTime")]
            [Validation(Required=false)]
            public string BackupStartTime { get; set; }

            /// <summary>
            /// The ID of the backup task.
            /// </summary>
            [NameInMap("BackupjobId")]
            [Validation(Required=false)]
            public string BackupjobId { get; set; }

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
            /// The progress of the backup task. Unit: %. The progress is returned only for running backup tasks.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

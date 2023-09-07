// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBackupTasksResponseBody : TeaModel {
        /// <summary>
        /// The details of the backup task.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupTasksResponseBodyItems Items { get; set; }
        public class DescribeBackupTasksResponseBodyItems : TeaModel {
            [NameInMap("BackupJob")]
            [Validation(Required=false)]
            public List<DescribeBackupTasksResponseBodyItemsBackupJob> BackupJob { get; set; }
            public class DescribeBackupTasksResponseBodyItemsBackupJob : TeaModel {
                /// <summary>
                /// The ID of the backup task.
                /// </summary>
                [NameInMap("BackupJobId")]
                [Validation(Required=false)]
                public string BackupJobId { get; set; }

                /// <summary>
                /// The state of the backup task. Valid values:
                /// 
                /// *   **NoStart**
                /// *   **Preparing**
                /// *   **Waiting**
                /// *   **Uploading**
                /// *   **Checking**
                /// *   **Finished**
                /// </summary>
                [NameInMap("BackupProgressStatus")]
                [Validation(Required=false)]
                public string BackupProgressStatus { get; set; }

                /// <summary>
                /// The backup mode. Valid values:
                /// 
                /// *   **Automated**
                /// *   **Manual**
                /// </summary>
                [NameInMap("JobMode")]
                [Validation(Required=false)]
                public string JobMode { get; set; }

                /// <summary>
                /// The progress of the backup task in percentage.
                /// </summary>
                [NameInMap("Process")]
                [Validation(Required=false)]
                public string Process { get; set; }

                /// <summary>
                /// The time when the backup task started. The time follows the ISO 8601 standard in the `YYYY-MM-DDThh:mm:ssZ` format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The type of the backup task. Valid values:
                /// 
                /// *   **TempBackupTask**: The backup task is an adhoc backup task.
                /// *   **NormalBackupTask**: The backup task is a common backup task.
                /// </summary>
                [NameInMap("TaskAction")]
                [Validation(Required=false)]
                public string TaskAction { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

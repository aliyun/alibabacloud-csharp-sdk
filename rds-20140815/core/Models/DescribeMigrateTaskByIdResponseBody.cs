// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeMigrateTaskByIdResponseBody : TeaModel {
        /// <summary>
        /// The type of the migration task. Valid values:
        /// 
        /// *   **FULL**: The migration task migrates full backup files that can be used to restore the full data of the instance.
        /// *   **UPDF**: The migration task migrates incremental or log backup files that can be used to restore the incremental data of the instance.
        /// </summary>
        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public string BackupMode { get; set; }

        /// <summary>
        /// The time when the migration task was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// The description of the migration task.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The time when the migration task was completed. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// Indicates whether the imported data overwrites the existing data. Valid values:
        /// 
        /// *   **False**: The imported data does not overwrite the existing data.
        /// *   **True**: The imported data overwrites the existing data.
        /// </summary>
        [NameInMap("IsDBReplaced")]
        [Validation(Required=false)]
        public string IsDBReplaced { get; set; }

        /// <summary>
        /// The ID of the migration task.
        /// </summary>
        [NameInMap("MigrateTaskId")]
        [Validation(Required=false)]
        public string MigrateTaskId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the migration task. Valid values:
        /// 
        /// *   **NoStart**: The task has not started.
        /// *   **Running**:The task is in progress.
        /// *   **Success**: The task is successful.
        /// *   **Failed**: The task failed.
        /// *   **Waiting**: The task is waiting for an incremental backup file to be imported.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

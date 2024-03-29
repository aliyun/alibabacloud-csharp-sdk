// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeMigrateTasksResponseBody : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The details of the migration task.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeMigrateTasksResponseBodyItems Items { get; set; }
        public class DescribeMigrateTasksResponseBodyItems : TeaModel {
            [NameInMap("MigrateTask")]
            [Validation(Required=false)]
            public List<DescribeMigrateTasksResponseBodyItemsMigrateTask> MigrateTask { get; set; }
            public class DescribeMigrateTasksResponseBodyItemsMigrateTask : TeaModel {
                /// <summary>
                /// The migration task type. Valid values:
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
                /// The database name.
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
                /// Indicates whether the imported data overwrites the existing data.
                /// </summary>
                [NameInMap("IsDBReplaced")]
                [Validation(Required=false)]
                public string IsDBReplaced { get; set; }

                /// <summary>
                /// The migration task ID.
                /// </summary>
                [NameInMap("MigrateTaskId")]
                [Validation(Required=false)]
                public string MigrateTaskId { get; set; }

                /// <summary>
                /// The status of the migration task. Valid values:
                /// 
                /// *   **NoStart**: The task is not started.
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

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeActiveOperationTaskResponseBody : TeaModel {
        /// <summary>
        /// Details of O\\&M tasks.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeActiveOperationTaskResponseBodyItems> Items { get; set; }
        public class DescribeActiveOperationTaskResponseBodyItems : TeaModel {
            /// <summary>
            /// The time when the O\\&M task was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*hh:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// The database type of the instance. The return value is **Redis**.
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// The deadline before which the time to preform the O&M task can be modified. The time in UTC is displayed in the *yyyy-MM-dd*T*HH:mm:ss*Z format.
            /// </summary>
            [NameInMap("Deadline")]
            [Validation(Required=false)]
            public string Deadline { get; set; }

            /// <summary>
            /// The ID of the O&M task.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InsName")]
            [Validation(Required=false)]
            public string InsName { get; set; }

            /// <summary>
            /// The time when the O\\&M task was modified. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*hh:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// The required preparation period between the task start time and the switchover time. The time is displayed in the *HH:mm:ss* format.
            /// </summary>
            [NameInMap("PrepareInterval")]
            [Validation(Required=false)]
            public string PrepareInterval { get; set; }

            /// <summary>
            /// The region ID of the instance.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The time when the O\\&M task was preformed. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*hh:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The state of the O&M task. Valid values:
            /// 
            /// *   **2**: The task is waiting for users to specify a switchover time.
            /// *   **3**: The task is waiting to be performed.
            /// *   **4**: The task is being performed. If the task is in this state, the [ModifyActiveOperationTask](~~ModifyActiveOperationTask~~) operation cannot be called to modify the scheduled switchover time.
            /// *   **5**: The task is performed.
            /// *   **6**: The task fails.
            /// *   **7**: The task is canceled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The time when the system performs the switchover operation. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*hh:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

            /// <summary>
            /// The type of the task. Valid values:
            /// 
            /// *   **rds_apsaradb_ha**: master-replica switchover
            /// *   **rds_apsaradb_transfer**: instance migration
            /// *   **rds_apsaradb_upgrade**: minor version update
            /// *   **all**: all types
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The maximum number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}

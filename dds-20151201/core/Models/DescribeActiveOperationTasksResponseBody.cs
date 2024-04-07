// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeActiveOperationTasksResponseBody : TeaModel {
        /// <summary>
        /// The O\&M tasks.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeActiveOperationTasksResponseBodyItems> Items { get; set; }
        public class DescribeActiveOperationTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// N/A
            /// </summary>
            [NameInMap("AllowCancel")]
            [Validation(Required=false)]
            public string AllowCancel { get; set; }

            /// <summary>
            /// Indicates whether the modification operation is allowed.
            /// 
            /// *   **0**: The modification operation is not allowed.
            /// *   **1**: The modification operation is allowed.
            /// </summary>
            [NameInMap("AllowChange")]
            [Validation(Required=false)]
            public string AllowChange { get; set; }

            /// <summary>
            /// The change level of the O\&M task.
            /// </summary>
            [NameInMap("ChangeLevel")]
            [Validation(Required=false)]
            public string ChangeLevel { get; set; }

            /// <summary>
            /// N/A
            /// </summary>
            [NameInMap("ChangeLevelEn")]
            [Validation(Required=false)]
            public string ChangeLevelEn { get; set; }

            /// <summary>
            /// The task type in English.
            /// </summary>
            [NameInMap("ChangeLevelZh")]
            [Validation(Required=false)]
            public string ChangeLevelZh { get; set; }

            /// <summary>
            /// The time when the task was created.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// N/A
            /// </summary>
            [NameInMap("CurrentAVZ")]
            [Validation(Required=false)]
            public string CurrentAVZ { get; set; }

            /// <summary>
            /// The type of the database engine.
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// The version of the database engine.
            /// </summary>
            [NameInMap("DbVersion")]
            [Validation(Required=false)]
            public string DbVersion { get; set; }

            /// <summary>
            /// The end time of the O\&M task.
            /// </summary>
            [NameInMap("Deadline")]
            [Validation(Required=false)]
            public string Deadline { get; set; }

            /// <summary>
            /// The task ID.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// N/A
            /// </summary>
            [NameInMap("ImpactEn")]
            [Validation(Required=false)]
            public string ImpactEn { get; set; }

            /// <summary>
            /// N/A
            /// </summary>
            [NameInMap("ImpactZh")]
            [Validation(Required=false)]
            public string ImpactZh { get; set; }

            /// <summary>
            /// The description of the instance.
            /// </summary>
            [NameInMap("InsComment")]
            [Validation(Required=false)]
            public string InsComment { get; set; }

            /// <summary>
            /// The ID of the node.
            /// </summary>
            [NameInMap("InsName")]
            [Validation(Required=false)]
            public string InsName { get; set; }

            /// <summary>
            /// The time when the task is modified. The time follows the ISO 8601 standard in the *yyyy-mm-dd*T*hh:mm:ss*Z format. The time is displayed in UTC.
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
            /// The region of the instance.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The result information. The value of this parameter can be ignored.
            /// </summary>
            [NameInMap("ResultInfo")]
            [Validation(Required=false)]
            public string ResultInfo { get; set; }

            /// <summary>
            /// The start time of the task. The time follows the ISO 8601 standard in the *yyyy-mm-dd* T*hh:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// N/A
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The subinstances.
            /// </summary>
            [NameInMap("SubInsNames")]
            [Validation(Required=false)]
            public List<string> SubInsNames { get; set; }

            /// <summary>
            /// The switchover point in time in which disconnection may occur. The time follows the ISO 8601 standard in the *yyyy-mm-dd*T*hh:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

            /// <summary>
            /// The task type.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// N/A
            /// </summary>
            [NameInMap("TaskTypeEn")]
            [Validation(Required=false)]
            public string TaskTypeEn { get; set; }

            /// <summary>
            /// The task type in Chinese.
            /// </summary>
            [NameInMap("TaskTypeZh")]
            [Validation(Required=false)]
            public string TaskTypeZh { get; set; }

        }

        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
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
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}

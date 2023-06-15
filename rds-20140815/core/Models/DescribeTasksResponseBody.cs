// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeTasksResponseBody : TeaModel {
        /// <summary>
        /// The details of the task execution.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeTasksResponseBodyItems Items { get; set; }
        public class DescribeTasksResponseBodyItems : TeaModel {
            [NameInMap("TaskProgressInfo")]
            [Validation(Required=false)]
            public List<DescribeTasksResponseBodyItemsTaskProgressInfo> TaskProgressInfo { get; set; }
            public class DescribeTasksResponseBodyItemsTaskProgressInfo : TeaModel {
                /// <summary>
                /// The start time of the task. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm*Z format. The time is displayed in UTC .
                /// </summary>
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public string BeginTime { get; set; }

                /// <summary>
                /// The name of the subtask.
                /// </summary>
                [NameInMap("CurrentStepName")]
                [Validation(Required=false)]
                public string CurrentStepName { get; set; }

                /// <summary>
                /// The name of the database. If the task involves a database, the database name is returned.
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// The estimated end time of the task.
                /// 
                /// > In most cases, this parameter is empty.
                /// </summary>
                [NameInMap("ExpectedFinishTime")]
                [Validation(Required=false)]
                public string ExpectedFinishTime { get; set; }

                /// <summary>
                /// The end time of the task. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// The progress of the task in percentage.
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// The description of the task progress.
                /// 
                /// > If no progress description is provided for the task, this parameter is empty.
                /// </summary>
                [NameInMap("ProgressInfo")]
                [Validation(Required=false)]
                public string ProgressInfo { get; set; }

                /// <summary>
                /// The estimated remaining time of the task. Unit: seconds.
                /// 
                /// >  If the task is not running, this parameter is not returned or the returned value is **0**.
                /// </summary>
                [NameInMap("Remain")]
                [Validation(Required=false)]
                public int? Remain { get; set; }

                /// <summary>
                /// The status of the task.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The progress of the subtask. For example, a value of `1/4` indicates that the task consists of four subtasks and the first subtask is in progress.
                /// </summary>
                [NameInMap("StepProgressInfo")]
                [Validation(Required=false)]
                public string StepProgressInfo { get; set; }

                /// <summary>
                /// The details of the subtasks.
                /// </summary>
                [NameInMap("StepsInfo")]
                [Validation(Required=false)]
                public string StepsInfo { get; set; }

                /// <summary>
                /// The operation that is used by the task, such as **CreateDBInstance**.
                /// </summary>
                [NameInMap("TaskAction")]
                [Validation(Required=false)]
                public string TaskAction { get; set; }

                /// <summary>
                /// The error code that is returned when an error occurs.
                /// 
                /// > This parameter is returned only when an error occurs.
                /// </summary>
                [NameInMap("TaskErrorCode")]
                [Validation(Required=false)]
                public string TaskErrorCode { get; set; }

                /// <summary>
                /// The error message that is returned when an error occurs.
                /// 
                /// >  This parameter is returned only when an error occurs.
                /// </summary>
                [NameInMap("TaskErrorMessage")]
                [Validation(Required=false)]
                public string TaskErrorMessage { get; set; }

                /// <summary>
                /// The ID of the task.
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries on the current page.
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
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}

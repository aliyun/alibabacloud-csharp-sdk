// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeTasksResponseBody : TeaModel {
        /// <summary>
        /// The details of the task.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeTasksResponseBodyItems> Items { get; set; }
        public class DescribeTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// The beginning time of the task. The time follows the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
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
            /// The end time of the task. The time follows the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// The progress of the task. Unit: %.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public float? Progress { get; set; }

            /// <summary>
            /// The estimated remaining duration of the task. Unit: seconds.
            /// 
            /// >  If the task is not running, this parameter is not returned or the returned value is **0**.
            /// </summary>
            [NameInMap("Remain")]
            [Validation(Required=false)]
            public int? Remain { get; set; }

            /// <summary>
            /// The status of the task. Valid values:
            /// 
            /// *   **0**: The task is pending.
            /// *   **1**: The task is running.
            /// *   **2**: The task is complete.
            /// *   **4**: The task is closed.
            /// *   **7**: The task is paused.
            /// *   **8**: The task is interrupted.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The progress of the subtask.
            /// 
            /// >  If the subtask does not exist, this parameter is not returned.
            /// </summary>
            [NameInMap("StepProgressInfo")]
            [Validation(Required=false)]
            public string StepProgressInfo { get; set; }

            /// <summary>
            /// The information about the subtask in the JSON format. This includes the expected remaining duration (**remain**), the name of the subtask (**name**), and the task progress (**progress**).
            /// 
            /// >  If the subtask does not exist, this parameter is not returned.
            /// </summary>
            [NameInMap("StepsInfo")]
            [Validation(Required=false)]
            public string StepsInfo { get; set; }

            /// <summary>
            /// The identifier of the task.
            /// </summary>
            [NameInMap("TaskAction")]
            [Validation(Required=false)]
            public string TaskAction { get; set; }

            /// <summary>
            /// The ID of the task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
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
        /// The total number of entries.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}

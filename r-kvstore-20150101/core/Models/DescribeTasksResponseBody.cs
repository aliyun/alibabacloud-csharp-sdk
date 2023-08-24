// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeTasksResponseBody : TeaModel {
        /// <summary>
        /// The estimated remaining duration of the task. Unit: seconds.
        /// 
        /// >  If the task is not running, this parameter is not returned or the returned value is **0**.
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
            /// The ID of the request.
            /// </summary>
            [NameInMap("CurrentStepName")]
            [Validation(Required=false)]
            public string CurrentStepName { get; set; }

            /// <summary>
            /// The beginning of the time range to query. Specify the time in the *yyyy-MM-dd*T*HH:mm*Z format. The time must be in UTC.
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// The number of entries returned on each page.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public float? Progress { get; set; }

            /// <summary>
            /// 2
            /// </summary>
            [NameInMap("Remain")]
            [Validation(Required=false)]
            public int? Remain { get; set; }

            /// <summary>
            /// 1
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The end time of the task. The time follows the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("StepProgressInfo")]
            [Validation(Required=false)]
            public string StepProgressInfo { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("StepsInfo")]
            [Validation(Required=false)]
            public string StepsInfo { get; set; }

            [NameInMap("TaskAction")]
            [Validation(Required=false)]
            public string TaskAction { get; set; }

            /// <summary>
            /// The name of the subtask.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// The ID of the instance. You can call the [DescribeInstances](~~60933~~) operation to query instance IDs.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 30
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The status of the task. Separate multiple values with commas (,). Valid values:
        /// 
        /// *   **0**: The task is pending.
        /// *   **1**: The task is running.
        /// *   **2**: The task is complete.
        /// *   **4**: The task is closed.
        /// *   **7**: The task is paused.
        /// *   **8**: The task is interrupted.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the subtask in the JSON format. This includes the expected remaining duration (**remain**), the name of the subtask (**name**), and the task progress (**progress**).
        /// 
        /// >  If the subtask does not exist, this parameter is not returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}

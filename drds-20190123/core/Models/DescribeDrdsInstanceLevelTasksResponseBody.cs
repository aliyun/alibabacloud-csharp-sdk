// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsInstanceLevelTasksResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The list of returned unfinished tasks.
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public DescribeDrdsInstanceLevelTasksResponseBodyTasks Tasks { get; set; }
        public class DescribeDrdsInstanceLevelTasksResponseBodyTasks : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<DescribeDrdsInstanceLevelTasksResponseBodyTasksTask> Task { get; set; }
            public class DescribeDrdsInstanceLevelTasksResponseBodyTasksTask : TeaModel {
                /// <summary>
                /// Indicates whether the task can be canceled.
                /// </summary>
                [NameInMap("AllowCancel")]
                [Validation(Required=false)]
                public bool? AllowCancel { get; set; }

                /// <summary>
                /// The error message returned for the task.
                /// </summary>
                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                /// <summary>
                /// The timestamp when the task is created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// The progress of the task. Valid values: 0 to 100.
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// The description of the task progress.
                /// </summary>
                [NameInMap("ProgressDescription")]
                [Validation(Required=false)]
                public string ProgressDescription { get; set; }

                /// <summary>
                /// Indicates whether the progress of the task is displayed.
                /// </summary>
                [NameInMap("ShowProgress")]
                [Validation(Required=false)]
                public bool? ShowProgress { get; set; }

                /// <summary>
                /// The ID of the task.
                /// </summary>
                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public long? TargetId { get; set; }

                /// <summary>
                /// The name of the task.
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// The phase of the task.
                /// </summary>
                [NameInMap("TaskPhase")]
                [Validation(Required=false)]
                public string TaskPhase { get; set; }

                /// <summary>
                /// The state of the task. Valid values:
                /// 
                /// *   0: The task is being executed.
                /// *   1: The task is executed.
                /// *   2: The task failed to be executed.
                /// *   3: The task is canceled.
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public int? TaskStatus { get; set; }

                /// <summary>
                /// The type of the task.
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public int? TaskType { get; set; }

            }

        }

    }

}

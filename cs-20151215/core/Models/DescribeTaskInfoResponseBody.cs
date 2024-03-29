// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The time when the task was created.
        /// </summary>
        [NameInMap("created")]
        [Validation(Required=false)]
        public string Created { get; set; }

        /// <summary>
        /// The current stage of the task.
        /// </summary>
        [NameInMap("current_stage")]
        [Validation(Required=false)]
        public string CurrentStage { get; set; }

        /// <summary>
        /// The error returned for the task.
        /// </summary>
        [NameInMap("error")]
        [Validation(Required=false)]
        public DescribeTaskInfoResponseBodyError Error { get; set; }
        public class DescribeTaskInfoResponseBodyError : TeaModel {
            /// <summary>
            /// The error code returned.
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The error message returned.
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// The event generated by the task.
        /// </summary>
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<DescribeTaskInfoResponseBodyEvents> Events { get; set; }
        public class DescribeTaskInfoResponseBodyEvents : TeaModel {
            /// <summary>
            /// The action of the event.
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The severity level of the event.
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// The message about the event.
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The cause of the event.
            /// </summary>
            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// The source of the event.
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The timestamp when the event was generated.
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

        }

        /// <summary>
        /// The task parameters.
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// Detailed information about the stage of the task.
        /// </summary>
        [NameInMap("stages")]
        [Validation(Required=false)]
        public List<DescribeTaskInfoResponseBodyStages> Stages { get; set; }
        public class DescribeTaskInfoResponseBodyStages : TeaModel {
            /// <summary>
            /// The end time of the stage.
            /// </summary>
            [NameInMap("end_time")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The message about the stage.
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The output generated at the stage.
            /// </summary>
            [NameInMap("outputs")]
            [Validation(Required=false)]
            public Dictionary<string, object> Outputs { get; set; }

            /// <summary>
            /// The start time of the stage.
            /// </summary>
            [NameInMap("start_time")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The status of the stage.
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// The status of the task. Valid values:
        /// 
        /// *   `running`: The task is running.
        /// *   `failed`: The task failed.
        /// *   `success`: The task is complete.
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The object of the task.
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public DescribeTaskInfoResponseBodyTarget Target { get; set; }
        public class DescribeTaskInfoResponseBodyTarget : TeaModel {
            /// <summary>
            /// The ID of the object.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The type of the object.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The task ID.
        /// </summary>
        [NameInMap("task_id")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The execution details of the task.
        /// </summary>
        [NameInMap("task_result")]
        [Validation(Required=false)]
        public List<DescribeTaskInfoResponseBodyTaskResult> TaskResult { get; set; }
        public class DescribeTaskInfoResponseBodyTaskResult : TeaModel {
            /// <summary>
            /// The resources that are managed by the task. For a scale-out task, the value of this parameter is the ID of the instance that is added by the task.
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            /// <summary>
            /// The status of the scale-out task. Valid values:
            /// 
            /// *   `success`: The scale-out task is successful.
            /// *   `success`: The scale-out task failed.
            /// *   `initial`: The scale-out task is being initialized.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The task type. A value of `cluster_scaleout` indicates a scale-out task.
        /// </summary>
        [NameInMap("task_type")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// The time when the task was updated.
        /// </summary>
        [NameInMap("updated")]
        [Validation(Required=false)]
        public string Updated { get; set; }

    }

}

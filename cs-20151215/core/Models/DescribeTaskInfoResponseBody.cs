// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// The ID of the ACK cluster.
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

        [NameInMap("current_stage")]
        [Validation(Required=false)]
        public string CurrentStage { get; set; }

        [NameInMap("error")]
        [Validation(Required=false)]
        public DescribeTaskInfoResponseBodyError Error { get; set; }
        public class DescribeTaskInfoResponseBodyError : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        [NameInMap("events")]
        [Validation(Required=false)]
        public List<DescribeTaskInfoResponseBodyEvents> Events { get; set; }
        public class DescribeTaskInfoResponseBodyEvents : TeaModel {
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

        }

        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        [NameInMap("stages")]
        [Validation(Required=false)]
        public List<DescribeTaskInfoResponseBodyStages> Stages { get; set; }
        public class DescribeTaskInfoResponseBodyStages : TeaModel {
            [NameInMap("end_time")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("outputs")]
            [Validation(Required=false)]
            public Dictionary<string, object> Outputs { get; set; }

            [NameInMap("start_time")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// The state of the task. Valid values:
        /// 
        /// *   `running`: The task is running.
        /// *   `fail`: The task failed.
        /// *   `success`: The task is complete.
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("target")]
        [Validation(Required=false)]
        public DescribeTaskInfoResponseBodyTarget Target { get; set; }
        public class DescribeTaskInfoResponseBodyTarget : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the task.
        /// </summary>
        [NameInMap("task_id")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The execution result of the task.
        /// </summary>
        [NameInMap("task_result")]
        [Validation(Required=false)]
        public List<DescribeTaskInfoResponseBodyTaskResult> TaskResult { get; set; }
        public class DescribeTaskInfoResponseBodyTaskResult : TeaModel {
            /// <summary>
            /// The resources that are managed by the task. For a scale-out task, the value of this parameter the ID of the instance that is added by the task.
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            /// <summary>
            /// The state of the scaling of the resource. Valid values:
            /// 
            /// *   `success`: The scale-out task is successful.
            /// *   `failed`: The scale-out task failed.
            /// *   `initail`: The scale-out task is initializing.
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

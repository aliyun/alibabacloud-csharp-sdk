// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class PauseAgentTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E38B41A8-8E00-5AE4-A957-6636ACB8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<PauseAgentTaskResponseBodyTasks> Tasks { get; set; }
        public class PauseAgentTaskResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The current status of the task. The following are possible values:</para>
            /// <para>PENDING: The task is being created.</para>
            /// <para>RUNNING: The task is running.</para>
            /// <para>COMPLETED: The task is completed.</para>
            /// <para>FAILED: The task failed.</para>
            /// <para>TIMEOUT: The task timed out.</para>
            /// <para>PAUSING: The task is being paused.</para>
            /// <para>PAUSED: The task is paused.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PAUSING</para>
            /// </summary>
            [NameInMap("CurrentStatus")]
            [Validation(Required=false)]
            public string CurrentStatus { get; set; }

            /// <summary>
            /// <para>The reason the task failed to pause.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Task status [COMPLETED] does not support pause, only RUNNING tasks can be paused.</para>
            /// </summary>
            [NameInMap("FailedReason")]
            [Validation(Required=false)]
            public string FailedReason { get; set; }

            /// <summary>
            /// <para>The ID of the Mobile node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp-anzzuho371azi44xr</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The time when the pause request was initiated, in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-13T17:42:19Z</para>
            /// </summary>
            [NameInMap("PausingAt")]
            [Validation(Required=false)]
            public string PausingAt { get; set; }

            /// <summary>
            /// <para>The status of the task before the pause request. The only valid value is:</para>
            /// <para>RUNNING: The task is running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("PreviousStatus")]
            [Validation(Required=false)]
            public string PreviousStatus { get; set; }

            /// <summary>
            /// <para>The unique ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-imr0fufqd7cle****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}

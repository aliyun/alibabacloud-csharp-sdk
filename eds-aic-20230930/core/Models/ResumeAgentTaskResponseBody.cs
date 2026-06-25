// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ResumeAgentTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status code.</para>
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
        /// <para>1A923337-44D9-5CAD-9A53-95084BD4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ResumeAgentTaskResponseBodyTasks> Tasks { get; set; }
        public class ResumeAgentTaskResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The current status of the task. Valid values:</para>
            /// <para><c>PENDING</c>: The task is being created.</para>
            /// <para><c>RUNNING</c>: The task is running.</para>
            /// <para><c>COMPLETED</c>: The task has completed.</para>
            /// <para><c>FAILED</c>: The task has failed.</para>
            /// <para><c>TIMEOUT</c>: The task has timed out.</para>
            /// <para><c>PAUSING</c>: The task is pausing.</para>
            /// <para><c>PAUSED</c>: The task is paused.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("CurrentStatus")]
            [Validation(Required=false)]
            public string CurrentStatus { get; set; }

            /// <summary>
            /// <para>The reason why the task failed to resume.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Task status [COMPLETED] does not support resume, only PAUSED tasks can be resumed.</para>
            /// </summary>
            [NameInMap("FailedReason")]
            [Validation(Required=false)]
            public string FailedReason { get; set; }

            /// <summary>
            /// <para>The ID of the mobile instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp-ek65k51zoxia3x8xz</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The time when the task was resumed, in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-13T17:42:19Z</para>
            /// </summary>
            [NameInMap("ResumingAt")]
            [Validation(Required=false)]
            public string ResumingAt { get; set; }

            /// <summary>
            /// <para>The globally unique ID of the task.</para>
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

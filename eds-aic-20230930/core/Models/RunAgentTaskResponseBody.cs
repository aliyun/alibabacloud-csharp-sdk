// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class RunAgentTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;200&quot; indicates success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The number of tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The message returned by the API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C8439B9-7DBF-57F4-92AE-55A9B9D3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<RunAgentTaskResponseBodyTasks> Tasks { get; set; }
        public class RunAgentTaskResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The current status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PENDING: The task is being created.</description></item>
            /// <item><description>RUNNING: The task is running.</description></item>
            /// <item><description>COMPLETED: The task is completed.</description></item>
            /// <item><description>FAILED: The task failed.</description></item>
            /// <item><description>TIMEOUT: The task execution timed out.</description></item>
            /// <item><description>CALL_FOR_USER: The task is waiting for user operations.</description></item>
            /// <item><description>PAUSING: The task is being paused.</description></item>
            /// <item><description>PAUSED: The task is paused.</description></item>
            /// <item><description>CANCELLING: The task is being canceled.</description></item>
            /// <item><description>CANCELED: The task is canceled.</description></item>
            /// <item><description>STOPPED: The task is stopped.</description></item>
            /// <item><description>TIMEOUT: The task timed out.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("CurrentStatus")]
            [Validation(Required=false)]
            public string CurrentStatus { get; set; }

            /// <summary>
            /// <para>The ID of the Mobile node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp-ek65k51zoxia3x8xz</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The time when the task was created. The time is in the ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-13T17:42:19Z</para>
            /// </summary>
            [NameInMap("RunningAt")]
            [Validation(Required=false)]
            public string RunningAt { get; set; }

            /// <summary>
            /// <para>The session ID. Tasks with the same session ID share the context.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ses-260702-21bh****。</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The globally unique ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-imr0fufqd7cle****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The user prompt in natural language. The agent performs operations based on this prompt.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Download DingTalk from the app store</para>
            /// </summary>
            [NameInMap("UserPrompt")]
            [Validation(Required=false)]
            public string UserPrompt { get; set; }

        }

    }

}

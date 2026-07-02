// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class RunAgentTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>For example, &quot;200&quot; indicates success.</para>
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
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("CurrentStatus")]
            [Validation(Required=false)]
            public string CurrentStatus { get; set; }

            /// <summary>
            /// <para>The Mobile node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp-ek65k51zoxia3x8xz</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The time when the task was created, in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-13T17:42:19Z</para>
            /// </summary>
            [NameInMap("RunningAt")]
            [Validation(Required=false)]
            public string RunningAt { get; set; }

            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The task ID, which is globally unique.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-imr0fufqd7cle****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The user instruction in natural language. The Agent performs operations based on this instruction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Download DingTalk from App Store</para>
            /// </summary>
            [NameInMap("UserPrompt")]
            [Validation(Required=false)]
            public string UserPrompt { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeAgentTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status code.</para>
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
        /// <para>The message returned by the API.</para>
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
        /// <para>310A783E-CC46-5452-A8A3-71AE5DB5****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<DescribeAgentTaskResponseBodyTasks> Tasks { get; set; }
        public class DescribeAgentTaskResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The current status of the task. Valid values:</para>
            /// <para>PENDING: The task is being created.</para>
            /// <para>RUNNING: The task is running.</para>
            /// <para>COMPLETED: The task is completed.</para>
            /// <para>FAILED: The task failed.</para>
            /// <para>TIMEOUT: The task execution timed out.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("CurrentStatus")]
            [Validation(Required=false)]
            public string CurrentStatus { get; set; }

            [NameInMap("DigestSource")]
            [Validation(Required=false)]
            public string DigestSource { get; set; }

            /// <summary>
            /// <para>The Mobile node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp-anzzuho371azi44xr</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The time when the task was created, in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-13T17:42:19Z</para>
            /// </summary>
            [NameInMap("RunningAt")]
            [Validation(Required=false)]
            public string RunningAt { get; set; }

            /// <summary>
            /// <para>The number of steps executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Steps")]
            [Validation(Required=false)]
            public string Steps { get; set; }

            [NameInMap("TaskDigest")]
            [Validation(Required=false)]
            public string TaskDigest { get; set; }

            /// <summary>
            /// <para>The task duration. This field is returned only when CurrentStatus is FAILED or COMPLETED.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TaskDuration")]
            [Validation(Required=false)]
            public string TaskDuration { get; set; }

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
            /// <para>The task result in the desired state. This field is returned only when CurrentStatus is COMPLETED or FAILED.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Download DingTalk succeeded.</para>
            /// </summary>
            [NameInMap("TaskResult")]
            [Validation(Required=false)]
            public string TaskResult { get; set; }

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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class RunAgentTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code. A value of <c>200</c> indicates that the request was successful.</para>
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
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C8439B9-7DBF-57F4-92AE-55A9B9D3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<RunAgentTaskResponseBodyTasks> Tasks { get; set; }
        public class RunAgentTaskResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The current status of the task. Valid values:</para>
            /// <para><c>PENDING</c>: The task is being created.</para>
            /// <para><c>RUNNING</c>: The task is running.</para>
            /// <para><c>COMPLETED</c>: The task completed successfully.</para>
            /// <para><c>FAILED</c>: The task failed.</para>
            /// <para><c>TIMEOUT</c>: The task timed out.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("CurrentStatus")]
            [Validation(Required=false)]
            public string CurrentStatus { get; set; }

            /// <summary>
            /// <para>The mobile node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp-ek65k51zoxia3x8xz</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The time when the task started running, in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-13T17:42:19Z</para>
            /// </summary>
            [NameInMap("RunningAt")]
            [Validation(Required=false)]
            public string RunningAt { get; set; }

            /// <summary>
            /// <para>The globally unique task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-imr0fufqd7cle****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The user prompt that the Agent used to perform the task.</para>
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

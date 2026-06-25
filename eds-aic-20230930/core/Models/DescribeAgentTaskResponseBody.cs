// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeAgentTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>For example, &quot;200&quot; indicates success.</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The task count.</para>
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
        /// <para>310A783E-CC46-5452-A8A3-71AE5DB5****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<DescribeAgentTaskResponseBodyTasks> Tasks { get; set; }
        public class DescribeAgentTaskResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The task\&quot;s current status. Valid values:</para>
            /// <para><c>PENDING</c>: The task is being created.</para>
            /// <para><c>RUNNING</c>: The task is running.</para>
            /// <para><c>COMPLETED</c>: The task has completed.</para>
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
            /// <para>acp-anzzuho371azi44xr</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The task\&quot;s creation time, in ISO 8601 format.</para>
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

            /// <summary>
            /// <para>The task duration. This field is returned only when <c>CurrentStatus</c> is <c>FAILED</c> or <c>COMPLETED</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TaskDuration")]
            [Validation(Required=false)]
            public string TaskDuration { get; set; }

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
            /// <para>The task result. This field is returned only when <c>CurrentStatus</c> is <c>COMPLETED</c> or <c>FAILED</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Download DingTalk succeeded.</para>
            /// </summary>
            [NameInMap("TaskResult")]
            [Validation(Required=false)]
            public string TaskResult { get; set; }

            /// <summary>
            /// <para>The user prompt that the Agent uses to perform the task.</para>
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

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
        /// <para>The list of tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<DescribeAgentTaskResponseBodyTasks> Tasks { get; set; }
        public class DescribeAgentTaskResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The number of task artifacts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ArtifactCount")]
            [Validation(Required=false)]
            public int? ArtifactCount { get; set; }

            /// <summary>
            /// <para>The list of uploaded task artifacts.</para>
            /// </summary>
            [NameInMap("Artifacts")]
            [Validation(Required=false)]
            public List<DescribeAgentTaskResponseBodyTasksArtifacts> Artifacts { get; set; }
            public class DescribeAgentTaskResponseBodyTasksArtifacts : TeaModel {
                /// <summary>
                /// <para>The MIME type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>image/png</para>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <para>The OSS pre-signed download URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://bucket.oss-cn-hangzhou.aliyuncs.com/">https://bucket.oss-cn-hangzhou.aliyuncs.com/</a>...</para>
                /// </summary>
                [NameInMap("DownloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                /// <summary>
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>screenshot.png</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The file size in bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <para>The upload time in ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-08-05T10:00:00+08:00</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public string UpdatedTime { get; set; }

            }

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
            /// <para>The source of the digest. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PROMPT_AUTO: auto-generated.</description></item>
            /// <item><description>RESULT_AUTO: result refinement.</description></item>
            /// <item><description>USER: user-edited.</description></item>
            /// </list>
            /// </summary>
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

            /// <summary>
            /// <para>The task digest text, up to 25 characters.</para>
            /// </summary>
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

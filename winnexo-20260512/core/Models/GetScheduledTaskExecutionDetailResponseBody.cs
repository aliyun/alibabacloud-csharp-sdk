// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetScheduledTaskExecutionDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The completion time in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("completedAt")]
        [Validation(Required=false)]
        public string CompletedAt { get; set; }

        /// <summary>
        /// <para>The full execution content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample content</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The list of digital employee names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("digitalEmployeeName")]
        [Validation(Required=false)]
        public List<string> DigitalEmployeeName { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The execution ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleExecutionId</para>
        /// </summary>
        [NameInMap("executionId")]
        [Validation(Required=false)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// <para>The list of output files.</para>
        /// </summary>
        [NameInMap("files")]
        [Validation(Required=false)]
        public List<GetScheduledTaskExecutionDetailResponseBodyFiles> Files { get; set; }
        public class GetScheduledTaskExecutionDetailResponseBodyFiles : TeaModel {
            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SampleName.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The OSS URL of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/oss/file.pdf">https://example.com/oss/file.pdf</a></para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        /// <summary>
        /// <para>The creation time in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The extended metadata.</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public GetScheduledTaskExecutionDetailResponseBodyMetadata Metadata { get; set; }
        public class GetScheduledTaskExecutionDetailResponseBodyMetadata : TeaModel {
            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleSessionId</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The token usage information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("usage")]
            [Validation(Required=false)]
            public Dictionary<string, object> Usage { get; set; }

        }

        /// <summary>
        /// <para>The structured output content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("outputContent")]
        [Validation(Required=false)]
        public string OutputContent { get; set; }

        /// <summary>
        /// <para>The push status of the execution result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>succuss</para>
        /// </summary>
        [NameInMap("pushResult")]
        [Validation(Required=false)]
        public string PushResult { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of associated skill codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("skillCodes")]
        [Validation(Required=false)]
        public List<string> SkillCodes { get; set; }

        /// <summary>
        /// <para>The start time in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("startedAt")]
        [Validation(Required=false)]
        public string StartedAt { get; set; }

        /// <summary>
        /// <para>The execution status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleTaskId</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The execution result title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample title</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The trigger information.</para>
        /// </summary>
        [NameInMap("triggerInfo")]
        [Validation(Required=false)]
        public GetScheduledTaskExecutionDetailResponseBodyTriggerInfo TriggerInfo { get; set; }
        public class GetScheduledTaskExecutionDetailResponseBodyTriggerInfo : TeaModel {
            /// <summary>
            /// <para>The user identifier that triggered the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_10001</para>
            /// </summary>
            [NameInMap("triggeredBy")]
            [Validation(Required=false)]
            public string TriggeredBy { get; set; }

        }

        /// <summary>
        /// <para>The trigger type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("triggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

        /// <summary>
        /// <para>The visibility scope of the execution record, which is always equal to the visibility scope of the associated task. Valid values: PRIVATE, COLLABORATIVE, and PUBLIC. This field is empty for personal task executions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COLLABORATIVE</para>
        /// </summary>
        [NameInMap("visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}

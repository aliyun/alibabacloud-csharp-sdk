// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunAiHelperWritingResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The Server-Sent Events (SSE) response header.</para>
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunAiHelperWritingResponseBodyHeader Header { get; set; }
        public class RunAiHelperWritingResponseBodyHeader : TeaModel {
            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidParameter</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>参数错误</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>result-generated</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>session-xxxxx</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The status code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public int? StatusCode { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-xxxxx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Trace ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response payload.</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunAiHelperWritingResponseBodyPayload Payload { get; set; }
        public class RunAiHelperWritingResponseBodyPayload : TeaModel {
            /// <summary>
            /// <para>The output content.</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunAiHelperWritingResponseBodyPayloadOutput Output { get; set; }
            public class RunAiHelperWritingResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <para>The generated text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>人工智能正在深刻改变我们的生活...</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The writing parameters for the AI-assisted writing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;wordCount&quot;: &quot;1000&quot;}</para>
                /// </summary>
                [NameInMap("WritingParams")]
                [Validation(Required=false)]
                public Dictionary<string, string> WritingParams { get; set; }

            }

            /// <summary>
            /// <para>The token usage.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunAiHelperWritingResponseBodyPayloadUsage Usage { get; set; }
            public class RunAiHelperWritingResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <para>The number of input tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>256</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>The number of output tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>The total number of tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1280</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

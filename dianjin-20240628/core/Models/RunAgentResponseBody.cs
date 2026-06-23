// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RunAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>Duration in milliseconds</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        /// <summary>
        /// <para>Response data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public RunAgentResponseBodyData Data { get; set; }
        public class RunAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Tool call responses</para>
            /// </summary>
            [NameInMap("functionCallResponses")]
            [Validation(Required=false)]
            public List<RunAgentResponseBodyDataFunctionCallResponses> FunctionCallResponses { get; set; }
            public class RunAgentResponseBodyDataFunctionCallResponses : TeaModel {
                /// <summary>
                /// <para>Tool function display name</para>
                /// 
                /// <b>Example:</b>
                /// <para>搜索引擎</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>End time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-21 16:37:14</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>Tool function arguments</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;query\&quot;:\&quot;2025年1月28日到2月3日天气预报\&quot;}</para>
                /// </summary>
                [NameInMap("functionArgs")]
                [Validation(Required=false)]
                public string FunctionArgs { get; set; }

                /// <summary>
                /// <para>Tool function name</para>
                /// 
                /// <b>Example:</b>
                /// <para>web_search</para>
                /// </summary>
                [NameInMap("functionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                /// <summary>
                /// <para>Tool call result</para>
                /// 
                /// <b>Example:</b>
                /// <para>下周天气晴朗</para>
                /// </summary>
                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <para>Start time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-21 16:37:14</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>Input tokens</para>
            /// 
            /// <b>Example:</b>
            /// <para>766</para>
            /// </summary>
            [NameInMap("inputTokens")]
            [Validation(Required=false)]
            public int? InputTokens { get; set; }

            /// <summary>
            /// <para>Output tokens</para>
            /// 
            /// <b>Example:</b>
            /// <para>988</para>
            /// </summary>
            [NameInMap("outputTokens")]
            [Validation(Required=false)]
            public int? OutputTokens { get; set; }

            /// <summary>
            /// <para>Model response</para>
            /// </summary>
            [NameInMap("response")]
            [Validation(Required=false)]
            public RunAgentResponseBodyDataResponse Response { get; set; }
            public class RunAgentResponseBodyDataResponse : TeaModel {
                /// <summary>
                /// <para>Details of the model-generated content.</para>
                /// </summary>
                [NameInMap("choices")]
                [Validation(Required=false)]
                public List<RunAgentResponseBodyDataResponseChoices> Choices { get; set; }
                public class RunAgentResponseBodyDataResponseChoices : TeaModel {
                    /// <summary>
                    /// <para>Reason why the model stopped generating content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>stop</para>
                    /// </summary>
                    [NameInMap("finishReason")]
                    [Validation(Required=false)]
                    public string FinishReason { get; set; }

                    /// <summary>
                    /// <para>Index number of the generated result. Default is 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    /// <summary>
                    /// <para>Message from the model.</para>
                    /// </summary>
                    [NameInMap("message")]
                    [Validation(Required=false)]
                    public RunAgentResponseBodyDataResponseChoicesMessage Message { get; set; }
                    public class RunAgentResponseBodyDataResponseChoicesMessage : TeaModel {
                        /// <summary>
                        /// <para>Text generated by the model.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>下周天气都不错</para>
                        /// </summary>
                        [NameInMap("content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <para>Role of the model. Fixed value: assistant.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>assistant</para>
                        /// </summary>
                        [NameInMap("role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        /// <summary>
                        /// <para>Display name of the model\&quot;s role.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>assistant</para>
                        /// </summary>
                        [NameInMap("roleDisplayName")]
                        [Validation(Required=false)]
                        public string RoleDisplayName { get; set; }

                    }

                }

                /// <summary>
                /// <para>Creation time</para>
                /// 
                /// <b>Example:</b>
                /// <para>1737448637</para>
                /// </summary>
                [NameInMap("created")]
                [Validation(Required=false)]
                public long? Created { get; set; }

                /// <summary>
                /// <para>ID generated by the system for this call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d91d9afa-7cfc-4235-b012-a6f8e6ffa443</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Name of the model used for this call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-plus</para>
                /// </summary>
                [NameInMap("modelId")]
                [Validation(Required=false)]
                public string ModelId { get; set; }

                /// <summary>
                /// <para>Time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-21T16:37:17.497206762</para>
                /// </summary>
                [NameInMap("time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

            /// <summary>
            /// <para>Thread ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>4vlag5ken3</para>
            /// </summary>
            [NameInMap("threadId")]
            [Validation(Required=false)]
            public string ThreadId { get; set; }

            /// <summary>
            /// <para>Trace ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>5bdb9809856c58acb92001f8ae65773c</para>
            /// </summary>
            [NameInMap("traceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

            /// <summary>
            /// <para>Agent version ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>w4paqoezm2</para>
            /// </summary>
            [NameInMap("versionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

        /// <summary>
        /// <para>Data type</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>EF4B5C9B-3BC8-5171-A47B-4C5CF3DC3258</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates success</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Timestamp</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RunAgentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public RunAgentResponseBodyData Data { get; set; }
        public class RunAgentResponseBodyData : TeaModel {
            [NameInMap("functionCallResponses")]
            [Validation(Required=false)]
            public List<RunAgentResponseBodyDataFunctionCallResponses> FunctionCallResponses { get; set; }
            public class RunAgentResponseBodyDataFunctionCallResponses : TeaModel {
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-01-21 16:37:14</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("functionArgs")]
                [Validation(Required=false)]
                public string FunctionArgs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>web_search</para>
                /// </summary>
                [NameInMap("functionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-01-21 16:37:14</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>766</para>
            /// </summary>
            [NameInMap("inputTokens")]
            [Validation(Required=false)]
            public int? InputTokens { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>988</para>
            /// </summary>
            [NameInMap("outputTokens")]
            [Validation(Required=false)]
            public int? OutputTokens { get; set; }

            [NameInMap("response")]
            [Validation(Required=false)]
            public RunAgentResponseBodyDataResponse Response { get; set; }
            public class RunAgentResponseBodyDataResponse : TeaModel {
                [NameInMap("choices")]
                [Validation(Required=false)]
                public List<RunAgentResponseBodyDataResponseChoices> Choices { get; set; }
                public class RunAgentResponseBodyDataResponseChoices : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>stop</para>
                    /// </summary>
                    [NameInMap("finishReason")]
                    [Validation(Required=false)]
                    public string FinishReason { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    [NameInMap("message")]
                    [Validation(Required=false)]
                    public RunAgentResponseBodyDataResponseChoicesMessage Message { get; set; }
                    public class RunAgentResponseBodyDataResponseChoicesMessage : TeaModel {
                        [NameInMap("content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>assistant</para>
                        /// </summary>
                        [NameInMap("role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>assistant</para>
                        /// </summary>
                        [NameInMap("roleDisplayName")]
                        [Validation(Required=false)]
                        public string RoleDisplayName { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1737448637</para>
                /// </summary>
                [NameInMap("created")]
                [Validation(Required=false)]
                public long? Created { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>d91d9afa-7cfc-4235-b012-a6f8e6ffa443</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>qwen-plus</para>
                /// </summary>
                [NameInMap("modelId")]
                [Validation(Required=false)]
                public string ModelId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-01-21T16:37:17.497206762</para>
                /// </summary>
                [NameInMap("time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4vlag5ken3</para>
            /// </summary>
            [NameInMap("threadId")]
            [Validation(Required=false)]
            public string ThreadId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5bdb9809856c58acb92001f8ae65773c</para>
            /// </summary>
            [NameInMap("traceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>w4paqoezm2</para>
            /// </summary>
            [NameInMap("versionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EF4B5C9B-3BC8-5171-A47B-4C5CF3DC3258</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}

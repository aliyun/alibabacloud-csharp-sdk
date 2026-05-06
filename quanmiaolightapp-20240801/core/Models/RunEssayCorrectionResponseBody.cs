// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunEssayCorrectionResponseBody : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public RunEssayCorrectionResponseBodyHeader Header { get; set; }
        public class RunEssayCorrectionResponseBodyHeader : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>AccessForbidden</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>错误信息</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task-finished</para>
            /// </summary>
            [NameInMap("event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxx</para>
            /// </summary>
            [NameInMap("traceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        [NameInMap("payload")]
        [Validation(Required=false)]
        public RunEssayCorrectionResponseBodyPayload Payload { get; set; }
        public class RunEssayCorrectionResponseBodyPayload : TeaModel {
            [NameInMap("output")]
            [Validation(Required=false)]
            public RunEssayCorrectionResponseBodyPayloadOutput Output { get; set; }
            public class RunEssayCorrectionResponseBodyPayloadOutput : TeaModel {
                [NameInMap("dimensionResults")]
                [Validation(Required=false)]
                public List<RunEssayCorrectionResponseBodyPayloadOutputDimensionResults> DimensionResults { get; set; }
                public class RunEssayCorrectionResponseBodyPayloadOutputDimensionResults : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>文章内容较为完整，涵盖了题目的核心要求，但部分论述略显简略。</para>
                    /// </summary>
                    [NameInMap("analysis")]
                    [Validation(Required=false)]
                    public string Analysis { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("maxScore")]
                    [Validation(Required=false)]
                    public double? MaxScore { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>内容完整度</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>25.5</para>
                    /// </summary>
                    [NameInMap("score")]
                    [Validation(Required=false)]
                    public double? Score { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>整体表现良好，建议在论述深度上进一步加强。</para>
                /// </summary>
                [NameInMap("overallComment")]
                [Validation(Required=false)]
                public string OverallComment { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>首先分析文章结构，发现开头、正文、结尾完整...</para>
                /// </summary>
                [NameInMap("reasoningContent")]
                [Validation(Required=false)]
                public string ReasoningContent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>本文整体结构清晰，语言流畅...</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("usage")]
            [Validation(Required=false)]
            public RunEssayCorrectionResponseBodyPayloadUsage Usage { get; set; }
            public class RunEssayCorrectionResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("totalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>117F5ABE-CF02-5502-9A3F-E56BC9081A64</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

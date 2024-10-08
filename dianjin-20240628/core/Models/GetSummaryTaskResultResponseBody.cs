// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetSummaryTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetSummaryTaskResultResponseBodyData Data { get; set; }
        public class GetSummaryTaskResultResponseBodyData : TeaModel {
            [NameInMap("choices")]
            [Validation(Required=false)]
            public List<GetSummaryTaskResultResponseBodyDataChoices> Choices { get; set; }
            public class GetSummaryTaskResultResponseBodyDataChoices : TeaModel {
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
                public GetSummaryTaskResultResponseBodyDataChoicesMessage Message { get; set; }
                public class GetSummaryTaskResultResponseBodyDataChoicesMessage : TeaModel {
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

                    [NameInMap("toolCalls")]
                    [Validation(Required=false)]
                    public List<Dictionary<string, object>> ToolCalls { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1726285125915</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1202</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen-max</para>
            /// </summary>
            [NameInMap("modelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0bc13a9517168617617186457e401f</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-04-24 11:54:34</para>
            /// </summary>
            [NameInMap("time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("totalTokens")]
            [Validation(Required=false)]
            public int? TotalTokens { get; set; }

            [NameInMap("usage")]
            [Validation(Required=false)]
            public GetSummaryTaskResultResponseBodyDataUsage Usage { get; set; }
            public class GetSummaryTaskResultResponseBodyDataUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("imageCount")]
                [Validation(Required=false)]
                public int? ImageCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("imageTokens")]
                [Validation(Required=false)]
                public int? ImageTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public int? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public int? OutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("totalTokens")]
                [Validation(Required=false)]
                public int? TotalTokens { get; set; }

            }

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
        /// <para>0bc13a9517168617617186457e401f</para>
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
        /// <para>2024-04-24 11:54:34</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RunChatResultGenerationResponseBody : TeaModel {
        [NameInMap("choices")]
        [Validation(Required=false)]
        public List<RunChatResultGenerationResponseBodyChoices> Choices { get; set; }
        public class RunChatResultGenerationResponseBodyChoices : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
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
            public RunChatResultGenerationResponseBodyChoicesMessage Message { get; set; }
            public class RunChatResultGenerationResponseBodyChoicesMessage : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user</para>
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
        /// <para>1720602203</para>
        /// </summary>
        [NameInMap("created")]
        [Validation(Required=false)]
        public long? Created { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eb2b6139-ddf1-91a0-a47f-df7617ae9032</para>
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
        /// <para>eb2b6139-ddf1-91a0-a47f-df7617ae9032</para>
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
        /// <para>500</para>
        /// </summary>
        [NameInMap("totalTokens")]
        [Validation(Required=false)]
        public int? TotalTokens { get; set; }

        [NameInMap("usage")]
        [Validation(Required=false)]
        public RunChatResultGenerationResponseBodyUsage Usage { get; set; }
        public class RunChatResultGenerationResponseBodyUsage : TeaModel {
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
            /// <para>200</para>
            /// </summary>
            [NameInMap("inputTokens")]
            [Validation(Required=false)]
            public int? InputTokens { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("outputTokens")]
            [Validation(Required=false)]
            public int? OutputTokens { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("totalTokens")]
            [Validation(Required=false)]
            public int? TotalTokens { get; set; }

        }

    }

}

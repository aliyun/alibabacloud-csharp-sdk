// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ListLLMTokenUsageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>11345</para>
        /// </summary>
        [NameInMap("CompletionTokens")]
        [Validation(Required=false)]
        public long? CompletionTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1500</para>
        /// </summary>
        [NameInMap("ExplicitCachedTokens")]
        [Validation(Required=false)]
        public long? ExplicitCachedTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1500</para>
        /// </summary>
        [NameInMap("ImplicitCachedTokens")]
        [Validation(Required=false)]
        public long? ImplicitCachedTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("PromptTokens")]
        [Validation(Required=false)]
        public long? PromptTokens { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TokenUsages")]
        [Validation(Required=false)]
        public List<ListLLMTokenUsageResponseBodyTokenUsages> TokenUsages { get; set; }
        public class ListLLMTokenUsageResponseBodyTokenUsages : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("CompletionReasoningTokens")]
            [Validation(Required=false)]
            public long? CompletionReasoningTokens { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("CompletionTokens")]
            [Validation(Required=false)]
            public long? CompletionTokens { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-12-01T16:00:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("ExplicitCachedTokens")]
            [Validation(Required=false)]
            public long? ExplicitCachedTokens { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1408</para>
            /// </summary>
            [NameInMap("ImplicitCachedTokens")]
            [Validation(Required=false)]
            public long? ImplicitCachedTokens { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>glm-5</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("PromptTokens")]
            [Validation(Required=false)]
            public long? PromptTokens { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-03-27</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("TotalTokens")]
            [Validation(Required=false)]
            public long? TotalTokens { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15345</para>
        /// </summary>
        [NameInMap("TotalTokens")]
        [Validation(Required=false)]
        public long? TotalTokens { get; set; }

    }

}

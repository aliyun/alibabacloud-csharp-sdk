// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiToolSelectionConfig : TeaModel {
        /// <summary>
        /// <para>Conditions for activating the tool selection feature.</para>
        /// </summary>
        [NameInMap("enableConditions")]
        [Validation(Required=false)]
        public AiToolSelectionConfigEnableConditions EnableConditions { get; set; }
        public class AiToolSelectionConfigEnableConditions : TeaModel {
            /// <summary>
            /// <para>The minimum number of tools required to activate tool selection.</para>
            /// </summary>
            [NameInMap("toolCountThreshold")]
            [Validation(Required=false)]
            public int? ToolCountThreshold { get; set; }

        }

        /// <summary>
        /// <para>The status of the AI tool selection plugin.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("pluginStatus")]
        [Validation(Required=false)]
        public AiPluginStatus PluginStatus { get; set; }

        /// <summary>
        /// <para>Configuration for query rewriting, which optimizes user queries before tool selection.</para>
        /// </summary>
        [NameInMap("queryRewriting")]
        [Validation(Required=false)]
        public AiToolSelectionConfigQueryRewriting QueryRewriting { get; set; }
        public class AiToolSelectionConfigQueryRewriting : TeaModel {
            /// <summary>
            /// <para>Method for selecting the conversation context for query rewriting.</para>
            /// </summary>
            [NameInMap("contextSelection")]
            [Validation(Required=false)]
            public AiToolSelectionConfigQueryRewritingContextSelection ContextSelection { get; set; }
            public class AiToolSelectionConfigQueryRewritingContextSelection : TeaModel {
                /// <summary>
                /// <para>The strategy for selecting the conversation context.</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value associated with the context selection strategy, such as the number of messages to include.</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public int? Value { get; set; }

            }

            /// <summary>
            /// <para>Whether to enable query rewriting.</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The fallback strategy used if query rewriting fails or returns no results.</para>
            /// </summary>
            [NameInMap("fallbackStrategy")]
            [Validation(Required=false)]
            public string FallbackStrategy { get; set; }

            /// <summary>
            /// <para>The maximum number of tokens to generate for the rewritten query.</para>
            /// </summary>
            [NameInMap("maxOutputTokens")]
            [Validation(Required=false)]
            public int? MaxOutputTokens { get; set; }

            /// <summary>
            /// <para>Model service configuration for query rewriting.</para>
            /// </summary>
            [NameInMap("modelService")]
            [Validation(Required=false)]
            public AiToolSelectionConfigQueryRewritingModelService ModelService { get; set; }
            public class AiToolSelectionConfigQueryRewritingModelService : TeaModel {
                /// <summary>
                /// <para>The name of the model used for query rewriting.</para>
                /// </summary>
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>The ID of the model service used for query rewriting.</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <para>The request timeout in milliseconds for the query rewriting model service.</para>
                /// </summary>
                [NameInMap("timeoutMillisecond")]
                [Validation(Required=false)]
                public int? TimeoutMillisecond { get; set; }

            }

            /// <summary>
            /// <para>Prompt configuration for query rewriting.</para>
            /// </summary>
            [NameInMap("promptConfig")]
            [Validation(Required=false)]
            public AiToolSelectionConfigQueryRewritingPromptConfig PromptConfig { get; set; }
            public class AiToolSelectionConfigQueryRewritingPromptConfig : TeaModel {
                /// <summary>
                /// <para>The custom prompt template for query rewriting. This parameter is required if <c>type</c> is set to <c>custom</c>.</para>
                /// </summary>
                [NameInMap("customPrompt")]
                [Validation(Required=false)]
                public string CustomPrompt { get; set; }

                /// <summary>
                /// <para>The type of prompt, such as default or custom.</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Conditions for activating query rewriting.</para>
            /// </summary>
            [NameInMap("triggerConditions")]
            [Validation(Required=false)]
            public AiToolSelectionConfigQueryRewritingTriggerConditions TriggerConditions { get; set; }
            public class AiToolSelectionConfigQueryRewritingTriggerConditions : TeaModel {
                /// <summary>
                /// <para>The minimum number of messages in the conversation history required to activate query rewriting.</para>
                /// </summary>
                [NameInMap("messageCountThreshold")]
                [Validation(Required=false)]
                public int? MessageCountThreshold { get; set; }

            }

        }

        /// <summary>
        /// <para>Configuration for tool reranking, which controls how tools are scored and filtered.</para>
        /// </summary>
        [NameInMap("toolReranking")]
        [Validation(Required=false)]
        public AiToolSelectionConfigToolReranking ToolReranking { get; set; }
        public class AiToolSelectionConfigToolReranking : TeaModel {
            /// <summary>
            /// <para>The fallback strategy used if tool reranking fails or returns no results.</para>
            /// </summary>
            [NameInMap("fallbackStrategy")]
            [Validation(Required=false)]
            public string FallbackStrategy { get; set; }

            /// <summary>
            /// <para>The method for filtering tools after reranking.</para>
            /// </summary>
            [NameInMap("filteringMethod")]
            [Validation(Required=false)]
            public string FilteringMethod { get; set; }

            /// <summary>
            /// <para>Model service configuration for tool reranking.</para>
            /// </summary>
            [NameInMap("modelService")]
            [Validation(Required=false)]
            public AiToolSelectionConfigToolRerankingModelService ModelService { get; set; }
            public class AiToolSelectionConfigToolRerankingModelService : TeaModel {
                /// <summary>
                /// <para>The name of the model used for reranking.</para>
                /// </summary>
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>The ID of the model service used for reranking.</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <para>The request timeout in milliseconds for the reranking model service.</para>
                /// </summary>
                [NameInMap("timeoutMillisecond")]
                [Validation(Required=false)]
                public int? TimeoutMillisecond { get; set; }

            }

            /// <summary>
            /// <para>The minimum score a tool must have to be selected. Tools with scores below this threshold are filtered out.</para>
            /// </summary>
            [NameInMap("scoreThreshold")]
            [Validation(Required=false)]
            public float? ScoreThreshold { get; set; }

            /// <summary>
            /// <para>The percentage of top-ranked tools to select. This parameter only applies when <c>filteringMethod</c> is set to a percentage-based method.</para>
            /// </summary>
            [NameInMap("topKPercent")]
            [Validation(Required=false)]
            public int? TopKPercent { get; set; }

            /// <summary>
            /// <para>The number of top-ranked tools to select. This parameter only applies when <c>filteringMethod</c> is set to a count-based method.</para>
            /// </summary>
            [NameInMap("topNCount")]
            [Validation(Required=false)]
            public int? TopNCount { get; set; }

        }

    }

}

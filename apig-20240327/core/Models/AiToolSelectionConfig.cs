// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiToolSelectionConfig : TeaModel {
        /// <summary>
        /// <para>The enable conditions configuration. Controls when the overall feature is triggered.</para>
        /// </summary>
        [NameInMap("enableConditions")]
        [Validation(Required=false)]
        public AiToolSelectionConfigEnableConditions EnableConditions { get; set; }
        public class AiToolSelectionConfigEnableConditions : TeaModel {
            /// <summary>
            /// <para>The tool count threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("toolCountThreshold")]
            [Validation(Required=false)]
            public int? ToolCountThreshold { get; set; }

        }

        /// <summary>
        /// <para>The plug-in running status.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("pluginStatus")]
        [Validation(Required=false)]
        public AiPluginStatus PluginStatus { get; set; }

        /// <summary>
        /// <para>The query rewrite configuration. Rewrites user queries before tool reranking to improve matching precision.</para>
        /// </summary>
        [NameInMap("queryRewriting")]
        [Validation(Required=false)]
        public AiToolSelectionConfigQueryRewriting QueryRewriting { get; set; }
        public class AiToolSelectionConfigQueryRewriting : TeaModel {
            /// <summary>
            /// <para>The context selection configuration.</para>
            /// </summary>
            [NameInMap("contextSelection")]
            [Validation(Required=false)]
            public AiToolSelectionConfigQueryRewritingContextSelection ContextSelection { get; set; }
            public class AiToolSelectionConfigQueryRewritingContextSelection : TeaModel {
                /// <summary>
                /// <para>The context selection method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>allMessages</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The number of retained messages or characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public int? Value { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether query rewrite is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The fallback strategy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skip</para>
            /// </summary>
            [NameInMap("fallbackStrategy")]
            [Validation(Required=false)]
            public string FallbackStrategy { get; set; }

            /// <summary>
            /// <para>The maximum number of output tokens for rewriting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("maxOutputTokens")]
            [Validation(Required=false)]
            public int? MaxOutputTokens { get; set; }

            /// <summary>
            /// <para>The rewriting model service configuration.</para>
            /// </summary>
            [NameInMap("modelService")]
            [Validation(Required=false)]
            public AiToolSelectionConfigQueryRewritingModelService ModelService { get; set; }
            public class AiToolSelectionConfigQueryRewritingModelService : TeaModel {
                /// <summary>
                /// <para>The model name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gte-rerank-v2</para>
                /// </summary>
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>The model service ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>svc-xxx</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <para>The request timeout period, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("timeoutMillisecond")]
                [Validation(Required=false)]
                public int? TimeoutMillisecond { get; set; }

            }

            /// <summary>
            /// <para>The prompt configuration.</para>
            /// </summary>
            [NameInMap("promptConfig")]
            [Validation(Required=false)]
            public AiToolSelectionConfigQueryRewritingPromptConfig PromptConfig { get; set; }
            public class AiToolSelectionConfigQueryRewritingPromptConfig : TeaModel {
                /// <summary>
                /// <para>The custom prompt content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>请将以下用户问题改写为...</para>
                /// </summary>
                [NameInMap("customPrompt")]
                [Validation(Required=false)]
                public string CustomPrompt { get; set; }

                /// <summary>
                /// <para>The prompt type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>builtIn</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The trigger condition configuration.</para>
            /// </summary>
            [NameInMap("triggerConditions")]
            [Validation(Required=false)]
            public AiToolSelectionConfigQueryRewritingTriggerConditions TriggerConditions { get; set; }
            public class AiToolSelectionConfigQueryRewritingTriggerConditions : TeaModel {
                /// <summary>
                /// <para>The number of conversation turns after which rewriting is triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("messageCountThreshold")]
                [Validation(Required=false)]
                public int? MessageCountThreshold { get; set; }

            }

        }

        /// <summary>
        /// <para>The tool reranking configuration. Uses a model to rank and filter candidate tools.</para>
        /// </summary>
        [NameInMap("toolReranking")]
        [Validation(Required=false)]
        public AiToolSelectionConfigToolReranking ToolReranking { get; set; }
        public class AiToolSelectionConfigToolReranking : TeaModel {
            /// <summary>
            /// <para>The fallback strategy upon failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skip</para>
            /// </summary>
            [NameInMap("fallbackStrategy")]
            [Validation(Required=false)]
            public string FallbackStrategy { get; set; }

            /// <summary>
            /// <para>The filtering method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>topN</para>
            /// </summary>
            [NameInMap("filteringMethod")]
            [Validation(Required=false)]
            public string FilteringMethod { get; set; }

            /// <summary>
            /// <para>The reranking model service configuration.</para>
            /// </summary>
            [NameInMap("modelService")]
            [Validation(Required=false)]
            public AiToolSelectionConfigToolRerankingModelService ModelService { get; set; }
            public class AiToolSelectionConfigToolRerankingModelService : TeaModel {
                /// <summary>
                /// <para>The model name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gte-rerank-v2</para>
                /// </summary>
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>The model service ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>svc-xxx</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <para>The request timeout period, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("timeoutMillisecond")]
                [Validation(Required=false)]
                public int? TimeoutMillisecond { get; set; }

            }

            /// <summary>
            /// <para>The score threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("scoreThreshold")]
            [Validation(Required=false)]
            public float? ScoreThreshold { get; set; }

            /// <summary>
            /// <para>The retention percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("topKPercent")]
            [Validation(Required=false)]
            public int? TopKPercent { get; set; }

            /// <summary>
            /// <para>The retention count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("topNCount")]
            [Validation(Required=false)]
            public int? TopNCount { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiToolSelectionConfig : TeaModel {
        [NameInMap("enableConditions")]
        [Validation(Required=false)]
        public AiToolSelectionConfigEnableConditions EnableConditions { get; set; }
        public class AiToolSelectionConfigEnableConditions : TeaModel {
            [NameInMap("toolCountThreshold")]
            [Validation(Required=false)]
            public int? ToolCountThreshold { get; set; }

        }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("pluginStatus")]
        [Validation(Required=false)]
        public AiPluginStatus PluginStatus { get; set; }

        [NameInMap("queryRewriting")]
        [Validation(Required=false)]
        public AiToolSelectionConfigQueryRewriting QueryRewriting { get; set; }
        public class AiToolSelectionConfigQueryRewriting : TeaModel {
            [NameInMap("contextSelection")]
            [Validation(Required=false)]
            public AiToolSelectionConfigQueryRewritingContextSelection ContextSelection { get; set; }
            public class AiToolSelectionConfigQueryRewritingContextSelection : TeaModel {
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public int? Value { get; set; }

            }

            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("fallbackStrategy")]
            [Validation(Required=false)]
            public string FallbackStrategy { get; set; }

            [NameInMap("maxOutputTokens")]
            [Validation(Required=false)]
            public int? MaxOutputTokens { get; set; }

            [NameInMap("modelService")]
            [Validation(Required=false)]
            public AiToolSelectionConfigQueryRewritingModelService ModelService { get; set; }
            public class AiToolSelectionConfigQueryRewritingModelService : TeaModel {
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                [NameInMap("timeoutMillisecond")]
                [Validation(Required=false)]
                public int? TimeoutMillisecond { get; set; }

            }

            [NameInMap("promptConfig")]
            [Validation(Required=false)]
            public AiToolSelectionConfigQueryRewritingPromptConfig PromptConfig { get; set; }
            public class AiToolSelectionConfigQueryRewritingPromptConfig : TeaModel {
                [NameInMap("customPrompt")]
                [Validation(Required=false)]
                public string CustomPrompt { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("triggerConditions")]
            [Validation(Required=false)]
            public AiToolSelectionConfigQueryRewritingTriggerConditions TriggerConditions { get; set; }
            public class AiToolSelectionConfigQueryRewritingTriggerConditions : TeaModel {
                [NameInMap("messageCountThreshold")]
                [Validation(Required=false)]
                public int? MessageCountThreshold { get; set; }

            }

        }

        [NameInMap("toolReranking")]
        [Validation(Required=false)]
        public AiToolSelectionConfigToolReranking ToolReranking { get; set; }
        public class AiToolSelectionConfigToolReranking : TeaModel {
            [NameInMap("fallbackStrategy")]
            [Validation(Required=false)]
            public string FallbackStrategy { get; set; }

            [NameInMap("filteringMethod")]
            [Validation(Required=false)]
            public string FilteringMethod { get; set; }

            [NameInMap("modelService")]
            [Validation(Required=false)]
            public AiToolSelectionConfigToolRerankingModelService ModelService { get; set; }
            public class AiToolSelectionConfigToolRerankingModelService : TeaModel {
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                [NameInMap("timeoutMillisecond")]
                [Validation(Required=false)]
                public int? TimeoutMillisecond { get; set; }

            }

            [NameInMap("scoreThreshold")]
            [Validation(Required=false)]
            public float? ScoreThreshold { get; set; }

            [NameInMap("topKPercent")]
            [Validation(Required=false)]
            public int? TopKPercent { get; set; }

            [NameInMap("topNCount")]
            [Validation(Required=false)]
            public int? TopNCount { get; set; }

        }

    }

}

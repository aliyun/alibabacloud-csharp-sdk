// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ModelParameters : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable explicit caching for system messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableCacheControl")]
        [Validation(Required=false)]
        public bool? EnableCacheControl { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable thinking mode. This takes effect only for hybrid thinking models and defaults to false if not specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableThinking")]
        [Validation(Required=false)]
        public bool? EnableThinking { get; set; }

        /// <summary>
        /// <para>The extended parameters, which are a serialized string of a JSON object. These are merged into the top level of the model request body to pass through other Model Studio parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enable_search&quot;:false}</para>
        /// </summary>
        [NameInMap("extraBody")]
        [Validation(Required=false)]
        public string ExtraBody { get; set; }

        /// <summary>
        /// <para>The frequency penalty where positive values reduce repetition, with a range of -2.0 to 2.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.2</para>
        /// </summary>
        [NameInMap("frequencyPenalty")]
        [Validation(Required=false)]
        public float? FrequencyPenalty { get; set; }

        /// <summary>
        /// <para>The maximum number of output tokens, including the chain-of-thought and the response. This is recommended for thinking models.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4096</para>
        /// </summary>
        [NameInMap("maxCompletionTokens")]
        [Validation(Required=false)]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// <para>The maximum number of output tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("maxTokens")]
        [Validation(Required=false)]
        public long? MaxTokens { get; set; }

        /// <summary>
        /// <para>The presence penalty where positive values encourage new topics, with a range of -2.0 to 2.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1</para>
        /// </summary>
        [NameInMap("presencePenalty")]
        [Validation(Required=false)]
        public float? PresencePenalty { get; set; }

        /// <summary>
        /// <para>The reasoning effort level. This takes effect only when thinking mode is enabled. For the Qwen3.8 series, valid values are low, medium, and xhigh. This cannot be set simultaneously with thinkingBudget.</para>
        /// 
        /// <b>Example:</b>
        /// <para>low</para>
        /// </summary>
        [NameInMap("reasoningEffort")]
        [Validation(Required=false)]
        public string ReasoningEffort { get; set; }

        /// <summary>
        /// <para>The repetition penalty that controls the repetition of consecutive sequences. The value must be greater than 0. A value of 1.0 indicates no penalty, and a larger value results in less repetition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.05</para>
        /// </summary>
        [NameInMap("repetitionPenalty")]
        [Validation(Required=false)]
        public double? RepetitionPenalty { get; set; }

        /// <summary>
        /// <para>The response content format, which defaults to text if not specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;json_schema&quot;,&quot;jsonSchema&quot;:{&quot;name&quot;:&quot;answer&quot;,&quot;strict&quot;:true,&quot;schema&quot;:&quot;{\&quot;type\&quot;:\&quot;object\&quot;,\&quot;properties\&quot;:{\&quot;answer\&quot;:{\&quot;type\&quot;:\&quot;string\&quot;}},\&quot;required\&quot;:[\&quot;answer\&quot;]}&quot;}}</para>
        /// </summary>
        [NameInMap("responseFormat")]
        [Validation(Required=false)]
        public ModelParametersResponseFormat ResponseFormat { get; set; }
        public class ModelParametersResponseFormat : TeaModel {
            /// <summary>
            /// <para>The JSON Schema constraint, which is required when the type is json_schema.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;name&quot;:&quot;answer&quot;,&quot;strict&quot;:true,&quot;schema&quot;:&quot;{\&quot;type\&quot;:\&quot;object\&quot;,\&quot;properties\&quot;:{\&quot;answer\&quot;:{\&quot;type\&quot;:\&quot;string\&quot;}},\&quot;required\&quot;:[\&quot;answer\&quot;]}&quot;}</para>
            /// </summary>
            [NameInMap("jsonSchema")]
            [Validation(Required=false)]
            public ModelParametersResponseFormatJsonSchema JsonSchema { get; set; }
            public class ModelParametersResponseFormatJsonSchema : TeaModel {
                /// <summary>
                /// <para>The schema name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>answer</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The JSON Schema definition, which is a serialized string of a JSON object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;answer&quot;:{&quot;type&quot;:&quot;string&quot;}},&quot;required&quot;:[&quot;answer&quot;]}</para>
                /// </summary>
                [NameInMap("schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

                /// <summary>
                /// <para>Specifies whether to strictly adhere to the schema structure. Set this to true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("strict")]
                [Validation(Required=false)]
                public bool? Strict { get; set; }

            }

            /// <summary>
            /// <para>The format type. Valid values: text, json_object, and json_schema. When using json_object, the prompt must explicitly request JSON output.</para>
            /// 
            /// <b>Example:</b>
            /// <para>json_object</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The random seed, with a range of 0 to 2147483647, which attempts to return the same result for the same input and parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("seed")]
        [Validation(Required=false)]
        public int? Seed { get; set; }

        /// <summary>
        /// <para>The stop sequences that immediately halt generation when encountered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;END&quot;]</para>
        /// </summary>
        [NameInMap("stopSequences")]
        [Validation(Required=false)]
        public List<string> StopSequences { get; set; }

        /// <summary>
        /// <para>The temperature parameter that controls the randomness of the output, with a range of 0 to 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.7</para>
        /// </summary>
        [NameInMap("temperature")]
        [Validation(Required=false)]
        public float? Temperature { get; set; }

        /// <summary>
        /// <para>The maximum number of tokens for the thinking process. This takes effect only when thinking mode is enabled and cannot be set simultaneously with reasoningEffort.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("thinkingBudget")]
        [Validation(Required=false)]
        public int? ThinkingBudget { get; set; }

        /// <summary>
        /// <para>The Top K sampling parameter, with a range of 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("topK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        /// <summary>
        /// <para>The Top P sampling parameter, with a range of 0 to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.9</para>
        /// </summary>
        [NameInMap("topP")]
        [Validation(Required=false)]
        public float? TopP { get; set; }

    }

}

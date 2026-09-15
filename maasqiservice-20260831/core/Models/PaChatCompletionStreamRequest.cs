// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaasQIService20260831.Models
{
    public class PaChatCompletionStreamRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[10,11]</para>
        /// </summary>
        [NameInMap("allowedTokenIds")]
        [Validation(Required=false)]
        public List<long?> AllowedTokenIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;blocked&quot;]</para>
        /// </summary>
        [NameInMap("badWords")]
        [Validation(Required=false)]
        public List<string> BadWords { get; set; }

        [NameInMap("chatTemplateKwargs")]
        [Validation(Required=false)]
        public PaChatCompletionStreamRequestChatTemplateKwargs ChatTemplateKwargs { get; set; }
        public class PaChatCompletionStreamRequestChatTemplateKwargs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableThinking")]
            [Validation(Required=false)]
            public bool? EnableThinking { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("preserveThinking")]
            [Validation(Required=false)]
            public bool? PreserveThinking { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("frequencyPenalty")]
        [Validation(Required=false)]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ignoreEos")]
        [Validation(Required=false)]
        public bool? IgnoreEos { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("includeReasoning")]
        [Validation(Required=false)]
        public bool? IncludeReasoning { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("logprobs")]
        [Validation(Required=false)]
        public bool? Logprobs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("maxCompletionTokens")]
        [Validation(Required=false)]
        public long? MaxCompletionTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("maxTokens")]
        [Validation(Required=false)]
        public long? MaxTokens { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<PaChatCompletionStreamRequestMessages> Messages { get; set; }
        public class PaChatCompletionStreamRequestMessages : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>请分析图片内容</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public List<PaChatCompletionStreamRequestMessagesContent> Content { get; set; }
            public class PaChatCompletionStreamRequestMessagesContent : TeaModel {
                [NameInMap("imageUrl")]
                [Validation(Required=false)]
                public PaChatCompletionStreamRequestMessagesContentImageUrl ImageUrl { get; set; }
                public class PaChatCompletionStreamRequestMessagesContentImageUrl : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/image.png">https://example.com/image.png</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>请分析这张图片</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>call_weather_1</para>
            /// </summary>
            [NameInMap("toolCallId")]
            [Validation(Required=false)]
            public string ToolCallId { get; set; }

            [NameInMap("toolCalls")]
            [Validation(Required=false)]
            public List<PaChatCompletionStreamRequestMessagesToolCalls> ToolCalls { get; set; }
            public class PaChatCompletionStreamRequestMessagesToolCalls : TeaModel {
                [NameInMap("function")]
                [Validation(Required=false)]
                public PaChatCompletionStreamRequestMessagesToolCallsFunction Function { get; set; }
                public class PaChatCompletionStreamRequestMessagesToolCallsFunction : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{&quot;city&quot;:&quot;杭州&quot;}</para>
                    /// </summary>
                    [NameInMap("arguments")]
                    [Validation(Required=false)]
                    public string Arguments { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>get_weather</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>call_weather_1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>function</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.05</para>
        /// </summary>
        [NameInMap("minP")]
        [Validation(Required=false)]
        public double? MinP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("minTokens")]
        [Validation(Required=false)]
        public long? MinTokens { get; set; }

        [NameInMap("mmProcessorKwargs")]
        [Validation(Required=false)]
        public PaChatCompletionStreamRequestMmProcessorKwargs MmProcessorKwargs { get; set; }
        public class PaChatCompletionStreamRequestMmProcessorKwargs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("maxDynamicPatch")]
            [Validation(Required=false)]
            public long? MaxDynamicPatch { get; set; }

        }

        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("n")]
        [Validation(Required=false)]
        public long? N { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("parallelToolCalls")]
        [Validation(Required=false)]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("presencePenalty")]
        [Validation(Required=false)]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("promptLogprobs")]
        [Validation(Required=false)]
        public long? PromptLogprobs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("reasoningEffort")]
        [Validation(Required=false)]
        public string ReasoningEffort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.1</para>
        /// </summary>
        [NameInMap("repetitionPenalty")]
        [Validation(Required=false)]
        public double? RepetitionPenalty { get; set; }

        [NameInMap("responseFormat")]
        [Validation(Required=false)]
        public PaChatCompletionStreamRequestResponseFormat ResponseFormat { get; set; }
        public class PaChatCompletionStreamRequestResponseFormat : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>json_object</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("seed")]
        [Validation(Required=false)]
        public long? Seed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("skipSpecialTokens")]
        [Validation(Required=false)]
        public bool? SkipSpecialTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;END&quot;]</para>
        /// </summary>
        [NameInMap("stop")]
        [Validation(Required=false)]
        public List<string> Stop { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[1,2]</para>
        /// </summary>
        [NameInMap("stopTokenIds")]
        [Validation(Required=false)]
        public List<long?> StopTokenIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        [NameInMap("streamOptions")]
        [Validation(Required=false)]
        public PaChatCompletionStreamRequestStreamOptions StreamOptions { get; set; }
        public class PaChatCompletionStreamRequestStreamOptions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("includeUsage")]
            [Validation(Required=false)]
            public bool? IncludeUsage { get; set; }

        }

        [NameInMap("structuredOutputs")]
        [Validation(Required=false)]
        public PaChatCompletionStreamRequestStructuredOutputs StructuredOutputs { get; set; }
        public class PaChatCompletionStreamRequestStructuredOutputs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;yes&quot;,&quot;no&quot;]</para>
            /// </summary>
            [NameInMap("choice")]
            [Validation(Required=false)]
            public List<string> Choice { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.2</para>
        /// </summary>
        [NameInMap("temperature")]
        [Validation(Required=false)]
        public double? Temperature { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("toolChoice")]
        [Validation(Required=false)]
        public string ToolChoice { get; set; }

        [NameInMap("tools")]
        [Validation(Required=false)]
        public List<PaChatCompletionStreamRequestTools> Tools { get; set; }
        public class PaChatCompletionStreamRequestTools : TeaModel {
            [NameInMap("function")]
            [Validation(Required=false)]
            public PaChatCompletionStreamRequestToolsFunction Function { get; set; }
            public class PaChatCompletionStreamRequestToolsFunction : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>查询指定城市天气</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>get_weather</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("parameters")]
                [Validation(Required=false)]
                public PaChatCompletionStreamRequestToolsFunctionParameters Parameters { get; set; }
                public class PaChatCompletionStreamRequestToolsFunctionParameters : TeaModel {
                    [NameInMap("properties")]
                    [Validation(Required=false)]
                    public PaChatCompletionStreamRequestToolsFunctionParametersProperties Properties { get; set; }
                    public class PaChatCompletionStreamRequestToolsFunctionParametersProperties : TeaModel {
                        [NameInMap("city")]
                        [Validation(Required=false)]
                        public PaChatCompletionStreamRequestToolsFunctionParametersPropertiesCity City { get; set; }
                        public class PaChatCompletionStreamRequestToolsFunctionParametersPropertiesCity : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>要查询天气的城市名称</para>
                            /// </summary>
                            [NameInMap("description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>string</para>
                            /// </summary>
                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                    }

                    [NameInMap("required")]
                    [Validation(Required=false)]
                    public List<string> Required { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>object</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("strict")]
                [Validation(Required=false)]
                public bool? Strict { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>function</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("topK")]
        [Validation(Required=false)]
        public long? TopK { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("topLogprobs")]
        [Validation(Required=false)]
        public long? TopLogprobs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.9</para>
        /// </summary>
        [NameInMap("topP")]
        [Validation(Required=false)]
        public double? TopP { get; set; }

    }

}

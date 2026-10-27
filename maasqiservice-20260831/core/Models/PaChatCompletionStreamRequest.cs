// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaasQIService20260831.Models
{
    public class PaChatCompletionStreamRequest : TeaModel {
        /// <summary>
        /// <para>The whitelist of token IDs allowed for generation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[10,11]</para>
        /// </summary>
        [NameInMap("allowedTokenIds")]
        [Validation(Required=false)]
        public List<long?> AllowedTokenIds { get; set; }

        /// <summary>
        /// <para>The list of words or strings prohibited from generation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;blocked&quot;]</para>
        /// </summary>
        [NameInMap("badWords")]
        [Validation(Required=false)]
        public List<string> BadWords { get; set; }

        /// <summary>
        /// <para>The vLLM/OpenAI-Compatible template parameter object. Request values are merged with model defaults, with request keys taking precedence, and passed to the model as-is.</para>
        /// </summary>
        [NameInMap("chatTemplateKwargs")]
        [Validation(Required=false)]
        public PaChatCompletionStreamRequestChatTemplateKwargs ChatTemplateKwargs { get; set; }
        public class PaChatCompletionStreamRequestChatTemplateKwargs : TeaModel {
            /// <summary>
            /// <para>Controls whether the model generates reasoning_content through chat_template_kwargs. This value is passed to the model used by the Mobile Planner Agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableThinking")]
            [Validation(Required=false)]
            public bool? EnableThinking { get; set; }

            /// <summary>
            /// <para>Specifies whether the model preserves and reuses existing reasoning content in subsequent turns. Passed through as-is per vLLM/Qwen chat_template_kwargs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("preserveThinking")]
            [Validation(Required=false)]
            public bool? PreserveThinking { get; set; }

        }

        /// <summary>
        /// <para>The frequency penalty parameter passed through to the Mobile Planner Agent model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("frequencyPenalty")]
        [Validation(Required=false)]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// <para>Specifies whether to ignore EOS and continue generation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ignoreEos")]
        [Validation(Required=false)]
        public bool? IgnoreEos { get; set; }

        /// <summary>
        /// <para>Specifies whether to request reasoning content from the upstream. The actual capability depends on the model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("includeReasoning")]
        [Validation(Required=false)]
        public bool? IncludeReasoning { get; set; }

        /// <summary>
        /// <para>A model-compatible parameter with the JSON field name logprobs. Whether it is accepted and takes effect depends on the model used by the instance. The current Agent response does not provide token log probability details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("logprobs")]
        [Validation(Required=false)]
        public bool? Logprobs { get; set; }

        /// <summary>
        /// <para>The maximum number of completion tokens. Must be greater than 0 if provided, and is passed as an OpenAI-compatible model parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("maxCompletionTokens")]
        [Validation(Required=false)]
        public long? MaxCompletionTokens { get; set; }

        /// <summary>
        /// <para>The OpenAI-compatible maximum number of generated tokens. Must be greater than 0 if provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("maxTokens")]
        [Validation(Required=false)]
        public long? MaxTokens { get; set; }

        /// <summary>
        /// <para>The list of conversation messages. The first call can submit one turn or an existing multi-turn conversation. When continuing with an existing session ID, retain the complete and unmodified historical message prefix and append the current turn messages. Tool results are associated through role=tool and the corresponding tool_call_id.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<PaChatCompletionStreamRequestMessages> Messages { get; set; }
        public class PaChatCompletionStreamRequestMessages : TeaModel {
            /// <summary>
            /// <para>The message content. Mobile Planner Agent supports text and multimodal content. Image URLs or base64 Data URLs are passed through to the Mobile Planner Agent model if it supports multimodal input.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Analyze the image content</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public List<PaChatCompletionStreamRequestMessagesContent> Content { get; set; }
            public class PaChatCompletionStreamRequestMessagesContent : TeaModel {
                /// <summary>
                /// <para>The image reference when type=image_url. Supports HTTPS URLs or data:image/...;base64,... format.</para>
                /// </summary>
                [NameInMap("imageUrl")]
                [Validation(Required=false)]
                public PaChatCompletionStreamRequestMessagesContentImageUrl ImageUrl { get; set; }
                public class PaChatCompletionStreamRequestMessagesContentImageUrl : TeaModel {
                    /// <summary>
                    /// <para>The image URL. Remote images must use HTTPS. Base64 Data URLs are also accepted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/image.png">https://example.com/image.png</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The non-empty text when type=text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Analyze this image</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The content part type. Mobile Planner Agent user messages support text or image_url.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The message role: user, assistant, tool, system, or developer. system/developer is used for optional per-turn text instruction overrides. If omitted, the instructions from the instance configuration are used. Tool results use tool and are associated with tool_call_id.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>Required when role=tool. Must match an id from the preceding assistant.tool_calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>call_weather_1</para>
            /// </summary>
            [NameInMap("toolCallId")]
            [Validation(Required=false)]
            public string ToolCallId { get; set; }

            /// <summary>
            /// <para>The list of function invocation entries that can be carried when role=assistant. Used for multi-turn tool invocation continuation.</para>
            /// </summary>
            [NameInMap("toolCalls")]
            [Validation(Required=false)]
            public List<PaChatCompletionStreamRequestMessagesToolCalls> ToolCalls { get; set; }
            public class PaChatCompletionStreamRequestMessagesToolCalls : TeaModel {
                /// <summary>
                /// <para>The function information of a historical tool invocation entry, including name and arguments as a JSON character string. Retain the actual returned values in subsequent turns.</para>
                /// </summary>
                [NameInMap("function")]
                [Validation(Required=false)]
                public PaChatCompletionStreamRequestMessagesToolCallsFunction Function { get; set; }
                public class PaChatCompletionStreamRequestMessagesToolCallsFunction : TeaModel {
                    /// <summary>
                    /// <para>The JSON object string of function arguments.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;city&quot;:&quot;Hangzhou&quot;}</para>
                    /// </summary>
                    [NameInMap("arguments")]
                    [Validation(Required=false)]
                    public string Arguments { get; set; }

                    /// <summary>
                    /// <para>The name of the function to call.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>get_weather</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The tool invocation ID. Subsequent tool messages reference this through tool_call_id.</para>
                /// 
                /// <b>Example:</b>
                /// <para>call_weather_1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The tool invocation type. Currently fixed as function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>function</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The vLLM Min-P sampling parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.05</para>
        /// </summary>
        [NameInMap("minP")]
        [Validation(Required=false)]
        public double? MinP { get; set; }

        /// <summary>
        /// <para>The minimum number of tokens to generate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("minTokens")]
        [Validation(Required=false)]
        public long? MinTokens { get; set; }

        /// <summary>
        /// <para>The multimodal preprocessor parameters passed through to vLLM as-is by key.</para>
        /// </summary>
        [NameInMap("mmProcessorKwargs")]
        [Validation(Required=false)]
        public PaChatCompletionStreamRequestMmProcessorKwargs MmProcessorKwargs { get; set; }
        public class PaChatCompletionStreamRequestMmProcessorKwargs : TeaModel {
            /// <summary>
            /// <para>Example: the maximum number of dynamic image patches allowed by the vision model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("maxDynamicPatch")]
            [Validation(Required=false)]
            public long? MaxDynamicPatch { get; set; }

        }

        /// <summary>
        /// <para>Reserved for OpenAI client compatibility. Ignored during routing. The actual model is determined by the published instance configuration. The model field in the response is always an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot; &quot;</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>Set this parameter to 1. Whether the model accepts this parameter depends on the model. The current Mobile Planner Agent response does not return multiple candidate results. Do not use this parameter for multiple-candidate responses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("n")]
        [Validation(Required=false)]
        public long? N { get; set; }

        /// <summary>
        /// <para>Specifies whether the model is allowed to generate multiple tool calling requests in parallel. The model invokes tools concurrently when this parameter is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("parallelToolCalls")]
        [Validation(Required=false)]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// <para>The presence penalty parameter, passed through to the Mobile Planner Agent model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("presencePenalty")]
        [Validation(Required=false)]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// <para>A model compatibility parameter. The JSON field is prompt_logprobs. Whether the model accepts this parameter depends on the model. The current Agent response does not return probability details for input tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("promptLogprobs")]
        [Validation(Required=false)]
        public long? PromptLogprobs { get; set; }

        /// <summary>
        /// <para>The OpenAI-compatible reasoning effort level, such as low, medium, or high.</para>
        /// 
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("reasoningEffort")]
        [Validation(Required=false)]
        public string ReasoningEffort { get; set; }

        /// <summary>
        /// <para>The vLLM repetition penalty parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1</para>
        /// </summary>
        [NameInMap("repetitionPenalty")]
        [Validation(Required=false)]
        public double? RepetitionPenalty { get; set; }

        /// <summary>
        /// <para>The structured response format, such as json_object or json_schema.</para>
        /// </summary>
        [NameInMap("responseFormat")]
        [Validation(Required=false)]
        public PaChatCompletionStreamRequestResponseFormat ResponseFormat { get; set; }
        public class PaChatCompletionStreamRequestResponseFormat : TeaModel {
            /// <summary>
            /// <para>The response format type, such as text, json_object, or json_schema.</para>
            /// 
            /// <b>Example:</b>
            /// <para>json_object</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The random seed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("seed")]
        [Validation(Required=false)]
        public long? Seed { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip special tokens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("skipSpecialTokens")]
        [Validation(Required=false)]
        public bool? SkipSpecialTokens { get; set; }

        /// <summary>
        /// <para>The stop sequences. Compatible with a single string or an array of strings. This field is displayed in array format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;END&quot;]</para>
        /// </summary>
        [NameInMap("stop")]
        [Validation(Required=false)]
        public List<string> Stop { get; set; }

        /// <summary>
        /// <para>The vLLM stop token ID list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2]</para>
        /// </summary>
        [NameInMap("stopTokenIds")]
        [Validation(Required=false)]
        public List<long?> StopTokenIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to use SSE streaming responses. This parameter must be set to true for this operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// <para>The OpenAI-compatible streaming options.</para>
        /// </summary>
        [NameInMap("streamOptions")]
        [Validation(Required=false)]
        public PaChatCompletionStreamRequestStreamOptions StreamOptions { get; set; }
        public class PaChatCompletionStreamRequestStreamOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to output a usage statistics chunk before data:[DONE].</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("includeUsage")]
            [Validation(Required=false)]
            public bool? IncludeUsage { get; set; }

        }

        /// <summary>
        /// <para>The vLLM structured output constraints.</para>
        /// </summary>
        [NameInMap("structuredOutputs")]
        [Validation(Required=false)]
        public PaChatCompletionStreamRequestStructuredOutputs StructuredOutputs { get; set; }
        public class PaChatCompletionStreamRequestStructuredOutputs : TeaModel {
            /// <summary>
            /// <para>The set of allowed enumeration text values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;yes&quot;,&quot;no&quot;]</para>
            /// </summary>
            [NameInMap("choice")]
            [Validation(Required=false)]
            public List<string> Choice { get; set; }

        }

        /// <summary>
        /// <para>The sampling temperature. Passed as an OpenAI-compatible model parameter to override the model default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.2</para>
        /// </summary>
        [NameInMap("temperature")]
        [Validation(Required=false)]
        public double? Temperature { get; set; }

        /// <summary>
        /// <para>The tool choice strategy. Valid values: auto, none, required, or a named selection supported by the model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("toolChoice")]
        [Validation(Required=false)]
        public string ToolChoice { get; set; }

        /// <summary>
        /// <para>The array of function tool definitions available for this request. Mobile Planner Agent registers each named function in the runtime Toolkit and returns tool_calls in the streaming response.</para>
        /// </summary>
        [NameInMap("tools")]
        [Validation(Required=false)]
        public List<PaChatCompletionStreamRequestTools> Tools { get; set; }
        public class PaChatCompletionStreamRequestTools : TeaModel {
            /// <summary>
            /// <para>The function tool definition, including the name, description, and JSON Schema parameters.</para>
            /// </summary>
            [NameInMap("function")]
            [Validation(Required=false)]
            public PaChatCompletionStreamRequestToolsFunction Function { get; set; }
            public class PaChatCompletionStreamRequestToolsFunction : TeaModel {
                /// <summary>
                /// <para>The description of the function purpose. The model uses this to determine when to call the tool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Query the weather for a specified city</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The function name. This parameter is required. Used to match assistant.tool_calls with subsequent tool results.</para>
                /// 
                /// <b>Example:</b>
                /// <para>get_weather</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The JSON Schema for function parameters, passed to the model as raw JSON. If not provided, an empty object Schema is used.</para>
                /// </summary>
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public PaChatCompletionStreamRequestToolsFunctionParameters Parameters { get; set; }
                public class PaChatCompletionStreamRequestToolsFunctionParameters : TeaModel {
                    /// <summary>
                    /// <para>The property definitions of the JSON Schema.</para>
                    /// </summary>
                    [NameInMap("properties")]
                    [Validation(Required=false)]
                    public PaChatCompletionStreamRequestToolsFunctionParametersProperties Properties { get; set; }
                    public class PaChatCompletionStreamRequestToolsFunctionParametersProperties : TeaModel {
                        /// <summary>
                        /// <para>The Schema for the sample business parameter city. The actual fields are determined by the caller\&quot;s tool definition.</para>
                        /// </summary>
                        [NameInMap("city")]
                        [Validation(Required=false)]
                        public PaChatCompletionStreamRequestToolsFunctionParametersPropertiesCity City { get; set; }
                        public class PaChatCompletionStreamRequestToolsFunctionParametersPropertiesCity : TeaModel {
                            /// <summary>
                            /// <para>The sample parameter description.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The name of the city for which to query the weather</para>
                            /// </summary>
                            [NameInMap("description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// <para>The JSON Schema type of the sample city field.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>string</para>
                            /// </summary>
                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The array of required field names in the JSON Schema.</para>
                    /// </summary>
                    [NameInMap("required")]
                    [Validation(Required=false)]
                    public List<string> Required { get; set; }

                    /// <summary>
                    /// <para>The root Schema type of the function parameters. Typically set to object.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>object</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>Specifies whether the model must strictly follow the function parameter JSON Schema.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("strict")]
                [Validation(Required=false)]
                public bool? Strict { get; set; }

            }

            /// <summary>
            /// <para>The tool type. This parameter must be set to function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>function</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The vLLM Top-K sampling parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("topK")]
        [Validation(Required=false)]
        public long? TopK { get; set; }

        /// <summary>
        /// <para>A model compatibility parameter. The JSON field is top_logprobs. Used for models that support this feature. The current Agent response does not provide candidate token probability details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("topLogprobs")]
        [Validation(Required=false)]
        public long? TopLogprobs { get; set; }

        /// <summary>
        /// <para>Top-P sampling parameter. Passed as an OpenAI-compatible model parameter to override the model default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.9</para>
        /// </summary>
        [NameInMap("topP")]
        [Validation(Required=false)]
        public double? TopP { get; set; }

    }

}

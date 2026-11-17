// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaasQIService20260831.Models
{
    public class PaChatCompletionStreamRequest : TeaModel {
        /// <summary>
        /// <para>The whitelist of allowed token IDs for generation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[10,11]</para>
        /// </summary>
        [NameInMap("allowedTokenIds")]
        [Validation(Required=false)]
        public List<long?> AllowedTokenIds { get; set; }

        /// <summary>
        /// <para>The list of banned words or strings for generation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;blocked&quot;]</para>
        /// </summary>
        [NameInMap("badWords")]
        [Validation(Required=false)]
        public List<string> BadWords { get; set; }

        /// <summary>
        /// <para>The vLLM or OpenAI-compatible template parameter object. Request values are merged with the default values of the model. Request keys with the same name take precedence and are passed to the model as-is.</para>
        /// </summary>
        [NameInMap("chatTemplateKwargs")]
        [Validation(Required=false)]
        public PaChatCompletionStreamRequestChatTemplateKwargs ChatTemplateKwargs { get; set; }
        public class PaChatCompletionStreamRequestChatTemplateKwargs : TeaModel {
            /// <summary>
            /// <para>Specifies whether the model generates reasoning_content through chat_template_kwargs. This value is passed to the model used by the Mobile Planner Agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableThinking")]
            [Validation(Required=false)]
            public bool? EnableThinking { get; set; }

            /// <summary>
            /// <para>Specifies whether the model retains and reuses existing thinking content in subsequent turns. This value is passed through as-is according to vLLM or Qwen chat_template_kwargs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("preserveThinking")]
            [Validation(Required=false)]
            public bool? PreserveThinking { get; set; }

        }

        /// <summary>
        /// <para>The frequency penalty parameter, passed through to the Mobile Planner Agent model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("frequencyPenalty")]
        [Validation(Required=false)]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// <para>Specifies whether to ignore the end-of-sequence (EOS) token and continue generation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ignoreEos")]
        [Validation(Required=false)]
        public bool? IgnoreEos { get; set; }

        /// <summary>
        /// <para>Specifies whether to require the upstream to return reasoning content. The specific capability depends on the model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("includeReasoning")]
        [Validation(Required=false)]
        public bool? IncludeReasoning { get; set; }

        /// <summary>
        /// <para>A model-compatible parameter with the JSON field logprobs. Whether it is accepted and takes effect depends on the model used by the instance. The current agent response does not provide token log probability details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("logprobs")]
        [Validation(Required=false)]
        public bool? Logprobs { get; set; }

        /// <summary>
        /// <para>The maximum number of completion tokens. If provided, the value must be greater than 0 and is passed as an OpenAI-compatible model parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("maxCompletionTokens")]
        [Validation(Required=false)]
        public long? MaxCompletionTokens { get; set; }

        /// <summary>
        /// <para>The OpenAI-compatible maximum number of tokens to generate. If provided, it must be greater than 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("maxTokens")]
        [Validation(Required=false)]
        public long? MaxTokens { get; set; }

        /// <summary>
        /// <para>The list of conversation messages. For the first call, you can submit a single turn or multiple turns of conversation. When continuing a session with an existing session ID, retain the complete and unmodified prefix of historical messages and append the messages for the current turn. Tool results are associated by using role=tool and the corresponding tool_call_id.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<PaChatCompletionStreamRequestMessages> Messages { get; set; }
        public class PaChatCompletionStreamRequestMessages : TeaModel {
            /// <summary>
            /// <para>The content of the message. The Mobile Planner Agent supports text and multimodal content. Image URLs or Base64 data URLs are passed through to the Mobile Planner Agent model that supports multimodal inputs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;type&quot;:&quot;text&quot;,&quot;text&quot;:&quot;Analyze the image content&quot;}]</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public List<PaChatCompletionStreamRequestMessagesContent> Content { get; set; }
            public class PaChatCompletionStreamRequestMessagesContent : TeaModel {
                /// <summary>
                /// <para>The image reference when the type is set to image_url. HTTPS URLs and data:image/...;base64,... formats are supported.</para>
                /// </summary>
                [NameInMap("imageUrl")]
                [Validation(Required=false)]
                public PaChatCompletionStreamRequestMessagesContentImageUrl ImageUrl { get; set; }
                public class PaChatCompletionStreamRequestMessagesContentImageUrl : TeaModel {
                    /// <summary>
                    /// <para>The image address. Remote images must use HTTPS. You can also pass a Base64 data URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/image.png">https://example.com/image.png</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The non-empty text when type is set to text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Analyze this image</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The type of the content part. Mobile Planner Agent user messages support text or image_url.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The role of the message: user, assistant, tool, system, or developer. The system or developer role is used to override optional text instructions for the current turn. If omitted, the instructions in the instance configuration are used. Tool results use the tool role and are associated with a tool_call_id.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>Required when role is set to tool. The value must match the id in the preceding assistant.tool_calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>call_weather_1</para>
            /// </summary>
            [NameInMap("toolCallId")]
            [Validation(Required=false)]
            public string ToolCallId { get; set; }

            /// <summary>
            /// <para>The list of function invocations that can be included when role is set to assistant. This is used to continue multi-turn tool invocations.</para>
            /// </summary>
            [NameInMap("toolCalls")]
            [Validation(Required=false)]
            public List<PaChatCompletionStreamRequestMessagesToolCalls> ToolCalls { get; set; }
            public class PaChatCompletionStreamRequestMessagesToolCalls : TeaModel {
                /// <summary>
                /// <para>The function information of the historical tool invocation, including the name and arguments in JSON string format. Subsequent turns should retain the actual return values.</para>
                /// </summary>
                [NameInMap("function")]
                [Validation(Required=false)]
                public PaChatCompletionStreamRequestMessagesToolCallsFunction Function { get; set; }
                public class PaChatCompletionStreamRequestMessagesToolCallsFunction : TeaModel {
                    /// <summary>
                    /// <para>The JSON object string of the function arguments.</para>
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
                /// <para>The tool invocation ID. Subsequent tool messages reference this ID by using tool_call_id.</para>
                /// 
                /// <b>Example:</b>
                /// <para>call_weather_1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The tool invocation type. Currently, this is fixed to function.</para>
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
        /// <para>The multimodal preprocessor arguments, which are passed through to vLLM as-is by key.</para>
        /// </summary>
        [NameInMap("mmProcessorKwargs")]
        [Validation(Required=false)]
        public PaChatCompletionStreamRequestMmProcessorKwargs MmProcessorKwargs { get; set; }
        public class PaChatCompletionStreamRequestMmProcessorKwargs : TeaModel {
            /// <summary>
            /// <para>Example: The maximum number of dynamic image patches allowed for vision models.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("maxDynamicPatch")]
            [Validation(Required=false)]
            public long? MaxDynamicPatch { get; set; }

        }

        /// <summary>
        /// <para>Reserved for OpenAI client compatibility. This parameter is ignored during routing. The actual model is determined by the published configuration of the instance, and the model field in the response is fixed to an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot; &quot;</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>Set this parameter to 1. Whether this parameter is accepted depends on the model. The current Mobile Planner Agent response does not return multiple candidate results. Do not use it for multi-candidate returns.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("n")]
        [Validation(Required=false)]
        public long? N { get; set; }

        /// <summary>
        /// <para>Specifies whether the model is allowed to generate multiple tool calls in parallel.</para>
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
        /// <para>A model-compatible parameter with the JSON field prompt_logprobs. Whether it is accepted depends on the model. The current agent response does not return input token probability details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("promptLogprobs")]
        [Validation(Required=false)]
        public long? PromptLogprobs { get; set; }

        /// <summary>
        /// <para>The OpenAI-compatible reasoning effort, such as low, medium, or high.</para>
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
            /// <para>The type of the response format, such as text, json_object, or json_schema.</para>
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
        /// <para>The stop sequences. Compatible with a single string or an array of strings. The array format is shown here.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;END&quot;]</para>
        /// </summary>
        [NameInMap("stop")]
        [Validation(Required=false)]
        public List<string> Stop { get; set; }

        /// <summary>
        /// <para>The list of vLLM stop token IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2]</para>
        /// </summary>
        [NameInMap("stopTokenIds")]
        [Validation(Required=false)]
        public List<long?> StopTokenIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to use SSE streaming responses. You must set this parameter to true for this API operation.</para>
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
            /// <para>Specifies whether to output the usage statistics block before data:[DONE].</para>
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
        /// <para>The sampling temperature. This is passed as an OpenAI-compatible model parameter and overrides the default value of the model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.2</para>
        /// </summary>
        [NameInMap("temperature")]
        [Validation(Required=false)]
        public double? Temperature { get; set; }

        /// <summary>
        /// <para>The tool choice strategy, which supports auto, none, required, or a named choice supported by the model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("toolChoice")]
        [Validation(Required=false)]
        public string ToolChoice { get; set; }

        /// <summary>
        /// <para>The array of function tool definitions available for the current request. Mobile Planner Agent registers each named function to the runtime toolkit and streams back tool_calls.</para>
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
                /// <para>The description of the function purpose, used by the model to determine when to call the tool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Query the weather in a specified city</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the function. It must not be empty and is used to match assistant.tool_calls with subsequent tool results.</para>
                /// 
                /// <b>Example:</b>
                /// <para>get_weather</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The JSON Schema for the function parameters. It is passed to the model as raw JSON. If not provided, an empty object schema is used.</para>
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
                        /// <para>The schema for the example business parameter city. The actual fields are determined by the caller\&quot;s tool definition.</para>
                        /// </summary>
                        [NameInMap("city")]
                        [Validation(Required=false)]
                        public PaChatCompletionStreamRequestToolsFunctionParametersPropertiesCity City { get; set; }
                        public class PaChatCompletionStreamRequestToolsFunctionParametersPropertiesCity : TeaModel {
                            /// <summary>
                            /// <para>The example parameter description.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The name of the city to query the weather for</para>
                            /// </summary>
                            [NameInMap("description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// <para>The JSON Schema type of the example city field.</para>
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
                    /// <para>The root schema type of the function parameters, typically object.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>object</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>Specifies whether the model is required to strictly follow the JSON Schema of the function parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("strict")]
                [Validation(Required=false)]
                public bool? Strict { get; set; }

            }

            /// <summary>
            /// <para>The type of the tool. Currently, it must be function.</para>
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
        /// <para>A model-compatible parameter with the JSON field top_logprobs. It is used for models that support this feature. The current agent response does not provide candidate token probability details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("topLogprobs")]
        [Validation(Required=false)]
        public long? TopLogprobs { get; set; }

        /// <summary>
        /// <para>The Top-P sampling parameter. It is passed as an OpenAI-compatible model parameter to override the model default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.9</para>
        /// </summary>
        [NameInMap("topP")]
        [Validation(Required=false)]
        public double? TopP { get; set; }

    }

}

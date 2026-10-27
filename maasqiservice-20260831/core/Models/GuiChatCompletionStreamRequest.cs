// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaasQIService20260831.Models
{
    public class GuiChatCompletionStreamRequest : TeaModel {
        /// <summary>
        /// <para>The whitelist of token IDs that are allowed to be generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[10,11]</para>
        /// </summary>
        [NameInMap("allowedTokenIds")]
        [Validation(Required=false)]
        public List<long?> AllowedTokenIds { get; set; }

        /// <summary>
        /// <para>The list of words or strings that are banned from being generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;blocked&quot;]</para>
        /// </summary>
        [NameInMap("badWords")]
        [Validation(Required=false)]
        public List<string> BadWords { get; set; }

        /// <summary>
        /// <para>The vLLM or OpenAI-compatible template parameter object. The request values override the default values with the same names in the model and are passed as-is to the primary model of the Mobile-Use Agent.</para>
        /// </summary>
        [NameInMap("chatTemplateKwargs")]
        [Validation(Required=false)]
        public GuiChatCompletionStreamRequestChatTemplateKwargs ChatTemplateKwargs { get; set; }
        public class GuiChatCompletionStreamRequestChatTemplateKwargs : TeaModel {
            /// <summary>
            /// <para>chat_template_kwargs.enable_thinking: the request-level switch for model thinking, which overrides the default value with the same name. Enabling this switch does not cause the Mobile-Use Agent response to return reasoning_content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableThinking")]
            [Validation(Required=false)]
            public bool? EnableThinking { get; set; }

            /// <summary>
            /// <para>Specifies whether to preserve the existing thinking context in subsequent rounds. This parameter is passed as-is according to the vLLM or Qwen chat_template_kwargs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("preserveThinking")]
            [Validation(Required=false)]
            public bool? PreserveThinking { get; set; }

        }

        /// <summary>
        /// <para>The frequency penalty parameter, which is passed through to the primary model of the Mobile-Use Agent.</para>
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
        /// <para>Specifies whether to request the upstream to generate the reasoning field. The client-facing results of the Mobile-Use Agent do not directly expose internal thinking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("includeReasoning")]
        [Validation(Required=false)]
        public bool? IncludeReasoning { get; set; }

        /// <summary>
        /// <para>The model compatibility parameter. The JSON field is logprobs. Whether this parameter is accepted and takes effect depends on the model used by the instance. The current Mobile-Use Agent response does not provide token log probability details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("logprobs")]
        [Validation(Required=false)]
        public bool? Logprobs { get; set; }

        /// <summary>
        /// <para>The OpenAI-compatible maximum number of completion tokens. If provided, the value must be greater than 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("maxCompletionTokens")]
        [Validation(Required=false)]
        public long? MaxCompletionTokens { get; set; }

        /// <summary>
        /// <para>The OpenAI-compatible maximum number of generated tokens. If provided, the value must be greater than 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("maxTokens")]
        [Validation(Required=false)]
        public long? MaxTokens { get; set; }

        /// <summary>
        /// <para>The messages for the current Mobile-Use Agent step. The first step can only contain one user message. Subsequent steps can only contain one tool message followed by one user message. Complete multi-round history is not allowed.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<GuiChatCompletionStreamRequestMessages> Messages { get; set; }
        public class GuiChatCompletionStreamRequestMessages : TeaModel {
            /// <summary>
            /// <para>The message content. For a user message, use a content array that contains exactly one current screenshot and optionally attached task text. Screenshots support public HTTPS URLs or Base64 image data URLs. When role is set to tool, fill in the actual execution result of the previous action, which can be a non-empty string, object, or array.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public List<GuiChatCompletionStreamRequestMessagesContent> Content { get; set; }
            public class GuiChatCompletionStreamRequestMessagesContent : TeaModel {
                /// <summary>
                /// <para>The compatible inline image field for input_image. You can pass a Base64 data URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>data:image/png;base64,...</para>
                /// </summary>
                [NameInMap("imageData")]
                [Validation(Required=false)]
                public string ImageData { get; set; }

                /// <summary>
                /// <para>The screenshot reference. Supports an image_url string or an object containing a url field. The object format is shown here.</para>
                /// </summary>
                [NameInMap("imageUrl")]
                [Validation(Required=false)]
                public GuiChatCompletionStreamRequestMessagesContentImageUrl ImageUrl { get; set; }
                public class GuiChatCompletionStreamRequestMessagesContentImageUrl : TeaModel {
                    /// <summary>
                    /// <para>A publicly accessible HTTPS image URL or a Base64 image data URL. Each round of user messages must and can only contain one current screenshot. Expired or inaccessible image addresses are rejected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/screenshot.png">https://example.com/screenshot.png</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The text content, which can describe the current operation objective or supplement the current page state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Click the search button</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The type of the content item. Use text or input_text for text. Use image_url or input_image for screenshots.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The message role. The current input must end with a user message. If an execution receipt from the previous round exists, the preceding message must be a tool message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>Required when role is set to tool. References the tool_call ID from the previous Mobile-Use Agent response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>call_gui_1</para>
            /// </summary>
            [NameInMap("toolCallId")]
            [Validation(Required=false)]
            public string ToolCallId { get; set; }

        }

        /// <summary>
        /// <para>The metadata for the Mobile-Use Agent step. Supports screen_width, screen_height, available_apps, and the compatibility field harness_message. The tool receipt and harness_message cannot be passed at the same time.</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public GuiChatCompletionStreamRequestMetadata Metadata { get; set; }
        public class GuiChatCompletionStreamRequestMetadata : TeaModel {
            /// <summary>
            /// <para>The compatible alias for available_apps, which is also an array of app name strings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;Chrome&quot;,&quot;Settings&quot;]</para>
            /// </summary>
            [NameInMap("appList")]
            [Validation(Required=false)]
            public List<string> AppList { get; set; }

            /// <summary>
            /// <para>The supplementary list of application names for the Standard Edition of Mobile-Use Agent. The JSON field is available_apps. The newly passed list replaces the previous supplementary items, but the default applications are retained. An empty array does not clear the default applications. The Dedicated Edition of Mobile-Use Agent does not use this list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;Chrome&quot;,&quot;Settings&quot;]</para>
            /// </summary>
            [NameInMap("availableApps")]
            [Validation(Required=false)]
            public List<string> AvailableApps { get; set; }

            /// <summary>
            /// <para>The Mobile-Use Agent Harness receipt text for legacy clients. This cannot be passed at the same time as the preceding tool message. New clients should prioritize using [tool,user] messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>previous action completed</para>
            /// </summary>
            [NameInMap("harnessMessage")]
            [Validation(Required=false)]
            public string HarnessMessage { get; set; }

            /// <summary>
            /// <para>The screen height as a positive integer. For Base64 images, the width and height are parsed from the image itself. For URL images, this value is used for the runtime screen size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("screenHeight")]
            [Validation(Required=false)]
            public long? ScreenHeight { get; set; }

            /// <summary>
            /// <para>The screen width as a positive integer. For Base64 images, the width and height are parsed from the image itself. For URL images, this value is used for the runtime screen size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("screenWidth")]
            [Validation(Required=false)]
            public long? ScreenWidth { get; set; }

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
        /// <para>The multimodal preprocessor parameters, passed through to the Mobile-Use Agent primary model as-is by key.</para>
        /// </summary>
        [NameInMap("mmProcessorKwargs")]
        [Validation(Required=false)]
        public GuiChatCompletionStreamRequestMmProcessorKwargs MmProcessorKwargs { get; set; }
        public class GuiChatCompletionStreamRequestMmProcessorKwargs : TeaModel {
            /// <summary>
            /// <para>The maximum number of dynamic image patches allowed by the vision model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("maxDynamicPatch")]
            [Validation(Required=false)]
            public long? MaxDynamicPatch { get; set; }

        }

        /// <summary>
        /// <para>Reserved for OpenAI client compatibility. This parameter is ignored during routing. The model is determined by the published configuration of the instance, and the model field in the response is always an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot; &quot;</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>Set this parameter to 1. Whether this parameter is accepted depends on the model. The current Mobile-Use Agent response does not return multiple candidate actions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("n")]
        [Validation(Required=false)]
        public long? N { get; set; }

        /// <summary>
        /// <para>The model-compatible switch to invoke parallel tool calling. This parameter does not expand the set of Mobile-Use Agent actions active for this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("parallelToolCalls")]
        [Validation(Required=false)]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// <para>The presence penalty parameter, passed through to the Mobile-Use Agent primary model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("presencePenalty")]
        [Validation(Required=false)]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// <para>A model-compatible parameter. The JSON field is prompt_logprobs. Whether this parameter is accepted depends on the model. The current Mobile-Use Agent response does not return input token probability details.</para>
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
        /// <para>medium</para>
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
        /// <para>The model-compatible structured output options. This parameter does not change the final Mobile-Use Agent tool calling structure when you invoke this operation. Avoid output constraint Settings that conflict with the action protocol.</para>
        /// </summary>
        [NameInMap("responseFormat")]
        [Validation(Required=false)]
        public GuiChatCompletionStreamRequestResponseFormat ResponseFormat { get; set; }
        public class GuiChatCompletionStreamRequestResponseFormat : TeaModel {
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
        /// <para>The stop sequences. This parameter is compatible with a single string or an array of strings. The array format is shown here.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;DONE&quot;]</para>
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
        /// <para>Specifies whether to use Server-Sent Events (SSE) for streaming responses. You must set this parameter to true for this operation.</para>
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
        public GuiChatCompletionStreamRequestStreamOptions StreamOptions { get; set; }
        public class GuiChatCompletionStreamRequestStreamOptions : TeaModel {
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
        public GuiChatCompletionStreamRequestStructuredOutputs StructuredOutputs { get; set; }
        public class GuiChatCompletionStreamRequestStructuredOutputs : TeaModel {
            /// <summary>
            /// <para>The set of allowed enum text values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;tap&quot;,&quot;type&quot;]</para>
            /// </summary>
            [NameInMap("choice")]
            [Validation(Required=false)]
            public List<string> Choice { get; set; }

        }

        /// <summary>
        /// <para>The sampling temperature, which overrides the default value of the Mobile-Use Agent primary model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.2</para>
        /// </summary>
        [NameInMap("temperature")]
        [Validation(Required=false)]
        public double? Temperature { get; set; }

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
        /// <para>A model-compatible parameter. The JSON field is top_logprobs. Whether this parameter is accepted depends on the model. The current Mobile-Use Agent response does not return candidate token probability details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("topLogprobs")]
        [Validation(Required=false)]
        public long? TopLogprobs { get; set; }

        /// <summary>
        /// <para>The Top-P nucleus sampling parameter, which overrides the default value of the Mobile-Use Agent primary model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.9</para>
        /// </summary>
        [NameInMap("topP")]
        [Validation(Required=false)]
        public double? TopP { get; set; }

    }

}

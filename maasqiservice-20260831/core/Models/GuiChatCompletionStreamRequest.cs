// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaasQIService20260831.Models
{
    public class GuiChatCompletionStreamRequest : TeaModel {
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
        public GuiChatCompletionStreamRequestChatTemplateKwargs ChatTemplateKwargs { get; set; }
        public class GuiChatCompletionStreamRequestChatTemplateKwargs : TeaModel {
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
        public List<GuiChatCompletionStreamRequestMessages> Messages { get; set; }
        public class GuiChatCompletionStreamRequestMessages : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public List<GuiChatCompletionStreamRequestMessagesContent> Content { get; set; }
            public class GuiChatCompletionStreamRequestMessagesContent : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>data:image/png;base64,...</para>
                /// </summary>
                [NameInMap("imageData")]
                [Validation(Required=false)]
                public string ImageData { get; set; }

                [NameInMap("imageUrl")]
                [Validation(Required=false)]
                public GuiChatCompletionStreamRequestMessagesContentImageUrl ImageUrl { get; set; }
                public class GuiChatCompletionStreamRequestMessagesContentImageUrl : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/screenshot.png">https://example.com/screenshot.png</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>点击搜索按钮</para>
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
            /// <para>call_gui_1</para>
            /// </summary>
            [NameInMap("toolCallId")]
            [Validation(Required=false)]
            public string ToolCallId { get; set; }

        }

        [NameInMap("metadata")]
        [Validation(Required=false)]
        public GuiChatCompletionStreamRequestMetadata Metadata { get; set; }
        public class GuiChatCompletionStreamRequestMetadata : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;Chrome&quot;,&quot;Settings&quot;]</para>
            /// </summary>
            [NameInMap("appList")]
            [Validation(Required=false)]
            public List<string> AppList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;Chrome&quot;,&quot;Settings&quot;]</para>
            /// </summary>
            [NameInMap("availableApps")]
            [Validation(Required=false)]
            public List<string> AvailableApps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>previous action completed</para>
            /// </summary>
            [NameInMap("harnessMessage")]
            [Validation(Required=false)]
            public string HarnessMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("screenHeight")]
            [Validation(Required=false)]
            public long? ScreenHeight { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("screenWidth")]
            [Validation(Required=false)]
            public long? ScreenWidth { get; set; }

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
        public GuiChatCompletionStreamRequestMmProcessorKwargs MmProcessorKwargs { get; set; }
        public class GuiChatCompletionStreamRequestMmProcessorKwargs : TeaModel {
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
        /// <para>medium</para>
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
        public GuiChatCompletionStreamRequestResponseFormat ResponseFormat { get; set; }
        public class GuiChatCompletionStreamRequestResponseFormat : TeaModel {
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
        /// <para>[&quot;DONE&quot;]</para>
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
        public GuiChatCompletionStreamRequestStreamOptions StreamOptions { get; set; }
        public class GuiChatCompletionStreamRequestStreamOptions : TeaModel {
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
        public GuiChatCompletionStreamRequestStructuredOutputs StructuredOutputs { get; set; }
        public class GuiChatCompletionStreamRequestStructuredOutputs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;tap&quot;,&quot;type&quot;]</para>
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

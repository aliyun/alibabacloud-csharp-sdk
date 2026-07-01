// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AIAgentOutboundCallConfig : TeaModel {
        /// <summary>
        /// <para>The configurations for ambient sound.</para>
        /// </summary>
        [NameInMap("AmbientSoundConfig")]
        [Validation(Required=false)]
        public AIAgentOutboundCallConfigAmbientSoundConfig AmbientSoundConfig { get; set; }
        public class AIAgentOutboundCallConfigAmbientSoundConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the ambient sound. You can obtain the ID from the advanced configurations of the AI agent on the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f67901c595834************</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The volume of the ambient sound. Valid values: 0 to 100. A value of 0 disables the sound.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Volume")]
            [Validation(Required=false)]
            public int? Volume { get; set; }

        }

        /// <summary>
        /// <para>The automatic speech recognition (ASR) configurations.</para>
        /// </summary>
        [NameInMap("AsrConfig")]
        [Validation(Required=false)]
        public AIAgentOutboundCallConfigAsrConfig AsrConfig { get; set; }
        public class AIAgentOutboundCallConfigAsrConfig : TeaModel {
            /// <summary>
            /// <para>The list of hotwords for ASR. You can specify a maximum of 128 hotwords in the list.</para>
            /// </summary>
            [NameInMap("AsrHotWords")]
            [Validation(Required=false)]
            public List<string> AsrHotWords { get; set; }

            /// <summary>
            /// <para>The language ID for ASR. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>zh_mandarin</c>: Chinese</para>
            /// </description></item>
            /// <item><description><para><c>en</c>: English</para>
            /// </description></item>
            /// <item><description><para><c>zh_en</c>: Chinese and English</para>
            /// </description></item>
            /// <item><description><para><c>es</c>: Spanish</para>
            /// </description></item>
            /// <item><description><para><c>jp</c>: Japanese</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh_mandarin</para>
            /// </summary>
            [NameInMap("AsrLanguageId")]
            [Validation(Required=false)]
            public string AsrLanguageId { get; set; }

            /// <summary>
            /// <para>The sentence segmentation threshold. If the duration of a silence exceeds this threshold, the system determines that the sentence is complete. Valid values: 200 to 1200. Unit: ms. Default value: 400.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("AsrMaxSilence")]
            [Validation(Required=false)]
            public int? AsrMaxSilence { get; set; }

            /// <summary>
            /// <para>The passthrough parameters for proprietary ASR.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mode=fast&amp;sample=16000&amp;format=wav</para>
            /// </summary>
            [NameInMap("CustomParams")]
            [Validation(Required=false)]
            public string CustomParams { get; set; }

            /// <summary>
            /// <para>The minimum duration threshold for VAD. This parameter controls the interruption sensitivity. A value of 0 indicates that this feature is disabled. Valid values: 200 to 2000. Unit: ms. A value from 200 to 500 corresponds to 1 to 4 words. The default value is empty, which indicates that this parameter is not in effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("VadDuration")]
            [Validation(Required=false)]
            public int? VadDuration { get; set; }

            /// <summary>
            /// <para>The interruption threshold for voice activity detection (VAD). Valid values: 0 to 11. Default value: 11.</para>
            /// <list type="bullet">
            /// <item><description><para>A value of 0 disables the VAD feature.</para>
            /// </description></item>
            /// <item><description><para>A value from 1 to 10 indicates that the higher the value, the less sensitive the interruption.</para>
            /// </description></item>
            /// <item><description><para>A value of 11 provides a significantly different experience from the previous values. It lowers audio distortion during conversations and enhances resistance to interference.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("VadLevel")]
            [Validation(Required=false)]
            public int? VadLevel { get; set; }

        }

        /// <summary>
        /// <para>The configurations for the automatic speech module of the AI agent, which includes prompts during LLM delays and inquiries during prolonged user silence.</para>
        /// </summary>
        [NameInMap("AutoSpeechConfig")]
        [Validation(Required=false)]
        public AIAgentOutboundCallConfigAutoSpeechConfig AutoSpeechConfig { get; set; }
        public class AIAgentOutboundCallConfigAutoSpeechConfig : TeaModel {
            /// <summary>
            /// <para>The configurations for broadcasts during LLM response delays.</para>
            /// </summary>
            [NameInMap("LlmPending")]
            [Validation(Required=false)]
            public AIAgentOutboundCallConfigAutoSpeechConfigLlmPending LlmPending { get; set; }
            public class AIAgentOutboundCallConfigAutoSpeechConfigLlmPending : TeaModel {
                /// <summary>
                /// <para>The collection of inquiry prompts. You can specify a maximum of 10 prompts. Each prompt can be up to 100 characters in length. The sum of the probabilities of all prompts must be 100%.</para>
                /// </summary>
                [NameInMap("Messages")]
                [Validation(Required=false)]
                public List<AIAgentOutboundCallConfigAutoSpeechConfigLlmPendingMessages> Messages { get; set; }
                public class AIAgentOutboundCallConfigAutoSpeechConfigLlmPendingMessages : TeaModel {
                    /// <summary>
                    /// <para>The selection probability of the prompt. Valid values: 0 to 1, which corresponds to 0% to 100%.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("Probability")]
                    [Validation(Required=false)]
                    public double? Probability { get; set; }

                    /// <summary>
                    /// <para>The text of the inquiry prompt. The text can be up to 100 characters in length.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>稍等一下</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The wait time threshold for LLM responses. This parameter is required. A broadcast prompt is triggered if this threshold is exceeded. Unit: ms. Valid values: 500 to 10000. You need to configure this parameter based on the actual usage of the LLM.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("WaitTime")]
                [Validation(Required=false)]
                public int? WaitTime { get; set; }

            }

            /// <summary>
            /// <para>The configurations for inquiry broadcasts during prolonged user silence.</para>
            /// </summary>
            [NameInMap("UserIdle")]
            [Validation(Required=false)]
            public AIAgentOutboundCallConfigAutoSpeechConfigUserIdle UserIdle { get; set; }
            public class AIAgentOutboundCallConfigAutoSpeechConfigUserIdle : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>我挂了，再见</para>
                /// </summary>
                [NameInMap("HangupEndWord")]
                [Validation(Required=false)]
                public string HangupEndWord { get; set; }

                /// <summary>
                /// <para>The maximum number of inquiries. This parameter is required. Valid values: 0 to 10. After the maximum number of inquiries is reached, no more inquiries are triggered, and the call is disconnected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("MaxRepeats")]
                [Validation(Required=false)]
                public int? MaxRepeats { get; set; }

                /// <summary>
                /// <para>The collection of inquiry prompts. You can specify a maximum of 10 prompts. Each prompt can be up to 100 characters in length. The sum of the probabilities of all prompts must be 100%.</para>
                /// </summary>
                [NameInMap("Messages")]
                [Validation(Required=false)]
                public List<AIAgentOutboundCallConfigAutoSpeechConfigUserIdleMessages> Messages { get; set; }
                public class AIAgentOutboundCallConfigAutoSpeechConfigUserIdleMessages : TeaModel {
                    /// <summary>
                    /// <para>The selection probability of the prompt. Valid values: 0 to 1, which corresponds to 0% to 100%.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("Probability")]
                    [Validation(Required=false)]
                    public double? Probability { get; set; }

                    /// <summary>
                    /// <para>The text of the inquiry prompt. The text can be up to 100 characters in length.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>您还在吗？</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                /// <summary>
                /// <para>The silence duration threshold. This parameter is required. An inquiry is triggered if this threshold is exceeded. Unit: ms. Valid values: 5000 to 600000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("WaitTime")]
                [Validation(Required=false)]
                public int? WaitTime { get; set; }

            }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is deprecated. Use <c>BackChannelingConfigs</c> instead.</para>
        /// </summary>
        [NameInMap("BackChannelingConfig")]
        [Validation(Required=false)]
        [Obsolete]
        public AIAgentOutboundCallConfigBackChannelingConfig BackChannelingConfig { get; set; }
        public class AIAgentOutboundCallConfigBackChannelingConfig : TeaModel {
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("Probability")]
            [Validation(Required=false)]
            public double? Probability { get; set; }

            [NameInMap("TriggerStage")]
            [Validation(Required=false)]
            public string TriggerStage { get; set; }

            [NameInMap("Words")]
            [Validation(Required=false)]
            public AIAgentOutboundCallConfigBackChannelingConfigWords Words { get; set; }
            public class AIAgentOutboundCallConfigBackChannelingConfigWords : TeaModel {
                [NameInMap("Probability")]
                [Validation(Required=false)]
                public double? Probability { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

        }

        /// <summary>
        /// <para>The configurations for the back-channeling feature module. If you enable this feature, the system randomly plays short and affirmative phrases at specific trigger points.</para>
        /// </summary>
        [NameInMap("BackChannelingConfigs")]
        [Validation(Required=false)]
        public List<AIAgentOutboundCallConfigBackChannelingConfigs> BackChannelingConfigs { get; set; }
        public class AIAgentOutboundCallConfigBackChannelingConfigs : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the back-channeling feature. This parameter is required. Valid values: true and false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The trigger probability. This parameter is required. Valid values: 0.0 to 1.0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("Probability")]
            [Validation(Required=false)]
            public double? Probability { get; set; }

            /// <summary>
            /// <para>The trigger point for back-channeling. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><c>pause_detected</c>: triggered when a short pause in speech is detected</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pause_detected</para>
            /// </summary>
            [NameInMap("TriggerStage")]
            [Validation(Required=false)]
            public string TriggerStage { get; set; }

            /// <summary>
            /// <para>The collection of back-channeling phrases. You can specify a maximum of 10 phrases. Each phrase can be up to 20 characters in length. The sum of the probabilities of all phrases must be 1.0.</para>
            /// </summary>
            [NameInMap("Words")]
            [Validation(Required=false)]
            public List<AIAgentOutboundCallConfigBackChannelingConfigsWords> Words { get; set; }
            public class AIAgentOutboundCallConfigBackChannelingConfigsWords : TeaModel {
                /// <summary>
                /// <para>The selection probability of this phrase. This parameter is required. Valid values: 0.0 to 1.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.3</para>
                /// </summary>
                [NameInMap("Probability")]
                [Validation(Required=false)]
                public double? Probability { get; set; }

                /// <summary>
                /// <para>The text of the phrase. This parameter is required. The text can be up to 20 characters in length and supports multiple languages.</para>
                /// 
                /// <b>Example:</b>
                /// <para>嗯嗯</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

        }

        /// <summary>
        /// <para>Specifies whether to enable intelligent segmentation. If you enable this feature, short and consecutive speech segments from the user are merged into a complete sentence. Default value: <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableIntelligentSegment")]
        [Validation(Required=false)]
        public bool? EnableIntelligentSegment { get; set; }

        /// <summary>
        /// <para>The parameters for experimental features. If you have any requirements, contact technical support.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("ExperimentalConfig")]
        [Validation(Required=false)]
        public string ExperimentalConfig { get; set; }

        /// <summary>
        /// <para>The welcome message. This change takes effect in the next call session. If this parameter is not set, no welcome message is played.</para>
        /// 
        /// <b>Example:</b>
        /// <para>你好</para>
        /// </summary>
        [NameInMap("Greeting")]
        [Validation(Required=false)]
        public string Greeting { get; set; }

        /// <summary>
        /// <para>The delay before the welcome message is played. Unit: ms. Default value: 0. Valid values: 0 to 5000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("GreetingDelay")]
        [Validation(Required=false)]
        public int? GreetingDelay { get; set; }

        /// <summary>
        /// <para>The speech interruption policy configurations.</para>
        /// </summary>
        [NameInMap("InterruptConfig")]
        [Validation(Required=false)]
        public AIAgentOutboundCallConfigInterruptConfig InterruptConfig { get; set; }
        public class AIAgentOutboundCallConfigInterruptConfig : TeaModel {
            /// <term><b>Obsolete</b></term>
            [NameInMap("Eagerness")]
            [Validation(Required=false)]
            [Obsolete]
            public string Eagerness { get; set; }

            /// <summary>
            /// <para>Specifies whether to support speech interruption. Default value: true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableVoiceInterrupt")]
            [Validation(Required=false)]
            public bool? EnableVoiceInterrupt { get; set; }

            /// <summary>
            /// <para>The specific words or phrases that trigger a conversation interruption.</para>
            /// </summary>
            [NameInMap("InterruptWords")]
            [Validation(Required=false)]
            public List<string> InterruptWords { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("KeepInterruptWordsForLLM")]
            [Validation(Required=false)]
            public bool? KeepInterruptWordsForLLM { get; set; }

            /// <summary>
            /// <para>The ASR processing policy in <c>NoInterruptMode</c>.</para>
            /// <list type="bullet">
            /// <item><description><para><c>cache</c>: caches the ASR text. The cached ASR text is processed in the next conversational turn.</para>
            /// </description></item>
            /// <item><description><para><c>discard</c>: discards the ASR text.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cache</para>
            /// </summary>
            [NameInMap("NoInterruptMode")]
            [Validation(Required=false)]
            public string NoInterruptMode { get; set; }

        }

        /// <summary>
        /// <para>The configurations of the large language model (LLM).</para>
        /// </summary>
        [NameInMap("LlmConfig")]
        [Validation(Required=false)]
        public AIAgentOutboundCallConfigLlmConfig LlmConfig { get; set; }
        public class AIAgentOutboundCallConfigLlmConfig : TeaModel {
            /// <summary>
            /// <para>The parameters for Alibaba Cloud Model Studio. For more information about the parameter format, see <a href="https://help.aliyun.com/document_detail/2858132.html">Alibaba Cloud Model Studio parameters</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{\&quot;biz_params\&quot;:{\&quot;user_defined_params\&quot;:{\&quot;your_plugin_id\&quot;:{\&quot;article_index\&quot;:2}}},\&quot;memory_id\&quot;:\&quot;your_memory_id\&quot;,\&quot;image_list\&quot;:[\&quot;<a href="https://your_image_url%5C%5C%22%5D,%5C%5C%22rag_options%5C%5C%22:%7B%5C%5C%22pipeline_ids%5C%5C%22:%5B%5C%5C%22your_id%5C%5C%22%5D,%5C%5C%22file_ids%5C%5C%22:%5B%5C%5C%22%E6%96%87%E6%A1%A3ID1%5C%5C%22,%5C%5C%22%E6%96%87%E6%A1%A3ID2%5C%5C%22%5D,%5C%5C%22metadata_filter%5C%5C%22:%7B%5C%5C%22name%5C%5C%22:%5C%5C%22%E5%BC%A0%E4%B8%89%5C%5C%22%7D,%5C%5C%22structured_filter%5C%5C%22:%7B%5C%5C%22key1%5C%5C%22:%5C%5C%22value1%5C%5C%22,%5C%5C%22key2%5C%5C%22:%5C%5C%22value2%5C%5C%22%7D,%5C%5C%22tags%5C%5C%22:%5B%5C%5C%22%E6%A0%87%E7%AD%BE1%5C%5C%22,%5C%5C%22%E6%A0%87%E7%AD%BE2%5C%5C%22%5D%7D%7D">https://your_image_url\\&quot;],\\&quot;rag_options\\&quot;:{\\&quot;pipeline_ids\\&quot;:[\\&quot;your_id\\&quot;],\\&quot;file_ids\\&quot;:[\\&quot;文档ID1\\&quot;,\\&quot;文档ID2\\&quot;],\\&quot;metadata_filter\\&quot;:{\\&quot;name\\&quot;:\\&quot;张三\\&quot;},\\&quot;structured_filter\\&quot;:{\\&quot;key1\\&quot;:\\&quot;value1\\&quot;,\\&quot;key2\\&quot;:\\&quot;value2\\&quot;},\\&quot;tags\\&quot;:[\\&quot;标签1\\&quot;,\\&quot;标签2\\&quot;]}}</a>&quot;</para>
            /// </summary>
            [NameInMap("BailianAppParams")]
            [Validation(Required=false)]
            public string BailianAppParams { get; set; }

            /// <summary>
            /// <para>The list of function mappings, which is used to map AI agent capabilities to LLM functions. This feature is supported only when function calls are used in custom LLMs that are compatible with the OpenAI protocol.</para>
            /// </summary>
            [NameInMap("FunctionMap")]
            [Validation(Required=false)]
            public List<AIAgentOutboundCallConfigLlmConfigFunctionMap> FunctionMap { get; set; }
            public class AIAgentOutboundCallConfigLlmConfigFunctionMap : TeaModel {
                /// <summary>
                /// <para>The name of the built-in function provided by the AI agent in Alibaba Cloud. The value hangup is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hangup</para>
                /// </summary>
                [NameInMap("Function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                /// <summary>
                /// <para>The name of the LLM function that corresponds to this function. This parameter is customized and used to call the corresponding function in the LLM. For more information about the protocol for custom LLMs, see <a href="https://help.aliyun.com/document_detail/2839094.html">Standard LLM API</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hangup</para>
                /// </summary>
                [NameInMap("MatchFunction")]
                [Validation(Required=false)]
                public string MatchFunction { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to keep the LLM message history consistent with the TTS playback content. Default value: false. If you enable this feature, the saved LLM messages are consistent with the TTS playback content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HistorySyncWithTTS")]
            [Validation(Required=false)]
            public bool? HistorySyncWithTTS { get; set; }

            /// <summary>
            /// <para>If you enable this feature, the system sends the complete LLM-generated result to the client after the generation is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("LlmCompleteReply")]
            [Validation(Required=false)]
            public bool? LlmCompleteReply { get; set; }

            /// <summary>
            /// <para>The conversation history of the LLM or MLLM.</para>
            /// </summary>
            [NameInMap("LlmHistory")]
            [Validation(Required=false)]
            public List<AIAgentOutboundCallConfigLlmConfigLlmHistory> LlmHistory { get; set; }
            public class AIAgentOutboundCallConfigLlmConfigLlmHistory : TeaModel {
                /// <summary>
                /// <para>The text of the conversation content that records the specific expressions or responses of the role in the conversation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>你好</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The role of the participant in the conversation. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>user</c>: the user</para>
                /// </description></item>
                /// <item><description><para><c>assistant</c>: the AI assistant</para>
                /// </description></item>
                /// <item><description><para><c>system</c>: the system</para>
                /// </description></item>
                /// <item><description><para><c>function</c>: a function</para>
                /// </description></item>
                /// <item><description><para><c>plugin</c>: a plug-in</para>
                /// </description></item>
                /// <item><description><para><c>tool</c>: a tool</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of conversational turns to retain in the history of the LLM or multimodal large language model (MLLM). Default value: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("LlmHistoryLimit")]
            [Validation(Required=false)]
            public int? LlmHistoryLimit { get; set; }

            /// <summary>
            /// <para>The system prompt for the LLM after the call is initiated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>你是一位友好且乐于助人的助手，专注于为用户提供准确的信息和建议。</para>
            /// </summary>
            [NameInMap("LlmSystemPrompt")]
            [Validation(Required=false)]
            public string LlmSystemPrompt { get; set; }

            /// <summary>
            /// <para>The additional query parameters for an LLM that is compatible with the OpenAI protocol. The parameters must be in the key=value format. If you specify multiple parameters, separate them with ampersands (<c>&amp;</c>). All values must be of the string type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api-version=2024-02-01&amp;api-key=sk-xxx</para>
            /// </summary>
            [NameInMap("OpenAIExtraQuery")]
            [Validation(Required=false)]
            public string OpenAIExtraQuery { get; set; }

            /// <summary>
            /// <para>The maximum delay for text output. If this threshold is exceeded, the cached text is forcibly output. Valid values: 1000 to 10000. Unit: ms. A value of 0 or empty indicates that this parameter is not in effect. Default value: empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("OutputMaxDelay")]
            [Validation(Required=false)]
            public string OutputMaxDelay { get; set; }

            /// <summary>
            /// <para>The minimum length of text output. The unit is characters. Text shorter than this length is cached and waits for concatenation. Valid values: 0 to 100. A value of 0 or empty indicates that this parameter is not in effect. Default value: empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("OutputMinLength")]
            [Validation(Required=false)]
            public int? OutputMinLength { get; set; }

        }

        /// <summary>
        /// <para>The maximum wait time for interaction with the AI agent. If the wait time is exceeded, the AI agent goes offline. Unit: seconds. Default value: 600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("MaxIdleTime")]
        [Validation(Required=false)]
        public int? MaxIdleTime { get; set; }

        /// <summary>
        /// <para>The text-to-speech (TTS) configurations.</para>
        /// </summary>
        [NameInMap("TtsConfig")]
        [Validation(Required=false)]
        public AIAgentOutboundCallConfigTtsConfig TtsConfig { get; set; }
        public class AIAgentOutboundCallConfigTtsConfig : TeaModel {
            /// <summary>
            /// <para>Only MiniMax is supported. The following seven emotions are supported:</para>
            /// <list type="bullet">
            /// <item><description><para><c>happy</c></para>
            /// </description></item>
            /// <item><description><para><c>sad</c></para>
            /// </description></item>
            /// <item><description><para><c>angry</c></para>
            /// </description></item>
            /// <item><description><para><c>fearful</c></para>
            /// </description></item>
            /// <item><description><para><c>disgusted</c></para>
            /// </description></item>
            /// <item><description><para><c>surprised</c></para>
            /// </description></item>
            /// <item><description><para><c>calm</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>happy</para>
            /// </summary>
            [NameInMap("Emotion")]
            [Validation(Required=false)]
            public string Emotion { get; set; }

            /// <summary>
            /// <para>Only MiniMax is supported. The default value is empty. This parameter enhances the recognition of specific minority languages and dialects. After you set this parameter, the speech performance in the specified minority language or dialect scenarios is improved. If the minority language type is unknown, you can set this parameter to <c>auto</c> to enable the model to automatically determine the minority language type. Valid values:</para>
            /// <details>
            /// 
            /// <summary>
            /// 
            /// <para>Supported languages</para>
            /// </summary>
            /// 
            /// <list type="bullet">
            /// <item><description><para><c>Chinese</c>: Chinese</para>
            /// </description></item>
            /// <item><description><para><c>Chinese,Yue</c>: Cantonese</para>
            /// </description></item>
            /// <item><description><para><c>English</c>: English</para>
            /// </description></item>
            /// <item><description><para><c>Arabic</c>: Arabic</para>
            /// </description></item>
            /// <item><description><para><c>Russian</c>: Russian</para>
            /// </description></item>
            /// <item><description><para><c>Spanish</c>: Spanish</para>
            /// </description></item>
            /// <item><description><para><c>French</c>: French</para>
            /// </description></item>
            /// <item><description><para><c>Portuguese</c>: Portuguese</para>
            /// </description></item>
            /// <item><description><para><c>German</c>: German</para>
            /// </description></item>
            /// <item><description><para><c>Turkish</c>: Turkish</para>
            /// </description></item>
            /// <item><description><para><c>Dutch</c>: Dutch</para>
            /// </description></item>
            /// <item><description><para><c>Ukrainian</c>: Ukrainian</para>
            /// </description></item>
            /// <item><description><para><c>Vietnamese</c>: Vietnamese</para>
            /// </description></item>
            /// <item><description><para><c>Indonesian</c>: Indonesian</para>
            /// </description></item>
            /// <item><description><para><c>Japanese</c>: Japanese</para>
            /// </description></item>
            /// <item><description><para><c>Italian</c>: Italian</para>
            /// </description></item>
            /// <item><description><para><c>Korean</c>: Korean</para>
            /// </description></item>
            /// <item><description><para><c>Thai</c>: Thai</para>
            /// </description></item>
            /// <item><description><para><c>Polish</c>: Polish</para>
            /// </description></item>
            /// <item><description><para><c>Romanian</c>: Romanian</para>
            /// </description></item>
            /// <item><description><para><c>Greek</c>: Greek</para>
            /// </description></item>
            /// <item><description><para><c>Czech</c>: Czech</para>
            /// </description></item>
            /// <item><description><para><c>Finnish</c>: Finnish</para>
            /// </description></item>
            /// <item><description><para><c>Hindi</c>: Hindi</para>
            /// </description></item>
            /// <item><description><para><c>auto</c>: Automatic detection</para>
            /// </description></item>
            /// </list>
            /// </details>
            /// 
            /// <b>Example:</b>
            /// <para>Chinese</para>
            /// </summary>
            [NameInMap("LanguageId")]
            [Validation(Required=false)]
            public string LanguageId { get; set; }

            /// <summary>
            /// <para>Only MiniMax is supported. Valid values: <c>speech-01-turbo</c> and <c>speech-02-turbo</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>speech-01-turbo</para>
            /// </summary>
            [NameInMap("ModelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            /// <summary>
            /// <para>The TTS pronunciation rules. You can specify a maximum of 20 rules in the array. The rules are executed in sequence.</para>
            /// </summary>
            [NameInMap("PronunciationRules")]
            [Validation(Required=false)]
            public List<AIAgentOutboundCallConfigTtsConfigPronunciationRules> PronunciationRules { get; set; }
            public class AIAgentOutboundCallConfigTtsConfigPronunciationRules : TeaModel {
                /// <summary>
                /// <para>The target pronunciation. The pronunciation must be a Chinese character string of up to 10 characters in length and cannot contain spaces.</para>
                /// 
                /// <b>Example:</b>
                /// <para>大石烂儿</para>
                /// </summary>
                [NameInMap("Pronunciation")]
                [Validation(Required=false)]
                public string Pronunciation { get; set; }

                /// <summary>
                /// <para>The type of the pronunciation rule. Valid value:</para>
                /// <list type="bullet">
                /// <item><description><c>replacement</c>: replaces the word with the specified pronunciation.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>replacement</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The word to be replaced. The word must be a Chinese character string of up to 10 characters in length and cannot contain spaces.</para>
                /// 
                /// <b>Example:</b>
                /// <para>大栅栏</para>
                /// </summary>
                [NameInMap("Word")]
                [Validation(Required=false)]
                public string Word { get; set; }

            }

            /// <summary>
            /// <para>This parameter is supported on all platforms. For CosyVoice, the default value is 1.0 and the valid values are 0.5 to 2.0. For MiniMax, the default value is 1.0 and the valid values are 0.5 to 2.0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("SpeechRate")]
            [Validation(Required=false)]
            public double? SpeechRate { get; set; }

            /// <summary>
            /// <para>The voice ID. The change takes effect on the next sentence. If you do not specify this parameter, the voice ID configured in the AI agent template is used. This parameter is valid only for preset TTS voices. The value can be up to 64 characters in length. For more information about the valid values, see <a href="https://help.aliyun.com/document_detail/449563.html">Intelligent speech effect samples</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>longcheng_v2</para>
            /// </summary>
            [NameInMap("VoiceId")]
            [Validation(Required=false)]
            public string VoiceId { get; set; }

            /// <summary>
            /// <para>The list of available voices.</para>
            /// </summary>
            [NameInMap("VoiceIdList")]
            [Validation(Required=false)]
            public List<string> VoiceIdList { get; set; }

        }

        /// <summary>
        /// <para>The configurations for conversational turn detection.</para>
        /// </summary>
        [NameInMap("TurnDetectionConfig")]
        [Validation(Required=false)]
        public AIAgentOutboundCallConfigTurnDetectionConfig TurnDetectionConfig { get; set; }
        public class AIAgentOutboundCallConfigTurnDetectionConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Low</para>
            /// </summary>
            [NameInMap("Eagerness")]
            [Validation(Required=false)]
            public string Eagerness { get; set; }

            /// <summary>
            /// <para>The mode for conversational turn detection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Normal</c>: a basic mode that does not use AI for semantic analysis.</para>
            /// </description></item>
            /// <item><description><para><c>Semantic</c>: an AI-powered mode that determines whether the user has finished speaking based on the conversational context.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>Normal</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Semantic</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The pause duration in AI mode that is used to determine whether a conversational turn has ended. Unit: ms. Default value: -1.</para>
            /// <list type="bullet">
            /// <item><description><para><c>-1</c>: The AI automatically determines an appropriate wait time.</para>
            /// </description></item>
            /// <item><description><para><c>0-10000</c>: A custom wait time. We recommend that you set this parameter to a value from 0 to 1500.</para>
            /// </description></item>
            /// </list>
            /// <para>Note: This parameter is invalid in Normal mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("SemanticWaitDuration")]
            [Validation(Required=false)]
            public int? SemanticWaitDuration { get; set; }

            /// <summary>
            /// <para>The list of keywords that are used to determine the end of a user\&quot;s conversational turn.</para>
            /// </summary>
            [NameInMap("TurnEndWords")]
            [Validation(Required=false)]
            public List<string> TurnEndWords { get; set; }

        }

    }

}

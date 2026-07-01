// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AIAgentConfig : TeaModel {
        /// <summary>
        /// <para>Configuration for ambient sound during the call.</para>
        /// </summary>
        [NameInMap("AmbientSoundConfig")]
        [Validation(Required=false)]
        public AIAgentConfigAmbientSoundConfig AmbientSoundConfig { get; set; }
        public class AIAgentConfigAmbientSoundConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the ambient sound resource. You can obtain this ID from the advanced settings of the agent configuration in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f67901c595834************</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The volume of the ambient sound. Range: 0–100. A value of 0 disables the sound.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Volume")]
            [Validation(Required=false)]
            public int? Volume { get; set; }

        }

        /// <summary>
        /// <para>Configuration for automatic speech recognition (ASR).</para>
        /// </summary>
        [NameInMap("AsrConfig")]
        [Validation(Required=false)]
        public AIAgentConfigAsrConfig AsrConfig { get; set; }
        public class AIAgentConfigAsrConfig : TeaModel {
            /// <summary>
            /// <para>A list of hotwords to improve ASR accuracy. You can specify a maximum of 128 hotwords.</para>
            /// </summary>
            [NameInMap("AsrHotWords")]
            [Validation(Required=false)]
            public List<string> AsrHotWords { get; set; }

            /// <summary>
            /// <para>The language for ASR. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>zh_mandarin</c>: Chinese (Mandarin)</para>
            /// </description></item>
            /// <item><description><para><c>en</c>: English</para>
            /// </description></item>
            /// <item><description><para><c>zh_en</c>: Chinese-English mixed</para>
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
            /// <para>The maximum duration of silence in milliseconds before the ASR engine finalizes an utterance. A pause longer than this value signals a sentence break. Range: 200–1200. Default: 400.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("AsrMaxSilence")]
            [Validation(Required=false)]
            public int? AsrMaxSilence { get; set; }

            /// <summary>
            /// <para>Passthrough parameters for proprietary ASR integrations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mode=fast&amp;sample=16000&amp;format=wav</para>
            /// </summary>
            [NameInMap("CustomParams")]
            [Validation(Required=false)]
            public string CustomParams { get; set; }

            /// <summary>
            /// <para>The minimum duration in milliseconds of continuous user speech required to trigger an interruption. This controls interruption sensitivity. A value of 0 disables this feature. Range: 200–2000. A common range is 200–500 ms, which typically corresponds to 1 to 4 Chinese characters. If omitted, this feature is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("VadDuration")]
            [Validation(Required=false)]
            public int? VadDuration { get; set; }

            /// <summary>
            /// <para>The Voice Activity Detection (VAD) threshold for interruptions. Range: 0–11. Default: 11.</para>
            /// <list type="bullet">
            /// <item><description><para><c>0</c>: Disables VAD.</para>
            /// </description></item>
            /// <item><description><para><c>1</c>–<c>10</c>: Sets the interruption sensitivity. A higher value makes the agent harder to interrupt.</para>
            /// </description></item>
            /// <item><description><para><c>11</c>: An enhanced mode with lower audio distortion and stronger noise resistance.</para>
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
        /// <para>Configuration for the agent\&quot;s automatic speech, including prompts for LLM latency and long periods of user silence.</para>
        /// </summary>
        [NameInMap("AutoSpeechConfig")]
        [Validation(Required=false)]
        public AIAgentConfigAutoSpeechConfig AutoSpeechConfig { get; set; }
        public class AIAgentConfigAutoSpeechConfig : TeaModel {
            /// <summary>
            /// <para>Configuration for prompts to play during LLM response latency.</para>
            /// </summary>
            [NameInMap("LlmPending")]
            [Validation(Required=false)]
            public AIAgentConfigAutoSpeechConfigLlmPending LlmPending { get; set; }
            public class AIAgentConfigAutoSpeechConfigLlmPending : TeaModel {
                /// <summary>
                /// <para>A collection of prompt messages. A maximum of 10 messages are supported, each up to 100 characters. The sum of all probabilities must be 100%.</para>
                /// </summary>
                [NameInMap("Messages")]
                [Validation(Required=false)]
                public List<AIAgentConfigAutoSpeechConfigLlmPendingMessages> Messages { get; set; }
                public class AIAgentConfigAutoSpeechConfigLlmPendingMessages : TeaModel {
                    /// <summary>
                    /// <para>The probability of this message being selected. Range: 0–1, corresponding to 0%–100%.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("Probability")]
                    [Validation(Required=false)]
                    public double? Probability { get; set; }

                    /// <summary>
                    /// <para>The text of the prompt message, up to 100 characters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>稍等一下</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                /// <summary>
                /// <para>The mode for handling LLM latency prompts. <c>random</c>: Plays a random message from the list. <c>sequence</c>: Plays messages in order. This is a required field.</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The wait time threshold for LLM responses. If the threshold is exceeded, a prompt is played. This is a required field. Unit: ms. Range: 500–10000. Set this value based on the actual performance of your LLM.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("WaitTime")]
                [Validation(Required=false)]
                public int? WaitTime { get; set; }

            }

            /// <summary>
            /// <para>Configuration for prompts to play when the user is silent for an extended period.</para>
            /// </summary>
            [NameInMap("UserIdle")]
            [Validation(Required=false)]
            public AIAgentConfigAutoSpeechConfigUserIdle UserIdle { get; set; }
            public class AIAgentConfigAutoSpeechConfigUserIdle : TeaModel {
                /// <summary>
                /// <para>A farewell message played before hanging up due to user inactivity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>我挂了，再见</para>
                /// </summary>
                [NameInMap("HangupEndWord")]
                [Validation(Required=false)]
                public string HangupEndWord { get; set; }

                /// <summary>
                /// <para>The maximum number of times the prompt can be repeated. Range: 0–10. This is a required field. If the limit is exceeded, the call is terminated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("MaxRepeats")]
                [Validation(Required=false)]
                public int? MaxRepeats { get; set; }

                /// <summary>
                /// <para>A collection of prompt messages. A maximum of 10 messages are supported, each up to 100 characters. The sum of all probabilities must be 100%.</para>
                /// </summary>
                [NameInMap("Messages")]
                [Validation(Required=false)]
                public List<AIAgentConfigAutoSpeechConfigUserIdleMessages> Messages { get; set; }
                public class AIAgentConfigAutoSpeechConfigUserIdleMessages : TeaModel {
                    /// <summary>
                    /// <para>The probability of this message being selected. Range: 0–1, corresponding to 0%–100%.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("Probability")]
                    [Validation(Required=false)]
                    public double? Probability { get; set; }

                    /// <summary>
                    /// <para>The text of the prompt message, up to 100 characters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>您还在吗？</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                /// <summary>
                /// <para>The silence duration threshold in milliseconds. If the user is silent for longer than this period, a prompt is triggered. Range: 5000–600000. This is a required field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("WaitTime")]
                [Validation(Required=false)]
                public int? WaitTime { get; set; }

            }

        }

        /// <summary>
        /// <para>Configuration for the avatar. This takes effect only if the workflow includes an avatar node.</para>
        /// </summary>
        [NameInMap("AvatarConfig")]
        [Validation(Required=false)]
        public AIAgentConfigAvatarConfig AvatarConfig { get; set; }
        public class AIAgentConfigAvatarConfig : TeaModel {
            /// <summary>
            /// <para>The model ID of the avatar.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5257</para>
            /// </summary>
            [NameInMap("AvatarId")]
            [Validation(Required=false)]
            public string AvatarId { get; set; }

        }

        /// <summary>
        /// <para>The URL of the avatar to display during voice calls. If omitted, no avatar is displayed.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com/a.jpg">http://example.com/a.jpg</a></para>
        /// </summary>
        [NameInMap("AvatarUrl")]
        [Validation(Required=false)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// <para>The type of the avatar URL. By default, this parameter is not set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("AvatarUrlType")]
        [Validation(Required=false)]
        public string AvatarUrlType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>已废弃，请使用 BackChannelingConfigs</para>
        /// </summary>
        [NameInMap("BackChannelingConfig")]
        [Validation(Required=false)]
        [Obsolete]
        public List<AIAgentConfigBackChannelingConfig> BackChannelingConfig { get; set; }
        public class AIAgentConfigBackChannelingConfig : TeaModel {
            /// <summary>
            /// <para>是否启用附和功能。必填，取值 true/false。</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>功能触发概率。范围 0.0–1.0。必填。</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("Probability")]
            [Validation(Required=false)]
            public double? Probability { get; set; }

            /// <summary>
            /// <para>附和触发的时机。可选值：</para>
            /// <list type="bullet">
            /// <item><description>pause_detected（检测到说话短暂停顿）</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pause_detected</para>
            /// </summary>
            [NameInMap("TriggerStage")]
            [Validation(Required=false)]
            public string TriggerStage { get; set; }

            /// <summary>
            /// <para>附和短语集合。最大 10 条，每条短语长度 ≤ 20 字符，概率总和为 1.0。</para>
            /// </summary>
            [NameInMap("Words")]
            [Validation(Required=false)]
            public List<AIAgentConfigBackChannelingConfigWords> Words { get; set; }
            public class AIAgentConfigBackChannelingConfigWords : TeaModel {
                /// <summary>
                /// <para>本短语的触发概率，范围 0.0–1.0，必填。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.3</para>
                /// </summary>
                [NameInMap("Probability")]
                [Validation(Required=false)]
                public double? Probability { get; set; }

                /// <summary>
                /// <para>短语文本，长度 ≤ 20 字符，支持多语言。必填。</para>
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
        /// <para>Configuration for back-channeling. When enabled, the system plays short, responsive phrases at specific trigger points.</para>
        /// </summary>
        [NameInMap("BackChannelingConfigs")]
        [Validation(Required=false)]
        public List<AIAgentConfigBackChannelingConfigs> BackChannelingConfigs { get; set; }
        public class AIAgentConfigBackChannelingConfigs : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable this back-channeling rule. This is a required field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The trigger probability. Range: 0.0–1.0. This is a required field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("Probability")]
            [Validation(Required=false)]
            public double? Probability { get; set; }

            /// <summary>
            /// <para>The trigger for the back-channeling. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><c>pause_detected</c>: Triggered when a short pause in speech is detected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pause_detected</para>
            /// </summary>
            [NameInMap("TriggerStage")]
            [Validation(Required=false)]
            public string TriggerStage { get; set; }

            /// <summary>
            /// <para>A collection of acknowledgment phrases. You can specify a maximum of 10 phrases. Each phrase must be 20 characters or less, and the sum of their probabilities must be 1.0.</para>
            /// </summary>
            [NameInMap("Words")]
            [Validation(Required=false)]
            public List<AIAgentConfigBackChannelingConfigsWords> Words { get; set; }
            public class AIAgentConfigBackChannelingConfigsWords : TeaModel {
                /// <summary>
                /// <para>本短语的触发概率，范围 0.0–1.0，必填。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.3</para>
                /// </summary>
                [NameInMap("Probability")]
                [Validation(Required=false)]
                public double? Probability { get; set; }

                /// <summary>
                /// <para>短语文本，长度 ≤ 20 字符，支持多语言。必填。</para>
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
        /// <para>Specifies whether to enable intelligent segmentation. When enabled, short user utterances are merged into a single sentence. Default: <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableIntelligentSegment")]
        [Validation(Required=false)]
        public bool? EnableIntelligentSegment { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable push-to-talk mode. Default: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnablePushToTalk")]
        [Validation(Required=false)]
        public bool? EnablePushToTalk { get; set; }

        /// <summary>
        /// <para>Parameters for experimental features. Contact support for assistance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("ExperimentalConfig")]
        [Validation(Required=false)]
        public string ExperimentalConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable graceful shutdown. Default: <c>false</c>.</para>
        /// <para>If enabled, the AI agent completes its current utterance before disconnecting when the task is stopped. The agent will not speak for more than 10 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("GracefulShutdown")]
        [Validation(Required=false)]
        public bool? GracefulShutdown { get; set; }

        /// <summary>
        /// <para>The welcome message the AI agent plays when joining the session. Changes apply to subsequent sessions. If omitted, no welcome message is played.</para>
        /// 
        /// <b>Example:</b>
        /// <para>你好</para>
        /// </summary>
        [NameInMap("Greeting")]
        [Validation(Required=false)]
        public string Greeting { get; set; }

        /// <summary>
        /// <para>Configuration for the speech interruption policy.</para>
        /// </summary>
        [NameInMap("InterruptConfig")]
        [Validation(Required=false)]
        public AIAgentConfigInterruptConfig InterruptConfig { get; set; }
        public class AIAgentConfigInterruptConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable speech interruption. Default: <c>true</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableVoiceInterrupt")]
            [Validation(Required=false)]
            public bool? EnableVoiceInterrupt { get; set; }

            /// <summary>
            /// <para>A list of specific words or phrases that trigger an interruption.</para>
            /// </summary>
            [NameInMap("InterruptWords")]
            [Validation(Required=false)]
            public List<string> InterruptWords { get; set; }

            /// <summary>
            /// <para>Specifies whether to include the interrupt words in the text sent to the LLM. Default: <c>false</c> (words are discarded).</para>
            /// <remarks>
            /// <para>For example, if &quot;hold on&quot; is an interrupt word and the user says &quot;hold on, what is the weather like today?&quot;, setting this to <c>false</c> results in only &quot;what is the weather like today?&quot; being sent to the LLM.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("KeepInterruptWordsForLLM")]
            [Validation(Required=false)]
            public bool? KeepInterruptWordsForLLM { get; set; }

            /// <summary>
            /// <para>Specifies how to handle user speech that occurs during a non-interruptible section of the agent\&quot;s utterance.</para>
            /// <list type="bullet">
            /// <item><description><para><c>cache</c>: Caches the user\&quot;s speech and processes it in the next conversational turn.</para>
            /// </description></item>
            /// <item><description><para><c>discard</c>: Discards the user\&quot;s speech.</para>
            /// </description></item>
            /// </list>
            /// <para>Default: <c>cache</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cache</para>
            /// </summary>
            [NameInMap("NoInterruptMode")]
            [Validation(Required=false)]
            public string NoInterruptMode { get; set; }

        }

        /// <summary>
        /// <para>Configuration for the large language model (LLM).</para>
        /// </summary>
        [NameInMap("LlmConfig")]
        [Validation(Required=false)]
        public AIAgentConfigLlmConfig LlmConfig { get; set; }
        public class AIAgentConfigLlmConfig : TeaModel {
            /// <summary>
            /// <para>Parameters for Alibaba Cloud Model Studio, provided as a JSON string. For the parameter format, see
            /// <a href="https://help.aliyun.com/document_detail/2858132.html">Alibaba Cloud Model Studio Parameters</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{\&quot;biz_params\&quot;:{\&quot;user_defined_params\&quot;:{\&quot;your_plugin_id\&quot;:{\&quot;article_index\&quot;:2}}},\&quot;memory_id\&quot;:\&quot;your_memory_id\&quot;,\&quot;image_list\&quot;:[\&quot;<a href="https://your_image_url%5C%5C%22%5D,%5C%5C%22rag_options%5C%5C%22:%7B%5C%5C%22pipeline_ids%5C%5C%22:%5B%5C%5C%22your_id%5C%5C%22%5D,%5C%5C%22file_ids%5C%5C%22:%5B%5C%5C%22%E6%96%87%E6%A1%A3ID1%5C%5C%22,%5C%5C%22%E6%96%87%E6%A1%A3ID2%5C%5C%22%5D,%5C%5C%22metadata_filter%5C%5C%22:%7B%5C%5C%22name%5C%5C%22:%5C%5C%22%E5%BC%A0%E4%B8%89%5C%5C%22%7D,%5C%5C%22structured_filter%5C%5C%22:%7B%5C%5C%22key1%5C%5C%22:%5C%5C%22value1%5C%5C%22,%5C%5C%22key2%5C%5C%22:%5C%5C%22value2%5C%5C%22%7D,%5C%5C%22tags%5C%5C%22:%5B%5C%5C%22%E6%A0%87%E7%AD%BE1%5C%5C%22,%5C%5C%22%E6%A0%87%E7%AD%BE2%5C%5C%22%5D%7D%7D">https://your_image_url\\&quot;],\\&quot;rag_options\\&quot;:{\\&quot;pipeline_ids\\&quot;:[\\&quot;your_id\\&quot;],\\&quot;file_ids\\&quot;:[\\&quot;文档ID1\\&quot;,\\&quot;文档ID2\\&quot;],\\&quot;metadata_filter\\&quot;:{\\&quot;name\\&quot;:\\&quot;张三\\&quot;},\\&quot;structured_filter\\&quot;:{\\&quot;key1\\&quot;:\\&quot;value1\\&quot;,\\&quot;key2\\&quot;:\\&quot;value2\\&quot;},\\&quot;tags\\&quot;:[\\&quot;标签1\\&quot;,\\&quot;标签2\\&quot;]}}</a>&quot;</para>
            /// </summary>
            [NameInMap("BailianAppParams")]
            [Validation(Required=false)]
            public string BailianAppParams { get; set; }

            /// <summary>
            /// <para>Maps built-in agent functions to custom LLM functions. Currently, this only supports function calling for custom, OpenAI-compatible LLMs.</para>
            /// </summary>
            [NameInMap("FunctionMap")]
            [Validation(Required=false)]
            public List<AIAgentConfigLlmConfigFunctionMap> FunctionMap { get; set; }
            public class AIAgentConfigLlmConfigFunctionMap : TeaModel {
                /// <summary>
                /// <para>The name of a built-in function provided by the AI agent system. Currently, only <c>hangup</c> is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hangup</para>
                /// </summary>
                [NameInMap("Function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                /// <summary>
                /// <para>The name of the custom LLM function that maps to the agent\&quot;s built-in function. For details on the custom LLM protocol, see <a href="https://help.aliyun.com/document_detail/2839094.html">LLM Standard Interface</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hangup</para>
                /// </summary>
                [NameInMap("MatchFunction")]
                [Validation(Required=false)]
                public string MatchFunction { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether the LLM message history is synchronized with the content played by the TTS. Default: <c>false</c>. When enabled, the saved LLM messages match the content actually played by the TTS.</para>
            /// <remarks>
            /// <para>When a user interrupts the agent, the <c>&lt;ims_agent_interrupted&gt;</c> tag is inserted into the message history at the point of interruption. This affects the next message sent to the LLM. For example:</para>
            /// </remarks>
            /// <pre><c>[
            ///   {&quot;role&quot;: &quot;user&quot;, &quot;content&quot;: &quot;Tell me a story.&quot;},
            ///   {&quot;role&quot;: &quot;assistant&quot;, &quot;content&quot;: &quot;Okay, I can tell you a story about the Three Kingdoms. Would you&lt;ims_agent_interrupted&gt; like that?&quot;},
            ///   {&quot;role&quot;: &quot;user&quot;, &quot;content&quot;: &quot;Tell me a different one.&quot;}
            /// ]
            /// </c></pre>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HistorySyncWithTTS")]
            [Validation(Required=false)]
            public bool? HistorySyncWithTTS { get; set; }

            /// <summary>
            /// <para>When set to <c>true</c>, the agent sends the entire LLM response in a single message after it is fully generated, rather than streaming it. This setting does not affect the streaming of subtitles.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("LlmCompleteReply")]
            [Validation(Required=false)]
            public bool? LlmCompleteReply { get; set; }

            /// <summary>
            /// <para>The conversation history context for the LLM/MLLM.</para>
            /// </summary>
            [NameInMap("LlmHistory")]
            [Validation(Required=false)]
            public List<AIAgentConfigLlmConfigLlmHistory> LlmHistory { get; set; }
            public class AIAgentConfigLlmConfigLlmHistory : TeaModel {
                /// <summary>
                /// <para>The text content of the message from this role.</para>
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
                /// <item><description><para><c>user</c></para>
                /// </description></item>
                /// <item><description><para><c>assistant</c></para>
                /// </description></item>
                /// <item><description><para><c>system</c></para>
                /// </description></item>
                /// <item><description><para><c>function</c></para>
                /// </description></item>
                /// <item><description><para><c>plugin</c></para>
                /// </description></item>
                /// <item><description><para><c>tool</c></para>
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
            /// <para>The maximum number of recent conversational turns to include in the LLM/MLLM context. Default: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("LlmHistoryLimit")]
            [Validation(Required=false)]
            public int? LlmHistoryLimit { get; set; }

            /// <summary>
            /// <para>The system prompt for the LLM after the call starts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>你是一位友好且乐于助人的助手，专注于为用户提供准确的信息和建议。</para>
            /// </summary>
            [NameInMap("LlmSystemPrompt")]
            [Validation(Required=false)]
            public string LlmSystemPrompt { get; set; }

            /// <summary>
            /// <para>Additional query parameters for an OpenAI-compatible LLM. Parameters must be provided as a URL query string (e.g., <c>key1=value1&amp;key2=value2</c>). All values must be strings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api-version=2024-02-01&amp;api-key=sk-xxx</para>
            /// </summary>
            [NameInMap("OpenAIExtraQuery")]
            [Validation(Required=false)]
            public string OpenAIExtraQuery { get; set; }

            /// <summary>
            /// <para>The maximum delay in milliseconds before buffered text is sent to the TTS engine, even if <c>OutputMinLength</c> is not met. Range: 1000–10000. A value of <c>0</c> or omitting this parameter disables the delay limit. Default: Not set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("OutputMaxDelay")]
            [Validation(Required=false)]
            public int? OutputMaxDelay { get; set; }

            /// <summary>
            /// <para>The minimum number of characters in a text chunk before it is sent to the TTS engine. Shorter chunks are buffered. Range: 0–100. A value of <c>0</c> or omitting this parameter disables buffering. Default: Not set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("OutputMinLength")]
            [Validation(Required=false)]
            public int? OutputMinLength { get; set; }

        }

        /// <summary>
        /// <para>The maximum idle duration in seconds before the AI agent disconnects. If the agent receives no user interaction within this period, it ends the task. Default: 600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("MaxIdleTime")]
        [Validation(Required=false)]
        public int? MaxIdleTime { get; set; }

        /// <summary>
        /// <para>Configuration for text-to-speech (TTS).</para>
        /// </summary>
        [NameInMap("TtsConfig")]
        [Validation(Required=false)]
        public AIAgentConfigTtsConfig TtsConfig { get; set; }
        public class AIAgentConfigTtsConfig : TeaModel {
            /// <summary>
            /// <para>This parameter applies only to the Minimax provider. Supported emotions include:</para>
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
            /// <para>This parameter is for the minimax provider only. It enhances recognition for specific low-resource languages and dialects. If the language is unknown, set this to <c>auto</c> for automatic detection. By default, this parameter is not set. Supported values include:</para>
            /// <details>
            /// 
            /// <summary>
            /// 
            /// <para>Supported languages</para>
            /// </summary>
            /// 
            /// <list type="bullet">
            /// <item><description><para>Chinese</para>
            /// </description></item>
            /// <item><description><para>Chinese,Yue: Cantonese</para>
            /// </description></item>
            /// <item><description><para>English</para>
            /// </description></item>
            /// <item><description><para>Arabic</para>
            /// </description></item>
            /// <item><description><para>Russian</para>
            /// </description></item>
            /// <item><description><para>Spanish</para>
            /// </description></item>
            /// <item><description><para>French</para>
            /// </description></item>
            /// <item><description><para>Portuguese</para>
            /// </description></item>
            /// <item><description><para>German</para>
            /// </description></item>
            /// <item><description><para>Turkish</para>
            /// </description></item>
            /// <item><description><para>Dutch</para>
            /// </description></item>
            /// <item><description><para>Ukrainian</para>
            /// </description></item>
            /// <item><description><para>Vietnamese</para>
            /// </description></item>
            /// <item><description><para>Indonesian</para>
            /// </description></item>
            /// <item><description><para>Japanese</para>
            /// </description></item>
            /// <item><description><para>Italian</para>
            /// </description></item>
            /// <item><description><para>Korean</para>
            /// </description></item>
            /// <item><description><para>Thai</para>
            /// </description></item>
            /// <item><description><para>Polish</para>
            /// </description></item>
            /// <item><description><para>Romanian</para>
            /// </description></item>
            /// <item><description><para>Greek</para>
            /// </description></item>
            /// <item><description><para>Czech</para>
            /// </description></item>
            /// <item><description><para>Finnish</para>
            /// </description></item>
            /// <item><description><para>Hindi</para>
            /// </description></item>
            /// <item><description><para>auto</para>
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
            /// <para>This parameter applies only to the Minimax provider. Valid values:
            /// <c>speech-01-turbo</c>, <c>speech-02-turbo</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>speech-01-turbo</para>
            /// </summary>
            [NameInMap("ModelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            /// <summary>
            /// <para>A list of TTS pronunciation rules, executed in order. You can specify a maximum of 20 rules.</para>
            /// </summary>
            [NameInMap("PronunciationRules")]
            [Validation(Required=false)]
            public List<AIAgentConfigTtsConfigPronunciationRules> PronunciationRules { get; set; }
            public class AIAgentConfigTtsConfigPronunciationRules : TeaModel {
                /// <summary>
                /// <para>The replacement pronunciation. It must be 1 to 9 Chinese characters long and cannot contain spaces.</para>
                /// 
                /// <b>Example:</b>
                /// <para>幺幺零</para>
                /// </summary>
                [NameInMap("Pronunciation")]
                [Validation(Required=false)]
                public string Pronunciation { get; set; }

                /// <summary>
                /// <para>The type of pronunciation rule.
                /// Valid value:</para>
                /// <list type="bullet">
                /// <item><description><c>replacement</c>: Replaces the specified <c>Word</c> with the <c>Pronunciation</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>replacement</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The word to be replaced. It must be 1 to 9 Chinese characters long and cannot contain spaces.</para>
                /// 
                /// <b>Example:</b>
                /// <para>一一零</para>
                /// </summary>
                [NameInMap("Word")]
                [Validation(Required=false)]
                public string Word { get; set; }

            }

            /// <summary>
            /// <para>The speech rate, where a value of 1.0 is normal speed. The supported range can vary by provider. For CosyVoice, the range is 0.5 to 2.0 (default: 1.0). For Minimax, the range is 0.5 to 2.0 (default: 1.0).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("SpeechRate")]
            [Validation(Required=false)]
            public double? SpeechRate { get; set; }

            /// <summary>
            /// <para>The ID of the preset TTS voice. Changes apply to the next utterance. If omitted, the voice from the AI agent template is used. The ID can be a maximum of 64 characters. For available voices, see <a href="https://help.aliyun.com/document_detail/449563.html">Intelligent Voice Samples</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>longcheng_v2</para>
            /// </summary>
            [NameInMap("VoiceId")]
            [Validation(Required=false)]
            public string VoiceId { get; set; }

            /// <summary>
            /// <para>A list of available voices.</para>
            /// </summary>
            [NameInMap("VoiceIdList")]
            [Validation(Required=false)]
            public List<string> VoiceIdList { get; set; }

        }

        /// <summary>
        /// <para>Configuration for conversational turn detection.</para>
        /// </summary>
        [NameInMap("TurnDetectionConfig")]
        [Validation(Required=false)]
        public AIAgentConfigTurnDetectionConfig TurnDetectionConfig { get; set; }
        public class AIAgentConfigTurnDetectionConfig : TeaModel {
            /// <summary>
            /// <para>Controls the agent\&quot;s response speed after detecting a user pause. This parameter applies only in <c>Semantic</c> mode. A higher setting results in a faster response but increases the risk of interrupting the user:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Low</c>: Waits patiently with a maximum wait time of 6 seconds, reducing the risk of interruption.</para>
            /// </description></item>
            /// <item><description><para><c>Medium</c>: A balanced wait time (up to 4 seconds), suitable for most scenarios.</para>
            /// </description></item>
            /// <item><description><para><c>High</c>: Responds quickly (up to 2 seconds), which improves speed but may increase the risk of incorrect turn-taking.</para>
            /// </description></item>
            /// </list>
            /// <para>This field is empty by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>High</para>
            /// </summary>
            [NameInMap("Eagerness")]
            [Validation(Required=false)]
            public string Eagerness { get; set; }

            /// <summary>
            /// <para>The conversational turn detection mode.</para>
            /// <list type="bullet">
            /// <item><description><para><c>Normal</c> (Default): The agent relies on pauses to detect the end of a user\&quot;s turn.</para>
            /// </description></item>
            /// <item><description><para><c>Semantic</c>: The agent uses AI to analyze conversational context to determine if the user has finished speaking.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Semantic</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The pause detection time in AI mode, in milliseconds. Default: -1.</para>
            /// <list type="bullet">
            /// <item><description><para>-1: The AI automatically determines a suitable wait time.</para>
            /// </description></item>
            /// <item><description><para>0–10000: A custom wait time. A range of 0–1500 ms is recommended.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter has no effect in <c>Normal</c> mode.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("SemanticWaitDuration")]
            [Validation(Required=false)]
            public int? SemanticWaitDuration { get; set; }

            /// <summary>
            /// <para>A list of keywords used to determine the end of a user\&quot;s conversational turn.</para>
            /// </summary>
            [NameInMap("TurnEndWords")]
            [Validation(Required=false)]
            public List<string> TurnEndWords { get; set; }

        }

        /// <summary>
        /// <para>The duration in seconds the AI agent waits before terminating the task after a user leaves the session. Default: 5.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("UserOfflineTimeout")]
        [Validation(Required=false)]
        public int? UserOfflineTimeout { get; set; }

        /// <summary>
        /// <para>The duration in seconds the AI agent waits for a user to join. If the user does not join within this time, the agent terminates the task. Default: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("UserOnlineTimeout")]
        [Validation(Required=false)]
        public int? UserOnlineTimeout { get; set; }

        /// <summary>
        /// <para>Configuration for video content recognition. This enables the system to send callbacks to the client about events detected in the video stream.</para>
        /// </summary>
        [NameInMap("VcrConfig")]
        [Validation(Required=false)]
        public AIAgentConfigVcrConfig VcrConfig { get; set; }
        public class AIAgentConfigVcrConfig : TeaModel {
            /// <summary>
            /// <para>Configuration for device identification.</para>
            /// </summary>
            [NameInMap("Equipment")]
            [Validation(Required=false)]
            public AIAgentConfigVcrConfigEquipment Equipment { get; set; }
            public class AIAgentConfigVcrConfigEquipment : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable device identification. Default: <c>false</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            /// <summary>
            /// <para>Configuration for head motion detection.</para>
            /// </summary>
            [NameInMap("HeadMotion")]
            [Validation(Required=false)]
            public AIAgentConfigVcrConfigHeadMotion HeadMotion { get; set; }
            public class AIAgentConfigVcrConfigHeadMotion : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable head motion detection. Default: <c>false</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            /// <summary>
            /// <para>Configuration for invalid frame detection.</para>
            /// </summary>
            [NameInMap("InvalidFrameMotion")]
            [Validation(Required=false)]
            public AIAgentConfigVcrConfigInvalidFrameMotion InvalidFrameMotion { get; set; }
            public class AIAgentConfigVcrConfigInvalidFrameMotion : TeaModel {
                /// <summary>
                /// <para>The duration in milliseconds that an invalid frame must persist before a notification is sent. If not specified, the setting from the console is used. Range: 200–5000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("CallbackDelay")]
                [Validation(Required=false)]
                public int? CallbackDelay { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable invalid frame detection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            /// <summary>
            /// <para>Configuration for look-away detection.</para>
            /// </summary>
            [NameInMap("LookAway")]
            [Validation(Required=false)]
            public AIAgentConfigVcrConfigLookAway LookAway { get; set; }
            public class AIAgentConfigVcrConfigLookAway : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable look-away detection. Default: <c>false</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            /// <summary>
            /// <para>Configuration for the people counting feature.</para>
            /// </summary>
            [NameInMap("PeopleCount")]
            [Validation(Required=false)]
            public AIAgentConfigVcrConfigPeopleCount PeopleCount { get; set; }
            public class AIAgentConfigVcrConfigPeopleCount : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable people counting. Default: <c>false</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            /// <summary>
            /// <para>Configuration for still frame detection.</para>
            /// </summary>
            [NameInMap("StillFrameMotion")]
            [Validation(Required=false)]
            public AIAgentConfigVcrConfigStillFrameMotion StillFrameMotion { get; set; }
            public class AIAgentConfigVcrConfigStillFrameMotion : TeaModel {
                /// <summary>
                /// <para>The duration in milliseconds that a frame must remain still before a notification is sent. If not specified, the setting from the console is used. Range: 200–5000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("CallbackDelay")]
                [Validation(Required=false)]
                public int? CallbackDelay { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable still frame detection. Default: <c>false</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

        }

        /// <summary>
        /// <para>Configuration for voiceprint recognition.</para>
        /// </summary>
        [NameInMap("VoiceprintConfig")]
        [Validation(Required=false)]
        public AIAgentConfigVoiceprintConfig VoiceprintConfig { get; set; }
        public class AIAgentConfigVoiceprintConfig : TeaModel {
            /// <summary>
            /// <para>The voiceprint registration mode. Default: <c>Explicit</c>.</para>
            /// <table>
            /// <thead>
            /// <tr>
            /// <th>Value</th>
            /// <th>Description</th>
            /// </tr>
            /// </thead>
            /// <tbody><tr>
            /// <td><c>Explicit</c></td>
            /// <td>In <c>Explicit</c> mode, the user must register their voiceprint in advance by using the voiceprint registration API.</td>
            /// </tr>
            /// <tr>
            /// <td><c>Implicit</c></td>
            /// <td>In <c>Implicit</c> mode, the system automatically collects user speech during the conversation to register a voiceprint.</td>
            /// </tr>
            /// </tbody></table>
            /// 
            /// <b>Example:</b>
            /// <para>Explicit</para>
            /// </summary>
            [NameInMap("RegistrationMode")]
            [Validation(Required=false)]
            public string RegistrationMode { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable voiceprint recognition. Default: <c>false</c>. If set to <c>true</c>, you must also provide a valid <c>VoiceprintId</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("UseVoiceprint")]
            [Validation(Required=false)]
            public bool? UseVoiceprint { get; set; }

            /// <summary>
            /// <para>The unique identifier for the voiceprint. This is not set by default. The ID must correspond to a voiceprint registered using the voiceprint registration API. For more information, see <a href="https://help.aliyun.com/document_detail/2964738.html">Register a voiceprint</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhixiaoxia</para>
            /// </summary>
            [NameInMap("VoiceprintId")]
            [Validation(Required=false)]
            public string VoiceprintId { get; set; }

        }

        /// <summary>
        /// <para>The speaking volume of the AI agent.</para>
        /// <list type="bullet">
        /// <item><description><para>If not set, the adaptive volume mode recommended by Alibaba Cloud is used by default.</para>
        /// </description></item>
        /// <item><description><para>If set, the value must be in the range of 0 to 400. The final output volume is calculated as: <c>(Workflow volume) * (volume / 100)</c>. For example:</para>
        /// </description></item>
        /// </list>
        /// <ol>
        /// <item><description><para>If <c>volume</c> is 0, the output volume is 0.</para>
        /// </description></item>
        /// <item><description><para>If <c>volume</c> is 100, the output volume is the same as the original volume.</para>
        /// </description></item>
        /// <item><description><para>If <c>volume</c> is 200, the output volume is twice the original volume.</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public long? Volume { get; set; }

        /// <summary>
        /// <para>A user-provided command that the AI agent responds to immediately after the call starts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>今天天气怎么样？</para>
        /// </summary>
        [NameInMap("WakeUpQuery")]
        [Validation(Required=false)]
        public string WakeUpQuery { get; set; }

        /// <summary>
        /// <para>A JSON string containing parameters to override the default workflow configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("WorkflowOverrideParams")]
        [Validation(Required=false)]
        public string WorkflowOverrideParams { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AIAgentOutboundCallConfig : TeaModel {
        /// <summary>
        /// <para>Configuration for the ambient sound played during the call.</para>
        /// </summary>
        [NameInMap("AmbientSoundConfig")]
        [Validation(Required=false)]
        public AIAgentOutboundCallConfigAmbientSoundConfig AmbientSoundConfig { get; set; }
        public class AIAgentOutboundCallConfigAmbientSoundConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the ambient sound. This ID can be obtained from the advanced settings section of the agent configuration in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f67901c595834************</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The volume of the ambient sound. Valid values: [0, 100]. A value of 0 disables the ambient sound.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Volume")]
            [Validation(Required=false)]
            public int? Volume { get; set; }

        }

        /// <summary>
        /// <para>The configuration for Automatic Speech Recognition (ASR).</para>
        /// </summary>
        [NameInMap("AsrConfig")]
        [Validation(Required=false)]
        public AIAgentOutboundCallConfigAsrConfig AsrConfig { get; set; }
        public class AIAgentOutboundCallConfigAsrConfig : TeaModel {
            /// <summary>
            /// <para>Hotwords for ASR to improve recognition accuracy. Maximum of 128 hotwords.</para>
            /// </summary>
            [NameInMap("AsrHotWords")]
            [Validation(Required=false)]
            public List<string> AsrHotWords { get; set; }

            /// <summary>
            /// <para>The language ID for ASR. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>zh_mandarin: Chinese</description></item>
            /// <item><description>en: English</description></item>
            /// <item><description>zh_en: Chinese and English</description></item>
            /// <item><description>es: Spanish</description></item>
            /// <item><description>jp: Japanese</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh_mandarin</para>
            /// </summary>
            [NameInMap("AsrLanguageId")]
            [Validation(Required=false)]
            public string AsrLanguageId { get; set; }

            /// <summary>
            /// <para>The silence threshold for sentence segmentation. A pause longer than this value is considered a sentence break. Unit: milliseconds. Default value: 400. Valid values: 200 to 1200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("AsrMaxSilence")]
            [Validation(Required=false)]
            public int? AsrMaxSilence { get; set; }

            /// <summary>
            /// <para>Passthrough parameters for ASR.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mode=fast&amp;sample=16000&amp;format=wav</para>
            /// </summary>
            [NameInMap("CustomParams")]
            [Validation(Required=false)]
            public string CustomParams { get; set; }

            /// <summary>
            /// <para>The minimum duration for voice activity detection, in milliseconds. This parameter controls the sensitivity of interruptions, preventing the agent from cutting off user speech too early during short pauses. 0: Disables this feature. Valid values: 200 to 2000. Recommended: 200 to 500 ms, which typically corresponds to the length of 1 to 4 words. By default, this parameter is left empty, which indicates the feature is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("VadDuration")]
            [Validation(Required=false)]
            public int? VadDuration { get; set; }

            /// <summary>
            /// <para>The VAD threshold for interruption. A higher value makes it harder to trigger interruptions. Valid values: 0 to 10. Default value: 1. The value of 0 specifies to disable the VAD feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VadLevel")]
            [Validation(Required=false)]
            public int? VadLevel { get; set; }

        }

        [NameInMap("AutoSpeechConfig")]
        [Validation(Required=false)]
        public AIAgentOutboundCallConfigAutoSpeechConfig AutoSpeechConfig { get; set; }
        public class AIAgentOutboundCallConfigAutoSpeechConfig : TeaModel {
            [NameInMap("LlmPending")]
            [Validation(Required=false)]
            public AIAgentOutboundCallConfigAutoSpeechConfigLlmPending LlmPending { get; set; }
            public class AIAgentOutboundCallConfigAutoSpeechConfigLlmPending : TeaModel {
                [NameInMap("Messages")]
                [Validation(Required=false)]
                public List<AIAgentOutboundCallConfigAutoSpeechConfigLlmPendingMessages> Messages { get; set; }
                public class AIAgentOutboundCallConfigAutoSpeechConfigLlmPendingMessages : TeaModel {
                    [NameInMap("Probability")]
                    [Validation(Required=false)]
                    public double? Probability { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                [NameInMap("WaitTime")]
                [Validation(Required=false)]
                public int? WaitTime { get; set; }

            }

            [NameInMap("UserIdle")]
            [Validation(Required=false)]
            public AIAgentOutboundCallConfigAutoSpeechConfigUserIdle UserIdle { get; set; }
            public class AIAgentOutboundCallConfigAutoSpeechConfigUserIdle : TeaModel {
                [NameInMap("MaxRepeats")]
                [Validation(Required=false)]
                public int? MaxRepeats { get; set; }

                [NameInMap("Messages")]
                [Validation(Required=false)]
                public List<AIAgentOutboundCallConfigAutoSpeechConfigUserIdleMessages> Messages { get; set; }
                public class AIAgentOutboundCallConfigAutoSpeechConfigUserIdleMessages : TeaModel {
                    [NameInMap("Probability")]
                    [Validation(Required=false)]
                    public double? Probability { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                [NameInMap("WaitTime")]
                [Validation(Required=false)]
                public int? WaitTime { get; set; }

            }

        }

        /// <term><b>Obsolete</b></term>
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

        [NameInMap("BackChannelingConfigs")]
        [Validation(Required=false)]
        public List<AIAgentOutboundCallConfigBackChannelingConfigs> BackChannelingConfigs { get; set; }
        public class AIAgentOutboundCallConfigBackChannelingConfigs : TeaModel {
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
            public List<AIAgentOutboundCallConfigBackChannelingConfigsWords> Words { get; set; }
            public class AIAgentOutboundCallConfigBackChannelingConfigsWords : TeaModel {
                [NameInMap("Probability")]
                [Validation(Required=false)]
                public double? Probability { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

        }

        /// <summary>
        /// <para>If enabled, the system intelligently merges short, interim segments into a single sentence. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableIntelligentSegment")]
        [Validation(Required=false)]
        public bool? EnableIntelligentSegment { get; set; }

        [NameInMap("ExperimentalConfig")]
        [Validation(Required=false)]
        public string ExperimentalConfig { get; set; }

        /// <summary>
        /// <para>The welcome message that the agent says upon joining. Changes take effect in the next session. Default value: None.</para>
        /// </summary>
        [NameInMap("Greeting")]
        [Validation(Required=false)]
        public string Greeting { get; set; }

        /// <summary>
        /// <para>The delay before playing the welcome message. Unit: milliseconds. Valid values: 0 to 5000. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("GreetingDelay")]
        [Validation(Required=false)]
        public int? GreetingDelay { get; set; }

        /// <summary>
        /// <para>The configuration for the speech interruption strategy.</para>
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
            /// <para>Specifies whether to allow the user to interrupt the agent by speaking. Default value: true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableVoiceInterrupt")]
            [Validation(Required=false)]
            public bool? EnableVoiceInterrupt { get; set; }

            /// <summary>
            /// <para>Words or phrases that will trigger an interruption.</para>
            /// </summary>
            [NameInMap("InterruptWords")]
            [Validation(Required=false)]
            public List<string> InterruptWords { get; set; }

            [NameInMap("KeepInterruptWordsForLLM")]
            [Validation(Required=false)]
            public bool? KeepInterruptWordsForLLM { get; set; }

            [NameInMap("NoInterruptMode")]
            [Validation(Required=false)]
            public string NoInterruptMode { get; set; }

        }

        /// <summary>
        /// <para>The configuration for the large language model (LLM).</para>
        /// </summary>
        [NameInMap("LlmConfig")]
        [Validation(Required=false)]
        public AIAgentOutboundCallConfigLlmConfig LlmConfig { get; set; }
        public class AIAgentOutboundCallConfigLlmConfig : TeaModel {
            /// <summary>
            /// <para>Alibaba Cloud Model Studio Application Center parameters. Reference: <a href="https://help.aliyun.com/document_detail/2858132.html">Model Studio Application Center Parameter</a></para>
            /// </summary>
            [NameInMap("BailianAppParams")]
            [Validation(Required=false)]
            public string BailianAppParams { get; set; }

            /// <summary>
            /// <para>Maps agent capabilities to LLM functions. Only supports function calling with custom LLMs that adhere to the OpenAI protocol.</para>
            /// </summary>
            [NameInMap("FunctionMap")]
            [Validation(Required=false)]
            public List<AIAgentOutboundCallConfigLlmConfigFunctionMap> FunctionMap { get; set; }
            public class AIAgentOutboundCallConfigLlmConfigFunctionMap : TeaModel {
                /// <summary>
                /// <para>The name of the built-in agent capability. Only hangup is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hangup</para>
                /// </summary>
                [NameInMap("Function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                /// <summary>
                /// <para>The corresponding user-defined function name in your LLM. When the LLM calls this function, it will trigger the mapped agent capability.<a href="~~2839094~~"></a></para>
                /// 
                /// <b>Example:</b>
                /// <para>hangup</para>
                /// </summary>
                [NameInMap("MatchFunction")]
                [Validation(Required=false)]
                public string MatchFunction { get; set; }

            }

            [NameInMap("HistorySyncWithTTS")]
            [Validation(Required=false)]
            public bool? HistorySyncWithTTS { get; set; }

            /// <summary>
            /// <para>If true, the service sends the complete result from the LLM to the client in a single response after the generation process is finished.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("LlmCompleteReply")]
            [Validation(Required=false)]
            public bool? LlmCompleteReply { get; set; }

            /// <summary>
            /// <para>The LLM/MLLM conversation history context.</para>
            /// </summary>
            [NameInMap("LlmHistory")]
            [Validation(Required=false)]
            public List<AIAgentOutboundCallConfigLlmConfigLlmHistory> LlmHistory { get; set; }
            public class AIAgentOutboundCallConfigLlmConfigLlmHistory : TeaModel {
                /// <summary>
                /// <para>The actual text content of the message for that role.</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The role of the participant in the conversation. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>user</description></item>
                /// <item><description>assistant</description></item>
                /// <item><description>system</description></item>
                /// <item><description>function</description></item>
                /// <item><description>plugin</description></item>
                /// <item><description>tool</description></item>
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
            /// <para>The maximum number of conversational turns to retain in the history. Default value: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("LlmHistoryLimit")]
            [Validation(Required=false)]
            public int? LlmHistoryLimit { get; set; }

            /// <summary>
            /// <para>The system prompt for the LLM.</para>
            /// </summary>
            [NameInMap("LlmSystemPrompt")]
            [Validation(Required=false)]
            public string LlmSystemPrompt { get; set; }

            /// <summary>
            /// <para>Additional query parameters to be sent to the OpenAI-protocol LLM, formatted as a URL query string (key=value pairs separated by &amp;). All values must be strings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api-version=2024-02-01&amp;api-key=sk-xxx</para>
            /// </summary>
            [NameInMap("OpenAIExtraQuery")]
            [Validation(Required=false)]
            public string OpenAIExtraQuery { get; set; }

            /// <summary>
            /// <para>The maximum time (in milliseconds) to buffer text before it is forcibly sent to the client. Valid values: [1000,10000]. A value of 0 or an empty string (default) disables this limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("OutputMaxDelay")]
            [Validation(Required=false)]
            public string OutputMaxDelay { get; set; }

            /// <summary>
            /// <para>The minimum number of characters that must be buffered before a text chunk is sent. Valid values: [0, 100]. A value of 0 or an empty string (default) disables this limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("OutputMinLength")]
            [Validation(Required=false)]
            public int? OutputMinLength { get; set; }

        }

        [NameInMap("MaxIdleTime")]
        [Validation(Required=false)]
        public int? MaxIdleTime { get; set; }

        /// <summary>
        /// <para>The configuration for Text-to-Speech (TTS).</para>
        /// </summary>
        [NameInMap("TtsConfig")]
        [Validation(Required=false)]
        public AIAgentOutboundCallConfigTtsConfig TtsConfig { get; set; }
        public class AIAgentOutboundCallConfigTtsConfig : TeaModel {
            /// <summary>
            /// <para>Applies only to MiniMax models. Seven types of emotions are supported:</para>
            /// <list type="bullet">
            /// <item><description>happy</description></item>
            /// <item><description>sad</description></item>
            /// <item><description>angry</description></item>
            /// <item><description>fearful</description></item>
            /// <item><description>disgusted</description></item>
            /// <item><description>surprised</description></item>
            /// <item><description>calm</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>happy</para>
            /// </summary>
            [NameInMap("Emotion")]
            [Validation(Required=false)]
            public string Emotion { get; set; }

            /// <summary>
            /// <para>Applies only to MiniMax models. By default, this parameter is left empty. This enhances speech recognition accuracy for specific languages and dialects. If the language type is unknown, set it to auto to have the model automatically detect it. Valid values:</para>
            /// <para><b>Supported languages</b></para>
            /// <list type="bullet">
            /// <item><description>Chinese</description></item>
            /// <item><description>Chinese,Yue</description></item>
            /// <item><description>English</description></item>
            /// <item><description>Arabic</description></item>
            /// <item><description>Russian</description></item>
            /// <item><description>Spanish</description></item>
            /// <item><description>French</description></item>
            /// <item><description>Portuguese</description></item>
            /// <item><description>German</description></item>
            /// <item><description>Turkish</description></item>
            /// <item><description>Dutch</description></item>
            /// <item><description>Ukrainian</description></item>
            /// <item><description>Vietnamese</description></item>
            /// <item><description>Indonesian</description></item>
            /// <item><description>Japanese</description></item>
            /// <item><description>Italian</description></item>
            /// <item><description>Korean</description></item>
            /// <item><description>Thai</description></item>
            /// <item><description>Polish</description></item>
            /// <item><description>Romanian</description></item>
            /// <item><description>Greek</description></item>
            /// <item><description>Czech</description></item>
            /// <item><description>Finnish</description></item>
            /// <item><description>Hindi</description></item>
            /// <item><description>auto</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Chinese</para>
            /// </summary>
            [NameInMap("LanguageId")]
            [Validation(Required=false)]
            public string LanguageId { get; set; }

            /// <summary>
            /// <para>Applies only to MiniMax models. Valid values: speech-01-turbo and speech-02-turbo.</para>
            /// 
            /// <b>Example:</b>
            /// <para>speech-01-turbo</para>
            /// </summary>
            [NameInMap("ModelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            /// <summary>
            /// <para>The pronunciation rules, executed in order. Maximum of 20 rules.</para>
            /// </summary>
            [NameInMap("PronunciationRules")]
            [Validation(Required=false)]
            public List<AIAgentOutboundCallConfigTtsConfigPronunciationRules> PronunciationRules { get; set; }
            public class AIAgentOutboundCallConfigTtsConfigPronunciationRules : TeaModel {
                /// <summary>
                /// <para>The target pronunciation. The value supports up to 10 Chinese characters. Other characters, including spaces, are not supported.</para>
                /// </summary>
                [NameInMap("Pronunciation")]
                [Validation(Required=false)]
                public string Pronunciation { get; set; }

                /// <summary>
                /// <para>The type of rule. Valid value:</para>
                /// <list type="bullet">
                /// <item><description>replacement: replaces every occurrence of Word value with Pronunciation value.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>replacement</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The word to be replaced. The value supports up to 10 Chinese characters. Other characters, including spaces, are not supported.</para>
                /// </summary>
                [NameInMap("Word")]
                [Validation(Required=false)]
                public string Word { get; set; }

            }

            /// <summary>
            /// <para>Supports all models. For CosyVoice, the default value is 1.0. Valid values: 0.5 to 2.0. For MiniMax, the default value is 1.0. Valid values: 0.5 to 2.0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("SpeechRate")]
            [Validation(Required=false)]
            public double? SpeechRate { get; set; }

            /// <summary>
            /// <para>The voice ID. Changes take effect on the next sentence. If not set, the system uses the default voice ID specified in the agent template. This parameter takes effect only for the preset TTS model. Max length: 64 characters. Refer to <a href="https://help.aliyun.com/document_detail/449563.html">Intelligent voice samples</a> for options.</para>
            /// 
            /// <b>Example:</b>
            /// <para>longcheng_v2</para>
            /// </summary>
            [NameInMap("VoiceId")]
            [Validation(Required=false)]
            public string VoiceId { get; set; }

            /// <summary>
            /// <para>Available voices.</para>
            /// </summary>
            [NameInMap("VoiceIdList")]
            [Validation(Required=false)]
            public List<string> VoiceIdList { get; set; }

        }

        /// <summary>
        /// <para>The configuration for detecting the end of a user\&quot;s conversational turn.</para>
        /// </summary>
        [NameInMap("TurnDetectionConfig")]
        [Validation(Required=false)]
        public AIAgentOutboundCallConfigTurnDetectionConfig TurnDetectionConfig { get; set; }
        public class AIAgentOutboundCallConfigTurnDetectionConfig : TeaModel {
            [NameInMap("Eagerness")]
            [Validation(Required=false)]
            public string Eagerness { get; set; }

            /// <summary>
            /// <para>The mode of turn detection.</para>
            /// <list type="bullet">
            /// <item><description>Normal: uses simple pause detection.</description></item>
            /// <item><description>Semantic: uses AI to analyze context.</description></item>
            /// </list>
            /// <para>Default value: Normal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Semantic</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>Specifies how long to wait after a user stops speaking for the agent to decide if the turn is over. Unit: milliseconds. Default value: -1.</para>
            /// <list type="bullet">
            /// <item><description>\-1: AI decides an appropriate wait time automatically.</description></item>
            /// <item><description>0 to 10000: A custom wait time. Recommended: 0 to 1500 ms.</description></item>
            /// </list>
            /// <para>Note: In Normal mode, this field is ignored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("SemanticWaitDuration")]
            [Validation(Required=false)]
            public int? SemanticWaitDuration { get; set; }

            /// <summary>
            /// <para>Keywords that signify the end of the user\&quot;s turn.</para>
            /// </summary>
            [NameInMap("TurnEndWords")]
            [Validation(Required=false)]
            public List<string> TurnEndWords { get; set; }

        }

    }

}

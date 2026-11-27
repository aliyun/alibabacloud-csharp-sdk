// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class StartAgentRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can create and query the ID in the console. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aoe****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the channel to join. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourChannelId</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The configuration for the agent to join a Real-Time Communication (RTC) channel.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RtcConfig")]
        [Validation(Required=false)]
        public StartAgentRequestRtcConfig RtcConfig { get; set; }
        public class StartAgentRequestRtcConfig : TeaModel {
            /// <summary>
            /// <para>The list of user IDs subscribed by the agent. Currently, only one user ID is supported.</para>
            /// </summary>
            [NameInMap("TargetUserIds")]
            [Validation(Required=false)]
            public List<string> TargetUserIds { get; set; }

            /// <summary>
            /// <para>The user ID of the agent in the RTC channel.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>423341</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The maximum duration threshold for user inactivity, in seconds.
            /// When the duration of any of the following states reaches this threshold, the agent automatically stops and exits the channel:</para>
            /// <ol>
            /// <item><description>All users in the targetUserIds list have left the channel.</description></item>
            /// <item><description>The users in the targetUserIds list have not joined the channel.</description></item>
            /// </ol>
            /// <para>Default value: 30.
            /// Valid values: 5 to 180.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("UserInactivityTimeout")]
            [Validation(Required=false)]
            public int? UserInactivityTimeout { get; set; }

        }

        /// <summary>
        /// <para>The task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourTaskId</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76dasgb****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The configuration for AI voice chat.</para>
        /// </summary>
        [NameInMap("VoiceChatConfig")]
        [Validation(Required=false)]
        public StartAgentRequestVoiceChatConfig VoiceChatConfig { get; set; }
        public class StartAgentRequestVoiceChatConfig : TeaModel {
            /// <summary>
            /// <para>The Automatic Speech Recognition (ASR) configuration.</para>
            /// </summary>
            [NameInMap("ASRConfig")]
            [Validation(Required=false)]
            public StartAgentRequestVoiceChatConfigASRConfig ASRConfig { get; set; }
            public class StartAgentRequestVoiceChatConfigASRConfig : TeaModel {
                /// <summary>
                /// <para>If this parameter is not specified, the model automatically identifies the language.
                /// Currently supported language codes:</para>
                /// <list type="bullet">
                /// <item><description>zh: Chinese, including Mandarin and dialects such as Shanghainese, Wu, Minnan, Northeastern, Gansu, Guizhou, Henan, Hubei, Hunan, Jiangxi, Ningxia, Shanxi, Shaanxi, Shandong, Sichuan, Tianjin, Yunnan, and Cantonese.</description></item>
                /// <item><description>en: English.</description></item>
                /// <item><description>ja: Japanese.</description></item>
                /// <item><description>yue: Cantonese.</description></item>
                /// <item><description>ko: Korean.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("LanguageHints")]
                [Validation(Required=false)]
                public List<string> LanguageHints { get; set; }

                /// <summary>
                /// <para>The voice segmentation detection threshold. Default value: 800. Unit: milliseconds. Recommended range: 200 to 6000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>800</para>
                /// </summary>
                [NameInMap("MaxSentenceSilence")]
                [Validation(Required=false)]
                public int? MaxSentenceSilence { get; set; }

                /// <summary>
                /// <para>Specifies whether semantic or voice segmentation is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SemanticPunctuationEnabled")]
                [Validation(Required=false)]
                public bool? SemanticPunctuationEnabled { get; set; }

                /// <summary>
                /// <para>No configuration is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zh</para>
                /// </summary>
                [NameInMap("SourceLanguage")]
                [Validation(Required=false)]
                public string SourceLanguage { get; set; }

                /// <summary>
                /// <para>The Voice Activity Detection (VAD) configuration.</para>
                /// </summary>
                [NameInMap("VadConfig")]
                [Validation(Required=false)]
                public StartAgentRequestVoiceChatConfigASRConfigVadConfig VadConfig { get; set; }
                public class StartAgentRequestVoiceChatConfigASRConfigVadConfig : TeaModel {
                    /// <summary>
                    /// <para>The minimum duration of continuous human voice signals required to avoid false interruptions, in milliseconds.
                    /// Valid values: 0 to 3000.
                    /// Default value: 300.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("InterruptSpeechDuration")]
                    [Validation(Required=false)]
                    public int? InterruptSpeechDuration { get; set; }

                }

                /// <summary>
                /// <para>The ID of the supported hot word.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vocab-xxx-24ee19fa8cfb4d52902170a0xxxxxxxx</para>
                /// </summary>
                [NameInMap("VocabularyId")]
                [Validation(Required=false)]
                public string VocabularyId { get; set; }

            }

            /// <summary>
            /// <para>The configuration for agent behavior during silence timeout. When a user joins the channel but does not interact effectively with the agent (the user does not speak), the agent is in a silent state. You can configure the agent to broadcast a voice messaging reminder or send a webhook notification during this silent state.</para>
            /// </summary>
            [NameInMap("AgentSilenceConfig")]
            [Validation(Required=false)]
            public StartAgentRequestVoiceChatConfigAgentSilenceConfig AgentSilenceConfig { get; set; }
            public class StartAgentRequestVoiceChatConfigAgentSilenceConfig : TeaModel {
                /// <summary>
                /// <para>The timeout period for silence reminders, in seconds.
                /// This reminder can be triggered multiple times. If the agent remains silent after a silence reminder timeout, the reminder is triggered again upon the next timeout.
                /// Valid values: 5 to 600.
                /// Default value: 0. A value of 0 indicates that no reminder is sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AlertTimeout")]
                [Validation(Required=false)]
                public int? AlertTimeout { get; set; }

                /// <summary>
                /// <para>The content of the silence prompt message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>**</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The switch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The script strategy for silence reminders. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Broadcast the prompt message specified by Content to the user by voice.</description></item>
                /// <item><description>2: Send the prompt message specified by Content and the conversation history to the LLM, and broadcast the generated reply by voice.
                /// Default value: 1.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public int? Strategy { get; set; }

                /// <summary>
                /// <para>The silence timeout period for triggering the agent silence timeout webhook, in seconds.
                /// This webhook can be triggered multiple times. If the agent remains silent after a webhook silence timeout, the webhook is triggered again upon the next timeout.
                /// Valid values: 10 to 600.
                /// Default value: 0. A value of 0 indicates that the webhook is not triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WebhookTriggerTimeout")]
                [Validation(Required=false)]
                public int? WebhookTriggerTimeout { get; set; }

            }

            /// <summary>
            /// <para>The ambient sound settings.</para>
            /// </summary>
            [NameInMap("AmbientSoundConfig")]
            [Validation(Required=false)]
            public StartAgentRequestVoiceChatConfigAmbientSoundConfig AmbientSoundConfig { get; set; }
            public class StartAgentRequestVoiceChatConfigAmbientSoundConfig : TeaModel {
                /// <summary>
                /// <para>The ambient sound ID. Built-in and download modes are planned. Currently, only the built-in mode is supported.</para>
                /// <list type="bullet">
                /// <item><description>If this parameter is not specified or is left empty, ambient sound is disabled.</description></item>
                /// <item><description>Built-in mode: The agent provides the following default ambient sounds: white_noise (white noise) and office (office environment).</description></item>
                /// <item><description>Download mode: You can specify a custom soundId in the console (which must be different from built-in IDs) and provide a URL. The agent will download and bind the sound internally.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>white_noise</para>
                /// </summary>
                [NameInMap("SoundId")]
                [Validation(Required=false)]
                public string SoundId { get; set; }

                /// <summary>
                /// <para>The volume of the ambient sound.
                /// Default value: 50 (original volume).
                /// Valid values: 0 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Volume")]
                [Validation(Required=false)]
                public int? Volume { get; set; }

            }

            /// <summary>
            /// <para>The backchannel settings.</para>
            /// </summary>
            [NameInMap("BackChannelConfig")]
            [Validation(Required=false)]
            public StartAgentRequestVoiceChatConfigBackChannelConfig BackChannelConfig { get; set; }
            public class StartAgentRequestVoiceChatConfigBackChannelConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable backchannel responses after the user finishes speaking. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("UserTurnEnd")]
                [Validation(Required=false)]
                public bool? UserTurnEnd { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <para>The chat mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: natural conversation mode. This is the default value.</description></item>
            /// <item><description>2: walkie-talkie mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ChatMode")]
            [Validation(Required=false)]
            public int? ChatMode { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable visual understanding. If enabled, the large language model (LLM) must support multimodal data.</para>
            /// </summary>
            [NameInMap("EnableVideoUnderstanding")]
            [Validation(Required=false)]
            public bool? EnableVideoUnderstanding { get; set; }

            /// <summary>
            /// <para>The greeting message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Good morning, my friend</para>
            /// </summary>
            [NameInMap("Greeting")]
            [Validation(Required=false)]
            public string Greeting { get; set; }

            /// <summary>
            /// <para>The interrupt settings.</para>
            /// </summary>
            [NameInMap("InterruptConfig")]
            [Validation(Required=false)]
            public StartAgentRequestVoiceChatConfigInterruptConfig InterruptConfig { get; set; }
            public class StartAgentRequestVoiceChatConfigInterruptConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable semantic interruption. Default value: true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SemanticsInterrupt")]
                [Validation(Required=false)]
                public bool? SemanticsInterrupt { get; set; }

            }

            /// <summary>
            /// <para>The interrupt mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: voice interruption supported. This is the default value.</description></item>
            /// <item><description>2: voice interruption disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InterruptMode")]
            [Validation(Required=false)]
            public int? InterruptMode { get; set; }

            /// <summary>
            /// <para>The large language model (LLM) configuration.</para>
            /// </summary>
            [NameInMap("LLMConfig")]
            [Validation(Required=false)]
            public StartAgentRequestVoiceChatConfigLLMConfig LLMConfig { get; set; }
            public class StartAgentRequestVoiceChatConfigLLMConfig : TeaModel {
                /// <summary>
                /// <para>The API key of the service provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                /// <summary>
                /// <para>The agent application ID. You must specify either Model or AppId. If both are specified, AppId takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The custom parameters.</para>
                /// </summary>
                [NameInMap("BizParams")]
                [Validation(Required=false)]
                public object BizParams { get; set; }

                /// <summary>
                /// <para>The number of historical conversation turns provided to the LLM.
                /// Default value: 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("HistoryDepth")]
                [Validation(Required=false)]
                public int? HistoryDepth { get; set; }

                /// <summary>
                /// <para>The maximum number of tokens for the output text.
                /// Default value: 8192.
                /// The maximum value for DeepSeek and Qwen models is 8192.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("MaxToken")]
                [Validation(Required=false)]
                public int? MaxToken { get; set; }

                /// <summary>
                /// <para>The model name.
                /// Supported models under the aliyun provider:
                /// [&quot;qwen-plus&quot;, &quot;deepseek-r1&quot;, &quot;qwen-omni-turbo&quot;]</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-plus</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>The custom user parameters in key-value pairs. This parameter is deprecated. Use the BizParams parameter instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;verification_code&quot;: &quot;xxx&quot;}</para>
                /// </summary>
                [NameInMap("Params")]
                [Validation(Required=false)]
                public Dictionary<string, object> Params { get; set; }

                /// <summary>
                /// <para>The prompt used to instruct the model on the role or behavior to adopt.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("Prompt")]
                [Validation(Required=false)]
                public string Prompt { get; set; }

                /// <summary>
                /// <para>The sampling temperature used to control the randomness and creativity of the generated text. A higher value indicates higher randomness.
                /// Default value: 0.7.
                /// Valid values: 0 to 2, excluding 2.
                /// Note: This parameter does not take effect for deepseek-r1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7</para>
                /// </summary>
                [NameInMap("Temperature")]
                [Validation(Required=false)]
                public double? Temperature { get; set; }

                [NameInMap("ToolExecutionConfig")]
                [Validation(Required=false)]
                public object ToolExecutionConfig { get; set; }

                [NameInMap("Tools")]
                [Validation(Required=false)]
                public List<object> Tools { get; set; }

                /// <summary>
                /// <para>The sampling range used to control the diversity of output tokens. The model samples from tokens whose cumulative probability exceeds this value to ensure the sampling range is not too broad. A higher value indicates a richer variety of output tokens.
                /// Valid values: 0 to 1, excluding 0.
                /// Default value: 0.8.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("TopP")]
                [Validation(Required=false)]
                public double? TopP { get; set; }

                /// <summary>
                /// <para>The endpoint URL for integrating a third-party LLM.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxxxx">https://xxxxx</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>The name of the service provider when a cloud service provider is integrated. Examples: aliyun for Model Studio, thirdparty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun</para>
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public string Vendor { get; set; }

            }

            /// <summary>
            /// <para>The text-to-speech (TTS) configuration.</para>
            /// </summary>
            [NameInMap("TTSConfig")]
            [Validation(Required=false)]
            public StartAgentRequestVoiceChatConfigTTSConfig TTSConfig { get; set; }
            public class StartAgentRequestVoiceChatConfigTTSConfig : TeaModel {
                /// <summary>
                /// <para>The API key of the service provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxxx</para>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                /// <summary>
                /// <para>The configuration to filter out characters within specified brackets from text-to-speech conversion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[1,2]</para>
                /// </summary>
                [NameInMap("FilterBrackets")]
                [Validation(Required=false)]
                public List<int?> FilterBrackets { get; set; }

                /// <summary>
                /// <para>The model name. Example: cosyvoice-v1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cosyvoice-v1</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>The pitch.
                /// Valid values: 0.5 to 2.0.
                /// Default value: 1.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Pitch")]
                [Validation(Required=false)]
                public double? Pitch { get; set; }

                /// <summary>
                /// <para>The speech rate.
                /// Valid values: 0.5 to 2.0.
                /// Default value: 1.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Rate")]
                [Validation(Required=false)]
                public double? Rate { get; set; }

                /// <summary>
                /// <para>The service provider. Example: aliyun for Model Studio.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun</para>
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public string Vendor { get; set; }

                /// <summary>
                /// <para>The voice. If you select the Alibaba Cloud cosyvoice-v1 model, the default voice is longxiaoxia.
                /// Available voices:
                /// longwan, longcheng, longhua, longxiaochun, longxiaoxia, longxiaocheng, longxiaobai, longlaotie, longshu, longshuo, longjing, longmiao, longyue, longyuan, longfei, longjielidou, longtong, longxiang, loongstella, and loongbella.</para>
                /// 
                /// <b>Example:</b>
                /// <para>longxiaoxia</para>
                /// </summary>
                [NameInMap("Voice")]
                [Validation(Required=false)]
                public string Voice { get; set; }

                /// <summary>
                /// <para>The volume.
                /// Valid values: 0 to 100.
                /// Default value: 50.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Volume")]
                [Validation(Required=false)]
                public int? Volume { get; set; }

            }

            /// <summary>
            /// <para>After visual understanding is enabled, you can specify the video stream that the agent prioritizes for understanding. The agent can understand only one video stream when both the camera stream and the screen sharing stream are pushed simultaneously.</para>
            /// <ol>
            /// <item><description>The agent prioritizes the camera stream.</description></item>
            /// <item><description>The agent prioritizes the screen sharing stream.</description></item>
            /// </ol>
            /// <para>By default, the camera stream is prioritized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("preferVideo")]
            [Validation(Required=false)]
            public int? PreferVideo { get; set; }

        }

    }

}

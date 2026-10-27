// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class GetScriptResponseBody : TeaModel {
        /// <summary>
        /// <para>Internal error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Scenario object information</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetScriptResponseBodyData Data { get; set; }
        public class GetScriptResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Concurrency</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public int? Concurrency { get; set; }

            /// <summary>
            /// <para>Creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1773228988000</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>Description</para>
            /// 
            /// <b>Example:</b>
            /// <para>test script</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Draft version information</para>
            /// </summary>
            [NameInMap("DraftVersion")]
            [Validation(Required=false)]
            public GetScriptResponseBodyDataDraftVersion DraftVersion { get; set; }
            public class GetScriptResponseBodyDataDraftVersion : TeaModel {
                /// <summary>
                /// <para>Interaction configuration</para>
                /// </summary>
                [NameInMap("InteractionConfig")]
                [Validation(Required=false)]
                public GetScriptResponseBodyDataDraftVersionInteractionConfig InteractionConfig { get; set; }
                public class GetScriptResponseBodyDataDraftVersionInteractionConfig : TeaModel {
                    /// <summary>
                    /// <para>Background music ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>office-ambience</para>
                    /// </summary>
                    [NameInMap("BackgroundMusicId")]
                    [Validation(Required=false)]
                    public string BackgroundMusicId { get; set; }

                    /// <summary>
                    /// <para>Hang-up configuration</para>
                    /// </summary>
                    [NameInMap("EndConversationConfig")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataDraftVersionInteractionConfigEndConversationConfig EndConversationConfig { get; set; }
                    public class GetScriptResponseBodyDataDraftVersionInteractionConfigEndConversationConfig : TeaModel {
                        /// <summary>
                        /// <para>The hang-up action is executed x seconds after the hang-up message is played. The range is 0 to 5.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Delay")]
                        [Validation(Required=false)]
                        public int? Delay { get; set; }

                        /// <summary>
                        /// <para>List of special case interceptions</para>
                        /// </summary>
                        [NameInMap("Triggers")]
                        [Validation(Required=false)]
                        public List<GetScriptResponseBodyDataDraftVersionInteractionConfigEndConversationConfigTriggers> Triggers { get; set; }
                        public class GetScriptResponseBodyDataDraftVersionInteractionConfigEndConversationConfigTriggers : TeaModel {
                            /// <summary>
                            /// <para>The message to play when hanging up after reaching the maximum number of rounds.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>感谢您的接听，祝您生活愉快，再见!</para>
                            /// </summary>
                            [NameInMap("ClosingStatement")]
                            [Validation(Required=false)]
                            public string ClosingStatement { get; set; }

                            /// <summary>
                            /// <para>List of custom interception keywords</para>
                            /// </summary>
                            [NameInMap("KeyWords")]
                            [Validation(Required=false)]
                            public List<string> KeyWords { get; set; }

                            /// <summary>
                            /// <para>TurnLimit: Maximum interaction rounds check. IntelligentVoiceAssistant: Voice assistant. InteractiveVoiceResponse: Extension transfer. KeyWords: Custom interception</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TurnLimit</para>
                            /// </summary>
                            [NameInMap("TriggerType")]
                            [Validation(Required=false)]
                            public string TriggerType { get; set; }

                            /// <summary>
                            /// <para>Hangs up when the number of interaction rounds exceeds x. The range is 0 to 100. A value of 0 indicates that the hang-up feature for exceeding the round limit is disabled.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>20</para>
                            /// </summary>
                            [NameInMap("TurnLimit")]
                            [Validation(Required=false)]
                            public int? TurnLimit { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The delay before playing audio after the call is connected, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("InitialGreetingDelayMilliseconds")]
                    [Validation(Required=false)]
                    public int? InitialGreetingDelayMilliseconds { get; set; }

                    /// <summary>
                    /// <para>Silence detection configuration</para>
                    /// </summary>
                    [NameInMap("SilenceDetectionConfig")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataDraftVersionInteractionConfigSilenceDetectionConfig SilenceDetectionConfig { get; set; }
                    public class GetScriptResponseBodyDataDraftVersionInteractionConfigSilenceDetectionConfig : TeaModel {
                        /// <summary>
                        /// <para>Hang up after consecutive rounds of silence. This takes effect when NluEngine is set to PROMPTS for the current scenario.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("MaxRepeats")]
                        [Validation(Required=false)]
                        public int? MaxRepeats { get; set; }

                        /// <summary>
                        /// <para>Silence timeout period in milliseconds. If the user remains silent for longer than the specified value, a silence timeout message is played. The range is 2000 to 10000.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5000</para>
                        /// </summary>
                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public int? Timeout { get; set; }

                    }

                }

                /// <summary>
                /// <para>List of label objects</para>
                /// </summary>
                [NameInMap("LabelConfig")]
                [Validation(Required=false)]
                public List<GetScriptResponseBodyDataDraftVersionLabelConfig> LabelConfig { get; set; }
                public class GetScriptResponseBodyDataDraftVersionLabelConfig : TeaModel {
                    /// <summary>
                    /// <para>List of candidate values for the label</para>
                    /// </summary>
                    [NameInMap("CandidateValues")]
                    [Validation(Required=false)]
                    public List<string> CandidateValues { get; set; }

                    /// <summary>
                    /// <para>Label description</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>用户是否同意于还款截止日期前还款</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Label name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>是否同意还款</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>Dialogue capability configuration</para>
                /// </summary>
                [NameInMap("ScriptProfile")]
                [Validation(Required=false)]
                public GetScriptResponseBodyDataDraftVersionScriptProfile ScriptProfile { get; set; }
                public class GetScriptResponseBodyDataDraftVersionScriptProfile : TeaModel {
                    /// <summary>
                    /// <para>Chatbot AgentKey</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1309723684579735_p_beebot_public</para>
                    /// </summary>
                    [NameInMap("AgentKey")]
                    [Validation(Required=false)]
                    public string AgentKey { get; set; }

                    /// <summary>
                    /// <para>Dialogue agent configuration</para>
                    /// </summary>
                    [NameInMap("AgentProfile")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataDraftVersionScriptProfileAgentProfile AgentProfile { get; set; }
                    public class GetScriptResponseBodyDataDraftVersionScriptProfileAgentProfile : TeaModel {
                        /// <summary>
                        /// <para>Prompt JSON</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{\&quot;prompts\&quot;:\&quot;我是一个聊天机器人。\&quot;}</para>
                        /// </summary>
                        [NameInMap("PromptsJson")]
                        [Validation(Required=false)]
                        public string PromptsJson { get; set; }

                        /// <summary>
                        /// <para>Scenario template ID</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CCC_PROMPTS_DEFAULT</para>
                        /// </summary>
                        [NameInMap("ScriptProfileTemplateId")]
                        [Validation(Required=false)]
                        public string ScriptProfileTemplateId { get; set; }

                    }

                    /// <summary>
                    /// <para>Chatbot ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chatbot-cn-MQuyjjb666</para>
                    /// </summary>
                    [NameInMap("ChatbotId")]
                    [Validation(Required=false)]
                    public string ChatbotId { get; set; }

                    /// <summary>
                    /// <para>Function Compute configuration</para>
                    /// </summary>
                    [NameInMap("FunctionMeta")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataDraftVersionScriptProfileFunctionMeta FunctionMeta { get; set; }
                    public class GetScriptResponseBodyDataDraftVersionScriptProfileFunctionMeta : TeaModel {
                        /// <summary>
                        /// <para>Function service ID</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9b752bbb-805a-4d3e-9013-eab5555c3fef</para>
                        /// </summary>
                        [NameInMap("FunctionId")]
                        [Validation(Required=false)]
                        public string FunctionId { get; set; }

                        /// <summary>
                        /// <para>Function service name</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>my_funciton</para>
                        /// </summary>
                        [NameInMap("FunctionName")]
                        [Validation(Required=false)]
                        public string FunctionName { get; set; }

                        /// <summary>
                        /// <para>Function trigger name</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>defaultTrigger</para>
                        /// </summary>
                        [NameInMap("HttpTriggerName")]
                        [Validation(Required=false)]
                        public string HttpTriggerName { get; set; }

                        /// <summary>
                        /// <para>Function trigger URL</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://chat-xxxxx-v-yewiundukb.cn-hangzhou-xxx.run">http://chat-xxxxx-v-yewiundukb.cn-hangzhou-xxx.run</a></para>
                        /// </summary>
                        [NameInMap("HttpTriggerUrl")]
                        [Validation(Required=false)]
                        public string HttpTriggerUrl { get; set; }

                        /// <summary>
                        /// <para>Region where the function service is located</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                    }

                    /// <summary>
                    /// <para>Dialogue model</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>qwen-plus</para>
                    /// </summary>
                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    /// <summary>
                    /// <para>Associated configuration</para>
                    /// </summary>
                    [NameInMap("NluAccessProfile")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataDraftVersionScriptProfileNluAccessProfile NluAccessProfile { get; set; }
                    public class GetScriptResponseBodyDataDraftVersionScriptProfileNluAccessProfile : TeaModel {
                        /// <summary>
                        /// <para>Third-party dialogue model configuration ID</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>c2c9baae-9351-4c49-a8cb-6f24a83a8718</para>
                        /// </summary>
                        [NameInMap("AccessProfileId")]
                        [Validation(Required=false)]
                        public string AccessProfileId { get; set; }

                    }

                    /// <summary>
                    /// <para>Dialogue model call method</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MANAGED</para>
                    /// </summary>
                    [NameInMap("NluAccessType")]
                    [Validation(Required=false)]
                    public string NluAccessType { get; set; }

                    /// <summary>
                    /// <para>NLU engine</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BEEBOT</para>
                    /// </summary>
                    [NameInMap("NluEngine")]
                    [Validation(Required=false)]
                    public string NluEngine { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the model is an Omni model.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("OmniModel")]
                    [Validation(Required=false)]
                    public bool? OmniModel { get; set; }

                }

                /// <summary>
                /// <para>TTS configuration</para>
                /// </summary>
                [NameInMap("SynthesizerConfig")]
                [Validation(Required=false)]
                public GetScriptResponseBodyDataDraftVersionSynthesizerConfig SynthesizerConfig { get; set; }
                public class GetScriptResponseBodyDataDraftVersionSynthesizerConfig : TeaModel {
                    /// <summary>
                    /// <para>TTS model</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CosyVoice</para>
                    /// </summary>
                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    /// <summary>
                    /// <para>Access account configuration</para>
                    /// </summary>
                    [NameInMap("NlsAccessProfile")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataDraftVersionSynthesizerConfigNlsAccessProfile NlsAccessProfile { get; set; }
                    public class GetScriptResponseBodyDataDraftVersionSynthesizerConfigNlsAccessProfile : TeaModel {
                        /// <summary>
                        /// <para>Third-party voice configuration</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0c4f978a-73bb-4841-bd84-75c0398edd4f</para>
                        /// </summary>
                        [NameInMap("AccessProfileId")]
                        [Validation(Required=false)]
                        public string AccessProfileId { get; set; }

                    }

                    /// <summary>
                    /// <para>TTS call method</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MANAGED</para>
                    /// </summary>
                    [NameInMap("NlsAccessType")]
                    [Validation(Required=false)]
                    public string NlsAccessType { get; set; }

                    /// <summary>
                    /// <para>TTS engine</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BAILIAN</para>
                    /// </summary>
                    [NameInMap("NlsEngine")]
                    [Validation(Required=false)]
                    public string NlsEngine { get; set; }

                    /// <summary>
                    /// <para>The speech pitch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PitchRate")]
                    [Validation(Required=false)]
                    public int? PitchRate { get; set; }

                    /// <summary>
                    /// <para>List of TTS intervention dictionaries</para>
                    /// </summary>
                    [NameInMap("PronRules")]
                    [Validation(Required=false)]
                    public List<GetScriptResponseBodyDataDraftVersionSynthesizerConfigPronRules> PronRules { get; set; }
                    public class GetScriptResponseBodyDataDraftVersionSynthesizerConfigPronRules : TeaModel {
                        /// <summary>
                        /// <para>Word prone to errors</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>还钱</para>
                        /// </summary>
                        [NameInMap("Pattern")]
                        [Validation(Required=false)]
                        public string Pattern { get; set; }

                        /// <summary>
                        /// <para>Replacement word</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>环钱</para>
                        /// </summary>
                        [NameInMap("Replacement")]
                        [Validation(Required=false)]
                        public string Replacement { get; set; }

                    }

                    /// <summary>
                    /// <para>Speech rate</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SpeechRate")]
                    [Validation(Required=false)]
                    public int? SpeechRate { get; set; }

                    /// <summary>
                    /// <para>Voice</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>longanyang</para>
                    /// </summary>
                    [NameInMap("Voice")]
                    [Validation(Required=false)]
                    public string Voice { get; set; }

                    /// <summary>
                    /// <para>Volume</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("Volume")]
                    [Validation(Required=false)]
                    public int? Volume { get; set; }

                }

                /// <summary>
                /// <para>ASR configuration</para>
                /// </summary>
                [NameInMap("TranscriberConfig")]
                [Validation(Required=false)]
                public GetScriptResponseBodyDataDraftVersionTranscriberConfig TranscriberConfig { get; set; }
                public class GetScriptResponseBodyDataDraftVersionTranscriberConfig : TeaModel {
                    [NameInMap("CorrectionRules")]
                    [Validation(Required=false)]
                    public List<GetScriptResponseBodyDataDraftVersionTranscriberConfigCorrectionRules> CorrectionRules { get; set; }
                    public class GetScriptResponseBodyDataDraftVersionTranscriberConfigCorrectionRules : TeaModel {
                        [NameInMap("Pattern")]
                        [Validation(Required=false)]
                        public string Pattern { get; set; }

                        [NameInMap("Replacement")]
                        [Validation(Required=false)]
                        public string Replacement { get; set; }

                    }

                    /// <summary>
                    /// <para>Self-learning language model ID (not currently supported)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0c4f978a-73bb-4841-bd84-75c0398edd6f</para>
                    /// </summary>
                    [NameInMap("CustomizationId")]
                    [Validation(Required=false)]
                    public string CustomizationId { get; set; }

                    /// <summary>
                    /// <para>Voice Activity Detection (VAD) sentence segmentation</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>500</para>
                    /// </summary>
                    [NameInMap("EndSilenceTimeout")]
                    [Validation(Required=false)]
                    public int? EndSilenceTimeout { get; set; }

                    /// <summary>
                    /// <para>ASR model</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Paraformer</para>
                    /// </summary>
                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    /// <summary>
                    /// <para>Access account configuration</para>
                    /// </summary>
                    [NameInMap("NlsAccessProfile")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataDraftVersionTranscriberConfigNlsAccessProfile NlsAccessProfile { get; set; }
                    public class GetScriptResponseBodyDataDraftVersionTranscriberConfigNlsAccessProfile : TeaModel {
                        /// <summary>
                        /// <para>Third-party voice configuration ID</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0c4f978a-73bb-4841-bd84-75c0398edd4f</para>
                        /// </summary>
                        [NameInMap("AccessProfileId")]
                        [Validation(Required=false)]
                        public string AccessProfileId { get; set; }

                    }

                    /// <summary>
                    /// <para>ASR call method</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MANAGED</para>
                    /// </summary>
                    [NameInMap("NlsAccessType")]
                    [Validation(Required=false)]
                    public string NlsAccessType { get; set; }

                    /// <summary>
                    /// <para>ASR engine</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BAILIAN</para>
                    /// </summary>
                    [NameInMap("NlsEngine")]
                    [Validation(Required=false)]
                    public string NlsEngine { get; set; }

                    /// <summary>
                    /// <para>Noise threshold</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SpeechNoiseThreshold")]
                    [Validation(Required=false)]
                    public string SpeechNoiseThreshold { get; set; }

                    /// <summary>
                    /// <para>Hotword ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0c4f978a-73bb-4841-bd84-75c0398edd5f</para>
                    /// </summary>
                    [NameInMap("VocabularyId")]
                    [Validation(Required=false)]
                    public string VocabularyId { get; set; }

                }

                /// <summary>
                /// <para>Version ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>0c4f978a-73bb-4841-bd84-75c0398edd4e</para>
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

            /// <summary>
            /// <para>Scenario name</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试场景</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Natural Language Understanding (NLU) engine</para>
            /// 
            /// <b>Example:</b>
            /// <para>BEEBOT</para>
            /// </summary>
            [NameInMap("NluEngine")]
            [Validation(Required=false)]
            public string NluEngine { get; set; }

            /// <summary>
            /// <para>Published version information</para>
            /// </summary>
            [NameInMap("PublishedVersion")]
            [Validation(Required=false)]
            public GetScriptResponseBodyDataPublishedVersion PublishedVersion { get; set; }
            public class GetScriptResponseBodyDataPublishedVersion : TeaModel {
                /// <summary>
                /// <para>Interaction configuration</para>
                /// </summary>
                [NameInMap("InteractionConfig")]
                [Validation(Required=false)]
                public GetScriptResponseBodyDataPublishedVersionInteractionConfig InteractionConfig { get; set; }
                public class GetScriptResponseBodyDataPublishedVersionInteractionConfig : TeaModel {
                    /// <summary>
                    /// <para>Background music ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>office-ambience</para>
                    /// </summary>
                    [NameInMap("BackgroundMusicId")]
                    [Validation(Required=false)]
                    public string BackgroundMusicId { get; set; }

                    /// <summary>
                    /// <para>Hang-up configuration</para>
                    /// </summary>
                    [NameInMap("EndConversationConfig")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataPublishedVersionInteractionConfigEndConversationConfig EndConversationConfig { get; set; }
                    public class GetScriptResponseBodyDataPublishedVersionInteractionConfigEndConversationConfig : TeaModel {
                        /// <summary>
                        /// <para>The hang-up action is executed x seconds after the hang-up message is played. The range is 0 to 5.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Delay")]
                        [Validation(Required=false)]
                        public int? Delay { get; set; }

                        /// <summary>
                        /// <para>Special case interception</para>
                        /// </summary>
                        [NameInMap("Triggers")]
                        [Validation(Required=false)]
                        public List<GetScriptResponseBodyDataPublishedVersionInteractionConfigEndConversationConfigTriggers> Triggers { get; set; }
                        public class GetScriptResponseBodyDataPublishedVersionInteractionConfigEndConversationConfigTriggers : TeaModel {
                            /// <summary>
                            /// <list type="bullet">
                            /// <item><description>The message to play when hanging up after reaching the maximum number of rounds.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>感谢您的接听，祝您生活愉快，再见!</para>
                            /// </summary>
                            [NameInMap("ClosingStatement")]
                            [Validation(Required=false)]
                            public string ClosingStatement { get; set; }

                            /// <summary>
                            /// <list type="bullet">
                            /// <item><description>List of custom interception keywords</description></item>
                            /// </list>
                            /// </summary>
                            [NameInMap("KeyWords")]
                            [Validation(Required=false)]
                            public List<string> KeyWords { get; set; }

                            /// <summary>
                            /// <list type="bullet">
                            /// <item><description><para><b>TurnLimit</b>: Maximum interaction rounds check.</para>
                            /// </description></item>
                            /// <item><description><para><b>IntelligentVoiceAssistant</b>: Voice assistant.</para>
                            /// </description></item>
                            /// <item><description><para><b>InteractiveVoiceResponse</b>: Extension transfer.</para>
                            /// </description></item>
                            /// <item><description><para><b>KeyWords</b>: Custom interception.</para>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TurnLimit</para>
                            /// </summary>
                            [NameInMap("TriggerType")]
                            [Validation(Required=false)]
                            public string TriggerType { get; set; }

                            /// <summary>
                            /// <list type="bullet">
                            /// <item><description><para>Hangs up when the number of interaction rounds exceeds x.</para>
                            /// </description></item>
                            /// <item><description><para>The range is 0 to 100.</para>
                            /// </description></item>
                            /// <item><description><para>A value of 0 indicates that the hang-up feature for exceeding the round limit is disabled.</para>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>20</para>
                            /// </summary>
                            [NameInMap("TurnLimit")]
                            [Validation(Required=false)]
                            public int? TurnLimit { get; set; }

                        }

                    }

                    /// <summary>
                    /// <list type="bullet">
                    /// <item><description><para>The delay before playing audio after the call is connected.</para>
                    /// </description></item>
                    /// <item><description><para>Unit: milliseconds.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("InitialGreetingDelayMilliseconds")]
                    [Validation(Required=false)]
                    public int? InitialGreetingDelayMilliseconds { get; set; }

                    /// <summary>
                    /// <para>Silence detection configuration</para>
                    /// </summary>
                    [NameInMap("SilenceDetectionConfig")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataPublishedVersionInteractionConfigSilenceDetectionConfig SilenceDetectionConfig { get; set; }
                    public class GetScriptResponseBodyDataPublishedVersionInteractionConfigSilenceDetectionConfig : TeaModel {
                        /// <summary>
                        /// <para>Hang up after consecutive rounds of silence.<br>
                        /// This takes effect when NluEngine is set to PROMPTS for the current scenario.<br></para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("MaxRepeats")]
                        [Validation(Required=false)]
                        public int? MaxRepeats { get; set; }

                        /// <summary>
                        /// <para>Silence timeout period in milliseconds.<br>
                        /// If the user remains silent for longer than the specified value, a silence timeout message is played.<br>
                        /// The range is 2000 to 10000.<br><br></para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5000</para>
                        /// </summary>
                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public int? Timeout { get; set; }

                    }

                }

                /// <summary>
                /// <para>Custom tag configuration</para>
                /// </summary>
                [NameInMap("LabelConfig")]
                [Validation(Required=false)]
                public List<GetScriptResponseBodyDataPublishedVersionLabelConfig> LabelConfig { get; set; }
                public class GetScriptResponseBodyDataPublishedVersionLabelConfig : TeaModel {
                    /// <summary>
                    /// <para>List of candidate values for the label</para>
                    /// </summary>
                    [NameInMap("CandidateValues")]
                    [Validation(Required=false)]
                    public List<string> CandidateValues { get; set; }

                    /// <summary>
                    /// <para>Label description</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>用户是否同意于还款截止日期前还款</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Label name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>是否同意还款</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>Dialogue capability configuration</para>
                /// </summary>
                [NameInMap("ScriptProfile")]
                [Validation(Required=false)]
                public GetScriptResponseBodyDataPublishedVersionScriptProfile ScriptProfile { get; set; }
                public class GetScriptResponseBodyDataPublishedVersionScriptProfile : TeaModel {
                    /// <summary>
                    /// <para>Chatbot AgentKey. This is required when NluEngine is set to BEEBOT for the current scenario.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1309723684579735_p_beebot_public</para>
                    /// </summary>
                    [NameInMap("AgentKey")]
                    [Validation(Required=false)]
                    public string AgentKey { get; set; }

                    /// <summary>
                    /// <para>Dialogue agent configuration</para>
                    /// </summary>
                    [NameInMap("AgentProfile")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataPublishedVersionScriptProfileAgentProfile AgentProfile { get; set; }
                    public class GetScriptResponseBodyDataPublishedVersionScriptProfileAgentProfile : TeaModel {
                        /// <summary>
                        /// <para>Dialogue agent description</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>用于测试</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>Dialogue agent name</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test agent</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para><b>Prompt JSON</b></para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{\&quot;prompts\&quot;:\&quot;我是一个聊天机器人。\&quot;}</para>
                        /// </summary>
                        [NameInMap("PromptsJson")]
                        [Validation(Required=false)]
                        public string PromptsJson { get; set; }

                        /// <summary>
                        /// <para><b>Scenario template ID</b></para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CCC_PROMPTS_DEFAULT</para>
                        /// </summary>
                        [NameInMap("ScriptProfileTemplateId")]
                        [Validation(Required=false)]
                        public string ScriptProfileTemplateId { get; set; }

                    }

                    /// <summary>
                    /// <para>Chatbot ID. This is required when NluEngine is set to BEEBOT for the current scenario.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chatbot-cn-MQuyjjb666</para>
                    /// </summary>
                    [NameInMap("ChatbotId")]
                    [Validation(Required=false)]
                    public string ChatbotId { get; set; }

                    /// <summary>
                    /// <para>Function Compute configuration</para>
                    /// </summary>
                    [NameInMap("FunctionMeta")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataPublishedVersionScriptProfileFunctionMeta FunctionMeta { get; set; }
                    public class GetScriptResponseBodyDataPublishedVersionScriptProfileFunctionMeta : TeaModel {
                        /// <summary>
                        /// <para>Function service ID. This is required when NluEngine is set to FUNCTION for the current scenario.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9b752bbb-805a-4d3e-9013-eab5555c3fef</para>
                        /// </summary>
                        [NameInMap("FunctionId")]
                        [Validation(Required=false)]
                        public string FunctionId { get; set; }

                        /// <summary>
                        /// <para>Function service name. This is required when NluEngine is set to FUNCTION for the current scenario.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>my_function</para>
                        /// </summary>
                        [NameInMap("FunctionName")]
                        [Validation(Required=false)]
                        public string FunctionName { get; set; }

                        /// <summary>
                        /// <para>Function trigger name. This is required when NluEngine is set to FUNCTION for the current scenario.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>defaultTrigger</para>
                        /// </summary>
                        [NameInMap("HttpTriggerName")]
                        [Validation(Required=false)]
                        public string HttpTriggerName { get; set; }

                        /// <summary>
                        /// <para>Function trigger URL. This is required when NluEngine is set to FUNCTION for the current scenario.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://chat-xxxxx-v-yewiundukb.cn-hangzhou-xxx.run">http://chat-xxxxx-v-yewiundukb.cn-hangzhou-xxx.run</a></para>
                        /// </summary>
                        [NameInMap("HttpTriggerUrl")]
                        [Validation(Required=false)]
                        public string HttpTriggerUrl { get; set; }

                        /// <summary>
                        /// <para>Region where the function service is located. This is required when NluEngine is set to FUNCTION for the current scenario.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                    }

                    /// <summary>
                    /// <para>Dialogue model. This is required when NluEngine is set to PROMPTS for the current scenario.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>qwen-plus</para>
                    /// </summary>
                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    /// <summary>
                    /// <para><b>Associated configuration</b></para>
                    /// </summary>
                    [NameInMap("NluAccessProfile")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataPublishedVersionScriptProfileNluAccessProfile NluAccessProfile { get; set; }
                    public class GetScriptResponseBodyDataPublishedVersionScriptProfileNluAccessProfile : TeaModel {
                        /// <summary>
                        /// <para>Third-party dialogue model configuration ID</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>c2c9baae-9351-4c49-a8cb-6f24a83a8718</para>
                        /// </summary>
                        [NameInMap("AccessProfileId")]
                        [Validation(Required=false)]
                        public string AccessProfileId { get; set; }

                    }

                    /// <summary>
                    /// <para>Dialogue model call method</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MANAGED</para>
                    /// </summary>
                    [NameInMap("NluAccessType")]
                    [Validation(Required=false)]
                    public string NluAccessType { get; set; }

                    /// <summary>
                    /// <para>NLU engine</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BEEBOT</para>
                    /// </summary>
                    [NameInMap("NluEngine")]
                    [Validation(Required=false)]
                    public string NluEngine { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the model is an Omni model.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("OmniModel")]
                    [Validation(Required=false)]
                    public bool? OmniModel { get; set; }

                }

                /// <summary>
                /// <para>TTS configuration</para>
                /// </summary>
                [NameInMap("SynthesizerConfig")]
                [Validation(Required=false)]
                public GetScriptResponseBodyDataPublishedVersionSynthesizerConfig SynthesizerConfig { get; set; }
                public class GetScriptResponseBodyDataPublishedVersionSynthesizerConfig : TeaModel {
                    /// <summary>
                    /// <para><b>TTS model</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CosyVoice</para>
                    /// </summary>
                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    /// <summary>
                    /// <para>Associated configuration</para>
                    /// </summary>
                    [NameInMap("NlsAccessProfile")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataPublishedVersionSynthesizerConfigNlsAccessProfile NlsAccessProfile { get; set; }
                    public class GetScriptResponseBodyDataPublishedVersionSynthesizerConfigNlsAccessProfile : TeaModel {
                        /// <summary>
                        /// <para>Third-party voice configuration ID (required when using third-party ASR services such as Doubao or iFLYTEK).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>c2c9baae-9351-4c49-a8cb-6f24a83a8718</para>
                        /// </summary>
                        [NameInMap("AccessProfileId")]
                        [Validation(Required=false)]
                        public string AccessProfileId { get; set; }

                    }

                    /// <summary>
                    /// <para><b>TTS call method</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MANAGED</para>
                    /// </summary>
                    [NameInMap("NlsAccessType")]
                    [Validation(Required=false)]
                    public string NlsAccessType { get; set; }

                    /// <summary>
                    /// <para><b>TTS engine</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BAILIAN</para>
                    /// </summary>
                    [NameInMap("NlsEngine")]
                    [Validation(Required=false)]
                    public string NlsEngine { get; set; }

                    /// <summary>
                    /// <para>Pitch rate
                    /// The range is -500 to 500.
                    /// The default value is 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PitchRate")]
                    [Validation(Required=false)]
                    public int? PitchRate { get; set; }

                    /// <summary>
                    /// <para>List of TTS intervention entries</para>
                    /// </summary>
                    [NameInMap("PronRules")]
                    [Validation(Required=false)]
                    public List<GetScriptResponseBodyDataPublishedVersionSynthesizerConfigPronRules> PronRules { get; set; }
                    public class GetScriptResponseBodyDataPublishedVersionSynthesizerConfigPronRules : TeaModel {
                        /// <summary>
                        /// <para>Word prone to errors</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>还钱</para>
                        /// </summary>
                        [NameInMap("Pattern")]
                        [Validation(Required=false)]
                        public string Pattern { get; set; }

                        /// <summary>
                        /// <para>Homophone</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>环钱</para>
                        /// </summary>
                        [NameInMap("Replacement")]
                        [Validation(Required=false)]
                        public string Replacement { get; set; }

                    }

                    /// <summary>
                    /// <para><b>Speech rate</b>
                    /// The range is -500 to 500.
                    /// The default value is 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SpeechRate")]
                    [Validation(Required=false)]
                    public int? SpeechRate { get; set; }

                    /// <summary>
                    /// <para><b>Voice</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>longanyang</para>
                    /// </summary>
                    [NameInMap("Voice")]
                    [Validation(Required=false)]
                    public string Voice { get; set; }

                    /// <summary>
                    /// <para>Volume
                    /// The range is 0 to 100.
                    /// The default value is 50.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("Volume")]
                    [Validation(Required=false)]
                    public int? Volume { get; set; }

                }

                /// <summary>
                /// <para>ASR configuration</para>
                /// </summary>
                [NameInMap("TranscriberConfig")]
                [Validation(Required=false)]
                public GetScriptResponseBodyDataPublishedVersionTranscriberConfig TranscriberConfig { get; set; }
                public class GetScriptResponseBodyDataPublishedVersionTranscriberConfig : TeaModel {
                    [NameInMap("CorrectionRules")]
                    [Validation(Required=false)]
                    public List<GetScriptResponseBodyDataPublishedVersionTranscriberConfigCorrectionRules> CorrectionRules { get; set; }
                    public class GetScriptResponseBodyDataPublishedVersionTranscriberConfigCorrectionRules : TeaModel {
                        [NameInMap("Pattern")]
                        [Validation(Required=false)]
                        public string Pattern { get; set; }

                        [NameInMap("Replacement")]
                        [Validation(Required=false)]
                        public string Replacement { get; set; }

                    }

                    /// <summary>
                    /// <para>Custom language model ID for ASR</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cd97223f-42f2-4cd9-95af-e734e2fe1fe4</para>
                    /// </summary>
                    [NameInMap("CustomizationId")]
                    [Validation(Required=false)]
                    public string CustomizationId { get; set; }

                    /// <summary>
                    /// <para>Silence detection (sentence segmentation is triggered when the speaking interval exceeds x milliseconds, which is Voice Activity Detection (VAD)).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>700</para>
                    /// </summary>
                    [NameInMap("EndSilenceTimeout")]
                    [Validation(Required=false)]
                    public int? EndSilenceTimeout { get; set; }

                    /// <summary>
                    /// <para>ASR model</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Paraformer</para>
                    /// </summary>
                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    /// <summary>
                    /// <para><b>Associated configuration</b></para>
                    /// </summary>
                    [NameInMap("NlsAccessProfile")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataPublishedVersionTranscriberConfigNlsAccessProfile NlsAccessProfile { get; set; }
                    public class GetScriptResponseBodyDataPublishedVersionTranscriberConfigNlsAccessProfile : TeaModel {
                        /// <summary>
                        /// <para>Third-party voice configuration ID (required when using third-party ASR services such as Doubao or iFLYTEK).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>c2c9baae-9351-4c49-a8cb-6f24a83a8718</para>
                        /// </summary>
                        [NameInMap("AccessProfileId")]
                        [Validation(Required=false)]
                        public string AccessProfileId { get; set; }

                    }

                    /// <summary>
                    /// <para><b>ASR call method</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MANAGED</para>
                    /// </summary>
                    [NameInMap("NlsAccessType")]
                    [Validation(Required=false)]
                    public string NlsAccessType { get; set; }

                    /// <summary>
                    /// <para><b>ASR engine</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BAILIAN</para>
                    /// </summary>
                    [NameInMap("NlsEngine")]
                    [Validation(Required=false)]
                    public string NlsEngine { get; set; }

                    /// <summary>
                    /// <para>Noise parameter threshold. The range is -100 to 100. The following describes the values:</para>
                    /// <para>The closer the value is to -100, the more likely noise is identified as speech.</para>
                    /// <para>The closer the value is to 100, the more likely speech is identified as noise.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SpeechNoiseThreshold")]
                    [Validation(Required=false)]
                    public string SpeechNoiseThreshold { get; set; }

                    /// <summary>
                    /// <para>Hotword table ID (obtained from the hotword management page).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cd97223f-42f2-4cd9-95af-e734e2fe1fe3</para>
                    /// </summary>
                    [NameInMap("VocabularyId")]
                    [Validation(Required=false)]
                    public string VocabularyId { get; set; }

                }

                /// <summary>
                /// <para>Version ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>8b77ff09-6a90-4784-8560-fdc2b860dc68</para>
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

            /// <summary>
            /// <para>Scenario ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>64241e64-190c-45d1-af66-06f51c07b090</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>Status</para>
            /// 
            /// <b>Example:</b>
            /// <para>DRAFT</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Update time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1773228988000</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance af81a389-91f0-4157-8d82-720edd02b66a
        ///  does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>List of dynamic error parameters</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>51E08AA9-8D1F-55F8-84A3-40635E2F0806</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

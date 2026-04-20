// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class GetScriptResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetScriptResponseBodyData Data { get; set; }
        public class GetScriptResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public int? Concurrency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1773228988000</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test script</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DraftVersion")]
            [Validation(Required=false)]
            public GetScriptResponseBodyDataDraftVersion DraftVersion { get; set; }
            public class GetScriptResponseBodyDataDraftVersion : TeaModel {
                [NameInMap("InteractionConfig")]
                [Validation(Required=false)]
                public GetScriptResponseBodyDataDraftVersionInteractionConfig InteractionConfig { get; set; }
                public class GetScriptResponseBodyDataDraftVersionInteractionConfig : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>office-ambience</para>
                    /// </summary>
                    [NameInMap("BackgroundMusicId")]
                    [Validation(Required=false)]
                    public string BackgroundMusicId { get; set; }

                    [NameInMap("EndConversationConfig")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataDraftVersionInteractionConfigEndConversationConfig EndConversationConfig { get; set; }
                    public class GetScriptResponseBodyDataDraftVersionInteractionConfigEndConversationConfig : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Delay")]
                        [Validation(Required=false)]
                        public int? Delay { get; set; }

                        [NameInMap("Triggers")]
                        [Validation(Required=false)]
                        public List<GetScriptResponseBodyDataDraftVersionInteractionConfigEndConversationConfigTriggers> Triggers { get; set; }
                        public class GetScriptResponseBodyDataDraftVersionInteractionConfigEndConversationConfigTriggers : TeaModel {
                            [NameInMap("ClosingStatement")]
                            [Validation(Required=false)]
                            public string ClosingStatement { get; set; }

                            [NameInMap("KeyWords")]
                            [Validation(Required=false)]
                            public List<string> KeyWords { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>TurnLimit</para>
                            /// </summary>
                            [NameInMap("TriggerType")]
                            [Validation(Required=false)]
                            public string TriggerType { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>20</para>
                            /// </summary>
                            [NameInMap("TurnLimit")]
                            [Validation(Required=false)]
                            public int? TurnLimit { get; set; }

                        }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("InitialGreetingDelayMilliseconds")]
                    [Validation(Required=false)]
                    public int? InitialGreetingDelayMilliseconds { get; set; }

                    [NameInMap("SilenceDetectionConfig")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataDraftVersionInteractionConfigSilenceDetectionConfig SilenceDetectionConfig { get; set; }
                    public class GetScriptResponseBodyDataDraftVersionInteractionConfigSilenceDetectionConfig : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("MaxRepeats")]
                        [Validation(Required=false)]
                        public int? MaxRepeats { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>5000</para>
                        /// </summary>
                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public int? Timeout { get; set; }

                    }

                }

                [NameInMap("LabelConfig")]
                [Validation(Required=false)]
                public List<GetScriptResponseBodyDataDraftVersionLabelConfig> LabelConfig { get; set; }
                public class GetScriptResponseBodyDataDraftVersionLabelConfig : TeaModel {
                    [NameInMap("CandidateValues")]
                    [Validation(Required=false)]
                    public List<string> CandidateValues { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("ScriptProfile")]
                [Validation(Required=false)]
                public GetScriptResponseBodyDataDraftVersionScriptProfile ScriptProfile { get; set; }
                public class GetScriptResponseBodyDataDraftVersionScriptProfile : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1309723684579735_p_beebot_public</para>
                    /// </summary>
                    [NameInMap("AgentKey")]
                    [Validation(Required=false)]
                    public string AgentKey { get; set; }

                    [NameInMap("AgentProfile")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataDraftVersionScriptProfileAgentProfile AgentProfile { get; set; }
                    public class GetScriptResponseBodyDataDraftVersionScriptProfileAgentProfile : TeaModel {
                        [NameInMap("PromptsJson")]
                        [Validation(Required=false)]
                        public string PromptsJson { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>CCC_PROMPTS_DEFAULT</para>
                        /// </summary>
                        [NameInMap("ScriptProfileTemplateId")]
                        [Validation(Required=false)]
                        public string ScriptProfileTemplateId { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>chatbot-cn-MQuyjjb666</para>
                    /// </summary>
                    [NameInMap("ChatbotId")]
                    [Validation(Required=false)]
                    public string ChatbotId { get; set; }

                    [NameInMap("FunctionMeta")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataDraftVersionScriptProfileFunctionMeta FunctionMeta { get; set; }
                    public class GetScriptResponseBodyDataDraftVersionScriptProfileFunctionMeta : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>9b752bbb-805a-4d3e-9013-eab5555c3fef</para>
                        /// </summary>
                        [NameInMap("FunctionId")]
                        [Validation(Required=false)]
                        public string FunctionId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>my_funciton</para>
                        /// </summary>
                        [NameInMap("FunctionName")]
                        [Validation(Required=false)]
                        public string FunctionName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>defaultTrigger</para>
                        /// </summary>
                        [NameInMap("HttpTriggerName")]
                        [Validation(Required=false)]
                        public string HttpTriggerName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="http://chat-xxxxx-v-yewiundukb.cn-hangzhou-xxx.run">http://chat-xxxxx-v-yewiundukb.cn-hangzhou-xxx.run</a></para>
                        /// </summary>
                        [NameInMap("HttpTriggerUrl")]
                        [Validation(Required=false)]
                        public string HttpTriggerUrl { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>qwen-plus</para>
                    /// </summary>
                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    [NameInMap("NluAccessProfile")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataDraftVersionScriptProfileNluAccessProfile NluAccessProfile { get; set; }
                    public class GetScriptResponseBodyDataDraftVersionScriptProfileNluAccessProfile : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>c2c9baae-9351-4c49-a8cb-6f24a83a8718</para>
                        /// </summary>
                        [NameInMap("AccessProfileId")]
                        [Validation(Required=false)]
                        public string AccessProfileId { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MANAGED</para>
                    /// </summary>
                    [NameInMap("NluAccessType")]
                    [Validation(Required=false)]
                    public string NluAccessType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BEEBOT</para>
                    /// </summary>
                    [NameInMap("NluEngine")]
                    [Validation(Required=false)]
                    public string NluEngine { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("OmniModel")]
                    [Validation(Required=false)]
                    public bool? OmniModel { get; set; }

                }

                [NameInMap("SynthesizerConfig")]
                [Validation(Required=false)]
                public GetScriptResponseBodyDataDraftVersionSynthesizerConfig SynthesizerConfig { get; set; }
                public class GetScriptResponseBodyDataDraftVersionSynthesizerConfig : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CosyVoice</para>
                    /// </summary>
                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    [NameInMap("NlsAccessProfile")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataDraftVersionSynthesizerConfigNlsAccessProfile NlsAccessProfile { get; set; }
                    public class GetScriptResponseBodyDataDraftVersionSynthesizerConfigNlsAccessProfile : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0c4f978a-73bb-4841-bd84-75c0398edd4f</para>
                        /// </summary>
                        [NameInMap("AccessProfileId")]
                        [Validation(Required=false)]
                        public string AccessProfileId { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MANAGED</para>
                    /// </summary>
                    [NameInMap("NlsAccessType")]
                    [Validation(Required=false)]
                    public string NlsAccessType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BAILIAN</para>
                    /// </summary>
                    [NameInMap("NlsEngine")]
                    [Validation(Required=false)]
                    public string NlsEngine { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PitchRate")]
                    [Validation(Required=false)]
                    public int? PitchRate { get; set; }

                    [NameInMap("PronRules")]
                    [Validation(Required=false)]
                    public List<GetScriptResponseBodyDataDraftVersionSynthesizerConfigPronRules> PronRules { get; set; }
                    public class GetScriptResponseBodyDataDraftVersionSynthesizerConfigPronRules : TeaModel {
                        [NameInMap("Pattern")]
                        [Validation(Required=false)]
                        public string Pattern { get; set; }

                        [NameInMap("Replacement")]
                        [Validation(Required=false)]
                        public string Replacement { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SpeechRate")]
                    [Validation(Required=false)]
                    public int? SpeechRate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>longanyang</para>
                    /// </summary>
                    [NameInMap("Voice")]
                    [Validation(Required=false)]
                    public string Voice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("Volume")]
                    [Validation(Required=false)]
                    public int? Volume { get; set; }

                }

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
                    /// <b>Example:</b>
                    /// <para>0c4f978a-73bb-4841-bd84-75c0398edd6f</para>
                    /// </summary>
                    [NameInMap("CustomizationId")]
                    [Validation(Required=false)]
                    public string CustomizationId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>500</para>
                    /// </summary>
                    [NameInMap("EndSilenceTimeout")]
                    [Validation(Required=false)]
                    public int? EndSilenceTimeout { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Paraformer</para>
                    /// </summary>
                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    [NameInMap("NlsAccessProfile")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataDraftVersionTranscriberConfigNlsAccessProfile NlsAccessProfile { get; set; }
                    public class GetScriptResponseBodyDataDraftVersionTranscriberConfigNlsAccessProfile : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0c4f978a-73bb-4841-bd84-75c0398edd4f</para>
                        /// </summary>
                        [NameInMap("AccessProfileId")]
                        [Validation(Required=false)]
                        public string AccessProfileId { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MANAGED</para>
                    /// </summary>
                    [NameInMap("NlsAccessType")]
                    [Validation(Required=false)]
                    public string NlsAccessType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BAILIAN</para>
                    /// </summary>
                    [NameInMap("NlsEngine")]
                    [Validation(Required=false)]
                    public string NlsEngine { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SpeechNoiseThreshold")]
                    [Validation(Required=false)]
                    public string SpeechNoiseThreshold { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0c4f978a-73bb-4841-bd84-75c0398edd5f</para>
                    /// </summary>
                    [NameInMap("VocabularyId")]
                    [Validation(Required=false)]
                    public string VocabularyId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0c4f978a-73bb-4841-bd84-75c0398edd4e</para>
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BEEBOT</para>
            /// </summary>
            [NameInMap("NluEngine")]
            [Validation(Required=false)]
            public string NluEngine { get; set; }

            [NameInMap("PublishedVersion")]
            [Validation(Required=false)]
            public GetScriptResponseBodyDataPublishedVersion PublishedVersion { get; set; }
            public class GetScriptResponseBodyDataPublishedVersion : TeaModel {
                [NameInMap("InteractionConfig")]
                [Validation(Required=false)]
                public GetScriptResponseBodyDataPublishedVersionInteractionConfig InteractionConfig { get; set; }
                public class GetScriptResponseBodyDataPublishedVersionInteractionConfig : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>office-ambience</para>
                    /// </summary>
                    [NameInMap("BackgroundMusicId")]
                    [Validation(Required=false)]
                    public string BackgroundMusicId { get; set; }

                    [NameInMap("EndConversationConfig")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataPublishedVersionInteractionConfigEndConversationConfig EndConversationConfig { get; set; }
                    public class GetScriptResponseBodyDataPublishedVersionInteractionConfigEndConversationConfig : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Delay")]
                        [Validation(Required=false)]
                        public int? Delay { get; set; }

                        [NameInMap("Triggers")]
                        [Validation(Required=false)]
                        public List<GetScriptResponseBodyDataPublishedVersionInteractionConfigEndConversationConfigTriggers> Triggers { get; set; }
                        public class GetScriptResponseBodyDataPublishedVersionInteractionConfigEndConversationConfigTriggers : TeaModel {
                            [NameInMap("ClosingStatement")]
                            [Validation(Required=false)]
                            public string ClosingStatement { get; set; }

                            [NameInMap("KeyWords")]
                            [Validation(Required=false)]
                            public List<string> KeyWords { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>TurnLimit</para>
                            /// </summary>
                            [NameInMap("TriggerType")]
                            [Validation(Required=false)]
                            public string TriggerType { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>20</para>
                            /// </summary>
                            [NameInMap("TurnLimit")]
                            [Validation(Required=false)]
                            public int? TurnLimit { get; set; }

                        }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("InitialGreetingDelayMilliseconds")]
                    [Validation(Required=false)]
                    public int? InitialGreetingDelayMilliseconds { get; set; }

                    [NameInMap("SilenceDetectionConfig")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataPublishedVersionInteractionConfigSilenceDetectionConfig SilenceDetectionConfig { get; set; }
                    public class GetScriptResponseBodyDataPublishedVersionInteractionConfigSilenceDetectionConfig : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("MaxRepeats")]
                        [Validation(Required=false)]
                        public int? MaxRepeats { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>5000</para>
                        /// </summary>
                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public int? Timeout { get; set; }

                    }

                }

                [NameInMap("LabelConfig")]
                [Validation(Required=false)]
                public List<GetScriptResponseBodyDataPublishedVersionLabelConfig> LabelConfig { get; set; }
                public class GetScriptResponseBodyDataPublishedVersionLabelConfig : TeaModel {
                    [NameInMap("CandidateValues")]
                    [Validation(Required=false)]
                    public List<string> CandidateValues { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("ScriptProfile")]
                [Validation(Required=false)]
                public GetScriptResponseBodyDataPublishedVersionScriptProfile ScriptProfile { get; set; }
                public class GetScriptResponseBodyDataPublishedVersionScriptProfile : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1309723684579735_p_beebot_public</para>
                    /// </summary>
                    [NameInMap("AgentKey")]
                    [Validation(Required=false)]
                    public string AgentKey { get; set; }

                    [NameInMap("AgentProfile")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataPublishedVersionScriptProfileAgentProfile AgentProfile { get; set; }
                    public class GetScriptResponseBodyDataPublishedVersionScriptProfileAgentProfile : TeaModel {
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>test agent</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("PromptsJson")]
                        [Validation(Required=false)]
                        public string PromptsJson { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>CCC_PROMPTS_DEFAULT</para>
                        /// </summary>
                        [NameInMap("ScriptProfileTemplateId")]
                        [Validation(Required=false)]
                        public string ScriptProfileTemplateId { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>chatbot-cn-MQuyjjb666</para>
                    /// </summary>
                    [NameInMap("ChatbotId")]
                    [Validation(Required=false)]
                    public string ChatbotId { get; set; }

                    [NameInMap("FunctionMeta")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataPublishedVersionScriptProfileFunctionMeta FunctionMeta { get; set; }
                    public class GetScriptResponseBodyDataPublishedVersionScriptProfileFunctionMeta : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>9b752bbb-805a-4d3e-9013-eab5555c3fef</para>
                        /// </summary>
                        [NameInMap("FunctionId")]
                        [Validation(Required=false)]
                        public string FunctionId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>my_function</para>
                        /// </summary>
                        [NameInMap("FunctionName")]
                        [Validation(Required=false)]
                        public string FunctionName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>defaultTrigger</para>
                        /// </summary>
                        [NameInMap("HttpTriggerName")]
                        [Validation(Required=false)]
                        public string HttpTriggerName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="http://chat-xxxxx-v-yewiundukb.cn-hangzhou-xxx.run">http://chat-xxxxx-v-yewiundukb.cn-hangzhou-xxx.run</a></para>
                        /// </summary>
                        [NameInMap("HttpTriggerUrl")]
                        [Validation(Required=false)]
                        public string HttpTriggerUrl { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>qwen-plus</para>
                    /// </summary>
                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    [NameInMap("NluAccessProfile")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataPublishedVersionScriptProfileNluAccessProfile NluAccessProfile { get; set; }
                    public class GetScriptResponseBodyDataPublishedVersionScriptProfileNluAccessProfile : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>c2c9baae-9351-4c49-a8cb-6f24a83a8718</para>
                        /// </summary>
                        [NameInMap("AccessProfileId")]
                        [Validation(Required=false)]
                        public string AccessProfileId { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MANAGED</para>
                    /// </summary>
                    [NameInMap("NluAccessType")]
                    [Validation(Required=false)]
                    public string NluAccessType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BEEBOT</para>
                    /// </summary>
                    [NameInMap("NluEngine")]
                    [Validation(Required=false)]
                    public string NluEngine { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("OmniModel")]
                    [Validation(Required=false)]
                    public bool? OmniModel { get; set; }

                }

                [NameInMap("SynthesizerConfig")]
                [Validation(Required=false)]
                public GetScriptResponseBodyDataPublishedVersionSynthesizerConfig SynthesizerConfig { get; set; }
                public class GetScriptResponseBodyDataPublishedVersionSynthesizerConfig : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CosyVoice</para>
                    /// </summary>
                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    [NameInMap("NlsAccessProfile")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataPublishedVersionSynthesizerConfigNlsAccessProfile NlsAccessProfile { get; set; }
                    public class GetScriptResponseBodyDataPublishedVersionSynthesizerConfigNlsAccessProfile : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>c2c9baae-9351-4c49-a8cb-6f24a83a8718</para>
                        /// </summary>
                        [NameInMap("AccessProfileId")]
                        [Validation(Required=false)]
                        public string AccessProfileId { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MANAGED</para>
                    /// </summary>
                    [NameInMap("NlsAccessType")]
                    [Validation(Required=false)]
                    public string NlsAccessType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BAILIAN</para>
                    /// </summary>
                    [NameInMap("NlsEngine")]
                    [Validation(Required=false)]
                    public string NlsEngine { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PitchRate")]
                    [Validation(Required=false)]
                    public int? PitchRate { get; set; }

                    [NameInMap("PronRules")]
                    [Validation(Required=false)]
                    public List<GetScriptResponseBodyDataPublishedVersionSynthesizerConfigPronRules> PronRules { get; set; }
                    public class GetScriptResponseBodyDataPublishedVersionSynthesizerConfigPronRules : TeaModel {
                        [NameInMap("Pattern")]
                        [Validation(Required=false)]
                        public string Pattern { get; set; }

                        [NameInMap("Replacement")]
                        [Validation(Required=false)]
                        public string Replacement { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SpeechRate")]
                    [Validation(Required=false)]
                    public int? SpeechRate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>longanyang</para>
                    /// </summary>
                    [NameInMap("Voice")]
                    [Validation(Required=false)]
                    public string Voice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("Volume")]
                    [Validation(Required=false)]
                    public int? Volume { get; set; }

                }

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
                    /// <b>Example:</b>
                    /// <para>cd97223f-42f2-4cd9-95af-e734e2fe1fe4</para>
                    /// </summary>
                    [NameInMap("CustomizationId")]
                    [Validation(Required=false)]
                    public string CustomizationId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>700</para>
                    /// </summary>
                    [NameInMap("EndSilenceTimeout")]
                    [Validation(Required=false)]
                    public int? EndSilenceTimeout { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Paraformer</para>
                    /// </summary>
                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    [NameInMap("NlsAccessProfile")]
                    [Validation(Required=false)]
                    public GetScriptResponseBodyDataPublishedVersionTranscriberConfigNlsAccessProfile NlsAccessProfile { get; set; }
                    public class GetScriptResponseBodyDataPublishedVersionTranscriberConfigNlsAccessProfile : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>c2c9baae-9351-4c49-a8cb-6f24a83a8718</para>
                        /// </summary>
                        [NameInMap("AccessProfileId")]
                        [Validation(Required=false)]
                        public string AccessProfileId { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MANAGED</para>
                    /// </summary>
                    [NameInMap("NlsAccessType")]
                    [Validation(Required=false)]
                    public string NlsAccessType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BAILIAN</para>
                    /// </summary>
                    [NameInMap("NlsEngine")]
                    [Validation(Required=false)]
                    public string NlsEngine { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SpeechNoiseThreshold")]
                    [Validation(Required=false)]
                    public string SpeechNoiseThreshold { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cd97223f-42f2-4cd9-95af-e734e2fe1fe3</para>
                    /// </summary>
                    [NameInMap("VocabularyId")]
                    [Validation(Required=false)]
                    public string VocabularyId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8b77ff09-6a90-4784-8560-fdc2b860dc68</para>
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>64241e64-190c-45d1-af66-06f51c07b090</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DRAFT</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1773228988000</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Instance af81a389-91f0-4157-8d82-720edd02b66a
        ///  does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>51E08AA9-8D1F-55F8-84A3-40635E2F0806</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

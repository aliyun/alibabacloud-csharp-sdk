// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class CreateScriptVersionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>abb4aa26-3a8e-43dd-82f8-0c3898c9c67f</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InteractionConfig")]
        [Validation(Required=false)]
        public CreateScriptVersionRequestInteractionConfig InteractionConfig { get; set; }
        public class CreateScriptVersionRequestInteractionConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>office-ambience</para>
            /// </summary>
            [NameInMap("BackgroundMusicId")]
            [Validation(Required=false)]
            public string BackgroundMusicId { get; set; }

            [NameInMap("EndConversationConfig")]
            [Validation(Required=false)]
            public CreateScriptVersionRequestInteractionConfigEndConversationConfig EndConversationConfig { get; set; }
            public class CreateScriptVersionRequestInteractionConfigEndConversationConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Delay")]
                [Validation(Required=false)]
                public int? Delay { get; set; }

                [NameInMap("Triggers")]
                [Validation(Required=false)]
                public List<CreateScriptVersionRequestInteractionConfigEndConversationConfigTriggers> Triggers { get; set; }
                public class CreateScriptVersionRequestInteractionConfigEndConversationConfigTriggers : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>感谢您的接听，祝您生活愉快，再见!</para>
                    /// </summary>
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
            public CreateScriptVersionRequestInteractionConfigSilenceDetectionConfig SilenceDetectionConfig { get; set; }
            public class CreateScriptVersionRequestInteractionConfigSilenceDetectionConfig : TeaModel {
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
        public List<CreateScriptVersionRequestLabelConfig> LabelConfig { get; set; }
        public class CreateScriptVersionRequestLabelConfig : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>64241e64-190c-45d1-af66-06f51c07b090</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        [NameInMap("ScriptProfile")]
        [Validation(Required=false)]
        public CreateScriptVersionRequestScriptProfile ScriptProfile { get; set; }
        public class CreateScriptVersionRequestScriptProfile : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1309723684579735_p_beebot_public</para>
            /// </summary>
            [NameInMap("AgentKey")]
            [Validation(Required=false)]
            public string AgentKey { get; set; }

            [NameInMap("AgentProfile")]
            [Validation(Required=false)]
            public CreateScriptVersionRequestScriptProfileAgentProfile AgentProfile { get; set; }
            public class CreateScriptVersionRequestScriptProfileAgentProfile : TeaModel {
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
            public CreateScriptVersionRequestScriptProfileFunctionMeta FunctionMeta { get; set; }
            public class CreateScriptVersionRequestScriptProfileFunctionMeta : TeaModel {
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
            public CreateScriptVersionRequestScriptProfileNluAccessProfile NluAccessProfile { get; set; }
            public class CreateScriptVersionRequestScriptProfileNluAccessProfile : TeaModel {
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
            /// <para>true</para>
            /// </summary>
            [NameInMap("OmniModel")]
            [Validation(Required=false)]
            public bool? OmniModel { get; set; }

        }

        [NameInMap("SourceVersionId")]
        [Validation(Required=false)]
        public string SourceVersionId { get; set; }

        [NameInMap("SynthesizerConfig")]
        [Validation(Required=false)]
        public CreateScriptVersionRequestSynthesizerConfig SynthesizerConfig { get; set; }
        public class CreateScriptVersionRequestSynthesizerConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CosyVoice</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            [NameInMap("NlsAccessProfile")]
            [Validation(Required=false)]
            public CreateScriptVersionRequestSynthesizerConfigNlsAccessProfile NlsAccessProfile { get; set; }
            public class CreateScriptVersionRequestSynthesizerConfigNlsAccessProfile : TeaModel {
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
            public List<CreateScriptVersionRequestSynthesizerConfigPronRules> PronRules { get; set; }
            public class CreateScriptVersionRequestSynthesizerConfigPronRules : TeaModel {
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
        public CreateScriptVersionRequestTranscriberConfig TranscriberConfig { get; set; }
        public class CreateScriptVersionRequestTranscriberConfig : TeaModel {
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
            public CreateScriptVersionRequestTranscriberConfigNlsAccessProfile NlsAccessProfile { get; set; }
            public class CreateScriptVersionRequestTranscriberConfigNlsAccessProfile : TeaModel {
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
            public int? SpeechNoiseThreshold { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cd97223f-42f2-4cd9-95af-e734e2fe1fe3</para>
            /// </summary>
            [NameInMap("VocabularyId")]
            [Validation(Required=false)]
            public string VocabularyId { get; set; }

        }

    }

}

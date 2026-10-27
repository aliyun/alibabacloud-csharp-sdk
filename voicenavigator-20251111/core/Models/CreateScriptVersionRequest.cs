// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class CreateScriptVersionRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abb4aa26-3a8e-43dd-82f8-0c3898c9c67f</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The interaction configuration.</para>
        /// </summary>
        [NameInMap("InteractionConfig")]
        [Validation(Required=false)]
        public CreateScriptVersionRequestInteractionConfig InteractionConfig { get; set; }
        public class CreateScriptVersionRequestInteractionConfig : TeaModel {
            /// <summary>
            /// <para>The background music ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>office-ambience</para>
            /// </summary>
            [NameInMap("BackgroundMusicId")]
            [Validation(Required=false)]
            public string BackgroundMusicId { get; set; }

            /// <summary>
            /// <para>The hang-up configuration.</para>
            /// </summary>
            [NameInMap("EndConversationConfig")]
            [Validation(Required=false)]
            public CreateScriptVersionRequestInteractionConfigEndConversationConfig EndConversationConfig { get; set; }
            public class CreateScriptVersionRequestInteractionConfigEndConversationConfig : TeaModel {
                /// <summary>
                /// <para>The number of seconds to wait after the hang-up script finishes playing before executing the hang-up action. Valid values: 0 to 5.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Delay")]
                [Validation(Required=false)]
                public int? Delay { get; set; }

                /// <summary>
                /// <para>The special case interception rules.</para>
                /// </summary>
                [NameInMap("Triggers")]
                [Validation(Required=false)]
                public List<CreateScriptVersionRequestInteractionConfigEndConversationConfigTriggers> Triggers { get; set; }
                public class CreateScriptVersionRequestInteractionConfigEndConversationConfigTriggers : TeaModel {
                    /// <summary>
                    /// <para>The closing statement played when the turn limit is reached and the hang-up action is executed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Thank you for your time. Have a nice day. Goodbye!</para>
                    /// </summary>
                    [NameInMap("ClosingStatement")]
                    [Validation(Required=false)]
                    public string ClosingStatement { get; set; }

                    /// <summary>
                    /// <para>The list of custom interception keywords.</para>
                    /// </summary>
                    [NameInMap("KeyWords")]
                    [Validation(Required=false)]
                    public List<string> KeyWords { get; set; }

                    /// <summary>
                    /// <para>Valid values:\</para>
                    /// <list type="bullet">
                    /// <item><description>TurnLimit: Maximum interaction turn check.\</description></item>
                    /// <item><description>IntelligentVoiceAssistant: Voice assistant.\</description></item>
                    /// <item><description>InteractiveVoiceResponse: Extension transfer.\</description></item>
                    /// <item><description>KeyWords: Custom interception.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TurnLimit</para>
                    /// </summary>
                    [NameInMap("TriggerType")]
                    [Validation(Required=false)]
                    public string TriggerType { get; set; }

                    /// <summary>
                    /// <para>The maximum number of interaction turns before the hang-up action is executed. Valid values: 0 to 100. A value of 0 indicates that the turn-limit hang-up feature is disabled.</para>
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
            /// <para>The delay before playing the greeting after the call is connected. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("InitialGreetingDelayMilliseconds")]
            [Validation(Required=false)]
            public int? InitialGreetingDelayMilliseconds { get; set; }

            /// <summary>
            /// <para>The silence detection configuration.</para>
            /// </summary>
            [NameInMap("SilenceDetectionConfig")]
            [Validation(Required=false)]
            public CreateScriptVersionRequestInteractionConfigSilenceDetectionConfig SilenceDetectionConfig { get; set; }
            public class CreateScriptVersionRequestInteractionConfigSilenceDetectionConfig : TeaModel {
                /// <summary>
                /// <para>The number of consecutive silence turns before the hang-up action is executed.\
                /// This parameter takes effect when NluEngine is set to PROMPTS for the current scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("MaxRepeats")]
                [Validation(Required=false)]
                public int? MaxRepeats { get; set; }

                /// <summary>
                /// <para>The silence timeout period, in milliseconds.\
                /// When the user remains silent for longer than the specified value, the silence timeout script is played.\
                /// Valid values: 2000 to 10000.</para>
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
        /// <para>The custom label configuration.</para>
        /// </summary>
        [NameInMap("LabelConfig")]
        [Validation(Required=false)]
        public List<CreateScriptVersionRequestLabelConfig> LabelConfig { get; set; }
        public class CreateScriptVersionRequestLabelConfig : TeaModel {
            /// <summary>
            /// <para>The list of candidate values for the label.</para>
            /// </summary>
            [NameInMap("CandidateValues")]
            [Validation(Required=false)]
            public List<string> CandidateValues { get; set; }

            /// <summary>
            /// <para>The label description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Whether the user agrees to repay before the repayment deadline</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The label name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Agree to repay</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The scenario ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64241e64-190c-45d1-af66-06f51c07b090</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The conversation capability configuration.</para>
        /// </summary>
        [NameInMap("ScriptProfile")]
        [Validation(Required=false)]
        public CreateScriptVersionRequestScriptProfile ScriptProfile { get; set; }
        public class CreateScriptVersionRequestScriptProfile : TeaModel {
            /// <summary>
            /// <para>The AgentKey of the chatbot.\
            /// This parameter is required when NluEngine is set to BEEBOT for the current scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1309723684579735_p_beebot_public</para>
            /// </summary>
            [NameInMap("AgentKey")]
            [Validation(Required=false)]
            public string AgentKey { get; set; }

            /// <summary>
            /// <para>The conversation agent configuration.</para>
            /// </summary>
            [NameInMap("AgentProfile")]
            [Validation(Required=false)]
            public CreateScriptVersionRequestScriptProfileAgentProfile AgentProfile { get; set; }
            public class CreateScriptVersionRequestScriptProfileAgentProfile : TeaModel {
                /// <summary>
                /// <para>The prompt in JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;prompts\&quot;:\&quot;I am a chatbot.\&quot;}</para>
                /// </summary>
                [NameInMap("PromptsJson")]
                [Validation(Required=false)]
                public string PromptsJson { get; set; }

                /// <summary>
                /// <para>The scenario template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CCC_PROMPTS_DEFAULT</para>
                /// </summary>
                [NameInMap("ScriptProfileTemplateId")]
                [Validation(Required=false)]
                public string ScriptProfileTemplateId { get; set; }

            }

            /// <summary>
            /// <para>The chatbot ID.\
            /// This parameter is required when NluEngine is set to BEEBOT for the current scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chatbot-cn-MQuyjjb666</para>
            /// </summary>
            [NameInMap("ChatbotId")]
            [Validation(Required=false)]
            public string ChatbotId { get; set; }

            /// <summary>
            /// <para>The Function Compute configuration.</para>
            /// </summary>
            [NameInMap("FunctionMeta")]
            [Validation(Required=false)]
            public CreateScriptVersionRequestScriptProfileFunctionMeta FunctionMeta { get; set; }
            public class CreateScriptVersionRequestScriptProfileFunctionMeta : TeaModel {
                /// <summary>
                /// <para>The function service ID.\
                /// This parameter is required when NluEngine is set to FUNCTION for the current scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9b752bbb-805a-4d3e-9013-eab5555c3fef</para>
                /// </summary>
                [NameInMap("FunctionId")]
                [Validation(Required=false)]
                public string FunctionId { get; set; }

                /// <summary>
                /// <para>The function service name.\
                /// This parameter is required when NluEngine is set to FUNCTION for the current scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my_funciton</para>
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                /// <summary>
                /// <para>The HTTP trigger name.\
                /// This parameter is required when NluEngine is set to FUNCTION for the current scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>defaultTrigger</para>
                /// </summary>
                [NameInMap("HttpTriggerName")]
                [Validation(Required=false)]
                public string HttpTriggerName { get; set; }

                /// <summary>
                /// <para>The HTTP trigger URL.\
                /// This parameter is required when NluEngine is set to FUNCTION for the current scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://chat-xxxxx-v-yewiundukb.cn-hangzhou-xxx.run">http://chat-xxxxx-v-yewiundukb.cn-hangzhou-xxx.run</a></para>
                /// </summary>
                [NameInMap("HttpTriggerUrl")]
                [Validation(Required=false)]
                public string HttpTriggerUrl { get; set; }

                /// <summary>
                /// <para>The region where the function service resides.\
                /// This parameter is required when NluEngine is set to FUNCTION for the current scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>The conversation model.\
            /// This parameter is required when NluEngine is set to PROMPTS for the current scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The associated configuration.</para>
            /// </summary>
            [NameInMap("NluAccessProfile")]
            [Validation(Required=false)]
            public CreateScriptVersionRequestScriptProfileNluAccessProfile NluAccessProfile { get; set; }
            public class CreateScriptVersionRequestScriptProfileNluAccessProfile : TeaModel {
                /// <summary>
                /// <para>The third-party conversation model configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c2c9baae-9351-4c49-a8cb-6f24a83a8718</para>
                /// </summary>
                [NameInMap("AccessProfileId")]
                [Validation(Required=false)]
                public string AccessProfileId { get; set; }

            }

            /// <summary>
            /// <para>The conversation model invocation method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MANAGED</para>
            /// </summary>
            [NameInMap("NluAccessType")]
            [Validation(Required=false)]
            public string NluAccessType { get; set; }

            /// <summary>
            /// <para>Specifies whether the model is an Omni model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OmniModel")]
            [Validation(Required=false)]
            public bool? OmniModel { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>d7b8a210-1f2d-4c5b-8a63-01e4f3b7c9d2</para>
        /// </summary>
        [NameInMap("SourceVersionId")]
        [Validation(Required=false)]
        public string SourceVersionId { get; set; }

        /// <summary>
        /// <para>The TTS configuration.</para>
        /// </summary>
        [NameInMap("SynthesizerConfig")]
        [Validation(Required=false)]
        public CreateScriptVersionRequestSynthesizerConfig SynthesizerConfig { get; set; }
        public class CreateScriptVersionRequestSynthesizerConfig : TeaModel {
            /// <summary>
            /// <para>The TTS model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CosyVoice</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The associated configuration.</para>
            /// </summary>
            [NameInMap("NlsAccessProfile")]
            [Validation(Required=false)]
            public CreateScriptVersionRequestSynthesizerConfigNlsAccessProfile NlsAccessProfile { get; set; }
            public class CreateScriptVersionRequestSynthesizerConfigNlsAccessProfile : TeaModel {
                /// <summary>
                /// <para>The third-party voice configuration ID. This parameter is required when you use a third-party ASR service such as Doubao or iFLYTEK.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c2c9baae-9351-4c49-a8cb-6f24a83a8718</para>
                /// </summary>
                [NameInMap("AccessProfileId")]
                [Validation(Required=false)]
                public string AccessProfileId { get; set; }

            }

            /// <summary>
            /// <para>The TTS invocation method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MANAGED</para>
            /// </summary>
            [NameInMap("NlsAccessType")]
            [Validation(Required=false)]
            public string NlsAccessType { get; set; }

            /// <summary>
            /// <para>The TTS engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BAILIAN</para>
            /// </summary>
            [NameInMap("NlsEngine")]
            [Validation(Required=false)]
            public string NlsEngine { get; set; }

            /// <summary>
            /// <para>The pitch rate.\
            /// Valid values: -500 to 500.\
            /// Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PitchRate")]
            [Validation(Required=false)]
            public int? PitchRate { get; set; }

            /// <summary>
            /// <para>The TTS pronunciation correction list.</para>
            /// </summary>
            [NameInMap("PronRules")]
            [Validation(Required=false)]
            public List<CreateScriptVersionRequestSynthesizerConfigPronRules> PronRules { get; set; }
            public class CreateScriptVersionRequestSynthesizerConfigPronRules : TeaModel {
                /// <summary>
                /// <para>The commonly mispronounced word.</para>
                /// 
                /// <b>Example:</b>
                /// <para>还钱</para>
                /// </summary>
                [NameInMap("Pattern")]
                [Validation(Required=false)]
                public string Pattern { get; set; }

                /// <summary>
                /// <para>The homophone replacement word.</para>
                /// 
                /// <b>Example:</b>
                /// <para>环钱</para>
                /// </summary>
                [NameInMap("Replacement")]
                [Validation(Required=false)]
                public string Replacement { get; set; }

            }

            /// <summary>
            /// <para>The speech rate.\
            /// Valid values: -500 to 500.\
            /// Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SpeechRate")]
            [Validation(Required=false)]
            public int? SpeechRate { get; set; }

            /// <summary>
            /// <para>The voice speaker.</para>
            /// 
            /// <b>Example:</b>
            /// <para>longanyang</para>
            /// </summary>
            [NameInMap("Voice")]
            [Validation(Required=false)]
            public string Voice { get; set; }

            /// <summary>
            /// <para>The volume.\
            /// Valid values: 0 to 100.\
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
        /// <para>The ASR configuration.</para>
        /// </summary>
        [NameInMap("TranscriberConfig")]
        [Validation(Required=false)]
        public CreateScriptVersionRequestTranscriberConfig TranscriberConfig { get; set; }
        public class CreateScriptVersionRequestTranscriberConfig : TeaModel {
            [NameInMap("CorrectionRules")]
            [Validation(Required=false)]
            public List<CreateScriptVersionRequestTranscriberConfigCorrectionRules> CorrectionRules { get; set; }
            public class CreateScriptVersionRequestTranscriberConfigCorrectionRules : TeaModel {
                [NameInMap("Pattern")]
                [Validation(Required=false)]
                public string Pattern { get; set; }

                [NameInMap("Replacement")]
                [Validation(Required=false)]
                public string Replacement { get; set; }

            }

            /// <summary>
            /// <para>The custom language model ID for ASR.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cd97223f-42f2-4cd9-95af-e734e2fe1fe4</para>
            /// </summary>
            [NameInMap("CustomizationId")]
            [Validation(Required=false)]
            public string CustomizationId { get; set; }

            /// <summary>
            /// <para>The silence detection threshold. When the silence interval between speech segments exceeds x milliseconds, sentence segmentation is triggered (Voice Activity Detection, or VAD).</para>
            /// 
            /// <b>Example:</b>
            /// <para>700</para>
            /// </summary>
            [NameInMap("EndSilenceTimeout")]
            [Validation(Required=false)]
            public int? EndSilenceTimeout { get; set; }

            /// <summary>
            /// <para>The ASR model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Paraformer</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The associated configuration.</para>
            /// </summary>
            [NameInMap("NlsAccessProfile")]
            [Validation(Required=false)]
            public CreateScriptVersionRequestTranscriberConfigNlsAccessProfile NlsAccessProfile { get; set; }
            public class CreateScriptVersionRequestTranscriberConfigNlsAccessProfile : TeaModel {
                /// <summary>
                /// <para>The third-party voice configuration ID. This parameter is required when you use a third-party ASR service such as Doubao or iFLYTEK.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c2c9baae-9351-4c49-a8cb-6f24a83a8718</para>
                /// </summary>
                [NameInMap("AccessProfileId")]
                [Validation(Required=false)]
                public string AccessProfileId { get; set; }

            }

            /// <summary>
            /// <para>The ASR invocation method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MANAGED</para>
            /// </summary>
            [NameInMap("NlsAccessType")]
            [Validation(Required=false)]
            public string NlsAccessType { get; set; }

            /// <summary>
            /// <para>The ASR engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BAILIAN</para>
            /// </summary>
            [NameInMap("NlsEngine")]
            [Validation(Required=false)]
            public string NlsEngine { get; set; }

            /// <summary>
            /// <para>The noise threshold. Valid values: -100 to 100.</para>
            /// <para>A value closer to -100 increases the probability that noise is classified as speech.</para>
            /// <para>A value closer to +100 increases the probability that speech is classified as noise.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SpeechNoiseThreshold")]
            [Validation(Required=false)]
            public int? SpeechNoiseThreshold { get; set; }

            /// <summary>
            /// <para>The hot word list ID. You can obtain this ID from the hot word management page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cd97223f-42f2-4cd9-95af-e734e2fe1fe3</para>
            /// </summary>
            [NameInMap("VocabularyId")]
            [Validation(Required=false)]
            public string VocabularyId { get; set; }

        }

    }

}

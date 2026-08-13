// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class UpdateScriptVersionRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The interaction configuration.</para>
        /// </summary>
        [NameInMap("InteractionConfig")]
        [Validation(Required=false)]
        public UpdateScriptVersionRequestInteractionConfig InteractionConfig { get; set; }
        public class UpdateScriptVersionRequestInteractionConfig : TeaModel {
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
            /// <para>The barge-in configuration.</para>
            /// </summary>
            [NameInMap("BargeInConfig")]
            [Validation(Required=false)]
            public UpdateScriptVersionRequestInteractionConfigBargeInConfig BargeInConfig { get; set; }
            public class UpdateScriptVersionRequestInteractionConfigBargeInConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether barge-in is supported during the closing statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ClosingBargeInEnabled")]
                [Validation(Required=false)]
                public bool? ClosingBargeInEnabled { get; set; }

                /// <summary>
                /// <para>Specifies whether barge-in is supported during the conversation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("GlobalBargeInEnabled")]
                [Validation(Required=false)]
                public bool? GlobalBargeInEnabled { get; set; }

                /// <summary>
                /// <para>Specifies whether barge-in is supported during the opening greeting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("OpeningBargeInEnabled")]
                [Validation(Required=false)]
                public bool? OpeningBargeInEnabled { get; set; }

            }

            /// <summary>
            /// <para>The hang-up configuration.</para>
            /// </summary>
            [NameInMap("EndConversationConfig")]
            [Validation(Required=false)]
            public UpdateScriptVersionRequestInteractionConfigEndConversationConfig EndConversationConfig { get; set; }
            public class UpdateScriptVersionRequestInteractionConfigEndConversationConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether barge-in is supported during the delayed hang-up waiting period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("BargeInEnabled")]
                [Validation(Required=false)]
                public bool? BargeInEnabled { get; set; }

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
                /// <para>The special condition interception configuration.</para>
                /// </summary>
                [NameInMap("Triggers")]
                [Validation(Required=false)]
                public List<UpdateScriptVersionRequestInteractionConfigEndConversationConfigTriggers> Triggers { get; set; }
                public class UpdateScriptVersionRequestInteractionConfigEndConversationConfigTriggers : TeaModel {
                    /// <summary>
                    /// <para>The closing script to play when the turn limit is reached and hang-up is executed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Thank you for answering the call. Have a nice day. Goodbye!</para>
                    /// </summary>
                    [NameInMap("ClosingStatement")]
                    [Validation(Required=false)]
                    public string ClosingStatement { get; set; }

                    /// <summary>
                    /// <para>The list of custom interception keywords.</para>
                    /// </summary>
                    [NameInMap("Keywords")]
                    [Validation(Required=false)]
                    public List<string> Keywords { get; set; }

                    /// <summary>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>TurnLimit: maximum interaction turn limit check.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TurnLimit</para>
                    /// </summary>
                    [NameInMap("TriggerType")]
                    [Validation(Required=false)]
                    public string TriggerType { get; set; }

                    /// <summary>
                    /// <para>The maximum number of interaction turns before executing hang-up. Valid values: 0 to 100. A value of 0 indicates that the turn-limit hang-up is not enabled.</para>
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
            /// <para>The delay in milliseconds before playing audio after the call is connected.</para>
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
            public UpdateScriptVersionRequestInteractionConfigSilenceDetectionConfig SilenceDetectionConfig { get; set; }
            public class UpdateScriptVersionRequestInteractionConfigSilenceDetectionConfig : TeaModel {
                /// <summary>
                /// <para>The list of actions to perform during consecutive silence.</para>
                /// </summary>
                [NameInMap("FallbackControlParamsList")]
                [Validation(Required=false)]
                public List<UpdateScriptVersionRequestInteractionConfigSilenceDetectionConfigFallbackControlParamsList> FallbackControlParamsList { get; set; }
                public class UpdateScriptVersionRequestInteractionConfigSilenceDetectionConfigFallbackControlParamsList : TeaModel {
                    /// <summary>
                    /// <para>The action to perform during consecutive silence.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HangUp</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The number of consecutive silence rounds before hanging up.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("MaxRepeats")]
                [Validation(Required=false)]
                public int? MaxRepeats { get; set; }

                /// <summary>
                /// <para>The silence prompt.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description>Repeat the content of the previous conversation round</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Prompt")]
                [Validation(Required=false)]
                public string Prompt { get; set; }

                /// <summary>
                /// <para>The silence timeout period, in milliseconds. When the user remains silent for longer than the specified value, the silence timeout prompt is played. Valid range: 2000 to 10000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

            }

            /// <summary>
            /// <para>The transition phrase model configuration.</para>
            /// </summary>
            [NameInMap("TransitionConfig")]
            [Validation(Required=false)]
            public UpdateScriptVersionRequestInteractionConfigTransitionConfig TransitionConfig { get; set; }
            public class UpdateScriptVersionRequestInteractionConfigTransitionConfig : TeaModel {
                /// <summary>
                /// <para>The prompt for model-generated transition phrases.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Based on the user\&quot;s latest reply in the conversation history below, generate a brief transitional phrase for the customer service agent to naturally and smoothly connect the conversation. Requirements are as follows:</para>
                /// <ol>
                /// <item><description>Use colloquial expressions common in customer service scenarios, maintaining a natural, polite, and neutral tone......</description></item>
                /// </ol>
                /// </summary>
                [NameInMap("AiPhrasePrompt")]
                [Validation(Required=false)]
                public string AiPhrasePrompt { get; set; }

                /// <summary>
                /// <para>The list of fixed transition phrases.</para>
                /// </summary>
                [NameInMap("FixedPhraseList")]
                [Validation(Required=false)]
                public List<string> FixedPhraseList { get; set; }

                /// <summary>
                /// <para>The method for generating transition phrases.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aiGenerated</para>
                /// </summary>
                [NameInMap("PhraseSource")]
                [Validation(Required=false)]
                public string PhraseSource { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable transition phrases.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("TransitionSwitch")]
                [Validation(Required=false)]
                public bool? TransitionSwitch { get; set; }

            }

        }

        /// <summary>
        /// <para>The label configurations.</para>
        /// </summary>
        [NameInMap("LabelConfigs")]
        [Validation(Required=false)]
        public List<UpdateScriptVersionRequestLabelConfigs> LabelConfigs { get; set; }
        public class UpdateScriptVersionRequestLabelConfigs : TeaModel {
            /// <summary>
            /// <para>The candidate values for the label.</para>
            /// </summary>
            [NameInMap("CandidateValues")]
            [Validation(Required=false)]
            public List<string> CandidateValues { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Describes whether the user is satisfied with this service</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The label name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Satisfaction</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The scenario ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b15</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The dialogue capability configuration.</para>
        /// </summary>
        [NameInMap("ScriptProfile")]
        [Validation(Required=false)]
        public UpdateScriptVersionRequestScriptProfile ScriptProfile { get; set; }
        public class UpdateScriptVersionRequestScriptProfile : TeaModel {
            /// <summary>
            /// <para>The chatbot AgentKey.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1309723684579735_p_beebot_public</para>
            /// </summary>
            [NameInMap("AgentKey")]
            [Validation(Required=false)]
            public string AgentKey { get; set; }

            /// <summary>
            /// <para>The dialogue agent configuration.</para>
            /// </summary>
            [NameInMap("AgentProfile")]
            [Validation(Required=false)]
            public UpdateScriptVersionRequestScriptProfileAgentProfile AgentProfile { get; set; }
            public class UpdateScriptVersionRequestScriptProfileAgentProfile : TeaModel {
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
                /// <para>OUTBOUND_BOT_PROMPTS_DEFAULT</para>
                /// </summary>
                [NameInMap("ScriptProfileTemplateId")]
                [Validation(Required=false)]
                public string ScriptProfileTemplateId { get; set; }

            }

            /// <summary>
            /// <para>The chatbot type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LITE</para>
            /// </summary>
            [NameInMap("BuilderType")]
            [Validation(Required=false)]
            public string BuilderType { get; set; }

            /// <summary>
            /// <para>The chatbot ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chatbot-cn-MQuyjjb666</para>
            /// </summary>
            [NameInMap("ChatbotId")]
            [Validation(Required=false)]
            public string ChatbotId { get; set; }

            /// <summary>
            /// <para>The function compute configuration.</para>
            /// </summary>
            [NameInMap("FunctionMeta")]
            [Validation(Required=false)]
            public UpdateScriptVersionRequestScriptProfileFunctionMeta FunctionMeta { get; set; }
            public class UpdateScriptVersionRequestScriptProfileFunctionMeta : TeaModel {
                /// <summary>
                /// <para>The function service ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9b752bbb-805a-4d3e-9013-eab5555c3fef</para>
                /// </summary>
                [NameInMap("FunctionId")]
                [Validation(Required=false)]
                public string FunctionId { get; set; }

                /// <summary>
                /// <para>The function service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my_funciton</para>
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                /// <summary>
                /// <para>The function trigger name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>defaultTrigger</para>
                /// </summary>
                [NameInMap("HttpTriggerName")]
                [Validation(Required=false)]
                public string HttpTriggerName { get; set; }

                /// <summary>
                /// <para>The function trigger URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://chat-xxxxx-v-yewiundukb.cn-hangzhou-xxx.run">http://chat-xxxxx-v-yewiundukb.cn-hangzhou-xxx.run</a></para>
                /// </summary>
                [NameInMap("HttpTriggerUrl")]
                [Validation(Required=false)]
                public string HttpTriggerUrl { get; set; }

                /// <summary>
                /// <para>The region where the function service resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>The dialogue model.</para>
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
            public UpdateScriptVersionRequestScriptProfileNluAccessProfile NluAccessProfile { get; set; }
            public class UpdateScriptVersionRequestScriptProfileNluAccessProfile : TeaModel {
                /// <summary>
                /// <para>The third-party dialogue model configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c2c9baae-9351-4c49-a8cb-6f24a83a8718</para>
                /// </summary>
                [NameInMap("AccessProfileId")]
                [Validation(Required=false)]
                public string AccessProfileId { get; set; }

            }

            /// <summary>
            /// <para>The dialogue model invocation method.</para>
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
        /// <para>The TTS configuration.</para>
        /// </summary>
        [NameInMap("SynthesizerConfig")]
        [Validation(Required=false)]
        public UpdateScriptVersionRequestSynthesizerConfig SynthesizerConfig { get; set; }
        public class UpdateScriptVersionRequestSynthesizerConfig : TeaModel {
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
            public UpdateScriptVersionRequestSynthesizerConfigNlsAccessProfile NlsAccessProfile { get; set; }
            public class UpdateScriptVersionRequestSynthesizerConfigNlsAccessProfile : TeaModel {
                /// <summary>
                /// <para>The third-party speech configuration ID. This parameter is required when you use a third-party ASR service such as Doubao or iFLYTEK.</para>
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
            /// <para>The pitch rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PitchRate")]
            [Validation(Required=false)]
            public int? PitchRate { get; set; }

            /// <summary>
            /// <para>The TTS correction dictionary.</para>
            /// </summary>
            [NameInMap("PronRules")]
            [Validation(Required=false)]
            public List<UpdateScriptVersionRequestSynthesizerConfigPronRules> PronRules { get; set; }
            public class UpdateScriptVersionRequestSynthesizerConfigPronRules : TeaModel {
                /// <summary>
                /// <para>The easily mispronounced word or phrase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>还钱</para>
                /// </summary>
                [NameInMap("Pattern")]
                [Validation(Required=false)]
                public string Pattern { get; set; }

                /// <summary>
                /// <para>The homophonic word or phrase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>环钱</para>
                /// </summary>
                [NameInMap("Replacement")]
                [Validation(Required=false)]
                public string Replacement { get; set; }

            }

            /// <summary>
            /// <para>The speech rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SpeechRate")]
            [Validation(Required=false)]
            public int? SpeechRate { get; set; }

            /// <summary>
            /// <para>The voice.</para>
            /// 
            /// <b>Example:</b>
            /// <para>longanyang</para>
            /// </summary>
            [NameInMap("Voice")]
            [Validation(Required=false)]
            public string Voice { get; set; }

            /// <summary>
            /// <para>The volume.</para>
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
        public UpdateScriptVersionRequestTranscriberConfig TranscriberConfig { get; set; }
        public class UpdateScriptVersionRequestTranscriberConfig : TeaModel {
            /// <summary>
            /// <para>The ASR correction dictionary.</para>
            /// </summary>
            [NameInMap("CorrectionRules")]
            [Validation(Required=false)]
            public List<UpdateScriptVersionRequestTranscriberConfigCorrectionRules> CorrectionRules { get; set; }
            public class UpdateScriptVersionRequestTranscriberConfigCorrectionRules : TeaModel {
                /// <summary>
                /// <para>The incorrectly recognized text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Aliabba</para>
                /// </summary>
                [NameInMap("Pattern")]
                [Validation(Required=false)]
                public string Pattern { get; set; }

                /// <summary>
                /// <para>The corrected text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba</para>
                /// </summary>
                [NameInMap("Replacement")]
                [Validation(Required=false)]
                public string Replacement { get; set; }

            }

            /// <summary>
            /// <para>The custom language model ID for ASR.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cd97223f-42f2-4cd9-95af-e734e2fe1472</para>
            /// </summary>
            [NameInMap("CustomizationId")]
            [Validation(Required=false)]
            public string CustomizationId { get; set; }

            /// <summary>
            /// <para>The silence detection threshold. Sentence segmentation is triggered when the speaking interval exceeds x milliseconds, also known as Voice Activity Detection (VAD).</para>
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
            public UpdateScriptVersionRequestTranscriberConfigNlsAccessProfile NlsAccessProfile { get; set; }
            public class UpdateScriptVersionRequestTranscriberConfigNlsAccessProfile : TeaModel {
                /// <summary>
                /// <para>The third-party speech configuration ID. This parameter is required when you use a third-party ASR service such as Doubao or iFLYTEK.</para>
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
            /// <para>A value closer to -100 increases the probability that noise is recognized as speech.</para>
            /// <para>A value closer to +100 increases the probability that speech is recognized as noise.</para>
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

        /// <summary>
        /// <para>The version ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b26</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}

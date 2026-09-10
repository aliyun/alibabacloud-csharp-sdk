// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianVoiceBot20250101.Models
{
    public class CreateApplicationVersionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BusinessUnitId")]
        [Validation(Required=false)]
        public string BusinessUnitId { get; set; }

        [NameInMap("InteractionConfig")]
        [Validation(Required=false)]
        public CreateApplicationVersionRequestInteractionConfig InteractionConfig { get; set; }
        public class CreateApplicationVersionRequestInteractionConfig : TeaModel {
            [NameInMap("BackgroundMusicId")]
            [Validation(Required=false)]
            public string BackgroundMusicId { get; set; }

            [NameInMap("EndConversationConfig")]
            [Validation(Required=false)]
            public CreateApplicationVersionRequestInteractionConfigEndConversationConfig EndConversationConfig { get; set; }
            public class CreateApplicationVersionRequestInteractionConfigEndConversationConfig : TeaModel {
                [NameInMap("Delay")]
                [Validation(Required=false)]
                public int? Delay { get; set; }

                [NameInMap("Triggers")]
                [Validation(Required=false)]
                public List<CreateApplicationVersionRequestInteractionConfigEndConversationConfigTriggers> Triggers { get; set; }
                public class CreateApplicationVersionRequestInteractionConfigEndConversationConfigTriggers : TeaModel {
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

            [NameInMap("InitialGreetingDelayMilliseconds")]
            [Validation(Required=false)]
            public int? InitialGreetingDelayMilliseconds { get; set; }

            [NameInMap("SilenceDetectionConfig")]
            [Validation(Required=false)]
            public CreateApplicationVersionRequestInteractionConfigSilenceDetectionConfig SilenceDetectionConfig { get; set; }
            public class CreateApplicationVersionRequestInteractionConfigSilenceDetectionConfig : TeaModel {
                [NameInMap("MaxRepeats")]
                [Validation(Required=false)]
                public int? MaxRepeats { get; set; }

                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

            }

        }

        [NameInMap("LabelConfig")]
        [Validation(Required=false)]
        public List<CreateApplicationVersionRequestLabelConfig> LabelConfig { get; set; }
        public class CreateApplicationVersionRequestLabelConfig : TeaModel {
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

        [NameInMap("RagConfig")]
        [Validation(Required=false)]
        public CreateApplicationVersionRequestRagConfig RagConfig { get; set; }
        public class CreateApplicationVersionRequestRagConfig : TeaModel {
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("KnowledgeBaseIds")]
            [Validation(Required=false)]
            public List<string> KnowledgeBaseIds { get; set; }

            [NameInMap("MaxContentLength")]
            [Validation(Required=false)]
            public int? MaxContentLength { get; set; }

            [NameInMap("RagEngine")]
            [Validation(Required=false)]
            public string RagEngine { get; set; }

            [NameInMap("TopN")]
            [Validation(Required=false)]
            public int? TopN { get; set; }

        }

        [NameInMap("ScriptProfile")]
        [Validation(Required=false)]
        public CreateApplicationVersionRequestScriptProfile ScriptProfile { get; set; }
        public class CreateApplicationVersionRequestScriptProfile : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>6f444ecf21d94238b516735916c98666</para>
            /// </summary>
            [NameInMap("AgentKey")]
            [Validation(Required=false)]
            public string AgentKey { get; set; }

            [NameInMap("AgentProfile")]
            [Validation(Required=false)]
            public CreateApplicationVersionRequestScriptProfileAgentProfile AgentProfile { get; set; }
            public class CreateApplicationVersionRequestScriptProfileAgentProfile : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PromptsJson")]
                [Validation(Required=false)]
                public string PromptsJson { get; set; }

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
            public CreateApplicationVersionRequestScriptProfileFunctionMeta FunctionMeta { get; set; }
            public class CreateApplicationVersionRequestScriptProfileFunctionMeta : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>9b752bbb-805a-4d3e-9013-eab5555c3fef</para>
                /// </summary>
                [NameInMap("FunctionId")]
                [Validation(Required=false)]
                public string FunctionId { get; set; }

                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

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

            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            [NameInMap("NluAccessProfile")]
            [Validation(Required=false)]
            public CreateApplicationVersionRequestScriptProfileNluAccessProfile NluAccessProfile { get; set; }
            public class CreateApplicationVersionRequestScriptProfileNluAccessProfile : TeaModel {
                [NameInMap("AccessProfileId")]
                [Validation(Required=false)]
                public string AccessProfileId { get; set; }

            }

            [NameInMap("NluAccessType")]
            [Validation(Required=false)]
            public string NluAccessType { get; set; }

            [NameInMap("OmniModel")]
            [Validation(Required=false)]
            public bool? OmniModel { get; set; }

        }

        [NameInMap("SourceVersionId")]
        [Validation(Required=false)]
        public string SourceVersionId { get; set; }

        [NameInMap("SynthesizerConfig")]
        [Validation(Required=false)]
        public CreateApplicationVersionRequestSynthesizerConfig SynthesizerConfig { get; set; }
        public class CreateApplicationVersionRequestSynthesizerConfig : TeaModel {
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            [NameInMap("NlsAccessProfile")]
            [Validation(Required=false)]
            public CreateApplicationVersionRequestSynthesizerConfigNlsAccessProfile NlsAccessProfile { get; set; }
            public class CreateApplicationVersionRequestSynthesizerConfigNlsAccessProfile : TeaModel {
                [NameInMap("AccessProfileId")]
                [Validation(Required=false)]
                public string AccessProfileId { get; set; }

            }

            [NameInMap("NlsAccessType")]
            [Validation(Required=false)]
            public string NlsAccessType { get; set; }

            [NameInMap("NlsEngine")]
            [Validation(Required=false)]
            public string NlsEngine { get; set; }

            [NameInMap("PitchRate")]
            [Validation(Required=false)]
            public int? PitchRate { get; set; }

            [NameInMap("PronRules")]
            [Validation(Required=false)]
            public List<CreateApplicationVersionRequestSynthesizerConfigPronRules> PronRules { get; set; }
            public class CreateApplicationVersionRequestSynthesizerConfigPronRules : TeaModel {
                [NameInMap("Pattern")]
                [Validation(Required=false)]
                public string Pattern { get; set; }

                [NameInMap("Replacement")]
                [Validation(Required=false)]
                public string Replacement { get; set; }

            }

            [NameInMap("SpeechRate")]
            [Validation(Required=false)]
            public int? SpeechRate { get; set; }

            [NameInMap("Voice")]
            [Validation(Required=false)]
            public string Voice { get; set; }

            [NameInMap("Volume")]
            [Validation(Required=false)]
            public int? Volume { get; set; }

        }

        [NameInMap("ToolConfig")]
        [Validation(Required=false)]
        public CreateApplicationVersionRequestToolConfig ToolConfig { get; set; }
        public class CreateApplicationVersionRequestToolConfig : TeaModel {
            [NameInMap("McpServers")]
            [Validation(Required=false)]
            public List<CreateApplicationVersionRequestToolConfigMcpServers> McpServers { get; set; }
            public class CreateApplicationVersionRequestToolConfigMcpServers : TeaModel {
                [NameInMap("BaseUrl")]
                [Validation(Required=false)]
                public string BaseUrl { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("SseEndpoint")]
                [Validation(Required=false)]
                public string SseEndpoint { get; set; }

            }

        }

        [NameInMap("TranscriberConfig")]
        [Validation(Required=false)]
        public CreateApplicationVersionRequestTranscriberConfig TranscriberConfig { get; set; }
        public class CreateApplicationVersionRequestTranscriberConfig : TeaModel {
            [NameInMap("CorrectionRules")]
            [Validation(Required=false)]
            public List<CreateApplicationVersionRequestTranscriberConfigCorrectionRules> CorrectionRules { get; set; }
            public class CreateApplicationVersionRequestTranscriberConfigCorrectionRules : TeaModel {
                [NameInMap("Pattern")]
                [Validation(Required=false)]
                public string Pattern { get; set; }

                [NameInMap("Replacement")]
                [Validation(Required=false)]
                public string Replacement { get; set; }

            }

            [NameInMap("CustomizationId")]
            [Validation(Required=false)]
            public string CustomizationId { get; set; }

            [NameInMap("EndSilenceTimeout")]
            [Validation(Required=false)]
            public int? EndSilenceTimeout { get; set; }

            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            [NameInMap("NlsAccessProfile")]
            [Validation(Required=false)]
            public CreateApplicationVersionRequestTranscriberConfigNlsAccessProfile NlsAccessProfile { get; set; }
            public class CreateApplicationVersionRequestTranscriberConfigNlsAccessProfile : TeaModel {
                [NameInMap("AccessProfileId")]
                [Validation(Required=false)]
                public string AccessProfileId { get; set; }

            }

            [NameInMap("NlsAccessType")]
            [Validation(Required=false)]
            public string NlsAccessType { get; set; }

            [NameInMap("NlsEngine")]
            [Validation(Required=false)]
            public string NlsEngine { get; set; }

            [NameInMap("SpeechNoiseThreshold")]
            [Validation(Required=false)]
            public int? SpeechNoiseThreshold { get; set; }

            [NameInMap("VocabularyId")]
            [Validation(Required=false)]
            public string VocabularyId { get; set; }

        }

    }

}

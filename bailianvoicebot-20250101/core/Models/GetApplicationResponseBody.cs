// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianVoiceBot20250101.Models
{
    public class GetApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetApplicationResponseBodyData Data { get; set; }
        public class GetApplicationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a395011f-a247-400f-bc69-28796749fd52</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The call concurrency, which is the number of calls being made simultaneously.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public int? Concurrency { get; set; }

            /// <summary>
            /// <para>The time when the application was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1730081561000</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The application description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Describe this application</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The draft version configuration content.</para>
            /// </summary>
            [NameInMap("DraftVersion")]
            [Validation(Required=false)]
            public GetApplicationResponseBodyDataDraftVersion DraftVersion { get; set; }
            public class GetApplicationResponseBodyDataDraftVersion : TeaModel {
                /// <summary>
                /// <para>The interaction configuration.</para>
                /// </summary>
                [NameInMap("InteractionConfig")]
                [Validation(Required=false)]
                public GetApplicationResponseBodyDataDraftVersionInteractionConfig InteractionConfig { get; set; }
                public class GetApplicationResponseBodyDataDraftVersionInteractionConfig : TeaModel {
                    [NameInMap("BackgroundMusicId")]
                    [Validation(Required=false)]
                    public string BackgroundMusicId { get; set; }

                    [NameInMap("EndConversationConfig")]
                    [Validation(Required=false)]
                    public GetApplicationResponseBodyDataDraftVersionInteractionConfigEndConversationConfig EndConversationConfig { get; set; }
                    public class GetApplicationResponseBodyDataDraftVersionInteractionConfigEndConversationConfig : TeaModel {
                        [NameInMap("Delay")]
                        [Validation(Required=false)]
                        public int? Delay { get; set; }

                        [NameInMap("Triggers")]
                        [Validation(Required=false)]
                        public List<GetApplicationResponseBodyDataDraftVersionInteractionConfigEndConversationConfigTriggers> Triggers { get; set; }
                        public class GetApplicationResponseBodyDataDraftVersionInteractionConfigEndConversationConfigTriggers : TeaModel {
                            [NameInMap("ClosingStatement")]
                            [Validation(Required=false)]
                            public string ClosingStatement { get; set; }

                            [NameInMap("KeyWords")]
                            [Validation(Required=false)]
                            public List<string> KeyWords { get; set; }

                            [NameInMap("TriggerType")]
                            [Validation(Required=false)]
                            public string TriggerType { get; set; }

                            [NameInMap("TurnLimit")]
                            [Validation(Required=false)]
                            public int? TurnLimit { get; set; }

                        }

                    }

                    [NameInMap("InitialGreetingDelayMilliseconds")]
                    [Validation(Required=false)]
                    public int? InitialGreetingDelayMilliseconds { get; set; }

                    /// <summary>
                    /// <para>The silence detection configuration.</para>
                    /// </summary>
                    [NameInMap("SilenceDetectionConfig")]
                    [Validation(Required=false)]
                    public GetApplicationResponseBodyDataDraftVersionInteractionConfigSilenceDetectionConfig SilenceDetectionConfig { get; set; }
                    public class GetApplicationResponseBodyDataDraftVersionInteractionConfigSilenceDetectionConfig : TeaModel {
                        [NameInMap("MaxRepeats")]
                        [Validation(Required=false)]
                        public int? MaxRepeats { get; set; }

                        /// <summary>
                        /// <para>The task execution timeout period, in seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public int? Timeout { get; set; }

                    }

                }

                [NameInMap("LabelConfig")]
                [Validation(Required=false)]
                public List<GetApplicationResponseBodyDataDraftVersionLabelConfig> LabelConfig { get; set; }
                public class GetApplicationResponseBodyDataDraftVersionLabelConfig : TeaModel {
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
                /// <para>The RAG configuration.</para>
                /// </summary>
                [NameInMap("RagConfig")]
                [Validation(Required=false)]
                public GetApplicationResponseBodyDataDraftVersionRagConfig RagConfig { get; set; }
                public class GetApplicationResponseBodyDataDraftVersionRagConfig : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether RAG is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The list of knowledge base IDs.</para>
                    /// </summary>
                    [NameInMap("KnowledgeBaseIds")]
                    [Validation(Required=false)]
                    public List<string> KnowledgeBaseIds { get; set; }

                    /// <summary>
                    /// <para>The maximum concatenation length of RAG content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("MaxContentLength")]
                    [Validation(Required=false)]
                    public int? MaxContentLength { get; set; }

                    /// <summary>
                    /// <para>The RAG engine.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BAILIAN</para>
                    /// </summary>
                    [NameInMap("RagEngine")]
                    [Validation(Required=false)]
                    public string RagEngine { get; set; }

                    /// <summary>
                    /// <para>The maximum number of data entries to retrieve.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("TopN")]
                    [Validation(Required=false)]
                    public int? TopN { get; set; }

                }

                /// <summary>
                /// <para>The application model configuration.</para>
                /// </summary>
                [NameInMap("ScriptProfile")]
                [Validation(Required=false)]
                public GetApplicationResponseBodyDataDraftVersionScriptProfile ScriptProfile { get; set; }
                public class GetApplicationResponseBodyDataDraftVersionScriptProfile : TeaModel {
                    [NameInMap("AgentKey")]
                    [Validation(Required=false)]
                    public string AgentKey { get; set; }

                    /// <summary>
                    /// <para>The agent configuration information.</para>
                    /// </summary>
                    [NameInMap("AgentProfile")]
                    [Validation(Required=false)]
                    public GetApplicationResponseBodyDataDraftVersionScriptProfileAgentProfile AgentProfile { get; set; }
                    public class GetApplicationResponseBodyDataDraftVersionScriptProfileAgentProfile : TeaModel {
                        /// <summary>
                        /// <para>The agent configuration ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>6a50b67072d44788951de29758432d94</para>
                        /// </summary>
                        [NameInMap("AgentProfileId")]
                        [Validation(Required=false)]
                        public string AgentProfileId { get; set; }

                        /// <summary>
                        /// <para>The agent description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Chatbot</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The prompt in JSON format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;prompts&quot;:&quot;I am a chatbot.&quot;}</para>
                        /// </summary>
                        [NameInMap("PromptsJson")]
                        [Validation(Required=false)]
                        public string PromptsJson { get; set; }

                        /// <summary>
                        /// <para>The application template ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SFM_PROMPTS_DEFAULT</para>
                        /// </summary>
                        [NameInMap("ScriptProfileTemplateId")]
                        [Validation(Required=false)]
                        public string ScriptProfileTemplateId { get; set; }

                    }

                    [NameInMap("ChatbotId")]
                    [Validation(Required=false)]
                    public string ChatbotId { get; set; }

                    [NameInMap("FunctionMeta")]
                    [Validation(Required=false)]
                    public GetApplicationResponseBodyDataDraftVersionScriptProfileFunctionMeta FunctionMeta { get; set; }
                    public class GetApplicationResponseBodyDataDraftVersionScriptProfileFunctionMeta : TeaModel {
                        [NameInMap("FunctionId")]
                        [Validation(Required=false)]
                        public string FunctionId { get; set; }

                        [NameInMap("FunctionName")]
                        [Validation(Required=false)]
                        public string FunctionName { get; set; }

                        [NameInMap("HttpTriggerName")]
                        [Validation(Required=false)]
                        public string HttpTriggerName { get; set; }

                        [NameInMap("HttpTriggerUrl")]
                        [Validation(Required=false)]
                        public string HttpTriggerUrl { get; set; }

                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                    }

                    /// <summary>
                    /// <para>The model.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>qwen-plus</para>
                    /// </summary>
                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    [NameInMap("NluAccessProfile")]
                    [Validation(Required=false)]
                    public GetApplicationResponseBodyDataDraftVersionScriptProfileNluAccessProfile NluAccessProfile { get; set; }
                    public class GetApplicationResponseBodyDataDraftVersionScriptProfileNluAccessProfile : TeaModel {
                        [NameInMap("AccessProfileId")]
                        [Validation(Required=false)]
                        public string AccessProfileId { get; set; }

                    }

                    [NameInMap("NluAccessType")]
                    [Validation(Required=false)]
                    public string NluAccessType { get; set; }

                    [NameInMap("NluEngine")]
                    [Validation(Required=false)]
                    public string NluEngine { get; set; }

                    [NameInMap("OmniModel")]
                    [Validation(Required=false)]
                    public bool? OmniModel { get; set; }

                    /// <summary>
                    /// <para>The probability threshold for nucleus sampling during generation.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>For example, when the value is set to 0.8, only the smallest set of most likely tokens whose cumulative probability is greater than or equal to 0.8 is retained as the candidate set.<list type="bullet">
                    /// <item><description>Valid values: (0, 1.0). A higher value increases randomness in generation. A lower value increases determinism in generation.</description></item>
                    /// </list>
                    /// </description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.8</para>
                    /// </summary>
                    [NameInMap("Temperature")]
                    [Validation(Required=false)]
                    public string Temperature { get; set; }

                    /// <summary>
                    /// <para>Controls the randomness and diversity of model responses.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Specifically, the temperature value controls the degree of smoothing applied to the probability distribution of each candidate token during text generation. A higher temperature value flattens the probability distribution, allowing more low-probability tokens to be selected, which produces more diverse results. A lower temperature value sharpens the probability distribution, making high-probability tokens more likely to be selected, which produces more deterministic results.</description></item>
                    /// <item><description>Valid values: [0, 2). Setting the value to 0 is not recommended because it is meaningless.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.1</para>
                    /// </summary>
                    [NameInMap("TopP")]
                    [Validation(Required=false)]
                    public string TopP { get; set; }

                }

                /// <summary>
                /// <para>The text-to-speech (TTS) configuration.</para>
                /// </summary>
                [NameInMap("SynthesizerConfig")]
                [Validation(Required=false)]
                public GetApplicationResponseBodyDataDraftVersionSynthesizerConfig SynthesizerConfig { get; set; }
                public class GetApplicationResponseBodyDataDraftVersionSynthesizerConfig : TeaModel {
                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    [NameInMap("NlsAccessProfile")]
                    [Validation(Required=false)]
                    public GetApplicationResponseBodyDataDraftVersionSynthesizerConfigNlsAccessProfile NlsAccessProfile { get; set; }
                    public class GetApplicationResponseBodyDataDraftVersionSynthesizerConfigNlsAccessProfile : TeaModel {
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
                    /// <para>ALIYUN</para>
                    /// </summary>
                    [NameInMap("NlsEngine")]
                    [Validation(Required=false)]
                    public string NlsEngine { get; set; }

                    /// <summary>
                    /// <para>The pitch rate.</para>
                    /// <remarks>
                    /// <para>Valid values: -500 to 500.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("PitchRate")]
                    [Validation(Required=false)]
                    public int? PitchRate { get; set; }

                    [NameInMap("PronRules")]
                    [Validation(Required=false)]
                    public List<GetApplicationResponseBodyDataDraftVersionSynthesizerConfigPronRules> PronRules { get; set; }
                    public class GetApplicationResponseBodyDataDraftVersionSynthesizerConfigPronRules : TeaModel {
                        [NameInMap("Pattern")]
                        [Validation(Required=false)]
                        public string Pattern { get; set; }

                        [NameInMap("Replacement")]
                        [Validation(Required=false)]
                        public string Replacement { get; set; }

                    }

                    /// <summary>
                    /// <para>The speech rate.</para>
                    /// <remarks>
                    /// <para>Valid values: -500 to 500.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SpeechRate")]
                    [Validation(Required=false)]
                    public int? SpeechRate { get; set; }

                    /// <summary>
                    /// <para>The voice.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aixia</para>
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
                /// <para>The tool configuration.</para>
                /// </summary>
                [NameInMap("ToolConfig")]
                [Validation(Required=false)]
                public GetApplicationResponseBodyDataDraftVersionToolConfig ToolConfig { get; set; }
                public class GetApplicationResponseBodyDataDraftVersionToolConfig : TeaModel {
                    /// <summary>
                    /// <para>The list of MCP server configurations.</para>
                    /// </summary>
                    [NameInMap("McpServers")]
                    [Validation(Required=false)]
                    public List<GetApplicationResponseBodyDataDraftVersionToolConfigMcpServers> McpServers { get; set; }
                    public class GetApplicationResponseBodyDataDraftVersionToolConfigMcpServers : TeaModel {
                        /// <summary>
                        /// <para>The base URL.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://example.com">https://example.com</a></para>
                        /// </summary>
                        [NameInMap("BaseUrl")]
                        [Validation(Required=false)]
                        public string BaseUrl { get; set; }

                        /// <summary>
                        /// <para>The name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>phone-ai-call</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The SSE endpoint.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/phone-ai-call/mcp/sse?key=value</para>
                        /// </summary>
                        [NameInMap("SseEndpoint")]
                        [Validation(Required=false)]
                        public string SseEndpoint { get; set; }

                    }

                }

                /// <summary>
                /// <para>The automatic speech recognition (ASR) configuration.</para>
                /// </summary>
                [NameInMap("TranscriberConfig")]
                [Validation(Required=false)]
                public GetApplicationResponseBodyDataDraftVersionTranscriberConfig TranscriberConfig { get; set; }
                public class GetApplicationResponseBodyDataDraftVersionTranscriberConfig : TeaModel {
                    [NameInMap("CorrectionRules")]
                    [Validation(Required=false)]
                    public List<GetApplicationResponseBodyDataDraftVersionTranscriberConfigCorrectionRules> CorrectionRules { get; set; }
                    public class GetApplicationResponseBodyDataDraftVersionTranscriberConfigCorrectionRules : TeaModel {
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
                    public GetApplicationResponseBodyDataDraftVersionTranscriberConfigNlsAccessProfile NlsAccessProfile { get; set; }
                    public class GetApplicationResponseBodyDataDraftVersionTranscriberConfigNlsAccessProfile : TeaModel {
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
                    /// <para>ALIYUN</para>
                    /// </summary>
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

                /// <summary>
                /// <para>The version ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>743219815472857088</para>
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test001</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The NLU access method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MANAGED</para>
            /// </summary>
            [NameInMap("NluAccessType")]
            [Validation(Required=false)]
            public string NluAccessType { get; set; }

            /// <summary>
            /// <para>The NLU engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROMPTS</para>
            /// </summary>
            [NameInMap("NluEngine")]
            [Validation(Required=false)]
            public string NluEngine { get; set; }

            /// <summary>
            /// <para>The published application version.</para>
            /// </summary>
            [NameInMap("PublishedVersion")]
            [Validation(Required=false)]
            public GetApplicationResponseBodyDataPublishedVersion PublishedVersion { get; set; }
            public class GetApplicationResponseBodyDataPublishedVersion : TeaModel {
                /// <summary>
                /// <para>The interaction configuration.</para>
                /// </summary>
                [NameInMap("InteractionConfig")]
                [Validation(Required=false)]
                public GetApplicationResponseBodyDataPublishedVersionInteractionConfig InteractionConfig { get; set; }
                public class GetApplicationResponseBodyDataPublishedVersionInteractionConfig : TeaModel {
                    [NameInMap("BackgroundMusicId")]
                    [Validation(Required=false)]
                    public string BackgroundMusicId { get; set; }

                    [NameInMap("EndConversationConfig")]
                    [Validation(Required=false)]
                    public GetApplicationResponseBodyDataPublishedVersionInteractionConfigEndConversationConfig EndConversationConfig { get; set; }
                    public class GetApplicationResponseBodyDataPublishedVersionInteractionConfigEndConversationConfig : TeaModel {
                        [NameInMap("Delay")]
                        [Validation(Required=false)]
                        public int? Delay { get; set; }

                        [NameInMap("Triggers")]
                        [Validation(Required=false)]
                        public List<GetApplicationResponseBodyDataPublishedVersionInteractionConfigEndConversationConfigTriggers> Triggers { get; set; }
                        public class GetApplicationResponseBodyDataPublishedVersionInteractionConfigEndConversationConfigTriggers : TeaModel {
                            [NameInMap("ClosingStatement")]
                            [Validation(Required=false)]
                            public string ClosingStatement { get; set; }

                            [NameInMap("KeyWords")]
                            [Validation(Required=false)]
                            public List<string> KeyWords { get; set; }

                            [NameInMap("TriggerType")]
                            [Validation(Required=false)]
                            public string TriggerType { get; set; }

                            [NameInMap("TurnLimit")]
                            [Validation(Required=false)]
                            public int? TurnLimit { get; set; }

                        }

                    }

                    [NameInMap("InitialGreetingDelayMilliseconds")]
                    [Validation(Required=false)]
                    public int? InitialGreetingDelayMilliseconds { get; set; }

                    /// <summary>
                    /// <para>The silence detection configuration.</para>
                    /// </summary>
                    [NameInMap("SilenceDetectionConfig")]
                    [Validation(Required=false)]
                    public GetApplicationResponseBodyDataPublishedVersionInteractionConfigSilenceDetectionConfig SilenceDetectionConfig { get; set; }
                    public class GetApplicationResponseBodyDataPublishedVersionInteractionConfigSilenceDetectionConfig : TeaModel {
                        [NameInMap("MaxRepeats")]
                        [Validation(Required=false)]
                        public int? MaxRepeats { get; set; }

                        /// <summary>
                        /// <para>The timeout period.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public int? Timeout { get; set; }

                    }

                }

                [NameInMap("LabelConfig")]
                [Validation(Required=false)]
                public List<GetApplicationResponseBodyDataPublishedVersionLabelConfig> LabelConfig { get; set; }
                public class GetApplicationResponseBodyDataPublishedVersionLabelConfig : TeaModel {
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
                /// <para>The RAG configuration.</para>
                /// </summary>
                [NameInMap("RagConfig")]
                [Validation(Required=false)]
                public GetApplicationResponseBodyDataPublishedVersionRagConfig RagConfig { get; set; }
                public class GetApplicationResponseBodyDataPublishedVersionRagConfig : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether RAG is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The list of knowledge base IDs.</para>
                    /// </summary>
                    [NameInMap("KnowledgeBaseIds")]
                    [Validation(Required=false)]
                    public List<string> KnowledgeBaseIds { get; set; }

                    /// <summary>
                    /// <para>The maximum concatenation length of RAG content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("MaxContentLength")]
                    [Validation(Required=false)]
                    public int? MaxContentLength { get; set; }

                    /// <summary>
                    /// <para>The RAG engine.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BAILIAN</para>
                    /// </summary>
                    [NameInMap("RagEngine")]
                    [Validation(Required=false)]
                    public string RagEngine { get; set; }

                    /// <summary>
                    /// <para>The maximum number of data entries to retrieve.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("TopN")]
                    [Validation(Required=false)]
                    public int? TopN { get; set; }

                }

                /// <summary>
                /// <para>The application model configuration.</para>
                /// </summary>
                [NameInMap("ScriptProfile")]
                [Validation(Required=false)]
                public GetApplicationResponseBodyDataPublishedVersionScriptProfile ScriptProfile { get; set; }
                public class GetApplicationResponseBodyDataPublishedVersionScriptProfile : TeaModel {
                    [NameInMap("AgentKey")]
                    [Validation(Required=false)]
                    public string AgentKey { get; set; }

                    /// <summary>
                    /// <para>The agent configuration information.</para>
                    /// </summary>
                    [NameInMap("AgentProfile")]
                    [Validation(Required=false)]
                    public GetApplicationResponseBodyDataPublishedVersionScriptProfileAgentProfile AgentProfile { get; set; }
                    public class GetApplicationResponseBodyDataPublishedVersionScriptProfileAgentProfile : TeaModel {
                        /// <summary>
                        /// <para>The agent configuration ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>b97b6822dd624c32b6c2a54d717db718</para>
                        /// </summary>
                        [NameInMap("AgentProfileId")]
                        [Validation(Required=false)]
                        public string AgentProfileId { get; set; }

                        /// <summary>
                        /// <para>The agent description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>I am a chatbot</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The prompt in JSON format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;prompts&quot;:&quot;I am a chatbot.&quot;}</para>
                        /// </summary>
                        [NameInMap("PromptsJson")]
                        [Validation(Required=false)]
                        public string PromptsJson { get; set; }

                        /// <summary>
                        /// <para>The agent configuration template ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SFM_PROMPTS_DEFAULT</para>
                        /// </summary>
                        [NameInMap("ScriptProfileTemplateId")]
                        [Validation(Required=false)]
                        public string ScriptProfileTemplateId { get; set; }

                    }

                    [NameInMap("ChatbotId")]
                    [Validation(Required=false)]
                    public string ChatbotId { get; set; }

                    [NameInMap("FunctionMeta")]
                    [Validation(Required=false)]
                    public GetApplicationResponseBodyDataPublishedVersionScriptProfileFunctionMeta FunctionMeta { get; set; }
                    public class GetApplicationResponseBodyDataPublishedVersionScriptProfileFunctionMeta : TeaModel {
                        [NameInMap("FunctionId")]
                        [Validation(Required=false)]
                        public string FunctionId { get; set; }

                        [NameInMap("FunctionName")]
                        [Validation(Required=false)]
                        public string FunctionName { get; set; }

                        [NameInMap("HttpTriggerName")]
                        [Validation(Required=false)]
                        public string HttpTriggerName { get; set; }

                        [NameInMap("HttpTriggerUrl")]
                        [Validation(Required=false)]
                        public string HttpTriggerUrl { get; set; }

                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                    }

                    /// <summary>
                    /// <para>The model.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>qwen-plus</para>
                    /// </summary>
                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    [NameInMap("NluAccessProfile")]
                    [Validation(Required=false)]
                    public GetApplicationResponseBodyDataPublishedVersionScriptProfileNluAccessProfile NluAccessProfile { get; set; }
                    public class GetApplicationResponseBodyDataPublishedVersionScriptProfileNluAccessProfile : TeaModel {
                        [NameInMap("AccessProfileId")]
                        [Validation(Required=false)]
                        public string AccessProfileId { get; set; }

                    }

                    [NameInMap("NluAccessType")]
                    [Validation(Required=false)]
                    public string NluAccessType { get; set; }

                    [NameInMap("NluEngine")]
                    [Validation(Required=false)]
                    public string NluEngine { get; set; }

                    [NameInMap("OmniModel")]
                    [Validation(Required=false)]
                    public bool? OmniModel { get; set; }

                    /// <summary>
                    /// <para>The probability threshold for nucleus sampling during generation.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>For example, when the value is set to 0.8, only the smallest set of most likely tokens whose cumulative probability is greater than or equal to 0.8 is retained as the candidate set.<list type="bullet">
                    /// <item><description>Valid values: (0, 1.0). A higher value increases randomness in generation. A lower value increases determinism in generation.</description></item>
                    /// </list>
                    /// </description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.8</para>
                    /// </summary>
                    [NameInMap("Temperature")]
                    [Validation(Required=false)]
                    public string Temperature { get; set; }

                    /// <summary>
                    /// <para>Controls the randomness and diversity of model responses.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Specifically, the temperature value controls the degree of smoothing applied to the probability distribution of each candidate token during text generation. A higher temperature value flattens the probability distribution, allowing more low-probability tokens to be selected, which produces more diverse results. A lower temperature value sharpens the probability distribution, making high-probability tokens more likely to be selected, which produces more deterministic results.</description></item>
                    /// <item><description>Valid values: [0, 2). Setting the value to 0 is not recommended because it is meaningless.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.1</para>
                    /// </summary>
                    [NameInMap("TopP")]
                    [Validation(Required=false)]
                    public string TopP { get; set; }

                }

                /// <summary>
                /// <para>The text-to-speech (TTS) configuration.</para>
                /// </summary>
                [NameInMap("SynthesizerConfig")]
                [Validation(Required=false)]
                public GetApplicationResponseBodyDataPublishedVersionSynthesizerConfig SynthesizerConfig { get; set; }
                public class GetApplicationResponseBodyDataPublishedVersionSynthesizerConfig : TeaModel {
                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    [NameInMap("NlsAccessProfile")]
                    [Validation(Required=false)]
                    public GetApplicationResponseBodyDataPublishedVersionSynthesizerConfigNlsAccessProfile NlsAccessProfile { get; set; }
                    public class GetApplicationResponseBodyDataPublishedVersionSynthesizerConfigNlsAccessProfile : TeaModel {
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
                    /// <para>ALIYUN</para>
                    /// </summary>
                    [NameInMap("NlsEngine")]
                    [Validation(Required=false)]
                    public string NlsEngine { get; set; }

                    /// <summary>
                    /// <para>The pitch rate.</para>
                    /// <remarks>
                    /// <para>Valid values: -500 to 500.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("PitchRate")]
                    [Validation(Required=false)]
                    public int? PitchRate { get; set; }

                    [NameInMap("PronRules")]
                    [Validation(Required=false)]
                    public List<GetApplicationResponseBodyDataPublishedVersionSynthesizerConfigPronRules> PronRules { get; set; }
                    public class GetApplicationResponseBodyDataPublishedVersionSynthesizerConfigPronRules : TeaModel {
                        [NameInMap("Pattern")]
                        [Validation(Required=false)]
                        public string Pattern { get; set; }

                        [NameInMap("Replacement")]
                        [Validation(Required=false)]
                        public string Replacement { get; set; }

                    }

                    /// <summary>
                    /// <para>The speech rate.</para>
                    /// <remarks>
                    /// <para>Valid values: -500 to 500.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-20</para>
                    /// </summary>
                    [NameInMap("SpeechRate")]
                    [Validation(Required=false)]
                    public int? SpeechRate { get; set; }

                    /// <summary>
                    /// <para>The voice.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aixia</para>
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
                /// <para>The tool configuration.</para>
                /// </summary>
                [NameInMap("ToolConfig")]
                [Validation(Required=false)]
                public GetApplicationResponseBodyDataPublishedVersionToolConfig ToolConfig { get; set; }
                public class GetApplicationResponseBodyDataPublishedVersionToolConfig : TeaModel {
                    /// <summary>
                    /// <para>The list of MCP server configurations.</para>
                    /// </summary>
                    [NameInMap("McpServers")]
                    [Validation(Required=false)]
                    public List<GetApplicationResponseBodyDataPublishedVersionToolConfigMcpServers> McpServers { get; set; }
                    public class GetApplicationResponseBodyDataPublishedVersionToolConfigMcpServers : TeaModel {
                        /// <summary>
                        /// <para>The base URL.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://example.com">https://example.com</a></para>
                        /// </summary>
                        [NameInMap("BaseUrl")]
                        [Validation(Required=false)]
                        public string BaseUrl { get; set; }

                        /// <summary>
                        /// <para>The name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>phone-ai-call</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The SSE endpoint.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/phone-ai-call/mcp/sse?key=value</para>
                        /// </summary>
                        [NameInMap("SseEndpoint")]
                        [Validation(Required=false)]
                        public string SseEndpoint { get; set; }

                    }

                }

                /// <summary>
                /// <para>The automatic speech recognition (ASR) configuration.</para>
                /// </summary>
                [NameInMap("TranscriberConfig")]
                [Validation(Required=false)]
                public GetApplicationResponseBodyDataPublishedVersionTranscriberConfig TranscriberConfig { get; set; }
                public class GetApplicationResponseBodyDataPublishedVersionTranscriberConfig : TeaModel {
                    [NameInMap("CorrectionRules")]
                    [Validation(Required=false)]
                    public List<GetApplicationResponseBodyDataPublishedVersionTranscriberConfigCorrectionRules> CorrectionRules { get; set; }
                    public class GetApplicationResponseBodyDataPublishedVersionTranscriberConfigCorrectionRules : TeaModel {
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
                    public GetApplicationResponseBodyDataPublishedVersionTranscriberConfigNlsAccessProfile NlsAccessProfile { get; set; }
                    public class GetApplicationResponseBodyDataPublishedVersionTranscriberConfigNlsAccessProfile : TeaModel {
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
                    /// <para>ALIYUN</para>
                    /// </summary>
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

                /// <summary>
                /// <para>The version ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47889c1f-dd3f-4ace-9587-a13a3563e678</para>
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the application was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1730081561000</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D771A1B6-3D5F-174A-BEE1-98CE1000D337</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

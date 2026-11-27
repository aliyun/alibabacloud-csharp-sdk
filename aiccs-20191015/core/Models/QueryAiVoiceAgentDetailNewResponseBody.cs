// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryAiVoiceAgentDetailNewResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason for the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The agent details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAiVoiceAgentDetailNewResponseBodyData Data { get; set; }
        public class QueryAiVoiceAgentDetailNewResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The voice configuration for intelligent outbound calls.</para>
            /// </summary>
            [NameInMap("AgentCallConfig")]
            [Validation(Required=false)]
            public QueryAiVoiceAgentDetailNewResponseBodyDataAgentCallConfig AgentCallConfig { get; set; }
            public class QueryAiVoiceAgentDetailNewResponseBodyDataAgentCallConfig : TeaModel {
                /// <summary>
                /// <para>The event configuration.</para>
                /// </summary>
                [NameInMap("EventConfig")]
                [Validation(Required=false)]
                public QueryAiVoiceAgentDetailNewResponseBodyDataAgentCallConfigEventConfig EventConfig { get; set; }
                public class QueryAiVoiceAgentDetailNewResponseBodyDataAgentCallConfigEventConfig : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to hang up when an AI answering assistant is detected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("CallAssistantHangup")]
                    [Validation(Required=false)]
                    public bool? CallAssistantHangup { get; set; }

                    /// <summary>
                    /// <para>Specifies whether AI answering assistant recognition is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("CallAssistantRecognize")]
                    [Validation(Required=false)]
                    public bool? CallAssistantRecognize { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the first mute event triggers the model.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("MuteActive")]
                    [Validation(Required=false)]
                    public bool? MuteActive { get; set; }

                    /// <summary>
                    /// <para>The mute duration in seconds. The minimum value is 3 and the maximum value is 15.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("MuteDuration")]
                    [Validation(Required=false)]
                    public long? MuteDuration { get; set; }

                    /// <summary>
                    /// <para>The number of consecutive mute events that trigger an automatic hang-up. The minimum value is 1 and the maximum value is 5.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MuteHangupNum")]
                    [Validation(Required=false)]
                    public long? MuteHangupNum { get; set; }

                    /// <summary>
                    /// <para>The maximum call duration in seconds. The minimum value is 600 and the maximum value is 3600. The call is automatically disconnected after a timeout.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("SessionTimeout")]
                    [Validation(Required=false)]
                    public long? SessionTimeout { get; set; }

                }

                /// <summary>
                /// <para>The opening remark.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hello, this is ******</para>
                /// </summary>
                [NameInMap("Prologue")]
                [Validation(Required=false)]
                public string Prologue { get; set; }

                /// <summary>
                /// <para>The URL of the audio file for the opening remark recording. This parameter has a value only when StartWordType is set to 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/oss-file-key</para>
                /// </summary>
                [NameInMap("RecordingFile")]
                [Validation(Required=false)]
                public string RecordingFile { get; set; }

                /// <summary>
                /// <para>The type of the opening remark. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Text.</description></item>
                /// <item><description>1: Recording.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StartWordType")]
                [Validation(Required=false)]
                public long? StartWordType { get; set; }

                /// <summary>
                /// <para>The agent transfer configuration.</para>
                /// </summary>
                [NameInMap("TransferConfig")]
                [Validation(Required=false)]
                public QueryAiVoiceAgentDetailNewResponseBodyDataAgentCallConfigTransferConfig TransferConfig { get; set; }
                public class QueryAiVoiceAgentDetailNewResponseBodyDataAgentCallConfigTransferConfig : TeaModel {
                    /// <summary>
                    /// <para>The called number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123111122222</para>
                    /// </summary>
                    [NameInMap("CalledNumber")]
                    [Validation(Required=false)]
                    public string CalledNumber { get; set; }

                    /// <summary>
                    /// <para>The calling number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123111122222</para>
                    /// </summary>
                    [NameInMap("CallerNumber")]
                    [Validation(Required=false)]
                    public string CallerNumber { get; set; }

                    /// <summary>
                    /// <para>The calling number type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>48</para>
                    /// </summary>
                    [NameInMap("CallerNumberType")]
                    [Validation(Required=false)]
                    public long? CallerNumberType { get; set; }

                    /// <summary>
                    /// <para>The answering party number, such as the user&quot;s mobile phone number, customer service agent number, or machine number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123111122222</para>
                    /// </summary>
                    [NameInMap("CallingNumber")]
                    [Validation(Required=false)]
                    public string CallingNumber { get; set; }

                    /// <summary>
                    /// <para>The called number type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CallingNumberType")]
                    [Validation(Required=false)]
                    public long? CallingNumberType { get; set; }

                    /// <summary>
                    /// <para>The customer route code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("CustomerRouteCode")]
                    [Validation(Required=false)]
                    public string CustomerRouteCode { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the feature is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The supplementary information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Additional information for the agent</para>
                    /// </summary>
                    [NameInMap("ExtraInfo")]
                    [Validation(Required=false)]
                    public string ExtraInfo { get; set; }

                    /// <summary>
                    /// <para>The prompt message for a failed transfer to a human agent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Failure description</para>
                    /// </summary>
                    [NameInMap("FailureContent")]
                    [Validation(Required=false)]
                    public string FailureContent { get; set; }

                    /// <summary>
                    /// <para>The agent route code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SEAT_CTI_A_NET</para>
                    /// </summary>
                    [NameInMap("SeatRouteCode")]
                    [Validation(Required=false)]
                    public string SeatRouteCode { get; set; }

                    /// <summary>
                    /// <para>The agent route name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Human agent</para>
                    /// </summary>
                    [NameInMap("SeatRouteName")]
                    [Validation(Required=false)]
                    public string SeatRouteName { get; set; }

                    /// <summary>
                    /// <para>The business ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("TransferBizId")]
                    [Validation(Required=false)]
                    public string TransferBizId { get; set; }

                    /// <summary>
                    /// <para>The prompt message for transferring to a human agent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Prompt message</para>
                    /// </summary>
                    [NameInMap("TransferContent")]
                    [Validation(Required=false)]
                    public string TransferContent { get; set; }

                    /// <summary>
                    /// <para>The agent transfer type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>73</para>
                    /// </summary>
                    [NameInMap("TransferType")]
                    [Validation(Required=false)]
                    public long? TransferType { get; set; }

                }

                /// <summary>
                /// <para>The TTS configuration.</para>
                /// </summary>
                [NameInMap("TtsConfig")]
                [Validation(Required=false)]
                public QueryAiVoiceAgentDetailNewResponseBodyDataAgentCallConfigTtsConfig TtsConfig { get; set; }
                public class QueryAiVoiceAgentDetailNewResponseBodyDataAgentCallConfigTtsConfig : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether background sound is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("BackgroundEnabled")]
                    [Validation(Required=false)]
                    public bool? BackgroundEnabled { get; set; }

                    /// <summary>
                    /// <para>The background sound ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>17</para>
                    /// </summary>
                    [NameInMap("BackgroundSound")]
                    [Validation(Required=false)]
                    public long? BackgroundSound { get; set; }

                    /// <summary>
                    /// <para>The background sound volume. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: Low.</description></item>
                    /// <item><description>1: Medium.</description></item>
                    /// <item><description>2: High.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("BackgroundVolume")]
                    [Validation(Required=false)]
                    public long? BackgroundVolume { get; set; }

                    /// <summary>
                    /// <para>The third-party voice platform account.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>75</para>
                    /// </summary>
                    [NameInMap("CustomerAccountId")]
                    [Validation(Required=false)]
                    public long? CustomerAccountId { get; set; }

                    /// <summary>
                    /// <para>Specifies whether audio mixing is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("MixingEnabled")]
                    [Validation(Required=false)]
                    public bool? MixingEnabled { get; set; }

                    /// <summary>
                    /// <para>The audio mixing template ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MixingTemplate")]
                    [Validation(Required=false)]
                    public long? MixingTemplate { get; set; }

                    /// <summary>
                    /// <para>The resource ID. This parameter is required only for third-party voices.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>voice-12345</para>
                    /// </summary>
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <para>The voice speed during TTS playback. Valid values: -200 to 200. Default value: 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TtsSpeed")]
                    [Validation(Required=false)]
                    public long? TtsSpeed { get; set; }

                    /// <summary>
                    /// <para>The voice style.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>longxiaoxia_v2p1</para>
                    /// </summary>
                    [NameInMap("TtsStyle")]
                    [Validation(Required=false)]
                    public string TtsStyle { get; set; }

                    /// <summary>
                    /// <para>The volume during TTS playback. Valid values: 0 to 100.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>88</para>
                    /// </summary>
                    [NameInMap("TtsVolume")]
                    [Validation(Required=false)]
                    public long? TtsVolume { get; set; }

                    /// <summary>
                    /// <para>The voice code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>V123ABC00</para>
                    /// </summary>
                    [NameInMap("VoiceCode")]
                    [Validation(Required=false)]
                    public string VoiceCode { get; set; }

                    /// <summary>
                    /// <para>The TTS voice type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>VOICE_TYPE_SYSTEM</c>: System voice.</description></item>
                    /// <item><description><c>VOICE_TYPE_CLONE</c>: Cloned voice.</description></item>
                    /// <item><description><c>VOICE_TYPE_DOUBAO</c>: Doubao voice.</description></item>
                    /// <item><description><c>VOICE_TYPE_MINIMAX</c>: Minimax voice.</description></item>
                    /// <item><description><c>VOICE_TYPE_OPENTTS</c>: Open voice.</description></item>
                    /// <item><description><c>VOICE_TYPE_BL_CUSTOM</c>: Custom premium cloned voice.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>VOICE_TYPE_SYSTEM</para>
                    /// </summary>
                    [NameInMap("VoiceType")]
                    [Validation(Required=false)]
                    public bool? VoiceType { get; set; }

                }

                /// <summary>
                /// <para>The hot word vocabulary ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>afb2c43**********83e6df30551c11f7</para>
                /// </summary>
                [NameInMap("VocabId")]
                [Validation(Required=false)]
                public string VocabId { get; set; }

            }

            /// <summary>
            /// <para>The agent business requirement configuration.</para>
            /// </summary>
            [NameInMap("AgentDemandConfig")]
            [Validation(Required=false)]
            public QueryAiVoiceAgentDetailNewResponseBodyDataAgentDemandConfig AgentDemandConfig { get; set; }
            public class QueryAiVoiceAgentDetailNewResponseBodyDataAgentDemandConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether AI-assisted building is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AiGenerate")]
                [Validation(Required=false)]
                public bool? AiGenerate { get; set; }

                /// <summary>
                /// <para>The basic task configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Conduct product marketing and introduce advantages and features</para>
                /// </summary>
                [NameInMap("BasicTaskDescription")]
                [Validation(Required=false)]
                public string BasicTaskDescription { get; set; }

                /// <summary>
                /// <para>The business scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public long? BusinessType { get; set; }

                /// <summary>
                /// <para>The core objective.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sales lead conversion</para>
                /// </summary>
                [NameInMap("CoreTarget")]
                [Validation(Required=false)]
                public string CoreTarget { get; set; }

                /// <summary>
                /// <para>The system role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sales</para>
                /// </summary>
                [NameInMap("SysRole")]
                [Validation(Required=false)]
                public string SysRole { get; set; }

                /// <summary>
                /// <para>The user role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Potential customer</para>
                /// </summary>
                [NameInMap("UserRole")]
                [Validation(Required=false)]
                public string UserRole { get; set; }

            }

            /// <summary>
            /// <para>The agent description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>For daily testing</para>
            /// </summary>
            [NameInMap("AgentDesc")]
            [Validation(Required=false)]
            public string AgentDesc { get; set; }

            /// <summary>
            /// <para>The agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3021893791</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public long? AgentId { get; set; }

            /// <summary>
            /// <para>The building method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Prompt mode.</description></item>
            /// <item><description>1: Dialog flow mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AgentMode")]
            [Validation(Required=false)]
            public long? AgentMode { get; set; }

            /// <summary>
            /// <para>The agent name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test agent</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <para>The deployment status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Not effective (NOT_EFFECT).</description></item>
            /// <item><description>1: Effective (EFFECT).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BranchDeployStatus")]
            [Validation(Required=false)]
            public long? BranchDeployStatus { get; set; }

            /// <summary>
            /// <para>The branch description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default branch</para>
            /// </summary>
            [NameInMap("BranchDesc")]
            [Validation(Required=false)]
            public string BranchDesc { get; set; }

            /// <summary>
            /// <para>The branch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("BranchId")]
            [Validation(Required=false)]
            public long? BranchId { get; set; }

            /// <summary>
            /// <para>The branch name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default version</para>
            /// </summary>
            [NameInMap("BranchName")]
            [Validation(Required=false)]
            public string BranchName { get; set; }

            /// <summary>
            /// <para>The knowledge base configuration.</para>
            /// </summary>
            [NameInMap("KnowledgeConfig")]
            [Validation(Required=false)]
            public QueryAiVoiceAgentDetailNewResponseBodyDataKnowledgeConfig KnowledgeConfig { get; set; }
            public class QueryAiVoiceAgentDetailNewResponseBodyDataKnowledgeConfig : TeaModel {
                /// <summary>
                /// <para>The knowledge base collection.</para>
                /// </summary>
                [NameInMap("KnowledgeIds")]
                [Validation(Required=false)]
                public List<QueryAiVoiceAgentDetailNewResponseBodyDataKnowledgeConfigKnowledgeIds> KnowledgeIds { get; set; }
                public class QueryAiVoiceAgentDetailNewResponseBodyDataKnowledgeConfigKnowledgeIds : TeaModel {
                    /// <summary>
                    /// <para>The knowledge base ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>68</para>
                    /// </summary>
                    [NameInMap("KnowledgeId")]
                    [Validation(Required=false)]
                    public long? KnowledgeId { get; set; }

                    /// <summary>
                    /// <para>The knowledge base name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Product knowledge base</para>
                    /// </summary>
                    [NameInMap("KnowledgeName")]
                    [Validation(Required=false)]
                    public string KnowledgeName { get; set; }

                }

                /// <summary>
                /// <para>The RAG configuration.</para>
                /// </summary>
                [NameInMap("RagConfig")]
                [Validation(Required=false)]
                public QueryAiVoiceAgentDetailNewResponseBodyDataKnowledgeConfigRagConfig RagConfig { get; set; }
                public class QueryAiVoiceAgentDetailNewResponseBodyDataKnowledgeConfigRagConfig : TeaModel {
                    /// <summary>
                    /// <para>The RAG retrieval description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Knowledge base retrieval</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Specifies whether RAG retrieval is enabled.</para>
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
            /// <para>The call variable configuration.</para>
            /// </summary>
            [NameInMap("PhoneTagConfig")]
            [Validation(Required=false)]
            public List<QueryAiVoiceAgentDetailNewResponseBodyDataPhoneTagConfig> PhoneTagConfig { get; set; }
            public class QueryAiVoiceAgentDetailNewResponseBodyDataPhoneTagConfig : TeaModel {
                /// <summary>
                /// <para>The call variable ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The available values for the call variable tag.</para>
                /// </summary>
                [NameInMap("PhoneTagEnum")]
                [Validation(Required=false)]
                public List<QueryAiVoiceAgentDetailNewResponseBodyDataPhoneTagConfigPhoneTagEnum> PhoneTagEnum { get; set; }
                public class QueryAiVoiceAgentDetailNewResponseBodyDataPhoneTagConfigPhoneTagEnum : TeaModel {
                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>gender</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The tag ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>male</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The key name of the call variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gender</para>
                /// </summary>
                [NameInMap("PhoneTagKey")]
                [Validation(Required=false)]
                public string PhoneTagKey { get; set; }

                /// <summary>
                /// <para>The description of the call variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>User gender</para>
                /// </summary>
                [NameInMap("PhoneTagName")]
                [Validation(Required=false)]
                public string PhoneTagName { get; set; }

                /// <summary>
                /// <para>Specifies whether the call variable is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("PhoneTagRequired")]
                [Validation(Required=false)]
                public bool? PhoneTagRequired { get; set; }

                /// <summary>
                /// <para>The source of the call variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MANUAL_CREATE</para>
                /// </summary>
                [NameInMap("PhoneTagSource")]
                [Validation(Required=false)]
                public string PhoneTagSource { get; set; }

                /// <summary>
                /// <para>The type of the call variable. Valid values: TEXT for text type, and ENUM for enumerable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENUM</para>
                /// </summary>
                [NameInMap("PhoneTagType")]
                [Validation(Required=false)]
                public string PhoneTagType { get; set; }

            }

            /// <summary>
            /// <para>The scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Individual customer lead conversion</para>
            /// </summary>
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>The service direction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample value sample value</para>
            /// </summary>
            [NameInMap("ServiceDirection")]
            [Validation(Required=false)]
            public string ServiceDirection { get; set; }

            /// <summary>
            /// <para>The call notes configuration.</para>
            /// </summary>
            [NameInMap("SummaryConfig")]
            [Validation(Required=false)]
            public QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfig SummaryConfig { get; set; }
            public class QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfig : TeaModel {
                /// <summary>
                /// <para>The call result tag mapping configuration.</para>
                /// </summary>
                [NameInMap("CallResultTagConfig")]
                [Validation(Required=false)]
                public QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigCallResultTagConfig CallResultTagConfig { get; set; }
                public class QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigCallResultTagConfig : TeaModel {
                    /// <summary>
                    /// <para>The default fallback tag information.</para>
                    /// </summary>
                    [NameInMap("DefaultTag")]
                    [Validation(Required=false)]
                    public QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigCallResultTagConfigDefaultTag DefaultTag { get; set; }
                    public class QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigCallResultTagConfigDefaultTag : TeaModel {
                        /// <summary>
                        /// <para>The description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Tag description</para>
                        /// </summary>
                        [NameInMap("Desc")]
                        [Validation(Required=false)]
                        public string Desc { get; set; }

                        /// <summary>
                        /// <para>The tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Tag 1</para>
                        /// </summary>
                        [NameInMap("Tag")]
                        [Validation(Required=false)]
                        public string Tag { get; set; }

                    }

                    /// <summary>
                    /// <para>The mapping between call results and tags.</para>
                    /// </summary>
                    [NameInMap("MappingTag")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> MappingTag { get; set; }

                }

                /// <summary>
                /// <para>The main intent.</para>
                /// </summary>
                [NameInMap("MainPurpose")]
                [Validation(Required=false)]
                public QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigMainPurpose MainPurpose { get; set; }
                public class QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigMainPurpose : TeaModel {
                    /// <summary>
                    /// <para>The main intent ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The main intent description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Description of the main intent</para>
                    /// </summary>
                    [NameInMap("MainPurposeDescription")]
                    [Validation(Required=false)]
                    public string MainPurposeDescription { get; set; }

                    /// <summary>
                    /// <para>The available values for the main intent.</para>
                    /// </summary>
                    [NameInMap("MainPurposeEnum")]
                    [Validation(Required=false)]
                    public List<QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigMainPurposeMainPurposeEnum> MainPurposeEnum { get; set; }
                    public class QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigMainPurposeMainPurposeEnum : TeaModel {
                        /// <summary>
                        /// <para>The description of the available value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Description of the tag value</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The unique ID of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tag_12345</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The available value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Tag value example</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The main intent name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Customer inquiry handling</para>
                    /// </summary>
                    [NameInMap("MainPurposeName")]
                    [Validation(Required=false)]
                    public string MainPurposeName { get; set; }

                    /// <summary>
                    /// <para>The value type of the main intent. Valid values: TEXT for text type, and ENUM for enumerable type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ENUM</para>
                    /// </summary>
                    [NameInMap("MainPurposeType")]
                    [Validation(Required=false)]
                    public string MainPurposeType { get; set; }

                }

                /// <summary>
                /// <para>The output tag configuration.</para>
                /// </summary>
                [NameInMap("OutputTagConfig")]
                [Validation(Required=false)]
                public List<QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigOutputTagConfig> OutputTagConfig { get; set; }
                public class QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigOutputTagConfig : TeaModel {
                    /// <summary>
                    /// <para>The output tag ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The description of the output tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>User willingness to purchase the product</para>
                    /// </summary>
                    [NameInMap("OutputTagDescription")]
                    [Validation(Required=false)]
                    public string OutputTagDescription { get; set; }

                    /// <summary>
                    /// <para>The available options for the output tag.</para>
                    /// </summary>
                    [NameInMap("OutputTagEnum")]
                    [Validation(Required=false)]
                    public List<QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigOutputTagConfigOutputTagEnum> OutputTagEnum { get; set; }
                    public class QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigOutputTagConfigOutputTagEnum : TeaModel {
                        /// <summary>
                        /// <para>The tag description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The user has a high willingness to purchase</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The tag ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The tag enumeration value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>High willingness</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The output tag name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Purchase willingness</para>
                    /// </summary>
                    [NameInMap("OutputTagName")]
                    [Validation(Required=false)]
                    public string OutputTagName { get; set; }

                    /// <summary>
                    /// <para>The value type of the output tag. Valid values: TEXT for text type, and ENUM for enumerable type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ENUM</para>
                    /// </summary>
                    [NameInMap("OutputTagType")]
                    [Validation(Required=false)]
                    public string OutputTagType { get; set; }

                }

            }

            /// <summary>
            /// <para>The version description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test first version</para>
            /// </summary>
            [NameInMap("VersionDesc")]
            [Validation(Required=false)]
            public string VersionDesc { get; set; }

            /// <summary>
            /// <para>The version ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>89</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public long? VersionId { get; set; }

            /// <summary>
            /// <para>The version name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test version 1</para>
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

            /// <summary>
            /// <para>The publish status of the version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Unpublished.</description></item>
            /// <item><description>1: Published.</description></item>
            /// <item><description>2: Draft.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VersionPublishStatus")]
            [Validation(Required=false)]
            public long? VersionPublishStatus { get; set; }

            /// <summary>
            /// <para>The last publish time of the version. Format: YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-15 10:30:00</para>
            /// </summary>
            [NameInMap("VersionPublishTime")]
            [Validation(Required=false)]
            public string VersionPublishTime { get; set; }

        }

        /// <summary>
        /// <para>The status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>742C9243-2870-B8D6-0C68-C12345AABBCC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Specifies whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Successful.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

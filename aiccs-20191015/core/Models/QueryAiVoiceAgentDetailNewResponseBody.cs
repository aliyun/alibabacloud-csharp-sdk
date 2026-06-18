// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryAiVoiceAgentDetailNewResponseBody : TeaModel {
        /// <summary>
        /// <para>The reason for the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The detailed data of the agent.</para>
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
                    /// <para>Specifies whether to disconnect the call when an answering machine is detected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("CallAssistantHangup")]
                    [Validation(Required=false)]
                    public bool? CallAssistantHangup { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable answering machine detection.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("CallAssistantRecognize")]
                    [Validation(Required=false)]
                    public bool? CallAssistantRecognize { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to wake up the model upon the first mute event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("MuteActive")]
                    [Validation(Required=false)]
                    public bool? MuteActive { get; set; }

                    /// <summary>
                    /// <para>The mute duration. Unit: seconds. Valid values: 3 to 15.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("MuteDuration")]
                    [Validation(Required=false)]
                    public long? MuteDuration { get; set; }

                    /// <summary>
                    /// <para>The number of consecutive mute events that trigger an automatic disconnection. Valid values: 1 to 5.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MuteHangupNum")]
                    [Validation(Required=false)]
                    public long? MuteHangupNum { get; set; }

                    /// <summary>
                    /// <para>The maximum call duration. Unit: seconds. Valid values: 600 to 3600. The call is automatically disconnected if this duration is exceeded.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("SessionTimeout")]
                    [Validation(Required=false)]
                    public long? SessionTimeout { get; set; }

                }

                /// <summary>
                /// <para>The prologue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>你好，这里是******。</para>
                /// </summary>
                [NameInMap("Prologue")]
                [Validation(Required=false)]
                public string Prologue { get; set; }

                /// <summary>
                /// <para>The URL of the audio file for the prologue. This parameter is returned only when <c>StartWordType</c> is set to <c>1</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/oss-file-key</para>
                /// </summary>
                [NameInMap("RecordingFile")]
                [Validation(Required=false)]
                public string RecordingFile { get; set; }

                /// <summary>
                /// <para>The type of the prologue. Valid values: <c>0</c> (text) and <c>1</c> (recording).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StartWordType")]
                [Validation(Required=false)]
                public long? StartWordType { get; set; }

                /// <summary>
                /// <para>The configuration for transferring the call to a manual agent.</para>
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
                    /// <para>The caller number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123111122222</para>
                    /// </summary>
                    [NameInMap("CallerNumber")]
                    [Validation(Required=false)]
                    public string CallerNumber { get; set; }

                    /// <summary>
                    /// <para>The type of the caller number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>48</para>
                    /// </summary>
                    [NameInMap("CallerNumberType")]
                    [Validation(Required=false)]
                    public long? CallerNumberType { get; set; }

                    /// <summary>
                    /// <para>The destination number for the transfer, such as the phone number of a customer service agent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123111122222</para>
                    /// </summary>
                    [NameInMap("CallingNumber")]
                    [Validation(Required=false)]
                    public string CallingNumber { get; set; }

                    /// <summary>
                    /// <para>The type of the called number.</para>
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
                    /// <para>Specifies whether to enable call transfer.</para>
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
                    /// <para>The prompt that is played when the transfer to a manual agent fails.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>失败说明</para>
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
                    /// <para>The name of the agent route.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>人工座席</para>
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
                    /// <para>The prompt that is played when the call is transferred to a manual agent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>提示语</para>
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
                /// <para>The Text-to-Speech (TTS) configuration.</para>
                /// </summary>
                [NameInMap("TtsConfig")]
                [Validation(Required=false)]
                public QueryAiVoiceAgentDetailNewResponseBodyDataAgentCallConfigTtsConfig TtsConfig { get; set; }
                public class QueryAiVoiceAgentDetailNewResponseBodyDataAgentCallConfigTtsConfig : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable background sound.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("BackgroundEnabled")]
                    [Validation(Required=false)]
                    public bool? BackgroundEnabled { get; set; }

                    /// <summary>
                    /// <para>The ID of the background sound.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>17</para>
                    /// </summary>
                    [NameInMap("BackgroundSound")]
                    [Validation(Required=false)]
                    public long? BackgroundSound { get; set; }

                    /// <summary>
                    /// <para>The volume of the background sound. Valid values: <c>0</c> (low), <c>1</c> (medium), and <c>2</c> (high).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("BackgroundVolume")]
                    [Validation(Required=false)]
                    public long? BackgroundVolume { get; set; }

                    /// <summary>
                    /// <para>The account of the third-party voice platform.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>75</para>
                    /// </summary>
                    [NameInMap("CustomerAccountId")]
                    [Validation(Required=false)]
                    public long? CustomerAccountId { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable audio mixing.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("MixingEnabled")]
                    [Validation(Required=false)]
                    public bool? MixingEnabled { get; set; }

                    /// <summary>
                    /// <para>The ID of the audio mixing template.</para>
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
                    /// <para>The speech rate for TTS playback. Valid values: -200 to 200. Default value: 0.</para>
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
                    /// <para>The volume of TTS playback. Valid values: 0 to 100.</para>
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
                    /// <para>The type of the TTS voice. Valid values:</para>
                    /// <para><c>VOICE_TYPE_SYSTEM</c>: a system voice.</para>
                    /// <para><c>VOICE_TYPE_CLONE</c>: a cloned voice.</para>
                    /// <para><c>VOICE_TYPE_DOUBAO</c>: a Doubao voice.</para>
                    /// <para><c>VOICE_TYPE_MINIMAX</c>: a Minimax voice.</para>
                    /// <para><c>VOICE_TYPE_OPENTTS</c>: an open voice.</para>
                    /// <para><c>VOICE_TYPE_BL_CUSTOM</c>: a high-quality custom cloned voice.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>VOICE_TYPE_SYSTEM</para>
                    /// </summary>
                    [NameInMap("VoiceType")]
                    [Validation(Required=false)]
                    public bool? VoiceType { get; set; }

                }

                /// <summary>
                /// <para>The ID of the hotword vocabulary.</para>
                /// 
                /// <b>Example:</b>
                /// <para>afb2c43**********83e6df30551c11f7</para>
                /// </summary>
                [NameInMap("VocabId")]
                [Validation(Required=false)]
                public string VocabId { get; set; }

            }

            /// <summary>
            /// <para>The business requirement configuration for the agent.</para>
            /// </summary>
            [NameInMap("AgentDemandConfig")]
            [Validation(Required=false)]
            public QueryAiVoiceAgentDetailNewResponseBodyDataAgentDemandConfig AgentDemandConfig { get; set; }
            public class QueryAiVoiceAgentDetailNewResponseBodyDataAgentDemandConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether the agent was built with AI assistance.</para>
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
                /// <para>进行产品营销，介绍优势特点</para>
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
                /// <para>销售线索转化</para>
                /// </summary>
                [NameInMap("CoreTarget")]
                [Validation(Required=false)]
                public string CoreTarget { get; set; }

                /// <summary>
                /// <para>The system role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>销售</para>
                /// </summary>
                [NameInMap("SysRole")]
                [Validation(Required=false)]
                public string SysRole { get; set; }

                /// <summary>
                /// <para>The user role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>潜在客户</para>
                /// </summary>
                [NameInMap("UserRole")]
                [Validation(Required=false)]
                public string UserRole { get; set; }

            }

            /// <summary>
            /// <para>The agent description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>日常测试使用。</para>
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
            /// <para>The build mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>0</c>: prompt-based mode.</para>
            /// </description></item>
            /// <item><description><para><c>1</c>: dialog flow mode.</para>
            /// </description></item>
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
            /// <para>测试智能体</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <para>The deployment status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>0</c>: Inactive (NOT_EFFECT).</para>
            /// </description></item>
            /// <item><description><para><c>1</c>: Active (EFFECT).</para>
            /// </description></item>
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
            /// <para>默认分支</para>
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
            /// <para>默认版本</para>
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
                /// <para>The collection of knowledge bases.</para>
                /// </summary>
                [NameInMap("KnowledgeIds")]
                [Validation(Required=false)]
                public List<QueryAiVoiceAgentDetailNewResponseBodyDataKnowledgeConfigKnowledgeIds> KnowledgeIds { get; set; }
                public class QueryAiVoiceAgentDetailNewResponseBodyDataKnowledgeConfigKnowledgeIds : TeaModel {
                    /// <summary>
                    /// <para>The ID of the knowledge base.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>68</para>
                    /// </summary>
                    [NameInMap("KnowledgeId")]
                    [Validation(Required=false)]
                    public long? KnowledgeId { get; set; }

                    /// <summary>
                    /// <para>The name of the knowledge base.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>产品知识库</para>
                    /// </summary>
                    [NameInMap("KnowledgeName")]
                    [Validation(Required=false)]
                    public string KnowledgeName { get; set; }

                }

                /// <summary>
                /// <para>The Retrieval-Augmented Generation (RAG) configuration.</para>
                /// </summary>
                [NameInMap("RagConfig")]
                [Validation(Required=false)]
                public QueryAiVoiceAgentDetailNewResponseBodyDataKnowledgeConfigRagConfig RagConfig { get; set; }
                public class QueryAiVoiceAgentDetailNewResponseBodyDataKnowledgeConfigRagConfig : TeaModel {
                    /// <summary>
                    /// <para>RAG retrieval description</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>知识库检索</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Enable RAG retrieval</para>
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
                /// <para>The ID of the call variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The enumerated values for the call variable.</para>
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
                /// <para>The key of the call variable.</para>
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
                /// <para>用户性别</para>
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
                /// <para>The type of the call variable. Valid values: <c>TEXT</c> and <c>ENUM</c>.</para>
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
            /// <para>个人客户线索转化</para>
            /// </summary>
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>The call summary configuration.</para>
            /// </summary>
            [NameInMap("SummaryConfig")]
            [Validation(Required=false)]
            public QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfig SummaryConfig { get; set; }
            public class QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfig : TeaModel {
                /// <summary>
                /// <para>The configuration for mapping call results to tags.</para>
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
                        /// <para>标签说明</para>
                        /// </summary>
                        [NameInMap("Desc")]
                        [Validation(Required=false)]
                        public string Desc { get; set; }

                        /// <summary>
                        /// <para>The tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>标签1</para>
                        /// </summary>
                        [NameInMap("Tag")]
                        [Validation(Required=false)]
                        public string Tag { get; set; }

                    }

                    /// <summary>
                    /// <para>The mapping of call results to tags.</para>
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
                    /// <para>The ID of the main intent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The description of the main intent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Description of the main intent</para>
                    /// </summary>
                    [NameInMap("MainPurposeDescription")]
                    [Validation(Required=false)]
                    public string MainPurposeDescription { get; set; }

                    /// <summary>
                    /// <para>The enumerated values for the main intent.</para>
                    /// </summary>
                    [NameInMap("MainPurposeEnum")]
                    [Validation(Required=false)]
                    public List<QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigMainPurposeMainPurposeEnum> MainPurposeEnum { get; set; }
                    public class QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigMainPurposeMainPurposeEnum : TeaModel {
                        /// <summary>
                        /// <para>The description of the value.</para>
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
                        /// <para>The value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Tag value example</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the main intent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Customer inquiry handling</para>
                    /// </summary>
                    [NameInMap("MainPurposeName")]
                    [Validation(Required=false)]
                    public string MainPurposeName { get; set; }

                    /// <summary>
                    /// <para>The value type of the main intent. Valid values: <c>TEXT</c> and <c>ENUM</c>.</para>
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
                    /// <para>The ID of the output tag.</para>
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
                    /// <para>用户购买产品的意愿</para>
                    /// </summary>
                    [NameInMap("OutputTagDescription")]
                    [Validation(Required=false)]
                    public string OutputTagDescription { get; set; }

                    /// <summary>
                    /// <para>The enumerated values for the output tag.</para>
                    /// </summary>
                    [NameInMap("OutputTagEnum")]
                    [Validation(Required=false)]
                    public List<QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigOutputTagConfigOutputTagEnum> OutputTagEnum { get; set; }
                    public class QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigOutputTagConfigOutputTagEnum : TeaModel {
                        /// <summary>
                        /// <para>The tag description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>用户有较高购买意愿</para>
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
                        /// <para>The enumerated value of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>高意愿</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the output tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>购买意愿</para>
                    /// </summary>
                    [NameInMap("OutputTagName")]
                    [Validation(Required=false)]
                    public string OutputTagName { get; set; }

                    /// <summary>
                    /// <para>The value type of the output tag. Valid values: <c>TEXT</c> and <c>ENUM</c>.</para>
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
            /// <para>Version Description</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试第一个版本</para>
            /// </summary>
            [NameInMap("VersionDesc")]
            [Validation(Required=false)]
            public string VersionDesc { get; set; }

            /// <summary>
            /// <para>Version ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>89</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public long? VersionId { get; set; }

            /// <summary>
            /// <para>Version name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试版本1</para>
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

            /// <summary>
            /// <para>The release status of the version. 0 indicates Unreleased, 1 indicates Released, and 2 indicates Draft.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VersionPublishStatus")]
            [Validation(Required=false)]
            public long? VersionPublishStatus { get; set; }

            /// <summary>
            /// <para>The most recent release time of the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-15 10:30:00</para>
            /// </summary>
            [NameInMap("VersionPublishTime")]
            [Validation(Required=false)]
            public string VersionPublishTime { get; set; }

        }

        /// <summary>
        /// <para>The message that is associated with the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
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
        /// <para>Indicates whether the API call was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The operation was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Failure.</para>
        /// </description></item>
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

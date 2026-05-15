// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryAiVoiceAgentDetailNewResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAiVoiceAgentDetailNewResponseBodyData Data { get; set; }
        public class QueryAiVoiceAgentDetailNewResponseBodyData : TeaModel {
            [NameInMap("AgentCallConfig")]
            [Validation(Required=false)]
            public QueryAiVoiceAgentDetailNewResponseBodyDataAgentCallConfig AgentCallConfig { get; set; }
            public class QueryAiVoiceAgentDetailNewResponseBodyDataAgentCallConfig : TeaModel {
                [NameInMap("EventConfig")]
                [Validation(Required=false)]
                public QueryAiVoiceAgentDetailNewResponseBodyDataAgentCallConfigEventConfig EventConfig { get; set; }
                public class QueryAiVoiceAgentDetailNewResponseBodyDataAgentCallConfigEventConfig : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("CallAssistantHangup")]
                    [Validation(Required=false)]
                    public bool? CallAssistantHangup { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("CallAssistantRecognize")]
                    [Validation(Required=false)]
                    public bool? CallAssistantRecognize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("MuteActive")]
                    [Validation(Required=false)]
                    public bool? MuteActive { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>63</para>
                    /// </summary>
                    [NameInMap("MuteDuration")]
                    [Validation(Required=false)]
                    public long? MuteDuration { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>70</para>
                    /// </summary>
                    [NameInMap("MuteHangupNum")]
                    [Validation(Required=false)]
                    public long? MuteHangupNum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("SessionTimeout")]
                    [Validation(Required=false)]
                    public long? SessionTimeout { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("Prologue")]
                [Validation(Required=false)]
                public string Prologue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/oss-file-key</para>
                /// </summary>
                [NameInMap("RecordingFile")]
                [Validation(Required=false)]
                public string RecordingFile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StartWordType")]
                [Validation(Required=false)]
                public long? StartWordType { get; set; }

                [NameInMap("TransferConfig")]
                [Validation(Required=false)]
                public QueryAiVoiceAgentDetailNewResponseBodyDataAgentCallConfigTransferConfig TransferConfig { get; set; }
                public class QueryAiVoiceAgentDetailNewResponseBodyDataAgentCallConfigTransferConfig : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123111122222</para>
                    /// </summary>
                    [NameInMap("CalledNumber")]
                    [Validation(Required=false)]
                    public string CalledNumber { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123111122222</para>
                    /// </summary>
                    [NameInMap("CallerNumber")]
                    [Validation(Required=false)]
                    public string CallerNumber { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>48</para>
                    /// </summary>
                    [NameInMap("CallerNumberType")]
                    [Validation(Required=false)]
                    public long? CallerNumberType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123111122222</para>
                    /// </summary>
                    [NameInMap("CallingNumber")]
                    [Validation(Required=false)]
                    public string CallingNumber { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CallingNumberType")]
                    [Validation(Required=false)]
                    public long? CallingNumberType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("CustomerRouteCode")]
                    [Validation(Required=false)]
                    public string CustomerRouteCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Additional information for the agent</para>
                    /// </summary>
                    [NameInMap("ExtraInfo")]
                    [Validation(Required=false)]
                    public string ExtraInfo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>示例值示例值</para>
                    /// </summary>
                    [NameInMap("FailureContent")]
                    [Validation(Required=false)]
                    public string FailureContent { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("SeatRouteCode")]
                    [Validation(Required=false)]
                    public string SeatRouteCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>示例值</para>
                    /// </summary>
                    [NameInMap("SeatRouteName")]
                    [Validation(Required=false)]
                    public string SeatRouteName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("TransferBizId")]
                    [Validation(Required=false)]
                    public string TransferBizId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>示例值示例值</para>
                    /// </summary>
                    [NameInMap("TransferContent")]
                    [Validation(Required=false)]
                    public string TransferContent { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>73</para>
                    /// </summary>
                    [NameInMap("TransferType")]
                    [Validation(Required=false)]
                    public long? TransferType { get; set; }

                }

                [NameInMap("TtsConfig")]
                [Validation(Required=false)]
                public QueryAiVoiceAgentDetailNewResponseBodyDataAgentCallConfigTtsConfig TtsConfig { get; set; }
                public class QueryAiVoiceAgentDetailNewResponseBodyDataAgentCallConfigTtsConfig : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("BackgroundEnabled")]
                    [Validation(Required=false)]
                    public bool? BackgroundEnabled { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>17</para>
                    /// </summary>
                    [NameInMap("BackgroundSound")]
                    [Validation(Required=false)]
                    public long? BackgroundSound { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>33</para>
                    /// </summary>
                    [NameInMap("BackgroundVolume")]
                    [Validation(Required=false)]
                    public long? BackgroundVolume { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>75</para>
                    /// </summary>
                    [NameInMap("CustomerAccountId")]
                    [Validation(Required=false)]
                    public long? CustomerAccountId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("MixingEnabled")]
                    [Validation(Required=false)]
                    public bool? MixingEnabled { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>57</para>
                    /// </summary>
                    [NameInMap("MixingTemplate")]
                    [Validation(Required=false)]
                    public long? MixingTemplate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>voice-12345</para>
                    /// </summary>
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>24</para>
                    /// </summary>
                    [NameInMap("TtsSpeed")]
                    [Validation(Required=false)]
                    public long? TtsSpeed { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>longxiaoxia_v2p1</para>
                    /// </summary>
                    [NameInMap("TtsStyle")]
                    [Validation(Required=false)]
                    public string TtsStyle { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>88</para>
                    /// </summary>
                    [NameInMap("TtsVolume")]
                    [Validation(Required=false)]
                    public long? TtsVolume { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>V123ABC00</para>
                    /// </summary>
                    [NameInMap("VoiceCode")]
                    [Validation(Required=false)]
                    public string VoiceCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>VOICE_TYPE_SYSTEM</para>
                    /// </summary>
                    [NameInMap("VoiceType")]
                    [Validation(Required=false)]
                    public bool? VoiceType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>afb2c43**********83e6df30551c11f7</para>
                /// </summary>
                [NameInMap("VocabId")]
                [Validation(Required=false)]
                public string VocabId { get; set; }

            }

            [NameInMap("AgentDemandConfig")]
            [Validation(Required=false)]
            public QueryAiVoiceAgentDetailNewResponseBodyDataAgentDemandConfig AgentDemandConfig { get; set; }
            public class QueryAiVoiceAgentDetailNewResponseBodyDataAgentDemandConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AiGenerate")]
                [Validation(Required=false)]
                public bool? AiGenerate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Basic task configuration for customer service</para>
                /// </summary>
                [NameInMap("BasicTaskDescription")]
                [Validation(Required=false)]
                public string BasicTaskDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>53</para>
                /// </summary>
                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public long? BusinessType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Improve customer service efficiency</para>
                /// </summary>
                [NameInMap("CoreTarget")]
                [Validation(Required=false)]
                public string CoreTarget { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>System administrator</para>
                /// </summary>
                [NameInMap("SysRole")]
                [Validation(Required=false)]
                public string SysRole { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>End user</para>
                /// </summary>
                [NameInMap("UserRole")]
                [Validation(Required=false)]
                public string UserRole { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("AgentDesc")]
            [Validation(Required=false)]
            public string AgentDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3021893791</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public long? AgentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>33</para>
            /// </summary>
            [NameInMap("AgentMode")]
            [Validation(Required=false)]
            public long? AgentMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("BranchDeployStatus")]
            [Validation(Required=false)]
            public long? BranchDeployStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("BranchDesc")]
            [Validation(Required=false)]
            public string BranchDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("BranchId")]
            [Validation(Required=false)]
            public long? BranchId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("BranchName")]
            [Validation(Required=false)]
            public string BranchName { get; set; }

            [NameInMap("KnowledgeConfig")]
            [Validation(Required=false)]
            public QueryAiVoiceAgentDetailNewResponseBodyDataKnowledgeConfig KnowledgeConfig { get; set; }
            public class QueryAiVoiceAgentDetailNewResponseBodyDataKnowledgeConfig : TeaModel {
                [NameInMap("KnowledgeIds")]
                [Validation(Required=false)]
                public List<QueryAiVoiceAgentDetailNewResponseBodyDataKnowledgeConfigKnowledgeIds> KnowledgeIds { get; set; }
                public class QueryAiVoiceAgentDetailNewResponseBodyDataKnowledgeConfigKnowledgeIds : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>68</para>
                    /// </summary>
                    [NameInMap("KnowledgeId")]
                    [Validation(Required=false)]
                    public long? KnowledgeId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>示例值示例值示例值</para>
                    /// </summary>
                    [NameInMap("KnowledgeName")]
                    [Validation(Required=false)]
                    public string KnowledgeName { get; set; }

                }

                [NameInMap("RagConfig")]
                [Validation(Required=false)]
                public QueryAiVoiceAgentDetailNewResponseBodyDataKnowledgeConfigRagConfig RagConfig { get; set; }
                public class QueryAiVoiceAgentDetailNewResponseBodyDataKnowledgeConfigRagConfig : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>示例值示例值示例值</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

            }

            [NameInMap("PhoneTagConfig")]
            [Validation(Required=false)]
            public List<QueryAiVoiceAgentDetailNewResponseBodyDataPhoneTagConfig> PhoneTagConfig { get; set; }
            public class QueryAiVoiceAgentDetailNewResponseBodyDataPhoneTagConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("PhoneTagEnum")]
                [Validation(Required=false)]
                public List<QueryAiVoiceAgentDetailNewResponseBodyDataPhoneTagConfigPhoneTagEnum> PhoneTagEnum { get; set; }
                public class QueryAiVoiceAgentDetailNewResponseBodyDataPhoneTagConfigPhoneTagEnum : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>gender</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>male</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gender</para>
                /// </summary>
                [NameInMap("PhoneTagKey")]
                [Validation(Required=false)]
                public string PhoneTagKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("PhoneTagName")]
                [Validation(Required=false)]
                public string PhoneTagName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("PhoneTagRequired")]
                [Validation(Required=false)]
                public bool? PhoneTagRequired { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("PhoneTagSource")]
                [Validation(Required=false)]
                public string PhoneTagSource { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ENUM</para>
                /// </summary>
                [NameInMap("PhoneTagType")]
                [Validation(Required=false)]
                public string PhoneTagType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Customer service scenario</para>
            /// </summary>
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            [NameInMap("SummaryConfig")]
            [Validation(Required=false)]
            public QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfig SummaryConfig { get; set; }
            public class QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfig : TeaModel {
                [NameInMap("CallResultTagConfig")]
                [Validation(Required=false)]
                public QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigCallResultTagConfig CallResultTagConfig { get; set; }
                public class QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigCallResultTagConfig : TeaModel {
                    [NameInMap("DefaultTag")]
                    [Validation(Required=false)]
                    public QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigCallResultTagConfigDefaultTag DefaultTag { get; set; }
                    public class QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigCallResultTagConfigDefaultTag : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>示例值示例值</para>
                        /// </summary>
                        [NameInMap("Desc")]
                        [Validation(Required=false)]
                        public string Desc { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>示例值</para>
                        /// </summary>
                        [NameInMap("Tag")]
                        [Validation(Required=false)]
                        public string Tag { get; set; }

                    }

                    [NameInMap("MappingTag")]
                    [Validation(Required=false)]
                    public QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigCallResultTagConfigMappingTag MappingTag { get; set; }
                    public class QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigCallResultTagConfigMappingTag : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>示例值示例值</para>
                        /// </summary>
                        [NameInMap("Desc")]
                        [Validation(Required=false)]
                        public string Desc { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>示例值示例值示例值</para>
                        /// </summary>
                        [NameInMap("Tag")]
                        [Validation(Required=false)]
                        public string Tag { get; set; }

                    }

                }

                [NameInMap("MainPurpose")]
                [Validation(Required=false)]
                public QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigMainPurpose MainPurpose { get; set; }
                public class QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigMainPurpose : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Description of the main intent</para>
                    /// </summary>
                    [NameInMap("MainPurposeDescription")]
                    [Validation(Required=false)]
                    public string MainPurposeDescription { get; set; }

                    [NameInMap("MainPurposeEnum")]
                    [Validation(Required=false)]
                    public List<QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigMainPurposeMainPurposeEnum> MainPurposeEnum { get; set; }
                    public class QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigMainPurposeMainPurposeEnum : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Description of the tag value</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>tag_12345</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Tag value example</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Customer inquiry handling</para>
                    /// </summary>
                    [NameInMap("MainPurposeName")]
                    [Validation(Required=false)]
                    public string MainPurposeName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ENUM</para>
                    /// </summary>
                    [NameInMap("MainPurposeType")]
                    [Validation(Required=false)]
                    public string MainPurposeType { get; set; }

                }

                [NameInMap("OutputTagConfig")]
                [Validation(Required=false)]
                public List<QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigOutputTagConfig> OutputTagConfig { get; set; }
                public class QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigOutputTagConfig : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>示例值示例值</para>
                    /// </summary>
                    [NameInMap("OutputTagDescription")]
                    [Validation(Required=false)]
                    public string OutputTagDescription { get; set; }

                    [NameInMap("OutputTagEnum")]
                    [Validation(Required=false)]
                    public List<QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigOutputTagConfigOutputTagEnum> OutputTagEnum { get; set; }
                    public class QueryAiVoiceAgentDetailNewResponseBodyDataSummaryConfigOutputTagConfigOutputTagEnum : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>示例值示例值</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>示例值示例值</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>示例值示例值示例值</para>
                    /// </summary>
                    [NameInMap("OutputTagName")]
                    [Validation(Required=false)]
                    public string OutputTagName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ENUM</para>
                    /// </summary>
                    [NameInMap("OutputTagType")]
                    [Validation(Required=false)]
                    public string OutputTagType { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("VersionDesc")]
            [Validation(Required=false)]
            public string VersionDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>89</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public long? VersionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VersionPublishStatus")]
            [Validation(Required=false)]
            public long? VersionPublishStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-15T10:30:00Z</para>
            /// </summary>
            [NameInMap("VersionPublishTime")]
            [Validation(Required=false)]
            public string VersionPublishTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>742C9243-2870-B8D6-0C68-C60BEB2DF09A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

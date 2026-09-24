// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryAiVoiceAgentDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason why access was denied.</para>
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
        public QueryAiVoiceAgentDetailResponseBodyData Data { get; set; }
        public class QueryAiVoiceAgentDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12311212******</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public long? AgentId { get; set; }

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
            /// <para>The intelligent outbound call voice configuration.</para>
            /// </summary>
            [NameInMap("AiVoiceAgentCallConfig")]
            [Validation(Required=false)]
            public QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentCallConfig AiVoiceAgentCallConfig { get; set; }
            public class QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentCallConfig : TeaModel {
                /// <summary>
                /// <para>The call event configuration.</para>
                /// </summary>
                [NameInMap("EventConfig")]
                [Validation(Required=false)]
                public QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentCallConfigEventConfig EventConfig { get; set; }
                public class QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentCallConfigEventConfig : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to hang up when an intelligent answering service is detected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("CallAssistantHangup")]
                    [Validation(Required=false)]
                    public bool? CallAssistantHangup { get; set; }

                    /// <summary>
                    /// <para>Specifies whether intelligent answering service detection is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("CallAssistantRecognize")]
                    [Validation(Required=false)]
                    public bool? CallAssistantRecognize { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the first silence triggers the model.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("MuteActive")]
                    [Validation(Required=false)]
                    public bool? MuteActive { get; set; }

                    /// <summary>
                    /// <para>The silence duration.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Maximum value: 15s.</description></item>
                    /// <item><description>Minimum value: 3s.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("MuteDuration")]
                    [Validation(Required=false)]
                    public long? MuteDuration { get; set; }

                    /// <summary>
                    /// <para>The number of consecutive silence events before the system proactively hangs up.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Maximum value: 5.</description></item>
                    /// <item><description>Minimum value: 1.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MuteHangupNum")]
                    [Validation(Required=false)]
                    public long? MuteHangupNum { get; set; }

                    /// <summary>
                    /// <para>The maximum call duration. The call is automatically hung up after the timeout. Unit: seconds.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Maximum value: 3600.</description></item>
                    /// <item><description>Minimum value: 600.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>600</para>
                    /// </summary>
                    [NameInMap("SessionTimeout")]
                    [Validation(Required=false)]
                    public long? SessionTimeout { get; set; }

                }

                /// <summary>
                /// <para>The TTS configuration.</para>
                /// </summary>
                [NameInMap("TtsConfig")]
                [Validation(Required=false)]
                public QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentCallConfigTtsConfig TtsConfig { get; set; }
                public class QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentCallConfigTtsConfig : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether background sound is enabled.</para>
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
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("BackgroundSound")]
                    [Validation(Required=false)]
                    public long? BackgroundSound { get; set; }

                    /// <summary>
                    /// <para>The background sound volume. Valid values: 0: low. 1: medium. 2: high.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("BackgroundVolume")]
                    [Validation(Required=false)]
                    public long? BackgroundVolume { get; set; }

                    /// <summary>
                    /// <para>Indicates whether audio mixing is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("MixingEnabled")]
                    [Validation(Required=false)]
                    public bool? MixingEnabled { get; set; }

                    /// <summary>
                    /// <para>The mixing template ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MixingTemplate")]
                    [Validation(Required=false)]
                    public long? MixingTemplate { get; set; }

                    /// <summary>
                    /// <para>The voice speed during TTS playback.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Valid values: -200 to 200. Default value: 0.</description></item>
                    /// <item><description>If no value is specified, the voice speed configured in the large model application is used by default.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>34</para>
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
                    /// <para>The TTS playback volume.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Valid values: 0 to 100. Default value: 0.</description></item>
                    /// <item><description>If no value is specified, the volume configured in the large model application is used by default.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>72</para>
                    /// </summary>
                    [NameInMap("TtsVolume")]
                    [Validation(Required=false)]
                    public long? TtsVolume { get; set; }

                    /// <summary>
                    /// <para>The voice code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Sample value</para>
                    /// </summary>
                    [NameInMap("VoiceCode")]
                    [Validation(Required=false)]
                    public string VoiceCode { get; set; }

                    /// <summary>
                    /// <para>The voice type. Valid values: SYSTEM: system voice. COSYCLONE: cloned voice. BL-CUSTOM: custom premium cloned voice.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Sample value</para>
                    /// </summary>
                    [NameInMap("VoiceType")]
                    [Validation(Required=false)]
                    public string VoiceType { get; set; }

                }

                /// <summary>
                /// <para>The hot word ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>afb2c43**********83e6df30551c11f7</para>
                /// </summary>
                [NameInMap("VocabId")]
                [Validation(Required=false)]
                public string VocabId { get; set; }

            }

            /// <summary>
            /// <para>The agent model configuration.</para>
            /// </summary>
            [NameInMap("AiVoiceAgentModelConfig")]
            [Validation(Required=false)]
            public QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfig AiVoiceAgentModelConfig { get; set; }
            public class QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfig : TeaModel {
                /// <summary>
                /// <para>The basic task configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Task description</para>
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
                /// <para>The list of subtask configurations.</para>
                /// </summary>
                [NameInMap("ChildTaskList")]
                [Validation(Required=false)]
                public List<QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigChildTaskList> ChildTaskList { get; set; }
                public class QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigChildTaskList : TeaModel {
                    /// <summary>
                    /// <para>The subtask description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>新用户邀约: \&quot;喂，家长您好！我是***<b>的王老师，我们现在有</b>课程100个试听名额，想帮宝贝安排一下体验，您看什么时候比较方便呢？\</para>
                    /// </summary>
                    [NameInMap("ChildTaskDescription")]
                    [Validation(Required=false)]
                    public string ChildTaskDescription { get; set; }

                    /// <summary>
                    /// <para>The subtask name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Opening and invitation</para>
                    /// </summary>
                    [NameInMap("ChildTaskName")]
                    [Validation(Required=false)]
                    public string ChildTaskName { get; set; }

                    /// <summary>
                    /// <para>The unique ID of the subtask.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>280cd4bf-*******df472c</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether custom exception handling is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("CustomExceptionEnable")]
                [Validation(Required=false)]
                public bool? CustomExceptionEnable { get; set; }

                /// <summary>
                /// <para>The custom exception file ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OSS文件ID</para>
                /// </summary>
                [NameInMap("CustomExceptionFileId")]
                [Validation(Required=false)]
                public string CustomExceptionFileId { get; set; }

                /// <summary>
                /// <para>The name of the custom exception file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>异常测试文件.xlsx</para>
                /// </summary>
                [NameInMap("CustomExceptionFileName")]
                [Validation(Required=false)]
                public string CustomExceptionFileName { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> This field is deprecated and will be removed in the future.</para>
                /// </summary>
                [NameInMap("CustomExceptionList")]
                [Validation(Required=false)]
                public List<QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigCustomExceptionList> CustomExceptionList { get; set; }
                public class QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigCustomExceptionList : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to output as an exception tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("ExceptionSign")]
                    [Validation(Required=false)]
                    public bool? ExceptionSign { get; set; }

                    /// <summary>
                    /// <para>The exception type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("ExceptionType")]
                    [Validation(Required=false)]
                    public string ExceptionType { get; set; }

                    /// <summary>
                    /// <para>The reply content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("Reply")]
                    [Validation(Required=false)]
                    public string Reply { get; set; }

                    /// <summary>
                    /// <para>Specifies whether interruption is supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("SupportBreak")]
                    [Validation(Required=false)]
                    public bool? SupportBreak { get; set; }

                }

                /// <summary>
                /// <para><b>[Deprecated]</b> This field is deprecated and will be removed in the future.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("CustomExceptionUrlPath")]
                [Validation(Required=false)]
                public string CustomExceptionUrlPath { get; set; }

                /// <summary>
                /// <para>The language style.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CustomExceptionVoiceStyle")]
                [Validation(Required=false)]
                public long? CustomExceptionVoiceStyle { get; set; }

                /// <summary>
                /// <para>The description of the advanced task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This outbound call communicates with parents through three core steps, ........ 3. User needs &gt; Proactive introduction</para>
                /// </summary>
                [NameInMap("FlowDesc")]
                [Validation(Required=false)]
                public string FlowDesc { get; set; }

                /// <summary>
                /// <para>The list of knowledge document IDs.</para>
                /// </summary>
                [NameInMap("KnowledgeDocIdList")]
                [Validation(Required=false)]
                public List<string> KnowledgeDocIdList { get; set; }

                /// <summary>
                /// <para>The list of knowledge document names.</para>
                /// </summary>
                [NameInMap("KnowledgeDocNameList")]
                [Validation(Required=false)]
                public List<string> KnowledgeDocNameList { get; set; }

                /// <summary>
                /// <para>The list of original file names of knowledge base documents.</para>
                /// </summary>
                [NameInMap("KnowledgeDocOriginalNameList")]
                [Validation(Required=false)]
                public List<string> KnowledgeDocOriginalNameList { get; set; }

                /// <summary>
                /// <para>Indicates whether a knowledge base is associated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("KnowledgeEnable")]
                [Validation(Required=false)]
                public bool? KnowledgeEnable { get; set; }

                /// <summary>
                /// <para>The knowledge base ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1232131*******</para>
                /// </summary>
                [NameInMap("KnowledgeId")]
                [Validation(Required=false)]
                public string KnowledgeId { get; set; }

                /// <summary>
                /// <para>The main intent configuration.</para>
                /// </summary>
                [NameInMap("MainPurpose")]
                [Validation(Required=false)]
                public QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigMainPurpose MainPurpose { get; set; }
                public class QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigMainPurpose : TeaModel {
                    /// <summary>
                    /// <para>The main intent ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1ee6e994-08e0-xxxx-f662-1659cc54d409</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The description of the main intent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Call effectiveness rating: A, B, C, D (A is the best)</para>
                    /// </summary>
                    [NameInMap("MainPurposeDescription")]
                    [Validation(Required=false)]
                    public string MainPurposeDescription { get; set; }

                    /// <summary>
                    /// <para>The list of valid values for the main intent.</para>
                    /// </summary>
                    [NameInMap("MainPurposeEnum")]
                    [Validation(Required=false)]
                    public List<QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigMainPurposeMainPurposeEnum> MainPurposeEnum { get; set; }
                    public class QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigMainPurposeMainPurposeEnum : TeaModel {
                        /// <summary>
                        /// <para>The description of the valid value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Strong intent</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The unique ID of the valid value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>d5606d80-7625-dcea-xxxx-17f66fbb564a</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The valid value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>A</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The main intent name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Call effectiveness rating</para>
                    /// </summary>
                    [NameInMap("MainPurposeName")]
                    [Validation(Required=false)]
                    public string MainPurposeName { get; set; }

                    /// <summary>
                    /// <para>The value type of the main intent. Currently, only the ENUM type is supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ENUM</para>
                    /// </summary>
                    [NameInMap("MainPurposeType")]
                    [Validation(Required=false)]
                    public string MainPurposeType { get; set; }

                }

                /// <summary>
                /// <para>The output tag configurations.</para>
                /// </summary>
                [NameInMap("OutputTagConfig")]
                [Validation(Required=false)]
                public List<QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigOutputTagConfig> OutputTagConfig { get; set; }
                public class QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigOutputTagConfig : TeaModel {
                    /// <summary>
                    /// <para>The unique ID of the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8757************2c499fa</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The tag description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Records the final status of this call</para>
                    /// </summary>
                    [NameInMap("OutputTagDescription")]
                    [Validation(Required=false)]
                    public string OutputTagDescription { get; set; }

                    /// <summary>
                    /// <para>The tag enum values. This field is available only when the tag value type is ENUM.</para>
                    /// </summary>
                    [NameInMap("OutputTagEnum")]
                    [Validation(Required=false)]
                    public List<QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigOutputTagConfigOutputTagEnum> OutputTagEnum { get; set; }
                    public class QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigOutputTagConfigOutputTagEnum : TeaModel {
                        /// <summary>
                        /// <para>The description of the tag enum value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>High (very positive, high probability of conversion)</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The unique ID of the tag enum value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8757************2c499fa</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The tag enum value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>High</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The tag name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Customer intent level</para>
                    /// </summary>
                    [NameInMap("OutputTagName")]
                    [Validation(Required=false)]
                    public string OutputTagName { get; set; }

                    /// <summary>
                    /// <para>The tag value type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ENUM</para>
                    /// </summary>
                    [NameInMap("OutputTagType")]
                    [Validation(Required=false)]
                    public string OutputTagType { get; set; }

                }

                /// <summary>
                /// <para>The call variable configuration.</para>
                /// </summary>
                [NameInMap("PhoneTagConfig")]
                [Validation(Required=false)]
                public List<QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigPhoneTagConfig> PhoneTagConfig { get; set; }
                public class QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigPhoneTagConfig : TeaModel {
                    /// <summary>
                    /// <para>The unique ID of the variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>280cd4bf-*******df472c</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The variable description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The car series the user is interested in</para>
                    /// </summary>
                    [NameInMap("PhoneTagDescription")]
                    [Validation(Required=false)]
                    public string PhoneTagDescription { get; set; }

                    /// <summary>
                    /// <para>The list of enumeration values for the variable. This field is present only when the variable value type is ENUM.</para>
                    /// </summary>
                    [NameInMap("PhoneTagEnum")]
                    [Validation(Required=false)]
                    public List<QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigPhoneTagConfigPhoneTagEnum> PhoneTagEnum { get; set; }
                    public class QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigPhoneTagConfigPhoneTagEnum : TeaModel {
                        /// <summary>
                        /// <para>The description of the enumeration value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The customer completely rejects retention</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The unique ID of the enum value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>c3d4ff4e-*********bc26dc044682</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The enumeration value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Completely unacceptable</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The variable key name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testParam</para>
                    /// </summary>
                    [NameInMap("PhoneTagKey")]
                    [Validation(Required=false)]
                    public string PhoneTagKey { get; set; }

                    /// <summary>
                    /// <para>The Chinese name of the variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>意向车系</para>
                    /// </summary>
                    [NameInMap("PhoneTagName")]
                    [Validation(Required=false)]
                    public string PhoneTagName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the variable is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("PhoneTagRequired")]
                    [Validation(Required=false)]
                    public bool? PhoneTagRequired { get; set; }

                    /// <summary>
                    /// <para>The source of the call variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Sample value</para>
                    /// </summary>
                    [NameInMap("PhoneTagSource")]
                    [Validation(Required=false)]
                    public string PhoneTagSource { get; set; }

                    /// <summary>
                    /// <para>The variable value type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ENUM</para>
                    /// </summary>
                    [NameInMap("PhoneTagType")]
                    [Validation(Required=false)]
                    public string PhoneTagType { get; set; }

                }

                /// <summary>
                /// <para>The opening statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hello, this is ******</para>
                /// </summary>
                [NameInMap("Prologue")]
                [Validation(Required=false)]
                public string Prologue { get; set; }

                /// <summary>
                /// <para>The URL of the opening greeting recording audio file. This field has a value only when StartWordType is set to 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample value</para>
                /// </summary>
                [NameInMap("RecordingFile")]
                [Validation(Required=false)]
                public string RecordingFile { get; set; }

                /// <summary>
                /// <para>The opening statement type. Valid values: 0: text. 1: recording.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StartWordType")]
                [Validation(Required=false)]
                public long? StartWordType { get; set; }

                /// <summary>
                /// <para>The system role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Course sales</para>
                /// </summary>
                [NameInMap("SysRole")]
                [Validation(Required=false)]
                public string SysRole { get; set; }

                /// <summary>
                /// <para>The task type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ADVANCED</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

                /// <summary>
                /// <para>The user role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>New user in urgent need of courses</para>
                /// </summary>
                [NameInMap("UserRole")]
                [Validation(Required=false)]
                public string UserRole { get; set; }

            }

            /// <summary>
            /// <para>The business scenario name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Personal lead conversion</para>
            /// </summary>
            [NameInMap("BusinessTypeName")]
            [Validation(Required=false)]
            public string BusinessTypeName { get; set; }

            /// <summary>
            /// <para>The agent description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Used for daily testing</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The knowledge base name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test knowledge base</para>
            /// </summary>
            [NameInMap("KnowledgeName")]
            [Validation(Required=false)]
            public string KnowledgeName { get; set; }

            /// <summary>
            /// <para>The agent status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// <para>The language style name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Friendly</para>
            /// </summary>
            [NameInMap("VoiceStyleName")]
            [Validation(Required=false)]
            public string VoiceStyleName { get; set; }

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
        /// <para>742C9243-2870-B8D6-0C68-C60BEB2DF09A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Successful.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

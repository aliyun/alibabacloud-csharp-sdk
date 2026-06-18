// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryAiVoiceAgentDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason why the access was denied.</para>
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
        /// <para>The details of the agent.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAiVoiceAgentDetailResponseBodyData Data { get; set; }
        public class QueryAiVoiceAgentDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12311212******</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public long? AgentId { get; set; }

            /// <summary>
            /// <para>The name of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试智能体</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <para>The voice configuration for AI-powered outbound calls.</para>
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
                    /// <para>Specifies whether to hang up the call if an answering machine is detected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("CallAssistantHangup")]
                    [Validation(Required=false)]
                    public bool? CallAssistantHangup { get; set; }

                    /// <summary>
                    /// <para>Whether answering machine detection is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("CallAssistantRecognize")]
                    [Validation(Required=false)]
                    public bool? CallAssistantRecognize { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to trigger the model on the first silence event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("MuteActive")]
                    [Validation(Required=false)]
                    public bool? MuteActive { get; set; }

                    /// <summary>
                    /// <para>Silence duration.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description><para>Maximum value: 15 s.</para>
                    /// </description></item>
                    /// <item><description><para>Minimum value: 3 s.</para>
                    /// </description></item>
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
                    /// <para>The system automatically disconnects the call after a specified number of consecutive silence events.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description><para>Maximum value: 5.</para>
                    /// </description></item>
                    /// <item><description><para>Minimum value: 1.</para>
                    /// </description></item>
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
                    /// <para>The maximum call duration, in seconds. The call automatically disconnects when this duration is exceeded.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description><para>Maximum value: 3600.</para>
                    /// </description></item>
                    /// <item><description><para>Minimum value: 600.</para>
                    /// </description></item>
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
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("BackgroundEnabled")]
                    [Validation(Required=false)]
                    public bool? BackgroundEnabled { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("BackgroundSound")]
                    [Validation(Required=false)]
                    public long? BackgroundSound { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("BackgroundVolume")]
                    [Validation(Required=false)]
                    public long? BackgroundVolume { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("MixingEnabled")]
                    [Validation(Required=false)]
                    public bool? MixingEnabled { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MixingTemplate")]
                    [Validation(Required=false)]
                    public long? MixingTemplate { get; set; }

                    /// <summary>
                    /// <para>The TTS speech rate.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description><para>Valid values: -200 to 200. Default value: 0.</para>
                    /// </description></item>
                    /// <item><description><para>If this parameter is not specified, the speech rate configured for the large model application is used.</para>
                    /// </description></item>
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
                    /// <item><description><para>Valid values: 0 to 100. Default value: 0.</para>
                    /// </description></item>
                    /// <item><description><para>If this parameter is not specified, the volume configured for the large model application is used.</para>
                    /// </description></item>
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
                    /// <b>Example:</b>
                    /// <para>示例值</para>
                    /// </summary>
                    [NameInMap("VoiceCode")]
                    [Validation(Required=false)]
                    public string VoiceCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>示例值</para>
                    /// </summary>
                    [NameInMap("VoiceType")]
                    [Validation(Required=false)]
                    public string VoiceType { get; set; }

                }

                /// <summary>
                /// <para>The ID of the hotword.</para>
                /// 
                /// <b>Example:</b>
                /// <para>afb2c43**********83e6df30551c11f7</para>
                /// </summary>
                [NameInMap("VocabId")]
                [Validation(Required=false)]
                public string VocabId { get; set; }

            }

            /// <summary>
            /// <para>The model configuration for the agent.</para>
            /// </summary>
            [NameInMap("AiVoiceAgentModelConfig")]
            [Validation(Required=false)]
            public QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfig AiVoiceAgentModelConfig { get; set; }
            public class QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfig : TeaModel {
                /// <summary>
                /// <para>The configuration for the basic task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>任务描述。</para>
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
                    /// <para>The description of the subtask.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>新用户邀约: \&quot;喂，家长您好！我是***<b>的王老师，我们现在有</b>课程100个试听名额，想帮宝贝安排一下体验，您看什么时候比较方便呢？\</para>
                    /// </summary>
                    [NameInMap("ChildTaskDescription")]
                    [Validation(Required=false)]
                    public string ChildTaskDescription { get; set; }

                    /// <summary>
                    /// <para>The name of the subtask.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>开场与邀约</para>
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
                /// <para>Specifies whether custom exception handling is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("CustomExceptionEnable")]
                [Validation(Required=false)]
                public bool? CustomExceptionEnable { get; set; }

                /// <summary>
                /// <para>The ID of the custom exception file.</para>
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
                /// <para>This parameter is deprecated and will be removed in a future release.</para>
                /// </summary>
                [NameInMap("CustomExceptionList")]
                [Validation(Required=false)]
                public List<QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigCustomExceptionList> CustomExceptionList { get; set; }
                public class QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigCustomExceptionList : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to output the content as an exception tag.</para>
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
                    /// <para>The reply.</para>
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
                /// <para>This parameter is deprecated and will be removed in a future release.</para>
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
                /// <para>The voice style.</para>
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
                /// <para>这次外呼通过三个核心步骤与家长沟通，........ 3. 用户需求 &gt; 主动介绍</para>
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
                /// <para>A list of original file names for the knowledge base documents.</para>
                /// </summary>
                [NameInMap("KnowledgeDocOriginalNameList")]
                [Validation(Required=false)]
                public List<string> KnowledgeDocOriginalNameList { get; set; }

                /// <summary>
                /// <para>Specifies whether the agent is associated with a knowledge base.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("KnowledgeEnable")]
                [Validation(Required=false)]
                public bool? KnowledgeEnable { get; set; }

                /// <summary>
                /// <para>The ID of the knowledge base.</para>
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
                    /// <para>The ID of the main intent.</para>
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
                    /// <para>通话效果评级：A、B、C、D，（A最好）</para>
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
                        /// <para>The description of the value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>意向强烈。</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The unique ID of the value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>d5606d80-7625-dcea-xxxx-17f66fbb564a</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>A</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the main intent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>通话效果评级</para>
                    /// </summary>
                    [NameInMap("MainPurposeName")]
                    [Validation(Required=false)]
                    public string MainPurposeName { get; set; }

                    /// <summary>
                    /// <para>The value type of the main intent. Currently, only the <c>ENUM</c> type is supported.</para>
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
                    /// <para>The description of the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>记录本次通话的最终状态</para>
                    /// </summary>
                    [NameInMap("OutputTagDescription")]
                    [Validation(Required=false)]
                    public string OutputTagDescription { get; set; }

                    /// <summary>
                    /// <para>The enumerated values for the tag. This parameter is returned only if the value of <c>OutputTagType</c> is <c>ENUM</c>.</para>
                    /// </summary>
                    [NameInMap("OutputTagEnum")]
                    [Validation(Required=false)]
                    public List<QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigOutputTagConfigOutputTagEnum> OutputTagEnum { get; set; }
                    public class QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigOutputTagConfigOutputTagEnum : TeaModel {
                        /// <summary>
                        /// <para>The description of the enumerated value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>高（非常积极，大概率转化）</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The unique ID of the enumerated value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8757************2c499fa</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The enumerated value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>高</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>客户意向度</para>
                    /// </summary>
                    [NameInMap("OutputTagName")]
                    [Validation(Required=false)]
                    public string OutputTagName { get; set; }

                    /// <summary>
                    /// <para>The data type of the tag.</para>
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
                    /// <para>The description of the variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>用户感兴趣的车系。</para>
                    /// </summary>
                    [NameInMap("PhoneTagDescription")]
                    [Validation(Required=false)]
                    public string PhoneTagDescription { get; set; }

                    /// <summary>
                    /// <para>A list of enumerated values for the variable. This parameter is returned only if the value of <c>PhoneTagType</c> is <c>ENUM</c>.</para>
                    /// </summary>
                    [NameInMap("PhoneTagEnum")]
                    [Validation(Required=false)]
                    public List<QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigPhoneTagConfigPhoneTagEnum> PhoneTagEnum { get; set; }
                    public class QueryAiVoiceAgentDetailResponseBodyDataAiVoiceAgentModelConfigPhoneTagConfigPhoneTagEnum : TeaModel {
                        /// <summary>
                        /// <para>The description of the enumerated value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>客户完全不接受挽留</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The unique ID of the enumerated value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>c3d4ff4e-*********bc26dc044682</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The enumerated value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>完全不接受</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The key of the variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testParam</para>
                    /// </summary>
                    [NameInMap("PhoneTagKey")]
                    [Validation(Required=false)]
                    public string PhoneTagKey { get; set; }

                    /// <summary>
                    /// <para>The name of the variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>意向车系</para>
                    /// </summary>
                    [NameInMap("PhoneTagName")]
                    [Validation(Required=false)]
                    public string PhoneTagName { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the variable is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("PhoneTagRequired")]
                    [Validation(Required=false)]
                    public bool? PhoneTagRequired { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>示例值</para>
                    /// </summary>
                    [NameInMap("PhoneTagSource")]
                    [Validation(Required=false)]
                    public string PhoneTagSource { get; set; }

                    /// <summary>
                    /// <para>The data type of the variable.</para>
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
                /// <para>你好，这里是******。</para>
                /// </summary>
                [NameInMap("Prologue")]
                [Validation(Required=false)]
                public string Prologue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值</para>
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

                /// <summary>
                /// <para>The system role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>课程销售</para>
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
                /// <para>急需课程的新用户</para>
                /// </summary>
                [NameInMap("UserRole")]
                [Validation(Required=false)]
                public string UserRole { get; set; }

            }

            /// <summary>
            /// <para>The name of the business scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>个人线索转化</para>
            /// </summary>
            [NameInMap("BusinessTypeName")]
            [Validation(Required=false)]
            public string BusinessTypeName { get; set; }

            /// <summary>
            /// <para>The description of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>日常测试使用。</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试知识库</para>
            /// </summary>
            [NameInMap("KnowledgeName")]
            [Validation(Required=false)]
            public string KnowledgeName { get; set; }

            /// <summary>
            /// <para>The status of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// <para>The name of the voice style.</para>
            /// 
            /// <b>Example:</b>
            /// <para>亲切</para>
            /// </summary>
            [NameInMap("VoiceStyleName")]
            [Validation(Required=false)]
            public string VoiceStyleName { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
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
        /// <para>742C9243-2870-B8D6-0C68-C60BEB2DF09A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The operation was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Failed.</para>
        /// </description></item>
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

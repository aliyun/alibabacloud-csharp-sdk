// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeScriptResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>The API message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("NlsConfig")]
        [Validation(Required=false)]
        public string NlsConfig { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The script.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Script")]
        [Validation(Required=false)]
        public DescribeScriptResponseBodyScript Script { get; set; }
        public class DescribeScriptResponseBodyScript : TeaModel {
            /// <summary>
            /// <para>The access key of the chatbot workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1218333</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public long? AgentId { get; set; }

            /// <summary>
            /// <para>The access key of the chatbot workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14791f5f226b4878b3d9b676a0291234</para>
            /// </summary>
            [NameInMap("AgentKey")]
            [Validation(Required=false)]
            public string AgentKey { get; set; }

            /// <summary>
            /// <para>Indicates whether the chatbot workspace is a large language model (LLM) workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AgentLlm")]
            [Validation(Required=false)]
            public bool? AgentLlm { get; set; }

            /// <summary>
            /// <para>The automatic speech recognition (ASR) configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;appKey&quot;: &quot;oQDVNlE6fZ5mg46X&quot;,
            ///     &quot;engine&quot;: &quot;ali&quot;,
            ///     &quot;engineXunfei&quot;: &quot;&quot;,
            ///     &quot;globalMaxEndSilence&quot;: 700,
            ///     &quot;globalMaxEndSilenceEnable&quot;: true,
            ///     &quot;maxEndSilence&quot;: &quot;500&quot;,
            ///     &quot;nlsServiceType&quot;: &quot;Managed&quot;,
            ///     &quot;silenceTimeout&quot;: &quot;5000&quot;,
            ///     &quot;speechNoiseThreshold&quot;: &quot;0&quot;
            /// }</para>
            /// </summary>
            [NameInMap("AsrConfig")]
            [Validation(Required=false)]
            public string AsrConfig { get; set; }

            /// <summary>
            /// <para>The call configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;silenceConfig&quot;:{&quot;silenceReplyTimeout&quot;:499,&quot;silenceTimeoutMaxCount&quot;:10,&quot;silenceTimeoutMaxCountEnable&quot;:true},&quot;hangupConfig&quot;:{&quot;aiHangupEnable&quot;:false,&quot;delayHangup&quot;:0,&quot;hangupMaxRounds&quot;:20,&quot;hangupMaxRoundsBroadcast&quot;:&quot;Thank you for taking the call. Have a great day. Goodbye!&quot;,&quot;hangupMaxRoundsEnable&quot;:false},&quot;securityInterceptConfig&quot;:{&quot;broadcast&quot;:&quot;I cannot answer this question. Please try asking something else.&quot;},&quot;specialInterceptConfig&quot;:{&quot;specialInterceptEnable&quot;:false,&quot;specialIntercepts&quot;:[{&quot;code&quot;:&quot;voiceAssistant&quot;},{&quot;code&quot;:&quot;extensionNumberTransfer&quot;}]},&quot;transitionConfig&quot;:{&quot;transitionSwitch&quot;:false}}</para>
            /// </summary>
            [NameInMap("ChatConfig")]
            [Validation(Required=false)]
            public string ChatConfig { get; set; }

            /// <summary>
            /// <para>The chatbot ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d31794e2a51f47d2901b4094d88311d7</para>
            /// </summary>
            [NameInMap("ChatbotId")]
            [Validation(Required=false)]
            public string ChatbotId { get; set; }

            /// <summary>
            /// <para>The debug status of the script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DRAFTED</para>
            /// </summary>
            [NameInMap("DebugStatus")]
            [Validation(Required=false)]
            public string DebugStatus { get; set; }

            /// <summary>
            /// <para>Specifies whether the emotion recognition feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EmotionEnable")]
            [Validation(Required=false)]
            public bool? EmotionEnable { get; set; }

            /// <summary>
            /// <para>The industry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Finance</para>
            /// </summary>
            [NameInMap("Industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

            /// <summary>
            /// <para>Indicates whether the debug version is in the draft state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDebugDrafted")]
            [Validation(Required=false)]
            public bool? IsDebugDrafted { get; set; }

            /// <summary>
            /// <para>Indicates whether the script is in the draft state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDrafted")]
            [Validation(Required=false)]
            public bool? IsDrafted { get; set; }

            /// <summary>
            /// <para>The custom label configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;labels\&quot;:[{\&quot;description\&quot;:\&quot;\&quot;,\&quot;name\&quot;:\&quot;Availability\&quot;,\&quot;valueList\&quot;:\&quot;[\\\&quot;Available\\\&quot;,\\\&quot;Unavailable\\\&quot;]\&quot;}]}</para>
            /// </summary>
            [NameInMap("LabelConfig")]
            [Validation(Required=false)]
            public string LabelConfig { get; set; }

            /// <summary>
            /// <para>Specifies whether the intelligent sentence segmentation feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("LongWaitEnable")]
            [Validation(Required=false)]
            public bool? LongWaitEnable { get; set; }

            /// <summary>
            /// <para>Specifies whether the mini playback feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MiniPlaybackEnable")]
            [Validation(Required=false)]
            public bool? MiniPlaybackEnable { get; set; }

            /// <summary>
            /// <para>Specifies whether the graceful barge-in feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NewBargeInEnable")]
            [Validation(Required=false)]
            public bool? NewBargeInEnable { get; set; }

            /// <summary>
            /// <para>The natural language understanding (NLU) engine. This parameter applies only to large language model (LLM) scenarios. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Prompts: text input mode. </description></item>
            /// <item><description>SSE_FUNCTION: Function Compute service mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Prompts</para>
            /// </summary>
            [NameInMap("NluEngine")]
            [Validation(Required=false)]
            public string NluEngine { get; set; }

            /// <summary>
            /// <para>The configuration of the Function Compute service mode.</para>
            /// </summary>
            [NameInMap("NluProfile")]
            [Validation(Required=false)]
            public DescribeScriptResponseBodyScriptNluProfile NluProfile { get; set; }
            public class DescribeScriptResponseBodyScriptNluProfile : TeaModel {
                /// <summary>
                /// <para>The function service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sanfang_test</para>
                /// </summary>
                [NameInMap("FcFunction")]
                [Validation(Required=false)]
                public string FcFunction { get; set; }

                /// <summary>
                /// <para>The HTTP trigger URL of the function.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://sanfang_test-xxxxxx.cn-shanghai-vpc.fcapp.run">http://sanfang_test-xxxxxx.cn-shanghai-vpc.fcapp.run</a></para>
                /// </summary>
                [NameInMap("FcHttpTriggerUrl")]
                [Validation(Required=false)]
                public string FcHttpTriggerUrl { get; set; }

                /// <summary>
                /// <para>The region of the function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("FcRegion")]
                [Validation(Required=false)]
                public string FcRegion { get; set; }

                /// <summary>
                /// <para>Indicates whether Chatbot prompts are supported. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Supported.</description></item>
                /// <item><description>false: Not supported.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("SupportBeebotPrompts")]
                [Validation(Required=false)]
                public bool? SupportBeebotPrompts { get; set; }

            }

            /// <summary>
            /// <para>The scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Collection</para>
            /// </summary>
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>The description of the script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Collection script</para>
            /// </summary>
            [NameInMap("ScriptDescription")]
            [Validation(Required=false)]
            public string ScriptDescription { get; set; }

            /// <summary>
            /// <para>The script ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>810b5872-57f0-4b27-80ab-7b3f4d8a6374</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>The name of the script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Collection script</para>
            /// </summary>
            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <para>The status of the script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DRAFTED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The text-to-speech (TTS) configuration of the script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;appKey&quot;: &quot;oQDVNlE6fZ5mg46X&quot;,
            ///     &quot;engine&quot;: &quot;ali&quot;,
            ///     &quot;engineXunfei&quot;: &quot;&quot;,
            ///     &quot;globalInterruptible&quot;: true,
            ///         &quot;closingStatementInterruptible&quot;: false, &quot;openingPromptInterruptible&quot;: false,
            ///     &quot;nlsServiceType&quot;: &quot;Managed&quot;,
            ///     &quot;pitchRate&quot;: &quot;0&quot;,
            ///     &quot;speechRate&quot;: &quot;0&quot;,
            ///     &quot;voice&quot;: &quot;zhiyuan&quot;,
            ///     &quot;volume&quot;: &quot;50&quot;
            /// }</para>
            /// </summary>
            [NameInMap("TtsConfig")]
            [Validation(Required=false)]
            public string TtsConfig { get; set; }

            /// <summary>
            /// <para>The update time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578881227000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeScriptResponseBody : TeaModel {
        /// <summary>
        /// <para>API status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>API message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Deprecated</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("NlsConfig")]
        [Validation(Required=false)]
        public string NlsConfig { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Script details</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Script")]
        [Validation(Required=false)]
        public DescribeScriptResponseBodyScript Script { get; set; }
        public class DescribeScriptResponseBodyScript : TeaModel {
            /// <summary>
            /// <para>Robot workspace access key</para>
            /// 
            /// <b>Example:</b>
            /// <para>1218333</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public long? AgentId { get; set; }

            /// <summary>
            /// <para>Robot workspace access key</para>
            /// 
            /// <b>Example:</b>
            /// <para>14791f5f226b4878b3d9b676a0291234</para>
            /// </summary>
            [NameInMap("AgentKey")]
            [Validation(Required=false)]
            public string AgentKey { get; set; }

            /// <summary>
            /// <para>Indicates whether the robot workspace uses a Large Language Model (LLM)</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AgentLlm")]
            [Validation(Required=false)]
            public bool? AgentLlm { get; set; }

            /// <summary>
            /// <para>ASR configuration</para>
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
            /// <para>Call configuration</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;silenceConfig&quot;:{&quot;silenceReplyTimeout&quot;:499,&quot;silenceTimeoutMaxCount&quot;:10,&quot;silenceTimeoutMaxCountEnable&quot;:true},&quot;hangupConfig&quot;:{&quot;aiHangupEnable&quot;:false,&quot;delayHangup&quot;:0,&quot;hangupMaxRounds&quot;:20,&quot;hangupMaxRoundsBroadcast&quot;:&quot;感谢您的接听，祝您生活愉快，再见!&quot;,&quot;hangupMaxRoundsEnable&quot;:false},&quot;securityInterceptConfig&quot;:{&quot;broadcast&quot;:&quot;您说的这个问题我不能回答您，您可以尝试询问其他问题。&quot;},&quot;specialInterceptConfig&quot;:{&quot;specialInterceptEnable&quot;:false,&quot;specialIntercepts&quot;:[{&quot;code&quot;:&quot;voiceAssistant&quot;},{&quot;code&quot;:&quot;extensionNumberTransfer&quot;}]},&quot;transitionConfig&quot;:{&quot;transitionSwitch&quot;:false}}</para>
            /// </summary>
            [NameInMap("ChatConfig")]
            [Validation(Required=false)]
            public string ChatConfig { get; set; }

            /// <summary>
            /// <para>Chatbot ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>d31794e2a51f47d2901b4094d88311d7</para>
            /// </summary>
            [NameInMap("ChatbotId")]
            [Validation(Required=false)]
            public string ChatbotId { get; set; }

            /// <summary>
            /// <para>Status of the debug script</para>
            /// 
            /// <b>Example:</b>
            /// <para>DRAFTED</para>
            /// </summary>
            [NameInMap("DebugStatus")]
            [Validation(Required=false)]
            public string DebugStatus { get; set; }

            /// <summary>
            /// <para>Enables emotion detection</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EmotionEnable")]
            [Validation(Required=false)]
            public bool? EmotionEnable { get; set; }

            /// <summary>
            /// <para>Industry</para>
            /// 
            /// <b>Example:</b>
            /// <para>金融</para>
            /// </summary>
            [NameInMap("Industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

            /// <summary>
            /// <para>Indicates whether the debug version is in draft status</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDebugDrafted")]
            [Validation(Required=false)]
            public bool? IsDebugDrafted { get; set; }

            /// <summary>
            /// <para>Indicates whether the script is in draft status</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDrafted")]
            [Validation(Required=false)]
            public bool? IsDrafted { get; set; }

            [NameInMap("LabelConfig")]
            [Validation(Required=false)]
            public string LabelConfig { get; set; }

            /// <summary>
            /// <para>Enables intelligent sentence break</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("LongWaitEnable")]
            [Validation(Required=false)]
            public bool? LongWaitEnable { get; set; }

            /// <summary>
            /// <para>Enables tone continuity</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MiniPlaybackEnable")]
            [Validation(Required=false)]
            public bool? MiniPlaybackEnable { get; set; }

            /// <summary>
            /// <para>Enables graceful barge-in</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NewBargeInEnable")]
            [Validation(Required=false)]
            public bool? NewBargeInEnable { get; set; }

            /// <summary>
            /// <para>NLU engine (applies only to LLM scenarios)</para>
            /// <list type="bullet">
            /// <item><description><para>Prompts — Text entry mode</para>
            /// </description></item>
            /// <item><description><para>SSE_FUNCTION — Function Compute service mode</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Prompts</para>
            /// </summary>
            [NameInMap("NluEngine")]
            [Validation(Required=false)]
            public string NluEngine { get; set; }

            /// <summary>
            /// <para>Function Compute service mode configuration</para>
            /// </summary>
            [NameInMap("NluProfile")]
            [Validation(Required=false)]
            public DescribeScriptResponseBodyScriptNluProfile NluProfile { get; set; }
            public class DescribeScriptResponseBodyScriptNluProfile : TeaModel {
                /// <summary>
                /// <para>Function service name</para>
                /// 
                /// <b>Example:</b>
                /// <para>sanfang_test</para>
                /// </summary>
                [NameInMap("FcFunction")]
                [Validation(Required=false)]
                public string FcFunction { get; set; }

                /// <summary>
                /// <para>Function service trigger URL</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://sanfang_test-xxxxxx.cn-shanghai-vpc.fcapp.run">http://sanfang_test-xxxxxx.cn-shanghai-vpc.fcapp.run</a></para>
                /// </summary>
                [NameInMap("FcHttpTriggerUrl")]
                [Validation(Required=false)]
                public string FcHttpTriggerUrl { get; set; }

                /// <summary>
                /// <para>Function service region</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("FcRegion")]
                [Validation(Required=false)]
                public string FcRegion { get; set; }

                [NameInMap("SupportBeebotPrompts")]
                [Validation(Required=false)]
                public bool? SupportBeebotPrompts { get; set; }

            }

            /// <summary>
            /// <para>Scenario</para>
            /// 
            /// <b>Example:</b>
            /// <para>催收</para>
            /// </summary>
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>Script description</para>
            /// 
            /// <b>Example:</b>
            /// <para>催收话术</para>
            /// </summary>
            [NameInMap("ScriptDescription")]
            [Validation(Required=false)]
            public string ScriptDescription { get; set; }

            /// <summary>
            /// <para>Script ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>810b5872-57f0-4b27-80ab-7b3f4d8a6374</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>Script name</para>
            /// 
            /// <b>Example:</b>
            /// <para>催收话术</para>
            /// </summary>
            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <para>Script status</para>
            /// 
            /// <b>Example:</b>
            /// <para>DRAFTED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>TTS configuration for the script</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;appKey&quot;: &quot;oQDVNlE6fZ5mg46X&quot;,
            ///     &quot;engine&quot;: &quot;ali&quot;,
            ///     &quot;engineXunfei&quot;: &quot;&quot;,
            ///     &quot;globalInterruptible&quot;: true,
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
            /// <para>Time when the script was last updated</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578881227000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the call succeeded</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

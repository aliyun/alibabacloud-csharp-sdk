// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeScriptResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("NlsConfig")]
        [Validation(Required=false)]
        public string NlsConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Script")]
        [Validation(Required=false)]
        public DescribeScriptResponseBodyScript Script { get; set; }
        public class DescribeScriptResponseBodyScript : TeaModel {
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public long? AgentId { get; set; }

            [NameInMap("AgentKey")]
            [Validation(Required=false)]
            public string AgentKey { get; set; }

            [NameInMap("AgentLlm")]
            [Validation(Required=false)]
            public bool? AgentLlm { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;AppKey\&quot;:\&quot;3GHttnsvir1FeWWb\&quot;}</para>
            /// </summary>
            [NameInMap("AsrConfig")]
            [Validation(Required=false)]
            public string AsrConfig { get; set; }

            [NameInMap("ChatConfig")]
            [Validation(Required=false)]
            public string ChatConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>chatbot-cn-EJfqqa***</para>
            /// </summary>
            [NameInMap("ChatbotId")]
            [Validation(Required=false)]
            public string ChatbotId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DRAFTED</para>
            /// </summary>
            [NameInMap("DebugStatus")]
            [Validation(Required=false)]
            public string DebugStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EmotionEnable")]
            [Validation(Required=false)]
            public bool? EmotionEnable { get; set; }

            [NameInMap("Industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDebugDrafted")]
            [Validation(Required=false)]
            public bool? IsDebugDrafted { get; set; }

            /// <summary>
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
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("LongWaitEnable")]
            [Validation(Required=false)]
            public bool? LongWaitEnable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MiniPlaybackEnable")]
            [Validation(Required=false)]
            public bool? MiniPlaybackEnable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NewBargeInEnable")]
            [Validation(Required=false)]
            public bool? NewBargeInEnable { get; set; }

            [NameInMap("NluEngine")]
            [Validation(Required=false)]
            public string NluEngine { get; set; }

            [NameInMap("NluProfile")]
            [Validation(Required=false)]
            public DescribeScriptResponseBodyScriptNluProfile NluProfile { get; set; }
            public class DescribeScriptResponseBodyScriptNluProfile : TeaModel {
                [NameInMap("FcFunction")]
                [Validation(Required=false)]
                public string FcFunction { get; set; }

                [NameInMap("FcHttpTriggerUrl")]
                [Validation(Required=false)]
                public string FcHttpTriggerUrl { get; set; }

                [NameInMap("FcRegion")]
                [Validation(Required=false)]
                public string FcRegion { get; set; }

                [NameInMap("SupportBeebotPrompts")]
                [Validation(Required=false)]
                public bool? SupportBeebotPrompts { get; set; }

            }

            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            [NameInMap("ScriptDescription")]
            [Validation(Required=false)]
            public string ScriptDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>810b5872-57f0-4b27-80ab-7b3f4d8a6374</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DRAFTED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;voice\&quot;:\&quot;xiaobei\&quot;,\&quot;volume\&quot;:\&quot;50\&quot;,\&quot;speechRate\&quot;:\&quot;-150\&quot;,\&quot;pitchRate\&quot;:\&quot;0\&quot;}</para>
            /// </summary>
            [NameInMap("TtsConfig")]
            [Validation(Required=false)]
            public string TtsConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1578881227000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyScriptRequest : TeaModel {
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
        /// <para>{\&quot;AppKey\&quot;:\&quot;kknxKIhTTUcpCzYX\&quot;}</para>
        /// </summary>
        [NameInMap("AsrConfig")]
        [Validation(Required=false)]
        public string AsrConfig { get; set; }

        [NameInMap("ChatConfig")]
        [Validation(Required=false)]
        public string ChatConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>chatbot-cn-iFZfi7eq6e</para>
        /// </summary>
        [NameInMap("ChatbotId")]
        [Validation(Required=false)]
        public string ChatbotId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EmotionEnable")]
        [Validation(Required=false)]
        public bool? EmotionEnable { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c6320d3c-fa45-4011-b3b1-acdfabe3a8c6</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("LongWaitEnable")]
        [Validation(Required=false)]
        public bool? LongWaitEnable { get; set; }

        [NameInMap("MiniPlaybackConfigListJsonString")]
        [Validation(Required=false)]
        public string MiniPlaybackConfigListJsonString { get; set; }

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

        [NameInMap("NlsConfig")]
        [Validation(Required=false)]
        public string NlsConfig { get; set; }

        [NameInMap("NluAccessType")]
        [Validation(Required=false)]
        public string NluAccessType { get; set; }

        [NameInMap("NluEngine")]
        [Validation(Required=false)]
        public string NluEngine { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("ScriptContent")]
        [Validation(Required=false)]
        public List<string> ScriptContent { get; set; }

        [NameInMap("ScriptDescription")]
        [Validation(Required=false)]
        public string ScriptDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c153d0d8-ba04-41c0-8632-453944c9dd0b</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ScriptName")]
        [Validation(Required=false)]
        public string ScriptName { get; set; }

        [NameInMap("ScriptWaveform")]
        [Validation(Required=false)]
        public List<string> ScriptWaveform { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;voice\&quot;:\&quot;siyue\&quot;,\&quot;volume\&quot;:\&quot;50\&quot;,\&quot;speechRate\&quot;:\&quot;-150\&quot;,\&quot;pitchRate\&quot;:\&quot;0\&quot;}</para>
        /// </summary>
        [NameInMap("TtsConfig")]
        [Validation(Required=false)]
        public string TtsConfig { get; set; }

    }

}

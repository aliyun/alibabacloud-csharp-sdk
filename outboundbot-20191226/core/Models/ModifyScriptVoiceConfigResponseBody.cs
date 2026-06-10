// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyScriptVoiceConfigResponseBody : TeaModel {
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The voice configuration for the script.</para>
        /// </summary>
        [NameInMap("ScriptVoiceConfig")]
        [Validation(Required=false)]
        public ModifyScriptVoiceConfigResponseBodyScriptVoiceConfig ScriptVoiceConfig { get; set; }
        public class ModifyScriptVoiceConfigResponseBodyScriptVoiceConfig : TeaModel {
            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bdd49242-114c-4045-b1d1-25ccc1756c75</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The text that corresponds to the audio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>你好</para>
            /// </summary>
            [NameInMap("ScriptContent")]
            [Validation(Required=false)]
            public string ScriptContent { get; set; }

            /// <summary>
            /// <para>The script ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1d7a26e0-628b-4c3c-9918-7f2e23273f54</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>The script voice configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4ddea690-6534-4c88-9cbd-0b5882ec64c0</para>
            /// </summary>
            [NameInMap("ScriptVoiceConfigId")]
            [Validation(Required=false)]
            public string ScriptVoiceConfigId { get; set; }

            /// <summary>
            /// <para>Maps script segments to audio recordings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;ScriptContent&quot;:&quot;你好&quot;,&quot;ScriptWaveformId&quot;:&quot;6facc560-9f25-420f-bb0b-99f4299ad0d5&quot;},{&quot;ScriptContent&quot;:&quot;吗&quot;,&quot;ScriptWaveformId&quot;:&quot;76f48266-e253-4f44-ab4f-f64f7d38f1b4&quot;}]</para>
            /// </summary>
            [NameInMap("ScriptWaveformRelation")]
            [Validation(Required=false)]
            public string ScriptWaveformRelation { get; set; }

            /// <summary>
            /// <para>The script source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DIALOGUE_FLOW</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The audio source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WAVEFORM</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

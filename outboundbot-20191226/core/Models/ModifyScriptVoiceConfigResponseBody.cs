// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyScriptVoiceConfigResponseBody : TeaModel {
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
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScriptVoiceConfig")]
        [Validation(Required=false)]
        public ModifyScriptVoiceConfigResponseBodyScriptVoiceConfig ScriptVoiceConfig { get; set; }
        public class ModifyScriptVoiceConfigResponseBodyScriptVoiceConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>bdd49242-114c-4045-b1d1-25ccc1756c75</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("ScriptContent")]
            [Validation(Required=false)]
            public string ScriptContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1d7a26e0-628b-4c3c-9918-7f2e23273f54</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4ddea690-6534-4c88-9cbd-0b5882ec64c0</para>
            /// </summary>
            [NameInMap("ScriptVoiceConfigId")]
            [Validation(Required=false)]
            public string ScriptVoiceConfigId { get; set; }

            [NameInMap("ScriptWaveformRelation")]
            [Validation(Required=false)]
            public string ScriptWaveformRelation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DIALOGUE_FLOW</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WAVEFORM</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

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

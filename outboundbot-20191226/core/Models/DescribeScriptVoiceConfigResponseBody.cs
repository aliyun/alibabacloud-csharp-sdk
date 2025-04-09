// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeScriptVoiceConfigResponseBody : TeaModel {
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
        public DescribeScriptVoiceConfigResponseBodyScriptVoiceConfig ScriptVoiceConfig { get; set; }
        public class DescribeScriptVoiceConfigResponseBodyScriptVoiceConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>291cfc6a-8703-4bdd-a99d-9cba32d5288a</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("ScriptContent")]
            [Validation(Required=false)]
            public string ScriptContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>947e0875-b5d4-4b33-b18c-7b2cf85bcb4f</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2a07b634-e15d-445f-bbcb-fc4ea2df7b87</para>
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

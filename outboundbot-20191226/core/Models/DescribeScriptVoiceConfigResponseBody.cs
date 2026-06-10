// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeScriptVoiceConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
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
        /// <para>The response message.</para>
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
        /// <para>The details of the script voice configuration.</para>
        /// </summary>
        [NameInMap("ScriptVoiceConfig")]
        [Validation(Required=false)]
        public DescribeScriptVoiceConfigResponseBodyScriptVoiceConfig ScriptVoiceConfig { get; set; }
        public class DescribeScriptVoiceConfigResponseBodyScriptVoiceConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>291cfc6a-8703-4bdd-a99d-9cba32d5288a</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The script content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>你的花呗欠款逾期了需要处理，你现在能处理一下吗？</para>
            /// </summary>
            [NameInMap("ScriptContent")]
            [Validation(Required=false)]
            public string ScriptContent { get; set; }

            /// <summary>
            /// <para>The ID of the script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>947e0875-b5d4-4b33-b18c-7b2cf85bcb4f</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>The ID of the script voice configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2a07b634-e15d-445f-bbcb-fc4ea2df7b87</para>
            /// </summary>
            [NameInMap("ScriptVoiceConfigId")]
            [Validation(Required=false)]
            public string ScriptVoiceConfigId { get; set; }

            /// <summary>
            /// <para>The script waveform relation data. Returned only when <c>Type</c> is <c>WAVEFORM</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;ScriptContent&quot;:&quot;请问你是&quot;,&quot;ScriptWaveformId&quot;:&quot;07db2f0a-acb2-4e68-b9f4-66397414f50c&quot;},{&quot;ScriptContent&quot;:&quot;吗？&quot;,&quot;ScriptWaveformId&quot;:&quot;c2a69440-03e3-406e-b0a9-a9791fccb31b&quot;}]</para>
            /// </summary>
            [NameInMap("ScriptWaveformRelation")]
            [Validation(Required=false)]
            public string ScriptWaveformRelation { get; set; }

            /// <summary>
            /// <para>The source of the script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DIALOGUE_FLOW</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The type of the voice configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>WAVEFORM</c>: A recording.</para>
            /// </description></item>
            /// <item><description><para><c>TTS</c>: Text-to-speech.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TTS</para>
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

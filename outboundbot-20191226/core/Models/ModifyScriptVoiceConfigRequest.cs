// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyScriptVoiceConfigRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bdd49242-114c-4045-b1d1-25ccc1756c75</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The script ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d7a26e0-628b-4c3c-9918-7f2e23273f54</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The script voice configuration ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e15cc646-50e5-4bc0-87ec-e4f2d1063b90</para>
        /// </summary>
        [NameInMap("ScriptVoiceConfigId")]
        [Validation(Required=false)]
        public string ScriptVoiceConfigId { get; set; }

        /// <summary>
        /// <para>Maps script segments to audio recordings. This parameter is required only when Type is set to WAVEFORM.</para>
        /// <remarks>
        /// <para>To obtain the value for the ScriptWaveformId parameter, call the CreateScriptWaveform operation. The ScriptContent parameter specifies the text that corresponds to the audio segment.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ScriptContent&quot;:&quot;请问你是&quot;,&quot;ScriptWaveformId&quot;:&quot;07db2f0a-acb2-4e68-b9f4-66397414f50c&quot;},{&quot;ScriptContent&quot;:&quot;吗？&quot;,&quot;ScriptWaveformId&quot;:&quot;c2a69440-03e3-406e-b0a9-a9791fccb31b&quot;}]</para>
        /// </summary>
        [NameInMap("ScriptWaveformRelation")]
        [Validation(Required=false)]
        public string ScriptWaveformRelation { get; set; }

        /// <summary>
        /// <para>The audio source type.</para>
        /// <list type="bullet">
        /// <item><description><para>WAVEFORM: A pre-recorded audio file.</para>
        /// </description></item>
        /// <item><description><para>TTS: Audio generated from text using the text-to-speech (TTS) service.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TTS</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

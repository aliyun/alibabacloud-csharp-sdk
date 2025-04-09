// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyScriptVoiceConfigRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bdd49242-114c-4045-b1d1-25ccc1756c75</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d7a26e0-628b-4c3c-9918-7f2e23273f54</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e15cc646-50e5-4bc0-87ec-e4f2d1063b90</para>
        /// </summary>
        [NameInMap("ScriptVoiceConfigId")]
        [Validation(Required=false)]
        public string ScriptVoiceConfigId { get; set; }

        [NameInMap("ScriptWaveformRelation")]
        [Validation(Required=false)]
        public string ScriptWaveformRelation { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WAVEFORM</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

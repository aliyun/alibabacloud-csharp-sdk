// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class CreateScriptVersionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abb4aa26-3a8e-43dd-82f8-0c3898c9c67f</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The interaction configuration.</para>
        /// </summary>
        [NameInMap("InteractionConfig")]
        [Validation(Required=false)]
        public string InteractionConfigShrink { get; set; }

        /// <summary>
        /// <para>The custom label configuration.</para>
        /// </summary>
        [NameInMap("LabelConfig")]
        [Validation(Required=false)]
        public string LabelConfigShrink { get; set; }

        /// <summary>
        /// <para>The scenario ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64241e64-190c-45d1-af66-06f51c07b090</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The conversation capability configuration.</para>
        /// </summary>
        [NameInMap("ScriptProfile")]
        [Validation(Required=false)]
        public string ScriptProfileShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>d7b8a210-1f2d-4c5b-8a63-01e4f3b7c9d2</para>
        /// </summary>
        [NameInMap("SourceVersionId")]
        [Validation(Required=false)]
        public string SourceVersionId { get; set; }

        /// <summary>
        /// <para>The TTS configuration.</para>
        /// </summary>
        [NameInMap("SynthesizerConfig")]
        [Validation(Required=false)]
        public string SynthesizerConfigShrink { get; set; }

        /// <summary>
        /// <para>The ASR configuration.</para>
        /// </summary>
        [NameInMap("TranscriberConfig")]
        [Validation(Required=false)]
        public string TranscriberConfigShrink { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class CreateScriptVersionShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>abb4aa26-3a8e-43dd-82f8-0c3898c9c67f</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InteractionConfig")]
        [Validation(Required=false)]
        public string InteractionConfigShrink { get; set; }

        [NameInMap("LabelConfig")]
        [Validation(Required=false)]
        public string LabelConfigShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>64241e64-190c-45d1-af66-06f51c07b090</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        [NameInMap("ScriptProfile")]
        [Validation(Required=false)]
        public string ScriptProfileShrink { get; set; }

        [NameInMap("SourceVersionId")]
        [Validation(Required=false)]
        public string SourceVersionId { get; set; }

        [NameInMap("SynthesizerConfig")]
        [Validation(Required=false)]
        public string SynthesizerConfigShrink { get; set; }

        [NameInMap("TranscriberConfig")]
        [Validation(Required=false)]
        public string TranscriberConfigShrink { get; set; }

    }

}

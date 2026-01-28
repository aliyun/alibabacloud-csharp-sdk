// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianVoiceBot20250101.Models
{
    public class CreateApplicationVersionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a395011f-a247-400f-bc69-28796749fd52</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-c11iig67g863rih8</para>
        /// </summary>
        [NameInMap("BusinessUnitId")]
        [Validation(Required=false)]
        public string BusinessUnitId { get; set; }

        [NameInMap("InteractionConfig")]
        [Validation(Required=false)]
        public string InteractionConfigShrink { get; set; }

        [NameInMap("ScriptProfile")]
        [Validation(Required=false)]
        public string ScriptProfileShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20904943-f711-494f-9f1f-e7f340f37707</para>
        /// </summary>
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

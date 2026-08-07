// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class CreateScriptVersionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>实例ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>交互配置</para>
        /// </summary>
        [NameInMap("InteractionConfig")]
        [Validation(Required=false)]
        public string InteractionConfigShrink { get; set; }

        /// <summary>
        /// <para>草稿版本的标签配置（JSON字符串）</para>
        /// </summary>
        [NameInMap("LabelConfigs")]
        [Validation(Required=false)]
        public string LabelConfigsShrink { get; set; }

        /// <summary>
        /// <para>场景ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b15</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>话术配置</para>
        /// </summary>
        [NameInMap("ScriptProfile")]
        [Validation(Required=false)]
        public string ScriptProfileShrink { get; set; }

        /// <summary>
        /// <para>源版本ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b26</para>
        /// </summary>
        [NameInMap("SourceVersionId")]
        [Validation(Required=false)]
        public string SourceVersionId { get; set; }

        /// <summary>
        /// <para>语音合成配置</para>
        /// </summary>
        [NameInMap("SynthesizerConfig")]
        [Validation(Required=false)]
        public string SynthesizerConfigShrink { get; set; }

        /// <summary>
        /// <para>语音识别配置</para>
        /// </summary>
        [NameInMap("TranscriberConfig")]
        [Validation(Required=false)]
        public string TranscriberConfigShrink { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ModelSetModelProfile : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>通义千问系列速度最快、成本很低的模型，适合简单任务。本模型是动态更新版本，模型更新不会提前通知，模型中英文综合能力显著提升，模型人类偏好显著提升，模型推理能力和复杂指令理解能力显著增强，困难任务上的表现更优，数学、代码能力显著提升。</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>通义千问-Turbo-Latest</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-turbo-latest</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("props")]
        [Validation(Required=false)]
        public ModelSetModelProfileProps Props { get; set; }
        public class ModelSetModelProfileProps : TeaModel {
            [NameInMap("contextSize")]
            [Validation(Required=false)]
            public long? ContextSize { get; set; }

            [NameInMap("llmMode")]
            [Validation(Required=false)]
            public string LlmMode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>predefined</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}

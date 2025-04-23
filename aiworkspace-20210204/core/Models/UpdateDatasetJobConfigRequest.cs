// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateDatasetJobConfigRequest : TeaModel {
        /// <summary>
        /// <para>The configuration content. Formats:</para>
        /// <list type="bullet">
        /// <item><description>MultimodalIntelligentTag</description></item>
        /// </list>
        /// <para>{ &quot;apiKey&quot;:&quot;sk-xxxxxxxxxxxxxxxxxxxxx&quot; }</para>
        /// <list type="bullet">
        /// <item><description>MultimodalSemanticIndex</description></item>
        /// </list>
        /// <para>{ &quot;defaultModelId&quot;: &quot;xxx&quot; &quot;defaultModelVersion&quot;:&quot;1.0.0&quot; }</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;apiKey&quot;:&quot;sk-xxxxxxxxxxxxxxxxxxxxx&quot; }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The configuration type.</para>
        /// <list type="bullet">
        /// <item><description>MultimodalIntelligentTag</description></item>
        /// <item><description>MultimodalSemanticIndex</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MultimodalSemanticIndex</para>
        /// </summary>
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>167497</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

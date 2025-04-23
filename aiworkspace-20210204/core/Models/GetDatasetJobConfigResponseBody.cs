// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetDatasetJobConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration content. Configuration format for MultimodalIntelligentTag:</para>
        /// <para>{ &quot;apiKey&quot;:&quot;sk-xxxxxxxxxxxxxxxxxxxxx&quot; }</para>
        /// <para>MultimodalSemanticIndex</para>
        /// <para>{ &quot;defaultModelId&quot;: &quot;xxx&quot; &quot;defaultModelVersion&quot;:&quot;1.0.0&quot; }</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;apiKey&quot;:&quot;sk-xxxxxxxxxxxxxxxxxxxxx&quot; }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The configuration type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MultimodalIntelligentTag</description></item>
        /// <item><description>MultimodalSemanticIndex</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MultimodalIntelligentTag</para>
        /// </summary>
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        /// <summary>
        /// <para>The time when the configuration is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-10-16T01:44:10Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The dataset ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-lfd60v0p****ujtsdx</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>The time when the configuration is modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-26T02:17:18Z</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D5BFFEE3-6025-443F-8A03-02D619B5C4B9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>114243</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

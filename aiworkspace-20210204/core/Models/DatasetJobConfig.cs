// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DatasetJobConfig : TeaModel {
        /// <summary>
        /// <para>The content of the dataset job configuration, in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;apiKey&quot;:&quot;sk-xxxxxxxxxxxxxxxxxxxxx&quot; }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The type of the dataset job configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MultimodalIntelligentTag</para>
        /// </summary>
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        /// <summary>
        /// <para>The time when the dataset job was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-14T01:37:37Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The ID of the dataset job configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dscfg-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DatasetJobConfigId")]
        [Validation(Required=false)]
        public string DatasetJobConfigId { get; set; }

        [NameInMap("DatasetVersion")]
        [Validation(Required=false)]
        public string DatasetVersion { get; set; }

        /// <summary>
        /// <para>The time when the dataset job was modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-10-11T02:18:54Z</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>234*34</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

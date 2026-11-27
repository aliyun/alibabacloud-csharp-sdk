// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RecipeResourceView : TeaModel {
        /// <summary>
        /// <para>资源池行 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public long? ResourceId { get; set; }

        /// <summary>
        /// <para>资源池类型，取值：train / eval</para>
        /// 
        /// <b>Example:</b>
        /// <para>train</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>资源规格列表，采用 CustomJob 资源形状（与入参 open_struct_RecipeSpec 同构），回显存储值</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;PodCount&quot;:1,&quot;CPU&quot;:&quot;4&quot;,&quot;Memory&quot;:&quot;8Gi&quot;,&quot;GPU&quot;:&quot;1&quot;,&quot;GPUType&quot;:&quot;A100&quot;,&quot;QuotaId&quot;:&quot;quotag2uo09dyp40&quot;}]</para>
        /// </summary>
        [NameInMap("Specs")]
        [Validation(Required=false)]
        public List<RecipeSpec> Specs { get; set; }

    }

}

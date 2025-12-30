// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PolardbAI20251013.Models
{
    public class CreateMultimodalSearchTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2ze454l20me07****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;ds-1&quot;, &quot;ds-2&quot;]</para>
        /// </summary>
        [NameInMap("DatasetIds")]
        [Validation(Required=false)]
        public string DatasetIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Multimodal-Embedding</para>
        /// </summary>
        [NameInMap("EmbeddingModel")]
        [Validation(Required=false)]
        public string EmbeddingModel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>指示牌</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Multimodal-Search</para>
        /// </summary>
        [NameInMap("SearchModel")]
        [Validation(Required=false)]
        public string SearchModel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

    }

}

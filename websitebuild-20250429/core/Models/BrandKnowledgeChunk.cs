// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class BrandKnowledgeChunk : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>chunk_example001</para>
        /// </summary>
        [NameInMap("ChunkId")]
        [Validation(Required=false)]
        public string ChunkId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例科技提供企业软件服务。</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>产品与服务</para>
        /// </summary>
        [NameInMap("HierarchicalTitle")]
        [Validation(Required=false)]
        public string HierarchicalTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}

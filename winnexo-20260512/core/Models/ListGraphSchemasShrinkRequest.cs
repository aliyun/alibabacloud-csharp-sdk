// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListGraphSchemasShrinkRequest : TeaModel {
        /// <summary>
        /// <para>关键词，匹配 graphName / displayName（可选，忽略大小写）</para>
        /// 
        /// <b>Example:</b>
        /// <para>crm</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>语义标签过滤（可选，命中任一标签即保留）</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;销售&quot;]</para>
        /// </summary>
        [NameInMap("semanticTags")]
        [Validation(Required=false)]
        public string SemanticTagsShrink { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数，缺省时使用调用方默认租户</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}

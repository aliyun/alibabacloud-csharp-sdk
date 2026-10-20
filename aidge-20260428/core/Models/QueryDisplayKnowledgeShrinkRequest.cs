// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class QueryDisplayKnowledgeShrinkRequest : Darabonba.Model {
        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The knowledge base ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rag_xxx</para>
        /// </summary>
        [NameInMap("RagId")]
        [Validation(Required=false)]
        public string RagId { get; set; }

        /// <summary>
        /// <para>The SKU ID for exact match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sku-001</para>
        /// </summary>
        [NameInMap("SkuId")]
        [Validation(Required=false)]
        public string SkuId { get; set; }

        /// <summary>
        /// <para>The keyword in the SKU name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Product front image</para>
        /// </summary>
        [NameInMap("SkuName")]
        [Validation(Required=false)]
        public string SkuName { get; set; }

        /// <summary>
        /// <para>The list of record statuses. Valid values: UPDATING, EMBEDDED, and FAILED.</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public string StatusesShrink { get; set; }

    }

}


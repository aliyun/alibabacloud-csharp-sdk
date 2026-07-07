// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class CategoryListQuery : TeaModel {
        /// <summary>
        /// <para>Collection of category IDs</para>
        /// </summary>
        [NameInMap("categoryIds")]
        [Validation(Required=false)]
        public List<long?> CategoryIds { get; set; }

        /// <summary>
        /// <para>Parent category ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>5200001</para>
        /// </summary>
        [NameInMap("parentCategoryId")]
        [Validation(Required=false)]
        public long? ParentCategoryId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class DeleteAssetCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The category ID. You can obtain the value by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>When you create a category by calling the CreateAssetCategory operation, the category ID is the value of CategoryId in the response.</description></item>
        /// <item><description>When you query categories by calling the ListAssetCategories operation, the category ID is the value of CategoryId in the corresponding entry in the response.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GetAssetCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The category ID. You can obtain the category ID by using the following methods:</para>
        /// <list type="bullet">
        /// <item><description><para>When you create a category by calling the CreateAssetCategory operation, the category ID is the value of CategoryId in the response.</para>
        /// </description></item>
        /// <item><description><para>When you query the category list by calling the ListAssetCategories operation, the category ID is the value of CategoryId in the corresponding entry in the response.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>scenery</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

    }

}

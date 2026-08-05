// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The category ID. You can obtain the category ID by using the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://ims.console.aliyun.com">IMS console</a>, and choose <b>Media Asset Management</b> &gt; <b>Category Management</b> to view the category ID.</description></item>
        /// <item><description>When you create a category by calling the create category operation, the category ID is the value of the CateId response parameter.</description></item>
        /// <item><description>When you query a category by calling the get category operation, the category ID is the value of the CateId response parameter.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43</para>
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// <para>The category name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Category 1</para>
        /// </summary>
        [NameInMap("CateName")]
        [Validation(Required=false)]
        public string CateName { get; set; }

    }

}

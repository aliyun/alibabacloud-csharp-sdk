// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The category ID. You can specify only one category ID. You can obtain the category ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Configuration management</b> &gt; <b>Media asset management configuration</b> &gt; <b>Category management</b> to view the category ID.</description></item>
        /// <item><description>Call the <a href="~~AddCategory~~">AddCategory</a> operation to create a category. The category ID is returned in the response.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the specified category ID is the ID of a parent category, the parent category and all its subcategories are deleted. Proceed with caution.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3300****</para>
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

    }

}

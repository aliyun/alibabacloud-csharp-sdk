// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the category. You can specify only one ID. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. Choose <b>Configuration Management</b> &gt; <b>Media Management</b> &gt; <b>Categories</b>. On the Audio and Video / Image Category or Short Video Material Category tab, view the category ID.</description></item>
        /// <item><description>Obtain the category ID from the response to the <a href="~~AddCategory~~">AddCategory</a> operation.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you specify the ID of a parent category, all subcategories under the parent category are deleted at the same time.</para>
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

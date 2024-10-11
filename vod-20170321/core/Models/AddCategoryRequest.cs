// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The name of the category.</para>
        /// <list type="bullet">
        /// <item><description>The value can be up to 64 bytes in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("CateName")]
        [Validation(Required=false)]
        public string CateName { get; set; }

        /// <summary>
        /// <para>The ID of the parent category.</para>
        /// <para>To obtain the category ID, perform the following steps: Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. Choose <b>Configuration Management</b> &gt; <b>Media Management</b> &gt; <b>Categories</b>. On the <b>Audio and Video / Image Category</b> or <b>Short Video Material Category</b> tab, view the category ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, the system creates a subcategory under the parent category. If you leave this parameter empty, the system creates a level 1 category.</description></item>
        /// <item><description>You cannot modify, add, or delete level 1 categories of short video materials. You can create only subcategories under level 1 categories for short video materials. This parameter is required when you set <c>Type</c> to <c>material</c>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100012****</para>
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// <para>The type of the category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b> (default): audio, video, and image files</description></item>
        /// <item><description><b>material</b>: short video materials</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

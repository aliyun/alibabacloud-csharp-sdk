// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The category name.</para>
        /// <list type="bullet">
        /// <item><description>It can be up to 64 bytes in length.</description></item>
        /// <item><description>It must be encoded in UTF-8.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Comedy</para>
        /// </summary>
        [NameInMap("CateName")]
        [Validation(Required=false)]
        public string CateName { get; set; }

        /// <summary>
        /// <para>The ID of the parent category.</para>
        /// <para>You can log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Configuration management</b> &gt; <b>Media asset management configuration</b> &gt; <b>Category management</b> &gt; <b>Audio, video, and image categories</b> or <b>Short video material categories</b> to view the category ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, a subcategory is created under the specified parent category. If you do not specify this parameter, a level-1 category is created.</description></item>
        /// <item><description>All level-1 categories for short video materials are built-in and cannot be modified, added, or deleted. You can only create subcategories under level-1 categories. Therefore, this parameter is required when <c>Type</c> is set to <c>material</c>.</description></item>
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
        /// <para>The category type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b>: audio, video, and image categories. This is the default value.</description></item>
        /// <item><description><b>material</b>: short video material categories.</description></item>
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

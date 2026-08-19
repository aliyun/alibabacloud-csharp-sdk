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
        /// <item><description>Maximum length: 64 bytes.</description></item>
        /// <item><description>UTF-8 encoded.</description></item>
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
        /// <para>The parent category ID.</para>
        /// <para>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Configuration Management</b> &gt; <b>Media Management Configuration</b> &gt; <b>Category Management</b> &gt; <b>Audio/Video/Image Categories</b> or <b>Short Video Material Categories</b> to view category IDs.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, a subcategory is created under the specified parent category. If you do not specify this parameter, a level-0 category is created.</description></item>
        /// <item><description>Because all level-0 categories for short video materials are built-in and cannot be modified, added, or deleted, only subcategories can be created under level-0 categories. Therefore, this parameter is required when <c>Type</c> is set to <c>material</c>.</description></item>
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
        /// <item><description><b>default</b> (default): audio/video/image category.</description></item>
        /// <item><description><b>material</b>: short video material category.</description></item>
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

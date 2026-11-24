// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The category ID. You can specify only one category ID. You can obtain the category ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Configuration Management</b> &gt; <b>Media Asset Management Configuration</b> &gt; <b>Category Management</b> &gt; <b>Audio/Video and Image Categories</b> or <b>Short Video Material Categories</b> to view the category ID.</description></item>
        /// <item><description>The category ID is returned when you call the <a href="~~AddCategory~~">AddCategory</a> operation to create a category.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10020****</para>
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// <para>The category name.</para>
        /// <list type="bullet">
        /// <item><description>The name can be up to 64 bytes in length.</description></item>
        /// <item><description>The name must be encoded in UTF-8.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Landscape</para>
        /// </summary>
        [NameInMap("CateName")]
        [Validation(Required=false)]
        public string CateName { get; set; }

    }

}

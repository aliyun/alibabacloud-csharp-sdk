// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the category. You can specify only one ID. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. Choose <b>Configuration Management</b> &gt; <b>Media Management</b> &gt; <b>Categories</b>. On the <b>Audio and Video / Image Category</b> or <b>Short Video Material Category</b> tab, view the category ID.</description></item>
        /// <item><description>Obtain the category ID from the response to the <a href="~~AddCategory~~">AddCategory</a> operation.</description></item>
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
        /// <para>The name of the category.</para>
        /// <list type="bullet">
        /// <item><description>The value can be up to 64 bytes in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beauty</para>
        /// </summary>
        [NameInMap("CateName")]
        [Validation(Required=false)]
        public string CateName { get; set; }

    }

}

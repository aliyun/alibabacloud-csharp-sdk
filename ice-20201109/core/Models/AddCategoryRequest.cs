// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AddCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The category name.</para>
        /// <list type="bullet">
        /// <item><description><para>The value can be up to 64 bytes in length.</para>
        /// </description></item>
        /// <item><description><para>The value must be encoded in UTF-8.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Third-level subcategory</para>
        /// </summary>
        [NameInMap("CateName")]
        [Validation(Required=false)]
        public string CateName { get; set; }

        /// <summary>
        /// <para>The ID of the parent category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// <para>The type of the category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>default: audio, video, and image files. This is the default value.</para>
        /// </description></item>
        /// <item><description><para>material: short video materials.</para>
        /// </description></item>
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

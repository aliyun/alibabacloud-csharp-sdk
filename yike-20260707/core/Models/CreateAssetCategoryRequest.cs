// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class CreateAssetCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The name of the category.</para>
        /// <para>The name can be up to 64 bytes in length.</para>
        /// <para>The name must be encoded in UTF-8.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Third-level subcategory</para>
        /// </summary>
        [NameInMap("CategoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// <para>The ID of the parent category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

    }

}

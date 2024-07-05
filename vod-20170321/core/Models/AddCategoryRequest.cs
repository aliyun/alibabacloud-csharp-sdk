// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddCategoryRequest : TeaModel {
        /// <summary>
        /// The name of the category.
        /// 
        /// *   The value can be up to 64 bytes in length.
        /// *   The value must be encoded in UTF-8.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CateName")]
        [Validation(Required=false)]
        public string CateName { get; set; }

        /// <summary>
        /// The ID of the parent category.
        /// 
        /// To obtain the category ID, perform the following steps: Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). Choose **Configuration Management** > **Media Management** > **Categories**. On the **Audio and Video / Image Category** or **Short Video Material Category** tab, view the category ID.
        /// 
        /// > *   If you specify this parameter, the system creates a subcategory under the parent category. If you leave this parameter empty, the system creates a level 1 category.
        /// >*   You cannot modify, add, or delete level 1 categories of short video materials. You can create only subcategories under level 1 categories for short video materials. This parameter is required when you set `Type` to `material`.
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// The type of the category. Valid values:
        /// 
        /// *   **default** (default): audio, video, and image files
        /// *   **material**: short video materials
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

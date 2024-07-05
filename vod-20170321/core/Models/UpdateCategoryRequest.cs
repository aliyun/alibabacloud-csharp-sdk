// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateCategoryRequest : TeaModel {
        /// <summary>
        /// The ID of the category. You can specify only one ID. You can use one of the following methods to obtain the ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). Choose **Configuration Management** > **Media Management** > **Categories**. On the **Audio and Video / Image Category** or **Short Video Material Category** tab, view the category ID.
        /// *   Obtain the category ID from the response to the [AddCategory](~~AddCategory~~) operation.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

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

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetCategoriesRequest : TeaModel {
        /// <summary>
        /// The ID of the category. If you specify this parameter, the system queries the category based on the ID. You can specify only one category ID. You can use one of the following methods to obtain the ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). Choose **Configuration Management** > **Media Management** > **Categories**. On the Audio and Video / Image Category or Short Video Material Category tab, view the category ID.
        /// *   Obtain the category ID from the response to the [AddCategory](~~AddCategory~~) operation.
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// The number of the page where the subcategories to be returned are listed. Default value: **1**.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// The number of entries to return on each page of the subcategory list. Default value: **10**. Maximum value: **100**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The sorting method of the results. Valid values:
        /// 
        /// *   **CreationTime:Desc** (default): The results are sorted in reverse chronological order based on the creation time.
        /// *   **CreationTime:Asc**: The results are sorted in chronological order based on the creation time.
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// The type of the category. If you specify this parameter, the system queries the category based on the type. Valid values:
        /// 
        /// *   **default** (default): audio, video, and image files
        /// *   **material**: short video materials
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

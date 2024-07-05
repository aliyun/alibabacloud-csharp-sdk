// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class MoveAppResourceRequest : TeaModel {
        /// <summary>
        /// The resource ID. You can specify a maximum of 20 IDs at a time. Separate multiple IDs with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// The resource type. Valid values:
        /// 
        /// *   **video**: video files.
        /// *   **image**: image files.
        /// *   **attached**: auxiliary media assets.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The ID of the application to which resources are migrated. Default value: **app-1000000**. For more information, see [Use the multi-application service](https://help.aliyun.com/document_detail/113600.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetAppId")]
        [Validation(Required=false)]
        public string TargetAppId { get; set; }

    }

}

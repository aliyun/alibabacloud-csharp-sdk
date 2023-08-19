// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class MoveAppResourceRequest : TeaModel {
        /// <summary>
        /// The ID of the resource. You can specify a maximum of 20 IDs at a time. Separate them with commas (,).
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// The type of the resource. Valid values:
        /// 
        /// *   **video**
        /// *   **image**
        /// *   **attached**
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The ID of the application to which resources are migrated. Default value: **app-1000000**. For more information, see [Overview](~~113600~~).
        /// </summary>
        [NameInMap("TargetAppId")]
        [Validation(Required=false)]
        public string TargetAppId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetResourceInventoryResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the resource inventory.
        /// </summary>
        [NameInMap("ResourceInventory")]
        [Validation(Required=false)]
        public GetResourceInventoryResponseBodyResourceInventory ResourceInventory { get; set; }
        public class GetResourceInventoryResponseBodyResourceInventory : TeaModel {
            /// <summary>
            /// The download URL of the resource inventory.
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// The time when the resource inventory was generated. The value is a timestamp.
            /// </summary>
            [NameInMap("ResourceInventoryGenerateTime")]
            [Validation(Required=false)]
            public long? ResourceInventoryGenerateTime { get; set; }

            /// <summary>
            /// The generation status of the resource inventory. Valid values:
            /// 
            /// *   CREATING: The resource inventory is being generated.
            /// *   COMPLETE: The resource inventory is generated.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}

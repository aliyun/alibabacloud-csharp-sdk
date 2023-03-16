// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateDIProjectConfigResponseBody : TeaModel {
        /// <summary>
        /// The information about the modification.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateDIProjectConfigResponseBodyData Data { get; set; }
        public class UpdateDIProjectConfigResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the default global configuration of synchronization solutions was modified. Valid values:
            /// 
            /// *   success: The default global configuration of synchronization solutions was modified.
            /// *   fail: The default global configuration of synchronization solutions failed to be modified.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request. You can use the ID to locate logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

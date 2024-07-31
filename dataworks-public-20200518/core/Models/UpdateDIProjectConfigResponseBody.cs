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
            /// Indicates whether the default global configuration of synchronization solutions is modified. Valid values:
            /// 
            /// *   success
            /// *   fail
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The request ID. You can locate logs and troubleshoot issues based on the ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

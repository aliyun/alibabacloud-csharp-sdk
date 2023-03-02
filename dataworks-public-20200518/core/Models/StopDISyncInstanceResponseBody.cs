// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class StopDISyncInstanceResponseBody : TeaModel {
        /// <summary>
        /// The information returned for the synchronization node.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public StopDISyncInstanceResponseBodyData Data { get; set; }
        public class StopDISyncInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// The reason why the synchronization node fails to be stopped.
            /// 
            /// If the synchronization node is stopped, the value null is returned.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// Indicates whether the synchronization node is stopped. Valid values:
            /// 
            /// *   success: The synchronization node is stopped.
            /// *   fail: The synchronization node fails to be stopped.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request. You can locate logs and troubleshoot issues based on the ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   true: The request is successful.
        /// *   false: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

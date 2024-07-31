// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class StartDISyncInstanceResponseBody : TeaModel {
        /// <summary>
        /// The result returned for the start.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public StartDISyncInstanceResponseBodyData Data { get; set; }
        public class StartDISyncInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// The reason why the real-time synchronization task or the data synchronization solution fails to be started.
            /// 
            /// If the real-time synchronization task or the data synchronization solution is started, the value null is returned.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// Indicates whether the real-time synchronization task or the data synchronization solution is started. Valid values:
            /// 
            /// *   success: The real-time synchronization task or the data synchronization solution is started.
            /// *   fail: The real-time synchronization task or the data synchronization solution fails to be started. You can troubleshoot the issue based on the provided cause.
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

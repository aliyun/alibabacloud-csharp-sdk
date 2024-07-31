// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TerminateDISyncInstanceResponseBody : TeaModel {
        /// <summary>
        /// The returned results.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TerminateDISyncInstanceResponseBodyData Data { get; set; }
        public class TerminateDISyncInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// The reason why the real-time synchronization task fails to be terminated. If the real-time synchronization task is undeployed, the value of this parameter is null.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// Indicates whether the real-time synchronization task is undeployed. Valid values:
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

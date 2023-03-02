// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TerminateDISyncInstanceResponseBody : TeaModel {
        /// <summary>
        /// The result of the operation.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TerminateDISyncInstanceResponseBodyData Data { get; set; }
        public class TerminateDISyncInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// The reason why the real-time synchronization node fails to be terminated. If the real-time synchronization node is terminated, this parameter is left empty.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// Indicates whether the real-time synchronization node is terminated. Valid values:
            /// 
            /// *   success
            /// *   fail
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request. You can query logs and troubleshoot issues based on the ID.
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class AbortChangeOrderResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the change order was terminated. Valid values:
        /// 
        /// *   **true**: The change order was terminated.
        /// *   **false**: The change order could not be terminated.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The ID of the change order.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AbortChangeOrderResponseBodyData Data { get; set; }
        public class AbortChangeOrderResponseBodyData : TeaModel {
            /// <summary>
            /// The error code.
            /// 
            /// *   The **ErrorCode** parameter is not returned when the request succeeds.
            /// *   The **ErrorCode** parameter is returned when the request fails. For more information, see **Error codes** in this topic.
            /// </summary>
            [NameInMap("ChangeOrderId")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }

        }

        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: indicates that the request was successful.
        /// *   **3xx**: indicates that the request was redirected.
        /// *   **4xx**: indicates that the request was invalid.
        /// *   **5xx**: indicates that a server error occurred.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The ID of the trace.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

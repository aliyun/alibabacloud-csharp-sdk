// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class BatchStopApplicationsResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the specified applications are stopped. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The ID of the change order.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchStopApplicationsResponseBodyData Data { get; set; }
        public class BatchStopApplicationsResponseBodyData : TeaModel {
            /// <summary>
            /// The error code.
            /// 
            /// *   If the request is successful, this parameter is not returned.****
            /// *   This parameter is returned only if the request failed.**** For more information, see the "**Error codes**" section in this topic.
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
        /// The ID of the trace. It can be used to query the details of a request.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The returned message.
        /// 
        /// *   **success** is returned when the request succeeds.
        /// *   An error code is returned when the request fails.
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DeleteApplicationResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the application is deleted. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The ID of the change order that is used to query the task execution status.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteApplicationResponseBodyData Data { get; set; }
        public class DeleteApplicationResponseBodyData : TeaModel {
            /// <summary>
            /// The error code that is returned if the request fails.
            /// 
            /// *   If the request is successful, this parameter is not returned.****
            /// *   This parameter is returned only if the request failed.**** For more information about the values of this parameter, see the "**Error codes**" section of this topic.
            /// </summary>
            [NameInMap("ChangeOrderId")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }

        }

        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: The request is successful.
        /// *   **3xx**: A redirection message is returned.
        /// *   **4xx**: The request is invalid.
        /// *   **5xx**: A server error occurred.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The trace ID that is used to query details of the request.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The returned message.
        /// 
        /// *   If the request is successful, **success** is returned.
        /// *   If an error occurred, the error code is returned.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The returned results.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

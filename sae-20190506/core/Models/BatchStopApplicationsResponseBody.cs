// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class BatchStopApplicationsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. Take note of the following rules:
        /// 
        /// - **2xx**: The call was successful.
        /// - **3xx**: The call was redirected.
        /// - **4xx**: The call failed.
        /// - **5xx**: A server error occurred.
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
        /// The error code returned if the request failed. Take note of the following rules:
        /// 
        /// - The ErrorCode parameter is not returned if the request succeeds.
        /// - If the call fails, the ErrorCode parameter is returned. For more information, see the "Error codes" section of this topic.
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

        /// <summary>
        /// Indicates whether the application is created. Valid values
        /// 
        /// - **true**
        /// - **false**
        /// </summary>
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

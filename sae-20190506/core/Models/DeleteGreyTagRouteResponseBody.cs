// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DeleteGreyTagRouteResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the information of the change order was queried. Valid values:
        /// 
        /// *   **true**: The information was queried.
        /// *   **false**: The information failed to be queried.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The ID of the canary release rule. The ID is globally unique.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteGreyTagRouteResponseBodyData Data { get; set; }
        public class DeleteGreyTagRouteResponseBodyData : TeaModel {
            /// <summary>
            /// The returned error code. Valid values:
            /// 
            /// *   If the call is successful, the **ErrorCode** parameter is not returned.
            /// *   If the call fails, the **ErrorCode** parameter is returned. For more information, see the "**Error codes**" section of this topic.
            /// </summary>
            [NameInMap("GreyTagRouteId")]
            [Validation(Required=false)]
            public long? GreyTagRouteId { get; set; }

        }

        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: The call was successful.
        /// *   **3xx**: The call was redirected.
        /// *   **4xx**: The call failed.
        /// *   **5xx**: A server error occurred.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The trace ID that is used to query the details of the request.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The returned information. Valid values:
        /// 
        /// *   success: If the call is successful, **success** is returned.
        /// *   An error code: If the call fails, an error code is returned.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The information about the canary release rule.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DeleteSecretResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: The call was successful.
        /// *   **3xx**: The call was redirected.
        /// *   **4xx**: The call failed.
        /// *   **5xx**: A server error occurred.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The response.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteSecretResponseBodyData Data { get; set; }
        public class DeleteSecretResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the deleted Secret.
            /// </summary>
            [NameInMap("SecretId")]
            [Validation(Required=false)]
            public long? SecretId { get; set; }

        }

        /// <summary>
        /// The error code returned. Valid values:
        /// 
        /// *   The **ErrorCode** parameter is not returned if the request succeeds.
        /// *   If the call fails, the **ErrorCode** parameter is returned. For more information, see the "**Error codes**" section of this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The additional information that is returned. Valid values:
        /// 
        /// *   success: If the call is successful, **success** is returned.
        /// *   An error code: If the call fails, an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the Secret is successfully deleted. Valid values:
        /// 
        /// *   **true**: The instance was deleted.
        /// *   **false**: The instance failed to be deleted.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The trace ID that is used to query the details of the request.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

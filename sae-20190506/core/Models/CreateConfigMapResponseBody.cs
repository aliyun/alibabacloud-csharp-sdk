// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateConfigMapResponseBody : TeaModel {
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
        /// The returned result.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateConfigMapResponseBodyData Data { get; set; }
        public class CreateConfigMapResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the ConfigMap that was created.
            /// </summary>
            [NameInMap("ConfigMapId")]
            [Validation(Required=false)]
            public long? ConfigMapId { get; set; }

        }

        /// <summary>
        /// The error code. Valid values:
        /// 
        /// *   If the call is successful, the **ErrorCode** parameter is not returned.
        /// *   If the call fails, the **ErrorCode** parameter is returned. For more information, see the **Error codes** section in this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the ConfigMap was created. Valid values:
        /// 
        /// *   **true**: The ConfigMap was created.
        /// *   **false**: The ConfigMap failed to be created.
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

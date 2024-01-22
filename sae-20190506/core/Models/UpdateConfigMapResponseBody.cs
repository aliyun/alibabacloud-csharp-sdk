// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateConfigMapResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the ConfigMap instance was updated. Valid values:
        /// 
        /// *   **true**: The instance was updated.
        /// *   **false**: The instance failed to be updated.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The ID of the ConfigMap instance.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateConfigMapResponseBodyData Data { get; set; }
        public class UpdateConfigMapResponseBodyData : TeaModel {
            /// <summary>
            /// The returned error code. Valid values:
            /// 
            /// *   If the call is successful, the **ErrorCode** parameter is not returned.
            /// *   If the call fails, the **ErrorCode** parameter is returned. For more information, see the "**Error codes**" section of this topic.
            /// </summary>
            [NameInMap("ConfigMapId")]
            [Validation(Required=false)]
            public string ConfigMapId { get; set; }

        }

        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx:**: indicates that the call was successful.
        /// *   **3xx**: indicates that the call was redirected.
        /// *   **4xx**: indicates that the call failed.
        /// *   **5xx**: indicates that a server error occurred.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The ID of the trace. The ID is used to query the details of a request.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The returned information.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

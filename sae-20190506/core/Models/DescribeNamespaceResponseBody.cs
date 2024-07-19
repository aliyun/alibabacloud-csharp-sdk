// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeNamespaceResponseBody : TeaModel {
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
        /// The information about the namespace.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeNamespaceResponseBodyData Data { get; set; }
        public class DescribeNamespaceResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the SAE built-in registry is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("EnableMicroRegistration")]
            [Validation(Required=false)]
            public bool? EnableMicroRegistration { get; set; }

            /// <summary>
            /// The short ID of the namespace.
            /// </summary>
            [NameInMap("NameSpaceShortId")]
            [Validation(Required=false)]
            public string NameSpaceShortId { get; set; }

            /// <summary>
            /// The description of the namespace.
            /// </summary>
            [NameInMap("NamespaceDescription")]
            [Validation(Required=false)]
            public string NamespaceDescription { get; set; }

            /// <summary>
            /// The ID of the namespace. The information about the default namespace cannot be queried or modified. The default namespace cannot be deleted.
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// The name of the namespace.
            /// </summary>
            [NameInMap("NamespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// The error code returned. Take note of the following rules:
        /// 
        /// *   The **ErrorCode** parameter is not returned if the request succeeds.
        /// *   The **ErrorCode** parameter is returned if the request fails. For more information, see the **Error codes** section in this topic.
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
        /// Indicates whether the information about the namespace was queried successfully. Valid values:
        /// 
        /// *   **true**: The information was queried.
        /// *   **false**: The image failed to be found.
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

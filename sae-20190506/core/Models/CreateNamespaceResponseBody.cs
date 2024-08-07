// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateNamespaceResponseBody : TeaModel {
        /// <summary>
        /// bucketPath
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The region where the namespace resides.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateNamespaceResponseBodyData Data { get; set; }
        public class CreateNamespaceResponseBodyData : TeaModel {
            [NameInMap("EnableMicroRegistration")]
            [Validation(Required=false)]
            public bool? EnableMicroRegistration { get; set; }

            /// <summary>
            /// Indicates whether the namespace was created. Valid values:
            /// 
            /// *   **true**: The instance was created.
            /// *   **false**: The call failed to be created.
            /// </summary>
            [NameInMap("NameSpaceShortId")]
            [Validation(Required=false)]
            public string NameSpaceShortId { get; set; }

            /// <summary>
            /// The short ID of the namespace.
            /// </summary>
            [NameInMap("NamespaceDescription")]
            [Validation(Required=false)]
            public string NamespaceDescription { get; set; }

            /// <summary>
            /// The error code returned. Take note of the following rules:
            /// 
            /// *   The **ErrorCode** parameter is not returned if the request succeeds.
            /// *   If the call fails, the **ErrorCode** parameter is returned. For more information, see the "**Error codes**" section of this topic.
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// Null
            /// </summary>
            [NameInMap("NamespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

            /// <summary>
            /// The HTTP status code. Valid values:
            /// 
            /// *   **2xx**: The call was successful.
            /// *   **3xx**: The call was redirected.
            /// *   **4xx**: The call failed.
            /// *   **5xx**: A server error occurred.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// http://sae_pop_pre/#vpc
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The ID of the namespace.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The description of the custom namespace.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// mountDir
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

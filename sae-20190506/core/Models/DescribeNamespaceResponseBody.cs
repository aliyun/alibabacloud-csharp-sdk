// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeNamespaceResponseBody : TeaModel {
        /// <summary>
        /// The ID of the trace. It can be used to query the details of a request.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information of the namespace.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeNamespaceResponseBodyData Data { get; set; }
        public class DescribeNamespaceResponseBodyData : TeaModel {
            [NameInMap("EnableMicroRegistration")]
            [Validation(Required=false)]
            public bool? EnableMicroRegistration { get; set; }

            [NameInMap("NameSpaceShortId")]
            [Validation(Required=false)]
            public string NameSpaceShortId { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("NamespaceDescription")]
            [Validation(Required=false)]
            public string NamespaceDescription { get; set; }

            /// <summary>
            /// cn-beijing:test
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
            /// cn-beijing:test
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The error code.
        /// 
        /// *   The **ErrorCode** parameter is not returned when the request succeeds.
        /// *   The **ErrorCode** parameter is returned when the request fails. For more information, see **Error codes** in this topic.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the namespace.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: indicates that the request was successful.
        /// *   **3xx**: indicates that the request was redirected.
        /// *   **4xx**: indicates that the request was invalid.
        /// *   **5xx**: indicates that a server error occurred.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

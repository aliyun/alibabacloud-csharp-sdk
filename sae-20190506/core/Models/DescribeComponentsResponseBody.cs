// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeComponentsResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the component version was obtained. Valid values:
        /// 
        /// *   **true**: indicates that the component version was obtained.
        /// *   **false**: indicates that the component version could not be obtained.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The component type.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeComponentsResponseBodyData> Data { get; set; }
        public class DescribeComponentsResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the component is expired. Valid values:
            /// 
            /// *   **true**: The component is expired.
            /// *   **false**: The component is not expired.
            /// </summary>
            [NameInMap("ComponentDescription")]
            [Validation(Required=false)]
            public string ComponentDescription { get; set; }

            /// <summary>
            /// The description of the component.
            /// </summary>
            [NameInMap("ComponentKey")]
            [Validation(Required=false)]
            public string ComponentKey { get; set; }

            /// <summary>
            /// The error code.
            /// 
            /// *   The **ErrorCode** parameter is not returned when the request succeeds.
            /// *   The **ErrorCode** parameter is returned when the request fails. For more information, see **Error codes** in this topic.
            /// </summary>
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public bool? Expired { get; set; }

            /// <summary>
            /// The ID of the component.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

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
        /// The ID of the trace. It is used to query the details of a request.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The details of the component.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

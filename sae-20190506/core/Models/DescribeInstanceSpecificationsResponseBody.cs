// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeInstanceSpecificationsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: indicates that the request was successful.
        /// *   **3xx**: indicates that the request was redirected.
        /// *   **4xx**: indicates that the request was invalid.
        /// *   **5xx**: indicates that a server error occurred.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Information of instance types.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeInstanceSpecificationsResponseBodyData> Data { get; set; }
        public class DescribeInstanceSpecificationsResponseBodyData : TeaModel {
            /// <summary>
            /// The CPU specification of the instance type. Unit: millicore.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// Indicates whether the instance type is available. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// The ID of the instance type.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// The memory size of the instance type. Unit: MB.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// The name of the instance type.
            /// </summary>
            [NameInMap("SpecInfo")]
            [Validation(Required=false)]
            public string SpecInfo { get; set; }

            /// <summary>
            /// The version number of the instance type.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        /// <summary>
        /// The error code.
        /// 
        /// *   If the request is successful, this parameter is not returned.****
        /// *   This parameter is returned only if the request failed.**** For more information, see **Error codes** in this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The returned message. Valid values:
        /// 
        /// *   **success** is returned when the request succeeds.
        /// *   An error code is returned when the request fails.
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
        /// Indicates whether information of the instance types is successfully obtained. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The ID of the trace. It is used to query the details of a request.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

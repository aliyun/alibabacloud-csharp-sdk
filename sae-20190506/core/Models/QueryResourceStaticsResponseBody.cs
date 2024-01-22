// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class QueryResourceStaticsResponseBody : TeaModel {
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
        /// The resource usage.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryResourceStaticsResponseBodyData Data { get; set; }
        public class QueryResourceStaticsResponseBodyData : TeaModel {
            /// <summary>
            /// The real-time resource usage.
            /// </summary>
            [NameInMap("RealTimeRes")]
            [Validation(Required=false)]
            public QueryResourceStaticsResponseBodyDataRealTimeRes RealTimeRes { get; set; }
            public class QueryResourceStaticsResponseBodyDataRealTimeRes : TeaModel {
                /// <summary>
                /// The CPU usage. Unit: core per minute.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// The memory usage. Unit: GiB per minute.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

            }

            /// <summary>
            /// The resource usage of the current month.
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public QueryResourceStaticsResponseBodyDataSummary Summary { get; set; }
            public class QueryResourceStaticsResponseBodyDataSummary : TeaModel {
                /// <summary>
                /// The CPU usage. Unit: core per minute.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// The memory usage. Unit: GiB per minute.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

            }

        }

        /// <summary>
        /// The error code. 
        /// 
        /// - The **ErrorCode** parameter is not returned when the request succeeds.
        /// - The **ErrorCode** parameter is returned when the request fails. For more information, see **Error codes** in this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The returned message.
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
        /// Indicates whether the resource usage of an application was obtained. Valid values:
        /// 
        /// *   **true**: indicates that the resource usage was obtained.
        /// *   **false**: indicates that the resource usage could not be obtained.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The ID of the trace. It can be used to query the details of a request.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

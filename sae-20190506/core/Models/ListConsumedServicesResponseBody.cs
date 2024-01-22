// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListConsumedServicesResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the microservice list was obtained. Valid values:
        /// 
        /// *   **true**: The list was obtained.
        /// *   **false**: The list failed to be obtained.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The type of the published service.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListConsumedServicesResponseBodyData> Data { get; set; }
        public class ListConsumedServicesResponseBodyData : TeaModel {
            /// <summary>
            /// A reserved parameter.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The subscription address of the service.
            /// </summary>
            [NameInMap("Group2Ip")]
            [Validation(Required=false)]
            public string Group2Ip { get; set; }

            /// <summary>
            /// The version of the published service
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<string> Groups { get; set; }

            /// <summary>
            /// The name of the published service.
            /// </summary>
            [NameInMap("Ips")]
            [Validation(Required=false)]
            public List<string> Ips { get; set; }

            /// <summary>
            /// The returned error code. Valid values:
            /// 
            /// *   If the call is successful, the **ErrorCode** parameter is not returned.
            /// *   If the call fails, the **ErrorCode** parameter is returned. For more information, see the "**Error codes**" section of this topic.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The service group that corresponds to the published service.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: indicates that the call was successful.
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
        /// The returned information. Valid values:
        /// 
        /// *   If the call is successful, **success** is returned.
        /// *   If the call fails, an error code is returned.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The details of the microservices.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

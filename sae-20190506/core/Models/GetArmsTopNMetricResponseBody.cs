// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class GetArmsTopNMetricResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The following limits are imposed on the ID:
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
        /// The details of applications.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetArmsTopNMetricResponseBodyData> Data { get; set; }
        public class GetArmsTopNMetricResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The total number of requests.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The number of errors.
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public long? Error { get; set; }

            /// <summary>
            /// The name of the application.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the namespace.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The average response time. Unit: milliseconds.
            /// </summary>
            [NameInMap("Rt")]
            [Validation(Required=false)]
            public long? Rt { get; set; }

        }

        /// <summary>
        /// The additional information that is returned. The following limits are imposed on the ID:
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
        /// Indicates whether the list of applications was obtained. The following limits are imposed on the ID:
        /// 
        /// *   **true**: The namespaces were obtained.
        /// *   **false**: no
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class GetAvailabilityMetricResponseBody : TeaModel {
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
        /// The data entries returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetAvailabilityMetricResponseBodyData> Data { get; set; }
        public class GetAvailabilityMetricResponseBodyData : TeaModel {
            /// <summary>
            /// The application ID.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// Indicates whether an auto scaling policy is enabled. Valid values:
            /// 
            /// *   **1**: An auto scaling policy is enabled.
            /// *   **0**: No auto scaling policy is enabled.
            /// </summary>
            [NameInMap("EnableAutoscale")]
            [Validation(Required=false)]
            public long? EnableAutoscale { get; set; }

            /// <summary>
            /// The number of abnormal instances.
            /// </summary>
            [NameInMap("ErrorInstances")]
            [Validation(Required=false)]
            public long? ErrorInstances { get; set; }

            /// <summary>
            /// The expected number of instances.
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public long? Instances { get; set; }

            /// <summary>
            /// The application name.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The namespace ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The current number of instances.
            /// </summary>
            [NameInMap("Runnings")]
            [Validation(Required=false)]
            public long? Runnings { get; set; }

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
        /// The request ID.
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

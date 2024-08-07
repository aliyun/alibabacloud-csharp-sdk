// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListApplicationMonitorDetectResultResponseBody : TeaModel {
        /// <summary>
        /// Details about the diagnostic result of the origin probing task.
        /// </summary>
        [NameInMap("ApplicationMonitorDetectResultList")]
        [Validation(Required=false)]
        public List<ListApplicationMonitorDetectResultResponseBodyApplicationMonitorDetectResultList> ApplicationMonitorDetectResultList { get; set; }
        public class ListApplicationMonitorDetectResultResponseBodyApplicationMonitorDetectResultList : TeaModel {
            /// <summary>
            /// The ID of the GA instance on which the origin probing task runs.
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// The response content returned by the origin probing task.
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// The description of the diagnostic result. Valid values:
            /// 
            /// *   **All forward nodes work well.:** The origin server is normal.
            /// *   **Endpoint network error.:** The origin server is abnormal. You must check whether the origin server is running as expected.
            /// *   **Public network error.:** An Internet error occurred, which is a network error that occurred when the client connected to the acceleration region.
            /// *   **Ga internal error.:** An internal error occurred. For example, an exception occurred when GA processed a request.
            /// *   **Ga has been deleted.:** The current GA instance is deleted.
            /// *   **Ga state is not stable.:** The current GA instance is in an unstable state, such as the Configuring state.
            /// *   **Ga has no listener configuration.:** No listener is configured for the current GA instance.
            /// *   **Missing endpoint configuration.:** No endpoint is configured.
            /// *   **Missing acceleration region configuration.:** No acceleration region is configured.
            /// *   **Missing endpointgroup configuration.:** No endpoint group is configured.
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// The time when the diagnosis of the origin probing task ends.
            /// </summary>
            [NameInMap("DetectTime")]
            [Validation(Required=false)]
            public string DetectTime { get; set; }

            /// <summary>
            /// The diagnostic result of the origin probing task. Valid values:
            /// 
            /// *   **success:** The origin probing task succeeded.
            /// *   **failed:** The origin probing task failed.
            /// </summary>
            [NameInMap("DiagStatus")]
            [Validation(Required=false)]
            public string DiagStatus { get; set; }

            /// <summary>
            /// The ID of the listener on which the origin probing task runs.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The listener port.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The network transmission protocol that is used by the listener. Valid values:
            /// 
            /// *   **tcp:** TCP.
            /// *   **udp:** UDP.
            /// *   **http:** HTTP.
            /// *   **https:** HTTPS.
            /// 
            /// >  UDP listeners do not support probing.
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// The error code returned by the origin probing task.
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

            /// <summary>
            /// The origin probing task ID.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

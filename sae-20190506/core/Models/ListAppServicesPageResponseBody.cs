// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListAppServicesPageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The total number of pages returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAppServicesPageResponseBodyData> Data { get; set; }
        public class ListAppServicesPageResponseBodyData : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public string CurrentPage { get; set; }

            /// <summary>
            /// The returned result.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// The name of the application.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// The version of the service. You can create a custom version.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListAppServicesPageResponseBodyDataResult> Result { get; set; }
            public class ListAppServicesPageResponseBodyDataResult : TeaModel {
                /// <summary>
                /// The group to which the service belongs. You can create a custom group.
                /// </summary>
                [NameInMap("EdasAppId")]
                [Validation(Required=false)]
                public string EdasAppId { get; set; }

                /// <summary>
                /// The total number of instances.
                /// </summary>
                [NameInMap("EdasAppName")]
                [Validation(Required=false)]
                public string EdasAppName { get; set; }

                /// <summary>
                /// The HTTP status code. Valid values:
                /// 
                /// *   **2xx**: indicates that the call was successful.
                /// *   **3xx**: indicates that the call was redirected.
                /// *   **4xx**: indicates that the call failed.
                /// *   **5xx**: indicates that a server error occurred.
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                /// <summary>
                /// The name of the service.
                /// </summary>
                [NameInMap("InstanceNum")]
                [Validation(Required=false)]
                public long? InstanceNum { get; set; }

                /// <summary>
                /// The returned error code. Valid values:
                /// 
                /// - If the call is successful, the **ErrorCode** parameter is not returned.
                /// - If the call fails, the **ErrorCode** parameter is returned. For more information, see the "**Error codes**" section of this topic.
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// The number of entries returned per page. Valid values: 0 to 9999.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public string TotalSize { get; set; }

        }

        /// <summary>
        /// Indicates whether the microservice list was obtained. Valid values:
        /// 
        /// *   **true**: The list was obtained.
        /// *   **false**: The list failed to be obtained.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The details of microservices.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the trace. The ID is used to query the details of a request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The page number of the current page.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationImageResponseBody : TeaModel {
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
        /// The information about the image of an application.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApplicationImageResponseBodyData Data { get; set; }
        public class DescribeApplicationImageResponseBodyData : TeaModel {
            /// <summary>
            /// This parameter is reserved.
            /// </summary>
            [NameInMap("CrUrl")]
            [Validation(Required=false)]
            public string CrUrl { get; set; }

            /// <summary>
            /// This parameter is reserved.
            /// </summary>
            [NameInMap("Logo")]
            [Validation(Required=false)]
            public string Logo { get; set; }

            /// <summary>
            /// The ID of the region.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The name of the repository.
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// The name of the namespace to which the repository belongs.
            /// </summary>
            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            /// <summary>
            /// The type of the repository. Only Container Registry is supported.
            /// </summary>
            [NameInMap("RepoOriginType")]
            [Validation(Required=false)]
            public string RepoOriginType { get; set; }

            /// <summary>
            /// The tag of the image.
            /// </summary>
            [NameInMap("RepoTag")]
            [Validation(Required=false)]
            public string RepoTag { get; set; }

            /// <summary>
            /// This parameter is reserved.
            /// </summary>
            [NameInMap("RepoType")]
            [Validation(Required=false)]
            public string RepoType { get; set; }

        }

        /// <summary>
        /// The error code.
        /// 
        /// *   The **ErrorCode** parameter is not returned when the request succeeds.
        /// *   The **ErrorCode** parameter is returned when the request fails. For more information, see **Error codes** in this topic.
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
        /// Indicates whether the image information was obtained. Valid values:
        /// 
        /// *   **true**: indicates that the information was obtained.
        /// *   **false**: indicates that the information could not be obtained.
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeSecretResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. Valid values:
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
        /// The response.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSecretResponseBodyData Data { get; set; }
        public class DescribeSecretResponseBodyData : TeaModel {
            /// <summary>
            /// The time when the task was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The ID of the namespace.
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// The associated application.
            /// </summary>
            [NameInMap("RelateApps")]
            [Validation(Required=false)]
            public List<DescribeSecretResponseBodyDataRelateApps> RelateApps { get; set; }
            public class DescribeSecretResponseBodyDataRelateApps : TeaModel {
                /// <summary>
                /// The application ID.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The name of the application.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

            }

            /// <summary>
            /// Secret key-value pair data.
            /// </summary>
            [NameInMap("SecretData")]
            [Validation(Required=false)]
            public Dictionary<string, string> SecretData { get; set; }

            /// <summary>
            /// The ID of the Secret instance.
            /// </summary>
            [NameInMap("SecretId")]
            [Validation(Required=false)]
            public long? SecretId { get; set; }

            /// <summary>
            /// The name of the Secret instance.
            /// </summary>
            [NameInMap("SecretName")]
            [Validation(Required=false)]
            public string SecretName { get; set; }

            /// <summary>
            /// The type of the Secret instance.
            /// </summary>
            [NameInMap("SecretType")]
            [Validation(Required=false)]
            public string SecretType { get; set; }

            /// <summary>
            /// The time when the task was updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// The error code returned. Valid values:
        /// 
        /// *   The **ErrorCode** parameter is not returned if the request succeeds.
        /// *   If the call fails, the **ErrorCode** parameter is returned. For more information, see **Error codes** in this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The additional information that is returned. Valid values:
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
        /// Indicates whether the details of the Secret instance are successfully queried. Valid values:
        /// 
        /// *   **true**: The information was queried.
        /// *   **false**: The image failed to be found.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The trace ID that is used to query the details of the request.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

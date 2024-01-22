// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListSecretsResponseBody : TeaModel {
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
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSecretsResponseBodyData Data { get; set; }
        public class ListSecretsResponseBodyData : TeaModel {
            /// <summary>
            /// The Secrets.
            /// </summary>
            [NameInMap("Secrets")]
            [Validation(Required=false)]
            public List<ListSecretsResponseBodyDataSecrets> Secrets { get; set; }
            public class ListSecretsResponseBodyDataSecrets : TeaModel {
                /// <summary>
                /// The time when the Secret was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The namespace ID.
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// The associated applications.
                /// </summary>
                [NameInMap("RelateApps")]
                [Validation(Required=false)]
                public List<ListSecretsResponseBodyDataSecretsRelateApps> RelateApps { get; set; }
                public class ListSecretsResponseBodyDataSecretsRelateApps : TeaModel {
                    /// <summary>
                    /// The application ID.
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// The application name.
                    /// </summary>
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                }

                /// <summary>
                /// The Secret ID.
                /// </summary>
                [NameInMap("SecretId")]
                [Validation(Required=false)]
                public long? SecretId { get; set; }

                /// <summary>
                /// The Secret name.
                /// </summary>
                [NameInMap("SecretName")]
                [Validation(Required=false)]
                public string SecretName { get; set; }

                /// <summary>
                /// The Secret type.
                /// 
                /// Set the value to **kubernetes.io/dockerconfigjson**. The value indicates the secret for the username and password of the image repository and is used for authentication when images are pulled during application deployment.
                /// </summary>
                [NameInMap("SecretType")]
                [Validation(Required=false)]
                public string SecretType { get; set; }

                /// <summary>
                /// The time when the Secret was updated.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// The error code returned. Take note of the following rules:
        /// 
        /// *   If the call is successful, the **ErrorCode** parameter is not returned.
        /// *   If the call fails, the **ErrorCode** parameter is returned. For more information, see the "**Error codes**" section in this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The returned message. Take note of the following rules:
        /// 
        /// *   If the call is successful, **success** is returned.
        /// *   If the call fails, an error code is returned.
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
        /// Indicates whether the call is successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
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

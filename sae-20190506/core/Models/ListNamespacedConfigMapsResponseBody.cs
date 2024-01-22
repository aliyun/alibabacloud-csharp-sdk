// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListNamespacedConfigMapsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: indicates that the call was successful.
        /// *   **3xx**: indicates that the call was redirected.
        /// *   **4xx**: indicates that the call failed.
        /// *   **5xx**: indicates that a server error occurred.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListNamespacedConfigMapsResponseBodyData Data { get; set; }
        public class ListNamespacedConfigMapsResponseBodyData : TeaModel {
            /// <summary>
            /// The ConfigMap instances.
            /// </summary>
            [NameInMap("ConfigMaps")]
            [Validation(Required=false)]
            public List<ListNamespacedConfigMapsResponseBodyDataConfigMaps> ConfigMaps { get; set; }
            public class ListNamespacedConfigMapsResponseBodyDataConfigMaps : TeaModel {
                /// <summary>
                /// The ID of the ConfigMap instance.
                /// </summary>
                [NameInMap("ConfigMapId")]
                [Validation(Required=false)]
                public long? ConfigMapId { get; set; }

                /// <summary>
                /// The time when the instance was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The data of ConfigMap key-value pairs. Format:
                /// 
                /// {"k1":"v1", "k2":"v2"}
                /// 
                /// k specifies a key and v specifies a value. For more information, see [Manage and use configurations](~~171326~~).
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public Dictionary<string, object> Data { get; set; }

                /// <summary>
                /// The description of the instance.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the ConfigMap instance.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the namespace.
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// The application that is associated with the instance.
                /// </summary>
                [NameInMap("RelateApps")]
                [Validation(Required=false)]
                public List<ListNamespacedConfigMapsResponseBodyDataConfigMapsRelateApps> RelateApps { get; set; }
                public class ListNamespacedConfigMapsResponseBodyDataConfigMapsRelateApps : TeaModel {
                    /// <summary>
                    /// The ID of the application.
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
                /// The time when the instance was last modified.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// The returned error code. Valid values:
        /// 
        /// - If the call is successful, the **ErrorCode** parameter is not returned.
        /// - If the call fails, the **ErrorCode** parameter is returned. For more information, see the "**Error codes**" section of this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The returned information. Valid values:
        /// 
        /// *   If the call is successful, **success** is returned.
        /// *   If the call fails, an error code is returned.
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
        /// Indicates whether the ConfigMap instances were obtained. Valid values:
        /// 
        /// *   **true**: The instances were obtained.
        /// *   **false**: The instances failed to be obtained.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The ID of the trace. The ID is used to query the details of a request.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

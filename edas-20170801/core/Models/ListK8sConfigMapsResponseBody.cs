// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListK8sConfigMapsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The additional information that is returned.
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
        /// The query results that are returned.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListK8sConfigMapsResponseBodyResult Result { get; set; }
        public class ListK8sConfigMapsResponseBodyResult : TeaModel {
            /// <summary>
            /// The information about ConfigMaps.
            /// </summary>
            [NameInMap("ConfigMaps")]
            [Validation(Required=false)]
            public List<ListK8sConfigMapsResponseBodyResultConfigMaps> ConfigMaps { get; set; }
            public class ListK8sConfigMapsResponseBodyResultConfigMaps : TeaModel {
                /// <summary>
                /// The ID of the Kubernetes cluster. You can obtain the cluster ID by calling the GetK8sCluster operation. For more information, see [GetK8sCluster](~~181437~~).
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The name of the cluster.
                /// </summary>
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                /// <summary>
                /// The time when the ConfigMaps were created. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The information about ConfigMaps.
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<ListK8sConfigMapsResponseBodyResultConfigMapsData> Data { get; set; }
                public class ListK8sConfigMapsResponseBodyResultConfigMapsData : TeaModel {
                    /// <summary>
                    /// The user-defined key that is stored in the ConfigMap.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The user-defined value that is stored in the ConfigMap.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The name of the ConfigMap.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The namespace of the Kubernetes cluster.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The related applications.
                /// </summary>
                [NameInMap("RelatedApps")]
                [Validation(Required=false)]
                public List<ListK8sConfigMapsResponseBodyResultConfigMapsRelatedApps> RelatedApps { get; set; }
                public class ListK8sConfigMapsResponseBodyResultConfigMapsRelatedApps : TeaModel {
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

            }

            /// <summary>
            /// The total number of entries that are returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

    }

}

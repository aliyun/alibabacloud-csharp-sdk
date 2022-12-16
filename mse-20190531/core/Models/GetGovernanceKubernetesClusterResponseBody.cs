// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGovernanceKubernetesClusterResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGovernanceKubernetesClusterResponseBodyData Data { get; set; }
        public class GetGovernanceKubernetesClusterResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the cluster.
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
            /// The version of Kubernetes.
            /// </summary>
            [NameInMap("K8sVersion")]
            [Validation(Required=false)]
            public string K8sVersion { get; set; }

            /// <summary>
            /// The information about namespaces.
            /// </summary>
            [NameInMap("NamespaceInfos")]
            [Validation(Required=false)]
            public string NamespaceInfos { get; set; }

            /// <summary>
            /// The details of namespaces.
            /// </summary>
            [NameInMap("Namespaces")]
            [Validation(Required=false)]
            public List<GetGovernanceKubernetesClusterResponseBodyDataNamespaces> Namespaces { get; set; }
            public class GetGovernanceKubernetesClusterResponseBodyDataNamespaces : TeaModel {
                /// <summary>
                /// The name of the namespace.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The tags of the namespace.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

            }

            /// <summary>
            /// The time when the cluster was started.
            /// </summary>
            [NameInMap("PilotStartTime")]
            [Validation(Required=false)]
            public string PilotStartTime { get; set; }

            /// <summary>
            /// The ID of the region in which the cluster resides.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The time when the cluster was last modified.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The message returned.
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
        /// Indicates whether the request is successful. Valid values:
        /// - `true`: The request is successful. 
        /// - `false`: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

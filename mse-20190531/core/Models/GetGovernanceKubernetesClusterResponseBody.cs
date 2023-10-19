// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGovernanceKubernetesClusterResponseBody : TeaModel {
        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGovernanceKubernetesClusterResponseBodyData Data { get; set; }
        public class GetGovernanceKubernetesClusterResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The name of the instance.
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
            /// The information of the namespace.
            /// </summary>
            [NameInMap("NamespaceInfos")]
            [Validation(Required=false)]
            public string NamespaceInfos { get; set; }

            /// <summary>
            /// The queried namespaces.
            /// </summary>
            [NameInMap("Namespaces")]
            [Validation(Required=false)]
            public List<GetGovernanceKubernetesClusterResponseBodyDataNamespaces> Namespaces { get; set; }
            public class GetGovernanceKubernetesClusterResponseBodyDataNamespaces : TeaModel {
                /// <summary>
                /// The name of the MSE namespace that you want to access.
                /// </summary>
                [NameInMap("MseNamespace")]
                [Validation(Required=false)]
                public string MseNamespace { get; set; }

                /// <summary>
                /// The name of the namespace in the ACK cluster.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The time when the pilot component was started.
            /// </summary>
            [NameInMap("PilotStartTime")]
            [Validation(Required=false)]
            public string PilotStartTime { get; set; }

            /// <summary>
            /// The ID of the region in which the instance resides. The region is supported by MSE.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The time of the last modification.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

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
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

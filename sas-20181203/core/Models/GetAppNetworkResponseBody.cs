// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAppNetworkResponseBody : TeaModel {
        /// <summary>
        /// The information about the application network topology.
        /// </summary>
        [NameInMap("AppNetwork")]
        [Validation(Required=false)]
        public GetAppNetworkResponseBodyAppNetwork AppNetwork { get; set; }
        public class GetAppNetworkResponseBodyAppNetwork : TeaModel {
            /// <summary>
            /// The information about the topology edge.
            /// </summary>
            [NameInMap("Edge")]
            [Validation(Required=false)]
            public List<GetAppNetworkResponseBodyAppNetworkEdge> Edge { get; set; }
            public class GetAppNetworkResponseBodyAppNetworkEdge : TeaModel {
                /// <summary>
                /// The ID of the destination node.
                /// </summary>
                [NameInMap("DstNodeId")]
                [Validation(Required=false)]
                public string DstNodeId { get; set; }

                /// <summary>
                /// The type of the destination node. Valid values:
                /// 
                /// *   **app**: an application
                /// *   **internet**: a network node in another cluster
                /// </summary>
                [NameInMap("DstNodeType")]
                [Validation(Required=false)]
                public string DstNodeType { get; set; }

                /// <summary>
                /// The ID of the edge.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The number of the destination port.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// The ID of the source node.
                /// </summary>
                [NameInMap("SrcNodeId")]
                [Validation(Required=false)]
                public string SrcNodeId { get; set; }

                /// <summary>
                /// The type of the source node. Valid values:
                /// 
                /// *   **app**: an application
                /// *   **internet**: a network node in another cluster
                /// </summary>
                [NameInMap("SrcNodeType")]
                [Validation(Required=false)]
                public string SrcNodeType { get; set; }

            }

            /// <summary>
            /// The namespace.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public List<GetAppNetworkResponseBodyAppNetworkNamespace> Namespace { get; set; }
            public class GetAppNetworkResponseBodyAppNetworkNamespace : TeaModel {
                /// <summary>
                /// The ID of the namespace.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The name of the custom namespace.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The information about the application node.
            /// </summary>
            [NameInMap("Node")]
            [Validation(Required=false)]
            public List<GetAppNetworkResponseBodyAppNetworkNode> Node { get; set; }
            public class GetAppNetworkResponseBodyAppNetworkNode : TeaModel {
                /// <summary>
                /// The list of the container IDs.
                /// </summary>
                [NameInMap("ContainerIds")]
                [Validation(Required=false)]
                public List<string> ContainerIds { get; set; }

                /// <summary>
                /// The ID of the node.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The name of the node.
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
                /// The risk level. Valid values:
                /// 
                /// *   **3**: high
                /// *   **2**: medium
                /// *   **1**: low
                /// *   **0**: warning
                /// *   **-1**: unknown
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// The type of the node. Valid values:
                /// 
                /// *   **app**: an application
                /// *   **internet**: a network node in another cluster
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

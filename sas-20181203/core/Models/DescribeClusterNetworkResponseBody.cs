// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterNetworkResponseBody : TeaModel {
        /// <summary>
        /// Information about the network topology edge in the cluster.
        /// </summary>
        [NameInMap("ClusterNetwork")]
        [Validation(Required=false)]
        public DescribeClusterNetworkResponseBodyClusterNetwork ClusterNetwork { get; set; }
        public class DescribeClusterNetworkResponseBodyClusterNetwork : TeaModel {
            /// <summary>
            /// An array that consists of information about the topology edge.
            /// </summary>
            [NameInMap("Edge")]
            [Validation(Required=false)]
            public List<DescribeClusterNetworkResponseBodyClusterNetworkEdge> Edge { get; set; }
            public class DescribeClusterNetworkResponseBodyClusterNetworkEdge : TeaModel {
                /// <summary>
                /// The ID of the destination node.
                /// </summary>
                [NameInMap("DstNodeId")]
                [Validation(Required=false)]
                public string DstNodeId { get; set; }

                /// <summary>
                /// The type of the destination node. Valid values:
                /// 
                /// *   **cluster**: a cluster
                /// </summary>
                [NameInMap("DstNodeType")]
                [Validation(Required=false)]
                public string DstNodeType { get; set; }

                /// <summary>
                /// The ID of the topology edge.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The port number of the topology edge.
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
                /// *   **cluster**: a cluster
                /// *   **internet**: a network node in another cluster
                /// </summary>
                [NameInMap("SrcNodeType")]
                [Validation(Required=false)]
                public string SrcNodeType { get; set; }

            }

            /// <summary>
            /// An array that consists of information about the node.
            /// </summary>
            [NameInMap("Node")]
            [Validation(Required=false)]
            public List<DescribeClusterNetworkResponseBodyClusterNetworkNode> Node { get; set; }
            public class DescribeClusterNetworkResponseBodyClusterNetworkNode : TeaModel {
                /// <summary>
                /// The micro-segmentation switch. Valid values:
                /// 
                /// *   **0**: The switch is turned off.
                /// *   **1**: The switch is turned on.
                /// </summary>
                [NameInMap("CnnfSwitch")]
                [Validation(Required=false)]
                public int? CnnfSwitch { get; set; }

                /// <summary>
                /// The ID of the node.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The network type. Valid values:
                /// 
                /// *   **0**: classic network
                /// *   **1**: virtual private cloud (VPC)
                /// </summary>
                [NameInMap("InterceptionType")]
                [Validation(Required=false)]
                public int? InterceptionType { get; set; }

                /// <summary>
                /// The name of the node.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The network topology switch. Valid values:
                /// 
                /// *   **ON**
                /// *   **OFF**
                /// </summary>
                [NameInMap("NetTopoSwitch")]
                [Validation(Required=false)]
                public string NetTopoSwitch { get; set; }

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
                /// *   **cluster**: a cluster
                /// *   **internet**: a node in another cluster
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

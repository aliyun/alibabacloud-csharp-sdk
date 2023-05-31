// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class FindContainerNetworkConnectRequest : TeaModel {
        /// <summary>
        /// The type of the information that you want to query. Valid values:
        /// 
        /// *   **EDGE**: connection information
        /// </summary>
        [NameInMap("CriteriaType")]
        [Validation(Required=false)]
        public string CriteriaType { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// The information about the destination node.
        /// </summary>
        [NameInMap("DstNode")]
        [Validation(Required=false)]
        public FindContainerNetworkConnectRequestDstNode DstNode { get; set; }
        public class FindContainerNetworkConnectRequestDstNode : TeaModel {
            /// <summary>
            /// The name of the container application.
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// The ID of the container cluster.
            /// 
            /// > You can call the [DescribeGroupedContainerInstances](~~DescribeGroupedContainerInstances~~) operation to query the IDs of container clusters.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The namespace of the cluster.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The node IDs.
            /// </summary>
            [NameInMap("NodeIds")]
            [Validation(Required=false)]
            public List<string> NodeIds { get; set; }

            /// <summary>
            /// The type of the node. Valid values:
            /// 
            /// *   **app**: application, which indicates that the node type is application.
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// The name of the pod.
            /// </summary>
            [NameInMap("PodName")]
            [Validation(Required=false)]
            public string PodName { get; set; }

        }

        /// <summary>
        /// The end time of the network connection.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.
        /// 
        /// > We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The information about the source node.
        /// </summary>
        [NameInMap("SrcNode")]
        [Validation(Required=false)]
        public FindContainerNetworkConnectRequestSrcNode SrcNode { get; set; }
        public class FindContainerNetworkConnectRequestSrcNode : TeaModel {
            /// <summary>
            /// The name of the container application.
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// The ID of the container cluster.
            /// 
            /// > You can call the [DescribeGroupedContainerInstances](~~DescribeGroupedContainerInstances~~) operation to query the IDs of container clusters.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The namespace of the cluster.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The node IDs.
            /// </summary>
            [NameInMap("NodeIds")]
            [Validation(Required=false)]
            public List<string> NodeIds { get; set; }

            /// <summary>
            /// The type of the node. Valid values:
            /// 
            /// *   **app**: application, which indicates that the node type is application.
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// The name of the pod.
            /// </summary>
            [NameInMap("PodName")]
            [Validation(Required=false)]
            public string PodName { get; set; }

        }

        /// <summary>
        /// The start time of the network connection.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}

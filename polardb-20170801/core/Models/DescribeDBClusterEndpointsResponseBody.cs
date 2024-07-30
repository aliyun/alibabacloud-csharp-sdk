// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterEndpointsResponseBody : TeaModel {
        /// <summary>
        /// The details of the endpoints.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBClusterEndpointsResponseBodyItems> Items { get; set; }
        public class DescribeDBClusterEndpointsResponseBodyItems : TeaModel {
            /// <summary>
            /// The details of the endpoint.
            /// </summary>
            [NameInMap("AddressItems")]
            [Validation(Required=false)]
            public List<DescribeDBClusterEndpointsResponseBodyItemsAddressItems> AddressItems { get; set; }
            public class DescribeDBClusterEndpointsResponseBodyItemsAddressItems : TeaModel {
                /// <summary>
                /// The endpoint.
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// The IP address.
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// The network type of the endpoint. Valid values:
                /// 
                /// *   **Public**
                /// *   **Private**
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// The port.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// The private domain name that is bound to the endpoint.
                /// </summary>
                [NameInMap("PrivateZoneConnectionString")]
                [Validation(Required=false)]
                public string PrivateZoneConnectionString { get; set; }

                /// <summary>
                /// The ID of the VPC.
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// The ID of the vSwitch.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The ID of the virtual private cloud (VPC) instance.
                /// 
                /// > This parameter is returned for only PolarDB for MySQL clusters.
                /// </summary>
                [NameInMap("VpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }

            }

            /// <summary>
            /// Indicates whether new nodes are automatically associated with the default cluster endpoint. Valid values:
            /// 
            /// *   **Enable**
            /// *   **Disable**
            /// </summary>
            [NameInMap("AutoAddNewNodes")]
            [Validation(Required=false)]
            public string AutoAddNewNodes { get; set; }

            /// <summary>
            /// The ID of the cluster.
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// The name of the endpoint.
            /// </summary>
            [NameInMap("DBEndpointDescription")]
            [Validation(Required=false)]
            public string DBEndpointDescription { get; set; }

            /// <summary>
            /// The ID of the endpoint.
            /// </summary>
            [NameInMap("DBEndpointId")]
            [Validation(Required=false)]
            public string DBEndpointId { get; set; }

            /// <summary>
            /// The advanced configurations of the endpoint.
            /// 
            /// *   **DistributedTransaction**: indicates whether transaction splitting is enabled. Valid values:
            /// 
            ///     *   **on**
            ///     *   **off**
            /// 
            /// *   **ConsistLevel**: the consistency level of sessions. Valid values:
            /// 
            ///     *   **0**: eventual consistency.
            ///     *   **1**: session consistency.
            ///     *   **2**: global consistency.
            /// 
            /// *   **LoadBalanceStrategy**: the load balancing policy that automatically schedules loads. Only **load** may be returned.
            /// 
            /// *   **MasterAcceptReads**: indicates whether the primary node processes read requests. Valid values:
            /// 
            ///     *   **on**
            ///     *   **off**
            /// </summary>
            [NameInMap("EndpointConfig")]
            [Validation(Required=false)]
            public string EndpointConfig { get; set; }

            /// <summary>
            /// The type of the endpoint. Valid values:
            /// 
            /// *   **Cluster**: the default endpoint.
            /// *   **Primary**: the primary endpoint.
            /// *   **Custom**: a custom cluster endpoint.
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// The role name of each node in the endpoint. The role name of the primary node is **Writer**. Multiple read-only nodes can be associated with an endpoint. Therefore, the role name of each read-only node is suffixed with a number, such as **Reader1** and **Reader2**.
            /// 
            /// > This parameter is valid only for PolarDB for PostgreSQL clusters and PolarDB for PostgreSQL (Compatible with Oracle)) clusters.
            /// </summary>
            [NameInMap("NodeWithRoles")]
            [Validation(Required=false)]
            public string NodeWithRoles { get; set; }

            /// <summary>
            /// The nodes in the endpoint.
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public string Nodes { get; set; }

            [NameInMap("PolarSccTimeoutAction")]
            [Validation(Required=false)]
            public string PolarSccTimeoutAction { get; set; }

            [NameInMap("PolarSccWaitTimeout")]
            [Validation(Required=false)]
            public string PolarSccWaitTimeout { get; set; }

            /// <summary>
            /// The read/write mode. Valid values:
            /// 
            /// *   **ReadWrite**: handles read and write requests. Automatic read/write splitting is enabled.
            /// *   **ReadOnly**: handles read-only requests.
            /// </summary>
            [NameInMap("ReadWriteMode")]
            [Validation(Required=false)]
            public string ReadWriteMode { get; set; }

            [NameInMap("SccMode")]
            [Validation(Required=false)]
            public string SccMode { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

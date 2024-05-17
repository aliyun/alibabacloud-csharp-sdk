// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeGlobalDatabaseNetworkResponseBody : TeaModel {
        /// <summary>
        /// The information about the connection to the cluster.
        /// </summary>
        [NameInMap("Connections")]
        [Validation(Required=false)]
        public List<DescribeGlobalDatabaseNetworkResponseBodyConnections> Connections { get; set; }
        public class DescribeGlobalDatabaseNetworkResponseBodyConnections : TeaModel {
            /// <summary>
            /// The URL of the endpoint.
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            /// <summary>
            /// The network type of the endpoint.
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            /// <summary>
            /// The port number of the endpoint.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

        }

        /// <summary>
        /// The time at which the GDN was created.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The clusters that are included in the GDN.
        /// </summary>
        [NameInMap("DBClusters")]
        [Validation(Required=false)]
        public List<DescribeGlobalDatabaseNetworkResponseBodyDBClusters> DBClusters { get; set; }
        public class DescribeGlobalDatabaseNetworkResponseBodyDBClusters : TeaModel {
            /// <summary>
            /// The description of the cluster.
            /// </summary>
            [NameInMap("DBClusterDescription")]
            [Validation(Required=false)]
            public string DBClusterDescription { get; set; }

            /// <summary>
            /// The ID of the cluster in the GDN.
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// The status of the cluster in the GDN. For more information, see [Cluster status table](https://help.aliyun.com/document_detail/99286.html).
            /// </summary>
            [NameInMap("DBClusterStatus")]
            [Validation(Required=false)]
            public string DBClusterStatus { get; set; }

            /// <summary>
            /// The specifications of the node in the cluster.
            /// </summary>
            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }

            /// <summary>
            /// The details of the node.
            /// </summary>
            [NameInMap("DBNodes")]
            [Validation(Required=false)]
            public List<DescribeGlobalDatabaseNetworkResponseBodyDBClustersDBNodes> DBNodes { get; set; }
            public class DescribeGlobalDatabaseNetworkResponseBodyDBClustersDBNodes : TeaModel {
                /// <summary>
                /// The time when the node was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The specifications of the node in the cluster.
                /// </summary>
                [NameInMap("DBNodeClass")]
                [Validation(Required=false)]
                public string DBNodeClass { get; set; }

                /// <summary>
                /// The ID of the node.
                /// </summary>
                [NameInMap("DBNodeId")]
                [Validation(Required=false)]
                public string DBNodeId { get; set; }

                /// <summary>
                /// The role of the node. Valid values:
                /// 
                /// *   **Writer**: The node is the primary node.
                /// *   **Reader**: The node is a read-only node.
                /// </summary>
                [NameInMap("DBNodeRole")]
                [Validation(Required=false)]
                public string DBNodeRole { get; set; }

                /// <summary>
                /// The status of the node. Valid values:
                /// 
                /// *   **Creating**: The cluster is being created.
                /// *   **Running**: The cluster is running.
                /// *   **Deleting**: The cluster is being deleted.
                /// *   **Rebooting**: The cluster is restarting.
                /// *   **DBNodeCreating**: PolarProxy is being added.
                /// *   **DBNodeDeleting**: PolarProxy is being deleted.
                /// *   **ClassChanging**: The specifications of PolarProxy are being changed.
                /// *   **NetAddressCreating**: The network connection is being created.
                /// *   **NetAddressDeleting**: The network connection is being deleted.
                /// *   **NetAddressModifying**: The network connection is being modified.
                /// *   **MinorVersionUpgrading**: The minor version is being updated.
                /// *   **Maintaining**: The cluster is being maintained.
                /// *   **Switching**: A failover is being performed.
                /// </summary>
                [NameInMap("DBNodeStatus")]
                [Validation(Required=false)]
                public string DBNodeStatus { get; set; }

                /// <summary>
                /// The priority of failover. Each node is assigned a failover priority. If a failover occurs, a node can be selected as the primary node based on the priority. A larger value indicates a higher priority. Valid values: 1 to 15.
                /// </summary>
                [NameInMap("FailoverPriority")]
                [Validation(Required=false)]
                public int? FailoverPriority { get; set; }

                /// <summary>
                /// The maximum number of concurrent connections to the cluster.
                /// </summary>
                [NameInMap("MaxConnections")]
                [Validation(Required=false)]
                public int? MaxConnections { get; set; }

                /// <summary>
                /// The maximum input/output operations per second (IOPS).
                /// </summary>
                [NameInMap("MaxIOPS")]
                [Validation(Required=false)]
                public int? MaxIOPS { get; set; }

                /// <summary>
                /// The zone ID of the cluster.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// The type of the database engine. Only MySQL is supported.
            /// </summary>
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            /// <summary>
            /// The version of the database engine. Only version 8.0 is supported.
            /// </summary>
            [NameInMap("DBVersion")]
            [Validation(Required=false)]
            public string DBVersion { get; set; }

            /// <summary>
            /// The expiration time of the cluster.
            /// 
            /// > A specific value is returned only for subscription (**Prepaid**) clusters. For pay-as-you-go (**Postpaid**) clusters, an empty string is returned.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// Indicates whether the cluster is expired. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// > This parameter is returned only for subscription (**Prepaid**) clusters.
            /// </summary>
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public string Expired { get; set; }

            /// <summary>
            /// The billing method of the cluster. Valid values:
            /// 
            /// *   **Postpaid**: pay-as-you-go.
            /// *   **Prepaid**: subscription.
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// The ID of the region in which the cluster resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The latency of cross-region data replication between the primary cluster and secondary clusters. Unit: seconds.
            /// </summary>
            [NameInMap("ReplicaLag")]
            [Validation(Required=false)]
            public string ReplicaLag { get; set; }

            /// <summary>
            /// The role of the cluster. Valid values:
            /// 
            /// *   **Primary**: the primary cluster
            /// *   **standby**: the secondary cluster
            /// 
            /// > A GDN consists of one primary cluster and up to four secondary clusters.
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("ServerlessType")]
            [Validation(Required=false)]
            public string ServerlessType { get; set; }

            /// <summary>
            /// The storage space that is occupied by the cluster. Unit: bytes.
            /// </summary>
            [NameInMap("StorageUsed")]
            [Validation(Required=false)]
            public string StorageUsed { get; set; }

        }

        /// <summary>
        /// The type of the database engine. Only MySQL is supported.
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// The version of the database engine. Only version 8.0 is supported.
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// The description of the GDN. The description must meet the following requirements:
        /// 
        /// *   It cannot start with `http://` or `https://`.
        /// *   It must start with a letter.
        /// *   It can contain letters, digits, underscores (_), and hyphens (-).
        /// *   It must be 2 to 126 characters in length.
        /// </summary>
        [NameInMap("GDNDescription")]
        [Validation(Required=false)]
        public string GDNDescription { get; set; }

        /// <summary>
        /// The ID of the GDN.
        /// </summary>
        [NameInMap("GDNId")]
        [Validation(Required=false)]
        public string GDNId { get; set; }

        /// <summary>
        /// The status of the GDN. Valid values:
        /// 
        /// *   **Creating**: The GDN is being created.
        /// *   **active**: The GDN is running.
        /// *   **deleting**: The GDN is being deleted.
        /// *   **locked**: The GDN is locked. If the GDN is locked, you cannot perform operations on clusters in the GDN.
        /// *   **removing_member**: The secondary cluster is being removed from the GDN.
        /// </summary>
        [NameInMap("GDNStatus")]
        [Validation(Required=false)]
        public string GDNStatus { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}

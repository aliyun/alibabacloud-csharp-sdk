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
            /// The endpoint URL of the database service.
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            /// <summary>
            /// The network type for the database connection.
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            /// <summary>
            /// The port number for the database connection.
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
        /// The clusters in the GDN.
        /// </summary>
        [NameInMap("DBClusters")]
        [Validation(Required=false)]
        public List<DescribeGlobalDatabaseNetworkResponseBodyDBClusters> DBClusters { get; set; }
        public class DescribeGlobalDatabaseNetworkResponseBodyDBClusters : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The description of the cluster.
            /// </summary>
            [NameInMap("DBClusterDescription")]
            [Validation(Required=false)]
            public string DBClusterDescription { get; set; }

            /// <summary>
            /// The ID of the cluster.
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// The status of the cluster. For more information, see [Cluster status table](https://help.aliyun.com/document_detail/99286.html).
            /// </summary>
            [NameInMap("DBClusterStatus")]
            [Validation(Required=false)]
            public string DBClusterStatus { get; set; }

            /// <summary>
            /// The node specifications of the cluster.
            /// </summary>
            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }

            /// <summary>
            /// The nodes of the cluster.
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
                /// The specifications of the node.
                /// </summary>
                [NameInMap("DBNodeClass")]
                [Validation(Required=false)]
                public string DBNodeClass { get; set; }

                /// <summary>
                /// The node ID.
                /// </summary>
                [NameInMap("DBNodeId")]
                [Validation(Required=false)]
                public string DBNodeId { get; set; }

                /// <summary>
                /// The role of the node. Valid values:
                /// 
                /// *   **Writer**: the primary node
                /// *   **Reader**: a read-only node
                /// </summary>
                [NameInMap("DBNodeRole")]
                [Validation(Required=false)]
                public string DBNodeRole { get; set; }

                /// <summary>
                /// The status of the node. Valid values:
                /// 
                /// *   **Creating**: The node is being created.
                /// *   **Running**: The node is running.
                /// *   **Deleting**: The node is being deleted.
                /// *   **Rebooting**: The node is restarting.
                /// *   **ClassChanging**: The specifications of the node are being changed.
                /// *   **NetAddressCreating**: The network connection is being created.
                /// *   **NetAddressDeleting**: The network connection is being deleted.
                /// *   **NetAddressModifying**: The network connection is being modified.
                /// *   **MinorVersionUpgrading**: The minor version of the node is being updated.
                /// *   **Maintaining**: The node is being maintained.
                /// *   **Switching**: A failover is being performed.
                /// </summary>
                [NameInMap("DBNodeStatus")]
                [Validation(Required=false)]
                public string DBNodeStatus { get; set; }

                /// <summary>
                /// The failover priority. Each node is assigned a failover priority. The failover priority determines which node is selected as the primary node when a failover occurs. A larger value indicates a higher priority. Valid values: 1 to 15.
                /// </summary>
                [NameInMap("FailoverPriority")]
                [Validation(Required=false)]
                public int? FailoverPriority { get; set; }

                /// <summary>
                /// The maximum number of concurrent connections.
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
                /// The zone ID of the node.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// The database engine type of the cluster. Only MySQL is supported.
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
            /// >  A specific value is returned only for subscription (**Prepaid**) clusters. No value is returned for pay-as-you-go (**Postpaid**) clusters.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// Indicates whether the cluster has expired. Valid values:
            /// 
            /// *   **true** (default)
            /// *   **false**
            /// 
            /// >  This parameter is returned only for subscription (**Prepaid**) clusters.
            /// </summary>
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public string Expired { get; set; }

            /// <summary>
            /// The billing method of the cluster. Valid values:
            /// 
            /// *   **Postpaid**: pay-as-you-go
            /// *   **Prepaid**: subscription
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// The region ID of the cluster.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The cross-region data replication latency between the primary cluster and secondary clusters. Unit: seconds.
            /// </summary>
            [NameInMap("ReplicaLag")]
            [Validation(Required=false)]
            public string ReplicaLag { get; set; }

            /// <summary>
            /// The role of the cluster. Valid values:
            /// 
            /// *   **Primary**: the primary cluster
            /// *   **standby**: a secondary cluster
            /// 
            /// >  A GDN consists of one primary cluster and up to four secondary clusters.
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// Indicates whether the cluster is a serverless cluster. The value is fixed at AgileServerless.
            /// 
            /// >  This parameter is returned only for serverless clusters.
            /// </summary>
            [NameInMap("ServerlessType")]
            [Validation(Required=false)]
            public string ServerlessType { get; set; }

            /// <summary>
            /// The storage usage of the cluster. Unit: bytes.
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

        [NameInMap("GlobalDomainName")]
        [Validation(Required=false)]
        public string GlobalDomainName { get; set; }

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

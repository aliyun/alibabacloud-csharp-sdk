// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClustersResponseBody : TeaModel {
        /// <summary>
        /// The details of the cluster.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClustersResponseBodyItems Items { get; set; }
        public class DescribeDBClustersResponseBodyItems : TeaModel {
            [NameInMap("DBCluster")]
            [Validation(Required=false)]
            public List<DescribeDBClustersResponseBodyItemsDBCluster> DBCluster { get; set; }
            public class DescribeDBClustersResponseBodyItemsDBCluster : TeaModel {
                /// <summary>
                /// The type of the AI node. Valid values:
                /// 
                /// *   SearchNode: Search node
                /// *   DLNode: ai node
                /// 
                /// Enumeration values:
                /// 
                /// *   SearchNode | DLNode
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     both
                /// 
                ///     <!-- -->
                /// 
                ///     .
                /// 
                /// *   DLNode
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     DLNode
                /// 
                ///     <!-- -->
                /// 
                ///     .
                /// 
                /// *   DLNode
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     DLNode
                /// 
                ///     <!-- -->
                /// 
                ///     .
                /// </summary>
                [NameInMap("AiType")]
                [Validation(Required=false)]
                public string AiType { get; set; }

                /// <summary>
                /// The edition of the cluster. Valid values:
                /// 
                /// *   **Normal**: Cluster Edition
                /// *   **Basic**: Single Node Edition
                /// *   **Archive**: X-Engine Edition
                /// *   **NormalMultimaster**: Multi-master Cluster (Database/Table)
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The time when the cluster was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

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
                /// The network type of the cluster.
                /// </summary>
                [NameInMap("DBClusterNetworkType")]
                [Validation(Required=false)]
                public string DBClusterNetworkType { get; set; }

                /// <summary>
                /// The status of the cluster.
                /// </summary>
                [NameInMap("DBClusterStatus")]
                [Validation(Required=false)]
                public string DBClusterStatus { get; set; }

                /// <summary>
                /// The specifications of the node.
                /// </summary>
                [NameInMap("DBNodeClass")]
                [Validation(Required=false)]
                public string DBNodeClass { get; set; }

                /// <summary>
                /// The number of nodes.
                /// </summary>
                [NameInMap("DBNodeNumber")]
                [Validation(Required=false)]
                public int? DBNodeNumber { get; set; }

                /// <summary>
                /// The nodes of the cluster.
                /// </summary>
                [NameInMap("DBNodes")]
                [Validation(Required=false)]
                public DescribeDBClustersResponseBodyItemsDBClusterDBNodes DBNodes { get; set; }
                public class DescribeDBClustersResponseBodyItemsDBClusterDBNodes : TeaModel {
                    [NameInMap("DBNode")]
                    [Validation(Required=false)]
                    public List<DescribeDBClustersResponseBodyItemsDBClusterDBNodesDBNode> DBNode { get; set; }
                    public class DescribeDBClustersResponseBodyItemsDBClusterDBNodesDBNode : TeaModel {
                        /// <summary>
                        /// The specifications of the node.
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
                        /// Indicates whether the hot standby feature is enabled. Valid values:
                        /// 
                        /// *   **ON**
                        /// *   **OFF**
                        /// </summary>
                        [NameInMap("HotReplicaMode")]
                        [Validation(Required=false)]
                        public string HotReplicaMode { get; set; }

                        /// <summary>
                        /// Indicates whether the In-Memory Column Index (IMCI) feature is enabled. Valid values:
                        /// 
                        /// *   **ON**
                        /// *   **OFF**
                        /// </summary>
                        [NameInMap("ImciSwitch")]
                        [Validation(Required=false)]
                        public string ImciSwitch { get; set; }

                        /// <summary>
                        /// The ID of the region in which the node resides.
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// Indicates whether the serverless feature is enabled for the current node. **ON** indicates that the serverless feature is enabled. An empty value indicates that the serverless feature is disabled.
                        /// </summary>
                        [NameInMap("Serverless")]
                        [Validation(Required=false)]
                        public string Serverless { get; set; }

                        /// <summary>
                        /// The zone ID of the node.
                        /// </summary>
                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                /// <summary>
                /// The type of the database engine.
                /// </summary>
                [NameInMap("DBType")]
                [Validation(Required=false)]
                public string DBType { get; set; }

                /// <summary>
                /// The version of the database.
                /// </summary>
                [NameInMap("DBVersion")]
                [Validation(Required=false)]
                public string DBVersion { get; set; }

                /// <summary>
                /// Indicates whether the cluster is protected from deletion. Valid values:
                /// 
                /// *   **0**: The cluster is not locked.
                /// *   **1**: The cluster is locked.
                /// 
                /// > If the cluster is locked, you cannot delete the cluster.
                /// </summary>
                [NameInMap("DeletionLock")]
                [Validation(Required=false)]
                public int? DeletionLock { get; set; }

                /// <summary>
                /// The engine of the cluster.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The expiration time of the cluster.
                /// 
                /// > A specific value is returned only for subscription (**Prepaid**) clusters. For pay-as-you-go (**Postpaid**) clusters, an empty string is returned.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// Indicates whether the cluster has expired. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// 
                /// > A specific value is returned only for subscription (**Prepaid**) clusters.
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public string Expired { get; set; }

                /// <summary>
                /// The lock status of the cluster. Valid values:
                /// 
                /// *   **Unlock**: The cluster is not locked.
                /// *   **ManualLock**: The cluster is manually locked.
                /// *   **LockByExpiration**: The cluster is automatically locked due to cluster expiration.
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

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
                /// The ID of the region in which the node resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// Indicates whether the cluster is a serverless cluster. **AgileServerless** indicates a serverless cluster. An empty value indicates a common cluster.
                /// </summary>
                [NameInMap("ServerlessType")]
                [Validation(Required=false)]
                public string ServerlessType { get; set; }

                /// <summary>
                /// The billing method of the storage space. Valid values:
                /// 
                /// *   **Postpaid**: pay-as-you-go.
                /// *   **Prepaid**: subscription.
                /// </summary>
                [NameInMap("StoragePayType")]
                [Validation(Required=false)]
                public string StoragePayType { get; set; }

                /// <summary>
                /// The storage space that is billed based on the subscription billing method. Unit: bytes.
                /// </summary>
                [NameInMap("StorageSpace")]
                [Validation(Required=false)]
                public long? StorageSpace { get; set; }

                /// <summary>
                /// The storage space this is occupied by the cluster. Unit: bytes.
                /// </summary>
                [NameInMap("StorageUsed")]
                [Validation(Required=false)]
                public long? StorageUsed { get; set; }

                /// <summary>
                /// Indicates whether multi-zone data consistency is enabled for the cluster. Valid values:
                /// 
                /// *   **ON**: multi-zone data consistency is enabled, which is suitable for Standard Edition clusters of Multi-zone Edition.
                /// *   **OFF**: multi-zone data consistency is disabled.
                /// </summary>
                [NameInMap("StrictConsistency")]
                [Validation(Required=false)]
                public string StrictConsistency { get; set; }

                /// <summary>
                /// The tags of the cluster.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDBClustersResponseBodyItemsDBClusterTags Tags { get; set; }
                public class DescribeDBClustersResponseBodyItemsDBClusterTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBClustersResponseBodyItemsDBClusterTagsTag> Tag { get; set; }
                    public class DescribeDBClustersResponseBodyItemsDBClusterTagsTag : TeaModel {
                        /// <summary>
                        /// The key of the tag.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the tag.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The VPC ID of the cluster.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The vSwitch ID of the cluster.
                /// </summary>
                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

                /// <summary>
                /// The zone ID of the cluster.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of clusters returned per page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}

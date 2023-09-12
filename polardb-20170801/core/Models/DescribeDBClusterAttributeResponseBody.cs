// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterAttributeResponseBody : TeaModel {
        /// <summary>
        /// The information status of the AI node. Valid values:
        /// 
        /// *   SearchNode: search node.
        /// *   DLNode: AI node
        /// </summary>
        [NameInMap("AiType")]
        [Validation(Required=false)]
        public string AiType { get; set; }

        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// Maximum blktags in file system.
        /// </summary>
        [NameInMap("BlktagTotal")]
        [Validation(Required=false)]
        public long? BlktagTotal { get; set; }

        /// <summary>
        /// The current blktag usage.
        /// </summary>
        [NameInMap("BlktagUsed")]
        [Validation(Required=false)]
        public long? BlktagUsed { get; set; }

        /// <summary>
        /// [The edition of PolarDB](~~183258~~). Valid values:
        /// 
        /// *   **Normal**: Cluster Edition.
        /// *   **Basic**: Single Node Edition.
        /// *   **Archive**: X-Engine Edition.
        /// *   **NormalMultimaster**: Multi-master Cluster Edition.
        /// *   **SENormal**: Standard Edition.
        /// 
        /// >-  Only PolarDB for MySQL supports Single Node Edition.
        /// >- Only PolarDB for MySQL 8.0.1 supports Standard Edition.
        /// >- Only PolarDB for MySQL 8.0 supports X-Engine Edition and Multi-master Cluster Edition.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("CompressStorageMode")]
        [Validation(Required=false)]
        public string CompressStorageMode { get; set; }

        /// <summary>
        /// The time when the cluster was created.
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// The description of the cluster.
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// The ID of cluster.
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
        /// The status of the cluster. For information about the valid values, see [Cluster states](~~99286~~).
        /// </summary>
        [NameInMap("DBClusterStatus")]
        [Validation(Required=false)]
        public string DBClusterStatus { get; set; }

        /// <summary>
        /// The details of the nodes.
        /// </summary>
        [NameInMap("DBNodes")]
        [Validation(Required=false)]
        public List<DescribeDBClusterAttributeResponseBodyDBNodes> DBNodes { get; set; }
        public class DescribeDBClusterAttributeResponseBodyDBNodes : TeaModel {
            /// <summary>
            /// The number of CPU cores for compute node scale-out within seconds.
            /// </summary>
            [NameInMap("AddedCpuCores")]
            [Validation(Required=false)]
            public string AddedCpuCores { get; set; }

            /// <summary>
            /// The time when the node was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The type of the node.
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
            /// *   **ClassChanging**: The specification type of PolarProxy are being modified.
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
            /// The failover priority. Each node is assigned a failover priority. If a failover occurs, a node can be selected as a primary node. The priority determines the probability at which a node is selected as a primary node. A larger value indicates a higher priority. Valid values: 1 to 15.
            /// </summary>
            [NameInMap("FailoverPriority")]
            [Validation(Required=false)]
            public int? FailoverPriority { get; set; }

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
            /// The ID of the primary node in the cluster that runs Multi-master Cluster Edition.
            /// </summary>
            [NameInMap("MasterId")]
            [Validation(Required=false)]
            public string MasterId { get; set; }

            /// <summary>
            /// The maximum number of concurrent connections in the cluster.
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
            /// Indicates whether the global consistency (high-performance mode) feature is enabled for the node. Valid values:
            /// 
            /// *   **ON**
            /// *   **OFF**
            /// </summary>
            [NameInMap("SccMode")]
            [Validation(Required=false)]
            public string SccMode { get; set; }

            /// <summary>
            /// The routing weight of the node. Valid values: 1 to 100 Default value: 1.
            /// </summary>
            [NameInMap("ServerWeight")]
            [Validation(Required=false)]
            public string ServerWeight { get; set; }

            /// <summary>
            /// The type of the serverless node. Only **AgileServerless** can be returned.
            /// 
            /// > This parameter is supported only for serverless clusters.
            /// </summary>
            [NameInMap("ServerlessType")]
            [Validation(Required=false)]
            public string ServerlessType { get; set; }

            /// <summary>
            /// The ID of the zone.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// The type of the database engine.
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// The version of the database engine.
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// The status of the minor version. Valid values:
        /// 
        /// *   **Stable**: The minor version is stable.
        /// *   **Old**: The minor version is outdated. We recommend that you upgrade the cluster to the latest version.
        /// *   **HighRisk**: The minor version has critical defects. We recommend that you immediately upgrade the cluster to the latest version.
        /// 
        /// > For more information about how to upgrade the minor version, see [Upgrade versions](~~158572~~).
        /// </summary>
        [NameInMap("DBVersionStatus")]
        [Validation(Required=false)]
        public string DBVersionStatus { get; set; }

        /// <summary>
        /// The total physical storage of level-1 backups (snapshots). Unit: bytes.
        /// </summary>
        [NameInMap("DataLevel1BackupChainSize")]
        [Validation(Required=false)]
        public long? DataLevel1BackupChainSize { get; set; }

        /// <summary>
        /// Indicates the rule of data replication. Valid values: AsyncSync: asynchronous. SemiSync: semi-synchronous.
        /// </summary>
        [NameInMap("DataSyncMode")]
        [Validation(Required=false)]
        public string DataSyncMode { get; set; }

        /// <summary>
        /// Indicates whether the cluster is locked and can be deleted. Valid values:
        /// 
        /// *   **0**: The cluster is not locked and can be deleted.
        /// *   **1**: The cluster is locked and cannot be deleted.
        /// </summary>
        [NameInMap("DeletionLock")]
        [Validation(Required=false)]
        public int? DeletionLock { get; set; }

        /// <summary>
        /// The unit to which the cluster belongs.
        /// </summary>
        [NameInMap("DeployUnit")]
        [Validation(Required=false)]
        public string DeployUnit { get; set; }

        /// <summary>
        /// The database type.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The time when the cluster expires.
        /// 
        /// > A specific value will be returned only for subscription (**Prepaid**) clusters. For pay-as-you-go (**Postpaid**) clusters, an empty string will be returned.
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// Indicates whether the cluster has expired. Valid values:
        /// 
        /// > This parameter is returned only for subscription (**Prepaid**) clusters.
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public string Expired { get; set; }

        /// <summary>
        /// Indicates whether to replenish resources for the primary database after a cross-zone switchover. Valid values: true false
        /// </summary>
        [NameInMap("HasCompleteStandbyRes")]
        [Validation(Required=false)]
        public bool? HasCompleteStandbyRes { get; set; }

        [NameInMap("HotStandbyCluster")]
        [Validation(Required=false)]
        public string HotStandbyCluster { get; set; }

        /// <summary>
        /// Maximum inodes in file system.
        /// </summary>
        [NameInMap("InodeTotal")]
        [Validation(Required=false)]
        public long? InodeTotal { get; set; }

        /// <summary>
        /// The current inode usage.
        /// </summary>
        [NameInMap("InodeUsed")]
        [Validation(Required=false)]
        public long? InodeUsed { get; set; }

        /// <summary>
        /// Indicates whether the kernel is of the latest version. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("IsLatestVersion")]
        [Validation(Required=false)]
        public bool? IsLatestVersion { get; set; }

        /// <summary>
        /// Indicates whether PolarProxy uses the latest version. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("IsProxyLatestVersion")]
        [Validation(Required=false)]
        public bool? IsProxyLatestVersion { get; set; }

        /// <summary>
        /// The lock mode. Valid values:
        /// 
        /// *   **Unlock**: The cluster is not locked.
        /// *   **ManualLock**: The cluster is manually locked.
        /// *   **LockByExpiration**: The cluster is automatically locked due to cluster expiration.
        /// </summary>
        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        /// <summary>
        /// The maintenance window of the cluster. The format is `HH:mmZ-HH:mmZ`. The time is displayed in UTC. For example, the value `16:00Z-17:00Z` indicates that the cluster can be maintained from 00:00 to 01:00 (UTC+08:00).
        /// </summary>
        [NameInMap("MaintainTime")]
        [Validation(Required=false)]
        public string MaintainTime { get; set; }

        /// <summary>
        /// The billing method of the cluster. Valid values:
        /// 
        /// *   **Postpaid**: pay-as-you-go.
        /// *   **Prepaid**: subscription
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The number of CPU cores for PolarProxy.
        /// </summary>
        [NameInMap("ProxyCpuCores")]
        [Validation(Required=false)]
        public string ProxyCpuCores { get; set; }

        /// <summary>
        /// The type of the serverless PolarProxy. Valid value: AgileServerless.
        /// </summary>
        [NameInMap("ProxyServerlessType")]
        [Validation(Required=false)]
        public string ProxyServerlessType { get; set; }

        /// <summary>
        /// The number of CPU cores for PolarProxy Standard Enterprise Edition.
        /// </summary>
        [NameInMap("ProxyStandardCpuCores")]
        [Validation(Required=false)]
        public string ProxyStandardCpuCores { get; set; }

        /// <summary>
        /// The status of PolarProxy. Valid values:
        /// 
        /// *   **Creating**: PolarProxy is being created.
        /// *   **Running**: PolarProxy is running.
        /// *   **Deleting**: PolarProxy is being released.
        /// *   **Rebooting**: PolarProxy is restarting.
        /// *   **DBNodeCreating**: PolarProxy is being added.
        /// *   **DBNodeDeleting**: PolarProxy is being deleted.
        /// *   **ClassChanging**: The specifications of PolarProxy are being changed.
        /// *   **NetAddressCreating**: The network connection is being created.
        /// *   **NetAddressDeleting**: The network connection is being deleted.
        /// *   **NetAddressModifying**: The network connection is being modified.
        /// *   **Deleted**: PolarProxy is released.
        /// </summary>
        [NameInMap("ProxyStatus")]
        [Validation(Required=false)]
        public string ProxyStatus { get; set; }

        /// <summary>
        /// The type of PolarProxy. Valid values:
        /// 
        /// *   **Exclusive**: Dedicated Enterprise Edition
        /// *   **General**: Standard Enterprise Edition
        /// </summary>
        [NameInMap("ProxyType")]
        [Validation(Required=false)]
        public string ProxyType { get; set; }

        /// <summary>
        /// The region ID of the security group.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of your Alibaba Cloud resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The storage of SQL. Unit: bytes. If the value is -1, no data is stored.
        /// </summary>
        [NameInMap("SQLSize")]
        [Validation(Required=false)]
        public long? SQLSize { get; set; }

        /// <summary>
        /// The type of the serverless cluster. Only **AgileServerless** can be returned.
        /// </summary>
        [NameInMap("ServerlessType")]
        [Validation(Required=false)]
        public string ServerlessType { get; set; }

        /// <summary>
        /// Indicates whether the cross-zone disaster recovery feature is enabled. Valid values: ON OFF 0: Customer Drill Mode
        /// </summary>
        [NameInMap("StandbyHAMode")]
        [Validation(Required=false)]
        public string StandbyHAMode { get; set; }

        /// <summary>
        /// The maximum storage capacity of the current cluster specification. Unit: bytes.
        /// </summary>
        [NameInMap("StorageMax")]
        [Validation(Required=false)]
        public long? StorageMax { get; set; }

        /// <summary>
        /// The billing method of the storage. Valid values:
        /// 
        /// *   **Postpaid**: pay-as-you-go
        /// *   **Prepaid**: subscription.
        /// </summary>
        [NameInMap("StoragePayType")]
        [Validation(Required=false)]
        public string StoragePayType { get; set; }

        /// <summary>
        /// The storage space that uses the subscription billing method. Unit: bytes.
        /// </summary>
        [NameInMap("StorageSpace")]
        [Validation(Required=false)]
        public long? StorageSpace { get; set; }

        /// <summary>
        /// The storage type. Set the value to **HighPerformance**.
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// The storage space consumed by the cluster. Unit: bytes.
        /// </summary>
        [NameInMap("StorageUsed")]
        [Validation(Required=false)]
        public long? StorageUsed { get; set; }

        /// <summary>
        /// Indicates whether the multi-zone data consistency feature is enabled for the cluster. Valid values:
        /// 
        /// *   **ON**: Multi-zone data consistency is enabled, which is suitable for Standard Edition clusters that run Multi-zone Edition.
        /// *   **OFF**
        /// </summary>
        [NameInMap("StrictConsistency")]
        [Validation(Required=false)]
        public string StrictConsistency { get; set; }

        /// <summary>
        /// The specification type of the compute node. Valid values:
        /// 
        /// *   **Exclusive**: dedicated.
        /// *   **General**: general-purpose.
        /// 
        /// > This parameter is supported only for PolarDB for MySQL clusters of Cluster Edition.
        /// </summary>
        [NameInMap("SubCategory")]
        [Validation(Required=false)]
        public string SubCategory { get; set; }

        /// <summary>
        /// Details about the tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeDBClusterAttributeResponseBodyTags> Tags { get; set; }
        public class DescribeDBClusterAttributeResponseBodyTags : TeaModel {
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

        /// <summary>
        /// The VPC ID of the cluster.
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// The vSwitch ID of the cluster.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The zone ID of the cluster.
        /// </summary>
        [NameInMap("ZoneIds")]
        [Validation(Required=false)]
        public string ZoneIds { get; set; }

    }

}

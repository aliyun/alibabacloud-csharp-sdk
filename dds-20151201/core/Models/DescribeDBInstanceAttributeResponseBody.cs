// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// Details about instances.
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public DescribeDBInstanceAttributeResponseBodyDBInstances DBInstances { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyDBInstances : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstance> DBInstance { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstance : TeaModel {
                /// <summary>
                /// The read and write throughput consumed by the instance.
                /// </summary>
                [NameInMap("CapacityUnit")]
                [Validation(Required=false)]
                public string CapacityUnit { get; set; }

                /// <summary>
                /// The billing method of the instance. Valid values:
                /// 
                /// *   **PrePaid**: subscription
                /// *   **PostPaid**: pay-as-you-go
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// Details about Configserver nodes.
                /// 
                /// > This parameter is returned if the instance is a sharded cluster instance.
                /// </summary>
                [NameInMap("ConfigserverList")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceConfigserverList ConfigserverList { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceConfigserverList : TeaModel {
                    [NameInMap("ConfigserverAttribute")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceConfigserverListConfigserverAttribute> ConfigserverAttribute { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceConfigserverListConfigserverAttribute : TeaModel {
                        /// <summary>
                        /// The endpoint of the Configserver node.
                        /// </summary>
                        [NameInMap("ConnectString")]
                        [Validation(Required=false)]
                        public string ConnectString { get; set; }

                        /// <summary>
                        /// The maximum number of connections to the Configserver node.
                        /// </summary>
                        [NameInMap("MaxConnections")]
                        [Validation(Required=false)]
                        public int? MaxConnections { get; set; }

                        /// <summary>
                        /// The maximum IOPS of the Configserver node.
                        /// </summary>
                        [NameInMap("MaxIOPS")]
                        [Validation(Required=false)]
                        public int? MaxIOPS { get; set; }

                        /// <summary>
                        /// The instance type of the Configserver node.
                        /// </summary>
                        [NameInMap("NodeClass")]
                        [Validation(Required=false)]
                        public string NodeClass { get; set; }

                        /// <summary>
                        /// The name of the Configserver node.
                        /// </summary>
                        [NameInMap("NodeDescription")]
                        [Validation(Required=false)]
                        public string NodeDescription { get; set; }

                        /// <summary>
                        /// The ID of the Configserver node.
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        /// <summary>
                        /// The storage capacity of the Configserver node.
                        /// </summary>
                        [NameInMap("NodeStorage")]
                        [Validation(Required=false)]
                        public int? NodeStorage { get; set; }

                        /// <summary>
                        /// The port number that is used to connect to the Configserver node.
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// The state of the Configserver node. For more information, see [Instance states](~~63870~~).
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                /// <summary>
                /// The time when the instance was created. The time is in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The minor version of the current database in the instance.
                /// </summary>
                [NameInMap("CurrentKernelVersion")]
                [Validation(Required=false)]
                public string CurrentKernelVersion { get; set; }

                /// <summary>
                /// The instance type.
                /// </summary>
                [NameInMap("DBInstanceClass")]
                [Validation(Required=false)]
                public string DBInstanceClass { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// The status of the orders generated for the instance. Valid values:
                /// 
                /// *   **all_completed**: All orders are being produced or complete.
                /// *   **order_unpaid**: The instance has unpaid orders.
                /// *   **order_wait_for_produce**: The order is being delivered for production.
                /// 
                /// >  The order production process includes placing an order, paying for an order, delivering an order for production, producing an order, and complete.
                /// 
                /// *   If an order is in the **order_wait_for_produce** state for a long time, an error occurs when the order is being delivered for production. The system will automatically retry.
                /// *   The instance status changes only when the order is in the producing and complete state, such as changing configurations and running.
                /// </summary>
                [NameInMap("DBInstanceOrderStatus")]
                [Validation(Required=false)]
                public string DBInstanceOrderStatus { get; set; }

                /// <summary>
                /// Indicates whether release protection is enabled for the instance. Valid values:
                /// 
                /// *   **true**: enabled
                /// *   **false**: disabled
                /// </summary>
                [NameInMap("DBInstanceReleaseProtection")]
                [Validation(Required=false)]
                public bool? DBInstanceReleaseProtection { get; set; }

                /// <summary>
                /// The state of the instance. For more information, see [Instance states](~~63870~~).
                /// </summary>
                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public string DBInstanceStatus { get; set; }

                /// <summary>
                /// The storage capacity of the instance.
                /// </summary>
                [NameInMap("DBInstanceStorage")]
                [Validation(Required=false)]
                public int? DBInstanceStorage { get; set; }

                /// <summary>
                /// The architecture of the instance. Valid values:
                /// 
                /// *   **replicate**: replica set instance
                /// *   **sharding**: sharded cluster instance
                /// </summary>
                [NameInMap("DBInstanceType")]
                [Validation(Required=false)]
                public string DBInstanceType { get; set; }

                /// <summary>
                /// The time when the instance data was destroyed. The time is in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("DestroyTime")]
                [Validation(Required=false)]
                public string DestroyTime { get; set; }

                /// <summary>
                /// The database engine of the instance.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The database engine version of the instance.
                /// 
                /// *   **6.0**
                /// *   **5.0**
                /// *   **4.4**
                /// *   **4.2**
                /// *   **4.0**
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// The time when the subscription instance expires. The time is in the *yyyy-MM-dd*T*HH:mm*Z format. The time is displayed in UTC.
                /// 
                /// > This parameter is returned if the instance is a subscription instance.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// The ID of the secondary zone 2 of the instance. Valid values:
                /// 
                /// *   **cn-hangzhou-g**: Hangzhou Zone G
                /// *   **cn-hangzhou-h**: Hangzhou Zone H
                /// *   **cn-hangzhou-i**: Hangzhou Zone I
                /// *   **cn-hongkong-b**: Hongkong Zone B
                /// *   **cn-hongkong-c**: Hongkong Zone C
                /// *   **cn-hongkong-d**: Hongkong Zone D
                /// *   **cn-wulanchabu-a**: Ulanqab Zone A
                /// *   **cn-wulanchabu-b**: Ulanqab Zone B
                /// *   **cn-wulanchabu-c**: Ulanqab Zone C
                /// *   **ap-southeast-1a**: Singapore Zone A
                /// *   **ap-southeast-1b**: Singapore Zone B
                /// *   **ap-southeast-1c**: Singapore Zone C
                /// *   **ap-southeast-5a**: Jakarta Zone A
                /// *   **ap-southeast-5b**: Jakarta Zone B
                /// *   **ap-southeast-5c**: Jakarta Zone C
                /// *   **eu-central-1a**: Frankfurt Zone A
                /// *   **eu-central-1b**: Frankfurt Zone B
                /// *   **eu-central-1c**: Frankfurt Zone C
                /// 
                /// > 
                /// 
                /// *   This parameter is returned if the instance is a replica set or sharded cluster instance that runs MongoDB 4.4 or 5.0 and uses multi-zone deployment.
                /// 
                /// *   This parameter is returned only if you use the Chine site (aliyun.com).
                /// </summary>
                [NameInMap("HiddenZoneId")]
                [Validation(Required=false)]
                public string HiddenZoneId { get; set; }

                /// <summary>
                /// The kind code of the instance. Valid values:
                /// 
                /// *   **0**: physical machine
                /// *   **1**: Elastic Compute Service (ECS) instance
                /// *   **2**: Docker cluster
                /// *   **18**: Kubernetes cluster
                /// </summary>
                [NameInMap("KindCode")]
                [Validation(Required=false)]
                public string KindCode { get; set; }

                /// <summary>
                /// The date when the last downgrade operation was performed.
                /// </summary>
                [NameInMap("LastDowngradeTime")]
                [Validation(Required=false)]
                public string LastDowngradeTime { get; set; }

                /// <summary>
                /// The lock state of the instance. Valid values:
                /// 
                /// *   **Unlock**: The instance is not locked.
                /// *   **ManualLock**: The instance is manually locked.
                /// *   **LockByExpiration**: The instance is automatically locked due to instance expiration.
                /// *   **LockByRestoration**: The instance is automatically locked before it is rolled back.
                /// *   **LockByDiskQuota**: The instance is automatically locked due to exhausted storage capacity.
                /// *   **Released**: The instance is released.
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                /// <summary>
                /// The end time of the maintenance window. The time is in the *HH:mm*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("MaintainEndTime")]
                [Validation(Required=false)]
                public string MaintainEndTime { get; set; }

                /// <summary>
                /// The start time of the maintenance window. The time is in the *HH:mm*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("MaintainStartTime")]
                [Validation(Required=false)]
                public string MaintainStartTime { get; set; }

                /// <summary>
                /// The maximum number of connections to the instance.
                /// </summary>
                [NameInMap("MaxConnections")]
                [Validation(Required=false)]
                public int? MaxConnections { get; set; }

                /// <summary>
                /// The maximum IOPS of the instance.
                /// </summary>
                [NameInMap("MaxIOPS")]
                [Validation(Required=false)]
                public int? MaxIOPS { get; set; }

                /// <summary>
                /// Details about mongos nodes.
                /// 
                /// > This parameter is returned if the instance is a sharded cluster instance.
                /// </summary>
                [NameInMap("MongosList")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceMongosList MongosList { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceMongosList : TeaModel {
                    [NameInMap("MongosAttribute")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceMongosListMongosAttribute> MongosAttribute { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceMongosListMongosAttribute : TeaModel {
                        /// <summary>
                        /// The endpoint of the mongos node.
                        /// </summary>
                        [NameInMap("ConnectSting")]
                        [Validation(Required=false)]
                        public string ConnectSting { get; set; }

                        /// <summary>
                        /// The maximum number of connections to the mongos node.
                        /// </summary>
                        [NameInMap("MaxConnections")]
                        [Validation(Required=false)]
                        public int? MaxConnections { get; set; }

                        /// <summary>
                        /// The maximum IOPS of the mongos node.
                        /// </summary>
                        [NameInMap("MaxIOPS")]
                        [Validation(Required=false)]
                        public int? MaxIOPS { get; set; }

                        /// <summary>
                        /// The instance type of the mongos node.
                        /// </summary>
                        [NameInMap("NodeClass")]
                        [Validation(Required=false)]
                        public string NodeClass { get; set; }

                        /// <summary>
                        /// The name of the mongos node.
                        /// </summary>
                        [NameInMap("NodeDescription")]
                        [Validation(Required=false)]
                        public string NodeDescription { get; set; }

                        /// <summary>
                        /// The ID of the mongos node.
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        /// <summary>
                        /// The port number that is used to connect to the mongos node.
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// The state of the mongos node. For more information, see [Instance states](~~63870~~).
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// The VPC ID of the node.
                        /// 
                        /// > This parameter is returned if the network type of the instance is VPC.
                        /// </summary>
                        [NameInMap("VPCId")]
                        [Validation(Required=false)]
                        public string VPCId { get; set; }

                        /// <summary>
                        /// The vSwitch ID of the node.
                        /// 
                        /// > This parameter is returned if the network type of the instance is VPC.
                        /// </summary>
                        [NameInMap("VSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                        /// <summary>
                        /// The ID of the mongos node.
                        /// </summary>
                        [NameInMap("VpcCloudInstanceId")]
                        [Validation(Required=false)]
                        public string VpcCloudInstanceId { get; set; }

                    }

                }

                /// <summary>
                /// The network type of the instance. Valid values:
                /// 
                /// *   **Classic**
                /// *   **VPC**
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The access protocol type of the instance. Valid values:
                /// 
                /// *   **mongodb**: the MongoDB protocol
                /// *   **dynamodb**: the DynamoDB protocol
                /// 
                /// > This parameter is returned if the instance is a sharded cluster instance.
                /// </summary>
                [NameInMap("ProtocolType")]
                [Validation(Required=false)]
                public string ProtocolType { get; set; }

                /// <summary>
                /// The number of read-only nodes in the instance.
                /// </summary>
                [NameInMap("ReadonlyReplicas")]
                [Validation(Required=false)]
                public string ReadonlyReplicas { get; set; }

                /// <summary>
                /// The region ID of the instance.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The logical ID of the replica instance.
                /// 
                /// > ApsaraDB for MongoDB does not support new instances of this type. This parameter applies only to previous-version replica instances.
                /// </summary>
                [NameInMap("ReplacateId")]
                [Validation(Required=false)]
                public string ReplacateId { get; set; }

                /// <summary>
                /// The name of the replica set instance.
                /// 
                /// > This parameter is returned if the instance is a replica set instance.
                /// </summary>
                [NameInMap("ReplicaSetName")]
                [Validation(Required=false)]
                public string ReplicaSetName { get; set; }

                /// <summary>
                /// Details about replica set instances.
                /// 
                /// > This parameter is returned if the instance is a replica set instance.
                /// </summary>
                [NameInMap("ReplicaSets")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceReplicaSets ReplicaSets { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceReplicaSets : TeaModel {
                    [NameInMap("ReplicaSet")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceReplicaSetsReplicaSet> ReplicaSet { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceReplicaSetsReplicaSet : TeaModel {
                        /// <summary>
                        /// The endpoint of the node.
                        /// </summary>
                        [NameInMap("ConnectionDomain")]
                        [Validation(Required=false)]
                        public string ConnectionDomain { get; set; }

                        /// <summary>
                        /// The port number that is used to connect to the node.
                        /// </summary>
                        [NameInMap("ConnectionPort")]
                        [Validation(Required=false)]
                        public string ConnectionPort { get; set; }

                        /// <summary>
                        /// The network type of the instance. Valid values:
                        /// 
                        /// *   **Classic**
                        /// *   **VPC**
                        /// </summary>
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        /// <summary>
                        /// The role of the node. Valid values:
                        /// 
                        /// *   **Primary**
                        /// *   **Secondary**
                        /// </summary>
                        [NameInMap("ReplicaSetRole")]
                        [Validation(Required=false)]
                        public string ReplicaSetRole { get; set; }

                        /// <summary>
                        /// The ID of the instance.
                        /// 
                        /// > This parameter is returned if the network type of the instance is VPC.
                        /// </summary>
                        [NameInMap("VPCCloudInstanceId")]
                        [Validation(Required=false)]
                        public string VPCCloudInstanceId { get; set; }

                        /// <summary>
                        /// The VPC ID of the instance.
                        /// 
                        /// > This parameter is returned if the network type of the instance is VPC.
                        /// </summary>
                        [NameInMap("VPCId")]
                        [Validation(Required=false)]
                        public string VPCId { get; set; }

                        /// <summary>
                        /// The vSwitch ID of the instance.
                        /// 
                        /// > This parameter is returned if the network type of the instance is VPC.
                        /// </summary>
                        [NameInMap("VSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                    }

                }

                /// <summary>
                /// The number of nodes in the instance.
                /// 
                /// > This parameter is returned if the instance is a replica set instance.
                /// </summary>
                [NameInMap("ReplicationFactor")]
                [Validation(Required=false)]
                public string ReplicationFactor { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// 
                /// > This parameter is returned only if you use the China site (aliyun.com).
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The ID of the secondary zone 1 of the instance. Valid values:
                /// 
                /// *   **cn-hangzhou-g**: Hangzhou Zone G
                /// *   **cn-hangzhou-h**: Hangzhou Zone H
                /// *   **cn-hangzhou-i**: Hangzhou Zone I
                /// *   **cn-hongkong-b**: Hongkong Zone B
                /// *   **cn-hongkong-c**: Hongkong Zone C
                /// *   **cn-hongkong-d**: Hongkong Zone D
                /// *   **cn-wulanchabu-a**: Ulanqab Zone A
                /// *   **cn-wulanchabu-b**: Ulanqab Zone B
                /// *   **cn-wulanchabu-c**: Ulanqab Zone C
                /// *   **ap-southeast-1a**: Singapore Zone A
                /// *   **ap-southeast-1b**: Singapore Zone B
                /// *   **ap-southeast-1c**: Singapore Zone C
                /// *   **ap-southeast-5a**: Jakarta Zone A
                /// *   **ap-southeast-5b**: Jakarta Zone B
                /// *   **ap-southeast-5c**: Jakarta Zone C
                /// *   **eu-central-1a**: Frankfurt Zone A
                /// *   **eu-central-1b**: Frankfurt Zone B
                /// *   **eu-central-1c**: Frankfurt Zone C
                /// 
                /// > 
                /// 
                /// *   This parameter is returned if the instance is a replica set or sharded cluster instance that runs MongoDB 4.4 or 5.0 and uses multi-zone deployment.
                /// 
                /// *   This parameter is returned only if you use the Chine site (aliyun.com).
                /// </summary>
                [NameInMap("SecondaryZoneId")]
                [Validation(Required=false)]
                public string SecondaryZoneId { get; set; }

                /// <summary>
                /// Details about shard nodes.
                /// 
                /// > This parameter is returned if the instance is a sharded cluster instance.
                /// </summary>
                [NameInMap("ShardList")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceShardList ShardList { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceShardList : TeaModel {
                    [NameInMap("ShardAttribute")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceShardListShardAttribute> ShardAttribute { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceShardListShardAttribute : TeaModel {
                        /// <summary>
                        /// The endpoint of the shard node.
                        /// </summary>
                        [NameInMap("ConnectString")]
                        [Validation(Required=false)]
                        public string ConnectString { get; set; }

                        /// <summary>
                        /// The maximum number of connections to the shard node.
                        /// </summary>
                        [NameInMap("MaxConnections")]
                        [Validation(Required=false)]
                        public int? MaxConnections { get; set; }

                        /// <summary>
                        /// The maximum IOPS of the shard node.
                        /// </summary>
                        [NameInMap("MaxIOPS")]
                        [Validation(Required=false)]
                        public int? MaxIOPS { get; set; }

                        /// <summary>
                        /// The instance type of the shard node.
                        /// </summary>
                        [NameInMap("NodeClass")]
                        [Validation(Required=false)]
                        public string NodeClass { get; set; }

                        /// <summary>
                        /// The name of the shard node.
                        /// </summary>
                        [NameInMap("NodeDescription")]
                        [Validation(Required=false)]
                        public string NodeDescription { get; set; }

                        /// <summary>
                        /// The ID of the shard node.
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        /// <summary>
                        /// The storage capacity of the shard node.
                        /// </summary>
                        [NameInMap("NodeStorage")]
                        [Validation(Required=false)]
                        public int? NodeStorage { get; set; }

                        /// <summary>
                        /// The port number that is used to connect to the shard node.
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// The number of read-only nodes in the shard node. Valid values: **0** to **5**. The value must be an integer.
                        /// </summary>
                        [NameInMap("ReadonlyReplicas")]
                        [Validation(Required=false)]
                        public int? ReadonlyReplicas { get; set; }

                        /// <summary>
                        /// The state of the shard node. For more information, see [Instance states](~~63870~~).
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                /// <summary>
                /// The storage engine of the instance.
                /// </summary>
                [NameInMap("StorageEngine")]
                [Validation(Required=false)]
                public string StorageEngine { get; set; }

                /// <summary>
                /// The storage type of the instance. Valid values:
                /// 
                /// **cloud_essd1** :ESSD PL1 **cloud_essd2**: ESSD of PL2. **cloud_essd3**: ESSD of PL3. **local_ssd**: local SSD.
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// Details about instance tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceTags Tags { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceTagsTag> Tag { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceTagsTag : TeaModel {
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
                /// The ID of the instance.
                /// 
                /// > This parameter is returned if the network type of the instance is VPC.
                /// </summary>
                [NameInMap("VPCCloudInstanceIds")]
                [Validation(Required=false)]
                public string VPCCloudInstanceIds { get; set; }

                /// <summary>
                /// The VPC ID of the instance.
                /// 
                /// > This parameter is returned if the network type of the instance is VPC.
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// The vSwitch ID of the instance.
                /// 
                /// > This parameter is returned if the network type of the instance is VPC.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// Indicates whether password-free access within the VPC is enabled. Valid values:
                /// 
                /// *   **Open**: Password-free access is enabled.
                /// *   **Close**: Password-free access is disabled, and you must use a password for access.
                /// *   **NotSupport**: Password-free access is not supported.
                /// </summary>
                [NameInMap("VpcAuthMode")]
                [Validation(Required=false)]
                public string VpcAuthMode { get; set; }

                /// <summary>
                /// The zone ID of the instance.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

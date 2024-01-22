// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstancesResponseBody : TeaModel {
        /// <summary>
        /// The details of the instances.
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public DescribeDBInstancesResponseBodyDBInstances DBInstances { get; set; }
        public class DescribeDBInstancesResponseBodyDBInstances : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesResponseBodyDBInstancesDBInstance> DBInstance { get; set; }
            public class DescribeDBInstancesResponseBodyDBInstancesDBInstance : TeaModel {
                /// <summary>
                /// The read and write throughput consumed by the instance.
                /// 
                /// >  This parameter is returned when the instance is a serverless instance.
                /// </summary>
                [NameInMap("CapacityUnit")]
                [Validation(Required=false)]
                public string CapacityUnit { get; set; }

                /// <summary>
                /// The billing method of the instance. Valid values:
                /// 
                /// *   **PrePaid**: subscription.
                /// *   **PostPaid**: pay-as-you-go.
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// The time when the instance was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The instance type of the instance.
                /// </summary>
                [NameInMap("DBInstanceClass")]
                [Validation(Required=false)]
                public string DBInstanceClass { get; set; }

                /// <summary>
                /// The description of the instance.
                /// </summary>
                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                /// <summary>
                /// The instance ID
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// The status of the instance. For more information, see [Instance states](~~63870~~).
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
                /// *   **sharding**: sharded cluster instance.
                /// *   **replicate**: replica set or standalone instance.
                /// </summary>
                [NameInMap("DBInstanceType")]
                [Validation(Required=false)]
                public string DBInstanceType { get; set; }

                /// <summary>
                /// The time when the instance data was destroyed. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// 
                /// > *   Subscription instances are released 15 days after expiration. After the instances are released, the data of the instances is deleted and cannot be restored.
                /// > *   Pay-as-you-go instances are locked after the payments have been overdue for longer than 24 hours. The instances are released after the payments have been overdue for longer than 15 days. The data of released instances is deleted and cannot be restored.
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
                /// *   **5.0**
                /// *   **4.4**
                /// *   **4.2**
                /// *   **4.0**
                /// *   **3.4**
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// The time when the instance expires. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// The ID of the secondary zone 2 of the instance. Valid values:
                /// 
                /// *   **cn-hangzhou-g**: Hangzhou Zone G.
                /// *   **cn-hangzhou-h**: Hangzhou Zone H.
                /// *   **cn-hangzhou-i**: Hangzhou Zone I.
                /// *   **cn-hongkong-b**: Hong Kong Zone B.
                /// *   **cn-hongkong-c**: Hong Kong Zone C.
                /// *   **cn-hongkong-d**: Hong Kong Zone D.
                /// *   **cn-wulanchabu-a**: Ulanqab Zone A.
                /// *   **cn-wulanchabu-b**: Ulanqab Zone B.
                /// *   **cn-wulanchabu-c**: Ulanqab Zone C.
                /// *   **ap-southeast-1a**: Singapore Zone A.
                /// *   **ap-southeast-1b**: Singapore Zone B.
                /// *   **ap-southeast-1c**: Singapore Zone C.
                /// *   **ap-southeast-5a**: Jakarta Zone A.
                /// *   **ap-southeast-5b**: Jakarta Zone B.
                /// *   **ap-southeast-5c**: Jakarta Zone C.
                /// *   **eu-central-1a**: Frankfurt Zone A.
                /// *   **eu-central-1b**: Frankfurt Zone B.
                /// *   **eu-central-1c**: Frankfurt Zone C.
                /// 
                /// > *   This parameter is returned if the instance is a replica set or sharded cluster instance that runs MongoDB 4.4 or 5.0 and uses multi-zone deployment.
                /// > *   This parameter is returned only if you use the China site (aliyun.com).
                /// </summary>
                [NameInMap("HiddenZoneId")]
                [Validation(Required=false)]
                public string HiddenZoneId { get; set; }

                /// <summary>
                /// The kind code of the instance. Valid values:
                /// 
                /// *   **0**: physical machine.
                /// *   **1**: Elastic Compute Service (ECS) instance.
                /// *   **2**: Docker cluster.
                /// *   **18**: Kubernetes cluster.
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
                /// The lock status of the instance. Valid values:
                /// 
                /// *   **Unlock**: The instance is not locked.
                /// *   **ManualLock**: The instance is manually locked.
                /// *   **LockByExpiration**: The instance is automatically locked due to instance expiration.
                /// *   **LockByRestoration**: The instance is automatically locked before the instance is rolled back.
                /// *   **LockByDiskQuota**: The instance is automatically locked after the storage space is exhausted.
                /// *   **Released**: The instance is released. After an instance is released, the instance cannot be unlocked. You can only restore the backup data of the instance to a new instance. This process requires a long period of time.
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                /// <summary>
                /// The details of the mongos node.
                /// 
                /// >  This parameter is returned if the instance is a sharded cluster instance.
                /// </summary>
                [NameInMap("MongosList")]
                [Validation(Required=false)]
                public DescribeDBInstancesResponseBodyDBInstancesDBInstanceMongosList MongosList { get; set; }
                public class DescribeDBInstancesResponseBodyDBInstancesDBInstanceMongosList : TeaModel {
                    [NameInMap("MongosAttribute")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancesResponseBodyDBInstancesDBInstanceMongosListMongosAttribute> MongosAttribute { get; set; }
                    public class DescribeDBInstancesResponseBodyDBInstancesDBInstanceMongosListMongosAttribute : TeaModel {
                        /// <summary>
                        /// The instance type of the mongos node.
                        /// </summary>
                        [NameInMap("NodeClass")]
                        [Validation(Required=false)]
                        public string NodeClass { get; set; }

                        /// <summary>
                        /// The description of the mongos node.
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

                    }

                }

                /// <summary>
                /// The network type of the instance. Valid values:
                /// 
                /// *   **Classic**: classic network.
                /// *   **VPC**: VPC.
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The region ID of the instance.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The number of nodes in the instance.
                /// 
                /// >  This parameter is returned if the instance is a replica set instance.
                /// </summary>
                [NameInMap("ReplicationFactor")]
                [Validation(Required=false)]
                public string ReplicationFactor { get; set; }

                /// <summary>
                /// The ID of the resource group to which the instance belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The ID of the secondary zone 1 of the instance. Valid values:
                /// 
                /// *   **cn-hangzhou-g**: Hangzhou Zone G.
                /// *   **cn-hangzhou-h**: Hangzhou Zone H.
                /// *   **cn-hangzhou-i**: Hangzhou Zone I.
                /// *   **cn-hongkong-b**: Hong Kong Zone B.
                /// *   **cn-hongkong-c**: Hong Kong Zone C.
                /// *   **cn-hongkong-d**: Hong Kong Zone D.
                /// *   **cn-wulanchabu-a**: Ulanqab Zone A.
                /// *   **cn-wulanchabu-b**: Ulanqab Zone B.
                /// *   **cn-wulanchabu-c**: Ulanqab Zone C.
                /// *   **ap-southeast-1a**: Singapore Zone A.
                /// *   **ap-southeast-1b**: Singapore Zone B.
                /// *   **ap-southeast-1c**: Singapore Zone C.
                /// *   **ap-southeast-5a**: Jakarta Zone A.
                /// *   **ap-southeast-5b**: Jakarta Zone B.
                /// *   **ap-southeast-5c**: Jakarta Zone C.
                /// *   **eu-central-1a**: Frankfurt Zone A.
                /// *   **eu-central-1b**: Frankfurt Zone B.
                /// *   **eu-central-1c**: Frankfurt Zone C.
                /// 
                /// > *   This parameter is returned if the instance is a replica set or sharded cluster instance that runs MongoDB 4.4 or 5.0 and uses multi-zone deployment.
                /// > *   This parameter is returned only if you use the China site (aliyun.com).
                /// </summary>
                [NameInMap("SecondaryZoneId")]
                [Validation(Required=false)]
                public string SecondaryZoneId { get; set; }

                /// <summary>
                /// The details of the shard node.
                /// 
                /// >  This parameter is returned if the instance is a sharded cluster instance.
                /// </summary>
                [NameInMap("ShardList")]
                [Validation(Required=false)]
                public DescribeDBInstancesResponseBodyDBInstancesDBInstanceShardList ShardList { get; set; }
                public class DescribeDBInstancesResponseBodyDBInstancesDBInstanceShardList : TeaModel {
                    [NameInMap("ShardAttribute")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancesResponseBodyDBInstancesDBInstanceShardListShardAttribute> ShardAttribute { get; set; }
                    public class DescribeDBInstancesResponseBodyDBInstancesDBInstanceShardListShardAttribute : TeaModel {
                        /// <summary>
                        /// The instance type of the shard node.
                        /// </summary>
                        [NameInMap("NodeClass")]
                        [Validation(Required=false)]
                        public string NodeClass { get; set; }

                        /// <summary>
                        /// The description of the shard node.
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
                        /// The storage capacity of the shard node. Unit: GB.
                        /// </summary>
                        [NameInMap("NodeStorage")]
                        [Validation(Required=false)]
                        public int? NodeStorage { get; set; }

                        /// <summary>
                        /// The number of read-only nodes in the shard node. Valid values: **0** to **5**.
                        /// </summary>
                        [NameInMap("ReadonlyReplicas")]
                        [Validation(Required=false)]
                        public int? ReadonlyReplicas { get; set; }

                    }

                }

                /// <summary>
                /// The storage type of the instance. Valid values:
                /// 
                /// *   **cloud_essd**: enhanced SSD (ESSD).
                /// *   **local_ssd**: local SSD.
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// The details of the resource tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDBInstancesResponseBodyDBInstancesDBInstanceTags Tags { get; set; }
                public class DescribeDBInstancesResponseBodyDBInstancesDBInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancesResponseBodyDBInstancesDBInstanceTagsTag> Tag { get; set; }
                    public class DescribeDBInstancesResponseBodyDBInstancesDBInstanceTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// Indicates whether password-free access within a virtual private cloud (VPC) is enabled. Valid values:
                /// 
                /// *   **Open**
                /// *   **Close**
                /// </summary>
                [NameInMap("VpcAuthMode")]
                [Validation(Required=false)]
                public string VpcAuthMode { get; set; }

                /// <summary>
                /// The ID of the zone in which the instance resides.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of instances in the query results.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

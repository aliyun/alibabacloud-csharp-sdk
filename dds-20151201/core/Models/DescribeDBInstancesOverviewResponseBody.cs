// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstancesOverviewResponseBody : TeaModel {
        /// <summary>
        /// Details about the instances.
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public List<DescribeDBInstancesOverviewResponseBodyDBInstances> DBInstances { get; set; }
        public class DescribeDBInstancesOverviewResponseBodyDBInstances : TeaModel {
            /// <summary>
            /// The I/O throughput consumed by the instance.
            /// 
            /// > * This parameter is returned when the instance is a serverless instance.
            /// > * Serverless instances are available only in the China site (aliyun.com).
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
            /// The time when the instance was created. The time is in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The instance type of the instance. The instance type varies based on the instance architecture. For more information about instance types supported by different instance architectures, see the following topics:
            /// 
            /// *   [Standalone instance types](~~311407~~)
            /// *   [Replica set instance types](~~311410~~)
            /// *   [Sharded cluster instance types](~~311414~~)
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
            /// The ID of the instance.
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// The state of the instance. For more information about valid values, see [Instance states](~~63870~~).
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
            /// The category of the instance. Valid values:
            /// 
            /// *   **sharding**: sharded cluster instance
            /// *   **replicate**: replica set or standalone instance
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
            /// The database engine of the instance. Set the value to **MongoDB**.
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// The database engine version of the instance.
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// The time when the instance expires. The time is in the *yyyy-MM-dd*T*HH:mm*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

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
            /// The last time when the instance was downgraded.
            /// </summary>
            [NameInMap("LastDowngradeTime")]
            [Validation(Required=false)]
            public string LastDowngradeTime { get; set; }

            /// <summary>
            /// Indicates whether the instance is locked. Valid values:
            /// 
            /// *   **Unlock**: The instance is not locked.
            /// *   **ManualLock**: The cluster is manually locked.
            /// *   **LockByExpiration**: The instance is automatically locked after it expires.
            /// *   **LockByRestoration**: The instance is automatically locked before it is rolled back.
            /// *   **LockByDiskQuota**: The instance is automatically locked after the storage capacity is exhausted.
            /// *   **Released**: The instance is released. After an instance is released, the instance cannot be unlocked. You can only restore the backup data of the instance to a new instance. This process requires an extended period of time.
            /// </summary>
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// Details about the mongos node.
            /// 
            /// >  This parameter is returned if the instance is a sharded cluster instance.
            /// </summary>
            [NameInMap("MongosList")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesOverviewResponseBodyDBInstancesMongosList> MongosList { get; set; }
            public class DescribeDBInstancesOverviewResponseBodyDBInstancesMongosList : TeaModel {
                /// <summary>
                /// The type of the mongos node.
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
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// Details about the shard node.
            /// 
            /// >  This parameter is returned if the instance is a sharded cluster instance.
            /// </summary>
            [NameInMap("ShardList")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesOverviewResponseBodyDBInstancesShardList> ShardList { get; set; }
            public class DescribeDBInstancesOverviewResponseBodyDBInstancesShardList : TeaModel {
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

            /// <summary>
            /// The tags of the instance.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesOverviewResponseBodyDBInstancesTags> Tags { get; set; }
            public class DescribeDBInstancesOverviewResponseBodyDBInstancesTags : TeaModel {
                /// <summary>
                /// The key of tag N of the instance. Valid values of N: **1** to **20**.
                /// 
                /// *   The key cannot start with `aliyun`, `acs:`, `http://`, or `https://`.
                /// *   The key can be up to 64 characters in length.
                /// *   The key cannot be an empty string.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of tag N of the instance. Valid values of N: **1** to **20**.
                /// 
                /// *   The value cannot start with `aliyun`, `acs:`, `http://`, or `https://`.
                /// *   The value can be up to 128 characters in length.
                /// *   The value can be an empty string.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// Indicates whether password-free access within a VPC is enabled. Valid values:
            /// 
            /// *   **Open**: Password-free access is enabled.
            /// *   **Close**: Password-free access is disabled.
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

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of instances in the query result.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}

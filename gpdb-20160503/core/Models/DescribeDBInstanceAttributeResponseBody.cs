// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// The queried instance.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstanceAttributeResponseBodyItems Items { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyItems : TeaModel {
            [NameInMap("DBInstanceAttribute")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttribute> DBInstanceAttribute { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttribute : TeaModel {
                /// <summary>
                /// The service availability of the instance. Unit: %.
                /// 
                /// > This parameter is returned only for instances in reserved storage mode.
                /// </summary>
                [NameInMap("AvailabilityValue")]
                [Validation(Required=false)]
                public string AvailabilityValue { get; set; }

                /// <summary>
                /// The access mode of the instance. Valid values:
                /// 
                /// *   **Performance**: standard mode.
                /// *   **Safety**: safe mode.
                /// *   **LVS**: Linux Virtual Server (LVS) mode.
                /// </summary>
                [NameInMap("ConnectionMode")]
                [Validation(Required=false)]
                public string ConnectionMode { get; set; }

                /// <summary>
                /// The endpoint that is used to connect to the instance.
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// The number of the minor version.
                /// </summary>
                [NameInMap("CoreVersion")]
                [Validation(Required=false)]
                public string CoreVersion { get; set; }

                /// <summary>
                /// The number of CPU cores per compute node.
                /// </summary>
                [NameInMap("CpuCores")]
                [Validation(Required=false)]
                public int? CpuCores { get; set; }

                /// <summary>
                /// The number of CPU cores per node.
                /// 
                /// > This parameter is returned only for instances in reserved storage mode.
                /// </summary>
                [NameInMap("CpuCoresPerNode")]
                [Validation(Required=false)]
                public int? CpuCoresPerNode { get; set; }

                /// <summary>
                /// The time when the instance was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The edition of the instance. Valid values:
                /// 
                /// *   **Basic**: Basic Edition.
                /// *   **HighAvailability**: High-availability Edition.
                /// </summary>
                [NameInMap("DBInstanceCategory")]
                [Validation(Required=false)]
                public string DBInstanceCategory { get; set; }

                /// <summary>
                /// The instance type of the instance.
                /// 
                /// > This parameter is returned only for instances in reserved storage mode.
                /// </summary>
                [NameInMap("DBInstanceClass")]
                [Validation(Required=false)]
                public string DBInstanceClass { get; set; }

                /// <summary>
                /// The instance family of the instance. Valid values:
                /// 
                /// *   **s**: shared.
                /// *   **x**: general-purpose.
                /// *   **d**: dedicated.
                /// *   **h**: dedicated host.
                /// </summary>
                [NameInMap("DBInstanceClassType")]
                [Validation(Required=false)]
                public string DBInstanceClassType { get; set; }

                /// <summary>
                /// The number of CPU cores.
                /// </summary>
                [NameInMap("DBInstanceCpuCores")]
                [Validation(Required=false)]
                public int? DBInstanceCpuCores { get; set; }

                /// <summary>
                /// The description of the instance.
                /// </summary>
                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                /// <summary>
                /// The maximum disk throughput of the compute group. Unit: Mbit/s.
                /// 
                /// > This parameter is returned only for instances in reserved storage mode.
                /// </summary>
                [NameInMap("DBInstanceDiskMBPS")]
                [Validation(Required=false)]
                public long? DBInstanceDiskMBPS { get; set; }

                /// <summary>
                /// The number of compute groups.
                /// 
                /// > This parameter is returned only for instances in reserved storage mode.
                /// </summary>
                [NameInMap("DBInstanceGroupCount")]
                [Validation(Required=false)]
                public string DBInstanceGroupCount { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// The memory capacity per compute node.
                /// 
                /// > The unit of this parameter is MB for instances in reserved storage mode and GB for instances in Serverless or elastic storage mode.
                /// </summary>
                [NameInMap("DBInstanceMemory")]
                [Validation(Required=false)]
                public long? DBInstanceMemory { get; set; }

                /// <summary>
                /// The resource type of the instance. Valid values:
                /// 
                /// *   **Serverless**: Serverless mode.
                /// *   **StorageElastic**: elastic storage mode.
                /// *   **Classic**: reserved storage mode.
                /// </summary>
                [NameInMap("DBInstanceMode")]
                [Validation(Required=false)]
                public string DBInstanceMode { get; set; }

                /// <summary>
                /// The type of the network interface card (NIC) that is used by the instance. Valid values:
                /// 
                /// *   **0**: Internet.
                /// *   **1**: internal network.
                /// *   **2**: VPC.
                /// </summary>
                [NameInMap("DBInstanceNetType")]
                [Validation(Required=false)]
                public string DBInstanceNetType { get; set; }

                /// <summary>
                /// The state of the instance. For more information, see the "Additional description of DBInstanceStatus" section of this topic.
                /// </summary>
                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public string DBInstanceStatus { get; set; }

                /// <summary>
                /// The maximum storage capacity per node. Unit: GB.
                /// </summary>
                [NameInMap("DBInstanceStorage")]
                [Validation(Required=false)]
                public long? DBInstanceStorage { get; set; }

                /// <summary>
                /// The encryption key.
                /// 
                /// > This parameter is returned only for instances that have disk encryption enabled.
                /// </summary>
                [NameInMap("EncryptionKey")]
                [Validation(Required=false)]
                public string EncryptionKey { get; set; }

                /// <summary>
                /// The encryption type. Valid values:
                /// 
                /// *   **CloudDisk**: disk encryption.
                /// 
                /// > This parameter is returned only for instances that have disk encryption enabled.
                /// </summary>
                [NameInMap("EncryptionType")]
                [Validation(Required=false)]
                public string EncryptionType { get; set; }

                /// <summary>
                /// The database engine of the instance.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The version of the database engine.
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// The expiration time of the instance. The time is displayed in UTC.
                /// 
                /// > The expiration time of a pay-as-you-go instance is `2999-09-08T16:00:00Z`.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// The disk type of the compute group. Valid values:
                /// 
                /// *   **0**: SSD.
                /// *   **1**: HDD.
                /// 
                /// > This parameter is returned only for instances in reserved storage mode.
                /// </summary>
                [NameInMap("HostType")]
                [Validation(Required=false)]
                public string HostType { get; set; }

                /// <summary>
                /// The wait period for the instance that has no traffic to become idle. Unit: seconds.
                /// 
                /// > This parameter is returned only for instances in Serverless automatic scheduling mode.
                /// </summary>
                [NameInMap("IdleTime")]
                [Validation(Required=false)]
                public int? IdleTime { get; set; }

                /// <summary>
                /// The network type of the instance. Valid values:
                /// 
                /// *   **Classic**: classic network.
                /// *   **VPC**: VPC.
                /// </summary>
                [NameInMap("InstanceNetworkType")]
                [Validation(Required=false)]
                public string InstanceNetworkType { get; set; }

                /// <summary>
                /// The lock mode of the instance. Valid values:
                /// 
                /// *   **Unlock**: The instance is not locked.
                /// *   **ManualLock**: The instance is manually locked.
                /// *   **LockByExpiration**: The instance is automatically locked due to instance expiration.
                /// *   **LockByRestoration**: The instance is automatically locked due to instance restoration.
                /// *   **LockByDiskQuota**: The instance is automatically locked due to exhausted storage.
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                /// <summary>
                /// An invalid parameter. It is no longer returned when you call this operation.
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// The end time of the maintenance window of the instance.
                /// </summary>
                [NameInMap("MaintainEndTime")]
                [Validation(Required=false)]
                public string MaintainEndTime { get; set; }

                /// <summary>
                /// The start time of the maintenance window of the instance.
                /// </summary>
                [NameInMap("MaintainStartTime")]
                [Validation(Required=false)]
                public string MaintainStartTime { get; set; }

                [NameInMap("MasterCU")]
                [Validation(Required=false)]
                public int? MasterCU { get; set; }

                /// <summary>
                /// The number of coordinator nodes.
                /// </summary>
                [NameInMap("MasterNodeNum")]
                [Validation(Required=false)]
                public int? MasterNodeNum { get; set; }

                /// <summary>
                /// The maximum number of concurrent connections to the instance.
                /// 
                /// > This parameter is returned only for instances in reserved storage mode.
                /// </summary>
                [NameInMap("MaxConnections")]
                [Validation(Required=false)]
                public int? MaxConnections { get; set; }

                /// <summary>
                /// The memory capacity per node. The unit of this parameter can be one of the valid values of **MemoryUnit**.
                /// 
                /// > This parameter is returned only for instances in reserved storage mode.
                /// </summary>
                [NameInMap("MemoryPerNode")]
                [Validation(Required=false)]
                public int? MemoryPerNode { get; set; }

                /// <summary>
                /// The memory capacity per compute node.
                /// 
                /// > The unit of this parameter is MB for instances in reserved storage mode and GB for instances in Serverless or elastic storage mode.
                /// </summary>
                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public long? MemorySize { get; set; }

                /// <summary>
                /// The unit of the memory capacity.
                /// 
                /// > This parameter is returned only for instances in reserved storage mode.
                /// </summary>
                [NameInMap("MemoryUnit")]
                [Validation(Required=false)]
                public string MemoryUnit { get; set; }

                /// <summary>
                /// The minor version of the instance.
                /// </summary>
                [NameInMap("MinorVersion")]
                [Validation(Required=false)]
                public string MinorVersion { get; set; }

                /// <summary>
                /// The billing method of the instance. Valid values:
                /// 
                /// *   **Postpaid**: pay-as-you-go.
                /// *   **Prepaid**: subscription.
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// The port number that is used to connect to the instance.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// An invalid parameter. It is no longer returned when you call this operation.
                /// </summary>
                [NameInMap("ReadDelayTime")]
                [Validation(Required=false)]
                public string ReadDelayTime { get; set; }

                /// <summary>
                /// The region ID of the instance.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group to which the instance belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The running duration of the instance.
                /// </summary>
                [NameInMap("RunningTime")]
                [Validation(Required=false)]
                public string RunningTime { get; set; }

                /// <summary>
                /// The IP address whitelist of the instance.
                /// </summary>
                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

                /// <summary>
                /// The performance level of ESSDs. Only **PL1** is supported.
                /// </summary>
                [NameInMap("SegDiskPerformanceLevel")]
                [Validation(Required=false)]
                public string SegDiskPerformanceLevel { get; set; }

                /// <summary>
                /// The number of compute nodes.
                /// 
                /// > This parameter is returned only for instances in Serverless or elastic storage mode.
                /// </summary>
                [NameInMap("SegNodeNum")]
                [Validation(Required=false)]
                public int? SegNodeNum { get; set; }

                /// <summary>
                /// The number of compute groups.
                /// 
                /// > This parameter is returned only for instances in reserved storage mode.
                /// </summary>
                [NameInMap("SegmentCounts")]
                [Validation(Required=false)]
                public int? SegmentCounts { get; set; }

                /// <summary>
                /// The type of the Serverless mode. Valid values:
                /// 
                /// *   **Manual**: manual scheduling.
                /// *   **Auto**: automatic scheduling.
                /// 
                /// > This parameter is returned only for instances in Serverless mode.
                /// </summary>
                [NameInMap("ServerlessMode")]
                [Validation(Required=false)]
                public string ServerlessMode { get; set; }

                /// <summary>
                /// The threshold of computing resources. Unit: AnalyticDB compute units (ACUs).
                /// 
                /// > This parameter is returned only for instances in Serverless automatic scheduling mode.
                /// </summary>
                [NameInMap("ServerlessResource")]
                [Validation(Required=false)]
                public int? ServerlessResource { get; set; }

                /// <summary>
                /// The time when the instance started to run.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The storage capacity per node. The unit of this parameter can be one of the valid values of **StorageUnit**.
                /// 
                /// > This parameter is returned only for instances in reserved storage mode.
                /// </summary>
                [NameInMap("StoragePerNode")]
                [Validation(Required=false)]
                public int? StoragePerNode { get; set; }

                /// <summary>
                /// The storage capacity of the instance. Unit: GB.
                /// </summary>
                [NameInMap("StorageSize")]
                [Validation(Required=false)]
                public long? StorageSize { get; set; }

                /// <summary>
                /// The storage type of the instance. Valid values:
                /// 
                /// *   **cloud_essd**: enhanced SSD (ESSD).
                /// *   **cloud_efficiency**: ultra disk.
                /// 
                /// > This parameter is returned only for instances in elastic storage mode.
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// The unit of the storage capacity. Valid values:
                /// 
                /// *   **GB SSD**
                /// *   **TB SSD**
                /// *   **GB HDD**
                /// 
                /// > This parameter is returned only for instances in Serverless or reserved storage mode.
                /// </summary>
                [NameInMap("StorageUnit")]
                [Validation(Required=false)]
                public string StorageUnit { get; set; }

                /// <summary>
                /// Indicates whether the instance supports backup and restoration. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("SupportRestore")]
                [Validation(Required=false)]
                public bool? SupportRestore { get; set; }

                /// <summary>
                /// The tags of the instance. Each tag is a key-value pair.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeTags Tags { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeTagsTag> Tag { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeTagsTag : TeaModel {
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
                /// The vSwitch ID of the instance.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// Indicates whether vector engine optimization is enabled. Valid values:
                /// 
                /// *   **enabled**
                /// *   **disabled**
                /// </summary>
                [NameInMap("VectorConfigurationStatus")]
                [Validation(Required=false)]
                public string VectorConfigurationStatus { get; set; }

                /// <summary>
                /// The virtual private cloud (VPC) ID of the instance.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The zone ID of the instance.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

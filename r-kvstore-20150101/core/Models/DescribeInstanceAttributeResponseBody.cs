// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// Details about the instances.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeInstanceAttributeResponseBodyInstances Instances { get; set; }
        public class DescribeInstanceAttributeResponseBodyInstances : TeaModel {
            [NameInMap("DBInstanceAttribute")]
            [Validation(Required=false)]
            public List<DescribeInstanceAttributeResponseBodyInstancesDBInstanceAttribute> DBInstanceAttribute { get; set; }
            public class DescribeInstanceAttributeResponseBodyInstancesDBInstanceAttribute : TeaModel {
                /// <summary>
                /// The architecture of the instance. Valid values:
                /// 
                /// *   **cluster**: cluster architecture
                /// *   **standard**: standard architecture
                /// *   **rwsplit**: read/write splitting architecture
                /// </summary>
                [NameInMap("ArchitectureType")]
                [Validation(Required=false)]
                public string ArchitectureType { get; set; }

                /// <summary>
                /// The retention period of audit logs. Unit: day. A value of 0 indicates that the audit log feature is disabled. For information about how to enable the feature, see [Enable the audit log feature](https://help.aliyun.com/document_detail/102015.html).
                /// </summary>
                [NameInMap("AuditLogRetention")]
                [Validation(Required=false)]
                public string AuditLogRetention { get; set; }

                /// <summary>
                /// The availability metric of the current month.
                /// </summary>
                [NameInMap("AvailabilityValue")]
                [Validation(Required=false)]
                public string AvailabilityValue { get; set; }

                /// <summary>
                /// The earliest point in time to which data can be restored. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// 
                /// > 
                /// 
                /// *   This parameter is returned only when the data flashback feature is enabled for the instance. For more information, see [Restore data to a point in time by using the data flashback feature](https://help.aliyun.com/document_detail/148479.html).
                /// 
                /// *   When you call the [RestoreInstance](https://help.aliyun.com/document_detail/61083.html) operation to implement data flashback, you can obtain the earliest point in time for data flashback from the return value of this parameter and set the **RestoreTime** parameter to this point in time.
                /// </summary>
                [NameInMap("BackupLogStartTime")]
                [Validation(Required=false)]
                public string BackupLogStartTime { get; set; }

                /// <summary>
                /// The bandwidth of the instance. Unit: Mbit/s.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                /// <summary>
                /// The storage capacity of the instance. Unit: MB.
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public long? Capacity { get; set; }

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
                /// This parameter is returned only when the instance is in a cloud box.
                /// </summary>
                [NameInMap("CloudType")]
                [Validation(Required=false)]
                public string CloudType { get; set; }

                /// <summary>
                /// The parameter configurations of the instance in the JSON format. For more information, see [Parameter descriptions](https://help.aliyun.com/document_detail/43885.html). You can use the [DescribeAuditLogConfig](https://help.aliyun.com/document_detail/473830.html) operation to query audit log configurations.
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// The internal endpoint of the instance.
                /// </summary>
                [NameInMap("ConnectionDomain")]
                [Validation(Required=false)]
                public string ConnectionDomain { get; set; }

                /// <summary>
                /// The maximum number of connections supported by the instance.
                /// </summary>
                [NameInMap("Connections")]
                [Validation(Required=false)]
                public long? Connections { get; set; }

                /// <summary>
                /// The time when the instance was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The time when the subscription expires. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The database engine of the instance. The return value is **Redis**.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The database engine version of the instance. Valid values: **2.8**, **4.0**, and **5.0**.
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// The ID of the distributed instance to which the instance belongs.
                /// 
                /// >  This parameter is returned only when the ApsaraDB for Redis instance is a child instance of a distributed instance.
                /// </summary>
                [NameInMap("GlobalInstanceId")]
                [Validation(Required=false)]
                public string GlobalInstanceId { get; set; }

                /// <summary>
                /// Indicates whether your Alibaba Cloud account has pending orders for renewal and configuration change. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("HasRenewChangeOrder")]
                [Validation(Required=false)]
                public string HasRenewChangeOrder { get; set; }

                /// <summary>
                /// The instance type. For more information, see [Instance types](https://help.aliyun.com/document_detail/107984.html).
                /// </summary>
                [NameInMap("InstanceClass")]
                [Validation(Required=false)]
                public string InstanceClass { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// Indicates whether the release protection feature is enabled for the instance. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("InstanceReleaseProtection")]
                [Validation(Required=false)]
                public bool? InstanceReleaseProtection { get; set; }

                /// <summary>
                /// The state of the instance. Valid values:
                /// 
                /// *   **Normal**: The instance is normal.
                /// *   **Creating**: The instance is being created.
                /// *   **Changing**: The configurations of the instance are being changed.
                /// *   **Inactive**: The instance is disabled.
                /// *   **Flushing**: The instance is being released.
                /// *   **Released**: The instance is released.
                /// *   **Transforming**: The billing method of the instance is being changed.
                /// *   **Unavailable**: The instance is unavailable.
                /// *   **Error**: The instance failed to be created.
                /// *   **Migrating**: The instance is being migrated.
                /// *   **BackupRecovering**: The instance is being restored from a backup.
                /// *   **MinorVersionUpgrading**: The minor version of the instance is being updated.
                /// *   **NetworkModifying**: The network type of the instance is being changed.
                /// *   **SSLModifying**: The SSL configurations of the instance are being changed.
                /// *   **MajorVersionUpgrading**: The major version of the instance is being upgraded. The instance remains accessible during the upgrade.
                /// 
                /// >  For more information about instance states, see [Instance states and impacts](https://help.aliyun.com/document_detail/200740.html).
                /// </summary>
                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                /// <summary>
                /// The database engine of the instance. Valid values:
                /// 
                /// *   **Tair**
                /// *   **Redis**
                /// *   **Memcache**
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// Indicates whether the order for instance configuration change has reached the final state. Valid values:
                /// 
                /// *   **true**: The configuration change has been completed or has not been performed.
                /// *   **false**: The configurations of the instance are being changed.
                /// </summary>
                [NameInMap("IsOrderCompleted")]
                [Validation(Required=false)]
                public bool? IsOrderCompleted { get; set; }

                /// <summary>
                /// Indicates whether the instance is managed by ApsaraDB RDS. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("IsRds")]
                [Validation(Required=false)]
                public bool? IsRds { get; set; }

                /// <summary>
                /// Indicates whether the transparent data encryption (TDE) feature is supported for the instance. Valid values:
                /// 
                /// *   **true**: This feature is supported. This feature is available only for [DRAM-based](https://help.aliyun.com/document_detail/443827.html) instances that use local disks.
                /// *   **false**: This feature is not supported.
                /// </summary>
                [NameInMap("IsSupportTDE")]
                [Validation(Required=false)]
                public bool? IsSupportTDE { get; set; }

                /// <summary>
                /// The end time of the maintenance window. The time is in the *HH:mmZ* format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("MaintainEndTime")]
                [Validation(Required=false)]
                public string MaintainEndTime { get; set; }

                /// <summary>
                /// The start time of the maintenance window. The time is in the *HH:mmZ* format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("MaintainStartTime")]
                [Validation(Required=false)]
                public string MaintainStartTime { get; set; }

                /// <summary>
                /// The network type of the instance. Valid values:
                /// 
                /// *   **CLASSIC**
                /// *   **VPC**
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The node type. Valid values:
                /// 
                /// *   **double**: The instance contains a master node and a replica node.
                /// *   **single**: The instance is a standalone instance.
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// The plan type. Valid values:
                /// 
                /// *   **standard**: standard plan.
                /// *   **customized**: custom plan. This plan type is phased out.
                /// </summary>
                [NameInMap("PackageType")]
                [Validation(Required=false)]
                public string PackageType { get; set; }

                /// <summary>
                /// The service port of the instance.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public long? Port { get; set; }

                /// <summary>
                /// The private IP address of the instance.
                /// 
                /// >  This parameter is not returned when the instance is deployed in the classic network.
                /// </summary>
                [NameInMap("PrivateIp")]
                [Validation(Required=false)]
                public string PrivateIp { get; set; }

                /// <summary>
                /// The expected maximum queries per second (QPS).
                /// </summary>
                [NameInMap("QPS")]
                [Validation(Required=false)]
                public long? QPS { get; set; }

                /// <summary>
                /// The number of read replicas. This parameter is available only for read/write splitting instances that use cloud disks.
                /// </summary>
                [NameInMap("ReadOnlyCount")]
                [Validation(Required=false)]
                public int? ReadOnlyCount { get; set; }

                /// <summary>
                /// If the instance is a cluster instance that uses cloud disks, this parameter indicates the actual instance type of individual shards in the instance. The InstanceClass parameter indicates the virtual instance type.
                /// 
                /// >  To query fees for instances of the instance type, you can specify the instance type that is returned by this parameter in the [DescribePrice](https://help.aliyun.com/document_detail/95612.html) operation.
                /// </summary>
                [NameInMap("RealInstanceClass")]
                [Validation(Required=false)]
                public string RealInstanceClass { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the replica node.
                /// </summary>
                [NameInMap("ReplicaId")]
                [Validation(Required=false)]
                public string ReplicaId { get; set; }

                /// <summary>
                /// The architecture of the replica node. Valid values:
                /// 
                /// *   **master-slave**: the standard master-replica architecture.
                /// *   **cluster**: the cluster architecture, which includes the read/write splitting instances and cluster instances.
                /// </summary>
                [NameInMap("ReplicationMode")]
                [Validation(Required=false)]
                public string ReplicationMode { get; set; }

                /// <summary>
                /// The ID of the resource group to which the instance belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The ID of the secondary zone.
                /// 
                /// >  This parameter is returned only if the instance has a secondary zone ID.
                /// </summary>
                [NameInMap("SecondaryZoneId")]
                [Validation(Required=false)]
                public string SecondaryZoneId { get; set; }

                /// <summary>
                /// The IP addresses in the whitelist.
                /// </summary>
                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

                /// <summary>
                /// The number of shards. This parameter is available only for ApsaraDB for Redis instances that are purchased on the China site (aliyun.com).
                /// </summary>
                [NameInMap("ShardCount")]
                [Validation(Required=false)]
                public int? ShardCount { get; set; }

                /// <summary>
                /// The number of read replicas in the secondary zone. This parameter is returned only after read/write splitting is enabled for the instance across multiple zones.
                /// </summary>
                [NameInMap("SlaveReadOnlyCount")]
                [Validation(Required=false)]
                public long? SlaveReadOnlyCount { get; set; }

                /// <summary>
                /// The storage capacity of the cloud disk.
                /// </summary>
                [NameInMap("Storage")]
                [Validation(Required=false)]
                public string Storage { get; set; }

                /// <summary>
                /// The storage type.
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// Details about the tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeInstanceAttributeResponseBodyInstancesDBInstanceAttributeTags Tags { get; set; }
                public class DescribeInstanceAttributeResponseBodyInstancesDBInstanceAttributeTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceAttributeResponseBodyInstancesDBInstanceAttributeTagsTag> Tag { get; set; }
                    public class DescribeInstanceAttributeResponseBodyInstancesDBInstanceAttributeTagsTag : TeaModel {
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
                /// The ID of the vSwitch.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// Indicates whether password authentication is enabled. Valid values:
                /// 
                /// *   **Open**: Password authentication is enabled.
                /// *   **Close**: Password authentication is disabled and [password-free access](https://help.aliyun.com/document_detail/85168.html) is enabled.
                /// </summary>
                [NameInMap("VpcAuthMode")]
                [Validation(Required=false)]
                public string VpcAuthMode { get; set; }

                /// <summary>
                /// The ID of the instance in the VPC.
                /// </summary>
                [NameInMap("VpcCloudInstanceId")]
                [Validation(Required=false)]
                public string VpcCloudInstanceId { get; set; }

                /// <summary>
                /// The ID of the virtual private cloud (VPC).
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The zone ID.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// The deployment type of the instance. Valid values:
                /// 
                /// *   **singlezone**: The instance is deployed in a single zone.
                /// *   **doublezone**: The instance is deployed in two zones of the same region.
                /// </summary>
                [NameInMap("ZoneType")]
                [Validation(Required=false)]
                public string ZoneType { get; set; }

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

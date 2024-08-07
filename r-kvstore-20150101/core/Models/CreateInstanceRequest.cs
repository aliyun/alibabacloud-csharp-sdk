// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable append-only file (AOF) persistence for the instance. Valid values:
        /// 
        /// *   **yes** (default): enables AOF persistence.
        /// *   **no**: disables AOF persistence.
        /// 
        /// **
        /// 
        /// **Description** This parameter is applicable to classic instances, and is unavailable for cloud-native instances.
        /// </summary>
        [NameInMap("Appendonly")]
        [Validation(Required=false)]
        public string Appendonly { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal for the instance. Default value: false. Valid values:
        /// 
        /// *   **true**: enables auto-renewal.
        /// *   **false**: disables auto-renewal.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// The subscription duration that is supported by auto-renewal. Unit: months. Valid values: **1**, **2**, **3**, **6**, and **12**.
        /// 
        /// > This parameter is required only if the **AutoRenew** parameter is set to **true**.
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public string AutoRenewPeriod { get; set; }

        /// <summary>
        /// Specifies whether to use a coupon. Default value: false. Valid values:
        /// 
        /// *   **true**: uses a coupon.
        /// *   **false**: does not use a coupon.
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public string AutoUseCoupon { get; set; }

        /// <summary>
        /// If your instance is a cloud-native cluster instance, we recommend that you use [DescribeClusterBackupList](https://help.aliyun.com/document_detail/2679158.html) to query the backup set ID of the cluster instance, such as cb-xx. Then, set the ClusterBackupId request parameter to the backup set ID to clone the cluster instance. This eliminates the need to specify the backup set ID of each shard.
        /// 
        /// You can set the BackupId parameter to the backup set ID of the source instance. The system uses the data stored in the backup set to create an instance. You can call the [DescribeBackups](https://help.aliyun.com/document_detail/61081.html) operation to query backup set IDs. If the source instance is a cluster instance, set the BackupId parameter to the backup set IDs of all shards of the source instance, separated by commas (,). Example: "10\\*\\*,11\\*\\*,15\\*\\*".
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// The ID of the promotional event or business information.
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// The storage capacity of the instance. Unit: MB.
        /// 
        /// > You must specify at least one of the **Capacity** and **InstanceClass** parameters when you call this operation.
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        /// <summary>
        /// The billing method of the instance. Default value: PrePaid. Valid values:
        /// 
        /// *   **PrePaid**: subscription
        /// *   **PostPaid**: pay-as-you-go
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// This parameter is supported for specific new cluster instances. You can query the backup set ID by using the [DescribeClusterBackupList](https://help.aliyun.com/document_detail/2679158.html) operation.
        /// 
        /// *   If this parameter is supported, you can specify the backup set ID. In this case, you do not need to specify the **BackupId** parameter.
        /// *   If this parameter is not supported, set the BackupId parameter to the IDs of backup sets for all shards of the source instance, separated by commas (,). Example: "2158\\*\\*\\*\\*20,2158\\*\\*\\*\\*22".
        /// </summary>
        [NameInMap("ClusterBackupId")]
        [Validation(Required=false)]
        public string ClusterBackupId { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **AllocateInstancePublicConnection**.
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// The coupon code. Default value: `default`.
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// The ID of the dedicated cluster. This parameter is required if you create an instance in a dedicated cluster.
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run. Default value: false. Valid values:
        /// 
        /// *   **true**: performs a dry run and does not create the instance. The system prechecks the request parameters, request format, service limits, and available resources. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false**: performs a dry run and sends the request. If the request passes the dry run, the instance is created.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The engine version. Valid values for **classic instances**:
        /// 
        /// *   **2.8** (not recommended due to [scheduled EOFS](https://help.aliyun.com/document_detail/2674657.html))
        /// *   **4.0** (not recommended)
        /// *   **5.0**
        /// 
        /// Valid values for **cloud-native instances**:
        /// 
        /// *   **5.0**
        /// *   **6.0** (recommended)
        /// *   **7.0**
        /// 
        /// >  The default value is **5.0**.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// Specifies whether to use the new instance as the first child instance of the distributed instance. Default value: false. Valid values:
        /// 
        /// *   **true**: uses the new instance as the first child instance.
        /// *   **false**: does not use the new instance as the first child instance.
        /// *   If you want to create an ApsaraDB for Redis Enhanced Edition (Tair) DRAM-based instance that runs Redis 5.0, you must set this parameter to **true**.
        /// 
        /// *   This parameter is available only on the China site (aliyun.com).
        /// </summary>
        [NameInMap("GlobalInstance")]
        [Validation(Required=false)]
        public bool? GlobalInstance { get; set; }

        /// <summary>
        /// The ID of the distributed instance. This parameter is available only on the China site (aliyun.com).
        /// </summary>
        [NameInMap("GlobalInstanceId")]
        [Validation(Required=false)]
        public string GlobalInstanceId { get; set; }

        /// <summary>
        /// The global IP whitelist template for the instance. Multiple IP whitelist templates should be separated by English commas (,) and cannot be duplicated.
        /// </summary>
        [NameInMap("GlobalSecurityGroupIds")]
        [Validation(Required=false)]
        public string GlobalSecurityGroupIds { get; set; }

        /// <summary>
        /// The instance type. For example, redis.master.small.default indicates a Community Edition standard master-replica instance that has 1 GB of memory. For more information, see [Overview](https://help.aliyun.com/document_detail/26350.html).
        /// 
        /// **
        /// 
        /// **Description** You must specify at least one of the **Capacity** and **InstanceClass** parameters when you call the CreateInstance operation.
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// The name of the instance. The name must be 2 to 80 characters in length and must start with a letter. It cannot contain spaces or specific special characters. These special characters include `@ / : = " < > { [ ] }`
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The category of the instance. Default value: Redis. Valid values:
        /// 
        /// *   **Redis**
        /// *   **Memcache**
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The network type of the instance. Default value: VPC. Valid values:
        /// 
        /// *   **VPC**
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// The node type. Valid values:
        /// 
        /// *   **MASTER_SLAVE**: high availability (master-replica)
        /// *   **STAND_ALONE**: standalone
        /// *   **double**: master-replica
        /// *   **single**: standalone
        /// 
        /// >  To create a cloud-native instance, set this parameter to **MASTER_SLAVE** or **STAND_ALONE**. To create a classic instance, set this parameter to **double** or **single**.
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The parameter template ID, which must be globally unique.
        /// </summary>
        [NameInMap("ParamGroupId")]
        [Validation(Required=false)]
        public string ParamGroupId { get; set; }

        /// <summary>
        /// The password that is used to connect to the instance. The password must be 8 to 32 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and specific special characters. These special characters include `! @ # $ % ^ & * ( ) _ + - =`
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// The subscription duration. Valid values: **1**, 2, 3, 4, 5, 6, 7, 8, **9**, **12**, **24**,**36**, and **60**. Unit: months.
        /// 
        /// > This parameter is available and required only if the **ChargeType** parameter is set to **PrePaid**.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The port number that is used to connect to the instance. Valid values: **1024** to **65535**. Default value: **6379**.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// The private IP address of the instance.
        /// 
        /// > The private IP address must be available within the CIDR block of the vSwitch to which to connect the instance.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// The number of read replicas in the primary zone. This parameter applies only to read/write splitting instances that use cloud disks. You can use this parameter to customize the number of read replicas. Valid values: 1 to 9.
        /// 
        /// >  The sum of the values of this parameter and SlaveReadOnlyCount cannot be greater than 9.
        /// </summary>
        [NameInMap("ReadOnlyCount")]
        [Validation(Required=false)]
        public int? ReadOnlyCount { get; set; }

        [NameInMap("RecoverConfigMode")]
        [Validation(Required=false)]
        public string RecoverConfigMode { get; set; }

        /// <summary>
        /// The ID of the region where you want to create the instance. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/61012.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// If data flashback is enabled for the source instance, you can use this parameter to specify a point in time within the backup retention period of the source instance. The system uses the backup data of the source instance at the point in time to create an instance. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// The secondary zone ID of the instance. You can call the [DescribeZones](https://help.aliyun.com/document_detail/472448.html) operation to query the most recent zone list.
        /// 
        /// > If you specify this parameter, the master node and replica node of the instance can be deployed in different zones and disaster recovery is implemented across zones. The instance can withstand failures in data centers.
        /// </summary>
        [NameInMap("SecondaryZoneId")]
        [Validation(Required=false)]
        public string SecondaryZoneId { get; set; }

        /// <summary>
        /// 系统自动生成的安全 Token，无需传入
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The number of data shards. This parameter is available only if you create a cluster instance that uses cloud disks.
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// The number of read replicas in the secondary zone. This parameter is used to create a read/write splitting instance that is deployed across multiple zones. The sum of the values of this parameter and ReadOnlyCount cannot be greater than 9.
        /// 
        /// > When you create a multi-zone read/write splitting instance, you must specify both SlaveReadOnlyCount and SecondaryZoneId.
        /// </summary>
        [NameInMap("SlaveReadOnlyCount")]
        [Validation(Required=false)]
        public int? SlaveReadOnlyCount { get; set; }

        /// <summary>
        /// If you want to create an instance based on the backup set of an existing instance, set this parameter to the ID of the source instance.
        /// 
        /// >  After you specify the SrcDBInstanceId parameter, use the **BackupId**, **ClusterBackupId** (recommended for cloud-native cluster instances), or **RestoreTime** parameter to specify the backup set or the specific point in time that you want to use to create an instance. The SrcDBInstanceId parameter must be used in combination with one of the preceding three parameters.
        /// </summary>
        [NameInMap("SrcDBInstanceId")]
        [Validation(Required=false)]
        public string SrcDBInstanceId { get; set; }

        /// <summary>
        /// The tags of the instance.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestTag> Tag { get; set; }
        public class CreateInstanceRequestTag : TeaModel {
            /// <summary>
            /// The keys of the tags that are added to the instance.
            /// 
            /// > 
            /// 
            /// *   **N** specifies the serial number of the tag. Up to 20 tags can be added to a single instance. For example, Tag.1.Key specifies the key of the first tag and Tag.2.Key specifies the key of the second tag.
            /// 
            /// *   If the key of the tag does not exist, the tag is automatically created.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The values of the tags that are added to the instance.
            /// 
            /// > **N** specifies the serial number of the tag. For example, **Tag.1.Value** specifies the value of the first tag and **Tag.2.Value** specifies the value of the second tag.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the token is unique among different requests. The token is case-sensitive. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// The ID of the vSwitch to which you want the instance to connect.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC).
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The primary zone ID of the instance. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/61012.html) operation to query the most recent zone list.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

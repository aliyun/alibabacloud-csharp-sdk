// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateTairInstanceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic payment. Set the value to **true**.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal for the instance. Valid values:
        /// 
        /// *   **true**: enables auto-renewal.
        /// *   **false** (default): disables auto-renewal.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// The subscription duration that is supported by auto-renewal. Unit: month. Valid values: **1**, **2**, **3**, **6**, and **12**.
        /// 
        /// >  This parameter is required if the **AutoRenew** parameter is set to **true**.
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public string AutoRenewPeriod { get; set; }

        /// <summary>
        /// Specifies whether to use a coupon. Valid values:
        /// 
        /// *   **true**: uses a coupon.
        /// *   **false** (default): does not use a coupon.
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
        /// The ID of the promotion event or the business information.
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// The billing method. Valid values:
        /// 
        /// *   **PrePaid** (default): subscription
        /// *   **PostPaid:** pay-as-you-go
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the token is unique among different requests. The token is case-sensitive. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// This parameter is supported for specific new cluster instances. You can query the backup set ID by calling the [DescribeClusterBackupList](https://help.aliyun.com/document_detail/2679158.html) operation.
        /// 
        /// *   If this parameter is supported, you can specify the backup set ID. In this case, you do not need to specify the **BackupId** parameter.
        /// *   If this parameter is not supported, set the BackupId parameter to the IDs of backup sets in all shards of the source instance, separated by commas (,). Example: "2158\\*\\*\\*\\*20,2158\\*\\*\\*\\*22".
        /// </summary>
        [NameInMap("ClusterBackupId")]
        [Validation(Required=false)]
        public string ClusterBackupId { get; set; }

        /// <summary>
        /// The coupon code.
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run. Valid values:
        /// 
        /// *   **true**: performs a dry run and does not create the instance. The system prechecks the request parameters, request format, service limits, and available resources. If the request fails the dry run, an error code is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false**: performs a dry run and sends the request. If the request passes the dry run, the instance is created.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The database engine version. Default value: **1.0**. The parameter value varies based on the Tair instance series.
        /// 
        /// *   For Tair DRAM-based instances (tair_rdb) that are compatible with Redis 5.0 or 6.0, set this parameter to **5.0** or **6.0**.
        /// *   For Tair persistent memory-optimized instances (tair_scm) that are compatible with Redis 6.0, set this parameter to **1.0**.
        /// *   For Tair ESSD/SSD-based instances (tair_essd) that are compatible with Redis 6.0, set this parameter to **1.0** to create an ESSD-based instance, and set this parameter to **2.0** to create an SSD-based instance.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// Specifies whether to use the created instance as a child instance of a distributed instance.
        /// 
        /// *   If you want the created instance to be used as the first child instance, enter **true**.
        /// *   If you want the created instance to be used as the second or third child instance, enter the ID of the distributed instance, such as gr-bp14rkqrhac\\*\\*\\*\\*.
        /// *   If you do not want the created instance to be used as a distributed instance, leave the parameter empty.
        /// 
        /// >  If you want the created instance to be used as a distributed instance, the created instance must be a Tair DRAM-based instance.
        /// </summary>
        [NameInMap("GlobalInstanceId")]
        [Validation(Required=false)]
        public string GlobalInstanceId { get; set; }

        /// <summary>
        /// The global IP whitelist template of the instance. Separate multiple IP whitelist templates with commas (,) and make sure that each IP whitelist template is unique.
        /// </summary>
        [NameInMap("GlobalSecurityGroupIds")]
        [Validation(Required=false)]
        public string GlobalSecurityGroupIds { get; set; }

        /// <summary>
        /// The instance type. For more information, see the following topics:
        /// 
        /// *   [DRAM-based instances](https://help.aliyun.com/document_detail/443844.html)
        /// *   [Persistent memory-optimized instances](https://help.aliyun.com/document_detail/443845.html)
        /// *   [ESSD-based instances](https://help.aliyun.com/document_detail/443846.html)
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// The name of the instance. The name must meet the following requirements:
        /// 
        /// *   The name is 2 to 80 characters in length.
        /// *   The name starts with a letter and does not contain spaces or special characters. Special characters include `@ / : = " < > { [ ] }`
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The instance series. Valid values:
        /// 
        /// *   **tair_rdb**: Tair DRAM-based instance
        /// *   **tair_scm**: Tair persistent memory-optimized instance
        /// *   **tair_essd**: ESSD/SSD-based instance
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the parameter template. The instance is created based on the parameters in the parameter template. The ID must be unique.
        /// </summary>
        [NameInMap("ParamGroupId")]
        [Validation(Required=false)]
        public string ParamGroupId { get; set; }

        /// <summary>
        /// The password that is used to connect to the instance. The password must meet the following requirements:
        /// 
        /// *   The password is 8 to 32 characters in length.
        /// *   The password contains at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include `! @ # $ % ^ & * ( ) _ + - =`
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// The subscription duration. Valid values: **1**, 2, 3, 4, 5, 6, 7, 8, **9**, **12**, **24**,**36**, and **60**. Unit: months.
        /// 
        /// > This parameter is required only if you set the **ChargeType** parameter to **PrePaid**.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The service port number of the instance. Valid values: 1024 to 65535. Default value: 6379.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// The private IP address of the instance.
        /// 
        /// > The IP address must be within the CIDR block of the vSwitch to which you want the instance to connect. You can call the [DescribeVSwitches](https://help.aliyun.com/document_detail/35748.html) operation of the VPC API to query the CIDR block information.
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
        /// The ID of the resource group to which you want to assign the instance.
        /// 
        /// > 
        /// 
        /// *   You can query resource group IDs by using the ApsaraDB for Redis console or by calling the [ListResourceGroups](https://help.aliyun.com/document_detail/158855.html) operation. For more information, see [View basic information of a resource group](https://help.aliyun.com/document_detail/151181.html).
        /// 
        /// *   Before you modify the resource group to which an instance belongs, you can call the [ListResources](https://help.aliyun.com/document_detail/158866.html) operation to view the current resource group of the instance.
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
        /// The ID of the secondary zone. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/61012.html) operation to query the ID of the secondary zone.
        /// 
        /// > You cannot specify multiple zone IDs or set this parameter to a value that is the same as that of the ZoneId parameter.
        /// </summary>
        [NameInMap("SecondaryZoneId")]
        [Validation(Required=false)]
        public string SecondaryZoneId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The number of data nodes in the instance. Valid values:
        /// 
        /// *   **1** (default): You can create a [standard instance](https://help.aliyun.com/document_detail/52228.html) that contains only a single data node.
        /// *   **2** to **32**: You can create a [cluster instance](https://help.aliyun.com/document_detail/52228.html) that contains the specified number of data nodes.
        /// 
        /// >  When the **InstanceType** parameter is set to **tair_rdb** or **tair_scm**, this parameter can be set to a value in the range of **2** to **32**. Only DRAM-based and persistent memory-optimized instances support the cluster architecture.
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// The shard type of the instance. Valid values:
        /// 
        /// *   **MASTER_SLAVE** (default): runs in a master-replica architecture that provides high availability.
        /// *   **STAND_ALONE**: runs in a standalone architecture. If the only node fails, the system creates a new instance and switches the workloads to the new instance. This may cause data loss. You can set the ShardType parameter to this value only if the instance uses the **single-zone** deployment mode. If you set the ShardType parameter to this value, you cannot create cluster or read/write splitting instances.
        /// </summary>
        [NameInMap("ShardType")]
        [Validation(Required=false)]
        public string ShardType { get; set; }

        /// <summary>
        /// The number of read replicas in the secondary zone when you create a multi-zone read/write splitting instance. The sum of the values of this parameter and ReadOnlyCount cannot be greater than 9.
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
        /// The storage space of cloud disks. Valid values vary based on the instance specifications. For more information, see [ESSD-based instances](https://help.aliyun.com/document_detail/443846.html).
        /// 
        /// > This parameter is available and required only if the **InstanceType** parameter is set to **tair_essd**.
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public int? Storage { get; set; }

        /// <summary>
        /// The storage type. Example values: **essd_pl1**, **essd_pl2**, and **essd_pl3**.
        /// 
        /// >  This parameter is required only when you set the **InstanceType** parameter to **tair_essd** to create an ESSD-based instance.
        /// 
        /// Valid values:
        /// 
        /// *   essd_pl0
        /// *   essd_pl1
        /// *   essd_pl2
        /// *   essd_pl3
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// The tags to add to the instance.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTairInstanceRequestTag> Tag { get; set; }
        public class CreateTairInstanceRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag. A tag is a key-value pair.
            /// 
            /// > A maximum of five key-value pairs can be specified at a time.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag.
            /// 
            /// > **N** specifies the serial number of the tag. For example, **Tag.1.Value** specifies the value of the first tag, and **Tag.2.Value** specifies the value of the second tag.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the vSwitch that belongs to the VPC. You can call the [DescribeVpcs](https://help.aliyun.com/document_detail/35739.html) operation to query the ID of the vSwitch.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC). You can call the [DescribeVpcs](https://help.aliyun.com/document_detail/35739.html) operation to query the ID of the VPC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The primary zone ID of the instance. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/61012.html) operation to query the IDs of available zones.
        /// 
        /// >  You can also set the SecondaryZoneId parameter to specify the secondary zone. The primary and secondary nodes will then be deployed in the specified primary and secondary zones to implement the master-replica zone-disaster recovery architecture. For example, you can set the ZoneId parameter to cn-hangzhou-h and the SecondaryZoneId parameter to cn-hangzhou-g.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

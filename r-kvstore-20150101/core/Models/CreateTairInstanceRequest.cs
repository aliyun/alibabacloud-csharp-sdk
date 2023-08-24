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
        /// The ID of the backup set of the source instance. You can call the [DescribeBackups](~~61081~~) operation to query the ID of the backup set.
        /// 
        /// > If you want to create an instance based on the backup set of an existing instance, you must specify this parameter after you specify the **SrcDBInstanceId** parameter. The system creates an instance based on the backup set that is specified by this parameter.
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
        /// The billing method of the instance. Default value: PrePaid. Valid values:
        /// 
        /// *   **PrePaid**: subscription
        /// *   **PostPaid**: pay-as-you-go
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
        /// The coupon code.
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run. Default value: false. Valid values:
        /// 
        /// *   **true**: performs a dry run and does not create the instance. The system prechecks the request parameters, request format, service limits, and available resources. If the request fails the dry run, an error code is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false**: performs a dry run and sends the request. If the request passes the dry run, the instance is created.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The database engine version of the instance. Default value: **1.0**, which is developed by Alibaba Cloud and compatible with Redis 5.0.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The ID of the distributed instance.
        /// </summary>
        [NameInMap("GlobalInstanceId")]
        [Validation(Required=false)]
        public string GlobalInstanceId { get; set; }

        /// <summary>
        /// 实例的全局IP白名单模板，多个IP白名单模板请用英文逗号（,）分隔，不可重复。
        /// </summary>
        [NameInMap("GlobalSecurityGroupIds")]
        [Validation(Required=false)]
        public string GlobalSecurityGroupIds { get; set; }

        /// <summary>
        /// The instance type. For more information, see the following topics:
        /// 
        /// *   [DRAM-based instances](~~443844~~)
        /// *   [Persistent memory-optimized instances](~~443845~~)
        /// *   [ESSD-based instances](~~443846~~)
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
        /// The storage type of the instance. Valid values:
        /// 
        /// *   **tair_rdb**: ApsaraDB for Redis Enhanced Edition (Tair) DRAM-based instance
        /// *   **tair_scm**: ApsaraDB for Redis Enhanced Edition (Tair) persistent memory-optimized instance
        /// *   **tair_essd**: ApsaraDB for Redis Enhanced Edition (Tair) ESSD-based instance
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

        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// The private IP address of the instance.
        /// 
        /// > The IP address must be within the CIDR block of the vSwitch to which you want the instance to connect. You can call the [DescribeVSwitches](~~35748~~) operation of the VPC API to query the CIDR block information.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// The number of read-only nodes of the instance. This parameter is available only if you create a read/write splitting instance that uses cloud disks. You can use this parameter to specify a custom number of read-only nodes for the instance. Valid value: 1 to 5.
        /// </summary>
        [NameInMap("ReadOnlyCount")]
        [Validation(Required=false)]
        public int? ReadOnlyCount { get; set; }

        /// <summary>
        /// The ID of the region where you want to create the instance. You can call the [DescribeRegions](~~61012~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which you want to assign the instance.
        /// 
        /// > 
        /// 
        /// *   You can query resource group IDs by using the ApsaraDB for Redis console or by calling the [ListResourceGroups](~~158855~~) operation. For more information, see [View basic information of a resource group](~~151181~~).
        /// 
        /// *   Before you modify the resource group to which an instance belongs, you can call the [ListResources](~~158866~~) operation to view the current resource group of the instance.
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
        /// The ID of the secondary zone. You can call the [DescribeRegions](~~61012~~) operation to query the ID of the secondary zone.
        /// 
        /// > 
        /// 
        /// *   You cannot specify multiple zone IDs or set this parameter to a value that is the same as that of the **ZoneId** parameter.
        /// 
        /// *   If you set both the SecondaryZoneId and **ZoneId** parameters, the master node is deployed in the primary zone and the replica node is deployed in the secondary zone within the same region. In this case, the instance adopts the zone-disaster recovery architecture.
        /// </summary>
        [NameInMap("SecondaryZoneId")]
        [Validation(Required=false)]
        public string SecondaryZoneId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The number of data shards in the instance. Default value: 1. Valid values:
        /// 
        /// *   **1**: You can create an instance in the [standard architecture](~~52228~~) that contains only a single data shard.
        /// *   **2** to **32**: You can create an instance in the [cluster architecture](~~52228~~) that contains the specified number of data shards.
        /// 
        /// > Only persistent memory-optimized instances can use the cluster architecture. You can set this parameter to an integer from **2** to **32** only if you set the **InstanceType** parameter to **tair_scm**.
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// The data shard type of the instance. Default value: MASTER_SLAVE. Valid values:
        /// 
        /// *   **MASTER_SLAVE**: runs in a master-replica architecture that provides high availability.
        /// *   **STAND_ALONE**: runs in a standalone architecture. If the only node fails, the system creates a new instance and switches the workloads to the new instance. This may cause data loss. You can set this parameter to this value only if the instance uses the **single-zone** deployment type. If you set this parameter to this value, you cannot create cluster or read/write splitting instances.
        /// </summary>
        [NameInMap("ShardType")]
        [Validation(Required=false)]
        public string ShardType { get; set; }

        /// <summary>
        /// The ID of the source instance.
        /// 
        /// > If you want to create an instance based on the backup set of an existing instance, set this parameter to the ID of the source instance and the **BackupId** parameter to the backup set that you want to use.
        /// </summary>
        [NameInMap("SrcDBInstanceId")]
        [Validation(Required=false)]
        public string SrcDBInstanceId { get; set; }

        /// <summary>
        /// The storage space of cloud disks. Valid values vary based on the instance specifications. For more information, see [ESSD-based instances](~~443846~~).
        /// 
        /// > This parameter is available and required only if the **InstanceType** parameter is set to **tair_essd**.
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public int? Storage { get; set; }

        /// <summary>
        /// The storage type of the instance. Set the value to **essd_pl1**.
        /// 
        /// > This parameter is available only if the **InstanceType** parameter is set to **tair_essd**.
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
        /// The ID of the vSwitch that belongs to the VPC. You can call the [DescribeVpcs](~~35739~~) operation to query the ID of the vSwitch.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC). You can call the [DescribeVpcs](~~35739~~) operation to query the ID of the VPC.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The primary zone ID of the instance. You can call the [DescribeRegions](~~61012~~) operation to query the most recent zone list.
        /// 
        /// > If you want to create an instance that adopts the zone-disaster recovery architecture, you can deploy the master node and replica node of the instance in different zones within the same region. You can set the **SecondaryZoneId** parameter to specify the secondary zone. In this case, do not set the ZoneId parameter to multiple zone IDs.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

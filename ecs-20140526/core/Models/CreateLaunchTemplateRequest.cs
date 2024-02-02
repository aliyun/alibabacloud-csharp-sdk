// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateLaunchTemplateRequest : TeaModel {
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public CreateLaunchTemplateRequestSystemDisk SystemDisk { get; set; }
        public class CreateLaunchTemplateRequestSystemDisk : TeaModel {
            /// <summary>
            /// The ID of the automatic snapshot policy to apply to the system disk.
            /// </summary>
            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// Specifies whether to enable the performance burst feature for the system disk. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("BurstingEnabled")]
            [Validation(Required=false)]
            public bool? BurstingEnabled { get; set; }

            /// <summary>
            /// The category of the system disk. Valid values:
            /// 
            /// *   cloud: basic disk.
            /// *   cloud_efficiency: ultra disk.
            /// *   cloud_ssd: standard SSD.
            /// *   cloud_essd: enhanced SSD (ESSD). You can use the `SystemDisk.PerformanceLevel` parameter to set the performance level of the ESSD to use as the system disk. cloud_auto: ESSD AutoPL disk.
            /// 
            /// For non-I/O optimized instances of a retired instance type, the default value is cloud. For other types of instances, the default value is cloud_efficiency.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// Specifies whether to release the system disk when the instance is released. Valid values:
            /// 
            /// *   true: releases the system disk when the instance is released.
            /// *   false: does not release the system disk when the instance is released.
            /// 
            /// Default value: true.
            /// </summary>
            [NameInMap("DeleteWithInstance")]
            [Validation(Required=false)]
            public bool? DeleteWithInstance { get; set; }

            /// <summary>
            /// The description of the system disk. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the system disk. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with `http://` or `https://`. It can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// 系统盘是否加密。取值范围：
            /// 
            /// - true：加密。
            /// - false：不加密。
            /// 
            /// 默认值：false。
            /// 
            /// >中国香港D可用区、新加坡A可用区暂不支持在创建实例时加密系统盘。
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// > This parameter is in invitational preview and is unavailable for general users.
            /// </summary>
            [NameInMap("Iops")]
            [Validation(Required=false)]
            public int? Iops { get; set; }

            /// <summary>
            /// The performance level of the ESSD to use as the system disk. Default value: PL0. Valid values:
            /// 
            /// *   PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.
            /// *   PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.
            /// *   PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.
            /// *   PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.
            /// 
            /// For more information about ESSD performance levels, see [ESSDs](~~122389~~).
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// The provisioned read/write IOPS of the ESSD AutoPL disk to use as the system disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}
            /// 
            /// Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}
            /// 
            /// > This parameter is available only if you set the SystemDisk.Category parameter to cloud_auto. For more information, see [ESSD AutoPL disks](~~368372~~) and [Modify the performance configurations of an ESSD AutoPL disk](~~413275~~).
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// The size of the system disk. Unit: GiB. Valid values: 20 to 500.
            /// 
            /// The value of this parameter must be at least 20 and greater than or equal to the size of the specified image.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// The automatic release time of the instance. Specify the time in the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// *   If the value of seconds (`ss`) is not `00`, the time is automatically rounded to the nearest minute based on the value of minutes (`mm`).
        /// *   The release time must be at least 30 minutes later than the current time.
        /// *   The release time must be at most three years from the current time.
        /// </summary>
        [NameInMap("AutoReleaseTime")]
        [Validation(Required=false)]
        public string AutoReleaseTime { get; set; }

        /// <summary>
        /// The performance mode of the burstable instance. Valid values:
        /// 
        /// *   Standard: the standard mode. For more information, see the "Standard mode" section in [Burstable instances](~~59977~~).
        /// *   Unlimited: the unlimited mode. For more information, see the "Unlimited mode" section in [Burstable instances](~~59977~~).
        /// </summary>
        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        /// <summary>
        /// The data disks.
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<CreateLaunchTemplateRequestDataDisk> DataDisk { get; set; }
        public class CreateLaunchTemplateRequestDataDisk : TeaModel {
            /// <summary>
            /// The ID of the automatic snapshot policy to apply to data disk N.
            /// </summary>
            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// Specifies whether to enable the performance burst feature for data disk N. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("BurstingEnabled")]
            [Validation(Required=false)]
            public bool? BurstingEnabled { get; set; }

            /// <summary>
            /// The category of data disk N. Valid values:
            /// 
            /// *   cloud: basic disk
            /// *   cloud_efficiency: ultra disk
            /// *   cloud_ssd: standard SSD
            /// *   cloud_essd: ESSD cloud_auto: ESSD AutoPL disk
            /// 
            /// For I/O optimized instances, the default value is cloud_efficiency. For non-I/O optimized instances, the default value is cloud.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// Specifies whether to release data disk N when the instance is released. Valid values:
            /// 
            /// *   true: releases data disk N when the instance is released.
            /// *   false: does not release data disk N when the instance is released.
            /// 
            /// Default value: true.
            /// </summary>
            [NameInMap("DeleteWithInstance")]
            [Validation(Required=false)]
            public bool? DeleteWithInstance { get; set; }

            /// <summary>
            /// The description of data disk N. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// > This parameter will be removed in the future. To ensure future compatibility, we recommend that you do not use this parameter.
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// The name of data disk N. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with `http://` or `https://`. It can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// Specifies whether to encrypt the data disk.
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// The performance level of the ESSD to use as data disk N. The value of N must be the same as that in `DataDisk.N.Category` when DataDisk.N.Category is set to cloud_essd. Default value: PL1. Valid values:
            /// 
            /// *   PL0: An ESSD can deliver up to 10,000 random read/write IOPS.
            /// *   PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.
            /// *   PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.
            /// *   PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.
            /// 
            /// For more information about ESSD performance levels, see [ESSDs](~~122389~~).
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// The provisioned read/write IOPS of the ESSD AutoPL disk to use as data disk N. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}
            /// 
            /// Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}
            /// 
            /// > This parameter is available only if you set the DataDisk.N.Category parameter to cloud_auto. For more information, see [ESSD AutoPL disks](~~368372~~) and [Modify the performance configurations of an ESSD AutoPL disk](~~413275~~).
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// The size of data disk N. Valid values of N: 1 to 16. Unit: GiB. Valid values:
            /// 
            /// *   Valid values when DataDisk.N.Category is set to cloud: 5 to 2000
            /// 
            /// *   Valid values when DataDisk.N.Category is set to cloud_efficiency: 20 to 32768
            /// 
            /// *   Valid values when DataDisk.N.Category is set to cloud_ssd: 20 to 32768
            /// 
            /// *   Valid values when DataDisk.N.Category is set to cloud_essd: depend on the `DataDisk.N.PerformanceLevel` value.
            /// 
            ///     *   Valid values when DataDisk.N.PerformanceLevel is set to PL0: 40 to 32768.
            ///     *   Valid values when DataDisk.N.PerformanceLevel is set to PL1: 20 to 32768.
            ///     *   Valid values when DataDisk.N.PerformanceLevel is set to PL2: 461 to 32768.
            ///     *   Valid values when DataDisk.N.PerformanceLevel is set to PL3: 1261 to 32768.
            /// 
            /// The value of this parameter must be greater than or equal to the size of the snapshot specified by the `SnapshotId` parameter.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// The ID of the snapshot to use to create data disk N. Valid values of N: 1 to 16. When the `DataDisk.N.SnapshotId` parameter is specified, the `DataDisk.N.Size` parameter is ignored. The data disk is created based on the size of the specified snapshot.
            /// 
            /// Use snapshots that were created on or after July 15, 2013. Otherwise, an error is returned and your request is rejected.
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

        }

        /// <summary>
        /// Specifies whether to enable release protection for the instance. This parameter determines whether you can use the ECS console or call the [DeleteInstance](~~25507~~) operation to release the instance. Valid values:
        /// 
        /// - true
        /// - false
        /// 
        /// Default value: false.
        /// 
        /// >This parameter is applicable only to pay-as-you-go instances. It can protect instances against manual releases, but not against automatic releases.
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// The ID of the deployment set to which to deploy the instance.
        /// </summary>
        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        /// <summary>
        /// The instance description. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to enable the operating system configuration of the instance.
        /// 
        /// > This parameter will be removed in the future. To ensure future compatibility, we recommend that you use other parameters.
        /// </summary>
        [NameInMap("EnableVmOsConfig")]
        [Validation(Required=false)]
        public bool? EnableVmOsConfig { get; set; }

        /// <summary>
        /// The instance hostname.
        /// 
        /// *   The hostname cannot start or end with a period (.) or hyphen (-). It cannot contain consecutive periods (.) or hyphens (-).
        /// *   For Windows instances, the hostname must be 2 to 15 characters in length and cannot contain periods (.) or contain only digits. It can contain letters, digits, and hyphens (-).
        /// *   For instances that run other operating systems such as Linux, the hostname must be 2 to 64 characters in length. You can use periods (.) to separate the hostname into multiple segments. Each segment can contain letters, digits, and hyphens (-).
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// The ID of the image to use to create the instance. You can call the [DescribeImages](~~25534~~) operation to query available images.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The source of the image. Valid values:
        /// 
        /// *   system: public images provided by Alibaba Cloud
        /// *   self: custom images that you create.
        /// *   others: shared images from other Alibaba Cloud accounts.
        /// *   marketplace: [Alibaba Cloud Marketplace](https://market.aliyun.com/) images. If Alibaba Cloud Marketplace images are found, you can use these images without prior subscription. You must pay attention to the billing details of Alibaba Cloud Marketplace images.
        /// </summary>
        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   PrePaid: subscription. If you set this parameter to PrePaid, make sure that you have sufficient balance and credit in your account. Otherwise, an `InvalidPayMethod` error is returned.
        /// *   PostPaid: pay-as-you-go.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The name of the instance. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with `http://` or `https://`. It can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The instance type of the instance. For more information, see [Instance families](~~25378~~). Alternatively, you can call the [DescribeInstanceTypes](~~25620~~) operation to query the most recent instance type list.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The billing method for network usage. Valid values:
        /// 
        /// *   PayByBandwidth: pay-by-bandwidth
        /// *   PayByTraffic: pay-by-traffic
        /// 
        /// > When the **pay-by-traffic** billing method for network usage is used, the maximum inbound and outbound bandwidths are used as the upper limits of bandwidths instead of guaranteed performance specifications. In scenarios where demand outstrips resource supplies, these maximum bandwidths may be limited. If you want guaranteed bandwidths for your instance, use the **pay-by-bandwidth** billing method for network usage.
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The maximum inbound public bandwidth. Unit: Mbit/s. Valid values:
        /// 
        /// *   When the purchased outbound public bandwidth is less than or equal to 10 Mbit/s, the valid values of this parameter are 1 to 10 and the default value is 10.
        /// *   When the purchased outbound public bandwidth is greater than 10 Mbit/s, the valid values of this parameter are 1 to the `InternetMaxBandwidthOut` value and the default value is the `InternetMaxBandwidthOut` value.
        /// </summary>
        [NameInMap("InternetMaxBandwidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthIn { get; set; }

        /// <summary>
        /// The maximum outbound public bandwidth. Unit: Mbit/s. Valid values: 0 to 100.
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// Specifies whether to create an I/O optimized instance. Valid values:
        /// 
        /// *   none: creates a non-I/O optimized instance.
        /// *   optimized: creates an I/O optimized instance.
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// The number of IPv6 addresses to randomly generate for the primary elastic network interface (ENI). Valid values: 1 to 10.
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// The name of the key pair. This parameter is empty by default.
        /// 
        /// *   For Windows instances, this parameter is ignored The `Password` parameter takes effect even if the KeyPairName parameter is specified.
        /// *   For Linux instances, the password-based logon method is disabled by default.
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// The name of the launch template. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with `http://` or `https://`. It can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("LaunchTemplateName")]
        [Validation(Required=false)]
        public string LaunchTemplateName { get; set; }

        /// <summary>
        /// The information of the ENI.
        /// </summary>
        [NameInMap("NetworkInterface")]
        [Validation(Required=false)]
        public List<CreateLaunchTemplateRequestNetworkInterface> NetworkInterface { get; set; }
        public class CreateLaunchTemplateRequestNetworkInterface : TeaModel {
            /// <summary>
            /// The description of the secondary ENI. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`. The value of N in `NetworkInterface.N` cannot be greater than 1.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The instance type of the instance.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The name of ENI N.
            /// 
            /// Take note of the following items:
            /// 
            /// *   Valid values of N: 1 and 2. If the value of N is 1, you can configure a primary or secondary ENI. If the value of N is 2, you must configure a primary ENI and a secondary ENI.
            /// *   If `NetworkInterface.N.InstanceType` is set to `Primary`, you do not need to set this parameter.
            /// </summary>
            [NameInMap("NetworkInterfaceName")]
            [Validation(Required=false)]
            public string NetworkInterfaceName { get; set; }

            /// <summary>
            /// The communication mode of the primary ENI. Valid values:
            /// 
            /// *   Standard: uses the TCP communication mode.
            /// *   HighPerformance: uses the remote direct memory access (RDMA) communication mode with the Elastic RDMA Interface (ERI) enabled.
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            /// <summary>
            /// The primary IP address to assign to ENI N.
            /// 
            /// Take note of the following items:
            /// 
            /// *   Valid values of N: 1 and 2.
            /// 
            ///     *   If the value of N is 1, you can configure a primary or secondary ENI. If this parameter is specified, `Amount` is set to a numeric value greater than 1, and NetworkInterface.N.InstanceType is set to Primary, the specified number of instances are created and consecutive primary IP addresses starting from the specified one are assigned to the instances. In this case, you cannot attach secondary ENIs to the instances.
            ///     *   If the value of N is 2, you can configure a primary ENI and a secondary ENI. If this parameter is specified, `Amount` is set to a numeric value greater than 1, and NetworkInterface.N.InstanceType is set to Primary, you cannot set `NetworkInterface.2.InstanceType` to Secondary to attach a secondary ENI.
            /// 
            /// *   If `NetworkInterface.N.InstanceType` is set to `Primary`, this parameter is equivalent to `PrivateIpAddress` and you cannot specify `PrivateIpAddress`.
            /// 
            /// *   If `NetworkInterface.N.InstanceType` is set to `Secondary` or left empty, the specified primary IP address is assigned to the secondary ENI. The default value is an IP address that is randomly selected from within the CIDR block of the vSwitch to which to connect the secondary ENI.
            /// 
            /// > You can attach only a single secondary ENI when you create an instance. After the instance is created, you can call the [CreateNetworkInterface](~~58504~~) and [AttachNetworkInterface](~~58515~~) operations to attach more secondary ENIs.
            /// </summary>
            [NameInMap("PrimaryIpAddress")]
            [Validation(Required=false)]
            public string PrimaryIpAddress { get; set; }

            /// <summary>
            /// The ID of the security group to which to assign secondary ENI N.
            /// 
            /// Take note of the following items:
            /// 
            /// *   Valid values of N: 1 and 2. If the value of N is 1, you can configure a primary or secondary ENI. If the value of N is 2, you must configure a primary ENI and a secondary ENI.
            /// *   If `NetworkInterface.N.InstanceType` is set to `Primary`, you must set this parameter. In this case, this parameter is equivalent to `SecurityGroupId` and you cannot specify `SecurityGroupId`, `SecurityGroupIds.N`, or `NetworkInterface.N.SecurityGroupIds.N`.
            /// *   If `NetworkInterface.N.InstanceType` is set to `Secondary` or left empty, this parameter is optional. The default value is the ID of the security group to which to assign the ECS instance.
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The ID of security group N to which to assign ENI N.
            /// 
            /// *   Valid values of the first N: 1 and 2. If the value of N is 1, you can configure a primary or secondary ENI. If the value of N is 2, you can configure a primary ENI and a secondary ENI.
            /// *   The second N indicates that one or more security group IDs can be specified. The valid values of N vary based on the maximum number of security groups to which an instance can belong. For more information, see the "Security group limits" section in [Limits](~~25412#SecurityGroupQuota1~~).
            /// 
            /// Take note of the following items:
            /// 
            /// *   If `NetworkInterface.N.InstanceType` is set to `Primary`, you must set this parameter or `NetworkInterface.N.SecurityGroupId`. In this case, this parameter is equivalent to `SecurityGroupIds.N` and you cannot specify `SecurityGroupId`, `SecurityGroupIds.N`, or `NetworkInterface.N.SecurityGroupId`.
            /// *   If `NetworkInterface.N.InstanceType` is set to `Secondary` or left empty, this parameter is optional. The default value is the ID of the security group to which to assign the ECS instance.
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// The ID of the vSwitch to which to connect to ENI N.
            /// 
            /// Take note of the following items:
            /// 
            /// *   Valid values of N: 1 and 2. If the value of N is 1, you can configure a primary or secondary ENI. If the value of N is 2, you must configure a primary ENI and a secondary ENI.
            /// *   If `NetworkInterface.N.InstanceType` is set to `Primary`, you must set this parameter. In this case, this parameter is equivalent to `VSwitchId` and you cannot specify `VSwitchId`.
            /// *   If `NetworkInterface.N.InstanceType` is set to `Secondary` or left empty, this parameter is optional. The default value is the ID of the vSwitch to which to connect the instance.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

        /// <summary>
        /// The network type of the instance. Valid values:
        /// 
        /// *   classic: classic network
        /// *   vpc: VPC
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Specifies whether to use the preset password of the image.
        /// 
        /// > If you set the PasswordInherit parameter to true, make sure that you leave the Password parameter empty and the selected image has a preset password.
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// The subscription duration of the instance. Unit: months. This parameter is valid and required only when `InstanceChargeType` is set to `PrePaid`. Valid values: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The private IP address to assign to the instance.
        /// 
        /// To assign a private IP address to an instance that resides in a VPC, make sure that the IP address is an idle IP address within the CIDR block of the vSwitch specified by the `VSwitchId` parameter.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// The name of the instance Resource Access Management (RAM) role. You can call the [ListRoles](~~28713~~) operation provided by RAM to query the instance RAM roles that you created.
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// The ID of the region in which to create the launch template. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which to assign the instance, Elastic Block Storage (EBS) device, and elastic network interface (ENI).
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
        /// Specifies whether to enable security hardening for the operating system. Valid values:
        /// 
        /// *   Active: enables security hardening. This value is applicable only to public images.
        /// *   Deactive: does not enable security hardening. This value is applicable to all images.
        /// </summary>
        [NameInMap("SecurityEnhancementStrategy")]
        [Validation(Required=false)]
        public string SecurityEnhancementStrategy { get; set; }

        /// <summary>
        /// The ID of the security group to which to assign the instance. Instances in the same security group can communicate with each other. A security group can contain up to 1,000 instances.
        /// 
        /// > You cannot specify both the `SecurityGroupId` and `SecurityGroupIds.N` parameters.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// The IDs of the security groups to which to assign the instance. The valid values of N are based on the maximum number of security groups to which the instance can belong. For more information, see the "Security group limits" section in [Limits](~~25412~~).
        /// 
        /// > You cannot specify both the `SecurityGroupId` and `SecurityGroupIds.N` parameters.
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// The protection period of the preemptible instance. Unit: hours. Default value: 1. Valid values:
        /// 
        /// - 1: After a preemptible instance is created, Alibaba Cloud ensures that the instance is not automatically released within 1 hour. After the 1-hour protection period ends, the system compares the bidding price with the market price and checks the resource inventory to determine whether to retain or release the instance. 
        /// 
        /// - 0: After a preemptible instance is created, Alibaba Cloud does not ensure that the instance runs for 1 hour. The system compares the biding price with the market price and checks the resource inventory to determine whether to retain or release the instance. 
        /// 
        /// Alibaba Cloud sends ECS system events to notify you 5 minutes before the instance is released. Preemptible instances are billed by second. We recommend that you specify a protection period based on your business requirements. 
        /// 
        /// >If you set SpotStrategy to SpotWithPriceLimit or SpotAsPriceGo, this parameter takes effect.
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// The maximum hourly price of the instance. The value is accurate to three decimal places. This parameter is valid only when the `SpotStrategy` parameter is set to `SpotWithPriceLimit`.
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// The bidding policy for the pay-as-you-go instance. This parameter is valid only when the `InstanceChargeType` parameter is set to `PostPaid`. Valid values:
        /// 
        /// *   NoSpot: The instance is a regular pay-as-you-go instance.
        /// *   SpotWithPriceLimit: The instance is created as a preemptible instance with a user-defined maximum hourly price.
        /// *   SpotAsPriceGo: The instance is created as a preemptible instance for which the market price at the time of purchase is automatically used as the bidding price.
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// The tags of the launch template.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateLaunchTemplateRequestTag> Tag { get; set; }
        public class CreateLaunchTemplateRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N to add to the instance, EBS device, and ENI. Valid values of N: 1 to 20. The tag key cannot be an empty string. It can be up to 64 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the instance, EBS device, and ENI. Valid values of N: 1 to 20. The tag value can be an empty string. It can be up to 128 characters in length. It cannot start with acs: or aliyun or contain [http:// or https://.](http://https://。)
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the resource group to which the launch template belongs.
        /// </summary>
        [NameInMap("TemplateResourceGroupId")]
        [Validation(Required=false)]
        public string TemplateResourceGroupId { get; set; }

        /// <summary>
        /// The tags to add to the launch template.
        /// </summary>
        [NameInMap("TemplateTag")]
        [Validation(Required=false)]
        public List<CreateLaunchTemplateRequestTemplateTag> TemplateTag { get; set; }
        public class CreateLaunchTemplateRequestTemplateTag : TeaModel {
            /// <summary>
            /// The key of tag N to add to the launch template. Valid values of N: 1 to 20. The tag key cannot be an empty string. It can be up to 128 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the launch template. Valid values of N: 1 to 20. The tag value can be an empty string. It can be up to 128 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The user data of the instance. The user data must be encoded in Base64. The maximum size of raw data is 16 KB.
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// The ID of the vSwitch to which to connect the instance. This parameter is required if you specify the VpcId parameter.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The description of the launch template version. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("VersionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC).
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The ID of the zone in which to create the instance.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

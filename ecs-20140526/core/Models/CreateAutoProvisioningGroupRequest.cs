// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateAutoProvisioningGroupRequest : TeaModel {
        [NameInMap("LaunchConfiguration")]
        [Validation(Required=false)]
        public CreateAutoProvisioningGroupRequestLaunchConfiguration LaunchConfiguration { get; set; }
        public class CreateAutoProvisioningGroupRequestLaunchConfiguration : TeaModel {
            /// <summary>
            /// This parameter is unavailable for public use.
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public List<CreateAutoProvisioningGroupRequestLaunchConfigurationArn> Arn { get; set; }
            public class CreateAutoProvisioningGroupRequestLaunchConfigurationArn : TeaModel {
                /// <summary>
                /// This parameter is unavailable for public use.
                /// </summary>
                [NameInMap("AssumeRoleFor")]
                [Validation(Required=false)]
                public long? AssumeRoleFor { get; set; }

                /// <summary>
                /// This parameter is unavailable for public use.
                /// </summary>
                [NameInMap("RoleType")]
                [Validation(Required=false)]
                public string RoleType { get; set; }

                /// <summary>
                /// This parameter is unavailable for public use.
                /// </summary>
                [NameInMap("Rolearn")]
                [Validation(Required=false)]
                public string Rolearn { get; set; }

            }

            /// <summary>
            /// 按量付费实例的自动释放时间。按照[ISO8601](~~25696~~)标准表示，使用UTC+0时间。格式为：`yyyy-MM-ddTHH:mm:ssZ`。
            /// 
            /// - 如果秒（`ss`）取值不是`00`，则自动取为当前分钟（`mm`）开始时。
            /// 
            /// - 最短释放时间为当前时间半小时之后。
            /// 
            /// - 最长释放时间不能超过当前时间三年。
            /// </summary>
            [NameInMap("AutoReleaseTime")]
            [Validation(Required=false)]
            public string AutoReleaseTime { get; set; }

            /// <summary>
            /// The performance mode of the burstable instance. Valid values:
            /// 
            /// *   Standard: the standard mode. For more information, see the "Standard mode" section in the [Burstable instances](~~59977~~) topic.
            /// *   Unlimited: the unlimited mode. For more information, see the "Unlimited mode" section in [Burstable instances](~~59977~~).
            /// 
            /// This parameter is empty by default.
            /// 
            /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("CreditSpecification")]
            [Validation(Required=false)]
            public string CreditSpecification { get; set; }

            /// <summary>
            /// The cloud disks in the extended configurations of the launch template.
            /// </summary>
            [NameInMap("DataDisk")]
            [Validation(Required=false)]
            public List<CreateAutoProvisioningGroupRequestLaunchConfigurationDataDisk> DataDisk { get; set; }
            public class CreateAutoProvisioningGroupRequestLaunchConfigurationDataDisk : TeaModel {
                /// <summary>
                /// The category of data disk N. Valid values of N: 1 to 16. Valid values:
                /// 
                /// *   cloud_efficiency: ultra disk.
                /// *   cloud_ssd: standard SSD.
                /// *   cloud_essd: ESSD
                /// *   cloud: basic disk.
                /// 
                /// For I/O optimized instances, the default value is cloud_efficiency. For non-I/O optimized instances, the default value is cloud.
                /// 
                /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// Specifies whether to release the data disk after the instance with which the disk is associated is released. Valid values:
                /// 
                /// *   true: yes
                /// *   false: no
                /// 
                /// Default value: true.
                /// 
                /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
                /// </summary>
                [NameInMap("DeleteWithInstance")]
                [Validation(Required=false)]
                public bool? DeleteWithInstance { get; set; }

                /// <summary>
                /// The description of data disk N. The description must be 2 to 256 characters in length. The description can contain letters but cannot start with `http://` or `https://`. If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The mount target of the data disk. If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
                /// </summary>
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                /// <summary>
                /// The name of the data disk. The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), colons (:), underscores (\_), and hyphens (-). The name must start with a letter but cannot start with `http://` or `https://`.
                /// 
                /// This parameter is empty by default.
                /// 
                /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
                /// </summary>
                [NameInMap("DiskName")]
                [Validation(Required=false)]
                public string DiskName { get; set; }

                /// <summary>
                /// Specifies whether to encrypt data disk N. Valid values:
                /// 
                /// *   true
                /// *   false
                /// 
                /// Default value: false.
                /// 
                /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public bool? Encrypted { get; set; }

                /// <summary>
                /// The ID of the Key Management Service (KMS) key to be used for the data disk. If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
                /// </summary>
                [NameInMap("KmsKeyId")]
                [Validation(Required=false)]
                public string KmsKeyId { get; set; }

                /// <summary>
                /// The PL of the ESSD that is used as the data disk. The number of PLs that you specify must be the same as the value of N in the `LaunchConfiguration.DataDisk.N.Category` parameter. Default value: PL1. Valid values:
                /// 
                /// *   PL0: An ESSD can deliver up to 10,000 random read/write IOPS.
                /// *   PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.
                /// *   PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.
                /// *   PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.
                /// 
                /// For more information about ESSD performance levels, see [ESSDs](~~122389~~).
                /// 
                /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// The size of data disk N. Valid values of N: 1 to 16. Unit: GiB. Valid values:
                /// 
                /// *   Valid values when LaunchConfiguration.DataDisk.N.Category is set to cloud_efficiency: 20 to 32768.
                /// 
                /// *   Valid values when LaunchConfiguration.DataDisk.N.Category is set to cloud_ssd: 20 to 32768.
                /// 
                /// *   Valid values when LaunchConfiguration.DataDisk.N.Category is set to cloud_essd: depend on the `LaunchConfiguration.DataDisk.N.PerformanceLevel` value.
                /// 
                ///     *   Valid values when LaunchConfiguration.DataDisk.N.PerformanceLevel is set to PL0: 40 to 32768.
                ///     *   Valid values when DataDisk.N.PerformanceLevel is set to PL1: 20 to 32768.
                ///     *   Valid values when LaunchConfiguration.DataDisk.N.PerformanceLevel is set to PL2: 461 to 32768.
                ///     *   Valid values when LaunchConfiguration.DataDisk.N.PerformanceLevel is set to PL3: 1261 to 32768.
                /// 
                /// *   Valid values when LaunchConfiguration.DataDisk.N.Category is set to cloud: 5 to 2000.
                /// 
                /// > The parameter value must be greater than or equal to the size of the snapshot specified by the `LaunchConfiguration.DataDisk.N.SnapshotId` parameter.
                /// 
                /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// The ID of the snapshot that you want to use to create the data disk. Valid values of N: 1 to 16.
                /// 
                /// After this parameter is specified, the `LaunchConfiguration.DataDisk.N.Size` parameter is ignored. The size of the data disk is the same as that of the snapshot specified by this parameter. Use snapshots created after July 15, 2013. Otherwise, an error is returned and your request is rejected.
                /// 
                /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
                /// </summary>
                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

            }

            /// <summary>
            /// The ID of the deployment set to which to deploy the instance.
            /// </summary>
            [NameInMap("DeploymentSetId")]
            [Validation(Required=false)]
            public string DeploymentSetId { get; set; }

            /// <summary>
            /// The hostname of the instance. Take note of the following items:
            /// 
            /// *   The hostname cannot start or end with a period (.) or hyphen (-). The hostname cannot contain consecutive periods (.) or hyphens (-).
            /// *   For Windows instances, the hostname must be 2 to 15 characters in length and cannot contain periods (.) or contain only digits. It can contain letters, digits, and hyphens (-).
            /// *   For instances that run other operating systems such as Linux, the hostname must be 2 to 64 characters in length. You can use periods (.) to separate a hostname into multiple segments. Each segment can contain letters, digits, and hyphens (-).
            /// *   You cannot specify both the `LaunchConfiguration.HostName` and `LaunchConfiguration.HostNames.N` parameters. Otherwise, an error is returned.
            /// *   If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// The hostname of the instance. You can use this parameter to specify different hostnames for multiple instances. Take note of the following items:
            /// 
            /// *   This parameter takes effect only when `AutoProvisioningGroupType` is set to instant.
            /// *   The value of N indicates the number of instances. Valid values: 1 to 1000. The value of N must be the same as the TotalTargetCapacity value.
            /// *   The hostname cannot start or end with a period (.) or hyphen (-). It cannot contain consecutive periods (.) or hyphens (-).
            /// *   For a Windows instance, the hostname must be 2 to 15 characters in length and cannot contain periods (.) or contain only digits. The hostname can contain letters, digits, and hyphens (-).
            /// *   For instances that run other operating systems such as Linux, the hostname must be 2 to 64 characters in length. You can use periods (.) to separate the hostname into multiple segments. Each segment can contain letters, digits, and hyphens (-).
            /// *   You cannot specify both the `LaunchConfiguration.HostName` and `LaunchConfiguration.HostNames.N` parameters. Otherwise, an error is returned.
            /// *   If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("HostNames")]
            [Validation(Required=false)]
            public List<string> HostNames { get; set; }

            /// <summary>
            /// The ID of the image that you want to use to create the instance. You can call the [DescribeImages](~~25534~~) operation to query available image resources. If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The description of the instance. The description must be 2 to 256 characters in length. The description can contain letters but cannot start with `http://` or `https://`. If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// The name of the instance . The name must be 2 to 128 characters in length. It must start with a letter and cannot start with `http://` or `https://`. It can contain letters, digits, colons (:), underscores (\_), periods (.), and hyphens (-). The default value of this parameter is the `InstanceId` value.
            /// 
            /// When you batch create instances, you can batch configure sequential names for the instances. For more information, see [Batch configure sequential names or hostnames for multiple instances](~~196048~~).
            /// 
            /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The billing method for network usage. Valid values:
            /// 
            /// *   PayByBandwidth: pay-by-bandwidth
            /// *   PayByTraffic: pay-by-traffic
            /// 
            /// > If the pay-by-traffic billing method for network usage is used, the maximum inbound and outbound bandwidths are used as the upper limits of bandwidths instead of guaranteed performance specifications. In scenarios where demand outstrips resource supplies, these maximum bandwidth values may not be reached. If you want guaranteed bandwidths for your instances, use the pay-by-bandwidth billing method for network usage.
            /// 
            /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// The maximum inbound public bandwidth. Unit: Mbit/s. Valid values:
            /// 
            /// *   When the purchased outbound public bandwidth is less than or equal to 10 Mbit/s, the valid values of this parameter are 1 to 10 and the default value is 10.
            /// *   When the purchased outbound public bandwidth is greater than 10 Mbit/s, the valid values of this parameter are 1 to the value of `LaunchConfiguration.InternetMaxBandwidthOut`, and the default value is the value of `LaunchConfiguration.InternetMaxBandwidthOut`.
            /// 
            /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("InternetMaxBandwidthIn")]
            [Validation(Required=false)]
            public int? InternetMaxBandwidthIn { get; set; }

            /// <summary>
            /// The maximum outbound public bandwidth. Unit: Mbit/s. Valid values: 0 to 100.
            /// 
            /// Default value: 0.
            /// 
            /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("InternetMaxBandwidthOut")]
            [Validation(Required=false)]
            public int? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// Specifies whether to create an I/O optimized instance. Valid values:
            /// 
            /// *   none: The instance is not I/O optimized.
            /// *   optimized: The instance is I/O optimized.
            /// 
            /// For instances of retired instance types, the default value is none. For instances of other instance types, the default value is optimized.
            /// 
            /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("IoOptimized")]
            [Validation(Required=false)]
            public string IoOptimized { get; set; }

            /// <summary>
            /// The name of the key pair to bind to the instance.
            /// 
            /// *   For Windows instances, this parameter is ignored. This parameter is empty by default.
            /// *   By default, password-based logon is disabled for Linux instances.
            /// 
            /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// The password of the instance. The password must be 8 to 30 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include:
            /// 
            /// ``()`~!@#$%^&*-_+=|{}`[]`:;\"<>,.?/``
            /// 
            /// For Windows instances, the password cannot start with a forward slash (/).
            /// 
            /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// Specifies whether to use the preset password of the image. Valid values:
            /// 
            /// *   true: uses the preset password.
            /// *   false: does not use the preset password.
            /// 
            /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("PasswordInherit")]
            [Validation(Required=false)]
            public bool? PasswordInherit { get; set; }

            /// <summary>
            /// The name of the instance Resource Access Management (RAM) role. You can call the [ListRoles](~~28713~~) operation provided by RAM to query the instance RAM roles that you created. If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// The ID of the resource group to which to assign the instance. If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// Indicates whether security hardening is enabled. Valid values:
            /// 
            /// *   Active: Security hardening is enabled. This value is applicable only to public images.
            /// *   Deactive: Security hardening is disabled. This value is applicable to all image types.
            /// 
            /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("SecurityEnhancementStrategy")]
            [Validation(Required=false)]
            public string SecurityEnhancementStrategy { get; set; }

            /// <summary>
            /// The ID of security group N to which to assign the instance. If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The IDs of the security groups to which the new ECS instances belong.
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// The information of the system disk on the instance. If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("SystemDisk")]
            [Validation(Required=false)]
            public CreateAutoProvisioningGroupRequestLaunchConfigurationSystemDisk SystemDisk { get; set; }
            public class CreateAutoProvisioningGroupRequestLaunchConfigurationSystemDisk : TeaModel {
                /// <summary>
                /// The algorithm to be used to encrypt data disks. Valid values:
                /// 
                /// *   aes-256
                /// *   sm4-128
                /// 
                /// Default value: aes-256.
                /// 
                /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
                /// </summary>
                [NameInMap("EncryptAlgorithm")]
                [Validation(Required=false)]
                public string EncryptAlgorithm { get; set; }

                /// <summary>
                /// Specifies whether to encrypt system disk N. Valid values:
                /// 
                /// *   true
                /// *   false
                /// 
                /// Default value: false.
                /// 
                /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public string Encrypted { get; set; }

                /// <summary>
                /// The ID of the KMS key that you want to use for the system disk.
                /// 
                /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
                /// </summary>
                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

            }

            /// <summary>
            /// The category of the system disk. Valid values:
            /// 
            /// *   cloud_efficiency: ultra disk.
            /// *   cloud_ssd: standard SSD.
            /// *   cloud_essd: enhanced SSD (ESSD)
            /// *   cloud: basic disk.
            /// 
            /// For non-I/O optimized instances of retired instance types, the default value is cloud. For other instances, the default value is cloud_efficiency.
            /// 
            /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// The description of the system disk. The description must be 2 to 256 characters in length. The description can contain letters but cannot start with `http://` or `https://`.
            /// 
            /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("SystemDiskDescription")]
            [Validation(Required=false)]
            public string SystemDiskDescription { get; set; }

            /// <summary>
            /// The name of the system disk. The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), colons (:), underscores (\_), and hyphens (-). The name must start with a letter but cannot start with `http://` or `https://`.
            /// 
            /// This parameter is empty by default.
            /// 
            /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("SystemDiskName")]
            [Validation(Required=false)]
            public string SystemDiskName { get; set; }

            /// <summary>
            /// The performance level of the ESSD that you want to use as the system disk. Default value: PL0. Valid values:
            /// 
            /// *   PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.
            /// *   PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.
            /// *   PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.
            /// *   PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.
            /// 
            /// For more information about ESSD performance levels, see [ESSDs](~~122389~~).
            /// 
            /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("SystemDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// The size of the system disk. Valid values: 20 to 500. Unit: GiB. This parameter value must be at least 20 and greater than or equal to the size of the image specified by the LaunchConfiguration.ImageId parameter.
            /// 
            /// Default value: 40 or the size of the image specified by the LaunchConfiguration.ImageId parameter, whichever is greater.
            /// 
            /// If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// The tags in the extended configurations of the launch template.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<CreateAutoProvisioningGroupRequestLaunchConfigurationTag> Tag { get; set; }
            public class CreateAutoProvisioningGroupRequestLaunchConfigurationTag : TeaModel {
                /// <summary>
                /// The key of the tag. Valid values of N: 1 to 20. The tag key cannot be an empty string. It can be up to 128 characters in length and cannot start with acs: or aliyun. It cannot contain `http://` or `https://`. If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the tag. Valid values of N: 1 to 20. The tag value can be an empty string. It can be up to 128 characters in length. It cannot start with acs: or contain `http://` or `https://`. If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The user data of the instance. The user data must be encoded in Base64. The raw data can be up to 16 KB in size. If both the LaunchTemplateId and LaunchConfiguration.\* parameters are specified, the LaunchTemplateId parameter takes precedence.
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// The name of the auto provisioning group. The name must be 2 to 128 characters in length, and can contain letters, digits, colons (:), underscores (\_), and hyphens (-). It must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("AutoProvisioningGroupName")]
        [Validation(Required=false)]
        public string AutoProvisioningGroupName { get; set; }

        /// <summary>
        /// The delivery type of the auto provisioning group. Valid values:
        /// 
        /// *   request: one-time asynchronous delivery. The auto provisioning group attempts to asynchronously deliver an instance cluster that meets the target capacity only once when it is started. The group does not retry the operation regardless of whether all the instances are delivered.
        /// *   instant: one-time synchronous delivery. The auto provisioning group attempts to synchronously deliver an instance cluster that meets the target capacity only once when it is started. The list of delivered instances and the causes of delivery failures are returned in the response.
        /// *   maintain: continuous delivery. The auto provisioning group attempts to deliver an instance cluster that meets the target capacity, and monitors the real-time capacity when it is started. If the target capacity of the auto provisioning group is not reached, the auto provisioning group continues to create instances until the target capacity is reached.
        /// 
        /// Default value: maintain.
        /// </summary>
        [NameInMap("AutoProvisioningGroupType")]
        [Validation(Required=false)]
        public string AutoProvisioningGroupType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but make sure that the value is unique among different requests. The ClientToken value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The information of data disks on the instance.
        /// </summary>
        [NameInMap("DataDiskConfig")]
        [Validation(Required=false)]
        public List<CreateAutoProvisioningGroupRequestDataDiskConfig> DataDiskConfig { get; set; }
        public class CreateAutoProvisioningGroupRequestDataDiskConfig : TeaModel {
            /// <summary>
            /// The category of the data disk. You can specify multiple disk categories, and the disk categories are prioritized in the order in which they are specified. If a specified disk category is unavailable, the system uses the next available disk category. Valid values:
            /// 
            /// *   cloud_efficiency: ultra disk.
            /// *   cloud_ssd: standard SSD.
            /// *   cloud_essd: ESSD
            /// *   cloud: basic disk.
            /// </summary>
            [NameInMap("DiskCategory")]
            [Validation(Required=false)]
            public string DiskCategory { get; set; }

        }

        /// <summary>
        /// The type of supplemental instances. If the sum of the values of the `PayAsYouGoTargetCapacity` and `SpotTargetCapacity` parameters is smaller than the value of the `TotalTargetCapacity` parameter, the auto provisioning group creates instances of the specified type to meet the capacity requirements. Valid values:
        /// 
        /// *   PayAsYouGo: pay-as-you-go instances
        /// *   Spot: preemptible instances.
        /// 
        /// Default value: Spot.
        /// </summary>
        [NameInMap("DefaultTargetCapacityType")]
        [Validation(Required=false)]
        public string DefaultTargetCapacityType { get; set; }

        /// <summary>
        /// The description of the auto provisioning group.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to release the removed instances when the real-time capacity of the auto provisioning group exceeds the target capacity and a scale-in event is triggered. Valid values:
        /// 
        /// *   termination: releases the removed instances.
        /// *   no-termination: only removes the instances from the auto provisioning group but does not release them.
        /// 
        /// Default value: no-termination.
        /// </summary>
        [NameInMap("ExcessCapacityTerminationPolicy")]
        [Validation(Required=false)]
        public string ExcessCapacityTerminationPolicy { get; set; }

        /// <summary>
        /// > This parameter is in invitational preview and is unavailable for general users.
        /// </summary>
        [NameInMap("HibernationOptionsConfigured")]
        [Validation(Required=false)]
        public bool? HibernationOptionsConfigured { get; set; }

        /// <summary>
        /// The extended configurations of the launch template.
        /// </summary>
        [NameInMap("LaunchTemplateConfig")]
        [Validation(Required=false)]
        public List<CreateAutoProvisioningGroupRequestLaunchTemplateConfig> LaunchTemplateConfig { get; set; }
        public class CreateAutoProvisioningGroupRequestLaunchTemplateConfig : TeaModel {
            /// <summary>
            /// The architectures of the instance types.
            /// </summary>
            [NameInMap("Architectures")]
            [Validation(Required=false)]
            public List<string> Architectures { get; set; }

            /// <summary>
            /// Specifies whether to include burstable instance types. Valid values:
            /// 
            /// *   Exclude: does not include burstable instance types.
            /// *   Include: includes burstable instance types.
            /// *   Required: includes only burstable instance types.
            /// 
            /// Default value: Include.
            /// </summary>
            [NameInMap("BurstablePerformance")]
            [Validation(Required=false)]
            public string BurstablePerformance { get; set; }

            /// <summary>
            /// The number of vCPU cores of the instance type.
            /// </summary>
            [NameInMap("Cores")]
            [Validation(Required=false)]
            public List<int?> Cores { get; set; }

            /// <summary>
            /// The instance types that you want to exclude.
            /// </summary>
            [NameInMap("ExcludedInstanceTypes")]
            [Validation(Required=false)]
            public List<string> ExcludedInstanceTypes { get; set; }

            /// <summary>
            /// The instance family level in the intelligent configuration mode. This parameter is used to filter the available instance types that meet the specified criteria. Valid values:
            /// 
            /// *   EntryLevel: shared instance type. Instances of this level are the most cost-effective but may not provide stable computing performance. Instances of this level are suitable for business scenarios in which the CPU utilization is low. For more information, see [Shared instance families](~~108489~~).
            /// *   EnterpriseLevel: enterprise level. Instances of this level provide stable performance and dedicated resources, and are suitable for scenarios in which high stability is required. For more information, see [Overview of instance families](~~25378~~).
            /// *   CreditEntryLevel: This value is available only for burstable instances. CPU credits are used to ensure computing performance. Instances of this level are suitable for scenarios in which the CPU utilization is low but may fluctuate in specific cases. For more information, see [What are burstable instances?](~~59977~~).
            /// 
            /// Valid values of N: 1 to 10.
            /// </summary>
            [NameInMap("InstanceFamilyLevel")]
            [Validation(Required=false)]
            public string InstanceFamilyLevel { get; set; }

            /// <summary>
            /// The instance type in extended configuration N. Valid values of N: 1 to 20. For more information about the valid values of this parameter, see [Instance families](~~25378~~).
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The maximum price of preemptible instances in extended configuration N.
            /// 
            /// **
            /// 
            /// **If you specify the **`LaunchTemplateConfig` parameter, you must also specify the `LaunchTemplateConfig.N.MaxPrice` parameter.
            /// </summary>
            [NameInMap("MaxPrice")]
            [Validation(Required=false)]
            public double? MaxPrice { get; set; }

            /// <summary>
            /// > This parameter is in invitational preview and is unavailable to general users.
            /// </summary>
            [NameInMap("MaxQuantity")]
            [Validation(Required=false)]
            public int? MaxQuantity { get; set; }

            /// <summary>
            /// The memory sizes of the instance type.
            /// </summary>
            [NameInMap("Memories")]
            [Validation(Required=false)]
            public List<float?> Memories { get; set; }

            /// <summary>
            /// The priority of the extended configuration. A value of 0 indicates the highest priority. Valid values: 0 to ∞.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// The ID of the vSwitch in extended configuration N. The zone of the ECS instances created from the extended configuration is determined by the vSwitch.
            /// 
            /// > If you specify the `LaunchTemplateConfig` parameter, you must also specify the `LaunchTemplateConfig.N.VSwitchId` parameter.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The weight of the instance type specified in the extended configuration. A greater weight indicates that a single instance has more computing power and fewer instances are required. The value must be greater than 0.
            /// 
            /// The weight is calculated based on the computing power of the instance type and the minimum computing power of a single instance in the cluster to be created by the auto provisioning group. For example, assume that the minimum computing power of a single instance is 8 vCPUs and 60 GiB of memory.
            /// 
            /// *   For an instance type with 8 vCPUs and 60 GiB of memory, you can set the weight to 1.
            /// *   For an instance type with 16 vCPUs and 120 GiB of memory, you can set the weight to 2.
            /// </summary>
            [NameInMap("WeightedCapacity")]
            [Validation(Required=false)]
            public double? WeightedCapacity { get; set; }

        }

        /// <summary>
        /// The ID of the launch template associated with the auto provisioning group. You can call the [DescribeLaunchTemplates](~~73759~~) operation to query available launch templates. If both the LaunchTemplateId and `LaunchConfiguration.*` parameters are specified, the LaunchTemplateId parameter takes precedence.
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// The version of the launch template associated with the auto provisioning group. You can call the [DescribeLaunchTemplateVersions](~~73761~~) operation to query the versions of available launch templates.
        /// 
        /// Default value: the default version of the launch template.
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public string LaunchTemplateVersion { get; set; }

        /// <summary>
        /// The maximum price of preemptible instances in the auto provisioning group.
        /// 
        /// > If the `MaxSpotPrice` and `LaunchTemplateConfig.N.MaxPrice` parameters are both specified, the lower price is used.
        /// </summary>
        [NameInMap("MaxSpotPrice")]
        [Validation(Required=false)]
        public float? MaxSpotPrice { get; set; }

        /// <summary>
        /// The minimum target capacity of the auto provisioning group. The value must be a positive integer.
        /// 
        /// When you specify this parameter, take note of the following items:
        /// 
        /// *   This parameter takes effect only when `AutoProvisioningGroupType` is set to instant.
        /// *   If the number of instances that can be created in the current region is smaller than the value of this parameter, the operation cannot be called and no instances are created.
        /// *   If the number of instances that can be created in the current region is greater than the value of this parameter, instances can be created based on the specified parameters.
        /// </summary>
        [NameInMap("MinTargetCapacity")]
        [Validation(Required=false)]
        public string MinTargetCapacity { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The policy for creating pay-as-you-go instances. Valid values:
        /// 
        /// *   lowest-price: cost optimization policy. The auto provisioning group attempts to create instances of the lowest-priced instance type.
        /// *   prioritized: priority-based policy. The auto provisioning group attempts to create instances based on the priority specified by the `LaunchTemplateConfig.N.Priority` parameter.
        /// 
        /// Default value: lowest-price.
        /// </summary>
        [NameInMap("PayAsYouGoAllocationStrategy")]
        [Validation(Required=false)]
        public string PayAsYouGoAllocationStrategy { get; set; }

        /// <summary>
        /// The target capacity of pay-as-you-go instances in the auto provisioning group. The value must be smaller than the `TotalTargetCapacity` value.
        /// </summary>
        [NameInMap("PayAsYouGoTargetCapacity")]
        [Validation(Required=false)]
        public string PayAsYouGoTargetCapacity { get; set; }

        /// <summary>
        /// The ID of the region in which to create the auto provisioning group. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which to assign the auto provisioning group.
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
        /// The policy for creating preemptible instances. Valid values:
        /// 
        /// *   lowest-price: cost optimization policy. The auto provisioning group attempts to create instances of the lowest-priced instance type.
        /// *   diversified: balanced distribution policy. The auto provisioning group attempts to create instances in zones that are specified in extended configurations and then evenly distribute the instances across the zones.
        /// *   capacity-optimized: capacity-optimized distribution policy. The auto provisioning group attempts to create instances that are of the optimal instance types across the optimal zones based on resource availability.
        /// 
        /// Default value: lowest-price.
        /// </summary>
        [NameInMap("SpotAllocationStrategy")]
        [Validation(Required=false)]
        public string SpotAllocationStrategy { get; set; }

        /// <summary>
        /// The operation to be performed on the preemptible instance when it is interrupted. Valid values:
        /// 
        /// *   stop: stops the preemptible instance.
        /// *   terminate: releases the preemptible instance.
        /// 
        /// Default value: terminate.
        /// </summary>
        [NameInMap("SpotInstanceInterruptionBehavior")]
        [Validation(Required=false)]
        public string SpotInstanceInterruptionBehavior { get; set; }

        /// <summary>
        /// The number of preemptible instances of the lowest-priced instance type to be created by the auto provisioning group. This parameter takes effect when the `SpotAllocationStrategy` parameter is set to `lowest-price`.
        /// 
        /// The value of SpotInstancePoolsToUseCount must be smaller than the N value specified in `LaunchTemplateConfig.N.*` parameters.
        /// </summary>
        [NameInMap("SpotInstancePoolsToUseCount")]
        [Validation(Required=false)]
        public int? SpotInstancePoolsToUseCount { get; set; }

        /// <summary>
        /// The target capacity of preemptible instances in the auto provisioning group. The value must be smaller than the `TotalTargetCapacity` value.
        /// </summary>
        [NameInMap("SpotTargetCapacity")]
        [Validation(Required=false)]
        public string SpotTargetCapacity { get; set; }

        /// <summary>
        /// The information of system disks on the instance.
        /// </summary>
        [NameInMap("SystemDiskConfig")]
        [Validation(Required=false)]
        public List<CreateAutoProvisioningGroupRequestSystemDiskConfig> SystemDiskConfig { get; set; }
        public class CreateAutoProvisioningGroupRequestSystemDiskConfig : TeaModel {
            /// <summary>
            /// The category of the system disk. You can specify multiple disk categories, and the disk categories are prioritized in the order in which they are specified. If a specified disk category is unavailable, the system uses the next available disk category. Valid values:
            /// 
            /// *   cloud_efficiency: ultra disk.
            /// *   cloud_ssd: standard SSD.
            /// *   cloud_essd: ESSD
            /// *   cloud: basic disk.
            /// </summary>
            [NameInMap("DiskCategory")]
            [Validation(Required=false)]
            public string DiskCategory { get; set; }

        }

        /// <summary>
        /// Specifies whether to release instances in the auto provisioning group after the auto provisioning group is deleted. Valid values:
        /// 
        /// *   true: releases instances in the auto provisioning group.
        /// *   false: retains instances in the auto provisioning group.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("TerminateInstances")]
        [Validation(Required=false)]
        public bool? TerminateInstances { get; set; }

        /// <summary>
        /// Specifies whether to release instances in the auto provisioning group after the auto provisioning group expires. Valid values:
        /// 
        /// *   true: releases instances in the auto provisioning group.
        /// *   false: only removes instances from the auto provisioning group but does not release them.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("TerminateInstancesWithExpiration")]
        [Validation(Required=false)]
        public bool? TerminateInstancesWithExpiration { get; set; }

        /// <summary>
        /// The total target capacity of the auto provisioning group. The value must be a positive integer.
        /// 
        /// The total target capacity of the auto provisioning group must be greater than or equal to the sum of the target capacity of pay-as-you-go instances specified by the `PayAsYouGoTargetCapacity` parameter and the target capacity of preemptible instances specified by the `SpotTargetCapacity` parameter.
        /// </summary>
        [NameInMap("TotalTargetCapacity")]
        [Validation(Required=false)]
        public string TotalTargetCapacity { get; set; }

        /// <summary>
        /// The time at which to start the auto provisioning group. The period of time between this point in time and the point in time specified by the `ValidUntil` parameter is the effective time period of the auto provisioning group.
        /// 
        /// Specify the time in the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// By default, an auto provisioning group is started immediately after it is created.
        /// </summary>
        [NameInMap("ValidFrom")]
        [Validation(Required=false)]
        public string ValidFrom { get; set; }

        /// <summary>
        /// The expiration time of the auto provisioning group. The period of time between this point in time and the point in time specified by the `ValidFrom` parameter is the effective time period of the auto provisioning group.
        /// 
        /// Specify the time in the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// Default value: 2099-12-31T23:59:59Z.
        /// </summary>
        [NameInMap("ValidUntil")]
        [Validation(Required=false)]
        public string ValidUntil { get; set; }

    }

}

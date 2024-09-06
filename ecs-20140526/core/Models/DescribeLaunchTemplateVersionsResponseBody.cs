// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeLaunchTemplateVersionsResponseBody : TeaModel {
        /// <summary>
        /// Details about the launch template versions.
        /// </summary>
        [NameInMap("LaunchTemplateVersionSets")]
        [Validation(Required=false)]
        public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSets LaunchTemplateVersionSets { get; set; }
        public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSets : TeaModel {
            [NameInMap("LaunchTemplateVersionSet")]
            [Validation(Required=false)]
            public List<DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSet> LaunchTemplateVersionSet { get; set; }
            public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSet : TeaModel {
                /// <summary>
                /// The time when the launch template version was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The creator of the launch template version.
                /// </summary>
                [NameInMap("CreatedBy")]
                [Validation(Required=false)]
                public string CreatedBy { get; set; }

                /// <summary>
                /// Indicates whether the launch template version is the default version.
                /// </summary>
                [NameInMap("DefaultVersion")]
                [Validation(Required=false)]
                public bool? DefaultVersion { get; set; }

                /// <summary>
                /// The configurations of the launch template.
                /// </summary>
                [NameInMap("LaunchTemplateData")]
                [Validation(Required=false)]
                public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateData LaunchTemplateData { get; set; }
                public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateData : TeaModel {
                    [NameInMap("SystemDisk")]
                    [Validation(Required=false)]
                    public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataSystemDisk SystemDisk { get; set; }
                    public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataSystemDisk : TeaModel {
                        [NameInMap("AutoSnapshotPolicyId")]
                        [Validation(Required=false)]
                        public string AutoSnapshotPolicyId { get; set; }

                        [NameInMap("BurstingEnabled")]
                        [Validation(Required=false)]
                        public bool? BurstingEnabled { get; set; }

                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        [NameInMap("DeleteWithInstance")]
                        [Validation(Required=false)]
                        public bool? DeleteWithInstance { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("DiskName")]
                        [Validation(Required=false)]
                        public string DiskName { get; set; }

                        [NameInMap("Encrypted")]
                        [Validation(Required=false)]
                        public string Encrypted { get; set; }

                        [NameInMap("Iops")]
                        [Validation(Required=false)]
                        public int? Iops { get; set; }

                        [NameInMap("PerformanceLevel")]
                        [Validation(Required=false)]
                        public string PerformanceLevel { get; set; }

                        [NameInMap("ProvisionedIops")]
                        [Validation(Required=false)]
                        public long? ProvisionedIops { get; set; }

                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public int? Size { get; set; }

                    }

                    /// <summary>
                    /// The automatic release time of the instance.
                    /// </summary>
                    [NameInMap("AutoReleaseTime")]
                    [Validation(Required=false)]
                    public string AutoReleaseTime { get; set; }

                    /// <summary>
                    /// Indicates whether auto-renewal is enabled for the instance. This parameter is valid only if `InstanceChargeType` is set to `PrePaid`. Valid values:
                    /// 
                    /// *   true
                    /// *   false
                    /// 
                    /// Default value: false.
                    /// </summary>
                    [NameInMap("AutoRenew")]
                    [Validation(Required=false)]
                    public bool? AutoRenew { get; set; }

                    /// <summary>
                    /// The auto-renewal period of the instance. Valid values:
                    /// 
                    /// Valid values when PeriodUnit is set to Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.
                    /// 
                    /// Default value: 1.
                    /// </summary>
                    [NameInMap("AutoRenewPeriod")]
                    [Validation(Required=false)]
                    public int? AutoRenewPeriod { get; set; }

                    /// <summary>
                    /// The performance mode of the burstable instance. Valid values:
                    /// 
                    /// *   Standard: the standard mode. For more information, see the "Standard mode" section in [Overview of burstable instances](https://help.aliyun.com/document_detail/59977.html).
                    /// *   Unlimited: the unlimited mode. For more information, see the "Unlimited mode" section in [Overview of burstable instances](https://help.aliyun.com/document_detail/59977.html).
                    /// </summary>
                    [NameInMap("CreditSpecification")]
                    [Validation(Required=false)]
                    public string CreditSpecification { get; set; }

                    /// <summary>
                    /// Details about the data disks.
                    /// </summary>
                    [NameInMap("DataDisks")]
                    [Validation(Required=false)]
                    public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataDataDisks DataDisks { get; set; }
                    public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataDataDisks : TeaModel {
                        [NameInMap("DataDisk")]
                        [Validation(Required=false)]
                        public List<DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataDataDisksDataDisk> DataDisk { get; set; }
                        public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataDataDisksDataDisk : TeaModel {
                            /// <summary>
                            /// The ID of the automatic snapshot policy.
                            /// </summary>
                            [NameInMap("AutoSnapshotPolicyId")]
                            [Validation(Required=false)]
                            public string AutoSnapshotPolicyId { get; set; }

                            /// <summary>
                            /// Indicates whether the performance burst feature is enabled. Valid values:
                            /// 
                            /// *   true
                            /// *   false
                            /// </summary>
                            [NameInMap("BurstingEnabled")]
                            [Validation(Required=false)]
                            public bool? BurstingEnabled { get; set; }

                            /// <summary>
                            /// The category of the data disk.
                            /// </summary>
                            [NameInMap("Category")]
                            [Validation(Required=false)]
                            public string Category { get; set; }

                            /// <summary>
                            /// Indicates whether to release the data disk when the instance is released.
                            /// </summary>
                            [NameInMap("DeleteWithInstance")]
                            [Validation(Required=false)]
                            public bool? DeleteWithInstance { get; set; }

                            /// <summary>
                            /// The description of the data disk.
                            /// </summary>
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// The mount point of the data disk. The mount points are named based on the number of data disks:
                            /// 
                            /// *   1st to 25th data disks: /dev/xvd`[b-z]`.
                            /// *   From the 26th data disk on: /dev/xvd`[aa-zz]`. For example, the 26th data disk is named /dev/xvdaa, the 27th data disk is named /dev/xvdab, and so on.
                            /// 
                            /// >  This parameter is applicable to scenarios in which a full image is used to create instances. A full image is an image that contains an operating system, application software, and business data. For these scenarios, you can set the parameter to the mount point of data disk N contained in the full image and modify `DataDisk.N.Size` and `DataDisk.N.Category` to change the category and size of data disk N created based on the image.
                            /// </summary>
                            [NameInMap("Device")]
                            [Validation(Required=false)]
                            public string Device { get; set; }

                            /// <summary>
                            /// The name of the data disk.
                            /// </summary>
                            [NameInMap("DiskName")]
                            [Validation(Required=false)]
                            public string DiskName { get; set; }

                            /// <summary>
                            /// Indicates whether the data disk is encrypted.
                            /// </summary>
                            [NameInMap("Encrypted")]
                            [Validation(Required=false)]
                            public string Encrypted { get; set; }

                            /// <summary>
                            /// The performance level of the ESSD to use as a data disk. This parameter is returned only when the value of `Category` is cloud_essd. Valid values:
                            /// 
                            /// *   PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.
                            /// *   PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.
                            /// *   PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.
                            /// *   PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.
                            /// </summary>
                            [NameInMap("PerformanceLevel")]
                            [Validation(Required=false)]
                            public string PerformanceLevel { get; set; }

                            /// <summary>
                            /// The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}.
                            /// 
                            /// Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}.
                            /// 
                            /// >  This parameter is available only if you set DataDisk.N.Category to cloud_auto. For more information, see [ESSD AutoPL disks](https://help.aliyun.com/document_detail/368372.html) and [Modify the performance configurations of an ESSD AutoPL disk](https://help.aliyun.com/document_detail/413275.html).
                            /// </summary>
                            [NameInMap("ProvisionedIops")]
                            [Validation(Required=false)]
                            public long? ProvisionedIops { get; set; }

                            /// <summary>
                            /// The size of the data disk.
                            /// </summary>
                            [NameInMap("Size")]
                            [Validation(Required=false)]
                            public int? Size { get; set; }

                            /// <summary>
                            /// The ID of the snapshot to use to create the data disk.
                            /// </summary>
                            [NameInMap("SnapshotId")]
                            [Validation(Required=false)]
                            public string SnapshotId { get; set; }

                        }

                    }

                    /// <summary>
                    /// Indicates whether release protection is enabled for the instance. This parameter indicates whether you can use the ECS console or call the [DeleteInstance](https://help.aliyun.com/document_detail/25507.html) operation to release the instance. Valid values:
                    /// 
                    /// *   true
                    /// *   false
                    /// 
                    /// Default value: false.
                    /// 
                    /// >  This parameter is applicable only to pay-as-you-go instances. The release protection feature can protect instances against manual releases, but not against automatic releases.
                    /// </summary>
                    [NameInMap("DeletionProtection")]
                    [Validation(Required=false)]
                    public bool? DeletionProtection { get; set; }

                    /// <summary>
                    /// The ID of the deployment set.
                    /// </summary>
                    [NameInMap("DeploymentSetId")]
                    [Validation(Required=false)]
                    public string DeploymentSetId { get; set; }

                    /// <summary>
                    /// The description of the system disk.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// Indicates whether the operating system configuration of the instance is enabled.
                    /// </summary>
                    [NameInMap("EnableVmOsConfig")]
                    [Validation(Required=false)]
                    public bool? EnableVmOsConfig { get; set; }

                    /// <summary>
                    /// The hostname of the instance.
                    /// </summary>
                    [NameInMap("HostName")]
                    [Validation(Required=false)]
                    public string HostName { get; set; }

                    /// <summary>
                    /// The ID of the image.
                    /// </summary>
                    [NameInMap("ImageId")]
                    [Validation(Required=false)]
                    public string ImageId { get; set; }

                    /// <summary>
                    /// The source of the image. Valid values:
                    /// 
                    /// *   system: public image provided by Alibaba Cloud
                    /// *   self: custom image that you created
                    /// *   others: shared image from another Alibaba Cloud account
                    /// *   marketplace: Alibaba Cloud Marketplace image
                    /// </summary>
                    [NameInMap("ImageOwnerAlias")]
                    [Validation(Required=false)]
                    public string ImageOwnerAlias { get; set; }

                    /// <summary>
                    /// The billing method of the instance. Valid values:
                    /// 
                    /// *   PrePaid: subscription
                    /// *   PostPaid: pay-as-you-go
                    /// </summary>
                    [NameInMap("InstanceChargeType")]
                    [Validation(Required=false)]
                    public string InstanceChargeType { get; set; }

                    /// <summary>
                    /// The name of the instance.
                    /// </summary>
                    [NameInMap("InstanceName")]
                    [Validation(Required=false)]
                    public string InstanceName { get; set; }

                    /// <summary>
                    /// The instance type of the instance.
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// The billing method for network usage.
                    /// </summary>
                    [NameInMap("InternetChargeType")]
                    [Validation(Required=false)]
                    public string InternetChargeType { get; set; }

                    /// <summary>
                    /// The maximum inbound public bandwidth.
                    /// </summary>
                    [NameInMap("InternetMaxBandwidthIn")]
                    [Validation(Required=false)]
                    public int? InternetMaxBandwidthIn { get; set; }

                    /// <summary>
                    /// The maximum outbound public bandwidth.
                    /// </summary>
                    [NameInMap("InternetMaxBandwidthOut")]
                    [Validation(Required=false)]
                    public int? InternetMaxBandwidthOut { get; set; }

                    /// <summary>
                    /// Indicates whether the instance is I/O optimized.
                    /// </summary>
                    [NameInMap("IoOptimized")]
                    [Validation(Required=false)]
                    public string IoOptimized { get; set; }

                    /// <summary>
                    /// The number of IPv6 addresses to assign to the instance.
                    /// </summary>
                    [NameInMap("Ipv6AddressCount")]
                    [Validation(Required=false)]
                    public int? Ipv6AddressCount { get; set; }

                    /// <summary>
                    /// The name of the key pair.
                    /// </summary>
                    [NameInMap("KeyPairName")]
                    [Validation(Required=false)]
                    public string KeyPairName { get; set; }

                    /// <summary>
                    /// Details about the secondary elastic network interfaces (ENIs).
                    /// </summary>
                    [NameInMap("NetworkInterfaces")]
                    [Validation(Required=false)]
                    public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataNetworkInterfaces NetworkInterfaces { get; set; }
                    public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataNetworkInterfaces : TeaModel {
                        [NameInMap("NetworkInterface")]
                        [Validation(Required=false)]
                        public List<DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataNetworkInterfacesNetworkInterface> NetworkInterface { get; set; }
                        public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataNetworkInterfacesNetworkInterface : TeaModel {
                            /// <summary>
                            /// The description of the secondary ENI.
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
                            /// The name of the secondary ENI.
                            /// </summary>
                            [NameInMap("NetworkInterfaceName")]
                            [Validation(Required=false)]
                            public string NetworkInterfaceName { get; set; }

                            /// <summary>
                            /// The communication mode of the primary ENI. Valid values:
                            /// 
                            /// *   Standard: uses the TCP communication mode.
                            /// *   HighPerformance: uses the remote direct memory access (RDMA) communication mode with Elastic RDMA Interface (ERI) enabled.
                            /// </summary>
                            [NameInMap("NetworkInterfaceTrafficMode")]
                            [Validation(Required=false)]
                            public string NetworkInterfaceTrafficMode { get; set; }

                            /// <summary>
                            /// The primary private IP address of the secondary ENI.
                            /// </summary>
                            [NameInMap("PrimaryIpAddress")]
                            [Validation(Required=false)]
                            public string PrimaryIpAddress { get; set; }

                            /// <summary>
                            /// The ID of the security group to which to assign the secondary ENI. The security group and the ENI must belong to the same VPC.
                            /// 
                            /// >  SecurityGroupId and SecurityGroupIds are mutually exclusive in the response.
                            /// </summary>
                            [NameInMap("SecurityGroupId")]
                            [Validation(Required=false)]
                            public string SecurityGroupId { get; set; }

                            /// <summary>
                            /// The IDs of the security groups to which to assign the secondary ENI.
                            /// 
                            /// >  SecurityGroupId and SecurityGroupIds are mutually exclusive in the response.
                            /// </summary>
                            [NameInMap("SecurityGroupIds")]
                            [Validation(Required=false)]
                            public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataNetworkInterfacesNetworkInterfaceSecurityGroupIds SecurityGroupIds { get; set; }
                            public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataNetworkInterfacesNetworkInterfaceSecurityGroupIds : TeaModel {
                                [NameInMap("SecurityGroupId")]
                                [Validation(Required=false)]
                                public List<string> SecurityGroupId { get; set; }

                            }

                            /// <summary>
                            /// The ID of the vSwitch to which to connect the ENI.
                            /// </summary>
                            [NameInMap("VSwitchId")]
                            [Validation(Required=false)]
                            public string VSwitchId { get; set; }

                        }

                    }

                    /// <summary>
                    /// The network type. Valid values:
                    /// 
                    /// *   classic: classic network
                    /// *   vpc: VPC
                    /// </summary>
                    [NameInMap("NetworkType")]
                    [Validation(Required=false)]
                    public string NetworkType { get; set; }

                    /// <summary>
                    /// Indicates whether the username and password preset in the image are used.
                    /// </summary>
                    [NameInMap("PasswordInherit")]
                    [Validation(Required=false)]
                    public bool? PasswordInherit { get; set; }

                    /// <summary>
                    /// The subscription duration of the instance.
                    /// </summary>
                    [NameInMap("Period")]
                    [Validation(Required=false)]
                    public int? Period { get; set; }

                    /// <summary>
                    /// The unit of the subscription period. Valid values:
                    /// 
                    /// Month (default)
                    /// </summary>
                    [NameInMap("PeriodUnit")]
                    [Validation(Required=false)]
                    public string PeriodUnit { get; set; }

                    /// <summary>
                    /// The private IP address to assign to the instance.
                    /// </summary>
                    [NameInMap("PrivateIpAddress")]
                    [Validation(Required=false)]
                    public string PrivateIpAddress { get; set; }

                    /// <summary>
                    /// The name of the instance Resource Access Management (RAM) role.
                    /// </summary>
                    [NameInMap("RamRoleName")]
                    [Validation(Required=false)]
                    public string RamRoleName { get; set; }

                    /// <summary>
                    /// The ID of the resource group to which the launch template belongs.
                    /// </summary>
                    [NameInMap("ResourceGroupId")]
                    [Validation(Required=false)]
                    public string ResourceGroupId { get; set; }

                    /// <summary>
                    /// Indicates whether Security Hardening is enabled.
                    /// </summary>
                    [NameInMap("SecurityEnhancementStrategy")]
                    [Validation(Required=false)]
                    public string SecurityEnhancementStrategy { get; set; }

                    /// <summary>
                    /// The ID of the security group to which to assign the instance.
                    /// 
                    /// >  `SecurityGroupId` and `SecurityGroupIds` are mutually exclusive in the response.
                    /// </summary>
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// The IDs of the security groups to which to assign the instance.
                    /// 
                    /// >  `SecurityGroupId` and `SecurityGroupIds` are mutually exclusive in the response.
                    /// </summary>
                    [NameInMap("SecurityGroupIds")]
                    [Validation(Required=false)]
                    public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataSecurityGroupIds SecurityGroupIds { get; set; }
                    public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataSecurityGroupIds : TeaModel {
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public List<string> SecurityGroupId { get; set; }

                    }

                    /// <summary>
                    /// The protection period of the preemptible instance. Unit: hours. Valid values:
                    /// 
                    /// *   1: After a preemptible instance is created, Alibaba Cloud ensures that the instance is not automatically released within 1 hour. After the 1-hour protection period ends, the system compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.
                    /// *   0: After a preemptible instance is created, Alibaba Cloud does not ensure that the instance runs for 1 hour. The system compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.
                    /// 
                    /// Alibaba Cloud sends an ECS system event to notify you 5 minutes before the instance is released. Preemptible instances are billed by second. We recommend that you specify a protection period based on your business requirements.
                    /// 
                    /// >  This parameter is returned when SpotStrategy is set to SpotWithPriceLimit or SpotAsPriceGo.
                    /// </summary>
                    [NameInMap("SpotDuration")]
                    [Validation(Required=false)]
                    public int? SpotDuration { get; set; }

                    /// <summary>
                    /// The maximum hourly price of the preemptible instance.
                    /// </summary>
                    [NameInMap("SpotPriceLimit")]
                    [Validation(Required=false)]
                    public float? SpotPriceLimit { get; set; }

                    /// <summary>
                    /// The bidding policy for the pay-as-you-go instance. Valid values:
                    /// 
                    /// *   NoSpot: The instance is a regular pay-as-you-go instance.
                    /// *   SpotWithPriceLimit: The instance is a preemptible instance with a user-defined maximum hourly price.
                    /// *   SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is automatically used as the bid price. The market price can be up to the pay-as-you-go price.
                    /// </summary>
                    [NameInMap("SpotStrategy")]
                    [Validation(Required=false)]
                    public string SpotStrategy { get; set; }

                    /// <summary>
                    /// The tags to add to the instance.
                    /// </summary>
                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataTags Tags { get; set; }
                    public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataTags : TeaModel {
                        [NameInMap("InstanceTag")]
                        [Validation(Required=false)]
                        public List<DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataTagsInstanceTag> InstanceTag { get; set; }
                        public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataTagsInstanceTag : TeaModel {
                            /// <summary>
                            /// The key of the tag to add to the instance.
                            /// </summary>
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            /// <summary>
                            /// The value of the tag to add to the instance.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// The user data of the instance, which is Base64-encoded.
                    /// </summary>
                    [NameInMap("UserData")]
                    [Validation(Required=false)]
                    public string UserData { get; set; }

                    /// <summary>
                    /// The ID of the vSwitch to which to connect the instance.
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
                    /// The zone ID of the instance.
                    /// </summary>
                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

                /// <summary>
                /// The ID of the launch template.
                /// </summary>
                [NameInMap("LaunchTemplateId")]
                [Validation(Required=false)]
                public string LaunchTemplateId { get; set; }

                /// <summary>
                /// The name of the launch template.
                /// </summary>
                [NameInMap("LaunchTemplateName")]
                [Validation(Required=false)]
                public string LaunchTemplateName { get; set; }

                /// <summary>
                /// The time when the launch template version was modified.
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// The description of the launch template version.
                /// </summary>
                [NameInMap("VersionDescription")]
                [Validation(Required=false)]
                public string VersionDescription { get; set; }

                /// <summary>
                /// The number of the launch template version.
                /// </summary>
                [NameInMap("VersionNumber")]
                [Validation(Required=false)]
                public long? VersionNumber { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of launch templates.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

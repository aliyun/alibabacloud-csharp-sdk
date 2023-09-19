// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingConfigurationsResponseBody : TeaModel {
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
        /// Details of the scaling configurations.
        /// </summary>
        [NameInMap("ScalingConfigurations")]
        [Validation(Required=false)]
        public List<DescribeScalingConfigurationsResponseBodyScalingConfigurations> ScalingConfigurations { get; set; }
        public class DescribeScalingConfigurationsResponseBodyScalingConfigurations : TeaModel {
            /// <summary>
            /// Indicates whether the instance on the dedicated host is associated with the dedicated host. Valid values:
            /// 
            /// *   default: The instance is not associated with the dedicated host. If you start an instance that was stopped in Economical Mode and the original dedicated host has insufficient resources, the instance is automatically deployed to another dedicated host in the automatic deployment resource pool.
            /// *   host: The instance is associated with the dedicated host. If you start an instance that was stopped in Economical Mode, the instance remains on the original dedicated host. If the original dedicated host has insufficient resources, the instance cannot be started.
            /// </summary>
            [NameInMap("Affinity")]
            [Validation(Required=false)]
            public string Affinity { get; set; }

            /// <summary>
            /// The number of vCPUs.
            /// 
            /// You can specify the number of vCPUs and the memory size to determine the range of instance types. For example, you can set the Cpu parameter to 2 and the Memory parameter to 16 to specify the instance types that have 2 vCPUs and 16 GiB of memory. If you specify the Cpu and Memory parameters, Auto Scaling determines the available instance types based on factors such as I/O optimization requirements and zones. Then, Auto Scaling preferentially creates instances of the instance type that is provided at the lowest price.
            /// 
            /// > You can specify CPU and memory specifications to determine the range of instance types only if the Scaling Policy parameter is set to Cost Optimization Policy and no instance type is specified in the scaling configuration.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// The time when the scaling configuration was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The performance mode of the burstable instance. Valid values:
            /// 
            /// *   Standard: standard mode. For more information, see the "Standard mode" section in the [Burstable instances](~~59977~~) topic.
            /// *   Unlimited: unlimited mode. For more information, see the "Unlimited mode" section in the [Burstable instances](~~59977~~) topic.
            /// </summary>
            [NameInMap("CreditSpecification")]
            [Validation(Required=false)]
            public string CreditSpecification { get; set; }

            /// <summary>
            /// Details of the data disks.
            /// </summary>
            [NameInMap("DataDisks")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsDataDisks> DataDisks { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsDataDisks : TeaModel {
                /// <summary>
                /// The ID of the automatic snapshot policy that is applied to the data disk.
                /// </summary>
                [NameInMap("AutoSnapshotPolicyId")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyId { get; set; }

                /// <summary>
                /// Indicates whether the burst feature is enabled for the data disk. Valid values:
                /// 
                /// *   true
                /// *   false
                /// 
                /// > This parameter is available only if you set the `DataDisk.Category` parameter to `cloud_auto`.
                /// 
                /// For more information, see the [ESSD AutoPL disks](~~368372~~) topic.
                /// </summary>
                [NameInMap("BurstingEnabled")]
                [Validation(Required=false)]
                public bool? BurstingEnabled { get; set; }

                /// <summary>
                /// The categories of the data disks. The values are sorted based on their priorities. The first value has the highest priority. If Auto Scaling cannot create instances by using the disk that has the highest priority, Auto Scaling creates instances by using the disk that has the next highest priority. Valid values:
                /// 
                /// *   cloud: basic disk. The DeleteWithInstance parameter of a basic disk that is created together with the instance is set to true.
                /// *   cloud_efficiency: ultra disk.
                /// *   cloud_ssd: standard SSD.
                /// *   cloud_essd: ESSD.
                /// </summary>
                [NameInMap("Categories")]
                [Validation(Required=false)]
                public List<string> Categories { get; set; }

                /// <summary>
                /// The category of the data disk. Valid values:
                /// 
                /// *   cloud: basic disk. The DeleteWithInstance parameter of a basic disk that is created together with the instance is set to true.
                /// *   cloud_efficiency: ultra disk.
                /// *   cloud_ssd: standard SSD.
                /// *   ephemeral_ssd: local standard SSD.
                /// *   cloud_essd: ESSD.
                /// *   cloud_auto: ESSD AutoPL disk.
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// Indicates whether the data disk is released if the instance to which the data disk is attached is released. Valid values:
                /// 
                /// *   true
                /// *   false
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
                /// The mount target of the data disk.
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
                /// Indicates whether the data disk is encrypted. Valid values:
                /// 
                /// *   true
                /// *   false
                /// 
                /// Default value: false.
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public string Encrypted { get; set; }

                /// <summary>
                /// The ID of the Key Management Service (KMS) key that is used to encrypt the data disk.
                /// </summary>
                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                /// <summary>
                /// The PL of the data disk of the ESSD category.
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// The provisioned input/output operations per second (IOPS) for the data disk.
                /// 
                /// > IOPS measures the number of read and write operations that an Elastic Block Storage (EBS) device can process per second.
                /// </summary>
                [NameInMap("ProvisionedIops")]
                [Validation(Required=false)]
                public long? ProvisionedIops { get; set; }

                /// <summary>
                /// The size of the data disk. Unit: GiB.
                /// 
                /// *   Valid values if you set the Category parameter to cloud: 5 to 2000.
                /// *   Valid values if you set the Category parameter to cloud_efficiency: 20 to 32768.
                /// *   Valid values if you set the Category parameter to cloud_ssd: 20 to 32768.
                /// *   Valid values if you set the Category parameter to cloud_essd: 20 to 32768.
                /// *   Valid values if you set the Category parameter to ephemeral_ssd: 5 to 800.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// The ID of the snapshot that is used to create the data disk.
                /// </summary>
                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

            }

            /// <summary>
            /// The ID of the dedicated host on which the ECS instance is created. Preemptible instances cannot be created on dedicated hosts. If you specify the DedicatedHostId parameter, the SpotStrategy and SpotPriceLimit parameters are ignored.
            /// 
            /// You can call the DescribeDedicatedHosts operation to query dedicated host IDs.
            /// </summary>
            [NameInMap("DedicatedHostId")]
            [Validation(Required=false)]
            public string DedicatedHostId { get; set; }

            [NameInMap("DeletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// The ID of the deployment set to which the Elastic Compute Service (ECS) instance belongs.
            /// </summary>
            [NameInMap("DeploymentSetId")]
            [Validation(Required=false)]
            public string DeploymentSetId { get; set; }

            /// <summary>
            /// The hostname of the ECS instance.
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// The ID of the Elastic High Performance Computing (E-HPC) cluster to which the ECS instance belongs.
            /// </summary>
            [NameInMap("HpcClusterId")]
            [Validation(Required=false)]
            public string HpcClusterId { get; set; }

            /// <summary>
            /// The name of the image family. If you specify this parameter, the latest custom images that are available in the specified image family are returned. You can use the images to create instances. If the ImageId parameter is specified, you cannot specify the ImageFamily parameter.
            /// </summary>
            [NameInMap("ImageFamily")]
            [Validation(Required=false)]
            public string ImageFamily { get; set; }

            /// <summary>
            /// The ID of the image that is used by Auto Scaling to create instances.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The name of the image file.
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// ECS实例是否使用ecs-user用户登录。可能值：
            /// 
            /// - true：是。
            /// - false：否。
            /// </summary>
            [NameInMap("ImageOptionsLoginAsNonRoot")]
            [Validation(Required=false)]
            public bool? ImageOptionsLoginAsNonRoot { get; set; }

            /// <summary>
            /// The source of the image. Valid values:
            /// 
            /// *   system: public images provided by Alibaba Cloud
            /// *   self: custom images that you create
            /// *   others: shared images from other Alibaba Cloud accounts or community images published by other Alibaba Cloud accounts
            /// *   marketplace: images that are available in Alibaba Cloud Marketplace
            /// </summary>
            [NameInMap("ImageOwnerAlias")]
            [Validation(Required=false)]
            public string ImageOwnerAlias { get; set; }

            /// <summary>
            /// The description of the ECS instance.
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// The generation of the ECS instance.
            /// </summary>
            [NameInMap("InstanceGeneration")]
            [Validation(Required=false)]
            public string InstanceGeneration { get; set; }

            /// <summary>
            /// The name of the ECS instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// Details of the intelligent configuration settings, which determines the range of instance types that meet the specified criteria.
            /// </summary>
            [NameInMap("InstancePatternInfos")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsInstancePatternInfos> InstancePatternInfos { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsInstancePatternInfos : TeaModel {
                /// <summary>
                /// The architectures of the instance types. Valid values:
                /// 
                /// *   X86: x86 architecture.
                /// *   Heterogeneous: heterogeneous architecture, such as GPUs and FPGAs.
                /// *   BareMetal: ECS Bare Metal Instance architecture.
                /// *   Arm: ARM architecture.
                /// *   SuperComputeCluster: Super Computing Cluster architecture.
                /// </summary>
                [NameInMap("Architectures")]
                [Validation(Required=false)]
                public List<string> Architectures { get; set; }

                /// <summary>
                /// Indicates whether burstable instance types are included. Valid values:
                /// 
                /// *   Exclude: Burstable instance types are not included.
                /// *   Include: Burstable instance types are included.
                /// *   Required: Only burstable instance types are included.
                /// </summary>
                [NameInMap("BurstablePerformance")]
                [Validation(Required=false)]
                public string BurstablePerformance { get; set; }

                /// <summary>
                /// The number of vCPUs of the instance type.
                /// </summary>
                [NameInMap("Cores")]
                [Validation(Required=false)]
                public int? Cores { get; set; }

                /// <summary>
                /// The instance types that are excluded. You can use wildcard characters such as an asterisk (\*) to exclude an instance type or an instance family. Examples:
                /// 
                /// *   ecs.c6.large: The ecs.c6.large instance type is excluded.
                /// *   ecs.c6.\*: The c6 instance family is excluded.
                /// </summary>
                [NameInMap("ExcludedInstanceTypes")]
                [Validation(Required=false)]
                public List<string> ExcludedInstanceTypes { get; set; }

                /// <summary>
                /// The level of the instance family.
                /// 
                /// *   EntryLevel: shared instance type. Instances of this level are cost-effective, but do not provide stable computing performance. Instances of this level are suitable for scenarios in which the CPU utilization is low. For more information, see [Shared instance families](~~108489~~).
                /// *   EnterpriseLevel: Instances of this level provide stable performance and dedicated resources, and are suitable for scenarios in which high stability is required. For more information, see [Overview of instance families](~~25378~~).
                /// *   CreditEntryLevel: This value is available only for burstable instances. CPU credits are used to ensure computing performance. Instances of this level are suitable for scenarios in which the CPU utilization is low but may fluctuate in specific cases. For more information, see [Overview](~~59977~~) of burstable instances
                /// </summary>
                [NameInMap("InstanceFamilyLevel")]
                [Validation(Required=false)]
                public string InstanceFamilyLevel { get; set; }

                /// <summary>
                /// The maximum hourly price for pay-as-you-go instances or preemptible instances.
                /// </summary>
                [NameInMap("MaxPrice")]
                [Validation(Required=false)]
                public float? MaxPrice { get; set; }

                /// <summary>
                /// The memory size of the instance type. Unit: GiB.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

            }

            /// <summary>
            /// The instance type of the ECS instance.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// Details of the ECS instance types.
            /// </summary>
            [NameInMap("InstanceTypes")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// The billing method for network usage. Valid values:
            /// 
            /// *   PayByBandwidth: You are charged for the maximum available bandwidth that is specified by the InternetMaxBandwidthOut parameter.
            /// *   PayByTraffic: You are charged for the actual data transfer. The InternetMaxBandwidthOut parameter specifies only the maximum available bandwidth.
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// The maximum inbound public bandwidth. Unit: Mbit/s. Valid values: 1 to 200.
            /// </summary>
            [NameInMap("InternetMaxBandwidthIn")]
            [Validation(Required=false)]
            public int? InternetMaxBandwidthIn { get; set; }

            /// <summary>
            /// The maximum outbound public bandwidth. Unit: Mbit/s. Valid values:
            /// 
            /// *   0 to 100 if you set the InternetChargeType parameter to PayByBandwidth. If you leave this parameter empty, this parameter is automatically set to 0.
            /// *   0 to 100 if you set the InternetChargeType parameter to PayByTraffic. If you leave this parameter empty, an error is reported.
            /// </summary>
            [NameInMap("InternetMaxBandwidthOut")]
            [Validation(Required=false)]
            public int? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// Indicates whether the instance is I/O optimized. Valid values:
            /// 
            /// *   none: The instance is not I/O optimized.
            /// *   optimized: The instance is I/O optimized.
            /// </summary>
            [NameInMap("IoOptimized")]
            [Validation(Required=false)]
            public string IoOptimized { get; set; }

            /// <summary>
            /// The number of randomly generated IPv6 addresses that are allocated to the elastic network interface (ENI).
            /// </summary>
            [NameInMap("Ipv6AddressCount")]
            [Validation(Required=false)]
            public int? Ipv6AddressCount { get; set; }

            /// <summary>
            /// The name of the key pair that is used to log on to the ECS instance.
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// The status of the scaling configuration in the scaling group. Valid values:
            /// 
            /// *   Active: The scaling configuration is active in the scaling group. Auto Scaling uses the active scaling configuration to automatically create ECS instances.
            /// *   Inactive: The scaling configuration is inactive in the scaling group. Auto Scaling does not use inactive scaling configurations to automatically create ECS instances. Inactive scaling configurations are retained in the scaling group.
            /// </summary>
            [NameInMap("LifecycleState")]
            [Validation(Required=false)]
            public string LifecycleState { get; set; }

            /// <summary>
            /// The weight of the ECS instance as a backend server. Valid values: 1 to 100.
            /// </summary>
            [NameInMap("LoadBalancerWeight")]
            [Validation(Required=false)]
            public int? LoadBalancerWeight { get; set; }

            /// <summary>
            /// The memory size. Unit: GiB.
            /// 
            /// You can specify the number of vCPUs and the memory size to determine the range of instance types. For example, you can set the Cpu parameter to 2 and the Memory parameter to 16 to specify the instance types that have 2 vCPUs and 16 GiB of memory. If you specify the Cpu and Memory parameters, Auto Scaling determines the available instance types based on factors such as I/O optimization requirements and zones. Then, Auto Scaling preferentially creates instances of the instance type that is provided at the lowest price.
            /// 
            /// > You can specify CPU and memory specifications to determine the range of instance types only if the Scaling Policy parameter is set to Cost Optimization Policy and no instance type is specified in the scaling configuration.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// Indicates whether the password preconfigured in the image is used.
            /// </summary>
            [NameInMap("PasswordInherit")]
            [Validation(Required=false)]
            public bool? PasswordInherit { get; set; }

            [NameInMap("PrivatePoolOptions.Id")]
            [Validation(Required=false)]
            public string PrivatePoolOptions_id { get; set; }

            [NameInMap("PrivatePoolOptions.MatchCriteria")]
            [Validation(Required=false)]
            public string PrivatePoolOptions_matchCriteria { get; set; }

            /// <summary>
            /// The name of the RAM role that is associated with the ECS instance. The name is provided and maintained by Resource Access Management (RAM). You can call the ListRoles operation to query the available RAM roles.
            /// </summary>
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// The ID of the resource group to which the ECS instance belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The ID of the scaling configuration.
            /// </summary>
            [NameInMap("ScalingConfigurationId")]
            [Validation(Required=false)]
            public string ScalingConfigurationId { get; set; }

            /// <summary>
            /// The name of the scaling configuration.
            /// </summary>
            [NameInMap("ScalingConfigurationName")]
            [Validation(Required=false)]
            public string ScalingConfigurationName { get; set; }

            /// <summary>
            /// The ID of the scaling group to which the scaling configuration belongs.
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// > This parameter is in invitational preview and is unavailable.
            /// </summary>
            [NameInMap("SchedulerOptions")]
            [Validation(Required=false)]
            public DescribeScalingConfigurationsResponseBodyScalingConfigurationsSchedulerOptions SchedulerOptions { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsSchedulerOptions : TeaModel {
                /// <summary>
                /// > This parameter is in invitational preview and is unavailable.
                /// </summary>
                [NameInMap("ManagedPrivateSpaceId")]
                [Validation(Required=false)]
                public string ManagedPrivateSpaceId { get; set; }

            }

            /// <summary>
            /// Indicates whether security hardening is enabled. Valid values:
            /// 
            /// *   Active: Security hardening is enabled. This value is available only to public images.
            /// *   Deactive: Security hardening is disabled. This value is available to all types of images.
            /// </summary>
            [NameInMap("SecurityEnhancementStrategy")]
            [Validation(Required=false)]
            public string SecurityEnhancementStrategy { get; set; }

            /// <summary>
            /// The ID of the security group with which the ECS instance is associated. ECS instances that are associated with the same security group can access each other.
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The IDs of the security groups with which the ECS instance is associated. ECS instances that are associated with the same security group can access each other.
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// The protection period of the preemptible instance. Unit: hours.
            /// </summary>
            [NameInMap("SpotDuration")]
            [Validation(Required=false)]
            public int? SpotDuration { get; set; }

            /// <summary>
            /// The interruption mode of the preemptible instance.
            /// </summary>
            [NameInMap("SpotInterruptionBehavior")]
            [Validation(Required=false)]
            public string SpotInterruptionBehavior { get; set; }

            /// <summary>
            /// Details of the preemptible instances.
            /// </summary>
            [NameInMap("SpotPriceLimits")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsSpotPriceLimits> SpotPriceLimits { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsSpotPriceLimits : TeaModel {
                /// <summary>
                /// The instance type of the preemptible instance.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The price limit of the preemptible instance.
                /// </summary>
                [NameInMap("PriceLimit")]
                [Validation(Required=false)]
                public float? PriceLimit { get; set; }

            }

            /// <summary>
            /// The preemption policy that is applied to pay-as-you-go instances and preemptible instances. Valid values:
            /// 
            /// *   NoSpot: The instance is created as a pay-as-you-go instance.
            /// *   SpotWithPriceLimit: The instance is a preemptible instance that has a user-defined maximum hourly price.
            /// *   SpotAsPriceGo: The instance is created as a preemptible instance for which the market price at the time of purchase is automatically used as the bid price.
            /// </summary>
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// The ID of the automatic snapshot policy that is applied to the system disk.
            /// </summary>
            [NameInMap("SystemDiskAutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string SystemDiskAutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// Indicates whether the burst feature is enabled for the system disk. Valid values:
            /// 
            /// *   true
            /// *   false
            /// 
            /// > This parameter is available only if you set the SystemDisk.Category parameter to cloud_auto.
            /// </summary>
            [NameInMap("SystemDiskBurstingEnabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// The categories of the system disks. The values are sorted based on their priorities. The first value has the highest priority. If Auto Scaling cannot create instances by using the disk that has the highest priority, Auto Scaling creates instances by using the disk that has the next highest priority. Valid values:
            /// 
            /// *   cloud: basic disk
            /// *   cloud_efficiency: ultra disk
            /// *   cloud_ssd: standard SSD
            /// *   cloud_essd: ESSD
            /// </summary>
            [NameInMap("SystemDiskCategories")]
            [Validation(Required=false)]
            public List<string> SystemDiskCategories { get; set; }

            /// <summary>
            /// The category of the system disk. Valid values:
            /// 
            /// *   cloud: basic disk
            /// *   cloud_efficiency: ultra disk
            /// *   cloud_ssd: standard SSD
            /// *   ephemeral_ssd: local standard SSD
            /// *   cloud_essd: enhanced SSD (ESSD)
            /// *   cloud_auto: ESSD AutoPL disk
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// The description of the system disk.
            /// </summary>
            [NameInMap("SystemDiskDescription")]
            [Validation(Required=false)]
            public string SystemDiskDescription { get; set; }

            /// <summary>
            /// The algorithm that is used to encrypt the system disk. Valid values:
            /// 
            /// *   AES-256
            /// *   SM4-128
            /// </summary>
            [NameInMap("SystemDiskEncryptAlgorithm")]
            [Validation(Required=false)]
            public string SystemDiskEncryptAlgorithm { get; set; }

            /// <summary>
            /// Indicates whether the system disk is encrypted. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("SystemDiskEncrypted")]
            [Validation(Required=false)]
            public bool? SystemDiskEncrypted { get; set; }

            /// <summary>
            /// The ID of the KMS key that is used to encrypt the system disk.
            /// </summary>
            [NameInMap("SystemDiskKMSKeyId")]
            [Validation(Required=false)]
            public string SystemDiskKMSKeyId { get; set; }

            /// <summary>
            /// The name of the system disk.
            /// </summary>
            [NameInMap("SystemDiskName")]
            [Validation(Required=false)]
            public string SystemDiskName { get; set; }

            /// <summary>
            /// The performance level (PL) of the system disk of the ESSD category.
            /// </summary>
            [NameInMap("SystemDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// The provisioned IOPS for the system disk.
            /// 
            /// > IOPS measures the number of read and write operations that an EBS device can process per second.
            /// </summary>
            [NameInMap("SystemDiskProvisionedIops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// The size of the system disk. Unit: GiB.
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// Details of the tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsTags> Tags { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsTags : TeaModel {
                /// <summary>
                /// The key of tag N. Valid values of N: 1 to 20.
                /// 
                /// The tag key cannot be an empty string. The tag key can be up to 128 characters in length, and cannot start with `acs:` or `aliyun`. The tag key cannot contain `http://` or `https://`.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of tag N. Valid values of N: 1 to 20.
                /// 
                /// The tag value can be an empty string. The tag value can be up to 128 characters in length, and cannot start with `acs:`. The tag value cannot contain `http://` or `https://`.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// Indicates whether the instance is created on a dedicated host. Valid values:
            /// 
            /// *   default: The instance is created on a non-dedicated host.
            /// *   host: The instance is created on a dedicated host. If you do not specify the DedicatedHostId parameter, Alibaba Cloud selects a dedicated host for the instance.
            /// 
            /// Default value: default.
            /// </summary>
            [NameInMap("Tenancy")]
            [Validation(Required=false)]
            public string Tenancy { get; set; }

            /// <summary>
            /// The user data of the ECS instance.
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// The weight of the instance type. The weight of an instance type indicates the capacity of an instance of the specified instance type in the scaling group. A higher weight indicates that a smaller number of instances of the specified instance type are required to meet the expected capacity requirement.
            /// </summary>
            [NameInMap("WeightedCapacities")]
            [Validation(Required=false)]
            public List<int?> WeightedCapacities { get; set; }

            /// <summary>
            /// The zone ID of the ECS instance. You can call the DescribeZones operation to query the most recent zone list.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// The total number of scaling configurations.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

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
        /// The scaling configurations.
        /// </summary>
        [NameInMap("ScalingConfigurations")]
        [Validation(Required=false)]
        public List<DescribeScalingConfigurationsResponseBodyScalingConfigurations> ScalingConfigurations { get; set; }
        public class DescribeScalingConfigurationsResponseBodyScalingConfigurations : TeaModel {
            /// <summary>
            /// Indicates whether the ECS instance on a dedicated host is associated with the dedicated host. Valid values:
            /// 
            /// *   default: The instance is not associated with the dedicated host. If you restart an instance that was stopped in Economical Mode and the original dedicated host of the instance has insufficient resources, the instance is automatically deployed to another dedicated host in the automatic deployment resource pool.
            /// *   host: The instance is associated with the dedicated host. If you restart an instance that was stopped in Economical Mode, the instance remains on the original dedicated host. If the available resources of the original dedicated host are insufficient, the instance cannot be restarted.
            /// </summary>
            [NameInMap("Affinity")]
            [Validation(Required=false)]
            public string Affinity { get; set; }

            /// <summary>
            /// The number of vCPUs.
            /// 
            /// You can specify CPU and Memory to define the range of instance types. For example, if you set CPU to 2 and Memory to 16, the instance types that have 2 vCPUs and 16 GiB are returned. If you specify CPU and Memory, Auto Scaling determines the available instance types based on factors such as I/O optimization requirements and zones and preferentially creates instances by using the lowest-priced instance type.
            /// 
            /// >  You can specify CPU and Memory to define instance types only when you set Scaling Policy to Cost Optimization and no instance type is specified in the scaling configuration.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// The time at which the scaling configuration was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The performance mode of the burstable instances. Valid values:
            /// 
            /// *   Standard: the standard mode. For more information, see the "Standard mode" section in the [Overview of burstable instances](https://help.aliyun.com/document_detail/59977.html) topic.
            /// *   Unlimited: the unlimited mode. For more information, see the "Unlimited mode" section in [Overview of burstable instances](https://help.aliyun.com/document_detail/59977.html).
            /// </summary>
            [NameInMap("CreditSpecification")]
            [Validation(Required=false)]
            public string CreditSpecification { get; set; }

            /// <summary>
            /// The priority of the custom ECS instance type + vSwitch combination.
            /// 
            /// >  This parameter takes effect only when Scaling Policy of the scaling group is set to Priority Policy.
            /// 
            /// If Auto Scaling cannot create ECS instances by using the custom ECS instance type + vSwitch combination of the highest priority, Auto Scaling creates ECS instances by using the custom ECS instance type + vSwitch combination of the next highest priority.
            /// 
            /// >  If you specify the priorities of only a portion of custom ECS instance type + vSwitch combinations, Auto Scaling preferentially creates ECS instances by using the custom combinations that have specified priorities. If the custom combinations that have specified priorities do not provide sufficient resources, Auto Scaling creates ECS instances by using the custom combinations that do not have specified priorities based on the specified orders of vSwitches and instance types.
            /// 
            /// *   Example: the specified order of vSwitches for your scaling group is vsw1 and vsw2 and the specified order of instance types in your scaling configuration is type1 and type 2. In addition, you use CustomPriorities to specify ["vsw2+type2", "vsw1+type2"]. In this example, the vsw2+type2 combination has the highest priority and the vsw2+type1 combination has the lowest priority. The vsw1+type2 combination has a higher priority than the vsw1+type1 combination.
            /// </summary>
            [NameInMap("CustomPriorities")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsCustomPriorities> CustomPriorities { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsCustomPriorities : TeaModel {
                /// <summary>
                /// The ECS instance type.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The vSwitch ID.
                /// </summary>
                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

            /// <summary>
            /// The data disks.
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
                /// Indicates whether the Performance Burst feature is enabled for the data disk. Valid values:
                /// 
                /// *   true
                /// *   false
                /// 
                /// >  This parameter is available only when you set `DataDisk.Category` to `cloud_auto`.
                /// </summary>
                [NameInMap("BurstingEnabled")]
                [Validation(Required=false)]
                public bool? BurstingEnabled { get; set; }

                /// <summary>
                /// The categories of the data disks. The values are sorted based on their priorities. The first value has the highest priority. If Auto Scaling cannot create instances by using the disk category of the highest priority, Auto Scaling creates instances by using the disk category of the next highest priority. Valid values:
                /// 
                /// *   cloud: basic disk. DeleteWithInstance of a basic disk created along with the ECS instance is set to true.
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
                /// *   cloud: basic disk. DeleteWithInstance of a basic disk created along with the ECS instance is set to true.
                /// *   cloud_efficiency: ultra disk.
                /// *   cloud_ssd: standard SSD.
                /// *   ephemeral_ssd: local SSD.
                /// *   cloud_essd: ESSD.
                /// *   cloud_auto: ESSD AutoPL.
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// Indicates whether the data disk is released when the instance to which the data disk is attached is released. Valid values:
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
                /// The ID of the Key Management Service (KMS) key that is applied to the data disk.
                /// </summary>
                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                /// <summary>
                /// The PL of the data disk that is an ESSD.
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// The provisioned IOPS of the data disk.
                /// 
                /// >  IOPS measures the number of read and write operations that an Elastic Block Storage (EBS) device can process per second.
                /// </summary>
                [NameInMap("ProvisionedIops")]
                [Validation(Required=false)]
                public long? ProvisionedIops { get; set; }

                /// <summary>
                /// The size of the data disk. Unit: GB. Valid values:
                /// 
                /// *   5 to 2000 if you set Category to cloud.
                /// *   20 to 32768 if you set Category to cloud_efficiency.
                /// *   20 to 32768 if you set Category to cloud_ssd.
                /// *   20 to 32768 if you set Category to cloud_essd.
                /// *   5 to 800 if you set Category to ephemeral_ssd.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// The ID of the snapshot based on which the data disk is created.
                /// </summary>
                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

            }

            /// <summary>
            /// The ID of the dedicated host cluster.
            /// </summary>
            [NameInMap("DedicatedHostClusterId")]
            [Validation(Required=false)]
            public string DedicatedHostClusterId { get; set; }

            /// <summary>
            /// The ID of the dedicated host on which the ECS instance is created. Preemptible instances are not supported by dedicated hosts. Therefore, if you specify DedicatedHostId, SpotStrategy and SpotPriceLimit are ignored.
            /// 
            /// You can call the DescribeDedicatedHosts operation to query the IDs of dedicated hosts.
            /// </summary>
            [NameInMap("DedicatedHostId")]
            [Validation(Required=false)]
            public string DedicatedHostId { get; set; }

            /// <summary>
            /// Indicates whether Release Protection is enabled for the ECS instances. You can specify this parameter to determine whether the ECS instances can be deleted by using the ECS console or calling the DeleteInstance operation. Valid values:
            /// 
            /// *   true: Release Protection is enabled for the ECS instances. You cannot delete the ECS instances by using the ECS console or calling the DeleteInstance operation.
            /// *   false: Release Protection is disabled for the ECS instances. You can delete the ECS instances by using the ECS console or calling the DeleteInstance operation.
            /// 
            /// >  You can enable Release Protection for only pay-as-you-go instances to prevent unexpected instance deletion during scale-in events. The Release Protection feature does not affect normal scaling activities. In other words, an instance that meets the criteria of scale-in policies may be removed from a scaling group during a scale-in event even if you enabled Release Protection for the instance.
            /// </summary>
            [NameInMap("DeletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// The ID of the deployment set to which the Elastic Compute Service (ECS) instances belong.
            /// </summary>
            [NameInMap("DeploymentSetId")]
            [Validation(Required=false)]
            public string DeploymentSetId { get; set; }

            /// <summary>
            /// The hostname series of the ECS instances.
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// The ID of the High Performance Computing (HPC) cluster to which the ECS instances belong.
            /// </summary>
            [NameInMap("HpcClusterId")]
            [Validation(Required=false)]
            public string HpcClusterId { get; set; }

            /// <summary>
            /// The name of the image family. You can specify this parameter to obtain the latest available images in the current image family for instance creation. If you specify ImageId, you cannot specify `ImageFamily`.
            /// </summary>
            [NameInMap("ImageFamily")]
            [Validation(Required=false)]
            public string ImageFamily { get; set; }

            /// <summary>
            /// The ID of the image file that provides the image resource for Auto Scaling to create ECS instances.
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
            /// Indicates whether the ecs-user username can be used to log on to an ECS instance created from the scaling configuration. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("ImageOptionsLoginAsNonRoot")]
            [Validation(Required=false)]
            public bool? ImageOptionsLoginAsNonRoot { get; set; }

            /// <summary>
            /// The image source. Valid values:
            /// 
            /// *   system: a public image provided by Alibaba Cloud
            /// *   self: a custom image that you created
            /// *   others: a shared image from another Alibaba Cloud account or a community image published by another Alibaba Cloud account
            /// *   marketplace: an Alibaba Cloud Marketplace image
            /// </summary>
            [NameInMap("ImageOwnerAlias")]
            [Validation(Required=false)]
            public string ImageOwnerAlias { get; set; }

            /// <summary>
            /// The description of the ECS instances.
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// The generation of the ECS instances.
            /// </summary>
            [NameInMap("InstanceGeneration")]
            [Validation(Required=false)]
            public string InstanceGeneration { get; set; }

            /// <summary>
            /// The naming series of the ECS instances.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The information about the intelligent configuration settings, which determine the available instance types.
            /// </summary>
            [NameInMap("InstancePatternInfos")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsInstancePatternInfos> InstancePatternInfos { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsInstancePatternInfos : TeaModel {
                /// <summary>
                /// The architecture types of the instance types. Valid values:
                /// 
                /// *   X86: x86
                /// *   Heterogeneous: heterogeneous computing, such as GPU-accelerated or FPGA-accelerated
                /// *   BareMetal: ECS Bare Metal Instance
                /// *   Arm: Arm
                /// *   SuperComputeCluster: Super Computing Cluster
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
                /// The CPU architectures of the instance types. Valid values:
                /// 
                /// >  You can specify 1 to 2 CPU architectures.
                /// 
                /// *   x86
                /// *   Arm
                /// </summary>
                [NameInMap("CpuArchitectures")]
                [Validation(Required=false)]
                public List<string> CpuArchitectures { get; set; }

                /// <summary>
                /// The instance types that are excluded. You can use wildcard characters, such as an asterisk (\\*), to exclude an instance type or an instance family. Examples:
                /// 
                /// *   ecs.c6.large: The ecs.c6.large instance type is excluded.
                /// *   ecs.c6.\\*: The c6 instance family is excluded.
                /// </summary>
                [NameInMap("ExcludedInstanceTypes")]
                [Validation(Required=false)]
                public List<string> ExcludedInstanceTypes { get; set; }

                /// <summary>
                /// The GPU models.
                /// </summary>
                [NameInMap("GpuSpecs")]
                [Validation(Required=false)]
                public List<string> GpuSpecs { get; set; }

                /// <summary>
                /// The categories of the instance.families. Valid values:
                /// 
                /// >  You can specify 1 to 10 categories.
                /// 
                /// *   General-purpose
                /// *   Compute-optimized
                /// *   Memory-optimized
                /// *   Big data
                /// *   Local SSDs
                /// *   High Clock Speed
                /// *   Enhanced
                /// *   Shared
                /// *   Compute-optimized with GPU
                /// *   Visual Compute-optimized
                /// *   Heterogeneous Service
                /// *   Compute-optimized with FPGA
                /// *   Compute-optimized with NPU
                /// *   ECS Bare Metal
                /// *   Super Computing Cluster
                /// *   High Performance Compute
                /// </summary>
                [NameInMap("InstanceCategories")]
                [Validation(Required=false)]
                public List<string> InstanceCategories { get; set; }

                /// <summary>
                /// The level of the instance family.
                /// 
                /// *   EntryLevel: entry level (shared instance types). Instance types of this level are the most cost-effective but may not provide stable computing performance. Instance types of this level are suitable for scenarios in which the CPU utilization is low. For more information, see [Shared instance families](https://help.aliyun.com/document_detail/108489.html).
                /// *   EnterpriseLevel: enterprise level. Instance types of this level provide stable performance and dedicated resources, and are suitable for scenarios that require high stability. For more information, see [Overview of instance families](https://help.aliyun.com/document_detail/25378.html).
                /// *   CreditEntryLevel: credit entry level (burstable instance types). CPU credits are used to ensure computing performance. Instance types of this level are suitable for scenarios in which the CPU utilization is low but may fluctuate in specific cases. For more information, see [Overview of burstable instances](https://help.aliyun.com/document_detail/59977.html).
                /// </summary>
                [NameInMap("InstanceFamilyLevel")]
                [Validation(Required=false)]
                public string InstanceFamilyLevel { get; set; }

                /// <summary>
                /// The instance families that are queried. You can query 1 to 10 instance families in each call.
                /// </summary>
                [NameInMap("InstanceTypeFamilies")]
                [Validation(Required=false)]
                public List<string> InstanceTypeFamilies { get; set; }

                /// <summary>
                /// The maximum hourly price for the pay-as-you-go or preemptible instances.
                /// </summary>
                [NameInMap("MaxPrice")]
                [Validation(Required=false)]
                public float? MaxPrice { get; set; }

                /// <summary>
                /// The maximum number of vCPUs per instance type.
                /// 
                /// >  The value of MaximumCpuCoreCount cannot exceed four times the value of MinimumCpuCoreCount.
                /// </summary>
                [NameInMap("MaximumCpuCoreCount")]
                [Validation(Required=false)]
                public int? MaximumCpuCoreCount { get; set; }

                /// <summary>
                /// The maximum number of GPUs per instance. The value must be a positive integer.
                /// </summary>
                [NameInMap("MaximumGpuAmount")]
                [Validation(Required=false)]
                public int? MaximumGpuAmount { get; set; }

                /// <summary>
                /// The maximum memory size per instance. Unit: GiB.
                /// </summary>
                [NameInMap("MaximumMemorySize")]
                [Validation(Required=false)]
                public float? MaximumMemorySize { get; set; }

                /// <summary>
                /// The memory size of the instance type. Unit: GiB.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

                /// <summary>
                /// The baseline vCPU computing performance (overall baseline performance of all vCPUs) per t5 or t6 burstable instance.
                /// </summary>
                [NameInMap("MinimumBaselineCredit")]
                [Validation(Required=false)]
                public int? MinimumBaselineCredit { get; set; }

                /// <summary>
                /// The minimum number of vCPUs per instance type.
                /// </summary>
                [NameInMap("MinimumCpuCoreCount")]
                [Validation(Required=false)]
                public int? MinimumCpuCoreCount { get; set; }

                /// <summary>
                /// The minimum number of IPv6 addresses per ENI.
                /// </summary>
                [NameInMap("MinimumEniIpv6AddressQuantity")]
                [Validation(Required=false)]
                public int? MinimumEniIpv6AddressQuantity { get; set; }

                /// <summary>
                /// The minimum number of IPv4 addresses per ENI.
                /// </summary>
                [NameInMap("MinimumEniPrivateIpAddressQuantity")]
                [Validation(Required=false)]
                public int? MinimumEniPrivateIpAddressQuantity { get; set; }

                /// <summary>
                /// The minimum number of elastic network interfaces (ENIs) per instance.
                /// </summary>
                [NameInMap("MinimumEniQuantity")]
                [Validation(Required=false)]
                public int? MinimumEniQuantity { get; set; }

                /// <summary>
                /// The minimum number of GPUs per instance. The value must be a positive integer.
                /// </summary>
                [NameInMap("MinimumGpuAmount")]
                [Validation(Required=false)]
                public int? MinimumGpuAmount { get; set; }

                /// <summary>
                /// The initial vCPU credits per t5 or t6 burstable instance.
                /// </summary>
                [NameInMap("MinimumInitialCredit")]
                [Validation(Required=false)]
                public int? MinimumInitialCredit { get; set; }

                /// <summary>
                /// The minimum memory size per instance. Unit: GiB.
                /// </summary>
                [NameInMap("MinimumMemorySize")]
                [Validation(Required=false)]
                public float? MinimumMemorySize { get; set; }

                /// <summary>
                /// The processor models of the instance types. You can specify 1 to 10 processor models.
                /// </summary>
                [NameInMap("PhysicalProcessorModels")]
                [Validation(Required=false)]
                public List<string> PhysicalProcessorModels { get; set; }

            }

            /// <summary>
            /// The instance types of the ECS instances.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The ECS instance types.
            /// </summary>
            [NameInMap("InstanceTypes")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// The billing method for network usage. Valid values:
            /// 
            /// *   PayByBandwidth: pay-by-bandwidth. You are charged for the bandwidth that you specified by using InternetMaxBandwidthOut.
            /// *   PayByTraffic: pay-by-traffic. You are charged for the actual traffic that you used. InternetMaxBandwidthOut specifies only the maximum available bandwidth.
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// The maximum inbound bandwidth. Unit: Mbit/s. Valid values: 1 to 200.
            /// </summary>
            [NameInMap("InternetMaxBandwidthIn")]
            [Validation(Required=false)]
            public int? InternetMaxBandwidthIn { get; set; }

            /// <summary>
            /// The maximum outbound bandwidth. Unit: Mbit/s. Valid values:
            /// 
            /// *   0 to 1024 if you set InternetChargeType to PayByBandwidth. If you leave this parameter empty, this parameter is automatically set to 0.
            /// *   0 to 1024 if you set InternetChargeType to PayByTraffic. If you leave this parameter empty, an error is returned.
            /// </summary>
            [NameInMap("InternetMaxBandwidthOut")]
            [Validation(Required=false)]
            public int? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// Indicates whether the ECS instances are I/O optimized. Valid values:
            /// 
            /// *   none: The ECS instances are not I/O optimized.
            /// *   optimized: The ECS instances are I/O optimized.
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
            /// The name of the key pair that is used to log on to an ECS instance created from the scaling configuration.
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// The status of the scaling configuration in the scaling group. Valid values:
            /// 
            /// *   Active: The scaling configuration is active in the scaling group. Auto Scaling uses the scaling configuration that is in the Active state to create ECS instances during scale-out events.
            /// *   Inactive: The scaling configuration is inactive in the scaling group. Scaling configurations that are in the Inactive state are still contained in the scaling group, but Auto Scaling does not use the inactive scaling configurations to create ECS instances during scale-out events.
            /// </summary>
            [NameInMap("LifecycleState")]
            [Validation(Required=false)]
            public string LifecycleState { get; set; }

            /// <summary>
            /// The weight of an ECS instance as a backend server. Valid values: 1 to 100.
            /// </summary>
            [NameInMap("LoadBalancerWeight")]
            [Validation(Required=false)]
            public int? LoadBalancerWeight { get; set; }

            /// <summary>
            /// The memory size. Unit: GiB.
            /// 
            /// You can specify CPU and Memory to define the range of instance types. For example, if you set CPU to 2 and Memory to 16, the instance types that have 2 vCPUs and 16 GiB are returned. If you specify CPU and Memory, Auto Scaling determines the available instance types based on factors such as I/O optimization requirements and zones and preferentially creates instances by using the lowest-priced instance type.
            /// 
            /// >  You can specify CPU and Memory to define instance types only when you set Scaling Policy to Cost Optimization and no instance type is specified in the scaling configuration.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// The ENIs.
            /// </summary>
            [NameInMap("NetworkInterfaces")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsNetworkInterfaces> NetworkInterfaces { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsNetworkInterfaces : TeaModel {
                /// <summary>
                /// The ENI type. Valid values:
                /// 
                /// *   Primary: the primary ENI
                /// *   Secondary: the secondary ENI
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The number of randomly generated IPv6 addresses that are allocated to the primary ENI.
                /// </summary>
                [NameInMap("Ipv6AddressCount")]
                [Validation(Required=false)]
                public int? Ipv6AddressCount { get; set; }

                /// <summary>
                /// The communication mode of the ENI. Valid values:
                /// 
                /// *   Standard: The TCP communication mode is used.
                /// *   HighPerformance: The Elastic RDMA Interface (ERI) is enabled and the remote direct memory access (RDMA) communication mode is used.
                /// </summary>
                [NameInMap("NetworkInterfaceTrafficMode")]
                [Validation(Required=false)]
                public string NetworkInterfaceTrafficMode { get; set; }

                /// <summary>
                /// The IDs of the security groups to which the ENIs belong.
                /// </summary>
                [NameInMap("SecurityGroupIds")]
                [Validation(Required=false)]
                public List<string> SecurityGroupIds { get; set; }

            }

            /// <summary>
            /// Indicates whether the password preconfigured in the image is used.
            /// </summary>
            [NameInMap("PasswordInherit")]
            [Validation(Required=false)]
            public bool? PasswordInherit { get; set; }

            /// <summary>
            /// Indicates whether a password is configured for the instance.
            /// </summary>
            [NameInMap("PasswordSetted")]
            [Validation(Required=false)]
            public bool? PasswordSetted { get; set; }

            [NameInMap("PrivatePoolOptions.Id")]
            [Validation(Required=false)]
            public string PrivatePoolOptions_id { get; set; }

            [NameInMap("PrivatePoolOptions.MatchCriteria")]
            [Validation(Required=false)]
            public string PrivatePoolOptions_matchCriteria { get; set; }

            /// <summary>
            /// The name of the Resource Access Management (RAM) role assumed by the ECS instances. This name is provided and maintained by RAM. You can call the ListRoles operation to query the available RAM roles.
            /// </summary>
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// The ID of the resource group to which the ECS instances belong.
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
            /// >  This parameter is in invitational preview and is not available for use.
            /// </summary>
            [NameInMap("SchedulerOptions")]
            [Validation(Required=false)]
            public DescribeScalingConfigurationsResponseBodyScalingConfigurationsSchedulerOptions SchedulerOptions { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsSchedulerOptions : TeaModel {
                /// <summary>
                /// >  This parameter is in invitational preview and is not available for use.
                /// </summary>
                [NameInMap("ManagedPrivateSpaceId")]
                [Validation(Required=false)]
                public string ManagedPrivateSpaceId { get; set; }

            }

            /// <summary>
            /// Indicates whether Security Hardening is enabled. Valid values:
            /// 
            /// *   Active: Security Hardening is enabled. This value is applicable to only public images.
            /// *   Deactive: Security Hardening is disabled. This value is applicable to all images.
            /// </summary>
            [NameInMap("SecurityEnhancementStrategy")]
            [Validation(Required=false)]
            public string SecurityEnhancementStrategy { get; set; }

            /// <summary>
            /// The ID of the security group to which the ECS instances belong. ECS instances that belong to the same security group can communicate with each other.
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The IDs of the security groups to which the ECS instances belong. ECS instances that belong to the same security group can communicate with each other.
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// The protection period of the preemptible instances. Unit: hours.
            /// </summary>
            [NameInMap("SpotDuration")]
            [Validation(Required=false)]
            public int? SpotDuration { get; set; }

            /// <summary>
            /// The interruption event of the preemptible instances.
            /// </summary>
            [NameInMap("SpotInterruptionBehavior")]
            [Validation(Required=false)]
            public string SpotInterruptionBehavior { get; set; }

            /// <summary>
            /// The preemptible instances.
            /// </summary>
            [NameInMap("SpotPriceLimits")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsSpotPriceLimits> SpotPriceLimits { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsSpotPriceLimits : TeaModel {
                /// <summary>
                /// The instance type of the preemptible instances.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The price limit of the preemptible instances.
                /// </summary>
                [NameInMap("PriceLimit")]
                [Validation(Required=false)]
                public float? PriceLimit { get; set; }

            }

            /// <summary>
            /// The preemption policy that is applied to pay-as-you-go instances. Valid values:
            /// 
            /// *   NoSpot: The instances are created as regular pay-as-you-go instances.
            /// *   SpotWithPriceLimit: The instances are created as preemptible instances that have a user-defined maximum hourly price.
            /// *   SpotAsPriceGo: The instances are preemptible instances for which the market price at the time of purchase is automatically used as the bid price.
            /// </summary>
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// The ID of the storage set.
            /// </summary>
            [NameInMap("StorageSetId")]
            [Validation(Required=false)]
            public string StorageSetId { get; set; }

            /// <summary>
            /// The maximum number of partitions in the storage set. The value is an integer that is greater than or equal to 2.
            /// </summary>
            [NameInMap("StorageSetPartitionNumber")]
            [Validation(Required=false)]
            public int? StorageSetPartitionNumber { get; set; }

            /// <summary>
            /// The ID of the automatic snapshot policy that is applied to the system disk.
            /// </summary>
            [NameInMap("SystemDiskAutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string SystemDiskAutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// Indicates whether the Performance Burst feature is enabled for the system disk. Valid values:
            /// 
            /// *   true
            /// *   false
            /// 
            /// >  This parameter is available only when you set SystemDisk.Category to cloud_auto.
            /// </summary>
            [NameInMap("SystemDiskBurstingEnabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// The categories of the system disks. The values are sorted based on their priorities. The first value has the highest priority. If Auto Scaling cannot create instances by using the disk category of the highest priority, Auto Scaling creates instances by using the disk category of the next highest priority. Valid values:
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
            /// *   ephemeral_ssd: local SSD
            /// *   cloud_essd: enterprise SSD (ESSD)
            /// *   cloud_auto: ESSD AutoPL
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
            /// The encryption algorithm that is applied to the system disk. Valid values:
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
            /// The ID of the KMS key that is applied to the system disk.
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
            /// The performance level (PL) of the system disk that is an ESSD.
            /// </summary>
            [NameInMap("SystemDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// The provisioned IOPS of the system disk.
            /// 
            /// >  IOPS measures the number of read and write operations that an EBS device can process per second.
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
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsTags> Tags { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsTags : TeaModel {
                /// <summary>
                /// The tag key of the ECS instance. You can specify up to 20 tags for each ECS instance.
                /// 
                /// The tag key cannot be an empty string. The tag key can be up to 128 characters in length. It cannot start with `acs:` or `aliyun` and cannot contain `http://` or `https://`.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value of the ECS instance. You can specify up to 20 tags for each ECS instance.
                /// 
                /// The tag value can be an empty string. The tag value can be up to 128 characters in length. It cannot start with `acs:` and cannot contain `http://` or `https://`.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// Indicates whether the ECS instance is created on a dedicated host. Valid values:
            /// 
            /// *   default: The ECS instance is created on a non-dedicated host.
            /// *   host: The ECS instance is created on a dedicated host. If you do not specify DedicatedHostId, the system selects a dedicated host for the ECS instance.
            /// 
            /// Default value: default.
            /// </summary>
            [NameInMap("Tenancy")]
            [Validation(Required=false)]
            public string Tenancy { get; set; }

            /// <summary>
            /// The user data of the ECS instances.
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// The weights of the instance types. The value of this parameter indicates the capacity of an instance of the specified instance type in the scaling group. A higher weight indicates that a smaller number of instances of the instance type are required to meet the expected capacity requirement.
            /// </summary>
            [NameInMap("WeightedCapacities")]
            [Validation(Required=false)]
            public List<int?> WeightedCapacities { get; set; }

            /// <summary>
            /// The ID of the zone in which the ECS instances are created. You can call the DescribeZones operation to query the zone IDs.
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

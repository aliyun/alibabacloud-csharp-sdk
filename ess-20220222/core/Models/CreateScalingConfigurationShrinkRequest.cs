// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CreateScalingConfigurationShrinkRequest : TeaModel {
        [NameInMap("ImageOptions")]
        [Validation(Required=false)]
        public CreateScalingConfigurationShrinkRequestImageOptions ImageOptions { get; set; }
        public class CreateScalingConfigurationShrinkRequestImageOptions : TeaModel {
            /// <summary>
            /// For more information about whether an ECS instance uses the ecs-user user user to log on to an ECS instance, see [Manage the login name of an ECS instance](https://help.aliyun.com/document_detail/388447.html). Value range:
            /// 
            /// - true: Yes.
            /// - false: No.
            /// 
            /// Default value: false.
            /// </summary>
            [NameInMap("LoginAsNonRoot")]
            [Validation(Required=false)]
            public bool? LoginAsNonRoot { get; set; }

        }

        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public CreateScalingConfigurationShrinkRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class CreateScalingConfigurationShrinkRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// The ID of the private pool. The ID of a private pool is the same as the ID of the elasticity assurance or capacity reservation for which the private pool is generated.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The type of the private pool that you want to use to start ECS instances. A private pool is generated when an elasticity assurance or a capacity reservation takes effect. You can select a private pool to create ECS instances. Valid values:
            /// 
            /// *   Open: open private pool. Auto Scaling selects a matching open private pool to start instances. If no matching open private pools are found, Auto Scaling uses the resources in the public pool to start instances. In this case, you do not need to specify PrivatePoolOptions.Id.
            /// *   Target: specified private pool. Auto Scaling uses the resources in the specified private pool to start ECS instances. If the specified private pool is unavailable, Auto Scaling cannot start ECS instances. If you set this parameter to Target, you must specify PrivatePoolOptions.Id.
            /// *   None: no private pool. Auto Scaling does not use the resources in private pools to start ECS instances.
            /// </summary>
            [NameInMap("MatchCriteria")]
            [Validation(Required=false)]
            public string MatchCriteria { get; set; }

        }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public CreateScalingConfigurationShrinkRequestSystemDisk SystemDisk { get; set; }
        public class CreateScalingConfigurationShrinkRequestSystemDisk : TeaModel {
            /// <summary>
            /// The ID of the automatic snapshot policy that you want to apply to the system disk.
            /// </summary>
            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// Specifies whether to enable the burst feature for the system disk. Valid values:
            /// 
            /// *   true
            /// *   false
            /// 
            /// > This parameter is available only if you set `SystemDisk.Category` to `cloud_auto`.
            /// </summary>
            [NameInMap("BurstingEnabled")]
            [Validation(Required=false)]
            public bool? BurstingEnabled { get; set; }

            /// <summary>
            /// The category of the system disk. Valid values:
            /// 
            /// *   cloud: basic disk
            /// *   cloud_efficiency: ultra disk
            /// *   cloud_ssd: standard SSD
            /// *   ephemeral_ssd: local SSD
            /// *   cloud_essd: enhanced SSD (ESSD)
            /// *   cloud_auto: ESSD AutoPL disk
            /// 
            /// If you specify SystemDisk.Category, you cannot specify `SystemDiskCategories`. If you do not specify SystemDisk.Category or `SystemDiskCategories`, the default value of SystemDisk.Category is used.
            /// 
            /// *   For I/O optimized instances, the default value is cloud_efficiency.
            /// *   For non-I/O optimized instances, the default value is cloud.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The description of the system disk. The description must be 2 to 256 characters in length. The description can contain letters and cannot start with `http://` or `https://`.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the system disk. The name must be 2 to 128 characters in length. The name can contain letters, digits, colons (:), underscores (_), and hyphens (-). The name must start with a letter but cannot start with `http://` or `https://`.
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// The encryption algorithm that you want to use to encrypt the system disk. Valid values:
            /// 
            /// *   AES-256
            /// *   SM4-128
            /// 
            /// Default value: AES-256
            /// </summary>
            [NameInMap("EncryptAlgorithm")]
            [Validation(Required=false)]
            public string EncryptAlgorithm { get; set; }

            /// <summary>
            /// Specifies whether to encrypt the system disk. Valid values:
            /// 
            /// *   true
            /// *   false
            /// 
            /// Default value: false
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public bool? Encrypted { get; set; }

            /// <summary>
            /// The ID of the KMS key that you want to use to encrypt the system disk.
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// The performance level (PL) of the system disk that is an enhanced SSD (ESSD). Valid values:
            /// 
            /// *   PL0: An ESSD can provide up to 10,000 random read/write IOPS.
            /// *   PL1: An ESSD can provide up to 50,000 random read/write IOPS.
            /// *   PL2: An ESSD can provide up to 100,000 random read/write IOPS.
            /// *   PL3: An ESSD can provide up to 1,000,000 random read/write IOPS.
            /// 
            /// Default value: PL1.
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// The IOPS metric that is preconfigured for the system disk.
            /// 
            /// > IOPS measures the number of read and write operations that an EBS device can process per second.
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// The size of the system disk. Unit: GiB.
            /// 
            /// *   If you set SystemDisk.Category cloud: 20 to 500.
            /// *   If you set SystemDisk.Category to cloud_efficiency: 20 to 500.
            /// *   If you set SystemDisk.Category to cloud_ssd: 20 to 500.
            /// *   If you set SystemDisk.Category to cloud_essd: 20 to 500.
            /// *   If you set SystemDisk.Category to cloud_essd: 20 to 500.
            /// 
            /// The value of SystemDisk.Size must be greater than or equal to the value of max{20, ImageSize}.
            /// 
            /// Default value: 40 or the size of the image, whichever is greater.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// Specifies whether to associate an ECS instance on a dedicated host with the dedicated host. Valid values:
        /// 
        /// *   default: does not associate the ECS instance with the dedicated host. If you start an ECS instance that was stopped in economical mode and the original dedicated host has insufficient resources, the ECS instance is automatically deployed to another dedicated host in the automatic deployment resource pool.
        /// *   host: associates the ECS instance with the dedicated host. If you start an ECS instance that was stopped in economical mode, the instance remains on the original dedicated host. If the original dedicated host has insufficient resources, the ECS instance fails to start.
        /// 
        /// Default value: default
        /// </summary>
        [NameInMap("Affinity")]
        [Validation(Required=false)]
        public string Affinity { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see the "[How to ensure the idempotence of a request](https://help.aliyun.com/document_detail/25693.html)" topic.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The number of vCPUs.
        /// 
        /// You can specify the number of vCPUs and the memory size to determine the range of instance types. For example, you can set CPU to 2 and Memory to 16 to specify instance types that have 2 vCPUs and 16 GiB of memory. If you specify Cpu and Memory, Auto Scaling determines the available instance types based on factors such as I/O optimization requirements and zones. Then, Auto Scaling preferentially creates instances by using the lowest-priced instance type.
        /// 
        /// > You can specify Cpu and Memory to determine the range of instance types only if you set Scaling Policy to Cost Optimization Policy and you do not specify instance types in the scaling configuration.
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// The performance mode of the burstable instance. Valid values:
        /// 
        /// *   Standard: standard mode
        /// *   Unlimited: unlimited mode
        /// 
        /// For more information, see the "Performance modes" section in the "[Overview](https://help.aliyun.com/document_detail/59977.html)" topic.
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
        /// >  If you specify the priorities of only partial custom ECS instance type + vSwitch combinations, Auto Scaling preferentially creates ECS instances by using the custom combinations that have specified priorities. If the custom combinations that have specified priorities do not provide sufficient resources, Auto Scaling creates ECS instances by using the custom combinations that do not have specified priorities based on the specified orders of vSwitches and instance types.
        /// 
        /// *   Example: the specified order of vSwitches for your scaling group is vsw1 and vsw2 and the specified order of instance types in your scaling configuration is type1 and type 2. In addition, you use CustomPriorities to specify ["vsw2+type2", "vsw1+type2"]. In this example, the vsw2+type2 combination has the highest priority and the vsw2+type1 combination has the lowest priority. The vsw1+type2 combination has a higher priority than the vsw1+type1 combination.
        /// </summary>
        [NameInMap("CustomPriorities")]
        [Validation(Required=false)]
        public List<CreateScalingConfigurationShrinkRequestCustomPriorities> CustomPriorities { get; set; }
        public class CreateScalingConfigurationShrinkRequestCustomPriorities : TeaModel {
            /// <summary>
            /// The ECS instance type.
            /// 
            /// >  The ECS instance type must be included in the instance types specified in the scaling configuration.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The vSwitch ID.
            /// 
            /// >  The vSwitch must be included in the vSwitch list of the scaling group.
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
        public List<CreateScalingConfigurationShrinkRequestDataDisks> DataDisks { get; set; }
        public class CreateScalingConfigurationShrinkRequestDataDisks : TeaModel {
            /// <summary>
            /// The ID of the automatic snapshot policy that you want to apply to the data disk.
            /// </summary>
            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// Specifies whether to enable the burst feature for the system disk. Valid values:
            /// 
            /// *   true
            /// *   false
            /// 
            /// > This parameter is available only if you set `SystemDisk.Category` to `cloud_auto`.
            /// </summary>
            [NameInMap("BurstingEnabled")]
            [Validation(Required=false)]
            public bool? BurstingEnabled { get; set; }

            /// <summary>
            /// The categories of the data disks. If Auto Scaling cannot create instances by using the disk category that has the highest priority, Auto Scaling creates instances by using the disk category that has the next highest priority. Valid values:
            /// 
            /// *   cloud: basic disk. For a basic disk that is created together with the instance, DeleteWithInstance is set to true.
            /// *   cloud_efficiency: ultra disk.
            /// *   cloud_ssd: standard SSD.
            /// *   cloud_essd: ESSD.
            /// 
            /// > If you specify Categories, you cannot specify `DataDisks.Category`.
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// The category of the data disk. Valid values:
            /// 
            /// *   cloud: basic disk
            /// *   cloud_efficiency: ultra disk
            /// *   cloud_ssd: standard SSD
            /// *   cloud_essd: ESSD
            /// *   ephemeral_ssd: local SSD
            /// *   cloud_auto: ESSD AutoPL disk
            /// 
            /// If you specify this parameter, you cannot specify Categories. If you do not specify Category or Categories, the default value of Category is used.
            /// 
            /// *   For I/O optimized instances, the default value is cloud_efficiency.
            /// *   For non-I/O optimized instances, the default value is cloud.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// Specifies whether to release the data disk when the instance to which the data disk is attached is released. Valid values:
            /// 
            /// *   true
            /// *   false
            /// 
            /// This parameter is available only for independent disks whose value of Category is set to cloud, cloud_efficiency, cloud_ssd, or cloud_essd. If you specify this parameter for other disks, an error is reported.
            /// 
            /// Default value: true
            /// </summary>
            [NameInMap("DeleteWithInstance")]
            [Validation(Required=false)]
            public bool? DeleteWithInstance { get; set; }

            /// <summary>
            /// The description of the data disk. The description must be 2 to 256 characters in length. The description can contain letters and cannot start with `http://` or `https://`.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The mount target of the data disk. If you do not specify Device, a mount target is automatically assigned when Auto Scaling creates ECS instances. The names of mount targets range from /dev/xvdb to /dev/xvdz.
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// The name of the system disk. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), and hyphens (-). The name must start with a letter but cannot start with `http://` or `https://`.
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// Specifies whether to encrypt the data disk. Valid values:
            /// 
            /// *   true
            /// *   false
            /// 
            /// Default value: false
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// The ID of the KMS key that you want to use to encrypt the data disk.
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// The PL of the data disk that is an ESSD. Valid values:
            /// 
            /// *   PL0: An ESSD can provide up to 10,000 random read/write IOPS.
            /// *   PL1: An ESSD can provide up to 50,000 random read/write IOPS.
            /// *   PL2: An ESSD can provide up to 100,000 random read/write IOPS.
            /// *   PL3: An ESSD can provide up to 1,000,000 random read/write IOPS.
            /// 
            /// > For more information about how to select ESSD PLs, see [ESSD](https://help.aliyun.com/document_detail/122389.html).
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// The IOPS metric that is preconfigured for the data disk.
            /// 
            /// > IOPS measures the number of read and write operations that an EBS device can process per second.
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// The size of the data disk. Unit: GiB. Valid values:
            /// 
            /// *   If you set Categories to cloud: 5 to 2000.
            /// *   If you set Categories to cloud_efficiency: 20 to 32768.
            /// *   If you set Categories to cloud_essd: 20 to 32768.
            /// *   If you set Categories to ephemeral_ssd: 5 to 800.
            /// 
            /// The size of the data disk must be greater than or equal to the size of the snapshot that is specified by SnapshotId.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// The ID of the snapshot that you want to use to create data disks. If you specify this parameter, DataDisks.Size is ignored. The size of the data disk is the same as the size of the specified snapshot.
            /// 
            /// If you specify a snapshot that is created on or before July 15, 2013, the operation fails and the system returns InvalidSnapshot.TooOld.
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
        /// The ID of the dedicated host on which you want to create an ECS instance. You cannot create preemptible instances on dedicated hosts. If you specify DedicatedHostId, SpotStrategy and SpotPriceLimit are ignored.
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
        /// The ID of the deployment set of the ECS instances that are created by using the scaling configuration.
        /// </summary>
        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        /// <summary>
        /// The hostname of the ECS instance. The hostname cannot start or end with a period (.) or a hyphen (-). The hostname cannot contain consecutive periods (.) or hyphens (-). Naming conventions for different types of instances:
        /// 
        /// *   Windows instances: The hostname must be 2 to 15 characters in length and can contain letters, digits, and hyphens (-). The hostname cannot contain periods (.) or contain only digits.
        /// *   Other instances, such as Linux instances: The hostname must be 2 to 64 characters in length. You can use periods (.) to separate a hostname into multiple segments. Each segment can contain letters, digits, and hyphens (-).
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// The ID of the Elastic High Performance Computing (E-HPC) cluster to which the ECS instances that are created by using the scaling configuration belong.
        /// </summary>
        [NameInMap("HpcClusterId")]
        [Validation(Required=false)]
        public string HpcClusterId { get; set; }

        /// <summary>
        /// The name of the image family. If you specify this parameter, the most recent custom images that are available in the specified image family are returned. You can use the images to create instances. If you specify ImageId, you cannot specify ImageFamily.
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// The ID of the image that Auto Scaling uses to automatically create ECS instances.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The name of the image. Each image name must be unique in a region. If you specify ImageId, ImageName is ignored.
        /// 
        /// You cannot use ImageName to specify images that are purchased from Alibaba Cloud Marketplace.
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// The description of the ECS instance. The description must be 2 to 256 characters in length. The description can contain letters and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("InstanceDescription")]
        [Validation(Required=false)]
        public string InstanceDescription { get; set; }

        /// <summary>
        /// The name of the ECS instance that Auto Scaling creates based on the scaling configuration.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The information about the intelligent configuration settings, which determine the available instance types.
        /// </summary>
        [NameInMap("InstancePatternInfos")]
        [Validation(Required=false)]
        public List<CreateScalingConfigurationShrinkRequestInstancePatternInfos> InstancePatternInfos { get; set; }
        public class CreateScalingConfigurationShrinkRequestInstancePatternInfos : TeaModel {
            /// <summary>
            /// The architecture types of instance types. Valid values:
            /// 
            /// *   X86: x86.
            /// *   Heterogeneous: heterogeneous computing, such as GPU-accelerated or FPGA-accelerated.
            /// *   BareMetal: ECS Bare Metal Instance.
            /// *   Arm: Arm.
            /// *   SuperComputeCluster: Super Computing Cluster.
            /// 
            /// By default, all values are included.
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
            /// The number of vCPUs per instance type in intelligent configuration mode. You can use this parameter to match the available instance types. For more information, see [Overview of instance families](https://help.aliyun.com/document_detail/25378.html).
            /// 
            /// Take note of the following items:
            /// 
            /// *   InstancePatternInfos applies only to the scaling groups that reside in virtual private clouds (VPCs).
            /// *   If you specify InstancePatternInfos, you must also specify InstancePatternInfos.Cores and InstancePatternInfos.Memory.
            /// *   If you specify InstanceType or InstanceTypes, Auto Scaling preferentially uses the instance type specified by InstanceType or InstanceTypes to create instances during scale-out events. If the specified instance type has insufficient inventory, Auto Scaling uses the lowest-priced instance type specified by InstancePatternInfos to create instances during scale-out events.
            /// </summary>
            [NameInMap("Cores")]
            [Validation(Required=false)]
            public int? Cores { get; set; }

            /// <summary>
            /// The CPU architectures of instance types. Valid values:
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
            /// The instance types that you want to exclude. You can use wildcard characters, such as an asterisk (\\*), to exclude an instance type or an instance family. Examples:
            /// 
            /// *   ecs.c6.large: excludes the ecs.c6.large instance type.
            /// *   ecs.c6.\\*: excludes the c6 instance family.
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
            /// The categories of instance types. Valid values:
            /// 
            /// >  You can specify up to 10 categories.
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
            /// The level of the instance family. You can use this parameter to match the available instance types. This parameter takes effect only if you set `CostOptimization` to true. Valid values:
            /// 
            /// *   EntryLevel: entry level (shared instance type). Instance types of this level are the most cost-effective but may not provide stable computing performance. Instance types of this level are suitable for scenarios in which the CPU utilization is low. For more information, see [Shared instance families](https://help.aliyun.com/document_detail/108489.html).
            /// *   EnterpriseLevel: enterprise level. Instance types of this level provide stable performance and dedicated resources, and are suitable for business scenarios that require high stability. For more information, see [Overview of instance families](https://help.aliyun.com/document_detail/25378.html).
            /// *   CreditEntryLevel: credit-based entry level (burstable instance types). CPU credits are used to ensure computing performance. Instance types of this level are suitable for scenarios in which the CPU utilization is low but may fluctuate in specific cases. For more information, see [Overview of burstable instances](https://help.aliyun.com/document_detail/59977.html).
            /// </summary>
            [NameInMap("InstanceFamilyLevel")]
            [Validation(Required=false)]
            public string InstanceFamilyLevel { get; set; }

            /// <summary>
            /// The instance families that you want to specify. You can specify up to 10 instance families in each call.
            /// </summary>
            [NameInMap("InstanceTypeFamilies")]
            [Validation(Required=false)]
            public List<string> InstanceTypeFamilies { get; set; }

            /// <summary>
            /// The maximum hourly price of pay-as-you-go or preemptible instances in intelligent configuration mode. You can specify this parameter to filter the available instance types.
            /// 
            /// >  If you set SpotStrategy to SpotWithPriceLimit, you must specify this parameter. In other cases, this parameter is optional.
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
            /// The memory size per instance type in intelligent configuration mode. Unit: GiB. You can use this parameter to match the available instance types.
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
            /// The processor models of instance types. You can specify up to 10 processor models.
            /// </summary>
            [NameInMap("PhysicalProcessorModels")]
            [Validation(Required=false)]
            public List<string> PhysicalProcessorModels { get; set; }

        }

        /// <summary>
        /// The instance type of the ECS instance. For more information, see the [Instance families](https://help.aliyun.com/document_detail/25378.html) topic.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The instance types.
        /// </summary>
        [NameInMap("InstanceTypeOverrides")]
        [Validation(Required=false)]
        public List<CreateScalingConfigurationShrinkRequestInstanceTypeOverrides> InstanceTypeOverrides { get; set; }
        public class CreateScalingConfigurationShrinkRequestInstanceTypeOverrides : TeaModel {
            /// <summary>
            /// Instance type N that you want to use to override the instance type that is specified in the launch template.
            /// 
            /// If you want to trigger scale-outs based on the weighted capacities of instances, specify InstanceType and WeightedCapacity at the same time. You can specify N instance types by using the Extended Configurations feature. Valid values of N: 1 to 10.
            /// 
            /// > This parameter takes effect only if you specify LaunchTemplateId.
            /// 
            /// You can specify an instance type that is available for purchase as the value of InstanceType.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The weight of instance type N. If you want to trigger scale-outs based on the weighted capacities of instances, you must specify WeightedCapacity after you specify InstanceType.
            /// 
            /// The weight of an instance type specifies the capacity of an instance of the instance type in the scaling group. A higher weight specifies that a smaller number of instances of the specified instance type is required to meet the expected capacity requirement.
            /// 
            /// Performance metrics, such as the number of vCPUs and the memory size of each instance type, may vary. You can specify different weights for different instance types based on your business requirements.
            /// 
            /// Example:
            /// 
            /// *   Current capacity: 0
            /// *   Expected capacity: 6
            /// *   Capacity of ecs.c5.xlarge: 4
            /// 
            /// To meet the expected capacity requirement, Auto Scaling must create and add two ecs.c5.xlarge instances.
            /// 
            /// > The capacity of the scaling group cannot exceed the sum of the maximum number of instances that is specified by MaxSize and the maximum weight of the instance types.
            /// 
            /// Valid values of WeightedCapacity: 1 to 500.
            /// </summary>
            [NameInMap("WeightedCapacity")]
            [Validation(Required=false)]
            public int? WeightedCapacity { get; set; }

        }

        /// <summary>
        /// The instance types. If you specify InstanceTypes, InstanceType is ignored.
        /// 
        /// Auto Scaling creates instances based on the priorities of the instance types. If Auto Scaling cannot create instances by using the instance type that has the highest priority, Auto Scaling creates instances by using the instance type that has the next highest priority.
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// The metering method for network usage. Valid values:
        /// 
        /// *   PayByBandwidth: You are charged for the maximum available bandwidth that is specified by InternetMaxBandwidthOut.
        /// *   PayByTraffic: You are charged based on the amount of transferred data. InternetMaxBandwidthOut specifies only the maximum available bandwidth.
        /// 
        /// For the classic network, the default value is PayByBandwidth. For VPCs, the default value is PayByTraffic.
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The maximum inbound public bandwidth. Unit: Mbit/s. Valid values: 1 to 200.
        /// 
        /// Default value: 200 This parameter is not used for billing because inbound traffic to instances is free of charge.
        /// </summary>
        [NameInMap("InternetMaxBandwidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthIn { get; set; }

        /// <summary>
        /// The maximum outbound public bandwidth. Unit: Mbit/s. Valid values:
        /// 
        /// *   Valid values if you set InternetChargeType to PayByBandwidth: 0 to 100. If you leave this parameter empty, this parameter is automatically set to 0.
        /// *   Valid values if you set InternetChargeType to PayByTraffic: 0 to 100. If you leave this parameter empty, an error is returned.
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// Specifies whether to create an I/O optimized instance. Valid values:
        /// 
        /// none: does not create an I/O optimized instance. optimized: creates an I/O optimized instance.
        /// 
        /// For instances of retired instance types, the default value is none. For instances of other instance types, the default value is optimized.
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// The number of randomly generated IPv6 addresses that you want to allocate to the elastic network interface (ENI).
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// The name of the key pair that you want to use to log on to an ECS instance.
        /// 
        /// *   Windows instances do not support this parameter.
        /// *   By default, the username and password authentication method is disabled for Linux instances.
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// The weight of an ECS instance as a backend server. Valid values: 1 to 100.
        /// 
        /// Default value: 50
        /// </summary>
        [NameInMap("LoadBalancerWeight")]
        [Validation(Required=false)]
        public int? LoadBalancerWeight { get; set; }

        /// <summary>
        /// The memory size. Unit: GiB.
        /// 
        /// You can specify the number of vCPUs and the memory size to determine the range of instance types. For example, you can set Cpu to 2 and Memory to 16 to specify instance types that have 2 vCPUs and 16 GiB of memory. If you specify Cpu and Memory, Auto Scaling determines the available instance types based on factors such as I/O optimization requirements and zones. Then, Auto Scaling preferentially creates instances by using the lowest-priced instance type.
        /// 
        /// > You can specify Cpu and Memory to determine the range of instance types only if you set Scaling Policy to Cost Optimization Policy and you do not specify instance types in the scaling configuration.
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        [NameInMap("NetworkInterfaces")]
        [Validation(Required=false)]
        public List<CreateScalingConfigurationShrinkRequestNetworkInterfaces> NetworkInterfaces { get; set; }
        public class CreateScalingConfigurationShrinkRequestNetworkInterfaces : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("Ipv6AddressCount")]
            [Validation(Required=false)]
            public int? Ipv6AddressCount { get; set; }

            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The password that you want to use to log on to an ECS instance. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported:
        /// 
        /// `` `() ~!@#$%^&*-_+=\\|{}[]:;\\"<>,.?/ ``
        /// 
        /// The password of a Windows instance cannot start with a forward slash (/).
        /// 
        /// > For security reasons, we recommend that you use HTTPS to send requests if you specify Password.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies whether to use the password that is preconfigured in the image. Before you use this parameter, make sure that a password is configured in the image. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// The name of the RAM role that you attach to the ECS instance. The name is provided and maintained by Resource Access Management (RAM). You can call the ListRoles operation to query the available RAM roles.
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// The ID of the resource group to which the ECS instances that are created by using the scaling configuration belong.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The name of the scaling configuration. The name must be 2 to 64 characters in length and can contain letters, digits, underscores (_), hyphens (-), and periods (.). The name must start with a letter or a digit.
        /// 
        /// The name of the scaling configuration must be unique in a region. If you do not specify this parameter, the scaling configuration ID is used.
        /// </summary>
        [NameInMap("ScalingConfigurationName")]
        [Validation(Required=false)]
        public string ScalingConfigurationName { get; set; }

        /// <summary>
        /// The ID of the scaling group in which you want to create a scaling configuration.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// The scheduler options.
        /// </summary>
        [NameInMap("SchedulerOptions")]
        [Validation(Required=false)]
        public string SchedulerOptionsShrink { get; set; }

        /// <summary>
        /// Specifies whether to enable security hardening. Valid values:
        /// 
        /// *   Active: enables security hardening. This value is applicable only to public images.
        /// *   Deactive: disables security hardening. This value is applicable to all image types.
        /// </summary>
        [NameInMap("SecurityEnhancementStrategy")]
        [Validation(Required=false)]
        public string SecurityEnhancementStrategy { get; set; }

        /// <summary>
        /// The ID of the security group with which ECS instances are associated. ECS instances that are associated with the same security group can access each other.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// The IDs of the security groups with which you want to associate the ECS instances that are created by using the scaling configuration. For more information, see the "Security group limits" section of the "[Limits](https://help.aliyun.com/document_detail/25412.html)" topic.
        /// 
        /// > If you specify SecurityGroupId, you cannot specify SecurityGroupIds.
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// The retention period of the preemptible instance. Unit: hours. Valid values: 0, 1, 2, 3, 4, 5, and 6.
        /// 
        /// *   The following retention periods are available in invitational preview: 2, 3, 4, 5, and 6 hours. If you want to set this parameter to one of these values, submit a ticket.
        /// *   If you set this parameter to 0, no protection period is specified for the preemptible instance.
        /// 
        /// Default value: 1
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// The interruption mode of the preemptible instance. Set the value to Terminate. The value specifies that the preemptible instance is to be released.
        /// </summary>
        [NameInMap("SpotInterruptionBehavior")]
        [Validation(Required=false)]
        public string SpotInterruptionBehavior { get; set; }

        /// <summary>
        /// The billing information of the preemptible instances.
        /// </summary>
        [NameInMap("SpotPriceLimits")]
        [Validation(Required=false)]
        public List<CreateScalingConfigurationShrinkRequestSpotPriceLimits> SpotPriceLimits { get; set; }
        public class CreateScalingConfigurationShrinkRequestSpotPriceLimits : TeaModel {
            /// <summary>
            /// The instance type of the preemptible instance. This parameter takes effect only if you set SpotStrategy to SpotWithPriceLimit.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The price limit of the preemptible instance. This parameter takes effect only if you set SpotStrategy to SpotWithPriceLimit.
            /// </summary>
            [NameInMap("PriceLimit")]
            [Validation(Required=false)]
            public float? PriceLimit { get; set; }

        }

        /// <summary>
        /// The preemption policy that you want to apply to pay-as-you-go and preemptible instances. Valid values:
        /// 
        /// *   NoSpot: The instance is created as a pay-as-you-go instance.
        /// *   SpotWithPriceLimit: The instance is a preemptible instance that has a user-defined maximum hourly price.
        /// *   SpotAsPriceGo: The instance is created as a preemptible instance for which the market price at the time of purchase is automatically used as the bid price.
        /// 
        /// Default value: NoSpot
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        [NameInMap("StorageSetId")]
        [Validation(Required=false)]
        public string StorageSetId { get; set; }

        [NameInMap("StorageSetPartitionNumber")]
        [Validation(Required=false)]
        public int? StorageSetPartitionNumber { get; set; }

        /// <summary>
        /// The categories of the system disks. If Auto Scaling cannot create instances by using the disk category that has the highest priority, Auto Scaling creates instances by using the disk category that has the next highest priority. Valid values:
        /// 
        /// *   cloud: basic disk
        /// *   cloud_efficiency: ultra disk
        /// *   cloud_ssd: standard SSD
        /// *   cloud_essd: ESSD
        /// 
        /// > If you specify SystemDiskCategories, you cannot specify `SystemDisk.Category`.
        /// </summary>
        [NameInMap("SystemDiskCategories")]
        [Validation(Required=false)]
        public List<string> SystemDiskCategories { get; set; }

        /// <summary>
        /// The tags of the ECS instance. Tags must be specified as key-value pairs. You can specify up to 20 tags. When you specify tag keys and tag values, take note of the following items:
        /// 
        /// *   A tag key can be up to 64 characters in length. The key cannot start with acs: or aliyun and cannot contain `http://` or `https://`. You cannot specify an empty string as a tag key.
        /// *   A tag value can be up to 128 characters in length. The value cannot start with acs: or aliyun and cannot contain `http://` or `https://`. You can specify an empty string as a tag value.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// Specifies whether to create an ECS instance on a dedicated host. Valid values:
        /// 
        /// *   default: does not create an ECS instance on a dedicated host.
        /// *   host: creates an ECS instance on a dedicated host. If you do not specify DedicatedHostId, Alibaba Cloud selects a dedicated host for the ECS instance.
        /// 
        /// Default value: default
        /// </summary>
        [NameInMap("Tenancy")]
        [Validation(Required=false)]
        public string Tenancy { get; set; }

        /// <summary>
        /// The user data of the Elastic Compute Service (ECS) instance. The user data must be encoded in Base64 format. The size of raw data before Base64 encoding cannot exceed 32 KB.
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// The zone ID of the ECS instance.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

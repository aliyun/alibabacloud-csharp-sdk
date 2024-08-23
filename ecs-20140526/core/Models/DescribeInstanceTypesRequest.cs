// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceTypesRequest : TeaModel {
        /// <summary>
        /// The CPU architecture. Valid values:
        /// 
        /// *   X86
        /// *   ARM
        /// </summary>
        [NameInMap("CpuArchitecture")]
        [Validation(Required=false)]
        public string CpuArchitecture { get; set; }

        /// <summary>
        /// The CPU architectures of instance types. Valid values:
        /// 
        /// >  Valid values of N: 1 and 2.
        /// 
        /// *   X86
        /// *   ARM
        /// </summary>
        [NameInMap("CpuArchitectures")]
        [Validation(Required=false)]
        public List<string> CpuArchitectures { get; set; }

        /// <summary>
        /// The GPU model.
        /// 
        /// >  Fuzzy match is supported. For example, if an instance type provides NVIDIA V100 GPUs and you set this parameter to NVIDIA, information about the instance type is queried.
        /// </summary>
        [NameInMap("GPUSpec")]
        [Validation(Required=false)]
        public string GPUSpec { get; set; }

        /// <summary>
        /// The GPU models of instance types. Valid values of N: 1 to 10.
        /// </summary>
        [NameInMap("GpuSpecs")]
        [Validation(Required=false)]
        public List<string> GpuSpecs { get; set; }

        /// <summary>
        /// The categories of instance types. Valid values:
        /// 
        /// >  Valid values of N: 1 to 10.
        /// 
        /// *   General-purpose: general-purpose instance type
        /// *   Compute-optimized: compute-optimized instance type
        /// *   Memory-optimized: memory-optimized instance type
        /// *   Big data: big data instance type
        /// *   Local SSDs: instance type with local SSDs
        /// *   High Clock Speed: instance type with high clock speeds
        /// *   Enhanced: enhanced instance type
        /// *   Shared: shared instance type
        /// *   Compute-optimized with GPU: GPU-accelerated compute-optimized instance type
        /// *   Visual Compute-optimized: visual compute-optimized instance type
        /// *   Heterogeneous Service: heterogeneous service instance type
        /// *   Compute-optimized with FPGA: FPGA-accelerated compute-optimized instance type
        /// *   Compute-optimized with NPU: NPU-accelerated compute-optimized instance type
        /// *   ECS Bare Metal: ECS Bare Metal Instance type
        /// *   Super Computing Cluster: SCC instance type
        /// *   High Performance Compute: high-performance computing instance type
        /// </summary>
        [NameInMap("InstanceCategories")]
        [Validation(Required=false)]
        public List<string> InstanceCategories { get; set; }

        /// <summary>
        /// The category of the instance type. Valid values:
        /// 
        /// *   General-purpose: general-purpose instance type
        /// *   Compute-optimized: compute-optimized instance type
        /// *   Memory-optimized: memory-optimized instance type
        /// *   Big data: big data instance type
        /// *   Local SSDs: instance type with local SSDs
        /// *   High Clock Speed: instance type with high clock speeds
        /// *   Enhanced: enhanced instance type
        /// *   Shared: shared instance type
        /// *   Compute-optimized with GPU: GPU-accelerated compute-optimized instance type
        /// *   Visual Compute-optimized: visual compute-optimized instance type
        /// *   Heterogeneous Service: heterogeneous service instance type
        /// *   Compute-optimized with FPGA: FPGA-accelerated compute-optimized instance type
        /// *   Compute-optimized with NPU: NPU-accelerated compute-optimized instance type
        /// *   ECS Bare Metal: ECS Bare Metal Instance type
        /// *   Super Computing Cluster: Super Computing Cluster (SCC) instance type
        /// *   High Performance Compute: high-performance computing instance type
        /// </summary>
        [NameInMap("InstanceCategory")]
        [Validation(Required=false)]
        public string InstanceCategory { get; set; }

        /// <summary>
        /// The level of the instance family. Valid values:
        /// 
        /// *   EntryLevel: entry level (shared)
        /// *   EnterpriseLevel: enterprise level
        /// *   CreditEntryLevel: credit-based entry level
        /// </summary>
        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        /// <summary>
        /// The instance families of instance types that you want to query. Valid values of N: 1 to 10.
        /// </summary>
        [NameInMap("InstanceTypeFamilies")]
        [Validation(Required=false)]
        public List<string> InstanceTypeFamilies { get; set; }

        /// <summary>
        /// The instance family to which the instance type belongs. For information about the valid values of this parameter, see [DescribeInstanceTypeFamilies](https://help.aliyun.com/document_detail/25621.html).
        /// 
        /// For more information about instance families, see [Instance families](https://help.aliyun.com/document_detail/25378.html).
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        /// <summary>
        /// Instance type N. Valid values of N: 1 to 10. If this parameter is left empty, information about all instance types is queried.
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// The categories of local disks. Valid values of N: 1 and 2. For more information, see [Local disks](~~63138#section_n2w_8yc_5u1~~). Valid values:
        /// 
        /// *   local_hdd_pro: local SATA HDDs, which are attached to d1ne or d1 instances
        /// *   local_ssd_pro: local NVMe SSDs, which are attached to i2, i2g, i1, ga1, or gn5 instances
        /// </summary>
        [NameInMap("LocalStorageCategories")]
        [Validation(Required=false)]
        public List<string> LocalStorageCategories { get; set; }

        /// <summary>
        /// The category of local disks. For more information, see [Local disks](~~63138#section_n2w_8yc_5u1~~). Valid values:
        /// 
        /// *   local_hdd_pro: local Serial Advanced Technology Attachment (SATA) HDDs, which are attached to d1ne or d1 instances.
        /// *   local_ssd_pro: local Non-Volatile Memory Express (NVMe) SSDs, which are attached to i2, i2g, i1, ga1, or gn5 instances.
        /// 
        /// Valid values:
        /// 
        /// *   local_hdd_pro
        /// *   local_ssd_pro
        /// </summary>
        [NameInMap("LocalStorageCategory")]
        [Validation(Required=false)]
        public string LocalStorageCategory { get; set; }

        /// <summary>
        /// The maximum number of entries per page. Valid values: 1 to 1600.
        /// 
        /// Default value: 1600.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// The maximum number of vCPUs. The value must be a positive integer.
        /// 
        /// >  If an instance type has more vCPUs than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MaximumCpuCoreCount")]
        [Validation(Required=false)]
        public int? MaximumCpuCoreCount { get; set; }

        /// <summary>
        /// The maximum clock speed.
        /// 
        /// >  If an instance type uses processors that have a higher clock speed than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MaximumCpuSpeedFrequency")]
        [Validation(Required=false)]
        public float? MaximumCpuSpeedFrequency { get; set; }

        /// <summary>
        /// The maximum turbo frequency.
        /// 
        /// >  If an instance type uses processors that deliver a higher turbo frequency than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MaximumCpuTurboFrequency")]
        [Validation(Required=false)]
        public float? MaximumCpuTurboFrequency { get; set; }

        /// <summary>
        /// The maximum number of GPUs. The value must be a positive integer.
        /// 
        /// >  If an instance type provides more GPUs than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MaximumGPUAmount")]
        [Validation(Required=false)]
        public int? MaximumGPUAmount { get; set; }

        /// <summary>
        /// The maximum memory size. Unit: GiB.
        /// 
        /// >  If the memory size of an instance type is larger than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MaximumMemorySize")]
        [Validation(Required=false)]
        public float? MaximumMemorySize { get; set; }

        /// <summary>
        /// The minimum baseline CPU performance (overall baseline performance of all vCPUs) of a t5 or t6 burstable instance.
        /// 
        /// >  If a t5 or t6 instance type provides baseline CPU performance lower than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MinimumBaselineCredit")]
        [Validation(Required=false)]
        public int? MinimumBaselineCredit { get; set; }

        /// <summary>
        /// The minimum number of vCPUs. The value must be a positive integer.
        /// 
        /// >  If an instance type has fewer vCPUs than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MinimumCpuCoreCount")]
        [Validation(Required=false)]
        public int? MinimumCpuCoreCount { get; set; }

        /// <summary>
        /// The minimum clock speed.
        /// 
        /// >  If an instance type uses processors that have a lower clock speed than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MinimumCpuSpeedFrequency")]
        [Validation(Required=false)]
        public float? MinimumCpuSpeedFrequency { get; set; }

        /// <summary>
        /// The minimum turbo frequency.
        /// 
        /// >  If an instance type uses processors that deliver a lower turbo frequency than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MinimumCpuTurboFrequency")]
        [Validation(Required=false)]
        public float? MinimumCpuTurboFrequency { get; set; }

        /// <summary>
        /// The minimum number of cloud disks per instance.
        /// 
        /// >  If an instance type supports fewer cloud disks than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MinimumDiskQuantity")]
        [Validation(Required=false)]
        public int? MinimumDiskQuantity { get; set; }

        /// <summary>
        /// The minimum number of IPv6 addresses per ENI.
        /// 
        /// >  If an instance type supports fewer IPv6 addresses per ENI than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MinimumEniIpv6AddressQuantity")]
        [Validation(Required=false)]
        public int? MinimumEniIpv6AddressQuantity { get; set; }

        /// <summary>
        /// The minimum number of IPv4 addresses per ENI.
        /// 
        /// >  If an instance type supports fewer IPv4 addresses per ENI than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MinimumEniPrivateIpAddressQuantity")]
        [Validation(Required=false)]
        public int? MinimumEniPrivateIpAddressQuantity { get; set; }

        /// <summary>
        /// The minimum number of elastic network interfaces (ENIs) per instance.
        /// 
        /// >  If an instance type supports fewer ENIs than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MinimumEniQuantity")]
        [Validation(Required=false)]
        public int? MinimumEniQuantity { get; set; }

        /// <summary>
        /// The minimum number of ERIs per instance.
        /// 
        /// >  If an instance type supports fewer ERIs than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MinimumEriQuantity")]
        [Validation(Required=false)]
        public int? MinimumEriQuantity { get; set; }

        /// <summary>
        /// The minimum number of GPUs. The value must be a positive integer.
        /// 
        /// >  If an instance type provides fewer GPUs than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MinimumGPUAmount")]
        [Validation(Required=false)]
        public int? MinimumGPUAmount { get; set; }

        /// <summary>
        /// The minimum initial CPU credits of a t5 or t6 burstable instance.
        /// 
        /// >  If a t5 or t6 instance type provides less initial vCPU credits than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MinimumInitialCredit")]
        [Validation(Required=false)]
        public int? MinimumInitialCredit { get; set; }

        /// <summary>
        /// The minimum inbound internal bandwidth. Unit: Kbit/s.
        /// 
        /// >  If an instance type provides an inbound internal bandwidth that is lower than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MinimumInstanceBandwidthRx")]
        [Validation(Required=false)]
        public int? MinimumInstanceBandwidthRx { get; set; }

        /// <summary>
        /// The minimum outbound internal bandwidth. Unit: Kbit/s.
        /// 
        /// >  If an instance type provides an outbound internal bandwidth that is lower than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MinimumInstanceBandwidthTx")]
        [Validation(Required=false)]
        public int? MinimumInstanceBandwidthTx { get; set; }

        /// <summary>
        /// The minimum inbound packet forwarding rate over the internal network. Unit: pps.
        /// 
        /// >  If an instance type provides an inbound packet forwarding rate over the internal network that is lower than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MinimumInstancePpsRx")]
        [Validation(Required=false)]
        public long? MinimumInstancePpsRx { get; set; }

        /// <summary>
        /// The minimum outbound packet forwarding rate over the internal network. Unit: pps.
        /// 
        /// >  If an instance type provides an outbound packet forwarding rate over the internal network that is lower than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MinimumInstancePpsTx")]
        [Validation(Required=false)]
        public long? MinimumInstancePpsTx { get; set; }

        /// <summary>
        /// The minimum number of local disks per instance.
        /// 
        /// >  If an instance type supports fewer local disks than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MinimumLocalStorageAmount")]
        [Validation(Required=false)]
        public int? MinimumLocalStorageAmount { get; set; }

        /// <summary>
        /// The capacity of each local disk attached per instance. Unit: GiB.
        /// </summary>
        [NameInMap("MinimumLocalStorageCapacity")]
        [Validation(Required=false)]
        public long? MinimumLocalStorageCapacity { get; set; }

        /// <summary>
        /// The minimum memory size. Unit: GiB.
        /// 
        /// >  If the memory size of an instance type is smaller than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MinimumMemorySize")]
        [Validation(Required=false)]
        public float? MinimumMemorySize { get; set; }

        /// <summary>
        /// The minimum default number of queues per primary network interface controller (NIC).
        /// 
        /// >  If an instance type supports fewer queues per primary NIC than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MinimumPrimaryEniQueueNumber")]
        [Validation(Required=false)]
        public int? MinimumPrimaryEniQueueNumber { get; set; }

        /// <summary>
        /// The minimum number of queue pair (QP) queues per elastic RDMA interface (ERI).
        /// 
        /// >  If an instance type supports fewer QP queues per ERI than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MinimumQueuePairNumber")]
        [Validation(Required=false)]
        public int? MinimumQueuePairNumber { get; set; }

        /// <summary>
        /// The minimum default number of queues per secondary NIC.
        /// 
        /// >  If an instance type supports fewer queues per secondary NIC than the specified value, information about the instance type is not queried.
        /// </summary>
        [NameInMap("MinimumSecondaryEniQueueNumber")]
        [Validation(Required=false)]
        public int? MinimumSecondaryEniQueueNumber { get; set; }

        /// <summary>
        /// The query token. Set the value to the NextToken value returned in the previous call to the DescribeInstanceTypes operation. You do not need to specify this parameter for the first request.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Specifies whether cloud disks can be attached by using the NVMe protocol. Valid values:
        /// 
        /// *   required: Cloud disks can be attached by using the NVMe protocol.
        /// *   unsupported: Cloud disks cannot be attached by using the NVMe protocol.
        /// </summary>
        [NameInMap("NvmeSupport")]
        [Validation(Required=false)]
        public string NvmeSupport { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The CPU model.
        /// 
        /// >  Fuzzy match is supported. For example, if an instance type uses Intel Xeon (Ice Lake) Platinum 8369B processors and you set this parameter to Intel, information about the instance type is queried.
        /// </summary>
        [NameInMap("PhysicalProcessorModel")]
        [Validation(Required=false)]
        public string PhysicalProcessorModel { get; set; }

        /// <summary>
        /// The CPU models of instance types. Valid values of N: 1 to 10.
        /// </summary>
        [NameInMap("PhysicalProcessorModels")]
        [Validation(Required=false)]
        public List<string> PhysicalProcessorModels { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribePatternTypesRequest : TeaModel {
        /// <summary>
        /// The architectures of instance types. Valid values:
        /// 
        /// *   X86: x86
        /// *   Heterogeneous: heterogeneous computing, such as GPU-accelerated or FPGA-accelerated
        /// *   BareMetal: ECS Bare Metal Instance
        /// *   Arm: Arm
        /// *   SuperComputeCluster: Super Computing Cluster
        /// 
        /// By default, all values are selected.
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public List<string> Architecture { get; set; }

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
        /// The channel ID. This parameter is not for public use.
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public long? ChannelId { get; set; }

        /// <summary>
        /// The number of vCPUs that you want to assign to the instance type.
        /// </summary>
        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        /// <summary>
        /// The number of vCPUs that you want to assign to the instance type. You can specify multiple vCPUs.
        /// </summary>
        [NameInMap("CoresList")]
        [Validation(Required=false)]
        public List<int?> CoresList { get; set; }

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

        [NameInMap("ExcludedInstanceType")]
        [Validation(Required=false)]
        public List<string> ExcludedInstanceType { get; set; }

        /// <summary>
        /// The GPU models.
        /// </summary>
        [NameInMap("GpuSpecs")]
        [Validation(Required=false)]
        public List<string> GpuSpecs { get; set; }

        /// <summary>
        /// The categories of the instance types. Valid values:
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
        /// The level of the instance family. Valid values:
        /// 
        /// *   EntryLevel: entry level
        /// *   EnterpriseLevel: enterprise level
        /// *   CreditEntryLevel: credit-based entry level For more information, see [Burstable instance families](https://help.aliyun.com/document_detail/59977.html).
        /// </summary>
        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        /// <summary>
        /// The instance families that you want to query. You can query 1 to 10 instance families in each call.
        /// </summary>
        [NameInMap("InstanceTypeFamilies")]
        [Validation(Required=false)]
        public List<string> InstanceTypeFamilies { get; set; }

        /// <summary>
        /// The maximum hourly price for pay-as-you-go or preemptible instances.
        /// </summary>
        [NameInMap("MaxPrice")]
        [Validation(Required=false)]
        public float? MaxPrice { get; set; }

        /// <summary>
        /// The maximum number of vCPUs per instance type.
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
        /// The memory size that you want to assign to the instance type. Unit: GiB.
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// The memory size that you want to assign to the instance type. Unit: GiB. You can specify multiple memory sizes.
        /// </summary>
        [NameInMap("MemoryList")]
        [Validation(Required=false)]
        public List<float?> MemoryList { get; set; }

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

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The preemption policy that you want to apply to pay-as-you-go instances. Valid values:
        /// 
        /// *   NoSpot: The instances are created as regular pay-as-you-go instances.
        /// *   SpotWithPriceLimit: The instances are created as preemptible instances that have a user-defined maximum hourly price.
        /// *   SpotAsPriceGo: The instances are created as preemptible instances for which the market price at the time of purchase is automatically used as the bidding price.
        /// 
        /// Default value: NoSpot.
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// The IDs of the vSwitches.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public List<string> VSwitchId { get; set; }

    }

}

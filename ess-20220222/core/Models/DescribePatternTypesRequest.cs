// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribePatternTypesRequest : TeaModel {
        /// <summary>
        /// <para>The architectures of instance types. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>X86: x86</description></item>
        /// <item><description>Heterogeneous: heterogeneous computing, such as GPU-accelerated or FPGA-accelerated</description></item>
        /// <item><description>BareMetal: ECS Bare Metal Instance</description></item>
        /// <item><description>Arm: Arm</description></item>
        /// <item><description>SuperComputeCluster: Super Computing Cluster</description></item>
        /// </list>
        /// <para>By default, all values are selected.</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public List<string> Architecture { get; set; }

        /// <summary>
        /// <para>Specifies whether to include burstable instance types. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Exclude: does not include burstable instance types.</description></item>
        /// <item><description>Include: includes burstable instance types.</description></item>
        /// <item><description>Required: includes only burstable instance types.</description></item>
        /// </list>
        /// <para>Default value: Include.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Include</para>
        /// </summary>
        [NameInMap("BurstablePerformance")]
        [Validation(Required=false)]
        public string BurstablePerformance { get; set; }

        /// <summary>
        /// <para>The channel ID. This parameter is not for public use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79425074</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public long? ChannelId { get; set; }

        /// <summary>
        /// <para>The number of vCPUs that you want to assign to the instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        /// <summary>
        /// <para>The number of vCPUs that you want to assign to the instance type. You can specify multiple vCPUs.</para>
        /// </summary>
        [NameInMap("CoresList")]
        [Validation(Required=false)]
        public List<int?> CoresList { get; set; }

        /// <summary>
        /// <para>The CPU architectures of the instance types. Valid values:</para>
        /// <remarks>
        /// <para> You can specify 1 to 2 CPU architectures.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>x86</description></item>
        /// <item><description>Arm</description></item>
        /// </list>
        /// </summary>
        [NameInMap("CpuArchitectures")]
        [Validation(Required=false)]
        public List<string> CpuArchitectures { get; set; }

        [NameInMap("ExcludedInstanceType")]
        [Validation(Required=false)]
        public List<string> ExcludedInstanceType { get; set; }

        /// <summary>
        /// <para>The GPU models.</para>
        /// </summary>
        [NameInMap("GpuSpecs")]
        [Validation(Required=false)]
        public List<string> GpuSpecs { get; set; }

        /// <summary>
        /// <para>The categories of the instance types. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>General-purpose</description></item>
        /// <item><description>Compute-optimized</description></item>
        /// <item><description>Memory-optimized</description></item>
        /// <item><description>Big data</description></item>
        /// <item><description>Local SSDs</description></item>
        /// <item><description>High Clock Speed</description></item>
        /// <item><description>Enhanced</description></item>
        /// <item><description>Shared</description></item>
        /// <item><description>Compute-optimized with GPU</description></item>
        /// <item><description>Visual Compute-optimized</description></item>
        /// <item><description>Heterogeneous Service</description></item>
        /// <item><description>Compute-optimized with FPGA</description></item>
        /// <item><description>Compute-optimized with NPU</description></item>
        /// <item><description>ECS Bare Metal</description></item>
        /// <item><description>Super Computing Cluster</description></item>
        /// <item><description>High Performance Compute</description></item>
        /// </list>
        /// </summary>
        [NameInMap("InstanceCategories")]
        [Validation(Required=false)]
        public List<string> InstanceCategories { get; set; }

        /// <summary>
        /// <para>The level of the instance family. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EntryLevel: entry level</description></item>
        /// <item><description>EnterpriseLevel: enterprise level</description></item>
        /// <item><description>CreditEntryLevel: credit-based entry level For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Burstable instance families</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EnterpriseLevel</para>
        /// </summary>
        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        /// <summary>
        /// <para>The instance families that you want to query. You can query 1 to 10 instance families in each call.</para>
        /// </summary>
        [NameInMap("InstanceTypeFamilies")]
        [Validation(Required=false)]
        public List<string> InstanceTypeFamilies { get; set; }

        /// <summary>
        /// <para>The maximum hourly price for pay-as-you-go or preemptible instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxPrice")]
        [Validation(Required=false)]
        public float? MaxPrice { get; set; }

        /// <summary>
        /// <para>The maximum number of vCPUs per instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MaximumCpuCoreCount")]
        [Validation(Required=false)]
        public int? MaximumCpuCoreCount { get; set; }

        /// <summary>
        /// <para>The maximum number of GPUs per instance. The value must be a positive integer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaximumGpuAmount")]
        [Validation(Required=false)]
        public int? MaximumGpuAmount { get; set; }

        /// <summary>
        /// <para>The maximum memory size per instance. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MaximumMemorySize")]
        [Validation(Required=false)]
        public float? MaximumMemorySize { get; set; }

        /// <summary>
        /// <para>The memory size that you want to assign to the instance type. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// <para>The memory size that you want to assign to the instance type. Unit: GiB. You can specify multiple memory sizes.</para>
        /// </summary>
        [NameInMap("MemoryList")]
        [Validation(Required=false)]
        public List<float?> MemoryList { get; set; }

        /// <summary>
        /// <para>The baseline vCPU computing performance (overall baseline performance of all vCPUs) per t5 or t6 burstable instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("MinimumBaselineCredit")]
        [Validation(Required=false)]
        public int? MinimumBaselineCredit { get; set; }

        /// <summary>
        /// <para>The minimum number of vCPUs per instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinimumCpuCoreCount")]
        [Validation(Required=false)]
        public int? MinimumCpuCoreCount { get; set; }

        /// <summary>
        /// <para>The minimum number of IPv6 addresses per ENI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinimumEniIpv6AddressQuantity")]
        [Validation(Required=false)]
        public int? MinimumEniIpv6AddressQuantity { get; set; }

        /// <summary>
        /// <para>The minimum number of IPv4 addresses per ENI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinimumEniPrivateIpAddressQuantity")]
        [Validation(Required=false)]
        public int? MinimumEniPrivateIpAddressQuantity { get; set; }

        /// <summary>
        /// <para>The minimum number of elastic network interfaces (ENIs) per instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinimumEniQuantity")]
        [Validation(Required=false)]
        public int? MinimumEniQuantity { get; set; }

        /// <summary>
        /// <para>The minimum number of GPUs per instance. The value must be a positive integer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinimumGpuAmount")]
        [Validation(Required=false)]
        public int? MinimumGpuAmount { get; set; }

        /// <summary>
        /// <para>The initial vCPU credits per t5 or t6 burstable instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("MinimumInitialCredit")]
        [Validation(Required=false)]
        public int? MinimumInitialCredit { get; set; }

        /// <summary>
        /// <para>The minimum memory size per instance. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MinimumMemorySize")]
        [Validation(Required=false)]
        public float? MinimumMemorySize { get; set; }

        /// <summary>
        /// <para>The processor models of the instance types. You can specify 1 to 10 processor models.</para>
        /// </summary>
        [NameInMap("PhysicalProcessorModels")]
        [Validation(Required=false)]
        public List<string> PhysicalProcessorModels { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The preemption policy that you want to apply to pay-as-you-go instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The instances are created as regular pay-as-you-go instances.</description></item>
        /// <item><description>SpotWithPriceLimit: The instances are created as preemptible instances that have a user-defined maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: The instances are created as preemptible instances for which the market price at the time of purchase is automatically used as the bidding price.</description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The IDs of the vSwitches.</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public List<string> VSwitchId { get; set; }

    }

}

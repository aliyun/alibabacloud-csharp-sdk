// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribePatternTypesRequest : TeaModel {
        /// <summary>
        /// <para>The architecture type of the instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>X86: x86 computing</description></item>
        /// <item><description>Heterogeneous: heterogeneous computing, such as GPU or FPGA</description></item>
        /// <item><description>BareMental: Elastic Compute Service Bare Metal Server</description></item>
        /// <item><description>Arm: Arm computing</description></item>
        /// </list>
        /// <para>Default value: all architecture types.</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public List<string> Architecture { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance type is a burstable instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Exclude: Burstable instance types are excluded.</description></item>
        /// <item><description>Include: Burstable instance types are included.</description></item>
        /// <item><description>Required: Only burstable instance types are included.</description></item>
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
        /// <para>The channel ID. This parameter is reserved for internal use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79425074</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public long? ChannelId { get; set; }

        /// <summary>
        /// <para>The number of vCPUs for the instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        /// <summary>
        /// <para>The number of vCPUs for the instance type. You can specify multiple values.</para>
        /// </summary>
        [NameInMap("CoresList")]
        [Validation(Required=false)]
        public List<int?> CoresList { get; set; }

        /// <summary>
        /// <para>The CPU architecture of the instance type. Valid values:</para>
        /// <remarks>
        /// <para>N specifies the number of CPU architectures that you can set. Valid values of N: 1 to 2.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>X86</description></item>
        /// <item><description>ARM</description></item>
        /// </list>
        /// </summary>
        [NameInMap("CpuArchitectures")]
        [Validation(Required=false)]
        public List<string> CpuArchitectures { get; set; }

        [NameInMap("ExcludedInstanceType")]
        [Validation(Required=false)]
        public List<string> ExcludedInstanceType { get; set; }

        /// <summary>
        /// <para>The GPU type.</para>
        /// </summary>
        [NameInMap("GpuSpecs")]
        [Validation(Required=false)]
        public List<string> GpuSpecs { get; set; }

        /// <summary>
        /// <para>The categorization of the instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>General-purpose: general-purpose</description></item>
        /// <item><description>Compute-optimized: compute-optimized</description></item>
        /// <item><description>Memory-optimized: memory-optimized</description></item>
        /// <item><description>Big data: big data</description></item>
        /// <item><description>Local SSDs: local SSD</description></item>
        /// <item><description>High Clock Speed: high frequency</description></item>
        /// <item><description>Enhanced: enhanced</description></item>
        /// <item><description>Shared: shared</description></item>
        /// <item><description>Compute-optimized with GPU: GPU-accelerated compute-optimized</description></item>
        /// <item><description>Visual Compute-optimized: visual compute-optimized</description></item>
        /// <item><description>Heterogeneous Service: heterogeneous service</description></item>
        /// <item><description>Compute-optimized with FPGA: FPGA-accelerated compute-optimized</description></item>
        /// <item><description>Compute-optimized with NPU: NPU-accelerated compute-optimized</description></item>
        /// <item><description>ECS Bare Metal: Elastic Compute Service Bare Metal Server</description></item>
        /// <item><description>High Performance Compute: high-performance computing (HPC)</description></item>
        /// </list>
        /// </summary>
        [NameInMap("InstanceCategories")]
        [Validation(Required=false)]
        public List<string> InstanceCategories { get; set; }

        /// <summary>
        /// <para>The level of the instance family. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EntryLevel: Entry-level instance family.</description></item>
        /// <item><description>EnterpriseLevel: Enterprise-level instance family.</description></item>
        /// <item><description>CreditEntryLevel: Credit entry-level instance family. For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Burstable instances</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EnterpriseLevel</para>
        /// </summary>
        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        /// <summary>
        /// <para>The instance families to be queried. N specifies the number of instance families that you can set. Valid values of N: 1 to 10.</para>
        /// </summary>
        [NameInMap("InstanceTypeFamilies")]
        [Validation(Required=false)]
        public List<string> InstanceTypeFamilies { get; set; }

        /// <summary>
        /// <para>The maximum acceptable hourly price for the pay-as-you-go or spot instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxPrice")]
        [Validation(Required=false)]
        public float? MaxPrice { get; set; }

        /// <summary>
        /// <para>The maximum number of vCPUs for the instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MaximumCpuCoreCount")]
        [Validation(Required=false)]
        public int? MaximumCpuCoreCount { get; set; }

        /// <summary>
        /// <para>The maximum number of GPUs for the instance. Valid values: positive integers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaximumGpuAmount")]
        [Validation(Required=false)]
        public int? MaximumGpuAmount { get; set; }

        /// <summary>
        /// <para>The maximum memory size of the instance. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MaximumMemorySize")]
        [Validation(Required=false)]
        public float? MaximumMemorySize { get; set; }

        /// <summary>
        /// <para>The memory size of the instance type. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// <para>The memory size of the instance type. Unit: GiB. You can specify multiple values.</para>
        /// </summary>
        [NameInMap("MemoryList")]
        [Validation(Required=false)]
        public List<float?> MemoryList { get; set; }

        /// <summary>
        /// <para>The minimum baseline vCPU computing performance (sum of all vCPUs) for burstable instances of the t5 and t6 instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("MinimumBaselineCredit")]
        [Validation(Required=false)]
        public int? MinimumBaselineCredit { get; set; }

        /// <summary>
        /// <para>The minimum number of vCPUs for the instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinimumCpuCoreCount")]
        [Validation(Required=false)]
        public int? MinimumCpuCoreCount { get; set; }

        /// <summary>
        /// <para>The minimum upper limit on the number of IPv6 addresses per elastic network interface controller (NIC) for the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinimumEniIpv6AddressQuantity")]
        [Validation(Required=false)]
        public int? MinimumEniIpv6AddressQuantity { get; set; }

        /// <summary>
        /// <para>The minimum upper limit on the number of IPv4 addresses per elastic network interface controller (NIC) for the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinimumEniPrivateIpAddressQuantity")]
        [Validation(Required=false)]
        public int? MinimumEniPrivateIpAddressQuantity { get; set; }

        /// <summary>
        /// <para>The minimum upper limit on the number of elastic network interfaces (ENIs) that can be bound to the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinimumEniQuantity")]
        [Validation(Required=false)]
        public int? MinimumEniQuantity { get; set; }

        /// <summary>
        /// <para>The minimum number of GPUs for the instance. Valid values: positive integers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinimumGpuAmount")]
        [Validation(Required=false)]
        public int? MinimumGpuAmount { get; set; }

        /// <summary>
        /// <para>The minimum initial vCPU credit for burstable instances of the t5 and t6 instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("MinimumInitialCredit")]
        [Validation(Required=false)]
        public int? MinimumInitialCredit { get; set; }

        /// <summary>
        /// <para>The minimum memory size of the instance. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MinimumMemorySize")]
        [Validation(Required=false)]
        public float? MinimumMemorySize { get; set; }

        /// <summary>
        /// <para>The processor model of the instance. N specifies the number of processor models that you can set. Valid values of N: 1 to 10.</para>
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
        /// <para>The preemption policy for the pay-as-you-go instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: regular pay-as-you-go instance</description></item>
        /// <item><description>SpotWithPriceLimit: spot instance with a maximum price limit</description></item>
        /// <item><description>SpotAsPriceGo: spot instance whose price is automatically offered by the system based on the current market price</description></item>
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
        /// <para>The list of vSwitch IDs. You must specify at least one of VSwitchId and ZoneId.</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public List<string> VSwitchId { get; set; }

        /// <summary>
        /// <para>The list of zone IDs. This parameter is invalid if a vSwitch ID is specified. You must specify at least one of VSwitchId and ZoneId.</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public List<string> ZoneId { get; set; }

    }

}

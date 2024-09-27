// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceTypesRequest : TeaModel {
        /// <summary>
        /// <para>The CPU architecture. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>X86</description></item>
        /// <item><description>ARM</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>X86</para>
        /// </summary>
        [NameInMap("CpuArchitecture")]
        [Validation(Required=false)]
        public string CpuArchitecture { get; set; }

        /// <summary>
        /// <para>The CPU architectures of instance types. Valid values:</para>
        /// <remarks>
        /// <para> Valid values of N: 1 and 2.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>X86</description></item>
        /// <item><description>ARM</description></item>
        /// </list>
        /// </summary>
        [NameInMap("CpuArchitectures")]
        [Validation(Required=false)]
        public List<string> CpuArchitectures { get; set; }

        /// <summary>
        /// <para>The GPU model.</para>
        /// <remarks>
        /// <para> Fuzzy match is supported. For example, if an instance type provides NVIDIA V100 GPUs and you set this parameter to NVIDIA, information about the instance type is queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>NVIDIA V100</para>
        /// </summary>
        [NameInMap("GPUSpec")]
        [Validation(Required=false)]
        public string GPUSpec { get; set; }

        /// <summary>
        /// <para>The GPU models of instance types. Valid values of N: 1 to 10.</para>
        /// </summary>
        [NameInMap("GpuSpecs")]
        [Validation(Required=false)]
        public List<string> GpuSpecs { get; set; }

        /// <summary>
        /// <para>The categories of instance types. Valid values:</para>
        /// <remarks>
        /// <para> Valid values of N: 1 to 10.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>General-purpose: general-purpose instance type</description></item>
        /// <item><description>Compute-optimized: compute-optimized instance type</description></item>
        /// <item><description>Memory-optimized: memory-optimized instance type</description></item>
        /// <item><description>Big data: big data instance type</description></item>
        /// <item><description>Local SSDs: instance type with local SSDs</description></item>
        /// <item><description>High Clock Speed: instance type with high clock speeds</description></item>
        /// <item><description>Enhanced: enhanced instance type</description></item>
        /// <item><description>Shared: shared instance type</description></item>
        /// <item><description>Compute-optimized with GPU: GPU-accelerated compute-optimized instance type</description></item>
        /// <item><description>Visual Compute-optimized: visual compute-optimized instance type</description></item>
        /// <item><description>Heterogeneous Service: heterogeneous service instance type</description></item>
        /// <item><description>Compute-optimized with FPGA: FPGA-accelerated compute-optimized instance type</description></item>
        /// <item><description>Compute-optimized with NPU: NPU-accelerated compute-optimized instance type</description></item>
        /// <item><description>ECS Bare Metal: ECS Bare Metal Instance type</description></item>
        /// <item><description>Super Computing Cluster: SCC instance type</description></item>
        /// <item><description>High Performance Compute: high-performance computing instance type</description></item>
        /// </list>
        /// </summary>
        [NameInMap("InstanceCategories")]
        [Validation(Required=false)]
        public List<string> InstanceCategories { get; set; }

        /// <summary>
        /// <para>The category of the instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>General-purpose: general-purpose instance type</description></item>
        /// <item><description>Compute-optimized: compute-optimized instance type</description></item>
        /// <item><description>Memory-optimized: memory-optimized instance type</description></item>
        /// <item><description>Big data: big data instance type</description></item>
        /// <item><description>Local SSDs: instance type with local SSDs</description></item>
        /// <item><description>High Clock Speed: instance type with high clock speeds</description></item>
        /// <item><description>Enhanced: enhanced instance type</description></item>
        /// <item><description>Shared: shared instance type</description></item>
        /// <item><description>Compute-optimized with GPU: GPU-accelerated compute-optimized instance type</description></item>
        /// <item><description>Visual Compute-optimized: visual compute-optimized instance type</description></item>
        /// <item><description>Heterogeneous Service: heterogeneous service instance type</description></item>
        /// <item><description>Compute-optimized with FPGA: FPGA-accelerated compute-optimized instance type</description></item>
        /// <item><description>Compute-optimized with NPU: NPU-accelerated compute-optimized instance type</description></item>
        /// <item><description>ECS Bare Metal: ECS Bare Metal Instance type</description></item>
        /// <item><description>Super Computing Cluster: Super Computing Cluster (SCC) instance type</description></item>
        /// <item><description>High Performance Compute: high-performance computing instance type</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Big data</para>
        /// </summary>
        [NameInMap("InstanceCategory")]
        [Validation(Required=false)]
        public string InstanceCategory { get; set; }

        /// <summary>
        /// <para>The level of the instance family. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EntryLevel: entry level (shared)</description></item>
        /// <item><description>EnterpriseLevel: enterprise level</description></item>
        /// <item><description>CreditEntryLevel: credit-based entry level</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EntryLevel</para>
        /// </summary>
        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        /// <summary>
        /// <para>The instance families of instance types that you want to query. Valid values of N: 1 to 10.</para>
        /// </summary>
        [NameInMap("InstanceTypeFamilies")]
        [Validation(Required=false)]
        public List<string> InstanceTypeFamilies { get; set; }

        /// <summary>
        /// <para>The instance family to which the instance type belongs. For information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/25621.html">DescribeInstanceTypeFamilies</a>.</para>
        /// <para>For more information about instance families, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6</para>
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        /// <summary>
        /// <para>Instance type N. Valid values of N: 1 to 10. If this parameter is left empty, information about all instance types is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The categories of local disks. Valid values of N: 1 and 2. For more information, see <a href="~~63138#section_n2w_8yc_5u1~~">Local disks</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>local_hdd_pro: local SATA HDDs, which are attached to d1ne or d1 instances</description></item>
        /// <item><description>local_ssd_pro: local NVMe SSDs, which are attached to i2, i2g, i1, ga1, or gn5 instances</description></item>
        /// </list>
        /// </summary>
        [NameInMap("LocalStorageCategories")]
        [Validation(Required=false)]
        public List<string> LocalStorageCategories { get; set; }

        /// <summary>
        /// <para>The category of local disks. For more information, see <a href="~~63138#section_n2w_8yc_5u1~~">Local disks</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>local_hdd_pro: local Serial Advanced Technology Attachment (SATA) HDDs, which are attached to d1ne or d1 instances.</description></item>
        /// <item><description>local_ssd_pro: local Non-Volatile Memory Express (NVMe) SSDs, which are attached to i2, i2g, i1, ga1, or gn5 instances.</description></item>
        /// </list>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>local_hdd_pro</description></item>
        /// <item><description>local_ssd_pro</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>local_ssd_pro</para>
        /// </summary>
        [NameInMap("LocalStorageCategory")]
        [Validation(Required=false)]
        public string LocalStorageCategory { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page. Valid values: 1 to 1600.</para>
        /// <para>Default value: 1600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The maximum number of vCPUs. The value must be a positive integer.</para>
        /// <remarks>
        /// <para> If an instance type has more vCPUs than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaximumCpuCoreCount")]
        [Validation(Required=false)]
        public int? MaximumCpuCoreCount { get; set; }

        /// <summary>
        /// <para>The maximum clock speed.</para>
        /// <remarks>
        /// <para> If an instance type uses processors that have a higher clock speed than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3.2</para>
        /// </summary>
        [NameInMap("MaximumCpuSpeedFrequency")]
        [Validation(Required=false)]
        public float? MaximumCpuSpeedFrequency { get; set; }

        /// <summary>
        /// <para>The maximum turbo frequency.</para>
        /// <remarks>
        /// <para> If an instance type uses processors that deliver a higher turbo frequency than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4.1</para>
        /// </summary>
        [NameInMap("MaximumCpuTurboFrequency")]
        [Validation(Required=false)]
        public float? MaximumCpuTurboFrequency { get; set; }

        /// <summary>
        /// <para>The maximum number of GPUs. The value must be a positive integer.</para>
        /// <remarks>
        /// <para> If an instance type provides more GPUs than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaximumGPUAmount")]
        [Validation(Required=false)]
        public int? MaximumGPUAmount { get; set; }

        /// <summary>
        /// <para>The maximum memory size. Unit: GiB.</para>
        /// <remarks>
        /// <para> If the memory size of an instance type is larger than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("MaximumMemorySize")]
        [Validation(Required=false)]
        public float? MaximumMemorySize { get; set; }

        /// <summary>
        /// <para>The minimum baseline CPU performance (overall baseline performance of all vCPUs) of a t5 or t6 burstable instance.</para>
        /// <remarks>
        /// <para> If a t5 or t6 instance type provides baseline CPU performance lower than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("MinimumBaselineCredit")]
        [Validation(Required=false)]
        public int? MinimumBaselineCredit { get; set; }

        /// <summary>
        /// <para>The minimum number of vCPUs. The value must be a positive integer.</para>
        /// <remarks>
        /// <para> If an instance type has fewer vCPUs than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinimumCpuCoreCount")]
        [Validation(Required=false)]
        public int? MinimumCpuCoreCount { get; set; }

        /// <summary>
        /// <para>The minimum clock speed.</para>
        /// <remarks>
        /// <para> If an instance type uses processors that have a lower clock speed than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2.5</para>
        /// </summary>
        [NameInMap("MinimumCpuSpeedFrequency")]
        [Validation(Required=false)]
        public float? MinimumCpuSpeedFrequency { get; set; }

        /// <summary>
        /// <para>The minimum turbo frequency.</para>
        /// <remarks>
        /// <para> If an instance type uses processors that deliver a lower turbo frequency than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3.2</para>
        /// </summary>
        [NameInMap("MinimumCpuTurboFrequency")]
        [Validation(Required=false)]
        public float? MinimumCpuTurboFrequency { get; set; }

        /// <summary>
        /// <para>The minimum number of cloud disks per instance.</para>
        /// <remarks>
        /// <para> If an instance type supports fewer cloud disks than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MinimumDiskQuantity")]
        [Validation(Required=false)]
        public int? MinimumDiskQuantity { get; set; }

        /// <summary>
        /// <para>The minimum number of IPv6 addresses per ENI.</para>
        /// <remarks>
        /// <para> If an instance type supports fewer IPv6 addresses per ENI than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinimumEniIpv6AddressQuantity")]
        [Validation(Required=false)]
        public int? MinimumEniIpv6AddressQuantity { get; set; }

        /// <summary>
        /// <para>The minimum number of IPv4 addresses per ENI.</para>
        /// <remarks>
        /// <para> If an instance type supports fewer IPv4 addresses per ENI than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinimumEniPrivateIpAddressQuantity")]
        [Validation(Required=false)]
        public int? MinimumEniPrivateIpAddressQuantity { get; set; }

        /// <summary>
        /// <para>The minimum number of elastic network interfaces (ENIs) per instance.</para>
        /// <remarks>
        /// <para> If an instance type supports fewer ENIs than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MinimumEniQuantity")]
        [Validation(Required=false)]
        public int? MinimumEniQuantity { get; set; }

        /// <summary>
        /// <para>The minimum number of ERIs per instance.</para>
        /// <remarks>
        /// <para> If an instance type supports fewer ERIs than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MinimumEriQuantity")]
        [Validation(Required=false)]
        public int? MinimumEriQuantity { get; set; }

        /// <summary>
        /// <para>The minimum number of GPUs. The value must be a positive integer.</para>
        /// <remarks>
        /// <para> If an instance type provides fewer GPUs than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MinimumGPUAmount")]
        [Validation(Required=false)]
        public int? MinimumGPUAmount { get; set; }

        /// <summary>
        /// <para>The minimum initial CPU credits of a t5 or t6 burstable instance.</para>
        /// <remarks>
        /// <para> If a t5 or t6 instance type provides less initial vCPU credits than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("MinimumInitialCredit")]
        [Validation(Required=false)]
        public int? MinimumInitialCredit { get; set; }

        /// <summary>
        /// <para>The minimum inbound internal bandwidth. Unit: Kbit/s.</para>
        /// <remarks>
        /// <para> If an instance type provides an inbound internal bandwidth that is lower than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12288</para>
        /// </summary>
        [NameInMap("MinimumInstanceBandwidthRx")]
        [Validation(Required=false)]
        public int? MinimumInstanceBandwidthRx { get; set; }

        /// <summary>
        /// <para>The minimum outbound internal bandwidth. Unit: Kbit/s.</para>
        /// <remarks>
        /// <para> If an instance type provides an outbound internal bandwidth that is lower than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12288</para>
        /// </summary>
        [NameInMap("MinimumInstanceBandwidthTx")]
        [Validation(Required=false)]
        public int? MinimumInstanceBandwidthTx { get; set; }

        /// <summary>
        /// <para>The minimum inbound packet forwarding rate over the internal network. Unit: pps.</para>
        /// <remarks>
        /// <para> If an instance type provides an inbound packet forwarding rate over the internal network that is lower than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("MinimumInstancePpsRx")]
        [Validation(Required=false)]
        public long? MinimumInstancePpsRx { get; set; }

        /// <summary>
        /// <para>The minimum outbound packet forwarding rate over the internal network. Unit: pps.</para>
        /// <remarks>
        /// <para> If an instance type provides an outbound packet forwarding rate over the internal network that is lower than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("MinimumInstancePpsTx")]
        [Validation(Required=false)]
        public long? MinimumInstancePpsTx { get; set; }

        /// <summary>
        /// <para>The minimum number of local disks per instance.</para>
        /// <remarks>
        /// <para> If an instance type supports fewer local disks than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MinimumLocalStorageAmount")]
        [Validation(Required=false)]
        public int? MinimumLocalStorageAmount { get; set; }

        /// <summary>
        /// <para>The capacity of each local disk attached per instance. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MinimumLocalStorageCapacity")]
        [Validation(Required=false)]
        public long? MinimumLocalStorageCapacity { get; set; }

        /// <summary>
        /// <para>The minimum memory size. Unit: GiB.</para>
        /// <remarks>
        /// <para> If the memory size of an instance type is smaller than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MinimumMemorySize")]
        [Validation(Required=false)]
        public float? MinimumMemorySize { get; set; }

        /// <summary>
        /// <para>The minimum default number of queues per primary network interface controller (NIC).</para>
        /// <remarks>
        /// <para> If an instance type supports fewer queues per primary NIC than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("MinimumPrimaryEniQueueNumber")]
        [Validation(Required=false)]
        public int? MinimumPrimaryEniQueueNumber { get; set; }

        /// <summary>
        /// <para>The minimum number of queue pair (QP) queues per elastic RDMA interface (ERI).</para>
        /// <remarks>
        /// <para> If an instance type supports fewer QP queues per ERI than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("MinimumQueuePairNumber")]
        [Validation(Required=false)]
        public int? MinimumQueuePairNumber { get; set; }

        /// <summary>
        /// <para>The minimum default number of queues per secondary NIC.</para>
        /// <remarks>
        /// <para> If an instance type supports fewer queues per secondary NIC than the specified value, information about the instance type is not queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MinimumSecondaryEniQueueNumber")]
        [Validation(Required=false)]
        public int? MinimumSecondaryEniQueueNumber { get; set; }

        /// <summary>
        /// <para>The query token. Set the value to the NextToken value returned in the previous call to the DescribeInstanceTypes operation. You do not need to specify this parameter for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e71d8a535bd9cc11</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Specifies whether cloud disks can be attached by using the NVMe protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>required: Cloud disks can be attached by using the NVMe protocol.</description></item>
        /// <item><description>unsupported: Cloud disks cannot be attached by using the NVMe protocol.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>required</para>
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
        /// <para>The CPU model.</para>
        /// <remarks>
        /// <para> Fuzzy match is supported. For example, if an instance type uses Intel Xeon (Ice Lake) Platinum 8369B processors and you set this parameter to Intel, information about the instance type is queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Intel Xeon(Ice Lake) Platinum 8369B</para>
        /// </summary>
        [NameInMap("PhysicalProcessorModel")]
        [Validation(Required=false)]
        public string PhysicalProcessorModel { get; set; }

        /// <summary>
        /// <para>The CPU models of instance types. Valid values of N: 1 to 10.</para>
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

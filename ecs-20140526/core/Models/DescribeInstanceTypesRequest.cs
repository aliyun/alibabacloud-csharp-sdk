// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceTypesRequest : TeaModel {
        /// <summary>
        /// <para>The list of advanced instance type features to return.</para>
        /// </summary>
        [NameInMap("AdditionalAttributes")]
        [Validation(Required=false)]
        public List<string> AdditionalAttributes { get; set; }

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
        /// <para>The array of CPU architectures to query. Array length: 1 to 2.</para>
        /// </summary>
        [NameInMap("CpuArchitectures")]
        [Validation(Required=false)]
        public List<string> CpuArchitectures { get; set; }

        /// <summary>
        /// <para>The GPU type.</para>
        /// <remarks>
        /// <para>Fuzzy match is supported. For example, if the GPU type of an instance type is NVIDIA V100, you can enter NVIDIA to query the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>NVIDIA V100</para>
        /// </summary>
        [NameInMap("GPUSpec")]
        [Validation(Required=false)]
        public string GPUSpec { get; set; }

        /// <summary>
        /// <para>The specified array of GPU types to query. Array length: 1 to 10.</para>
        /// </summary>
        [NameInMap("GpuSpecs")]
        [Validation(Required=false)]
        public List<string> GpuSpecs { get; set; }

        /// <summary>
        /// <para>The array of instance type categorizations to query. Array length: 1 to 10.</para>
        /// </summary>
        [NameInMap("InstanceCategories")]
        [Validation(Required=false)]
        public List<string> InstanceCategories { get; set; }

        /// <summary>
        /// <para>The categorization of the instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>General-purpose: General-purpose.</description></item>
        /// <item><description>Compute-optimized: Compute-optimized.</description></item>
        /// <item><description>Memory-optimized: Memory-optimized.</description></item>
        /// <item><description>Big data: Big data.</description></item>
        /// <item><description>Local SSDs: Local SSDs.</description></item>
        /// <item><description>High Clock Speed: High clock speed.</description></item>
        /// <item><description>Enhanced: enhanced instance families.</description></item>
        /// <item><description>Shared: Shared.</description></item>
        /// <item><description>Compute-optimized with GPU: GPU computing.</description></item>
        /// <item><description>Visual Compute-optimized: Visual compute-optimized.</description></item>
        /// <item><description>Heterogeneous Service: Heterogeneous service.</description></item>
        /// <item><description>Compute-optimized with FPGA: FPGA-accelerated compute-optimized.</description></item>
        /// <item><description>Compute-optimized with NPU: NPU-accelerated compute-optimized.</description></item>
        /// <item><description>ECS Bare Metal: ECS Bare Metal.</description></item>
        /// <item><description>Super Computing Cluster: Super Computing Cluster (SCC).</description></item>
        /// <item><description>High Performance Compute: high-performance computing (HPC) compute-optimized.</description></item>
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
        /// <item><description>EntryLevel: Entry-level (shared).</description></item>
        /// <item><description>EnterpriseLevel: Enterprise-level.</description></item>
        /// <item><description>CreditEntryLevel: Credit entry-level.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EntryLevel</para>
        /// </summary>
        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        /// <summary>
        /// <para>The specified array of instance families to query. Array length: 1 to 10.</para>
        /// </summary>
        [NameInMap("InstanceTypeFamilies")]
        [Validation(Required=false)]
        public List<string> InstanceTypeFamilies { get; set; }

        /// <summary>
        /// <para>The instance family to which the instance type belongs. For valid values, see <a href="https://help.aliyun.com/document_detail/25621.html">DescribeInstanceTypeFamilies</a>.</para>
        /// <para>For more information about instance families, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6</para>
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        /// <summary>
        /// <para>The specified array of instance types. Array length: 1 to 10. If this parameter is not specified, the information of all instance types is queried by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The array of local disk categories to query. Array length: 1 to 2.</para>
        /// </summary>
        [NameInMap("LocalStorageCategories")]
        [Validation(Required=false)]
        public List<string> LocalStorageCategories { get; set; }

        /// <summary>
        /// <para>The type of the local disk. For more information, see <a href="~~63138#section_n2w_8yc_5u1~~">Local disks</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>local_hdd_pro: SATA HDD local disks equipped with the d1ne and d1 instance families.</description></item>
        /// <item><description>local_ssd_pro: NVMe SSD local disks equipped with instance families such as i2, i2g, i1, ga1, and gn5.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>local_ssd_pro</para>
        /// </summary>
        [NameInMap("LocalStorageCategory")]
        [Validation(Required=false)]
        public string LocalStorageCategory { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page for paging queries. Maximum value: 1600.</para>
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
        /// <para>The maximum expected number of vCPU cores when querying instance types. Valid values: positive integers.</para>
        /// <remarks>
        /// <para>If the number of vCPU cores of an instance type is greater than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaximumCpuCoreCount")]
        [Validation(Required=false)]
        public int? MaximumCpuCoreCount { get; set; }

        /// <summary>
        /// <para>The maximum expected clock speed when querying instance types.</para>
        /// <remarks>
        /// <para>If the clock speed of an instance type is greater than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3.2</para>
        /// </summary>
        [NameInMap("MaximumCpuSpeedFrequency")]
        [Validation(Required=false)]
        public float? MaximumCpuSpeedFrequency { get; set; }

        /// <summary>
        /// <para>The maximum expected turbo frequency when querying instance types.</para>
        /// <remarks>
        /// <para>If the turbo frequency of an instance type is greater than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4.1</para>
        /// </summary>
        [NameInMap("MaximumCpuTurboFrequency")]
        [Validation(Required=false)]
        public float? MaximumCpuTurboFrequency { get; set; }

        /// <summary>
        /// <para>The maximum expected number of GPUs when querying instance types. Valid values: positive integers.</para>
        /// <remarks>
        /// <para>If the number of GPUs of an instance type is greater than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaximumGPUAmount")]
        [Validation(Required=false)]
        public int? MaximumGPUAmount { get; set; }

        /// <summary>
        /// <para>The maximum expected memory size when querying instance types. Unit: GiB.</para>
        /// <remarks>
        /// <para>If the memory size of an instance type is greater than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("MaximumMemorySize")]
        [Validation(Required=false)]
        public float? MaximumMemorySize { get; set; }

        /// <summary>
        /// <para>The minimum expected baseline vCPU computing performance (sum of all vCPUs) of burstable instances t5 and t6 when querying instance types.</para>
        /// <remarks>
        /// <para>If the baseline vCPU computing performance (sum of all vCPUs) of a burstable instance t5 or t6 is less than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("MinimumBaselineCredit")]
        [Validation(Required=false)]
        public int? MinimumBaselineCredit { get; set; }

        /// <summary>
        /// <para>The minimum expected number of vCPU cores when querying instance types. Valid values: positive integers.</para>
        /// <remarks>
        /// <para>If the number of vCPU cores of an instance type is less than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinimumCpuCoreCount")]
        [Validation(Required=false)]
        public int? MinimumCpuCoreCount { get; set; }

        /// <summary>
        /// <para>The minimum expected clock speed when querying instance types.</para>
        /// <remarks>
        /// <para>If the clock speed of an instance type is less than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2.5</para>
        /// </summary>
        [NameInMap("MinimumCpuSpeedFrequency")]
        [Validation(Required=false)]
        public float? MinimumCpuSpeedFrequency { get; set; }

        /// <summary>
        /// <para>The minimum expected turbo frequency when querying instance types.</para>
        /// <remarks>
        /// <para>If the turbo frequency of an instance type is less than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3.2</para>
        /// </summary>
        [NameInMap("MinimumCpuTurboFrequency")]
        [Validation(Required=false)]
        public float? MinimumCpuTurboFrequency { get; set; }

        /// <summary>
        /// <para>The minimum expected maximum number of cloud disks that can be attached when querying instance types.</para>
        /// <remarks>
        /// <para>If the maximum number of cloud disks that can be attached to an instance type is less than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MinimumDiskQuantity")]
        [Validation(Required=false)]
        public int? MinimumDiskQuantity { get; set; }

        /// <summary>
        /// <para>The minimum expected maximum number of IPv6 addresses per Elastic Network Interface (ENI) network interface controller (NIC) when querying instance types.</para>
        /// <remarks>
        /// <para>If the maximum number of IPv6 addresses per Elastic Network Interface (ENI) network interface controller (NIC) of an instance type is less than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinimumEniIpv6AddressQuantity")]
        [Validation(Required=false)]
        public int? MinimumEniIpv6AddressQuantity { get; set; }

        /// <summary>
        /// <para>The minimum expected maximum number of IPv4 addresses per Elastic Network Interface (ENI) network interface controller (NIC) when querying instance types.</para>
        /// <remarks>
        /// <para>If the maximum number of IPv4 addresses per Elastic Network Interface (ENI) network interface controller (NIC) of an instance type is less than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinimumEniPrivateIpAddressQuantity")]
        [Validation(Required=false)]
        public int? MinimumEniPrivateIpAddressQuantity { get; set; }

        /// <summary>
        /// <para>The minimum expected maximum number of Elastic Network Interface (ENI) network interface controller (NIC) that can be attached when querying instance types.</para>
        /// <remarks>
        /// <para>If the maximum number of Elastic Network Interface (ENI) network interface controller (NIC) that can be attached to an instance type is less than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MinimumEniQuantity")]
        [Validation(Required=false)]
        public int? MinimumEniQuantity { get; set; }

        /// <summary>
        /// <para>The minimum expected number of Elastic RDMA Interface (ERI) Elastic RDMA network interface controller (NIC) when querying instance types.</para>
        /// <remarks>
        /// <para>If the number of Elastic RDMA Interface (ERI) Elastic RDMA network interface controller (NIC) of an instance type is less than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MinimumEriQuantity")]
        [Validation(Required=false)]
        public int? MinimumEriQuantity { get; set; }

        /// <summary>
        /// <para>The minimum expected number of GPUs when querying instance types. Valid values: positive integers.</para>
        /// <remarks>
        /// <para>If the number of GPUs of an instance type is less than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MinimumGPUAmount")]
        [Validation(Required=false)]
        public int? MinimumGPUAmount { get; set; }

        /// <summary>
        /// <para>The minimum expected initial vCPU credits of burstable instances t5 and t6 when querying instance types.</para>
        /// <remarks>
        /// <para>If the initial vCPU credits of a burstable instance t5 or t6 are less than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("MinimumInitialCredit")]
        [Validation(Required=false)]
        public int? MinimumInitialCredit { get; set; }

        /// <summary>
        /// <para>The minimum expected inbound internal bandwidth limit when querying instance types. Unit: kbit/s.</para>
        /// <remarks>
        /// <para>If the inbound internal bandwidth limit of an instance type is less than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12288</para>
        /// </summary>
        [NameInMap("MinimumInstanceBandwidthRx")]
        [Validation(Required=false)]
        public int? MinimumInstanceBandwidthRx { get; set; }

        /// <summary>
        /// <para>The minimum expected outbound internal bandwidth limit when querying instance types. Unit: kbit/s.</para>
        /// <remarks>
        /// <para>If the outbound internal bandwidth limit of an instance type is less than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12288</para>
        /// </summary>
        [NameInMap("MinimumInstanceBandwidthTx")]
        [Validation(Required=false)]
        public int? MinimumInstanceBandwidthTx { get; set; }

        /// <summary>
        /// <para>The minimum expected inbound internal network packet forwarding rate when querying instance types. Unit: pps.</para>
        /// <remarks>
        /// <para>If the inbound internal network packet forwarding rate of an instance type is less than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("MinimumInstancePpsRx")]
        [Validation(Required=false)]
        public long? MinimumInstancePpsRx { get; set; }

        /// <summary>
        /// <para>The minimum expected outbound internal network packet forwarding rate when querying instance types. Unit: pps.</para>
        /// <remarks>
        /// <para>If the outbound internal network packet forwarding rate of an instance type is less than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("MinimumInstancePpsTx")]
        [Validation(Required=false)]
        public long? MinimumInstancePpsTx { get; set; }

        /// <summary>
        /// <para>The minimum expected number of local disks attached to the instance when querying instance types.</para>
        /// <remarks>
        /// <para>If the number of local disks attached to an instance type is less than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MinimumLocalStorageAmount")]
        [Validation(Required=false)]
        public int? MinimumLocalStorageAmount { get; set; }

        /// <summary>
        /// <para>The capacity of a single local disk attached to the instance. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MinimumLocalStorageCapacity")]
        [Validation(Required=false)]
        public long? MinimumLocalStorageCapacity { get; set; }

        /// <summary>
        /// <para>The minimum expected memory size when querying instance types. Unit: GiB.</para>
        /// <remarks>
        /// <para>If the memory size of an instance type is less than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MinimumMemorySize")]
        [Validation(Required=false)]
        public float? MinimumMemorySize { get; set; }

        /// <summary>
        /// <para>The minimum expected default number of queues for the primary ENI when querying instance types.</para>
        /// <remarks>
        /// <para>If the default number of queues for the primary ENI of an instance type is less than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("MinimumPrimaryEniQueueNumber")]
        [Validation(Required=false)]
        public int? MinimumPrimaryEniQueueNumber { get; set; }

        /// <summary>
        /// <para>The minimum expected maximum number of Queue Pair (QP) queues per Elastic RDMA Interface (ERI) when querying instance types.</para>
        /// <remarks>
        /// <para>If the maximum number of QP queues per ERI of an instance type is less than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("MinimumQueuePairNumber")]
        [Validation(Required=false)]
        public int? MinimumQueuePairNumber { get; set; }

        /// <summary>
        /// <para>The minimum expected default number of queues for secondary Elastic Network Interface (ENI) network interface controller (NIC) when querying instance types.</para>
        /// <remarks>
        /// <para>If the default number of queues for secondary Elastic Network Interface (ENI) network interface controller (NIC) of an instance type is less than the specified value, the system does not return the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MinimumSecondaryEniQueueNumber")]
        [Validation(Required=false)]
        public int? MinimumSecondaryEniQueueNumber { get; set; }

        /// <summary>
        /// <para>The query token. Set the value to the NextToken value returned from the last call to this operation. You do not need to specify this parameter for the first call.</para>
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
        /// <para>Specifies whether the cloud disks attached to the instance type support NVMe. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>required: Supported. Indicates that cloud disks are attached over NVMe.</description></item>
        /// <item><description>unsupported: Not supported. Indicates that cloud disks are not attached over NVMe.</description></item>
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
        /// <para>The processor model.</para>
        /// <remarks>
        /// <para>Fuzzy match is supported. For example, if the processor model of an instance type is Intel Xeon (Ice Lake) Platinum 8369B, you can enter Intel to query the information of the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Intel Xeon(Ice Lake) Platinum 8369B</para>
        /// </summary>
        [NameInMap("PhysicalProcessorModel")]
        [Validation(Required=false)]
        public string PhysicalProcessorModel { get; set; }

        /// <summary>
        /// <para>The array of physical processor models to query. Array length: 1 to 10.</para>
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

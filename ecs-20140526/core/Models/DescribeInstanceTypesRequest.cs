// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceTypesRequest : TeaModel {
        /// <summary>
        /// <para>The list of advanced features to return for instance types.</para>
        /// </summary>
        [NameInMap("AdditionalAttributes")]
        [Validation(Required=false)]
        public List<string> AdditionalAttributes { get; set; }

        /// <summary>
        /// <para>The CPU architecture. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>X86.</description></item>
        /// <item><description>ARM.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>X86</para>
        /// </summary>
        [NameInMap("CpuArchitecture")]
        [Validation(Required=false)]
        public string CpuArchitecture { get; set; }

        /// <summary>
        /// <para>The CPU architectures to query. Array length: 1 to 2.</para>
        /// </summary>
        [NameInMap("CpuArchitectures")]
        [Validation(Required=false)]
        public List<string> CpuArchitectures { get; set; }

        /// <summary>
        /// <para>The GPU type.</para>
        /// <remarks>
        /// <para>Fuzzy matching is supported. For example, if the GPU type of an instance type is NVIDIA V100, you can enter NVIDIA to query the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>NVIDIA V100</para>
        /// </summary>
        [NameInMap("GPUSpec")]
        [Validation(Required=false)]
        public string GPUSpec { get; set; }

        /// <summary>
        /// <para>The GPU types to query. Array length: 1 to 10.</para>
        /// </summary>
        [NameInMap("GpuSpecs")]
        [Validation(Required=false)]
        public List<string> GpuSpecs { get; set; }

        /// <summary>
        /// <para>The instance type categories to query. Array length: 1 to 10.</para>
        /// </summary>
        [NameInMap("InstanceCategories")]
        [Validation(Required=false)]
        public List<string> InstanceCategories { get; set; }

        /// <summary>
        /// <para>The category of the instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>General-purpose: general-purpose instance type.</description></item>
        /// <item><description>Compute-optimized: compute-optimized instance type.</description></item>
        /// <item><description>Memory-optimized: memory-optimized instance type.</description></item>
        /// <item><description>Big data: big data instance type.</description></item>
        /// <item><description>Local SSDs: local SSD instance type.</description></item>
        /// <item><description>High Clock Speed: high clock speed instance type.</description></item>
        /// <item><description>Enhanced: enhanced instance type.</description></item>
        /// <item><description>Shared: shared instance type.</description></item>
        /// <item><description>Compute-optimized with GPU: GPU-accelerated compute-optimized instance type.</description></item>
        /// <item><description>Visual Compute-optimized: visual compute-optimized instance type.</description></item>
        /// <item><description>Heterogeneous Service: heterogeneous service instance type.</description></item>
        /// <item><description>Compute-optimized with FPGA: FPGA-accelerated compute-optimized instance type.</description></item>
        /// <item><description>Compute-optimized with NPU: NPU-accelerated compute-optimized instance type.</description></item>
        /// <item><description>ECS Bare Metal: ECS Bare Metal Instance.</description></item>
        /// <item><description>Super Computing Cluster: Super Computing Cluster instance type.</description></item>
        /// <item><description>High Performance Compute: high-performance computing instance type.</description></item>
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
        /// <item><description>EntryLevel: entry level (shared).</description></item>
        /// <item><description>EnterpriseLevel: enterprise level.</description></item>
        /// <item><description>CreditEntryLevel: credit-based entry level.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EntryLevel</para>
        /// </summary>
        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        /// <summary>
        /// <para>The instance families to query. Array length: 1 to 10.</para>
        /// </summary>
        [NameInMap("InstanceTypeFamilies")]
        [Validation(Required=false)]
        public List<string> InstanceTypeFamilies { get; set; }

        /// <summary>
        /// <para>The instance family that the instance type belongs to. For valid values, see <a href="https://help.aliyun.com/document_detail/25621.html">DescribeInstanceTypeFamilies</a>.</para>
        /// <para>For more information about instance families, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6</para>
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        /// <summary>
        /// <para>The specified instance types. Array length: 1 to 10. If this parameter is not specified, information about all instance types is queried by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The local disk categories to query. Array length: 1 to 2.</para>
        /// </summary>
        [NameInMap("LocalStorageCategories")]
        [Validation(Required=false)]
        public List<string> LocalStorageCategories { get; set; }

        /// <summary>
        /// <para>The category of local disks. For more information, see <a href="~~63138#section_n2w_8yc_5u1~~">Local disks</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>local_hdd_pro: SATA HDDs used by the d1ne and d1 instance families.</description></item>
        /// <item><description>local_ssd_pro: NVMe SSDs used by the i2, i2g, i1, ga1, and gn5 instance families.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>local_ssd_pro</para>
        /// </summary>
        [NameInMap("LocalStorageCategory")]
        [Validation(Required=false)]
        public string LocalStorageCategory { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for a paginated query. Maximum value: 1600.</para>
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
        /// <para>The maximum number of vCPU cores when you query instance types. Valid values: positive integers.</para>
        /// <remarks>
        /// <para>Instance types with more vCPU cores than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaximumCpuCoreCount")]
        [Validation(Required=false)]
        public int? MaximumCpuCoreCount { get; set; }

        /// <summary>
        /// <para>The maximum CPU base clock speed when you query instance types.</para>
        /// <remarks>
        /// <para>Instance types with a base clock speed higher than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3.2</para>
        /// </summary>
        [NameInMap("MaximumCpuSpeedFrequency")]
        [Validation(Required=false)]
        public float? MaximumCpuSpeedFrequency { get; set; }

        /// <summary>
        /// <para>The maximum CPU turbo frequency when you query instance types.</para>
        /// <remarks>
        /// <para>Instance types with a turbo frequency higher than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4.1</para>
        /// </summary>
        [NameInMap("MaximumCpuTurboFrequency")]
        [Validation(Required=false)]
        public float? MaximumCpuTurboFrequency { get; set; }

        /// <summary>
        /// <para>The maximum number of GPUs when you query instance types. Valid values: positive integers.</para>
        /// <remarks>
        /// <para>Instance types with more GPUs than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaximumGPUAmount")]
        [Validation(Required=false)]
        public int? MaximumGPUAmount { get; set; }

        /// <summary>
        /// <para>The maximum memory size when you query instance types. Unit: GiB.</para>
        /// <remarks>
        /// <para>Instance types with a memory size larger than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("MaximumMemorySize")]
        [Validation(Required=false)]
        public float? MaximumMemorySize { get; set; }

        /// <summary>
        /// <para>The minimum baseline vCPU computing performance (total of all vCPUs) for burstable instance types t5 and t6 when you query instance types.</para>
        /// <remarks>
        /// <para>Instance types with a baseline vCPU computing performance lower than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("MinimumBaselineCredit")]
        [Validation(Required=false)]
        public int? MinimumBaselineCredit { get; set; }

        /// <summary>
        /// <para>The minimum number of vCPU cores when you query instance types. Valid values: positive integers.</para>
        /// <remarks>
        /// <para>Instance types with fewer vCPU cores than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinimumCpuCoreCount")]
        [Validation(Required=false)]
        public int? MinimumCpuCoreCount { get; set; }

        /// <summary>
        /// <para>The minimum CPU base clock speed when you query instance types.</para>
        /// <remarks>
        /// <para>Instance types with a base clock speed lower than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2.5</para>
        /// </summary>
        [NameInMap("MinimumCpuSpeedFrequency")]
        [Validation(Required=false)]
        public float? MinimumCpuSpeedFrequency { get; set; }

        /// <summary>
        /// <para>The minimum CPU turbo frequency when you query instance types.</para>
        /// <remarks>
        /// <para>Instance types with a turbo frequency lower than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3.2</para>
        /// </summary>
        [NameInMap("MinimumCpuTurboFrequency")]
        [Validation(Required=false)]
        public float? MinimumCpuTurboFrequency { get; set; }

        /// <summary>
        /// <para>The minimum number of cloud disks that can be attached when you query instance types.</para>
        /// <remarks>
        /// <para>Instance types that support fewer cloud disks than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MinimumDiskQuantity")]
        [Validation(Required=false)]
        public int? MinimumDiskQuantity { get; set; }

        /// <summary>
        /// <para>The minimum number of IPv6 addresses per ENI when you query instance types.</para>
        /// <remarks>
        /// <para>Instance types that support fewer IPv6 addresses per ENI than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinimumEniIpv6AddressQuantity")]
        [Validation(Required=false)]
        public int? MinimumEniIpv6AddressQuantity { get; set; }

        /// <summary>
        /// <para>The minimum number of IPv4 addresses per ENI when you query instance types.</para>
        /// <remarks>
        /// <para>Instance types that support fewer IPv4 addresses per ENI than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinimumEniPrivateIpAddressQuantity")]
        [Validation(Required=false)]
        public int? MinimumEniPrivateIpAddressQuantity { get; set; }

        /// <summary>
        /// <para>The minimum number of ENIs that can be attached when you query instance types.</para>
        /// <remarks>
        /// <para>Instance types that support fewer ENIs than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MinimumEniQuantity")]
        [Validation(Required=false)]
        public int? MinimumEniQuantity { get; set; }

        /// <summary>
        /// <para>The minimum number of ERIs when you query instance types.</para>
        /// <remarks>
        /// <para>Instance types with fewer ERIs than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MinimumEriQuantity")]
        [Validation(Required=false)]
        public int? MinimumEriQuantity { get; set; }

        /// <summary>
        /// <para>The minimum number of GPUs when you query instance types. Valid values: positive integers.</para>
        /// <remarks>
        /// <para>Instance types with fewer GPUs than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MinimumGPUAmount")]
        [Validation(Required=false)]
        public int? MinimumGPUAmount { get; set; }

        /// <summary>
        /// <para>The minimum initial vCPU credits for burstable instance types t5 and t6 when you query instance types.</para>
        /// <remarks>
        /// <para>Instance types with initial vCPU credits lower than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("MinimumInitialCredit")]
        [Validation(Required=false)]
        public int? MinimumInitialCredit { get; set; }

        /// <summary>
        /// <para>The minimum inbound internal bandwidth when you query instance types. Unit: kbit/s.</para>
        /// <remarks>
        /// <para>Instance types with an inbound internal bandwidth lower than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12288</para>
        /// </summary>
        [NameInMap("MinimumInstanceBandwidthRx")]
        [Validation(Required=false)]
        public int? MinimumInstanceBandwidthRx { get; set; }

        /// <summary>
        /// <para>The minimum outbound internal bandwidth when you query instance types. Unit: kbit/s.</para>
        /// <remarks>
        /// <para>Instance types with an outbound internal bandwidth lower than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12288</para>
        /// </summary>
        [NameInMap("MinimumInstanceBandwidthTx")]
        [Validation(Required=false)]
        public int? MinimumInstanceBandwidthTx { get; set; }

        /// <summary>
        /// <para>The minimum inbound packet forwarding rate over the internal network when you query instance types. Unit: pps.</para>
        /// <remarks>
        /// <para>Instance types with an inbound packet forwarding rate lower than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("MinimumInstancePpsRx")]
        [Validation(Required=false)]
        public long? MinimumInstancePpsRx { get; set; }

        /// <summary>
        /// <para>The minimum outbound packet forwarding rate over the internal network when you query instance types. Unit: pps.</para>
        /// <remarks>
        /// <para>Instance types with an outbound packet forwarding rate lower than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("MinimumInstancePpsTx")]
        [Validation(Required=false)]
        public long? MinimumInstancePpsTx { get; set; }

        /// <summary>
        /// <para>The minimum number of local disks attached to the instance when you query instance types.</para>
        /// <remarks>
        /// <para>Instance types with fewer local disks than the specified value are not returned.</para>
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
        /// <para>The minimum memory size when you query instance types. Unit: GiB.</para>
        /// <remarks>
        /// <para>Instance types with a memory size smaller than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MinimumMemorySize")]
        [Validation(Required=false)]
        public float? MinimumMemorySize { get; set; }

        /// <summary>
        /// <para>The minimum default number of queues supported by the primary ENI when you query instance types.</para>
        /// <remarks>
        /// <para>Instance types with fewer default queues on the primary ENI than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("MinimumPrimaryEniQueueNumber")]
        [Validation(Required=false)]
        public int? MinimumPrimaryEniQueueNumber { get; set; }

        /// <summary>
        /// <para>The minimum number of QueuePair (QP) queues per Elastic RDMA Interface (ERI) when you query instance types.</para>
        /// <remarks>
        /// <para>Instance types with fewer QP queues per ERI than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("MinimumQueuePairNumber")]
        [Validation(Required=false)]
        public int? MinimumQueuePairNumber { get; set; }

        /// <summary>
        /// <para>The minimum default number of queues supported by the secondary ENI when you query instance types.</para>
        /// <remarks>
        /// <para>Instance types with fewer default queues on the secondary ENI than the specified value are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MinimumSecondaryEniQueueNumber")]
        [Validation(Required=false)]
        public int? MinimumSecondaryEniQueueNumber { get; set; }

        /// <summary>
        /// <para>The pagination token. Set this parameter to the NextToken value returned in the previous call to this API operation. You do not need to set this parameter for the first request.</para>
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
        /// <para>Indicates whether cloud disks attached to the instance type support NVMe. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>required: supported. Cloud disks are attached in NVMe mode.</description></item>
        /// <item><description>unsupported: not supported. Cloud disks are not attached in NVMe mode.</description></item>
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
        /// <para>Fuzzy matching is supported. For example, if the processor model of an instance type is Intel Xeon(Ice Lake) Platinum 8369B, you can enter Intel to query the instance type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Intel Xeon(Ice Lake) Platinum 8369B</para>
        /// </summary>
        [NameInMap("PhysicalProcessorModel")]
        [Validation(Required=false)]
        public string PhysicalProcessorModel { get; set; }

        /// <summary>
        /// <para>The processor models to query. Array length: 1 to 10.</para>
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

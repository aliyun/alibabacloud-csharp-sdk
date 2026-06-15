// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceTypesRequest : TeaModel {
        /// <summary>
        /// <para>The advanced attributes of the instance type to return.</para>
        /// </summary>
        [NameInMap("AdditionalAttributes")]
        [Validation(Required=false)]
        public List<string> AdditionalAttributes { get; set; }

        /// <summary>
        /// <para>The CPU architecture. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>X86</para>
        /// </description></item>
        /// <item><description><para>ARM</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>X86</para>
        /// </summary>
        [NameInMap("CpuArchitecture")]
        [Validation(Required=false)]
        public string CpuArchitecture { get; set; }

        /// <summary>
        /// <para>An array of 1 to 2 CPU architectures.</para>
        /// </summary>
        [NameInMap("CpuArchitectures")]
        [Validation(Required=false)]
        public List<string> CpuArchitectures { get; set; }

        /// <summary>
        /// <para>The GPU type.</para>
        /// <remarks>
        /// <para>This parameter supports fuzzy search. For example, specifying <c>NVIDIA</c> returns instance types with <c>NVIDIA V100</c> GPUs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>NVIDIA V100</para>
        /// </summary>
        [NameInMap("GPUSpec")]
        [Validation(Required=false)]
        public string GPUSpec { get; set; }

        /// <summary>
        /// <para>An array of 1 to 10 GPU types.</para>
        /// </summary>
        [NameInMap("GpuSpecs")]
        [Validation(Required=false)]
        public List<string> GpuSpecs { get; set; }

        /// <summary>
        /// <para>An array of 1 to 10 instance categories.</para>
        /// </summary>
        [NameInMap("InstanceCategories")]
        [Validation(Required=false)]
        public List<string> InstanceCategories { get; set; }

        /// <summary>
        /// <para>The instance category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>General-purpose</para>
        /// </description></item>
        /// <item><description><para>Compute-optimized</para>
        /// </description></item>
        /// <item><description><para>Memory-optimized</para>
        /// </description></item>
        /// <item><description><para>Big data</para>
        /// </description></item>
        /// <item><description><para>Local SSDs</para>
        /// </description></item>
        /// <item><description><para>High clock speed</para>
        /// </description></item>
        /// <item><description><para>Enhanced</para>
        /// </description></item>
        /// <item><description><para>Shared</para>
        /// </description></item>
        /// <item><description><para>Compute-optimized with GPU</para>
        /// </description></item>
        /// <item><description><para>Visual Compute-optimized</para>
        /// </description></item>
        /// <item><description><para>Heterogeneous service</para>
        /// </description></item>
        /// <item><description><para>Compute-optimized with FPGA</para>
        /// </description></item>
        /// <item><description><para>Compute-optimized with NPU</para>
        /// </description></item>
        /// <item><description><para>ECS Bare Metal</para>
        /// </description></item>
        /// <item><description><para>Super Computing Cluster</para>
        /// </description></item>
        /// <item><description><para>High performance compute</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Big data</para>
        /// </summary>
        [NameInMap("InstanceCategory")]
        [Validation(Required=false)]
        public string InstanceCategory { get; set; }

        /// <summary>
        /// <para>The instance family level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>EntryLevel</c>: Entry-level (shared).</para>
        /// </description></item>
        /// <item><description><para><c>EnterpriseLevel</c>: Enterprise-level.</para>
        /// </description></item>
        /// <item><description><para><c>CreditEntryLevel</c>: Credit-based entry-level.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EntryLevel</para>
        /// </summary>
        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        /// <summary>
        /// <para>An array of 1 to 10 instance type families.</para>
        /// </summary>
        [NameInMap("InstanceTypeFamilies")]
        [Validation(Required=false)]
        public List<string> InstanceTypeFamilies { get; set; }

        /// <summary>
        /// <para>The instance type family. For valid values, call the <a href="https://help.aliyun.com/document_detail/25621.html">DescribeInstanceTypeFamilies</a> operation.</para>
        /// <para>For more information about instance type families, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance type families</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6</para>
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        /// <summary>
        /// <para>An array of 1 to 10 instance types. If you do not specify this parameter, the operation returns information about all instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>An array of 1 to 2 local disk categories.</para>
        /// </summary>
        [NameInMap("LocalStorageCategories")]
        [Validation(Required=false)]
        public List<string> LocalStorageCategories { get; set; }

        /// <summary>
        /// <para>The category of local disks. For more information, see <a href="~~63138#section_n2w_8yc_5u1~~">Local disks</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>local_hdd_pro</c>: SATA HDD local disks, supported by d1ne and d1 instance types.</para>
        /// </description></item>
        /// <item><description><para><c>local_ssd_pro</c>: NVMe SSD local disks, supported by i2, i2g, i1, ga1, and gn5 instance types.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>local_ssd_pro</para>
        /// </summary>
        [NameInMap("LocalStorageCategory")]
        [Validation(Required=false)]
        public string LocalStorageCategory { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page. Maximum value: 1600.</para>
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
        /// <para>The maximum number of vCPU cores for the instance type. The value must be a positive integer.</para>
        /// <remarks>
        /// <para>The response excludes instance types with more vCPU cores than this value.</para>
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
        /// <para>The response excludes instance types with a clock speed higher than this value.</para>
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
        /// <para>The response excludes instance types with a turbo frequency higher than this value.</para>
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
        /// <para>The response excludes instance types with more GPUs than this value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaximumGPUAmount")]
        [Validation(Required=false)]
        public int? MaximumGPUAmount { get; set; }

        /// <summary>
        /// <para>The maximum memory size for the instance type. Unit: GiB.</para>
        /// <remarks>
        /// <para>The response excludes instance types with a larger memory size than this value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("MaximumMemorySize")]
        [Validation(Required=false)]
        public float? MaximumMemorySize { get; set; }

        /// <summary>
        /// <para>The minimum baseline vCPU performance of a t5 or t6 burstable performance instance. This value is the sum of the baseline performance of all vCPUs.</para>
        /// <remarks>
        /// <para>The response excludes instance types with a baseline vCPU performance lower than this value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("MinimumBaselineCredit")]
        [Validation(Required=false)]
        public int? MinimumBaselineCredit { get; set; }

        /// <summary>
        /// <para>The minimum number of vCPU cores for the instance type. The value must be a positive integer.</para>
        /// <remarks>
        /// <para>The response excludes instance types with fewer vCPU cores than this value.</para>
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
        /// <para>The response excludes instance types with a clock speed lower than this value.</para>
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
        /// <para>The response excludes instance types with a turbo frequency lower than this value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3.2</para>
        /// </summary>
        [NameInMap("MinimumCpuTurboFrequency")]
        [Validation(Required=false)]
        public float? MinimumCpuTurboFrequency { get; set; }

        /// <summary>
        /// <para>The minimum value for the maximum number of cloud disks that can be attached to the instance type.</para>
        /// <remarks>
        /// <para>The response excludes instance types that support fewer attachable cloud disks than this value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MinimumDiskQuantity")]
        [Validation(Required=false)]
        public int? MinimumDiskQuantity { get; set; }

        /// <summary>
        /// <para>The minimum value for the maximum number of IPv6 addresses that can be assigned to a single elastic network interface.</para>
        /// <remarks>
        /// <para>The response excludes instance types whose ENIs support fewer assignable IPv6 addresses than this value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinimumEniIpv6AddressQuantity")]
        [Validation(Required=false)]
        public int? MinimumEniIpv6AddressQuantity { get; set; }

        /// <summary>
        /// <para>The minimum value for the maximum number of IPv4 addresses that can be assigned to a single elastic network interface.</para>
        /// <remarks>
        /// <para>The response excludes instance types whose ENIs support fewer assignable IPv4 addresses than this value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinimumEniPrivateIpAddressQuantity")]
        [Validation(Required=false)]
        public int? MinimumEniPrivateIpAddressQuantity { get; set; }

        /// <summary>
        /// <para>The minimum value for the maximum number of elastic network interfaces (ENIs) that can be attached to the instance type.</para>
        /// <remarks>
        /// <para>The response excludes instance types that support fewer ENIs than this value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MinimumEniQuantity")]
        [Validation(Required=false)]
        public int? MinimumEniQuantity { get; set; }

        /// <summary>
        /// <para>The minimum number of Elastic RDMA Interfaces (ERIs).</para>
        /// <remarks>
        /// <para>The response excludes instance types that support fewer ERIs than this value.</para>
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
        /// <para>The response excludes instance types with fewer GPUs than this value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MinimumGPUAmount")]
        [Validation(Required=false)]
        public int? MinimumGPUAmount { get; set; }

        /// <summary>
        /// <para>The minimum initial vCPU credits of a t5 or t6 burstable performance instance.</para>
        /// <remarks>
        /// <para>The response excludes instance types with fewer initial vCPU credits than this value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("MinimumInitialCredit")]
        [Validation(Required=false)]
        public int? MinimumInitialCredit { get; set; }

        /// <summary>
        /// <para>The minimum inbound bandwidth over the internal network. Unit: kbit/s.</para>
        /// <remarks>
        /// <para>The response excludes instance types that have a lower inbound bandwidth limit over the internal network than this value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12288</para>
        /// </summary>
        [NameInMap("MinimumInstanceBandwidthRx")]
        [Validation(Required=false)]
        public int? MinimumInstanceBandwidthRx { get; set; }

        /// <summary>
        /// <para>The minimum outbound bandwidth over the internal network. Unit: kbit/s.</para>
        /// <remarks>
        /// <para>The response excludes instance types that have a lower outbound bandwidth limit over the internal network than this value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12288</para>
        /// </summary>
        [NameInMap("MinimumInstanceBandwidthTx")]
        [Validation(Required=false)]
        public int? MinimumInstanceBandwidthTx { get; set; }

        /// <summary>
        /// <para>The minimum inbound packet rate over the internal network. Unit: pps.</para>
        /// <remarks>
        /// <para>The response excludes instance types that have a lower inbound packet rate over the internal network than this value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("MinimumInstancePpsRx")]
        [Validation(Required=false)]
        public long? MinimumInstancePpsRx { get; set; }

        /// <summary>
        /// <para>The minimum outbound packet rate over the internal network. Unit: pps.</para>
        /// <remarks>
        /// <para>The response excludes instance types that have a lower outbound packet rate over the internal network than this value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("MinimumInstancePpsTx")]
        [Validation(Required=false)]
        public long? MinimumInstancePpsTx { get; set; }

        /// <summary>
        /// <para>The minimum number of local disks available on the instance type.</para>
        /// <remarks>
        /// <para>The response excludes instance types that support fewer local disks than this value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MinimumLocalStorageAmount")]
        [Validation(Required=false)]
        public int? MinimumLocalStorageAmount { get; set; }

        /// <summary>
        /// <para>The minimum capacity of a single local disk, in GiB. The response excludes instance types whose local disks have a capacity smaller than this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MinimumLocalStorageCapacity")]
        [Validation(Required=false)]
        public long? MinimumLocalStorageCapacity { get; set; }

        /// <summary>
        /// <para>The minimum memory size for the instance type. Unit: GiB.</para>
        /// <remarks>
        /// <para>The response excludes instance types with a smaller memory size than this value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MinimumMemorySize")]
        [Validation(Required=false)]
        public float? MinimumMemorySize { get; set; }

        /// <summary>
        /// <para>The minimum number of queues supported by the primary elastic network interface.</para>
        /// <remarks>
        /// <para>The response excludes instance types that support fewer queues for the primary elastic network interface than this value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("MinimumPrimaryEniQueueNumber")]
        [Validation(Required=false)]
        public int? MinimumPrimaryEniQueueNumber { get; set; }

        /// <summary>
        /// <para>The minimum value for the maximum number of queue pairs (QPs) supported by a single Elastic RDMA Interface (ERI).</para>
        /// <remarks>
        /// <para>The response excludes instance types whose ERIs support fewer queue pairs than this value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("MinimumQueuePairNumber")]
        [Validation(Required=false)]
        public int? MinimumQueuePairNumber { get; set; }

        /// <summary>
        /// <para>The minimum number of queues supported by a secondary elastic network interface.</para>
        /// <remarks>
        /// <para>The response excludes instance types that support fewer queues for a secondary elastic network interface than this value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MinimumSecondaryEniQueueNumber")]
        [Validation(Required=false)]
        public int? MinimumSecondaryEniQueueNumber { get; set; }

        /// <summary>
        /// <para>The token used to retrieve the next page of results. You do not need to set this parameter for the first request. For subsequent requests, set this to the <c>NextToken</c> value from the previous response.</para>
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
        /// <para>Specifies whether cloud disks attached to the instance type support NVMe. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>required</c>: Cloud disks are attached using the NVMe protocol.</para>
        /// </description></item>
        /// <item><description><para><c>unsupported</c>: Cloud disks are attached without using the NVMe protocol.</para>
        /// </description></item>
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
        /// <para>This parameter supports fuzzy search. For example, specifying <c>Intel</c> returns instance types with <c>Intel Xeon(Ice Lake) Platinum 8369B</c> processors.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Intel Xeon(Ice Lake) Platinum 8369B</para>
        /// </summary>
        [NameInMap("PhysicalProcessorModel")]
        [Validation(Required=false)]
        public string PhysicalProcessorModel { get; set; }

        /// <summary>
        /// <para>An array of 1 to 10 processor models.</para>
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

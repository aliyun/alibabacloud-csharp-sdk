// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the instance types.</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public DescribeInstanceTypesResponseBodyInstanceTypes InstanceTypes { get; set; }
        public class DescribeInstanceTypesResponseBodyInstanceTypes : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public List<DescribeInstanceTypesResponseBodyInstanceTypesInstanceType> InstanceType { get; set; }
            public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceType : TeaModel {
                /// <summary>
                /// <para>The baseline vCPU computing performance (overall baseline performance of all vCPUs) per t5 or t6 burstable instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("BaselineCredit")]
                [Validation(Required=false)]
                public int? BaselineCredit { get; set; }

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
                /// <para>The number of vCPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("CpuCoreCount")]
                [Validation(Required=false)]
                public int? CpuCoreCount { get; set; }

                [NameInMap("CpuOptions")]
                [Validation(Required=false)]
                public DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeCpuOptions CpuOptions { get; set; }
                public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeCpuOptions : TeaModel {
                    [NameInMap("SupportedTopologyTypes")]
                    [Validation(Required=false)]
                    public DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeCpuOptionsSupportedTopologyTypes SupportedTopologyTypes { get; set; }
                    public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeCpuOptionsSupportedTopologyTypes : TeaModel {
                        [NameInMap("SupportedTopologyType")]
                        [Validation(Required=false)]
                        public List<string> SupportedTopologyType { get; set; }

                    }

                }

                /// <summary>
                /// <para>The CPU base frequency. Unit: GHz.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.7</para>
                /// </summary>
                [NameInMap("CpuSpeedFrequency")]
                [Validation(Required=false)]
                public float? CpuSpeedFrequency { get; set; }

                /// <summary>
                /// <para>The CPU turbo frequency. Unit: GHz.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.5</para>
                /// </summary>
                [NameInMap("CpuTurboFrequency")]
                [Validation(Required=false)]
                public float? CpuTurboFrequency { get; set; }

                /// <summary>
                /// <para>The maximum number of cloud disks per instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>17</para>
                /// </summary>
                [NameInMap("DiskQuantity")]
                [Validation(Required=false)]
                public int? DiskQuantity { get; set; }

                /// <summary>
                /// <remarks>
                /// <para> This parameter is not publicly available.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("EnhancedNetwork")]
                [Validation(Required=false)]
                public DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeEnhancedNetwork EnhancedNetwork { get; set; }
                public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeEnhancedNetwork : TeaModel {
                    /// <summary>
                    /// <remarks>
                    /// <para> This parameter is not publicly available.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("SriovSupport")]
                    [Validation(Required=false)]
                    public bool? SriovSupport { get; set; }

                    /// <summary>
                    /// <remarks>
                    /// <para> This parameter is not publicly available.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("VfQueueNumberPerEni")]
                    [Validation(Required=false)]
                    public int? VfQueueNumberPerEni { get; set; }

                }

                /// <summary>
                /// <para>The maximum number of IPv6 addresses per ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EniIpv6AddressQuantity")]
                [Validation(Required=false)]
                public int? EniIpv6AddressQuantity { get; set; }

                /// <summary>
                /// <para>The maximum number of IPv4 addresses per ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("EniPrivateIpAddressQuantity")]
                [Validation(Required=false)]
                public int? EniPrivateIpAddressQuantity { get; set; }

                /// <summary>
                /// <para>The maximum number of ENIs per instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("EniQuantity")]
                [Validation(Required=false)]
                public int? EniQuantity { get; set; }

                /// <summary>
                /// <para>The maximum number of ENIs, including primary, secondary, and trunk ENIs.</para>
                /// <remarks>
                /// <para> This parameter is in invitational preview and is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("EniTotalQuantity")]
                [Validation(Required=false)]
                public int? EniTotalQuantity { get; set; }

                /// <summary>
                /// <para>Indicates whether trunk ENIs are supported.</para>
                /// <remarks>
                /// <para> This parameter is in invitational preview and is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EniTrunkSupported")]
                [Validation(Required=false)]
                public bool? EniTrunkSupported { get; set; }

                /// <summary>
                /// <para>The number of ERIs.</para>
                /// <remarks>
                /// <para> This parameter is in invitational preview and is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("EriQuantity")]
                [Validation(Required=false)]
                public int? EriQuantity { get; set; }

                /// <summary>
                /// <para>The number of GPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("GPUAmount")]
                [Validation(Required=false)]
                public int? GPUAmount { get; set; }

                /// <summary>
                /// <para>The amount of GPU memory per GPU. Unit: GiB</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("GPUMemorySize")]
                [Validation(Required=false)]
                public float? GPUMemorySize { get; set; }

                /// <summary>
                /// <para>The GPU model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NVIDIA V100</para>
                /// </summary>
                [NameInMap("GPUSpec")]
                [Validation(Required=false)]
                public string GPUSpec { get; set; }

                /// <summary>
                /// <para>The initial vCPU credits per t5 or t6 burstable instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("InitialCredit")]
                [Validation(Required=false)]
                public int? InitialCredit { get; set; }

                /// <summary>
                /// <para>The maximum inbound internal bandwidth. Unit: Kbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024000</para>
                /// </summary>
                [NameInMap("InstanceBandwidthRx")]
                [Validation(Required=false)]
                public int? InstanceBandwidthRx { get; set; }

                /// <summary>
                /// <para>The maximum outbound internal bandwidth. Unit: Kbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024000</para>
                /// </summary>
                [NameInMap("InstanceBandwidthTx")]
                [Validation(Required=false)]
                public int? InstanceBandwidthTx { get; set; }

                /// <summary>
                /// <para>The category of the instance type. Valid values:</para>
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
                /// <item><description>CreditEntryLevel: credit-based entry level. For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Overview</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EnterpriseLevel</para>
                /// </summary>
                [NameInMap("InstanceFamilyLevel")]
                [Validation(Required=false)]
                public string InstanceFamilyLevel { get; set; }

                /// <summary>
                /// <para>The inbound packet forwarding rate over the internal network. Unit: pps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500000</para>
                /// </summary>
                [NameInMap("InstancePpsRx")]
                [Validation(Required=false)]
                public long? InstancePpsRx { get; set; }

                /// <summary>
                /// <para>The outbound packet forwarding rate over the internal network. Unit: pps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500000</para>
                /// </summary>
                [NameInMap("InstancePpsTx")]
                [Validation(Required=false)]
                public long? InstancePpsTx { get; set; }

                /// <summary>
                /// <para>The instance family.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g6</para>
                /// </summary>
                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                /// <summary>
                /// <para>The ID of the instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g6.large</para>
                /// </summary>
                [NameInMap("InstanceTypeId")]
                [Validation(Required=false)]
                public string InstanceTypeId { get; set; }

                /// <summary>
                /// <para>The number of local disks per instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LocalStorageAmount")]
                [Validation(Required=false)]
                public int? LocalStorageAmount { get; set; }

                /// <summary>
                /// <para>The capacity of each local disk. Unit: GiB</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("LocalStorageCapacity")]
                [Validation(Required=false)]
                public long? LocalStorageCapacity { get; set; }

                /// <summary>
                /// <para>The category of local disks. For more information, see <a href="https://help.aliyun.com/document_detail/63138.html">Local disks</a>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>local_hdd_pro: local SATA HDDs, which are attached to d1ne or d1 instances</description></item>
                /// <item><description>local_ssd_pro: local NVMe SSDs, which are attached to i2, i2g, i1, ga1, or gn5 instances</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>local_ssd_pro</para>
                /// </summary>
                [NameInMap("LocalStorageCategory")]
                [Validation(Required=false)]
                public string LocalStorageCategory { get; set; }

                /// <summary>
                /// <para>The maximum number of queues per ENI, including primary and secondary ENIs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("MaximumQueueNumberPerEni")]
                [Validation(Required=false)]
                public int? MaximumQueueNumberPerEni { get; set; }

                /// <summary>
                /// <para>The memory size. Unit: GiB</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public float? MemorySize { get; set; }

                /// <summary>
                /// <para>The maximum number of network cards that the instance type supports.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NetworkCardQuantity")]
                [Validation(Required=false)]
                public int? NetworkCardQuantity { get; set; }

                /// <summary>
                /// <para>The information about the network cards.</para>
                /// </summary>
                [NameInMap("NetworkCards")]
                [Validation(Required=false)]
                public DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeNetworkCards NetworkCards { get; set; }
                public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeNetworkCards : TeaModel {
                    [NameInMap("NetworkCardInfo")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeNetworkCardsNetworkCardInfo> NetworkCardInfo { get; set; }
                    public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeNetworkCardsNetworkCardInfo : TeaModel {
                        /// <summary>
                        /// <para>The index of the network card.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("NetworkCardIndex")]
                        [Validation(Required=false)]
                        public int? NetworkCardIndex { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether to allow network traffic transmitted over virtual private clouds (VPCs) to be encrypted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("NetworkEncryptionSupport")]
                [Validation(Required=false)]
                public bool? NetworkEncryptionSupport { get; set; }

                /// <summary>
                /// <para>Indicates whether cloud disks can be attached by using the NVMe protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>required: Cloud disks can be attached by using the NVMe protocol.</description></item>
                /// <item><description>unsupported: Cloud disks cannot be attached by using the NVMe protocol.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>unsupported</para>
                /// </summary>
                [NameInMap("NvmeSupport")]
                [Validation(Required=false)]
                public string NvmeSupport { get; set; }

                /// <summary>
                /// <para>The CPU model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Intel Xeon(Ice Lake) Platinum 8369B</para>
                /// </summary>
                [NameInMap("PhysicalProcessorModel")]
                [Validation(Required=false)]
                public string PhysicalProcessorModel { get; set; }

                /// <summary>
                /// <para>The default number of queues per primary ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("PrimaryEniQueueNumber")]
                [Validation(Required=false)]
                public int? PrimaryEniQueueNumber { get; set; }

                /// <summary>
                /// <para>The maximum number of QPs per ERI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("QueuePairNumber")]
                [Validation(Required=false)]
                public int? QueuePairNumber { get; set; }

                /// <summary>
                /// <para>The default number of queues per secondary ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("SecondaryEniQueueNumber")]
                [Validation(Required=false)]
                public int? SecondaryEniQueueNumber { get; set; }

                /// <summary>
                /// <para>The boot modes supported by the instance type.</para>
                /// </summary>
                [NameInMap("SupportedBootModes")]
                [Validation(Required=false)]
                public DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeSupportedBootModes SupportedBootModes { get; set; }
                public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeSupportedBootModes : TeaModel {
                    [NameInMap("SupportedBootMode")]
                    [Validation(Required=false)]
                    public List<string> SupportedBootMode { get; set; }

                }

                /// <summary>
                /// <para>The maximum number of queues on ENIs that the instance type supports.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("TotalEniQueueQuantity")]
                [Validation(Required=false)]
                public int? TotalEniQueueQuantity { get; set; }

            }

        }

        /// <summary>
        /// <para>The query token returned in this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e71d8a535bd9cc11</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00827261-20B7-4562-83F2-4DF39876A45A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

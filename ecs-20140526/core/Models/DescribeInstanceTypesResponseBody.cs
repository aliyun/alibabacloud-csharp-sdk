// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceTypesResponseBody : TeaModel {
        /// <summary>
        /// Details about the instance types.
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
                /// The baseline vCPU computing performance (overall baseline performance of all vCPUs) per t5 or t6 burstable instance.
                /// </summary>
                [NameInMap("BaselineCredit")]
                [Validation(Required=false)]
                public int? BaselineCredit { get; set; }

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
                /// The number of vCPUs.
                /// </summary>
                [NameInMap("CpuCoreCount")]
                [Validation(Required=false)]
                public int? CpuCoreCount { get; set; }

                /// <summary>
                /// The CPU base frequency. Unit: GHz.
                /// </summary>
                [NameInMap("CpuSpeedFrequency")]
                [Validation(Required=false)]
                public float? CpuSpeedFrequency { get; set; }

                /// <summary>
                /// The CPU turbo frequency. Unit: GHz.
                /// </summary>
                [NameInMap("CpuTurboFrequency")]
                [Validation(Required=false)]
                public float? CpuTurboFrequency { get; set; }

                /// <summary>
                /// The maximum number of cloud disks per instance.
                /// </summary>
                [NameInMap("DiskQuantity")]
                [Validation(Required=false)]
                public int? DiskQuantity { get; set; }

                /// <summary>
                /// >  This parameter is not publicly available.
                /// </summary>
                [NameInMap("EnhancedNetwork")]
                [Validation(Required=false)]
                public DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeEnhancedNetwork EnhancedNetwork { get; set; }
                public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeEnhancedNetwork : TeaModel {
                    /// <summary>
                    /// *
                    /// *
                    /// 
                    /// >  This parameter is not publicly available.
                    /// </summary>
                    [NameInMap("SriovSupport")]
                    [Validation(Required=false)]
                    public bool? SriovSupport { get; set; }

                    /// <summary>
                    /// >  This parameter is not publicly available.
                    /// </summary>
                    [NameInMap("VfQueueNumberPerEni")]
                    [Validation(Required=false)]
                    public int? VfQueueNumberPerEni { get; set; }

                }

                /// <summary>
                /// The maximum number of IPv6 addresses per ENI.
                /// </summary>
                [NameInMap("EniIpv6AddressQuantity")]
                [Validation(Required=false)]
                public int? EniIpv6AddressQuantity { get; set; }

                /// <summary>
                /// The maximum number of IPv4 addresses per ENI.
                /// </summary>
                [NameInMap("EniPrivateIpAddressQuantity")]
                [Validation(Required=false)]
                public int? EniPrivateIpAddressQuantity { get; set; }

                /// <summary>
                /// The maximum number of ENIs per instance.
                /// </summary>
                [NameInMap("EniQuantity")]
                [Validation(Required=false)]
                public int? EniQuantity { get; set; }

                /// <summary>
                /// The maximum number of ENIs, including primary, secondary, and trunk ENIs.
                /// 
                /// >  This parameter is in invitational preview and is not publicly available.
                /// </summary>
                [NameInMap("EniTotalQuantity")]
                [Validation(Required=false)]
                public int? EniTotalQuantity { get; set; }

                /// <summary>
                /// Indicates whether trunk ENIs are supported.
                /// 
                /// >  This parameter is in invitational preview and is not publicly available.
                /// </summary>
                [NameInMap("EniTrunkSupported")]
                [Validation(Required=false)]
                public bool? EniTrunkSupported { get; set; }

                /// <summary>
                /// The number of ERIs.
                /// 
                /// >  This parameter is in invitational preview and is not publicly available.
                /// </summary>
                [NameInMap("EriQuantity")]
                [Validation(Required=false)]
                public int? EriQuantity { get; set; }

                /// <summary>
                /// The number of GPUs.
                /// </summary>
                [NameInMap("GPUAmount")]
                [Validation(Required=false)]
                public int? GPUAmount { get; set; }

                /// <summary>
                /// The amount of GPU memory per GPU. Unit: GiB
                /// </summary>
                [NameInMap("GPUMemorySize")]
                [Validation(Required=false)]
                public float? GPUMemorySize { get; set; }

                /// <summary>
                /// The GPU model.
                /// </summary>
                [NameInMap("GPUSpec")]
                [Validation(Required=false)]
                public string GPUSpec { get; set; }

                /// <summary>
                /// The initial vCPU credits per t5 or t6 burstable instance.
                /// </summary>
                [NameInMap("InitialCredit")]
                [Validation(Required=false)]
                public int? InitialCredit { get; set; }

                /// <summary>
                /// The maximum inbound internal bandwidth. Unit: Kbit/s.
                /// </summary>
                [NameInMap("InstanceBandwidthRx")]
                [Validation(Required=false)]
                public int? InstanceBandwidthRx { get; set; }

                /// <summary>
                /// The maximum outbound internal bandwidth. Unit: Kbit/s.
                /// </summary>
                [NameInMap("InstanceBandwidthTx")]
                [Validation(Required=false)]
                public int? InstanceBandwidthTx { get; set; }

                /// <summary>
                /// The category of the instance type. Valid values:
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
                [NameInMap("InstanceCategory")]
                [Validation(Required=false)]
                public string InstanceCategory { get; set; }

                /// <summary>
                /// The level of the instance family. Valid values:
                /// 
                /// *   EntryLevel: entry level (shared).
                /// *   EnterpriseLevel: enterprise level.
                /// *   CreditEntryLevel: credit-based entry level. For more information, see [Overview](https://help.aliyun.com/document_detail/59977.html).
                /// </summary>
                [NameInMap("InstanceFamilyLevel")]
                [Validation(Required=false)]
                public string InstanceFamilyLevel { get; set; }

                /// <summary>
                /// The inbound packet forwarding rate over the internal network. Unit: pps.
                /// </summary>
                [NameInMap("InstancePpsRx")]
                [Validation(Required=false)]
                public long? InstancePpsRx { get; set; }

                /// <summary>
                /// The outbound packet forwarding rate over the internal network. Unit: pps.
                /// </summary>
                [NameInMap("InstancePpsTx")]
                [Validation(Required=false)]
                public long? InstancePpsTx { get; set; }

                /// <summary>
                /// The instance family.
                /// </summary>
                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                /// <summary>
                /// The ID of the instance type.
                /// </summary>
                [NameInMap("InstanceTypeId")]
                [Validation(Required=false)]
                public string InstanceTypeId { get; set; }

                /// <summary>
                /// The number of local disks per instance.
                /// </summary>
                [NameInMap("LocalStorageAmount")]
                [Validation(Required=false)]
                public int? LocalStorageAmount { get; set; }

                /// <summary>
                /// The capacity of each local disk. Unit: GiB
                /// </summary>
                [NameInMap("LocalStorageCapacity")]
                [Validation(Required=false)]
                public long? LocalStorageCapacity { get; set; }

                /// <summary>
                /// The category of local disks. For more information, see [Local disks](https://help.aliyun.com/document_detail/63138.html). Valid values:
                /// 
                /// *   local_hdd_pro: local SATA HDDs, which are attached to d1ne or d1 instances
                /// *   local_ssd_pro: local NVMe SSDs, which are attached to i2, i2g, i1, ga1, or gn5 instances
                /// </summary>
                [NameInMap("LocalStorageCategory")]
                [Validation(Required=false)]
                public string LocalStorageCategory { get; set; }

                /// <summary>
                /// The maximum number of queues per ENI, including primary and secondary ENIs.
                /// </summary>
                [NameInMap("MaximumQueueNumberPerEni")]
                [Validation(Required=false)]
                public int? MaximumQueueNumberPerEni { get; set; }

                /// <summary>
                /// The memory size. Unit: GiB
                /// </summary>
                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public float? MemorySize { get; set; }

                /// <summary>
                /// The maximum number of network cards that the instance type supports.
                /// </summary>
                [NameInMap("NetworkCardQuantity")]
                [Validation(Required=false)]
                public int? NetworkCardQuantity { get; set; }

                /// <summary>
                /// The information about the network cards.
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
                        /// The index of the network card.
                        /// </summary>
                        [NameInMap("NetworkCardIndex")]
                        [Validation(Required=false)]
                        public int? NetworkCardIndex { get; set; }

                    }

                }

                /// <summary>
                /// Indicates whether to allow network traffic transmitted over virtual private clouds (VPCs) to be encrypted. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("NetworkEncryptionSupport")]
                [Validation(Required=false)]
                public bool? NetworkEncryptionSupport { get; set; }

                /// <summary>
                /// Indicates whether cloud disks can be attached by using the NVMe protocol. Valid values:
                /// 
                /// *   required: Cloud disks can be attached by using the NVMe protocol.
                /// *   unsupported: Cloud disks cannot be attached by using the NVMe protocol.
                /// </summary>
                [NameInMap("NvmeSupport")]
                [Validation(Required=false)]
                public string NvmeSupport { get; set; }

                /// <summary>
                /// The CPU model.
                /// </summary>
                [NameInMap("PhysicalProcessorModel")]
                [Validation(Required=false)]
                public string PhysicalProcessorModel { get; set; }

                /// <summary>
                /// The default number of queues per primary ENI.
                /// </summary>
                [NameInMap("PrimaryEniQueueNumber")]
                [Validation(Required=false)]
                public int? PrimaryEniQueueNumber { get; set; }

                /// <summary>
                /// The maximum number of QPs per ERI.
                /// </summary>
                [NameInMap("QueuePairNumber")]
                [Validation(Required=false)]
                public int? QueuePairNumber { get; set; }

                /// <summary>
                /// The default number of queues per secondary ENI.
                /// </summary>
                [NameInMap("SecondaryEniQueueNumber")]
                [Validation(Required=false)]
                public int? SecondaryEniQueueNumber { get; set; }

                /// <summary>
                /// The boot modes supported by the instance type.
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
                /// The maximum number of queues on ENIs that the instance type supports.
                /// </summary>
                [NameInMap("TotalEniQueueQuantity")]
                [Validation(Required=false)]
                public int? TotalEniQueueQuantity { get; set; }

            }

        }

        /// <summary>
        /// The query token returned in this call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

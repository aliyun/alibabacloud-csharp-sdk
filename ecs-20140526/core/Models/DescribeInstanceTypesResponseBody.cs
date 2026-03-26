// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceTypesResponseBody : TeaModel {
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public DescribeInstanceTypesResponseBodyInstanceTypes InstanceTypes { get; set; }
        public class DescribeInstanceTypesResponseBodyInstanceTypes : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public List<DescribeInstanceTypesResponseBodyInstanceTypesInstanceType> InstanceType { get; set; }
            public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceType : TeaModel {
                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeAttributes Attributes { get; set; }
                public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeAttributes : TeaModel {
                    [NameInMap("Attribute")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeAttributesAttribute> Attribute { get; set; }
                    public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeAttributesAttribute : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("BaselineCredit")]
                [Validation(Required=false)]
                public int? BaselineCredit { get; set; }

                [NameInMap("Clock")]
                [Validation(Required=false)]
                public DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeClock Clock { get; set; }
                public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeClock : TeaModel {
                    [NameInMap("PtpSupport")]
                    [Validation(Required=false)]
                    public string PtpSupport { get; set; }

                }

                [NameInMap("CpuArchitecture")]
                [Validation(Required=false)]
                public string CpuArchitecture { get; set; }

                [NameInMap("CpuCoreCount")]
                [Validation(Required=false)]
                public int? CpuCoreCount { get; set; }

                [NameInMap("CpuOptions")]
                [Validation(Required=false)]
                public DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeCpuOptions CpuOptions { get; set; }
                public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeCpuOptions : TeaModel {
                    [NameInMap("Core")]
                    [Validation(Required=false)]
                    public int? Core { get; set; }

                    [NameInMap("CoreFactor")]
                    [Validation(Required=false)]
                    public int? CoreFactor { get; set; }

                    [NameInMap("HyperThreadingAdjustable")]
                    [Validation(Required=false)]
                    public bool? HyperThreadingAdjustable { get; set; }

                    [NameInMap("SupportedTopologyTypes")]
                    [Validation(Required=false)]
                    public DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeCpuOptionsSupportedTopologyTypes SupportedTopologyTypes { get; set; }
                    public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeCpuOptionsSupportedTopologyTypes : TeaModel {
                        [NameInMap("SupportedTopologyType")]
                        [Validation(Required=false)]
                        public List<string> SupportedTopologyType { get; set; }

                    }

                    [NameInMap("ThreadsPerCore")]
                    [Validation(Required=false)]
                    public int? ThreadsPerCore { get; set; }

                }

                [NameInMap("CpuSpeedFrequency")]
                [Validation(Required=false)]
                public float? CpuSpeedFrequency { get; set; }

                [NameInMap("CpuTurboFrequency")]
                [Validation(Required=false)]
                public float? CpuTurboFrequency { get; set; }

                [NameInMap("DiskQuantity")]
                [Validation(Required=false)]
                public int? DiskQuantity { get; set; }

                [NameInMap("EnhancedNetwork")]
                [Validation(Required=false)]
                public DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeEnhancedNetwork EnhancedNetwork { get; set; }
                public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeEnhancedNetwork : TeaModel {
                    [NameInMap("RssSupport")]
                    [Validation(Required=false)]
                    public bool? RssSupport { get; set; }

                    [NameInMap("SriovSupport")]
                    [Validation(Required=false)]
                    public bool? SriovSupport { get; set; }

                    [NameInMap("VfQueueNumberPerEni")]
                    [Validation(Required=false)]
                    public int? VfQueueNumberPerEni { get; set; }

                }

                [NameInMap("EniIpv6AddressQuantity")]
                [Validation(Required=false)]
                public int? EniIpv6AddressQuantity { get; set; }

                [NameInMap("EniPrivateIpAddressQuantity")]
                [Validation(Required=false)]
                public int? EniPrivateIpAddressQuantity { get; set; }

                [NameInMap("EniQuantity")]
                [Validation(Required=false)]
                public int? EniQuantity { get; set; }

                [NameInMap("EniTotalQuantity")]
                [Validation(Required=false)]
                public int? EniTotalQuantity { get; set; }

                [NameInMap("EniTrunkSupported")]
                [Validation(Required=false)]
                public bool? EniTrunkSupported { get; set; }

                [NameInMap("EriQuantity")]
                [Validation(Required=false)]
                public int? EriQuantity { get; set; }

                [NameInMap("GPUAmount")]
                [Validation(Required=false)]
                public int? GPUAmount { get; set; }

                [NameInMap("GPUMemorySize")]
                [Validation(Required=false)]
                public float? GPUMemorySize { get; set; }

                [NameInMap("GPUSpec")]
                [Validation(Required=false)]
                public string GPUSpec { get; set; }

                [NameInMap("InitialCredit")]
                [Validation(Required=false)]
                public int? InitialCredit { get; set; }

                [NameInMap("InstanceBandwidthRx")]
                [Validation(Required=false)]
                public int? InstanceBandwidthRx { get; set; }

                [NameInMap("InstanceBandwidthTx")]
                [Validation(Required=false)]
                public int? InstanceBandwidthTx { get; set; }

                [NameInMap("InstanceCategory")]
                [Validation(Required=false)]
                public string InstanceCategory { get; set; }

                [NameInMap("InstanceFamilyLevel")]
                [Validation(Required=false)]
                public string InstanceFamilyLevel { get; set; }

                [NameInMap("InstancePpsRx")]
                [Validation(Required=false)]
                public long? InstancePpsRx { get; set; }

                [NameInMap("InstancePpsTx")]
                [Validation(Required=false)]
                public long? InstancePpsTx { get; set; }

                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                [NameInMap("InstanceTypeId")]
                [Validation(Required=false)]
                public string InstanceTypeId { get; set; }

                [NameInMap("JumboFrameSupport")]
                [Validation(Required=false)]
                public bool? JumboFrameSupport { get; set; }

                [NameInMap("LocalStorageAmount")]
                [Validation(Required=false)]
                public int? LocalStorageAmount { get; set; }

                [NameInMap("LocalStorageCapacity")]
                [Validation(Required=false)]
                public long? LocalStorageCapacity { get; set; }

                [NameInMap("LocalStorageCategory")]
                [Validation(Required=false)]
                public string LocalStorageCategory { get; set; }

                [NameInMap("MaximumQueueNumberPerEni")]
                [Validation(Required=false)]
                public int? MaximumQueueNumberPerEni { get; set; }

                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public float? MemorySize { get; set; }

                [NameInMap("NetworkCardQuantity")]
                [Validation(Required=false)]
                public int? NetworkCardQuantity { get; set; }

                [NameInMap("NetworkCards")]
                [Validation(Required=false)]
                public DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeNetworkCards NetworkCards { get; set; }
                public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeNetworkCards : TeaModel {
                    [NameInMap("NetworkCardInfo")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeNetworkCardsNetworkCardInfo> NetworkCardInfo { get; set; }
                    public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeNetworkCardsNetworkCardInfo : TeaModel {
                        [NameInMap("NetworkCardIndex")]
                        [Validation(Required=false)]
                        public int? NetworkCardIndex { get; set; }

                    }

                }

                [NameInMap("NetworkEncryptionSupport")]
                [Validation(Required=false)]
                public bool? NetworkEncryptionSupport { get; set; }

                [NameInMap("NetworkInfo")]
                [Validation(Required=false)]
                public DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeNetworkInfo NetworkInfo { get; set; }
                public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeNetworkInfo : TeaModel {
                    [NameInMap("BandwidthWeighting")]
                    [Validation(Required=false)]
                    public DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeNetworkInfoBandwidthWeighting BandwidthWeighting { get; set; }
                    public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeNetworkInfoBandwidthWeighting : TeaModel {
                        [NameInMap("WeightingInfos")]
                        [Validation(Required=false)]
                        public DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeNetworkInfoBandwidthWeightingWeightingInfos WeightingInfos { get; set; }
                        public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeNetworkInfoBandwidthWeightingWeightingInfos : TeaModel {
                            [NameInMap("WeightingInfo")]
                            [Validation(Required=false)]
                            public List<DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeNetworkInfoBandwidthWeightingWeightingInfosWeightingInfo> WeightingInfo { get; set; }
                            public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeNetworkInfoBandwidthWeightingWeightingInfosWeightingInfo : TeaModel {
                                [NameInMap("EbsBandwidth")]
                                [Validation(Required=false)]
                                public long? EbsBandwidth { get; set; }

                                [NameInMap("EbsBurstBandwidth")]
                                [Validation(Required=false)]
                                public long? EbsBurstBandwidth { get; set; }

                                [NameInMap("Name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                                [NameInMap("VpcBandwidth")]
                                [Validation(Required=false)]
                                public long? VpcBandwidth { get; set; }

                                [NameInMap("VpcBurstBandwidth")]
                                [Validation(Required=false)]
                                public long? VpcBurstBandwidth { get; set; }

                            }

                        }

                    }

                }

                [NameInMap("NvmeSupport")]
                [Validation(Required=false)]
                public string NvmeSupport { get; set; }

                [NameInMap("PhysicalProcessorModel")]
                [Validation(Required=false)]
                public string PhysicalProcessorModel { get; set; }

                [NameInMap("PrimaryEniQueueNumber")]
                [Validation(Required=false)]
                public int? PrimaryEniQueueNumber { get; set; }

                [NameInMap("QueuePairNumber")]
                [Validation(Required=false)]
                public int? QueuePairNumber { get; set; }

                [NameInMap("SecondaryEniQueueNumber")]
                [Validation(Required=false)]
                public int? SecondaryEniQueueNumber { get; set; }

                [NameInMap("SupportedBootModes")]
                [Validation(Required=false)]
                public DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeSupportedBootModes SupportedBootModes { get; set; }
                public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceTypeSupportedBootModes : TeaModel {
                    [NameInMap("SupportedBootMode")]
                    [Validation(Required=false)]
                    public List<string> SupportedBootMode { get; set; }

                }

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

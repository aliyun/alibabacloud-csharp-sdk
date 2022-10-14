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
                [NameInMap("BaselineCredit")]
                [Validation(Required=false)]
                public int? BaselineCredit { get; set; }

                [NameInMap("CpuArchitecture")]
                [Validation(Required=false)]
                public string CpuArchitecture { get; set; }

                [NameInMap("CpuCoreCount")]
                [Validation(Required=false)]
                public int? CpuCoreCount { get; set; }

                [NameInMap("CpuSpeedFrequency")]
                [Validation(Required=false)]
                public float? CpuSpeedFrequency { get; set; }

                [NameInMap("CpuTurboFrequency")]
                [Validation(Required=false)]
                public float? CpuTurboFrequency { get; set; }

                [NameInMap("DiskQuantity")]
                [Validation(Required=false)]
                public int? DiskQuantity { get; set; }

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

                [NameInMap("NetworkEncryptionSupport")]
                [Validation(Required=false)]
                public bool? NetworkEncryptionSupport { get; set; }

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

                [NameInMap("TotalEniQueueQuantity")]
                [Validation(Required=false)]
                public int? TotalEniQueueQuantity { get; set; }

            }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

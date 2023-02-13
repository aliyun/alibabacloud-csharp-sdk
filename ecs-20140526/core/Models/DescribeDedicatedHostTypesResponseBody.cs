// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDedicatedHostTypesResponseBody : TeaModel {
        /// <summary>
        /// The information about the dedicated host type.
        /// </summary>
        [NameInMap("DedicatedHostTypes")]
        [Validation(Required=false)]
        public DescribeDedicatedHostTypesResponseBodyDedicatedHostTypes DedicatedHostTypes { get; set; }
        public class DescribeDedicatedHostTypesResponseBodyDedicatedHostTypes : TeaModel {
            [NameInMap("DedicatedHostType")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostType> DedicatedHostType { get; set; }
            public class DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostType : TeaModel {
                /// <summary>
                /// The number of cores in a single physical CPU.
                /// </summary>
                [NameInMap("Cores")]
                [Validation(Required=false)]
                public int? Cores { get; set; }

                /// <summary>
                /// The supported CPU overcommit ratio range.
                /// </summary>
                [NameInMap("CpuOverCommitRatioRange")]
                [Validation(Required=false)]
                public string CpuOverCommitRatioRange { get; set; }

                /// <summary>
                /// The type of the dedicated host. You can submit a ticket to request more dedicated host types.
                /// </summary>
                [NameInMap("DedicatedHostType")]
                [Validation(Required=false)]
                public string DedicatedHostType { get; set; }

                /// <summary>
                /// The GPU model.
                /// </summary>
                [NameInMap("GPUSpec")]
                [Validation(Required=false)]
                public string GPUSpec { get; set; }

                /// <summary>
                /// The number of local disks on a dedicated host.
                /// </summary>
                [NameInMap("LocalStorageAmount")]
                [Validation(Required=false)]
                public int? LocalStorageAmount { get; set; }

                /// <summary>
                /// The capacity of a local disk. Unit: GiB.
                /// </summary>
                [NameInMap("LocalStorageCapacity")]
                [Validation(Required=false)]
                public long? LocalStorageCapacity { get; set; }

                /// <summary>
                /// The category of the local disks.
                /// </summary>
                [NameInMap("LocalStorageCategory")]
                [Validation(Required=false)]
                public string LocalStorageCategory { get; set; }

                /// <summary>
                /// The size of the memory. Unit: GiB.
                /// </summary>
                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public float? MemorySize { get; set; }

                /// <summary>
                /// The number of physical GPUs.
                /// </summary>
                [NameInMap("PhysicalGpus")]
                [Validation(Required=false)]
                public int? PhysicalGpus { get; set; }

                /// <summary>
                /// The number of physical CPUs.
                /// </summary>
                [NameInMap("Sockets")]
                [Validation(Required=false)]
                public int? Sockets { get; set; }

                /// <summary>
                /// Indicates whether the CPU overcommit ratio setting is supported.
                /// </summary>
                [NameInMap("SupportCpuOverCommitRatio")]
                [Validation(Required=false)]
                public bool? SupportCpuOverCommitRatio { get; set; }

                /// <summary>
                /// The ECS instance families supported by the dedicated host.
                /// </summary>
                [NameInMap("SupportedInstanceTypeFamilies")]
                [Validation(Required=false)]
                public DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostTypeSupportedInstanceTypeFamilies SupportedInstanceTypeFamilies { get; set; }
                public class DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostTypeSupportedInstanceTypeFamilies : TeaModel {
                    [NameInMap("SupportedInstanceTypeFamily")]
                    [Validation(Required=false)]
                    public List<string> SupportedInstanceTypeFamily { get; set; }

                }

                /// <summary>
                /// The ECS instance types supported by the dedicated host.
                /// </summary>
                [NameInMap("SupportedInstanceTypesList")]
                [Validation(Required=false)]
                public DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostTypeSupportedInstanceTypesList SupportedInstanceTypesList { get; set; }
                public class DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostTypeSupportedInstanceTypesList : TeaModel {
                    [NameInMap("SupportedInstanceTypesList")]
                    [Validation(Required=false)]
                    public List<string> SupportedInstanceTypesList { get; set; }

                }

                /// <summary>
                /// The total number of vCPUs.
                /// </summary>
                [NameInMap("TotalVcpus")]
                [Validation(Required=false)]
                public int? TotalVcpus { get; set; }

                /// <summary>
                /// The total number of vGPUs.
                /// </summary>
                [NameInMap("TotalVgpus")]
                [Validation(Required=false)]
                public int? TotalVgpus { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

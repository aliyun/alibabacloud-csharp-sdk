// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeDedicatedHostTypesResponseBody : TeaModel {
        [NameInMap("DedicatedHostTypes")]
        [Validation(Required=false)]
        public DescribeDedicatedHostTypesResponseBodyDedicatedHostTypes DedicatedHostTypes { get; set; }
        public class DescribeDedicatedHostTypesResponseBodyDedicatedHostTypes : TeaModel {
            [NameInMap("DedicatedHostType")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostType> DedicatedHostType { get; set; }
            public class DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostType : TeaModel {
                [NameInMap("CpuOverCommitRatioRange")]
                [Validation(Required=false)]
                public string CpuOverCommitRatioRange { get; set; }

                [NameInMap("DedicatedHostType")]
                [Validation(Required=false)]
                public string DedicatedHostType { get; set; }

                [NameInMap("GPUSpec")]
                [Validation(Required=false)]
                public string GPUSpec { get; set; }

                [NameInMap("Generation")]
                [Validation(Required=false)]
                public string Generation { get; set; }

                [NameInMap("LocalStorageAmount")]
                [Validation(Required=false)]
                public int? LocalStorageAmount { get; set; }

                [NameInMap("LocalStorageCapacity")]
                [Validation(Required=false)]
                public long? LocalStorageCapacity { get; set; }

                [NameInMap("LocalStorageCategory")]
                [Validation(Required=false)]
                public string LocalStorageCategory { get; set; }

                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public float? MemorySize { get; set; }

                [NameInMap("PhysicalGpus")]
                [Validation(Required=false)]
                public int? PhysicalGpus { get; set; }

                [NameInMap("SupportCpuOverCommitRatio")]
                [Validation(Required=false)]
                public bool? SupportCpuOverCommitRatio { get; set; }

                [NameInMap("SupportInstanceTypeFamilies")]
                [Validation(Required=false)]
                public DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostTypeSupportInstanceTypeFamilies SupportInstanceTypeFamilies { get; set; }
                public class DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostTypeSupportInstanceTypeFamilies : TeaModel {
                    [NameInMap("SupportInstanceTypeFamily")]
                    [Validation(Required=false)]
                    public List<string> SupportInstanceTypeFamily { get; set; }

                }

                [NameInMap("SupportInstanceTypesList")]
                [Validation(Required=false)]
                public DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostTypeSupportInstanceTypesList SupportInstanceTypesList { get; set; }
                public class DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostTypeSupportInstanceTypesList : TeaModel {
                    [NameInMap("SupportInstanceTypesList")]
                    [Validation(Required=false)]
                    public List<string> SupportInstanceTypesList { get; set; }

                }

                [NameInMap("TotalPhysicalCores")]
                [Validation(Required=false)]
                public int? TotalPhysicalCores { get; set; }

                [NameInMap("TotalSockets")]
                [Validation(Required=false)]
                public int? TotalSockets { get; set; }

                [NameInMap("TotalVcpus")]
                [Validation(Required=false)]
                public int? TotalVcpus { get; set; }

                [NameInMap("TotalVgpus")]
                [Validation(Required=false)]
                public int? TotalVgpus { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

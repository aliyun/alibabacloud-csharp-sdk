// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
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
                public int? Cores { get; set; }
                public string CpuOverCommitRatioRange { get; set; }
                public string DedicatedHostType { get; set; }
                public string GPUSpec { get; set; }
                public int? LocalStorageAmount { get; set; }
                public long? LocalStorageCapacity { get; set; }
                public string LocalStorageCategory { get; set; }
                public float? MemorySize { get; set; }
                public int? PhysicalGpus { get; set; }
                public int? Sockets { get; set; }
                public bool? SupportCpuOverCommitRatio { get; set; }
                public DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostTypeSupportedInstanceTypeFamilies SupportedInstanceTypeFamilies { get; set; }
                public class DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostTypeSupportedInstanceTypeFamilies : TeaModel {
                    [NameInMap("SupportedInstanceTypeFamily")]
                    [Validation(Required=false)]
                    public List<string> SupportedInstanceTypeFamily { get; set; }

                }
                public DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostTypeSupportedInstanceTypesList SupportedInstanceTypesList { get; set; }
                public class DescribeDedicatedHostTypesResponseBodyDedicatedHostTypesDedicatedHostTypeSupportedInstanceTypesList : TeaModel {
                    [NameInMap("SupportedInstanceTypesList")]
                    [Validation(Required=false)]
                    public List<string> SupportedInstanceTypesList { get; set; }

                }
                public int? TotalVcpus { get; set; }
                public int? TotalVgpus { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

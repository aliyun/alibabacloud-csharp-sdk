// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDedicatedHostTypesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DedicatedHostTypes")]
        [Validation(Required=false)]
        public List<DescribeDedicatedHostTypesResponseBodyDedicatedHostTypes> DedicatedHostTypes { get; set; }
        public class DescribeDedicatedHostTypesResponseBodyDedicatedHostTypes : TeaModel {
            [NameInMap("Cores")]
            [Validation(Required=false)]
            public int? Cores { get; set; }

            [NameInMap("GPUSpec")]
            [Validation(Required=false)]
            public string GPUSpec { get; set; }

            [NameInMap("LocalStorageCategory")]
            [Validation(Required=false)]
            public string LocalStorageCategory { get; set; }

            [NameInMap("TotalVcpus")]
            [Validation(Required=false)]
            public int? TotalVcpus { get; set; }

            [NameInMap("CpuOverCommitRatioRange")]
            [Validation(Required=false)]
            public string CpuOverCommitRatioRange { get; set; }

            [NameInMap("SupportedInstanceTypesList")]
            [Validation(Required=false)]
            public List<string> SupportedInstanceTypesList { get; set; }

            [NameInMap("PhysicalGpus")]
            [Validation(Required=false)]
            public int? PhysicalGpus { get; set; }

            [NameInMap("MemorySize")]
            [Validation(Required=false)]
            public float? MemorySize { get; set; }

            [NameInMap("SupportCpuOverCommitRatio")]
            [Validation(Required=false)]
            public bool? SupportCpuOverCommitRatio { get; set; }

            [NameInMap("LocalStorageCapacity")]
            [Validation(Required=false)]
            public long? LocalStorageCapacity { get; set; }

            [NameInMap("LocalStorageAmount")]
            [Validation(Required=false)]
            public int? LocalStorageAmount { get; set; }

            [NameInMap("DedicatedHostType")]
            [Validation(Required=false)]
            public string DedicatedHostType { get; set; }

            [NameInMap("TotalVgpus")]
            [Validation(Required=false)]
            public int? TotalVgpus { get; set; }

            [NameInMap("Sockets")]
            [Validation(Required=false)]
            public int? Sockets { get; set; }

            [NameInMap("SupportedInstanceTypeFamilies")]
            [Validation(Required=false)]
            public List<string> SupportedInstanceTypeFamilies { get; set; }

        }

    }

}

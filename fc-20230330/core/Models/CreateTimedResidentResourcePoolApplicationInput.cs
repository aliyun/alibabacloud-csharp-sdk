// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CreateTimedResidentResourcePoolApplicationInput : TeaModel {
        [NameInMap("associatedPoolId")]
        [Validation(Required=false)]
        public string AssociatedPoolId { get; set; }

        [NameInMap("diskSizeInGB")]
        [Validation(Required=false)]
        public long? DiskSizeInGB { get; set; }

        [NameInMap("gpuType")]
        [Validation(Required=false)]
        public string GpuType { get; set; }

        [NameInMap("memorySizeInGB")]
        [Validation(Required=false)]
        public long? MemorySizeInGB { get; set; }

        [NameInMap("operationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        [NameInMap("poolName")]
        [Validation(Required=false)]
        public string PoolName { get; set; }

        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("timedConfig")]
        [Validation(Required=false)]
        public TimedPoolConfig TimedConfig { get; set; }

        [NameInMap("timedPoolId")]
        [Validation(Required=false)]
        public string TimedPoolId { get; set; }

        [NameInMap("totalGPUCards")]
        [Validation(Required=false)]
        public long? TotalGPUCards { get; set; }

        [NameInMap("vCpuCores")]
        [Validation(Required=false)]
        public long? VCpuCores { get; set; }

    }

}

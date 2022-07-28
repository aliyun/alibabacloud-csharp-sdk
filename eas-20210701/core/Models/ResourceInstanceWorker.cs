// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ResourceInstanceWorker : TeaModel {
        [NameInMap("CpuLimit")]
        [Validation(Required=false)]
        public int? CpuLimit { get; set; }

        [NameInMap("CpuRequest")]
        [Validation(Required=false)]
        public int? CpuRequest { get; set; }

        [NameInMap("GpuLimit")]
        [Validation(Required=false)]
        public int? GpuLimit { get; set; }

        [NameInMap("GpuRequest")]
        [Validation(Required=false)]
        public int? GpuRequest { get; set; }

        [NameInMap("MemoryLimit")]
        [Validation(Required=false)]
        public int? MemoryLimit { get; set; }

        [NameInMap("MemoryRquest")]
        [Validation(Required=false)]
        public int? MemoryRquest { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Ready")]
        [Validation(Required=false)]
        public bool? Ready { get; set; }

        [NameInMap("RestartCount")]
        [Validation(Required=false)]
        public int? RestartCount { get; set; }

        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

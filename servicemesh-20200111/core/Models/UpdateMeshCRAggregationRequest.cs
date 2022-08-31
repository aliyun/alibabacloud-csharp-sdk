// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateMeshCRAggregationRequest : TeaModel {
        [NameInMap("CPULimit")]
        [Validation(Required=false)]
        public string CPULimit { get; set; }

        [NameInMap("CPURequirement")]
        [Validation(Required=false)]
        public string CPURequirement { get; set; }

        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("MemoryLimit")]
        [Validation(Required=false)]
        public string MemoryLimit { get; set; }

        [NameInMap("MemoryRequirement")]
        [Validation(Required=false)]
        public string MemoryRequirement { get; set; }

        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}

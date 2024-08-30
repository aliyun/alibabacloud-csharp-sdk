// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class NodePodInfo : TeaModel {
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        [NameInMap("PodIP")]
        [Validation(Required=false)]
        public string PodIP { get; set; }

        [NameInMap("PodName")]
        [Validation(Required=false)]
        public string PodName { get; set; }

        [NameInMap("PodNamespace")]
        [Validation(Required=false)]
        public string PodNamespace { get; set; }

        [NameInMap("ResourceSpec")]
        [Validation(Required=false)]
        public ResourceAmount ResourceSpec { get; set; }

        [NameInMap("WorkloadId")]
        [Validation(Required=false)]
        public string WorkloadId { get; set; }

        [NameInMap("WorkloadType")]
        [Validation(Required=false)]
        public string WorkloadType { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class RelatedWorkload : TeaModel {
        [NameInMap("workloadId")]
        [Validation(Required=false)]
        public string WorkloadId { get; set; }

        [NameInMap("workloadName")]
        [Validation(Required=false)]
        public string WorkloadName { get; set; }

        [NameInMap("workloadType")]
        [Validation(Required=false)]
        public string WorkloadType { get; set; }

    }

}

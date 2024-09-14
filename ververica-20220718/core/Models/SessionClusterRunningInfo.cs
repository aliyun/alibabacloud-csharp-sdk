// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class SessionClusterRunningInfo : TeaModel {
        [NameInMap("lastUpdateTime")]
        [Validation(Required=false)]
        public long? LastUpdateTime { get; set; }

        [NameInMap("referenceDeploymentIds")]
        [Validation(Required=false)]
        public List<string> ReferenceDeploymentIds { get; set; }

        [NameInMap("startedAt")]
        [Validation(Required=false)]
        public long? StartedAt { get; set; }

    }

}

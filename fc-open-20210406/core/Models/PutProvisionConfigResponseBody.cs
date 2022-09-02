// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class PutProvisionConfigResponseBody : TeaModel {
        [NameInMap("alwaysAllocateCPU")]
        [Validation(Required=false)]
        public bool? AlwaysAllocateCPU { get; set; }

        [NameInMap("current")]
        [Validation(Required=false)]
        public long? Current { get; set; }

        [NameInMap("resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        [NameInMap("scheduledActions")]
        [Validation(Required=false)]
        public List<ScheduledActions> ScheduledActions { get; set; }

        [NameInMap("target")]
        [Validation(Required=false)]
        public long? Target { get; set; }

        [NameInMap("targetTrackingPolicies")]
        [Validation(Required=false)]
        public List<TargetTrackingPolicies> TargetTrackingPolicies { get; set; }

    }

}

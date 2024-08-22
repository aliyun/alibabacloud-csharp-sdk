// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class PutProvisionConfigInput : TeaModel {
        [NameInMap("alwaysAllocateCPU")]
        [Validation(Required=false)]
        public bool? AlwaysAllocateCPU { get; set; }

        [NameInMap("alwaysAllocateGPU")]
        [Validation(Required=false)]
        public bool? AlwaysAllocateGPU { get; set; }

        [NameInMap("scheduledActions")]
        [Validation(Required=false)]
        public List<ScheduledAction> ScheduledActions { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public long? Target { get; set; }

        [NameInMap("targetTrackingPolicies")]
        [Validation(Required=false)]
        public List<TargetTrackingPolicy> TargetTrackingPolicies { get; set; }

    }

}

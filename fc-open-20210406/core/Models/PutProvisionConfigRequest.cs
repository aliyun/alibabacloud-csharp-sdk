// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class PutProvisionConfigRequest : TeaModel {
        /// <summary>
        /// Specifies whether to always allocate CPU resources. Default value: true.
        /// </summary>
        [NameInMap("alwaysAllocateCPU")]
        [Validation(Required=false)]
        public bool? AlwaysAllocateCPU { get; set; }

        /// <summary>
        /// The configurations of scheduled auto scaling.
        /// </summary>
        [NameInMap("scheduledActions")]
        [Validation(Required=false)]
        public List<ScheduledActions> ScheduledActions { get; set; }

        /// <summary>
        /// The number of provisioned instances. Value range: [1,100000].
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public long? Target { get; set; }

        /// <summary>
        /// The configurations of metric-based auto scaling.
        /// </summary>
        [NameInMap("targetTrackingPolicies")]
        [Validation(Required=false)]
        public List<TargetTrackingPolicies> TargetTrackingPolicies { get; set; }

        /// <summary>
        /// The name of the alias.
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

    }

}

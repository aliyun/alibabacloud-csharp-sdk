// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class GetProvisionConfigResponseBody : TeaModel {
        /// <summary>
        /// Specifies whether to always allocate CPU to a function instance.
        /// </summary>
        [NameInMap("alwaysAllocateCPU")]
        [Validation(Required=false)]
        public bool? AlwaysAllocateCPU { get; set; }

        /// <summary>
        /// The actual number of provisioned instances.
        /// </summary>
        [NameInMap("current")]
        [Validation(Required=false)]
        public long? Current { get; set; }

        /// <summary>
        /// The error message returned if a provisioned instance fails to be created.
        /// </summary>
        [NameInMap("currentError")]
        [Validation(Required=false)]
        public string CurrentError { get; set; }

        /// <summary>
        /// The description of the resource.
        /// </summary>
        [NameInMap("resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        /// <summary>
        /// The configurations of scheduled auto scaling.
        /// </summary>
        [NameInMap("scheduledActions")]
        [Validation(Required=false)]
        public List<ScheduledActions> ScheduledActions { get; set; }

        /// <summary>
        /// The expected number of provisioned instances.
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

    }

}

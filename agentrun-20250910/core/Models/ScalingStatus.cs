// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ScalingStatus : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>error</para>
        /// </summary>
        [NameInMap("currentError")]
        [Validation(Required=false)]
        public string CurrentError { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("currentInstances")]
        [Validation(Required=false)]
        public long? CurrentInstances { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("minInstances")]
        [Validation(Required=false)]
        public long? MinInstances { get; set; }

        [NameInMap("scheduledPolicies")]
        [Validation(Required=false)]
        public List<ScheduledPolicy> ScheduledPolicies { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("targetInstances")]
        [Validation(Required=false)]
        public long? TargetInstances { get; set; }

    }

}

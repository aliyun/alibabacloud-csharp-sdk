// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ScalingConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("minInstances")]
        [Validation(Required=false)]
        public long? MinInstances { get; set; }

        [NameInMap("scheduledPolicies")]
        [Validation(Required=false)]
        public List<ScheduledPolicy> ScheduledPolicies { get; set; }

    }

}

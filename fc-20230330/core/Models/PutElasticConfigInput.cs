// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class PutElasticConfigInput : TeaModel {
        [NameInMap("minInstances")]
        [Validation(Required=false)]
        public long? MinInstances { get; set; }

        [NameInMap("residentPoolId")]
        [Validation(Required=false)]
        public string ResidentPoolId { get; set; }

        [NameInMap("scalingPolicies")]
        [Validation(Required=false)]
        public List<ScalingPolicy> ScalingPolicies { get; set; }

        [NameInMap("scheduledPolicies")]
        [Validation(Required=false)]
        public List<ScheduledPolicy> ScheduledPolicies { get; set; }

    }

}

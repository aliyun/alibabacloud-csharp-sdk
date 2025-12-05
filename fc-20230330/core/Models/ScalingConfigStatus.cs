// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ScalingConfigStatus : TeaModel {
        [NameInMap("currentError")]
        [Validation(Required=false)]
        public string CurrentError { get; set; }

        [NameInMap("currentInstances")]
        [Validation(Required=false)]
        public long? CurrentInstances { get; set; }

        [NameInMap("enableOnDemandScaling")]
        [Validation(Required=false)]
        public bool? EnableOnDemandScaling { get; set; }

        [NameInMap("functionArn")]
        [Validation(Required=false)]
        public string FunctionArn { get; set; }

        [NameInMap("horizontalScalingPolicies")]
        [Validation(Required=false)]
        public List<ScalingPolicy> HorizontalScalingPolicies { get; set; }

        [NameInMap("minInstances")]
        [Validation(Required=false)]
        public long? MinInstances { get; set; }

        [NameInMap("residentPoolId")]
        [Validation(Required=false)]
        public string ResidentPoolId { get; set; }

        [NameInMap("scheduledPolicies")]
        [Validation(Required=false)]
        public List<ScheduledPolicy> ScheduledPolicies { get; set; }

        [NameInMap("targetInstances")]
        [Validation(Required=false)]
        public long? TargetInstances { get; set; }

    }

}

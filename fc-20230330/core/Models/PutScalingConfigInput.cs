// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class PutScalingConfigInput : TeaModel {
        [NameInMap("enableMixMode")]
        [Validation(Required=false)]
        public bool? EnableMixMode { get; set; }

        [NameInMap("enableOnDemandScaling")]
        [Validation(Required=false)]
        public bool? EnableOnDemandScaling { get; set; }

        [NameInMap("horizontalScalingPolicies")]
        [Validation(Required=false)]
        public List<ScalingPolicy> HorizontalScalingPolicies { get; set; }

        [NameInMap("minInstances")]
        [Validation(Required=false)]
        public long? MinInstances { get; set; }

        [NameInMap("requestDispatchPolicy")]
        [Validation(Required=false)]
        public string RequestDispatchPolicy { get; set; }

        [NameInMap("residentPoolId")]
        [Validation(Required=false)]
        public string ResidentPoolId { get; set; }

        [NameInMap("scheduledPolicies")]
        [Validation(Required=false)]
        public List<ScheduledPolicy> ScheduledPolicies { get; set; }

    }

}

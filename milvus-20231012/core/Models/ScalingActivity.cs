// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class ScalingActivity : TeaModel {
        [NameInMap("componentTypes")]
        [Validation(Required=false)]
        public string ComponentTypes { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("policyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        [NameInMap("scalingActivityId")]
        [Validation(Required=false)]
        public string ScalingActivityId { get; set; }

        [NameInMap("scalingActivityState")]
        [Validation(Required=false)]
        public string ScalingActivityState { get; set; }

        [NameInMap("scalingPolicyId")]
        [Validation(Required=false)]
        public string ScalingPolicyId { get; set; }

        [NameInMap("scalingRuleDetail")]
        [Validation(Required=false)]
        public string ScalingRuleDetail { get; set; }

        [NameInMap("scalingRuleId")]
        [Validation(Required=false)]
        public string ScalingRuleId { get; set; }

        [NameInMap("scalingRuleName")]
        [Validation(Required=false)]
        public string ScalingRuleName { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}

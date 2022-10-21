// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ScalingRule : TeaModel {
        [NameInMap("ActivityType")]
        [Validation(Required=false)]
        public string ActivityType { get; set; }

        [NameInMap("AdjustmentType")]
        [Validation(Required=false)]
        public string AdjustmentType { get; set; }

        [NameInMap("AdjustmentValue")]
        [Validation(Required=false)]
        public int? AdjustmentValue { get; set; }

        [NameInMap("MetricsTrigger")]
        [Validation(Required=false)]
        public MetricsTrigger MetricsTrigger { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("TimeTrigger")]
        [Validation(Required=false)]
        public TimeTrigger TimeTrigger { get; set; }

        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}

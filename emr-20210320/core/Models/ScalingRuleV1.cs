// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ScalingRuleV1 : TeaModel {
        [NameInMap("AdjustmentType")]
        [Validation(Required=false)]
        public string AdjustmentType { get; set; }

        [NameInMap("AdjustmentValue")]
        [Validation(Required=false)]
        public int? AdjustmentValue { get; set; }

        [NameInMap("CoolDownTime")]
        [Validation(Required=false)]
        public int? CoolDownTime { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("RuleParam")]
        [Validation(Required=false)]
        public ScalingRuleV1RuleParam RuleParam { get; set; }
        public class ScalingRuleV1RuleParam : TeaModel {
            [NameInMap("ComparisonOperator")]
            [Validation(Required=false)]
            public string ComparisonOperator { get; set; }

            [NameInMap("EvaluationCount")]
            [Validation(Required=false)]
            public int? EvaluationCount { get; set; }

            [NameInMap("LaunchExpirationTime")]
            [Validation(Required=false)]
            public int? LaunchExpirationTime { get; set; }

            [NameInMap("LaunchTime")]
            [Validation(Required=false)]
            public string LaunchTime { get; set; }

            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            [NameInMap("RecurrenceEndTime")]
            [Validation(Required=false)]
            public string RecurrenceEndTime { get; set; }

            [NameInMap("RecurrenceType")]
            [Validation(Required=false)]
            public string RecurrenceType { get; set; }

            [NameInMap("RecurrenceValue")]
            [Validation(Required=false)]
            public string RecurrenceValue { get; set; }

            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public int? Threshold { get; set; }

        }

        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        [NameInMap("ScalingConfigBizId")]
        [Validation(Required=false)]
        public string ScalingConfigBizId { get; set; }

    }

}

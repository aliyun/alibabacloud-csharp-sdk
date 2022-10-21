// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ScalingRuleSpec : TeaModel {
        [NameInMap("AdjustmentValue")]
        [Validation(Required=false)]
        public int? AdjustmentValue { get; set; }

        [NameInMap("ByLoadScalingRuleSpec")]
        [Validation(Required=false)]
        public ScalingRuleSpecByLoadScalingRuleSpec ByLoadScalingRuleSpec { get; set; }
        public class ScalingRuleSpecByLoadScalingRuleSpec : TeaModel {
            [NameInMap("ComparisonOperator")]
            [Validation(Required=false)]
            public string ComparisonOperator { get; set; }

            [NameInMap("EvaluationCount")]
            [Validation(Required=false)]
            public int? EvaluationCount { get; set; }

            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public double? Threshold { get; set; }

            [NameInMap("TimeWindow")]
            [Validation(Required=false)]
            public int? TimeWindow { get; set; }

        }

        [NameInMap("ByTimeScalingRuleSpec")]
        [Validation(Required=false)]
        public ScalingRuleSpecByTimeScalingRuleSpec ByTimeScalingRuleSpec { get; set; }
        public class ScalingRuleSpecByTimeScalingRuleSpec : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("LaunchTime")]
            [Validation(Required=false)]
            public long? LaunchTime { get; set; }

            [NameInMap("RecurrenceType")]
            [Validation(Required=false)]
            public string RecurrenceType { get; set; }

            [NameInMap("RecurrenceValue")]
            [Validation(Required=false)]
            public string RecurrenceValue { get; set; }

        }

        [NameInMap("CoolDownInterval")]
        [Validation(Required=false)]
        public int? CoolDownInterval { get; set; }

        [NameInMap("ScalingActivityType")]
        [Validation(Required=false)]
        public string ScalingActivityType { get; set; }

        [NameInMap("ScalingRuleName")]
        [Validation(Required=false)]
        public string ScalingRuleName { get; set; }

        [NameInMap("ScalingRuleType")]
        [Validation(Required=false)]
        public string ScalingRuleType { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeScalingRuleResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TimeoutWithGrace")]
        [Validation(Required=false)]
        public long? TimeoutWithGrace { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Cooldown")]
        [Validation(Required=false)]
        public int? Cooldown { get; set; }

        [NameInMap("CloudWatchTrigger")]
        [Validation(Required=false)]
        public DescribeScalingRuleResponseBodyCloudWatchTrigger CloudWatchTrigger { get; set; }
        public class DescribeScalingRuleResponseBodyCloudWatchTrigger : TeaModel {
            [NameInMap("ComparisonOperator")]
            [Validation(Required=false)]
            public string ComparisonOperator { get; set; }
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }
            [NameInMap("EvaluationCount")]
            [Validation(Required=false)]
            public string EvaluationCount { get; set; }
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }
            [NameInMap("MetricDisplayName")]
            [Validation(Required=false)]
            public string MetricDisplayName { get; set; }
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public string Threshold { get; set; }
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }
        };

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("AdjustmentType")]
        [Validation(Required=false)]
        public string AdjustmentType { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("AdjustmentValue")]
        [Validation(Required=false)]
        public int? AdjustmentValue { get; set; }

        [NameInMap("SchedulerTrigger")]
        [Validation(Required=false)]
        public DescribeScalingRuleResponseBodySchedulerTrigger SchedulerTrigger { get; set; }
        public class DescribeScalingRuleResponseBodySchedulerTrigger : TeaModel {
            [NameInMap("LaunchExpirationTime")]
            [Validation(Required=false)]
            public int? LaunchExpirationTime { get; set; }
            [NameInMap("RecurrenceValue")]
            [Validation(Required=false)]
            public string RecurrenceValue { get; set; }
            [NameInMap("RecurrenceType")]
            [Validation(Required=false)]
            public string RecurrenceType { get; set; }
            [NameInMap("RecurrenceEndTime")]
            [Validation(Required=false)]
            public long? RecurrenceEndTime { get; set; }
            [NameInMap("LaunchTime")]
            [Validation(Required=false)]
            public long? LaunchTime { get; set; }
        };

        [NameInMap("WithGrace")]
        [Validation(Required=false)]
        public bool? WithGrace { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("RuleCategory")]
        [Validation(Required=false)]
        public string RuleCategory { get; set; }

    }

}

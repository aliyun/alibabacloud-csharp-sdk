// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20140828.Models
{
    public class DescribeScalingRulesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("ScalingRules")]
        [Validation(Required=false)]
        public DescribeScalingRulesResponseBodyScalingRules ScalingRules { get; set; }
        public class DescribeScalingRulesResponseBodyScalingRules : TeaModel {
            [NameInMap("ScalingRule")]
            [Validation(Required=false)]
            public List<DescribeScalingRulesResponseBodyScalingRulesScalingRule> ScalingRule { get; set; }
            public class DescribeScalingRulesResponseBodyScalingRulesScalingRule : TeaModel {
                public string MetricName { get; set; }
                public int? InitialMaxSize { get; set; }
                public DescribeScalingRulesResponseBodyScalingRulesScalingRuleAlarms Alarms { get; set; }
                public class DescribeScalingRulesResponseBodyScalingRulesScalingRuleAlarms : TeaModel {
                    [NameInMap("Alarm")]
                    [Validation(Required=false)]
                    public List<DescribeScalingRulesResponseBodyScalingRulesScalingRuleAlarmsAlarm> Alarm { get; set; }
                    public class DescribeScalingRulesResponseBodyScalingRulesScalingRuleAlarmsAlarm : TeaModel {
                        [NameInMap("AlarmTaskId")]
                        [Validation(Required=false)]
                        public string AlarmTaskId { get; set; }

                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        [NameInMap("MetricName")]
                        [Validation(Required=false)]
                        public string MetricName { get; set; }

                        [NameInMap("EvaluationCount")]
                        [Validation(Required=false)]
                        public int? EvaluationCount { get; set; }

                        [NameInMap("AlarmTaskName")]
                        [Validation(Required=false)]
                        public string AlarmTaskName { get; set; }

                        [NameInMap("Dimensions")]
                        [Validation(Required=false)]
                        public DescribeScalingRulesResponseBodyScalingRulesScalingRuleAlarmsAlarmDimensions Dimensions { get; set; }
                        public class DescribeScalingRulesResponseBodyScalingRulesScalingRuleAlarmsAlarmDimensions : TeaModel {
                            [NameInMap("Dimension")]
                            [Validation(Required=false)]
                            public List<DescribeScalingRulesResponseBodyScalingRulesScalingRuleAlarmsAlarmDimensionsDimension> Dimension { get; set; }
                            public class DescribeScalingRulesResponseBodyScalingRulesScalingRuleAlarmsAlarmDimensionsDimension : TeaModel {
                                public string DimensionKey { get; set; }
                                public string DimensionValue { get; set; }
                            }
                        };

                        [NameInMap("MetricType")]
                        [Validation(Required=false)]
                        public string MetricType { get; set; }

                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public float? Threshold { get; set; }

                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                    }

                }
                public int? ScaleOutEvaluationCount { get; set; }
                public string PredictiveScalingMode { get; set; }
                public int? MinSize { get; set; }
                public int? PredictiveTaskBufferTime { get; set; }
                public string ScalingGroupId { get; set; }
                public string PredictiveValueBehavior { get; set; }
                public int? Cooldown { get; set; }
                public string ScalingRuleType { get; set; }
                public int? PredictiveValueBuffer { get; set; }
                public int? ScaleInEvaluationCount { get; set; }
                public bool? DisableScaleIn { get; set; }
                public string ScalingRuleName { get; set; }
                public string AdjustmentType { get; set; }
                public int? EstimatedInstanceWarmup { get; set; }
                public int? MinAdjustmentMagnitude { get; set; }
                public string ScalingRuleAri { get; set; }
                public DescribeScalingRulesResponseBodyScalingRulesScalingRuleStepAdjustments StepAdjustments { get; set; }
                public class DescribeScalingRulesResponseBodyScalingRulesScalingRuleStepAdjustments : TeaModel {
                    [NameInMap("StepAdjustment")]
                    [Validation(Required=false)]
                    public List<DescribeScalingRulesResponseBodyScalingRulesScalingRuleStepAdjustmentsStepAdjustment> StepAdjustment { get; set; }
                    public class DescribeScalingRulesResponseBodyScalingRulesScalingRuleStepAdjustmentsStepAdjustment : TeaModel {
                        [NameInMap("MetricIntervalUpperBound")]
                        [Validation(Required=false)]
                        public float? MetricIntervalUpperBound { get; set; }

                        [NameInMap("ScalingAdjustment")]
                        [Validation(Required=false)]
                        public int? ScalingAdjustment { get; set; }

                        [NameInMap("MetricIntervalLowerBound")]
                        [Validation(Required=false)]
                        public float? MetricIntervalLowerBound { get; set; }

                    }

                }
                public float? TargetValue { get; set; }
                public int? MaxSize { get; set; }
                public int? AdjustmentValue { get; set; }
                public string ScalingRuleId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}

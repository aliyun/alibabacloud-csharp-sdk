// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingRulesResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details of the scaling rules.
        /// </summary>
        [NameInMap("ScalingRules")]
        [Validation(Required=false)]
        public List<DescribeScalingRulesResponseBodyScalingRules> ScalingRules { get; set; }
        public class DescribeScalingRulesResponseBodyScalingRules : TeaModel {
            /// <summary>
            /// The scaling mode of the scaling rule. Valid values:
            /// 
            /// *   QuantityChangeInCapacity: adds the specified number of ECS instances to or removes the specified number of ECS instances from the scaling group.
            /// *   PercentChangeInCapacity: adds the specified percentage of ECS instances to or removes the specified percentage of ECS instances from the scaling group.
            /// *   TotalCapacity: adjusts the number of ECS instances in the scaling group to the specified number.
            /// </summary>
            [NameInMap("AdjustmentType")]
            [Validation(Required=false)]
            public string AdjustmentType { get; set; }

            /// <summary>
            /// The adjustment value that is specified in the scaling rule.
            /// </summary>
            [NameInMap("AdjustmentValue")]
            [Validation(Required=false)]
            public int? AdjustmentValue { get; set; }

            /// <summary>
            /// 监控项维度信息值，适用于目标追踪规则，当监控项需额外维度信息时设置，例如LoadBalancerRealServerAverageQps监控项需指定rulePool维度信息。
            /// </summary>
            [NameInMap("AlarmDimensions")]
            [Validation(Required=false)]
            public List<DescribeScalingRulesResponseBodyScalingRulesAlarmDimensions> AlarmDimensions { get; set; }
            public class DescribeScalingRulesResponseBodyScalingRulesAlarmDimensions : TeaModel {
                /// <summary>
                /// 监控项关联的维度信息键。
                /// </summary>
                [NameInMap("DimensionKey")]
                [Validation(Required=false)]
                public string DimensionKey { get; set; }

                /// <summary>
                /// 监控项关联的维度信息值。
                /// </summary>
                [NameInMap("DimensionValue")]
                [Validation(Required=false)]
                public string DimensionValue { get; set; }

            }

            /// <summary>
            /// The event-triggered tasks that are associated with the scaling rule. Event-triggered tasks that are associated with the scaling rule are returned only if you set the ShowAlarmRules parameter to true. Otherwise, an empty list is returned.
            /// </summary>
            [NameInMap("Alarms")]
            [Validation(Required=false)]
            public List<DescribeScalingRulesResponseBodyScalingRulesAlarms> Alarms { get; set; }
            public class DescribeScalingRulesResponseBodyScalingRulesAlarms : TeaModel {
                /// <summary>
                /// The ID of the event-triggered task that is associated with the scaling rule.
                /// </summary>
                [NameInMap("AlarmTaskId")]
                [Validation(Required=false)]
                public string AlarmTaskId { get; set; }

                /// <summary>
                /// The name of the event-triggered task that is associated with the scaling rule.
                /// </summary>
                [NameInMap("AlarmTaskName")]
                [Validation(Required=false)]
                public string AlarmTaskName { get; set; }

                /// <summary>
                /// The comparison operator between the metric value and the threshold for the event-triggered task that is associated with the scaling rule. The comparison operator indicates the relationship between the metric value and the threshold that is required to meet the condition.
                /// 
                /// *   Valid value if the metric value is greater than or equal to the threshold: >=.
                /// *   Valid value if the metric value is less than or equal to the threshold: <=.
                /// *   Valid value if the metric value is greater than the threshold: >.
                /// *   Valid value if the metric value is less than the threshold: <.
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// The dimensions of the event-triggered task that is associated with the scaling rule.
                /// </summary>
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public List<DescribeScalingRulesResponseBodyScalingRulesAlarmsDimensions> Dimensions { get; set; }
                public class DescribeScalingRulesResponseBodyScalingRulesAlarmsDimensions : TeaModel {
                    /// <summary>
                    /// The key of the dimension that is associated with the metric. Valid values:
                    /// 
                    /// *   scaling_group: the ID of the scaling group
                    /// *   userId: the ID of the Alibaba Cloud account
                    /// </summary>
                    [NameInMap("DimensionKey")]
                    [Validation(Required=false)]
                    public string DimensionKey { get; set; }

                    /// <summary>
                    /// The value of the dimension that is associated with the metric.
                    /// </summary>
                    [NameInMap("DimensionValue")]
                    [Validation(Required=false)]
                    public string DimensionValue { get; set; }

                }

                /// <summary>
                /// The number of consecutive times for which the event-triggered task that is associated with the scaling rule meets the threshold expressions before an alert is triggered.
                /// </summary>
                [NameInMap("EvaluationCount")]
                [Validation(Required=false)]
                public int? EvaluationCount { get; set; }

                /// <summary>
                /// The name of the metric of the event-triggered task that is associated with the scaling rule.
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// The type of the event-triggered task that is associated with the scaling rule. Valid values:
                /// 
                /// *   system: system monitoring event-triggered tasks
                /// *   custom: custom monitoring event-triggered tasks
                /// </summary>
                [NameInMap("MetricType")]
                [Validation(Required=false)]
                public string MetricType { get; set; }

                /// <summary>
                /// The statistical method of the event-triggered task that is associated with the scaling rule. Valid values:
                /// 
                /// *   Average
                /// *   Maximum
                /// *   Minimum
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// The alert threshold of the event-triggered task that is associated with the scaling rule.
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public float? Threshold { get; set; }

            }

            /// <summary>
            /// The cooldown time of the scaling rule. This parameter is available only if you set the ScalingRuleType parameter to SimpleScalingRule. Valid values: 0 to 86400. Unit: seconds.
            /// </summary>
            [NameInMap("Cooldown")]
            [Validation(Required=false)]
            public int? Cooldown { get; set; }

            /// <summary>
            /// Specifies whether to disable scale-in. This parameter is available only if you set the ScalingRuleType parameter to TargetTrackingScalingRule. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("DisableScaleIn")]
            [Validation(Required=false)]
            public bool? DisableScaleIn { get; set; }

            /// <summary>
            /// The warmup period of the ECS instance.
            /// </summary>
            [NameInMap("EstimatedInstanceWarmup")]
            [Validation(Required=false)]
            public int? EstimatedInstanceWarmup { get; set; }

            /// <summary>
            /// The maximum number of ECS instances in the scaling group. You must specify the InitialMaxSize and PredictiveValueBehavior parameters.
            /// </summary>
            [NameInMap("InitialMaxSize")]
            [Validation(Required=false)]
            public int? InitialMaxSize { get; set; }

            /// <summary>
            /// The maximum number of ECS instances in the scaling group.
            /// </summary>
            [NameInMap("MaxSize")]
            [Validation(Required=false)]
            public int? MaxSize { get; set; }

            /// <summary>
            /// The name of the metric of the event-triggered task that is associated with the scaling rule.
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The minimum number of instances that must be scaled when the AdjustmentType parameter is set to PercentChangeInCapacity. This parameter takes effect only if you set the ScalingRuleType parameter to SimpleScalingRule or StepScalingRule.
            /// </summary>
            [NameInMap("MinAdjustmentMagnitude")]
            [Validation(Required=false)]
            public int? MinAdjustmentMagnitude { get; set; }

            /// <summary>
            /// The minimum number of ECS instances in the scaling group.
            /// </summary>
            [NameInMap("MinSize")]
            [Validation(Required=false)]
            public int? MinSize { get; set; }

            /// <summary>
            /// The mode of the predictive scaling rule. Valid values:
            /// 
            /// *   PredictAndScale: produces predictions and creates prediction tasks.
            /// *   PredictOnly: produces predictions but does not create prediction tasks.
            /// </summary>
            [NameInMap("PredictiveScalingMode")]
            [Validation(Required=false)]
            public string PredictiveScalingMode { get; set; }

            /// <summary>
            /// The amount of buffer time before the prediction task is executed. By default, all scheduled tasks that are automatically created for a predictive scaling rule are executed on the hour. You can specify a buffer time for resource preparation before prediction tasks are executed. Valid values: 0 to 60. Unit: minutes.
            /// </summary>
            [NameInMap("PredictiveTaskBufferTime")]
            [Validation(Required=false)]
            public int? PredictiveTaskBufferTime { get; set; }

            /// <summary>
            /// Specifies which one of the initial maximum capacity and the predicted value can be used as the maximum value for prediction tasks. Valid values:
            /// 
            /// *   MaxOverridePredictiveValue: uses the initial maximum capacity as the maximum value for prediction tasks if the predicted value is greater than the initial maximum capacity.
            /// *   PredictiveValueOverrideMax: uses the predicted value as the maximum value for prediction tasks when the predicted value is greater than the initial maximum capacity.
            /// *   PredictiveValueOverrideMaxWithBuffer: increases the predicted value by a percentage that is specified by the PredictiveValueBuffer parameter. If the predicted value that is increased by the percentage is greater than the initial maximum capacity, the increased value is used as the maximum value for prediction tasks.
            /// </summary>
            [NameInMap("PredictiveValueBehavior")]
            [Validation(Required=false)]
            public string PredictiveValueBehavior { get; set; }

            /// <summary>
            /// The percentage of the increment to the predicted value when the PredictiveValueBehavior parameter is set to PredictiveValueOverrideMaxWithBuffer. If the predicted value increased by this percentage is greater than the initial maximum capacity, the increased value is used as the maximum value for prediction tasks. Valid values: 0 to 100.
            /// </summary>
            [NameInMap("PredictiveValueBuffer")]
            [Validation(Required=false)]
            public int? PredictiveValueBuffer { get; set; }

            /// <summary>
            /// The number of consecutive times that the event-triggered task created for scale-out activities must meet the threshold conditions before an alert is triggered. After a target tracking scaling rule is created, an event-triggered task is automatically created and then associated with the target tracking scaling rule.
            /// </summary>
            [NameInMap("ScaleInEvaluationCount")]
            [Validation(Required=false)]
            public int? ScaleInEvaluationCount { get; set; }

            /// <summary>
            /// The number of consecutive times that the event-triggered task created for scale-in activities must meet the threshold conditions before an alert is triggered. After a target tracking scaling rule is created, an event-triggered task is automatically created and then associated with the target tracking scaling rule.
            /// </summary>
            [NameInMap("ScaleOutEvaluationCount")]
            [Validation(Required=false)]
            public int? ScaleOutEvaluationCount { get; set; }

            /// <summary>
            /// The ID of the scaling group.
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// The unique identifier of the scaling rule.
            /// </summary>
            [NameInMap("ScalingRuleAri")]
            [Validation(Required=false)]
            public string ScalingRuleAri { get; set; }

            /// <summary>
            /// The ID of the scaling rule.
            /// </summary>
            [NameInMap("ScalingRuleId")]
            [Validation(Required=false)]
            public string ScalingRuleId { get; set; }

            /// <summary>
            /// The name of the scaling rule.
            /// </summary>
            [NameInMap("ScalingRuleName")]
            [Validation(Required=false)]
            public string ScalingRuleName { get; set; }

            /// <summary>
            /// The type of the scaling rule. Valid values:
            /// 
            /// *   SimpleScalingRule: adjusts the number of ECS instances based on the values of the AdjustmentType and AdjustmentValue parameters.
            /// *   TargetTrackingScalingRule: calculates the number of ECS instances that need to be scaled in a dynamic manner and maintains the value of a predefined metric close to the value of the TargetValue parameter.
            /// *   StepScalingRule: scales ECS instances in steps based on specified thresholds and metric values.
            /// *   PredictiveScalingRule: uses machine learning to analyze historical monitoring data of the scaling group and predicts the future values of metrics. In addition, Auto Scaling automatically creates scheduled tasks to adjust the boundary values for the scaling group.
            /// </summary>
            [NameInMap("ScalingRuleType")]
            [Validation(Required=false)]
            public string ScalingRuleType { get; set; }

            /// <summary>
            /// The step adjustments of the step scaling rule.
            /// </summary>
            [NameInMap("StepAdjustments")]
            [Validation(Required=false)]
            public List<DescribeScalingRulesResponseBodyScalingRulesStepAdjustments> StepAdjustments { get; set; }
            public class DescribeScalingRulesResponseBodyScalingRulesStepAdjustments : TeaModel {
                /// <summary>
                /// The lower limit that is specified in a step adjustment. Valid values: -9.999999E18 to 9.999999E18.
                /// </summary>
                [NameInMap("MetricIntervalLowerBound")]
                [Validation(Required=false)]
                public float? MetricIntervalLowerBound { get; set; }

                /// <summary>
                /// The upper limit that is specified in a step adjustment. Valid values: -9.999999E18 to 9.999999E18.
                /// </summary>
                [NameInMap("MetricIntervalUpperBound")]
                [Validation(Required=false)]
                public float? MetricIntervalUpperBound { get; set; }

                /// <summary>
                /// The number of ECS instances that are scaled in a step adjustment.
                /// </summary>
                [NameInMap("ScalingAdjustment")]
                [Validation(Required=false)]
                public int? ScalingAdjustment { get; set; }

            }

            /// <summary>
            /// The target value of the metric.
            /// </summary>
            [NameInMap("TargetValue")]
            [Validation(Required=false)]
            public float? TargetValue { get; set; }

        }

        /// <summary>
        /// The total number of scaling rules.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

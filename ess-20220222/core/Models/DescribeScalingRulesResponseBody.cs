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
        /// The scaling rules.
        /// </summary>
        [NameInMap("ScalingRules")]
        [Validation(Required=false)]
        public List<DescribeScalingRulesResponseBodyScalingRules> ScalingRules { get; set; }
        public class DescribeScalingRulesResponseBodyScalingRules : TeaModel {
            /// <summary>
            /// The adjustment method of the scaling rule. Valid values:
            /// 
            /// *   QuantityChangeInCapacity: adds or removes the specified number of Elastic Compute Service (ECS) instances to or from the scaling group.
            /// *   PercentChangeInCapacity: adds or removes the specified percentage of ECS instances to or from the scaling group.
            /// *   TotalCapacity: adjusts the number of ECS instances in the scaling group to the specified number.
            /// </summary>
            [NameInMap("AdjustmentType")]
            [Validation(Required=false)]
            public string AdjustmentType { get; set; }

            /// <summary>
            /// The number of instances that must be scaled based on the scaling rule.
            /// </summary>
            [NameInMap("AdjustmentValue")]
            [Validation(Required=false)]
            public int? AdjustmentValue { get; set; }

            /// <summary>
            /// The dimensions. This parameter is applicable to target tracking scaling rules. You can specify this parameter if your predefined metric requires extra dimensions. For example, if you predefine the LoadBalancerRealServerAverageQps metric, you must use this parameter to specify the rulePool dimension.
            /// </summary>
            [NameInMap("AlarmDimensions")]
            [Validation(Required=false)]
            public List<DescribeScalingRulesResponseBodyScalingRulesAlarmDimensions> AlarmDimensions { get; set; }
            public class DescribeScalingRulesResponseBodyScalingRulesAlarmDimensions : TeaModel {
                /// <summary>
                /// The dimension key of the metric.
                /// </summary>
                [NameInMap("DimensionKey")]
                [Validation(Required=false)]
                public string DimensionKey { get; set; }

                /// <summary>
                /// The dimension value of the metric.
                /// </summary>
                [NameInMap("DimensionValue")]
                [Validation(Required=false)]
                public string DimensionValue { get; set; }

            }

            /// <summary>
            /// The event-triggered tasks that are associated with the scaling rule. The value of this parameter is returned only if you set ShowAlarmRules to true. Otherwise, null is returned.
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
                /// The comparison operator between the statistical value and the threshold of the metric of the event-triggered task that is associated with the scaling rule. The comparison operator indicates the relationship in which the metric value and the metric threshold can meet the alert condition.
                /// 
                /// *   Valid value if the metric value is greater than or equal to the threshold: >=
                /// *   Valid value if the metric value is less than or equal to the threshold: <=
                /// *   Valid value if the metric value is greater than the threshold: >
                /// *   Valid value if the metric value is less than the threshold: <
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
                    /// *   ScalingGroupId: the ID of the scaling group.
                    /// *   userId: the ID of the user account.
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
                /// The number of consecutive times when the event-triggered task that is associated with the scaling rule must meet the alert condition before an alert is triggered.
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
                /// The type of the metric of the event-triggered task that is associated with the scaling rule. Valid values:
                /// 
                /// *   system: system metrics
                /// *   custom: custom metrics
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
            /// The cooldown period of the scaling rule. This parameter is available only if you set ScalingRuleType to SimpleScalingRule. Valid values: 0 to 86400. Unit: seconds.
            /// </summary>
            [NameInMap("Cooldown")]
            [Validation(Required=false)]
            public int? Cooldown { get; set; }

            /// <summary>
            /// Indicates whether scale-in is disabled. This parameter takes effect only if you set ScalingRuleType to TargetTrackingScalingRule. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("DisableScaleIn")]
            [Validation(Required=false)]
            public bool? DisableScaleIn { get; set; }

            /// <summary>
            /// The warm-up period of instances. During the warm-up period, a series of preparation measures are taken for the new instances. Performance metrics of instances being warmed up are not counted towards the monitoring range.
            /// </summary>
            [NameInMap("EstimatedInstanceWarmup")]
            [Validation(Required=false)]
            public int? EstimatedInstanceWarmup { get; set; }

            [NameInMap("HybridMetrics")]
            [Validation(Required=false)]
            public List<DescribeScalingRulesResponseBodyScalingRulesHybridMetrics> HybridMetrics { get; set; }
            public class DescribeScalingRulesResponseBodyScalingRulesHybridMetrics : TeaModel {
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public List<DescribeScalingRulesResponseBodyScalingRulesHybridMetricsDimensions> Dimensions { get; set; }
                public class DescribeScalingRulesResponseBodyScalingRulesHybridMetricsDimensions : TeaModel {
                    [NameInMap("DimensionKey")]
                    [Validation(Required=false)]
                    public string DimensionKey { get; set; }

                    [NameInMap("DimensionValue")]
                    [Validation(Required=false)]
                    public string DimensionValue { get; set; }

                }

                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                [NameInMap("Statistic")]
                [Validation(Required=false)]
                public string Statistic { get; set; }

            }

            [NameInMap("HybridMonitorNamespace")]
            [Validation(Required=false)]
            public string HybridMonitorNamespace { get; set; }

            /// <summary>
            /// The maximum number of ECS instances that can be contained in the scaling group. If you specify this parameter, you must also specify PredictiveValueBehavior.
            /// </summary>
            [NameInMap("InitialMaxSize")]
            [Validation(Required=false)]
            public int? InitialMaxSize { get; set; }

            /// <summary>
            /// The maximum number of ECS instances that can be contained in the scaling group.
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

            [NameInMap("MetricType")]
            [Validation(Required=false)]
            public string MetricType { get; set; }

            /// <summary>
            /// The minimum number of instances that must be scaled. This parameter takes effect only if you set ScalingRuleType to SimpleScalingRule or StepScalingRule and set AdjustmentType to PercentChangeInCapacity.
            /// </summary>
            [NameInMap("MinAdjustmentMagnitude")]
            [Validation(Required=false)]
            public int? MinAdjustmentMagnitude { get; set; }

            /// <summary>
            /// The minimum number of ECS instances that must be contained in the scaling group.
            /// </summary>
            [NameInMap("MinSize")]
            [Validation(Required=false)]
            public int? MinSize { get; set; }

            /// <summary>
            /// The mode of the predictive scaling rule. Valid values:
            /// 
            /// *   PredictAndScale: provides predictions and creates prediction tasks.
            /// *   PredictOnly: provides predictions but does not create prediction tasks.
            /// </summary>
            [NameInMap("PredictiveScalingMode")]
            [Validation(Required=false)]
            public string PredictiveScalingMode { get; set; }

            /// <summary>
            /// The amount of buffer time before prediction tasks are executed. By default, all prediction tasks that are automatically created based on a predictive scaling rule are executed on the hour. You can specify a buffer time for resource preparation before prediction tasks are executed. Valid values: 0 to 60. Unit: minutes.
            /// </summary>
            [NameInMap("PredictiveTaskBufferTime")]
            [Validation(Required=false)]
            public int? PredictiveTaskBufferTime { get; set; }

            /// <summary>
            /// The action on the predicted maximum value. Valid values:
            /// 
            /// *   MaxOverridePredictiveValue: uses the initial maximum capacity as the maximum value for prediction tasks if the predicted value is greater than the initial maximum capacity.
            /// *   PredictiveValueOverrideMax: uses the predicted value as the maximum value for prediction tasks when the predicted value is greater than the initial maximum capacity.
            /// *   PredictiveValueOverrideMaxWithBuffer: increases the predicted value by a ratio that is specified by PredictiveValueBuffer, and uses the increased value as the maximum value for prediction tasks if the predicted value increased by this ratio is greater than the initial maximum capacity.
            /// </summary>
            [NameInMap("PredictiveValueBehavior")]
            [Validation(Required=false)]
            public string PredictiveValueBehavior { get; set; }

            /// <summary>
            /// The ratio based on which the predicted value is increased when PredictiveValueBehavior is set to PredictiveValueOverrideMaxWithBuffer. If the predicted value increased by this ratio is greater than the initial maximum capacity, the increased value is used as the maximum value for prediction tasks. Valid values: 0 to 100.
            /// </summary>
            [NameInMap("PredictiveValueBuffer")]
            [Validation(Required=false)]
            public int? PredictiveValueBuffer { get; set; }

            /// <summary>
            /// The number of consecutive times that the event-triggered task for scale-in purposes must meet the threshold conditions before an alert is triggered. After a target tracking scaling rule is created, an event-triggered task is automatically created and associated with the target tracking scaling rule.
            /// </summary>
            [NameInMap("ScaleInEvaluationCount")]
            [Validation(Required=false)]
            public int? ScaleInEvaluationCount { get; set; }

            /// <summary>
            /// The number of consecutive times that the event-triggered task created for scale-out purposes must meet the threshold conditions before an alert is triggered. After a target tracking scaling rule is created, an event-triggered task is automatically created and associated with the target tracking scaling rule.
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
            /// *   SimpleScalingRule: a simple scaling rule. Once a simple scaling rule is executed, Auto Scaling adjusts the number of ECS instances in the scaling group based on the values of AdjustmentType and AdjustmentValue.
            /// *   TargetTrackingScalingRule: a target tracking scaling rule. Once a target tracking scaling rule is executed, Auto Scaling dynamically calculates the number of ECS instances or elastic container instances to scale based on the predefined metric (MetricName) and attempts to maintain the metric value close to the specified target value (TargetValue).
            /// *   StepScalingRule: a step scaling rule. Once a step scaling rule is executed, Auto Scaling scales instances step by step based on the predefined thresholds and metric values.
            /// *   PredictiveScalingRule: a predictive scaling rule. Once a predictive scaling rule is executed, Auto Scaling analyzes the historical monitoring data based on the machine learning technology and predicts the trends of metric data. Auto Scaling also creates scheduled tasks to enable dynamic adjustment of the boundary values for the scaling group.
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
                /// The lower limit of a step adjustment. Valid values: -9.999999E18 to 9.999999E18.
                /// </summary>
                [NameInMap("MetricIntervalLowerBound")]
                [Validation(Required=false)]
                public float? MetricIntervalLowerBound { get; set; }

                /// <summary>
                /// The upper limit of a step adjustment. Valid values: -9.999999E18 to 9.999999E18.
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
            /// The target value of the metric. If you set ScalingRuleType to TargetTrackingScalingRule or PredictiveScalingRule, Auto Scaling keeps the metric value close to the target value by adding instances to or removing instances from the scaling group.
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

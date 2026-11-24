// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the scaling rules.</para>
        /// </summary>
        [NameInMap("ScalingRules")]
        [Validation(Required=false)]
        public List<DescribeScalingRulesResponseBodyScalingRules> ScalingRules { get; set; }
        public class DescribeScalingRulesResponseBodyScalingRules : TeaModel {
            /// <summary>
            /// <para>The adjustment type of the scaling rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>QuantityChangeInCapacity: increases or decreases a specified number of ECS instances.</description></item>
            /// <item><description>PercentChangeInCapacity: increases or decreases a specified percentage of ECS instances.</description></item>
            /// <item><description>TotalCapacity: adjusts the number of ECS instances in the scaling group to a specified number.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>QuantityChangeInCapacity</para>
            /// </summary>
            [NameInMap("AdjustmentType")]
            [Validation(Required=false)]
            public string AdjustmentType { get; set; }

            /// <summary>
            /// <para>The adjustment value of the scaling rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AdjustmentValue")]
            [Validation(Required=false)]
            public int? AdjustmentValue { get; set; }

            /// <summary>
            /// <para>The dimension value of the metric. This parameter applies to target tracking scaling rules and is configured when the metric requires additional dimension information. For example, the LoadBalancerRealServerAverageQps metric requires the rulePool dimension information.</para>
            /// </summary>
            [NameInMap("AlarmDimensions")]
            [Validation(Required=false)]
            public List<DescribeScalingRulesResponseBodyScalingRulesAlarmDimensions> AlarmDimensions { get; set; }
            public class DescribeScalingRulesResponseBodyScalingRulesAlarmDimensions : TeaModel {
                /// <summary>
                /// <para>The key of the dimension associated with the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rulePool</para>
                /// </summary>
                [NameInMap("DimensionKey")]
                [Validation(Required=false)]
                public string DimensionKey { get; set; }

                /// <summary>
                /// <para>The value of the dimension associated with the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sgp-l1cbirz451yxu2****</para>
                /// </summary>
                [NameInMap("DimensionValue")]
                [Validation(Required=false)]
                public string DimensionValue { get; set; }

            }

            /// <summary>
            /// <para>The CloudMonitor event-triggered tasks associated with the scaling rule. The associated CloudMonitor event-triggered tasks are returned only when the ShowAlarmRules parameter is set to true. Otherwise, an empty list is returned.</para>
            /// </summary>
            [NameInMap("Alarms")]
            [Validation(Required=false)]
            public List<DescribeScalingRulesResponseBodyScalingRulesAlarms> Alarms { get; set; }
            public class DescribeScalingRulesResponseBodyScalingRulesAlarms : TeaModel {
                /// <summary>
                /// <para>The ID of the event-triggered task associated with the scaling rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asg-bp18p2yfxow2dloq****_1f9458d1-70e1-4bee-8c7f-7a47695b****</para>
                /// </summary>
                [NameInMap("AlarmTaskId")]
                [Validation(Required=false)]
                public string AlarmTaskId { get; set; }

                /// <summary>
                /// <para>The name of the event-triggered task associated with the scaling rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alarmtask****</para>
                /// </summary>
                [NameInMap("AlarmTaskName")]
                [Validation(Required=false)]
                public string AlarmTaskName { get; set; }

                /// <summary>
                /// <para>The comparison operator used to compare the statistical value of the metric with the threshold for the event-triggered task associated with the scaling rule. This operator specifies the relationship between the statistical value and the threshold that meets the condition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><remarks>
                /// <para>=: the statistical value of the metric is greater than or equal to the threshold.</para>
                /// </remarks>
                /// </description></item>
                /// <item><description>&lt;=: the statistical value of the metric is less than or equal to the threshold.</description></item>
                /// <item><description><remarks>
                /// <para>: the statistical value of the metric is greater than the threshold.</para>
                /// </remarks>
                /// </description></item>
                /// <item><description>&lt;: the statistical value of the metric is less than the threshold.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <remarks>
                /// <para>=</para>
                /// </remarks>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The dimension information of the event-triggered task associated with the scaling rule.</para>
                /// </summary>
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public List<DescribeScalingRulesResponseBodyScalingRulesAlarmsDimensions> Dimensions { get; set; }
                public class DescribeScalingRulesResponseBodyScalingRulesAlarmsDimensions : TeaModel {
                    /// <summary>
                    /// <para>The key of the dimension associated with the metric. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>scaling_group: the ID of the scaling group.</description></item>
                    /// <item><description>userId: the ID of the user account.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>scaling_group</para>
                    /// </summary>
                    [NameInMap("DimensionKey")]
                    [Validation(Required=false)]
                    public string DimensionKey { get; set; }

                    /// <summary>
                    /// <para>The value of the dimension associated with the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>asg-bp18p2yfxow2dloq****</para>
                    /// </summary>
                    [NameInMap("DimensionValue")]
                    [Validation(Required=false)]
                    public string DimensionValue { get; set; }

                }

                /// <summary>
                /// <para>The number of consecutive times the threshold expression must be met for the event-triggered task associated with the scaling rule to reach the alert state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("EvaluationCount")]
                [Validation(Required=false)]
                public int? EvaluationCount { get; set; }

                /// <summary>
                /// <para>The name of the metric for the event-triggered task associated with the scaling rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CpuUtilization</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The type of the event-triggered task associated with the scaling rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>system: system monitoring event-triggered task.</description></item>
                /// <item><description>custom: custom monitoring event-triggered task.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("MetricType")]
                [Validation(Required=false)]
                public string MetricType { get; set; }

                /// <summary>
                /// <para>The period for collecting metric data in the target tracking scaling rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public int? Period { get; set; }

                /// <summary>
                /// <para>The statistical method of the event-triggered task associated with the scaling rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Average: the average value.</description></item>
                /// <item><description>Maximum: the maximum value.</description></item>
                /// <item><description>Minimum: the minimum value.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>The alert threshold of the event-triggered task associated with the scaling rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public float? Threshold { get; set; }

            }

            /// <summary>
            /// <para>The cooldown time of the scaling rule. This parameter applies only to simple scaling rules. Valid values: 0 to 86400. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Cooldown")]
            [Validation(Required=false)]
            public int? Cooldown { get; set; }

            /// <summary>
            /// <para>Specifies whether to disable scale-in. This parameter applies only to target tracking scaling rules. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: disables scale-in.</description></item>
            /// <item><description>false: allows scale-in.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DisableScaleIn")]
            [Validation(Required=false)]
            public bool? DisableScaleIn { get; set; }

            /// <summary>
            /// <para>The warmup time required for newly created instances to complete a series of preparations. During the warmup period, the started instances do not affect the monitoring metrics of the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("EstimatedInstanceWarmup")]
            [Validation(Required=false)]
            public int? EstimatedInstanceWarmup { get; set; }

            /// <summary>
            /// <para>The monitoring metrics settings for Hybrid Cloud Monitoring. For more information about how to configure the settings, see <a href="https://help.aliyun.com/document_detail/2852162.html">Use formula operations to customize target tracking scaling rules</a>.</para>
            /// </summary>
            [NameInMap("HybridMetrics")]
            [Validation(Required=false)]
            public List<DescribeScalingRulesResponseBodyScalingRulesHybridMetrics> HybridMetrics { get; set; }
            public class DescribeScalingRulesResponseBodyScalingRulesHybridMetrics : TeaModel {
                /// <summary>
                /// <para>The dimensions of the metric. Used to specify the resources monitored by the metric.</para>
                /// </summary>
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public List<DescribeScalingRulesResponseBodyScalingRulesHybridMetricsDimensions> Dimensions { get; set; }
                public class DescribeScalingRulesResponseBodyScalingRulesHybridMetricsDimensions : TeaModel {
                    /// <summary>
                    /// <para>The key of the metric dimension.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>queue</para>
                    /// </summary>
                    [NameInMap("DimensionKey")]
                    [Validation(Required=false)]
                    public string DimensionKey { get; set; }

                    /// <summary>
                    /// <para>The value of the metric dimension.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testQueue</para>
                    /// </summary>
                    [NameInMap("DimensionValue")]
                    [Validation(Required=false)]
                    public string DimensionValue { get; set; }

                }

                /// <summary>
                /// <para>The metric operation expression for multiple Hybrid Cloud Monitoring metrics. The calculation result of the expression is used to trigger scaling.</para>
                /// <para>The operation expression must meet the Reverse Polish Notation (RPN) specification, and only the <c>+ - * /</c> operators are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(a+b)/2</para>
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <para>The reference ID of the metric in the metric operation expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the monitoring metrics in the monitoring metrics repository for Hybrid Cloud Monitoring.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AliyunSmq_NumberOfMessagesVisible</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The statistical method of the metric. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Average: the average value of all data points in the specified period.</description></item>
                /// <item><description>Minimum: the minimum value of all data points in the specified period.</description></item>
                /// <item><description>Maximum: the maximum value of all data points in the specified period.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistic")]
                [Validation(Required=false)]
                public string Statistic { get; set; }

            }

            /// <summary>
            /// <para>The ID of the monitoring metrics repository for Hybrid Cloud Monitoring.</para>
            /// <para>To manage monitoring metrics repositories, see <a href="https://help.aliyun.com/document_detail/217606.html">Manage monitoring metrics repositories</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun-test</para>
            /// </summary>
            [NameInMap("HybridMonitorNamespace")]
            [Validation(Required=false)]
            public string HybridMonitorNamespace { get; set; }

            /// <summary>
            /// <para>The maximum number of instances in the scaling group. This parameter is used in combination with PredictiveValueBehavior.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("InitialMaxSize")]
            [Validation(Required=false)]
            public int? InitialMaxSize { get; set; }

            /// <summary>
            /// <para>The maximum number of instances in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxSize")]
            [Validation(Required=false)]
            public int? MaxSize { get; set; }

            /// <summary>
            /// <para>The name of the metric for the event-triggered task associated with the scaling rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CpuUtilization</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The type of the metric. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>system: uses system metrics of CloudMonitor.</description></item>
            /// <item><description>custom: uses custom metrics reported to CloudMonitor.</description></item>
            /// <item><description>hybrid: uses metrics of Hybrid Cloud Monitoring.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("MetricType")]
            [Validation(Required=false)]
            public string MetricType { get; set; }

            /// <summary>
            /// <para>The minimum number of instances to be adjusted by the scaling rule. This parameter takes effect only when the scaling rule type is SimpleScalingRule or StepScalingRule and the AdjustmentType is PercentChangeInCapacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinAdjustmentMagnitude")]
            [Validation(Required=false)]
            public int? MinAdjustmentMagnitude { get; set; }

            /// <summary>
            /// <para>The minimum number of instances in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinSize")]
            [Validation(Required=false)]
            public int? MinSize { get; set; }

            /// <summary>
            /// <para>The mode of the predictive scaling rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PredictAndScale: generates prediction results and creates predictive tasks.</description></item>
            /// <item><description>PredictOnly: generates prediction results but does not create predictive tasks.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PredictAndScale</para>
            /// </summary>
            [NameInMap("PredictiveScalingMode")]
            [Validation(Required=false)]
            public string PredictiveScalingMode { get; set; }

            /// <summary>
            /// <para>The predictive tasks automatically created by the predictive scaling rule are executed on the hour by default. You can set the pre-start time to execute the predictive tasks in advance and prepare resources. Valid values: 0 to 60. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("PredictiveTaskBufferTime")]
            [Validation(Required=false)]
            public int? PredictiveTaskBufferTime { get; set; }

            /// <summary>
            /// <para>The processing method for the maximum value of the predictive scaling rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MaxOverridePredictiveValue: the initial maximum value overrides the predicted value. If the predicted value is greater than the initial maximum value, the maximum value of the predictive task uses the initial maximum value.</description></item>
            /// <item><description>PredictiveValueOverrideMax: the predicted value overrides the initial maximum value. If the predicted value is greater than the initial maximum value, the maximum value of the predictive task uses the predicted value.</description></item>
            /// <item><description>PredictiveValueOverrideMaxWithBuffer: a certain percentage is added to the predicted value. The predicted value is increased by the percentage specified by PredictiveValueBuffer. If the increased value is greater than the initial maximum value, the increased value is used.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MaxOverridePredictiveValue</para>
            /// </summary>
            [NameInMap("PredictiveValueBehavior")]
            [Validation(Required=false)]
            public string PredictiveValueBehavior { get; set; }

            /// <summary>
            /// <para>This parameter takes effect when PredictiveValueBehavior is set to PredictiveValueOverrideMaxWithBuffer. The predicted value is increased by this percentage. If the increased value is greater than the initial maximum value, the increased value is used. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PredictiveValueBuffer")]
            [Validation(Required=false)]
            public int? PredictiveValueBuffer { get; set; }

            /// <summary>
            /// <para>After a target tracking scaling rule is created, an event-triggered task is automatically created. This parameter specifies the number of consecutive times the threshold condition must be met to trigger the scale-in event-triggered task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("ScaleInEvaluationCount")]
            [Validation(Required=false)]
            public int? ScaleInEvaluationCount { get; set; }

            /// <summary>
            /// <para>After a target tracking scaling rule is created, an event-triggered task is automatically created. This parameter specifies the number of consecutive times the threshold condition must be met to trigger the scale-out event-triggered task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ScaleOutEvaluationCount")]
            [Validation(Required=false)]
            public int? ScaleOutEvaluationCount { get; set; }

            /// <summary>
            /// <para>The ID of the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asg-bp1ffogfdauy0jw0****</para>
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// <para>The unique identifier of the scaling rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ari:acs:ess:cn-hangzhou:140692647406****:scalingrule/asr-bp1dvirgwkoowxk7****</para>
            /// </summary>
            [NameInMap("ScalingRuleAri")]
            [Validation(Required=false)]
            public string ScalingRuleAri { get; set; }

            /// <summary>
            /// <para>The ID of the scaling rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asr-bp1dvirgwkoowxk7****</para>
            /// </summary>
            [NameInMap("ScalingRuleId")]
            [Validation(Required=false)]
            public string ScalingRuleId { get; set; }

            /// <summary>
            /// <para>The name of the scaling rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>scalingrule****</para>
            /// </summary>
            [NameInMap("ScalingRuleName")]
            [Validation(Required=false)]
            public string ScalingRuleName { get; set; }

            /// <summary>
            /// <para>The type of the scaling rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SimpleScalingRule: simple scaling rule. Adjusts the number of ECS instances based on the adjustment type (AdjustmentType) and adjustment value (AdjustmentValue).</description></item>
            /// <item><description>TargetTrackingScalingRule: target tracking scaling rule. Dynamically calculates the number of ECS instances to scale out or scale-in based on a predefined metric (MetricName) and attempts to maintain the metric value near the target value (TargetValue).</description></item>
            /// <item><description>StepScalingRule: step scaling rule. Provides a step-by-step extension method based on thresholds and metric values.</description></item>
            /// <item><description>PredictiveScalingRule: predictive scaling rule. Analyzes the historical monitoring data of the scaling group based on machine learning capabilities to predict future monitoring metrics, and supports the automatic creation of scheduled tasks to set the boundaries of the scaling group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SimpleScalingRule</para>
            /// </summary>
            [NameInMap("ScalingRuleType")]
            [Validation(Required=false)]
            public string ScalingRuleType { get; set; }

            /// <summary>
            /// <para>The step adjustments of the step scaling rule.</para>
            /// </summary>
            [NameInMap("StepAdjustments")]
            [Validation(Required=false)]
            public List<DescribeScalingRulesResponseBodyScalingRulesStepAdjustments> StepAdjustments { get; set; }
            public class DescribeScalingRulesResponseBodyScalingRulesStepAdjustments : TeaModel {
                /// <summary>
                /// <para>The lower boundary of the step adjustment. Valid values: -9.999999E18 to 9.999999E18.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("MetricIntervalLowerBound")]
                [Validation(Required=false)]
                public float? MetricIntervalLowerBound { get; set; }

                /// <summary>
                /// <para>The upper boundary of the step adjustment. Valid values: -9.999999E18 to 9.999999E18.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.0</para>
                /// </summary>
                [NameInMap("MetricIntervalUpperBound")]
                [Validation(Required=false)]
                public float? MetricIntervalUpperBound { get; set; }

                /// <summary>
                /// <para>The number of instances to be scaled for the step adjustment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ScalingAdjustment")]
                [Validation(Required=false)]
                public int? ScalingAdjustment { get; set; }

            }

            /// <summary>
            /// <para>The target value. When the scaling rule is a target tracking scaling rule or a predictive scaling rule, the scaling rule maintains the metric near the target value by adding or removing instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.125</para>
            /// </summary>
            [NameInMap("TargetValue")]
            [Validation(Required=false)]
            public float? TargetValue { get; set; }

        }

        /// <summary>
        /// <para>The total number of scaling rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

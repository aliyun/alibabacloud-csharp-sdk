// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The scaling rules.</para>
        /// </summary>
        [NameInMap("ScalingRules")]
        [Validation(Required=false)]
        public List<DescribeScalingRulesResponseBodyScalingRules> ScalingRules { get; set; }
        public class DescribeScalingRulesResponseBodyScalingRules : TeaModel {
            /// <summary>
            /// <para>The adjustment method of the scaling rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>QuantityChangeInCapacity: adds or removes the specified number of Elastic Compute Service (ECS) instances to or from the scaling group.</description></item>
            /// <item><description>PercentChangeInCapacity: adds or removes the specified percentage of ECS instances to or from the scaling group.</description></item>
            /// <item><description>TotalCapacity: adjusts the number of ECS instances in the scaling group to the specified number.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>QuantityChangeInCapacity</para>
            /// </summary>
            [NameInMap("AdjustmentType")]
            [Validation(Required=false)]
            public string AdjustmentType { get; set; }

            /// <summary>
            /// <para>The number of instances that must be scaled based on the scaling rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AdjustmentValue")]
            [Validation(Required=false)]
            public int? AdjustmentValue { get; set; }

            /// <summary>
            /// <para>The dimensions. This parameter is applicable to target tracking scaling rules. You can specify this parameter if your predefined metric requires extra dimensions. For example, if you predefine the LoadBalancerRealServerAverageQps metric, you must use this parameter to specify the rulePool dimension.</para>
            /// </summary>
            [NameInMap("AlarmDimensions")]
            [Validation(Required=false)]
            public List<DescribeScalingRulesResponseBodyScalingRulesAlarmDimensions> AlarmDimensions { get; set; }
            public class DescribeScalingRulesResponseBodyScalingRulesAlarmDimensions : TeaModel {
                /// <summary>
                /// <para>The dimension key of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rulePool</para>
                /// </summary>
                [NameInMap("DimensionKey")]
                [Validation(Required=false)]
                public string DimensionKey { get; set; }

                /// <summary>
                /// <para>The dimension value of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sgp-l1cbirz451yxu2dxxx</para>
                /// </summary>
                [NameInMap("DimensionValue")]
                [Validation(Required=false)]
                public string DimensionValue { get; set; }

            }

            /// <summary>
            /// <para>The event-triggered tasks that are associated with the scaling rule. The value of this parameter is returned only if you set ShowAlarmRules to true. Otherwise, null is returned.</para>
            /// </summary>
            [NameInMap("Alarms")]
            [Validation(Required=false)]
            public List<DescribeScalingRulesResponseBodyScalingRulesAlarms> Alarms { get; set; }
            public class DescribeScalingRulesResponseBodyScalingRulesAlarms : TeaModel {
                /// <summary>
                /// <para>The ID of the event-triggered task that is associated with the scaling rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asg-bp18p2yfxow2dloq****_1f9458d1-70e1-4bee-8c7f-7a47695b****</para>
                /// </summary>
                [NameInMap("AlarmTaskId")]
                [Validation(Required=false)]
                public string AlarmTaskId { get; set; }

                /// <summary>
                /// <para>The name of the event-triggered task that is associated with the scaling rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alarmtask****</para>
                /// </summary>
                [NameInMap("AlarmTaskName")]
                [Validation(Required=false)]
                public string AlarmTaskName { get; set; }

                /// <summary>
                /// <para>The comparison operator between the statistical value and the threshold of the metric of the event-triggered task that is associated with the scaling rule. The comparison operator indicates the relationship in which the metric value and the metric threshold can meet the alert condition.</para>
                /// <list type="bullet">
                /// <item><description>Valid value if the metric value is greater than or equal to the threshold: &gt;=</description></item>
                /// <item><description>Valid value if the metric value is less than or equal to the threshold: &lt;=</description></item>
                /// <item><description>Valid value if the metric value is greater than the threshold: &gt;</description></item>
                /// <item><description>Valid value if the metric value is less than the threshold: &lt;</description></item>
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
                /// <para>The dimensions of the event-triggered task that is associated with the scaling rule.</para>
                /// </summary>
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public List<DescribeScalingRulesResponseBodyScalingRulesAlarmsDimensions> Dimensions { get; set; }
                public class DescribeScalingRulesResponseBodyScalingRulesAlarmsDimensions : TeaModel {
                    /// <summary>
                    /// <para>The key of the dimension that is associated with the metric. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ScalingGroupId: the ID of the scaling group.</description></item>
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
                    /// <para>The value of the dimension that is associated with the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>asg-bp18p2yfxow2dloq****</para>
                    /// </summary>
                    [NameInMap("DimensionValue")]
                    [Validation(Required=false)]
                    public string DimensionValue { get; set; }

                }

                /// <summary>
                /// <para>The number of consecutive times when the event-triggered task that is associated with the scaling rule must meet the alert condition before an alert is triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("EvaluationCount")]
                [Validation(Required=false)]
                public int? EvaluationCount { get; set; }

                /// <summary>
                /// <para>The name of the metric of the event-triggered task that is associated with the scaling rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CpuUtilization</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The type of the metric of the event-triggered task that is associated with the scaling rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>system: system metrics</description></item>
                /// <item><description>custom: custom metrics</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("MetricType")]
                [Validation(Required=false)]
                public string MetricType { get; set; }

                /// <summary>
                /// <para>The statistical method of the event-triggered task that is associated with the scaling rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Average</description></item>
                /// <item><description>Maximum</description></item>
                /// <item><description>Minimum</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>The alert threshold of the event-triggered task that is associated with the scaling rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public float? Threshold { get; set; }

            }

            /// <summary>
            /// <para>The cooldown period of the scaling rule. This parameter is available only if you set ScalingRuleType to SimpleScalingRule. Valid values: 0 to 86400. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Cooldown")]
            [Validation(Required=false)]
            public int? Cooldown { get; set; }

            /// <summary>
            /// <para>Indicates whether scale-in is disabled. This parameter takes effect only if you set ScalingRuleType to TargetTrackingScalingRule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DisableScaleIn")]
            [Validation(Required=false)]
            public bool? DisableScaleIn { get; set; }

            /// <summary>
            /// <para>The warm-up period of instances. During the warm-up period, a series of preparation measures are taken for the new instances. Performance metrics of instances being warmed up are not counted towards the monitoring range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("EstimatedInstanceWarmup")]
            [Validation(Required=false)]
            public int? EstimatedInstanceWarmup { get; set; }

            /// <summary>
            /// <para>The Hybrid Cloud Monitoring metrics.</para>
            /// </summary>
            [NameInMap("HybridMetrics")]
            [Validation(Required=false)]
            public List<DescribeScalingRulesResponseBodyScalingRulesHybridMetrics> HybridMetrics { get; set; }
            public class DescribeScalingRulesResponseBodyScalingRulesHybridMetrics : TeaModel {
                /// <summary>
                /// <para>The metric dimensions. This parameter is used to specify the monitored resources.</para>
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
                    /// <para>The key of the metric dimension.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testQueue</para>
                    /// </summary>
                    [NameInMap("DimensionValue")]
                    [Validation(Required=false)]
                    public string DimensionValue { get; set; }

                }

                /// <summary>
                /// <para>The metric expression that consists of multiple Hybrid Cloud Monitoring metrics. It calculates a result used to trigger scaling events.</para>
                /// <para>The expression is written in Reverse Polish Notation (RPN) format and supports only the following operators: <c>+, -, *, /</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(a+b)/2</para>
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <para>The reference ID of the metric in the metric expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the Hybrid Cloud Monitoring metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AliyunSmq_NumberOfMessagesVisible</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The statistical method of the metric value. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Average: The average value of all metric values within a specified interval is calculated.</description></item>
                /// <item><description>Minimum: The minimum value of all metric values within a specified interval is calculated.</description></item>
                /// <item><description>Maximum: The maximum value of all metric values within a specified interval is calculated.</description></item>
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
            /// <para>The ID of the Hybrid Cloud Monitoring namespace.</para>
            /// <para>For information about how to manage Hybrid Cloud Monitoring namespaces, see <a href="https://help.aliyun.com/document_detail/217606.html">Manage namespaces</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun-test</para>
            /// </summary>
            [NameInMap("HybridMonitorNamespace")]
            [Validation(Required=false)]
            public string HybridMonitorNamespace { get; set; }

            /// <summary>
            /// <para>The maximum number of ECS instances that can be contained in the scaling group. If you specify this parameter, you must also specify PredictiveValueBehavior.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("InitialMaxSize")]
            [Validation(Required=false)]
            public int? InitialMaxSize { get; set; }

            /// <summary>
            /// <para>The maximum number of ECS instances that can be contained in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxSize")]
            [Validation(Required=false)]
            public int? MaxSize { get; set; }

            /// <summary>
            /// <para>The name of the metric of the event-triggered task that is associated with the scaling rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CpuUtilization</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The metric type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>system: system metrics of CloudMonitor.</description></item>
            /// <item><description>custom: custom metrics that are reported to CloudMonitor.</description></item>
            /// <item><description>hybrid: metrics of Hybrid Cloud Monitoring.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("MetricType")]
            [Validation(Required=false)]
            public string MetricType { get; set; }

            /// <summary>
            /// <para>The minimum number of instances that must be scaled. This parameter takes effect only if you set ScalingRuleType to SimpleScalingRule or StepScalingRule and set AdjustmentType to PercentChangeInCapacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinAdjustmentMagnitude")]
            [Validation(Required=false)]
            public int? MinAdjustmentMagnitude { get; set; }

            /// <summary>
            /// <para>The minimum number of ECS instances that must be contained in the scaling group.</para>
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
            /// <item><description>PredictAndScale: provides predictions and creates prediction tasks.</description></item>
            /// <item><description>PredictOnly: provides predictions but does not create prediction tasks.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PredictAndScale</para>
            /// </summary>
            [NameInMap("PredictiveScalingMode")]
            [Validation(Required=false)]
            public string PredictiveScalingMode { get; set; }

            /// <summary>
            /// <para>The amount of buffer time before prediction tasks are executed. By default, all prediction tasks that are automatically created based on a predictive scaling rule are executed on the hour. You can specify a buffer time for resource preparation before prediction tasks are executed. Valid values: 0 to 60. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("PredictiveTaskBufferTime")]
            [Validation(Required=false)]
            public int? PredictiveTaskBufferTime { get; set; }

            /// <summary>
            /// <para>The action on the predicted maximum value. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MaxOverridePredictiveValue: uses the initial maximum capacity as the maximum value for prediction tasks if the predicted value is greater than the initial maximum capacity.</description></item>
            /// <item><description>PredictiveValueOverrideMax: uses the predicted value as the maximum value for prediction tasks when the predicted value is greater than the initial maximum capacity.</description></item>
            /// <item><description>PredictiveValueOverrideMaxWithBuffer: increases the predicted value by a ratio that is specified by PredictiveValueBuffer, and uses the increased value as the maximum value for prediction tasks if the predicted value increased by this ratio is greater than the initial maximum capacity.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MaxOverridePredictiveValue</para>
            /// </summary>
            [NameInMap("PredictiveValueBehavior")]
            [Validation(Required=false)]
            public string PredictiveValueBehavior { get; set; }

            /// <summary>
            /// <para>The ratio based on which the predicted value is increased when PredictiveValueBehavior is set to PredictiveValueOverrideMaxWithBuffer. If the predicted value increased by this ratio is greater than the initial maximum capacity, the increased value is used as the maximum value for prediction tasks. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PredictiveValueBuffer")]
            [Validation(Required=false)]
            public int? PredictiveValueBuffer { get; set; }

            /// <summary>
            /// <para>The number of consecutive times that the event-triggered task for scale-in purposes must meet the threshold conditions before an alert is triggered. After a target tracking scaling rule is created, an event-triggered task is automatically created and associated with the target tracking scaling rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("ScaleInEvaluationCount")]
            [Validation(Required=false)]
            public int? ScaleInEvaluationCount { get; set; }

            /// <summary>
            /// <para>The number of consecutive times that the event-triggered task created for scale-out purposes must meet the threshold conditions before an alert is triggered. After a target tracking scaling rule is created, an event-triggered task is automatically created and associated with the target tracking scaling rule.</para>
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
            /// <item><description>SimpleScalingRule: a simple scaling rule. Once a simple scaling rule is executed, Auto Scaling adjusts the number of ECS instances in the scaling group based on the values of AdjustmentType and AdjustmentValue.</description></item>
            /// <item><description>TargetTrackingScalingRule: a target tracking scaling rule. Once a target tracking scaling rule is executed, Auto Scaling dynamically calculates the number of ECS instances or elastic container instances to scale based on the predefined metric (MetricName) and attempts to maintain the metric value close to the specified target value (TargetValue).</description></item>
            /// <item><description>StepScalingRule: a step scaling rule. Once a step scaling rule is executed, Auto Scaling scales instances step by step based on the predefined thresholds and metric values.</description></item>
            /// <item><description>PredictiveScalingRule: a predictive scaling rule. Once a predictive scaling rule is executed, Auto Scaling analyzes the historical monitoring data based on the machine learning technology and predicts the trends of metric data. Auto Scaling also creates scheduled tasks to enable dynamic adjustment of the boundary values for the scaling group.</description></item>
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
                /// <para>The lower limit of a step adjustment. Valid values: -9.999999E18 to 9.999999E18.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("MetricIntervalLowerBound")]
                [Validation(Required=false)]
                public float? MetricIntervalLowerBound { get; set; }

                /// <summary>
                /// <para>The upper limit of a step adjustment. Valid values: -9.999999E18 to 9.999999E18.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.0</para>
                /// </summary>
                [NameInMap("MetricIntervalUpperBound")]
                [Validation(Required=false)]
                public float? MetricIntervalUpperBound { get; set; }

                /// <summary>
                /// <para>The number of ECS instances that are scaled in a step adjustment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ScalingAdjustment")]
                [Validation(Required=false)]
                public int? ScalingAdjustment { get; set; }

            }

            /// <summary>
            /// <para>The target value of the metric. If you set ScalingRuleType to TargetTrackingScalingRule or PredictiveScalingRule, Auto Scaling keeps the metric value close to the target value by adding instances to or removing instances from the scaling group.</para>
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

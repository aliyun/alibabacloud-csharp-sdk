// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CreateScalingRuleRequest : TeaModel {
        /// <summary>
        /// <para>The scaling method of the scaling rule. This parameter is required only if you set the ScalingRuleType parameter to SimpleScalingRule or StepScalingRule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>QuantityChangeInCapacity: adds the specified number of ECS instances to or removes the specified number of ECS instances from the scaling group.</description></item>
        /// <item><description>PercentChangeInCapacity: adds the specified percentage of ECS instances to or removes the specified percentage of ECS instances from the scaling group.</description></item>
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
        /// <para>The number of instances that must be scaled based on the scaling rule. This parameter is required only if you set the ScalingRuleType parameter to SimpleScalingRule or StepScalingRule. The number of ECS instances that are scaled in a single scaling activity cannot exceed 1,000.</para>
        /// <list type="bullet">
        /// <item><description>Valid values if you set the AdjustmentType parameter to QuantityChangeInCapacity: -1000 to 1000.</description></item>
        /// <item><description>Valid values if you set the AdjustmentType parameter to PercentChangeInCapacity: -100 to 10000.</description></item>
        /// <item><description>Valid values if you set the AdjustmentType parameter to TotalCapacity: 0 to 2000.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("AdjustmentValue")]
        [Validation(Required=false)]
        public int? AdjustmentValue { get; set; }

        /// <summary>
        /// <para>The metric dimensions. This parameter is applicable to target tracking scaling rules. If your predefined metric requires extra dimensions, you must specify this parameter. For example, if you use LoadBalancerRealServerAverageQps as your predefined metric, you must use this parameter to specify the rulePool dimension.</para>
        /// </summary>
        [NameInMap("AlarmDimensions")]
        [Validation(Required=false)]
        public List<CreateScalingRuleRequestAlarmDimensions> AlarmDimensions { get; set; }
        public class CreateScalingRuleRequestAlarmDimensions : TeaModel {
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
            /// <para>sgp-l1cbirz451yxuxxx</para>
            /// </summary>
            [NameInMap("DimensionValue")]
            [Validation(Required=false)]
            public string DimensionValue { get; set; }

        }

        /// <summary>
        /// <para>The cooldown time of the scaling rule. This parameter is available only if you set the ScalingRuleType parameter to SimpleScalingRule. Valid values: 0 to 86400. Unit: seconds.</para>
        /// <para>By default, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Cooldown")]
        [Validation(Required=false)]
        public int? Cooldown { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable scale-in. This parameter is available only if you set the ScalingRuleType parameter to TargetTrackingScalingRule.</para>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableScaleIn")]
        [Validation(Required=false)]
        public bool? DisableScaleIn { get; set; }

        /// <summary>
        /// <para>The warmup period of an instance. This parameter is available only if you set the ScalingRuleType parameter to TargetTrackingScalingRule or PredictiveScalingRule. Auto Scaling adds ECS instances that are in the warmup state to a scaling group but does not report monitoring data to CloudMonitor during the warmup period.</para>
        /// <remarks>
        /// <para>Auto Scaling calculates the number of ECS instances that must be scaled. ECS instances in the warmup state are not counted towards the current capacity of the scaling group.</para>
        /// </remarks>
        /// <para>Valid values: 0 to 86400. Unit: seconds.</para>
        /// <para>Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("EstimatedInstanceWarmup")]
        [Validation(Required=false)]
        public int? EstimatedInstanceWarmup { get; set; }

        [NameInMap("HybridMetrics")]
        [Validation(Required=false)]
        public List<CreateScalingRuleRequestHybridMetrics> HybridMetrics { get; set; }
        public class CreateScalingRuleRequestHybridMetrics : TeaModel {
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<CreateScalingRuleRequestHybridMetricsDimensions> Dimensions { get; set; }
            public class CreateScalingRuleRequestHybridMetricsDimensions : TeaModel {
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
        /// <para>The maximum number of ECS instances that can be contained in the scaling group. If you specify InitialMaxSize, you must specify <c>PredictiveValueBehavior</c>.</para>
        /// <para>The default value of this parameter is the value of MaxSize.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("InitialMaxSize")]
        [Validation(Required=false)]
        public int? InitialMaxSize { get; set; }

        /// <summary>
        /// <para>The predefined metric of the scaling rule. If you set ScalingRuleType to TargetTrackingScalingRule or PredictiveScalingRule, you must specify this parameter.</para>
        /// <para>Valid values if you set ScalingRuleType to TargetTrackingScalingRule:</para>
        /// <list type="bullet">
        /// <item><description>CpuUtilizationAgent (recommended): the CPU utilization.</description></item>
        /// <item><description>MemoryUtilization (recommended): the memory usage.</description></item>
        /// <item><description>CpuUtilization: the average CPU utilization.</description></item>
        /// <item><description>IntranetTx: the outbound traffic over an internal network.</description></item>
        /// <item><description>IntranetRx: the inbound traffic over an internal network.</description></item>
        /// <item><description>VpcInternetTx: the outbound traffic from a virtual private cloud (VPC) to the Internet.</description></item>
        /// <item><description>VpcInternetRx: the inbound traffic from the Internet to a VPC.</description></item>
        /// <item><description>LoadBalancerRealServerAverageQps:the queries per second (QPS) per Application Load Balancer (ALB) server group.</description></item>
        /// </list>
        /// <para>Valid values if you set ScalingRuleType to PredictiveScalingRule:</para>
        /// <list type="bullet">
        /// <item><description>CpuUtilization: the average CPU utilization.</description></item>
        /// <item><description>IntranetRx: the inbound traffic over an internal network.</description></item>
        /// <item><description>IntranetTx: the outbound traffic over an internal network.</description></item>
        /// </list>
        /// <para>For more information, see <a href="https://www.alibabacloud.com/help/zh/auto-scaling/user-guide/event-triggered-tasks-of-the-system-monitoring-type">Event-triggered tasks of the system monitoring type</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CpuUtilization</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>The minimum number of instances that must be scaled when the AdjustmentType parameter is set to PercentChangeInCapacity. This parameter takes effect only if you set the ScalingRuleType parameter to SimpleScalingRule or StepScalingRule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinAdjustmentMagnitude")]
        [Validation(Required=false)]
        public int? MinAdjustmentMagnitude { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The mode of the predictive scaling rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PredictAndScale: produces predictions and creates prediction tasks.</description></item>
        /// <item><description>PredictOnly: produces predictions but does not create prediction tasks.</description></item>
        /// </list>
        /// <para>Default value: PredictAndScale.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PredictAndScale</para>
        /// </summary>
        [NameInMap("PredictiveScalingMode")]
        [Validation(Required=false)]
        public string PredictiveScalingMode { get; set; }

        /// <summary>
        /// <para>The amount of buffer time before the prediction task is executed. By default, all prediction tasks that are automatically created for a predictive scaling rule are executed on the hour. You can specify an amount of buffer time for resource preparation before the prediction tasks are executed. Valid values: 0 to 60. Unit: minutes.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PredictiveTaskBufferTime")]
        [Validation(Required=false)]
        public int? PredictiveTaskBufferTime { get; set; }

        /// <summary>
        /// <para>The maximum value for predication tasks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MaxOverridePredictiveValue: uses the initial maximum capacity as the maximum value for prediction tasks if the predicted value is greater than the initial maximum capacity.</description></item>
        /// <item><description>PredictiveValueOverrideMax: uses the predicted value as the maximum value for prediction tasks if the predicted value is greater than the initial maximum capacity.</description></item>
        /// <item><description>PredictiveValueOverrideMaxWithBuffer: increases the predicted value by a percentage that is specified by the PredictiveValueBuffer parameter. If the predicted value that is increased by the percentage is greater than the initial maximum capacity, the increased value is used as the maximum value for prediction tasks.</description></item>
        /// </list>
        /// <para>Default value: MaxOverridePredictiveValue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxOverridePredictiveValue</para>
        /// </summary>
        [NameInMap("PredictiveValueBehavior")]
        [Validation(Required=false)]
        public string PredictiveValueBehavior { get; set; }

        /// <summary>
        /// <para>The ratio based on which the predicted value is increased when you set <c>PredictiveValueBehavior</c> to <c>PredictiveValueOverrideMaxWithBuffer</c>. If the predicted value increased by this ratio is greater than the initial maximum capacity, the increased value is used as the maximum value for prediction tasks. Valid values: 0 to 100.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PredictiveValueBuffer")]
        [Validation(Required=false)]
        public int? PredictiveValueBuffer { get; set; }

        /// <summary>
        /// <para>The region ID of the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The number of consecutive times that the event-triggered task created for scale-in activities must meet the threshold conditions before an alert is triggered. After a target tracking scaling rule is created, an event-triggered task is automatically created and then associated with the target tracking scaling rule.</para>
        /// <para>Default value: 15.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("ScaleInEvaluationCount")]
        [Validation(Required=false)]
        public int? ScaleInEvaluationCount { get; set; }

        /// <summary>
        /// <para>The number of consecutive times that the event-triggered task created for scale-out activities must meet the threshold conditions before an alert is triggered. After a target tracking scaling rule is created, an event-triggered task is automatically created and then associated with the target tracking scaling rule.</para>
        /// <para>Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ScaleOutEvaluationCount")]
        [Validation(Required=false)]
        public int? ScaleOutEvaluationCount { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group to which the scaling rule belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp1ffogfdauy0jw0****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>The name of the scaling rule. The name must be 2 to 64 characters in length, and can contain letters, digits, underscores (_), hyphens (-), and periods (.). The name must start with a letter or a digit.</para>
        /// <para>The name of each scaling rule must be unique under the same account within a region.</para>
        /// <para>If you leave this parameter empty, the scaling rule ID is used.</para>
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
        /// <item><description>SimpleScalingRule: a simple scaling rule. Once a simple scaling rule is executed, Auto Scaling adjusts the number of ECS instances or elastic container instances in the scaling group based on the values of AdjustmentType and AdjustmentValue.</description></item>
        /// <item><description>TargetTrackingScalingRule: a target tracking scaling rule. Once a target tracking scaling rule is executed, Auto Scaling dynamically calculates the number of ECS instances or elastic container instances to scale based on the predefined metric (MetricName) and attempts to maintain the metric value close to the specified target value (TargetValue).</description></item>
        /// <item><description>StepScalingRule: a step scaling rule. Once a step scaling rule is executed, Auto Scaling scales instances step by step based on the predefined thresholds and metric values.</description></item>
        /// <item><description>PredictiveScalingRule: a predictive scaling rule. Once a predictive scaling rule is executed, Auto Scaling analyzes the historical monitoring data based on the machine learning technology and predicts the trends of metric data. Auto Scaling also creates scheduled tasks to enable dynamic adjustment of the boundary values for the scaling group.</description></item>
        /// </list>
        /// <para>Default value: SimpleScalingRule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SimpleScalingRule</para>
        /// </summary>
        [NameInMap("ScalingRuleType")]
        [Validation(Required=false)]
        public string ScalingRuleType { get; set; }

        /// <summary>
        /// <para>Details of the step adjustments.</para>
        /// </summary>
        [NameInMap("StepAdjustments")]
        [Validation(Required=false)]
        public List<CreateScalingRuleRequestStepAdjustments> StepAdjustments { get; set; }
        public class CreateScalingRuleRequestStepAdjustments : TeaModel {
            /// <summary>
            /// <para>The lower limit specified in a step adjustment. This parameter is available only if you set the ScalingRuleType parameter to StepScalingRule. Valid values: -9.999999E18 to 9.999999E18.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("MetricIntervalLowerBound")]
            [Validation(Required=false)]
            public float? MetricIntervalLowerBound { get; set; }

            /// <summary>
            /// <para>The upper limit that is specified in a step adjustment. Valid values: -9.999999E18 to 9.999999E18.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.0</para>
            /// </summary>
            [NameInMap("MetricIntervalUpperBound")]
            [Validation(Required=false)]
            public float? MetricIntervalUpperBound { get; set; }

            /// <summary>
            /// <para>The number of ECS instances that you want to scale in a step adjustment. This parameter is available only if you set the ScalingRuleType parameter to StepScalingRule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScalingAdjustment")]
            [Validation(Required=false)]
            public int? ScalingAdjustment { get; set; }

        }

        /// <summary>
        /// <para>The target value. This parameter is required only if you set the ScalingRuleType parameter to TargetTrackingScalingRule or PredictiveScalingRule. The value must be greater than 0 and can have up to three decimal places.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.125</para>
        /// </summary>
        [NameInMap("TargetValue")]
        [Validation(Required=false)]
        public float? TargetValue { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyScalingRuleRequest : TeaModel {
        /// <summary>
        /// <para>The adjustment method of the scaling rule. This is required when the ScalingRuleType parameter is set to SimpleScalingRule or StepScalingRule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>QuantityChangeInCapacity: adds the specified number of ECS instances to or removes the specified number of ECS instances from the scaling group.</description></item>
        /// <item><description>PercentChangeInCapacity: adds the specified percentage of ECS instances to or removes the specified percentage of ECS instances from the scaling group.</description></item>
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
        /// <para>The target value specified in the scaling rule. This parameter is required when the ScalingRuleType parameter is set to SimpleScalingRule or StepScalingRule. The number of ECS instances that are scaled in a single scaling activity cannot exceed 1,000.</para>
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
        /// <para>The dimensions. This parameter is applicable to target tracking scaling rules. You can specify this parameter if your predefined metric requires extra dimensions. For example, if you predefine the LoadBalancerRealServerAverageQps metric, you must use this parameter to specify the rulePool dimension.</para>
        /// </summary>
        [NameInMap("AlarmDimensions")]
        [Validation(Required=false)]
        public List<ModifyScalingRuleRequestAlarmDimensions> AlarmDimensions { get; set; }
        public class ModifyScalingRuleRequestAlarmDimensions : TeaModel {
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
        /// <para>The cooldown time of the scaling rule. This parameter is available only if you set the ScalingRuleType parameter to SimpleScalingRule.</para>
        /// <para>Valid values: 0 to 86400. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Cooldown")]
        [Validation(Required=false)]
        public int? Cooldown { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable scale-in. This parameter is available only if you set the ScalingRuleType parameter to TargetTrackingScalingRule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisableScaleIn")]
        [Validation(Required=false)]
        public bool? DisableScaleIn { get; set; }

        /// <summary>
        /// <para>The warmup period of an instance. This parameter is available only if you set the ScalingRuleType parameter to TargetTrackingScalingRule or PredictiveScalingRule. Auto Scaling adds ECS instances that are in the warmup state to a scaling group but does not report monitoring data to CloudMonitor during the warmup period.</para>
        /// <remarks>
        /// <para>Auto Scaling calculates the number of ECS instances that need to be scaled. ECS instances in the warmup state are not counted towards the current capacity of the scaling group.</para>
        /// </remarks>
        /// <para>Valid values: 0 to 86400. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("EstimatedInstanceWarmup")]
        [Validation(Required=false)]
        public int? EstimatedInstanceWarmup { get; set; }

        [NameInMap("HybridMetrics")]
        [Validation(Required=false)]
        public List<ModifyScalingRuleRequestHybridMetrics> HybridMetrics { get; set; }
        public class ModifyScalingRuleRequestHybridMetrics : TeaModel {
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<ModifyScalingRuleRequestHybridMetricsDimensions> Dimensions { get; set; }
            public class ModifyScalingRuleRequestHybridMetricsDimensions : TeaModel {
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
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("InitialMaxSize")]
        [Validation(Required=false)]
        public int? InitialMaxSize { get; set; }

        /// <summary>
        /// <para>The predefined metric. This parameter is required only if you create a target tracking scaling rule or predictive scaling rule.</para>
        /// <para>Valid values if you create a target tracking scaling rule:</para>
        /// <list type="bullet">
        /// <item><description>CpuUtilizationAgent (recommended): the CPU utilization.</description></item>
        /// <item><description>MemoryUtilization (recommended): the memory usage.</description></item>
        /// <item><description>CpuUtilization: the average CPU utilization.</description></item>
        /// <item><description>IntranetTx: the average outbound traffic over an internal network.</description></item>
        /// <item><description>IntranetRx: the average inbound traffic over an internal network.</description></item>
        /// <item><description>VpcInternetTx: the average outbound traffic from a virtual private cloud (VPC) to the Internet.</description></item>
        /// <item><description>VpcInternetRx: the average inbound traffic from the Internet to a VPC.</description></item>
        /// <item><description>LoadBalancerRealServerAverageQps: the queries per second (QPS) per Application Load Balancer (ALB) server group.</description></item>
        /// </list>
        /// <para>Valid values if you create a predictive scaling rule:</para>
        /// <list type="bullet">
        /// <item><description>CpuUtilization: the average CPU utilization.</description></item>
        /// <item><description>IntranetRx: the average inbound traffic over an internal network.</description></item>
        /// <item><description>IntranetTx: the average outbound traffic over an internal network.</description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/74854.html">Event-triggered tasks of the system monitoring type</a>.</para>
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
        /// <para>The minimum number of instances to scale. This parameter takes effect only if you create a simple scaling rule or step scaling rule and set <c>AdjustmentType</c> to <c>PercentChangeInCapacity</c>.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>PredictAndScale</para>
        /// </summary>
        [NameInMap("PredictiveScalingMode")]
        [Validation(Required=false)]
        public string PredictiveScalingMode { get; set; }

        /// <summary>
        /// <para>The amount of buffer time before the prediction task is executed. By default, all prediction tasks that are automatically created for a predictive scaling rule are executed on the hour. You can specify an amount of buffer time for resource preparation before the prediction tasks are executed. Valid values: 0 to 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PredictiveTaskBufferTime")]
        [Validation(Required=false)]
        public int? PredictiveTaskBufferTime { get; set; }

        /// <summary>
        /// <para>Specifies which one of the initial maximum capacity and the predicted value can be used as the maximum value for prediction tasks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MaxOverridePredictiveValue: uses the initial maximum capacity as the maximum value for prediction tasks if the predicted value is greater than the initial maximum capacity.</description></item>
        /// <item><description>PredictiveValueOverrideMax: uses the predicted value as the maximum value for prediction tasks when the predicted value is greater than the initial maximum capacity.</description></item>
        /// <item><description>PredictiveValueOverrideMaxWithBuffer: increases the predicted value by a percentage that is specified by the PredictiveValueBuffer parameter. If the predicted value that is increased by the percentage is greater than the initial maximum capacity, the increased value is used as the maximum value for prediction tasks.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MaxOverridePredictiveValue</para>
        /// </summary>
        [NameInMap("PredictiveValueBehavior")]
        [Validation(Required=false)]
        public string PredictiveValueBehavior { get; set; }

        /// <summary>
        /// <para>The ratio based on which the predicted value is increased when <c>PredictiveValueBehavior</c> is set to <c>PredictiveValueOverrideMaxWithBuffer</c>. If the predicted value increased by this ratio is greater than the initial maximum capacity, the increased value is used as the maximum value for prediction tasks. Valid values: 0 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PredictiveValueBuffer")]
        [Validation(Required=false)]
        public int? PredictiveValueBuffer { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The number of consecutive times that the event-triggered task created for scale-in activities must meet the threshold conditions before an alert is triggered. After a target tracking scaling rule is created, an event-triggered task is automatically created and then associated with the target tracking scaling rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("ScaleInEvaluationCount")]
        [Validation(Required=false)]
        public int? ScaleInEvaluationCount { get; set; }

        /// <summary>
        /// <para>The number of consecutive times that the event-triggered task created for scale-out activities must meet the threshold conditions before an alert is triggered. After a target tracking scaling rule is created, an event-triggered task is automatically created and then associated with the target tracking scaling rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ScaleOutEvaluationCount")]
        [Validation(Required=false)]
        public int? ScaleOutEvaluationCount { get; set; }

        /// <summary>
        /// <para>The ID of the scaling rule that you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asr-bp1dvirgwkoowxk7****</para>
        /// </summary>
        [NameInMap("ScalingRuleId")]
        [Validation(Required=false)]
        public string ScalingRuleId { get; set; }

        /// <summary>
        /// <para>The name of the scaling rule. The name must be 2 to 64 letters in length and can contain letters, digits, underscores (_), hyphens (-), and periods (.). It must start with a letter or digit.</para>
        /// <para>The name of each scaling rule must be unique under the same account within the same region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scalingrule****</para>
        /// </summary>
        [NameInMap("ScalingRuleName")]
        [Validation(Required=false)]
        public string ScalingRuleName { get; set; }

        /// <summary>
        /// <para>Details of the step adjustments.</para>
        /// </summary>
        [NameInMap("StepAdjustments")]
        [Validation(Required=false)]
        public List<ModifyScalingRuleRequestStepAdjustments> StepAdjustments { get; set; }
        public class ModifyScalingRuleRequestStepAdjustments : TeaModel {
            /// <summary>
            /// <para>The lower limit that is specified in a step adjustment. This parameter is available only if you set the ScalingRuleType parameter to StepScalingRule. Valid values: -9.999999E18 to 9.999999E18.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("MetricIntervalLowerBound")]
            [Validation(Required=false)]
            public float? MetricIntervalLowerBound { get; set; }

            /// <summary>
            /// <para>The upper limit specified in a step adjustment. This parameter is available only if you set the ScalingRuleType parameter to StepScalingRule. Valid values: -9.999999E18 to 9.999999E18.</para>
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
        /// <para>The target value. This parameter is available only if you set the ScalingRuleType parameter to TargetTrackingScalingRule or PredictiveScalingRule. The value must be greater than 0 and can have up to three decimal places.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.125</para>
        /// </summary>
        [NameInMap("TargetValue")]
        [Validation(Required=false)]
        public float? TargetValue { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyScalingRuleRequest : TeaModel {
        /// <summary>
        /// The target value specified in the scaling rule. This parameter is required when the ScalingRuleType parameter is set to SimpleScalingRule or StepScalingRule. The number of ECS instances that are scaled in a single scaling activity cannot exceed 1,000.
        /// 
        /// *   Valid values if you set the AdjustmentType parameter to QuantityChangeInCapacity: -1000 to 1000.
        /// *   Valid values if you set the AdjustmentType parameter to PercentChangeInCapacity: -100 to 10000.
        /// *   Valid values if you set the AdjustmentType parameter to TotalCapacity: 0 to 2000.
        /// </summary>
        [NameInMap("AdjustmentType")]
        [Validation(Required=false)]
        public string AdjustmentType { get; set; }

        /// <summary>
        /// The warmup period of an instance. This parameter is available only if you set the ScalingRuleType parameter to TargetTrackingScalingRule or PredictiveScalingRule. Auto Scaling adds ECS instances that are in the warmup state to a scaling group but does not report monitoring data to CloudMonitor during the warmup period.
        /// 
        /// > Auto Scaling calculates the number of ECS instances that need to be scaled. ECS instances in the warmup state are not counted towards the current capacity of the scaling group.
        /// 
        /// Valid values: 0 to 86400. Unit: seconds.
        /// </summary>
        [NameInMap("AdjustmentValue")]
        [Validation(Required=false)]
        public int? AdjustmentValue { get; set; }

        /// <summary>
        /// 监控项维度信息值，适用于目标追踪规则，当监控项需额外维度信息时设置，例如LoadBalancerRealServerAverageQps监控项需指定rulePool维度信息。
        /// </summary>
        [NameInMap("AlarmDimensions")]
        [Validation(Required=false)]
        public List<ModifyScalingRuleRequestAlarmDimensions> AlarmDimensions { get; set; }
        public class ModifyScalingRuleRequestAlarmDimensions : TeaModel {
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
        /// The minimum number of instances that must be scaled when the AdjustmentType parameter is set to PercentChangeInCapacity. This parameter takes effect only if you set the ScalingRuleType parameter to SimpleScalingRule or StepScalingRule.
        /// </summary>
        [NameInMap("Cooldown")]
        [Validation(Required=false)]
        public int? Cooldown { get; set; }

        /// <summary>
        /// The number of consecutive times that the event-triggered task created for scale-in activities must meet the threshold conditions before an alert is triggered. After a target tracking scaling rule is created, an event-triggered task is automatically created and then associated with the target tracking scaling rule.
        /// </summary>
        [NameInMap("DisableScaleIn")]
        [Validation(Required=false)]
        public bool? DisableScaleIn { get; set; }

        /// <summary>
        /// The predefined metric that you want to monitor. This parameter is required only if you set the ScalingRuleType parameter to TargetTrackingScalingRule or PredictiveScalingRule.
        /// 
        /// Valid values if you set the ScalingRuleType parameter to TargetTrackingScalingRule:
        /// 
        /// *   CpuUtilization: the average CPU utilization
        /// *   ClassicInternetRx: the average inbound Internet traffic over the classic network
        /// *   ClassicInternetTx: the average outbound Internet traffic over the classic network
        /// *   VpcInternetRx: the average inbound Internet traffic over the virtual private cloud (VPC)
        /// *   VpcInternetTx: the average outbound Internet traffic over the VPC
        /// *   IntranetRx: the average inbound traffic over the internal network
        /// *   IntranetTx: the average outbound traffic over the internal network
        /// 
        /// Valid values if you set the ScalingRuleType parameter to PredictiveScalingRule:
        /// 
        /// *   CpuUtilization: the average CPU utilization
        /// *   IntranetRx: the average inbound traffic over the internal network
        /// *   IntranetTx: the average outbound traffic over the internal network
        /// </summary>
        [NameInMap("EstimatedInstanceWarmup")]
        [Validation(Required=false)]
        public int? EstimatedInstanceWarmup { get; set; }

        /// <summary>
        /// Details of the step adjustments.
        /// </summary>
        [NameInMap("InitialMaxSize")]
        [Validation(Required=false)]
        public int? InitialMaxSize { get; set; }

        /// <summary>
        /// The target value. This parameter is available only if you set the ScalingRuleType parameter to TargetTrackingScalingRule or PredictiveScalingRule. The value must be greater than 0 and can have up to three decimal places.
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The adjustment method of the scaling rule. This is required when the ScalingRuleType parameter is set to SimpleScalingRule or StepScalingRule. Valid values:
        /// 
        /// *   QuantityChangeInCapacity: adds the specified number of ECS instances to or removes the specified number of ECS instances from the scaling group.
        /// *   PercentChangeInCapacity: adds the specified percentage of ECS instances to or removes the specified percentage of ECS instances from the scaling group.
        /// *   TotalCapacity: adjusts the number of ECS instances in the scaling group to the specified number.
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
        /// Specifies which one of the initial maximum capacity and the predicted value can be used as the maximum value for prediction tasks. Valid values:
        /// 
        /// *   MaxOverridePredictiveValue: uses the initial maximum capacity as the maximum value for prediction tasks if the predicted value is greater than the initial maximum capacity.
        /// *   PredictiveValueOverrideMax: uses the predicted value as the maximum value for prediction tasks when the predicted value is greater than the initial maximum capacity.
        /// *   PredictiveValueOverrideMaxWithBuffer: increases the predicted value by a percentage that is specified by the PredictiveValueBuffer parameter. If the predicted value that is increased by the percentage is greater than the initial maximum capacity, the increased value is used as the maximum value for prediction tasks.
        /// </summary>
        [NameInMap("PredictiveScalingMode")]
        [Validation(Required=false)]
        public string PredictiveScalingMode { get; set; }

        /// <summary>
        /// The maximum number of ECS instances in the scaling group. If you specify this parameter, you must also specify the PredictiveValueBehavior parameter.
        /// </summary>
        [NameInMap("PredictiveTaskBufferTime")]
        [Validation(Required=false)]
        public int? PredictiveTaskBufferTime { get; set; }

        /// <summary>
        /// The percentage of the increment to the predicted value when the PredictiveValueBehavior parameter is set to PredictiveValueOverrideMaxWithBuffer. If the predicted value increased by this percentage is greater than the initial maximum capacity, the increased value is used as the maximum value for prediction tasks. Valid values: 0 to 100.
        /// </summary>
        [NameInMap("PredictiveValueBehavior")]
        [Validation(Required=false)]
        public string PredictiveValueBehavior { get; set; }

        /// <summary>
        /// The amount of buffer time before the prediction task is executed. By default, all prediction tasks that are automatically created for a predictive scaling rule are executed on the hour. You can specify an amount of buffer time for resource preparation before the prediction tasks are executed. Valid values: 0 to 60.
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
        /// The number of consecutive times that the event-triggered task created for scale-out activities must meet the threshold conditions before an alert is triggered. After a target tracking scaling rule is created, an event-triggered task is automatically created and then associated with the target tracking scaling rule.
        /// </summary>
        [NameInMap("ScaleInEvaluationCount")]
        [Validation(Required=false)]
        public int? ScaleInEvaluationCount { get; set; }

        /// <summary>
        /// The mode of the predictive scaling rule. Valid values:
        /// 
        /// *   PredictAndScale: produces predictions and creates prediction tasks.
        /// *   PredictOnly: produces predictions but does not create prediction tasks.
        /// </summary>
        [NameInMap("ScaleOutEvaluationCount")]
        [Validation(Required=false)]
        public int? ScaleOutEvaluationCount { get; set; }

        /// <summary>
        /// The name of the scaling rule. The name must be 2 to 64 characters in length, and can contain letters, digits, underscores (\_), hyphens (-), and periods (.). The name must start with a letter or a digit. The name of a scaling rule must be unique in the scaling group to which the scaling rule belongs and within an Alibaba Cloud account.
        /// </summary>
        [NameInMap("ScalingRuleId")]
        [Validation(Required=false)]
        public string ScalingRuleId { get; set; }

        /// <summary>
        /// The name of the scaling rule. The name must be 2 to 64 characters in length and can contain letters, digits, underscores (\_), hyphens (-), and periods (.). It must start with a letter or a digit. The name of a scaling rule must be unique within an Alibaba Cloud account in a region.
        /// </summary>
        [NameInMap("ScalingRuleName")]
        [Validation(Required=false)]
        public string ScalingRuleName { get; set; }

        /// <summary>
        /// Details of the step adjustments.
        /// </summary>
        [NameInMap("StepAdjustments")]
        [Validation(Required=false)]
        public List<ModifyScalingRuleRequestStepAdjustments> StepAdjustments { get; set; }
        public class ModifyScalingRuleRequestStepAdjustments : TeaModel {
            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("MetricIntervalLowerBound")]
            [Validation(Required=false)]
            public float? MetricIntervalLowerBound { get; set; }

            /// <summary>
            /// The number of ECS instances that you want to scale in a step adjustment. This parameter is available only if you set the ScalingRuleType parameter to StepScalingRule.
            /// </summary>
            [NameInMap("MetricIntervalUpperBound")]
            [Validation(Required=false)]
            public float? MetricIntervalUpperBound { get; set; }

            /// <summary>
            /// The lower limit that is specified in a step adjustment. This parameter is available only if you set the ScalingRuleType parameter to StepScalingRule. Valid values: -9.999999E18 to 9.999999E18.
            /// </summary>
            [NameInMap("ScalingAdjustment")]
            [Validation(Required=false)]
            public int? ScalingAdjustment { get; set; }

        }

        /// <summary>
        /// Specifies whether to disable scale-in. This parameter is available only if you set the ScalingRuleType parameter to TargetTrackingScalingRule.
        /// </summary>
        [NameInMap("TargetValue")]
        [Validation(Required=false)]
        public float? TargetValue { get; set; }

    }

}

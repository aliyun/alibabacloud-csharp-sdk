// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CreateScalingRuleRequest : TeaModel {
        /// <summary>
        /// <para>The adjustment method of the scaling rule. This parameter is required for simple scaling rules and step scaling rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>QuantityChangeInCapacity: adds or removes a specified number of ECS instances.</description></item>
        /// <item><description>PercentChangeInCapacity: adds or removes a specified percentage of ECS instances.</description></item>
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
        /// <para>The adjustment value of the scaling rule. This parameter is required for simple scaling rules and step scaling rules. The number of ECS instances adjusted in a single operation cannot exceed 1,000. Valid values vary based on the adjustment method:</para>
        /// <list type="bullet">
        /// <item><description>QuantityChangeInCapacity: -1000 to 1000.</description></item>
        /// <item><description>PercentChangeInCapacity: -100 to 10000.</description></item>
        /// <item><description>TotalCapacity: 0 to 2000.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("AdjustmentValue")]
        [Validation(Required=false)]
        public int? AdjustmentValue { get; set; }

        /// <summary>
        /// <para>The dimension information of the metric. This parameter is applicable to target tracking scaling rules and is configured when the metric requires additional dimension information. For example, the LoadBalancerRealServerAverageQps metric requires the dimension key-value information of rulePool.</para>
        /// </summary>
        [NameInMap("AlarmDimensions")]
        [Validation(Required=false)]
        public List<CreateScalingRuleRequestAlarmDimensions> AlarmDimensions { get; set; }
        public class CreateScalingRuleRequestAlarmDimensions : TeaModel {
            /// <summary>
            /// <para>The dimension key associated with the metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rulePool</para>
            /// </summary>
            [NameInMap("DimensionKey")]
            [Validation(Required=false)]
            public string DimensionKey { get; set; }

            /// <summary>
            /// <para>The dimension value associated with the metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sgp-l1cbirz451yxuxxx</para>
            /// </summary>
            [NameInMap("DimensionValue")]
            [Validation(Required=false)]
            public string DimensionValue { get; set; }

        }

        /// <summary>
        /// <para>The definition of alert attributes.</para>
        /// </summary>
        [NameInMap("AlarmOptions")]
        [Validation(Required=false)]
        public CreateScalingRuleRequestAlarmOptions AlarmOptions { get; set; }
        public class CreateScalingRuleRequestAlarmOptions : TeaModel {
            /// <summary>
            /// <para>The period for collecting metric data in the target tracking scaling rule. Unit: seconds. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>15</description></item>
            /// <item><description>60</description></item>
            /// <item><description>120</description></item>
            /// <item><description>300</description></item>
            /// <item><description>900</description></item>
            /// </list>
            /// <remarks>
            /// <para>Default value: 60.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

        }

        /// <summary>
        /// <para>The cooldown time of the scaling rule. This parameter is applicable only to simple scaling rules. Valid values: 0 to 86400. Unit: seconds.</para>
        /// <para>Default value: none.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Cooldown")]
        [Validation(Required=false)]
        public int? Cooldown { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable scale-in. This parameter is applicable only to target tracking scaling rules.</para>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableScaleIn")]
        [Validation(Required=false)]
        public bool? DisableScaleIn { get; set; }

        /// <summary>
        /// <para>The warmup time of instances. This parameter is applicable to target tracking scaling rules and step scaling rules. ECS instances in the warmup state are added to the scaling group normally, but they do not report monitoring data to CloudMonitor during the warmup period.</para>
        /// <remarks>
        /// <para>When dynamically calculating the number of ECS instances to be scaled, instances in the warmup state are not counted in the current number of instances.</para>
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

        /// <summary>
        /// <para>The metric settings for Hybrid Cloud Monitoring. For more information about how to configure the settings, see <a href="https://help.aliyun.com/document_detail/2852162.html">Customize target tracking scaling rules by using formula operations</a>.</para>
        /// </summary>
        [NameInMap("HybridMetrics")]
        [Validation(Required=false)]
        public List<CreateScalingRuleRequestHybridMetrics> HybridMetrics { get; set; }
        public class CreateScalingRuleRequestHybridMetrics : TeaModel {
            /// <summary>
            /// <para>The dimensions of the metric. Used to specify the resources monitored by the metric.</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<CreateScalingRuleRequestHybridMetricsDimensions> Dimensions { get; set; }
            public class CreateScalingRuleRequestHybridMetricsDimensions : TeaModel {
                /// <summary>
                /// <para>The dimension key of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>queue</para>
                /// </summary>
                [NameInMap("DimensionKey")]
                [Validation(Required=false)]
                public string DimensionKey { get; set; }

                /// <summary>
                /// <para>The dimension value of the metric.</para>
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
            /// <para>The operation expression must comply with the Reverse Polish Notation (RPN) specification, and only the <c>+</c>, <c>-</c>, <c>*</c>, and <c>/</c> operators are supported.</para>
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
            /// <item><description>Average: the average value of all data points within the specified period.</description></item>
            /// <item><description>Minimum: the minimum value of all data points within the specified period.</description></item>
            /// <item><description>Maximum: the maximum value of all data points within the specified period.</description></item>
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
        /// <para>For more information about managing monitoring metrics repositories, see <a href="https://help.aliyun.com/document_detail/217606.html">Manage monitoring metrics repositories</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-test</para>
        /// </summary>
        [NameInMap("HybridMonitorNamespace")]
        [Validation(Required=false)]
        public string HybridMonitorNamespace { get; set; }

        /// <summary>
        /// <para>The maximum number of instances in the scaling group. This parameter is used in combination with <c>PredictiveValueBehavior</c>.</para>
        /// <para>Default value: the maximum number of instances in the scaling group (the value of MaxSize).</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("InitialMaxSize")]
        [Validation(Required=false)]
        public int? InitialMaxSize { get; set; }

        /// <summary>
        /// <para>The predefined metric. This parameter is required for target tracking scaling rules and predictive scaling rules.</para>
        /// <para>Valid values for target tracking scaling rules: </para>
        /// <list type="bullet">
        /// <item><description>CpuUtilizationAgent: (Agent) CPU utilization (recommended).</description></item>
        /// <item><description>MemoryUtilization: (Agent) memory usage (recommended).</description></item>
        /// <item><description>CpuUtilization: (ECS) average CPU utilization.</description></item>
        /// <item><description>IntranetTx: (ECS) average outbound traffic over the internal network.</description></item>
        /// <item><description>IntranetRx: (ECS) average inbound traffic over the internal network.</description></item>
        /// <item><description>VpcInternetTx: (ECS) average outbound traffic over the Internet.</description></item>
        /// <item><description>VpcInternetRx: (ECS) average inbound traffic over the Internet.</description></item>
        /// <item><description>LoadBalancerRealServerAverageQps: (ALB) average QPS per backend server in a server group.</description></item>
        /// </list>
        /// <para>Valid values for predictive scaling rules: </para>
        /// <list type="bullet">
        /// <item><description>CpuUtilization: (ECS) average CPU utilization.</description></item>
        /// <item><description>IntranetRx: (ECS) average inbound traffic over the internal network.</description></item>
        /// <item><description>IntranetTx: (ECS) average outbound traffic over the internal network.</description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/74854.html">System monitoring event-triggered tasks</a>.</para>
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
        /// <para>The minimum number of instances to be adjusted. This parameter takes effect only when the scaling rule type is SimpleScalingRule or StepScalingRule and AdjustmentType is set to PercentChangeInCapacity.</para>
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
        /// <item><description>PredictAndScale: generates prediction results and creates predictive tasks.</description></item>
        /// <item><description>PredictOnly: generates prediction results but does not create predictive tasks.</description></item>
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
        /// <para>The predictive tasks automatically created by predictive scaling rules are executed on the hour by default. You can set the pre-startup time to execute the predictive tasks in advance and prepare resources beforehand. Valid values: 0 to 60. Unit: minutes.</para>
        /// <para>Default value: 0.</para>
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
        /// <item><description>MaxOverridePredictiveValue: The initial maximum value overrides the predicted value. If the predicted value is greater than the initial maximum value, the maximum value of the predictive task uses the initial maximum value.</description></item>
        /// <item><description>PredictiveValueOverrideMax: The predicted value overrides the initial maximum value. If the predicted value is greater than the initial maximum value, the maximum value of the predictive task uses the predicted value.</description></item>
        /// <item><description>PredictiveValueOverrideMaxWithBuffer: A buffer ratio is added to the predicted value. The predicted value is increased by the ratio specified by PredictiveValueBuffer. If the increased value is greater than the initial maximum value, the increased value is used.</description></item>
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
        /// <para>This parameter takes effect only when <c>PredictiveValueBehavior</c> is set to <c>PredictiveValueOverrideMaxWithBuffer</c>. The predicted value is increased by this ratio. If the increased value is greater than the initial maximum value, the increased value is used. Valid values: 0 to 100.</para>
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
        /// <para>After a target tracking scaling rule is created, an event-triggered task is automatically created. This parameter specifies the number of consecutive times the threshold condition must be met before the corresponding scale-in event-triggered task triggers an alert.</para>
        /// <para>Default value: 15.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("ScaleInEvaluationCount")]
        [Validation(Required=false)]
        public int? ScaleInEvaluationCount { get; set; }

        /// <summary>
        /// <para>After a target tracking scaling rule is created, an event-triggered task is automatically created. This parameter specifies the number of consecutive times the threshold condition must be met before the corresponding scale-out event-triggered task triggers an alert.</para>
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
        /// <para>The name of the scaling rule. The name must be 2 to 64 characters in length and can contain letters, digits, underscores (_), hyphens (-), and periods (.). It must start with a letter, digit, or Chinese character.</para>
        /// <para>The name of a scaling rule must be unique within a scaling group in a region for an Alibaba Cloud account.</para>
        /// <para>If this parameter is not specified, the value of ScalingRuleId is used by default.</para>
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
        /// <item><description>SimpleScalingRule: simple scaling rule. Adjusts the number of ECS or ECI instances based on the adjustment method (AdjustmentType) and adjustment value (AdjustmentValue).</description></item>
        /// <item><description>TargetTrackingScalingRule: target tracking scaling rule. Dynamically calculates the number of ECS or ECI instances for scale-out or scale-in based on a predefined metric (MetricName) to keep the metric value close to the target value (TargetValue).</description></item>
        /// <item><description>StepScalingRule: step scaling rule. Provides a step-by-step scaling method based on thresholds and metric values.</description></item>
        /// <item><description>PredictiveScalingRule: predictive scaling rule. Analyzes historical monitoring data of the scaling group based on machine learning capabilities to predict future metric values, and supports the automatic creation of scheduled tasks to configure the boundary values of the scaling group.</description></item>
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
        /// <para>The collection of instance scaling information corresponding to step adjustments.</para>
        /// </summary>
        [NameInMap("StepAdjustments")]
        [Validation(Required=false)]
        public List<CreateScalingRuleRequestStepAdjustments> StepAdjustments { get; set; }
        public class CreateScalingRuleRequestStepAdjustments : TeaModel {
            /// <summary>
            /// <para>The lower boundary of the step adjustment. This parameter is applicable only to step scaling rules. Valid values: -9.999999E18 to 9.999999E18.</para>
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
            /// <para>The number of instances to be scaled for the step adjustment. This parameter is applicable only to step scaling rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScalingAdjustment")]
            [Validation(Required=false)]
            public int? ScalingAdjustment { get; set; }

        }

        /// <summary>
        /// <para>The target value. This parameter is required for target tracking scaling rules and predictive scaling rules. The value of TargetValue can be rounded to three decimal places and must be greater than 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.125</para>
        /// </summary>
        [NameInMap("TargetValue")]
        [Validation(Required=false)]
        public float? TargetValue { get; set; }

    }

}

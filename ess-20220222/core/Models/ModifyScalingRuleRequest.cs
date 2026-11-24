// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyScalingRuleRequest : TeaModel {
        /// <summary>
        /// <para>The adjustment method of the scaling rule. This parameter is required and applicable only to simple scaling rules and step scaling rules. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>QuantityChangeInCapacity: adds or removes a specified number of ECS instances. </description></item>
        /// <item><description>PercentChangeInCapacity: adds or removes a specified percentage of ECS instances. </description></item>
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
        /// <para>The adjustment value of the scaling rule. This parameter is required and applicable only to simple scaling rules and step scaling rules. The number of ECS instances adjusted in a single operation cannot exceed 1,000. Valid values vary based on the adjustment method:</para>
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
        /// <para>The dimension values of the monitoring metric. This parameter is applicable to target tracking scaling rules and is configured when the monitoring metric requires additional dimension information. For example, the LoadBalancerRealServerAverageQps metric requires the rulePool dimension.</para>
        /// </summary>
        [NameInMap("AlarmDimensions")]
        [Validation(Required=false)]
        public List<ModifyScalingRuleRequestAlarmDimensions> AlarmDimensions { get; set; }
        public class ModifyScalingRuleRequestAlarmDimensions : TeaModel {
            /// <summary>
            /// <para>The key of the dimension associated with the monitoring metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rulePool</para>
            /// </summary>
            [NameInMap("DimensionKey")]
            [Validation(Required=false)]
            public string DimensionKey { get; set; }

            /// <summary>
            /// <para>The value of the dimension associated with the monitoring metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sgp-l1cbirz451yxu2dxxx</para>
            /// </summary>
            [NameInMap("DimensionValue")]
            [Validation(Required=false)]
            public string DimensionValue { get; set; }

        }

        /// <summary>
        /// <para>The alert attributes.</para>
        /// </summary>
        [NameInMap("AlarmOptions")]
        [Validation(Required=false)]
        public ModifyScalingRuleRequestAlarmOptions AlarmOptions { get; set; }
        public class ModifyScalingRuleRequestAlarmOptions : TeaModel {
            /// <summary>
            /// <para>The period for collecting monitoring metric data in the target tracking scaling rule. Unit: seconds. Valid values:</para>
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
        /// <para>The cooldown time of the scaling rule. This parameter is applicable only to simple scaling rules.</para>
        /// <para>Valid values: 0 to 86400. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Cooldown")]
        [Validation(Required=false)]
        public int? Cooldown { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable scale-in. This parameter is applicable only to target tracking scaling rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisableScaleIn")]
        [Validation(Required=false)]
        public bool? DisableScaleIn { get; set; }

        /// <summary>
        /// <para>The warmup period of instances. This parameter is applicable to target tracking scaling rules and step scaling rules. ECS instances in the warmup state are added to the scaling group as usual, but they do not report monitoring data to CloudMonitor during the warmup period.</para>
        /// <remarks>
        /// <para>When the system dynamically calculates the number of ECS instances to scale out or scale in, instances in the warmup state are not counted as existing instances.</para>
        /// </remarks>
        /// <para>Valid values: 0 to 86400. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("EstimatedInstanceWarmup")]
        [Validation(Required=false)]
        public int? EstimatedInstanceWarmup { get; set; }

        /// <summary>
        /// <para>The Hybrid Cloud Monitoring monitoring metrics settings. For more information about how to configure the settings, see <a href="https://help.aliyun.com/document_detail/2852162.html">Use formula operations to customize target tracking scaling rules</a>.</para>
        /// </summary>
        [NameInMap("HybridMetrics")]
        [Validation(Required=false)]
        public List<ModifyScalingRuleRequestHybridMetrics> HybridMetrics { get; set; }
        public class ModifyScalingRuleRequestHybridMetrics : TeaModel {
            /// <summary>
            /// <para>The dimensions of the metric. This parameter is used to specify the resources monitored by the metric.</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<ModifyScalingRuleRequestHybridMetricsDimensions> Dimensions { get; set; }
            public class ModifyScalingRuleRequestHybridMetricsDimensions : TeaModel {
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
            /// <para>The metric operation expression for multiple Hybrid Cloud Monitoring metrics. The calculation result of the expression is used to trigger scaling activities.</para>
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
            /// <para>The name of the metric in the Hybrid Cloud Monitoring monitoring metrics repository.</para>
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
        /// <para>The ID of the Hybrid Cloud Monitoring monitoring metrics repository.</para>
        /// <para>For more information about how to manage monitoring metrics repositories, see <a href="https://help.aliyun.com/document_detail/217606.html">Manage monitoring metrics repositories</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-test</para>
        /// </summary>
        [NameInMap("HybridMonitorNamespace")]
        [Validation(Required=false)]
        public string HybridMonitorNamespace { get; set; }

        /// <summary>
        /// <para>The maximum number of instances in the scaling group. This parameter is used together with <c>PredictiveValueBehavior</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("InitialMaxSize")]
        [Validation(Required=false)]
        public int? InitialMaxSize { get; set; }

        /// <summary>
        /// <para>The predefined monitoring metric. This parameter is required and applicable to target tracking scaling rules and predictive scaling rules.</para>
        /// <para>Valid values for target tracking scaling rules:</para>
        /// <list type="bullet">
        /// <item><description>CpuUtilizationAgent: the CPU utilization collected by the CloudMonitor agent (recommended).</description></item>
        /// <item><description>MemoryUtilization: the memory usage collected by the CloudMonitor agent (recommended).</description></item>
        /// <item><description>CpuUtilization: the average CPU utilization of ECS instances.</description></item>
        /// <item><description>IntranetTx: the average outbound internal traffic of ECS instances.</description></item>
        /// <item><description>IntranetRx: the average inbound internal traffic of ECS instances.</description></item>
        /// <item><description>VpcInternetTx: the average outbound Internet traffic of ECS instances.</description></item>
        /// <item><description>VpcInternetRx: the average inbound Internet traffic of ECS instances.</description></item>
        /// <item><description>LoadBalancerRealServerAverageQps: the average queries per second (QPS) per backend server in an Application Load Balancer (ALB) server group.</description></item>
        /// </list>
        /// <para>Valid values for predictive scaling rules:</para>
        /// <list type="bullet">
        /// <item><description>CpuUtilization: the average CPU utilization of ECS instances.</description></item>
        /// <item><description>IntranetRx: the average inbound internal traffic of ECS instances.</description></item>
        /// <item><description>IntranetTx: the average outbound internal traffic of ECS instances.</description></item>
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
        /// <para>The type of the monitoring metric. Valid values:</para>
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
        /// <para>The minimum number of instances to adjust. This parameter takes effect only when the scaling rule type is SimpleScalingRule or StepScalingRule and <c>AdjustmentType</c> is set to <c>PercentChangeInCapacity</c>.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>PredictAndScale</para>
        /// </summary>
        [NameInMap("PredictiveScalingMode")]
        [Validation(Required=false)]
        public string PredictiveScalingMode { get; set; }

        /// <summary>
        /// <para>By default, predictive tasks automatically created by predictive scaling rules are executed on the hour. You can set a pre-start time to execute the predictive tasks in advance and prepare resources. Valid values: 0 to 60. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PredictiveTaskBufferTime")]
        [Validation(Required=false)]
        public int? PredictiveTaskBufferTime { get; set; }

        /// <summary>
        /// <para>The method to handle the maximum value for the predictive scaling rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MaxOverridePredictiveValue: the initial maximum value overrides the predicted value. If the predicted value is greater than the initial maximum value, the initial maximum value is used as the maximum value for the predictive task.</description></item>
        /// <item><description>PredictiveValueOverrideMax: the predicted value overrides the initial maximum value. If the predicted value is greater than the initial maximum value, the predicted value is used as the maximum value for the predictive task.</description></item>
        /// <item><description>PredictiveValueOverrideMaxWithBuffer: a buffer ratio is added to the predicted value. The predicted value is increased by the ratio specified by PredictiveValueBuffer. If the increased value is greater than the initial maximum value, the increased value is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MaxOverridePredictiveValue</para>
        /// </summary>
        [NameInMap("PredictiveValueBehavior")]
        [Validation(Required=false)]
        public string PredictiveValueBehavior { get; set; }

        /// <summary>
        /// <para>The buffer ratio added to the predicted value. This parameter takes effect only when <c>PredictiveValueBehavior</c> is set to <c>PredictiveValueOverrideMaxWithBuffer</c>. The predicted value is increased by this ratio. If the increased value is greater than the initial maximum value, the increased value is used. Valid values: 0 to 100.</para>
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
        /// <para>After a target tracking scaling rule is created, an event-triggered task is automatically created. This parameter specifies the number of consecutive times that the threshold condition must be met before the scale-in event-triggered task triggers an alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("ScaleInEvaluationCount")]
        [Validation(Required=false)]
        public int? ScaleInEvaluationCount { get; set; }

        /// <summary>
        /// <para>After a target tracking scaling rule is created, an event-triggered task is automatically created. This parameter specifies the number of consecutive times that the threshold condition must be met before the scale-out event-triggered task triggers an alert.</para>
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
        /// <para>The name of the scaling rule. The name must be 2 to 64 characters in length and can contain letters, digits, underscores (_), hyphens (-), and periods (.). It must start with a letter or digit. The scaling rule name must be unique within a scaling group in a region for an Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scalingrule****</para>
        /// </summary>
        [NameInMap("ScalingRuleName")]
        [Validation(Required=false)]
        public string ScalingRuleName { get; set; }

        /// <summary>
        /// <para>The set of instance scaling configurations for step adjustments.</para>
        /// </summary>
        [NameInMap("StepAdjustments")]
        [Validation(Required=false)]
        public List<ModifyScalingRuleRequestStepAdjustments> StepAdjustments { get; set; }
        public class ModifyScalingRuleRequestStepAdjustments : TeaModel {
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
            /// <para>The upper boundary of the step adjustment. This parameter is applicable only to step scaling rules. Valid values: -9.999999E18 to 9.999999E18.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.0</para>
            /// </summary>
            [NameInMap("MetricIntervalUpperBound")]
            [Validation(Required=false)]
            public float? MetricIntervalUpperBound { get; set; }

            /// <summary>
            /// <para>The number of instances to adjust for the step adjustment. This parameter is applicable only to step scaling rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScalingAdjustment")]
            [Validation(Required=false)]
            public int? ScalingAdjustment { get; set; }

        }

        /// <summary>
        /// <para>The target value. This parameter is applicable to target tracking scaling rules and predictive scaling rules. The value can have up to three decimal places and must be greater than 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.125</para>
        /// </summary>
        [NameInMap("TargetValue")]
        [Validation(Required=false)]
        public float? TargetValue { get; set; }

    }

}

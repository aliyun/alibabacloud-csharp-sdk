// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DisableApplicationScalingRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the auto scaling policy.</para>
        /// </summary>
        [NameInMap("AppScalingRule")]
        [Validation(Required=false)]
        public DisableApplicationScalingRuleResponseBodyAppScalingRule AppScalingRule { get; set; }
        public class DisableApplicationScalingRuleResponseBodyAppScalingRule : TeaModel {
            /// <summary>
            /// <para>The ID of the application to which the auto scaling policy belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>78194c76-3dca-418e-a263-cccd1ab4****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The time when the auto scaling policy was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23212323123</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the auto scaling policy was last disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23212323123</para>
            /// </summary>
            [NameInMap("LastDisableTime")]
            [Validation(Required=false)]
            public long? LastDisableTime { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaxReplicas")]
            [Validation(Required=false)]
            public int? MaxReplicas { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// </summary>
            [NameInMap("Metric")]
            [Validation(Required=false)]
            public DisableApplicationScalingRuleResponseBodyAppScalingRuleMetric Metric { get; set; }
            public class DisableApplicationScalingRuleResponseBodyAppScalingRuleMetric : TeaModel {
                /// <summary>
                /// <para>This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("MaxReplicas")]
                [Validation(Required=false)]
                public int? MaxReplicas { get; set; }

                /// <summary>
                /// <para>This parameter is deprecated.</para>
                /// </summary>
                [NameInMap("Metrics")]
                [Validation(Required=false)]
                public List<DisableApplicationScalingRuleResponseBodyAppScalingRuleMetricMetrics> Metrics { get; set; }
                public class DisableApplicationScalingRuleResponseBodyAppScalingRuleMetricMetrics : TeaModel {
                    /// <summary>
                    /// <para>This parameter is deprecated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MetricTargetAverageUtilization")]
                    [Validation(Required=false)]
                    public int? MetricTargetAverageUtilization { get; set; }

                    /// <summary>
                    /// <para>This parameter is deprecated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MetricType")]
                    [Validation(Required=false)]
                    public string MetricType { get; set; }

                }

                /// <summary>
                /// <para>This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MinReplicas")]
                [Validation(Required=false)]
                public int? MinReplicas { get; set; }

            }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinReplicas")]
            [Validation(Required=false)]
            public int? MinReplicas { get; set; }

            /// <summary>
            /// <para>Indicates whether the auto scaling policy is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The auto scaling policy is enabled.</description></item>
            /// <item><description><b>false</b>: The auto scaling policy is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ScaleRuleEnabled")]
            [Validation(Required=false)]
            public bool? ScaleRuleEnabled { get; set; }

            /// <summary>
            /// <para>The name of the auto scaling policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cron-trigger</para>
            /// </summary>
            [NameInMap("ScaleRuleName")]
            [Validation(Required=false)]
            public string ScaleRuleName { get; set; }

            /// <summary>
            /// <para>The type of the auto scaling policy. The value is fixed to trigger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>trigger</para>
            /// </summary>
            [NameInMap("ScaleRuleType")]
            [Validation(Required=false)]
            public string ScaleRuleType { get; set; }

            /// <summary>
            /// <para>The configurations of the trigger.</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public DisableApplicationScalingRuleResponseBodyAppScalingRuleTrigger Trigger { get; set; }
            public class DisableApplicationScalingRuleResponseBodyAppScalingRuleTrigger : TeaModel {
                /// <summary>
                /// <para>The maximum number of replicas. The upper limit is 1000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("MaxReplicas")]
                [Validation(Required=false)]
                public int? MaxReplicas { get; set; }

                /// <summary>
                /// <para>The minimum number of replicas. The lower limit is 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MinReplicas")]
                [Validation(Required=false)]
                public int? MinReplicas { get; set; }

                /// <summary>
                /// <para>The information about the trigger.</para>
                /// </summary>
                [NameInMap("Triggers")]
                [Validation(Required=false)]
                public List<DisableApplicationScalingRuleResponseBodyAppScalingRuleTriggerTriggers> Triggers { get; set; }
                public class DisableApplicationScalingRuleResponseBodyAppScalingRuleTriggerTriggers : TeaModel {
                    /// <summary>
                    /// <para>The metadata of the trigger.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;dryRun&quot;:true}</para>
                    /// </summary>
                    [NameInMap("MetaData")]
                    [Validation(Required=false)]
                    public string MetaData { get; set; }

                    /// <summary>
                    /// <para>The name of the trigger.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cron-trigger</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The type of the trigger. Valid values: cron and app_metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cron</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The time when the auto scaling policy was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23212323123</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5d6fa0bc-cc3**********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

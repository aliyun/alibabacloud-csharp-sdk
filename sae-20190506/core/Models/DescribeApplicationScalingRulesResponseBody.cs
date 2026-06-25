// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationScalingRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request was redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: The request was invalid.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server error occurred.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApplicationScalingRulesResponseBodyData Data { get; set; }
        public class DescribeApplicationScalingRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of auto scaling policies for the application.</para>
            /// </summary>
            [NameInMap("ApplicationScalingRules")]
            [Validation(Required=false)]
            public List<DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRules> ApplicationScalingRules { get; set; }
            public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRules : TeaModel {
                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The timestamp of the policy\&quot;s creation, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1616642248938</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The timestamp of when the policy was last disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1641882854484</para>
                /// </summary>
                [NameInMap("LastDisableTime")]
                [Validation(Required=false)]
                public long? LastDisableTime { get; set; }

                /// <summary>
                /// <para>The metric-based scaling policy.</para>
                /// </summary>
                [NameInMap("Metric")]
                [Validation(Required=false)]
                public DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetric Metric { get; set; }
                public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetric : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("MaxReplicas")]
                    [Validation(Required=false)]
                    public int? MaxReplicas { get; set; }

                    /// <summary>
                    /// <para>The source of the metrics.</para>
                    /// </summary>
                    [NameInMap("MetricSource")]
                    [Validation(Required=false)]
                    public string MetricSource { get; set; }

                    /// <summary>
                    /// <para>The metric-based conditions that trigger scaling.</para>
                    /// </summary>
                    [NameInMap("Metrics")]
                    [Validation(Required=false)]
                    public List<DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricMetrics> Metrics { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricMetrics : TeaModel {
                        /// <summary>
                        /// <para>The target value for the metric. The unit varies based on the value of <c>MetricType</c>.</para>
                        /// <list type="bullet">
                        /// <item><description><para>Target CPU usage, in percent.</para>
                        /// </description></item>
                        /// <item><description><para>Target memory usage, in percent.</para>
                        /// </description></item>
                        /// <item><description><para>Target QPS, in queries per second.</para>
                        /// </description></item>
                        /// <item><description><para>Target response time, in milliseconds.</para>
                        /// </description></item>
                        /// <item><description><para>Target number of active TCP connections.</para>
                        /// </description></item>
                        /// <item><description><para>Target QPS of a public-facing SLB instance, in queries per second.</para>
                        /// </description></item>
                        /// <item><description><para>Target response time of a public-facing SLB instance, in milliseconds.</para>
                        /// </description></item>
                        /// <item><description><para>Target QPS of a private SLB instance, in queries per second.</para>
                        /// </description></item>
                        /// <item><description><para>Target response time of a private SLB instance, in milliseconds.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("MetricTargetAverageUtilization")]
                        [Validation(Required=false)]
                        public int? MetricTargetAverageUtilization { get; set; }

                        /// <summary>
                        /// <para>The metric used to trigger the auto scaling policy. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>CPU</b>: CPU usage.</para>
                        /// </description></item>
                        /// <item><description><para><b>MEMORY</b>: memory usage.</para>
                        /// </description></item>
                        /// <item><description><para><b>QPS</b>: Average queries per second (QPS) per instance over a 1-minute period. This metric applies to Java applications only.</para>
                        /// </description></item>
                        /// <item><description><para><b>RT</b>: Average response time of all service interfaces in a Java application over a 1-minute period.</para>
                        /// </description></item>
                        /// <item><description><para><b>tcpActiveConn</b>: Average number of active TCP connections per instance over a 30-second period.</para>
                        /// </description></item>
                        /// <item><description><para><b>SLB_QPS</b>: Average QPS per instance for a public-facing SLB instance over a 15-second period.</para>
                        /// </description></item>
                        /// <item><description><para><b>SLB_RT</b>: Average response time of a public-facing SLB instance over a 15-second period.</para>
                        /// </description></item>
                        /// <item><description><para><b>INTRANET_SLB_QPS</b>: Average QPS per instance for a private SLB instance over a 15-second period.</para>
                        /// </description></item>
                        /// <item><description><para><b>INTRANET_SLB_RT</b>: Average response time of a private SLB instance over a 15-second period.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CPU</para>
                        /// </summary>
                        [NameInMap("MetricType")]
                        [Validation(Required=false)]
                        public string MetricType { get; set; }

                        /// <summary>
                        /// <para>The ID of the SLB instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>lb-xxx</para>
                        /// </summary>
                        [NameInMap("SlbId")]
                        [Validation(Required=false)]
                        public string SlbId { get; set; }

                        /// <summary>
                        /// <para>The Logstore in Log Service that stores SLB access logs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("SlbLogstore")]
                        [Validation(Required=false)]
                        public string SlbLogstore { get; set; }

                        /// <summary>
                        /// <para>The project in Log Service that stores SLB access logs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("SlbProject")]
                        [Validation(Required=false)]
                        public string SlbProject { get; set; }

                        /// <summary>
                        /// <para>The monitored port of the SLB instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>80</para>
                        /// </summary>
                        [NameInMap("Vport")]
                        [Validation(Required=false)]
                        public string Vport { get; set; }

                    }

                    /// <summary>
                    /// <para>The status of the metric-based scaling policy.</para>
                    /// </summary>
                    [NameInMap("MetricsStatus")]
                    [Validation(Required=false)]
                    public DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricMetricsStatus MetricsStatus { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricMetricsStatus : TeaModel {
                        /// <summary>
                        /// <para>A list of the current metrics for scaling.</para>
                        /// </summary>
                        [NameInMap("CurrentMetrics")]
                        [Validation(Required=false)]
                        public List<DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricMetricsStatusCurrentMetrics> CurrentMetrics { get; set; }
                        public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricMetricsStatusCurrentMetrics : TeaModel {
                            /// <summary>
                            /// <para>The current value.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("CurrentValue")]
                            [Validation(Required=false)]
                            public long? CurrentValue { get; set; }

                            /// <summary>
                            /// <para>The name of the trigger condition.</para>
                            /// <list type="bullet">
                            /// <item><description><para><b>cpu</b>: CPU usage.</para>
                            /// </description></item>
                            /// <item><description><para><b>memory</b>: memory usage.</para>
                            /// </description></item>
                            /// <item><description><para><b>arms_incall_qps_v2</b>: QPS of a Java application.</para>
                            /// </description></item>
                            /// <item><description><para><b>arms_incall_rt</b>: Response time of a Java application.</para>
                            /// </description></item>
                            /// <item><description><para><b>tcpActiveConn</b>: The number of active TCP connections.</para>
                            /// </description></item>
                            /// <item><description><para><b>slb_incall_qps</b>: QPS of a public-facing SLB instance.</para>
                            /// </description></item>
                            /// <item><description><para><b>slb_incall_rt</b>: Response time of a public-facing SLB instance.</para>
                            /// </description></item>
                            /// <item><description><para><b>intranet_slb_incall_qps</b>: QPS of a private SLB instance.</para>
                            /// </description></item>
                            /// <item><description><para><b>intranet_slb_incall_rt</b>: Response time of a private SLB instance.</para>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>cpu</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>The data type. This parameter is associated with the specified metric.</para>
                            /// <list type="bullet">
                            /// <item><description><para><b>Resource</b>: The metric value for <b>cpu</b> or <b>memory</b>.</para>
                            /// </description></item>
                            /// <item><description><para><b>Pods</b>: The metric value for <b>tcpActiveConn</b>.</para>
                            /// </description></item>
                            /// <item><description><para><b>External</b>: The metric value for <b>arms</b> or <b>slb</b>.</para>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Resource</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        /// <summary>
                        /// <para>The current number of instances.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("CurrentReplicas")]
                        [Validation(Required=false)]
                        public long? CurrentReplicas { get; set; }

                        /// <summary>
                        /// <para>The target number of instances.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("DesiredReplicas")]
                        [Validation(Required=false)]
                        public long? DesiredReplicas { get; set; }

                        /// <summary>
                        /// <para>The time of the last scaling activity.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-01-11T08:14:32Z</para>
                        /// </summary>
                        [NameInMap("LastScaleTime")]
                        [Validation(Required=false)]
                        public string LastScaleTime { get; set; }

                        /// <summary>
                        /// <para>The maximum number of instances.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("MaxReplicas")]
                        [Validation(Required=false)]
                        public long? MaxReplicas { get; set; }

                        /// <summary>
                        /// <para>The minimum number of instances.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("MinReplicas")]
                        [Validation(Required=false)]
                        public long? MinReplicas { get; set; }

                        /// <summary>
                        /// <para>A list of metrics for the next scaling activity.</para>
                        /// </summary>
                        [NameInMap("NextScaleMetrics")]
                        [Validation(Required=false)]
                        public List<DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricMetricsStatusNextScaleMetrics> NextScaleMetrics { get; set; }
                        public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricMetricsStatusNextScaleMetrics : TeaModel {
                            /// <summary>
                            /// <para>The name of the trigger condition.</para>
                            /// <list type="bullet">
                            /// <item><description><para><b>cpu</b>: CPU usage.</para>
                            /// </description></item>
                            /// <item><description><para><b>memory</b>: memory usage.</para>
                            /// </description></item>
                            /// <item><description><para><b>arms_incall_qps_v2</b>: QPS of a Java application.</para>
                            /// </description></item>
                            /// <item><description><para><b>arms_incall_rt</b>: Response time of a Java application.</para>
                            /// </description></item>
                            /// <item><description><para><b>tcpActiveConn</b>: The number of active TCP connections.</para>
                            /// </description></item>
                            /// <item><description><para><b>slb_incall_qps</b>: QPS of a public-facing SLB instance.</para>
                            /// </description></item>
                            /// <item><description><para><b>slb_incall_rt</b>: Response time of a public-facing SLB instance.</para>
                            /// </description></item>
                            /// <item><description><para><b>intranet_slb_incall_qps</b>: QPS of a private SLB instance.</para>
                            /// </description></item>
                            /// <item><description><para><b>intranet_slb_incall_rt</b>: Response time of a private SLB instance.</para>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>cpu</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>The metric value that triggers the next scale-in event. The value is a percentage.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("NextScaleInAverageUtilization")]
                            [Validation(Required=false)]
                            public int? NextScaleInAverageUtilization { get; set; }

                            /// <summary>
                            /// <para>The metric value that triggers the next scale-out event. The value is a percentage.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>21</para>
                            /// </summary>
                            [NameInMap("NextScaleOutAverageUtilization")]
                            [Validation(Required=false)]
                            public int? NextScaleOutAverageUtilization { get; set; }

                        }

                        /// <summary>
                        /// <para>The next period for metric-based scaling.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("NextScaleTimePeriod")]
                        [Validation(Required=false)]
                        public int? NextScaleTimePeriod { get; set; }

                    }

                    /// <summary>
                    /// <para>The minimum number of instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MinReplicas")]
                    [Validation(Required=false)]
                    public int? MinReplicas { get; set; }

                    /// <summary>
                    /// <para>The Prometheus metrics.</para>
                    /// </summary>
                    [NameInMap("PrometheusMetrics")]
                    [Validation(Required=false)]
                    public List<DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricPrometheusMetrics> PrometheusMetrics { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricPrometheusMetrics : TeaModel {
                        /// <summary>
                        /// <para>The Prometheus query.</para>
                        /// </summary>
                        [NameInMap("PrometheusQuery")]
                        [Validation(Required=false)]
                        public string PrometheusQuery { get; set; }

                        /// <summary>
                        /// <para>The target value for the Prometheus query that triggers a scaling event.</para>
                        /// </summary>
                        [NameInMap("TargetMetricValue")]
                        [Validation(Required=false)]
                        public string TargetMetricValue { get; set; }

                    }

                    /// <summary>
                    /// <para>The Prometheus token.</para>
                    /// </summary>
                    [NameInMap("PrometheusToken")]
                    [Validation(Required=false)]
                    public string PrometheusToken { get; set; }

                    /// <summary>
                    /// <para>The endpoint of the Prometheus service.</para>
                    /// </summary>
                    [NameInMap("PrometheusUrl")]
                    [Validation(Required=false)]
                    public string PrometheusUrl { get; set; }

                    /// <summary>
                    /// <para>Configuration for scale-in events.</para>
                    /// </summary>
                    [NameInMap("ScaleDownRules")]
                    [Validation(Required=false)]
                    public DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricScaleDownRules ScaleDownRules { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricScaleDownRules : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether to disable scale-in. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>true</b>: Disables scale-in.</para>
                        /// </description></item>
                        /// <item><description><para><b>false</b>: Enables scale-in.</para>
                        /// </description></item>
                        /// </list>
                        /// <remarks>
                        /// <para>Setting this to <c>true</c> prevents the application from scaling in, which can be useful to avoid service disruptions from unexpected capacity reduction during peak hours. Default: <c>false</c>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Disabled")]
                        [Validation(Required=false)]
                        public bool? Disabled { get; set; }

                        /// <summary>
                        /// <para>The cooldown time for scale-in events, in seconds. During this period, no further scaling events are triggered. The value must be an integer from 0 to 3,600. The default value is 0.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>300</para>
                        /// </summary>
                        [NameInMap("StabilizationWindowSeconds")]
                        [Validation(Required=false)]
                        public long? StabilizationWindowSeconds { get; set; }

                        /// <summary>
                        /// <para>The number of instances to remove in a single scale-in event.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Step")]
                        [Validation(Required=false)]
                        public long? Step { get; set; }

                    }

                    /// <summary>
                    /// <para>Configuration for scale-out events.</para>
                    /// </summary>
                    [NameInMap("ScaleUpRules")]
                    [Validation(Required=false)]
                    public DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricScaleUpRules ScaleUpRules { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricScaleUpRules : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether to disable scale-out. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>true</b>: Disables scale-out.</para>
                        /// </description></item>
                        /// <item><description><para><b>false</b>: Enables scale-out.</para>
                        /// </description></item>
                        /// </list>
                        /// <remarks>
                        /// <para>If this parameter is set to <c>true</c>, application instances are never scaled out. This can be useful to freeze the application capacity during specific events. By default, this parameter is set to <c>false</c>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Disabled")]
                        [Validation(Required=false)]
                        public bool? Disabled { get; set; }

                        /// <summary>
                        /// <para>The cooldown time for scale-out events, in seconds. During this period, no further scaling events are triggered. The value must be an integer from 0 to 3,600. The default value is 0.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>300</para>
                        /// </summary>
                        [NameInMap("StabilizationWindowSeconds")]
                        [Validation(Required=false)]
                        public long? StabilizationWindowSeconds { get; set; }

                        /// <summary>
                        /// <para>The number of instances to add in a single scale-out event.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Step")]
                        [Validation(Required=false)]
                        public long? Step { get; set; }

                    }

                }

                /// <summary>
                /// <para>The minimum number of available instances, specified as a percentage. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>-1</b>: Indicates that this parameter is not used.</para>
                /// </description></item>
                /// <item><description><para><b>0 to 100</b>: a percentage that is rounded up to the nearest integer. For example, if you set this parameter to 50% and you have five instances, the minimum number of available instances is 3.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>If you specify both <b>MinReadyInstances</b> and <b>MinReadyInstanceRatio</b>, the value of <b>MinReadyInstanceRatio</b> takes precedence, unless it is set to <b>-1</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("MinReadyInstanceRatio")]
                [Validation(Required=false)]
                public int? MinReadyInstanceRatio { get; set; }

                /// <summary>
                /// <para>The minimum number of available instances. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>If you set this parameter to <b>0</b>, the application may be interrupted during an upgrade.</para>
                /// </description></item>
                /// <item><description><para>If you set this parameter to <b>-1</b>, a recommended value is used, which is 25% of the current number of instances, rounded up to the nearest integer. For example, if an application has five instances, the minimum number of available instances is 2 (5 \* 25% = 1.25, rounded up).</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>To ensure business continuity during a rolling deployment, we recommend that you set this parameter to a value greater than or equal to 1.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MinReadyInstances")]
                [Validation(Required=false)]
                public int? MinReadyInstances { get; set; }

                /// <summary>
                /// <para>Indicates whether the auto scaling policy is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: The policy is enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: The policy is disabled.</para>
                /// </description></item>
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
                /// <para>test</para>
                /// </summary>
                [NameInMap("ScaleRuleName")]
                [Validation(Required=false)]
                public string ScaleRuleName { get; set; }

                /// <summary>
                /// <para>The type of the auto scaling policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>timing</b>: A scheduled scaling policy.</para>
                /// </description></item>
                /// <item><description><para><b>metric</b>: A metric-based scaling policy.</para>
                /// </description></item>
                /// <item><description><para><b>mix</b>: A hybrid scaling policy.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>timing</para>
                /// </summary>
                [NameInMap("ScaleRuleType")]
                [Validation(Required=false)]
                public string ScaleRuleType { get; set; }

                /// <summary>
                /// <para>The scheduled scaling policy.</para>
                /// </summary>
                [NameInMap("Timer")]
                [Validation(Required=false)]
                public DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesTimer Timer { get; set; }
                public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesTimer : TeaModel {
                    /// <summary>
                    /// <para>The start date of the short-term scheduled scaling policy. The following rules apply:</para>
                    /// <list type="bullet">
                    /// <item><description><para>If <b>BeginDate</b> and <b>EndDate</b> are not specified, the policy is long-term by default.</para>
                    /// </description></item>
                    /// <item><description><para>If you specify a <c>BeginDate</c> and an <c>EndDate</c>, the policy is short-term and applies only within that date range.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2021-03-25</para>
                    /// </summary>
                    [NameInMap("BeginDate")]
                    [Validation(Required=false)]
                    public string BeginDate { get; set; }

                    /// <summary>
                    /// <para>The end date of the short-term scheduled scaling policy. The following rules apply:</para>
                    /// <list type="bullet">
                    /// <item><description><para>If <b>BeginDate</b> and <b>EndDate</b> are not specified, the policy is long-term by default.</para>
                    /// </description></item>
                    /// <item><description><para>If you specify a <c>BeginDate</c> and an <c>EndDate</c>, the policy is short-term and applies only within that date range.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2021-04-25</para>
                    /// </summary>
                    [NameInMap("EndDate")]
                    [Validation(Required=false)]
                    public string EndDate { get; set; }

                    /// <summary>
                    /// <para>The days on which the scheduled scaling policy runs. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><em><em>\</em> \</em> \***: The policy is executed at a specified time every day.</para>
                    /// </description></item>
                    /// <item><description><para><em><em>\</em> \</em> Fri,Mon**: Executes the policy on specified days of the week. The time zone is GMT+8. Valid days are listed below:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>Sun</b>: Sunday</para>
                    /// </description></item>
                    /// <item><description><para><b>Mon</b>: Monday</para>
                    /// </description></item>
                    /// <item><description><para><b>Tue</b>: Tuesday</para>
                    /// </description></item>
                    /// <item><description><para><b>Wed</b>: Wednesday</para>
                    /// </description></item>
                    /// <item><description><para><b>Thu</b>: Thursday</para>
                    /// </description></item>
                    /// <item><description><para><b>Fri</b>: Friday</para>
                    /// </description></item>
                    /// <item><description><para><b>Sat</b>: Saturday</para>
                    /// </description></item>
                    /// </list>
                    /// </description></item>
                    /// <item><description><para><em><em>1,2,3,28,31 \</em> \</em>**: Executes the policy on specified days of the month (1-31). If a specified day does not exist in a given month (e.g., the 31st), the policy does not run on that day.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("Period")]
                    [Validation(Required=false)]
                    public string Period { get; set; }

                    /// <summary>
                    /// <para>The daily trigger schedule for the policy.</para>
                    /// </summary>
                    [NameInMap("Schedules")]
                    [Validation(Required=false)]
                    public List<DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesTimerSchedules> Schedules { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesTimerSchedules : TeaModel {
                        /// <summary>
                        /// <para>The trigger time in <c>HH:mm</c> format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>08:00</para>
                        /// </summary>
                        [NameInMap("AtTime")]
                        [Validation(Required=false)]
                        public string AtTime { get; set; }

                        /// <summary>
                        /// <para>The maximum number of instances.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>50</para>
                        /// </summary>
                        [NameInMap("MaxReplicas")]
                        [Validation(Required=false)]
                        public long? MaxReplicas { get; set; }

                        /// <summary>
                        /// <para>The minimum number of instances.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("MinReplicas")]
                        [Validation(Required=false)]
                        public long? MinReplicas { get; set; }

                        /// <summary>
                        /// <para>The target number of instances.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("TargetReplicas")]
                        [Validation(Required=false)]
                        public int? TargetReplicas { get; set; }

                    }

                    /// <summary>
                    /// <para>The time zone.</para>
                    /// </summary>
                    [NameInMap("TimeZone")]
                    [Validation(Required=false)]
                    public string TimeZone { get; set; }

                }

                /// <summary>
                /// <para>The timestamp of the last policy update, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1616642248938</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of auto scaling policies for the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The error code. This parameter is returned only when the request fails.</para>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// <item><description><para>For more information, see the <b>Error codes</b> section of this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The response message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Returns <b>success</b> if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>Returns an error message if the request fails.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The call was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

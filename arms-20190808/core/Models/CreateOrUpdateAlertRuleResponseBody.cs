// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateAlertRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The alert rule object.</para>
        /// </summary>
        [NameInMap("AlertRule")]
        [Validation(Required=false)]
        public CreateOrUpdateAlertRuleResponseBodyAlertRule AlertRule { get; set; }
        public class CreateOrUpdateAlertRuleResponseBodyAlertRule : TeaModel {
            /// <summary>
            /// <para>The check type of the Prometheus alert rule.</para>
            /// <list type="bullet">
            /// <item><description><para><c>STATIC</c>: The alert is triggered based on a static threshold.</para>
            /// </description></item>
            /// <item><description><para><c>CUSTOM</c>: The alert is triggered based on a custom PromQL expression.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STATIC</para>
            /// </summary>
            [NameInMap("AlertCheckType")]
            [Validation(Required=false)]
            public string AlertCheckType { get; set; }

            /// <summary>
            /// <para>The alert group for the Prometheus alert rule.</para>
            /// <list type="bullet">
            /// <item><description><para><c>-1</c>: Custom PromQL</para>
            /// </description></item>
            /// <item><description><para><c>1</c>: Kubernetes Workloads</para>
            /// </description></item>
            /// <item><description><para><c>15</c>: Kubernetes Nodes</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("AlertGroup")]
            [Validation(Required=false)]
            public long? AlertGroup { get; set; }

            /// <summary>
            /// <para>The ID of the alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5510445</para>
            /// </summary>
            [NameInMap("AlertId")]
            [Validation(Required=false)]
            public long? AlertId { get; set; }

            /// <summary>
            /// <para>The name of the alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arms-test</para>
            /// </summary>
            [NameInMap("AlertName")]
            [Validation(Required=false)]
            public string AlertName { get; set; }

            /// <summary>
            /// <para>The content of the alert rule. This applies to application monitoring and browser monitoring.</para>
            /// </summary>
            [NameInMap("AlertRuleContent")]
            [Validation(Required=false)]
            public CreateOrUpdateAlertRuleResponseBodyAlertRuleAlertRuleContent AlertRuleContent { get; set; }
            public class CreateOrUpdateAlertRuleResponseBodyAlertRuleAlertRuleContent : TeaModel {
                /// <summary>
                /// <para>The alert conditions. This applies to application monitoring and browser monitoring alert rules.</para>
                /// </summary>
                [NameInMap("AlertRuleItems")]
                [Validation(Required=false)]
                public List<CreateOrUpdateAlertRuleResponseBodyAlertRuleAlertRuleContentAlertRuleItems> AlertRuleItems { get; set; }
                public class CreateOrUpdateAlertRuleResponseBodyAlertRuleAlertRuleContentAlertRuleItems : TeaModel {
                    /// <summary>
                    /// <para>The aggregation method for the alert condition.</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>AVG</c>: average</para>
                    /// </description></item>
                    /// <item><description><para><c>SUM</c>: sum</para>
                    /// </description></item>
                    /// <item><description><para><c>MAX</c>: maximum</para>
                    /// </description></item>
                    /// <item><description><para><c>MIN</c>: minimum</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AVG</para>
                    /// </summary>
                    [NameInMap("Aggregate")]
                    [Validation(Required=false)]
                    public string Aggregate { get; set; }

                    /// <summary>
                    /// <para>The metric that is evaluated by the alert condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>JVM非堆总使用内存量</para>
                    /// </summary>
                    [NameInMap("MetricKey")]
                    [Validation(Required=false)]
                    public string MetricKey { get; set; }

                    /// <summary>
                    /// <para>The duration of the time window, in minutes, for evaluating the alert condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public float? N { get; set; }

                    /// <summary>
                    /// <para>The operator used to compare the aggregated metric value with the threshold.</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>CURRENT_GTE</c>: greater than or equal to</para>
                    /// </description></item>
                    /// <item><description><para><c>CURRENT_LTE</c>: less than or equal to</para>
                    /// </description></item>
                    /// <item><description><para><c>PREVIOUS_UP</c>: period-over-period increase percentage</para>
                    /// </description></item>
                    /// <item><description><para><c>PREVIOUS_DOWN</c>: period-over-period decrease percentage</para>
                    /// </description></item>
                    /// <item><description><para><c>HOH_UP</c>: hour-over-hour increase percentage</para>
                    /// </description></item>
                    /// <item><description><para><c>HOH_DOWN</c>: hour-over-hour decrease percentage</para>
                    /// </description></item>
                    /// <item><description><para><c>DOD_UP</c>: day-over-day increase percentage</para>
                    /// </description></item>
                    /// <item><description><para><c>DOD_DOWN</c>: day-over-day decrease percentage</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CURRENT_GTE</para>
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>The threshold for the alert condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The logical operator for combining multiple alert conditions. This applies to application monitoring and browser monitoring.</para>
                /// <list type="bullet">
                /// <item><description><para><c>OR</c>: The alert is triggered if any condition is met.</para>
                /// </description></item>
                /// <item><description><para><c>AND</c>: The alert is triggered only if all conditions are met.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OR</para>
                /// </summary>
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

            }

            /// <summary>
            /// <para>The status of the alert rule.</para>
            /// <list type="bullet">
            /// <item><description><para><c>RUNNING</c>: The alert rule is running.</para>
            /// </description></item>
            /// <item><description><para><c>STOPPED</c>: The alert rule is stopped.</para>
            /// </description></item>
            /// <item><description><para><c>PAUSED</c>: The alert rule is paused.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>The <c>PAUSED</c> status indicates that the system has automatically suspended the alert rule due to an abnormality. This can happen if the alert rule generates too many distinct time series or its associated cluster is deleted.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("AlertStatus")]
            [Validation(Required=false)]
            public string AlertStatus { get; set; }

            /// <summary>
            /// <para>The type of the alert rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>APPLICATION_MONITORING_ALERT_RULE</c>: an alert rule for application monitoring.</para>
            /// </description></item>
            /// <item><description><para><c>BROWSER_MONITORING_ALERT_RULE</c>: an alert rule for browser monitoring.</para>
            /// </description></item>
            /// <item><description><para><c>PROMETHEUS_MONITORING_ALERT_RULE</c>: an alert rule for Prometheus monitoring.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>APPLICATION_MONITORING_ALERT_RULE</para>
            /// </summary>
            [NameInMap("AlertType")]
            [Validation(Required=false)]
            public string AlertType { get; set; }

            /// <summary>
            /// <para>The annotations of the Prometheus alert rule.</para>
            /// </summary>
            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<CreateOrUpdateAlertRuleResponseBodyAlertRuleAnnotations> Annotations { get; set; }
            public class CreateOrUpdateAlertRuleResponseBodyAlertRuleAnnotations : TeaModel {
                /// <summary>
                /// <para>The annotation key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The annotation value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether newly created applications are automatically added to the alert rule. This applies to application monitoring and browser monitoring rules.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enabled</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoAddNewApplication")]
            [Validation(Required=false)]
            public bool? AutoAddNewApplication { get; set; }

            /// <summary>
            /// <para>The ID of the cluster that is associated with the Prometheus alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ceba9b9ea5b924dd0b6726d2de6******</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp, in milliseconds, when the alert rule was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1641438611000</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The duration, in minutes, for which a condition must be true before an alert is triggered. This applies only to Prometheus alert rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <para>The extended fields, returned as a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;alarmContext\&quot;:\&quot;{\\\&quot;content\\\&quot;:\\\&quot;报警名称:$报警名称\\\\n筛选条件: $筛选\\\\n报警时间: $报警时间\\\\n报警内容: $报警内容\\\\n注意！：该报警未收到恢复邮件之前，正在持续报警中，24小时后会再次提醒您！\\\&quot;,\\\&quot;subTitle\\\&quot;:\\\&quot;\\\&quot;}\&quot;,\&quot;alertWays\&quot;:\&quot;[0,1]\&quot;,\&quot;contactGroupIds\&quot;:\&quot;381,5075\&quot;,\&quot;notice\&quot;:\&quot;{\\\&quot;endTime\\\&quot;:1480607940000,\\\&quot;noticeEndTime\\\&quot;:1480607940000,\\\&quot;noticeStartTime\\\&quot;:1480521600000,\\\&quot;startTime\\\&quot;:1480521600000}\&quot;}</para>
            /// </summary>
            [NameInMap("Extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            /// <summary>
            /// <para>The filters of the alert rule. This applies to application monitoring or browser monitoring.</para>
            /// </summary>
            [NameInMap("Filters")]
            [Validation(Required=false)]
            public CreateOrUpdateAlertRuleResponseBodyAlertRuleFilters Filters { get; set; }
            public class CreateOrUpdateAlertRuleResponseBodyAlertRuleFilters : TeaModel {
                /// <summary>
                /// <para>The custom filter conditions for the browser monitoring alert rule.</para>
                /// </summary>
                [NameInMap("CustomSLSFilters")]
                [Validation(Required=false)]
                public List<CreateOrUpdateAlertRuleResponseBodyAlertRuleFiltersCustomSLSFilters> CustomSLSFilters { get; set; }
                public class CreateOrUpdateAlertRuleResponseBodyAlertRuleFiltersCustomSLSFilters : TeaModel {
                    /// <summary>
                    /// <para>The key of the filter condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>username</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The operator for the filter condition.</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>=</c>: equals</para>
                    /// </description></item>
                    /// <item><description><para><c>not</c>: not equal to</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>=</para>
                    /// </summary>
                    [NameInMap("Opt")]
                    [Validation(Required=false)]
                    public string Opt { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the filter condition is displayed on the console.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Show")]
                    [Validation(Required=false)]
                    public bool? Show { get; set; }

                    /// <summary>
                    /// <para>Used exclusively to distinguish between log types in browser monitoring. This parameter does not apply to other filter conditions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("T")]
                    [Validation(Required=false)]
                    public string T { get; set; }

                    /// <summary>
                    /// <para>The value for the filter condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The aggregation dimensions.</para>
                /// </summary>
                [NameInMap("CustomSLSGroupByDimensions")]
                [Validation(Required=false)]
                public List<string> CustomSLSGroupByDimensions { get; set; }

                /// <summary>
                /// <para>The configured filter conditions.</para>
                /// </summary>
                [NameInMap("CustomSLSWheres")]
                [Validation(Required=false)]
                public List<string> CustomSLSWheres { get; set; }

                /// <summary>
                /// <para>The filter conditions of the alert rule. This applies to application monitoring or browser monitoring.</para>
                /// </summary>
                [NameInMap("DimFilters")]
                [Validation(Required=false)]
                public List<CreateOrUpdateAlertRuleResponseBodyAlertRuleFiltersDimFilters> DimFilters { get; set; }
                public class CreateOrUpdateAlertRuleResponseBodyAlertRuleFiltersDimFilters : TeaModel {
                    /// <summary>
                    /// <para>The key of the filter condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rootIp</para>
                    /// </summary>
                    [NameInMap("FilterKey")]
                    [Validation(Required=false)]
                    public string FilterKey { get; set; }

                    /// <summary>
                    /// <para>The operator for the filter condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ALL</para>
                    /// </summary>
                    [NameInMap("FilterOpt")]
                    [Validation(Required=false)]
                    public string FilterOpt { get; set; }

                    /// <summary>
                    /// <para>The values for the filter condition.</para>
                    /// </summary>
                    [NameInMap("FilterValues")]
                    [Validation(Required=false)]
                    public List<string> FilterValues { get; set; }

                }

            }

            /// <summary>
            /// <para>The labels of the Prometheus alert rule.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<CreateOrUpdateAlertRuleResponseBodyAlertRuleLabels> Labels { get; set; }
            public class CreateOrUpdateAlertRuleResponseBodyAlertRuleLabels : TeaModel {
                /// <summary>
                /// <para>The label key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The label value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The severity level of the Prometheus alert rule.</para>
            /// <list type="bullet">
            /// <item><description><para><c>P1</c>: Critical. Indicates major issues that affect core business availability and can have severe consequences.</para>
            /// </description></item>
            /// <item><description><para><c>P2</c>: Warning. Indicates issues that impact system availability but have a limited scope.</para>
            /// </description></item>
            /// <item><description><para><c>P3</c>: Info. Indicates potential issues or alerts from less critical services.</para>
            /// </description></item>
            /// <item><description><para><c>P4</c>: Low priority. Indicates informational alerts that do not affect services.</para>
            /// </description></item>
            /// <item><description><para><c>Default</c>: The default level used when no specific severity is required.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>P2</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The message of the Prometheus alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>命名空间: {{$labels.namespace}} / Pod: {{$labels.pod_name}} / 容器: {{$labels.container}} 内存使用率超过80%, 当前值{{ printf \\\&quot;%.2f\\\&quot; $value }}%</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The metric type of the alert rule. This applies to application monitoring and browser monitoring.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JVM</para>
            /// </summary>
            [NameInMap("MetricsType")]
            [Validation(Required=false)]
            public string MetricsType { get; set; }

            /// <summary>
            /// <para>The notification mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL_MODE</para>
            /// </summary>
            [NameInMap("NotifyMode")]
            [Validation(Required=false)]
            public string NotifyMode { get; set; }

            /// <summary>
            /// <para>The notification policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALERT_MANAGER</para>
            /// </summary>
            [NameInMap("NotifyStrategy")]
            [Validation(Required=false)]
            public string NotifyStrategy { get; set; }

            /// <summary>
            /// <para>The PIDs of the applications associated with the alert rule. This applies to application monitoring and browser monitoring rules.</para>
            /// </summary>
            [NameInMap("Pids")]
            [Validation(Required=false)]
            public List<string> Pids { get; set; }

            /// <summary>
            /// <para>The PromQL expression for the Prometheus alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>node_memory_MemAvailable_bytes{} / node_memory_MemTotal_bytes{} * 100</para>
            /// </summary>
            [NameInMap("PromQL")]
            [Validation(Required=false)]
            public string PromQL { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The tags that are added to the alert rule.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<CreateOrUpdateAlertRuleResponseBodyAlertRuleTags> Tags { get; set; }
            public class CreateOrUpdateAlertRuleResponseBodyAlertRuleTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>owner</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The UNIX timestamp, in milliseconds, when the alert rule was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1641438611000</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1131971649******</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>337B8F7E-0A64-5768-9225-E9B3CF******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

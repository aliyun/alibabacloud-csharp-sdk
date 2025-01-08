// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateAlertRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the alert rule.</para>
        /// </summary>
        [NameInMap("AlertRule")]
        [Validation(Required=false)]
        public CreateOrUpdateAlertRuleResponseBodyAlertRule AlertRule { get; set; }
        public class CreateOrUpdateAlertRuleResponseBodyAlertRule : TeaModel {
            /// <summary>
            /// <para>The alert check type of the Prometheus alert rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>STATIC: a static threshold value.</description></item>
            /// <item><description>CUSTOM: a custom PromQL statement.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STATIC</para>
            /// </summary>
            [NameInMap("AlertCheckType")]
            [Validation(Required=false)]
            public string AlertCheckType { get; set; }

            /// <summary>
            /// <para>The alert contact group ID of the Prometheus alert rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>\-1: custom PromQL</description></item>
            /// <item><description>1: Kubernetes load</description></item>
            /// <item><description>15: Kubernetes node</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("AlertGroup")]
            [Validation(Required=false)]
            public long? AlertGroup { get; set; }

            /// <summary>
            /// <para>The alert rule ID.</para>
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
            /// <para>The content of the Application Monitoring or Browser Monitoring alert rule.</para>
            /// </summary>
            [NameInMap("AlertRuleContent")]
            [Validation(Required=false)]
            public CreateOrUpdateAlertRuleResponseBodyAlertRuleAlertRuleContent AlertRuleContent { get; set; }
            public class CreateOrUpdateAlertRuleResponseBodyAlertRuleAlertRuleContent : TeaModel {
                /// <summary>
                /// <para>The trigger conditions of the Application Monitoring or Browser Monitoring alert rule.</para>
                /// </summary>
                [NameInMap("AlertRuleItems")]
                [Validation(Required=false)]
                public List<CreateOrUpdateAlertRuleResponseBodyAlertRuleAlertRuleContentAlertRuleItems> AlertRuleItems { get; set; }
                public class CreateOrUpdateAlertRuleResponseBodyAlertRuleAlertRuleContentAlertRuleItems : TeaModel {
                    /// <summary>
                    /// <para>The aggregation method of the alert condition. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>AVG: calculates the average value</description></item>
                    /// <item><description>SUM: calculates the total value</description></item>
                    /// <item><description>MAX: selects the maximum value</description></item>
                    /// <item><description>MIN: selects the minimum value</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AVG</para>
                    /// </summary>
                    [NameInMap("Aggregate")]
                    [Validation(Required=false)]
                    public string Aggregate { get; set; }

                    /// <summary>
                    /// <para>The metric of the alert condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>appstat.jvm.non_heap_used</para>
                    /// </summary>
                    [NameInMap("MetricKey")]
                    [Validation(Required=false)]
                    public string MetricKey { get; set; }

                    /// <summary>
                    /// <para>Indicates the last N minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public float? N { get; set; }

                    /// <summary>
                    /// <para>The comparison operator that was used to compare the metric value with the threshold. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>CURRENT_GTE: greater than or equal to</description></item>
                    /// <item><description>CURRENT_LTE: less than or equal to</description></item>
                    /// <item><description>PREVIOUS_UP: the increase percentage compared with the last period</description></item>
                    /// <item><description>PREVIOUS_DOWN: the decrease percentage compared with the last period</description></item>
                    /// <item><description>HOH_UP: the increase percentage compared with the last hour</description></item>
                    /// <item><description>HOH_DOWN: the decrease percentage compared with the last hour</description></item>
                    /// <item><description>DOD_UP: the increase percentage compared with the last day</description></item>
                    /// <item><description>DOD_DOWN: the decrease percentage compared with the last day</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CURRENT_GTE</para>
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>The threshold of the alert condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The relationship between multiple alert conditions that were specified for the Application Monitoring or Browser Monitoring alert rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OR: meets any of the specified conditions.</description></item>
                /// <item><description>AND: meets all the specified conditions.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;|&quot;</para>
                /// </summary>
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

            }

            /// <summary>
            /// <para>The status of the alert rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RUNNING</description></item>
            /// <item><description>STOPPED</description></item>
            /// <item><description>PAUSED</description></item>
            /// </list>
            /// <remarks>
            /// <para>The PAUSED status indicates that the alert rule is abnormal and is actively paused by the system. The alert rule may be paused because that it is not unique or the associated cluster has been deleted.</para>
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
            /// <item><description>APPLICATION_MONITORING_ALERT_RULE: alert rule for Application Monitoring</description></item>
            /// <item><description>BROWSER_MONITORING_ALERT_RULE: alert rule for Browser Monitoring</description></item>
            /// <item><description>PROMETHEUS_MONITORING_ALERT_RULE: alert rule for Prometheus Service</description></item>
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
                /// <para>The key of the annotation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the annotation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the alert rule was applied to new applications that were created in Application Monitoring or Browser Monitoring. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enables the health check feature.</description></item>
            /// <item><description><c>false</c>: disables the automatic backup feature.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoAddNewApplication")]
            [Validation(Required=false)]
            public bool? AutoAddNewApplication { get; set; }

            /// <summary>
            /// <para>The ID of the monitored cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ceba9b9ea5b924dd0b6726d2de6******</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the alert rule was created. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1641438611000</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The duration of the Prometheus alert rule. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <para>The extended fields.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\\&quot;alarmContext\\&quot;:\\&quot;{\\\\\&quot;content\\\\\&quot;:\\\\Alert name: $Alert name\\\\\\nFilter condition: $Filter condition\\\\\\nAlert time: $Alert time\\\\\\nAlert content: $Alert content\\\\\\nNote: The alert persists before you receive an email that reminds you to clear the alert. You will be reminded of the alert again 24 hours later. \\\\\&quot;,\\\\\&quot;subTitle\\\\\&quot;:\\\\\&quot;\\\\\&quot;}\\&quot;,\\&quot;alertWays\\&quot;:\\&quot;[0,1]\\&quot;,\\&quot;contactGroupIds\\&quot;:\\&quot;381,5075\\&quot;,\\&quot;notice\\&quot;:\\&quot;{\\\\\&quot;endTime\\\\\&quot;:1480607940000,\\\\\&quot;noticeEndTime\\\\\&quot;:1480607940000,\\\\\&quot;noticeStartTime\\\\\&quot;:1480521600000,\\\\\&quot;startTime\\\\\&quot;:1480521600000}\\&quot;}</para>
            /// </summary>
            [NameInMap("Extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            /// <summary>
            /// <para>The filter conditions of the Application Monitoring or Browser Monitoring alert rule.</para>
            /// </summary>
            [NameInMap("Filters")]
            [Validation(Required=false)]
            public CreateOrUpdateAlertRuleResponseBodyAlertRuleFilters Filters { get; set; }
            public class CreateOrUpdateAlertRuleResponseBodyAlertRuleFilters : TeaModel {
                /// <summary>
                /// <para>The custom filter condition of the Browser Monitoring alert rule.</para>
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
                    /// <para>The logical operator of the filter condition. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>\=: equal to</description></item>
                    /// <item><description>not: not equal to</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>=</para>
                    /// </summary>
                    [NameInMap("Opt")]
                    [Validation(Required=false)]
                    public string Opt { get; set; }

                    /// <summary>
                    /// <para>Indicates whether this filter condition was displayed on the frontend.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Show")]
                    [Validation(Required=false)]
                    public bool? Show { get; set; }

                    /// <summary>
                    /// <para>The log type of Browser Monitoring. This field was not included in other filter conditions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("T")]
                    [Validation(Required=false)]
                    public string T { get; set; }

                    /// <summary>
                    /// <para>The value of the filter condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The information of the aggregation dimension.</para>
                /// </summary>
                [NameInMap("CustomSLSGroupByDimensions")]
                [Validation(Required=false)]
                public List<string> CustomSLSGroupByDimensions { get; set; }

                /// <summary>
                /// <para>The details of the custom filter condition.</para>
                /// </summary>
                [NameInMap("CustomSLSWheres")]
                [Validation(Required=false)]
                public List<string> CustomSLSWheres { get; set; }

                /// <summary>
                /// <para>The information about each filter condition of the Application Monitoring or Browser Monitoring alert rule.</para>
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
                    /// <para>The logical operator of the filter condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ALL</para>
                    /// </summary>
                    [NameInMap("FilterOpt")]
                    [Validation(Required=false)]
                    public string FilterOpt { get; set; }

                    /// <summary>
                    /// <para>The details of the filter condition.</para>
                    /// </summary>
                    [NameInMap("FilterValues")]
                    [Validation(Required=false)]
                    public List<string> FilterValues { get; set; }

                }

            }

            /// <summary>
            /// <para>The tags of the Prometheus alert rule.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<CreateOrUpdateAlertRuleResponseBodyAlertRuleLabels> Labels { get; set; }
            public class CreateOrUpdateAlertRuleResponseBodyAlertRuleLabels : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
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
            /// <item><description>P1: Alert notifications are sent for major issues that affect the availability of core business, have a huge impact, and may lead to serious consequences.</description></item>
            /// <item><description>P2: Alert notifications are sent for service errors that affect the system availability with relatively limited impact.</description></item>
            /// <item><description>P3: Alert notifications are sent for issues that may cause service errors or negative effects, or alert notifications for services that are relatively less important.</description></item>
            /// <item><description>P4: Alert notifications are sent for low-priority issues that do not affect your business.</description></item>
            /// <item><description>Default: Alert notifications are sent regardless of alert levels.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>P2</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The alert message of the Prometheus alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Namespace: {{$labels.namespace}} / Pod: {{$labels.pod_name}} / Container: {{$labels.container}} Memory usage exceeds 80%. Current value: {{ printf \\\\\&quot;%.2f\\\\\&quot; $value }}%</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The metric type of the Application Monitoring or Browser Monitoring alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JVM</para>
            /// </summary>
            [NameInMap("MetricsType")]
            [Validation(Required=false)]
            public string MetricsType { get; set; }

            /// <summary>
            /// <para>Notification Mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL_MODE</para>
            /// </summary>
            [NameInMap("NotifyMode")]
            [Validation(Required=false)]
            public string NotifyMode { get; set; }

            /// <summary>
            /// <para>The name of the notification policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALERT_MANAGER</para>
            /// </summary>
            [NameInMap("NotifyStrategy")]
            [Validation(Required=false)]
            public string NotifyStrategy { get; set; }

            /// <summary>
            /// <para>The process ID (PID) that was associated with the Application Monitoring or Browser Monitoring alert rule.</para>
            /// </summary>
            [NameInMap("Pids")]
            [Validation(Required=false)]
            public List<string> Pids { get; set; }

            /// <summary>
            /// <para>The PromQL statement of the Prometheus alert rule.</para>
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
            /// <para>The list of tags.</para>
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
            /// <para>The timestamp generated when the alert rule was updated. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1641438611000</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateAlertRuleRequest : TeaModel {
        /// <summary>
        /// <para>The alert check type of the Prometheus alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>STATIC: a static threshold value. If you set the parameter to STATIC, you must specify the <b>MetricsKey</b> parameter. For more information, see the <b>Correspondence between AlertGroup and MetricsKey for Prometheus Service</b> table.</description></item>
        /// <item><description>CUSTOM: a custom PromQL statement. If you set the parameter to CUSTOM, you must specify the <b>PromQL</b>, <b>Duration</b>, and <b>Message</b> parameters to create a Prometheus alert rule.</description></item>
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
        /// <para>The ID of the alert rule.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, a new alert rule is created.</description></item>
        /// <item><description>If you specify this parameter, the specified alert rule is modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>546xxx</para>
        /// </summary>
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public long? AlertId { get; set; }

        /// <summary>
        /// <para>The name of the alert rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alert Rule Demo</para>
        /// </summary>
        [NameInMap("AlertName")]
        [Validation(Required=false)]
        public string AlertName { get; set; }

        /// <summary>
        /// <para>The configuration of the alert sending channel. This parameter is used to be compatible with the old version of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("AlertPiplines")]
        [Validation(Required=false)]
        public string AlertPiplines { get; set; }

        /// <summary>
        /// <para>The content of the Application Monitoring or Browser Monitoring alert rule. The following code provides an example of the <b>AlertRuleContent</b> parameter. For more information about the meaning of each field, see the supplementary description.</para>
        /// <pre><code class="language-json">{ 
        ///     &quot;Condition&quot;: &quot;OR&quot;,
        ///      &quot;AlertRuleItems&quot;: [
        ///              { &quot;Operator&quot;: &quot;CURRENT_LTE&quot;,
        ///                  &quot;MetricKey&quot;: &quot;appstat.jvm.threadcount&quot;,
        ///                  &quot;Value&quot;: 1000,
        ///                  &quot;Aggregate&quot;: &quot;AVG&quot;,
        ///                   &quot;N&quot;: 10,
        ///                   &quot;Tolerability&quot;: 169
        ///             } 
        ///        ]  
        ///   }
        /// </c></pre>
        /// <remarks>
        /// <para> The filter conditions specified by the <b>AlertRuleItems.MetricKey</b> field depends on the value of the <b>MetricsType</b> parameter. For more information about the types of metrics supported by Application Monitoring and Browser Monitoring and the alert rule fields corresponding to each metric, see the supplementary description.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;Condition&quot;: &quot;OR&quot;, &quot;AlertRuleItems&quot;: [ { &quot;Operator&quot;: &quot;CURRENT_LTE&quot;,  &quot;MetricKey&quot;: &quot;appstat.jvm.threadcount&quot;,  &quot;Value&quot;: 1000,  &quot;Aggregate&quot;: &quot;AVG&quot;,   &quot;N&quot;: 1  }  ]  }</para>
        /// </summary>
        [NameInMap("AlertRuleContent")]
        [Validation(Required=false)]
        public string AlertRuleContent { get; set; }

        /// <summary>
        /// <para>The status of the alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RUNNING (default)</description></item>
        /// <item><description>STOPPED</description></item>
        /// </list>
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
        /// <item><description>PROMETHEUS_MONITORING_ALERT_RULE: alert rule for Managed Service for Prometheus</description></item>
        /// <item><description>XTRACE_MONITORING_ALERT_RULE: alert rule for Managed Service for OpenTelemetry</description></item>
        /// <item><description>EBPF_MONITORING_ALERT_RULE: alert rule for Application Monitoring eBPF Edition</description></item>
        /// <item><description>RUM_MONITORING_ALERT_RULE: alert rule for Real User Monitoring</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APPLICATION_MONITORING_ALERT_RULE</para>
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        /// <summary>
        /// <para>The annotations of the Prometheus alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ { &quot;Value&quot;: &quot;PolarDB slow queries&quot;, &quot;Name&quot;: &quot;_aliyun_display_name&quot; }</para>
        /// </summary>
        [NameInMap("Annotations")]
        [Validation(Required=false)]
        public string Annotations { get; set; }

        /// <summary>
        /// <para>Specifies whether to apply the alert rule to new applications that are created in Application Monitoring or Browser Monitoring. Valid values:</para>
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
        /// <para>The configurations that are automatically appended to monitor the application based on the specified alert rule.</para>
        /// <list type="bullet">
        /// <item><description><para>autoAddMatchType:</para>
        /// <para>the matching mode. Valid values: REGULAR and NOT_REGULAR.</para>
        /// </description></item>
        /// <item><description><para>autoAddMatchExp: the regular expression</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;autoAddMatchType\&quot;:\&quot;REGULAR\&quot;,\&quot;autoAddMatchExp\&quot;:\&quot;.<em>cbw.</em>\&quot;}</para>
        /// </summary>
        [NameInMap("AutoAddTargetConfig")]
        [Validation(Required=false)]
        public string AutoAddTargetConfig { get; set; }

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
        /// <para>Data Configuration. The dataRevision field specifies the data repair method when there is no data for the metric.</para>
        /// <list type="bullet">
        /// <item><description>Fill with zero: 0</description></item>
        /// <item><description>Fill with one: 1</description></item>
        /// <item><description>Fill with null: 2 (default, does not trigger an alarm)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;dataRevision&quot;: 2
        /// }</para>
        /// </summary>
        [NameInMap("DataConfig")]
        [Validation(Required=false)]
        public string DataConfig { get; set; }

        /// <summary>
        /// <para>The duration of the Prometheus alert rule, in minutes, in the range of [0,1440].</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <para>The filter conditions of the Application Monitoring or Browser Monitoring alert rule. Format:</para>
        /// <pre><c>&quot;DimFilters&quot;: [ 
        /// { 
        ///  &quot;FilterOpt&quot;: &quot;ALL&quot;,
        /// &quot;FilterValues&quot;: [],         //The value of the filter condition.
        /// &quot;FilterKey&quot;: &quot;rootIp&quot;     //The key of the filter condition.
        /// }
        /// ]
        /// </c></pre>
        /// <para>Valid values of <b>FilterOpt</b>:</para>
        /// <list type="bullet">
        /// <item><description>STATIC: matches the value of the specified dimension.</description></item>
        /// <item><description>ALL: traverses all dimension values. Dynamic thresholds do not support traversal.</description></item>
        /// <item><description>DISABLE: aggregates the values of all dimensions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;DimFilters&quot;: [             {               &quot;FilterOpt&quot;: &quot;ALL&quot;,               &quot;FilterValues&quot;: [],               &quot;FilterKey&quot;: &quot;rootIp&quot;             }           ]         }</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public string Filters { get; set; }

        /// <summary>
        /// <para>The tags of the Prometheus alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[  { &quot;Value&quot;: &quot;cms_polardb&quot;,             &quot;Name&quot;: &quot;_aliyun_cloud_product&quot;           }         ]</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

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
        /// <para>Application Tags. Used for application monitoring alert rules, to filter applications associated with alert rules.</para>
        /// </summary>
        [NameInMap("MarkTags")]
        [Validation(Required=false)]
        public List<CreateOrUpdateAlertRuleRequestMarkTags> MarkTags { get; set; }
        public class CreateOrUpdateAlertRuleRequestMarkTags : TeaModel {
            /// <summary>
            /// <para>The Tag Key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The Tag Value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>proudct</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

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
        /// <para>The alert metrics. If you set the <b>AlertCheckType</b> parameter to <b>STATIC</b> when you create a Prometheus alert rule, you must specify the <b>MetricsKey</b> parameter.</para>
        /// <remarks>
        /// <para>Alert metrics vary depending on the value of the <b>AlertGroup</b> parameter. For more information about the correspondence between <b>AlertGroup</b> and <b>MetricsKey</b>, see the supplementary description.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pop.status.error</para>
        /// </summary>
        [NameInMap("MetricsKey")]
        [Validation(Required=false)]
        public string MetricsKey { get; set; }

        /// <summary>
        /// <para>The metric type of the Application Monitoring or Browser Monitoring alert rule. For more information, see the following table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jvm</para>
        /// </summary>
        [NameInMap("MetricsType")]
        [Validation(Required=false)]
        public string MetricsType { get; set; }

        /// <summary>
        /// <para>The effective time and notification time. This parameter is used to be compatible with the old version of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Notice")]
        [Validation(Required=false)]
        public string Notice { get; set; }

        /// <summary>
        /// <para>The notification mode. You can specify the normal mode or simple mode.</para>
        /// <list type="bullet">
        /// <item><description>DIRECTED_MODE</description></item>
        /// <item><description>NORMAL_MODE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL_MODE</para>
        /// </summary>
        [NameInMap("NotifyMode")]
        [Validation(Required=false)]
        public string NotifyMode { get; set; }

        /// <summary>
        /// <para>The notification policy.</para>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to null, no notification policy is specified. After you create an alert rule, you can create a notification policy and specify match rules and match conditions. For example, you can specify the name of the alert rule as the match condition. When the alert rule is triggered, an alert event is generated and an alert notification is sent to the contacts or contact groups that are specified in the notification policy.</description></item>
        /// <item><description>To specify a notification policy, set this parameter to the ID of the notification policy. Application Real-Time Monitoring Service (ARMS) automatically adds a match rule to the notification policy and specifies the ID of the alert rule as the match condition. The name of the alert rule is also displayed. This way, the alert events that are generated based on the alert rule can be matched by the specified notification policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>569xxx</para>
        /// </summary>
        [NameInMap("NotifyStrategy")]
        [Validation(Required=false)]
        public string NotifyStrategy { get; set; }

        /// <summary>
        /// <para>The process ID (PID) that is associated with the Application Monitoring or Browser Monitoring alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;b590lhguqs@40d8deedfa9******&quot;]</para>
        /// </summary>
        [NameInMap("Pids")]
        [Validation(Required=false)]
        public string Pids { get; set; }

        /// <summary>
        /// <para>The product code. If you specify this parameter when you create a Prometheus alert rule, the backend checks whether the product exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clickhouse</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

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
        /// <para>This parameter is required.</para>
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
        public List<CreateOrUpdateAlertRuleRequestTags> Tags { get; set; }
        public class CreateOrUpdateAlertRuleRequestTags : TeaModel {
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

    }

}

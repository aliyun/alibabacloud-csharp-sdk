// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateAlertRuleRequest : TeaModel {
        /// <summary>
        /// <para>The check type for a Prometheus monitoring alert rule.</para>
        /// <list type="bullet">
        /// <item><description><para><c>STATIC</c>: A static threshold. The <b>MetricsKey</b> parameter is required. For more information, see the description of the <b>MetricsKey</b> parameter below.</para>
        /// </description></item>
        /// <item><description><para><c>CUSTOM</c>: A custom PromQL query. The <b>PromQL</b>, <b>Duration</b>, and <b>Message</b> parameters are required.</para>
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
        /// <para>The alert group ID for the Prometheus alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>-1</c>: Custom PromQL</para>
        /// </description></item>
        /// <item><description><para><c>1</c>: Kubernetes workloads</para>
        /// </description></item>
        /// <item><description><para><c>15</c>: Kubernetes nodes</para>
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
        /// <list type="bullet">
        /// <item><description><para>Omit this parameter to create a new alert rule.</para>
        /// </description></item>
        /// <item><description><para>Specify an ID to modify an existing alert rule.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>546xxx</para>
        /// </summary>
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public long? AlertId { get; set; }

        /// <summary>
        /// <para>The alert rule name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alert Rule Demo</para>
        /// </summary>
        [NameInMap("AlertName")]
        [Validation(Required=false)]
        public string AlertName { get; set; }

        /// <summary>
        /// <para>The alert pipeline configuration. Used for compatibility with legacy alert rules.</para>
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
        /// <para>The content of the alert rule for application monitoring or browser monitoring. The following is a template for the <b>AlertRuleContent</b> parameter. For a description of the fields in the template, see the supplementary information below this table.</para>
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
        /// <para>The available fields for <b>AlertRuleItems.MetricKey</b> depend on the <b>MetricsType</b> value. For information about the metric types supported by application monitoring and browser monitoring and their corresponding alert rule fields, see the supplementary information below this table.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{ 
        ///     &quot;Condition&quot;: &quot;OR&quot;,
        ///      &quot;AlertRuleItems&quot;: [
        ///              { &quot;Operator&quot;: &quot;CURRENT_LTE&quot;,
        ///                  &quot;MetricKey&quot;: &quot;appstat.jvm.threadcount&quot;,
        ///                  &quot;Value&quot;: 1000,
        ///                  &quot;Aggregate&quot;: &quot;AVG&quot;,
        ///                   &quot;N&quot;: 10,
        ///                   &quot;Tolerability&quot;: 169
        ///             } 
        ///        ]<br>  }</para>
        /// </summary>
        [NameInMap("AlertRuleContent")]
        [Validation(Required=false)]
        public string AlertRuleContent { get; set; }

        /// <summary>
        /// <para>The status of the alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>RUNNING</c>: The alert rule is running. (Default)</para>
        /// </description></item>
        /// <item><description><para><c>STOPPED</c>: The alert rule is stopped.</para>
        /// </description></item>
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
        /// <item><description><para><c>APPLICATION_MONITORING_ALERT_RULE</c>: For application monitoring.</para>
        /// </description></item>
        /// <item><description><para><c>BROWSER_MONITORING_ALERT_RULE</c>: For browser monitoring.</para>
        /// </description></item>
        /// <item><description><para><c>PROMETHEUS_MONITORING_ALERT_RULE</c>: For Prometheus monitoring.</para>
        /// </description></item>
        /// <item><description><para><c>XTRACE_MONITORING_ALERT_RULE</c>: For Tracing Analysis (OpenTelemetry edition).</para>
        /// </description></item>
        /// <item><description><para><c>EBPF_MONITORING_ALERT_RULE</c>: For eBPF monitoring.</para>
        /// </description></item>
        /// <item><description><para><c>RUM_MONITORING_ALERT_RULE</c>: For real user monitoring (RUM).</para>
        /// </description></item>
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
        /// <para>Annotations to add to the Prometheus alert rule. Specify as a JSON string representing an array of objects, each with Name and Value keys.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ { &quot;Value&quot;: &quot;PolarDB 慢查询数量&quot;,             &quot;Name&quot;: &quot;_aliyun_display_name&quot;           }</para>
        /// </summary>
        [NameInMap("Annotations")]
        [Validation(Required=false)]
        public string Annotations { get; set; }

        /// <summary>
        /// <para>Determines whether to automatically apply this alert rule to new applications. This applies only to application monitoring and browser monitoring rules.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: enables the feature.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: disables the feature.</para>
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
        /// <para>The configuration for automatically adding applications to an application monitoring alert rule. Specify this parameter as a JSON string with the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><c>autoAddMatchType</c>: The matching method. Can be <c>REGULAR</c> (matches the regular expression) or <c>NOT_REGULAR</c> (does not match the regular expression).</para>
        /// <para>Match type: Regular expression match (REGULAR) / Not a regular expression match (NOT_REGULAR)</para>
        /// </description></item>
        /// <item><description><para><c>autoAddMatchExp</c>: The regular expression.</para>
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
        /// <para>The check interval for the Prometheus alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CheckCycle")]
        [Validation(Required=false)]
        public long? CheckCycle { get; set; }

        /// <summary>
        /// <para>The cluster ID for the Prometheus monitoring alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ceba9b9ea5b924dd0b6726d2de6******</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The data configuration. The dataRevision field specifies how to handle missing metric data.</para>
        /// <list type="bullet">
        /// <item><description><para><c>0</c>: Fills the data with 0.</para>
        /// </description></item>
        /// <item><description><para><c>1</c>: Fills the data with 1.</para>
        /// </description></item>
        /// <item><description><para><c>2</c>: Fills the data with null. This is the default and does not trigger an alert.</para>
        /// </description></item>
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
        /// <para>The period, in minutes, that a condition must be true before a Prometheus alert is triggered. Valid values: 0 to 1440.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <para>The filters for an application monitoring or browser monitoring alert rule.
        /// Specify this parameter as a JSON string in the following format:</para>
        /// <pre><c>&quot;DimFilters&quot;: [ 
        /// { 
        ///  &quot;FilterOpt&quot;: &quot;ALL&quot;,
        ///  &quot;FilterValues&quot;: [],         // The filter value.
        ///  &quot;FilterKey&quot;: &quot;rootIp&quot;     // The filter key.
        /// }
        /// ]
        /// </c></pre>
        /// <para>Valid values for <b>FilterOpt</b>:</para>
        /// <list type="bullet">
        /// <item><description><para><c>STATIC</c>: Matches a fixed dimension value.</para>
        /// </description></item>
        /// <item><description><para><c>ALL</c>: Iterates over all dimension values. Note: This option is not supported for range detection.</para>
        /// </description></item>
        /// <item><description><para><c>DISABLE</c>: Aggregates all dimension values by summing them.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;DimFilters&quot;: [             {               &quot;FilterOpt&quot;: &quot;ALL&quot;,               &quot;FilterValues&quot;: [],               &quot;FilterKey&quot;: &quot;rootIp&quot;             }           ]         }</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public string Filters { get; set; }

        /// <summary>
        /// <para>Labels to add to the Prometheus alert rule. Specify as a JSON string representing an array of objects, each with Name and Value keys.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[  { &quot;Value&quot;: &quot;cms_polardb&quot;,             &quot;Name&quot;: &quot;_aliyun_cloud_product&quot;           }         ]</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The severity level for the Prometheus alert rule.</para>
        /// <list type="bullet">
        /// <item><description><para><c>P1</c>: Critical. For major issues that affect core business availability with a wide impact and severe consequences.</para>
        /// </description></item>
        /// <item><description><para><c>P2</c>: Warning. For issues that cause partial service failures or affect system availability with a limited scope.</para>
        /// </description></item>
        /// <item><description><para><c>P3</c>: Info. For potential issues or alerts from non-critical services.</para>
        /// </description></item>
        /// <item><description><para><c>P4</c>: Low priority. Used for informational alerts that require attention but do not affect services.</para>
        /// </description></item>
        /// <item><description><para><c>Default</c>: The default level, used when no specific severity is required.</para>
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
        /// <para>Application tags used to filter applications in application monitoring alert rules.</para>
        /// </summary>
        [NameInMap("MarkTags")]
        [Validation(Required=false)]
        public List<CreateOrUpdateAlertRuleRequestMarkTags> MarkTags { get; set; }
        public class CreateOrUpdateAlertRuleRequestMarkTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>proudct</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The alert message for the Prometheus alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>命名空间: {{$labels.namespace}} / Pod: {{$labels.pod_name}} / 容器: {{$labels.container}} 内存使用率超过80%, 当前值{{ printf \\\&quot;%.2f\\\&quot; $value }}%</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The alert metric. This parameter is required for Prometheus alert rules when <b>AlertCheckType</b> is <b>STATIC</b>.</para>
        /// <remarks>
        /// <para>The available alert metrics vary based on the value of <b>AlertGroup</b>. For information about the mapping between <b>AlertGroup</b> and <b>MetricsKey</b>, see the supplementary information below this table.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pop.status.error</para>
        /// </summary>
        [NameInMap("MetricsKey")]
        [Validation(Required=false)]
        public string MetricsKey { get; set; }

        /// <summary>
        /// <para>The alert metric type for application monitoring or browser monitoring alert rules. For more information, see the table below.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jvm</para>
        /// </summary>
        [NameInMap("MetricsType")]
        [Validation(Required=false)]
        public string MetricsType { get; set; }

        /// <summary>
        /// <para>The effective time and notification time. Used for compatibility with legacy alert rules.</para>
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
        /// <para>The notification mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>DIRECTED_MODE</c>: Directed mode.</para>
        /// </description></item>
        /// <item><description><para><c>NORMAL_MODE</c>: Normal mode.</para>
        /// </description></item>
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
        /// <item><description><para><c>null</c>: Does not associate the alert rule with a notification policy. You can associate them later by creating a notification policy with a matching rule, for example, based on the alert rule\&quot;s name. When the alert rule is triggered, alert events are sent to the contacts or contact groups specified in the matching notification policy.</para>
        /// </description></item>
        /// <item><description><para>A notification policy ID: Associates the alert rule with a specific notification policy. ARMS automatically adds a matching rule to the policy that uses the alert rule\&quot;s ID. This ensures that alert events from this rule are always processed by the specified policy.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>569xxx</para>
        /// </summary>
        [NameInMap("NotifyStrategy")]
        [Validation(Required=false)]
        public string NotifyStrategy { get; set; }

        /// <summary>
        /// <para>The PIDs of applications for an application monitoring or browser monitoring alert rule. Specify as a JSON array of strings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;b590lhguqs@40d8deedfa9******&quot;]</para>
        /// </summary>
        [NameInMap("Pids")]
        [Validation(Required=false)]
        public string Pids { get; set; }

        /// <summary>
        /// <para>Required for Prometheus alert rules. Used to filter by cloud service. The specified product name must be valid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clickhouse</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        /// <summary>
        /// <para>The PromQL expression to evaluate.</para>
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
        /// <para>The tags to add to the alert rule. These are standard Alibaba Cloud resource tags.</para>
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

        /// <summary>
        /// <para>The language of the response.</para>
        /// </summary>
        [NameInMap("aliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

    }

}

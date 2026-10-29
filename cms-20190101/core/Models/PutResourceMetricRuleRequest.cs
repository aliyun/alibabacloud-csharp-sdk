// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutResourceMetricRuleRequest : TeaModel {
        [NameInMap("Escalations")]
        [Validation(Required=false)]
        public PutResourceMetricRuleRequestEscalations Escalations { get; set; }
        public class PutResourceMetricRuleRequestEscalations : TeaModel {
            [NameInMap("Critical")]
            [Validation(Required=false)]
            public PutResourceMetricRuleRequestEscalationsCritical Critical { get; set; }
            public class PutResourceMetricRuleRequestEscalationsCritical : TeaModel {
                /// <summary>
                /// <para>The comparison operator for the Critical-level threshold. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold.</description></item>
                /// <item><description>GreaterThanThreshold: greater than the threshold.</description></item>
                /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold.</description></item>
                /// <item><description>LessThanThreshold: less than the threshold.</description></item>
                /// <item><description>NotEqualToThreshold: not equal to the threshold.</description></item>
                /// <item><description>EqualToThreshold: equal to the threshold.</description></item>
                /// <item><description>GreaterThanYesterday: greater than the value at the same time yesterday.</description></item>
                /// <item><description>LessThanYesterday: less than the value at the same time yesterday.</description></item>
                /// <item><description>GreaterThanLastWeek: greater than the value at the same time last week.</description></item>
                /// <item><description>LessThanLastWeek: less than the value at the same time last week.</description></item>
                /// <item><description>GreaterThanLastPeriod: greater than the value in the previous period.</description></item>
                /// <item><description>LessThanLastPeriod: less than the value in the previous period.</description></item>
                /// </list>
                /// <remarks>
                /// <para>You must configure at least one of the following alert levels: Critical, Warn, and Info. For the configured alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The statistical method for the Critical-level alert.</para>
                /// <para>The valid values of this parameter are determined by the <c>Statistics</c> column corresponding to the <c>MetricName</c> of the specified Alibaba Cloud service. Examples: Maximum, Minimum, and Average. For more information about how to obtain the valid values for this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service metrics</a>.</para>
                /// <remarks>
                /// <para>You must configure at least one of the following alert levels: Critical, Warn, and Info. For the configured alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>The threshold for the Critical-level alert.</para>
                /// <remarks>
                /// <para>You must configure at least one of the following alert levels: Critical, Warn, and Info. For the configured alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// <para>The number of retries for the Critical-level alert.</para>
                /// <remarks>
                /// <para>You must configure at least one of the following alert levels: Critical, Warn, and Info. For the configured alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public int? Times { get; set; }

            }

            [NameInMap("Info")]
            [Validation(Required=false)]
            public PutResourceMetricRuleRequestEscalationsInfo Info { get; set; }
            public class PutResourceMetricRuleRequestEscalationsInfo : TeaModel {
                /// <summary>
                /// <para>The comparison operator for the Info-level threshold. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold.</description></item>
                /// <item><description>GreaterThanThreshold: greater than the threshold.</description></item>
                /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold.</description></item>
                /// <item><description>LessThanThreshold: less than the threshold.</description></item>
                /// <item><description>NotEqualToThreshold: not equal to the threshold.</description></item>
                /// <item><description>EqualToThreshold: equal to the threshold.</description></item>
                /// <item><description>GreaterThanYesterday: greater than the value at the same time yesterday.</description></item>
                /// <item><description>LessThanYesterday: less than the value at the same time yesterday.</description></item>
                /// <item><description>GreaterThanLastWeek: greater than the value at the same time last week.</description></item>
                /// <item><description>LessThanLastWeek: less than the value at the same time last week.</description></item>
                /// <item><description>GreaterThanLastPeriod: greater than the value in the previous period.</description></item>
                /// <item><description>LessThanLastPeriod: less than the value in the previous period.</description></item>
                /// </list>
                /// <remarks>
                /// <para>You must configure at least one of the following alert levels: Critical, Warn, and Info. For the configured alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The statistical method for the Info-level alert.</para>
                /// <para>The valid values of this parameter are determined by the <c>Statistics</c> column corresponding to the <c>MetricName</c> of the specified Alibaba Cloud service. Examples: Maximum, Minimum, and Average. For more information about how to obtain the valid values for this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service metrics</a>.</para>
                /// <remarks>
                /// <para>You must configure at least one of the following alert levels: Critical, Warn, and Info. For the configured alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>The threshold for the Info-level alert.</para>
                /// <remarks>
                /// <para>You must configure at least one of the following alert levels: Critical, Warn, and Info. For the configured alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// <para>The number of retries for the Info-level alert.</para>
                /// <remarks>
                /// <para>You must configure at least one of the following alert levels: Critical, Warn, and Info. For the configured alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public int? Times { get; set; }

            }

            [NameInMap("Warn")]
            [Validation(Required=false)]
            public PutResourceMetricRuleRequestEscalationsWarn Warn { get; set; }
            public class PutResourceMetricRuleRequestEscalationsWarn : TeaModel {
                /// <summary>
                /// <para>The comparison operator for the Warn-level threshold. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold.</description></item>
                /// <item><description>GreaterThanThreshold: greater than the threshold.</description></item>
                /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold.</description></item>
                /// <item><description>LessThanThreshold: less than the threshold.</description></item>
                /// <item><description>NotEqualToThreshold: not equal to the threshold.</description></item>
                /// <item><description>EqualToThreshold: equal to the threshold.</description></item>
                /// <item><description>GreaterThanYesterday: greater than the value at the same time yesterday.</description></item>
                /// <item><description>LessThanYesterday: less than the value at the same time yesterday.</description></item>
                /// <item><description>GreaterThanLastWeek: greater than the value at the same time last week.</description></item>
                /// <item><description>LessThanLastWeek: less than the value at the same time last week.</description></item>
                /// <item><description>GreaterThanLastPeriod: greater than the value in the previous period.</description></item>
                /// <item><description>LessThanLastPeriod: less than the value in the previous period.</description></item>
                /// </list>
                /// <remarks>
                /// <para>You must configure at least one of the following alert levels: Critical, Warn, and Info. For the configured alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The statistical method for the Warn-level alert.</para>
                /// <para>The valid values of this parameter are determined by the <c>Statistics</c> column corresponding to the <c>MetricName</c> of the specified Alibaba Cloud service. Examples: Maximum, Minimum, and Average. For more information about how to obtain the valid values for this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service metrics</a>.</para>
                /// <remarks>
                /// <para>You must configure at least one of the following alert levels: Critical, Warn, and Info. For the configured alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>The threshold for the Warn-level alert.</para>
                /// <remarks>
                /// <para>You must configure at least one of the following alert levels: Critical, Warn, and Info. For the configured alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// <para>The number of retries for the Warn-level alert.</para>
                /// <remarks>
                /// <para>You must configure at least one of the following alert levels: Critical, Warn, and Info. For the configured alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public int? Times { get; set; }

            }

        }

        /// <summary>
        /// <para>The alert conditions for multiple metrics.</para>
        /// <remarks>
        /// <para>Single-metric and multi-metric alert conditions are mutually exclusive and cannot be configured at the same time.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CompositeExpression")]
        [Validation(Required=false)]
        public PutResourceMetricRuleRequestCompositeExpression CompositeExpression { get; set; }
        public class PutResourceMetricRuleRequestCompositeExpression : TeaModel {
            /// <summary>
            /// <para>The list of standard alert conditions.</para>
            /// </summary>
            [NameInMap("ExpressionList")]
            [Validation(Required=false)]
            public List<PutResourceMetricRuleRequestCompositeExpressionExpressionList> ExpressionList { get; set; }
            public class PutResourceMetricRuleRequestCompositeExpressionExpressionList : TeaModel {
                /// <summary>
                /// <para>The comparison operator for the threshold. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold.</description></item>
                /// <item><description>GreaterThanThreshold: greater than the threshold.</description></item>
                /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold.</description></item>
                /// <item><description>LessThanThreshold: less than the threshold.</description></item>
                /// <item><description>NotEqualToThreshold: not equal to the threshold.</description></item>
                /// <item><description>EqualToThreshold: equal to the threshold.</description></item>
                /// <item><description>GreaterThanYesterday: greater than the value at the same time yesterday.</description></item>
                /// <item><description>LessThanYesterday: less than the value at the same time yesterday.</description></item>
                /// <item><description>GreaterThanLastWeek: greater than the value at the same time last week.</description></item>
                /// <item><description>LessThanLastWeek: less than the value at the same time last week.</description></item>
                /// <item><description>GreaterThanLastPeriod: greater than the value in the previous period.</description></item>
                /// <item><description>LessThanLastPeriod: less than the value in the previous period.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The name of the metric for the Alibaba Cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cpu_total</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The aggregation period of the metric.</para>
                /// <para>Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public long? Period { get; set; }

                /// <summary>
                /// <para>The statistical method of the metric. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>$Maximum: the maximum value.</description></item>
                /// <item><description>$Minimum: the minimum value.</description></item>
                /// <item><description>$Average: the average value.</description></item>
                /// <item><description>$Availability: the active rate. This is typically used for site monitoring.</description></item>
                /// </list>
                /// <remarks>
                /// <para><c>$</c> is the unified prefix for metrics. For more information about supported Alibaba Cloud services, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service metrics</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>$Maximum</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>The alert threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

            }

            /// <summary>
            /// <para>The logical relationship between multi-metric alert conditions. Valid values: </para>
            /// <list type="bullet">
            /// <item><description><para><c>&amp;&amp;</c>: An alert is triggered only when all metrics meet the alert conditions. An alert is triggered only when all expressions in ExpressionList evaluate to <c>true</c>.</para>
            /// </description></item>
            /// <item><description><para><c>||</c>: An alert is triggered when any metric meets the alert condition.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>||</para>
            /// </summary>
            [NameInMap("ExpressionListJoin")]
            [Validation(Required=false)]
            public string ExpressionListJoin { get; set; }

            /// <summary>
            /// <para>The alert conditions created by using expressions. This includes but is not limited to the following scenarios:</para>
            /// <list type="bullet">
            /// <item><description>Configure an alert blacklist for specific resources. Example: <c>$instanceId != \\&quot;i-io8kfvcpp7x5****\\&quot; ``&amp;&amp;`` $Average &gt; 50</c>. This indicates that no alert is triggered even if the <c>Average</c> value of the instance <c>i-io8kfvcpp7x5****</c> in the alert rule is greater than 50.</description></item>
            /// <item><description>Configure a special alert threshold for a specific instance in the rule. Example: <c>$Average &gt; ($instanceId == \\&quot;i-io8kfvcpp7x5****\\&quot;? 80: 50)</c>. This indicates that an alert is triggered only when the <c>Average</c> value of the instance <c>i-io8kfvcpp7x5****</c> in the alert rule is greater than 80. For other instances, an alert is triggered when the <c>Average</c> value is greater than 50.</description></item>
            /// <item><description>Limit the number of instances that exceed the threshold in the rule. Example: <c>count($Average &gt; 20) &gt; 3</c>. This indicates that an alert is triggered only when the number of instances whose <c>Average</c> value is greater than 20 exceeds 3.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>$Average &gt; ($instanceId == \&quot;i-io8kfvcpp7x5****\&quot;? 80: 50)</para>
            /// </summary>
            [NameInMap("ExpressionRaw")]
            [Validation(Required=false)]
            public string ExpressionRaw { get; set; }

            /// <summary>
            /// <para>The alert level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CRITICAL: critical.</description></item>
            /// <item><description>WARN: warning.</description></item>
            /// <item><description>INFO: info.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CRITICAL</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The number of times that the alert condition must be met before an alert notification is sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

        }

        /// <summary>
        /// <para>The alert contact group. Alert notifications are sent to the alert contacts in this alert contact group.</para>
        /// <remarks>
        /// <para>An alert contact group contains one or more alert contacts. For more information about how to create alert contacts and alert contact groups, see <a href="https://help.aliyun.com/document_detail/114923.html">PutContact</a> and <a href="https://help.aliyun.com/document_detail/114929.html">PutContactGroup</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_Group</para>
        /// </summary>
        [NameInMap("ContactGroups")]
        [Validation(Required=false)]
        public string ContactGroups { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is prechecked but not executed. The system checks whether the required parameters are specified, the request format is valid, and the service limits are met. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): The request is sent and executed. If the request passes the precheck, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The effective period of the alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00-23:59</para>
        /// </summary>
        [NameInMap("EffectiveInterval")]
        [Validation(Required=false)]
        public string EffectiveInterval { get; set; }

        /// <summary>
        /// <para>The subject of the alert email.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS instance alert</para>
        /// </summary>
        [NameInMap("EmailSubject")]
        [Validation(Required=false)]
        public string EmailSubject { get; set; }

        /// <summary>
        /// <para>The trigger epoch of the alert rule. Unit: seconds.</para>
        /// <remarks>
        /// <para>For more information about how to query the statistical epoch of a metric, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service metrics</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The labels that are added to the metric and displayed in the alert notification when the metric meets the alert condition and an alert is triggered.</para>
        /// <remarks>
        /// <para>This feature is the same as the Label feature in Prometheus alerts.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<PutResourceMetricRuleRequestLabels> Labels { get; set; }
        public class PutResourceMetricRuleRequestLabels : TeaModel {
            /// <summary>
            /// <para>The label key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagKey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The label value.</para>
            /// <remarks>
            /// <para>The label value supports template parameters. The template parameters are replaced with the actual label values.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the metric. For more information about how to query the name of a metric, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service metrics</a>.</para>
        /// <remarks>
        /// <para>When you create a Prometheus alert rule for CloudMonitor, this parameter specifies the name of the metric repository. For more information about how to obtain the name of a metric repository, see <a href="https://help.aliyun.com/document_detail/428880.html">DescribeHybridMonitorNamespaceList</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_total</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The data namespace of the Alibaba Cloud service. For more information about how to query the data namespace of an Alibaba Cloud service, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service metrics</a>.</para>
        /// <remarks>
        /// <para>When you create a Prometheus alert rule for CloudMonitor, you must configure this parameter to <c>acs_prometheus</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The action to take when no monitoring data is found. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>KEEP_LAST_STATE (default): No action is taken.</description></item>
        /// <item><description>INSUFFICIENT_DATA: The alert content indicates that no data is found.</description></item>
        /// <item><description>OK: The status is normal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KEEP_LAST_STATE</para>
        /// </summary>
        [NameInMap("NoDataPolicy")]
        [Validation(Required=false)]
        public string NoDataPolicy { get; set; }

        /// <summary>
        /// <para>The time range during which the alert rule is inactive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00-06:00</para>
        /// </summary>
        [NameInMap("NoEffectiveInterval")]
        [Validation(Required=false)]
        public string NoEffectiveInterval { get; set; }

        /// <summary>
        /// <para>The statistical epoch of the metric. Unit: seconds. The default value is the original reporting epoch of the metric.</para>
        /// <remarks>
        /// <para>For more information about how to query the statistical epoch of a metric, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service metrics</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The Prometheus alert.</para>
        /// <remarks>
        /// <para>You need to configure this parameter only when you create a Prometheus alert rule for Hybrid Cloud Monitoring.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Prometheus")]
        [Validation(Required=false)]
        public PutResourceMetricRuleRequestPrometheus Prometheus { get; set; }
        public class PutResourceMetricRuleRequestPrometheus : TeaModel {
            /// <summary>
            /// <para>The annotations that are rendered with their keys and values during a Prometheus alert to help you understand the metric or alert rule.</para>
            /// <remarks>
            /// <para>This feature is equivalent to the Annotation feature in Prometheus.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<PutResourceMetricRuleRequestPrometheusAnnotations> Annotations { get; set; }
            public class PutResourceMetricRuleRequestPrometheusAnnotations : TeaModel {
                /// <summary>
                /// <para>The annotation key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>summary</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The annotation value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{{ $labels.instance }} CPU usage above 10% {current value: {{ humanizePercentage $value }} }</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The alert level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CRITICAL: critical.</description></item>
            /// <item><description>WARN: warning.</description></item>
            /// <item><description>INFO: info.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CRITICAL</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The PromQL query statement.</para>
            /// <remarks>
            /// <para>The data obtained by using the PromQL query statement is used as the alert data. You must include the alert threshold in this statement.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cpuUsage{instanceId=&quot;xxxx&quot;}[1m]&gt;90</para>
            /// </summary>
            [NameInMap("PromQL")]
            [Validation(Required=false)]
            public string PromQL { get; set; }

            /// <summary>
            /// <para>The number of times that the alert condition must be met before an alert notification is sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

        }

        /// <summary>
        /// <para>The resource information. Examples: <c>[{&quot;instanceId&quot;:&quot;i-uf6j91r34rnwawoo****&quot;}]</c> and <c>[{&quot;userId&quot;:&quot;100931896542****&quot;}]</c>.</para>
        /// <para>For more information about the dimensions supported by resource information, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service metrics</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;instanceId&quot;:&quot;i-uf6j91r34rnwawoo****&quot;}]</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        /// <summary>
        /// <para>The ID of the alert rule.</para>
        /// <para>You can enter a new alert rule ID or use an existing alert rule ID in CloudMonitor. For more information about how to query the ID of an alert rule, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
        /// <remarks>
        /// <para>Entering a new alert rule ID indicates that a threshold-based alert rule is created.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a151cd6023eacee2f0978e03863cc1697c89508****</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The name of the alert rule.</para>
        /// <para>You can enter a new alert rule name or use an existing alert rule name in CloudMonitor. For more information about how to query the name of an alert rule, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
        /// <remarks>
        /// <para>Entering a new alert rule name indicates that a threshold-based alert rule is created.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>Specifies whether to send a recovery notification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SendOK")]
        [Validation(Required=false)]
        public bool? SendOK { get; set; }

        /// <summary>
        /// <para>The mute epoch. Unit: seconds. Default value: 86400.</para>
        /// <remarks>
        /// <para>The mute epoch refers to the interval at which to send an alert notification again if the alert does not recover to Normal after it is triggered.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public int? SilenceTime { get; set; }

        /// <summary>
        /// <para>The webhook URL to which a POST request is sent when an alert is triggered.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://alert.aliyun.com.com:8080/callback">https://alert.aliyun.com.com:8080/callback</a></para>
        /// </summary>
        [NameInMap("Webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}

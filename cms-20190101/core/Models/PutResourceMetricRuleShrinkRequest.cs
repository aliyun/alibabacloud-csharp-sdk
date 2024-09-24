// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutResourceMetricRuleShrinkRequest : TeaModel {
        [NameInMap("Escalations")]
        [Validation(Required=false)]
        public PutResourceMetricRuleShrinkRequestEscalations Escalations { get; set; }
        public class PutResourceMetricRuleShrinkRequestEscalations : TeaModel {
            [NameInMap("Critical")]
            [Validation(Required=false)]
            public PutResourceMetricRuleShrinkRequestEscalationsCritical Critical { get; set; }
            public class PutResourceMetricRuleShrinkRequestEscalationsCritical : TeaModel {
                /// <summary>
                /// <para>The operator that is used to compare the metric value with the threshold for Critical-level alerts. Valid value:</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold</description></item>
                /// <item><description>GreaterThanThreshold: greater than the threshold</description></item>
                /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold</description></item>
                /// <item><description>LessThanThreshold: less than the threshold</description></item>
                /// <item><description>NotEqualToThreshold: not equal to the threshold</description></item>
                /// <item><description>EqualToThreshold: equal to the threshold</description></item>
                /// <item><description>GreaterThanYesterday: greater than the metric value at the same time yesterday</description></item>
                /// <item><description>LessThanYesterday: less than the metric value at the same time yesterday</description></item>
                /// <item><description>GreaterThanLastWeek: greater than the metric value at the same time last week</description></item>
                /// <item><description>LessThanLastWeek: less than the metric value at the same time last week</description></item>
                /// <item><description>GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle</description></item>
                /// <item><description>LessThanLastPeriod: less than the metric value in the last monitoring cycle</description></item>
                /// </list>
                /// <remarks>
                /// <para> You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The statistical methods for Critical-level alerts.</para>
                /// <para>The value of this parameter is determined by the <c>Statistics</c> column corresponding to the <c>MetricName</c> parameter of the specified cloud service. The value of this parameter can be Maximum, Minimum, or Average. For more information about how to obtain the value of this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
                /// <remarks>
                /// <para> You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>The threshold for Critical-level alerts.</para>
                /// <remarks>
                /// <para> You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// <para>The consecutive number of times for which the metric value meets the alert condition before a Critical-level alert is triggered.</para>
                /// <remarks>
                /// <para> You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
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
            public PutResourceMetricRuleShrinkRequestEscalationsInfo Info { get; set; }
            public class PutResourceMetricRuleShrinkRequestEscalationsInfo : TeaModel {
                /// <summary>
                /// <para>The operator that is used to compare the metric value with the threshold for Info-level alerts. Valid value:</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold</description></item>
                /// <item><description>GreaterThanThreshold: greater than the threshold</description></item>
                /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold</description></item>
                /// <item><description>LessThanThreshold: less than the threshold</description></item>
                /// <item><description>NotEqualToThreshold: not equal to the threshold</description></item>
                /// <item><description>EqualToThreshold: equal to the threshold</description></item>
                /// <item><description>GreaterThanYesterday: greater than the metric value at the same time yesterday</description></item>
                /// <item><description>LessThanYesterday: less than the metric value at the same time yesterday</description></item>
                /// <item><description>GreaterThanLastWeek: greater than the metric value at the same time last week</description></item>
                /// <item><description>LessThanLastWeek: less than the metric value at the same time last week</description></item>
                /// <item><description>GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle</description></item>
                /// <item><description>LessThanLastPeriod: less than the metric value in the last monitoring cycle</description></item>
                /// </list>
                /// <remarks>
                /// <para> You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The statistical methods for Info-level alerts.</para>
                /// <para>The value of this parameter is determined by the <c>Statistics</c> column corresponding to the <c>MetricName</c> parameter of the specified cloud service. The value of this parameter can be Maximum, Minimum, or Average. For more information about how to obtain the value of this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
                /// <remarks>
                /// <para> You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>The threshold for Info-level alerts.</para>
                /// <remarks>
                /// <para> You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// <para>The consecutive number of times for which the metric value meets the alert condition before an Info-level alert is triggered.</para>
                /// <remarks>
                /// <para> You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
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
            public PutResourceMetricRuleShrinkRequestEscalationsWarn Warn { get; set; }
            public class PutResourceMetricRuleShrinkRequestEscalationsWarn : TeaModel {
                /// <summary>
                /// <para>The operator that is used to compare the metric value with the threshold for Warn-level alerts. Valid value:</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold</description></item>
                /// <item><description>GreaterThanThreshold: greater than the threshold</description></item>
                /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold</description></item>
                /// <item><description>LessThanThreshold: less than the threshold</description></item>
                /// <item><description>NotEqualToThreshold: not equal to the threshold</description></item>
                /// <item><description>EqualToThreshold: equal to the threshold</description></item>
                /// <item><description>GreaterThanYesterday: greater than the metric value at the same time yesterday</description></item>
                /// <item><description>LessThanYesterday: less than the metric value at the same time yesterday</description></item>
                /// <item><description>GreaterThanLastWeek: greater than the metric value at the same time last week</description></item>
                /// <item><description>LessThanLastWeek: less than the metric value at the same time last week</description></item>
                /// <item><description>GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle</description></item>
                /// <item><description>LessThanLastPeriod: less than the metric value in the last monitoring cycle</description></item>
                /// </list>
                /// <remarks>
                /// <para> You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The statistical methods for Warn-level alerts.</para>
                /// <para>The value of this parameter is determined by the <c>Statistics</c> column corresponding to the <c>MetricName</c> parameter of the specified cloud service. The value of this parameter can be Maximum, Minimum, or Average. For more information about how to obtain the value of this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
                /// <remarks>
                /// <para> You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>The threshold for Warn-level alerts.</para>
                /// <remarks>
                /// <para> You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// <para>The consecutive number of times for which the metric value meets the alert condition before a Warn-level alert is triggered.</para>
                /// <remarks>
                /// <para> You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
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
        /// <para>The trigger conditions for multiple metrics.</para>
        /// <remarks>
        /// <para> The trigger conditions for a single metric and multiple metrics are mutually exclusive. You cannot specify trigger conditions for a single metric and multiple metrics at the same time.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CompositeExpression")]
        [Validation(Required=false)]
        public string CompositeExpressionShrink { get; set; }

        /// <summary>
        /// <para>The alert contact groups. Alert notifications are sent to the alert contacts in the alert contact group.</para>
        /// <remarks>
        /// <para> An alert contact group can contain one or more alert contacts. For information about how to create alert contacts and alert contact groups, see <a href="https://help.aliyun.com/document_detail/114923.html">PutContact</a> and <a href="https://help.aliyun.com/document_detail/114929.html">PutContactGroup</a>.</para>
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
        /// <para>The period of time during which the alert rule is effective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00-23:59</para>
        /// </summary>
        [NameInMap("EffectiveInterval")]
        [Validation(Required=false)]
        public string EffectiveInterval { get; set; }

        /// <summary>
        /// <para>The subject of the alert notification email.</para>
        /// </summary>
        [NameInMap("EmailSubject")]
        [Validation(Required=false)]
        public string EmailSubject { get; set; }

        /// <summary>
        /// <para>The interval at which alerts are triggered based on the alert rule. Unit: seconds.</para>
        /// <remarks>
        /// <para> For more information about how to query the statistical periods of metrics, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>If the metric meets the specified condition in the alert rule and CloudMonitor sends an alert notification, the tag is also written to the metric and displayed in the alert notification.</para>
        /// <remarks>
        /// <para> This parameter is equivalent to the Label parameter of Prometheus alerts.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<PutResourceMetricRuleShrinkRequestLabels> Labels { get; set; }
        public class PutResourceMetricRuleShrinkRequestLabels : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagKey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <remarks>
            /// <para> You can use a template parameter to specify a tag value. CloudMonitor replaces the value of the template parameter with an actual tag value.</para>
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
        /// <para>The metric name. For more information about how to query metric names, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
        /// <remarks>
        /// <para> If you create a Prometheus alert rule for Hybrid Cloud Monitoring, you must set this parameter to the name of the namespace. For more information about how to query the names of namespaces, see <a href="https://help.aliyun.com/document_detail/428880.html">DescribeHybridMonitorNamespaceList</a>.</para>
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
        /// <para>The namespace of the cloud service. For more information about how to query the namespaces of cloud services, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
        /// <remarks>
        /// <para> If you create a Prometheus alert rule for Hybrid Cloud Monitoring, you must set this parameter to <c>acs_prometheus</c>.</para>
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
        /// <para>The method that is used to handle alerts when no monitoring data is found. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>KEEP_LAST_STATE (default): No operation is performed.</description></item>
        /// <item><description>INSUFFICIENT_DATA: An alert whose content is &quot;Insufficient data&quot; is triggered.</description></item>
        /// <item><description>OK: The status is considered normal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KEEP_LAST_STATE</para>
        /// </summary>
        [NameInMap("NoDataPolicy")]
        [Validation(Required=false)]
        public string NoDataPolicy { get; set; }

        /// <summary>
        /// <para>The period of time during which the alert rule is ineffective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00-06:00</para>
        /// </summary>
        [NameInMap("NoEffectiveInterval")]
        [Validation(Required=false)]
        public string NoEffectiveInterval { get; set; }

        /// <summary>
        /// <para>The statistical period of the metric. Unit: seconds. The default value is the interval at which the monitoring data of the metric is collected.</para>
        /// <remarks>
        /// <para> For more information about how to query the statistical periods of metrics, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>Prometheus alerts.</para>
        /// <remarks>
        /// <para> This parameter is required only if you create a Prometheus alert rule for Hybrid Cloud Monitoring.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Prometheus")]
        [Validation(Required=false)]
        public string PrometheusShrink { get; set; }

        /// <summary>
        /// <para>The resource information. Examples: <c>[{&quot;instanceId&quot;:&quot;i-uf6j91r34rnwawoo****&quot;}]</c> and <c>[{&quot;userId&quot;:&quot;100931896542****&quot;}]</c>.</para>
        /// <para>For more information about the supported dimensions that are used to query resources, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;instanceId&quot;:&quot;i-uf6j91r34rnwawoo****&quot;}]</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        /// <summary>
        /// <para>The ID of the alert rule.</para>
        /// <para>You can specify a new ID or the ID of an existing alert rule. For more information about how to query the IDs of alert rules, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
        /// <remarks>
        /// <para> If you specify a new ID, a threshold-triggered alert rule is created.</para>
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
        /// <para>You can specify a new name or the name of an existing alert rule. For more information about how to query the names of alert rules, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
        /// <remarks>
        /// <para> If you specify a new name, a threshold-triggered alert rule is created.</para>
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
        /// <para>The mute period during which new alert notifications are not sent even if the trigger conditions are met. Unit: seconds. Default value: 86400.</para>
        /// <remarks>
        /// <para> If an alert is not cleared after the mute period ends, CloudMonitor resends an alert notification.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public int? SilenceTime { get; set; }

        /// <summary>
        /// <para>The callback URL to which a POST request is sent when an alert is triggered based on the alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://alert.aliyun.com.com:8080/callback">https://alert.aliyun.com.com:8080/callback</a></para>
        /// </summary>
        [NameInMap("Webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}

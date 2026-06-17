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
                /// <para>Critical级别阈值比较符。取值：</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold：大于等于。</description></item>
                /// <item><description>GreaterThanThreshold：大于。</description></item>
                /// <item><description>LessThanOrEqualToThreshold：小于等于。</description></item>
                /// <item><description>LessThanThreshold：小于。</description></item>
                /// <item><description>NotEqualToThreshold：不等于。</description></item>
                /// <item><description>EqualToThreshold：等于。</description></item>
                /// <item><description>GreaterThanYesterday：同比昨天时间上涨。</description></item>
                /// <item><description>LessThanYesterday：同比昨天时间下降。</description></item>
                /// <item><description>GreaterThanLastWeek：同比上周同一时间上涨。</description></item>
                /// <item><description>LessThanLastWeek：同比上周同一时间下降。</description></item>
                /// <item><description>GreaterThanLastPeriod：环比上周期上涨。</description></item>
                /// <item><description>LessThanLastPeriod：环比上周期下降。</description></item>
                /// </list>
                /// <remarks>
                /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>Critical级别报警统计方法。</para>
                /// <para>该参数的取值由指定云产品的<c>MetricName</c>对应的<c>Statistics</c>列决定，例如：Maximum、Minimum和Average。关于如何获取该参数的取值，请参见<a href="https://help.aliyun.com/document_detail/163515.html">云产品监控项</a>。</para>
                /// <remarks>
                /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>Critical级别报警阈值。</para>
                /// <remarks>
                /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// <para>Critical级别报警重试次数。</para>
                /// <remarks>
                /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
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
                /// <para>Info级别阈值比较符。取值：</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold：大于等于。</description></item>
                /// <item><description>GreaterThanThreshold：大于。</description></item>
                /// <item><description>LessThanOrEqualToThreshold：小于等于。</description></item>
                /// <item><description>LessThanThreshold：小于。</description></item>
                /// <item><description>NotEqualToThreshold：不等于。</description></item>
                /// <item><description>EqualToThreshold：等于。</description></item>
                /// <item><description>GreaterThanYesterday：同比昨天时间上涨。</description></item>
                /// <item><description>LessThanYesterday：同比昨天时间下降。</description></item>
                /// <item><description>GreaterThanLastWeek：同比上周同一时间上涨。</description></item>
                /// <item><description>LessThanLastWeek：同比上周同一时间下降。</description></item>
                /// <item><description>GreaterThanLastPeriod：环比上周期上涨。</description></item>
                /// <item><description>LessThanLastPeriod：环比上周期下降。</description></item>
                /// </list>
                /// <remarks>
                /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>Info级别报警统计方法。</para>
                /// <para>该参数的取值由指定云产品的<c>MetricName</c>对应的<c>Statistics</c>列决定，例如：Maximum、Minimum和Average。关于如何获取该参数的取值，请参见<a href="https://help.aliyun.com/document_detail/163515.html">云产品监控项</a>。</para>
                /// <remarks>
                /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>Info级别报警阈值。</para>
                /// <remarks>
                /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// <para>Info级别报警重试次数。</para>
                /// <remarks>
                /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
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
                /// <para>Warn级别阈值比较符。取值：</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold：大于等于。</description></item>
                /// <item><description>GreaterThanThreshold：大于。</description></item>
                /// <item><description>LessThanOrEqualToThreshold：小于等于。</description></item>
                /// <item><description>LessThanThreshold：小于。</description></item>
                /// <item><description>NotEqualToThreshold：不等于。</description></item>
                /// <item><description>EqualToThreshold：等于。</description></item>
                /// <item><description>GreaterThanYesterday：同比昨天时间上涨。</description></item>
                /// <item><description>LessThanYesterday：同比昨天时间下降。</description></item>
                /// <item><description>GreaterThanLastWeek：同比上周同一时间上涨。</description></item>
                /// <item><description>LessThanLastWeek：同比上周同一时间下降。</description></item>
                /// <item><description>GreaterThanLastPeriod：环比上周期上涨。</description></item>
                /// <item><description>LessThanLastPeriod：环比上周期下降。</description></item>
                /// </list>
                /// <remarks>
                /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>Warn级别报警统计方法。</para>
                /// <para>该参数的取值由指定云产品的<c>MetricName</c>对应的<c>Statistics</c>列决定，例如：Maximum、Minimum和Average。关于如何获取该参数的取值，请参见<a href="https://help.aliyun.com/document_detail/163515.html">云产品监控项</a>。</para>
                /// <remarks>
                /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>Warn级别报警阈值。</para>
                /// <remarks>
                /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// <para>Warn级别报警重试次数。</para>
                /// <remarks>
                /// <para>报警级别Critical（严重）、Warn（警告）或Info（信息）至少设置一个，且该报警级别中的参数Statistics、ComparisonOperator、Threshold和Times必须同时设置。</para>
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
        /// <para>Single-metric and multi-metric alert conditions are mutually exclusive and cannot be set at the same time.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CompositeExpression")]
        [Validation(Required=false)]
        public PutResourceMetricRuleRequestCompositeExpression CompositeExpression { get; set; }
        public class PutResourceMetricRuleRequestCompositeExpression : TeaModel {
            /// <summary>
            /// <para>The list of alert conditions created in standard mode.</para>
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
                /// <item><description>GreaterThanLastPeriod: greater than the value in the last period.</description></item>
                /// <item><description>LessThanLastPeriod: less than the value in the last period.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The metric name of the Alibaba Cloud service.</para>
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
                /// <item><description>$Maximum: maximum value.</description></item>
                /// <item><description>$Minimum: minimum value.</description></item>
                /// <item><description>$Average: average value.</description></item>
                /// <item><description>$Availability: active rate (typically used for site monitoring).</description></item>
                /// </list>
                /// <remarks>
                /// <para><c>$</c> is the unified prefix for metrics. For information about supported Alibaba Cloud services, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service monitoring metrics</a>.</para>
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
            /// <para>The relationship between multi-metric alert conditions. Valid values: </para>
            /// <list type="bullet">
            /// <item><description><para><c>&amp;&amp;</c>: An alert is triggered only when all metrics meet the alert conditions. An alert is triggered only when all expressions in ExpressionList evaluate to <c>true</c>.</para>
            /// </description></item>
            /// <item><description><para><c>||</c>: An alert is triggered when any metric meets the alert conditions.</para>
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
            /// <para>The alert condition created by using an expression. The following scenarios are supported:</para>
            /// <list type="bullet">
            /// <item><description>Set an alert blacklist for specific resources. For example, <c>$instanceId != \\&quot;i-io8kfvcpp7x5****\\&quot; ``&amp;&amp;`` $Average &gt; 50</c> specifies that no alert is triggered for instance <c>i-io8kfvcpp7x5****</c> even if its <c>Average</c> exceeds 50.</description></item>
            /// <item><description>Set a special alert threshold for a specific instance in the rule. For example, <c>$Average &gt; ($instanceId == \\&quot;i-io8kfvcpp7x5****\\&quot;? 80: 50)</c> specifies that an alert is triggered for instance <c>i-io8kfvcpp7x5****</c> only when its <c>Average</c> exceeds 80, while an alert is triggered for other instances when their <c>Average</c> exceeds 50.</description></item>
            /// <item><description>Limit the number of instances that exceed the threshold. For example, <c>count($Average &gt; 20) &gt; 3</c> specifies that an alert is triggered only when more than three instances have an <c>Average</c> greater than 20.</description></item>
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
            /// <item><description>INFO: information.</description></item>
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
        /// <para>An alert contact group contains one or more alert contacts. For information about how to create alert contacts and alert contact groups, see <a href="https://help.aliyun.com/document_detail/114923.html">PutContact</a> and <a href="https://help.aliyun.com/document_detail/114929.html">PutContactGroup</a>.</para>
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
        /// <para>The trigger period of the alert rule. Unit: seconds.</para>
        /// <remarks>
        /// <para>For information about how to query the statistical period of a metric, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service monitoring metrics</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The labels that are written to the metric and displayed in alert notifications when the metric meets the alert condition.</para>
        /// <remarks>
        /// <para>This feature is the same as the Label feature in Prometheus alerting.</para>
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
            /// <para>The label value supports template parameters. Template parameters are replaced with actual label values.</para>
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
        /// <para>The name of the metric. For information about how to query metric names, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service monitoring metrics</a>.</para>
        /// <remarks>
        /// <para>If you create a Prometheus alert rule for Hybrid Cloud Monitoring, this parameter specifies the name of the metric repository. For information about how to obtain the metric repository name, see <a href="https://help.aliyun.com/document_detail/428880.html">DescribeHybridMonitorNamespaceList</a>.</para>
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
        /// <para>The namespace of the Alibaba Cloud service. For information about how to query the namespace of an Alibaba Cloud service, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service monitoring metrics</a>.</para>
        /// <remarks>
        /// <para>If you create a Prometheus alert rule for Hybrid Cloud Monitoring, set this parameter to <c>acs_prometheus</c>.</para>
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
        /// <para>The processing method when no monitoring data is found. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>KEEP_LAST_STATE (default): No action is taken.</description></item>
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
        /// <para>The time range during which the alert rule is ineffective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00-06:00</para>
        /// </summary>
        [NameInMap("NoEffectiveInterval")]
        [Validation(Required=false)]
        public string NoEffectiveInterval { get; set; }

        /// <summary>
        /// <para>The statistical period of the metric. Unit: seconds. The default value is the original reporting period of the metric.</para>
        /// <remarks>
        /// <para>For information about how to query the statistical period of a metric, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service monitoring metrics</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The Prometheus alert configuration.</para>
        /// <remarks>
        /// <para>Set this parameter only when you create a Prometheus alert rule for Hybrid Cloud Monitoring.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Prometheus")]
        [Validation(Required=false)]
        public PutResourceMetricRuleRequestPrometheus Prometheus { get; set; }
        public class PutResourceMetricRuleRequestPrometheus : TeaModel {
            /// <summary>
            /// <para>The annotations for Prometheus alerting. The annotation keys and values are rendered to help you understand the metric or alert rule.</para>
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
            /// <item><description>INFO: information.</description></item>
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
            /// <para>The data obtained by the PromQL query statement is the alert data. Include the alert threshold in this statement.</para>
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
        /// <para>The resource information, such as <c>[{&quot;instanceId&quot;:&quot;i-uf6j91r34rnwawoo****&quot;}]</c> or <c>[{&quot;userId&quot;:&quot;100931896542****&quot;}]</c>.</para>
        /// <para>For information about the supported monitoring dimensions, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service monitoring metrics</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;instanceId&quot;:&quot;i-uf6j91r34rnwawoo****&quot;}]</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        /// <summary>
        /// <para>The ID of the alert rule.</para>
        /// <para>You can enter a new alert rule ID or use the ID of an existing alert rule in CloudMonitor. For information about how to query alert rule IDs, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
        /// <remarks>
        /// <para>If you enter a new alert rule ID, a threshold alert rule is created.</para>
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
        /// <para>You can enter a new alert rule name or use the name of an existing alert rule in CloudMonitor. For information about how to query alert rule names, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
        /// <remarks>
        /// <para>If you enter a new alert rule name, a threshold alert rule is created.</para>
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
        /// <para>The mute period. Unit: seconds. Default value: 86400.</para>
        /// <remarks>
        /// <para>The mute period specifies the interval at which an alert notification is re-sent if the alert does not recover to Normal.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public int? SilenceTime { get; set; }

        /// <summary>
        /// <para>The callback URL to which a POST request is sent when an alert is triggered.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://alert.aliyun.com.com:8080/callback">https://alert.aliyun.com.com:8080/callback</a></para>
        /// </summary>
        [NameInMap("Webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}

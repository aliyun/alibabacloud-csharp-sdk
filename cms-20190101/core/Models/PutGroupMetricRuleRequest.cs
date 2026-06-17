// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutGroupMetricRuleRequest : TeaModel {
        [NameInMap("Escalations")]
        [Validation(Required=false)]
        public PutGroupMetricRuleRequestEscalations Escalations { get; set; }
        public class PutGroupMetricRuleRequestEscalations : TeaModel {
            [NameInMap("Critical")]
            [Validation(Required=false)]
            public PutGroupMetricRuleRequestEscalationsCritical Critical { get; set; }
            public class PutGroupMetricRuleRequestEscalationsCritical : TeaModel {
                /// <summary>
                /// <para>Critical级别阈值比较符。取值：</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold：大于等于。</description></item>
                /// <item><description>GreaterThanThreshold：大于。</description></item>
                /// <item><description>LessThanOrEqualToThreshold：小于等于。</description></item>
                /// <item><description>LessThanThreshold：小于。</description></item>
                /// <item><description>NotEqualToThreshold：不等于。</description></item>
                /// <item><description>GreaterThanYesterday：同比昨天时间上涨。</description></item>
                /// <item><description>LessThanYesterday：同比昨天时间下降。</description></item>
                /// <item><description>GreaterThanLastWeek：同比上周同一时间上涨。</description></item>
                /// <item><description>LessThanLastWeek：同比上周同一时间下降。</description></item>
                /// <item><description>GreaterThanLastPeriod：环比上周期上涨。</description></item>
                /// <item><description>LessThanLastPeriod：环比上周期下降。</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>Critical级别报警统计方法。多个统计方法之间用半角逗号（,）分隔。</para>
                /// <para>该参数的取值由指定云产品的<c>MetricName</c>对应的<c>Statistics</c>列决定，例如：Maximum、Minimum和Average。关于如何获取该参数的取值，请参见<a href="https://help.aliyun.com/document_detail/163515.html">云产品监控项</a>。</para>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>Critical级别报警阈值。</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// <para>Critical级别报警重试次数。</para>
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
            public PutGroupMetricRuleRequestEscalationsInfo Info { get; set; }
            public class PutGroupMetricRuleRequestEscalationsInfo : TeaModel {
                /// <summary>
                /// <para>Info级别阈值比较符。取值：</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold：大于等于。</description></item>
                /// <item><description>GreaterThanThreshold：大于。</description></item>
                /// <item><description>LessThanOrEqualToThreshold：小于等于。</description></item>
                /// <item><description>LessThanThreshold：小于。</description></item>
                /// <item><description>NotEqualToThreshold：不等于。</description></item>
                /// <item><description>GreaterThanYesterday：同比昨天时间上涨。</description></item>
                /// <item><description>LessThanYesterday：同比昨天时间下降。</description></item>
                /// <item><description>GreaterThanLastWeek：同比上周同一时间上涨。</description></item>
                /// <item><description>LessThanLastWeek：同比上周同一时间下降。</description></item>
                /// <item><description>GreaterThanLastPeriod：环比上周期上涨。</description></item>
                /// <item><description>LessThanLastPeriod：环比上周期下降。</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>Info级别报警统计方法。多个统计方法之间用半角逗号（,）分隔。</para>
                /// <para>该参数的取值由指定云产品的<c>MetricName</c>对应的<c>Statistics</c>列决定，例如：Maximum、Minimum和Average。关于如何获取该参数的取值，请参见<a href="https://help.aliyun.com/document_detail/163515.html">云产品监控项</a>。</para>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>Info级别报警阈值。</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// <para>Info级别报警重试次数。</para>
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
            public PutGroupMetricRuleRequestEscalationsWarn Warn { get; set; }
            public class PutGroupMetricRuleRequestEscalationsWarn : TeaModel {
                /// <summary>
                /// <para>Warn级别阈值比较符。取值：</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold：大于等于。</description></item>
                /// <item><description>GreaterThanThreshold：大于。</description></item>
                /// <item><description>LessThanOrEqualToThreshold：小于等于。</description></item>
                /// <item><description>LessThanThreshold：小于。</description></item>
                /// <item><description>NotEqualToThreshold：不等于。</description></item>
                /// <item><description>GreaterThanYesterday：同比昨天时间上涨。</description></item>
                /// <item><description>LessThanYesterday：同比昨天时间下降。</description></item>
                /// <item><description>GreaterThanLastWeek：同比上周同一时间上涨。</description></item>
                /// <item><description>LessThanLastWeek：同比上周同一时间下降。</description></item>
                /// <item><description>GreaterThanLastPeriod：环比上周期上涨。</description></item>
                /// <item><description>LessThanLastPeriod：环比上周期下降。</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>Warn级别报警统计方法。多个统计方法之间用半角逗号（,）分隔。</para>
                /// <para>该参数的取值由指定云产品的<c>MetricName</c>对应的<c>Statistics</c>列决定，例如：Maximum、Minimum和Average。关于如何获取该参数的取值，请参见<a href="https://help.aliyun.com/document_detail/163515.html">云产品监控项</a>。</para>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>Warn级别报警阈值。</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// <para>Warn级别报警重试次数。</para>
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
        /// <para>The abbreviation of the Alibaba Cloud service name.</para>
        /// <para>For information about how to obtain the abbreviation, see the <c>metricCategory</c> tag in the <c>Labels</c> response parameter of the <a href="https://help.aliyun.com/document_detail/114916.html">DescribeProjectMeta</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The alert contact group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_Group</para>
        /// </summary>
        [NameInMap("ContactGroups")]
        [Validation(Required=false)]
        public string ContactGroups { get; set; }

        /// <summary>
        /// <para>The first-level dimensions of the alert rule in the application group.</para>
        /// <para>Format: a collection of <c>key:value</c> pairs, such as <c>{&quot;userId&quot;:&quot;120886317861****&quot;}</c> and <c>{&quot;instanceId&quot;:&quot;i-m5e1qg6uo38rztr4****&quot;}</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;instanceId&quot;:&quot;i-m5e1qg6uo38rztr4****&quot;}]</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// <para>The effective period during which the alert rule takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05:31-23:59</para>
        /// </summary>
        [NameInMap("EffectiveInterval")]
        [Validation(Required=false)]
        public string EffectiveInterval { get; set; }

        /// <summary>
        /// <para>The subject of the alert email.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS instance</para>
        /// </summary>
        [NameInMap("EmailSubject")]
        [Validation(Required=false)]
        public string EmailSubject { get; set; }

        /// <summary>
        /// <para>The second-level or third-level dimensions of the alert rule in the application group.</para>
        /// <para>Format: a collection of <c>key:value</c> pairs, such as <c>port:80</c> and <c>/dev/xvda:d-m5e6yphgzn3aprwu****</c>.</para>
        /// <para>If the first-level dimension is <c>{&quot;instanceId&quot;:&quot;i-m5e1qg6uo38rztr4****&quot;}</c>, the second-level dimension is a cloud disk of the instance: <c>{&quot;/dev/xvda&quot;:&quot;d-m5e6yphgzn3aprwu****&quot;}</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;/dev/xvda&quot;:&quot;d-m5e6yphgzn3aprwu****&quot;}</para>
        /// </summary>
        [NameInMap("ExtraDimensionJson")]
        [Validation(Required=false)]
        public string ExtraDimensionJson { get; set; }

        /// <summary>
        /// <para>The application group ID.</para>
        /// <para>For information about how to obtain the application group ID, see <a href="https://help.aliyun.com/document_detail/115032.html">DescribeMonitorGroups</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17285****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The detection period of the alert rule. Unit: seconds.</para>
        /// <remarks>
        /// <para>Keep the detection period consistent with the data reporting period. If the detection period is shorter than the data reporting period, alerts may not be triggered due to insufficient data.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The tags of the alert rule.</para>
        /// <para>Tags are included in alert notifications.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<PutGroupMetricRuleRequestLabels> Labels { get; set; }
        public class PutGroupMetricRuleRequestLabels : TeaModel {
            /// <summary>
            /// <para>The tag key of the alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The metric name.</para>
        /// <para>For information about how to obtain the metric name, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a> or <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_total</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The namespace of the Alibaba Cloud service.</para>
        /// <para>For information about how to obtain the namespace, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a> or <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring</a>.</para>
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
        /// <item><description>KEEP_LAST_STATE (default): No action is performed.</description></item>
        /// <item><description>INSUFFICIENT_DATA: An alert whose content is &quot;Insufficient Data&quot; is triggered.</description></item>
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
        /// <para>00:00-05:30</para>
        /// </summary>
        [NameInMap("NoEffectiveInterval")]
        [Validation(Required=false)]
        public string NoEffectiveInterval { get; set; }

        /// <summary>
        /// <para>The advanced settings.</para>
        /// <para>Format: {&quot;key1&quot;:&quot;value1&quot;,&quot;key2&quot;:&quot;value2&quot;}. Example: {&quot;NotSendOK&quot;:true}. This specifies whether to send a notification when the alert is cleared. The key is NotSendOK, and the value is true (do not send) or false (send, which is the default).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotSendOK&quot;:true}</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>The reporting period of monitoring data.</para>
        /// <para>The value of <c>Period</c> must be 60 or a multiple of 60. Unit: seconds. Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The alert rule ID.</para>
        /// <list type="bullet">
        /// <item><description><para>To create an alert rule for the application group, enter an alert rule ID.</para>
        /// </description></item>
        /// <item><description><para>To modify a specified alert rule in the application group, obtain the alert rule ID. For information about how to obtain the alert rule ID, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The alert rule name.</para>
        /// <list type="bullet">
        /// <item><description><para>To create an alert rule for the application group, enter an alert rule name.</para>
        /// </description></item>
        /// <item><description><para>To modify a specified alert rule in the application group, obtain the alert rule name. For information about how to obtain the alert rule name, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Rule_01</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The mute period.</para>
        /// <para>Unit: seconds. Default value: 86400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public int? SilenceTime { get; set; }

        /// <summary>
        /// <para>The callback URL to which a request is sent when an alert is triggered.</para>
        /// <para>Enter a publicly accessible URL. CloudMonitor sends a POST request to push alert information to this URL. Only the HTTP protocol is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}

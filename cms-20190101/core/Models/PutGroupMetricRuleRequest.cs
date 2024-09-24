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
                /// <para>The operator that is used to compare the metric value with the threshold for Critical-level alerts. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold</description></item>
                /// <item><description>GreaterThanThreshold: greater than the threshold</description></item>
                /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold</description></item>
                /// <item><description>LessThanThreshold: less than the threshold</description></item>
                /// <item><description>NotEqualToThreshold: not equal to the threshold</description></item>
                /// <item><description>GreaterThanYesterday: greater than the metric value at the same time yesterday</description></item>
                /// <item><description>LessThanYesterday: less than the metric value at the same time yesterday</description></item>
                /// <item><description>GreaterThanLastWeek: greater than the metric value at the same time last week</description></item>
                /// <item><description>LessThanLastWeek: less than the metric value at the same time last week</description></item>
                /// <item><description>GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle</description></item>
                /// <item><description>LessThanLastPeriod: less than the metric value in the last monitoring cycle</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The statistical methods for Critical-level alerts. Separate multiple statistical methods with commas (,).</para>
                /// <para>The value of this parameter is determined by the <c>Statistics</c> column corresponding to the <c>MetricName</c> parameter of the specified cloud service. The value of this parameter can be Maximum, Minimum, or Average. For more information about how to obtain the value of this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>The threshold for Critical-level alerts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// <para>The consecutive number of times for which the metric value meets the alert condition before a Critical-level alert is triggered.</para>
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
                /// <para>The operator that is used to compare the metric value with the threshold for Info-level alerts. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold</description></item>
                /// <item><description>GreaterThanThreshold: greater than the threshold</description></item>
                /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold</description></item>
                /// <item><description>LessThanThreshold: less than the threshold</description></item>
                /// <item><description>NotEqualToThreshold: not equal to the threshold</description></item>
                /// <item><description>GreaterThanYesterday: greater than the metric value at the same time yesterday</description></item>
                /// <item><description>LessThanYesterday: less than the metric value at the same time yesterday</description></item>
                /// <item><description>GreaterThanLastWeek: greater than the metric value at the same time last week</description></item>
                /// <item><description>LessThanLastWeek: less than the metric value at the same time last week</description></item>
                /// <item><description>GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle</description></item>
                /// <item><description>LessThanLastPeriod: less than the metric value in the last monitoring cycle</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The statistical methods for Info-level alerts. Separate multiple statistical methods with commas (,).</para>
                /// <para>The value of this parameter is determined by the <c>Statistics</c> column corresponding to the <c>MetricName</c> parameter of the specified cloud service. The value of this parameter can be Maximum, Minimum, or Average. For more information about how to obtain the value of this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>The threshold for Info-level alerts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// <para>The consecutive number of times for which the metric value meets the alert condition before an Info-level alert is triggered.</para>
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
                /// <para>The operator that is used to compare the metric value with the threshold for Warn-level alerts. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold</description></item>
                /// <item><description>GreaterThanThreshold: greater than the threshold</description></item>
                /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold</description></item>
                /// <item><description>LessThanThreshold: less than the threshold</description></item>
                /// <item><description>NotEqualToThreshold: not equal to the threshold</description></item>
                /// <item><description>GreaterThanYesterday: greater than the metric value at the same time yesterday</description></item>
                /// <item><description>LessThanYesterday: less than the metric value at the same time yesterday</description></item>
                /// <item><description>GreaterThanLastWeek: greater than the metric value at the same time last week</description></item>
                /// <item><description>LessThanLastWeek: less than the metric value at the same time last week</description></item>
                /// <item><description>GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle</description></item>
                /// <item><description>LessThanLastPeriod: less than the metric value in the last monitoring cycle</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The statistical methods for Warn-level alerts. Separate multiple statistical methods with commas (,).</para>
                /// <para>The value of this parameter is determined by the <c>Statistics</c> column corresponding to the <c>MetricName</c> parameter of the specified cloud service. The value of this parameter can be Maximum, Minimum, or Average. For more information about how to obtain the value of this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>The threshold for Warn-level alerts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// <para>The consecutive number of times for which the metric value meets the alert condition before a Warn-level alert is triggered.</para>
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
        /// <para>The abbreviation of the cloud service name.</para>
        /// <para>For more information about how to obtain the abbreviation of a cloud service name, see <c>metricCategory</c> in the response parameter <c>Labels</c> of the <a href="https://help.aliyun.com/document_detail/114916.html">DescribeProjectMeta</a> operation.</para>
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
        /// <para>The first-level dimension of the alert rule in the application group.</para>
        /// <para>Set the value to a set of key-value pairs, for example, <c>userId:120886317861****</c> or <c>instanceId:i-m5e1qg6uo38rztr4****</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;instanceId&quot;:&quot;i-m5e1qg6uo38rztr4****&quot;}]</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// <para>The time period during which the alert rule is effective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05:31-23:59</para>
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
        /// <para>The second-level or third-level dimension of the alert rule in the application group.</para>
        /// <para>Set the value to a set of key-value pairs, for example, <c>port:80</c> or <c>/dev/xvda:d-m5e6yphgzn3aprwu****</c>.</para>
        /// <para>If the first-level dimension of the alert rule is <c>instanceId:i-m5e1qg6uo38rztr4****</c>, its second-level dimension is the <c>/dev/xvda:d-m5e6yphgzn3aprwu****</c> disk in the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;/dev/xvda&quot;:&quot;d-m5e6yphgzn3aprwu****&quot;}</para>
        /// </summary>
        [NameInMap("ExtraDimensionJson")]
        [Validation(Required=false)]
        public string ExtraDimensionJson { get; set; }

        /// <summary>
        /// <para>The application group ID.</para>
        /// <para>For more information about how to obtain the ID of an application group, see <a href="https://help.aliyun.com/document_detail/115032.html">DescribeMonitorGroups</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17285****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The interval at which CloudMonitor checks whether the alert rule is triggered. Unit: seconds.</para>
        /// <remarks>
        /// <para> We recommend that you set the interval to the data aggregation period. If the interval is shorter than the data aggregation period, alerts cannot be triggered due to insufficient data.</para>
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
        /// <para>The specified tag is contained in alert notifications.</para>
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
        /// <para>For more information about how to obtain the name of a metric, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a> or <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_total</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The namespace of the cloud service.</para>
        /// <para>For more information about how to obtain the namespace of a cloud service, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a> or <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The method that is used to handle alerts when no monitoring data is found. Valid values:</para>
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
        /// <para>The time period during which the alert rule is ineffective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00-05:30</para>
        /// </summary>
        [NameInMap("NoEffectiveInterval")]
        [Validation(Required=false)]
        public string NoEffectiveInterval { get; set; }

        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>The aggregation period of the metric data.</para>
        /// <para>Set the <c>Period</c> parameter to an integral multiple of 60. Unit: seconds. Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The ID of the alert rule.</para>
        /// <list type="bullet">
        /// <item><description>When you create an alert rule for the application group, enter the ID of the alert rule.</description></item>
        /// <item><description>When you modify a specified alert rule in the application group, you must obtain the ID of the alert rule. For information about how to obtain the ID of an alert rule, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</description></item>
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
        /// <para>The name of the alert rule.</para>
        /// <list type="bullet">
        /// <item><description>When you create an alert rule for the application group, enter the name of the alert rule.</description></item>
        /// <item><description>When you modify a specified alert rule in the application group, you must obtain the name of the alert rule. For more information about how to obtain the name of an alert rule, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</description></item>
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
        /// <para>The mute period during which new alerts are not sent even if the trigger conditions are met.</para>
        /// <para>Unit: seconds. Default value: 86400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public int? SilenceTime { get; set; }

        /// <summary>
        /// <para>The callback URL.</para>
        /// <para>The callback URL must be accessible over the Internet. CloudMonitor sends a POST request to push an alert notification to the callback URL that you specify. Only HTTP requests are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}

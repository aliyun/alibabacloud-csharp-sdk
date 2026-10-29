// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateGroupMetricRulesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application group.</para>
        /// <para>For information about how to obtain the application group ID, see <a href="https://help.aliyun.com/document_detail/115032.html">DescribeMonitorGroups</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3607****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The list of metric-based alert rules for the application group.</para>
        /// </summary>
        [NameInMap("GroupMetricRules")]
        [Validation(Required=false)]
        public List<CreateGroupMetricRulesRequestGroupMetricRules> GroupMetricRules { get; set; }
        public class CreateGroupMetricRulesRequestGroupMetricRules : TeaModel {
            [NameInMap("Escalations")]
            [Validation(Required=false)]
            public CreateGroupMetricRulesRequestGroupMetricRulesEscalations Escalations { get; set; }
            public class CreateGroupMetricRulesRequestGroupMetricRulesEscalations : TeaModel {
                [NameInMap("Critical")]
                [Validation(Required=false)]
                public CreateGroupMetricRulesRequestGroupMetricRulesEscalationsCritical Critical { get; set; }
                public class CreateGroupMetricRulesRequestGroupMetricRulesEscalationsCritical : TeaModel {
                    /// <summary>
                    /// <para>The comparison operator for Critical-level alerts. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold. </description></item>
                    /// <item><description>GreaterThanThreshold: greater than the threshold. </description></item>
                    /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold. </description></item>
                    /// <item><description>LessThanThreshold: less than the threshold. </description></item>
                    /// <item><description>NotEqualToThreshold: not equal to the threshold. </description></item>
                    /// <item><description>GreaterThanYesterday: greater than the value at the same time yesterday. </description></item>
                    /// <item><description>LessThanYesterday: less than the value at the same time yesterday. </description></item>
                    /// <item><description>GreaterThanLastWeek: greater than the value at the same time last week. </description></item>
                    /// <item><description>LessThanLastWeek: less than the value at the same time last week. </description></item>
                    /// <item><description>GreaterThanLastPeriod: greater than the value in the last period. </description></item>
                    /// <item><description>LessThanLastPeriod: less than the value in the last period.</description></item>
                    /// </list>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>Set at least one of the alert severity levels Critical, Warn, or Info. For each specified alert severity level, you must set all of the following parameters: Statistics, ComparisonOperator, Threshold, and Times.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GreaterThanOrEqualToThreshold</para>
                    /// </summary>
                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public string N { get; set; }

                    [NameInMap("PreCondition")]
                    [Validation(Required=false)]
                    public string PreCondition { get; set; }

                    /// <summary>
                    /// <para>The statistical method for Critical-level alerts.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <para>The valid values of this parameter are determined by the <c>Statistics</c> column corresponding to the <c>MetricName</c> of the specified Alibaba Cloud service, such as Maximum, Minimum, and Average. For information about how to obtain the valid values, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring</a>.</para>
                    /// <remarks>
                    /// <para>Set at least one of the alert severity levels Critical, Warn, or Info. For each specified alert severity level, you must set all of the following parameters: Statistics, ComparisonOperator, Threshold, and Times.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Average</para>
                    /// </summary>
                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    /// <summary>
                    /// <para>The threshold that triggers Critical-level alert notifications.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>Set at least one of the alert severity levels Critical, Warn, or Info. For each specified alert severity level, you must set all of the following parameters: Statistics, ComparisonOperator, Threshold, and Times.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>90</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    /// <summary>
                    /// <para>The number of times that the monitoring metric must reach the alert threshold before a Critical-level alert notification is sent.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>Settings for at least one of the alert severity levels Critical, Warn (warning), or Info must be specified. For each specified alert severity level, you must set all of the following parameters: Statistics, ComparisonOperator, Threshold, and Times.</para>
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
                public CreateGroupMetricRulesRequestGroupMetricRulesEscalationsInfo Info { get; set; }
                public class CreateGroupMetricRulesRequestGroupMetricRulesEscalationsInfo : TeaModel {
                    /// <summary>
                    /// <para>The comparison operator for Info-level alerts. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold. </description></item>
                    /// <item><description>GreaterThanThreshold: greater than the threshold. </description></item>
                    /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold. </description></item>
                    /// <item><description>LessThanThreshold: less than the threshold. </description></item>
                    /// <item><description>NotEqualToThreshold: not equal to the threshold. </description></item>
                    /// <item><description>GreaterThanYesterday: greater than the value at the same time yesterday. </description></item>
                    /// <item><description>LessThanYesterday: less than the value at the same time yesterday. </description></item>
                    /// <item><description>GreaterThanLastWeek: greater than the value at the same time last week. </description></item>
                    /// <item><description>LessThanLastWeek: less than the value at the same time last week. </description></item>
                    /// <item><description>GreaterThanLastPeriod: greater than the value in the last period. </description></item>
                    /// <item><description>LessThanLastPeriod: less than the value in the last period.</description></item>
                    /// </list>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>Set at least one of the alert severity levels Critical, Warn, or Info. For each specified alert severity level, you must set all of the following parameters: Statistics, ComparisonOperator, Threshold, and Times.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GreaterThanOrEqualToThreshold</para>
                    /// </summary>
                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public string N { get; set; }

                    [NameInMap("PreCondition")]
                    [Validation(Required=false)]
                    public string PreCondition { get; set; }

                    /// <summary>
                    /// <para>The statistical method for Info-level alerts.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <para>The valid values of this parameter are determined by the <c>Statistics</c> column corresponding to the <c>MetricName</c> of the specified Alibaba Cloud service, such as Maximum, Minimum, and Average. For information about how to obtain the valid values, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring</a>.</para>
                    /// <remarks>
                    /// <para>Set at least one of the alert severity levels Critical, Warn, or Info. For each specified alert severity level, you must set all of the following parameters: Statistics, ComparisonOperator, Threshold, and Times.</para>
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
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>Set at least one of the alert severity levels Critical, Warn, or Info. For each specified alert severity level, you must set all of the following parameters: Statistics, ComparisonOperator, Threshold, and Times.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    /// <summary>
                    /// <para>The number of times that the monitoring metric must reach the alert threshold before an Info-level alert notification is sent.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>Settings for at least one of the alert severity levels Critical, Warn (warning), or Info must be specified. For each specified alert severity level, you must set all of the following parameters: Statistics, ComparisonOperator, Threshold, and Times.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }

                [NameInMap("Warn")]
                [Validation(Required=false)]
                public CreateGroupMetricRulesRequestGroupMetricRulesEscalationsWarn Warn { get; set; }
                public class CreateGroupMetricRulesRequestGroupMetricRulesEscalationsWarn : TeaModel {
                    /// <summary>
                    /// <para>The comparison operator for Warn-level alerts. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold. </description></item>
                    /// <item><description>GreaterThanThreshold: greater than the threshold. </description></item>
                    /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold. </description></item>
                    /// <item><description>LessThanThreshold: less than the threshold. </description></item>
                    /// <item><description>NotEqualToThreshold: not equal to the threshold. </description></item>
                    /// <item><description>GreaterThanYesterday: greater than the value at the same time yesterday. </description></item>
                    /// <item><description>LessThanYesterday: less than the value at the same time yesterday. </description></item>
                    /// <item><description>GreaterThanLastWeek: greater than the value at the same time last week. </description></item>
                    /// <item><description>LessThanLastWeek: less than the value at the same time last week. </description></item>
                    /// <item><description>GreaterThanLastPeriod: greater than the value in the last period. </description></item>
                    /// <item><description>LessThanLastPeriod: less than the value in the last period.</description></item>
                    /// </list>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>Set at least one of the alert severity levels Critical, Warn, or Info. For each specified alert severity level, you must set all of the following parameters: Statistics, ComparisonOperator, Threshold, and Times.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GreaterThanOrEqualToThreshold</para>
                    /// </summary>
                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public string N { get; set; }

                    [NameInMap("PreCondition")]
                    [Validation(Required=false)]
                    public string PreCondition { get; set; }

                    /// <summary>
                    /// <para>The statistical method for Warn-level alerts.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <para>The valid values of this parameter are determined by the <c>Statistics</c> column corresponding to the <c>MetricName</c> of the specified Alibaba Cloud service, such as Maximum, Minimum, and Average. For information about how to obtain the valid values, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring</a>.</para>
                    /// <remarks>
                    /// <para>Set at least one of the alert severity levels Critical, Warn, or Info. For each specified alert severity level, you must set all of the following parameters: Statistics, ComparisonOperator, Threshold, and Times.</para>
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
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>Set at least one of the alert severity levels Critical, Warn, or Info. For each specified alert severity level, you must set all of the following parameters: Statistics, ComparisonOperator, Threshold, and Times.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    /// <summary>
                    /// <para>The number of times that the monitoring metric must reach the alert threshold before a Warn-level alert notification is sent.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>Settings for at least one of the alert severity levels Critical, Warn (warning), or Info must be specified. For each specified alert severity level, you must set all of the following parameters: Statistics, ComparisonOperator, Threshold, and Times.</para>
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
            /// <para>The abbreviation of the Alibaba Cloud service name.</para>
            /// <para>Valid values of N: 1 to 200.</para>
            /// <para>For information about how to obtain the abbreviation, see the <c>metricCategory</c> tag in the <c>Labels</c> response parameter of the <a href="https://help.aliyun.com/document_detail/114916.html">DescribeProjectMeta</a> operation.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The alert contact group.</para>
            /// <para>Valid values of N: 1 to 200.</para>
            /// <para>For information about how to obtain the alert contact group, see <a href="https://help.aliyun.com/document_detail/114922.html">DescribeContactGroupList</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_Group</para>
            /// </summary>
            [NameInMap("ContactGroups")]
            [Validation(Required=false)]
            public string ContactGroups { get; set; }

            /// <summary>
            /// <para>The monitoring dimensions of the specified resource.</para>
            /// <para>The value is a collection of <c>key:value</c> pairs, such as <c>{&quot;userId&quot;:&quot;120886317861****&quot;}</c> and <c>{&quot;instanceId&quot;:&quot;i-2ze2d6j5uhg20x47****&quot;}</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;instanceId&quot;:&quot;i-m5e1qg6uo38rztr4****&quot;}]</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public string Dimensions { get; set; }

            /// <summary>
            /// <para>The effective period of the alert rule. Valid values of N: 1 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>05:31-23:59</para>
            /// </summary>
            [NameInMap("EffectiveInterval")]
            [Validation(Required=false)]
            public string EffectiveInterval { get; set; }

            /// <summary>
            /// <para>The subject of the alert notification email.</para>
            /// <para>Valid values of N: 1 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS instance</para>
            /// </summary>
            [NameInMap("EmailSubject")]
            [Validation(Required=false)]
            public string EmailSubject { get; set; }

            /// <summary>
            /// <para>The detection period of the alert rule.</para>
            /// <para>Valid values of N: 1 to 200.</para>
            /// <para>Unit: seconds. The default value is the minimum reporting frequency of the metric.</para>
            /// <remarks>
            /// <para>Keep the detection period of the alert rule consistent with the data reporting period. If the detection period is shorter than the data reporting period, alerts may not be triggered due to insufficient data.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public string Interval { get; set; }

            /// <summary>
            /// <para>The tag keys of the alert rule.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<CreateGroupMetricRulesRequestGroupMetricRulesLabels> Labels { get; set; }
            public class CreateGroupMetricRulesRequestGroupMetricRulesLabels : TeaModel {
                /// <summary>
                /// <para>The tag key of the alert rule. The tag is included in alert notifications.</para>
                /// <para>Valid values of N: 1 to 200.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the alert rule. The tag is included in alert notifications.</para>
                /// <para>Valid values of N: 1 to 200.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The name of the metric.</para>
            /// <para>Valid values of N: 1 to 200.</para>
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
            /// <para>Valid values of N: 1 to 200.</para>
            /// <para>For information about how to obtain the namespace of an Alibaba Cloud service, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a> or <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring</a>.</para>
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
            /// <para>Valid values of N: 1 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KEEP_LAST_STATE</para>
            /// </summary>
            [NameInMap("NoDataPolicy")]
            [Validation(Required=false)]
            public string NoDataPolicy { get; set; }

            /// <summary>
            /// <para>The time period during which the alert rule is ineffective. Valid values of N: 1 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00-05:30</para>
            /// </summary>
            [NameInMap("NoEffectiveInterval")]
            [Validation(Required=false)]
            public string NoEffectiveInterval { get; set; }

            /// <summary>
            /// <para>The advanced settings.</para>
            /// <para>Format: {&quot;key1&quot;:&quot;value1&quot;,&quot;key2&quot;:&quot;value2&quot;}. For example, {&quot;NotSendOK&quot;:true} specifies whether to send an alert recovery notification. The key is NotSendOK, and the value is true (do not send) or false (send, which is the default).</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;NotSendOK&quot;: true
            /// }</para>
            /// </summary>
            [NameInMap("Options")]
            [Validation(Required=false)]
            public string Options { get; set; }

            /// <summary>
            /// <para>The reporting period of monitoring data.</para>
            /// <para>Valid values of N: 1 to 200. </para>
            /// <para>The value of <c>Period</c> must be 60 or a multiple of 60. Unit: seconds. Default value: 300.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            /// <summary>
            /// <para>The ID of the alert rule.</para>
            /// <para>Valid values of N: 1 to 200.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>456789</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The name of the alert rule.</para>
            /// <para>Valid values of N: 1 to 200.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_Rule1</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The mute period of the alert notification. Valid values of N: 1 to 200.</para>
            /// <para>Unit: seconds. Default value: 86400. Minimum value: 3600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public int? SilenceTime { get; set; }

            /// <summary>
            /// <para>The callback URL to which an alert notification is sent. Valid values of N: 1 to 200.</para>
            /// <para>Specify a publicly accessible URL. CloudMonitor sends a POST request to push alert information to this URL. Only the HTTP protocol is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

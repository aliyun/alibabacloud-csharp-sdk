// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutResourceMetricRulesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The system only prechecks the request and does not bind a security group to the instance. The system checks whether required parameters are specified, the request format, and service limits. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): The system sends a normal request. After the request passes the precheck, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The list of threshold alert rules.</para>
        /// <para>Valid values of N: 1 to 50.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<PutResourceMetricRulesRequestRules> Rules { get; set; }
        public class PutResourceMetricRulesRequestRules : TeaModel {
            [NameInMap("Escalations")]
            [Validation(Required=false)]
            public PutResourceMetricRulesRequestRulesEscalations Escalations { get; set; }
            public class PutResourceMetricRulesRequestRulesEscalations : TeaModel {
                [NameInMap("Critical")]
                [Validation(Required=false)]
                public PutResourceMetricRulesRequestRulesEscalationsCritical Critical { get; set; }
                public class PutResourceMetricRulesRequestRulesEscalationsCritical : TeaModel {
                    /// <summary>
                    /// <para>The comparison operator for the Critical-level threshold. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to.</description></item>
                    /// <item><description>GreaterThanThreshold: greater than.</description></item>
                    /// <item><description>LessThanOrEqualToThreshold: less than or equal to.</description></item>
                    /// <item><description>LessThanThreshold: less than.</description></item>
                    /// <item><description>NotEqualToThreshold: not equal to.</description></item>
                    /// <item><description>EqualToThreshold: equal to.</description></item>
                    /// <item><description>GreaterThanYesterday: greater than the value at the same time yesterday.</description></item>
                    /// <item><description>LessThanYesterday: less than the value at the same time yesterday.</description></item>
                    /// <item><description>GreaterThanLastWeek: greater than the value at the same time last week.</description></item>
                    /// <item><description>LessThanLastWeek: less than the value at the same time last week.</description></item>
                    /// <item><description>GreaterThanLastPeriod: greater than the value in the previous period.</description></item>
                    /// <item><description>LessThanLastPeriod: less than the value in the previous period.</description></item>
                    /// </list>
                    /// <para>Valid values of N: 1 to 50.</para>
                    /// <remarks>
                    /// <para>You must configure at least one of the following alert levels: Critical, Warn, and Info. For the configured alert level, you must configure the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
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
                    public int? N { get; set; }

                    [NameInMap("PreCondition")]
                    [Validation(Required=false)]
                    public string PreCondition { get; set; }

                    /// <summary>
                    /// <para>The statistical method for Critical-level alerts.</para>
                    /// <para>Valid values of N: 1 to 50.</para>
                    /// <para>The value of this parameter is determined by the <c>Statistics</c> column corresponding to the <c>MetricName</c> parameter of the specified Alibaba Cloud service, such as Maximum, Minimum, and Average. For more information about how to obtain the value of this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service monitoring metrics</a>.</para>
                    /// <remarks>
                    /// <para>You must configure the Settings for at least one of the following alert levels: Critical, Warn (warning), and Info. For the configured alert level, you must configure the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
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
                    /// <para>Valid values of N: 1 to 50.</para>
                    /// <remarks>
                    /// <para>You must configure at least one of the following alert levels: Critical, Warn, and Info. For the configured alert level, you must configure the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>90</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    /// <summary>
                    /// <para>The number of retries for Critical-level alerts.</para>
                    /// <para>Valid values of N: 1 to 50.</para>
                    /// <remarks>
                    /// <para>You must configure at least one of the following alert levels: Critical, Warn, and Info. For the configured alert level, you must configure the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
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
                public PutResourceMetricRulesRequestRulesEscalationsInfo Info { get; set; }
                public class PutResourceMetricRulesRequestRulesEscalationsInfo : TeaModel {
                    /// <summary>
                    /// <para>The comparison operator for the Info-level threshold. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to.</description></item>
                    /// <item><description>GreaterThanThreshold: greater than.</description></item>
                    /// <item><description>LessThanOrEqualToThreshold: less than or equal to.</description></item>
                    /// <item><description>LessThanThreshold: less than.</description></item>
                    /// <item><description>NotEqualToThreshold: not equal to.</description></item>
                    /// <item><description>EqualToThreshold: equal to.</description></item>
                    /// <item><description>GreaterThanYesterday: greater than the value at the same time yesterday.</description></item>
                    /// <item><description>LessThanYesterday: less than the value at the same time yesterday.</description></item>
                    /// <item><description>GreaterThanLastWeek: greater than the value at the same time last week.</description></item>
                    /// <item><description>LessThanLastWeek: less than the value at the same time last week.</description></item>
                    /// <item><description>GreaterThanLastPeriod: greater than the value in the previous period.</description></item>
                    /// <item><description>LessThanLastPeriod: less than the value in the previous period.</description></item>
                    /// </list>
                    /// <para>Valid values of N: 1 to 50.</para>
                    /// <remarks>
                    /// <para>You must configure at least one of the following alert levels: Critical, Warn, and Info. For the configured alert level, you must configure the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
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
                    public int? N { get; set; }

                    [NameInMap("PreCondition")]
                    [Validation(Required=false)]
                    public string PreCondition { get; set; }

                    /// <summary>
                    /// <para>The statistical method for Info-level alerts.</para>
                    /// <para>Valid values of N: 1 to 50.</para>
                    /// <para>The value of this parameter is determined by the <c>Statistics</c> column corresponding to the <c>MetricName</c> parameter of the specified Alibaba Cloud service, such as Maximum, Minimum, and Average. For more information about how to obtain the value of this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service monitoring metrics</a>.</para>
                    /// <remarks>
                    /// <para>You must configure the Settings for at least one of the following alert levels: Critical, Warn (warning), and Info. For the configured alert level, you must configure the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
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
                    /// <para>You must configure at least one of the following alert levels: Critical, Warn, and Info. For the configured alert level, you must configure the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>90</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    /// <summary>
                    /// <para>The number of retries for Info-level alerts.</para>
                    /// <para>Valid values of N: 1 to 50.</para>
                    /// <remarks>
                    /// <para>You must configure at least one of the following alert levels: Critical, Warn, and Info. For the configured alert level, you must configure the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
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
                public PutResourceMetricRulesRequestRulesEscalationsWarn Warn { get; set; }
                public class PutResourceMetricRulesRequestRulesEscalationsWarn : TeaModel {
                    /// <summary>
                    /// <para>The comparison operator for the Warn-level threshold. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to.</description></item>
                    /// <item><description>GreaterThanThreshold: greater than.</description></item>
                    /// <item><description>LessThanOrEqualToThreshold: less than or equal to.</description></item>
                    /// <item><description>LessThanThreshold: less than.</description></item>
                    /// <item><description>NotEqualToThreshold: not equal to.</description></item>
                    /// <item><description>EqualToThreshold: equal to.</description></item>
                    /// <item><description>GreaterThanYesterday: greater than the value at the same time yesterday.</description></item>
                    /// <item><description>LessThanYesterday: less than the value at the same time yesterday.</description></item>
                    /// <item><description>GreaterThanLastWeek: greater than the value at the same time last week.</description></item>
                    /// <item><description>LessThanLastWeek: less than the value at the same time last week.</description></item>
                    /// <item><description>GreaterThanLastPeriod: greater than the value in the previous period.</description></item>
                    /// <item><description>LessThanLastPeriod: less than the value in the previous period.</description></item>
                    /// </list>
                    /// <para>Valid values of N: 1 to 50.</para>
                    /// <remarks>
                    /// <para>You must configure at least one of the following alert levels: Critical, Warn, and Info. For the configured alert level, you must configure the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
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
                    public int? N { get; set; }

                    [NameInMap("PreCondition")]
                    [Validation(Required=false)]
                    public string PreCondition { get; set; }

                    /// <summary>
                    /// <para>The statistical method for Warn-level alerts.</para>
                    /// <para>Valid values of N: 1 to 50.</para>
                    /// <para>The value of this parameter is determined by the <c>Statistics</c> column corresponding to the <c>MetricName</c> parameter of the specified Alibaba Cloud service, such as Maximum, Minimum, and Average. For more information about how to obtain the value of this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service monitoring metrics</a>.</para>
                    /// <remarks>
                    /// <para>You must configure the Settings for at least one of the following alert levels: Critical, Warn (warning), and Info. For the configured alert level, you must configure the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
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
                    /// <para>Valid values of N: 1 to 50.</para>
                    /// <remarks>
                    /// <para>You must configure at least one of the following alert levels: Critical, Warn, and Info. For the configured alert level, you must configure the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>90</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    /// <summary>
                    /// <para>The number of retries for Warn-level alerts.</para>
                    /// <para>Valid values of N: 1 to 50.</para>
                    /// <remarks>
                    /// <para>You must configure at least one of the following alert levels: Critical, Warn, and Info. For the configured alert level, you must configure the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
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
            /// <para>The alert contact group. Alert notifications are sent to the alert contacts in this alert contact group.</para>
            /// <para>Valid values of N: 1 to 50.</para>
            /// <remarks>
            /// <para>An alert contact group is a group of alert contacts and can contain one or more alert contacts. For more information about how to create alert contacts and alert contact groups, see <a href="https://help.aliyun.com/document_detail/114923.html">PutContact</a> and <a href="https://help.aliyun.com/document_detail/114929.html">PutContactGroup</a>.</para>
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
            /// <para>Valid values of N: 1 to 50.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00-23:59</para>
            /// </summary>
            [NameInMap("EffectiveInterval")]
            [Validation(Required=false)]
            public string EffectiveInterval { get; set; }

            /// <summary>
            /// <para>The subject of the alert email.</para>
            /// <para>Valid values of N: 1 to 50.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS instance alert</para>
            /// </summary>
            [NameInMap("EmailSubject")]
            [Validation(Required=false)]
            public string EmailSubject { get; set; }

            /// <summary>
            /// <para>The trigger period of the alert rule.</para>
            /// <para>Unit: seconds.</para>
            /// <para>Valid values of N: 1 to 50.</para>
            /// <remarks>
            /// <para>For more information about how to query the statistical period of a monitoring metric, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service monitoring metrics</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public string Interval { get; set; }

            /// <summary>
            /// <para>The labels that are written to the metric and displayed in the alert notification when the metric meets the alert condition and an alert is triggered.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<PutResourceMetricRulesRequestRulesLabels> Labels { get; set; }
            public class PutResourceMetricRulesRequestRulesLabels : TeaModel {
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
                /// <para>Tag values support template parameters. The template parameters are replaced with the actual tag values.</para>
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
            /// <para>The monitoring metric name.</para>
            /// <para>Valid values of N: 1 to 50.</para>
            /// <para>For more information about how to query the monitoring metric name, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service monitoring metrics</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpu_total</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The data namespace of the Alibaba Cloud service.</para>
            /// <para>Valid values of N: 1 to 50.</para>
            /// <para>For more information about how to query the data namespace of an Alibaba Cloud service, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service monitoring metrics</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs_ecs_dashboard</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The handling method for alerts when no monitoring data is available. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>KEEP_LAST_STATE (default): No operations are performed.</description></item>
            /// <item><description>INSUFFICIENT_DATA: The alert content indicates that no data is available.</description></item>
            /// <item><description>OK: Normal.</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 50.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KEEP_LAST_STATE</para>
            /// </summary>
            [NameInMap("NoDataPolicy")]
            [Validation(Required=false)]
            public string NoDataPolicy { get; set; }

            /// <summary>
            /// <para>The inactive time range of the alert rule.</para>
            /// <para>Valid values of N: 1 to 50.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00-06:00</para>
            /// </summary>
            [NameInMap("NoEffectiveInterval")]
            [Validation(Required=false)]
            public string NoEffectiveInterval { get; set; }

            /// <summary>
            /// <para>The statistical period of the monitoring metric.</para>
            /// <para>Unit: seconds. Default value: the original reporting period of the monitoring metric.</para>
            /// <para>Valid values of N: 1 to 50.</para>
            /// <remarks>
            /// <para>For more information about how to query the statistical period of a monitoring metric, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service monitoring metrics</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            /// <summary>
            /// <para>The resource information. Examples: <c>[{&quot;instanceId&quot;:&quot;i-uf6j91r34rnwawoo****&quot;}]</c> and <c>[{&quot;userId&quot;:&quot;100931896542****&quot;}]</c>.</para>
            /// <para>Valid values of N: 1 to 50.</para>
            /// <para>For more information about the dimensions supported by resource information, see <a href="https://help.aliyun.com/document_detail/163515.html">Alibaba Cloud service monitoring metrics</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;instanceId&quot;:&quot;i-uf6j91r34rnwawoo****&quot;}]</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public string Resources { get; set; }

            /// <summary>
            /// <para>The ID of the alert rule.</para>
            /// <para>Valid values of N: 1 to 50.</para>
            /// <para>You can enter a new alert rule ID or use an existing alert rule ID in CloudMonitor. For more information about how to query the ID of an alert rule, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
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
            /// <para>Valid values of N: 1 to 50.</para>
            /// <para>You can enter a new alert rule name or use an existing alert rule name in CloudMonitor. For more information about how to query the name of an alert rule, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
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
            /// <para>The mute epoch.</para>
            /// <para>Unit: seconds. Default value: 86400.</para>
            /// <para>Valid values of N: 1 to 50.</para>
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
            /// <para>The webhook URL to which a POST request is sent when an alert callback is triggered.</para>
            /// <para>Valid values of N: 1 to 50.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://alert.aliyun.com.com:8080/callback">https://alert.aliyun.com.com:8080/callback</a></para>
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

    }

}

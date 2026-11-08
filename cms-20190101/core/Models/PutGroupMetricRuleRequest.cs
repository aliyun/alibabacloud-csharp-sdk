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
                /// <para>The threshold comparison operator for Critical-level alerts. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold: Greater than or equal to the threshold.</description></item>
                /// <item><description>GreaterThanThreshold: Greater than the threshold.</description></item>
                /// <item><description>LessThanOrEqualToThreshold: Less than or equal to the threshold.</description></item>
                /// <item><description>LessThanThreshold: Less than the threshold.</description></item>
                /// <item><description>NotEqualToThreshold: Not equal to the threshold.</description></item>
                /// <item><description>GreaterThanYesterday: Greater than the value at the same time yesterday.</description></item>
                /// <item><description>LessThanYesterday: Less than the value at the same time yesterday.</description></item>
                /// <item><description>GreaterThanLastWeek: Greater than the value at the same time last week.</description></item>
                /// <item><description>LessThanLastWeek: Less than the value at the same time last week.</description></item>
                /// <item><description>GreaterThanLastPeriod: Greater than the value in the last period.</description></item>
                /// <item><description>LessThanLastPeriod: Less than the value in the last period.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The statistical method for Critical-level alerts. Separate multiple statistical methods with commas (,).</para>
                /// <para>The valid values of this parameter are determined by the Statistics column corresponding to the MetricName of the specified Alibaba Cloud service, such as Maximum, Minimum, and Average. For information about how to obtain the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring metrics</a>.</para>
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
                /// <para>The number of retries for Critical-level alerts.</para>
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
                /// <para>The threshold comparison operator for Info-level alerts. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold: Greater than or equal to the threshold.</description></item>
                /// <item><description>GreaterThanThreshold: Greater than the threshold.</description></item>
                /// <item><description>LessThanOrEqualToThreshold: Less than or equal to the threshold.</description></item>
                /// <item><description>LessThanThreshold: Less than the threshold.</description></item>
                /// <item><description>NotEqualToThreshold: Not equal to the threshold.</description></item>
                /// <item><description>GreaterThanYesterday: Greater than the value at the same time yesterday.</description></item>
                /// <item><description>LessThanYesterday: Less than the value at the same time yesterday.</description></item>
                /// <item><description>GreaterThanLastWeek: Greater than the value at the same time last week.</description></item>
                /// <item><description>LessThanLastWeek: Less than the value at the same time last week.</description></item>
                /// <item><description>GreaterThanLastPeriod: Greater than the value in the last period.</description></item>
                /// <item><description>LessThanLastPeriod: Less than the value in the last period.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The statistical method for Info-level alerts. Separate multiple statistical methods with commas (,).</para>
                /// <para>The valid values of this parameter are determined by the Statistics column corresponding to the MetricName of the specified Alibaba Cloud service, such as Maximum, Minimum, and Average. For information about how to obtain the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring metrics</a>.</para>
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
                /// <para>The number of retries for Info-level alerts.</para>
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
                /// <para>The threshold comparison operator for Warn-level alerts. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>GreaterThanOrEqualToThreshold: Greater than or equal to the threshold.</description></item>
                /// <item><description>GreaterThanThreshold: Greater than the threshold.</description></item>
                /// <item><description>LessThanOrEqualToThreshold: Less than or equal to the threshold.</description></item>
                /// <item><description>LessThanThreshold: Less than the threshold.</description></item>
                /// <item><description>NotEqualToThreshold: Not equal to the threshold.</description></item>
                /// <item><description>GreaterThanYesterday: Greater than the value at the same time yesterday.</description></item>
                /// <item><description>LessThanYesterday: Less than the value at the same time yesterday.</description></item>
                /// <item><description>GreaterThanLastWeek: Greater than the value at the same time last week.</description></item>
                /// <item><description>LessThanLastWeek: Less than the value at the same time last week.</description></item>
                /// <item><description>GreaterThanLastPeriod: Greater than the value in the last period.</description></item>
                /// <item><description>LessThanLastPeriod: Less than the value in the last period.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanOrEqualToThreshold</para>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The statistical method for Warn-level alerts. Separate multiple statistical methods with commas (,).</para>
                /// <para>The valid values of this parameter are determined by the Statistics column corresponding to the MetricName of the specified Alibaba Cloud service, such as Maximum, Minimum, and Average. For information about how to obtain the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring metrics</a>.</para>
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
                /// <para>The number of retries for Warn-level alerts.</para>
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
        /// <para>For information about how to obtain the abbreviation, see the metricCategory field in the Labels response parameter of the <a href="https://help.aliyun.com/document_detail/114916.html">DescribeProjectMeta</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

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
        /// <para>Format: a collection of key:value pairs, such as <c>{&quot;userId&quot;:&quot;120886317861****&quot;}</c> and <c>{&quot;instanceId&quot;:&quot;i-m5e1qg6uo38rztr4****&quot;}</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;instanceId&quot;:&quot;i-m5e1qg6uo38rztr4****&quot;}]</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: A check request is sent, and no security group is associated with the instance. The check items include whether required parameters are specified, the request format, and service limits. If the check fails, an error is returned. If the check succeeds, the error code DryRunOperation is returned.</description></item>
        /// <item><description><b>false</b>: A normal request is sent. If the check succeeds, an HTTP 2xx status code is returned and the operation is performed. This is the default value.</description></item>
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
        /// <para>The second-level or third-level dimension of the alert rule in the application group.</para>
        /// <para>Format: a collection of key:value pairs, such as <c>port:80</c> and <c>/dev/xvda:d-m5e6yphgzn3aprwu****</c>.</para>
        /// <para>If the first-level dimension of the alert rule is <c>{&quot;instanceId&quot;:&quot;i-m5e1qg6uo38rztr4****&quot;}</c>, the second-level dimension is the cloud disk in the instance, such as <c>{&quot;/dev/xvda&quot;:&quot;d-m5e6yphgzn3aprwu****&quot;}</c>.</para>
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
        /// <para>Set the detection period of the alert rule to the same as the data reporting period. If the detection period is shorter than the data reporting period, alerts cannot be triggered due to insufficient data.</para>
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
        /// <para>Alert notifications include the tags.</para>
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
        /// <para>For information about how to obtain the metric name, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a> or <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring metrics</a>.</para>
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
        /// <para>For information about how to obtain the namespace, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a> or <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring metrics</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The processing method when no monitoring data is available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>KEEP_LAST_STATE: No action is taken. This is the default value.</description></item>
        /// <item><description>INSUFFICIENT_DATA: An alert indicating insufficient data is triggered.</description></item>
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
        /// <para>00:00-05:30</para>
        /// </summary>
        [NameInMap("NoEffectiveInterval")]
        [Validation(Required=false)]
        public string NoEffectiveInterval { get; set; }

        /// <summary>
        /// <para>The advanced settings.</para>
        /// <para>Format: <c>{&quot;key1&quot;:&quot;value1&quot;,&quot;key2&quot;:&quot;value2&quot;}</c>. Example: <c>{&quot;NotSendOK&quot;:true}</c>, which specifies whether to send alert recovery notifications. The key is NotSendOK, and the value is true (do not send) or false (send, which is the default value).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotSendOK&quot;:true}</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>The reporting period of monitoring data.</para>
        /// <para>The value of Period must be 60 or an integer multiple of 60. Unit: seconds. Default value: 300.</para>
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
        /// <item><description><para>When you create an alert rule for the application group, enter the alert rule ID.</para>
        /// </description></item>
        /// <item><description><para>When you modify a specified alert rule in the application group, you must obtain the alert rule ID. For information about how to obtain the alert rule ID, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
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
        /// <item><description><para>When you create an alert rule for the application group, enter the alert rule name.</para>
        /// </description></item>
        /// <item><description><para>When you modify a specified alert rule in the application group, you must obtain the alert rule name. For information about how to obtain the alert rule name, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
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
        /// <para>The webhook URL that is called when an alert is triggered.</para>
        /// <para>Enter a publicly accessible URL. CloudMonitor pushes alert notifications to this URL by sending POST requests. Only HTTP is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateMetricRuleTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The alert templates.</para>
        /// </summary>
        [NameInMap("AlertTemplates")]
        [Validation(Required=false)]
        public List<CreateMetricRuleTemplateRequestAlertTemplates> AlertTemplates { get; set; }
        public class CreateMetricRuleTemplateRequestAlertTemplates : TeaModel {
            [NameInMap("Escalations")]
            [Validation(Required=false)]
            public CreateMetricRuleTemplateRequestAlertTemplatesEscalations Escalations { get; set; }
            public class CreateMetricRuleTemplateRequestAlertTemplatesEscalations : TeaModel {
                [NameInMap("Critical")]
                [Validation(Required=false)]
                public CreateMetricRuleTemplateRequestAlertTemplatesEscalationsCritical Critical { get; set; }
                public class CreateMetricRuleTemplateRequestAlertTemplatesEscalationsCritical : TeaModel {
                    /// <summary>
                    /// <para>The comparison operator for the critical-level alert threshold. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold. </description></item>
                    /// <item><description>GreaterThanThreshold: greater than the threshold. </description></item>
                    /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold. </description></item>
                    /// <item><description>LessThanThreshold: less than the threshold. </description></item>
                    /// <item><description>NotEqualToThreshold: not equal to the threshold. </description></item>
                    /// <item><description>GreaterThanYesterday: greater than the metric value at the same time yesterday. </description></item>
                    /// <item><description>LessThanYesterday: less than the metric value at the same time yesterday. </description></item>
                    /// <item><description>GreaterThanLastWeek: greater than the metric value at the same time last week. </description></item>
                    /// <item><description>LessThanLastWeek: less than the metric value at the same time last week. </description></item>
                    /// <item><description>GreaterThanLastPeriod: greater than the metric value in the last period. </description></item>
                    /// <item><description>LessThanLastPeriod: less than the metric value in the last period.</description></item>
                    /// </list>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
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

                    /// <summary>
                    /// <para>The statistical method for critical-level alerts.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <para>The valid values of this parameter are determined by the Statistics column that corresponds to the MetricName parameter of the specified cloud service. Examples: Maximum, Minimum, and Average. For more information about how to obtain the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring metrics</a>.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, the Settings for the Statistics, ComparisonOperator, Threshold, and Times parameters must be configured at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Average</para>
                    /// </summary>
                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    /// <summary>
                    /// <para>The threshold that triggers a critical-level alert notification.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, the Settings for the Statistics, ComparisonOperator, Threshold, and Times parameters must be configured at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    /// <summary>
                    /// <para>The number of consecutive times that the monitoring metrics must reach the alert threshold to send a critical alert notification.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, the Settings for the Statistics, ComparisonOperator, Threshold, and Times parameters must be configured at the same time.</para>
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
                public CreateMetricRuleTemplateRequestAlertTemplatesEscalationsInfo Info { get; set; }
                public class CreateMetricRuleTemplateRequestAlertTemplatesEscalationsInfo : TeaModel {
                    /// <summary>
                    /// <para>The comparison operator for the info-level alert threshold. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold. </description></item>
                    /// <item><description>GreaterThanThreshold: greater than the threshold. </description></item>
                    /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold. </description></item>
                    /// <item><description>LessThanThreshold: less than the threshold. </description></item>
                    /// <item><description>NotEqualToThreshold: not equal to the threshold. </description></item>
                    /// <item><description>GreaterThanYesterday: greater than the metric value at the same time yesterday. </description></item>
                    /// <item><description>LessThanYesterday: less than the metric value at the same time yesterday. </description></item>
                    /// <item><description>GreaterThanLastWeek: greater than the metric value at the same time last week. </description></item>
                    /// <item><description>LessThanLastWeek: less than the metric value at the same time last week. </description></item>
                    /// <item><description>GreaterThanLastPeriod: greater than the metric value in the last period. </description></item>
                    /// <item><description>LessThanLastPeriod: less than the metric value in the last period.</description></item>
                    /// </list>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
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

                    /// <summary>
                    /// <para>The statistical method for info-level alerts.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <para>The valid values of this parameter are determined by the Statistics column that corresponds to the MetricName parameter of the specified cloud service. Examples: Maximum, Minimum, and Average. For more information about how to obtain the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring metrics</a>.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, the Settings for the Statistics, ComparisonOperator, Threshold, and Times parameters must be configured at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Average</para>
                    /// </summary>
                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    /// <summary>
                    /// <para>The info-level alert threshold.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    /// <summary>
                    /// <para>The number of consecutive times that the monitoring metrics must reach the alert threshold to send an info-level alert notification.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, the Settings for the Statistics, ComparisonOperator, Threshold, and Times parameters must be configured at the same time.</para>
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
                public CreateMetricRuleTemplateRequestAlertTemplatesEscalationsWarn Warn { get; set; }
                public class CreateMetricRuleTemplateRequestAlertTemplatesEscalationsWarn : TeaModel {
                    /// <summary>
                    /// <para>The comparison operator for the warning-level alert threshold. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold. </description></item>
                    /// <item><description>GreaterThanThreshold: greater than the threshold. </description></item>
                    /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold. </description></item>
                    /// <item><description>LessThanThreshold: less than the threshold. </description></item>
                    /// <item><description>NotEqualToThreshold: not equal to the threshold. </description></item>
                    /// <item><description>GreaterThanYesterday: greater than the metric value at the same time yesterday. </description></item>
                    /// <item><description>LessThanYesterday: less than the metric value at the same time yesterday. </description></item>
                    /// <item><description>GreaterThanLastWeek: greater than the metric value at the same time last week. </description></item>
                    /// <item><description>LessThanLastWeek: less than the metric value at the same time last week. </description></item>
                    /// <item><description>GreaterThanLastPeriod: greater than the metric value in the last period. </description></item>
                    /// <item><description>LessThanLastPeriod: less than the metric value in the last period.</description></item>
                    /// </list>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
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

                    /// <summary>
                    /// <para>The statistical method for warning-level alerts.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <para>The valid values of this parameter are determined by the Statistics column that corresponds to the MetricName parameter of the specified cloud service. Examples: Maximum, Minimum, and Average. For more information about how to obtain the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring metrics</a>.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, the Settings for the Statistics, ComparisonOperator, Threshold, and Times parameters must be configured at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Average</para>
                    /// </summary>
                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    /// <summary>
                    /// <para>The warning-level alert threshold.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    /// <summary>
                    /// <para>The number of consecutive times that the monitoring metrics must reach the alert threshold to send a warning alert notification.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, the Settings for the Statistics, ComparisonOperator, Threshold, and Times parameters must be configured at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }

            }

            /// <summary>
            /// <para>The abbreviation of the cloud service name.</para>
            /// <para>Valid values of N: 1 to 200.</para>
            /// <para>For more information about how to obtain the abbreviation of a cloud service name, see the metricCategory field in the Labels response parameter of the <a href="https://help.aliyun.com/document_detail/114916.html">DescribeProjectMeta</a> operation.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The name of the metric.</para>
            /// <para>Valid values of N: 1 to 200.</para>
            /// <para>For more information about how to obtain the metric name, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a> or <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring metrics</a>.</para>
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
            /// <para>Valid values of N: 1 to 200.</para>
            /// <para>For more information about how to obtain the namespace of a cloud service, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a> or <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring metrics</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs_ecs_dashboard</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The aggregation period of the monitoring data. Unit: seconds.</para>
            /// <para>The default value is the minimum aggregation period of the metric. In most cases, you do not need to specify this parameter.</para>
            /// <para>Valid values of N: 1 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

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
            /// <para>The options for the extended Dimension field.</para>
            /// <para>Valid values of N: 1 to 200.</para>
            /// <para>For example, if the alert template is applied to an application group, this parameter is set to <c>{&quot;disk&quot;:&quot;/&quot;}</c>, and the MetricName parameter is set to DiskUtilization, the root partition (<c>&quot;/&quot;</c>) of the disk for all instances in the application group is associated with the corresponding alert rule.</para>
            /// <remarks>
            /// <para>For more information about the valid values of the extended field options, see <a href="https://help.aliyun.com/document_detail/114979.html">DescribeMetricRuleTemplateAttribute</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;disk&quot;:&quot;/&quot;}</para>
            /// </summary>
            [NameInMap("Selector")]
            [Validation(Required=false)]
            public string Selector { get; set; }

            /// <summary>
            /// <para>The webhook URL to which alert notifications are sent.</para>
            /// <para>Valid values of N: 1 to 200.</para>
            /// <para>Specify a publicly accessible URL. CloudMonitor sends alert notifications to this URL by using HTTP POST requests. Only HTTP is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://ww.aliyun.com">http://ww.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

        /// <summary>
        /// <para>The description of the alert template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_Template1</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the alert template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Template1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateMetricRuleTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The details of the alert template.</para>
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
                    /// <para>The operator that is used to compare the metric value with the threshold for Critical-level alerts. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>GreaterThanOrEqualToThreshold: greater than or equal to the threshold</para>
                    /// </description></item>
                    /// <item><description><para>GreaterThanThreshold: greater than the threshold</para>
                    /// </description></item>
                    /// <item><description><para>LessThanOrEqualToThreshold: less than or equal to the threshold</para>
                    /// </description></item>
                    /// <item><description><para>LessThanThreshold: less than the threshold</para>
                    /// </description></item>
                    /// <item><description><para>NotEqualToThreshold: not equal to the threshold</para>
                    /// </description></item>
                    /// <item><description><para>GreaterThanYesterday: greater than the metric value at the same time yesterday</para>
                    /// </description></item>
                    /// <item><description><para>LessThanYesterday: less than the metric value at the same time yesterday</para>
                    /// </description></item>
                    /// <item><description><para>GreaterThanLastWeek: greater than the metric value at the same time last week</para>
                    /// </description></item>
                    /// <item><description><para>LessThanLastWeek: less than the metric value at the same time last week</para>
                    /// </description></item>
                    /// <item><description><para>GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle</para>
                    /// </description></item>
                    /// <item><description><para>LessThanLastPeriod: less than the metric value in the previous monitoring cycle</para>
                    /// </description></item>
                    /// </list>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
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
                    /// <para>The statistical method for Critical-level alerts.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <para>The value of this parameter is determined by the <c>Statistics</c> column corresponding to the <c>MetricName</c> parameter of the specified cloud service. The value of this parameter can be Maximum, Minimum, or Average. For more information about how to obtain the value of this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
                    /// <remarks>
                    /// <para>You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
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
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    /// <summary>
                    /// <para>The consecutive number of times for which the metric value meets the alert condition before a Critical-level alert is triggered.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
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
                    /// <para>The operator that is used to compare the metric value with the threshold for Info-level alerts. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>GreaterThanOrEqualToThreshold: greater than or equal to the threshold</para>
                    /// </description></item>
                    /// <item><description><para>GreaterThanThreshold: greater than the threshold</para>
                    /// </description></item>
                    /// <item><description><para>LessThanOrEqualToThreshold: less than or equal to the threshold</para>
                    /// </description></item>
                    /// <item><description><para>LessThanThreshold: less than the threshold</para>
                    /// </description></item>
                    /// <item><description><para>NotEqualToThreshold: not equal to the threshold</para>
                    /// </description></item>
                    /// <item><description><para>GreaterThanYesterday: greater than the metric value at the same time yesterday</para>
                    /// </description></item>
                    /// <item><description><para>LessThanYesterday: less than the metric value at the same time yesterday</para>
                    /// </description></item>
                    /// <item><description><para>GreaterThanLastWeek: greater than the metric value at the same time last week</para>
                    /// </description></item>
                    /// <item><description><para>LessThanLastWeek: less than the metric value at the same time last week</para>
                    /// </description></item>
                    /// <item><description><para>GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle</para>
                    /// </description></item>
                    /// <item><description><para>LessThanLastPeriod: less than the metric value in the previous monitoring cycle</para>
                    /// </description></item>
                    /// </list>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
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
                    /// <para>The statistical method for Info-level alerts.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <para>The value of this parameter is determined by the <c>Statistics</c> column corresponding to the <c>MetricName</c> parameter of the specified cloud service. The value of this parameter can be Maximum, Minimum, or Average. For more information about how to obtain the value of this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
                    /// <remarks>
                    /// <para>You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
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
                    /// <para>You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    /// <summary>
                    /// <para>The consecutive number of times for which the metric value meets the alert condition before an Info-level alert is triggered.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
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
                    /// <para>The operator that is used to compare the metric value with the threshold for Warn-level alerts. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>GreaterThanOrEqualToThreshold: greater than or equal to the threshold</para>
                    /// </description></item>
                    /// <item><description><para>GreaterThanThreshold: greater than the threshold</para>
                    /// </description></item>
                    /// <item><description><para>LessThanOrEqualToThreshold: less than or equal to the threshold</para>
                    /// </description></item>
                    /// <item><description><para>LessThanThreshold: less than the threshold</para>
                    /// </description></item>
                    /// <item><description><para>NotEqualToThreshold: not equal to the threshold</para>
                    /// </description></item>
                    /// <item><description><para>GreaterThanYesterday: greater than the metric value at the same time yesterday</para>
                    /// </description></item>
                    /// <item><description><para>LessThanYesterday: less than the metric value at the same time yesterday</para>
                    /// </description></item>
                    /// <item><description><para>GreaterThanLastWeek: greater than the metric value at the same time last week</para>
                    /// </description></item>
                    /// <item><description><para>LessThanLastWeek: less than the metric value at the same time last week</para>
                    /// </description></item>
                    /// <item><description><para>GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle</para>
                    /// </description></item>
                    /// <item><description><para>LessThanLastPeriod: less than the metric value in the previous monitoring cycle</para>
                    /// </description></item>
                    /// </list>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
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
                    /// <para>The statistical method for the Warn-level alert.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <para>The value of this parameter is determined by the <c>Statistics</c> column corresponding to the <c>MetricName</c> parameter of the specified cloud service. The value of this parameter can be Maximum, Minimum, or Average. For more information about how to obtain the value of this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
                    /// <remarks>
                    /// <para>You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
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
                    /// <para>You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    /// <summary>
                    /// <para>The consecutive number of times for which the metric value meets the alert condition before a Warn-level alert is triggered.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must select at least one of the Critical, Warn, and Info alert levels and specify the Statistics, ComparisonOperator, Threshold, and Times parameters for each alert level.</para>
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
            /// <para>For more information about how to obtain the abbreviation of a cloud service name, see <c>metricCategory</c> in the response parameter <c>Labels</c> of the <a href="https://help.aliyun.com/document_detail/114916.html">DescribeProjectMeta</a> operation.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The metric name.</para>
            /// <para>Valid values of N: 1 to 200.</para>
            /// <para>For information about how to obtain the name of a metric, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a> or <a href="https://help.aliyun.com/document_detail/163515.html">Metrics</a>.</para>
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
            /// <para>For information about how to obtain the namespace of a cloud service, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a> or <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs_ecs_dashboard</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The aggregation period of monitoring data. Unit: seconds.</para>
            /// <para>The default value is the minimum aggregation period. Generally, you do not need to specify the minimum aggregation period.</para>
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
            /// <para>The dimension of the alert. It is an extended field.</para>
            /// <para>Valid values of N: 1 to 200.</para>
            /// <para>For example, an alert template is applied to an application group, this parameter is set to <c>{&quot;disk&quot;:&quot;/&quot;}</c>, and the MetricName parameter is set to <c>DiskUtilization</c>. In this case, the generated alert rule is applied to the root disk partition (<c>&quot;/&quot;</c>) of all instances in the application group to which the alert template is applied.</para>
            /// <remarks>
            /// <para>For more information about the values of extended fields, see <a href="https://help.aliyun.com/document_detail/114979.html">DescribeMetricRuleTemplateAttribute</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;disk&quot;:&quot;/&quot;}</para>
            /// </summary>
            [NameInMap("Selector")]
            [Validation(Required=false)]
            public string Selector { get; set; }

            /// <summary>
            /// <para>The callback URL.</para>
            /// <para>Valid values of N: 1 to 200.</para>
            /// <para>The callback URL must be accessible over the Internet. CloudMonitor pushes an alert notification to the specified callback URL by sending an HTTP POST request. Only the HTTP protocol is supported.</para>
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

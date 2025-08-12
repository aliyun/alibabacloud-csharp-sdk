// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleTemplateAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8F3A82AD-DA92-52B0-8EC6-C059D1C3839F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the alert template.</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public DescribeMetricRuleTemplateAttributeResponseBodyResource Resource { get; set; }
        public class DescribeMetricRuleTemplateAttributeResponseBodyResource : TeaModel {
            /// <summary>
            /// <para>The queried alert templates.</para>
            /// </summary>
            [NameInMap("AlertTemplates")]
            [Validation(Required=false)]
            public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplates AlertTemplates { get; set; }
            public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplates : TeaModel {
                [NameInMap("AlertTemplate")]
                [Validation(Required=false)]
                public List<DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplate> AlertTemplate { get; set; }
                public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplate : TeaModel {
                    /// <summary>
                    /// <para>The abbreviation of the Alibaba Cloud service name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ecs</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>The threshold and the alert level.</para>
                    /// </summary>
                    [NameInMap("Escalations")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalations Escalations { get; set; }
                    public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalations : TeaModel {
                        /// <summary>
                        /// <para>The conditions for triggering Critical-level alerts.</para>
                        /// </summary>
                        [NameInMap("Critical")]
                        [Validation(Required=false)]
                        public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsCritical Critical { get; set; }
                        public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsCritical : TeaModel {
                            /// <summary>
                            /// <para>The comparison operator that is used to compare the metric value with the threshold for Critical-level alerts. Valid values:</para>
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
                            /// <para>The statistical method for Critical-level alerts.</para>
                            /// <para>The value of the <c>Statistics</c> parameter varies with the cloud service. For more information, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
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
                            /// <para>5</para>
                            /// </summary>
                            [NameInMap("Times")]
                            [Validation(Required=false)]
                            public int? Times { get; set; }

                        }

                        /// <summary>
                        /// <para>The conditions for triggering Info-level alerts.</para>
                        /// </summary>
                        [NameInMap("Info")]
                        [Validation(Required=false)]
                        public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsInfo Info { get; set; }
                        public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsInfo : TeaModel {
                            /// <summary>
                            /// <para>The comparison operator that is used to compare the metric value with the threshold for Info-level alerts. Valid values:</para>
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
                            /// <para>The statistical method for Info-level alerts.</para>
                            /// <para>The value of the <c>Statistics</c> parameter varies with the cloud service. For more information, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
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

                        /// <summary>
                        /// <para>The conditions for triggering Warn-level alerts.</para>
                        /// </summary>
                        [NameInMap("Warn")]
                        [Validation(Required=false)]
                        public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsWarn Warn { get; set; }
                        public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsWarn : TeaModel {
                            /// <summary>
                            /// <para>The comparison operator that is used to compare the metric value with the threshold for Warn-level alerts. Valid values:</para>
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
                            /// <para>The statistical method for Warn-level alerts.</para>
                            /// <para>The value of the <c>Statistics</c> parameter varies with the cloud service. For more information, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
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
                    /// <para>The tags of the alert template.</para>
                    /// </summary>
                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateLabels Labels { get; set; }
                    public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateLabels : TeaModel {
                        [NameInMap("Labels")]
                        [Validation(Required=false)]
                        public List<DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateLabelsLabels> Labels { get; set; }
                        public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateLabelsLabels : TeaModel {
                            /// <summary>
                            /// <para>The tag key of the alert template.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>label1</para>
                            /// </summary>
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            /// <summary>
                            /// <para>The tag value of the alert template.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>value1</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The metric name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cpu_total</para>
                    /// </summary>
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    /// <summary>
                    /// <para>The namespace of the Alibaba Cloud service.</para>
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
                    /// <para>The name of the alert rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ECS_Rule</para>
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    /// <summary>
                    /// <para>The dimension of the alert. It is an extended field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;disk&quot;:&quot;/&quot;}</para>
                    /// </summary>
                    [NameInMap("Selector")]
                    [Validation(Required=false)]
                    public string Selector { get; set; }

                    [NameInMap("SilenceTime")]
                    [Validation(Required=false)]
                    public int? SilenceTime { get; set; }

                    /// <summary>
                    /// <para>The callback URL to which a request is sent when an alert is triggered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
                    /// </summary>
                    [NameInMap("Webhook")]
                    [Validation(Required=false)]
                    public string Webhook { get; set; }

                }

            }

            /// <summary>
            /// <para>The description of the alert template.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the alert template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_Template1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The version of the alert template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RestVersion")]
            [Validation(Required=false)]
            public string RestVersion { get; set; }

            /// <summary>
            /// <para>The ID of the alert template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70****</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

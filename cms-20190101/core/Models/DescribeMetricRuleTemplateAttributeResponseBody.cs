// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleTemplateAttributeResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the alert template.
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public DescribeMetricRuleTemplateAttributeResponseBodyResource Resource { get; set; }
        public class DescribeMetricRuleTemplateAttributeResponseBodyResource : TeaModel {
            /// <summary>
            /// The queried alert templates.
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
                    /// The abbreviation of the Alibaba Cloud service name.
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// The threshold and the alert level.
                    /// </summary>
                    [NameInMap("Escalations")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalations Escalations { get; set; }
                    public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalations : TeaModel {
                        /// <summary>
                        /// The conditions for triggering Critical-level alerts.
                        /// </summary>
                        [NameInMap("Critical")]
                        [Validation(Required=false)]
                        public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsCritical Critical { get; set; }
                        public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsCritical : TeaModel {
                            /// <summary>
                            /// The comparison operator that is used to compare the metric value with the threshold for Critical-level alerts. Valid values:
                            /// 
                            /// *   GreaterThanOrEqualToThreshold: greater than or equal to the threshold
                            /// *   GreaterThanThreshold: greater than the threshold
                            /// *   LessThanOrEqualToThreshold: less than or equal to the threshold
                            /// *   LessThanThreshold: less than the threshold
                            /// *   NotEqualToThreshold: not equal to the threshold
                            /// *   GreaterThanYesterday: greater than the metric value at the same time yesterday
                            /// *   LessThanYesterday: less than the metric value at the same time yesterday
                            /// *   GreaterThanLastWeek: greater than the metric value at the same time last week
                            /// *   LessThanLastWeek: less than the metric value at the same time last week
                            /// *   GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle
                            /// *   LessThanLastPeriod: less than the metric value in the last monitoring cycle
                            /// </summary>
                            [NameInMap("ComparisonOperator")]
                            [Validation(Required=false)]
                            public string ComparisonOperator { get; set; }

                            /// <summary>
                            /// The statistical method for Critical-level alerts.
                            /// 
                            /// The value of the `Statistics` parameter varies with the cloud service. For more information, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
                            /// </summary>
                            [NameInMap("Statistics")]
                            [Validation(Required=false)]
                            public string Statistics { get; set; }

                            /// <summary>
                            /// The threshold for Critical-level alerts.
                            /// </summary>
                            [NameInMap("Threshold")]
                            [Validation(Required=false)]
                            public string Threshold { get; set; }

                            /// <summary>
                            /// The consecutive number of times for which the metric value meets the alert condition before a Critical-level alert is triggered.
                            /// </summary>
                            [NameInMap("Times")]
                            [Validation(Required=false)]
                            public int? Times { get; set; }

                        }

                        /// <summary>
                        /// The conditions for triggering Info-level alerts.
                        /// </summary>
                        [NameInMap("Info")]
                        [Validation(Required=false)]
                        public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsInfo Info { get; set; }
                        public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsInfo : TeaModel {
                            /// <summary>
                            /// The comparison operator that is used to compare the metric value with the threshold for Info-level alerts. Valid values:
                            /// 
                            /// *   GreaterThanOrEqualToThreshold: greater than or equal to the threshold
                            /// *   GreaterThanThreshold: greater than the threshold
                            /// *   LessThanOrEqualToThreshold: less than or equal to the threshold
                            /// *   LessThanThreshold: less than the threshold
                            /// *   NotEqualToThreshold: not equal to the threshold
                            /// *   GreaterThanYesterday: greater than the metric value at the same time yesterday
                            /// *   LessThanYesterday: less than the metric value at the same time yesterday
                            /// *   GreaterThanLastWeek: greater than the metric value at the same time last week
                            /// *   LessThanLastWeek: less than the metric value at the same time last week
                            /// *   GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle
                            /// *   LessThanLastPeriod: less than the metric value in the last monitoring cycle
                            /// </summary>
                            [NameInMap("ComparisonOperator")]
                            [Validation(Required=false)]
                            public string ComparisonOperator { get; set; }

                            /// <summary>
                            /// The statistical method for Info-level alerts.
                            /// 
                            /// The value of the `Statistics` parameter varies with the cloud service. For more information, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
                            /// </summary>
                            [NameInMap("Statistics")]
                            [Validation(Required=false)]
                            public string Statistics { get; set; }

                            /// <summary>
                            /// The threshold for Info-level alerts.
                            /// </summary>
                            [NameInMap("Threshold")]
                            [Validation(Required=false)]
                            public string Threshold { get; set; }

                            /// <summary>
                            /// The consecutive number of times for which the metric value meets the alert condition before an Info-level alert is triggered.
                            /// </summary>
                            [NameInMap("Times")]
                            [Validation(Required=false)]
                            public int? Times { get; set; }

                        }

                        /// <summary>
                        /// The conditions for triggering Warn-level alerts.
                        /// </summary>
                        [NameInMap("Warn")]
                        [Validation(Required=false)]
                        public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsWarn Warn { get; set; }
                        public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsWarn : TeaModel {
                            /// <summary>
                            /// The comparison operator that is used to compare the metric value with the threshold for Warn-level alerts. Valid values:
                            /// 
                            /// *   GreaterThanOrEqualToThreshold: greater than or equal to the threshold
                            /// *   GreaterThanThreshold: greater than the threshold
                            /// *   LessThanOrEqualToThreshold: less than or equal to the threshold
                            /// *   LessThanThreshold: less than the threshold
                            /// *   NotEqualToThreshold: not equal to the threshold
                            /// *   GreaterThanYesterday: greater than the metric value at the same time yesterday
                            /// *   LessThanYesterday: less than the metric value at the same time yesterday
                            /// *   GreaterThanLastWeek: greater than the metric value at the same time last week
                            /// *   LessThanLastWeek: less than the metric value at the same time last week
                            /// *   GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle
                            /// *   LessThanLastPeriod: less than the metric value in the last monitoring cycle
                            /// </summary>
                            [NameInMap("ComparisonOperator")]
                            [Validation(Required=false)]
                            public string ComparisonOperator { get; set; }

                            /// <summary>
                            /// The statistical method for Warn-level alerts.
                            /// 
                            /// The value of the `Statistics` parameter varies with the cloud service. For more information, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
                            /// </summary>
                            [NameInMap("Statistics")]
                            [Validation(Required=false)]
                            public string Statistics { get; set; }

                            /// <summary>
                            /// The threshold for Warn-level alerts.
                            /// </summary>
                            [NameInMap("Threshold")]
                            [Validation(Required=false)]
                            public string Threshold { get; set; }

                            /// <summary>
                            /// The consecutive number of times for which the metric value meets the alert condition before a Warn-level alert is triggered.
                            /// </summary>
                            [NameInMap("Times")]
                            [Validation(Required=false)]
                            public int? Times { get; set; }

                        }

                    }

                    /// <summary>
                    /// The tags of the alert template.
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
                            /// The tag key of the alert template.
                            /// </summary>
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            /// <summary>
                            /// The tag value of the alert template.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// The metric name.
                    /// </summary>
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    /// <summary>
                    /// The namespace of the Alibaba Cloud service.
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// The method that is used to handle alerts when no monitoring data is found. Valid values:
                    /// 
                    /// *   KEEP_LAST_STATE (default): No operation is performed.
                    /// *   INSUFFICIENT_DATA: An alert whose content is "Insufficient data" is triggered.
                    /// *   OK: The status is considered normal.
                    /// </summary>
                    [NameInMap("NoDataPolicy")]
                    [Validation(Required=false)]
                    public string NoDataPolicy { get; set; }

                    /// <summary>
                    /// The name of the alert rule.
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    /// <summary>
                    /// The dimension of the alert. It is an extended field.
                    /// </summary>
                    [NameInMap("Selector")]
                    [Validation(Required=false)]
                    public string Selector { get; set; }

                    /// <summary>
                    /// The callback URL to which a request is sent when an alert is triggered.
                    /// </summary>
                    [NameInMap("Webhook")]
                    [Validation(Required=false)]
                    public string Webhook { get; set; }

                }

            }

            /// <summary>
            /// The description of the alert template.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the alert template.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The version of the alert template.
            /// </summary>
            [NameInMap("RestVersion")]
            [Validation(Required=false)]
            public string RestVersion { get; set; }

            /// <summary>
            /// The ID of the alert template.
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

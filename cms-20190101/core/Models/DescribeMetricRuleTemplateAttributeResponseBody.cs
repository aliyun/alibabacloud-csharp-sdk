// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleTemplateAttributeResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// Indicates whether the call is successful. Valid values:
        /// 
        /// *   true: The call is successful.
        /// *   false: The call fails.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The details of the alert template.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The version of the alert template.
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public DescribeMetricRuleTemplateAttributeResponseBodyResource Resource { get; set; }
        public class DescribeMetricRuleTemplateAttributeResponseBodyResource : TeaModel {
            /// <summary>
            /// The callback URL to which a request is sent when an alert is triggered.
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
                    /// The name of the alert rule.
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// The comparison operator that is used to compare the metric value with the threshold. Valid values:
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
                    [NameInMap("Escalations")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalations Escalations { get; set; }
                    public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalations : TeaModel {
                        /// <summary>
                        /// The consecutive number of times for which the metric value meets the alert condition before a Critical-level alert is triggered.
                        /// </summary>
                        [NameInMap("Critical")]
                        [Validation(Required=false)]
                        public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsCritical Critical { get; set; }
                        public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsCritical : TeaModel {
                            /// <summary>
                            /// The threshold for Critical-level alerts.
                            /// </summary>
                            [NameInMap("ComparisonOperator")]
                            [Validation(Required=false)]
                            public string ComparisonOperator { get; set; }

                            /// <summary>
                            /// For more information about common request parameters, see [Common parameters](~~199331~~).
                            /// </summary>
                            [NameInMap("Statistics")]
                            [Validation(Required=false)]
                            public string Statistics { get; set; }

                            /// <summary>
                            /// This topic provides an example to show how to query the details of an alert template whose ID is `70****`.
                            /// </summary>
                            [NameInMap("Threshold")]
                            [Validation(Required=false)]
                            public string Threshold { get; set; }

                            /// <summary>
                            /// The statistical method for Critical-level alerts.
                            /// 
                            /// The value of the `Statistics` parameter varies with the cloud service. For more information, see [Appendix 1: Metrics](~~163515~~).
                            /// </summary>
                            [NameInMap("Times")]
                            [Validation(Required=false)]
                            public int? Times { get; set; }

                        }

                        /// <summary>
                        /// The consecutive number of times for which the metric value meets the alert condition before an Info-level alert is triggered.
                        /// </summary>
                        [NameInMap("Info")]
                        [Validation(Required=false)]
                        public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsInfo Info { get; set; }
                        public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsInfo : TeaModel {
                            /// <summary>
                            /// The threshold for Info-level alerts.
                            /// </summary>
                            [NameInMap("ComparisonOperator")]
                            [Validation(Required=false)]
                            public string ComparisonOperator { get; set; }

                            /// <summary>
                            /// The comparison operator that is used to compare the metric value with the threshold. Valid values:
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
                            [NameInMap("Statistics")]
                            [Validation(Required=false)]
                            public string Statistics { get; set; }

                            /// <summary>
                            /// The conditions for triggering Warn-level alerts.
                            /// </summary>
                            [NameInMap("Threshold")]
                            [Validation(Required=false)]
                            public string Threshold { get; set; }

                            /// <summary>
                            /// The statistical method for Info-level alerts.
                            /// 
                            /// The value of the `Statistics` parameter varies with the cloud service. For more information, see [Appendix 1: Metrics](~~163515~~).
                            /// </summary>
                            [NameInMap("Times")]
                            [Validation(Required=false)]
                            public int? Times { get; set; }

                        }

                        /// <summary>
                        /// The consecutive number of times for which the metric value meets the alert condition before a Warn-level alert is triggered.
                        /// </summary>
                        [NameInMap("Warn")]
                        [Validation(Required=false)]
                        public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsWarn Warn { get; set; }
                        public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsWarn : TeaModel {
                            /// <summary>
                            /// The threshold for Warn-level alerts.
                            /// </summary>
                            [NameInMap("ComparisonOperator")]
                            [Validation(Required=false)]
                            public string ComparisonOperator { get; set; }

                            /// <summary>
                            /// The comparison operator that is used to compare the metric value with the threshold. Valid values:
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
                            [NameInMap("Statistics")]
                            [Validation(Required=false)]
                            public string Statistics { get; set; }

                            /// <summary>
                            /// The conditions for triggering Critical-level alerts.
                            /// </summary>
                            [NameInMap("Threshold")]
                            [Validation(Required=false)]
                            public string Threshold { get; set; }

                            /// <summary>
                            /// The statistical method for Warn-level alerts.
                            /// 
                            /// The value of the `Statistics` parameter varies with the cloud service. For more information, see [Appendix 1: Metrics](~~163515~~).
                            /// </summary>
                            [NameInMap("Times")]
                            [Validation(Required=false)]
                            public int? Times { get; set; }

                        }

                    }

                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateLabels Labels { get; set; }
                    public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateLabels : TeaModel {
                        [NameInMap("Labels")]
                        [Validation(Required=false)]
                        public List<DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateLabelsLabels> Labels { get; set; }
                        public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateLabelsLabels : TeaModel {
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    /// <summary>
                    /// The processing method of alerts when no monitoring data is found. Valid values:
                    /// 
                    /// *   KEEP_LAST_STATE (default value): No operation is performed.
                    /// *   INSUFFICIENT_DATA: An alert whose content is "Insufficient data" is triggered.
                    /// *   OK: The alert rule has no active alerts.
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// The threshold and the alert level.
                    /// </summary>
                    [NameInMap("NoDataPolicy")]
                    [Validation(Required=false)]
                    public string NoDataPolicy { get; set; }

                    /// <summary>
                    /// The conditions for triggering Info-level alerts.
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    /// <summary>
                    /// The namespace of the cloud service.
                    /// </summary>
                    [NameInMap("Selector")]
                    [Validation(Required=false)]
                    public string Selector { get; set; }

                    /// <summary>
                    /// The abbreviation of the cloud service name.
                    /// </summary>
                    [NameInMap("Webhook")]
                    [Validation(Required=false)]
                    public string Webhook { get; set; }

                }

            }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the alert template.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The list of alert templates.
            /// </summary>
            [NameInMap("RestVersion")]
            [Validation(Required=false)]
            public string RestVersion { get; set; }

            /// <summary>
            /// The dimension of the alert. It is an extended field.
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// The name of the alert template.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

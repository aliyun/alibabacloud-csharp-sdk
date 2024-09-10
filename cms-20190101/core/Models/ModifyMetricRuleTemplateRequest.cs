// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyMetricRuleTemplateRequest : TeaModel {
        /// <summary>
        /// The details of the alert template.
        /// </summary>
        [NameInMap("AlertTemplates")]
        [Validation(Required=false)]
        public List<ModifyMetricRuleTemplateRequestAlertTemplates> AlertTemplates { get; set; }
        public class ModifyMetricRuleTemplateRequestAlertTemplates : TeaModel {
            [NameInMap("Escalations")]
            [Validation(Required=false)]
            public ModifyMetricRuleTemplateRequestAlertTemplatesEscalations Escalations { get; set; }
            public class ModifyMetricRuleTemplateRequestAlertTemplatesEscalations : TeaModel {
                [NameInMap("Critical")]
                [Validation(Required=false)]
                public ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsCritical Critical { get; set; }
                public class ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsCritical : TeaModel {
                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public int? N { get; set; }

                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }

                [NameInMap("Info")]
                [Validation(Required=false)]
                public ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsInfo Info { get; set; }
                public class ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsInfo : TeaModel {
                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public int? N { get; set; }

                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }

                [NameInMap("Warn")]
                [Validation(Required=false)]
                public ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsWarn Warn { get; set; }
                public class ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsWarn : TeaModel {
                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public int? N { get; set; }

                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }

            }

            /// <summary>
            /// The abbreviation of the cloud service name.
            /// 
            /// Valid values of N: 1 to 200.
            /// 
            /// For more information about how to obtain the abbreviation of a cloud service name, see `metricCategory` in the response parameter `Labels` of the [DescribeProjectMeta](https://help.aliyun.com/document_detail/114916.html) operation.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The metric name.
            /// 
            /// Valid values of N: 1 to 200.
            /// 
            /// For information about how to obtain metrics, see [DescribeMetricMetaList](https://help.aliyun.com/document_detail/98846.html) or [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The namespace of the cloud service.
            /// 
            /// Valid values of N: 1 to 200.
            /// 
            /// For information about how to obtain the namespace of a cloud service, see [DescribeMetricMetaList](https://help.aliyun.com/document_detail/98846.html) or [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The statistical period of the monitoring data.
            /// 
            /// Valid values of N: 1 to 200.
            /// 
            /// > If the value is set to 300 seconds, the monitoring data is collected every 300 seconds. If the monitoring data is reported every 1 minute, the alert system calculates the average, maximum, and minimum values of the monitoring data of 5 minutes and checks whether the aggregated values exceed the threshold. To prevent unexpected alerts, we recommend that you set this parameter together with other parameters.
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// The name of the alert rule.
            /// 
            /// Valid values of N: 1 to 200.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The dimension of the alert. It is an extended field.
            /// 
            /// Valid values of N: 1 to 200.
            /// 
            /// For example, an alert template is applied to an application group, this parameter is set to `{"disk":"/"}`, and the MetricName parameter is set to `DiskUtilization`. In this case, the generated alert rule is applied to the root disk partition (`"/"`) of all instances in the application group to which the alert template is applied.
            /// 
            /// > For more information about the values of extended fields, see [DescribeMetricRuleTemplateAttribute](https://help.aliyun.com/document_detail/114979.html).
            /// </summary>
            [NameInMap("Selector")]
            [Validation(Required=false)]
            public string Selector { get; set; }

            /// <summary>
            /// The callback URL.
            /// 
            /// Valid values of N: 1 to 200.
            /// 
            /// The callback URL must be accessible over the Internet. CloudMonitor pushes an alert notification to the specified callback URL by sending an HTTP POST request. Only the HTTP protocol is supported.
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

        /// <summary>
        /// The description of the alert template.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the alert template.
        /// 
        /// For information about how to obtain the name of an alert template, see [DescribeMetricRuleTemplateList](https://help.aliyun.com/document_detail/114982.html).
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The version of the alert template. The version changes with the number of times that the alert template is modified.
        /// 
        /// For information about how to obtain the version of an alert template, see [DescribeMetricRuleTemplateList](https://help.aliyun.com/document_detail/114982.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RestVersion")]
        [Validation(Required=false)]
        public long? RestVersion { get; set; }

        /// <summary>
        /// The ID of the alert template.
        /// 
        /// For information about how to obtain the ID of an alert template, see [DescribeMetricRuleTemplateList](https://help.aliyun.com/document_detail/114982.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateMetricRuleTemplateRequest : TeaModel {
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
                public CreateMetricRuleTemplateRequestAlertTemplatesEscalationsInfo Info { get; set; }
                public class CreateMetricRuleTemplateRequestAlertTemplatesEscalationsInfo : TeaModel {
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
                public CreateMetricRuleTemplateRequestAlertTemplatesEscalationsWarn Warn { get; set; }
                public class CreateMetricRuleTemplateRequestAlertTemplatesEscalationsWarn : TeaModel {
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
            /// The abbreviation of the Alibaba Cloud service name.
            /// 
            /// To obtain the abbreviation of an Alibaba Cloud service name, call the [DescribeProjectMeta](https://help.aliyun.com/document_detail/114916.html) operation. The `metricCategory` tag in the `Labels` response parameter indicates the abbreviation of the Alibaba Cloud service name.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The name of the metric. Valid values of N: 1 to 200.
            /// 
            /// >  For more information, see [DescribeMetricMetaList](https://help.aliyun.com/document_detail/98846.html) or [Appendix 1: Metrics](https://help.aliyun.com/document_detail/28619.html).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The namespace of the cloud service. Valid values of N: 1 to 200.
            /// 
            /// >  For more information, see [DescribeMetricMetaList](https://help.aliyun.com/document_detail/98846.html) or [Appendix 1: Metrics](https://help.aliyun.com/document_detail/28619.html).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The aggregation period of monitoring data. Unit: seconds.
            /// 
            /// The default value is the minimum aggregation period. Generally, you do not need to specify the minimum aggregation period.
            /// 
            /// Valid values of N: 1 to 200.
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// The name of the alert rule. Valid values of N: 1 to 200.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The extended field selectors. Valid values of N: 1 to 200.
            /// </summary>
            [NameInMap("Selector")]
            [Validation(Required=false)]
            public string Selector { get; set; }

            /// <summary>
            /// The callback URL to which a POST request is sent when an alert is triggered based on the alert rule.
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
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

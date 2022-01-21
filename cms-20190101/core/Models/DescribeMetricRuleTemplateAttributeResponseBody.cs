// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleTemplateAttributeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resource")]
        [Validation(Required=false)]
        public DescribeMetricRuleTemplateAttributeResponseBodyResource Resource { get; set; }
        public class DescribeMetricRuleTemplateAttributeResponseBodyResource : TeaModel {
            [NameInMap("AlertTemplates")]
            [Validation(Required=false)]
            public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplates AlertTemplates { get; set; }
            public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplates : TeaModel {
                [NameInMap("AlertTemplate")]
                [Validation(Required=false)]
                public List<DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplate> AlertTemplate { get; set; }
                public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplate : TeaModel {
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    [NameInMap("Escalations")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalations Escalations { get; set; }
                    public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalations : TeaModel {
                        [NameInMap("Critical")]
                        [Validation(Required=false)]
                        public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsCritical Critical { get; set; }
                        public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsCritical : TeaModel {
                            [NameInMap("ComparisonOperator")]
                            [Validation(Required=false)]
                            public string ComparisonOperator { get; set; }

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
                        public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsInfo Info { get; set; }
                        public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsInfo : TeaModel {
                            [NameInMap("ComparisonOperator")]
                            [Validation(Required=false)]
                            public string ComparisonOperator { get; set; }

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
                        public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsWarn Warn { get; set; }
                        public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsWarn : TeaModel {
                            [NameInMap("ComparisonOperator")]
                            [Validation(Required=false)]
                            public string ComparisonOperator { get; set; }

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
                    };

                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    [NameInMap("NoDataPolicy")]
                    [Validation(Required=false)]
                    public string NoDataPolicy { get; set; }

                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    [NameInMap("Selector")]
                    [Validation(Required=false)]
                    public string Selector { get; set; }

                    [NameInMap("Webhook")]
                    [Validation(Required=false)]
                    public string Webhook { get; set; }

                }

            }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("RestVersion")]
            [Validation(Required=false)]
            public string RestVersion { get; set; }
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

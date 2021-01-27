// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyMetricRuleTemplateRequest : TeaModel {
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("RestVersion")]
        [Validation(Required=false)]
        public long? RestVersion { get; set; }

        [NameInMap("AlertTemplates")]
        [Validation(Required=false)]
        public List<ModifyMetricRuleTemplateRequestAlertTemplates> AlertTemplates { get; set; }
        public class ModifyMetricRuleTemplateRequestAlertTemplates : TeaModel {
            [NameInMap("Escalations")]
            [Validation(Required=true)]
            public ModifyMetricRuleTemplateRequestAlertTemplatesEscalations Escalations { get; set; }
            public class ModifyMetricRuleTemplateRequestAlertTemplatesEscalations : TeaModel {
                [NameInMap("Info")]
                [Validation(Required=true)]
                public ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsInfo Info { get; set; }
                public class ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsInfo : TeaModel {
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }
                [NameInMap("Warn")]
                [Validation(Required=true)]
                public ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsWarn Warn { get; set; }
                public class ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsWarn : TeaModel {
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                }
                [NameInMap("Critical")]
                [Validation(Required=true)]
                public ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsCritical Critical { get; set; }
                public class ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsCritical : TeaModel {
                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                }
            };

            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            [NameInMap("Selector")]
            [Validation(Required=false)]
            public string Selector { get; set; }

            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

        }

    }

}

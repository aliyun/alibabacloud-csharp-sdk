// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutResourceMetricRulesRequest : TeaModel {
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<PutResourceMetricRulesRequestRules> Rules { get; set; }
        public class PutResourceMetricRulesRequestRules : TeaModel {
            [NameInMap("Escalations")]
            [Validation(Required=true)]
            public PutResourceMetricRulesRequestRulesEscalations Escalations { get; set; }
            public class PutResourceMetricRulesRequestRulesEscalations : TeaModel {
                [NameInMap("Info")]
                [Validation(Required=true)]
                public PutResourceMetricRulesRequestRulesEscalationsInfo Info { get; set; }
                public class PutResourceMetricRulesRequestRulesEscalationsInfo : TeaModel {
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                }
                [NameInMap("Warn")]
                [Validation(Required=true)]
                public PutResourceMetricRulesRequestRulesEscalationsWarn Warn { get; set; }
                public class PutResourceMetricRulesRequestRulesEscalationsWarn : TeaModel {
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                }
                [NameInMap("Critical")]
                [Validation(Required=true)]
                public PutResourceMetricRulesRequestRulesEscalationsCritical Critical { get; set; }
                public class PutResourceMetricRulesRequestRulesEscalationsCritical : TeaModel {
                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                }
            };

            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            [NameInMap("NoEffectiveInterval")]
            [Validation(Required=false)]
            public string NoEffectiveInterval { get; set; }

            [NameInMap("EffectiveInterval")]
            [Validation(Required=false)]
            public string EffectiveInterval { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            [NameInMap("Resources")]
            [Validation(Required=false)]
            public string Resources { get; set; }

            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public int? SilenceTime { get; set; }

            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

            [NameInMap("ContactGroups")]
            [Validation(Required=false)]
            public string ContactGroups { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("EmailSubject")]
            [Validation(Required=false)]
            public string EmailSubject { get; set; }

            [NameInMap("Period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("Interval")]
            [Validation(Required=false)]
            public string Interval { get; set; }

        }

    }

}

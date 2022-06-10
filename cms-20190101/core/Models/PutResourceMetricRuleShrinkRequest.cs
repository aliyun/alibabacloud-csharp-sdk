// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutResourceMetricRuleShrinkRequest : TeaModel {
        [NameInMap("Escalations")]
        [Validation(Required=false)]
        public PutResourceMetricRuleShrinkRequestEscalations Escalations { get; set; }
        public class PutResourceMetricRuleShrinkRequestEscalations : TeaModel {
            [NameInMap("Critical")]
            [Validation(Required=true)]
            public PutResourceMetricRuleShrinkRequestEscalationsCritical Critical { get; set; }
            public class PutResourceMetricRuleShrinkRequestEscalationsCritical : TeaModel {
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
            [Validation(Required=true)]
            public PutResourceMetricRuleShrinkRequestEscalationsInfo Info { get; set; }
            public class PutResourceMetricRuleShrinkRequestEscalationsInfo : TeaModel {
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
            [Validation(Required=true)]
            public PutResourceMetricRuleShrinkRequestEscalationsWarn Warn { get; set; }
            public class PutResourceMetricRuleShrinkRequestEscalationsWarn : TeaModel {
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

        [NameInMap("CompositeExpression")]
        [Validation(Required=false)]
        public string CompositeExpressionShrink { get; set; }

        [NameInMap("ContactGroups")]
        [Validation(Required=false)]
        public string ContactGroups { get; set; }

        [NameInMap("EffectiveInterval")]
        [Validation(Required=false)]
        public string EffectiveInterval { get; set; }

        [NameInMap("EmailSubject")]
        [Validation(Required=false)]
        public string EmailSubject { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<PutResourceMetricRuleShrinkRequestLabels> Labels { get; set; }
        public class PutResourceMetricRuleShrinkRequestLabels : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("NoDataPolicy")]
        [Validation(Required=false)]
        public string NoDataPolicy { get; set; }

        [NameInMap("NoEffectiveInterval")]
        [Validation(Required=false)]
        public string NoEffectiveInterval { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("Prometheus")]
        [Validation(Required=false)]
        public string PrometheusShrink { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public int? SilenceTime { get; set; }

        [NameInMap("Webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}

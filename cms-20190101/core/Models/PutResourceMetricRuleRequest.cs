// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutResourceMetricRuleRequest : TeaModel {
        [NameInMap("Escalations")]
        [Validation(Required=false)]
        public PutResourceMetricRuleRequestEscalations Escalations { get; set; }
        public class PutResourceMetricRuleRequestEscalations : TeaModel {
            [NameInMap("Critical")]
            [Validation(Required=true)]
            public PutResourceMetricRuleRequestEscalationsCritical Critical { get; set; }
            public class PutResourceMetricRuleRequestEscalationsCritical : TeaModel {
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
            public PutResourceMetricRuleRequestEscalationsInfo Info { get; set; }
            public class PutResourceMetricRuleRequestEscalationsInfo : TeaModel {
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
            public PutResourceMetricRuleRequestEscalationsWarn Warn { get; set; }
            public class PutResourceMetricRuleRequestEscalationsWarn : TeaModel {
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
        public List<PutResourceMetricRuleRequestLabels> Labels { get; set; }
        public class PutResourceMetricRuleRequestLabels : TeaModel {
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

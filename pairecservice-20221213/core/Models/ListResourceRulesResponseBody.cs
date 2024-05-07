// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListResourceRulesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceRules")]
        [Validation(Required=false)]
        public List<ListResourceRulesResponseBodyResourceRules> ResourceRules { get; set; }
        public class ListResourceRulesResponseBodyResourceRules : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("MetricOperationType")]
            [Validation(Required=false)]
            public string MetricOperationType { get; set; }

            [NameInMap("MetricPullInfo")]
            [Validation(Required=false)]
            public string MetricPullInfo { get; set; }

            [NameInMap("MetricPullPeriod")]
            [Validation(Required=false)]
            public string MetricPullPeriod { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ResourceRuleId")]
            [Validation(Required=false)]
            public string ResourceRuleId { get; set; }

            [NameInMap("RuleComputingDefinition")]
            [Validation(Required=false)]
            public string RuleComputingDefinition { get; set; }

            [NameInMap("RuleItems")]
            [Validation(Required=false)]
            public List<ListResourceRulesResponseBodyResourceRulesRuleItems> RuleItems { get; set; }
            public class ListResourceRulesResponseBodyResourceRulesRuleItems : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("MaxValue")]
                [Validation(Required=false)]
                public string MaxValue { get; set; }

                [NameInMap("MinValue")]
                [Validation(Required=false)]
                public string MinValue { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateResourceRuleRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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

        [NameInMap("RuleComputingDefinition")]
        [Validation(Required=false)]
        public string RuleComputingDefinition { get; set; }

        [NameInMap("RuleItems")]
        [Validation(Required=false)]
        public List<CreateResourceRuleRequestRuleItems> RuleItems { get; set; }
        public class CreateResourceRuleRequestRuleItems : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("MaxValue")]
            [Validation(Required=false)]
            public double? MaxValue { get; set; }

            [NameInMap("MinValue")]
            [Validation(Required=false)]
            public double? MinValue { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public double? Value { get; set; }

        }

    }

}

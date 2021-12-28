// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetManagedRuleResponseBody : TeaModel {
        [NameInMap("ManagedRule")]
        [Validation(Required=false)]
        public GetManagedRuleResponseBodyManagedRule ManagedRule { get; set; }
        public class GetManagedRuleResponseBodyManagedRule : TeaModel {
            [NameInMap("CompulsoryInputParameterDetails")]
            [Validation(Required=false)]
            public List<string> CompulsoryInputParameterDetails { get; set; }
            [NameInMap("ConfigRuleName")]
            [Validation(Required=false)]
            public string ConfigRuleName { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("HelpUrls")]
            [Validation(Required=false)]
            public string HelpUrls { get; set; }
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }
            [NameInMap("OptionalInputParameterDetails")]
            [Validation(Required=false)]
            public List<string> OptionalInputParameterDetails { get; set; }
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public GetManagedRuleResponseBodyManagedRuleScope Scope { get; set; }
            public class GetManagedRuleResponseBodyManagedRuleScope : TeaModel {
                [NameInMap("ComplianceResourceTypes")]
                [Validation(Required=false)]
                public List<string> ComplianceResourceTypes { get; set; }

            }
            [NameInMap("SourceDetails")]
            [Validation(Required=false)]
            public List<GetManagedRuleResponseBodyManagedRuleSourceDetails> SourceDetails { get; set; }
            public class GetManagedRuleResponseBodyManagedRuleSourceDetails : TeaModel {
                public string MaximumExecutionFrequency { get; set; }
                public string MessageType { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

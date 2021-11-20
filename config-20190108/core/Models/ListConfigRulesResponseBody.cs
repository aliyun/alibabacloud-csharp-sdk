// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class ListConfigRulesResponseBody : TeaModel {
        [NameInMap("ConfigRules")]
        [Validation(Required=false)]
        public ListConfigRulesResponseBodyConfigRules ConfigRules { get; set; }
        public class ListConfigRulesResponseBodyConfigRules : TeaModel {
            [NameInMap("ConfigRuleList")]
            [Validation(Required=false)]
            public List<ListConfigRulesResponseBodyConfigRulesConfigRuleList> ConfigRuleList { get; set; }
            public class ListConfigRulesResponseBodyConfigRulesConfigRuleList : TeaModel {
                public long? AccountId { get; set; }
                public string AutomationType { get; set; }
                public ListConfigRulesResponseBodyConfigRulesConfigRuleListCompliance Compliance { get; set; }
                public class ListConfigRulesResponseBodyConfigRulesConfigRuleListCompliance : TeaModel {
                    [NameInMap("ComplianceType")]
                    [Validation(Required=false)]
                    public string ComplianceType { get; set; }

                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                }
                public string CompliancePackId { get; set; }
                public string ConfigRuleArn { get; set; }
                public string ConfigRuleId { get; set; }
                public string ConfigRuleName { get; set; }
                public string ConfigRuleState { get; set; }
                public ListConfigRulesResponseBodyConfigRulesConfigRuleListCreateBy CreateBy { get; set; }
                public class ListConfigRulesResponseBodyConfigRulesConfigRuleListCreateBy : TeaModel {
                    [NameInMap("CompliancePackId")]
                    [Validation(Required=false)]
                    public string CompliancePackId { get; set; }

                    [NameInMap("CompliancePackName")]
                    [Validation(Required=false)]
                    public string CompliancePackName { get; set; }

                }
                public string Description { get; set; }
                public int? RiskLevel { get; set; }
                public string SourceIdentifier { get; set; }
                public string SourceOwner { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

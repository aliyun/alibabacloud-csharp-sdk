// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateConfigRulesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ConfigRules")]
        [Validation(Required=false)]
        public ListAggregateConfigRulesResponseBodyConfigRules ConfigRules { get; set; }
        public class ListAggregateConfigRulesResponseBodyConfigRules : TeaModel {
            [NameInMap("ConfigRuleList")]
            [Validation(Required=false)]
            public List<ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleList> ConfigRuleList { get; set; }
            public class ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleList : TeaModel {
                public int? RiskLevel { get; set; }
                public string SourceOwner { get; set; }
                public long? AccountId { get; set; }
                public string ConfigRuleState { get; set; }
                public ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleListCompliance Compliance { get; set; }
                public class ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleListCompliance : TeaModel {
                    [NameInMap("ComplianceType")]
                    [Validation(Required=false)]
                    public string ComplianceType { get; set; }

                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                }
                public string SourceIdentifier { get; set; }
                public string ConfigRuleArn { get; set; }
                public string Description { get; set; }
                public ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleListCreateBy CreateBy { get; set; }
                public class ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleListCreateBy : TeaModel {
                    [NameInMap("CompliancePackId")]
                    [Validation(Required=false)]
                    public string CompliancePackId { get; set; }

                    [NameInMap("AggregatorName")]
                    [Validation(Required=false)]
                    public string AggregatorName { get; set; }

                    [NameInMap("CompliancePackName")]
                    [Validation(Required=false)]
                    public string CompliancePackName { get; set; }

                    [NameInMap("CreatorName")]
                    [Validation(Required=false)]
                    public string CreatorName { get; set; }

                    [NameInMap("CreatorType")]
                    [Validation(Required=false)]
                    public string CreatorType { get; set; }

                    [NameInMap("CreatorId")]
                    [Validation(Required=false)]
                    public string CreatorId { get; set; }

                    [NameInMap("AggregatorId")]
                    [Validation(Required=false)]
                    public string AggregatorId { get; set; }

                }
                public string AutomationType { get; set; }
                public string ConfigRuleName { get; set; }
                public string ConfigRuleId { get; set; }
            }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

    }

}

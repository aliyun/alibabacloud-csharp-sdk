// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
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
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                [NameInMap("AutomationType")]
                [Validation(Required=false)]
                public string AutomationType { get; set; }

                [NameInMap("Compliance")]
                [Validation(Required=false)]
                public ListConfigRulesResponseBodyConfigRulesConfigRuleListCompliance Compliance { get; set; }
                public class ListConfigRulesResponseBodyConfigRulesConfigRuleListCompliance : TeaModel {
                    [NameInMap("ComplianceType")]
                    [Validation(Required=false)]
                    public string ComplianceType { get; set; }

                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                }

                [NameInMap("ConfigRuleArn")]
                [Validation(Required=false)]
                public string ConfigRuleArn { get; set; }

                [NameInMap("ConfigRuleId")]
                [Validation(Required=false)]
                public string ConfigRuleId { get; set; }

                [NameInMap("ConfigRuleName")]
                [Validation(Required=false)]
                public string ConfigRuleName { get; set; }

                [NameInMap("ConfigRuleState")]
                [Validation(Required=false)]
                public string ConfigRuleState { get; set; }

                [NameInMap("CreateBy")]
                [Validation(Required=false)]
                public ListConfigRulesResponseBodyConfigRulesConfigRuleListCreateBy CreateBy { get; set; }
                public class ListConfigRulesResponseBodyConfigRulesConfigRuleListCreateBy : TeaModel {
                    [NameInMap("CompliancePackId")]
                    [Validation(Required=false)]
                    public string CompliancePackId { get; set; }

                    [NameInMap("CompliancePackName")]
                    [Validation(Required=false)]
                    public string CompliancePackName { get; set; }

                }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ResourceTypesScope")]
                [Validation(Required=false)]
                public string ResourceTypesScope { get; set; }

                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

                [NameInMap("SourceIdentifier")]
                [Validation(Required=false)]
                public string SourceIdentifier { get; set; }

                [NameInMap("SourceOwner")]
                [Validation(Required=false)]
                public string SourceOwner { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListConfigRulesResponseBodyConfigRulesConfigRuleListTags> Tags { get; set; }
                public class ListConfigRulesResponseBodyConfigRulesConfigRuleListTags : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

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

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

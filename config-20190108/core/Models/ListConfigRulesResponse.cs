// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class ListConfigRulesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ConfigRules")]
        [Validation(Required=true)]
        public ListConfigRulesResponseConfigRules ConfigRules { get; set; }
        public class ListConfigRulesResponseConfigRules : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public long TotalCount { get; set; }
            [NameInMap("ConfigRuleList")]
            [Validation(Required=true)]
            public List<ListConfigRulesResponseConfigRulesConfigRuleList> ConfigRuleList { get; set; }
            public class ListConfigRulesResponseConfigRulesConfigRuleList : TeaModel {
                public long AccountId { get; set; }
                public string ConfigRuleArn { get; set; }
                public string ConfigRuleId { get; set; }
                public string ConfigRuleName { get; set; }
                public string ConfigRuleState { get; set; }
                public string Description { get; set; }
                public int? RiskLevel { get; set; }
                public string SourceIdentifier { get; set; }
                public string SourceOwner { get; set; }
                public string AutomationType { get; set; }
                public ListConfigRulesResponseConfigRulesConfigRuleListCompliance Compliance { get; set; }
                public class ListConfigRulesResponseConfigRulesConfigRuleListCompliance : TeaModel {
                    [NameInMap("ComplianceType")]
                    [Validation(Required=true)]
                    public string ComplianceType { get; set; }

                    [NameInMap("Count")]
                    [Validation(Required=true)]
                    public int? Count { get; set; }

                }
                public ListConfigRulesResponseConfigRulesConfigRuleListCreateBy CreateBy { get; set; }
                public class ListConfigRulesResponseConfigRulesConfigRuleListCreateBy : TeaModel {
                    [NameInMap("CreatorId")]
                    [Validation(Required=true)]
                    public string CreatorId { get; set; }

                    [NameInMap("CreatorName")]
                    [Validation(Required=true)]
                    public string CreatorName { get; set; }

                    [NameInMap("CreatorType")]
                    [Validation(Required=true)]
                    public string CreatorType { get; set; }

                    [NameInMap("ConfigRuleSceneId")]
                    [Validation(Required=true)]
                    public string ConfigRuleSceneId { get; set; }

                    [NameInMap("ConfigRuleSceneName")]
                    [Validation(Required=true)]
                    public string ConfigRuleSceneName { get; set; }

                }
            }
        };

    }

}

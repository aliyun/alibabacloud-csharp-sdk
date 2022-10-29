// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateForwardingRulesRequest : TeaModel {
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ForwardingRules")]
        [Validation(Required=false)]
        public List<CreateForwardingRulesRequestForwardingRules> ForwardingRules { get; set; }
        public class CreateForwardingRulesRequestForwardingRules : TeaModel {
            [NameInMap("ForwardingRuleName")]
            [Validation(Required=false)]
            public string ForwardingRuleName { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("RuleActions")]
            [Validation(Required=false)]
            public List<CreateForwardingRulesRequestForwardingRulesRuleActions> RuleActions { get; set; }
            public class CreateForwardingRulesRequestForwardingRulesRuleActions : TeaModel {
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public CreateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class CreateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfig : TeaModel {
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<CreateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class CreateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        [NameInMap("EndpointGroupId")]
                        [Validation(Required=false)]
                        public string EndpointGroupId { get; set; }

                    }

                }

                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                [NameInMap("RuleActionType")]
                [Validation(Required=false)]
                public string RuleActionType { get; set; }

                [NameInMap("RuleActionValue")]
                [Validation(Required=false)]
                public string RuleActionValue { get; set; }

            }

            [NameInMap("RuleConditions")]
            [Validation(Required=false)]
            public List<CreateForwardingRulesRequestForwardingRulesRuleConditions> RuleConditions { get; set; }
            public class CreateForwardingRulesRequestForwardingRulesRuleConditions : TeaModel {
                [NameInMap("HostConfig")]
                [Validation(Required=false)]
                public CreateForwardingRulesRequestForwardingRulesRuleConditionsHostConfig HostConfig { get; set; }
                public class CreateForwardingRulesRequestForwardingRulesRuleConditionsHostConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public CreateForwardingRulesRequestForwardingRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class CreateForwardingRulesRequestForwardingRulesRuleConditionsPathConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                [NameInMap("RuleConditionType")]
                [Validation(Required=false)]
                public string RuleConditionType { get; set; }

                [NameInMap("RuleConditionValue")]
                [Validation(Required=false)]
                public string RuleConditionValue { get; set; }

            }

            [NameInMap("RuleDirection")]
            [Validation(Required=false)]
            public string RuleDirection { get; set; }

        }

        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

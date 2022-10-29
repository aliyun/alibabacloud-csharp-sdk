// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateForwardingRulesRequest : TeaModel {
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ForwardingRules")]
        [Validation(Required=false)]
        public List<UpdateForwardingRulesRequestForwardingRules> ForwardingRules { get; set; }
        public class UpdateForwardingRulesRequestForwardingRules : TeaModel {
            [NameInMap("ForwardingRuleId")]
            [Validation(Required=false)]
            public string ForwardingRuleId { get; set; }

            [NameInMap("ForwardingRuleName")]
            [Validation(Required=false)]
            public string ForwardingRuleName { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("RuleActions")]
            [Validation(Required=false)]
            public List<UpdateForwardingRulesRequestForwardingRulesRuleActions> RuleActions { get; set; }
            public class UpdateForwardingRulesRequestForwardingRulesRuleActions : TeaModel {
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public UpdateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class UpdateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfig : TeaModel {
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<UpdateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class UpdateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
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
            public List<UpdateForwardingRulesRequestForwardingRulesRuleConditions> RuleConditions { get; set; }
            public class UpdateForwardingRulesRequestForwardingRulesRuleConditions : TeaModel {
                [NameInMap("HostConfig")]
                [Validation(Required=false)]
                public UpdateForwardingRulesRequestForwardingRulesRuleConditionsHostConfig HostConfig { get; set; }
                public class UpdateForwardingRulesRequestForwardingRulesRuleConditionsHostConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public UpdateForwardingRulesRequestForwardingRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class UpdateForwardingRulesRequestForwardingRulesRuleConditionsPathConfig : TeaModel {
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListForwardingRulesResponseBody : TeaModel {
        [NameInMap("ForwardingRules")]
        [Validation(Required=false)]
        public List<ListForwardingRulesResponseBodyForwardingRules> ForwardingRules { get; set; }
        public class ListForwardingRulesResponseBodyForwardingRules : TeaModel {
            [NameInMap("ForwardingRuleId")]
            [Validation(Required=false)]
            public string ForwardingRuleId { get; set; }

            [NameInMap("ForwardingRuleName")]
            [Validation(Required=false)]
            public string ForwardingRuleName { get; set; }

            [NameInMap("ForwardingRuleStatus")]
            [Validation(Required=false)]
            public string ForwardingRuleStatus { get; set; }

            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("RuleActions")]
            [Validation(Required=false)]
            public List<ListForwardingRulesResponseBodyForwardingRulesRuleActions> RuleActions { get; set; }
            public class ListForwardingRulesResponseBodyForwardingRulesRuleActions : TeaModel {
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public ListForwardingRulesResponseBodyForwardingRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class ListForwardingRulesResponseBodyForwardingRulesRuleActionsForwardGroupConfig : TeaModel {
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<ListForwardingRulesResponseBodyForwardingRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class ListForwardingRulesResponseBodyForwardingRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        public string EndpointGroupId { get; set; }
                    }
                };

                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                [NameInMap("RuleActionType")]
                [Validation(Required=false)]
                public string RuleActionType { get; set; }

            }

            [NameInMap("RuleConditions")]
            [Validation(Required=false)]
            public List<ListForwardingRulesResponseBodyForwardingRulesRuleConditions> RuleConditions { get; set; }
            public class ListForwardingRulesResponseBodyForwardingRulesRuleConditions : TeaModel {
                [NameInMap("HostConfig")]
                [Validation(Required=false)]
                public ListForwardingRulesResponseBodyForwardingRulesRuleConditionsHostConfig HostConfig { get; set; }
                public class ListForwardingRulesResponseBodyForwardingRulesRuleConditionsHostConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }
                };

                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public ListForwardingRulesResponseBodyForwardingRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class ListForwardingRulesResponseBodyForwardingRulesRuleConditionsPathConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }
                };

                [NameInMap("RuleConditionType")]
                [Validation(Required=false)]
                public string RuleConditionType { get; set; }

            }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

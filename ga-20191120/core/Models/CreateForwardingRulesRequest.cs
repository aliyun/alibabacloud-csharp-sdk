// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateForwardingRulesRequest : TeaModel {
        /// <summary>
        /// The ID of the GA instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. ClientToken can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
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

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("RuleActions")]
            [Validation(Required=false)]
            public List<CreateForwardingRulesRequestForwardingRulesRuleActions> RuleActions { get; set; }
            public class CreateForwardingRulesRequestForwardingRulesRuleActions : TeaModel {
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public CreateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class CreateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfig : TeaModel {
                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<CreateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class CreateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("EndpointGroupId")]
                        [Validation(Required=false)]
                        public string EndpointGroupId { get; set; }

                    }

                }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("RuleActionType")]
                [Validation(Required=false)]
                public string RuleActionType { get; set; }

                [NameInMap("RuleActionValue")]
                [Validation(Required=false)]
                public string RuleActionValue { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
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

        /// <summary>
        /// The ID of the listener.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

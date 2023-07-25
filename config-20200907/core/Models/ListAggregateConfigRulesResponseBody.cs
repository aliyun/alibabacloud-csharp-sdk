// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateConfigRulesResponseBody : TeaModel {
        /// <summary>
        /// The rules.
        /// </summary>
        [NameInMap("ConfigRules")]
        [Validation(Required=false)]
        public ListAggregateConfigRulesResponseBodyConfigRules ConfigRules { get; set; }
        public class ListAggregateConfigRulesResponseBodyConfigRules : TeaModel {
            /// <summary>
            /// The details of the rules.
            /// </summary>
            [NameInMap("ConfigRuleList")]
            [Validation(Required=false)]
            public List<ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleList> ConfigRuleList { get; set; }
            public class ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleList : TeaModel {
                /// <summary>
                /// The ID of the management account to which the rules belong.
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// The type of the remediation template. Valid value: OOS, which stands for Operation Orchestration Service.
                /// </summary>
                [NameInMap("AutomationType")]
                [Validation(Required=false)]
                public string AutomationType { get; set; }

                /// <summary>
                /// The compliance evaluation result.
                /// </summary>
                [NameInMap("Compliance")]
                [Validation(Required=false)]
                public ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleListCompliance Compliance { get; set; }
                public class ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleListCompliance : TeaModel {
                    /// <summary>
                    /// The summary result of the rule compliance evaluation. Valid values:
                    /// 
                    /// *   COMPLIANT: The resource was evaluated as compliant.
                    /// *   NON_COMPLIANT: The resource was evaluated as incompliant.
                    /// *   NOT_APPLICABLE: The rule did not apply to your resources.
                    /// *   INSUFFICIENT_DATA: No resource data was available.
                    /// </summary>
                    [NameInMap("ComplianceType")]
                    [Validation(Required=false)]
                    public string ComplianceType { get; set; }

                    /// <summary>
                    /// The number of evaluation resources that correspond to the summary result of the rule compliance evaluation.
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                }

                /// <summary>
                /// The ARN of the rule.
                /// </summary>
                [NameInMap("ConfigRuleArn")]
                [Validation(Required=false)]
                public string ConfigRuleArn { get; set; }

                /// <summary>
                /// The rule ID.
                /// </summary>
                [NameInMap("ConfigRuleId")]
                [Validation(Required=false)]
                public string ConfigRuleId { get; set; }

                /// <summary>
                /// The name of the rule.
                /// </summary>
                [NameInMap("ConfigRuleName")]
                [Validation(Required=false)]
                public string ConfigRuleName { get; set; }

                /// <summary>
                /// The status of the rule. Valid values:
                /// 
                /// *   ACTIVE: The rule is being used to monitor resource configurations.
                /// *   DELETING: The rule is being deleted.
                /// *   EVALUATING: The rule is triggered and is being used to monitor resource configurations.
                /// *   INACTIVE: The rule is disabled.
                /// </summary>
                [NameInMap("ConfigRuleState")]
                [Validation(Required=false)]
                public string ConfigRuleState { get; set; }

                /// <summary>
                /// The information about the creation of the rule.
                /// </summary>
                [NameInMap("CreateBy")]
                [Validation(Required=false)]
                public ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleListCreateBy CreateBy { get; set; }
                public class ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleListCreateBy : TeaModel {
                    /// <summary>
                    /// The ID of the account group.
                    /// </summary>
                    [NameInMap("AggregatorId")]
                    [Validation(Required=false)]
                    public string AggregatorId { get; set; }

                    /// <summary>
                    /// The name of the account group.
                    /// </summary>
                    [NameInMap("AggregatorName")]
                    [Validation(Required=false)]
                    public string AggregatorName { get; set; }

                    /// <summary>
                    /// The ID of the compliance package.
                    /// </summary>
                    [NameInMap("CompliancePackId")]
                    [Validation(Required=false)]
                    public string CompliancePackId { get; set; }

                    /// <summary>
                    /// The name of the compliance package.
                    /// </summary>
                    [NameInMap("CompliancePackName")]
                    [Validation(Required=false)]
                    public string CompliancePackName { get; set; }

                    /// <summary>
                    /// The ID of the management account that was used to create the rule.
                    /// </summary>
                    [NameInMap("CreatorId")]
                    [Validation(Required=false)]
                    public string CreatorId { get; set; }

                    /// <summary>
                    /// The name of the management account that was used to create the rule.
                    /// </summary>
                    [NameInMap("CreatorName")]
                    [Validation(Required=false)]
                    public string CreatorName { get; set; }

                    /// <summary>
                    /// The type of the creator of the rule. The value is fixed to AGGREGATOR, which indicates an account group.
                    /// </summary>
                    [NameInMap("CreatorType")]
                    [Validation(Required=false)]
                    public string CreatorType { get; set; }

                }

                /// <summary>
                /// The description of the rule.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ResourceTypesScope")]
                [Validation(Required=false)]
                public string ResourceTypesScope { get; set; }

                /// <summary>
                /// The risk level of the resources that do not comply with the rule. Valid values:
                /// 
                /// *   1: high
                /// *   2: medium
                /// *   3: low
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

                /// <summary>
                /// The identifier of the rule.
                /// 
                /// *   If the rule was created based on a managed rule, the value of this parameter is the name of the managed rule.
                /// *   If the rule is a custom rule, the value of this parameter is the Alibaba Cloud Resource Name (ARN) of the relevant function in Function Compute.
                /// </summary>
                [NameInMap("SourceIdentifier")]
                [Validation(Required=false)]
                public string SourceIdentifier { get; set; }

                /// <summary>
                /// The method that is used to create the rule. Valid values:
                /// 
                /// *   CUSTOM_FC: a custom rule.
                /// *   ALIYUN: a managed rule.
                /// </summary>
                [NameInMap("SourceOwner")]
                [Validation(Required=false)]
                public string SourceOwner { get; set; }

                /// <summary>
                /// The tags of the rule.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleListTags> Tags { get; set; }
                public class ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleListTags : TeaModel {
                    /// <summary>
                    /// The tag key of the rule.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The tag value of the rule.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// The number of the page returned.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of rules.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

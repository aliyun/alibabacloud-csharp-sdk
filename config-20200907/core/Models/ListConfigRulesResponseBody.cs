// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListConfigRulesResponseBody : TeaModel {
        /// <summary>
        /// The queried rules.
        /// </summary>
        [NameInMap("ConfigRules")]
        [Validation(Required=false)]
        public ListConfigRulesResponseBodyConfigRules ConfigRules { get; set; }
        public class ListConfigRulesResponseBodyConfigRules : TeaModel {
            /// <summary>
            /// The rule list.
            /// </summary>
            [NameInMap("ConfigRuleList")]
            [Validation(Required=false)]
            public List<ListConfigRulesResponseBodyConfigRulesConfigRuleList> ConfigRuleList { get; set; }
            public class ListConfigRulesResponseBodyConfigRulesConfigRuleList : TeaModel {
                /// <summary>
                /// The ID of the management account to which the rule belongs.
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// The type of the remediation template. Valid value: OOS, which indicates Operation Orchestration Service.
                /// </summary>
                [NameInMap("AutomationType")]
                [Validation(Required=false)]
                public string AutomationType { get; set; }

                /// <summary>
                /// The compliance evaluation result.
                /// </summary>
                [NameInMap("Compliance")]
                [Validation(Required=false)]
                public ListConfigRulesResponseBodyConfigRulesConfigRuleListCompliance Compliance { get; set; }
                public class ListConfigRulesResponseBodyConfigRulesConfigRuleListCompliance : TeaModel {
                    /// <summary>
                    /// The compliance evaluation result. Valid values:
                    /// 
                    /// - COMPLIANT: The resource is evaluated as compliant.
                    /// 
                    /// - NON_COMPLIANT: The resource is evaluated as non-compliant.
                    /// 
                    /// - NOT_APPLICABLE: The rule does not apply to the resource.
                    /// 
                    /// - INSUFFICIENT_DATA: No resource data is available.
                    /// </summary>
                    [NameInMap("ComplianceType")]
                    [Validation(Required=false)]
                    public string ComplianceType { get; set; }

                    /// <summary>
                    /// The number of evaluated resources.
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
                /// The rule name.
                /// </summary>
                [NameInMap("ConfigRuleName")]
                [Validation(Required=false)]
                public string ConfigRuleName { get; set; }

                /// <summary>
                /// The status of the rule. Valid values:
                /// 
                /// - ACTIVE: The rule is enabled.
                /// 
                /// - DELETING: The rule is being deleted.
                /// 
                /// - EVALUATING: The rule is triggered and is being used to monitor resource configurations.
                /// 
                /// - INACTIVE: The rule is disabled.
                /// </summary>
                [NameInMap("ConfigRuleState")]
                [Validation(Required=false)]
                public string ConfigRuleState { get; set; }

                /// <summary>
                /// The information about the creation of the rule.
                /// </summary>
                [NameInMap("CreateBy")]
                [Validation(Required=false)]
                public ListConfigRulesResponseBodyConfigRulesConfigRuleListCreateBy CreateBy { get; set; }
                public class ListConfigRulesResponseBodyConfigRulesConfigRuleListCreateBy : TeaModel {
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

                }

                /// <summary>
                /// The description of the rule.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The types of resources evaluated by the rule. Multiple resource types are separated with commas (,).
                /// </summary>
                [NameInMap("ResourceTypesScope")]
                [Validation(Required=false)]
                public string ResourceTypesScope { get; set; }

                /// <summary>
                /// The risk level of the resources that are not compliant with the rule. Valid values:
                /// 
                /// - 1: high
                /// 
                /// - 2: medium
                /// 
                /// - 3: low
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

                /// <summary>
                /// The ID of the rule.
                /// 
                /// - If the rule is a managed rule, the value of this parameter is the name of the managed rule.
                /// 
                /// - If the rule is a custom rule, the value of this parameter is the Alibaba Cloud Resource Name (ARN) of the relevant function in Function Compute.
                /// </summary>
                [NameInMap("SourceIdentifier")]
                [Validation(Required=false)]
                public string SourceIdentifier { get; set; }

                /// <summary>
                /// The type of the rule. Valid values:
                /// 
                /// - CUSTOM_FC: custom rule
                /// 
                /// - ALIYUN: managed rule
                /// </summary>
                [NameInMap("SourceOwner")]
                [Validation(Required=false)]
                public string SourceOwner { get; set; }

                /// <summary>
                /// The tags of the rule.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListConfigRulesResponseBodyConfigRulesConfigRuleListTags> Tags { get; set; }
                public class ListConfigRulesResponseBodyConfigRulesConfigRuleListTags : TeaModel {
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
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
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

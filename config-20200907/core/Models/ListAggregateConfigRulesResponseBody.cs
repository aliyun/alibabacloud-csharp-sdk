// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateConfigRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried rules.</para>
        /// </summary>
        [NameInMap("ConfigRules")]
        [Validation(Required=false)]
        public ListAggregateConfigRulesResponseBodyConfigRules ConfigRules { get; set; }
        public class ListAggregateConfigRulesResponseBodyConfigRules : TeaModel {
            /// <summary>
            /// <para>The details of the rule.</para>
            /// </summary>
            [NameInMap("ConfigRuleList")]
            [Validation(Required=false)]
            public List<ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleList> ConfigRuleList { get; set; }
            public class ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleList : TeaModel {
                /// <summary>
                /// <para>The ID of the management account to which the rules belong.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100931896542****</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// <para>The type of the remediation template. Only OOS is returned, which indicates CloudOps Orchestration Service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OOS</para>
                /// </summary>
                [NameInMap("AutomationType")]
                [Validation(Required=false)]
                public string AutomationType { get; set; }

                /// <summary>
                /// <para>The compliance evaluation result.</para>
                /// </summary>
                [NameInMap("Compliance")]
                [Validation(Required=false)]
                public ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleListCompliance Compliance { get; set; }
                public class ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleListCompliance : TeaModel {
                    /// <summary>
                    /// <para>The compliance evaluation result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>COMPLIANT: The resources are evaluated as compliant.</description></item>
                    /// <item><description>NON_COMPLIANT: The resources are evaluated as non-compliant.</description></item>
                    /// <item><description>NOT_APPLICABLE: The rule does not apply to the resources.</description></item>
                    /// <item><description>INSUFFICIENT_DATA: No data is available.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>COMPLIANT</para>
                    /// </summary>
                    [NameInMap("ComplianceType")]
                    [Validation(Required=false)]
                    public string ComplianceType { get; set; }

                    /// <summary>
                    /// <para>The number of evaluation resources that correspond to the summary result of the rule compliance evaluation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                }

                /// <summary>
                /// <para>The ARN of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:config::100931896542****:rule/cr-fdc8626622af00f9****</para>
                /// </summary>
                [NameInMap("ConfigRuleArn")]
                [Validation(Required=false)]
                public string ConfigRuleArn { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cr-fdc8626622af00f9****</para>
                /// </summary>
                [NameInMap("ConfigRuleId")]
                [Validation(Required=false)]
                public string ConfigRuleId { get; set; }

                /// <summary>
                /// <para>The name of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-rule-name</para>
                /// </summary>
                [NameInMap("ConfigRuleName")]
                [Validation(Required=false)]
                public string ConfigRuleName { get; set; }

                /// <summary>
                /// <para>The status of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ACTIVE: The rule is being used to monitor resource configurations.</description></item>
                /// <item><description>DELETING: The rule is being deleted.</description></item>
                /// <item><description>EVALUATING: The rule is triggered and is being used to monitor resource configurations.</description></item>
                /// <item><description>INACTIVE: The rule is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ACTIVE</para>
                /// </summary>
                [NameInMap("ConfigRuleState")]
                [Validation(Required=false)]
                public string ConfigRuleState { get; set; }

                /// <summary>
                /// <para>The information about the creation of the rule.</para>
                /// </summary>
                [NameInMap("CreateBy")]
                [Validation(Required=false)]
                public ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleListCreateBy CreateBy { get; set; }
                public class ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleListCreateBy : TeaModel {
                    /// <summary>
                    /// <para>The account group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ca-f632626622af0079****</para>
                    /// </summary>
                    [NameInMap("AggregatorId")]
                    [Validation(Required=false)]
                    public string AggregatorId { get; set; }

                    /// <summary>
                    /// <para>The name of the account group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test_Group</para>
                    /// </summary>
                    [NameInMap("AggregatorName")]
                    [Validation(Required=false)]
                    public string AggregatorName { get; set; }

                    /// <summary>
                    /// <para>The compliance package ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cp-fdc8626622af00f9****</para>
                    /// </summary>
                    [NameInMap("CompliancePackId")]
                    [Validation(Required=false)]
                    public string CompliancePackId { get; set; }

                    /// <summary>
                    /// <para>The name of the compliance package.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-pack-name</para>
                    /// </summary>
                    [NameInMap("CompliancePackName")]
                    [Validation(Required=false)]
                    public string CompliancePackName { get; set; }

                    /// <summary>
                    /// <para>The ID of the management account that created the rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100931896542****</para>
                    /// </summary>
                    [NameInMap("CreatorId")]
                    [Validation(Required=false)]
                    public string CreatorId { get; set; }

                    /// <summary>
                    /// <para>The name of the management account that create the rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Alice</para>
                    /// </summary>
                    [NameInMap("CreatorName")]
                    [Validation(Required=false)]
                    public string CreatorName { get; set; }

                    /// <summary>
                    /// <para>The type of the creator of the rule. The value is fixed to AGGREGATOR, which indicates an account group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AGGREGATOR</para>
                    /// </summary>
                    [NameInMap("CreatorType")]
                    [Validation(Required=false)]
                    public string CreatorType { get; set; }

                }

                /// <summary>
                /// <para>The description of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The description of the test rule.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The types of resources evaluated by the rule. Multiple resource types are separated with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS::EIP::EipAddress</para>
                /// </summary>
                [NameInMap("ResourceTypesScope")]
                [Validation(Required=false)]
                public string ResourceTypesScope { get; set; }

                /// <summary>
                /// <para>The risk level of the resources that do not comply with the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: high</description></item>
                /// <item><description>2: medium</description></item>
                /// <item><description>3: low</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

                /// <summary>
                /// <para>The identifier of the rule.</para>
                /// <list type="bullet">
                /// <item><description>If the rule is a managed rule, the value of this parameter is the name of the managed rule.</description></item>
                /// <item><description>If the rule is a custom rule, the value of this parameter is the Alibaba Cloud Resource Name (ARN) of a function.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>eip-bandwidth-limit</para>
                /// </summary>
                [NameInMap("SourceIdentifier")]
                [Validation(Required=false)]
                public string SourceIdentifier { get; set; }

                /// <summary>
                /// <para>The type of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CUSTOM_FC: a custom rule.</description></item>
                /// <item><description>ALIYUN: a managed rule.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN</para>
                /// </summary>
                [NameInMap("SourceOwner")]
                [Validation(Required=false)]
                public string SourceOwner { get; set; }

                /// <summary>
                /// <para>The tags of the rule.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleListTags> Tags { get; set; }
                public class ListAggregateConfigRulesResponseBodyConfigRulesConfigRuleListTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key of the rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>env</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The tag value of the rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>prod</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The number of the page returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22EF8287-2C9A-4F1F-80A6-CEFA7612689D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

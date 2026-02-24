// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListConfigRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of rules.</para>
        /// </summary>
        [NameInMap("ConfigRules")]
        [Validation(Required=false)]
        public ListConfigRulesResponseBodyConfigRules ConfigRules { get; set; }
        public class ListConfigRulesResponseBodyConfigRules : TeaModel {
            /// <summary>
            /// <para>The details of the rules.</para>
            /// </summary>
            [NameInMap("ConfigRuleList")]
            [Validation(Required=false)]
            public List<ListConfigRulesResponseBodyConfigRulesConfigRuleList> ConfigRuleList { get; set; }
            public class ListConfigRulesResponseBodyConfigRulesConfigRuleList : TeaModel {
                /// <summary>
                /// <para>The ID of the account to which the rule belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100931896542****</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// <para>The remediation type. Only Operation Orchestration Service (OOS) is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OOS</para>
                /// </summary>
                [NameInMap("AutomationType")]
                [Validation(Required=false)]
                public string AutomationType { get; set; }

                /// <summary>
                /// <para>The compliance aggregation results of the rule.</para>
                /// </summary>
                [NameInMap("Compliance")]
                [Validation(Required=false)]
                public ListConfigRulesResponseBodyConfigRulesConfigRuleListCompliance Compliance { get; set; }
                public class ListConfigRulesResponseBodyConfigRulesConfigRuleListCompliance : TeaModel {
                    /// <summary>
                    /// <para>The summary of the compliance evaluation result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>COMPLIANT: Compliant.</para>
                    /// </description></item>
                    /// <item><description><para>NON_COMPLIANT: Non-compliant.</para>
                    /// </description></item>
                    /// <item><description><para>NOT_APPLICABLE: Not applicable.</para>
                    /// </description></item>
                    /// <item><description><para>INSUFFICIENT_DATA: Insufficient data.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>COMPLIANT</para>
                    /// </summary>
                    [NameInMap("ComplianceType")]
                    [Validation(Required=false)]
                    public string ComplianceType { get; set; }

                    /// <summary>
                    /// <para>The number of evaluated resources that correspond to the compliance summary.</para>
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
                /// <para>The name of the rule.</para>
                /// </summary>
                [NameInMap("ConfigRuleName")]
                [Validation(Required=false)]
                public string ConfigRuleName { get; set; }

                /// <summary>
                /// <para>The state of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>ACTIVE: The rule is enabled.</para>
                /// </description></item>
                /// <item><description><para>DELETING: The rule is being deleted.</para>
                /// </description></item>
                /// <item><description><para>EVALUATING: The rule is being evaluated.</para>
                /// </description></item>
                /// <item><description><para>INACTIVE: The rule is disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ACTIVE</para>
                /// </summary>
                [NameInMap("ConfigRuleState")]
                [Validation(Required=false)]
                public string ConfigRuleState { get; set; }

                /// <summary>
                /// <para>The information about the creator of the rule.</para>
                /// </summary>
                [NameInMap("CreateBy")]
                [Validation(Required=false)]
                public ListConfigRulesResponseBodyConfigRulesConfigRuleListCreateBy CreateBy { get; set; }
                public class ListConfigRulesResponseBodyConfigRulesConfigRuleListCreateBy : TeaModel {
                    /// <summary>
                    /// <para>The ID of the compliance package.</para>
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
                    /// <para>The name of the compliance package.</para>
                    /// </summary>
                    [NameInMap("CompliancePackName")]
                    [Validation(Required=false)]
                    public string CompliancePackName { get; set; }

                }

                /// <summary>
                /// <para>The time when the rule was created. The time is displayed in UTC+8.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-09-19T15:51:00</para>
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                /// <summary>
                /// <para>The description of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The description of the rule.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The types of resources evaluated by the rule. Multiple resource types are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS::EIP::EipAddress</para>
                /// </summary>
                [NameInMap("ResourceTypesScope")]
                [Validation(Required=false)]
                public string ResourceTypesScope { get; set; }

                /// <summary>
                /// <para>The risk level of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>1: High risk.</para>
                /// </description></item>
                /// <item><description><para>2: Medium risk.</para>
                /// </description></item>
                /// <item><description><para>3: Low risk.</para>
                /// </description></item>
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
                /// <item><description><para>If the rule is a managed rule, this parameter indicates the identifier of the managed rule.</para>
                /// </description></item>
                /// <item><description><para>If the rule is a custom rule, this parameter indicates the Alibaba Cloud Resource Name (ARN) of the function.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>eip-bandwidth-limit</para>
                /// </summary>
                [NameInMap("SourceIdentifier")]
                [Validation(Required=false)]
                public string SourceIdentifier { get; set; }

                /// <summary>
                /// <para>The owner of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>CUSTOM_FC: a custom rule created using a Function Compute (FC) function.</para>
                /// </description></item>
                /// <item><description><para>ALIYUN: a managed rule.</para>
                /// </description></item>
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
                public List<ListConfigRulesResponseBodyConfigRulesConfigRuleListTags> Tags { get; set; }
                public class ListConfigRulesResponseBodyConfigRulesConfigRuleListTags : TeaModel {
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
            /// <para>The page number.</para>
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
        /// <para>AC3A7E12-72E6-5CC9-A5C1-D8D8919829A7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

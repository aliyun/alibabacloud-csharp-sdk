// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetSecuritySuggestionListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <list type="bullet">
        /// <item><description><b>200</b>: Success.</description></item>
        /// <item><description><b>Other (400, 500)</b>: Failure.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSecuritySuggestionListResponseBodyData Data { get; set; }
        public class GetSecuritySuggestionListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of rules.</para>
            /// </summary>
            [NameInMap("ConfigRuleList")]
            [Validation(Required=false)]
            public List<GetSecuritySuggestionListResponseBodyDataConfigRuleList> ConfigRuleList { get; set; }
            public class GetSecuritySuggestionListResponseBodyDataConfigRuleList : TeaModel {
                /// <summary>
                /// <para>The ID of the account to which the rule belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1625772519123804</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// <para>The remediation type. Only OOS (CloudOps Orchestration Service) is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OOS</para>
                /// </summary>
                [NameInMap("AutomationType")]
                [Validation(Required=false)]
                public string AutomationType { get; set; }

                /// <summary>
                /// <para>The aggregated compliance result of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{count=1, complianceType=NON_COMPLIANT}</para>
                /// </summary>
                [NameInMap("Compliance")]
                [Validation(Required=false)]
                public string Compliance { get; set; }

                /// <summary>
                /// <para>The aggregated compliance result of the rule.</para>
                /// </summary>
                [NameInMap("ComplianceObject")]
                [Validation(Required=false)]
                public GetSecuritySuggestionListResponseBodyDataConfigRuleListComplianceObject ComplianceObject { get; set; }
                public class GetSecuritySuggestionListResponseBodyDataConfigRuleListComplianceObject : TeaModel {
                    /// <summary>
                    /// <para>The compliance evaluation result of the rule. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>COMPLIANT</b>: Compliant.</description></item>
                    /// <item><description><b>NON_COMPLIANT</b>: Non-compliant.</description></item>
                    /// <item><description><b>NOT_APPLICABLE</b>: Not applicable.</description></item>
                    /// <item><description><b>INSUFFICIENT_DATA</b>: Insufficient data.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NON_COMPLIANT</para>
                    /// </summary>
                    [NameInMap("ComplianceType")]
                    [Validation(Required=false)]
                    public string ComplianceType { get; set; }

                    /// <summary>
                    /// <para>The number of evaluations corresponding to the summary result of the rule evaluation.</para>
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
                /// <para>cr-bqa2f25bc5ce00af6323</para>
                /// </summary>
                [NameInMap("ConfigRuleId")]
                [Validation(Required=false)]
                public string ConfigRuleId { get; set; }

                /// <summary>
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The name of the rule.</para>
                /// </summary>
                [NameInMap("ConfigRuleName")]
                [Validation(Required=false)]
                public string ConfigRuleName { get; set; }

                /// <summary>
                /// <para>The rule running status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ACTIVE</b>: Active.</description></item>
                /// <item><description><b>DELETING</b>: Being deleted.</description></item>
                /// <item><description><b>EVALUATING</b>: Being evaluated.</description></item>
                /// <item><description><b>INACTIVE</b>: Inactive.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ACTIVE</para>
                /// </summary>
                [NameInMap("ConfigRuleState")]
                [Validation(Required=false)]
                public string ConfigRuleState { get; set; }

                /// <summary>
                /// <para>The information about the rule creator.</para>
                /// </summary>
                [NameInMap("CreateBy")]
                [Validation(Required=false)]
                public GetSecuritySuggestionListResponseBodyDataConfigRuleListCreateBy CreateBy { get; set; }
                public class GetSecuritySuggestionListResponseBodyDataConfigRuleListCreateBy : TeaModel {
                    /// <summary>
                    /// <para>The ID of the compliance package to which the rule belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cp-fdc8626622af00f9****</para>
                    /// </summary>
                    [NameInMap("CompliancePackId")]
                    [Validation(Required=false)]
                    public string CompliancePackId { get; set; }

                    /// <summary>
                    /// <para>The compliance package name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The name of the compliance package.</para>
                    /// </summary>
                    [NameInMap("CompliancePackName")]
                    [Validation(Required=false)]
                    public string CompliancePackName { get; set; }

                }

                /// <summary>
                /// <para>The rule description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The description of the rule.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The resource type scope. Multiple resource types are separated by commas (,).</para>
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
                /// <item><description><b>1</b>: High risk.</description></item>
                /// <item><description><b>2</b>: Medium risk.</description></item>
                /// <item><description><b>3</b>: Low risk.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

                /// <summary>
                /// <para>The rule identifier.</para>
                /// <list type="bullet">
                /// <item><description><para>If the rule uses a managed rule, this parameter is the managed rule name.</para>
                /// </description></item>
                /// <item><description><para>If the rule uses a custom function, this parameter is the function ARN.</para>
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
                /// <para>The owner of the rule source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>CUSTOM_FC</b>: Custom rule.</description></item>
                /// <item><description><b>ALIYUN</b>: Rule template.</description></item>
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
                public List<GetSecuritySuggestionListResponseBodyDataConfigRuleListTags> Tags { get; set; }
                public class GetSecuritySuggestionListResponseBodyDataConfigRuleListTags : TeaModel {
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
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>51</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>855FCC89-0B13-5FC0-AAD2-120878081C1C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.         </description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UpdateAggregateCompliancePackRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the account group.</para>
        /// <para>For more information about how to obtain the ID of an account group, see <a href="https://help.aliyun.com/document_detail/255797.html">ListAggregators</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-f632626622af0079****</para>
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// <para>The client token that you want to use to ensure the idempotency of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.``</para>
        /// 
        /// <b>Example:</b>
        /// <para>1594295238-f9361358-5843-4294-8d30-b5183fac****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the compliance package.</para>
        /// <para>For more information about how to obtain the ID of a compliance package, see <a href="https://help.aliyun.com/document_detail/262059.html">ListAggregateCompliancePacks</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cp-fdc8626622af00f9****</para>
        /// </summary>
        [NameInMap("CompliancePackId")]
        [Validation(Required=false)]
        public string CompliancePackId { get; set; }

        /// <summary>
        /// <para>The name of the compliance package.</para>
        /// <para>For more information about how to obtain the name of a compliance package, see <a href="https://help.aliyun.com/document_detail/262059.html">ListAggregateCompliancePacks</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-pack-name</para>
        /// </summary>
        [NameInMap("CompliancePackName")]
        [Validation(Required=false)]
        public string CompliancePackName { get; set; }

        /// <summary>
        /// <para>The rules in the compliance package.</para>
        /// <para>If you leave this parameter empty, the rules in the compliance package remain unchanged. If you set this parameter, Cloud Config replaces the existing rules in the compliance package with the specified rules.</para>
        /// </summary>
        [NameInMap("ConfigRules")]
        [Validation(Required=false)]
        public List<UpdateAggregateCompliancePackRequestConfigRules> ConfigRules { get; set; }
        public class UpdateAggregateCompliancePackRequestConfigRules : TeaModel {
            /// <summary>
            /// <para>The rule ID. If you specify this parameter, Cloud Config adds the rule that has the specified ID to the compliance package.</para>
            /// <para>You only need to configure the <c>ManagedRuleIdentifier</c> or <c>ConfigRuleId</c> parameter. If you configure both parameters, the value of the <c>ConfigRuleId</c> parameter takes precedence. For more information about how to obtain the ID of a rule, see <a href="https://help.aliyun.com/document_detail/264148.html">ListAggregateConfigRules</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cr-e918626622af000f****</para>
            /// </summary>
            [NameInMap("ConfigRuleId")]
            [Validation(Required=false)]
            public string ConfigRuleId { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-rule-name</para>
            /// </summary>
            [NameInMap("ConfigRuleName")]
            [Validation(Required=false)]
            public string ConfigRuleName { get; set; }

            /// <summary>
            /// <para>The details of the input parameter of the rule.</para>
            /// </summary>
            [NameInMap("ConfigRuleParameters")]
            [Validation(Required=false)]
            public List<UpdateAggregateCompliancePackRequestConfigRulesConfigRuleParameters> ConfigRuleParameters { get; set; }
            public class UpdateAggregateCompliancePackRequestConfigRulesConfigRuleParameters : TeaModel {
                /// <summary>
                /// <para>The name of the input parameter.</para>
                /// <para>You must specify both <c>ParameterName</c> and <c>ParameterValue</c> or neither of them. If the managed rule has an input parameter but no default value exists, you must configure this parameter. For more information about how to obtain the name of an input parameter for a managed rule, see <a href="https://help.aliyun.com/document_detail/261176.html">ListCompliancePackTemplates</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bandwidth</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// <para>The value of the input parameter.</para>
                /// <para>You must specify both <c>ParameterName</c> and <c>ParameterValue</c> or neither of them. If the managed rule has an input parameter but no default value exists, you must configure this parameter. For more information about how to obtain the value of an input parameter for a managed rule, see <a href="https://help.aliyun.com/document_detail/261176.html">ListCompliancePackTemplates</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

            /// <summary>
            /// <para>The rule description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The description of the test rule.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The identifier of the managed rule. Cloud Config automatically creates a rule based on the identifier of the managed rule and adds the rule to the current compliance package.</para>
            /// <para>You need to only configure the <c>ManagedRuleIdentifier</c> or <c>ConfigRuleId</c> parameter. If you configure both parameters, the value of the <c>ConfigRuleId</c> parameter takes precedence. You can call the <a href="https://help.aliyun.com/document_detail/261176.html">ListCompliancePackTemplates</a> operation to obtain the identifier of the managed rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip-bandwidth-limit</para>
            /// </summary>
            [NameInMap("ManagedRuleIdentifier")]
            [Validation(Required=false)]
            public string ManagedRuleIdentifier { get; set; }

            /// <summary>
            /// <para>The risk level of the resources that do not comply with the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: high risk level</description></item>
            /// <item><description>2: medium risk level</description></item>
            /// <item><description>3: low risk level</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

        }

        /// <summary>
        /// <para>The description of the compliance package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test compliance pack description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The IDs of the regions to which the rule not applies. Separate multiple region IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("ExcludeRegionIdsScope")]
        [Validation(Required=false)]
        public string ExcludeRegionIdsScope { get; set; }

        /// <summary>
        /// <para>ExcludeResourceGroupIdsScope. Separate multiple resource group IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bnczc6r7rml****</para>
        /// </summary>
        [NameInMap("ExcludeResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceGroupIdsScope { get; set; }

        /// <summary>
        /// <para>The ID of the resource that you do not want to evaluate by using the compliance package. Separate multiple resource IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-8vbf3x310fn56ijfd****</para>
        /// </summary>
        [NameInMap("ExcludeResourceIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceIdsScope { get; set; }

        /// <summary>
        /// <para>ExcludeTagsScope</para>
        /// </summary>
        [NameInMap("ExcludeTagsScope")]
        [Validation(Required=false)]
        public List<UpdateAggregateCompliancePackRequestExcludeTagsScope> ExcludeTagsScope { get; set; }
        public class UpdateAggregateCompliancePackRequestExcludeTagsScope : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-2</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value-2</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>The ID of the region whose resources you want to evaluate by using the compliance package. Separate multiple region IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionIdsScope")]
        [Validation(Required=false)]
        public string RegionIdsScope { get; set; }

        /// <summary>
        /// <para>The ID of the resource group whose resources you want to evaluate by using the compliance package. Separate multiple resource group IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzc7r7rhx****</para>
        /// </summary>
        [NameInMap("ResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ResourceGroupIdsScope { get; set; }

        /// <summary>
        /// <para>The IDs of the resources included from the compliance evaluations performed by the rule. Separate multiple resource IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5cmbowstbkss9ta03****</para>
        /// </summary>
        [NameInMap("ResourceIdsScope")]
        [Validation(Required=false)]
        public string ResourceIdsScope { get; set; }

        /// <summary>
        /// <para>The risk level of the resources that are not compliant with the rules in the compliance package. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: high risk level</description></item>
        /// <item><description>2: medium risk level</description></item>
        /// <item><description>3: low risk level</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public int? RiskLevel { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// <para>You can add up to 20 tags to a resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<UpdateAggregateCompliancePackRequestTag> Tag { get; set; }
        public class UpdateAggregateCompliancePackRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys.</para>
            /// <para>The tag key cannot be an empty string. The tag key must be 1 to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs</c>:. The tag key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag values.</para>
            /// <para>The tag values can be an empty string or up to 128 characters in length. The tag values cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>Each key-value must be unique. You can specify at most 20 tag values in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value-1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The tag key of the resource that you want to evaluate by using the compliance package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("TagKeyScope")]
        [Validation(Required=false)]
        public string TagKeyScope { get; set; }

        /// <summary>
        /// <para>The tag value of the resource that you want to evaluate by using the compliance package.</para>
        /// <remarks>
        /// <para> You must configure the TagValueScope parameter together with the TagKeyScope parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TagValueScope")]
        [Validation(Required=false)]
        public string TagValueScope { get; set; }

        /// <summary>
        /// <para>TagsScope</para>
        /// </summary>
        [NameInMap("TagsScope")]
        [Validation(Required=false)]
        public List<UpdateAggregateCompliancePackRequestTagsScope> TagsScope { get; set; }
        public class UpdateAggregateCompliancePackRequestTagsScope : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-1</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value-1</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

    }

}

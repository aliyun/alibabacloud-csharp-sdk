// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UpdateCompliancePackRequest : TeaModel {
        /// <summary>
        /// <para>A client token to ensure the idempotence of the request. Generate a unique token for each request. The <c>ClientToken</c> value can contain only ASCII characters and must be no more than 64 characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1594295238-f9361358-5843-4294-8d30-b5183fac****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the compliance pack.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/263332.html">ListCompliancePacks</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cp-a8a8626622af0082****</para>
        /// </summary>
        [NameInMap("CompliancePackId")]
        [Validation(Required=false)]
        public string CompliancePackId { get; set; }

        /// <summary>
        /// <para>The name of the compliance pack.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/263332.html">ListCompliancePacks</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>等保三级预检合规包</para>
        /// </summary>
        [NameInMap("CompliancePackName")]
        [Validation(Required=false)]
        public string CompliancePackName { get; set; }

        /// <summary>
        /// <para>The rules in the compliance pack.</para>
        /// <para>If you leave this parameter empty when you modify the compliance pack, the original rules are retained. If you specify new rules, they replace the original rules.</para>
        /// </summary>
        [NameInMap("ConfigRules")]
        [Validation(Required=false)]
        public List<UpdateCompliancePackRequestConfigRules> ConfigRules { get; set; }
        public class UpdateCompliancePackRequestConfigRules : TeaModel {
            /// <summary>
            /// <para>The rule ID. CloudConfig adds an existing rule to the compliance pack.</para>
            /// <para>You must specify either <c>ManagedRuleIdentifier</c> or <c>ConfigRuleId</c>. If you specify both parameters, <c>ConfigRuleId</c> takes precedence. For more information, see <a href="https://help.aliyun.com/document_detail/169607.html">ListConfigRules</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cr-e918626622af000f****</para>
            /// </summary>
            [NameInMap("ConfigRuleId")]
            [Validation(Required=false)]
            public string ConfigRuleId { get; set; }

            /// <summary>
            /// <para>The name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>检测闲置弹性公网IP</para>
            /// </summary>
            [NameInMap("ConfigRuleName")]
            [Validation(Required=false)]
            public string ConfigRuleName { get; set; }

            /// <summary>
            /// <para>The parameters of the rule.</para>
            /// </summary>
            [NameInMap("ConfigRuleParameters")]
            [Validation(Required=false)]
            public List<UpdateCompliancePackRequestConfigRulesConfigRuleParameters> ConfigRuleParameters { get; set; }
            public class UpdateCompliancePackRequestConfigRulesConfigRuleParameters : TeaModel {
                /// <summary>
                /// <para>The name of the rule parameter.</para>
                /// <para>You must specify <c>ParameterName</c> and <c>ParameterValue</c> together, or leave them both empty. If a rule template has a parameter without a default value, you must specify this parameter. For more information, see <a href="https://help.aliyun.com/document_detail/261176.html">ListCompliancePackTemplates</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bandwidth</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// <para>The value of the rule parameter.</para>
                /// <para>You must specify <c>ParameterName</c> and <c>ParameterValue</c> together, or leave them both empty. If a rule template has a parameter without a default value, you must specify this parameter. For more information, see <a href="https://help.aliyun.com/document_detail/261176.html">ListCompliancePackTemplates</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

            /// <summary>
            /// <para>The description of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>弹性公网已绑定到ECS或者NAT实例，非闲置状态，视为“合规”。</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The identifier of the rule template. CloudConfig automatically creates a rule based on this identifier and adds the rule to the compliance pack.</para>
            /// <para>You must specify either <c>ManagedRuleIdentifier</c> or <c>ConfigRuleId</c>. If you specify both parameters, <c>ConfigRuleId</c> takes precedence. For more information, see <a href="https://help.aliyun.com/document_detail/261176.html">ListCompliancePackTemplates</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip-bandwidth-limit</para>
            /// </summary>
            [NameInMap("ManagedRuleIdentifier")]
            [Validation(Required=false)]
            public string ManagedRuleIdentifier { get; set; }

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

        }

        /// <summary>
        /// <para>The description of the compliance pack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>基于等保2.0三级标准，提供持续检测合规性的建议模板，帮助您提前自检并修复问题，以便快速通过正式检测。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The compliance pack does not evaluate resources in the specified regions. Separate multiple region IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("ExcludeRegionIdsScope")]
        [Validation(Required=false)]
        public string ExcludeRegionIdsScope { get; set; }

        /// <summary>
        /// <para>The compliance pack does not evaluate resources in the specified resource groups. Separate multiple resource group IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bnczc6r7rml****</para>
        /// </summary>
        [NameInMap("ExcludeResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceGroupIdsScope { get; set; }

        /// <summary>
        /// <para>The compliance pack does not evaluate the specified resources. Separate multiple resource IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>23642660635687****</para>
        /// </summary>
        [NameInMap("ExcludeResourceIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceIdsScope { get; set; }

        /// <summary>
        /// <para>The excluded tag scope.</para>
        /// </summary>
        [NameInMap("ExcludeTagsScope")]
        [Validation(Required=false)]
        public List<UpdateCompliancePackRequestExcludeTagsScope> ExcludeTagsScope { get; set; }
        public class UpdateCompliancePackRequestExcludeTagsScope : TeaModel {
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
        /// <para>The compliance pack evaluates only resources in the specified regions. Separate multiple region IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionIdsScope")]
        [Validation(Required=false)]
        public string RegionIdsScope { get; set; }

        /// <summary>
        /// <para>The compliance pack evaluates only resources in the specified resource groups. Separate multiple resource group IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzdibsjjc****</para>
        /// </summary>
        [NameInMap("ResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ResourceGroupIdsScope { get; set; }

        /// <summary>
        /// <para>The compliance pack evaluates only the specified resources. Separate multiple resource IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5cmbowstbkss9ta03****</para>
        /// </summary>
        [NameInMap("ResourceIdsScope")]
        [Validation(Required=false)]
        public string ResourceIdsScope { get; set; }

        /// <summary>
        /// <para>The risk level of the compliance pack. Valid values:</para>
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

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The tags of the resource. This parameter is deprecated. Ignore this parameter because it is no longer valid.</para>
        /// <para>You can add up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        [Obsolete]
        public List<UpdateCompliancePackRequestTag> Tag { get; set; }
        public class UpdateCompliancePackRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <para>If you specify this parameter, it cannot be an empty string. The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https:// </c>.</para>
            /// <para>You can specify the tag keys of up to 20 tags at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. If you specify this parameter, it can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value-1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The compliance pack evaluates only resources that have the specified tag key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("TagKeyScope")]
        [Validation(Required=false)]
        public string TagKeyScope { get; set; }

        /// <summary>
        /// <para>The compliance pack evaluates only resources that have the specified tag key and value.</para>
        /// <remarks>
        /// <para>You must use TagValueScope with TagKeyScope.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TagValueScope")]
        [Validation(Required=false)]
        public string TagValueScope { get; set; }

        /// <summary>
        /// <para>The tag scope.</para>
        /// </summary>
        [NameInMap("TagsScope")]
        [Validation(Required=false)]
        public List<UpdateCompliancePackRequestTagsScope> TagsScope { get; set; }
        public class UpdateCompliancePackRequestTagsScope : TeaModel {
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

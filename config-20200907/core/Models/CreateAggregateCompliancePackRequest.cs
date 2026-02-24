// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateAggregateCompliancePackRequest : TeaModel {
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
        /// <para>A client token. It is used to ensure the idempotence of the request. Generate a value from your client to make sure that the value is unique among different requests. <c>ClientToken</c> supports only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1594295238-f9361358-5843-4294-8d30-b5183fac****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the compliance pack.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>等保三级预检合规包</para>
        /// </summary>
        [NameInMap("CompliancePackName")]
        [Validation(Required=false)]
        public string CompliancePackName { get; set; }

        /// <summary>
        /// <para>The ID of the compliance pack template.</para>
        /// <para>For more information about how to obtain the ID of a compliance pack template, see <a href="https://help.aliyun.com/document_detail/261176.html">ListCompliancePackTemplates</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ct-5f26ff4e06a300c4****</para>
        /// </summary>
        [NameInMap("CompliancePackTemplateId")]
        [Validation(Required=false)]
        public string CompliancePackTemplateId { get; set; }

        /// <summary>
        /// <para>The rules in the compliance pack.</para>
        /// <remarks>
        /// <para>Specify either this parameter or <c>TemplateContent</c>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ConfigRules")]
        [Validation(Required=false)]
        public List<CreateAggregateCompliancePackRequestConfigRules> ConfigRules { get; set; }
        public class CreateAggregateCompliancePackRequestConfigRules : TeaModel {
            /// <summary>
            /// <para>The rule ID. CloudConfig adds an existing rule to the compliance pack.</para>
            /// <para>Specify either <c>ManagedRuleIdentifier</c> or <c>ConfigRuleId</c>. If both parameters are specified, <c>ConfigRuleId</c> is used.</para>
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
            /// <para>弹性IP实例带宽满足最低要求</para>
            /// </summary>
            [NameInMap("ConfigRuleName")]
            [Validation(Required=false)]
            public string ConfigRuleName { get; set; }

            /// <summary>
            /// <para>The parameters of the rule.</para>
            /// </summary>
            [NameInMap("ConfigRuleParameters")]
            [Validation(Required=false)]
            public List<CreateAggregateCompliancePackRequestConfigRulesConfigRuleParameters> ConfigRuleParameters { get; set; }
            public class CreateAggregateCompliancePackRequestConfigRulesConfigRuleParameters : TeaModel {
                /// <summary>
                /// <para>The name of the rule parameter.</para>
                /// <para>Specify both <c>ParameterName</c> and <c>ParameterValue</c>, or leave both empty. If a rule template has a parameter that does not have a default value, the parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bandwidth</para>
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// <para>The value of the rule parameter.</para>
                /// <para>Specify both <c>ParameterName</c> and <c>ParameterValue</c>, or leave both empty. If a rule template has a parameter that does not have a default value, the parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
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
            /// <para>The identifier of the rule template. CloudConfig automatically creates a rule based on the rule template identifier and adds the rule to the compliance pack.</para>
            /// <para>Specify either <c>ManagedRuleIdentifier</c> or <c>ConfigRuleId</c>. If both parameters are specified, <c>ConfigRuleId</c> is used.</para>
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
            /// <item><description><para>1: High</para>
            /// </description></item>
            /// <item><description><para>2: Medium</para>
            /// </description></item>
            /// <item><description><para>3: Low</para>
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
        /// <para>Indicates whether the rule is enabled for quick activation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The rule is enabled when you quickly activate the compliance pack.</para>
        /// </description></item>
        /// <item><description><para>false (default): The rule is not enabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DefaultEnable")]
        [Validation(Required=false)]
        public bool? DefaultEnable { get; set; }

        /// <summary>
        /// <para>The description of the compliance pack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>基于等保三级的部分要求，对阿里云上资源的合规性做检测。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The compliance pack does not take effect for resources in the specified regions. The resources in these regions are not evaluated. Separate multiple region IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("ExcludeRegionIdsScope")]
        [Validation(Required=false)]
        public string ExcludeRegionIdsScope { get; set; }

        /// <summary>
        /// <para>The compliance pack does not take effect for resources in the specified resource groups. The resources in these resource groups are not evaluated. Separate multiple resource group IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bnczc6r7rml****</para>
        /// </summary>
        [NameInMap("ExcludeResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceGroupIdsScope { get; set; }

        /// <summary>
        /// <para>The compliance pack does not take effect for the specified resources. The resources are not evaluated. Separate multiple resource IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-8vbf3x310fn56ijfd****</para>
        /// </summary>
        [NameInMap("ExcludeResourceIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceIdsScope { get; set; }

        /// <summary>
        /// <para>The excluded tags.</para>
        /// </summary>
        [NameInMap("ExcludeTagsScope")]
        [Validation(Required=false)]
        public List<CreateAggregateCompliancePackRequestExcludeTagsScope> ExcludeTagsScope { get; set; }
        public class CreateAggregateCompliancePackRequestExcludeTagsScope : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>The compliance pack takes effect only for resources in the specified regions. Separate multiple region IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionIdsScope")]
        [Validation(Required=false)]
        public string RegionIdsScope { get; set; }

        /// <summary>
        /// <para>The compliance pack takes effect only for resources in the specified resource groups. Separate multiple resource group IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzc7r7rhx****</para>
        /// </summary>
        [NameInMap("ResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ResourceGroupIdsScope { get; set; }

        /// <summary>
        /// <para>The compliance pack takes effect only for the specified resources. Separate multiple resource IDs with commas (,).</para>
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
        /// <item><description><para>1: High</para>
        /// </description></item>
        /// <item><description><para>2 (default): Medium</para>
        /// </description></item>
        /// <item><description><para>3: Low</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public int? RiskLevel { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// <para>You can add up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateAggregateCompliancePackRequestTag> Tag { get; set; }
        public class CreateAggregateCompliancePackRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <para>You can add up to 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// <para>You can add up to 20 tag values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value-1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The compliance pack takes effect only for resources that have the specified tag key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("TagKeyScope")]
        [Validation(Required=false)]
        public string TagKeyScope { get; set; }

        /// <summary>
        /// <para>The compliance pack takes effect only for resources that have the specified tag key-value pair.</para>
        /// <remarks>
        /// <para>TagValueScope must be used with TagKeyScope.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TagValueScope")]
        [Validation(Required=false)]
        public string TagValueScope { get; set; }

        /// <summary>
        /// <para>The effective tags.</para>
        /// </summary>
        [NameInMap("TagsScope")]
        [Validation(Required=false)]
        public List<CreateAggregateCompliancePackRequestTagsScope> TagsScope { get; set; }
        public class CreateAggregateCompliancePackRequestTagsScope : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagKey1</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagValue1</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>The template information that is used to generate the compliance pack. You can view the template content in the details of an existing compliance pack or create a template. For more information, see <a href="https://help.aliyun.com/document_detail/2659733.html">Create a configurable compliance pack template</a>.</para>
        /// <remarks>
        /// <para>Specify either this parameter or <c>ConfigRules</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;configRuleTemplates&quot;: [
        ///         {
        ///             &quot;configRuleName&quot;: &quot;自定义条件规则示例&quot;,
        ///             &quot;scope&quot;: {
        ///                 &quot;complianceResourceTypes&quot;: [
        ///                     &quot;ACS::ECS::Instance&quot;
        ///                 ]
        ///             },
        ///             &quot;description&quot;: &quot;&quot;,
        ///             &quot;source&quot;: {
        ///                 &quot;owner&quot;: &quot;CUSTOM_CONFIGURATION&quot;,
        ///                 &quot;identifier&quot;: &quot;acs-config-configuration&quot;,
        ///                 &quot;sourceDetails&quot;: [
        ///                     {
        ///                         &quot;messageType&quot;: &quot;ScheduledNotification&quot;,
        ///                         &quot;maximumExecutionFrequency&quot;: &quot;Twelve_Hours&quot;
        ///                     },
        ///                     {
        ///                         &quot;messageType&quot;: &quot;ConfigurationItemChangeNotification&quot;
        ///                     }
        ///                 ],
        ///                 &quot;conditions&quot;: &quot;{\&quot;ComplianceConditions\&quot;:\&quot;{\\\&quot;operator\\\&quot;:\\\&quot;and\\\&quot;,\\\&quot;children\\\&quot;:[{\\\&quot;operator\\\&quot;:\\\&quot;GreaterOrEquals\\\&quot;,\\\&quot;featurePath\\\&quot;:\\\&quot;$.Cpu\\\&quot;,\\\&quot;featureSource\\\&quot;:\\\&quot;CONFIGURATION\\\&quot;,\\\&quot;desired\\\&quot;:\\\&quot;2\\\&quot;}]}\&quot;}&quot;
        ///             },
        ///             &quot;inputParameters&quot;: {}
        ///         },
        ///         {
        ///             &quot;configRuleName&quot;: &quot;OSS存储空间Referer在指定的防盗链白名单中&quot;,
        ///             &quot;scope&quot;: {
        ///                 &quot;complianceResourceTypes&quot;: [
        ///                     &quot;ACS::OSS::Bucket&quot;
        ///                 ]
        ///             },
        ///             &quot;description&quot;: &quot;OSS存储空间开启防盗链并且Referer在指定白名单中，视为“合规”。&quot;,
        ///             &quot;source&quot;: {
        ///                 &quot;owner&quot;: &quot;ALIYUN&quot;,
        ///                 &quot;identifier&quot;: &quot;oss-bucket-referer-limit&quot;,
        ///                 &quot;sourceDetails&quot;: [
        ///                     {
        ///                         &quot;messageType&quot;: &quot;ConfigurationItemChangeNotification&quot;
        ///                     }
        ///                 ]
        ///             },
        ///             &quot;inputParameters&quot;: {
        ///                 &quot;allowEmptyReferer&quot;: &quot;true&quot;,
        ///                 &quot;allowReferers&quot;: &quot;<a href="http://www.aliyun.com">http://www.aliyun.com</a>&quot;
        ///             }
        ///         }
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public string TemplateContent { get; set; }

    }

}

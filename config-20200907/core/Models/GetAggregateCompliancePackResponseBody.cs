// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateCompliancePackResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the compliance pack.</para>
        /// </summary>
        [NameInMap("CompliancePack")]
        [Validation(Required=false)]
        public GetAggregateCompliancePackResponseBodyCompliancePack CompliancePack { get; set; }
        public class GetAggregateCompliancePackResponseBodyCompliancePack : TeaModel {
            /// <summary>
            /// <para>The ID of the management account to which the compliance pack belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100931896542****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <para>The ID of the account group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca-f632626622af0079****</para>
            /// </summary>
            [NameInMap("AggregatorId")]
            [Validation(Required=false)]
            public string AggregatorId { get; set; }

            /// <summary>
            /// <para>The ID of the compliance pack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cp-fdc8626622af00f9****</para>
            /// </summary>
            [NameInMap("CompliancePackId")]
            [Validation(Required=false)]
            public string CompliancePackId { get; set; }

            /// <summary>
            /// <para>The name of the compliance pack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>等保三级预检合规包</para>
            /// </summary>
            [NameInMap("CompliancePackName")]
            [Validation(Required=false)]
            public string CompliancePackName { get; set; }

            /// <summary>
            /// <para>The ID of the compliance pack template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ct-5f26ff4e06a300c4****</para>
            /// </summary>
            [NameInMap("CompliancePackTemplateId")]
            [Validation(Required=false)]
            public string CompliancePackTemplateId { get; set; }

            /// <summary>
            /// <para>The list of rules in the compliance pack.</para>
            /// </summary>
            [NameInMap("ConfigRules")]
            [Validation(Required=false)]
            public List<GetAggregateCompliancePackResponseBodyCompliancePackConfigRules> ConfigRules { get; set; }
            public class GetAggregateCompliancePackResponseBodyCompliancePackConfigRules : TeaModel {
                /// <summary>
                /// <para>The ID of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cr-a260626622af0005****</para>
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
                /// <para>The input parameters of the rule.</para>
                /// </summary>
                [NameInMap("ConfigRuleParameters")]
                [Validation(Required=false)]
                public List<GetAggregateCompliancePackResponseBodyCompliancePackConfigRulesConfigRuleParameters> ConfigRuleParameters { get; set; }
                public class GetAggregateCompliancePackResponseBodyCompliancePackConfigRulesConfigRuleParameters : TeaModel {
                    /// <summary>
                    /// <para>The name of the input parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bandwidth</para>
                    /// </summary>
                    [NameInMap("ParameterName")]
                    [Validation(Required=false)]
                    public string ParameterName { get; set; }

                    /// <summary>
                    /// <para>The value of the input parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("ParameterValue")]
                    [Validation(Required=false)]
                    public string ParameterValue { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the input parameter is required. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>true: The input parameter is required.</para>
                    /// </description></item>
                    /// <item><description><para>false: The input parameter is not required.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                }

                /// <summary>
                /// <para>The description of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>弹性IP实例可用带宽大于等于指定参数值，视为“合规”。默认值：10 MB。</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The identifier of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eip-bandwidth-limit</para>
                /// </summary>
                [NameInMap("ManagedRuleIdentifier")]
                [Validation(Required=false)]
                public string ManagedRuleIdentifier { get; set; }

                /// <summary>
                /// <para>The types of the resources that are evaluated by the rule. Separate multiple resource types with commas (,).</para>
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
                /// <item><description><para>1: high</para>
                /// </description></item>
                /// <item><description><para>2: medium</para>
                /// </description></item>
                /// <item><description><para>3: low</para>
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
            /// <para>The timestamp when the compliance pack was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1624243657000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

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
            /// <para>The risk level of the compliance pack. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: high</para>
            /// </description></item>
            /// <item><description><para>2: medium</para>
            /// </description></item>
            /// <item><description><para>3: low</para>
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
            /// <para>The evaluation scope of the compliance pack.</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public GetAggregateCompliancePackResponseBodyCompliancePackScope Scope { get; set; }
            public class GetAggregateCompliancePackResponseBodyCompliancePackScope : TeaModel {
                /// <summary>
                /// <para>The IDs of the regions to exclude. Separate multiple region IDs with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("ExcludeRegionIdsScope")]
                [Validation(Required=false)]
                public string ExcludeRegionIdsScope { get; set; }

                /// <summary>
                /// <para>The IDs of the resource groups to exclude. The compliance pack does not apply to resources in these groups. Separate multiple resource group IDs with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aekzc7r7rhx****</para>
                /// </summary>
                [NameInMap("ExcludeResourceGroupIdsScope")]
                [Validation(Required=false)]
                public string ExcludeResourceGroupIdsScope { get; set; }

                /// <summary>
                /// <para>The IDs of the resources to exclude. The compliance pack does not apply to these resources. Separate multiple resource IDs with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>eip-8vbf3x310fn56ijfd****</para>
                /// </summary>
                [NameInMap("ExcludeResourceIdsScope")]
                [Validation(Required=false)]
                public string ExcludeResourceIdsScope { get; set; }

                /// <summary>
                /// <para>The excluded tag scope.</para>
                /// </summary>
                [NameInMap("ExcludeTagsScope")]
                [Validation(Required=false)]
                public List<GetAggregateCompliancePackResponseBodyCompliancePackScopeExcludeTagsScope> ExcludeTagsScope { get; set; }
                public class GetAggregateCompliancePackResponseBodyCompliancePackScopeExcludeTagsScope : TeaModel {
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
                /// <para>The IDs of the regions where the compliance pack applies. Separate multiple region IDs with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionIdsScope")]
                [Validation(Required=false)]
                public string RegionIdsScope { get; set; }

                /// <summary>
                /// <para>The IDs of the resource groups where the compliance pack applies. Separate multiple resource group IDs with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aekzc7r7rhx****</para>
                /// </summary>
                [NameInMap("ResourceGroupIdsScope")]
                [Validation(Required=false)]
                public string ResourceGroupIdsScope { get; set; }

                /// <summary>
                /// <para>The IDs of the resources to which the rule applies. Separate multiple resource IDs with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>eip-8vbf3x310fn56ijfd****</para>
                /// </summary>
                [NameInMap("ResourceIdsScope")]
                [Validation(Required=false)]
                public string ResourceIdsScope { get; set; }

                /// <summary>
                /// <para>The tag key of the resources to which the compliance pack applies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS</para>
                /// </summary>
                [NameInMap("TagKeyScope")]
                [Validation(Required=false)]
                public string TagKeyScope { get; set; }

                /// <summary>
                /// <para>The tag value of the resources to which the compliance pack applies.</para>
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
                public List<GetAggregateCompliancePackResponseBodyCompliancePackScopeTagsScope> TagsScope { get; set; }
                public class GetAggregateCompliancePackResponseBodyCompliancePackScopeTagsScope : TeaModel {
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

            /// <summary>
            /// <para>The status of the compliance pack. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ACTIVE: The compliance pack is active.</para>
            /// </description></item>
            /// <item><description><para>CREATING: The compliance pack is being created.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags of the resource.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetAggregateCompliancePackResponseBodyCompliancePackTags> Tags { get; set; }
            public class GetAggregateCompliancePackResponseBodyCompliancePackTags : TeaModel {
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

            /// <summary>
            /// <para>The information about the compliance pack template. The list of rules in the template does not include user-defined function rules. You can use the template to quickly create the same compliance pack for other accounts or account groups.</para>
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

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EC7AED1-172F-42AE-9C12-295BC2ADB751</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

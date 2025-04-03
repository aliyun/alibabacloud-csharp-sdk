// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateCompliancePackResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the compliance package.</para>
        /// </summary>
        [NameInMap("CompliancePack")]
        [Validation(Required=false)]
        public GetAggregateCompliancePackResponseBodyCompliancePack CompliancePack { get; set; }
        public class GetAggregateCompliancePackResponseBodyCompliancePack : TeaModel {
            /// <summary>
            /// <para>The ID of the management account to which the compliance package belongs.</para>
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

            /// <summary>
            /// <para>The ID of the compliance package template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ct-5f26ff4e06a300c4****</para>
            /// </summary>
            [NameInMap("CompliancePackTemplateId")]
            [Validation(Required=false)]
            public string CompliancePackTemplateId { get; set; }

            /// <summary>
            /// <para>The rules in the compliance package.</para>
            /// </summary>
            [NameInMap("ConfigRules")]
            [Validation(Required=false)]
            public List<GetAggregateCompliancePackResponseBodyCompliancePackConfigRules> ConfigRules { get; set; }
            public class GetAggregateCompliancePackResponseBodyCompliancePackConfigRules : TeaModel {
                /// <summary>
                /// <para>The rule ID.</para>
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
                /// <para>The name of the rule.</para>
                /// </summary>
                [NameInMap("ConfigRuleName")]
                [Validation(Required=false)]
                public string ConfigRuleName { get; set; }

                /// <summary>
                /// <para>The details of the input parameter of the rule.</para>
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
                    /// <para>Indicates whether the input parameter was required. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true</description></item>
                    /// <item><description>false</description></item>
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
                /// <para>The description of the rule.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the rule template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eip-bandwidth-limit</para>
                /// </summary>
                [NameInMap("ManagedRuleIdentifier")]
                [Validation(Required=false)]
                public string ManagedRuleIdentifier { get; set; }

                /// <summary>
                /// <para>The type of the resource evaluated based on the rule. Multiple resource types are separated with commas (,).</para>
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

            }

            /// <summary>
            /// <para>The timestamp when the compliance package was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1624243657000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The description of the compliance package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The description of the compliance package.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The risk level of the resources that are not compliant with the rules in the compliance package. Valid values:</para>
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
            /// <para>The evaluation scope of the compliance package.</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public GetAggregateCompliancePackResponseBodyCompliancePackScope Scope { get; set; }
            public class GetAggregateCompliancePackResponseBodyCompliancePackScope : TeaModel {
                /// <summary>
                /// <para>The IDs of regions that are excluded. Separate multiple region IDs with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("ExcludeRegionIdsScope")]
                [Validation(Required=false)]
                public string ExcludeRegionIdsScope { get; set; }

                /// <summary>
                /// <para>The IDs of the resource groups whose resources you do not want to evaluate by using the compliance package. Separate multiple resource group IDs with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aekzc7r7rhx****</para>
                /// </summary>
                [NameInMap("ExcludeResourceGroupIdsScope")]
                [Validation(Required=false)]
                public string ExcludeResourceGroupIdsScope { get; set; }

                /// <summary>
                /// <para>The ID of the resource that is not evaluated by using the compliance package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eip-8vbf3x310fn56ijfd****</para>
                /// </summary>
                [NameInMap("ExcludeResourceIdsScope")]
                [Validation(Required=false)]
                public string ExcludeResourceIdsScope { get; set; }

                /// <summary>
                /// <para>The scope of the tag that is excluded.</para>
                /// </summary>
                [NameInMap("ExcludeTagsScope")]
                [Validation(Required=false)]
                public List<GetAggregateCompliancePackResponseBodyCompliancePackScopeExcludeTagsScope> ExcludeTagsScope { get; set; }
                public class GetAggregateCompliancePackResponseBodyCompliancePackScopeExcludeTagsScope : TeaModel {
                    /// <summary>
                    /// <para>The key of the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key-2</para>
                    /// </summary>
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    /// <summary>
                    /// <para>The value of the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>value-2</para>
                    /// </summary>
                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

                /// <summary>
                /// <para>The ID of the region whose resources were evaluated by using the compliance package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionIdsScope")]
                [Validation(Required=false)]
                public string RegionIdsScope { get; set; }

                /// <summary>
                /// <para>The ID of the resource group whose resources are evaluated by using the compliance package.</para>
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
                /// <para>The tag key of the resource that is evaluated by using the compliance package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS</para>
                /// </summary>
                [NameInMap("TagKeyScope")]
                [Validation(Required=false)]
                public string TagKeyScope { get; set; }

                /// <summary>
                /// <para>The tag value of the resource that is evaluated by using the compliance package.</para>
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
                    /// <para>The key of the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key-1</para>
                    /// </summary>
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    /// <summary>
                    /// <para>The value of the tag.</para>
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
            /// <para>The status of the compliance package. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ACTIVE: The compliance package was normal.</description></item>
            /// <item><description>CREATING: The compliance package was being created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetAggregateCompliancePackResponseBodyCompliancePackTags> Tags { get; set; }
            public class GetAggregateCompliancePackResponseBodyCompliancePackTags : TeaModel {
                /// <summary>
                /// <para>The tag keys of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key-1</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag values of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value-1</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The information about the current compliance package template. The rules in the template do not contain custom function rules. You can quickly create the same compliance package for other accounts or account groups based on the template information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;configRuleTemplates&quot;: [
            ///     {
            ///       &quot;configRuleName&quot;: &quot;OSS-test-name&quot;,
            ///       &quot;scope&quot;: {
            ///         &quot;complianceResourceTypes&quot;: [
            ///           &quot;ACS::OSS::Bucket&quot;
            ///         ]
            ///       },
            ///       &quot;description&quot;: &quot;test-description&quot;,
            ///       &quot;source&quot;: {
            ///         &quot;owner&quot;: &quot;ALIYUN&quot;,
            ///         &quot;identifier&quot;: &quot;oss-bucket-referer-xxx&quot;,
            ///         &quot;sourceDetails&quot;: [
            ///           {
            ///             &quot;messageType&quot;: &quot;ConfigurationItemChangeNotification&quot;
            ///           }
            ///         ]
            ///       },
            ///       &quot;inputParameters&quot;: {
            ///         &quot;allowEmptyReferer&quot;: &quot;true&quot;,
            ///         &quot;allowReferers&quot;: &quot;<a href="http://www.aliyun.com">http://www.aliyun.com</a>&quot;
            ///       }
            ///     }
            ///   ]
            /// }</para>
            /// </summary>
            [NameInMap("TemplateContent")]
            [Validation(Required=false)]
            public string TemplateContent { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EC7AED1-172F-42AE-9C12-295BC2ADB751</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetCompliancePackResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the compliance package.</para>
        /// </summary>
        [NameInMap("CompliancePack")]
        [Validation(Required=false)]
        public GetCompliancePackResponseBodyCompliancePack CompliancePack { get; set; }
        public class GetCompliancePackResponseBodyCompliancePack : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the compliance package belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100931896542****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <para>The ID of the compliance package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cp-a8a8626622af0082****</para>
            /// </summary>
            [NameInMap("CompliancePackId")]
            [Validation(Required=false)]
            public string CompliancePackId { get; set; }

            /// <summary>
            /// <para>The name of the compliance package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-pack-name</para>
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
            public List<GetCompliancePackResponseBodyCompliancePackConfigRules> ConfigRules { get; set; }
            public class GetCompliancePackResponseBodyCompliancePackConfigRules : TeaModel {
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
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eip-bandwidth-limit</para>
                /// </summary>
                [NameInMap("ConfigRuleName")]
                [Validation(Required=false)]
                public string ConfigRuleName { get; set; }

                /// <summary>
                /// <para>The input parameters of the rule.</para>
                /// </summary>
                [NameInMap("ConfigRuleParameters")]
                [Validation(Required=false)]
                public List<GetCompliancePackResponseBodyCompliancePackConfigRulesConfigRuleParameters> ConfigRuleParameters { get; set; }
                public class GetCompliancePackResponseBodyCompliancePackConfigRulesConfigRuleParameters : TeaModel {
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
                    /// <para>Indicates whether the input parameters are required. Valid values:</para>
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
                /// <para>The rule description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The identifier of the managed rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eip-bandwidth-limit</para>
                /// </summary>
                [NameInMap("ManagedRuleIdentifier")]
                [Validation(Required=false)]
                public string ManagedRuleIdentifier { get; set; }

                /// <summary>
                /// <para>The type of the resource evaluated based on the rule. Separate multiple resource types with commas (,).</para>
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
            /// <para>1624245766000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The description of the compliance package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-name</para>
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
            /// <para>The resource group for which the compliance package took effect.</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public GetCompliancePackResponseBodyCompliancePackScope Scope { get; set; }
            public class GetCompliancePackResponseBodyCompliancePackScope : TeaModel {
                /// <summary>
                /// <para>Excluded region scope, multiple regions should be separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("ExcludeRegionIdsScope")]
                [Validation(Required=false)]
                public string ExcludeRegionIdsScope { get; set; }

                /// <summary>
                /// <para>Excluded resourceGroup scope, multiple resourceGroup should be separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aekzc7r7rhx****</para>
                /// </summary>
                [NameInMap("ExcludeResourceGroupIdsScope")]
                [Validation(Required=false)]
                public string ExcludeResourceGroupIdsScope { get; set; }

                /// <summary>
                /// <para>The ID of the resource that you do not want to evaluate by using the compliance package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eip-8vbf3x310fn56ijfd****</para>
                /// </summary>
                [NameInMap("ExcludeResourceIdsScope")]
                [Validation(Required=false)]
                public string ExcludeResourceIdsScope { get; set; }

                /// <summary>
                /// <para>Exclude tag scope.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("ExcludeTagsScope")]
                [Validation(Required=false)]
                public List<GetCompliancePackResponseBodyCompliancePackScopeExcludeTagsScope> ExcludeTagsScope { get; set; }
                public class GetCompliancePackResponseBodyCompliancePackScopeExcludeTagsScope : TeaModel {
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
                /// <para>The ID of the region whose resources you want to evaluate by using the compliance package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionIdsScope")]
                [Validation(Required=false)]
                public string RegionIdsScope { get; set; }

                /// <summary>
                /// <para>The ID of the resource group whose resources you want to evaluate by using the compliance package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aekzc7r7rhx****</para>
                /// </summary>
                [NameInMap("ResourceGroupIdsScope")]
                [Validation(Required=false)]
                public string ResourceGroupIdsScope { get; set; }

                /// <summary>
                /// <para>Include ResourceId scope, multiple resourceIds should be separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eip-8vbf3x310fn56ijfd****</para>
                /// </summary>
                [NameInMap("ResourceIdsScope")]
                [Validation(Required=false)]
                public string ResourceIdsScope { get; set; }

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
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TagValueScope")]
                [Validation(Required=false)]
                public string TagValueScope { get; set; }

                /// <summary>
                /// <para>Include tag scope.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("TagsScope")]
                [Validation(Required=false)]
                public List<GetCompliancePackResponseBodyCompliancePackScopeTagsScope> TagsScope { get; set; }
                public class GetCompliancePackResponseBodyCompliancePackScopeTagsScope : TeaModel {
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
            /// <para>The status of the compliance package. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ACTIVE: The compliance package is normal.</description></item>
            /// <item><description>CREATING: The compliance package is being created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The information about the current compliance package template. The rules in the template do not contain custom function rules. You can quickly create the same compliance package for other accounts or account groups based on the template information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;configRuleTemplates&quot;: [
            ///         {
            ///           &quot;configRuleName&quot;: &quot;弹性IP实例带宽满足最低要求&quot;,
            ///           &quot;scope&quot;: {
            ///             &quot;complianceResourceTypes&quot;: [
            ///               &quot;ACS::EIP::EipAddress&quot;
            ///             ]
            ///           },
            ///           &quot;description&quot;: &quot;弹性IP实例可用带宽大于等于指定参数值，视为“合规”。默认值：10MB&quot;,
            ///           &quot;source&quot;: {
            ///             &quot;owner&quot;: &quot;ALIYUN&quot;,
            ///             &quot;identifier&quot;: &quot;eip-bandwidth-limit&quot;,
            ///             &quot;sourceDetails&quot;: [
            ///               {
            ///                 &quot;messageType&quot;: &quot;ConfigurationItemChangeNotification&quot;
            ///               }
            ///             ]
            ///           },
            ///           &quot;inputParameters&quot;: {
            ///             &quot;bandwidth&quot;: &quot;10&quot;
            ///           }
            ///         }
            ///       ],
            ///       &quot;compliancePackTemplate&quot;: {
            ///         &quot;riskLevel&quot;: 2,
            ///         &quot;compliancePackName&quot;: &quot;gy-test&quot;,
            ///         &quot;description&quot;: &quot;&quot;
            ///       }
            ///     }</para>
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

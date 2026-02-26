// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UpdateAggregateConfigRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The rule applies only to resources of the specified member accounts. Separate multiple member account IDs with a comma (,).</para>
        /// <remarks>
        /// <para>This parameter applies only to rule templates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>115748125982****</para>
        /// </summary>
        [NameInMap("AccountIdsScope")]
        [Validation(Required=false)]
        public string AccountIdsScope { get; set; }

        /// <summary>
        /// <para>The account group ID.</para>
        /// <para>For more information, see <a href="">ListAggregators</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-a4e5626622af0079****</para>
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// <para>A client token used to ensure the idempotence of the request. Make sure that the client token is unique for each request. The <c>ClientToken</c> can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1594295238-f9361358-5843-4294-8d30-b5183fac****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The conditions for the custom rule, specified in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ComplianceConditions&quot;:&quot;{\&quot;operator\&quot;:\&quot;and\&quot;,\&quot;children\&quot;:[{\&quot;operator\&quot;:\&quot;StringEquals\&quot;,\&quot;featurePath\&quot;:\&quot;$.Status\&quot;,\&quot;desired\&quot;:\&quot;1\&quot;,\&quot;featureSource\&quot;:\&quot;CONFIGURATION\&quot;}]}&quot;}</para>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// <para>For more information, see <a href="">ListAggregateConfigRules</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cr-4e3d626622af0080****</para>
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// <para>The rule name.</para>
        /// <para>For more information, see <a href="">ListAggregateConfigRules</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>存在所有指定标签</para>
        /// </summary>
        [NameInMap("ConfigRuleName")]
        [Validation(Required=false)]
        public string ConfigRuleName { get; set; }

        /// <summary>
        /// <para>The trigger mechanism of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ConfigurationItemChangeNotification: Configuration changes.</para>
        /// </description></item>
        /// <item><description><para>ScheduledNotification: Scheduled execution.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can modify this parameter only for custom rules.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ConfigurationItemChangeNotification</para>
        /// </summary>
        [NameInMap("ConfigRuleTriggerTypes")]
        [Validation(Required=false)]
        public string ConfigRuleTriggerTypes { get; set; }

        /// <summary>
        /// <para>The description of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>最多可以定义6组标签。如果资源同时具有指定的所有标签，则视为“合规”。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The member accounts to exclude. The rule does not apply to resources of these member accounts. Separate multiple member account IDs with a comma (,).</para>
        /// <remarks>
        /// <para>This parameter applies only to rule templates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>120886317861****</para>
        /// </summary>
        [NameInMap("ExcludeAccountIdsScope")]
        [Validation(Required=false)]
        public string ExcludeAccountIdsScope { get; set; }

        /// <summary>
        /// <para>The folders to exclude. The rule does not apply to resources of member accounts in these folders. Separate multiple folder IDs with a comma (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter applies only to rules in a global account group.</para>
        /// </description></item>
        /// <item><description><para>This parameter applies only to rule templates.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>fd-pWmkqZ****</para>
        /// </summary>
        [NameInMap("ExcludeFolderIdsScope")]
        [Validation(Required=false)]
        public string ExcludeFolderIdsScope { get; set; }

        /// <summary>
        /// <para>The regions to exclude. The rule does not apply to resources in these regions. Separate multiple region IDs with a comma (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("ExcludeRegionIdsScope")]
        [Validation(Required=false)]
        public string ExcludeRegionIdsScope { get; set; }

        /// <summary>
        /// <para>The resource groups to exclude. The rule does not apply to resources in these resource groups. Separate multiple resource group IDs with a comma (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bnczc6r7rml****</para>
        /// </summary>
        [NameInMap("ExcludeResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceGroupIdsScope { get; set; }

        /// <summary>
        /// <para>The resources to exclude. The rule does not apply to these resources. Separate multiple resource IDs with a comma (,).</para>
        /// <remarks>
        /// <para>This parameter applies only to rule templates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>lb-t4nbowvtbkss7t326****</para>
        /// </summary>
        [NameInMap("ExcludeResourceIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceIdsScope { get; set; }

        /// <summary>
        /// <para>The excluded tag scope.</para>
        /// </summary>
        [NameInMap("ExcludeTagsScope")]
        [Validation(Required=false)]
        public List<UpdateAggregateConfigRuleShrinkRequestExcludeTagsScope> ExcludeTagsScope { get; set; }
        public class UpdateAggregateConfigRuleShrinkRequestExcludeTagsScope : TeaModel {
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
        /// <para>The rule applies only to resources of member accounts in the specified resource directory IDs.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter applies only to rules in a global account group.</para>
        /// </description></item>
        /// <item><description><para>This parameter applies only to rule templates.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>fd-ZtHsRH****</para>
        /// </summary>
        [NameInMap("FolderIdsScope")]
        [Validation(Required=false)]
        public string FolderIdsScope { get; set; }

        /// <summary>
        /// <para>The rule parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;tag1Key&quot;:&quot;ECS&quot;,&quot;tag1Value&quot;:&quot;test&quot;}</para>
        /// </summary>
        [NameInMap("InputParameters")]
        [Validation(Required=false)]
        public string InputParametersShrink { get; set; }

        /// <summary>
        /// <para>The frequency at which the rule runs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>One_Hour: 1 hour.</para>
        /// </description></item>
        /// <item><description><para>Three_Hours: 3 hours.</para>
        /// </description></item>
        /// <item><description><para>Six_Hours: 6 hours.</para>
        /// </description></item>
        /// <item><description><para>Twelve_Hours: 12 hours.</para>
        /// </description></item>
        /// <item><description><para>TwentyFour_Hours: 24 hours.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required if you set <c>ConfigRuleTriggerTypes</c> to <c>ScheduledNotification</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>One_Hour</para>
        /// </summary>
        [NameInMap("MaximumExecutionFrequency")]
        [Validation(Required=false)]
        public string MaximumExecutionFrequency { get; set; }

        /// <summary>
        /// <para>The rule applies only to resources in the specified region IDs. Separate multiple region IDs with a comma (,).</para>
        /// <remarks>
        /// <para>This parameter applies only to rule templates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionIdsScope")]
        [Validation(Required=false)]
        public string RegionIdsScope { get; set; }

        /// <summary>
        /// <para>The rule applies only to resources in the specified resource group IDs. Separate multiple resource group IDs with a comma (,).</para>
        /// <remarks>
        /// <para>This parameter applies only to rule templates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzc7r7rhx****</para>
        /// </summary>
        [NameInMap("ResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ResourceGroupIdsScope { get; set; }

        /// <summary>
        /// <para>The rule applies only to the specified resource IDs. Separate multiple resource IDs with a comma (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5cmbowstbkss9ta03****</para>
        /// </summary>
        [NameInMap("ResourceIdsScope")]
        [Validation(Required=false)]
        public string ResourceIdsScope { get; set; }

        /// <summary>
        /// <para>The rule applies only to resources with the specified resource name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-xxx</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("ResourceNameScope")]
        [Validation(Required=false)]
        public string ResourceNameScope { get; set; }

        /// <summary>
        /// <para>The resource types that the rule evaluates. Separate multiple resource types with a comma (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::ECS::Instance</para>
        /// </summary>
        [NameInMap("ResourceTypesScope")]
        [Validation(Required=false)]
        public string ResourceTypesScopeShrink { get; set; }

        /// <summary>
        /// <para>The risk level of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: high risk.</para>
        /// </description></item>
        /// <item><description><para>2: medium risk.</para>
        /// </description></item>
        /// <item><description><para>3: low risk.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public int? RiskLevel { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The rule applies only to resources with the specified resource name.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        [Obsolete]
        public string TagShrink { get; set; }

        /// <summary>
        /// <para>The logical relationship for multiple tags in the <c>TagsScope</c> parameter. For example, if you set the <c>TagsScope</c> parameter to <c>&quot;TagsScope.1.TagKey&quot;:&quot;a&quot;,&quot;TagsScope.1.TagValue&quot;:&quot;a&quot;,&quot;TagsScope.2.TagKey&quot;:&quot;b&quot;,&quot;TagsScope.2.TagValue&quot;:&quot;b&quot;</c> and set this parameter to <c>AND</c>, the rule applies only to resources that have both the <c>a:a</c> and <c>b:b</c> tags. If you do not set this parameter, the default value is <c>OR</c>.</para>
        /// <para>This parameter also works with the deprecated <c>TagKeyScope</c> parameter (not recommended). For example, if you set the <c>TagKeyScope</c> parameter to <c>ECS,OSS</c> and set this parameter to <c>AND</c>, the rule applies only to resources that have both the <c>ECS</c> and <c>OSS</c> tags.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AND: Logical AND.</para>
        /// </description></item>
        /// <item><description><para>OR: Logical OR.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AND</para>
        /// </summary>
        [NameInMap("TagKeyLogicScope")]
        [Validation(Required=false)]
        public string TagKeyLogicScope { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. Use the <c>TagsScope</c> parameter instead.</para>
        /// <para>The rule applies only to resources with the specified tag.</para>
        /// <remarks>
        /// <para>This parameter applies only to rule templates. You must specify both <c>TagKeyScope</c> and <c>TagValueScope</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("TagKeyScope")]
        [Validation(Required=false)]
        [Obsolete]
        public string TagKeyScope { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. Use the <c>TagsScope</c> parameter instead.</para>
        /// <para>The rule applies only to resources with the specified tag.</para>
        /// <remarks>
        /// <para>This parameter applies only to rule templates. You must specify both <c>TagKeyScope</c> and <c>TagValueScope</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TagValueScope")]
        [Validation(Required=false)]
        [Obsolete]
        public string TagValueScope { get; set; }

        /// <summary>
        /// <para>The tag scope.</para>
        /// </summary>
        [NameInMap("TagsScope")]
        [Validation(Required=false)]
        public List<UpdateAggregateConfigRuleShrinkRequestTagsScope> TagsScope { get; set; }
        public class UpdateAggregateConfigRuleShrinkRequestTagsScope : TeaModel {
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

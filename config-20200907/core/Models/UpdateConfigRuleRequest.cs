// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UpdateConfigRuleRequest : TeaModel {
        /// <summary>
        /// <para>A client token used to ensure the idempotence of the request. You can use a client to generate the token, but you must make sure that the token is unique for different requests. The <c>ClientToken</c> parameter can contain only ASCII characters and cannot be more than 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1594295238-f9361358-5843-4294-8d30-b5183fac****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;ComplianceConditions&quot;:&quot;{&quot;operator&quot;:&quot;and&quot;,&quot;children&quot;:[{&quot;operator&quot;:&quot;StringEquals&quot;,&quot;featurePath&quot;:&quot;$.Status&quot;,&quot;desired&quot;:&quot;1&quot;,&quot;featureSource&quot;:&quot;CONFIGURATION&quot;}]}&quot;}</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/169607.html">ListConfigRules</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cr-a260626622af0005****</para>
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/264148.html">ListAggregateConfigRules</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>存在所有指定标签</para>
        /// </summary>
        [NameInMap("ConfigRuleName")]
        [Validation(Required=false)]
        public string ConfigRuleName { get; set; }

        /// <summary>
        /// <para>The trigger type of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ConfigurationItemChangeNotification: The rule is triggered by configuration changes.</para>
        /// </description></item>
        /// <item><description><para>ScheduledNotification: The rule is triggered on a regular basis.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter can be modified only for custom rules.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ConfigurationItemChangeNotification</para>
        /// </summary>
        [NameInMap("ConfigRuleTriggerTypes")]
        [Validation(Required=false)]
        public string ConfigRuleTriggerTypes { get; set; }

        /// <summary>
        /// <para>The description of the rule. The description can be up to 500 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>最多可以定义6组标签。如果资源同时具有指定的所有标签，则视为“合规”。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The regions where the rule is not effective. The system does not evaluate resources in these regions. To specify multiple region IDs, separate them with a comma (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("ExcludeRegionIdsScope")]
        [Validation(Required=false)]
        public string ExcludeRegionIdsScope { get; set; }

        /// <summary>
        /// <para>The resource groups where the rule is not effective. The system does not evaluate resources in these resource groups. To specify multiple resource group IDs, separate them with a comma (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bnczc6r7rml****</para>
        /// </summary>
        [NameInMap("ExcludeResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceGroupIdsScope { get; set; }

        /// <summary>
        /// <para>The resources that are not evaluated by the rule. The system does not evaluate these resources. To specify multiple resource IDs, separate them with a comma (,).</para>
        /// <remarks>
        /// <para>This parameter applies only to managed rules.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>lb-t4nbowvtbkss7t326****</para>
        /// </summary>
        [NameInMap("ExcludeResourceIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceIdsScope { get; set; }

        /// <summary>
        /// <para>The tags that are used to exclude resources.</para>
        /// </summary>
        [NameInMap("ExcludeTagsScope")]
        [Validation(Required=false)]
        public List<UpdateConfigRuleRequestExcludeTagsScope> ExcludeTagsScope { get; set; }
        public class UpdateConfigRuleRequestExcludeTagsScope : TeaModel {
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
        /// <para>The extended content. This parameter is optional. You can use this parameter with a 24-hour trigger period to set the trigger time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;fixedHour&quot;:&quot;12&quot;}</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("ExtendContent")]
        [Validation(Required=false)]
        public string ExtendContent { get; set; }

        /// <summary>
        /// <para>The input parameters of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;tag1Key&quot;:&quot;ECS&quot;,&quot;tag1Value&quot;:&quot;test&quot;}</para>
        /// </summary>
        [NameInMap("InputParameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> InputParameters { get; set; }

        /// <summary>
        /// <para>The frequency at which the rule is run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>One_Hour: 1 hour.</para>
        /// </description></item>
        /// <item><description><para>Three_Hours: 3 hours.</para>
        /// </description></item>
        /// <item><description><para>Six_Hours: 6 hours.</para>
        /// </description></item>
        /// <item><description><para>Twelve_Hours: 12 hours.</para>
        /// </description></item>
        /// <item><description><para>TwentyFour_Hours (default): 24 hours.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when <c>ConfigRuleTriggerTypes</c> is set to <c>ScheduledNotification</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>One_Hour</para>
        /// </summary>
        [NameInMap("MaximumExecutionFrequency")]
        [Validation(Required=false)]
        public string MaximumExecutionFrequency { get; set; }

        /// <summary>
        /// <para>The regions where the rule is effective. The rule evaluates only resources in these regions. To specify multiple region IDs, separate them with a comma (,).</para>
        /// <remarks>
        /// <para>This parameter applies only to managed rules.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionIdsScope")]
        [Validation(Required=false)]
        public string RegionIdsScope { get; set; }

        /// <summary>
        /// <para>The resource groups where the rule is effective. The rule evaluates only resources in these resource groups. To specify multiple resource group IDs, separate them with a comma (,).</para>
        /// <remarks>
        /// <para>This parameter applies only to managed rules.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzc7r7rhx****</para>
        /// </summary>
        [NameInMap("ResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ResourceGroupIdsScope { get; set; }

        /// <summary>
        /// <para>The resources that the rule evaluates. To specify multiple resource IDs, separate them with a comma (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5cmbowstbkss9ta03****</para>
        /// </summary>
        [NameInMap("ResourceIdsScope")]
        [Validation(Required=false)]
        public string ResourceIdsScope { get; set; }

        /// <summary>
        /// <para>The names of the resources that the rule evaluates.</para>
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
        /// <para>The resource types that the rule evaluates. To specify multiple resource types, separate them with a comma (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::ECS::Instance</para>
        /// </summary>
        [NameInMap("ResourceTypesScope")]
        [Validation(Required=false)]
        public List<string> ResourceTypesScope { get; set; }

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
        /// <para>The tags of the resource. This parameter is deprecated. The value that you specify for this parameter does not take effect.</para>
        /// <para>You can add up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        [Obsolete]
        public List<UpdateConfigRuleRequestTag> Tag { get; set; }
        public class UpdateConfigRuleRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value-1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The logical relationship for the tags that you specify for the <c>TagsScope</c> parameter. For example, if you set the <c>TagsScope</c> parameter to <c>&quot;TagsScope.1.TagKey&quot;:&quot;a&quot;,&quot;TagsScope.1.TagValue&quot;:&quot;a&quot;,&quot;TagsScope.2.TagKey&quot;:&quot;b&quot;,&quot;TagsScope.2.TagValue&quot;:&quot;b&quot;</c> and set this parameter to <c>AND</c>, the rule applies only to resources that have both the <c>a:a</c> and <c>b:b</c> tags. If you do not specify this parameter, the <c>OR</c> logic is used by default.</para>
        /// <para>This parameter also applies to the deprecated <c>TagKeyScope</c> parameter, but this is not recommended. For example, if you set the <c>TagKeyScope</c> parameter to <c>ECS,OSS</c> and set this parameter to <c>AND</c>, the rule applies only to resources that have both the <c>ECS</c> and <c>OSS</c> tags.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AND</para>
        /// </description></item>
        /// <item><description><para>OR</para>
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
        /// <para>The rule is effective only for resources that have the specified tag.</para>
        /// <remarks>
        /// <para>This parameter applies only to managed rules. The <c>TagKeyScope</c> and <c>TagValueScope</c> parameters must be specified at the same time.</para>
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
        /// <para>The rule is effective only for resources that have the specified tag.</para>
        /// <remarks>
        /// <para>This parameter applies only to managed rules. The <c>TagKeyScope</c> and <c>TagValueScope</c> parameters must be specified at the same time.</para>
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
        /// <para>The tags that are used to filter resources.</para>
        /// </summary>
        [NameInMap("TagsScope")]
        [Validation(Required=false)]
        public List<UpdateConfigRuleRequestTagsScope> TagsScope { get; set; }
        public class UpdateConfigRuleRequestTagsScope : TeaModel {
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

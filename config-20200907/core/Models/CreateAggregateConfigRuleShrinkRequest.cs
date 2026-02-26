// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateAggregateConfigRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The rule applies only to resources of the specified member accounts. Separate multiple member account IDs with commas (,).</para>
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
        /// <para>The ID of the account group.</para>
        /// <para>For more information about how to obtain the ID of an account group, see <a href="https://help.aliyun.com/document_detail/255797.html">the referenced document</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-a4e5626622af0079****</para>
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// <para>A client token that ensures the request is idempotent. Generate a unique value from your client for each request. The <c>ClientToken</c> parameter must contain only ASCII characters and be no more than 64 characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1594295238-f9361358-5843-4294-8d30-b5183fac****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The conditions for a custom condition rule, in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ComplianceConditions&quot;:&quot;{\&quot;operator\&quot;:\&quot;and\&quot;,\&quot;children\&quot;:[{\&quot;operator\&quot;:\&quot;StringEquals\&quot;,\&quot;featurePath\&quot;:\&quot;$.Status\&quot;,\&quot;desired\&quot;:\&quot;1\&quot;,\&quot;featureSource\&quot;:\&quot;CONFIGURATION\&quot;}]}&quot;}</para>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>存在所有指定标签</para>
        /// </summary>
        [NameInMap("ConfigRuleName")]
        [Validation(Required=false)]
        public string ConfigRuleName { get; set; }

        /// <summary>
        /// <para>The trigger type for the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ConfigurationItemChangeNotification: The rule triggers when a resource configuration changes.</para>
        /// </description></item>
        /// <item><description><para>ScheduledNotification: The rule triggers on a schedule.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ConfigurationItemChangeNotification</para>
        /// </summary>
        [NameInMap("ConfigRuleTriggerTypes")]
        [Validation(Required=false)]
        public string ConfigRuleTriggerTypes { get; set; }

        /// <summary>
        /// <para>A description of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>最多可以定义6组标签。如果资源同时具有指定的所有标签，则视为“合规”。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The rule does not apply to resources of the specified member accounts. Resources in these accounts are not evaluated. Separate multiple member account IDs with commas (,).</para>
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
        /// <para>The rule does not apply to resources of member accounts in the specified folders. Resources in these folders are not evaluated. Separate multiple folder IDs with commas (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter applies only to global account group rules.</para>
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
        /// <para>The rule does not apply to resources in the specified regions. Resources in these regions are not evaluated. Separate multiple region IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("ExcludeRegionIdsScope")]
        [Validation(Required=false)]
        public string ExcludeRegionIdsScope { get; set; }

        /// <summary>
        /// <para>The rule does not apply to resources in the specified resource groups. Resources in these groups are not evaluated. Separate multiple resource group IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bnczc6r7rml****</para>
        /// </summary>
        [NameInMap("ExcludeResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceGroupIdsScope { get; set; }

        /// <summary>
        /// <para>The rule does not apply to the specified resources. These resources are not evaluated. Separate multiple resource IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-t4nbowvtbkss7t326****</para>
        /// </summary>
        [NameInMap("ExcludeResourceIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceIdsScope { get; set; }

        /// <summary>
        /// <para>The scope of tags to exclude.</para>
        /// </summary>
        [NameInMap("ExcludeTagsScope")]
        [Validation(Required=false)]
        public List<CreateAggregateConfigRuleShrinkRequestExcludeTagsScope> ExcludeTagsScope { get; set; }
        public class CreateAggregateConfigRuleShrinkRequestExcludeTagsScope : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource to exclude.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-2</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value of the resource to exclude.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value-2</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>Extended content. This parameter currently supports only setting the trigger time for rules that run on a 24-hour cycle.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;fixedHour&quot;:&quot;12&quot;}</para>
        /// </summary>
        [NameInMap("ExtendContent")]
        [Validation(Required=false)]
        public string ExtendContent { get; set; }

        /// <summary>
        /// <para>The rule applies only to resources of member accounts in the specified folders. Separate multiple folder IDs with commas (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter applies only to global account group rules.</para>
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
        /// <para>The input parameters for the rule.</para>
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
        /// <item><description><para>TwentyFour_Hours (default): 24 hours.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Set this parameter if you set <c>ConfigRuleTriggerTypes</c> to <c>ScheduledNotification</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>One_Hour</para>
        /// </summary>
        [NameInMap("MaximumExecutionFrequency")]
        [Validation(Required=false)]
        public string MaximumExecutionFrequency { get; set; }

        /// <summary>
        /// <para>The rule applies only to resources in the specified regions. Separate multiple region IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionIdsScope")]
        [Validation(Required=false)]
        public string RegionIdsScope { get; set; }

        /// <summary>
        /// <para>The rule applies only to resources in the specified resource groups. Separate multiple resource group IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzc7r7rhx****</para>
        /// </summary>
        [NameInMap("ResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ResourceGroupIdsScope { get; set; }

        /// <summary>
        /// <para>The rule applies only to the specified resources. Separate multiple resource IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5cmbowstbkss9ta03****</para>
        /// </summary>
        [NameInMap("ResourceIdsScope")]
        [Validation(Required=false)]
        public string ResourceIdsScope { get; set; }

        /// <summary>
        /// <para>The rule applies only to resources with the specified names.</para>
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
        /// <para>The resource types to evaluate. Separate multiple types with commas (,).</para>
        /// <para>This parameter is required.</para>
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
        /// <item><description><para>1: high</para>
        /// </description></item>
        /// <item><description><para>2: medium</para>
        /// </description></item>
        /// <item><description><para>3: low</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <item><description><para>If <c>SourceOwner</c> is <c>ALIYUN</c>, enter the identifier of the rule template, such as <c>required-tags</c>.</para>
        /// <remarks>
        /// <para>For more information about how to query rule template identifiers, see <a href="https://help.aliyun.com/document_detail/127404.html">the referenced document</a>.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>If <c>SourceOwner</c> is <c>CUSTOM_CONFIGURATION</c>, enter <c>acs-config-configuration</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>SourceOwner</c> is <c>CUSTOM_FC</c>, enter the Alibaba Cloud Resource Name (ARN) of the Function Compute function.</para>
        /// <para>The ARN format is <c>acs:fc:{region}:{accountId}:services/{serviceName}.LATEST/functions/{functionName}</c>. For example, <c>acs:fc:cn-hangzhou:120886317861****:services/service-test.LATEST/functions/config-test</c>.</para>
        /// <remarks>
        /// <para>For more information about how to obtain a function ARN, see <a href="https://help.aliyun.com/document_detail/415752.html">the referenced document</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>required-tags</para>
        /// </summary>
        [NameInMap("SourceIdentifier")]
        [Validation(Required=false)]
        public string SourceIdentifier { get; set; }

        /// <summary>
        /// <para>The type of rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ALIYUN: rule template</para>
        /// </description></item>
        /// <item><description><para>CUSTOM_FC: custom Function Compute rule</para>
        /// </description></item>
        /// <item><description><para>CUSTOM_CONFIGURATION: custom condition rule</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN</para>
        /// </summary>
        [NameInMap("SourceOwner")]
        [Validation(Required=false)]
        public string SourceOwner { get; set; }

        /// <summary>
        /// <para>The tag of the rule.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

        /// <summary>
        /// <para>The logical relationship between multiple tags in the <c>TagsScope</c> parameter. For example, if you set <c>TagsScope</c> to <c>&quot;TagsScope.1.TagKey&quot;:&quot;a&quot;,&quot;TagsScope.1.TagValue&quot;:&quot;a&quot;,&quot;TagsScope.2.TagKey&quot;:&quot;b&quot;,&quot;TagsScope.2.TagValue&quot;:&quot;b&quot;</c> and set this parameter to <c>AND</c>, the rule applies only to resources that have both the <c>a:a</c> and <c>b:b</c> tags. The default value is <c>OR</c>.</para>
        /// <para>You can also use this parameter with the deprecated <c>TagKeyScope</c> parameter, but this is not recommended. For example, if you set <c>TagKeyScope</c> to <c>ECS,OSS</c> and set this parameter to <c>AND</c>, the rule applies only to resources that have both the <c>ECS</c> and <c>OSS</c> tags.</para>
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
        /// <para>The rule applies only to resources that have the specified tag keys. Separate multiple tag keys with commas (,).</para>
        /// <remarks>
        /// <para>This parameter applies only to rule templates. Set both <c>TagKeyScope</c> and <c>TagValueScope</c> together.</para>
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
        /// <para>The rule applies only to resources that have the specified tag values.</para>
        /// <remarks>
        /// <para>This parameter applies only to rule templates. Set both <c>TagKeyScope</c> and <c>TagValueScope</c> together.</para>
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
        /// <para>The scope of tags to include.</para>
        /// </summary>
        [NameInMap("TagsScope")]
        [Validation(Required=false)]
        public List<CreateAggregateConfigRuleShrinkRequestTagsScope> TagsScope { get; set; }
        public class CreateAggregateConfigRuleShrinkRequestTagsScope : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-1</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
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

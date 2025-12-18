// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UpdateConfigRuleRequest : TeaModel {
        /// <summary>
        /// <para>The client token that you want to use to ensure the idempotency of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.``</para>
        /// 
        /// <b>Example:</b>
        /// <para>1594295238-f9361358-5843-4294-8d30-b5183fac****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the rule.</para>
        /// <para>For more information about how to query the ID of a rule, see <a href="https://help.aliyun.com/document_detail/169607.html">ListConfigRules</a>.</para>
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
        /// <para>For more information about how to query the name of a rule, see <a href="https://help.aliyun.com/document_detail/264148.html">ListAggregateConfigRules</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The name of the rule.</para>
        /// </summary>
        [NameInMap("ConfigRuleName")]
        [Validation(Required=false)]
        public string ConfigRuleName { get; set; }

        /// <summary>
        /// <para>The trigger type of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ConfigurationItemChangeNotification: The rule is triggered by configuration changes.</description></item>
        /// <item><description>ScheduledNotification: The rule is periodically triggered.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter applies only to custom rules.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ConfigurationItemChangeNotification</para>
        /// </summary>
        [NameInMap("ConfigRuleTriggerTypes")]
        [Validation(Required=false)]
        public string ConfigRuleTriggerTypes { get; set; }

        /// <summary>
        /// <para>The description of the rule. You can enter up to 500 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The description of the rule.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The IDs of the regions excluded from the compliance evaluations performed by the rule. Separate multiple region IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("ExcludeRegionIdsScope")]
        [Validation(Required=false)]
        public string ExcludeRegionIdsScope { get; set; }

        /// <summary>
        /// <para>The IDs of the resource groups excluded from the compliance evaluations performed by the rule. Separate multiple resource group IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bnczc6r7rml****</para>
        /// </summary>
        [NameInMap("ExcludeResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceGroupIdsScope { get; set; }

        /// <summary>
        /// <para>The IDs of the resources excluded from the compliance evaluations performed by the rule. Separate multiple resource IDs with commas (,).</para>
        /// <remarks>
        /// <para> This parameter applies only to a managed rule.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>lb-t4nbowvtbkss7t326****</para>
        /// </summary>
        [NameInMap("ExcludeResourceIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceIdsScope { get; set; }

        /// <summary>
        /// <para>The scope of the tag that is excluded.</para>
        /// </summary>
        [NameInMap("ExcludeTagsScope")]
        [Validation(Required=false)]
        public List<UpdateConfigRuleRequestExcludeTagsScope> ExcludeTagsScope { get; set; }
        public class UpdateConfigRuleRequestExcludeTagsScope : TeaModel {
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
        /// <para>Optional. The extended content of the resource. This parameter can be used together with the MaximumExecutionFrequency parameter when the MaximumExecutionFrequency parameter is set to TwentyFour_Hours to specify the trigger time.</para>
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
        /// <para>The interval at which the rule is triggered. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>One_Hour</description></item>
        /// <item><description>Three_Hours</description></item>
        /// <item><description>Six_Hours</description></item>
        /// <item><description>Twelve_Hours</description></item>
        /// <item><description>TwentyFour_Hours (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if the <c>ConfigRuleTriggerTypes</c> parameter is set to <c>ScheduledNotification</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>One_Hour</para>
        /// </summary>
        [NameInMap("MaximumExecutionFrequency")]
        [Validation(Required=false)]
        public string MaximumExecutionFrequency { get; set; }

        /// <summary>
        /// <para>The IDs of the regions to which the rule applies. Separate multiple region IDs with commas (,).</para>
        /// <remarks>
        /// <para> This parameter applies only to a managed rule.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionIdsScope")]
        [Validation(Required=false)]
        public string RegionIdsScope { get; set; }

        /// <summary>
        /// <para>The IDs of the resource groups to which the rule applies. Separate multiple resource group IDs with commas (,).</para>
        /// <remarks>
        /// <para> This parameter applies only to a managed rule.</para>
        /// </remarks>
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
        /// <para>lb-5cmbowstbkss9ta03****</para>
        /// </summary>
        [NameInMap("ResourceIdsScope")]
        [Validation(Required=false)]
        public string ResourceIdsScope { get; set; }

        /// <summary>
        /// <para>The names of the resource to which the rule applies.</para>
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
        /// <para>The type of the resource to be evaluated by the rule. Separate multiple resource types with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::ECS::Instance</para>
        /// </summary>
        [NameInMap("ResourceTypesScope")]
        [Validation(Required=false)]
        public List<string> ResourceTypesScope { get; set; }

        /// <summary>
        /// <para>The risk level of the resources that do not comply with the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: high</description></item>
        /// <item><description>2: medium</description></item>
        /// <item><description>3: low</description></item>
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
        /// <para>The tags of the resource.</para>
        /// <para>You can add up to 20 tags to a resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        [Obsolete]
        public List<UpdateConfigRuleRequestTag> Tag { get; set; }
        public class UpdateConfigRuleRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the key pair. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N. Valid values of N: <b>1 to 20</b>. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag value cannot start with <c>aliyun</c> and <c>acs:</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value-1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The logical relationship when parameter <c>TagsScope</c> takes multiple values, for example: When the parameter <c>TagsScope</c> is <c>&quot;TagsScope.1.TagKey&quot;:&quot;a&quot;, &quot;TagsScope.1.TagValue&quot;:&quot;a&quot;, &quot;TagsScope.2.TagKey&quot;:&quot;b&quot;, &quot;TagsScope.2.TagValue&quot;:&quot;b&quot;</c>, if this parameter is set to<c> AND</c>, it means that the rule only applies to resources bound with both tags <c>a:a</c> and <c>b:b</c>. If not specified, the default logic is <c>OR</c>.</para>
        /// <para>It can also be used for the deprecated field <c>TagKeyScope</c> (not recommended), for example: When the parameter <c>TagKeyScope</c> has a value of <c>ECS</c>,<c>OSS</c>, if this parameter is set to <c>AND</c>, it means that the rule only applies to resources bound with both labels <c>ECS</c> and <c>OSS</c>.</para>
        /// <para>Values:</para>
        /// <list type="bullet">
        /// <item><description><para>AND: And.</para>
        /// </description></item>
        /// <item><description><para>OR: Or.</para>
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
        /// <para>This parameter is deprecated. We recommend that you use the <c>TagsScope</c> parameter.</para>
        /// <para>The tag key used to filter resources. The rule applies only to the resources with the specified tag key.</para>
        /// <remarks>
        /// <para> This parameter applies only to a managed rule. You must configure the <c>TagKeyScope</c> and <c>TagValueScope</c> parameters at the same time.</para>
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
        /// <para>This parameter is deprecated. We recommend that you use the <c>TagsScope</c> parameter.</para>
        /// <para>The tag value used to filter resources. The rule applies only to the resources that use the specified tag value.</para>
        /// <remarks>
        /// <para> This parameter applies only to a managed rule. You must configure the <c>TagKeyScope</c> and <c>TagValueScope</c> parameters at the same time.</para>
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
        public List<UpdateConfigRuleRequestTagsScope> TagsScope { get; set; }
        public class UpdateConfigRuleRequestTagsScope : TeaModel {
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

}

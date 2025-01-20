// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateConfigRuleRequest : TeaModel {
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
        /// <para>The name of the rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>required-tags</para>
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
        /// <para> If a rule supports the preceding trigger types, separate the types with a comma (,).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
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
        /// <para>example-description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>ExcludeRegionIdsScope</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("ExcludeRegionIdsScope")]
        [Validation(Required=false)]
        public string ExcludeRegionIdsScope { get; set; }

        /// <summary>
        /// <para>ExcludeResourceGroupIdsScope</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bnczc6r7rml****</para>
        /// </summary>
        [NameInMap("ExcludeResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceGroupIdsScope { get; set; }

        /// <summary>
        /// <para>The ID of the resource to be excluded from the compliance evaluations performed by the rule. Separate multiple resource IDs with commas (,).</para>
        /// <remarks>
        /// <para> This parameter applies only to managed rules.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>lb-t4nbowvtbkss7t326****</para>
        /// </summary>
        [NameInMap("ExcludeResourceIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceIdsScope { get; set; }

        /// <summary>
        /// <para>ExcludeTagsScope</para>
        /// </summary>
        [NameInMap("ExcludeTagsScope")]
        [Validation(Required=false)]
        public List<CreateConfigRuleRequestExcludeTagsScope> ExcludeTagsScope { get; set; }
        public class CreateConfigRuleRequestExcludeTagsScope : TeaModel {
            /// <summary>
            /// <para>TagKey</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-2</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>TagValue</para>
            /// 
            /// <b>Example:</b>
            /// <para>value-2</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>Optional field, only used in conjunction with the 24-hour cycle execution to set the trigger time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;fixedHour&quot;:&quot;13&quot;}</para>
        /// </summary>
        [NameInMap("ExtendContent")]
        [Validation(Required=false)]
        public string ExtendContent { get; set; }

        /// <summary>
        /// <para>The input parameter of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;tag1Key&quot;:&quot;ECS&quot;,&quot;tag1Value&quot;:&quot;test&quot;}</para>
        /// </summary>
        [NameInMap("InputParameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> InputParameters { get; set; }

        /// <summary>
        /// <para>The intervals at which the rule is triggered. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>One_Hour: 1 hour.</description></item>
        /// <item><description>Three_Hours: 3 hours.</description></item>
        /// <item><description>Six_Hours: 6 hours.</description></item>
        /// <item><description>Twelve_Hours: 12 hours.</description></item>
        /// <item><description>TwentyFour_Hours (default): 24 hours.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if the ConfigRuleTriggerTypes parameter is set to ScheduledNotification.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>One_Hour</para>
        /// </summary>
        [NameInMap("MaximumExecutionFrequency")]
        [Validation(Required=false)]
        public string MaximumExecutionFrequency { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the rule applies. Separate multiple region IDs with commas (,).</para>
        /// <remarks>
        /// <para> This parameter applies only to managed rules.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionIdsScope")]
        [Validation(Required=false)]
        public string RegionIdsScope { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the rule applies. Separate multiple resource group IDs with commas (,).</para>
        /// <remarks>
        /// <para> This parameter applies only to managed rules.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzc7r7rhx****</para>
        /// </summary>
        [NameInMap("ResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ResourceGroupIdsScope { get; set; }

        /// <summary>
        /// <para>ResourceIdsScope</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5cmbowstbkss9ta03****</para>
        /// </summary>
        [NameInMap("ResourceIdsScope")]
        [Validation(Required=false)]
        public string ResourceIdsScope { get; set; }

        /// <summary>
        /// <para>The type of the resource to be evaluated by the rule. Separate multiple resource types with commas (,).</para>
        /// <para>This parameter is required.</para>
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
        /// <item><description>1: high.</description></item>
        /// <item><description>2: medium.</description></item>
        /// <item><description>3: low.</description></item>
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
        /// <para>The ID of the rule.</para>
        /// <list type="bullet">
        /// <item><description>If you set the SourceOwner parameter to ALIYUN, set this parameter to the name of the managed rule.</description></item>
        /// <item><description>If you set the SourceOwner parameter to CUSTOM_FC, set this parameter to the Alibaba Cloud Resource Name (ARN) of the relevant function in Function Compute.</description></item>
        /// </list>
        /// <para>For more information about how to query the name of a managed rule, see <a href="https://help.aliyun.com/document_detail/127404.html">Managed rules</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>required-tags</para>
        /// </summary>
        [NameInMap("SourceIdentifier")]
        [Validation(Required=false)]
        public string SourceIdentifier { get; set; }

        /// <summary>
        /// <para>The type of the rule Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALIYUN: managed rule.</description></item>
        /// <item><description>CUSTOM_FC: custom rule.</description></item>
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
        /// <para>rule attached tags</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateConfigRuleRequestTag> Tag { get; set; }
        public class CreateConfigRuleRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag keys.</para>
            /// <para>The tag keys cannot be an empty string. The tag keys can be up to 64 characters in length. The tag keys cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify at most 20 tag keys in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. The tag value cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value-1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The logical relationship among the tag keys if you specify multiple tag keys for <c>TagKeyScope</c>. For example, if you set <c>TagKeyScope</c> to <c>ECS,OSS</c> and set TagKeyLogicScope to <c>AND</c>, the rule applies to resources with both the <c>ECS</c> and <c>OSS</c> tag keys. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AND</description></item>
        /// <item><description>OR</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AND</para>
        /// </summary>
        [NameInMap("TagKeyLogicScope")]
        [Validation(Required=false)]
        public string TagKeyLogicScope { get; set; }

        /// <summary>
        /// <para>The tag key used to filter resources. The rule applies only to the resources with the specified tag key.</para>
        /// <remarks>
        /// <para> This parameter applies only to managed rules. You must specify both <c>TagKeyScope</c> and <c>TagValueScope</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("TagKeyScope")]
        [Validation(Required=false)]
        public string TagKeyScope { get; set; }

        /// <summary>
        /// <para>The tag value used to filter resources. The rule applies only to the resources that use the specified tag value.</para>
        /// <remarks>
        /// <para> This parameter applies only to managed rules. You must specify both <c>TagKeyScope</c> and <c>TagValueScope</c>.</para>
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
        public List<CreateConfigRuleRequestTagsScope> TagsScope { get; set; }
        public class CreateConfigRuleRequestTagsScope : TeaModel {
            /// <summary>
            /// <para>TagKey</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-1</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>TagValue</para>
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

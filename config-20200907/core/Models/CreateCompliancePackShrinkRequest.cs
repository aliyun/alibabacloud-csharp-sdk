// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateCompliancePackShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client token that you want to use to ensure the idempotency of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.``</para>
        /// 
        /// <b>Example:</b>
        /// <para>1594295238-f9361358-5843-4294-8d30-b5183fac****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the compliance package.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-pack-name</para>
        /// </summary>
        [NameInMap("CompliancePackName")]
        [Validation(Required=false)]
        public string CompliancePackName { get; set; }

        /// <summary>
        /// <para>The ID of the compliance package template.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/261176.html">ListCompliancePackTemplates</a> operation to obtain the ID of the compliance package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ct-5f26ff4e06a300c4****</para>
        /// </summary>
        [NameInMap("CompliancePackTemplateId")]
        [Validation(Required=false)]
        public string CompliancePackTemplateId { get; set; }

        /// <summary>
        /// <para>The rules in the compliance package. You must specify either this parameter or TemplateContent.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("ConfigRules")]
        [Validation(Required=false)]
        public string ConfigRulesShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the rule together with the compliance package. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The system enables the rule together with the compliance package.</description></item>
        /// <item><description>false: The system does not enable the rule together with the compliance package.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DefaultEnable")]
        [Validation(Required=false)]
        public bool? DefaultEnable { get; set; }

        /// <summary>
        /// <para>The description of the compliance package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test pack description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>ExcludeRegionIdsScope</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ExcludeRegionIdsScope")]
        [Validation(Required=false)]
        public string ExcludeRegionIdsScope { get; set; }

        /// <summary>
        /// <para>ExcludeResourceGroupIdsScope. Separate multiple resource group IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bnczc6r7rml****</para>
        /// </summary>
        [NameInMap("ExcludeResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceGroupIdsScope { get; set; }

        /// <summary>
        /// <para>The ID of the resource that you do not want to evaluate by using the compliance package. Separate multiple resource IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-8vbf3x310fn56ijfd****</para>
        /// </summary>
        [NameInMap("ExcludeResourceIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceIdsScope { get; set; }

        /// <summary>
        /// <para>ExcludeTagsScope</para>
        /// </summary>
        [NameInMap("ExcludeTagsScope")]
        [Validation(Required=false)]
        public List<CreateCompliancePackShrinkRequestExcludeTagsScope> ExcludeTagsScope { get; set; }
        public class CreateCompliancePackShrinkRequestExcludeTagsScope : TeaModel {
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
        /// <para>The ID of the region whose resources you want to evaluate by using the compliance package. Separate multiple region IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionIdsScope")]
        [Validation(Required=false)]
        public string RegionIdsScope { get; set; }

        /// <summary>
        /// <para>The ID of the resource group whose resources you want to evaluate by using the compliance package. Separate multiple resource group IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzdibsjjc****</para>
        /// </summary>
        [NameInMap("ResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ResourceGroupIdsScope { get; set; }

        /// <summary>
        /// <para>ResourceIdsScope</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-8vbf3x310fn56ijfd****</para>
        /// </summary>
        [NameInMap("ResourceIdsScope")]
        [Validation(Required=false)]
        public string ResourceIdsScope { get; set; }

        /// <summary>
        /// <para>The risk level of the resources that are not compliant with the rules in the compliance package. Default value: 2. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: high.</description></item>
        /// <item><description>2: medium.</description></item>
        /// <item><description>3: low.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public int? RiskLevel { get; set; }

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
        /// <remarks>
        /// <para> You must configure the TagValueScope parameter together with the TagKeyScope parameter.</para>
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
        public List<CreateCompliancePackShrinkRequestTagsScope> TagsScope { get; set; }
        public class CreateCompliancePackShrinkRequestTagsScope : TeaModel {
            /// <summary>
            /// <para>Tagkey</para>
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

        /// <summary>
        /// <para>The information about the template that is used to generate the compliance package. You can call an API operation to view the details of an existing compliance package or write a compliance package template. For more information, see <a href="https://help.aliyun.com/document_detail/2659733.html">Write a compliance package template in a configuration file</a>. You must specify one of ConfigRules and TemplateContent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;configRuleTemplates&quot;: [ { &quot;configRuleName&quot;: &quot;condition-rule-example&quot;, &quot;scope&quot;: { &quot;complianceResourceTypes&quot;: [ &quot;ACS::ECS::Instance&quot; ] }, &quot;description&quot;: &quot;&quot;, &quot;source&quot;: { &quot;owner&quot;: &quot;CUSTOM_CONFIGURATION&quot;, &quot;identifier&quot;: &quot;acs-config-configuration&quot;, &quot;sourceDetails&quot;: [ { &quot;messageType&quot;: &quot;ScheduledNotification&quot;, &quot;maximumExecutionFrequency&quot;: &quot;Twelve_Hours&quot; }, { &quot;messageType&quot;: &quot;ConfigurationItemChangeNotification&quot; } ], &quot;conditions&quot;: &quot;{\\&quot;ComplianceConditions\\&quot;:\\&quot;{\\\\\&quot;operator\\\\\&quot;:\\\\\&quot;and\\\\\&quot;,\\\\\&quot;children\\\\\&quot;:[{\\\\\&quot;operator\\\\\&quot;:\\\\\&quot;GreaterOrEquals\\\\\&quot;,\\\\\&quot;featurePath\\\\\&quot;:\\\\\&quot;$.Cpu\\\\\&quot;,\\\\\&quot;featureSource\\\\\&quot;:\\\\\&quot;CONFIGURATION\\\\\&quot;,\\\\\&quot;desired\\\\\&quot;:\\\\\&quot;2\\\\\&quot;}]}\\&quot;}&quot; }, &quot;inputParameters&quot;: {} }, { &quot;configRuleName&quot;: &quot;oss-bucket-referer-limit&quot;, &quot;scope&quot;: { &quot;complianceResourceTypes&quot;: [ &quot;ACS::OSS::Bucket&quot; ] }, &quot;description&quot;: &quot;If the hotlink protection feature is enabled for the Object Storage Service (OSS) bucket and the Referer is added to a specific whitelist, the evaluation result is compliant.&quot;, &quot;source&quot;: { &quot;owner&quot;: &quot;ALIYUN&quot;, &quot;identifier&quot;: &quot;oss-bucket-referer-limit&quot;, &quot;sourceDetails&quot;: [ { &quot;messageType&quot;: &quot;ConfigurationItemChangeNotification&quot; } ] }, &quot;inputParameters&quot;: { &quot;allowEmptyReferer&quot;: &quot;true&quot;, &quot;allowReferers&quot;: &quot;<a href="http://www.aliyun.com">http://www.aliyun.com</a>&quot; } } ] }</para>
        /// </summary>
        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public string TemplateContent { get; set; }

    }

}

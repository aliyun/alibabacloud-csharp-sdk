// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetAutoGroupingRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9EA4F962-1A2E-4AFE-BE0C-B14736FC46CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the rule.</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public GetAutoGroupingRuleResponseBodyRule Rule { get; set; }
        public class GetAutoGroupingRuleResponseBodyRule : TeaModel {
            /// <summary>
            /// <para>The time when the rule was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The IDs of excluded regions. Multiple IDs are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou,cn-shanghai</para>
            /// </summary>
            [NameInMap("ExcludeRegionIdsScope")]
            [Validation(Required=false)]
            public string ExcludeRegionIdsScope { get; set; }

            /// <summary>
            /// <para>The IDs of excluded resource groups. Multiple IDs are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekz<b><b><b>4b5ea,rg-aek2</b></b></b>fxykq</para>
            /// </summary>
            [NameInMap("ExcludeResourceGroupIdsScope")]
            [Validation(Required=false)]
            public string ExcludeResourceGroupIdsScope { get; set; }

            /// <summary>
            /// <para>The IDs of excluded resources. Multiple IDs are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2zee<b><b><b>ym49kfmwis,vpc-5ts6</b></b></b>fnw493g849a</para>
            /// </summary>
            [NameInMap("ExcludeResourceIdsScope")]
            [Validation(Required=false)]
            public string ExcludeResourceIdsScope { get; set; }

            /// <summary>
            /// <para>The excluded resource types. Multiple resource types are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.instance,vpc.vpc</para>
            /// </summary>
            [NameInMap("ExcludeResourceTypesScope")]
            [Validation(Required=false)]
            public string ExcludeResourceTypesScope { get; set; }

            /// <summary>
            /// <para>The time when the rule was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The IDs of regions. Multiple IDs are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou,cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionIdsScope")]
            [Validation(Required=false)]
            public string RegionIdsScope { get; set; }

            /// <summary>
            /// <para>The IDs of resource groups. Multiple IDs are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekz<b><b><b>4b5ea,rg-aek2</b></b></b>fxykq</para>
            /// </summary>
            [NameInMap("ResourceGroupIdsScope")]
            [Validation(Required=false)]
            public string ResourceGroupIdsScope { get; set; }

            /// <summary>
            /// <para>The IDs of resources. Multiple IDs are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2zee<b><b><b>ym49kfmwis,vpc-5ts6</b></b></b>fnw493g849a</para>
            /// </summary>
            [NameInMap("ResourceIdsScope")]
            [Validation(Required=false)]
            public string ResourceIdsScope { get; set; }

            /// <summary>
            /// <para>The resource types. Multiple resource types are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.instance,vpc.vpc</para>
            /// </summary>
            [NameInMap("ResourceTypesScope")]
            [Validation(Required=false)]
            public string ResourceTypesScope { get; set; }

            /// <summary>
            /// <para>The content records of the rule.</para>
            /// </summary>
            [NameInMap("RuleContents")]
            [Validation(Required=false)]
            public List<GetAutoGroupingRuleResponseBodyRuleRuleContents> RuleContents { get; set; }
            public class GetAutoGroupingRuleResponseBodyRuleRuleContents : TeaModel {
                /// <summary>
                /// <para>The condition for the range of resources that are automatically transferred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;children&quot;:[{&quot;desired&quot;:&quot;{\&quot;env\&quot;:\&quot;online\&quot;, \&quot;project\&quot;:\&quot;A\&quot;}&quot;,&quot;featurePath&quot;:&quot;$.tags&quot;,&quot;featureSource&quot;:&quot;RESOURCE&quot;,&quot;operator&quot;:&quot;TagMatchAll&quot;}],&quot;operator&quot;:&quot;and&quot;}</para>
                /// </summary>
                [NameInMap("AutoGroupingScopeCondition")]
                [Validation(Required=false)]
                public string AutoGroupingScopeCondition { get; set; }

                /// <summary>
                /// <para>The ID of the content record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>grc-acfo******fwybpq</para>
                /// </summary>
                [NameInMap("RuleContentId")]
                [Validation(Required=false)]
                public string RuleContentId { get; set; }

                /// <summary>
                /// <para>The condition for the destination resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;children&quot;:[{&quot;desired&quot;:&quot;rg-aek2********qcy&quot;,&quot;featurePath&quot;:&quot;$.resourceGroupId&quot;,&quot;featureSource&quot;:&quot;RESOURCE&quot;,&quot;operator&quot;:&quot;StringEquals&quot;}],&quot;operator&quot;:&quot;and&quot;}</para>
                /// </summary>
                [NameInMap("TargetResourceGroupCondition")]
                [Validation(Required=false)]
                public string TargetResourceGroupCondition { get; set; }

            }

            /// <summary>
            /// <para>The description of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Transfer resources to which the {&quot;env&quot;: &quot;online&quot;} and {&quot;project&quot;: &quot;A&quot;} tags are added to the resource group rg-aek2********qcy.</para>
            /// </summary>
            [NameInMap("RuleDesc")]
            [Validation(Required=false)]
            public string RuleDesc { get; set; }

            /// <summary>
            /// <para>The ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gr-acfo******hy6a</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom Transfer Rule for Online Resources of Project A</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The type of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>custom_condition: custom transfer rule</description></item>
            /// <item><description>associated_transfer: transfer rule for associated resources</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>associated_transfer</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

        }

    }

}

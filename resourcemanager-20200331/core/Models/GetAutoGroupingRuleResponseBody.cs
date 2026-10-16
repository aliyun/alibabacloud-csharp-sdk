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
        /// <para>The rule information.</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public GetAutoGroupingRuleResponseBodyRule Rule { get; set; }
        public class GetAutoGroupingRuleResponseBodyRule : TeaModel {
            /// <summary>
            /// <para>The time when the rule was created, in RFC 3339 format with a UTC offset of +08:00.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The excluded region IDs. Multiple region IDs are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou,cn-shanghai</para>
            /// </summary>
            [NameInMap("ExcludeRegionIdsScope")]
            [Validation(Required=false)]
            public string ExcludeRegionIdsScope { get; set; }

            /// <summary>
            /// <para>The excluded resource group IDs. Multiple resource group IDs are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekz<b><b><b>4b5ea,rg-aek2</b></b></b>fxykq</para>
            /// </summary>
            [NameInMap("ExcludeResourceGroupIdsScope")]
            [Validation(Required=false)]
            public string ExcludeResourceGroupIdsScope { get; set; }

            /// <summary>
            /// <para>The excluded resource IDs. Multiple resource IDs are separated by commas (,).</para>
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
            /// <para>The time when the rule was last modified, in RFC 3339 format with a UTC offset of +08:00.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The region IDs in scope. Multiple region IDs are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou,cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionIdsScope")]
            [Validation(Required=false)]
            public string RegionIdsScope { get; set; }

            /// <summary>
            /// <para>The resource group IDs in scope. Multiple resource group IDs are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekz<b><b><b>4b5ea,rg-aek2</b></b></b>fxykq</para>
            /// </summary>
            [NameInMap("ResourceGroupIdsScope")]
            [Validation(Required=false)]
            public string ResourceGroupIdsScope { get; set; }

            /// <summary>
            /// <para>The resource IDs in scope. Multiple resource IDs are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2zee<b><b><b>ym49kfmwis,vpc-5ts6</b></b></b>fnw493g849a</para>
            /// </summary>
            [NameInMap("ResourceIdsScope")]
            [Validation(Required=false)]
            public string ResourceIdsScope { get; set; }

            /// <summary>
            /// <para>The resource types in scope. Multiple resource types are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.instance,vpc.vpc</para>
            /// </summary>
            [NameInMap("ResourceTypesScope")]
            [Validation(Required=false)]
            public string ResourceTypesScope { get; set; }

            /// <summary>
            /// <para>The list of rule contents.</para>
            /// </summary>
            [NameInMap("RuleContents")]
            [Validation(Required=false)]
            public List<GetAutoGroupingRuleResponseBodyRuleRuleContents> RuleContents { get; set; }
            public class GetAutoGroupingRuleResponseBodyRuleRuleContents : TeaModel {
                /// <summary>
                /// <para>The scope condition for automatic group transfer, which specifies the range of resources to be automatically transferred to a resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;children&quot;:[{&quot;desired&quot;:&quot;{\&quot;env\&quot;:\&quot;online\&quot;, \&quot;project\&quot;:\&quot;A\&quot;}&quot;,&quot;featurePath&quot;:&quot;$.tags&quot;,&quot;featureSource&quot;:&quot;RESOURCE&quot;,&quot;operator&quot;:&quot;TagMatchAll&quot;}],&quot;operator&quot;:&quot;and&quot;}</para>
                /// </summary>
                [NameInMap("AutoGroupingScopeCondition")]
                [Validation(Required=false)]
                public string AutoGroupingScopeCondition { get; set; }

                /// <summary>
                /// <para>The rule content ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>grc-acfo******fwybpq</para>
                /// </summary>
                [NameInMap("RuleContentId")]
                [Validation(Required=false)]
                public string RuleContentId { get; set; }

                /// <summary>
                /// <para>The target resource group condition, which specifies the destination resource group for automatic grouping.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;children&quot;:[{&quot;desired&quot;:&quot;rg-aek2********qcy&quot;,&quot;featurePath&quot;:&quot;$.resourceGroupId&quot;,&quot;featureSource&quot;:&quot;RESOURCE&quot;,&quot;operator&quot;:&quot;StringEquals&quot;}],&quot;operator&quot;:&quot;and&quot;}</para>
                /// </summary>
                [NameInMap("TargetResourceGroupCondition")]
                [Validation(Required=false)]
                public string TargetResourceGroupCondition { get; set; }

            }

            /// <summary>
            /// <para>The rule description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Transfer resources with tags {&quot;env&quot;: &quot;online&quot;} and {&quot;project&quot;: &quot;A&quot;} to resource group rg-aek2********qcy</para>
            /// </summary>
            [NameInMap("RuleDesc")]
            [Validation(Required=false)]
            public string RuleDesc { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gr-acfo******hy6a</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Automatic group transfer rule for Project A online resources</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The rule type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>custom_condition: Transfer based on custom rules.</description></item>
            /// <item><description>associated_transfer: Transfer associated resources together.</description></item>
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

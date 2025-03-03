// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UpdateAutoGroupingRuleRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of regions to be excluded. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing,cn-guangzhou</para>
        /// </summary>
        [NameInMap("ExcludeRegionIdsScope")]
        [Validation(Required=false)]
        public string ExcludeRegionIdsScope { get; set; }

        /// <summary>
        /// <para>The IDs of resource groups to be excluded. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekz<b><b><b>zj2oi,rg-aekz</b></b></b>r62ua</para>
        /// </summary>
        [NameInMap("ExcludeResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceGroupIdsScope { get; set; }

        /// <summary>
        /// <para>The IDs of resources to be excluded. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-uf6p******4h784y,rmq-cn-******ny0y</para>
        /// </summary>
        [NameInMap("ExcludeResourceIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceIdsScope { get; set; }

        /// <summary>
        /// <para>The resource types to be excluded. Separate multiple resource types with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse.cluster,slb.loadbalancer</para>
        /// </summary>
        [NameInMap("ExcludeResourceTypesScope")]
        [Validation(Required=false)]
        public string ExcludeResourceTypesScope { get; set; }

        /// <summary>
        /// <para>The IDs of regions. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou,cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionIdsScope")]
        [Validation(Required=false)]
        public string RegionIdsScope { get; set; }

        /// <summary>
        /// <para>The IDs of resource groups. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekz<b><b><b>4b5ea,rg-aek2</b></b></b>fxykq</para>
        /// </summary>
        [NameInMap("ResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ResourceGroupIdsScope { get; set; }

        /// <summary>
        /// <para>The IDs of resources. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2zee<b><b><b>ym49kfmwis,vpc-5ts6</b></b></b>fnw493g849a</para>
        /// </summary>
        [NameInMap("ResourceIdsScope")]
        [Validation(Required=false)]
        public string ResourceIdsScope { get; set; }

        /// <summary>
        /// <para>The resource types. Separate multiple resource types with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds.dbinstance,oss.bucket</para>
        /// </summary>
        [NameInMap("ResourceTypesScope")]
        [Validation(Required=false)]
        public string ResourceTypesScope { get; set; }

        /// <summary>
        /// <para>The content records of the rule.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RuleContents")]
        [Validation(Required=false)]
        public List<UpdateAutoGroupingRuleRequestRuleContents> RuleContents { get; set; }
        public class UpdateAutoGroupingRuleRequestRuleContents : TeaModel {
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
            /// <para>This parameter is required.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gr-acfo******hy6a</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom Transfer Rule for Online Resources of Project A</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}

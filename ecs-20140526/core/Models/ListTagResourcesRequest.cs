// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the resource. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource IDs. Valid values of N: 1 to 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1j6qtvdm8w0z1o****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>instance: ECS instance</description></item>
        /// <item><description>disk: disk</description></item>
        /// <item><description>snapshot: snapshot</description></item>
        /// <item><description>image: image</description></item>
        /// <item><description>securitygroup: security group</description></item>
        /// <item><description>volume: storage volume</description></item>
        /// <item><description>eni: elastic network interface (ENI)</description></item>
        /// <item><description>ddh: dedicated host</description></item>
        /// <item><description>ddhcluster: dedicated host cluster</description></item>
        /// <item><description>keypair: SSH key pair</description></item>
        /// <item><description>launchtemplate: launch template</description></item>
        /// <item><description>reservedinstance: reserved instance</description></item>
        /// <item><description>snapshotpolicy: automatic snapshot policy</description></item>
        /// <item><description>elasticityassurance: elasticity assurance</description></item>
        /// <item><description>capacityreservation: capacity reservation</description></item>
        /// <item><description>command: Cloud Assistant command</description></item>
        /// <item><description>invocation: Cloud Assistant command execution result or file delivery result</description></item>
        /// <item><description>activation: activation code for a Cloud Assistant managed instance</description></item>
        /// <item><description>managedinstance: Cloud Assistant managed instance</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N used for exact search of ECS resources. The tag key must be 1 to 128 characters in length. Valid values of N: 1 to 20.</para>
            /// <para>Methods of using the <c>Tag.N</c> parameter pair (Tag.N.Key and Tag.N.Value):</para>
            /// <list type="bullet">
            /// <item><description><para>Method 1: Use this parameter pair for exact search of ECS resources that have specified tags added. Each tag is a key-value pair.</para>
            /// <list type="bullet">
            /// <item><description>If you specify only <c>Tag.N.Key</c>, all ECS resources whose tags contain the specified tag key are returned.</description></item>
            /// <item><description>If you specify only <c>Tag.N.Value</c>, the <c>InvalidParameter.TagValue</c> error is returned.</description></item>
            /// <item><description>If you specify multiple tag key-value pairs, only the ECS resources that have all these tag key-value pairs added are returned.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Method 2: Use this parameter pair to query resource information of a non-default resource group. Set <c>Key</c> to <c>acs:rm:rgId</c> and <c>Value</c> to the ID of a resource group.</para>
            /// <list type="bullet">
            /// <item><description>If you set <c>Key</c> to <c>acs:rm:rgId</c>, you must set <c>Value</c> to the ID of a non-default resource group. If you set Value to the ID of the default resource group, an error message is returned.</description></item>
            /// <item><description>If you set <c>Key</c> to <c>acs:rm:rgId</c>, you cannot specify other Tag.N parameter pairs. If you specify multiple <c>Tag.N</c> parameter pairs to query resource groups and resources at the same time, an error message is returned.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N used for exact search of ECS resources. The tag value must be 1 to 128 characters in length. Valid values of N: 1 to 20.</para>
            /// <remarks>
            /// <para>When Key is set to <c>acs:rm:rgId</c>, you can set Value only to the ID of a non-default resource group.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The regular expressions used to filter tags.</para>
        /// </summary>
        [NameInMap("TagFilter")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTagFilter> TagFilter { get; set; }
        public class ListTagResourcesRequestTagFilter : TeaModel {
            /// <summary>
            /// <para>The key of tag N used for fuzzy search of ECS resources. The tag key must be 1 to 128 characters in length. Valid values of N: 1 to 5.</para>
            /// <para>The <c>TagFilter.N</c> parameter pair (TagFilter.N.TagKey and TagFilter.N.TagValues.N) is used for fuzzy search of ECS resources that have specified tags added. In the specified tags, a single tag key may correspond to one or more tag values. Fuzzy search may have a latency of 2 seconds. A fuzzy search can return a result set of entries about a maximum of 5,000 resources.</para>
            /// <list type="bullet">
            /// <item><description>When you use <c>TagFilter.N.TagKey</c> for fuzzy search of ECS resources, you must leave <c>TagFilter.N.TagValues.N</c> empty. For example, to query ECS resources whose tags contain the <c>environment</c> tag key, you can set <c>TagFilter.1.TagKey</c> to <c>env*</c> for prefix search, <c>*env*</c> for infix search, or <c>env</c> for exact search, but you must leave <c>TagFilter.1.TagValues</c> empty.</description></item>
            /// <item><description>When you use <c>TagFilter.N.TagValues.N</c> for fuzzy search of ECS resources, you must set <c>TagFilter.N.TagKey</c> to an exact value. For example, to query ECS resources that have a tag composed of the <c>env</c> tag key and the <c>product</c> tag value, you must set <c>TagFilter.1.TagKey</c> to <c>env</c> and can set <c>TagFilter.1.TagValues.1</c> to <c>proc*</c> for prefix search, to <c>*proc*</c> for infix search, or to <c>proc</c> for exact search. Only one of the preceding search methods can be used for each tag key (<c>TagFilter.N.TagKey</c>). If multiple search methods are configured for a tag key, the first search method prevails.</description></item>
            /// <item><description>If you specify multiple tag keys, only the ECS resources that have all the specified tag keys added are returned.</description></item>
            /// <item><description>If you specify a tag key that corresponds to multiple tag values, all the ECS resources that have one or more of these tag key-value pairs added are returned.</description></item>
            /// </list>
            /// <remarks>
            /// <para>The <c>TagFilter.N</c> parameter pair (TagFilter.N.TagKey and TagFilter.N.TagValues.N) cannot be used together with the <c>Tag.N</c> parameter pair (Tag.N.Key and Tag.N.Value). Otherwise, an error message is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The values of tag N used for fuzzy search of ECS resources. The tag values must be 1 to 128 characters in length. Valid values of N: 1 to 5. For more information, see the description of <c>TagFilter.N.TagKey</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestTagFilter</para>
            /// </summary>
            [NameInMap("TagValues")]
            [Validation(Required=false)]
            public List<string> TagValues { get; set; }

        }

    }

}

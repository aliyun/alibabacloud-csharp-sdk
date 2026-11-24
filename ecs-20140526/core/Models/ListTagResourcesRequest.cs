// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The token for the next query.</para>
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
        /// <para>The ID of the ECS resource. Valid values of N: 1 to 50.</para>
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
        /// <item><description>disk: cloud disk</description></item>
        /// <item><description>snapshot: snapshot</description></item>
        /// <item><description>image: image</description></item>
        /// <item><description>securitygroup: security group</description></item>
        /// <item><description>volume: storage volume</description></item>
        /// <item><description>eni: Elastic Network Interface (ENI)</description></item>
        /// <item><description>ddh: dedicated host</description></item>
        /// <item><description>ddhcluster: dedicated host cluster</description></item>
        /// <item><description>keypair: SSH key pair</description></item>
        /// <item><description>launchtemplate: launch template</description></item>
        /// <item><description>reservedinstance: reserved instance</description></item>
        /// <item><description>snapshotpolicy: automatic snapshot policy</description></item>
        /// <item><description>elasticityassurance: elasticity assurance</description></item>
        /// <item><description>capacityreservation: capacity reservation</description></item>
        /// <item><description>command: Cloud Assistant command</description></item>
        /// <item><description>invocation: Cloud Assistant command execution or file delivery result</description></item>
        /// <item><description>activation: Cloud Assistant managed instance activation code</description></item>
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
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key used for exact match when querying ECS resources. The tag key must be 1 to 128 characters in length. Valid values of N: 1 to 20.</para>
            /// <para>Usage notes for the Tag.N parameter:</para>
            /// <list type="bullet">
            /// <item><description><para>Method 1: Used to exactly query ECS resources bound to specific tags. It consists of a key-value pair.</para>
            /// <list type="bullet">
            /// <item><description><para>If only Tag.N.Key is specified, all resources associated with the tag key are returned.</para>
            /// </description></item>
            /// <item><description><para>If only Tag.N.Value is specified, the InvalidParameter.TagValue error is returned.</para>
            /// </description></item>
            /// <item><description><para>If multiple tag key-value pairs are specified, only ECS resources that meet all the tag key-value pairs are returned.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Method 2: Used to query resources in non-default resource groups. The Key is fixed as acs:rm:rgId, and the corresponding Value is the resource group ID.</para>
            /// <list type="bullet">
            /// <item><description><para>If Key is set to acs:rm:rgId, Value can only be a non-default resource group ID. If the specified resource group ID is the default resource group, an error message is returned.</para>
            /// </description></item>
            /// <item><description><para>If Key is set to acs:rm:rgId, you cannot specify other tag key-value pairs. If you query resources corresponding to both resource groups and tags by using multiple Tag.N parameters at the same time, an error message is returned.</para>
            /// </description></item>
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
            /// <para>The tag value used for exact match when querying ECS resources. The tag value must be 1 to 128 characters in length. Valid values of N: 1 to 20.</para>
            /// <remarks>
            /// <para>When Key is set to acs:rm:rgId, this parameter can only be set to a resource group ID, and the resource group ID cannot be the default resource group.</para>
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
        /// <para>The tag filtering rules.</para>
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TagFilter")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTagFilter> TagFilter { get; set; }
        public class ListTagResourcesRequestTagFilter : TeaModel {
            /// <summary>
            /// <para>The tag key used for fuzzy match when querying ECS resources. The tag key must be 1 to 128 characters in length. Valid values of N: 1 to 5.</para>
            /// <para>TagFilter.N is used to fuzzy query ECS resources bound to specific tags. It consists of a key and one or more values. Fuzzy queries may have a delay of 2 seconds and only support scenarios where the number of resources after fuzzy filtering is less than or equal to 5,000.</para>
            /// <list type="bullet">
            /// <item><description><para>When you fuzzy query ECS resources by tag key (TagFilter.N.TagKey), the tag value (TagFilter.N.TagValues.N) must be empty. For example, to fuzzy search for ECS resources with the tag key environment, you can set TagFilter.1.TagKey to env* (prefix match), <em>env</em> (infix match), or env (exact match), and TagFilter.1.TagValues must be empty.</para>
            /// </description></item>
            /// <item><description><para>When you fuzzy query ECS resources by tag value (TagFilter.N.TagValues.N), the tag key (TagFilter.N.TagKey) must be set to an exact value. For example, to fuzzy search for ECS resources with the tag key env and the tag value product, you must set TagFilter.1.TagKey exactly to env, and you can set TagFilter.1.TagValues.1 to proc* (prefix match), <em>proc</em> (infix match), or proc (exact match). You can use only one search method under the same TagKey. If multiple different search methods are set, the first method prevails.</para>
            /// </description></item>
            /// <item><description><para>Tag keys have an intersection relationship. Only ECS resources that meet all the specified tag keys are returned.</para>
            /// </description></item>
            /// <item><description><para>Tag values under the same tag key have a union relationship. ECS resources that meet any of the specified tag values for the tag key are returned.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>You cannot use TagFilter.N and Tag.N at the same time. Otherwise, an error message is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value used for fuzzy match when querying ECS resources. The tag value must be 1 to 128 characters in length. Valid values of N: 1 to 5. For the specific metric description, see the description of the TagFilter.N.TagKey parameter.</para>
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

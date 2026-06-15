// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The pagination token to retrieve the next page of results.</para>
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
        /// <para>The ID of the region where the resource is located. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to view the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of an ECS resource. The value of N ranges from 1 to 50.</para>
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
        /// <item><description><para>instance: ECS instance</para>
        /// </description></item>
        /// <item><description><para>disk: disk</para>
        /// </description></item>
        /// <item><description><para>snapshot: snapshot</para>
        /// </description></item>
        /// <item><description><para>image: image</para>
        /// </description></item>
        /// <item><description><para>securitygroup: security group</para>
        /// </description></item>
        /// <item><description><para>volume: volume</para>
        /// </description></item>
        /// <item><description><para>eni: elastic network interface</para>
        /// </description></item>
        /// <item><description><para>ddh: dedicated host</para>
        /// </description></item>
        /// <item><description><para>ddhcluster: dedicated host cluster</para>
        /// </description></item>
        /// <item><description><para>keypair: SSH key pair</para>
        /// </description></item>
        /// <item><description><para>launchtemplate: launch template</para>
        /// </description></item>
        /// <item><description><para>reservedinstance: reserved instance</para>
        /// </description></item>
        /// <item><description><para>snapshotpolicy: snapshot policy</para>
        /// </description></item>
        /// <item><description><para>elasticityassurance: Elasticity Assurance</para>
        /// </description></item>
        /// <item><description><para>capacityreservation: capacity reservation</para>
        /// </description></item>
        /// <item><description><para>command: Cloud Assistant command</para>
        /// </description></item>
        /// <item><description><para>invocation: The result of a command execution or file delivery in Cloud Assistant</para>
        /// </description></item>
        /// <item><description><para>activation: Cloud Assistant managed instance activation code</para>
        /// </description></item>
        /// <item><description><para>managedinstance: Cloud Assistant managed instance</para>
        /// </description></item>
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
        /// <para>A list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key to use for an exact match. The tag key must be 1 to 128 characters in length. The value of N ranges from 1 to 20.</para>
            /// <para>Usage notes for the <c>Tag.N</c> parameter:</para>
            /// <list type="bullet">
            /// <item><description><para>Method 1: To find ECS resources that have specific tags.</para>
            /// <list type="bullet">
            /// <item><description><para>If you specify only <c>Tag.N.Key</c>, the operation returns all resources that have the specified tag key.</para>
            /// </description></item>
            /// <item><description><para>If you specify only <c>Tag.N.Value</c>, the operation returns an <c>InvalidParameter.TagValue</c> error.</para>
            /// </description></item>
            /// <item><description><para>If you specify multiple tag key-value pairs, the operation returns only the ECS resources that match all specified pairs.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Method 2: To query resources in a non-default resource group.</para>
            /// <list type="bullet">
            /// <item><description><para>If you set <c>Key</c> to <c>acs:rm:rgId</c>, you must set <c>Value</c> to the ID of a non-default resource group. If you specify the ID of the default resource group, the operation returns an error.</para>
            /// </description></item>
            /// <item><description><para>If you set <c>Key</c> to <c>acs:rm:rgId</c>, you cannot specify other tag key-value pairs. If you use multiple <c>Tag.N</c> parameters to query for resources by both resource group and tag, the operation returns an error.</para>
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
            /// <para>The tag value to use for an exact match. The tag value must be 1 to 128 characters in length. The value of N ranges from 1 to 20.</para>
            /// <remarks>
            /// <para>When <c>Key</c> is <c>acs:rm:rgId</c>, you must set this parameter to the ID of a non-default resource group.</para>
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
        /// <para>A list of tag filters.</para>
        /// <remarks>
        /// <para>This parameter is in invitation-only preview and is not yet available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TagFilter")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTagFilter> TagFilter { get; set; }
        public class ListTagResourcesRequestTagFilter : TeaModel {
            /// <summary>
            /// <para>The tag key to use for a fuzzy match. The tag key must be 1 to 128 characters in length. The value of N ranges from 1 to 5.</para>
            /// <para>Use the <c>TagFilter.N</c> parameter to perform a fuzzy match on tags to find matching ECS resources. Each filter consists of one key and one or more values. A fuzzy match may have a 2-second latency and is supported only for queries that return 5,000 or fewer resources after filtering.</para>
            /// <list type="bullet">
            /// <item><description><para>To perform a fuzzy match by tag key (<c>TagFilter.N.TagKey</c>), you must leave the tag values (<c>TagFilter.N.TagValues.N</c>) empty. For example, to search for ECS resources that have the tag key <c>environment</c>, you can set <c>TagFilter.1.TagKey</c> to <c>env*</c> (prefix match), <c>*env*</c> (substring match), or <c>env</c> (exact match), but you must leave <c>TagFilter.1.TagValues</c> empty.</para>
            /// </description></item>
            /// <item><description><para>To perform a fuzzy match by tag value (<c>TagFilter.N.TagValues.N</c>), you must set the tag key (<c>TagFilter.N.TagKey</c>) to an exact value. For example, to search for ECS resources with the tag key <c>env</c> and the tag value <c>product</c>, you must set <c>TagFilter.1.TagKey</c> to <c>env</c>. You can then set <c>TagFilter.1.TagValues.1</c> to <c>proc*</c> (prefix match), <c>*proc*</c> (substring match), or <c>proc</c> (exact match). For the same <c>TagKey</c>, you can use only one search pattern. If you specify multiple patterns, the system uses only the first pattern.</para>
            /// </description></item>
            /// <item><description><para>Tag keys are combined by using a logical AND. The operation returns only the ECS resources that match all specified tag keys.</para>
            /// </description></item>
            /// <item><description><para>Tag values for the same tag key are combined by using a logical OR. The operation returns the ECS resources that match any of the specified tag values for that tag key.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>You cannot specify both the <c>TagFilter.N</c> and <c>Tag.N</c> parameters in the same request.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag values to use for a fuzzy match. The tag value must be 1 to 128 characters in length. The value of N ranges from 1 to 5. For more information, see the description of the <c>TagFilter.N.TagKey</c> parameter.</para>
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

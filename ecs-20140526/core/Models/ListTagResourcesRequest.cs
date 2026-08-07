// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The token used to start the next query.</para>
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
        /// <para>The region ID of the resource. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ECS resource ID. Valid values of N: 1 to 50.</para>
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
        /// <item><description>instance: ECS instance.</description></item>
        /// <item><description>disk: cloud disk.</description></item>
        /// <item><description>snapshot: snapshot.</description></item>
        /// <item><description>image: image.</description></item>
        /// <item><description>securitygroup: security group.</description></item>
        /// <item><description>volume: storage volume.</description></item>
        /// <item><description>eni: Elastic Network Interface (ENI).</description></item>
        /// <item><description>ddh: dedicated host.</description></item>
        /// <item><description>ddhcluster: dedicated host cluster.</description></item>
        /// <item><description>keypair: SSH key pair.</description></item>
        /// <item><description>launchtemplate: launch template.</description></item>
        /// <item><description>reservedinstance: reserved instance.</description></item>
        /// <item><description>snapshotpolicy: automatic snapshot policy.</description></item>
        /// <item><description>elasticityassurance: elasticity assurance.</description></item>
        /// <item><description>capacityreservation: capacity reservation.</description></item>
        /// <item><description>command: Cloud Assistant command.</description></item>
        /// <item><description>invocation: Cloud Assistant command execution or file sending result.</description></item>
        /// <item><description>activation: Cloud Assistant managed instance activation code.</description></item>
        /// <item><description>managedinstance: Cloud Assistant managed instance.</description></item>
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
            /// <para>The tag key used to perform an exact search for ECS resources. The tag key must be 1 to 128 characters in length. Valid values of N: 1 to 20.</para>
            /// <para>Usage notes of the <c>Tag.N</c> parameter:</para>
            /// <list type="bullet">
            /// <item><description><para>Method 1: Used to perform an exact search for ECS resources that have the specified tags bound. Each tag is a key-value pair.</para>
            /// <list type="bullet">
            /// <item><description><para>If you specify only <c>Tag.N.Key</c>, all resources associated with the tag key are returned.</para>
            /// </description></item>
            /// <item><description><para>If you specify only <c>Tag.N.Value</c>, the <c>InvalidParameter.TagValue</c> error is returned.</para>
            /// </description></item>
            /// <item><description><para>If you specify multiple tag key-value pairs at the same time, only ECS resources that match all the specified tag key-value pairs are returned.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Method 2: Used to query resource information in non-default resource groups. Set <c>Key</c> to <c>acs:rm:rgId</c> and set the corresponding <c>Value</c> to the resource group ID.</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>Key</c> is set to <c>acs:rm:rgId</c>, <c>Value</c> can only be set to a non-default resource group ID. If the specified resource group ID is the default resource group, an error message is returned.</para>
            /// </description></item>
            /// <item><description><para>If <c>Key</c> is set to <c>acs:rm:rgId</c>, you cannot specify other tag key-value pairs. If you use multiple <c>Tag.N</c> parameters to query resources by resource group and tags at the same time, an error message is returned.</para>
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
            /// <para>The tag value used to perform an exact search for ECS resources. The tag value must be 1 to 128 characters in length. Valid values of N: 1 to 20.</para>
            /// <remarks>
            /// <para>If <c>Key=acs:rm:rgId</c>, this parameter can only be set to a resource group ID, and the resource group ID cannot be the default resource group.</para>
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
        /// <para>The tag filter rules.</para>
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TagFilter")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTagFilter> TagFilter { get; set; }
        public class ListTagResourcesRequestTagFilter : TeaModel {
            /// <summary>
            /// <para>The tag key used to perform a fuzzy search for ECS resources. The tag key must be 1 to 128 characters in length. Valid values of N: 1 to 5.</para>
            /// <para><c>TagFilter.N</c> is used to perform a fuzzy search for ECS resources that have the specified tags bound. It consists of a key and one or more values. A fuzzy search may have a latency of up to 2 seconds and supports only scenarios where the number of resources after fuzzy filtering is less than or equal to 5,000.</para>
            /// <list type="bullet">
            /// <item><description><para>When you perform a fuzzy search for ECS resources by tag key (<c>TagFilter.N.TagKey</c>), the tag value (<c>TagFilter.N.TagValues.N</c>) must be empty. For example, to perform a fuzzy search for ECS resources whose tag key is <c>environment</c>, you can set <c>TagFilter.1.TagKey</c> to <c>env*</c> (prefix match), <c>*env*</c> (infix match), or <c>env</c> (exact match), and <c>TagFilter.1.TagValues</c> must be empty.</para>
            /// </description></item>
            /// <item><description><para>When you perform a fuzzy search for ECS resources by tag value (<c>TagFilter.N.TagValues.N</c>), the tag key (<c>TagFilter.N.TagKey</c>) must be set to an exact value. For example, to perform a fuzzy search for ECS resources whose tag key is <c>env</c> and tag value is <c>product</c>, <c>TagFilter.1.TagKey</c> must be set to the exact value <c>env</c>, and <c>TagFilter.1.TagValues.1</c> can be set to <c>proc*</c> (prefix match), <c>*proc*</c> (infix match), or <c>proc</c> (exact match). Only one search method can be used for the same <c>TagKey</c>. If multiple search methods are specified, the first method takes precedence.</para>
            /// </description></item>
            /// <item><description><para>Tag keys have an AND relationship. Only ECS resources that match all specified tag keys are returned.</para>
            /// </description></item>
            /// <item><description><para>Tag values under the same tag key have an OR relationship. ECS resources that match any of the tag values specified for a tag key are returned.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>The <c>TagFilter.N</c> and <c>Tag.N</c> parameters cannot be used at the same time. Otherwise, an error message is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value used to perform a fuzzy search for ECS resources. The tag value must be 1 to 128 characters in length. Valid values of N: 1 to 5. For the metric description, see the <c>TagFilter.N.TagKey</c> parameter description.</para>
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

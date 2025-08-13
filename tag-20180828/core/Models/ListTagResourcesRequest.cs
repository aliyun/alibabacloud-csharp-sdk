// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The type of the tag. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Custom</description></item>
        /// <item><description>System</description></item>
        /// <item><description>All</description></item>
        /// </list>
        /// <para>Default value: All.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The token that is used to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
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
        /// <para>The number of entries to return on each page.</para>
        /// <para>Maximum value: 1000. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <list type="bullet">
        /// <item><description>If the resources belong to a service that is centrally deployed, set the value to the region ID of the resources by referring to <a href="https://help.aliyun.com/document_detail/2579691.html">Regions supported by tag-related operations on resources of centrally deployed Alibaba Cloud services</a>.</description></item>
        /// <item><description>If the resources belong to a service that is not centrally deployed, set the value to the region ID of the resources.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of a resource.</para>
        /// <para>Valid values of N: 1 to 50.</para>
        /// <para>ARN format: <c>arn:acs:${ProductCode}:${Region}:${Account}:${ResourceType}/${ResourceId}</c> Fields:</para>
        /// <list type="bullet">
        /// <item><description><c>ProductCode</c>: the service code. You can set this field to a value obtained from the response of the <a href="https://help.aliyun.com/document_detail/2330915.html">ListSupportResourceTypes</a> operation.</description></item>
        /// <item><description><c>Region</c>: the region ID of the resource. You can set this field to an asterisk (\*) to indicate the current region.</description></item>
        /// <item><description><c>Account</c>: the ID of the Alibaba Cloud account to which the resource belongs. You can set this field to an asterisk (\*) to indicate the current Alibaba Cloud account.</description></item>
        /// <item><description><c>ResourceType</c>: the resource type. You can set this field to a value obtained from the response of the <a href="https://help.aliyun.com/document_detail/2330915.html">ListSupportResourceTypes</a> operation.</description></item>
        /// <item><description><c>ResourceId</c>: the ID of the resource.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can set <c>ProductCode</c> and <c>ResourceType</c> in ResourceARN to values defined in Resource Group, ActionTrail, or Resource Center.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>arn:acs:ecs:cn-hangzhou:123456789****:instance/i-bp15hr53jws84akg****</para>
        /// </summary>
        [NameInMap("ResourceARN")]
        [Validation(Required=false)]
        public List<string> ResourceARN { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The key-value pairs of tags. You can specify 1 to 10 key-value pairs.</para>
        /// <para>If you specify multiple tags, the system queries the resources to which all these tags are added.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>A tag key must be 1 to 128 characters in length.</description></item>
        /// <item><description>A tag value must be 1 to 128 characters in length.</description></item>
        /// <item><description>Tag keys and tag values are case-sensitive.</description></item>
        /// <item><description>Each tag key on a resource can have only one tag value. If you create a tag that has the same key as an existing tag, the value of the existing tag is overwritten.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;k1&quot;:&quot;v1&quot;,&quot;k2&quot;:&quot;v2&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}

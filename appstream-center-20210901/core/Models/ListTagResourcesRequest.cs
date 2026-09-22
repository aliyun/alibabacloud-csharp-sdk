// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The paged query token. You do not need to specify this parameter for the first request. If the previous invoke returned a non-empty NextToken value, pass it in as-is to retrieve subsequent paging results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAYRHtOLVQzCYj17y+OP7LZRrUJaF4rnBGQkWwMiVHlLZBB1w3Us37CVvhvyM0TXavA==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of resource IDs. A maximum of 50 resource IDs are supported.</para>
        /// <para>If the resource type is delivery group, specify the delivery group ID (prefixed with <c>aig-</c>). You can call the ListAppInstanceGroup operation to obtain the delivery group ID.</para>
        /// <remarks>
        /// <para>Specify at least one of ResourceId.N and Tag.N. If only ResourceId.N is specified, all tags bound to the specified resources are returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>APPINSTANCEGROUP: delivery group.</description></item>
        /// </list>
        /// <para>This parameter is case-insensitive. Only this value is supported. If you specify other values, the error code <c>InvalidResourceType.Invalid</c> is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APPINSTANCEGROUP</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tag conditions. A maximum of 20 tag conditions are supported.</para>
        /// <remarks>
        /// <para>Specify at least one of ResourceId.N and Tag.N. Multiple tags have an AND relationship. Only resources that have all specified tags bound are returned.</para>
        /// </remarks>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. This parameter is required. The tag key is case-sensitive and must be 1 to 128 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Resolution</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value is case-sensitive and can be up to 256 characters in length. If this parameter is not specified, the value of the tag key is not restricted, which means any tag value under the key is matched.</para>
            /// 
            /// <b>Example:</b>
            /// <para>720p</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

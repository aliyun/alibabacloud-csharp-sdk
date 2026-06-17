// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>A token to retrieve the next page of results. You do not need to specify this parameter for the first request. If the first request does not return all results, the response returns a token. You can use this token in the next request to continue the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>212db86sca4384811e0b5e8707*******</para>
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
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to view the available region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of a cluster. You can specify multiple cluster IDs to query the tags of multiple clusters.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You must specify either the <c>ResourceId.N</c> parameter or the <c>Tag.N.Key</c> parameter.</para>
        /// </description></item>
        /// <item><description><para>If you specify the <c>ResourceId.N</c> parameter, you can add up to 50 cluster IDs.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
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
        /// <para>The resource type. Set the value to <b>cluster</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster</para>
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
            /// <para>The key of a tag. You can specify multiple tags to query for resources that have all of the specified tags.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>You must specify either the <c>ResourceId.N</c> parameter or the <c>Tag.N.Key</c> parameter.</para>
            /// </description></item>
            /// <item><description><para>If you specify the <c>Tag.N.Key</c> parameter, you can add up to 20 tag pairs.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>type</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value that corresponds to the tag key. An empty string is allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListSupabaseProjectTagsRequest : TeaModel {
        /// <summary>
        /// <para>The token for the next page of results. This token is returned in the <c>NextToken</c> parameter of a previous request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You must specify at least one of the <c>ResourceId</c> and <c>Tag</c> parameters.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Set the value to <c>instance</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>A list of tags.</para>
        /// <remarks>
        /// <para>You must specify at least one of the <c>ResourceId</c> and <c>Tag</c> parameters.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListSupabaseProjectTagsRequestTag> Tag { get; set; }
        public class ListSupabaseProjectTagsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The key can be 1 to 64 characters in length.</para>
            /// <para>The <c>Tag.N</c> parameter specifies a key-value pair to filter Supabase instances.</para>
            /// <para>N is an integer from 1 to 20.</para>
            /// <list type="bullet">
            /// <item><description><para>If you specify only <c>Tag.N.Key</c>, the operation returns all instances that have the specified tag key.</para>
            /// </description></item>
            /// <item><description><para>If you specify only <c>Tag.N.Value</c>, an <c>InvalidParameter.TagValue</c> error is returned.</para>
            /// </description></item>
            /// <item><description><para>If you specify multiple tag key-value pairs, the operation returns only Supabase instances that match all the specified pairs.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>test-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The value can be 1 to 128 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListSupabaseProjectTagsRequest : TeaModel {
        /// <summary>
        /// <para>The token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Region ID</para>
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
        /// <para>You must specify at least one of ResourceId and Tag.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Set the value to instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// <remarks>
        /// <para>You must specify at least one of ResourceId and Tag.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListSupabaseProjectTagsRequestTag> Tag { get; set; }
        public class ListSupabaseProjectTagsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key must be 1 to 64 characters in length.</para>
            /// <para>Tag.N is used to exactly match Supabase instances that have the specified tags bound. A tag is a key-value pair.</para>
            /// <para>Valid values of N: 1 to 20.</para>
            /// <list type="bullet">
            /// <item><description>If you specify only Tag.N.Key, all instances associated with the specified tag key are returned.</description></item>
            /// <item><description>If you specify only Tag.N.Value, the error message <c>InvalidParameter.TagValue</c> is returned.</description></item>
            /// <item><description>If you specify multiple tag key-value pairs at the same time, only instances that match all the specified tag key-value pairs are returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>test-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value must be 1 to 128 characters in length.</para>
            /// <para>Valid values of N: 1 to 20.</para>
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

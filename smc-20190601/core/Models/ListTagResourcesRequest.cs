// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
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

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The IDs of SMC resources. SMC resources include migration sources and migration jobs. You can specify a maximum of 50 SMC resource IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp1e2fsl57knvuug****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The type of the SMC resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>sourceserver: migration source.</description></item>
        /// <item><description>replicationjob: migration job.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sourceserver</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags that are attached to SMC resources.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N. The tag key must be 1 to 64 characters in length. Valid values of N: 1 to 20.</para>
            /// <para>Tag.N is used for exact match of SMC resources to which the tag is attached. Tag N consists of a key-value pair.</para>
            /// <list type="bullet">
            /// <item><description>Tag keys and values are case-sensitive.</description></item>
            /// <item><description>If you set only the Tag.N.Key parameter, all resources to which the specified tags are attached are returned.</description></item>
            /// <item><description>If you set only the Tag.N.Value parameter, the error message InvalidParameter.TagValue is returned.</description></item>
            /// <item><description>If you specify multiple tag key-value pairs at a time, only SMC resources that match all tag key-value pairs are returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N. The value must be 1 to 64 characters in length. Valid values of N: 1 to 20.</para>
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

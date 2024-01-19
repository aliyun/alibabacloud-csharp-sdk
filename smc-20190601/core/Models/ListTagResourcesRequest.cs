// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The IDs of SMC resources. SMC resources include migration sources and migration jobs. You can specify a maximum of 50 SMC resource IDs.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The type of the SMC resource. Valid values:
        /// 
        /// *   sourceserver: migration source.
        /// *   replicationjob: migration job.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tags that are attached to SMC resources.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N. The tag key must be 1 to 64 characters in length. Valid values of N: 1 to 20.
            /// 
            /// Tag.N is used for exact match of SMC resources to which the tag is attached. Tag N consists of a key-value pair.
            /// 
            /// *   Tag keys and values are case-sensitive.
            /// *   If you set only the Tag.N.Key parameter, all resources to which the specified tags are attached are returned.
            /// *   If you set only the Tag.N.Value parameter, the error message InvalidParameter.TagValue is returned.
            /// *   If you specify multiple tag key-value pairs at a time, only SMC resources that match all tag key-value pairs are returned.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N. The value must be 1 to 64 characters in length. Valid values of N: 1 to 20.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

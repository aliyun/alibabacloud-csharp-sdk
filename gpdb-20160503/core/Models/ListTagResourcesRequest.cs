// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// The token used to perform the next query.
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
        /// The region ID of the instance. You can call the [DescribeRegions](~~86912~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of instance N. Valid values of N: 1 to 50.
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
        /// The storage mode of the instance. Valid values:
        /// 
        /// *   `instance`: reserved storage mode
        /// *   `ALIYUN::GPDB::INSTANCE`: elastic storage mode
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The queried tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N. The key must be 1 to 128 characters in length.
            /// 
            /// You can use `Tag.N` to query instances that have specific tags added. Tag.N consists of Tag.N.Key and Tag.N.Value.
            /// 
            /// Valid values of N: 1 to 20.
            /// 
            /// *   If you specify only `Tag.N.Key`, all instances that have the tag key added are returned.
            /// *   If you specify only `Tag.N.Value`, the `InvalidParameter.TagValue` error is returned.
            /// *   If you specify multiple tag key-value pairs at a time, the instances that match all the specified tag key-value pairs are returned.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N. The value must be 1 to 128 characters in length.
            /// 
            /// Valid values of N: 1 to 20.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

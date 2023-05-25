// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RemoveTagsRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The key of tag N of the resource. Valid values of N: 1 to 20. It cannot be an empty string. The tag key can be up to 64 characters in length and cannot contain http:// or https://. It cannot start with acs: or aliyun.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The key of tag N of the resource.
        /// 
        /// >  We recommend that you use the Tag.N.Key parameter to ensure future compatibility.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The value of tag N of the resource. Valid values of N: 1 to 20. It can be an empty string. The tag value can be up to 128 characters in length and cannot contain http:// or https://. It cannot start with acs: or aliyun.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<RemoveTagsRequestTag> Tag { get; set; }
        public class RemoveTagsRequestTag : TeaModel {
            /// <summary>
            /// The value of tag N of the resource.
            /// 
            /// >  We recommend that you use the Tag.N.Value parameter to ensure future compatibility.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N of the resource. Valid values of N: 1 to 20. It can be an empty string. The tag value can be up to 128 characters in length and cannot contain http:// or https://. It cannot start with acs: or aliyun.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

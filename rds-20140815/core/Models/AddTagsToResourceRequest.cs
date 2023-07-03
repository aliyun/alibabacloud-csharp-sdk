// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class AddTagsToResourceRequest : TeaModel {
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AddTagsToResourceRequestTag> Tag { get; set; }
        public class AddTagsToResourceRequestTag : TeaModel {
            /// <summary>
            /// The TagKey of the first tag that you want to bind. Each tag consists of a TagKey and a TagValue. You can specify up to five tags in a single request. The TagKey is required, and the TagValue is optional.
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The TagValue of the first tag that you want to bind. Each tag consists of a TagKey and a TagValue. You can specify up to five tags in a single request. The TagKey is required, and the TagValue is optional.
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// >  You can enter up to 30 instance IDs in a single request. If you enter more than one instance ID, you must separate the instance IDs with commas (,).
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The logon name of the RAM user.
        /// </summary>
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~26243~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The tags that you want to bind. Each tag consists of a TagKey and a TagValue. You can specify up to five tags in a single request. Format: {"key1":"value1","key2":"value2"...}.
        /// 
        /// >  The TagKey is required, and the TagValue is optional.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// The ID of the proxy pattern.
        /// </summary>
        [NameInMap("proxyId")]
        [Validation(Required=false)]
        public string ProxyId { get; set; }

    }

}

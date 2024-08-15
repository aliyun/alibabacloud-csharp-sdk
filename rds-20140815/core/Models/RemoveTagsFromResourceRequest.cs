// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RemoveTagsFromResourceRequest : TeaModel {
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<RemoveTagsFromResourceRequestTag> Tag { get; set; }
        public class RemoveTagsFromResourceRequestTag : TeaModel {
            /// <summary>
            /// The TagKey of the first tag that you want to unbind. Each tag consists of a TagKey and a TagValue. You can specify up to five tags in a single request. You cannot specify an empty string as the tag key. You can specify an empty string as the tag value.
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The TagValue of the first tag that you want to unbind. Each tag consists of a TagKey and a TagValue. You can specify up to five tags in a single request. You cannot specify an empty string as the tag key. You can specify an empty string as the tag value.
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID. You can call the DescribeRegions operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID. You can call the ListResourceGroups operation to query the resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// A set of a TagKey and a TagValue that you use to unbind the tag. Format: {"key1":"value1"}.
        /// 
        /// >  You cannot specify an empty string for TagKey. You can specify an empty string for TagValue.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// The ID of the proxy mode.
        /// </summary>
        [NameInMap("proxyId")]
        [Validation(Required=false)]
        public string ProxyId { get; set; }

    }

}

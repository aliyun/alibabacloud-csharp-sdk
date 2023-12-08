// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class TagResourcesRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the resources.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of a resource.
        /// </summary>
        [NameInMap("ResourceARN")]
        [Validation(Required=false)]
        public List<string> ResourceARN { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The key-value pairs of tags. You can specify 1 to 10 key-value pairs.
        /// 
        /// If you specify multiple tags, the system adds all the tags to the specified resources.
        /// 
        /// Limits:
        /// 
        /// *   A tag key must be 1 to 128 characters in length.
        /// *   A tag value must be 1 to 128 characters in length.
        /// *   Tag keys and tag values are case-sensitive.
        /// *   Each tag key on a resource can have only one tag value. If you create a tag that has the same key as an existing tag, the value of the existing tag is overwritten.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}

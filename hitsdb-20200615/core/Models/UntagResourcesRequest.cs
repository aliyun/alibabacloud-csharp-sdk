// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to remove all tags from the instance. Valid values:
        /// 
        /// *   **true**: Remove all tags from the instances.
        /// *   **false**: Do not remove all tags from the instances.
        /// 
        /// > 
        /// 
        /// *   The default value of this parameter is false.
        /// 
        /// *   If you specify the TagKey parameter together with this parameter, this parameter does not take effect.
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The IDs of instances.
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
        /// The resource type. Set the value to **INSTANCE**.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The list of keys of the tags that you want to remove.
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}

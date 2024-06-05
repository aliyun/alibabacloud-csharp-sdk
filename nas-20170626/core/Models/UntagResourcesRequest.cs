// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to remove all tags from the file system.
        /// 
        /// This parameter is valid only if the TagKey.N parameter is not specified.
        /// 
        /// Valid values:
        /// 
        /// *   true: All tags are removed from the file system. If the file system does not have tags, a success message is returned.
        /// *   false (default): No tags are removed from the file system and a success message is returned.
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// The resource IDs. Valid values of N: 1 to 50.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The resource type.
        /// 
        /// Set the value to filesystem.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tag keys of the resources. Valid values of N: 1 to 20.
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}

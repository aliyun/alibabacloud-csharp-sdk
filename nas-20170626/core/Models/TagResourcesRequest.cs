// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// The resource IDs. Valid values of N: 1 to 50.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The resource type. Set the value to filesystem.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The details about the tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N to add to the resource.
            /// 
            /// Limits:
            /// 
            /// *   The tag key cannot be left empty.
            /// *   Valid values of N: 1 to 20.
            /// *   The tag key must be 1 to 128 characters in length.
            /// *   The tag key cannot start with `aliyun` or `acs:`.
            /// *   The tag key cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the resource.
            /// 
            /// Limits:
            /// 
            /// *   Valid values of N: 1 to 20.
            /// *   The tag value must be 1 to 128 characters in length.
            /// *   The tag value cannot start with `aliyun` or `acs:`.
            /// *   The tag value cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

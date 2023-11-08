// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// The region ID of the Service Mesh (ASM) instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of the ASM instances.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The resource type. Set the value to `servicemesh`.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The tag keys.
            /// 
            /// The following limits apply:
            /// 
            /// *   The key of tag N cannot be an empty string.
            /// *   Valid values of N: 1 to 20.
            /// *   The tag key can be up to 128 characters in length.
            /// *   The tag key cannot start with `aliyun` or `acs:`.
            /// *   The tag key cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag values.
            /// 
            /// The following limits apply:
            /// 
            /// *   The value of tag N cannot be an empty string.
            /// *   Valid values of N: 1 to 20.
            /// *   The tag value can be up to 128 characters in length.
            /// *   The tag value cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

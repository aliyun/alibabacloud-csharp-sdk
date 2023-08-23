// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// The ID of the ApsaraMQ for RocketMQ instance that contains the resource to which you want to attach tags.
        /// 
        /// > This parameter is required when you attach tags to a topic or a group.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The resource IDs.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The type of the resource to which you want to attach tags. Valid values:
        /// 
        /// *   **INSTANCE**
        /// *   **TOPIC**
        /// *   **GROUP**
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tags that you want to attach to the resource.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The tag key. If you configure this parameter, you must also configure the **Value** parameter.****
            /// *   The value of this parameter cannot be an empty string.
            /// *   A tag key must be 1 to 128 characters in length and cannot contain `http://` or `https://`. A tag key cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag that you want to attach to the resource. If you configure this parameter, you must also configure the **Key** parameter.****
            /// *   The value of this parameter can be an empty string.
            /// *   A tag value must be 1 to 128 characters in length and cannot contain `http://` or `https://`. A tag value cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

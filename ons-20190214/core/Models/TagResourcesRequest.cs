// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// The ID of the Message Queue for Apache RocketMQ instance which contains the resource to which you want to attach tags.
        /// 
        /// > : This parameter is required when you attach tags to a topic or a group.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The list of resource IDs.
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
        /// The list of tags that are attached to the resources.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag that you want to attach to the specified resource. If you configure this parameter, you must also configure the **Tag.N.Key** parameter.****
            /// 
            /// *   The value of N can be an integer value from 1 to 20.
            /// *   The value of this parameter cannot be an empty string.
            /// *   The tag key can be up to 128 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag that you want to attach to the specified resource. If you configure this parameter, you must also configure the **Tag.N.Key** parameter.****
            /// 
            /// *   The value of N can be an integer value from 1 to 20.
            /// *   The value of this parameter can be an empty string.
            /// *   The tag key can be up to 128 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

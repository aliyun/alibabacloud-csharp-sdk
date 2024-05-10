// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// The resource IDs. You can specify only one resource and add tags to the resource.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The type of the resource. Set the value to project.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tags that you want to add to the resource. Up to 20 tags are supported at a time. Each tag is a key-value pair.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTags> Tags { get; set; }
        public class TagResourcesRequestTags : TeaModel {
            /// <summary>
            /// The key of the tag. The key must meet the following requirements:
            /// 
            /// *   The key must be `1 to 128` characters in length.
            /// *   The key cannot contain `"http://"` or `"https://"`.
            /// *   The key cannot start with `"acs:"` or `"aliyun"`.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag. The value must meet the following requirements:
            /// 
            /// *   The value must be `1 to 128` characters in length.
            /// *   The value cannot contain `"http://"` or `"https://"`.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

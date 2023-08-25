// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// The list of resource IDs.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The resource type. Set the value to **ANYCASTEIPADDRESS**.
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
            /// The key of tag N to add to the resource. You must enter at least one tag key and at most 20 tag keys. The tag key cannot be an empty string.
            /// 
            /// The key cannot exceed 64 characters in length, and can contain digits, periods (.), underscores (\_), and hyphens (-). The key must start with a letter but cannot start with `aliyun` or `acs:`. The key cannot contain `http://` or `https://`.
            /// 
            /// >  When you call this operation, you must specify **Tag.N.Key**.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the resource. You must enter at least one tag value and at most 20 tag values. The tag value can be an empty string.
            /// 
            /// The tag value cannot exceed 128 characters in length, and can contain digits, periods (.), underscores (\_), and hyphens (-). It must start with a letter but cannot start with `aliyun` or `acs:`. It cannot contain `http://` or `https://`.
            /// 
            /// >  When you call this operation, you must specify **Tag.N.Value**.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

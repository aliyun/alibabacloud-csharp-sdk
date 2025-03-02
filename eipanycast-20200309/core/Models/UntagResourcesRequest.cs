// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// The resource ID. You can specify up to 20 resource IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The resource type. Set the value to **ANYCASTEIPADDRESS**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The key of the tag that you want to remove. You can specify at most 20 tag keys. The tag key cannot be an empty string.
        /// 
        /// A tag key can be up to 128 characters in length. It cannot start with aliyun or acs:, and cannot contain `http://` or `https://`.
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}

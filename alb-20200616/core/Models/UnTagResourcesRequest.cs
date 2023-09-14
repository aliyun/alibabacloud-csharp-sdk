// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UnTagResourcesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to remove all tags from the specified resource. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// The IDs of the resources from which you want to remove tags.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The type of the resource. Valid values:
        /// 
        /// *   **acl**: an access control list (ACL)
        /// *   **loadbalancer**: an Application Load Balancer (ALB) instance
        /// *   **securitypolicy**: a security policy
        /// *   **servergroup**: a server group
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tags that you want to remove.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<UnTagResourcesRequestTag> Tag { get; set; }
        public class UnTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag that you want to remove. The key can be up to 128 characters in length and cannot start with `acs:` or `aliyun`. The key cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag that you want to remove. The value can be up to 128 characters in length and cannot start with `acs:` or `aliyun`. The value cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The keys of the tags that you want to remove.
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}

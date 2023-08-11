// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// The ID of resource N.
        /// 
        /// Valid values of N: 1 to 50. If ResourceType is set to user, the resource ID is the ID of the RAM user.
        /// 
        /// > You must specify only one of the following parameters: ResourceId and ResourcePrincipalName.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The name of resource N.
        /// 
        /// Valid values of N: 1 to 50. If ResourceType is set to user, the resource name is the name of the RAM user.
        /// 
        /// > You must specify only one of the following parameters: ResourceId and ResourcePrincipalName.
        /// </summary>
        [NameInMap("ResourcePrincipalName")]
        [Validation(Required=false)]
        public List<string> ResourcePrincipalName { get; set; }

        /// <summary>
        /// The type of the resource. Valid value:
        /// 
        /// *   user: a RAM user
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tag value.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N.
            /// 
            /// Valid values of N: 1 to 20. You cannot specify empty strings as tag keys. The tag key can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag key cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N.
            /// 
            /// Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be a up to128 characters in length and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

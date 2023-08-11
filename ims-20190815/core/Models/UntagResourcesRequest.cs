// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to remove all tags from the resource. Valid values:
        /// 
        /// *   true: remove all tags from the resources.
        /// *   false (default): does not remove all tags from the resources.
        /// 
        /// > This parameter takes effect only when TagKey.N is not set in the request.
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// The IDs of resources.
        /// 
        /// Valid values of N: 1 to 50. If the ResourceType parameter is set to user, the resource ID is the ID of the RAM user.
        /// 
        /// > You must specify only one of the following parameters: ResourceId and ResourcePrincipalName.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The names of resources.
        /// 
        /// Valid values of N: 1 to 50. If the ResourceType parameter is set to user, the resource name is the name of the RAM user.
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
        /// The tag keys of resources.
        /// 
        /// Valid values of N: 1 to 20. N must be consecutive.
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}

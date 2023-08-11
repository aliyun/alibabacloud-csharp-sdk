// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// The token that is used to initiate the next request if the response of the current request is truncated. You can use the token to initiate another request and obtain the remaining records.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The number of entries per page. If a response is truncated because it reaches the value of PageSize, the value of IsTruncated will be true. Valid values: 1 to 100. Default value: 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// 
        /// Valid values of N: 1 to 20. N must be consecutive.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N.
            /// 
            /// Valid values of N: 1 to 20. N must be consecutive.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N.
            /// 
            /// Valid values of N: 1 to 20. N must be consecutive.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

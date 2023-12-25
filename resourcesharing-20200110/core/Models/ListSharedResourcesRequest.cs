// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListSharedResourcesRequest : TeaModel {
        /// <summary>
        /// The maximum number of entries to return for a single request.
        /// 
        /// Valid values: 1 to 100. Default value: 20.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The `token` that is used to initiate the next request. If the response of the current request is truncated, you can use the token to initiate another request and obtain the remaining records.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of a shared resource.
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// The owner of the resource shares. Valid values:
        /// 
        /// *   Self: your account. If you set the value to Self, the resources you share with other accounts are queried.
        /// *   OtherAccounts: another account. If you set the value to OtherAccounts, the resources other accounts share with you are queried.
        /// </summary>
        [NameInMap("ResourceOwner")]
        [Validation(Required=false)]
        public string ResourceOwner { get; set; }

        /// <summary>
        /// The ID of a resource share.
        /// </summary>
        [NameInMap("ResourceShareIds")]
        [Validation(Required=false)]
        public List<string> ResourceShareIds { get; set; }

        /// <summary>
        /// The type of the shared resources.
        /// 
        /// For more information about the types of resources that can be shared, see [Services that work with Resource Sharing](~~450526~~).
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The ID of the principal or resource owner.
        /// 
        /// *   If the value of `ResourceOwner` is `Self`, set this parameter to the ID of a principal.
        /// *   If the value of `ResourceOwner` is `OtherAccounts`, set this parameter to the ID of a resource owner.
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

    }

}

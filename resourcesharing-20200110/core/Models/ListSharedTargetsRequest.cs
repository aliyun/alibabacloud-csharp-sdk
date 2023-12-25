// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListSharedTargetsRequest : TeaModel {
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
        /// The ID of the shared resource.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The owner of the resource share.
        /// 
        /// *   Self: your account. If you set the value to Self, the principals that are associated with your resource shares are queried.
        /// *   OtherAccounts: another account. If you set the value to OtherAccounts, the resource shares with which your account is associated and the owners of the resource shares are queried.
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
        /// The ID of a principal.
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<string> Targets { get; set; }

    }

}

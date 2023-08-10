// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListResourceSharesRequest : TeaModel {
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
        /// The name of the permission. For more information, see [Permission library](~~465474~~).
        /// </summary>
        [NameInMap("PermissionName")]
        [Validation(Required=false)]
        public string PermissionName { get; set; }

        /// <summary>
        /// The owner of the resource shares. Valid values:
        /// 
        /// *   Self: the current account
        /// *   OtherAccounts: an account other than the current account
        /// </summary>
        [NameInMap("ResourceOwner")]
        [Validation(Required=false)]
        public string ResourceOwner { get; set; }

        [NameInMap("ResourceShareIds")]
        [Validation(Required=false)]
        public List<string> ResourceShareIds { get; set; }

        /// <summary>
        /// The name of the resource share.
        /// </summary>
        [NameInMap("ResourceShareName")]
        [Validation(Required=false)]
        public string ResourceShareName { get; set; }

        /// <summary>
        /// The status of the resource share. Valid values:
        /// 
        /// *   Active: The resource share is enabled.
        /// *   Pending: The resource share is associated with one or more resource sharing invitations that are waiting for confirmation.
        /// *   Deleting: The resource share is being deleted.
        /// *   Deleted: The resource share is deleted.
        /// 
        /// >  The system deletes the records of resource shares in the Deleted state within 48 hours to 96 hours after you delete the resource shares.
        /// </summary>
        [NameInMap("ResourceShareStatus")]
        [Validation(Required=false)]
        public string ResourceShareStatus { get; set; }

    }

}

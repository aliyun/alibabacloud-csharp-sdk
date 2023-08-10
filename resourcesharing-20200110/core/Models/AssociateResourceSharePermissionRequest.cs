// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class AssociateResourceSharePermissionRequest : TeaModel {
        /// <summary>
        /// The name of the permission.
        /// </summary>
        [NameInMap("PermissionName")]
        [Validation(Required=false)]
        public string PermissionName { get; set; }

        /// <summary>
        /// Specifies whether to use the specified permission to replace an existing permission. Valid values:
        /// 
        /// *   false: does not use the specified permission to replace an existing permission. This is the default value. If you set the value to false for a resource share that does not have associated permissions, the system associates the specified permission with the resource share. In a resource share, one resource type can have only one permission. If you set the value to false for a resource share that already has a permission for the resource type indicated by the specified permission, the system reports an error. This prevents you from replacing the existing permission by mistake.
        /// *   true: uses the specified permission to replace an existing permission of the same resource type.
        /// </summary>
        [NameInMap("Replace")]
        [Validation(Required=false)]
        public bool? Replace { get; set; }

        /// <summary>
        /// The ID of the resource share.
        /// </summary>
        [NameInMap("ResourceShareId")]
        [Validation(Required=false)]
        public string ResourceShareId { get; set; }

    }

}

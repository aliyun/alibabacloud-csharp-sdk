// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class DisassociateResourceSharePermissionRequest : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("PermissionName")]
        [Validation(Required=false)]
        public string PermissionName { get; set; }

        /// <summary>
        /// The name of the permission. For more information, see [Permission library](~~465474~~).
        /// </summary>
        [NameInMap("ResourceShareId")]
        [Validation(Required=false)]
        public string ResourceShareId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class GetPermissionRequest : TeaModel {
        /// <summary>
        /// The name of the permission.
        /// </summary>
        [NameInMap("PermissionName")]
        [Validation(Required=false)]
        public string PermissionName { get; set; }

        /// <summary>
        /// The version of the permission.
        /// </summary>
        [NameInMap("PermissionVersion")]
        [Validation(Required=false)]
        public string PermissionVersion { get; set; }

    }

}

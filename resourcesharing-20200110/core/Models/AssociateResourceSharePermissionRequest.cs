// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class AssociateResourceSharePermissionRequest : TeaModel {
        [NameInMap("PermissionName")]
        [Validation(Required=false)]
        public string PermissionName { get; set; }

        [NameInMap("Replace")]
        [Validation(Required=false)]
        public bool? Replace { get; set; }

        [NameInMap("ResourceShareId")]
        [Validation(Required=false)]
        public string ResourceShareId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class GrantUserPermissionsShrinkRequest : TeaModel {
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public string PermissionsShrink { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

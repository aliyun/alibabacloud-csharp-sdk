// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ConfigureSecurityGroupPermissionsShrinkRequest : TeaModel {
        [NameInMap("AuthorizePermissions")]
        [Validation(Required=false)]
        public string AuthorizePermissionsShrink { get; set; }

        [NameInMap("RevokePermissions")]
        [Validation(Required=false)]
        public string RevokePermissionsShrink { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

    }

}

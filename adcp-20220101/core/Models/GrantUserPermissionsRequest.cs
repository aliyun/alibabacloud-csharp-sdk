// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class GrantUserPermissionsRequest : TeaModel {
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<GrantUserPermissionsRequestPermissions> Permissions { get; set; }
        public class GrantUserPermissionsRequestPermissions : TeaModel {
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

        }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

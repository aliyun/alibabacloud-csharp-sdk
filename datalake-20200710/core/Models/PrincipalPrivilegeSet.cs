// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class PrincipalPrivilegeSet : TeaModel {
        [NameInMap("GroupPrivileges")]
        [Validation(Required=false)]
        public Dictionary<string, List<PrivilegeGrantInfo>> GroupPrivileges { get; set; }

        [NameInMap("RolePrivileges")]
        [Validation(Required=false)]
        public Dictionary<string, List<PrivilegeGrantInfo>> RolePrivileges { get; set; }

        [NameInMap("UserPrivileges")]
        [Validation(Required=false)]
        public Dictionary<string, List<PrivilegeGrantInfo>> UserPrivileges { get; set; }

    }

}

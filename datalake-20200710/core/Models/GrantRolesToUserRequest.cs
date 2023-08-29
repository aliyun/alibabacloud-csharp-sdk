// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class GrantRolesToUserRequest : TeaModel {
        [NameInMap("RoleNames")]
        [Validation(Required=false)]
        public List<string> RoleNames { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public Principal User { get; set; }

    }

}

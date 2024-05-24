// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CheckServiceRoleResponseBody : TeaModel {
        [NameInMap("roles")]
        [Validation(Required=false)]
        public List<CheckServiceRoleResponseBodyRoles> Roles { get; set; }
        public class CheckServiceRoleResponseBodyRoles : TeaModel {
            [NameInMap("granted")]
            [Validation(Required=false)]
            public bool? Granted { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}

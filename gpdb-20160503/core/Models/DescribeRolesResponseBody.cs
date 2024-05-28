// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeRolesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RoleList")]
        [Validation(Required=false)]
        public DescribeRolesResponseBodyRoleList RoleList { get; set; }
        public class DescribeRolesResponseBodyRoleList : TeaModel {
            [NameInMap("Role")]
            [Validation(Required=false)]
            public List<string> Role { get; set; }

        }

    }

}

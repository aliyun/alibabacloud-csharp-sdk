// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeRolesResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The roles.
        /// </summary>
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

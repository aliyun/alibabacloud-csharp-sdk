// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeUsersWithPermissionsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to query the IDs of all RAM users or RAM roles to which an RBAC role is assigned. Valid values:
        /// 
        /// *   `SubUser`: Query the IDs of all RAM users to which an RBAC role is assigned.
        /// *   `RamRole`: Query the IDs of all RAM roles to which an RBAC role is assigned.
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}

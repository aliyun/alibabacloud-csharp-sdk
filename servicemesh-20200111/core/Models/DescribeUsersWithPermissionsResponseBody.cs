// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeUsersWithPermissionsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The IDs of the RAM users or RAM roles to which an RBAC role is assigned.
        /// </summary>
        [NameInMap("UIDs")]
        [Validation(Required=false)]
        public List<string> UIDs { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class UpdateRoleRequest : TeaModel {
        [NameInMap("RoleInput")]
        [Validation(Required=false)]
        public RoleInput RoleInput { get; set; }

        /// <summary>
        /// RoleName
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

    }

}
